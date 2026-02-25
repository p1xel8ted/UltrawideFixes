// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalStageFrameStats
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DecalStageFrameStats
{
  private static readonly System.IntPtr NativeFieldInfoPtr_totalDecalCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleDecalCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_decalDrawCallCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_totalMaskDecalCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleMaskDecalCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_maskDecalDrawCallCount;
  [FieldOffset(0)]
  public int totalDecalCount;
  [FieldOffset(4)]
  public int visibleDecalCount;
  [FieldOffset(8)]
  public int decalDrawCallCount;
  [FieldOffset(12)]
  public int totalMaskDecalCount;
  [FieldOffset(16 /*0x10*/)]
  public int visibleMaskDecalCount;
  [FieldOffset(20)]
  public int maskDecalDrawCallCount;

  static DecalStageFrameStats()
  {
    Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalStageFrameStats));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr);
    DecalStageFrameStats.NativeFieldInfoPtr_totalDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, nameof (totalDecalCount));
    DecalStageFrameStats.NativeFieldInfoPtr_visibleDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, nameof (visibleDecalCount));
    DecalStageFrameStats.NativeFieldInfoPtr_decalDrawCallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, nameof (decalDrawCallCount));
    DecalStageFrameStats.NativeFieldInfoPtr_totalMaskDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, nameof (totalMaskDecalCount));
    DecalStageFrameStats.NativeFieldInfoPtr_visibleMaskDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, nameof (visibleMaskDecalCount));
    DecalStageFrameStats.NativeFieldInfoPtr_maskDecalDrawCallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, nameof (maskDecalDrawCallCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalStageFrameStats>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
