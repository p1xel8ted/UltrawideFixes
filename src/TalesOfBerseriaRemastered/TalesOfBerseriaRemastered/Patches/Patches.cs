// Patches.cs - Native code patches for TLSampleViewerTO12.dll
// Originally authored by p1xel8ted (Harmony framerate/VSync prefixes)
// Native code patching by Claude (code cave architecture, signature scanning, all 3 native patches,
//   PE section parsing, UI width scaling, logo timing zeroing)

// ReSharper disable InconsistentNaming

namespace TalesOfBerseriaRemastered.Patches;

/// <summary>
/// Native code patches applied directly to TLSampleViewerTO12.dll (the game's C++ rendering DLL).
///
/// This game uses a custom native render pipeline — most rendering logic lives in native C++ code,
/// not managed IL2CPP. Standard Harmony patches on Unity types (Camera, Canvas, etc.) have no effect
/// on the native renderer. Instead, we patch the DLL's code and data segments in-memory at runtime.
///
/// Three native patches are applied:
///   1. Perspective aspect code cave — redirects the aspect ratio read for perspective cameras
///      to use the ultrawide value instead of the game's hardcoded 16:9.
///   2. UI coordinate width scaling — patches (1280, 720) float pairs in data sections to prevent
///      UI elements from stretching on ultrawide monitors.
///   3. Logo timing zeroing — zeros the fade/duration values in the startup logo data table so
///      the 3 publisher/middleware logos (Bandai Namco, CriWare, etc.) are skipped instantly.
///
/// All native patches use signature scanning for resilience against game updates — no hardcoded RVAs.
/// </summary>
[Harmony]
public static class Patches
{
    /// <summary>Ensures TryPatchNative runs only once, even if RenderManager.Render fires every frame.</summary>
    private static bool _nativePatchAttempted;

    /// <summary>Pointer to the VirtualAlloc'd code cave memory. Kept alive to prevent deallocation.</summary>
    private static IntPtr _codeCavePtr;

    #region P/Invoke — Windows API for native memory manipulation

    [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32", SetLastError = true)]
    private static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, uint flAllocationType, uint flProtect);

    [DllImport("kernel32", SetLastError = true)]
    private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

    [DllImport("kernel32", SetLastError = true)]
    private static extern bool FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, UIntPtr dwSize);

    [DllImport("kernel32")]
    private static extern IntPtr GetCurrentProcess();

    #endregion

    #region Constants — VirtualAlloc/VirtualProtect flags

    private const uint MEM_COMMIT = 0x1000;
    private const uint MEM_RESERVE = 0x2000;
    private const uint PAGE_EXECUTE_READWRITE = 0x40;
    private const uint PAGE_READWRITE = 0x04;

    #endregion

    #region Signatures — byte patterns for update-resilient scanning

    // Aspect patch signature: INT3 padding (function boundary) followed by two movss instructions.
    // The INT3 bytes (0xCC) anchor us to the start of the function, ensuring a unique match.
    //   CC CC CC CC           — INT3 padding (compiler inserts between functions for alignment)
    //   F3 0F 10 4A 14        — movss xmm1, [rdx+14h]  (reads aspect ratio from camera struct)
    //   F3 0F 10 41 14        — movss xmm0, [rcx+14h]  (reads aspect from another struct)
    // We patch the first movss (at offset 4) to jump to our code cave instead.
    private static readonly byte[] AspectPatchSig = [0xCC, 0xCC, 0xCC, 0xCC, 0xF3, 0x0F, 0x10, 0x4A, 0x14, 0xF3, 0x0F, 0x10, 0x41, 0x14];
    private const int SigPatchOffset = 4; // target instruction starts 4 bytes into the signature

    #endregion

    #region Logo timing constants

    // The native DLL stores logo display data in a table with 3 entries (one per logo screen).
    // Each entry is 24 bytes: [string_ptr:8][fade:4][duration:4][flag:8]
    // Default timing is {fade=30.0f, duration=180.0f} per logo — about 3 seconds at 60fps.
    // We scan for 3 consecutive 180.0f values at stride 24 (a unique pattern in the DLL)
    // and zero both fade and duration to make logos flash for ~1 frame then skip.
    private const int LogoEntryStride = 24;
    private const int LogoCount = 3;

    #endregion

    /// <summary>
    /// Reads the SizeOfImage field from the PE optional header.
    /// This tells us how much of the DLL's virtual address space is mapped into memory,
    /// giving us the safe upper bound for scanning.
    /// </summary>
    private static unsafe int GetImageSize(byte* dllBase)
    {
        // PE header offset is stored at DOS header + 0x3C
        var peOffset = *(int*)(dllBase + 0x3C);
        // SizeOfImage is at PE optional header + 0x50
        return *(int*)(dllBase + peOffset + 0x50);
    }

    /// <summary>
    /// Scans a memory region for a byte pattern. Returns the address of the first match,
    /// or IntPtr.Zero if not found. Logs a warning if multiple matches are found (indicates
    /// the signature needs extending for uniqueness).
    /// </summary>
    private static unsafe IntPtr ScanForPattern(byte* start, int length, byte[] pattern)
    {
        var result = IntPtr.Zero;
        var matchCount = 0;

        for (var i = 0; i <= length - pattern.Length; i++)
        {
            var match = !pattern.Where((t, j) => start[i + j] != t).Any();

            if (!match) continue;

            matchCount++;
            if (matchCount == 1)
            {
                result = (IntPtr)(start + i);
            }
            else
            {
                Plugin.Logger.LogWarning($"Pattern has multiple matches ({matchCount}) - signature may need extending");
            }
        }

        return result;
    }

    /// <summary>
    /// Strict UI width target scan: only searches .rdata and .data PE sections for (1280.0f, 720.0f)
    /// float pairs. This is the preferred approach as it avoids false positives in code sections.
    /// Parses the PE section table to identify data sections by name.
    /// </summary>
    private static unsafe List<long> CollectUiWidthTargetsStrict(byte* dllBase, int imageSize)
    {
        var targets = new List<long>();

        // Parse PE section table to find .rdata and .data sections
        var peOffset = *(int*)(dllBase + 0x3C);
        var sectionCount = *(ushort*)(dllBase + peOffset + 0x6);
        var optionalHeaderSize = *(ushort*)(dllBase + peOffset + 0x14);
        var sectionTable = dllBase + peOffset + 0x18 + optionalHeaderSize;

        for (var s = 0; s < sectionCount; s++)
        {
            var section = sectionTable + s * 40;

            // Read the 8-byte section name from IMAGE_SECTION_HEADER
            var nameBytes = new byte[8];
            for (var n = 0; n < 8; n++) nameBytes[n] = section[n];
            var sectionName = System.Text.Encoding.ASCII.GetString(nameBytes).TrimEnd('\0');

            // Only scan read-only data (.rdata) and read-write data (.data) sections
            if (sectionName != ".rdata" && sectionName != ".data") continue;

            var virtualSize = *(uint*)(section + 0x8);
            var virtualAddress = *(uint*)(section + 0xC);
            var scanLength = (int)Math.Min(virtualSize, (uint)Math.Max(0, imageSize - (int)virtualAddress));
            if (scanLength < 8) continue;

            // Scan for adjacent (1280.0f, 720.0f) float pairs at 4-byte alignment.
            // The native DLL stores UI coordinate space dimensions as consecutive floats:
            //   [1280.0f @ offset N][720.0f @ offset N+4]
            // We patch the 1280.0f to a scaled value matching the ultrawide aspect ratio.
            for (var i = 4; i < scanLength; i += 4)
            {
                var absolute = (int)virtualAddress + i;
                var prev = absolute - 4;
                if (Mathf.Approximately(*(float*)(dllBase + absolute), 720.0f) &&
                    Mathf.Approximately(*(float*)(dllBase + prev), 1280.0f))
                {
                    targets.Add(prev);
                }
            }
        }

        return targets.Distinct().OrderBy(v => v).ToList();
    }

    /// <summary>
    /// Broad UI width target scan: searches the entire DLL image for (1280.0f, 720.0f) pairs.
    /// Used as a fallback if the strict section-based scan finds no matches (e.g. if the game
    /// stores these values in an unexpected section). May have false positives in code sections.
    /// </summary>
    private static unsafe List<long> CollectUiWidthTargetsBroad(byte* dllBase, int imageSize)
    {
        var targets = new List<long>();
        for (var i = 4; i < imageSize; i += 4)
        {
            if (Mathf.Approximately(*(float*)(dllBase + i), 720.0f) &&
                Mathf.Approximately(*(float*)(dllBase + i - 4), 1280.0f))
            {
                targets.Add(i - 4L);
            }
        }

        return targets;
    }

    /// <summary>
    /// Patches the 1280.0f value at each target RVA to the scaled ultrawide width.
    /// Uses VirtualProtect to temporarily make the memory writable, then restores original protection.
    /// </summary>
    private static unsafe int PatchUiWidthTargets(byte* dllBase, float scaledWidth, IEnumerable<long> targets, List<long> patchedRvas)
    {
        var patched = 0;
        foreach (var rva in targets)
        {
            var pairAddr = (IntPtr)(dllBase + rva);
            if (!VirtualProtect(pairAddr, (UIntPtr)4, PAGE_READWRITE, out var oldProtect)) continue;
            *(float*)(dllBase + rva) = scaledWidth;
            VirtualProtect(pairAddr, (UIntPtr)4, oldProtect, out _);
            patched++;
            patchedRvas.Add(rva);
        }

        return patched;
    }

    /// <summary>Formats a list of RVA values as hex strings for log output.</summary>
    private static string ToRvaList(IEnumerable<long> values, int max = 8)
    {
        var list = values.Select(v => $"0x{v:X}").Take(max).ToList();
        return list.Count == 0 ? "none" : string.Join(", ", list);
    }

    /// <summary>
    /// Applies all native patches to TLSampleViewerTO12.dll. Called once on the first frame
    /// via the RenderManager.Render Harmony prefix (the earliest point where the native DLL
    /// is guaranteed to be loaded and mapped into memory).
    ///
    /// Patch 1 — Perspective aspect code cave:
    ///   Overwrites `movss xmm1,[rdx+14]` with a JMP to a code cave that checks the camera
    ///   type at [rdx+0x10]. If perspective (type == 1), loads the ultrawide aspect ratio;
    ///   otherwise executes the original instruction (preserving orthographic cameras).
    ///
    /// Patch 2 — UI coordinate width scaling:
    ///   Finds (1280.0f, 720.0f) float pairs in the DLL's data sections and replaces 1280.0f
    ///   with a scaled value: 1280 * (currentAspect / (16/9)). This prevents UI stretching
    ///   by expanding the UI coordinate space to match the wider screen.
    ///
    /// Patch 3 — Logo timing zeroing:
    ///   Finds the logo data table (3 entries at stride 24, each with a 180.0f duration) and
    ///   zeros both fade and duration values. Logos still flash for ~1 frame (the native state
    ///   machine processes LOGO state before transitioning) but are effectively instant.
    /// </summary>
    private static unsafe void TryPatchNative()
    {
        if (_nativePatchAttempted) return;

        try
        {
            // Wait for the native DLL to be loaded. On early frames it may not be mapped yet.
            var dllBase = GetModuleHandle("TLSampleViewerTO12");
            if (dllBase == IntPtr.Zero) return;

            var dp = (byte*)dllBase;
            var imageSize = GetImageSize(dp);
            Plugin.Logger.LogInfo($"Native patch start - module=TLSampleViewerTO12 base=0x{dllBase.ToInt64():X} imageSize=0x{imageSize:X}");

            // =====================================================================
            // Patch 1: Perspective aspect code cave (signature scan)
            // =====================================================================
            // The native renderer reads the camera's aspect ratio with:
            //   movss xmm1, [rdx+14h]  — loads aspect from the camera parameter struct
            // We redirect this to a code cave that conditionally overrides the value:
            //   - Perspective cameras (type == 1 at [rdx+10h]): use ultrawide aspect
            //   - All other cameras (ortho, etc.): keep the original value
            // This gives us Hor+ (horizontal plus) scaling for 3D scenes while leaving
            // 2D/UI cameras unaffected.

            var sigAddr = ScanForPattern(dp, imageSize, AspectPatchSig);
            if (sigAddr == IntPtr.Zero)
            {
                Plugin.Logger.LogError("Aspect patch signature not found in TLSampleViewerTO12.dll");
                _nativePatchAttempted = true;
                return;
            }

            var targetAddr = sigAddr + SigPatchOffset;
            var targetLong = targetAddr.ToInt64();
            Plugin.Logger.LogInfo($"Aspect patch target at RVA 0x{targetLong - (long)dllBase:X}");

            var target = (byte*)targetAddr;
            const int patchSize = 5; // movss xmm1,[rdx+14] is 5 bytes, same size as jmp rel32

            // Allocate executable memory for the code cave. Must be within +/-2GB of the
            // patch site for the rel32 JMP encoding to reach. We search outward in 64KB
            // increments in both directions until VirtualAlloc succeeds.
            var caveSize = (UIntPtr)32;
            _codeCavePtr = IntPtr.Zero;

            for (long offset = 0x10000; offset < 0x7FFF0000L; offset += 0x10000)
            {
                _codeCavePtr = VirtualAlloc((IntPtr)(targetLong + offset), caveSize, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
                if (_codeCavePtr != IntPtr.Zero) break;

                if (targetLong - offset > 0)
                {
                    _codeCavePtr = VirtualAlloc((IntPtr)(targetLong - offset), caveSize, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
                    if (_codeCavePtr != IntPtr.Zero) break;
                }
            }

            if (_codeCavePtr == IntPtr.Zero)
            {
                Plugin.Logger.LogError("Failed to allocate code cave memory");
                _nativePatchAttempted = true;
                return;
            }

            var caveLong = _codeCavePtr.ToInt64();
            var cave = (byte*)_codeCavePtr;
            var pos = 0;

            // Write the code cave — x86-64 machine code:
            //
            // The camera parameter struct has the camera type at offset 0x10:
            //   [rdx+0x10] == 1  →  perspective camera (needs ultrawide aspect)
            //   [rdx+0x10] != 1  →  orthographic or other (keep original aspect)
            //
            // Code cave layout (32 bytes):
            //   [0..3]   cmp dword ptr [rdx+10h], 1     — check camera type
            //   [4..5]   jne +8                          — if not perspective, skip to original
            //   [6..13]  movss xmm1, [rip+12]            — load ultrawide aspect constant
            //   [14..15] jmp +5                          — skip original instruction
            //   [16..20] movss xmm1, [rdx+14h]           — original instruction (for non-perspective)
            //   [21..25] jmp back                         — return to instruction after patch site
            //   [26..29] float: ultrawide aspect ratio    — constant data (e.g. 2.3889 for 3440x1440)
            if (cave != null)
            {
                // cmp dword ptr [rdx+10h], 1
                cave[pos++] = 0x83;
                cave[pos++] = 0x7A;
                cave[pos++] = 0x10;
                cave[pos++] = 0x01;
                // jne +8 (skip to original instruction at offset 16)
                cave[pos++] = 0x75;
                cave[pos++] = 0x08;
                // movss xmm1, [rip+12] — RIP-relative load of the float constant at offset 26
                cave[pos++] = 0xF3;
                cave[pos++] = 0x0F;
                cave[pos++] = 0x10;
                cave[pos++] = 0x0D;
                *(int*)(cave + pos) = 12; // displacement: 12 bytes from end of this instruction to float at offset 26
                pos += 4;
                // jmp +5 (skip over the original instruction to the jmp-back at offset 21)
                cave[pos++] = 0xEB;
                cave[pos++] = 0x05;
                // Original instruction: movss xmm1, [rdx+14h] (for non-perspective cameras)
                cave[pos++] = 0xF3;
                cave[pos++] = 0x0F;
                cave[pos++] = 0x10;
                cave[pos++] = 0x4A;
                cave[pos++] = 0x14;
                // jmp rel32 back to the instruction after the patch site
                cave[pos++] = 0xE9;
                *(int*)(cave + pos) = (int)((targetLong + patchSize) - (caveLong + pos + 4));
                pos += 4;
                // Float constant: the ultrawide aspect ratio (e.g. 3440/1440 = 2.3889)
                *(float*)(cave + pos) = Plugin.CurrentAspect;
            }

            // Overwrite the original instruction with a JMP rel32 to the code cave.
            // The original 5-byte `movss xmm1,[rdx+14]` is exactly the size of `jmp rel32`.
            if (!VirtualProtect(targetAddr, (UIntPtr)patchSize, PAGE_READWRITE, out var oldProtect))
            {
                Plugin.Logger.LogError($"VirtualProtect failed: error {Marshal.GetLastWin32Error()}");
                _nativePatchAttempted = true;
                return;
            }

            if (target != null)
            {
                target[0] = 0xE9; // JMP rel32 opcode
                *(int*)(target + 1) = (int)(caveLong - (targetLong + 5)); // relative displacement
            }

            VirtualProtect(targetAddr, (UIntPtr)patchSize, oldProtect, out _);

            // Flush instruction cache for both the patch site and the code cave to ensure
            // the CPU doesn't execute stale cached instructions.
            FlushInstructionCache(GetCurrentProcess(), targetAddr, (UIntPtr)patchSize);
            FlushInstructionCache(GetCurrentProcess(), _codeCavePtr, (UIntPtr)32);

            Plugin.Logger.LogInfo(
                $"Aspect code cave applied (perspective={Plugin.CurrentAspect:F4}, " +
                $"caveRVA=0x{caveLong - (long)dllBase:X}, returnRVA=0x{targetLong + patchSize - (long)dllBase:X})");

            // =====================================================================
            // Patch 2: Scale UI coordinate width in (1280, 720) data pairs
            // =====================================================================
            // The native renderer uses (1280, 720) as its internal UI coordinate space.
            // At 16:9 this maps 1:1, but on ultrawide monitors the UI stretches horizontally.
            // We scale 1280 proportionally: newWidth = 1280 * (currentAspect / (16/9))
            // e.g. at 21:9 (3440x1440): 1280 * (2.389 / 1.778) = ~1720
            // The 720 height stays the same — only the width expands.
            //
            // Strict scan checks only .rdata/.data PE sections to avoid false positives.
            // Falls back to a broad whole-image scan if strict finds nothing.

            var scaledWidth = 1280.0f * Plugin.CurrentAspect / (16f / 9f);
            int patchCount;
            var uiPatchedRvas = new List<long>();
            var strictTargets = CollectUiWidthTargetsStrict(dp, imageSize);
            if (strictTargets.Count > 0)
            {
                patchCount = PatchUiWidthTargets(dp, scaledWidth, strictTargets, uiPatchedRvas);
                Plugin.Logger.LogInfo(
                    $"UI width patched (strict): {patchCount} location(s), 1280 -> {scaledWidth:F1}, " +
                    $"RVA(s): {ToRvaList(uiPatchedRvas)}");
            }
            else
            {
                var broadTargets = CollectUiWidthTargetsBroad(dp, imageSize);
                patchCount = PatchUiWidthTargets(dp, scaledWidth, broadTargets, uiPatchedRvas);
                Plugin.Logger.LogWarning(
                    $"UI strict target scan found 0 matches; fallback broad patch used ({patchCount} location(s), " +
                    $"1280 -> {scaledWidth:F1}, RVA(s): {ToRvaList(uiPatchedRvas)})");
            }

            // =====================================================================
            // Patch 3: Zero logo display timings (data scan)
            // =====================================================================
            // The startup logo table stores 3 entries at stride 24 bytes:
            //   [string_ptr:8][fade:4][duration:4][flag:8]
            // Each logo defaults to {fade=30.0f, duration=180.0f} (about 3 seconds at 60fps).
            // We scan for 3 consecutive 180.0f values at stride 24 — this pattern is unique
            // in the DLL — then zero both fade and duration for each entry.
            // The logos still flash for ~1 frame because the native state machine processes
            // the LOGO state before checking timings, but they're effectively instant.

            var logoPatchCount = 0;
            var logoTableRva = -1L;
            var logoPatchedRvas = new List<long>();

            for (var i = 0; i < imageSize - LogoEntryStride * LogoCount; i += 4)
            {
                // Check for 3 consecutive 180.0f values at stride 24
                var allMatch = true;
                for (var l = 0; l < LogoCount; l++)
                {
                    var off = i + l * LogoEntryStride;
                    if (!Mathf.Approximately(*(float*)(dp + off), 180.0f))
                    {
                        allMatch = false;
                        break;
                    }
                }

                if (!allMatch) continue;
                logoTableRva = i;

                // Zero both fade (offset -4 relative to duration) and duration for each logo
                for (var l = 0; l < LogoCount; l++)
                {
                    var fadeAddr = (IntPtr)(dp + i + l * LogoEntryStride - 4);

                    if (VirtualProtect(fadeAddr, (UIntPtr)8, PAGE_READWRITE, out var lOld))
                    {
                        *(float*)(dp + i + l * LogoEntryStride - 4) = 0f; // fade = 0
                        *(float*)(dp + i + l * LogoEntryStride) = 0f;     // duration = 0
                        VirtualProtect(fadeAddr, (UIntPtr)8, lOld, out _);
                        logoPatchCount++;
                        logoPatchedRvas.Add(i + l * LogoEntryStride - 4L);
                    }
                }

                break; // only one logo table exists
            }

            if (logoPatchCount > 0)
            {
                Plugin.Logger.LogInfo(
                    $"Logo timings zeroed: {logoPatchCount} logo(s), tableRVA=0x{logoTableRva:X}, " +
                    $"fade/duration RVA(s): {ToRvaList(logoPatchedRvas, 12)}");
            }
            else
            {
                Plugin.Logger.LogWarning("Logo timing pattern not found");
            }

            Plugin.Logger.LogInfo(
                $"Native patch complete - aspect=ok uiPatched={patchCount} logoPatched={logoPatchCount}");

            _nativePatchAttempted = true;
        }
        catch (Exception ex)
        {
            Plugin.Logger.LogError($"Native patch failed: {ex}");
            _nativePatchAttempted = true;
        }
    }

    // =========================================================================
    // Harmony patches
    // =========================================================================

    /// <summary>
    /// Triggers native patching on the first frame.
    /// RenderManager.Render is the earliest managed callback where TLSampleViewerTO12.dll
    /// is guaranteed to be loaded. After the first call, TryPatchNative short-circuits
    /// via _nativePatchAttempted.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(RenderManager), nameof(RenderManager.Render))]
    public static void RenderManager_Render()
    {
        TryPatchNative();
    }

    /// <summary>
    /// Intercepts ALL calls to QualitySettings.vSyncCount setter from any managed code.
    /// Forces 0 (VSync off) and logs any attempt to enable VSync.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), "set_vSyncCount")]
    public static void QualitySettings_set_vSyncCount(ref int value)
    {
        if (value != 0)
        {
            Plugin.Logger.LogInfo($"vSyncCount setter intercepted: {value} -> 0");
            value = 0;
        }
    }
}
