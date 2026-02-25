// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UniformFroxelThickness
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public static class UniformFroxelThickness : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupFroxelDepthIndexConversionParams_Public_Static_Void_Single_Single_Single_byref_Vector4_byref_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_Single_Single_Single_0;

  static UniformFroxelThickness()
  {
    Il2CppClassPointerStore<UniformFroxelThickness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UniformFroxelThickness));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniformFroxelThickness>.NativeClassPtr);
    UniformFroxelThickness.NativeMethodInfoPtr_SetupFroxelDepthIndexConversionParams_Public_Static_Void_Single_Single_Single_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniformFroxelThickness>.NativeClassPtr, 100664248);
    UniformFroxelThickness.NativeMethodInfoPtr_Test_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniformFroxelThickness>.NativeClassPtr, 100664249);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935507, XrefRangeEnd = 935511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetupFroxelDepthIndexConversionParams(
    float near,
    float far,
    float totalSliceCount,
    out Vector4 index2DepthParams,
    out Vector4 depth2IndexParams)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &near;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &far;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &totalSliceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref index2DepthParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref depth2IndexParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UniformFroxelThickness.NativeMethodInfoPtr_SetupFroxelDepthIndexConversionParams_Public_Static_Void_Single_Single_Single_byref_Vector4_byref_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935511, XrefRangeEnd = 935544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Test(float near, float far, float totalSliceCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &near;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &far;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &totalSliceCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UniformFroxelThickness.NativeMethodInfoPtr_Test_Public_Static_Void_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public UniformFroxelThickness(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
