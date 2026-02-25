// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SceneFrame
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

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class SceneFrame(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kColorFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRadianceSourceMipmapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kHIZMipmapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDecalBufferSliceCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTextureCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTextureParamsList;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTextureDescriptors;
  private static readonly System.IntPtr NativeFieldInfoPtr__frameIndexNumber;
  private static readonly System.IntPtr NativeFieldInfoPtr__debugLabels;
  private static readonly System.IntPtr NativeFieldInfoPtr__prevFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr__textures;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderTargetSize;
  private static readonly System.IntPtr NativeFieldInfoPtr__halfResSize;
  private static readonly System.IntPtr NativeFieldInfoPtr__projectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr__nonJitteredProjectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr__depthProjectionParams;
  private static readonly System.IntPtr NativeFieldInfoPtr__cllInputBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__lineLightsBufferRenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr__lineLightsBufferPackedData;
  private static readonly System.IntPtr NativeFieldInfoPtr__lineLightsBufferPackedDataVolumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr__puncLightsBufferRenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr__puncLightsBufferPackedData;
  private static readonly System.IntPtr NativeFieldInfoPtr__puncLightsBufferPackedDataVolumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr__puncLightsBufferShadowMapData;
  private static readonly System.IntPtr NativeFieldInfoPtr__puncLightsBufferSMProjectionViewReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr__puncLightsBufferPatternData;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumetricVBufferSize;
  private static readonly System.IntPtr NativeFieldInfoPtr__VolumetricProjectionData_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexGlobalIlluminationDescriptor_Public_Static_get_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexSceneColorDescriptor_Public_Static_get_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexSceneDepthDescriptor_Public_Static_get_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexRadianceMapDescriptor_Public_Static_get_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexStableCocDescriptor_Public_Static_get_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PrevFrame_Public_get_SceneFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RenderTargetSize_Public_get_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProjectionViewMatrix_Public_get_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NonJitteredProjectionViewMatrix_Public_get_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthProjectionParams_Public_get_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumetricProjectionData_Public_get_VolumetricProjectionData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VolumetricProjectionData_Public_set_Void_VolumetricProjectionData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumetricVBufferSize_Public_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumetricCanDoTaa_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Void_Vector2Int_byref_Matrix4x4_byref_Matrix4x4_Vector4_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexSceneDepth_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexSceneDepthCopy_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexMinHIZ_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexGlobalIllumination_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexRadianceMap_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexFrameMask_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexDecalBuffer_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexSceneColor_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexSceneNormal_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexMinHINormal_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexStableDofColor_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexStableCoc_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexStableBokehColor_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexColorAAResult_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexDensityBufferLit_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexCameraScatteredLight_Public_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCllInputBuffer_Public_Buffer_1_CLLPackedLightData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLineLightsBufferRenderingLayerMask_Public_Buffer_1_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLineLightsBufferPackedData_Public_Buffer_1_PackedData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLineLightsBufferPackedDataVolumetric_Public_Buffer_1_PackedData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPuncLightsBufferRenderingLayerMask_Public_Buffer_1_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPuncLightsBufferPackedData_Public_Buffer_1_PackedData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPuncLightsBufferPackedDataVolumetric_Public_Buffer_1_PackedData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPuncLightsBufferShadowMapData_Public_Buffer_1_SMData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPuncLightsBufferSMProjectionViewReceiver_Public_Buffer_1_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPuncLightsBufferPatternData_Public_Buffer_1_PatternData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReallocTexture_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Private_RenderTextureResource_TextureId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPreviousFrame_Internal_Void_SceneFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Vector2Int_TextureSizeMode_PDM_0;

  static SceneFrame()
  {
    Il2CppClassPointerStore<SceneFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SceneFrame));
    SceneFrame.NativeFieldInfoPtr_kColorFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kColorFormat));
    SceneFrame.NativeFieldInfoPtr_kRadianceSourceMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kRadianceSourceMipmapCount));
    SceneFrame.NativeFieldInfoPtr_kHIZMipmapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kHIZMipmapCount));
    SceneFrame.NativeFieldInfoPtr_kDecalBufferSliceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kDecalBufferSliceCount));
    SceneFrame.NativeFieldInfoPtr_kTextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kTextureCount));
    SceneFrame.NativeFieldInfoPtr_kTextureParamsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kTextureParamsList));
    SceneFrame.NativeFieldInfoPtr_kTextureDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (kTextureDescriptors));
    SceneFrame.NativeFieldInfoPtr__frameIndexNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_frameIndexNumber));
    SceneFrame.NativeFieldInfoPtr__debugLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_debugLabels));
    SceneFrame.NativeFieldInfoPtr__prevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_prevFrame));
    SceneFrame.NativeFieldInfoPtr__textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_textures));
    SceneFrame.NativeFieldInfoPtr__renderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_renderTargetSize));
    SceneFrame.NativeFieldInfoPtr__halfResSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_halfResSize));
    SceneFrame.NativeFieldInfoPtr__projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_projectionViewMatrix));
    SceneFrame.NativeFieldInfoPtr__nonJitteredProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_nonJitteredProjectionViewMatrix));
    SceneFrame.NativeFieldInfoPtr__depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_depthProjectionParams));
    SceneFrame.NativeFieldInfoPtr__cllInputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_cllInputBuffer));
    SceneFrame.NativeFieldInfoPtr__lineLightsBufferRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_lineLightsBufferRenderingLayerMask));
    SceneFrame.NativeFieldInfoPtr__lineLightsBufferPackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_lineLightsBufferPackedData));
    SceneFrame.NativeFieldInfoPtr__lineLightsBufferPackedDataVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_lineLightsBufferPackedDataVolumetric));
    SceneFrame.NativeFieldInfoPtr__puncLightsBufferRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_puncLightsBufferRenderingLayerMask));
    SceneFrame.NativeFieldInfoPtr__puncLightsBufferPackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_puncLightsBufferPackedData));
    SceneFrame.NativeFieldInfoPtr__puncLightsBufferPackedDataVolumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_puncLightsBufferPackedDataVolumetric));
    SceneFrame.NativeFieldInfoPtr__puncLightsBufferShadowMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_puncLightsBufferShadowMapData));
    SceneFrame.NativeFieldInfoPtr__puncLightsBufferSMProjectionViewReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_puncLightsBufferSMProjectionViewReceiver));
    SceneFrame.NativeFieldInfoPtr__puncLightsBufferPatternData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_puncLightsBufferPatternData));
    SceneFrame.NativeFieldInfoPtr__volumetricVBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (_volumetricVBufferSize));
    SceneFrame.NativeFieldInfoPtr__VolumetricProjectionData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, "<VolumetricProjectionData>k__BackingField");
    SceneFrame.NativeMethodInfoPtr_get_TexGlobalIlluminationDescriptor_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663516 /*0x060000DC*/);
    SceneFrame.NativeMethodInfoPtr_get_TexSceneColorDescriptor_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663517 /*0x060000DD*/);
    SceneFrame.NativeMethodInfoPtr_get_TexSceneDepthDescriptor_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663518 /*0x060000DE*/);
    SceneFrame.NativeMethodInfoPtr_get_TexRadianceMapDescriptor_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663519 /*0x060000DF*/);
    SceneFrame.NativeMethodInfoPtr_get_TexStableCocDescriptor_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663520 /*0x060000E0*/);
    SceneFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663522 /*0x060000E2*/);
    SceneFrame.NativeMethodInfoPtr_get_PrevFrame_Public_get_SceneFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663523 /*0x060000E3*/);
    SceneFrame.NativeMethodInfoPtr_get_RenderTargetSize_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663524 /*0x060000E4*/);
    SceneFrame.NativeMethodInfoPtr_get_ProjectionViewMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663525 /*0x060000E5*/);
    SceneFrame.NativeMethodInfoPtr_get_NonJitteredProjectionViewMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663526 /*0x060000E6*/);
    SceneFrame.NativeMethodInfoPtr_get_DepthProjectionParams_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663527 /*0x060000E7*/);
    SceneFrame.NativeMethodInfoPtr_get_VolumetricProjectionData_Public_get_VolumetricProjectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663528 /*0x060000E8*/);
    SceneFrame.NativeMethodInfoPtr_set_VolumetricProjectionData_Public_set_Void_VolumetricProjectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663529 /*0x060000E9*/);
    SceneFrame.NativeMethodInfoPtr_get_VolumetricVBufferSize_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663530 /*0x060000EA*/);
    SceneFrame.NativeMethodInfoPtr_get_VolumetricCanDoTaa_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663531 /*0x060000EB*/);
    SceneFrame.NativeMethodInfoPtr_Begin_Public_Void_Vector2Int_byref_Matrix4x4_byref_Matrix4x4_Vector4_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663532 /*0x060000EC*/);
    SceneFrame.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663533 /*0x060000ED*/);
    SceneFrame.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663534 /*0x060000EE*/);
    SceneFrame.NativeMethodInfoPtr_GetTexSceneDepth_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663535 /*0x060000EF*/);
    SceneFrame.NativeMethodInfoPtr_GetTexSceneDepthCopy_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663536 /*0x060000F0*/);
    SceneFrame.NativeMethodInfoPtr_GetTexMinHIZ_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663537 /*0x060000F1*/);
    SceneFrame.NativeMethodInfoPtr_GetTexGlobalIllumination_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663538 /*0x060000F2*/);
    SceneFrame.NativeMethodInfoPtr_GetTexRadianceMap_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663539 /*0x060000F3*/);
    SceneFrame.NativeMethodInfoPtr_GetTexFrameMask_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663540 /*0x060000F4*/);
    SceneFrame.NativeMethodInfoPtr_GetTexDecalBuffer_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663541 /*0x060000F5*/);
    SceneFrame.NativeMethodInfoPtr_GetTexSceneColor_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663542 /*0x060000F6*/);
    SceneFrame.NativeMethodInfoPtr_GetTexSceneNormal_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663543 /*0x060000F7*/);
    SceneFrame.NativeMethodInfoPtr_GetTexMinHINormal_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663544 /*0x060000F8*/);
    SceneFrame.NativeMethodInfoPtr_GetTexStableDofColor_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663545 /*0x060000F9*/);
    SceneFrame.NativeMethodInfoPtr_GetTexStableCoc_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663546 /*0x060000FA*/);
    SceneFrame.NativeMethodInfoPtr_GetTexStableBokehColor_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663547 /*0x060000FB*/);
    SceneFrame.NativeMethodInfoPtr_GetTexColorAAResult_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663548 /*0x060000FC*/);
    SceneFrame.NativeMethodInfoPtr_GetTexDensityBufferLit_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663549 /*0x060000FD*/);
    SceneFrame.NativeMethodInfoPtr_GetTexCameraScatteredLight_Public_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663550 /*0x060000FE*/);
    SceneFrame.NativeMethodInfoPtr_GetCllInputBuffer_Public_Buffer_1_CLLPackedLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663551 /*0x060000FF*/);
    SceneFrame.NativeMethodInfoPtr_GetLineLightsBufferRenderingLayerMask_Public_Buffer_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663552 /*0x06000100*/);
    SceneFrame.NativeMethodInfoPtr_GetLineLightsBufferPackedData_Public_Buffer_1_PackedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663553 /*0x06000101*/);
    SceneFrame.NativeMethodInfoPtr_GetLineLightsBufferPackedDataVolumetric_Public_Buffer_1_PackedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663554 /*0x06000102*/);
    SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferRenderingLayerMask_Public_Buffer_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663555 /*0x06000103*/);
    SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferPackedData_Public_Buffer_1_PackedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663556 /*0x06000104*/);
    SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferPackedDataVolumetric_Public_Buffer_1_PackedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663557 /*0x06000105*/);
    SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferShadowMapData_Public_Buffer_1_SMData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663558 /*0x06000106*/);
    SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferSMProjectionViewReceiver_Public_Buffer_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663559 /*0x06000107*/);
    SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferPatternData_Public_Buffer_1_PatternData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663560 /*0x06000108*/);
    SceneFrame.NativeMethodInfoPtr_ReallocTexture_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663561 /*0x06000109*/);
    SceneFrame.NativeMethodInfoPtr_GetTexture_Private_RenderTextureResource_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663562 /*0x0600010A*/);
    SceneFrame.NativeMethodInfoPtr_SetPreviousFrame_Internal_Void_SceneFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663563 /*0x0600010B*/);
    SceneFrame.NativeMethodInfoPtr_Method_Private_Vector2Int_TextureSizeMode_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, 100663564 /*0x0600010C*/);
  }

  public static unsafe RenderTextureDescriptor TexGlobalIlluminationDescriptor
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 925852, RefRangeEnd = 925854, XrefRangeStart = 925848, XrefRangeEnd = 925852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_TexGlobalIlluminationDescriptor_Public_Static_get_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureDescriptor*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RenderTextureDescriptor TexSceneColorDescriptor
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 925858, RefRangeEnd = 925861, XrefRangeStart = 925854, XrefRangeEnd = 925858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_TexSceneColorDescriptor_Public_Static_get_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureDescriptor*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RenderTextureDescriptor TexSceneDepthDescriptor
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 925865, RefRangeEnd = 925867, XrefRangeStart = 925861, XrefRangeEnd = 925865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_TexSceneDepthDescriptor_Public_Static_get_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureDescriptor*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RenderTextureDescriptor TexRadianceMapDescriptor
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 925871, RefRangeEnd = 925873, XrefRangeStart = 925867, XrefRangeEnd = 925871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_TexRadianceMapDescriptor_Public_Static_get_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureDescriptor*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RenderTextureDescriptor TexStableCocDescriptor
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 925877, RefRangeEnd = 925879, XrefRangeStart = 925873, XrefRangeEnd = 925877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_TexStableCocDescriptor_Public_Static_get_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureDescriptor*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926052, RefRangeEnd = 926053, XrefRangeStart = 925879, XrefRangeEnd = 926052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneFrame(int index)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SceneFrame PrevFrame
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_PrevFrame_Public_get_SceneFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SceneFrame) null : Il2CppObjectPool.Get<SceneFrame>(num3);
    }
  }

  public unsafe Vector2Int RenderTargetSize
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_RenderTargetSize_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Matrix4x4 ProjectionViewMatrix
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_ProjectionViewMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Matrix4x4 NonJitteredProjectionViewMatrix
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_NonJitteredProjectionViewMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector4 DepthProjectionParams
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 926053, RefRangeEnd = 926054, XrefRangeStart = 926053, XrefRangeEnd = 926053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_DepthProjectionParams_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe VolumetricProjectionData VolumetricProjectionData
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_VolumetricProjectionData_Public_get_VolumetricProjectionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(VolumetricProjectionData*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_set_VolumetricProjectionData_Public_set_Void_VolumetricProjectionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3Int VolumetricVBufferSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_VolumetricVBufferSize_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool VolumetricCanDoTaa
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 926062, RefRangeEnd = 926063, XrefRangeStart = 926054, XrefRangeEnd = 926062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_get_VolumetricCanDoTaa_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926086, RefRangeEnd = 926087, XrefRangeStart = 926063, XrefRangeEnd = 926086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Begin(
    Vector2Int renderTargetSize,
    [In] ref Matrix4x4 projectionViewMatrix,
    [In] ref Matrix4x4 nonJitteredProjectionViewMatrix,
    Vector4 depthProjectionParams,
    Vector3Int vbufferSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &renderTargetSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref nonJitteredProjectionViewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &vbufferSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_Begin_Public_Void_Vector2Int_byref_Matrix4x4_byref_Matrix4x4_Vector4_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926095, RefRangeEnd = 926096, XrefRangeStart = 926087, XrefRangeEnd = 926095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926096, XrefRangeEnd = 926135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 926136, RefRangeEnd = 926145, XrefRangeStart = 926135, XrefRangeEnd = 926136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexSceneDepth()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexSceneDepth_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 926146, RefRangeEnd = 926151, XrefRangeStart = 926145, XrefRangeEnd = 926146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexSceneDepthCopy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexSceneDepthCopy_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 926152, RefRangeEnd = 926156, XrefRangeStart = 926151, XrefRangeEnd = 926152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexMinHIZ()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexMinHIZ_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 926157, RefRangeEnd = 926160, XrefRangeStart = 926156, XrefRangeEnd = 926157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexGlobalIllumination()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexGlobalIllumination_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926161, RefRangeEnd = 926163, XrefRangeStart = 926160, XrefRangeEnd = 926161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexRadianceMap()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexRadianceMap_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926164, RefRangeEnd = 926166, XrefRangeStart = 926163, XrefRangeEnd = 926164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexFrameMask()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexFrameMask_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926167, RefRangeEnd = 926169, XrefRangeStart = 926166, XrefRangeEnd = 926167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexDecalBuffer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexDecalBuffer_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 926170, RefRangeEnd = 926176, XrefRangeStart = 926169, XrefRangeEnd = 926170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexSceneColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexSceneColor_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926177, RefRangeEnd = 926179, XrefRangeStart = 926176, XrefRangeEnd = 926177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexSceneNormal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexSceneNormal_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926180, RefRangeEnd = 926182, XrefRangeStart = 926179, XrefRangeEnd = 926180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexMinHINormal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexMinHINormal_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926183, RefRangeEnd = 926185, XrefRangeStart = 926182, XrefRangeEnd = 926183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexStableDofColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexStableDofColor_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926186, RefRangeEnd = 926188, XrefRangeStart = 926185, XrefRangeEnd = 926186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexStableCoc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexStableCoc_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926189, RefRangeEnd = 926191, XrefRangeStart = 926188, XrefRangeEnd = 926189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexStableBokehColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexStableBokehColor_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 926192, RefRangeEnd = 926195, XrefRangeStart = 926191, XrefRangeEnd = 926192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexColorAAResult()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexColorAAResult_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926196, RefRangeEnd = 926198, XrefRangeStart = 926195, XrefRangeEnd = 926196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexDensityBufferLit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexDensityBufferLit_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926199, RefRangeEnd = 926200, XrefRangeStart = 926198, XrefRangeEnd = 926199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexCameraScatteredLight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexCameraScatteredLight_Public_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  public unsafe Buffer<CLLPackedLightData> GetCllInputBuffer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetCllInputBuffer_Public_Buffer_1_CLLPackedLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<CLLPackedLightData>) null : Il2CppObjectPool.Get<Buffer<CLLPackedLightData>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<uint> GetLineLightsBufferRenderingLayerMask()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetLineLightsBufferRenderingLayerMask_Public_Buffer_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<uint>) null : Il2CppObjectPool.Get<Buffer<uint>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<LineLightsV2Data.PackedData> GetLineLightsBufferPackedData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetLineLightsBufferPackedData_Public_Buffer_1_PackedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<LineLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<LineLightsV2Data.PackedData>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<LineLightsV2Data.PackedData> GetLineLightsBufferPackedDataVolumetric()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetLineLightsBufferPackedDataVolumetric_Public_Buffer_1_PackedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<LineLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<LineLightsV2Data.PackedData>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<uint> GetPuncLightsBufferRenderingLayerMask()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferRenderingLayerMask_Public_Buffer_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<uint>) null : Il2CppObjectPool.Get<Buffer<uint>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<PunctualLightsV2Data.PackedData> GetPuncLightsBufferPackedData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferPackedData_Public_Buffer_1_PackedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PackedData>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<PunctualLightsV2Data.PackedData> GetPuncLightsBufferPackedDataVolumetric()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferPackedDataVolumetric_Public_Buffer_1_PackedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PackedData>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<PunctualLightsV2Data.SMData> GetPuncLightsBufferShadowMapData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferShadowMapData_Public_Buffer_1_SMData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.SMData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.SMData>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<Matrix4x4> GetPuncLightsBufferSMProjectionViewReceiver()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferSMProjectionViewReceiver_Public_Buffer_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<Matrix4x4>) null : Il2CppObjectPool.Get<Buffer<Matrix4x4>>(num3);
  }

  [CallerCount(0)]
  public unsafe Buffer<PunctualLightsV2Data.PatternData> GetPuncLightsBufferPatternData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetPuncLightsBufferPatternData_Public_Buffer_1_PatternData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PatternData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PatternData>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926216, RefRangeEnd = 926217, XrefRangeStart = 926200, XrefRangeEnd = 926216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReallocTexture(int idx)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &idx
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_ReallocTexture_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 926223, RefRangeEnd = 926240, XrefRangeStart = 926217, XrefRangeEnd = 926223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource GetTexture(SceneFrame.TextureId tid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &tid
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_GetTexture_Private_RenderTextureResource_TextureId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPreviousFrame(SceneFrame prevFrame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prevFrame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_SetPreviousFrame_Internal_Void_SceneFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Vector2Int Method_Private_Vector2Int_TextureSizeMode_PDM_0(
    SceneFrame.TextureSizeMode sm)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sm
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrame.NativeMethodInfoPtr_Method_Private_Vector2Int_TextureSizeMode_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe RenderTextureFormat kColorFormat
  {
    get
    {
      RenderTextureFormat kColorFormat;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kColorFormat, (void*) &kColorFormat);
      return kColorFormat;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kColorFormat, (void*) &value);
    }
  }

  public static unsafe int kRadianceSourceMipmapCount
  {
    get
    {
      int sourceMipmapCount;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kRadianceSourceMipmapCount, (void*) &sourceMipmapCount);
      return sourceMipmapCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kRadianceSourceMipmapCount, (void*) &value);
    }
  }

  public static unsafe int kHIZMipmapCount
  {
    get
    {
      int kHizMipmapCount;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kHIZMipmapCount, (void*) &kHizMipmapCount);
      return kHizMipmapCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kHIZMipmapCount, (void*) &value);
    }
  }

  public static unsafe int kDecalBufferSliceCount
  {
    get
    {
      int bufferSliceCount;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kDecalBufferSliceCount, (void*) &bufferSliceCount);
      return bufferSliceCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kDecalBufferSliceCount, (void*) &value);
    }
  }

  public static unsafe int kTextureCount
  {
    get
    {
      int kTextureCount;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kTextureCount, (void*) &kTextureCount);
      return kTextureCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kTextureCount, (void*) &value);
    }
  }

  public static unsafe Il2CppStructArray<SceneFrame.TextureParams> kTextureParamsList
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kTextureParamsList, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<SceneFrame.TextureParams>) null : Il2CppObjectPool.Get<Il2CppStructArray<SceneFrame.TextureParams>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kTextureParamsList, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<RenderTextureDescriptor> kTextureDescriptors
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneFrame.NativeFieldInfoPtr_kTextureDescriptors, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<RenderTextureDescriptor>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderTextureDescriptor>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrame.NativeFieldInfoPtr_kTextureDescriptors, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _frameIndexNumber
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__frameIndexNumber));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__frameIndexNumber)) = value;
    }
  }

  public unsafe Il2CppStringArray _debugLabels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__debugLabels));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__debugLabels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SceneFrame _prevFrame
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__prevFrame));
      return num == System.IntPtr.Zero ? (SceneFrame) null : Il2CppObjectPool.Get<SceneFrame>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__prevFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<RenderTextureResource> _textures
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__textures));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RenderTextureResource>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTextureResource>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__textures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int _renderTargetSize
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__renderTargetSize));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__renderTargetSize)) = value;
    }
  }

  public unsafe Vector2Int _halfResSize
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__halfResSize));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__halfResSize)) = value;
    }
  }

  public unsafe Matrix4x4 _projectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__projectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__projectionViewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 _nonJitteredProjectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__nonJitteredProjectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__nonJitteredProjectionViewMatrix)) = value;
    }
  }

  public unsafe Vector4 _depthProjectionParams
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__depthProjectionParams));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__depthProjectionParams)) = value;
    }
  }

  public unsafe Buffer<CLLPackedLightData> _cllInputBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__cllInputBuffer));
      return num == System.IntPtr.Zero ? (Buffer<CLLPackedLightData>) null : Il2CppObjectPool.Get<Buffer<CLLPackedLightData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__cllInputBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<uint> _lineLightsBufferRenderingLayerMask
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__lineLightsBufferRenderingLayerMask));
      return num == System.IntPtr.Zero ? (Buffer<uint>) null : Il2CppObjectPool.Get<Buffer<uint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__lineLightsBufferRenderingLayerMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<LineLightsV2Data.PackedData> _lineLightsBufferPackedData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__lineLightsBufferPackedData));
      return num == System.IntPtr.Zero ? (Buffer<LineLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<LineLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__lineLightsBufferPackedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<LineLightsV2Data.PackedData> _lineLightsBufferPackedDataVolumetric
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__lineLightsBufferPackedDataVolumetric));
      return num == System.IntPtr.Zero ? (Buffer<LineLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<LineLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__lineLightsBufferPackedDataVolumetric), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<uint> _puncLightsBufferRenderingLayerMask
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferRenderingLayerMask));
      return num == System.IntPtr.Zero ? (Buffer<uint>) null : Il2CppObjectPool.Get<Buffer<uint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferRenderingLayerMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.PackedData> _puncLightsBufferPackedData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferPackedData));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferPackedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.PackedData> _puncLightsBufferPackedDataVolumetric
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferPackedDataVolumetric));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PackedData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PackedData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferPackedDataVolumetric), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.SMData> _puncLightsBufferShadowMapData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferShadowMapData));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.SMData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.SMData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferShadowMapData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<Matrix4x4> _puncLightsBufferSMProjectionViewReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferSMProjectionViewReceiver));
      return num == System.IntPtr.Zero ? (Buffer<Matrix4x4>) null : Il2CppObjectPool.Get<Buffer<Matrix4x4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferSMProjectionViewReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<PunctualLightsV2Data.PatternData> _puncLightsBufferPatternData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferPatternData));
      return num == System.IntPtr.Zero ? (Buffer<PunctualLightsV2Data.PatternData>) null : Il2CppObjectPool.Get<Buffer<PunctualLightsV2Data.PatternData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__puncLightsBufferPatternData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3Int _volumetricVBufferSize
  {
    get
    {
      return *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__volumetricVBufferSize));
    }
    [param: In] set
    {
      *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__volumetricVBufferSize)) = value;
    }
  }

  public unsafe VolumetricProjectionData _VolumetricProjectionData_k__BackingField
  {
    get
    {
      return *(VolumetricProjectionData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__VolumetricProjectionData_k__BackingField));
    }
    [param: In] set
    {
      *(VolumetricProjectionData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrame.NativeFieldInfoPtr__VolumetricProjectionData_k__BackingField)) = value;
    }
  }

  public enum TextureId
  {
    SceneDepth,
    SceneDepthCopy,
    MinHIZ,
    GlobalIllumination,
    RadianceMap,
    FrameMask,
    DecalBuffer,
    SceneColor,
    SceneNormal,
    MinHINormal,
    StableDofColor,
    StableCoc,
    StableBokehColor,
    ColorAAResult,
    VolumetricDensityBufferLit,
    VolumetricCameraScatteredLight,
  }

  public enum TextureSizeMode
  {
    Full,
    Half,
    Volumetric3D,
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TextureParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sizeMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_isTransient;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureSizeMode_Boolean_0;
    [FieldOffset(0)]
    public readonly SceneFrame.TextureSizeMode sizeMode;
    [FieldOffset(4)]
    public readonly bool isTransient;

    static TextureParams()
    {
      Il2CppClassPointerStore<SceneFrame.TextureParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneFrame>.NativeClassPtr, nameof (TextureParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneFrame.TextureParams>.NativeClassPtr);
      SceneFrame.TextureParams.NativeFieldInfoPtr_sizeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame.TextureParams>.NativeClassPtr, nameof (sizeMode));
      SceneFrame.TextureParams.NativeFieldInfoPtr_isTransient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrame.TextureParams>.NativeClassPtr, nameof (isTransient));
      SceneFrame.TextureParams.NativeMethodInfoPtr__ctor_Public_Void_TextureSizeMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrame.TextureParams>.NativeClassPtr, 100663565 /*0x0600010D*/);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 331127, RefRangeEnd = 331137, XrefRangeStart = 331127, XrefRangeEnd = 331137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TextureParams(SceneFrame.TextureSizeMode sizeMode, bool isTransient)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sizeMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isTransient;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SceneFrame.TextureParams.NativeMethodInfoPtr__ctor_Public_Void_TextureSizeMode_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneFrame.TextureParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
