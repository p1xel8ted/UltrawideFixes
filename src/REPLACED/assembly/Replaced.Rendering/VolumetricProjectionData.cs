// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumetricProjectionData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VolumetricProjectionData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewPositionWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_depth2SliceIndexpParams;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_Matrix4x4_Vector3_Vector4_0;
  [FieldOffset(0)]
  public readonly Matrix4x4 projectionViewMatrix;
  [FieldOffset(64 /*0x40*/)]
  public readonly Vector3 viewPositionWs;
  [FieldOffset(76)]
  public readonly Vector4 depth2SliceIndexpParams;

  static VolumetricProjectionData()
  {
    Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumetricProjectionData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr);
    VolumetricProjectionData.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr, nameof (projectionViewMatrix));
    VolumetricProjectionData.NativeFieldInfoPtr_viewPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr, nameof (viewPositionWs));
    VolumetricProjectionData.NativeFieldInfoPtr_depth2SliceIndexpParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr, nameof (depth2SliceIndexpParams));
    VolumetricProjectionData.NativeMethodInfoPtr__ctor_Public_Void_byref_Matrix4x4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr, 100663515 /*0x060000DB*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925847, RefRangeEnd = 925848, XrefRangeStart = 925847, XrefRangeEnd = 925847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VolumetricProjectionData(
    [In] ref Matrix4x4 projectionViewMatrix,
    Vector3 viewPositionWs,
    Vector4 depth2SliceIndexpParams)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref projectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &viewPositionWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth2SliceIndexpParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricProjectionData.NativeMethodInfoPtr__ctor_Public_Void_byref_Matrix4x4_Vector3_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumetricProjectionData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
