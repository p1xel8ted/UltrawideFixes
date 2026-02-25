// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CameraScatteredLightIntegrationCBuffer
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CameraScatteredLightIntegrationCBuffer
{
  private static readonly System.IntPtr NativeFieldInfoPtr_voxelUvScaleOffset;
  [FieldOffset(0)]
  public Vector4 voxelUvScaleOffset;

  static CameraScatteredLightIntegrationCBuffer()
  {
    Il2CppClassPointerStore<CameraScatteredLightIntegrationCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CameraScatteredLightIntegrationCBuffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraScatteredLightIntegrationCBuffer>.NativeClassPtr);
    CameraScatteredLightIntegrationCBuffer.NativeFieldInfoPtr_voxelUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationCBuffer>.NativeClassPtr, nameof (voxelUvScaleOffset));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraScatteredLightIntegrationCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
