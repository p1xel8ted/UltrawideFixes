// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SkyAndCloudsPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class SkyAndCloudsPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCloudCoverageMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCelestialBodyBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBaseNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDetailNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr__texLowFrequencyNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr__texCloudDetailNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr__texCelestialBodyBaseColorDefault;
  private static readonly System.IntPtr NativeFieldInfoPtr__vertexCbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__fragmentCbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__firmamentMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__currBaseShapeNoiseOffset;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakePointOnSphere_Private_Static_Vector3_Single_Single_Single_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitForegroundCoverageRectVertices_Public_Static_Void_byref_SkyAndCloudsParams_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitRectangleGeometryData_Private_Static_Void_Vector3_Vector3_Vector3_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeWorldToPlaneUvMatrix_Private_Static_FirmamentGeometryData_byref_CelestialBodyParams_byref_SkyAndCloudsParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CelestialBodyParams_byref_SkyAndCloudsParams_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupVertexCBuffers_Private_Void_CommandBuffer_byref_SkyAndCloudsParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupFragmentCBuffers_Private_Void_CommandBuffer_byref_CelestialBodyParams_byref_SkyAndCloudsParams_0;

  static SkyAndCloudsPass()
  {
    Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SkyAndCloudsPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr);
    SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexCloudCoverageMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (kSidTexCloudCoverageMap));
    SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexCelestialBodyBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (kSidTexCelestialBodyBaseColor));
    SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexBaseNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (kSidTexBaseNoise));
    SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexDetailNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (kSidTexDetailNoise));
    SkyAndCloudsPass.NativeFieldInfoPtr__texLowFrequencyNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_texLowFrequencyNoise));
    SkyAndCloudsPass.NativeFieldInfoPtr__texCloudDetailNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_texCloudDetailNoise));
    SkyAndCloudsPass.NativeFieldInfoPtr__texCelestialBodyBaseColorDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_texCelestialBodyBaseColorDefault));
    SkyAndCloudsPass.NativeFieldInfoPtr__vertexCbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_vertexCbuffer));
    SkyAndCloudsPass.NativeFieldInfoPtr__fragmentCbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_fragmentCbuffer));
    SkyAndCloudsPass.NativeFieldInfoPtr__firmamentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_firmamentMaterial));
    SkyAndCloudsPass.NativeFieldInfoPtr__currBaseShapeNoiseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (_currBaseShapeNoiseOffset));
    SkyAndCloudsPass.NativeMethodInfoPtr_MakePointOnSphere_Private_Static_Vector3_Single_Single_Single_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663755);
    SkyAndCloudsPass.NativeMethodInfoPtr_InitForegroundCoverageRectVertices_Public_Static_Void_byref_SkyAndCloudsParams_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663756);
    SkyAndCloudsPass.NativeMethodInfoPtr_InitRectangleGeometryData_Private_Static_Void_Vector3_Vector3_Vector3_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663757);
    SkyAndCloudsPass.NativeMethodInfoPtr_MakeWorldToPlaneUvMatrix_Private_Static_FirmamentGeometryData_byref_CelestialBodyParams_byref_SkyAndCloudsParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663758);
    SkyAndCloudsPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663759);
    SkyAndCloudsPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CelestialBodyParams_byref_SkyAndCloudsParams_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663760 /*0x060001D0*/);
    SkyAndCloudsPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663761);
    SkyAndCloudsPass.NativeMethodInfoPtr_SetupVertexCBuffers_Private_Void_CommandBuffer_byref_SkyAndCloudsParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663762);
    SkyAndCloudsPass.NativeMethodInfoPtr_SetupFragmentCBuffers_Private_Void_CommandBuffer_byref_CelestialBodyParams_byref_SkyAndCloudsParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, 100663763);
  }

  [CallerCount(0)]
  public static unsafe Vector3 MakePointOnSphere(
    float sinTheta,
    float cosTheta,
    float sinPhi,
    float cosPhi,
    Vector3 sphereOriginWs,
    Vector3 sphereRadius3Ws)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &sinTheta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cosTheta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sinPhi;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &cosPhi;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereOriginWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &sphereRadius3Ws;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_MakePointOnSphere_Private_Static_Vector3_Single_Single_Single_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 928576, RefRangeEnd = 928578, XrefRangeStart = 928564, XrefRangeEnd = 928576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitForegroundCoverageRectVertices(
    [In] ref SkyAndCloudsParams sac,
    out Vector3 finalRightTopWs,
    out Vector3 finalLeftTopWs,
    out Vector3 finalRightBottomWs,
    out Vector3 finalLeftBottomWs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sac);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref finalRightTopWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref finalLeftTopWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref finalRightBottomWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref finalLeftBottomWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_InitForegroundCoverageRectVertices_Public_Static_Void_byref_SkyAndCloudsParams_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928596, RefRangeEnd = 928597, XrefRangeStart = 928578, XrefRangeEnd = 928596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitRectangleGeometryData(
    Vector3 rightTopWs,
    Vector3 leftTopWs,
    Vector3 rightBottomWs,
    Vector3 leftBottomWs,
    out Vector3 outRightWs,
    out Vector3 outUpWs,
    out Matrix4x4 outWorldToRectUvMatrix,
    out Vector3 outRectNormalWs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &rightTopWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &leftTopWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rightBottomWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &leftBottomWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outRightWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref outUpWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref outWorldToRectUvMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref outRectNormalWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_InitRectangleGeometryData_Private_Static_Void_Vector3_Vector3_Vector3_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928606, RefRangeEnd = 928607, XrefRangeStart = 928597, XrefRangeEnd = 928606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SkyAndCloudsPass.FirmamentGeometryData MakeWorldToPlaneUvMatrix(
    [In] ref CelestialBodyParams cbp,
    [In] ref SkyAndCloudsParams sac)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cbp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sac);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_MakeWorldToPlaneUvMatrix_Private_Static_FirmamentGeometryData_byref_CelestialBodyParams_byref_SkyAndCloudsParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SkyAndCloudsPass.FirmamentGeometryData*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928607, XrefRangeEnd = 928630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SkyAndCloudsPass(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928677, RefRangeEnd = 928678, XrefRangeStart = 928630, XrefRangeEnd = 928677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref CelestialBodyParams cbp,
    [In] ref SkyAndCloudsParams sac,
    RenderTextureResource texColorRenderTarget,
    RenderTextureResource texDepthRenderTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cbp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sac);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColorRenderTarget));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDepthRenderTarget));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_CelestialBodyParams_byref_SkyAndCloudsParams_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928678, XrefRangeEnd = 928685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928685, XrefRangeEnd = 928706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupVertexCBuffers(CommandBuffer cmd, [In] ref SkyAndCloudsParams sac)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sac);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_SetupVertexCBuffers_Private_Void_CommandBuffer_byref_SkyAndCloudsParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928726, RefRangeEnd = 928727, XrefRangeStart = 928706, XrefRangeEnd = 928726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupFragmentCBuffers(
    CommandBuffer cmd,
    [In] ref CelestialBodyParams cbp,
    [In] ref SkyAndCloudsParams sac)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cbp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sac);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsPass.NativeMethodInfoPtr_SetupFragmentCBuffers_Private_Void_CommandBuffer_byref_CelestialBodyParams_byref_SkyAndCloudsParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexCloudCoverageMap
  {
    get
    {
      int cloudCoverageMap;
      IL2CPP.il2cpp_field_static_get_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexCloudCoverageMap, (void*) &cloudCoverageMap);
      return cloudCoverageMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexCloudCoverageMap, (void*) &value);
    }
  }

  public static unsafe int kSidTexCelestialBodyBaseColor
  {
    get
    {
      int celestialBodyBaseColor;
      IL2CPP.il2cpp_field_static_get_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexCelestialBodyBaseColor, (void*) &celestialBodyBaseColor);
      return celestialBodyBaseColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexCelestialBodyBaseColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBaseNoise
  {
    get
    {
      int kSidTexBaseNoise;
      IL2CPP.il2cpp_field_static_get_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexBaseNoise, (void*) &kSidTexBaseNoise);
      return kSidTexBaseNoise;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexBaseNoise, (void*) &value);
    }
  }

  public static unsafe int kSidTexDetailNoise
  {
    get
    {
      int sidTexDetailNoise;
      IL2CPP.il2cpp_field_static_get_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexDetailNoise, (void*) &sidTexDetailNoise);
      return sidTexDetailNoise;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SkyAndCloudsPass.NativeFieldInfoPtr_kSidTexDetailNoise, (void*) &value);
    }
  }

  public unsafe Texture3D _texLowFrequencyNoise
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__texLowFrequencyNoise));
      return num == System.IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__texLowFrequencyNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3D _texCloudDetailNoise
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__texCloudDetailNoise));
      return num == System.IntPtr.Zero ? (Texture3D) null : Il2CppObjectPool.Get<Texture3D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__texCloudDetailNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D _texCelestialBodyBaseColorDefault
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__texCelestialBodyBaseColorDefault));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__texCelestialBodyBaseColorDefault), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData> _vertexCbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__vertexCbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__vertexCbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData> _fragmentCbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__fragmentCbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__fragmentCbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _firmamentMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__firmamentMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__firmamentMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 _currBaseShapeNoiseOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__currBaseShapeNoiseOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkyAndCloudsPass.NativeFieldInfoPtr__currBaseShapeNoiseOffset)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SkyAndCloudsPassVertexCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sphereColumnCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_paddin;
    private static readonly System.IntPtr NativeFieldInfoPtr_spherePositionWsVert;
    private static readonly System.IntPtr NativeFieldInfoPtr_sphereRadius3Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_sphereThetaOffsetScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_spherePhiOffsetScale;
    [FieldOffset(0)]
    public uint sphereColumnCount;
    [FieldOffset(4)]
    public Vector3Int paddin;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 spherePositionWsVert;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 sphereRadius3Ws;
    [FieldOffset(48 /*0x30*/)]
    public Vector2 sphereThetaOffsetScale;
    [FieldOffset(56)]
    public Vector2 spherePhiOffsetScale;

    static SkyAndCloudsPassVertexCBufferData()
    {
      Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (SkyAndCloudsPassVertexCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr);
      SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData.NativeFieldInfoPtr_sphereColumnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, nameof (sphereColumnCount));
      SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData.NativeFieldInfoPtr_paddin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, nameof (paddin));
      SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData.NativeFieldInfoPtr_spherePositionWsVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, nameof (spherePositionWsVert));
      SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData.NativeFieldInfoPtr_sphereRadius3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, nameof (sphereRadius3Ws));
      SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData.NativeFieldInfoPtr_sphereThetaOffsetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, nameof (sphereThetaOffsetScale));
      SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData.NativeFieldInfoPtr_spherePhiOffsetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, nameof (spherePhiOffsetScale));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassVertexCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SkyAndCloudsPassFramgmentCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_topColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_middleColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_topColorLimits;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomColorLimits;
    private static readonly System.IntPtr NativeFieldInfoPtr_sphereOriginWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_outerSphereRadius3WsRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_outerSphereRadius3Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_innerSphereRadius3Rcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_innerSphereRadius3Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_rectNormalWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_worldToUvRow0;
    private static readonly System.IntPtr NativeFieldInfoPtr_worldToUvRow1;
    private static readonly System.IntPtr NativeFieldInfoPtr_frgLayerBoundingSphereRadius3WsRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_bgrCoverage;
    private static readonly System.IntPtr NativeFieldInfoPtr_bgrCoverageTopVertOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_bgrCoverageBottomVertOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_clBaseNoiseSmoothness;
    private static readonly System.IntPtr NativeFieldInfoPtr_clBaseNoiseUvwOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_clBaseNoiseUvwScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_clBaseShapeTop;
    private static readonly System.IntPtr NativeFieldInfoPtr_clBaseShapeBottom;
    private static readonly System.IntPtr NativeFieldInfoPtr_clDetailNoiseSmoothness;
    private static readonly System.IntPtr NativeFieldInfoPtr_clDetailShapeTop;
    private static readonly System.IntPtr NativeFieldInfoPtr_clDetailShapeBottom;
    private static readonly System.IntPtr NativeFieldInfoPtr_clExtinctionTop;
    private static readonly System.IntPtr NativeFieldInfoPtr_clExtinctionBottom;
    private static readonly System.IntPtr NativeFieldInfoPtr_frgSkyIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_bgrSkyIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_celbPositionWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_celbSizeWsRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_celbTint;
    private static readonly System.IntPtr NativeFieldInfoPtr_debugOptions;
    [FieldOffset(0)]
    public Vector4 topColor;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 middleColor;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 bottomColor;
    [FieldOffset(48 /*0x30*/)]
    public Vector2 topColorLimits;
    [FieldOffset(56)]
    public Vector2 bottomColorLimits;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 sphereOriginWs;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 outerSphereRadius3WsRcp;
    [FieldOffset(96 /*0x60*/)]
    public Vector4 outerSphereRadius3Ws;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 innerSphereRadius3Rcp;
    [FieldOffset(128 /*0x80*/)]
    public Vector4 innerSphereRadius3Ws;
    [FieldOffset(144 /*0x90*/)]
    public Vector4 rectNormalWs;
    [FieldOffset(160 /*0xA0*/)]
    public Vector4 worldToUvRow0;
    [FieldOffset(176 /*0xB0*/)]
    public Vector4 worldToUvRow1;
    [FieldOffset(192 /*0xC0*/)]
    public Vector4 frgLayerBoundingSphereRadius3WsRcp;
    [FieldOffset(208 /*0xD0*/)]
    public Vector2 bgrCoverage;
    [FieldOffset(216)]
    public Vector2 bgrCoverageTopVertOffset;
    [FieldOffset(224 /*0xE0*/)]
    public Vector2 bgrCoverageBottomVertOffset;
    [FieldOffset(232)]
    public Vector2 clBaseNoiseSmoothness;
    [FieldOffset(240 /*0xF0*/)]
    public Vector4 clBaseNoiseUvwOffset;
    [FieldOffset(256 /*0x0100*/)]
    public Vector4 clBaseNoiseUvwScale;
    [FieldOffset(272)]
    public Vector2 clBaseShapeTop;
    [FieldOffset(280)]
    public Vector2 clBaseShapeBottom;
    [FieldOffset(288)]
    public Vector2 clDetailNoiseSmoothness;
    [FieldOffset(296)]
    public Vector2 clDetailShapeTop;
    [FieldOffset(304)]
    public Vector2 clDetailShapeBottom;
    [FieldOffset(312)]
    public Vector2 clExtinctionTop;
    [FieldOffset(320)]
    public Vector2 clExtinctionBottom;
    [FieldOffset(328)]
    public float frgSkyIntensity;
    [FieldOffset(332)]
    public float bgrSkyIntensity;
    [FieldOffset(336)]
    public Vector3 celbPositionWs;
    [FieldOffset(348)]
    public float celbSizeWsRcp;
    [FieldOffset(352)]
    public Vector3 celbTint;
    [FieldOffset(364)]
    public int debugOptions;

    static SkyAndCloudsPassFramgmentCBufferData()
    {
      Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (SkyAndCloudsPassFramgmentCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr);
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (topColor));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_middleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (middleColor));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (bottomColor));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_topColorLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (topColorLimits));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_bottomColorLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (bottomColorLimits));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_sphereOriginWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (sphereOriginWs));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_outerSphereRadius3WsRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (outerSphereRadius3WsRcp));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_outerSphereRadius3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (outerSphereRadius3Ws));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_innerSphereRadius3Rcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (innerSphereRadius3Rcp));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_innerSphereRadius3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (innerSphereRadius3Ws));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_rectNormalWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (rectNormalWs));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_worldToUvRow0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (worldToUvRow0));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_worldToUvRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (worldToUvRow1));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_frgLayerBoundingSphereRadius3WsRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (frgLayerBoundingSphereRadius3WsRcp));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_bgrCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (bgrCoverage));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_bgrCoverageTopVertOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (bgrCoverageTopVertOffset));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_bgrCoverageBottomVertOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (bgrCoverageBottomVertOffset));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clBaseNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clBaseNoiseSmoothness));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clBaseNoiseUvwOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clBaseNoiseUvwOffset));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clBaseNoiseUvwScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clBaseNoiseUvwScale));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clBaseShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clBaseShapeTop));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clBaseShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clBaseShapeBottom));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clDetailNoiseSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clDetailNoiseSmoothness));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clDetailShapeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clDetailShapeTop));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clDetailShapeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clDetailShapeBottom));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clExtinctionTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clExtinctionTop));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_clExtinctionBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (clExtinctionBottom));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_frgSkyIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (frgSkyIntensity));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_bgrSkyIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (bgrSkyIntensity));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_celbPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (celbPositionWs));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_celbSizeWsRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (celbSizeWsRcp));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_celbTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (celbTint));
      SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData.NativeFieldInfoPtr_debugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, nameof (debugOptions));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkyAndCloudsPass.SkyAndCloudsPassFramgmentCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct FirmamentGeometryData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldToRectUvMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_rectNormalWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_innerSphereRadius3Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_outerSphereRaidus3Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_frgLayerBoundingSphereRadius3Ws;
    private static readonly System.IntPtr NativeFieldInfoPtr_celestialBodyPositionWs;
    [FieldOffset(0)]
    public Matrix4x4 worldToRectUvMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Vector3 rectNormalWs;
    [FieldOffset(76)]
    public Vector3 innerSphereRadius3Ws;
    [FieldOffset(88)]
    public Vector3 outerSphereRaidus3Ws;
    [FieldOffset(100)]
    public Vector3 frgLayerBoundingSphereRadius3Ws;
    [FieldOffset(112 /*0x70*/)]
    public Vector3 celestialBodyPositionWs;

    static FirmamentGeometryData()
    {
      Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkyAndCloudsPass>.NativeClassPtr, nameof (FirmamentGeometryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr);
      SkyAndCloudsPass.FirmamentGeometryData.NativeFieldInfoPtr_worldToRectUvMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, nameof (worldToRectUvMatrix));
      SkyAndCloudsPass.FirmamentGeometryData.NativeFieldInfoPtr_rectNormalWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, nameof (rectNormalWs));
      SkyAndCloudsPass.FirmamentGeometryData.NativeFieldInfoPtr_innerSphereRadius3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, nameof (innerSphereRadius3Ws));
      SkyAndCloudsPass.FirmamentGeometryData.NativeFieldInfoPtr_outerSphereRaidus3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, nameof (outerSphereRaidus3Ws));
      SkyAndCloudsPass.FirmamentGeometryData.NativeFieldInfoPtr_frgLayerBoundingSphereRadius3Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, nameof (frgLayerBoundingSphereRadius3Ws));
      SkyAndCloudsPass.FirmamentGeometryData.NativeFieldInfoPtr_celestialBodyPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, nameof (celestialBodyPositionWs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkyAndCloudsPass.FirmamentGeometryData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
