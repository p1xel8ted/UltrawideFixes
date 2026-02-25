// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CLLPackedLightData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CLLPackedLightData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_descriptor;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionVs;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionVs2;
  private static readonly System.IntPtr NativeFieldInfoPtr_radiusVsTanOuterHalf;
  [FieldOffset(0)]
  public uint descriptor;
  [FieldOffset(4)]
  public Vector3 positionVs;
  [FieldOffset(16 /*0x10*/)]
  public Vector3 positionVs2;
  [FieldOffset(28)]
  public uint radiusVsTanOuterHalf;

  static CLLPackedLightData()
  {
    Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CLLPackedLightData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr);
    CLLPackedLightData.NativeFieldInfoPtr_descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr, nameof (descriptor));
    CLLPackedLightData.NativeFieldInfoPtr_positionVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr, nameof (positionVs));
    CLLPackedLightData.NativeFieldInfoPtr_positionVs2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr, nameof (positionVs2));
    CLLPackedLightData.NativeFieldInfoPtr_radiusVsTanOuterHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr, nameof (radiusVsTanOuterHalf));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CLLPackedLightData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
