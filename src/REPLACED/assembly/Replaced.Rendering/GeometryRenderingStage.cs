// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GeometryRenderingStage
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

public sealed class GeometryRenderingStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexSceneColorTransparentRoughMipmapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderTargetCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidSingleColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexFrameMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDecalBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexGlobalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneColorTransparentRoughInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPerObjectDataFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_kOpaqueRenderQueueRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTransparentRenderQueueRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTransparentRoughRenderQueueRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_kFakeFogQueueRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_kShaderPassArray;
  private static readonly System.IntPtr NativeFieldInfoPtr_kLegacyShaderPassNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDecalMaterialPreviewPassName;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderStateDefault;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderStateShadedWireframe;
  private static readonly System.IntPtr NativeFieldInfoPtr__transmittanceCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderTragets;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderTargetLoadActions;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderTargetStoreActions;
  private static readonly System.IntPtr NativeFieldInfoPtr__wireframeMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__unsupportedMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__pixelizationPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__generateSceneColorMipmapsPass;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexSceneColorWithMipmaps_Private_Static_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_FrameRenderingParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupPass_Private_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_byref_RenderTargetBinding_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeOpaqueAndAlphaTest_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeTransparent_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeTransparentRough_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeUnsupportedMaterials_Private_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeWireframe_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GeometryRenderingStage()
  {
    Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GeometryRenderingStage));
    GeometryRenderingStage.NativeFieldInfoPtr_kTexSceneColorTransparentRoughMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kTexSceneColorTransparentRoughMipmapCount));
    GeometryRenderingStage.NativeFieldInfoPtr_kRenderTargetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kRenderTargetCount));
    GeometryRenderingStage.NativeFieldInfoPtr_kSidSingleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kSidSingleColor));
    GeometryRenderingStage.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kSidTexSceneDepth));
    GeometryRenderingStage.NativeFieldInfoPtr_kSidTexFrameMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kSidTexFrameMask));
    GeometryRenderingStage.NativeFieldInfoPtr_kSidTexDecalBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kSidTexDecalBuffer));
    GeometryRenderingStage.NativeFieldInfoPtr_kSidTexGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kSidTexGlobalIllumination));
    GeometryRenderingStage.NativeFieldInfoPtr_kSidTexSceneColorTransparentRoughInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kSidTexSceneColorTransparentRoughInput));
    GeometryRenderingStage.NativeFieldInfoPtr_kPerObjectDataFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kPerObjectDataFlags));
    GeometryRenderingStage.NativeFieldInfoPtr_kOpaqueRenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kOpaqueRenderQueueRange));
    GeometryRenderingStage.NativeFieldInfoPtr_kTransparentRenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kTransparentRenderQueueRange));
    GeometryRenderingStage.NativeFieldInfoPtr_kTransparentRoughRenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kTransparentRoughRenderQueueRange));
    GeometryRenderingStage.NativeFieldInfoPtr_kFakeFogQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kFakeFogQueueRange));
    GeometryRenderingStage.NativeFieldInfoPtr_kShaderPassArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kShaderPassArray));
    GeometryRenderingStage.NativeFieldInfoPtr_kLegacyShaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kLegacyShaderPassNames));
    GeometryRenderingStage.NativeFieldInfoPtr_kDecalMaterialPreviewPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kDecalMaterialPreviewPassName));
    GeometryRenderingStage.NativeFieldInfoPtr_kRenderStateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kRenderStateDefault));
    GeometryRenderingStage.NativeFieldInfoPtr_kRenderStateShadedWireframe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (kRenderStateShadedWireframe));
    GeometryRenderingStage.NativeFieldInfoPtr__transmittanceCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_transmittanceCBuffer));
    GeometryRenderingStage.NativeFieldInfoPtr__renderTragets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_renderTragets));
    GeometryRenderingStage.NativeFieldInfoPtr__renderTargetLoadActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_renderTargetLoadActions));
    GeometryRenderingStage.NativeFieldInfoPtr__renderTargetStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_renderTargetStoreActions));
    GeometryRenderingStage.NativeFieldInfoPtr__wireframeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_wireframeMaterial));
    GeometryRenderingStage.NativeFieldInfoPtr__unsupportedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_unsupportedMaterial));
    GeometryRenderingStage.NativeFieldInfoPtr__pixelizationPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_pixelizationPass));
    GeometryRenderingStage.NativeFieldInfoPtr__generateSceneColorMipmapsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (_generateSceneColorMipmapsPass));
    GeometryRenderingStage.NativeMethodInfoPtr_MakeTexSceneColorWithMipmaps_Private_Static_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663791);
    GeometryRenderingStage.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_FrameRenderingParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663792 /*0x060001F0*/);
    GeometryRenderingStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663793);
    GeometryRenderingStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663794);
    GeometryRenderingStage.NativeMethodInfoPtr_SetupPass_Private_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_byref_RenderTargetBinding_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663795);
    GeometryRenderingStage.NativeMethodInfoPtr_EncodeOpaqueAndAlphaTest_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663796);
    GeometryRenderingStage.NativeMethodInfoPtr_EncodeTransparent_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663797);
    GeometryRenderingStage.NativeMethodInfoPtr_EncodeTransparentRough_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663798);
    GeometryRenderingStage.NativeMethodInfoPtr_EncodeUnsupportedMaterials_Private_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663799);
    GeometryRenderingStage.NativeMethodInfoPtr_EncodeWireframe_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663800);
    GeometryRenderingStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, 100663801);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929045, XrefRangeEnd = 929063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexSceneColorWithMipmaps(
    RenderTextureResource texSceneColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_MakeTexSceneColorWithMipmaps_Private_Static_RenderTextureResource_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 929079, RefRangeEnd = 929082, XrefRangeStart = 929063, XrefRangeEnd = 929079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererList MakeRendererList(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp,
    Il2CppStructArray<ShaderTagId> shaderPassArray,
    SortingCriteria sortingCriteria,
    RenderQueueRange renderQueueRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shaderPassArray);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &renderQueueRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_FrameRenderingParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929138, RefRangeEnd = 929139, XrefRangeStart = 929082, XrefRangeEnd = 929138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GeometryRenderingStage(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929182, RefRangeEnd = 929183, XrefRangeStart = 929139, XrefRangeEnd = 929182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929230, RefRangeEnd = 929231, XrefRangeStart = 929183, XrefRangeEnd = 929230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupPass(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp,
    out RenderTargetBinding renderTargetBinding,
    out RenderTextureResource texSceneColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_SetupPass_Private_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_byref_RenderTargetBinding_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref RenderTargetBinding local1 = ref renderTargetBinding;
    System.IntPtr pointer1 = zero1;
    RenderTargetBinding renderTargetBinding1 = pointer1 == System.IntPtr.Zero ? (RenderTargetBinding) null : new RenderTargetBinding(pointer1);
    local1 = renderTargetBinding1;
    ref RenderTextureResource local2 = ref texSceneColor;
    System.IntPtr pointer2 = zero2;
    RenderTextureResource renderTextureResource = pointer2 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer2);
    local2 = renderTextureResource;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929244, RefRangeEnd = 929245, XrefRangeStart = 929231, XrefRangeEnd = 929244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeOpaqueAndAlphaTest(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_EncodeOpaqueAndAlphaTest_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929258, RefRangeEnd = 929259, XrefRangeStart = 929245, XrefRangeEnd = 929258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeTransparent(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_EncodeTransparent_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929281, RefRangeEnd = 929282, XrefRangeStart = 929259, XrefRangeEnd = 929281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeTransparentRough(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    RenderTextureResource texSceneColorTransparentRoughInput)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColorTransparentRoughInput));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_EncodeTransparentRough_Private_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeUnsupportedMaterials(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_EncodeUnsupportedMaterials_Private_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeWireframe([In] ref ScriptableRenderContext ctx, [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_EncodeWireframe_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929295, RefRangeEnd = 929296, XrefRangeStart = 929282, XrefRangeEnd = 929295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryRenderingStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kTexSceneColorTransparentRoughMipmapCount
  {
    get
    {
      int roughMipmapCount;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kTexSceneColorTransparentRoughMipmapCount, (void*) &roughMipmapCount);
      return roughMipmapCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kTexSceneColorTransparentRoughMipmapCount, (void*) &value);
    }
  }

  public static unsafe int kRenderTargetCount
  {
    get
    {
      int renderTargetCount;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kRenderTargetCount, (void*) &renderTargetCount);
      return renderTargetCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kRenderTargetCount, (void*) &value);
    }
  }

  public static unsafe int kSidSingleColor
  {
    get
    {
      int kSidSingleColor;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidSingleColor, (void*) &kSidSingleColor);
      return kSidSingleColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidSingleColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexFrameMask
  {
    get
    {
      int kSidTexFrameMask;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexFrameMask, (void*) &kSidTexFrameMask);
      return kSidTexFrameMask;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexFrameMask, (void*) &value);
    }
  }

  public static unsafe int kSidTexDecalBuffer
  {
    get
    {
      int sidTexDecalBuffer;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexDecalBuffer, (void*) &sidTexDecalBuffer);
      return sidTexDecalBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexDecalBuffer, (void*) &value);
    }
  }

  public static unsafe int kSidTexGlobalIllumination
  {
    get
    {
      int globalIllumination;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexGlobalIllumination, (void*) &globalIllumination);
      return globalIllumination;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexGlobalIllumination, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneColorTransparentRoughInput
  {
    get
    {
      int transparentRoughInput;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexSceneColorTransparentRoughInput, (void*) &transparentRoughInput);
      return transparentRoughInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kSidTexSceneColorTransparentRoughInput, (void*) &value);
    }
  }

  public static unsafe PerObjectData kPerObjectDataFlags
  {
    get
    {
      PerObjectData perObjectDataFlags;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kPerObjectDataFlags, (void*) &perObjectDataFlags);
      return perObjectDataFlags;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kPerObjectDataFlags, (void*) &value);
    }
  }

  public static unsafe RenderQueueRange kOpaqueRenderQueueRange
  {
    get
    {
      RenderQueueRange renderQueueRange;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kOpaqueRenderQueueRange, (void*) &renderQueueRange);
      return renderQueueRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kOpaqueRenderQueueRange, (void*) &value);
    }
  }

  public static unsafe RenderQueueRange kTransparentRenderQueueRange
  {
    get
    {
      RenderQueueRange renderQueueRange;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kTransparentRenderQueueRange, (void*) &renderQueueRange);
      return renderQueueRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kTransparentRenderQueueRange, (void*) &value);
    }
  }

  public static unsafe RenderQueueRange kTransparentRoughRenderQueueRange
  {
    get
    {
      RenderQueueRange renderQueueRange;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kTransparentRoughRenderQueueRange, (void*) &renderQueueRange);
      return renderQueueRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kTransparentRoughRenderQueueRange, (void*) &value);
    }
  }

  public static unsafe RenderQueueRange kFakeFogQueueRange
  {
    get
    {
      RenderQueueRange fakeFogQueueRange;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kFakeFogQueueRange, (void*) &fakeFogQueueRange);
      return fakeFogQueueRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kFakeFogQueueRange, (void*) &value);
    }
  }

  public static unsafe Il2CppStructArray<ShaderTagId> kShaderPassArray
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kShaderPassArray, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<ShaderTagId>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kShaderPassArray, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<ShaderTagId> kLegacyShaderPassNames
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kLegacyShaderPassNames, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<ShaderTagId>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kLegacyShaderPassNames, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ShaderTagId kDecalMaterialPreviewPassName
  {
    get
    {
      ShaderTagId materialPreviewPassName;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kDecalMaterialPreviewPassName, (void*) &materialPreviewPassName);
      return materialPreviewPassName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kDecalMaterialPreviewPassName, (void*) &value);
    }
  }

  public static unsafe RenderStateBlock kRenderStateDefault
  {
    get
    {
      RenderStateBlock renderStateDefault;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kRenderStateDefault, (void*) &renderStateDefault);
      return renderStateDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kRenderStateDefault, (void*) &value);
    }
  }

  public static unsafe RenderStateBlock kRenderStateShadedWireframe
  {
    get
    {
      RenderStateBlock stateShadedWireframe;
      IL2CPP.il2cpp_field_static_get_value(GeometryRenderingStage.NativeFieldInfoPtr_kRenderStateShadedWireframe, (void*) &stateShadedWireframe);
      return stateShadedWireframe;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GeometryRenderingStage.NativeFieldInfoPtr_kRenderStateShadedWireframe, (void*) &value);
    }
  }

  public unsafe CBuffer<GeometryRenderingStage.TransmittanceCBufferData> _transmittanceCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__transmittanceCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GeometryRenderingStage.TransmittanceCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GeometryRenderingStage.TransmittanceCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__transmittanceCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<RenderTargetIdentifier> _renderTragets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__renderTragets));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RenderTargetIdentifier>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__renderTragets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<RenderBufferLoadAction> _renderTargetLoadActions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__renderTargetLoadActions));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RenderBufferLoadAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferLoadAction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__renderTargetLoadActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<RenderBufferStoreAction> _renderTargetStoreActions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__renderTargetStoreActions));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RenderBufferStoreAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__renderTargetStoreActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _wireframeMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__wireframeMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__wireframeMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _unsupportedMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__unsupportedMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__unsupportedMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PixelizationPass _pixelizationPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__pixelizationPass));
      return num == System.IntPtr.Zero ? (PixelizationPass) null : Il2CppObjectPool.Get<PixelizationPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__pixelizationPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GenerateSceneColorMipmapsPass _generateSceneColorMipmapsPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__generateSceneColorMipmapsPass));
      return num == System.IntPtr.Zero ? (GenerateSceneColorMipmapsPass) null : Il2CppObjectPool.Get<GenerateSceneColorMipmapsPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeometryRenderingStage.NativeFieldInfoPtr__generateSceneColorMipmapsPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TransmittanceCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texSceneColorTransparentRoughInputMipmapCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public float texSceneColorTransparentRoughInputMipmapCount;
    [FieldOffset(4)]
    public Vector3 padding;

    static TransmittanceCBufferData()
    {
      Il2CppClassPointerStore<GeometryRenderingStage.TransmittanceCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeometryRenderingStage>.NativeClassPtr, nameof (TransmittanceCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryRenderingStage.TransmittanceCBufferData>.NativeClassPtr);
      GeometryRenderingStage.TransmittanceCBufferData.NativeFieldInfoPtr_texSceneColorTransparentRoughInputMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage.TransmittanceCBufferData>.NativeClassPtr, nameof (texSceneColorTransparentRoughInputMipmapCount));
      GeometryRenderingStage.TransmittanceCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryRenderingStage.TransmittanceCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GeometryRenderingStage.TransmittanceCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
