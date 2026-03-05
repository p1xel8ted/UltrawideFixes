// Patches.cs - Native code patches for TLSampleViewerTO12.dll

// ReSharper disable InconsistentNaming

namespace TalesOfBerseriaRemastered.Patches;

[Harmony]
public static class Patches
{
    private static bool _nativePatchAttempted;
    private static IntPtr _codeCavePtr;

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

    private const uint MEM_COMMIT = 0x1000;
    private const uint MEM_RESERVE = 0x2000;
    private const uint PAGE_EXECUTE_READWRITE = 0x40;
    private const uint PAGE_READWRITE = 0x04;

    private static readonly byte[] AspectPatchSig =
        [0xCC, 0xCC, 0xCC, 0xCC, 0xF3, 0x0F, 0x10, 0x4A, 0x14, 0xF3, 0x0F, 0x10, 0x41, 0x14];

    private const int SigPatchOffset = 4;
    private const int LogoEntryStride = 24;
    private const int LogoCount = 3;

    private static unsafe int GetImageSize(byte* dllBase)
    {
        var peOffset = *(int*)(dllBase + 0x3C);
        return *(int*)(dllBase + peOffset + 0x50);
    }

    private static unsafe IntPtr ScanForPattern(byte* start, int length, byte[] pattern)
    {
        var result = IntPtr.Zero;
        var matchCount = 0;

        for (var i = 0; i <= length - pattern.Length; i++)
        {
            var match = true;
            for (var j = 0; j < pattern.Length; j++)
            {
                if (start[i + j] == pattern[j]) continue;
                match = false;
                break;
            }

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

    private static unsafe List<long> CollectUiWidthTargetsStrict(byte* dllBase, int imageSize)
    {
        var targets = new List<long>();

        var peOffset = *(int*)(dllBase + 0x3C);
        var sectionCount = *(ushort*)(dllBase + peOffset + 0x6);
        var optionalHeaderSize = *(ushort*)(dllBase + peOffset + 0x14);
        var sectionTable = dllBase + peOffset + 0x18 + optionalHeaderSize;

        for (var s = 0; s < sectionCount; s++)
        {
            var section = sectionTable + s * 40;

            var nameBytes = new byte[8];
            for (var n = 0; n < 8; n++) nameBytes[n] = section[n];
            var sectionName = System.Text.Encoding.ASCII.GetString(nameBytes).TrimEnd('\0');
            if (sectionName != ".rdata" && sectionName != ".data") continue;

            var virtualSize = *(uint*)(section + 0x8);
            var virtualAddress = *(uint*)(section + 0xC);
            var scanLength = (int)Math.Min(virtualSize, (uint)Math.Max(0, imageSize - (int)virtualAddress));
            if (scanLength < 8) continue;

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

    private static string ToRvaList(IEnumerable<long> values, int max = 8)
    {
        var list = values.Select(v => $"0x{v:X}").Take(max).ToList();
        return list.Count == 0 ? "none" : string.Join(", ", list);
    }

    private static unsafe void TryPatchNative()
    {
        if (_nativePatchAttempted) return;

        try
        {
            var dllBase = GetModuleHandle("TLSampleViewerTO12");
            if (dllBase == IntPtr.Zero) return;

            var dp = (byte*)dllBase;
            var imageSize = GetImageSize(dp);
            Plugin.Logger.LogInfo($"Native patch start - module=TLSampleViewerTO12 base=0x{dllBase.ToInt64():X} imageSize=0x{imageSize:X}");

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
            const int patchSize = 5;

            var caveSize = (UIntPtr)32;
            _codeCavePtr = IntPtr.Zero;

            for (long offset = 0x10000; offset < 0x7FFF0000L; offset += 0x10000)
            {
                _codeCavePtr = VirtualAlloc((IntPtr)(targetLong + offset), caveSize, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
                if (_codeCavePtr != IntPtr.Zero) break;

                if (targetLong - offset <= 0) continue;

                _codeCavePtr = VirtualAlloc((IntPtr)(targetLong - offset), caveSize, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
                if (_codeCavePtr != IntPtr.Zero) break;
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

            cave[pos++] = 0x83;
            cave[pos++] = 0x7A;
            cave[pos++] = 0x10;
            cave[pos++] = 0x01;
            cave[pos++] = 0x75;
            cave[pos++] = 0x08;
            cave[pos++] = 0xF3;
            cave[pos++] = 0x0F;
            cave[pos++] = 0x10;
            cave[pos++] = 0x0D;
            *(int*)(cave + pos) = 12;
            pos += 4;
            cave[pos++] = 0xEB;
            cave[pos++] = 0x05;
            cave[pos++] = 0xF3;
            cave[pos++] = 0x0F;
            cave[pos++] = 0x10;
            cave[pos++] = 0x4A;
            cave[pos++] = 0x14;
            cave[pos++] = 0xE9;
            *(int*)(cave + pos) = (int)((targetLong + patchSize) - (caveLong + pos + 4));
            pos += 4;
            *(float*)(cave + pos) = Plugin.CurrentAspect;

            if (!VirtualProtect(targetAddr, (UIntPtr)patchSize, PAGE_READWRITE, out var oldProtect))
            {
                Plugin.Logger.LogError($"VirtualProtect failed: error {Marshal.GetLastWin32Error()}");
                _nativePatchAttempted = true;
                return;
            }

            target[0] = 0xE9;
            *(int*)(target + 1) = (int)(caveLong - (targetLong + 5));
            VirtualProtect(targetAddr, (UIntPtr)patchSize, oldProtect, out _);

            FlushInstructionCache(GetCurrentProcess(), targetAddr, (UIntPtr)patchSize);
            FlushInstructionCache(GetCurrentProcess(), _codeCavePtr, (UIntPtr)32);

            Plugin.Logger.LogInfo(
                $"Aspect code cave applied (perspective={Plugin.CurrentAspect:F4}, caveRVA=0x{caveLong - (long)dllBase:X}, returnRVA=0x{targetLong + patchSize - (long)dllBase:X})");

            var scaledWidth = 1280.0f * Plugin.CurrentAspect / (16f / 9f);
            int patchCount;
            var uiPatchedRvas = new List<long>();
            var strictTargets = CollectUiWidthTargetsStrict(dp, imageSize);
            if (strictTargets.Count > 0)
            {
                patchCount = PatchUiWidthTargets(dp, scaledWidth, strictTargets, uiPatchedRvas);
                Plugin.Logger.LogInfo(
                    $"UI width patched (strict): {patchCount} location(s), 1280 -> {scaledWidth:F1}, RVA(s): {ToRvaList(uiPatchedRvas)}");
            }
            else
            {
                var broadTargets = CollectUiWidthTargetsBroad(dp, imageSize);
                patchCount = PatchUiWidthTargets(dp, scaledWidth, broadTargets, uiPatchedRvas);
                Plugin.Logger.LogWarning(
                    $"UI strict target scan found 0 matches; fallback broad patch used ({patchCount} location(s), 1280 -> {scaledWidth:F1}, RVA(s): {ToRvaList(uiPatchedRvas)})");
            }

            var logoPatchCount = 0;
            var logoTableRva = -1L;
            var logoPatchedRvas = new List<long>();

            for (var i = 0; i < imageSize - LogoEntryStride * LogoCount; i += 4)
            {
                var allMatch = true;
                for (var l = 0; l < LogoCount; l++)
                {
                    var off = i + l * LogoEntryStride;
                    if (Mathf.Approximately(*(float*)(dp + off), 180.0f)) continue;
                    allMatch = false;
                    break;
                }

                if (!allMatch) continue;
                logoTableRva = i;

                for (var l = 0; l < LogoCount; l++)
                {
                    var fadeAddr = (IntPtr)(dp + i + l * LogoEntryStride - 4);
                    if (!VirtualProtect(fadeAddr, (UIntPtr)8, PAGE_READWRITE, out var lOld)) continue;
                    *(float*)(dp + i + l * LogoEntryStride - 4) = 0f;
                    *(float*)(dp + i + l * LogoEntryStride) = 0f;
                    VirtualProtect(fadeAddr, (UIntPtr)8, lOld, out _);
                    logoPatchCount++;
                    logoPatchedRvas.Add(i + l * LogoEntryStride - 4L);
                }

                break;
            }

            if (logoPatchCount > 0)
            {
                Plugin.Logger.LogInfo(
                    $"Logo timings zeroed: {logoPatchCount} logo(s), tableRVA=0x{logoTableRva:X}, fade/duration RVA(s): {ToRvaList(logoPatchedRvas, 12)}");
            }
            else
            {
                Plugin.Logger.LogWarning("Logo timing pattern not found");
            }

            Plugin.Logger.LogInfo($"Native patch complete - aspect=ok uiPatched={patchCount} logoPatched={logoPatchCount}");
            _nativePatchAttempted = true;
        }
        catch (Exception ex)
        {
            Plugin.Logger.LogError($"Native patch failed: {ex}");
            _nativePatchAttempted = true;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RenderManager), nameof(RenderManager.Render))]
    public static void RenderManager_Render()
    {
        TryPatchNative();
    }
}

