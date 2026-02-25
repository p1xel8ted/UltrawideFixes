// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.RenderingUtils
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public static class RenderingUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kCubemapViewWorldMatrices;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCubemapFaceDirections;
  private static readonly System.IntPtr NativeFieldInfoPtr_kYCoCgChromaBias;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRgb2YCoCgRed;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRgb2YCoCgGreen;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRgb2YCoCgBlue;
  private static readonly System.IntPtr NativeMethodInfoPtr_CubemapFaceDirWs_Public_Static_Vector3_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DispatchCompute_Public_Static_Void_CommandBuffer_ComputeShader_Int32_byref_Vector2Int_byref_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DispatchCompute_Public_Static_Void_CommandBuffer_ComputeShader_Int32_byref_Vector3Int_byref_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteAndReleaseCommandBuffer_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteAndReleaseCommandBufferAsync_Public_Static_GraphicsFence_byref_ScriptableRenderContext_CommandBuffer_SynchronisationStageFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeGraphicsFence_Public_Static_GraphicsFence_CommandBuffer_SynchronisationStageFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFragPosition2CubemapDirWs_Public_Static_Matrix4x4_byref_Vector2_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPointLightViewMatrix_Public_Static_Matrix4x4_Int32_VisibleLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeJitteredProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_Vector2_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeDepthProjectionParams_Public_Static_Vector4_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMsaaSampleCount_Private_Static_Int32_MsaaMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexture_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector2Int_MsaaMode_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexture_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector3Int_MsaaMode_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rgb2YCoCg_Public_Static_Vector3_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeDrawingSettings_Public_Static_DrawingSettings_Camera_ShaderTagId_PerObjectData_SortingCriteria_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeDrawingSettings_Public_Static_DrawingSettings_Camera_Il2CppStructArray_1_ShaderTagId_PerObjectData_SortingCriteria_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeColorThresholdCurve_Public_Static_Vector4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexelSize_Public_Static_Vector4_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsSingleChannelRedFormat_Public_Static_Boolean_TextureFormat_0;

  static RenderingUtils()
  {
    Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (RenderingUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr);
    RenderingUtils.NativeFieldInfoPtr_kCubemapViewWorldMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, nameof (kCubemapViewWorldMatrices));
    RenderingUtils.NativeFieldInfoPtr_kCubemapFaceDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, nameof (kCubemapFaceDirections));
    RenderingUtils.NativeFieldInfoPtr_kYCoCgChromaBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, nameof (kYCoCgChromaBias));
    RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, nameof (kRgb2YCoCgRed));
    RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, nameof (kRgb2YCoCgGreen));
    RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, nameof (kRgb2YCoCgBlue));
    RenderingUtils.NativeMethodInfoPtr_CubemapFaceDirWs_Public_Static_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663332 /*0x06000024*/);
    RenderingUtils.NativeMethodInfoPtr_DispatchCompute_Public_Static_Void_CommandBuffer_ComputeShader_Int32_byref_Vector2Int_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663333 /*0x06000025*/);
    RenderingUtils.NativeMethodInfoPtr_DispatchCompute_Public_Static_Void_CommandBuffer_ComputeShader_Int32_byref_Vector3Int_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663334 /*0x06000026*/);
    RenderingUtils.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663335 /*0x06000027*/);
    RenderingUtils.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663336 /*0x06000028*/);
    RenderingUtils.NativeMethodInfoPtr_ExecuteAndReleaseCommandBuffer_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663337 /*0x06000029*/);
    RenderingUtils.NativeMethodInfoPtr_ExecuteAndReleaseCommandBufferAsync_Public_Static_GraphicsFence_byref_ScriptableRenderContext_CommandBuffer_SynchronisationStageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663338 /*0x0600002A*/);
    RenderingUtils.NativeMethodInfoPtr_MakeGraphicsFence_Public_Static_GraphicsFence_CommandBuffer_SynchronisationStageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663339 /*0x0600002B*/);
    RenderingUtils.NativeMethodInfoPtr_GetFragPosition2CubemapDirWs_Public_Static_Matrix4x4_byref_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663340 /*0x0600002C*/);
    RenderingUtils.NativeMethodInfoPtr_GetPointLightViewMatrix_Public_Static_Matrix4x4_Int32_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663341 /*0x0600002D*/);
    RenderingUtils.NativeMethodInfoPtr_MakeJitteredProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663342 /*0x0600002E*/);
    RenderingUtils.NativeMethodInfoPtr_MakeDepthProjectionParams_Public_Static_Vector4_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663343 /*0x0600002F*/);
    RenderingUtils.NativeMethodInfoPtr_GetMsaaSampleCount_Private_Static_Int32_MsaaMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663344 /*0x06000030*/);
    RenderingUtils.NativeMethodInfoPtr_MakeTexture_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector2Int_MsaaMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663345 /*0x06000031*/);
    RenderingUtils.NativeMethodInfoPtr_MakeTexture_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector3Int_MsaaMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663346 /*0x06000032*/);
    RenderingUtils.NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663347 /*0x06000033*/);
    RenderingUtils.NativeMethodInfoPtr_Rgb2YCoCg_Public_Static_Vector3_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663348 /*0x06000034*/);
    RenderingUtils.NativeMethodInfoPtr_MakeDrawingSettings_Public_Static_DrawingSettings_Camera_ShaderTagId_PerObjectData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663349 /*0x06000035*/);
    RenderingUtils.NativeMethodInfoPtr_MakeDrawingSettings_Public_Static_DrawingSettings_Camera_Il2CppStructArray_1_ShaderTagId_PerObjectData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663350 /*0x06000036*/);
    RenderingUtils.NativeMethodInfoPtr_MakeColorThresholdCurve_Public_Static_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663351 /*0x06000037*/);
    RenderingUtils.NativeMethodInfoPtr_MakeTexelSize_Public_Static_Vector4_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663352 /*0x06000038*/);
    RenderingUtils.NativeMethodInfoPtr_IsSingleChannelRedFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100663353 /*0x06000039*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924142, RefRangeEnd = 924143, XrefRangeStart = 924138, XrefRangeEnd = 924142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 CubemapFaceDirWs(int face)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &face
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_CubemapFaceDirWs_Public_Static_Vector3_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 924147, RefRangeEnd = 924171, XrefRangeStart = 924143, XrefRangeEnd = 924147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DispatchCompute(
    CommandBuffer cmd,
    ComputeShader cs,
    int kernel,
    [In] ref Vector2Int totalSize,
    [In] ref Vector2Int groupSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref groupSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_DispatchCompute_Public_Static_Void_CommandBuffer_ComputeShader_Int32_byref_Vector2Int_byref_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 924172, RefRangeEnd = 924176, XrefRangeStart = 924171, XrefRangeEnd = 924172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DispatchCompute(
    CommandBuffer cmd,
    ComputeShader cs,
    int kernel,
    [In] ref Vector3Int totalSize,
    [In] ref Vector3Int groupSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref groupSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_DispatchCompute_Public_Static_Void_CommandBuffer_ComputeShader_Int32_byref_Vector3Int_byref_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 924181, RefRangeEnd = 924224, XrefRangeStart = 924176, XrefRangeEnd = 924181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteCommandBuffer([In] ref ScriptableRenderContext ctx, CommandBuffer cmd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924230, RefRangeEnd = 924231, XrefRangeStart = 924224, XrefRangeEnd = 924230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteCommandBufferAsync(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer asyncCmd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asyncCmd);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 924244, RefRangeEnd = 924271, XrefRangeStart = 924231, XrefRangeEnd = 924244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteAndReleaseCommandBuffer(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ExecuteAndReleaseCommandBuffer_Public_Static_Void_byref_ScriptableRenderContext_CommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924284, RefRangeEnd = 924285, XrefRangeStart = 924271, XrefRangeEnd = 924284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFence ExecuteAndReleaseCommandBufferAsync(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SynchronisationStageFlags syncFlags = SynchronisationStageFlags.AllGPUOperations)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &syncFlags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ExecuteAndReleaseCommandBufferAsync_Public_Static_GraphicsFence_byref_ScriptableRenderContext_CommandBuffer_SynchronisationStageFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFence*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924286, RefRangeEnd = 924287, XrefRangeStart = 924285, XrefRangeEnd = 924286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFence MakeGraphicsFence(
    CommandBuffer cmd,
    SynchronisationStageFlags statgeFlags = SynchronisationStageFlags.AllGPUOperations)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statgeFlags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeGraphicsFence_Public_Static_GraphicsFence_CommandBuffer_SynchronisationStageFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFence*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924299, RefRangeEnd = 924300, XrefRangeStart = 924287, XrefRangeEnd = 924299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 GetFragPosition2CubemapDirWs(
    [In] ref Vector2 cubemapSizeRcp,
    int cubemapFaceIndex,
    float rotationOyDegrees)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref cubemapSizeRcp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapFaceIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationOyDegrees;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetFragPosition2CubemapDirWs_Public_Static_Matrix4x4_byref_Vector2_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924311, RefRangeEnd = 924312, XrefRangeStart = 924300, XrefRangeEnd = 924311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 GetPointLightViewMatrix(int face, VisibleLight vl)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vl;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetPointLightViewMatrix_Public_Static_Matrix4x4_Int32_VisibleLight_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924315, RefRangeEnd = 924316, XrefRangeStart = 924312, XrefRangeEnd = 924315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 MakeJitteredProjectionMatrix(
    Matrix4x4 projMatrix,
    bool taaIsOn,
    Vector2 subpixelOffset,
    bool flipProjectionHorizontally)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &projMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &taaIsOn;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &subpixelOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flipProjectionHorizontally;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeJitteredProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_Vector2_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924316, XrefRangeEnd = 924320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 MakeDepthProjectionParams(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeDepthProjectionParams_Public_Static_Vector4_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int GetMsaaSampleCount(MsaaMode msaaMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &msaaMode
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetMsaaSampleCount_Private_Static_Int32_MsaaMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 924339, RefRangeEnd = 924354, XrefRangeStart = 924320, XrefRangeEnd = 924339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexture(
    string label,
    [In] ref RenderTextureDescriptor descPrototype,
    [In] ref Vector2Int size,
    MsaaMode msaaMode,
    bool isTransient)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref descPrototype;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &msaaMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isTransient;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeTexture_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector2Int_MsaaMode_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924354, XrefRangeEnd = 924373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexture(
    string label,
    [In] ref RenderTextureDescriptor descPrototype,
    [In] ref Vector3Int size3D,
    MsaaMode msaaMode,
    bool isTransient)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref descPrototype;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref size3D;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &msaaMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isTransient;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeTexture_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector3Int_MsaaMode_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  public static unsafe float Luminance([In] ref Vector4 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_Luminance_Public_Static_Single_byref_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924373, XrefRangeEnd = 924377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Rgb2YCoCg([In] ref Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref color
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_Rgb2YCoCg_Public_Static_Vector3_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924377, XrefRangeEnd = 924389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DrawingSettings MakeDrawingSettings(
    Camera camera,
    ShaderTagId shaderPass,
    PerObjectData perObjectDataFlags,
    SortingCriteria sortingCriteria)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shaderPass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &perObjectDataFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeDrawingSettings_Public_Static_DrawingSettings_Camera_ShaderTagId_PerObjectData_SortingCriteria_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DrawingSettings*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924389, XrefRangeEnd = 924405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DrawingSettings MakeDrawingSettings(
    Camera camera,
    Il2CppStructArray<ShaderTagId> shaderPassArray,
    PerObjectData perObjectDataFlags,
    SortingCriteria sortingCriteria)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shaderPassArray);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &perObjectDataFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeDrawingSettings_Public_Static_DrawingSettings_Camera_Il2CppStructArray_1_ShaderTagId_PerObjectData_SortingCriteria_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DrawingSettings*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 924406, RefRangeEnd = 924409, XrefRangeStart = 924405, XrefRangeEnd = 924406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 MakeColorThresholdCurve(float threshold)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &threshold
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeColorThresholdCurve_Public_Static_Vector4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 924413, RefRangeEnd = 924417, XrefRangeStart = 924409, XrefRangeEnd = 924413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 MakeTexelSize(Texture texture)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MakeTexelSize_Public_Static_Vector4_Texture_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsSingleChannelRedFormat(TextureFormat fmt)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fmt
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_IsSingleChannelRedFormat_Public_Static_Boolean_TextureFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public RenderingUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStructArray<Matrix4x4> kCubemapViewWorldMatrices
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_kCubemapViewWorldMatrices, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<Matrix4x4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_kCubemapViewWorldMatrices, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<Vector3> kCubemapFaceDirections
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_kCubemapFaceDirections, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_kCubemapFaceDirections, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float kYCoCgChromaBias
  {
    get
    {
      float kYcoCgChromaBias;
      IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_kYCoCgChromaBias, (void*) &kYcoCgChromaBias);
      return kYcoCgChromaBias;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_kYCoCgChromaBias, (void*) &value);
    }
  }

  public static unsafe Vector3 kRgb2YCoCgRed
  {
    get
    {
      Vector3 kRgb2YcoCgRed;
      IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgRed, (void*) &kRgb2YcoCgRed);
      return kRgb2YcoCgRed;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgRed, (void*) &value);
    }
  }

  public static unsafe Vector3 kRgb2YCoCgGreen
  {
    get
    {
      Vector3 kRgb2YcoCgGreen;
      IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgGreen, (void*) &kRgb2YcoCgGreen);
      return kRgb2YcoCgGreen;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgGreen, (void*) &value);
    }
  }

  public static unsafe Vector3 kRgb2YCoCgBlue
  {
    get
    {
      Vector3 kRgb2YcoCgBlue;
      IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgBlue, (void*) &kRgb2YcoCgBlue);
      return kRgb2YcoCgBlue;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_kRgb2YCoCgBlue, (void*) &value);
    }
  }
}
