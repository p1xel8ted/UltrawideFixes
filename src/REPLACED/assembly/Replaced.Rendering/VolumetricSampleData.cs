// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumetricSampleData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VolumetricSampleData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraUpWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitDepthPixelSizeWs;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_Int32_0;
  [FieldOffset(0)]
  public readonly Vector3 cameraUpWs;
  [FieldOffset(12)]
  public readonly float unitDepthPixelSizeWs;

  static VolumetricSampleData()
  {
    Il2CppClassPointerStore<VolumetricSampleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumetricSampleData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricSampleData>.NativeClassPtr);
    VolumetricSampleData.NativeFieldInfoPtr_cameraUpWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricSampleData>.NativeClassPtr, nameof (cameraUpWs));
    VolumetricSampleData.NativeFieldInfoPtr_unitDepthPixelSizeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricSampleData>.NativeClassPtr, nameof (unitDepthPixelSizeWs));
    VolumetricSampleData.NativeMethodInfoPtr__ctor_Public_Void_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricSampleData>.NativeClassPtr, 100664254);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935624, XrefRangeEnd = 935628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VolumetricSampleData(Camera camera, int renderTargetSizeY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderTargetSizeY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricSampleData.NativeMethodInfoPtr__ctor_Public_Void_Camera_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumetricSampleData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
