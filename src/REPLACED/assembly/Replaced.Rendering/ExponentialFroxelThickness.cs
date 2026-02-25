// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ExponentialFroxelThickness
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public static class ExponentialFroxelThickness : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SolveForScaleOffset_Public_Static_Void_Single_Single_Single_Single_byref_Single_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupFroxelDepthIndexConversionParams_Public_Static_Void_Single_Single_Single_Single_byref_Vector4_byref_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTestReport_Public_Static_String_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_Single_Single_Single_Single_0;

  static ExponentialFroxelThickness()
  {
    Il2CppClassPointerStore<ExponentialFroxelThickness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ExponentialFroxelThickness));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExponentialFroxelThickness>.NativeClassPtr);
    ExponentialFroxelThickness.NativeMethodInfoPtr_SolveForScaleOffset_Public_Static_Void_Single_Single_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialFroxelThickness>.NativeClassPtr, 100664250);
    ExponentialFroxelThickness.NativeMethodInfoPtr_SetupFroxelDepthIndexConversionParams_Public_Static_Void_Single_Single_Single_Single_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialFroxelThickness>.NativeClassPtr, 100664251);
    ExponentialFroxelThickness.NativeMethodInfoPtr_GenerateTestReport_Public_Static_String_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialFroxelThickness>.NativeClassPtr, 100664252);
    ExponentialFroxelThickness.NativeMethodInfoPtr_Test_Public_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialFroxelThickness>.NativeClassPtr, 100664253);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935544, XrefRangeEnd = 935548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SolveForScaleOffset(
    float near,
    float far,
    float totalSliceCount,
    float globalScale,
    out float outScale,
    out float outOffset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &near;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &far;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &totalSliceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &globalScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref outOffset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExponentialFroxelThickness.NativeMethodInfoPtr_SolveForScaleOffset_Public_Static_Void_Single_Single_Single_Single_byref_Single_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 935558, RefRangeEnd = 935560, XrefRangeStart = 935548, XrefRangeEnd = 935558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetupFroxelDepthIndexConversionParams(
    float near,
    float far,
    float totalSliceCount,
    float globalScale,
    out Vector4 index2DepthParams,
    out Vector4 depth2IndexParams)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &near;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &far;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &totalSliceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &globalScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref index2DepthParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref depth2IndexParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExponentialFroxelThickness.NativeMethodInfoPtr_SetupFroxelDepthIndexConversionParams_Public_Static_Void_Single_Single_Single_Single_byref_Vector4_byref_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935618, RefRangeEnd = 935619, XrefRangeStart = 935560, XrefRangeEnd = 935618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GenerateTestReport(
    float near,
    float far,
    float totalSliceCount,
    float globalScale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &near;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &far;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &totalSliceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &globalScale;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExponentialFroxelThickness.NativeMethodInfoPtr_GenerateTestReport_Public_Static_String_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935619, XrefRangeEnd = 935624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Test(float near, float far, float totalSliceCount, float globalScale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &near;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &far;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &totalSliceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &globalScale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExponentialFroxelThickness.NativeMethodInfoPtr_Test_Public_Static_Void_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ExponentialFroxelThickness(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
