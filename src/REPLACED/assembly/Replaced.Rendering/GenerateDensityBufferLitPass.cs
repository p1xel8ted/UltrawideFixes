// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GenerateDensityBufferLitPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class GenerateDensityBufferLitPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kBoxCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kXyOffsetCount1D;
  private static readonly System.IntPtr NativeFieldInfoPtr_kXySampleCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDepthSampleCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kThreadGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidVolumeDensityGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidVolumeNoiseIsOnGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidVolumeNoiseGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidVolumeMaterialGpuList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTex3DNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTex3DCurlNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDensityBufferLit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDensityBufferLitHistory;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferPhase0;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferPhase1;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelDoTaa;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelWithoutTaa;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferVolumeDensityGpu;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeNoiseIsOnGpuBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeNoiseGpuBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__bufferVolumeMaterialGpu;
  private static readonly System.IntPtr NativeFieldInfoPtr__tex3DNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr__tex3DCurlNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr__xyOffsets;
  private static readonly System.IntPtr NativeFieldInfoPtr__globalRandomSeed;
  private static readonly System.IntPtr NativeFieldInfoPtr__xySampleOffsetIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr__zOffsets;
  private static readonly System.IntPtr NativeFieldInfoPtr__depthSampleOffsetIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture3D_Texture3D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_byref_MediumCullingResult_byref_VolumetricSampleData_RenderTextureResource_RenderTextureResource_byref_VolumetricProjectionData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBufferPhase0_Private_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_byref_MediumCullingResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBufferPhase1_Private_Void_CommandBuffer_Vector3Int_byref_VolumetricSampleData_byref_VolumetricProjectionData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupBuffers_Private_Void_CommandBuffer_byref_MediumCullingResult_Int32_0;

  static GenerateDensityBufferLitPass()
  {
    Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GenerateDensityBufferLitPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr);
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kBoxCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kBoxCountLimit));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kXyOffsetCount1D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kXyOffsetCount1D));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kXySampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kXySampleCount));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kDepthSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kDepthSampleCount));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kThreadGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kThreadGroupSize));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeDensityGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidVolumeDensityGpuList));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeNoiseIsOnGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidVolumeNoiseIsOnGpuList));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeNoiseGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidVolumeNoiseGpuList));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeMaterialGpuList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidVolumeMaterialGpuList));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTex3DNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidTex3DNoise));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTex3DCurlNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidTex3DCurlNoise));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTexDensityBufferLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidTexDensityBufferLit));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTexDensityBufferLitHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (kSidTexDensityBufferLitHistory));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__cbufferPhase0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_cbufferPhase0));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__cbufferPhase1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_cbufferPhase1));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_compute));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__kernelDoTaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_kernelDoTaa));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__kernelWithoutTaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_kernelWithoutTaa));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__bufferVolumeDensityGpu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_bufferVolumeDensityGpu));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__volumeNoiseIsOnGpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_volumeNoiseIsOnGpuBuffer));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__volumeNoiseGpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_volumeNoiseGpuBuffer));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__bufferVolumeMaterialGpu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_bufferVolumeMaterialGpu));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__tex3DNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_tex3DNoise));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__tex3DCurlNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_tex3DCurlNoise));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__xyOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_xyOffsets));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__globalRandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_globalRandomSeed));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__xySampleOffsetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_xySampleOffsetIndex));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__zOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_zOffsets));
    GenerateDensityBufferLitPass.NativeFieldInfoPtr__depthSampleOffsetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (_depthSampleOffsetIndex));
    GenerateDensityBufferLitPass.NativeMethodInfoPtr_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664255);
    GenerateDensityBufferLitPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture3D_Texture3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664256 /*0x060003C0*/);
    GenerateDensityBufferLitPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_byref_MediumCullingResult_byref_VolumetricSampleData_RenderTextureResource_RenderTextureResource_byref_VolumetricProjectionData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664257);
    GenerateDensityBufferLitPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664258);
    GenerateDensityBufferLitPass.NativeMethodInfoPtr_SetupCBufferPhase0_Private_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_byref_MediumCullingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664259);
    GenerateDensityBufferLitPass.NativeMethodInfoPtr_SetupCBufferPhase1_Private_Void_CommandBuffer_Vector3Int_byref_VolumetricSampleData_byref_VolumetricProjectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664260);
    GenerateDensityBufferLitPass.NativeMethodInfoPtr_SetupBuffers_Private_Void_CommandBuffer_byref_MediumCullingResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, 100664261);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935634, RefRangeEnd = 935635, XrefRangeStart = 935628, XrefRangeEnd = 935634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ComputeBuffer MakeByteAddressBuffer<T>(string label, int itemCount) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.MethodInfoStoreGeneric_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 935689, RefRangeEnd = 935691, XrefRangeStart = 935635, XrefRangeEnd = 935689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenerateDensityBufferLitPass(
    ComputeShader compute,
    Texture3D tex3DNoise,
    Texture3D tex3DCurlNoise)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tex3DNoise);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tex3DCurlNoise);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_Texture3D_Texture3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935738, RefRangeEnd = 935739, XrefRangeStart = 935691, XrefRangeEnd = 935738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref VBufferParams vbuffer,
    [In] ref VolumetricParams volumetric,
    [In] ref MediumCullingResult mediumCullingResult,
    [In] ref VolumetricSampleData volumetricSampleData,
    RenderTextureResource texDensityBufferLit,
    RenderTextureResource texDensityBufferLitHistory,
    [In] ref VolumetricProjectionData reprojData,
    bool doTaa)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vbuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumetric;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mediumCullingResult);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumetricSampleData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDensityBufferLit));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDensityBufferLitHistory));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref reprojData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &doTaa;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_byref_MediumCullingResult_byref_VolumetricSampleData_RenderTextureResource_RenderTextureResource_byref_VolumetricProjectionData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935739, XrefRangeEnd = 935750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935755, RefRangeEnd = 935756, XrefRangeStart = 935750, XrefRangeEnd = 935755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBufferPhase0(
    CommandBuffer cmd,
    [In] ref VBufferParams vbuffer,
    [In] ref VolumetricParams vol,
    [In] ref MediumCullingResult mediumCullingResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vbuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref vol;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mediumCullingResult);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.NativeMethodInfoPtr_SetupCBufferPhase0_Private_Void_CommandBuffer_byref_VBufferParams_byref_VolumetricParams_byref_MediumCullingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935795, RefRangeEnd = 935796, XrefRangeStart = 935756, XrefRangeEnd = 935795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBufferPhase1(
    CommandBuffer cmd,
    Vector3Int volumeSize,
    [In] ref VolumetricSampleData volumetricSampleData,
    [In] ref VolumetricProjectionData reprojData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &volumeSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumetricSampleData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref reprojData;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.NativeMethodInfoPtr_SetupCBufferPhase1_Private_Void_CommandBuffer_Vector3Int_byref_VolumetricSampleData_byref_VolumetricProjectionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935796, XrefRangeEnd = 935811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupBuffers(
    CommandBuffer cmd,
    [In] ref MediumCullingResult mediumCullingResult,
    int kernel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mediumCullingResult);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kernel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDensityBufferLitPass.NativeMethodInfoPtr_SetupBuffers_Private_Void_CommandBuffer_byref_MediumCullingResult_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kBoxCountLimit
  {
    get
    {
      int kBoxCountLimit;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kBoxCountLimit, (void*) &kBoxCountLimit);
      return kBoxCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kBoxCountLimit, (void*) &value);
    }
  }

  public static unsafe int kXyOffsetCount1D
  {
    get
    {
      int kXyOffsetCount1D;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kXyOffsetCount1D, (void*) &kXyOffsetCount1D);
      return kXyOffsetCount1D;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kXyOffsetCount1D, (void*) &value);
    }
  }

  public static unsafe int kXySampleCount
  {
    get
    {
      int kXySampleCount;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kXySampleCount, (void*) &kXySampleCount);
      return kXySampleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kXySampleCount, (void*) &value);
    }
  }

  public static unsafe int kDepthSampleCount
  {
    get
    {
      int depthSampleCount;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kDepthSampleCount, (void*) &depthSampleCount);
      return depthSampleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kDepthSampleCount, (void*) &value);
    }
  }

  public static unsafe Vector3Int kThreadGroupSize
  {
    get
    {
      Vector3Int kThreadGroupSize;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kThreadGroupSize, (void*) &kThreadGroupSize);
      return kThreadGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kThreadGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidVolumeDensityGpuList
  {
    get
    {
      int volumeDensityGpuList;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeDensityGpuList, (void*) &volumeDensityGpuList);
      return volumeDensityGpuList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeDensityGpuList, (void*) &value);
    }
  }

  public static unsafe int kSidVolumeNoiseIsOnGpuList
  {
    get
    {
      int noiseIsOnGpuList;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeNoiseIsOnGpuList, (void*) &noiseIsOnGpuList);
      return noiseIsOnGpuList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeNoiseIsOnGpuList, (void*) &value);
    }
  }

  public static unsafe int kSidVolumeNoiseGpuList
  {
    get
    {
      int volumeNoiseGpuList;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeNoiseGpuList, (void*) &volumeNoiseGpuList);
      return volumeNoiseGpuList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeNoiseGpuList, (void*) &value);
    }
  }

  public static unsafe int kSidVolumeMaterialGpuList
  {
    get
    {
      int volumeMaterialGpuList;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeMaterialGpuList, (void*) &volumeMaterialGpuList);
      return volumeMaterialGpuList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidVolumeMaterialGpuList, (void*) &value);
    }
  }

  public static unsafe int kSidTex3DNoise
  {
    get
    {
      int kSidTex3Dnoise;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTex3DNoise, (void*) &kSidTex3Dnoise);
      return kSidTex3Dnoise;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTex3DNoise, (void*) &value);
    }
  }

  public static unsafe int kSidTex3DCurlNoise
  {
    get
    {
      int sidTex3DcurlNoise;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTex3DCurlNoise, (void*) &sidTex3DcurlNoise);
      return sidTex3DcurlNoise;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTex3DCurlNoise, (void*) &value);
    }
  }

  public static unsafe int kSidTexDensityBufferLit
  {
    get
    {
      int densityBufferLit;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTexDensityBufferLit, (void*) &densityBufferLit);
      return densityBufferLit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTexDensityBufferLit, (void*) &value);
    }
  }

  public static unsafe int kSidTexDensityBufferLitHistory
  {
    get
    {
      int bufferLitHistory;
      IL2CPP.il2cpp_field_static_get_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTexDensityBufferLitHistory, (void*) &bufferLitHistory);
      return bufferLitHistory;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDensityBufferLitPass.NativeFieldInfoPtr_kSidTexDensityBufferLitHistory, (void*) &value);
    }
  }

  public unsafe CBuffer<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData> _cbufferPhase0
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__cbufferPhase0));
      return num == System.IntPtr.Zero ? (CBuffer<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>) null : Il2CppObjectPool.Get<CBuffer<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__cbufferPhase0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData> _cbufferPhase1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__cbufferPhase1));
      return num == System.IntPtr.Zero ? (CBuffer<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>) null : Il2CppObjectPool.Get<CBuffer<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__cbufferPhase1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernelDoTaa
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__kernelDoTaa));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__kernelDoTaa)) = value;
    }
  }

  public unsafe int _kernelWithoutTaa
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__kernelWithoutTaa));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__kernelWithoutTaa)) = value;
    }
  }

  public unsafe ComputeBuffer _bufferVolumeDensityGpu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__bufferVolumeDensityGpu));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__bufferVolumeDensityGpu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _volumeNoiseIsOnGpuBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__volumeNoiseIsOnGpuBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__volumeNoiseIsOnGpuBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _volumeNoiseGpuBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__volumeNoiseGpuBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__volumeNoiseGpuBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _bufferVolumeMaterialGpu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__bufferVolumeMaterialGpu));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__bufferVolumeMaterialGpu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D _tex3DNoise
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__tex3DNoise));
      return num == System.IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__tex3DNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D _tex3DCurlNoise
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__tex3DCurlNoise));
      return num == System.IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__tex3DCurlNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector2> _xyOffsets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__xyOffsets));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__xyOffsets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe uint _globalRandomSeed
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__globalRandomSeed));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__globalRandomSeed)) = value;
    }
  }

  public unsafe int _xySampleOffsetIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__xySampleOffsetIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__xySampleOffsetIndex)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> _zOffsets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__zOffsets));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__zOffsets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _depthSampleOffsetIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__depthSampleOffsetIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDensityBufferLitPass.NativeFieldInfoPtr__depthSampleOffsetIndex)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GenerateDensityBufferLitPhase0CBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_voxelUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogStartDistanceSqr0Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogHeightFadeStart0Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogHeightFadeEnd0Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogExtinction0;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAnisotropy0;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAlbedo0;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogStartDistance1Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogHeightFadeStart1Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogHeightFadeEnd1Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogExtinction1;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAnisotropy1;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAlbedo1;
    private static readonly System.IntPtr NativeFieldInfoPtr_participatingMediumCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_tex3DNoiseMipmapCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding2;
    [FieldOffset(0)]
    public Vector4 voxelUvScaleOffset;
    [FieldOffset(16 /*0x10*/)]
    public float globalFogStartDistanceSqr0Ws;
    [FieldOffset(20)]
    public float globalFogHeightFadeStart0Ws;
    [FieldOffset(24)]
    public float globalFogHeightFadeEnd0Ws;
    [FieldOffset(28)]
    public float globalFogExtinction0;
    [FieldOffset(32 /*0x20*/)]
    public float globalFogAnisotropy0;
    [FieldOffset(36)]
    public Vector3 globalFogAlbedo0;
    [FieldOffset(48 /*0x30*/)]
    public float globalFogStartDistance1Ws;
    [FieldOffset(52)]
    public float globalFogHeightFadeStart1Ws;
    [FieldOffset(56)]
    public float globalFogHeightFadeEnd1Ws;
    [FieldOffset(60)]
    public float globalFogExtinction1;
    [FieldOffset(64 /*0x40*/)]
    public float globalFogAnisotropy1;
    [FieldOffset(68)]
    public Vector3 globalFogAlbedo1;
    [FieldOffset(80 /*0x50*/)]
    public uint participatingMediumCount;
    [FieldOffset(84)]
    public float tex3DNoiseMipmapCount;
    [FieldOffset(88)]
    public Vector2 padding2;

    static GenerateDensityBufferLitPhase0CBufferData()
    {
      Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (GenerateDensityBufferLitPhase0CBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr);
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_voxelUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (voxelUvScaleOffset));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogStartDistanceSqr0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogStartDistanceSqr0Ws));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogHeightFadeStart0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogHeightFadeStart0Ws));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogHeightFadeEnd0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogHeightFadeEnd0Ws));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogExtinction0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogExtinction0));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogAnisotropy0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogAnisotropy0));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogAlbedo0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogAlbedo0));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogStartDistance1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogStartDistance1Ws));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogHeightFadeStart1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogHeightFadeStart1Ws));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogHeightFadeEnd1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogHeightFadeEnd1Ws));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogExtinction1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogExtinction1));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogAnisotropy1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogAnisotropy1));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_globalFogAlbedo1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (globalFogAlbedo1));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_participatingMediumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (participatingMediumCount));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_tex3DNoiseMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (tex3DNoiseMipmapCount));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData.NativeFieldInfoPtr_padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, nameof (padding2));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase0CBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GenerateDensityBufferLitPhase1CBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_froxelUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_xySampleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_globalIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding0;
    private static readonly System.IntPtr NativeFieldInfoPtr_zSampleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraUpWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_historyVolumeProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_historyVolumeViewPositionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_historyDepth2SliceIndexpParams;
    [FieldOffset(0)]
    public Vector4 froxelUvScaleOffset;
    [FieldOffset(16 /*0x10*/)]
    public Vector2 xySampleOffset;
    [FieldOffset(24)]
    public uint globalIndex;
    [FieldOffset(28)]
    public float padding0;
    [FieldOffset(32 /*0x20*/)]
    public float zSampleOffset;
    [FieldOffset(36)]
    public Vector3 cameraUpWs;
    [FieldOffset(48 /*0x30*/)]
    public Matrix4x4 historyVolumeProjectionViewMatrix;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 historyVolumeViewPositionWs;
    [FieldOffset(128 /*0x80*/)]
    public Vector4 historyDepth2SliceIndexpParams;

    static GenerateDensityBufferLitPhase1CBufferData()
    {
      Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr, nameof (GenerateDensityBufferLitPhase1CBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr);
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_froxelUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (froxelUvScaleOffset));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_xySampleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (xySampleOffset));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_globalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (globalIndex));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_padding0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (padding0));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_zSampleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (zSampleOffset));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_cameraUpWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (cameraUpWs));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_historyVolumeProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (historyVolumeProjectionViewMatrix));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_historyVolumeViewPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (historyVolumeViewPositionWs));
      GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData.NativeFieldInfoPtr_historyDepth2SliceIndexpParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, nameof (historyDepth2SliceIndexpParams));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateDensityBufferLitPass.GenerateDensityBufferLitPhase1CBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  private sealed class MethodInfoStoreGeneric_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GenerateDensityBufferLitPass.NativeMethodInfoPtr_MakeByteAddressBuffer_Private_Static_ComputeBuffer_String_Int32_0, Il2CppClassPointerStore<GenerateDensityBufferLitPass>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
