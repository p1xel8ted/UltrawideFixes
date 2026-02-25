// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PunctualLightGlobalShadowData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct PunctualLightGlobalShadowData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset0;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset1;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric0;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric1;
  [FieldOffset(0)]
  public Vector4 uvOffset0;
  [FieldOffset(16 /*0x10*/)]
  public Vector4 uvOffset1;
  [FieldOffset(32 /*0x20*/)]
  public Vector4 uvOffsetVolumetric0;
  [FieldOffset(48 /*0x30*/)]
  public Vector4 uvOffsetVolumetric1;

  static PunctualLightGlobalShadowData()
  {
    Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PunctualLightGlobalShadowData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr);
    PunctualLightGlobalShadowData.NativeFieldInfoPtr_uvOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr, nameof (uvOffset0));
    PunctualLightGlobalShadowData.NativeFieldInfoPtr_uvOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr, nameof (uvOffset1));
    PunctualLightGlobalShadowData.NativeFieldInfoPtr_uvOffsetVolumetric0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr, nameof (uvOffsetVolumetric0));
    PunctualLightGlobalShadowData.NativeFieldInfoPtr_uvOffsetVolumetric1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr, nameof (uvOffsetVolumetric1));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PunctualLightGlobalShadowData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
