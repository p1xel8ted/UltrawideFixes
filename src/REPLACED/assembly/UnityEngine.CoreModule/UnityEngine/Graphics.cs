// Decompiled with JetBrains decompiler
// Type: UnityEngine.Graphics
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public class Graphics(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kMaxDrawMeshInstanceCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_RenderInstancedDataLayouts;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_activeTier_Public_Static_set_Void_GraphicsTier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearRandomWriteTargets_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Material_Int32_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Slice_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Region_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_IntPtr_Int32_IntPtr_IntPtr_ShadowCastingMode_Boolean_IntPtr_LightProbeUsage_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstanced_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_byref_ManagedSpanWrapper_Int32_IntPtr_ShadowCastingMode_Boolean_Int32_IntPtr_LightProbeUsage_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BlitMaterial5_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Blit2_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Injected_Private_Static_Void_IntPtr_0;
  private static readonly Graphics.GetActiveColorGamutDelegate GetActiveColorGamutDelegateField;
  private static readonly Graphics.GetPreserveFramebufferAlphaDelegate GetPreserveFramebufferAlphaDelegateField;
  private static readonly Graphics.GetMinOpenGLESVersionDelegate GetMinOpenGLESVersionDelegateField;
  private static readonly Graphics.Internal_DrawProceduralNowDelegate Internal_DrawProceduralNowDelegateField;
  private static readonly Graphics.CreateGPUFenceImplDelegate CreateGPUFenceImplDelegateField;
  private static readonly Graphics.WaitOnGPUFenceImplDelegate WaitOnGPUFenceImplDelegateField;
  private static readonly Graphics.GetActiveColorBuffer_InjectedDelegate GetActiveColorBuffer_InjectedDelegateField;
  private static readonly Graphics.GetActiveDepthBuffer_InjectedDelegate GetActiveDepthBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_SetGfxRT_InjectedDelegate Internal_SetGfxRT_InjectedDelegateField;
  private static readonly Graphics.Internal_SetMRTSimple_InjectedDelegate Internal_SetMRTSimple_InjectedDelegateField;
  private static readonly Graphics.Internal_SetMRTFullSetup_InjectedDelegate Internal_SetMRTFullSetup_InjectedDelegateField;
  private static readonly Graphics.Internal_SetRandomWriteTargetRT_InjectedDelegate Internal_SetRandomWriteTargetRT_InjectedDelegateField;
  private static readonly Graphics.Internal_SetRandomWriteTargetBuffer_InjectedDelegate Internal_SetRandomWriteTargetBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegate Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegateField;
  private static readonly Graphics.CopyTexture_Full_InjectedDelegate CopyTexture_Full_InjectedDelegateField;
  private static readonly Graphics.CopyTexture_Slice_AllMips_InjectedDelegate CopyTexture_Slice_AllMips_InjectedDelegateField;
  private static readonly Graphics.CopyTexture_Full_Gfx_InjectedDelegate CopyTexture_Full_Gfx_InjectedDelegateField;
  private static readonly Graphics.CopyTexture_Slice_AllMips_Gfx_InjectedDelegate CopyTexture_Slice_AllMips_Gfx_InjectedDelegateField;
  private static readonly Graphics.CopyTexture_Slice_Gfx_InjectedDelegate CopyTexture_Slice_Gfx_InjectedDelegateField;
  private static readonly Graphics.CopyTexture_Region_Gfx_InjectedDelegate CopyTexture_Region_Gfx_InjectedDelegateField;
  private static readonly Graphics.ConvertTexture_Full_InjectedDelegate ConvertTexture_Full_InjectedDelegateField;
  private static readonly Graphics.ConvertTexture_Slice_InjectedDelegate ConvertTexture_Slice_InjectedDelegateField;
  private static readonly Graphics.ConvertTexture_Full_Gfx_InjectedDelegate ConvertTexture_Full_Gfx_InjectedDelegateField;
  private static readonly Graphics.ConvertTexture_Slice_Gfx_InjectedDelegate ConvertTexture_Slice_Gfx_InjectedDelegateField;
  private static readonly Graphics.CopyBufferImpl_InjectedDelegate CopyBufferImpl_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawMeshNow1_InjectedDelegate Internal_DrawMeshNow1_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawMeshNow2_InjectedDelegate Internal_DrawMeshNow2_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate Internal_DrawMeshInstancedProcedural_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate Internal_DrawMeshInstancedIndirect_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndexedNow_InjectedDelegate Internal_DrawProceduralIndexedNow_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndirectNow_InjectedDelegate Internal_DrawProceduralIndirectNow_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNow_InjectedDelegate Internal_DrawProceduralIndexedIndirectNow_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;
  private static readonly Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMaterial6_InjectedDelegate Internal_BlitMaterial6_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMultiTap4_InjectedDelegate Internal_BlitMultiTap4_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMultiTap5_InjectedDelegate Internal_BlitMultiTap5_InjectedDelegateField;
  private static readonly Graphics.Blit3_InjectedDelegate Blit3_InjectedDelegateField;
  private static readonly Graphics.Blit4_InjectedDelegate Blit4_InjectedDelegateField;
  private static readonly Graphics.Blit5_InjectedDelegate Blit5_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMaterialGfx5_InjectedDelegate Internal_BlitMaterialGfx5_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMaterialGfx6_InjectedDelegate Internal_BlitMaterialGfx6_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMultiTapGfx4_InjectedDelegate Internal_BlitMultiTapGfx4_InjectedDelegateField;
  private static readonly Graphics.Internal_BlitMultiTapGfx5_InjectedDelegate Internal_BlitMultiTapGfx5_InjectedDelegateField;
  private static readonly Graphics.BlitGfx2_InjectedDelegate BlitGfx2_InjectedDelegateField;
  private static readonly Graphics.BlitGfx3_InjectedDelegate BlitGfx3_InjectedDelegateField;
  private static readonly Graphics.BlitGfx4_InjectedDelegate BlitGfx4_InjectedDelegateField;
  private static readonly Graphics.BlitGfx5_InjectedDelegate BlitGfx5_InjectedDelegateField;
  private static readonly Graphics.ExecuteCommandBufferAsync_InjectedDelegate ExecuteCommandBufferAsync_InjectedDelegateField;

  static Graphics()
  {
    Il2CppClassPointerStore<Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Graphics));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphics>.NativeClassPtr);
    Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, nameof (kMaxDrawMeshInstanceCount));
    Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, nameof (s_RenderInstancedDataLayouts));
    Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664695);
    Graphics.NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664696);
    Graphics.NativeMethodInfoPtr_set_activeTier_Public_Static_set_Void_GraphicsTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664697);
    Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664698);
    Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664699);
    Graphics.NativeMethodInfoPtr_ClearRandomWriteTargets_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664700);
    Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664701);
    Graphics.NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664702);
    Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664703);
    Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664704 /*0x06000580*/);
    Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664705);
    Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664706);
    Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664707);
    Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664708);
    Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664709);
    Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664710);
    Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664711);
    Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664712);
    Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664713);
    Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664714);
    Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664715);
    Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664716);
    Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664717);
    Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Material_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664718);
    Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664719);
    Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664720 /*0x06000590*/);
    Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664722);
    Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664723);
    Graphics.NativeMethodInfoPtr_CopyTexture_Region_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664724);
    Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_IntPtr_Int32_IntPtr_IntPtr_ShadowCastingMode_Boolean_IntPtr_LightProbeUsage_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664725);
    Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_byref_ManagedSpanWrapper_Int32_IntPtr_ShadowCastingMode_Boolean_Int32_IntPtr_LightProbeUsage_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664726);
    Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664727);
    Graphics.NativeMethodInfoPtr_Blit2_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664728);
    Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664729);
    Graphics.GetActiveColorGamutDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorGamutDelegate>("UnityEngine.Graphics::GetActiveColorGamut");
    Graphics.GetPreserveFramebufferAlphaDelegateField = IL2CPP.ResolveICall<Graphics.GetPreserveFramebufferAlphaDelegate>("UnityEngine.Graphics::GetPreserveFramebufferAlpha");
    Graphics.GetMinOpenGLESVersionDelegateField = IL2CPP.ResolveICall<Graphics.GetMinOpenGLESVersionDelegate>("UnityEngine.Graphics::GetMinOpenGLESVersion");
    Graphics.Internal_DrawProceduralNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralNow");
    Graphics.CreateGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.CreateGPUFenceImplDelegate>("UnityEngine.Graphics::CreateGPUFenceImpl");
    Graphics.WaitOnGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.WaitOnGPUFenceImplDelegate>("UnityEngine.Graphics::WaitOnGPUFenceImpl");
    Graphics.GetActiveColorBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveColorBuffer_Injected");
    Graphics.GetActiveDepthBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveDepthBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveDepthBuffer_Injected");
    Graphics.Internal_SetGfxRT_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetGfxRT_InjectedDelegate>("UnityEngine.Graphics::Internal_SetGfxRT_Injected");
    Graphics.Internal_SetMRTSimple_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTSimple_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTSimple_Injected");
    Graphics.Internal_SetMRTFullSetup_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTFullSetup_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTFullSetup_Injected");
    Graphics.Internal_SetRandomWriteTargetRT_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetRT_InjectedDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetRT_Injected");
    Graphics.Internal_SetRandomWriteTargetBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetBuffer_Injected");
    Graphics.Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetGraphicsBuffer_Injected");
    Graphics.CopyTexture_Full_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Full_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Full_Injected");
    Graphics.CopyTexture_Slice_AllMips_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Slice_AllMips_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips_Injected");
    Graphics.CopyTexture_Full_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Full_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Full_Gfx_Injected");
    Graphics.CopyTexture_Slice_AllMips_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Slice_AllMips_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips_Gfx_Injected");
    Graphics.CopyTexture_Slice_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Slice_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Slice_Gfx_Injected");
    Graphics.CopyTexture_Region_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_Region_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Region_Gfx_Injected");
    Graphics.ConvertTexture_Full_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_Full_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Full_Injected");
    Graphics.ConvertTexture_Slice_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_Slice_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Slice_Injected");
    Graphics.ConvertTexture_Full_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_Full_Gfx_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Full_Gfx_Injected");
    Graphics.ConvertTexture_Slice_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_Slice_Gfx_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Slice_Gfx_Injected");
    Graphics.CopyBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.CopyBufferImpl_InjectedDelegate>("UnityEngine.Graphics::CopyBufferImpl_Injected");
    Graphics.Internal_DrawMeshNow1_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow1_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow1_Injected");
    Graphics.Internal_DrawMeshNow2_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow2_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow2_Injected");
    Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedProcedural_Injected");
    Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirect_Injected");
    Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected");
    Graphics.Internal_DrawProceduralIndexedNow_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedNow_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedNow_Injected");
    Graphics.Internal_DrawProceduralIndirectNow_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNow_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNow_Injected");
    Graphics.Internal_DrawProceduralIndexedIndirectNow_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNow_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNow_Injected");
    Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNowGraphicsBuffer_Injected");
    Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_Injected");
    Graphics.Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProcedural_Injected");
    Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexed_Injected");
    Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirect_Injected");
    Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectGraphicsBuffer_Injected");
    Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirect_Injected");
    Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected");
    Graphics.Internal_BlitMaterial6_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial6_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMaterial6_Injected");
    Graphics.Internal_BlitMultiTap4_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap4_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTap4_Injected");
    Graphics.Internal_BlitMultiTap5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap5_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTap5_Injected");
    Graphics.Blit3_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit3_InjectedDelegate>("UnityEngine.Graphics::Blit3_Injected");
    Graphics.Blit4_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit4_InjectedDelegate>("UnityEngine.Graphics::Blit4_Injected");
    Graphics.Blit5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit5_InjectedDelegate>("UnityEngine.Graphics::Blit5_Injected");
    Graphics.Internal_BlitMaterialGfx5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterialGfx5_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMaterialGfx5_Injected");
    Graphics.Internal_BlitMaterialGfx6_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterialGfx6_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMaterialGfx6_Injected");
    Graphics.Internal_BlitMultiTapGfx4_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTapGfx4_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTapGfx4_Injected");
    Graphics.Internal_BlitMultiTapGfx5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTapGfx5_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTapGfx5_Injected");
    Graphics.BlitGfx2_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.BlitGfx2_InjectedDelegate>("UnityEngine.Graphics::BlitGfx2_Injected");
    Graphics.BlitGfx3_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.BlitGfx3_InjectedDelegate>("UnityEngine.Graphics::BlitGfx3_Injected");
    Graphics.BlitGfx4_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.BlitGfx4_InjectedDelegate>("UnityEngine.Graphics::BlitGfx4_Injected");
    Graphics.BlitGfx5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.BlitGfx5_InjectedDelegate>("UnityEngine.Graphics::BlitGfx5_Injected");
    Graphics.ExecuteCommandBufferAsync_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferAsync_InjectedDelegate>("UnityEngine.Graphics::ExecuteCommandBufferAsync_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423163, XrefRangeEnd = 423165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Internal_GetMaxDrawMeshInstanceCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe GraphicsTier activeTier
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423165, XrefRangeEnd = 423167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsTier*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423167, XrefRangeEnd = 423169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_set_activeTier_Public_Static_set_Void_GraphicsTier_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423169, XrefRangeEnd = 423171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SetNullRT()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423171, XrefRangeEnd = 423176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SetRTSimple(
    RenderBuffer color,
    RenderBuffer depth,
    int mip,
    CubemapFace face,
    int depthSlice)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423178, RefRangeEnd = 423179, XrefRangeStart = 423176, XrefRangeEnd = 423178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClearRandomWriteTargets()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_ClearRandomWriteTargets_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423179, XrefRangeEnd = 423190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTexture_Slice(
    Texture src,
    int srcElement,
    int srcMip,
    Texture dst,
    int dstElement,
    int dstMip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dst);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423190, XrefRangeEnd = 423201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTexture_Region(
    Texture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    Texture dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &srcY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &srcHeight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dst);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dstX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &dstY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423201, XrefRangeEnd = 423225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_DrawMesh(
    Mesh mesh,
    int submeshIndex,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &matrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) properties);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &castShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &receiveShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) probeAnchor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeUsage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightProbeProxyVolume);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423256, RefRangeEnd = 423257, XrefRangeStart = 423225, XrefRangeEnd = 423256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) matrices);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) properties);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &castShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &receiveShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeUsage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightProbeProxyVolume);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423257, XrefRangeEnd = 423276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_BlitMaterial5(
    Texture source,
    RenderTexture dest,
    Material mat,
    int pass,
    bool setRT)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &setRT;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423276, XrefRangeEnd = 423288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Blit2(Texture source, RenderTexture dest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 423299, RefRangeEnd = 423303, XrefRangeStart = 423288, XrefRangeEnd = 423299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteCommandBuffer(CommandBuffer buffer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423303, XrefRangeEnd = 423311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetRenderTargetImpl(
    RenderBuffer colorBuffer,
    RenderBuffer depthBuffer,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &colorBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depthBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423311, XrefRangeEnd = 423320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetRenderTargetImpl(
    RenderTexture rt,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rt);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423332, RefRangeEnd = 423334, XrefRangeStart = 423320, XrefRangeEnd = 423332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetRenderTarget(
    RenderTexture rt,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rt);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423348, RefRangeEnd = 423349, XrefRangeStart = 423334, XrefRangeEnd = 423348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTexture(
    Texture src,
    int srcElement,
    int srcMip,
    Texture dst,
    int dstElement,
    int dstMip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dst);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 423363, RefRangeEnd = 423375, XrefRangeStart = 423349, XrefRangeEnd = 423363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTexture(
    Texture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    Texture dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &srcY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &srcHeight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dst);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dstX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &dstY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423375, XrefRangeEnd = 423406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &matrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) properties);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &castShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &receiveShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) probeAnchor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeUsage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightProbeProxyVolume);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 423432, RefRangeEnd = 423435, XrefRangeStart = 423406, XrefRangeEnd = 423432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) matrices);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) properties);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &castShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &receiveShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeUsage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightProbeProxyVolume);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423450, RefRangeEnd = 423451, XrefRangeStart = 423435, XrefRangeEnd = 423450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Blit(Texture source, RenderTexture dest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423451, XrefRangeEnd = 423473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Blit(Texture source, RenderTexture dest, Material mat, int pass)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pass;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423496, RefRangeEnd = 423497, XrefRangeStart = 423473, XrefRangeEnd = 423496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Blit(Texture source, RenderTexture dest, Material mat)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mat);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423530, RefRangeEnd = 423531, XrefRangeStart = 423497, XrefRangeEnd = 423530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Material_Int32_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 423535, RefRangeEnd = 423538, XrefRangeStart = 423531, XrefRangeEnd = 423535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetRenderTarget(RenderTexture rt)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rt)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423542, RefRangeEnd = 423543, XrefRangeStart = 423538, XrefRangeEnd = 423542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetRenderTarget(RenderTexture rt, int mipLevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rt);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423543, XrefRangeEnd = 423545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SetRTSimple_Injected(
    [In] ref RenderBuffer color,
    [In] ref RenderBuffer depth,
    int mip,
    CubemapFace face,
    int depthSlice)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423545, XrefRangeEnd = 423547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTexture_Slice_Injected(
    System.IntPtr src,
    int srcElement,
    int srcMip,
    System.IntPtr dst,
    int dstElement,
    int dstMip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dst;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Slice_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423547, XrefRangeEnd = 423549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTexture_Region_Injected(
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    System.IntPtr dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &srcY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &srcHeight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &dst;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dstX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &dstY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Region_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423549, XrefRangeEnd = 423551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_DrawMesh_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    [In] ref Matrix4x4 matrix,
    System.IntPtr material,
    int layer,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    System.IntPtr probeAnchor,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = (System.IntPtr) &mesh;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref matrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &material;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &properties;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &castShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &receiveShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &probeAnchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeUsage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeProxyVolume;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_IntPtr_Int32_IntPtr_IntPtr_ShadowCastingMode_Boolean_IntPtr_LightProbeUsage_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423551, XrefRangeEnd = 423553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_DrawMeshInstanced_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    ref ManagedSpanWrapper matrices,
    int count,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = (System.IntPtr) &mesh;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &material;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref matrices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &properties;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &castShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &receiveShadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &camera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeUsage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &lightProbeProxyVolume;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMeshInstanced_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_byref_ManagedSpanWrapper_Int32_IntPtr_ShadowCastingMode_Boolean_Int32_IntPtr_LightProbeUsage_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423553, XrefRangeEnd = 423555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_BlitMaterial5_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dest;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &setRT;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423555, XrefRangeEnd = 423557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Blit2_Injected(System.IntPtr source, System.IntPtr dest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &source;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dest;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit2_Injected_Private_Static_Void_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423557, XrefRangeEnd = 423559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteCommandBuffer_Injected(System.IntPtr buffer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buffer
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_ExecuteCommandBuffer_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kMaxDrawMeshInstanceCount
  {
    get
    {
      int meshInstanceCount;
      IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*) &meshInstanceCount);
      return meshInstanceCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*) &value);
    }
  }

  public static unsafe Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<int, RenderInstancedDataLayout>) null : Il2CppObjectPool.Get<Dictionary<int, RenderInstancedDataLayout>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_s_RenderInstancedDataLayouts, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static ColorGamut GetActiveColorGamut() => Graphics.GetActiveColorGamutDelegateField();

  public static ColorGamut activeColorGamut => Graphics.GetActiveColorGamut();

  public static bool GetPreserveFramebufferAlpha()
  {
    return Graphics.GetPreserveFramebufferAlphaDelegateField();
  }

  public static bool preserveFramebufferAlpha => Graphics.GetPreserveFramebufferAlpha();

  public static OpenGLESVersion GetMinOpenGLESVersion()
  {
    return Graphics.GetMinOpenGLESVersionDelegateField();
  }

  public static OpenGLESVersion minOpenGLESVersion => Graphics.GetMinOpenGLESVersion();

  public static RenderBuffer GetActiveColorBuffer()
  {
    RenderBuffer ret;
    Graphics.GetActiveColorBuffer_Injected(out ret);
    return ret;
  }

  public static RenderBuffer GetActiveDepthBuffer()
  {
    RenderBuffer ret;
    Graphics.GetActiveDepthBuffer_Injected(out ret);
    return ret;
  }

  public static void Internal_SetGfxRT(
    GraphicsTexture gfxTex,
    int mip,
    CubemapFace face,
    int depthSlice)
  {
    Graphics.Internal_SetGfxRT_Injected(gfxTex == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(gfxTex), mip, face, depthSlice);
  }

  public static unsafe void Internal_SetMRTSimple(
    Il2CppStructArray<RenderBuffer> color,
    RenderBuffer depth,
    int mip,
    CubemapFace face,
    int depthSlice)
  {
    if (color == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) color, nameof (color));
    Il2CppSystem.Span<RenderBuffer> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<RenderBuffer>) ref span).\u002Ector((Il2CppArrayBase<RenderBuffer>) color);
    fixed (RenderBuffer* begin = &((Il2CppSystem.Span<RenderBuffer>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper color1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<RenderBuffer>) ref span).Length);
      Graphics.Internal_SetMRTSimple_Injected(ref color1, ref depth, mip, face, depthSlice);
    }
  }

  public static unsafe void Internal_SetMRTFullSetup(
    Il2CppStructArray<RenderBuffer> color,
    RenderBuffer depth,
    int mip,
    CubemapFace face,
    int depthSlice,
    Il2CppStructArray<RenderBufferLoadAction> colorLA,
    Il2CppStructArray<RenderBufferStoreAction> colorSA,
    RenderBufferLoadAction depthLA,
    RenderBufferStoreAction depthSA)
  {
    if (color == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) color, nameof (color));
    if (colorLA == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) colorLA, nameof (colorLA));
    if (colorSA == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) colorSA, nameof (colorSA));
    Il2CppSystem.Span<RenderBuffer> span1;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<RenderBuffer>) ref span1).\u002Ector((Il2CppArrayBase<RenderBuffer>) color);
    fixed (RenderBuffer* begin1 = &((Il2CppSystem.Span<RenderBuffer>) ref span1).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin1, ((Il2CppSystem.Span<RenderBuffer>) ref span1).Length);
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ref RenderBuffer local2 = ref depth;
      int mip1 = mip;
      int face1 = (int) face;
      int depthSlice1 = depthSlice;
      Il2CppSystem.Span<RenderBufferLoadAction> span2;
      // ISSUE: explicit constructor call
      ((Il2CppSystem.Span<RenderBufferLoadAction>) ref span2).\u002Ector((Il2CppArrayBase<RenderBufferLoadAction>) colorLA);
      fixed (RenderBufferLoadAction* begin2 = &((Il2CppSystem.Span<RenderBufferLoadAction>) ref span2).GetPinnableReference())
      {
        ManagedSpanWrapper managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin2, ((Il2CppSystem.Span<RenderBufferLoadAction>) ref span2).Length);
        ref ManagedSpanWrapper local3 = ref managedSpanWrapper2;
        Il2CppSystem.Span<RenderBufferStoreAction> span3;
        // ISSUE: explicit constructor call
        ((Il2CppSystem.Span<RenderBufferStoreAction>) ref span3).\u002Ector((Il2CppArrayBase<RenderBufferStoreAction>) colorSA);
        fixed (RenderBufferStoreAction* begin3 = &((Il2CppSystem.Span<RenderBufferStoreAction>) ref span3).GetPinnableReference())
        {
          ManagedSpanWrapper managedSpanWrapper3 = new ManagedSpanWrapper((void*) begin3, ((Il2CppSystem.Span<RenderBufferStoreAction>) ref span3).Length);
          ref ManagedSpanWrapper local4 = ref managedSpanWrapper3;
          int depthLA1 = (int) depthLA;
          int depthSA1 = (int) depthSA;
          Graphics.Internal_SetMRTFullSetup_Injected(ref local1, ref local2, mip1, (CubemapFace) face1, depthSlice1, ref local3, ref local4, (RenderBufferLoadAction) depthLA1, (RenderBufferStoreAction) depthSA1);
        }
      }
    }
  }

  public static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav)
  {
    Graphics.Internal_SetRandomWriteTargetRT_Injected(index, Object.MarshalledUnityObject.Marshal<RenderTexture>(uav));
  }

  public static void Internal_SetRandomWriteTargetBuffer(
    int index,
    ComputeBuffer uav,
    bool preserveCounterValue)
  {
    Graphics.Internal_SetRandomWriteTargetBuffer_Injected(index, uav == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(uav), preserveCounterValue);
  }

  public static void Internal_SetRandomWriteTargetGraphicsBuffer(
    int index,
    GraphicsBuffer uav,
    bool preserveCounterValue)
  {
    Graphics.Internal_SetRandomWriteTargetGraphicsBuffer_Injected(index, uav == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(uav), preserveCounterValue);
  }

  public static void CopyTexture_Full(Texture src, Texture dst)
  {
    Graphics.CopyTexture_Full_Injected(Object.MarshalledUnityObject.Marshal<Texture>(src), Object.MarshalledUnityObject.Marshal<Texture>(dst));
  }

  public static void CopyTexture_Slice_AllMips(
    Texture src,
    int srcElement,
    Texture dst,
    int dstElement)
  {
    Graphics.CopyTexture_Slice_AllMips_Injected(Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, Object.MarshalledUnityObject.Marshal<Texture>(dst), dstElement);
  }

  public static void CopyTexture_Full_Gfx(GraphicsTexture src, GraphicsTexture dst)
  {
    Graphics.CopyTexture_Full_Gfx_Injected(src == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst));
  }

  public static void CopyTexture_Slice_AllMips_Gfx(
    GraphicsTexture src,
    int srcElement,
    GraphicsTexture dst,
    int dstElement)
  {
    Graphics.CopyTexture_Slice_AllMips_Gfx_Injected(src == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, dst == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement);
  }

  public static void CopyTexture_Slice_Gfx(
    GraphicsTexture src,
    int srcElement,
    int srcMip,
    GraphicsTexture dst,
    int dstElement,
    int dstMip)
  {
    Graphics.CopyTexture_Slice_Gfx_Injected(src == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, srcMip, dst == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement, dstMip);
  }

  public static void CopyTexture_Region_Gfx(
    GraphicsTexture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    GraphicsTexture dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    Graphics.CopyTexture_Region_Gfx_Injected(src == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement, dstMip, dstX, dstY);
  }

  public static bool ConvertTexture_Full(Texture src, Texture dst)
  {
    return Graphics.ConvertTexture_Full_Injected(Object.MarshalledUnityObject.Marshal<Texture>(src), Object.MarshalledUnityObject.Marshal<Texture>(dst));
  }

  public static bool ConvertTexture_Slice(
    Texture src,
    int srcElement,
    Texture dst,
    int dstElement)
  {
    return Graphics.ConvertTexture_Slice_Injected(Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, Object.MarshalledUnityObject.Marshal<Texture>(dst), dstElement);
  }

  public static bool ConvertTexture_Full_Gfx(GraphicsTexture src, GraphicsTexture dst)
  {
    return Graphics.ConvertTexture_Full_Gfx_Injected(src == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), dst == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst));
  }

  public static bool ConvertTexture_Slice_Gfx(
    GraphicsTexture src,
    int srcElement,
    GraphicsTexture dst,
    int dstElement)
  {
    return Graphics.ConvertTexture_Slice_Gfx_Injected(src == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, dst == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement);
  }

  public static void CopyBufferImpl(GraphicsBuffer source, GraphicsBuffer dest)
  {
    if (source == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) source, nameof (source));
    if (dest == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) dest, nameof (dest));
    System.IntPtr native1 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(source);
    if (native1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) source, nameof (source));
    System.IntPtr native2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(dest);
    if (native2 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) dest, nameof (dest));
    Graphics.CopyBufferImpl_Injected(native1, native2);
  }

  public static void Internal_DrawMeshNow1(
    Mesh mesh,
    int subsetIndex,
    Vector3 position,
    Quaternion rotation)
  {
    if (mesh == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    System.IntPtr mesh1 = Object.MarshalledUnityObject.MarshalNotNull<Mesh>(mesh);
    if (mesh1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    Graphics.Internal_DrawMeshNow1_Injected(mesh1, subsetIndex, ref position, ref rotation);
  }

  public static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
  {
    if (mesh == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    System.IntPtr mesh1 = Object.MarshalledUnityObject.MarshalNotNull<Mesh>(mesh);
    if (mesh1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    Graphics.Internal_DrawMeshNow2_Injected(mesh1, subsetIndex, ref matrix);
  }

  public static void Internal_DrawMeshInstancedProcedural(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    if (mesh == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    if (material == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) material, nameof (material));
    System.IntPtr mesh1 = Object.MarshalledUnityObject.MarshalNotNull<Mesh>(mesh);
    if (mesh1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    int submeshIndex1 = submeshIndex;
    System.IntPtr material1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(material);
    if (material1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) material, nameof (material));
    ref Bounds local = ref bounds;
    int count1 = count;
    System.IntPtr properties1 = properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties);
    int castShadows1 = (int) castShadows;
    int num1 = receiveShadows ? 1 : 0;
    int layer1 = layer;
    System.IntPtr camera1 = Object.MarshalledUnityObject.Marshal<Camera>(camera);
    int num2 = (int) lightProbeUsage;
    System.IntPtr lightProbeProxyVolume1 = Object.MarshalledUnityObject.Marshal<LightProbeProxyVolume>(lightProbeProxyVolume);
    Graphics.Internal_DrawMeshInstancedProcedural_Injected(mesh1, submeshIndex1, material1, ref local, count1, properties1, (ShadowCastingMode) castShadows1, num1 != 0, layer1, camera1, (LightProbeUsage) num2, lightProbeProxyVolume1);
  }

  public static void Internal_DrawMeshInstancedIndirect(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    ComputeBuffer bufferWithArgs,
    int argsOffset,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    if (mesh == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    if (material == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) material, nameof (material));
    System.IntPtr mesh1 = Object.MarshalledUnityObject.MarshalNotNull<Mesh>(mesh);
    if (mesh1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    int submeshIndex1 = submeshIndex;
    System.IntPtr material1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(material);
    if (material1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) material, nameof (material));
    ref Bounds local = ref bounds;
    System.IntPtr bufferWithArgs1 = bufferWithArgs == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs);
    int argsOffset1 = argsOffset;
    System.IntPtr properties1 = properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties);
    int castShadows1 = (int) castShadows;
    int num1 = receiveShadows ? 1 : 0;
    int layer1 = layer;
    System.IntPtr camera1 = Object.MarshalledUnityObject.Marshal<Camera>(camera);
    int num2 = (int) lightProbeUsage;
    System.IntPtr lightProbeProxyVolume1 = Object.MarshalledUnityObject.Marshal<LightProbeProxyVolume>(lightProbeProxyVolume);
    Graphics.Internal_DrawMeshInstancedIndirect_Injected(mesh1, submeshIndex1, material1, ref local, bufferWithArgs1, argsOffset1, properties1, (ShadowCastingMode) castShadows1, num1 != 0, layer1, camera1, (LightProbeUsage) num2, lightProbeProxyVolume1);
  }

  public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    GraphicsBuffer bufferWithArgs,
    int argsOffset,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    if (mesh == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    if (material == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) material, nameof (material));
    System.IntPtr mesh1 = Object.MarshalledUnityObject.MarshalNotNull<Mesh>(mesh);
    if (mesh1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mesh, nameof (mesh));
    int submeshIndex1 = submeshIndex;
    System.IntPtr material1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(material);
    if (material1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) material, nameof (material));
    ref Bounds local = ref bounds;
    System.IntPtr bufferWithArgs1 = bufferWithArgs == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs);
    int argsOffset1 = argsOffset;
    System.IntPtr properties1 = properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties);
    int castShadows1 = (int) castShadows;
    int num1 = receiveShadows ? 1 : 0;
    int layer1 = layer;
    System.IntPtr camera1 = Object.MarshalledUnityObject.Marshal<Camera>(camera);
    int num2 = (int) lightProbeUsage;
    System.IntPtr lightProbeProxyVolume1 = Object.MarshalledUnityObject.Marshal<LightProbeProxyVolume>(lightProbeProxyVolume);
    Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(mesh1, submeshIndex1, material1, ref local, bufferWithArgs1, argsOffset1, properties1, (ShadowCastingMode) castShadows1, num1 != 0, layer1, camera1, (LightProbeUsage) num2, lightProbeProxyVolume1);
  }

  public static void Internal_DrawProceduralNow(
    MeshTopology topology,
    int vertexCount,
    int instanceCount)
  {
    Graphics.Internal_DrawProceduralNowDelegateField(topology, vertexCount, instanceCount);
  }

  public static void Internal_DrawProceduralIndexedNow(
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    int indexCount,
    int instanceCount)
  {
    Graphics.Internal_DrawProceduralIndexedNow_Injected(topology, indexBuffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), indexCount, instanceCount);
  }

  public static void Internal_DrawProceduralIndirectNow(
    MeshTopology topology,
    ComputeBuffer bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndirectNow_Injected(topology, bufferWithArgs == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
  }

  public static void Internal_DrawProceduralIndexedIndirectNow(
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    ComputeBuffer bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndexedIndirectNow_Injected(topology, indexBuffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), bufferWithArgs == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
  }

  public static void Internal_DrawProceduralIndirectNowGraphicsBuffer(
    MeshTopology topology,
    GraphicsBuffer bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer_Injected(topology, bufferWithArgs == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
  }

  public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    GraphicsBuffer bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_Injected(topology, indexBuffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), bufferWithArgs == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
  }

  public static void Internal_DrawProcedural(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    int vertexCount,
    int instanceCount,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProcedural_Injected(Object.MarshalledUnityObject.Marshal<Material>(material), ref bounds, topology, vertexCount, instanceCount, Object.MarshalledUnityObject.Marshal<Camera>(camera), properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndexed(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    int indexCount,
    int instanceCount,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndexed_Injected(Object.MarshalledUnityObject.Marshal<Material>(material), ref bounds, topology, indexBuffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), indexCount, instanceCount, Object.MarshalledUnityObject.Marshal<Camera>(camera), properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndirect(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    ComputeBuffer bufferWithArgs,
    int argsOffset,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndirect_Injected(Object.MarshalledUnityObject.Marshal<Material>(material), ref bounds, topology, bufferWithArgs == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal<Camera>(camera), properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndirectGraphicsBuffer(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer bufferWithArgs,
    int argsOffset,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_Injected(Object.MarshalledUnityObject.Marshal<Material>(material), ref bounds, topology, bufferWithArgs == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal<Camera>(camera), properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndexedIndirect(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    ComputeBuffer bufferWithArgs,
    int argsOffset,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndexedIndirect_Injected(Object.MarshalledUnityObject.Marshal<Material>(material), ref bounds, topology, indexBuffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), bufferWithArgs == null ? System.IntPtr.Zero : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal<Camera>(camera), properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    GraphicsBuffer bufferWithArgs,
    int argsOffset,
    Camera camera,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(Object.MarshalledUnityObject.Marshal<Material>(material), ref bounds, topology, indexBuffer == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), bufferWithArgs == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal<Camera>(camera), properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
  }

  public static void Internal_BlitMaterial6(
    Texture source,
    RenderTexture dest,
    Material mat,
    int pass,
    bool setRT,
    int destDepthSlice)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = Object.MarshalledUnityObject.Marshal<RenderTexture>(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    int pass1 = pass;
    int num = setRT ? 1 : 0;
    int destDepthSlice1 = destDepthSlice;
    Graphics.Internal_BlitMaterial6_Injected(source1, dest1, mat1, pass1, num != 0, destDepthSlice1);
  }

  public static unsafe void Internal_BlitMultiTap4(
    Texture source,
    RenderTexture dest,
    Material mat,
    Il2CppStructArray<Vector2> offsets)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    if (offsets == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) offsets, nameof (offsets));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = Object.MarshalledUnityObject.Marshal<RenderTexture>(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    Il2CppSystem.Span<Vector2> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector2>) ref span).\u002Ector((Il2CppArrayBase<Vector2>) offsets);
    fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector2>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      Graphics.Internal_BlitMultiTap4_Injected(source1, dest1, mat1, ref local);
    }
  }

  public static unsafe void Internal_BlitMultiTap5(
    Texture source,
    RenderTexture dest,
    Material mat,
    Il2CppStructArray<Vector2> offsets,
    int destDepthSlice)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    if (offsets == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) offsets, nameof (offsets));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = Object.MarshalledUnityObject.Marshal<RenderTexture>(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    Il2CppSystem.Span<Vector2> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector2>) ref span).\u002Ector((Il2CppArrayBase<Vector2>) offsets);
    fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector2>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int destDepthSlice1 = destDepthSlice;
      Graphics.Internal_BlitMultiTap5_Injected(source1, dest1, mat1, ref local, destDepthSlice1);
    }
  }

  public static void Blit3(
    Texture source,
    RenderTexture dest,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.Blit3_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), Object.MarshalledUnityObject.Marshal<RenderTexture>(dest), sourceDepthSlice, destDepthSlice);
  }

  public static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
  {
    Graphics.Blit4_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), Object.MarshalledUnityObject.Marshal<RenderTexture>(dest), ref scale, ref offset);
  }

  public static void Blit5(
    Texture source,
    RenderTexture dest,
    Vector2 scale,
    Vector2 offset,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.Blit5_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), Object.MarshalledUnityObject.Marshal<RenderTexture>(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
  }

  public static void Internal_BlitMaterialGfx5(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    int pass,
    bool setRT)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    int pass1 = pass;
    int num = setRT ? 1 : 0;
    Graphics.Internal_BlitMaterialGfx5_Injected(source1, dest1, mat1, pass1, num != 0);
  }

  public static void Internal_BlitMaterialGfx6(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    int pass,
    bool setRT,
    int destDepthSlice)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    int pass1 = pass;
    int num = setRT ? 1 : 0;
    int destDepthSlice1 = destDepthSlice;
    Graphics.Internal_BlitMaterialGfx6_Injected(source1, dest1, mat1, pass1, num != 0, destDepthSlice1);
  }

  public static unsafe void Internal_BlitMultiTapGfx4(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    Il2CppStructArray<Vector2> offsets)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    if (offsets == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) offsets, nameof (offsets));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    Il2CppSystem.Span<Vector2> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector2>) ref span).\u002Ector((Il2CppArrayBase<Vector2>) offsets);
    fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector2>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      Graphics.Internal_BlitMultiTapGfx4_Injected(source1, dest1, mat1, ref local);
    }
  }

  public static unsafe void Internal_BlitMultiTapGfx5(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    Il2CppStructArray<Vector2> offsets,
    int destDepthSlice)
  {
    if (mat == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    if (offsets == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) offsets, nameof (offsets));
    System.IntPtr source1 = Object.MarshalledUnityObject.Marshal<Texture>(source);
    System.IntPtr dest1 = dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest);
    System.IntPtr mat1 = Object.MarshalledUnityObject.MarshalNotNull<Material>(mat);
    if (mat1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) mat, nameof (mat));
    Il2CppSystem.Span<Vector2> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector2>) ref span).\u002Ector((Il2CppArrayBase<Vector2>) offsets);
    fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector2>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int destDepthSlice1 = destDepthSlice;
      Graphics.Internal_BlitMultiTapGfx5_Injected(source1, dest1, mat1, ref local, destDepthSlice1);
    }
  }

  public static void BlitGfx2(Texture source, GraphicsTexture dest)
  {
    Graphics.BlitGfx2_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest));
  }

  public static void BlitGfx3(
    Texture source,
    GraphicsTexture dest,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.BlitGfx3_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest), sourceDepthSlice, destDepthSlice);
  }

  public static void BlitGfx4(Texture source, GraphicsTexture dest, Vector2 scale, Vector2 offset)
  {
    Graphics.BlitGfx4_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest), ref scale, ref offset);
  }

  public static void BlitGfx5(
    Texture source,
    GraphicsTexture dest,
    Vector2 scale,
    Vector2 offset,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.BlitGfx5_Injected(Object.MarshalledUnityObject.Marshal<Texture>(source), dest == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
  }

  public static System.IntPtr CreateGPUFenceImpl(
    GraphicsFenceType fenceType,
    SynchronisationStageFlags stage)
  {
    return Graphics.CreateGPUFenceImplDelegateField(fenceType, stage);
  }

  public static void WaitOnGPUFenceImpl(System.IntPtr fencePtr, SynchronisationStageFlags stage)
  {
    Graphics.WaitOnGPUFenceImplDelegateField(fencePtr, stage);
  }

  public static void ExecuteCommandBufferAsync(CommandBuffer buffer, ComputeQueueType queueType)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr native = CommandBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    Graphics.ExecuteCommandBufferAsync_Injected(native, queueType);
  }

  public static void CheckLoadActionValid(RenderBufferLoadAction load, string bufferType)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void CheckStoreActionValid(RenderBufferStoreAction store, string bufferType)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void SetRenderTargetImpl(
    GraphicsTexture rt,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    if (rt != null)
      Graphics.Internal_SetGfxRT(rt, mipLevel, face, depthSlice);
    else
      Graphics.Internal_SetNullRT();
  }

  public static void SetRenderTargetImpl(
    Il2CppStructArray<RenderBuffer> colorBuffers,
    RenderBuffer depthBuffer,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    RenderBuffer depth = depthBuffer;
    Graphics.Internal_SetMRTSimple(colorBuffers, depth, mipLevel, face, depthSlice);
  }

  public static void SetRenderTarget(
    GraphicsTexture rt,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    Graphics.SetRenderTargetImpl(rt, mipLevel, face, depthSlice);
  }

  public static void SetRenderTarget(
    RenderBuffer colorBuffer,
    RenderBuffer depthBuffer,
    int mipLevel,
    CubemapFace face,
    int depthSlice)
  {
    Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
  }

  public static void SetRenderTarget(
    Il2CppStructArray<RenderBuffer> colorBuffers,
    RenderBuffer depthBuffer)
  {
    Graphics.SetRenderTargetImpl(colorBuffers, depthBuffer, 0, CubemapFace.Unknown, 0);
  }

  public static RenderBuffer activeColorBuffer => Graphics.GetActiveColorBuffer();

  public static RenderBuffer activeDepthBuffer => Graphics.GetActiveDepthBuffer();

  public static void SetRandomWriteTarget(int index, RenderTexture uav)
  {
    if (index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (index), Il2CppSystem.String.Format("must be non-negative less than {0}.", (Il2CppSystem.Object) (System.ValueType) SystemInfo.supportedRandomWriteTargetCount));
    Graphics.Internal_SetRandomWriteTargetRT(index, uav);
  }

  public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue)
  {
    if (uav == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (uav));
    if (uav.m_Ptr == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ObjectDisposedException(nameof (uav));
    if (index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (index), Il2CppSystem.String.Format("must be non-negative less than {0}.", (Il2CppSystem.Object) (System.ValueType) SystemInfo.supportedRandomWriteTargetCount));
    Graphics.Internal_SetRandomWriteTargetBuffer(index, uav, preserveCounterValue);
  }

  public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue)
  {
    if (uav == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (uav));
    if (uav.m_Ptr == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ObjectDisposedException(nameof (uav));
    if (index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (index), Il2CppSystem.String.Format("must be non-negative less than {0}.", (Il2CppSystem.Object) (System.ValueType) SystemInfo.supportedRandomWriteTargetCount));
    Graphics.Internal_SetRandomWriteTargetGraphicsBuffer(index, uav, preserveCounterValue);
  }

  public static void CopyTexture(Texture src, Texture dst) => Graphics.CopyTexture_Full(src, dst);

  public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
  {
    Graphics.CopyTexture_Slice_AllMips(src, srcElement, dst, dstElement);
  }

  public static void CopyTexture(GraphicsTexture src, GraphicsTexture dst)
  {
    Graphics.CopyTexture_Full_Gfx(src, dst);
  }

  public static void CopyTexture(
    GraphicsTexture src,
    int srcElement,
    GraphicsTexture dst,
    int dstElement)
  {
    Graphics.CopyTexture_Slice_AllMips_Gfx(src, srcElement, dst, dstElement);
  }

  public static void CopyTexture(
    GraphicsTexture src,
    int srcElement,
    int srcMip,
    GraphicsTexture dst,
    int dstElement,
    int dstMip)
  {
    Graphics.CopyTexture_Slice_Gfx(src, srcElement, srcMip, dst, dstElement, dstMip);
  }

  public static void CopyTexture(
    GraphicsTexture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    GraphicsTexture dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    Graphics.CopyTexture_Region_Gfx(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
  }

  public static bool ConvertTexture(Texture src, Texture dst)
  {
    return Graphics.ConvertTexture_Full(src, dst);
  }

  public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
  {
    return Graphics.ConvertTexture_Slice(src, srcElement, dst, dstElement);
  }

  public static bool ConvertTexture(GraphicsTexture src, GraphicsTexture dst)
  {
    return Graphics.ConvertTexture_Full_Gfx(src, dst);
  }

  public static bool ConvertTexture(
    GraphicsTexture src,
    int srcElement,
    GraphicsTexture dst,
    int dstElement)
  {
    return Graphics.ConvertTexture_Slice_Gfx(src, srcElement, dst, dstElement);
  }

  public static GraphicsFence CreateAsyncGraphicsFence(SynchronisationStage stage)
  {
    return Graphics.CreateGraphicsFence(GraphicsFenceType.AsyncQueueSynchronisation, GraphicsFence.TranslateSynchronizationStageToFlags(stage));
  }

  public static GraphicsFence CreateAsyncGraphicsFence()
  {
    return Graphics.CreateGraphicsFence(GraphicsFenceType.AsyncQueueSynchronisation, SynchronisationStageFlags.PixelProcessing);
  }

  public static GraphicsFence CreateGraphicsFence(
    GraphicsFenceType fenceType,
    SynchronisationStageFlags stage)
  {
    GraphicsFence graphicsFence = new GraphicsFence();
    graphicsFence.m_FenceType = fenceType;
    graphicsFence.m_Ptr = Graphics.CreateGPUFenceImpl(fenceType, stage);
    graphicsFence.InitPostAllocation();
    graphicsFence.Validate();
    return graphicsFence;
  }

  public static void WaitOnAsyncGraphicsFence(GraphicsFence fence)
  {
    Graphics.WaitOnAsyncGraphicsFence(fence, SynchronisationStage.PixelProcessing);
  }

  public static void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage)
  {
    if (fence.m_FenceType != 0)
      throw new Il2CppSystem.ArgumentException("Graphics.WaitOnGraphicsFence can only be called with fences created with GraphicsFenceType.AsyncQueueSynchronization.");
    fence.Validate();
    if (!fence.IsFencePending())
      return;
    Graphics.WaitOnGPUFenceImpl(fence.m_Ptr, GraphicsFence.TranslateSynchronizationStageToFlags(stage));
  }

  public static void ValidateCopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
  {
    if (source == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (source));
    if (dest == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (dest));
    long num1 = (long) source.count * (long) source.stride;
    long num2 = (long) dest.count * (long) dest.stride;
    if (num1 != num2)
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("CopyBuffer source and destination buffers must be the same size, source was {0} bytes, dest was {1} bytes", (Il2CppSystem.Object) (System.ValueType) num1, (Il2CppSystem.Object) (System.ValueType) num2));
    if ((source.target & GraphicsBuffer.Target.CopySource) == (GraphicsBuffer.Target) 0)
      throw new Il2CppSystem.ArgumentException("CopyBuffer source must have CopySource target", nameof (source));
    if ((dest.target & GraphicsBuffer.Target.CopyDestination) == (GraphicsBuffer.Target) 0)
      throw new Il2CppSystem.ArgumentException("CopyBuffer destination must have CopyDestination target", nameof (dest));
  }

  public static void CopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
  {
    Graphics.ValidateCopyBuffer(source, dest);
    Graphics.CopyBufferImpl(source, dest);
  }

  public static void DrawTextureImpl(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Color color,
    Material mat,
    int pass)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Color color,
    Material mat,
    int pass)
  {
    Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Material mat,
    int pass)
  {
    Color32 color32 = new Color32((byte) 128 /*0x80*/, (byte) 128 /*0x80*/, (byte) 128 /*0x80*/, (byte) 128 /*0x80*/);
    Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, (Color) color32, mat, pass);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Material mat,
    int pass)
  {
    Graphics.DrawTexture(screenRect, texture, new Rect(0.0f, 0.0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
  }

  public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass)
  {
    Graphics.DrawTexture(screenRect, texture, 0, 0, 0, 0, mat, pass);
  }

  public static RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(Il2CppSystem.Type type)
  {
    int hashCode = type.GetHashCode();
    RenderInstancedDataLayout instancedDataLayout;
    if (!Graphics.s_RenderInstancedDataLayouts.TryGetValue(hashCode, out instancedDataLayout))
    {
      instancedDataLayout = new RenderInstancedDataLayout(type);
      Graphics.s_RenderInstancedDataLayouts.Add(hashCode, instancedDataLayout);
    }
    return instancedDataLayout;
  }

  public static void DrawMeshNow(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    int materialIndex)
  {
    if ((Object) mesh == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (mesh));
    Graphics.Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
  }

  public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
  {
    if ((Object) mesh == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (mesh));
    Graphics.Internal_DrawMeshNow2(mesh, materialIndex, matrix);
  }

  public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
  {
    Graphics.DrawMeshNow(mesh, position, rotation, -1);
  }

  public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
  {
    Graphics.DrawMeshNow(mesh, matrix, -1);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    bool castShadows,
    bool receiveShadows,
    bool useLightProbes)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, (Transform) null, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor,
    bool useLightProbes)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    bool castShadows,
    bool receiveShadows,
    bool useLightProbes)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, (Transform) null, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    if (matrices == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (matrices));
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, (Il2CppStructArray<Matrix4x4>) NoAllocHelpers.ExtractArrayFromList<Matrix4x4>(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void DrawMeshInstancedProcedural(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    int count,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int),
    Camera camera = null,
    LightProbeUsage lightProbeUsage = default (LightProbeUsage),
    LightProbeProxyVolume lightProbeProxyVolume = null)
  {
    if (!SystemInfo.supportsInstancing)
      throw new Il2CppSystem.InvalidOperationException("Instancing is not supported.");
    if ((Object) mesh == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (mesh));
    if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (submeshIndex), "submeshIndex out of range.");
    if ((Object) material == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (material));
    if (count <= 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (count));
    if (lightProbeUsage == LightProbeUsage.UseProxyVolume && (Object) lightProbeProxyVolume == (Object) null)
      throw new Il2CppSystem.ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", nameof (lightProbeProxyVolume));
    if (count <= 0)
      return;
    Graphics.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void DrawMeshInstancedIndirect(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    ComputeBuffer bufferWithArgs,
    int argsOffset,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    if (!SystemInfo.supportsInstancing)
      throw new Il2CppSystem.InvalidOperationException("Instancing is not supported.");
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if ((Object) mesh == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (mesh));
    if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (submeshIndex), "submeshIndex out of range.");
    if ((Object) material == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (material));
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    if (lightProbeUsage == LightProbeUsage.UseProxyVolume && (Object) lightProbeProxyVolume == (Object) null)
      throw new Il2CppSystem.ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", nameof (lightProbeProxyVolume));
    Graphics.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void DrawMeshInstancedIndirect(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    GraphicsBuffer bufferWithArgs,
    int argsOffset,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage,
    LightProbeProxyVolume lightProbeProxyVolume)
  {
    if (!SystemInfo.supportsInstancing)
      throw new Il2CppSystem.InvalidOperationException("Instancing is not supported.");
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if ((Object) mesh == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (mesh));
    if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (submeshIndex), "submeshIndex out of range.");
    if ((Object) material == (Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (material));
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    if (lightProbeUsage == LightProbeUsage.UseProxyVolume && (Object) lightProbeProxyVolume == (Object) null)
      throw new Il2CppSystem.ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", nameof (lightProbeProxyVolume));
    Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount = default (int))
  {
    Graphics.Internal_DrawProceduralNow(topology, vertexCount, instanceCount);
  }

  public static void DrawProceduralNow(
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    int indexCount,
    int instanceCount = default (int))
  {
    if (indexBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indexBuffer));
    Graphics.Internal_DrawProceduralIndexedNow(topology, indexBuffer, indexCount, instanceCount);
  }

  public static void DrawProceduralIndirectNow(
    MeshTopology topology,
    ComputeBuffer bufferWithArgs,
    int argsOffset = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
  }

  public static void DrawProceduralIndirectNow(
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    ComputeBuffer bufferWithArgs,
    int argsOffset = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (indexBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indexBuffer));
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndexedIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
  }

  public static void DrawProceduralIndirectNow(
    MeshTopology topology,
    GraphicsBuffer bufferWithArgs,
    int argsOffset = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer(topology, bufferWithArgs, argsOffset);
  }

  public static void DrawProceduralIndirectNow(
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    GraphicsBuffer bufferWithArgs,
    int argsOffset = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (indexBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indexBuffer));
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(topology, indexBuffer, bufferWithArgs, argsOffset);
  }

  public static void DrawProcedural(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    int vertexCount,
    int instanceCount = default (int),
    Camera camera = null,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int))
  {
    Graphics.Internal_DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void DrawProcedural(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    int indexCount,
    int instanceCount = default (int),
    Camera camera = null,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int))
  {
    if (indexBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indexBuffer));
    Graphics.Internal_DrawProceduralIndexed(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void DrawProceduralIndirect(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    ComputeBuffer bufferWithArgs,
    int argsOffset = default (int),
    Camera camera = null,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void DrawProceduralIndirect(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer bufferWithArgs,
    int argsOffset = default (int),
    Camera camera = null,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndirectGraphicsBuffer(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void DrawProceduralIndirect(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    ComputeBuffer bufferWithArgs,
    int argsOffset = default (int),
    Camera camera = null,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (indexBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indexBuffer));
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndexedIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void DrawProceduralIndirect(
    Material material,
    Bounds bounds,
    MeshTopology topology,
    GraphicsBuffer indexBuffer,
    GraphicsBuffer bufferWithArgs,
    int argsOffset = default (int),
    Camera camera = null,
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int))
  {
    if (!SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    if (indexBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indexBuffer));
    if (bufferWithArgs == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (bufferWithArgs));
    Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Blit(
    Texture source,
    RenderTexture dest,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.Blit3(source, dest, sourceDepthSlice, destDepthSlice);
  }

  public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
  {
    Graphics.Blit4(source, dest, scale, offset);
  }

  public static void Blit(
    Texture source,
    RenderTexture dest,
    Vector2 scale,
    Vector2 offset,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.Blit5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
  }

  public static void Blit(
    Texture source,
    RenderTexture dest,
    Material mat,
    int pass,
    int destDepthSlice)
  {
    Graphics.Internal_BlitMaterial6(source, dest, mat, pass, true, destDepthSlice);
  }

  public static void Blit(Texture source, Material mat, int pass)
  {
    Graphics.Internal_BlitMaterial5(source, (RenderTexture) null, mat, pass, false);
  }

  public static void Blit(Texture source, Material mat, int pass, int destDepthSlice)
  {
    Graphics.Internal_BlitMaterial6(source, (RenderTexture) null, mat, pass, false, destDepthSlice);
  }

  public static void Blit(Texture source, Material mat) => Graphics.Blit(source, mat, -1);

  public static void BlitMultiTap(
    Texture source,
    RenderTexture dest,
    Material mat,
    Il2CppStructArray<Vector2> offsets)
  {
    if (((Il2CppArrayBase) offsets).Length == 0)
      throw new Il2CppSystem.ArgumentException("empty offsets list passed.", nameof (offsets));
    Graphics.Internal_BlitMultiTap4(source, dest, mat, offsets);
  }

  public static void BlitMultiTap(
    Texture source,
    RenderTexture dest,
    Material mat,
    params Vector2[] offsets)
  {
    Graphics.BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
  }

  public static void BlitMultiTap(
    Texture source,
    RenderTexture dest,
    Material mat,
    int destDepthSlice,
    Il2CppStructArray<Vector2> offsets)
  {
    if (((Il2CppArrayBase) offsets).Length == 0)
      throw new Il2CppSystem.ArgumentException("empty offsets list passed.", nameof (offsets));
    Graphics.Internal_BlitMultiTap5(source, dest, mat, offsets, destDepthSlice);
  }

  public static void BlitMultiTap(
    Texture source,
    RenderTexture dest,
    Material mat,
    int destDepthSlice,
    params Vector2[] offsets)
  {
    Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
  }

  public static void Blit(Texture source, GraphicsTexture dest) => Graphics.BlitGfx2(source, dest);

  public static void Blit(
    Texture source,
    GraphicsTexture dest,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.BlitGfx3(source, dest, sourceDepthSlice, destDepthSlice);
  }

  public static void Blit(Texture source, GraphicsTexture dest, Vector2 scale, Vector2 offset)
  {
    Graphics.BlitGfx4(source, dest, scale, offset);
  }

  public static void Blit(
    Texture source,
    GraphicsTexture dest,
    Vector2 scale,
    Vector2 offset,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.BlitGfx5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
  }

  public static void Blit(Texture source, GraphicsTexture dest, Material mat, int pass)
  {
    Graphics.Internal_BlitMaterialGfx5(source, dest, mat, pass, true);
  }

  public static void Blit(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    int pass,
    int destDepthSlice)
  {
    Graphics.Internal_BlitMaterialGfx6(source, dest, mat, pass, true, destDepthSlice);
  }

  public static void Blit(Texture source, GraphicsTexture dest, Material mat)
  {
    Graphics.Blit(source, dest, mat, -1);
  }

  public static void BlitMultiTap(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    Il2CppStructArray<Vector2> offsets)
  {
    if (((Il2CppArrayBase) offsets).Length == 0)
      throw new Il2CppSystem.ArgumentException("empty offsets list passed.", nameof (offsets));
    Graphics.Internal_BlitMultiTapGfx4(source, dest, mat, offsets);
  }

  public static void BlitMultiTap(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    params Vector2[] offsets)
  {
    Graphics.BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
  }

  public static void BlitMultiTap(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    int destDepthSlice,
    Il2CppStructArray<Vector2> offsets)
  {
    if (((Il2CppArrayBase) offsets).Length == 0)
      throw new Il2CppSystem.ArgumentException("empty offsets list passed.", nameof (offsets));
    Graphics.Internal_BlitMultiTapGfx5(source, dest, mat, offsets, destDepthSlice);
  }

  public static void BlitMultiTap(
    Texture source,
    GraphicsTexture dest,
    Material mat,
    int destDepthSlice,
    params Vector2[] offsets)
  {
    Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, (Camera) null, 0, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    bool castShadows)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    bool castShadows,
    bool receiveShadows)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor)
  {
    Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, (Camera) null, 0, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, 0, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, ShadowCastingMode.On, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    bool castShadows)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    bool castShadows,
    bool receiveShadows)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, true, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, (Transform) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor,
    bool useLightProbes)
  {
    Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, (LightProbeProxyVolume) null);
  }

  public static void DrawMesh(
    Mesh mesh,
    Matrix4x4 matrix,
    Material material,
    int layer,
    Camera camera,
    int submeshIndex,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    Transform probeAnchor,
    LightProbeUsage lightProbeUsage)
  {
    Graphics.Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, ((Il2CppArrayBase) matrices).Length, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, ShadowCastingMode.On, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Il2CppStructArray<Matrix4x4> matrices,
    int count,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, (MaterialPropertyBlock) null, ShadowCastingMode.On, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, ShadowCastingMode.On, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, true, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, 0, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, (Camera) null, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, LightProbeUsage.BlendProbes, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstanced(
    Mesh mesh,
    int submeshIndex,
    Material material,
    List<Matrix4x4> matrices,
    MaterialPropertyBlock properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    Camera camera,
    LightProbeUsage lightProbeUsage)
  {
    Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstancedIndirect(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    ComputeBuffer bufferWithArgs,
    int argsOffset = default (int),
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int),
    Camera camera = null,
    LightProbeUsage lightProbeUsage = default (LightProbeUsage))
  {
    Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, (LightProbeProxyVolume) null);
  }

  public static void DrawMeshInstancedIndirect(
    Mesh mesh,
    int submeshIndex,
    Material material,
    Bounds bounds,
    GraphicsBuffer bufferWithArgs,
    int argsOffset = default (int),
    MaterialPropertyBlock properties = null,
    ShadowCastingMode castShadows = default (ShadowCastingMode),
    bool receiveShadows = default (bool),
    int layer = default (int),
    Camera camera = null,
    LightProbeUsage lightProbeUsage = default (LightProbeUsage))
  {
    Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, (LightProbeProxyVolume) null);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Color color,
    Material mat)
  {
    Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, -1);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Color color)
  {
    Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, (Material) null, -1);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Material mat)
  {
    Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    Rect sourceRect,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder)
  {
    Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, (Material) null, -1);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Material mat)
  {
    Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
  }

  public static void DrawTexture(
    Rect screenRect,
    Texture texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder)
  {
    Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, (Material) null, -1);
  }

  public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
  {
    Graphics.DrawTexture(screenRect, texture, mat, -1);
  }

  public static void DrawTexture(Rect screenRect, Texture texture)
  {
    Graphics.DrawTexture(screenRect, texture, (Material) null, -1);
  }

  public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
  {
    Graphics.SetRenderTarget(rt, mipLevel, face, 0);
  }

  public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
  {
    Graphics.SetRenderTarget(colorBuffer, depthBuffer, 0, CubemapFace.Unknown, 0);
  }

  public static void SetRenderTarget(
    RenderBuffer colorBuffer,
    RenderBuffer depthBuffer,
    int mipLevel)
  {
    Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, CubemapFace.Unknown, 0);
  }

  public static void SetRenderTarget(
    RenderBuffer colorBuffer,
    RenderBuffer depthBuffer,
    int mipLevel,
    CubemapFace face)
  {
    Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, 0);
  }

  public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
  {
    Graphics.SetRandomWriteTarget(index, uav, false);
  }

  public static void SetRandomWriteTarget(int index, GraphicsBuffer uav)
  {
    Graphics.SetRandomWriteTarget(index, uav, false);
  }

  public static void GetActiveColorBuffer_Injected(out RenderBuffer ret)
  {
    Graphics.GetActiveColorBuffer_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void GetActiveDepthBuffer_Injected(out RenderBuffer ret)
  {
    Graphics.GetActiveDepthBuffer_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void Internal_SetGfxRT_Injected(
    System.IntPtr gfxTex,
    int mip,
    CubemapFace face,
    int depthSlice)
  {
    Graphics.Internal_SetGfxRT_InjectedDelegateField(gfxTex, mip, face, depthSlice);
  }

  public static void Internal_SetMRTSimple_Injected(
    ref ManagedSpanWrapper color,
    [In] ref RenderBuffer depth,
    int mip,
    CubemapFace face,
    int depthSlice)
  {
    Graphics.Internal_SetMRTSimple_InjectedDelegateField((System.IntPtr) ref color, (System.IntPtr) ref depth, mip, face, depthSlice);
  }

  public static void Internal_SetMRTFullSetup_Injected(
    ref ManagedSpanWrapper color,
    [In] ref RenderBuffer depth,
    int mip,
    CubemapFace face,
    int depthSlice,
    ref ManagedSpanWrapper colorLA,
    ref ManagedSpanWrapper colorSA,
    RenderBufferLoadAction depthLA,
    RenderBufferStoreAction depthSA)
  {
    Graphics.Internal_SetMRTFullSetup_InjectedDelegateField((System.IntPtr) ref color, (System.IntPtr) ref depth, mip, face, depthSlice, (System.IntPtr) ref colorLA, (System.IntPtr) ref colorSA, depthLA, depthSA);
  }

  public static void Internal_SetRandomWriteTargetRT_Injected(int index, System.IntPtr uav)
  {
    Graphics.Internal_SetRandomWriteTargetRT_InjectedDelegateField(index, uav);
  }

  public static void Internal_SetRandomWriteTargetBuffer_Injected(
    int index,
    System.IntPtr uav,
    bool preserveCounterValue)
  {
    Graphics.Internal_SetRandomWriteTargetBuffer_InjectedDelegateField(index, uav, preserveCounterValue);
  }

  public static void Internal_SetRandomWriteTargetGraphicsBuffer_Injected(
    int index,
    System.IntPtr uav,
    bool preserveCounterValue)
  {
    Graphics.Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegateField(index, uav, preserveCounterValue);
  }

  public static void CopyTexture_Full_Injected(System.IntPtr src, System.IntPtr dst)
  {
    Graphics.CopyTexture_Full_InjectedDelegateField(src, dst);
  }

  public static void CopyTexture_Slice_AllMips_Injected(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement)
  {
    Graphics.CopyTexture_Slice_AllMips_InjectedDelegateField(src, srcElement, dst, dstElement);
  }

  public static void CopyTexture_Full_Gfx_Injected(System.IntPtr src, System.IntPtr dst)
  {
    Graphics.CopyTexture_Full_Gfx_InjectedDelegateField(src, dst);
  }

  public static void CopyTexture_Slice_AllMips_Gfx_Injected(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement)
  {
    Graphics.CopyTexture_Slice_AllMips_Gfx_InjectedDelegateField(src, srcElement, dst, dstElement);
  }

  public static void CopyTexture_Slice_Gfx_Injected(
    System.IntPtr src,
    int srcElement,
    int srcMip,
    System.IntPtr dst,
    int dstElement,
    int dstMip)
  {
    Graphics.CopyTexture_Slice_Gfx_InjectedDelegateField(src, srcElement, srcMip, dst, dstElement, dstMip);
  }

  public static void CopyTexture_Region_Gfx_Injected(
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    System.IntPtr dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    Graphics.CopyTexture_Region_Gfx_InjectedDelegateField(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
  }

  public static bool ConvertTexture_Full_Injected(System.IntPtr src, System.IntPtr dst)
  {
    return Graphics.ConvertTexture_Full_InjectedDelegateField(src, dst);
  }

  public static bool ConvertTexture_Slice_Injected(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement)
  {
    return Graphics.ConvertTexture_Slice_InjectedDelegateField(src, srcElement, dst, dstElement);
  }

  public static bool ConvertTexture_Full_Gfx_Injected(System.IntPtr src, System.IntPtr dst)
  {
    return Graphics.ConvertTexture_Full_Gfx_InjectedDelegateField(src, dst);
  }

  public static bool ConvertTexture_Slice_Gfx_Injected(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement)
  {
    return Graphics.ConvertTexture_Slice_Gfx_InjectedDelegateField(src, srcElement, dst, dstElement);
  }

  public static void CopyBufferImpl_Injected(System.IntPtr source, System.IntPtr dest)
  {
    Graphics.CopyBufferImpl_InjectedDelegateField(source, dest);
  }

  public static void Internal_DrawMeshNow1_Injected(
    System.IntPtr mesh,
    int subsetIndex,
    [In] ref Vector3 position,
    [In] ref Quaternion rotation)
  {
    Graphics.Internal_DrawMeshNow1_InjectedDelegateField(mesh, subsetIndex, (System.IntPtr) ref position, (System.IntPtr) ref rotation);
  }

  public static void Internal_DrawMeshNow2_Injected(
    System.IntPtr mesh,
    int subsetIndex,
    [In] ref Matrix4x4 matrix)
  {
    Graphics.Internal_DrawMeshNow2_InjectedDelegateField(mesh, subsetIndex, (System.IntPtr) ref matrix);
  }

  public static void Internal_DrawMeshInstancedProcedural_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    [In] ref Bounds bounds,
    int count,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume)
  {
    Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField(mesh, submeshIndex, material, (System.IntPtr) ref bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void Internal_DrawMeshInstancedIndirect_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    [In] ref Bounds bounds,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume)
  {
    Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField(mesh, submeshIndex, material, (System.IntPtr) ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    [In] ref Bounds bounds,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume)
  {
    Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField(mesh, submeshIndex, material, (System.IntPtr) ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
  }

  public static void Internal_DrawProceduralIndexedNow_Injected(
    MeshTopology topology,
    System.IntPtr indexBuffer,
    int indexCount,
    int instanceCount)
  {
    Graphics.Internal_DrawProceduralIndexedNow_InjectedDelegateField(topology, indexBuffer, indexCount, instanceCount);
  }

  public static void Internal_DrawProceduralIndirectNow_Injected(
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndirectNow_InjectedDelegateField(topology, bufferWithArgs, argsOffset);
  }

  public static void Internal_DrawProceduralIndexedIndirectNow_Injected(
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndexedIndirectNow_InjectedDelegateField(topology, indexBuffer, bufferWithArgs, argsOffset);
  }

  public static void Internal_DrawProceduralIndirectNowGraphicsBuffer_Injected(
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegateField(topology, bufferWithArgs, argsOffset);
  }

  public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_Injected(
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset)
  {
    Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegateField(topology, indexBuffer, bufferWithArgs, argsOffset);
  }

  public static void Internal_DrawProcedural_Injected(
    System.IntPtr material,
    [In] ref Bounds bounds,
    MeshTopology topology,
    int vertexCount,
    int instanceCount,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProcedural_InjectedDelegateField(material, (System.IntPtr) ref bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndexed_Injected(
    System.IntPtr material,
    [In] ref Bounds bounds,
    MeshTopology topology,
    System.IntPtr indexBuffer,
    int indexCount,
    int instanceCount,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField(material, (System.IntPtr) ref bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndirect_Injected(
    System.IntPtr material,
    [In] ref Bounds bounds,
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField(material, (System.IntPtr) ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(
    System.IntPtr material,
    [In] ref Bounds bounds,
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField(material, (System.IntPtr) ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndexedIndirect_Injected(
    System.IntPtr material,
    [In] ref Bounds bounds,
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(material, (System.IntPtr) ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(
    System.IntPtr material,
    [In] ref Bounds bounds,
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer)
  {
    Graphics.Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField(material, (System.IntPtr) ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
  }

  public static void Internal_BlitMaterial6_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT,
    int destDepthSlice)
  {
    Graphics.Internal_BlitMaterial6_InjectedDelegateField(source, dest, mat, pass, setRT, destDepthSlice);
  }

  public static void Internal_BlitMultiTap4_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    ref ManagedSpanWrapper offsets)
  {
    Graphics.Internal_BlitMultiTap4_InjectedDelegateField(source, dest, mat, (System.IntPtr) ref offsets);
  }

  public static void Internal_BlitMultiTap5_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    ref ManagedSpanWrapper offsets,
    int destDepthSlice)
  {
    Graphics.Internal_BlitMultiTap5_InjectedDelegateField(source, dest, mat, (System.IntPtr) ref offsets, destDepthSlice);
  }

  public static void Blit3_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.Blit3_InjectedDelegateField(source, dest, sourceDepthSlice, destDepthSlice);
  }

  public static void Blit4_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    [In] ref Vector2 scale,
    [In] ref Vector2 offset)
  {
    Graphics.Blit4_InjectedDelegateField(source, dest, (System.IntPtr) ref scale, (System.IntPtr) ref offset);
  }

  public static void Blit5_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    [In] ref Vector2 scale,
    [In] ref Vector2 offset,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.Blit5_InjectedDelegateField(source, dest, (System.IntPtr) ref scale, (System.IntPtr) ref offset, sourceDepthSlice, destDepthSlice);
  }

  public static void Internal_BlitMaterialGfx5_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT)
  {
    Graphics.Internal_BlitMaterialGfx5_InjectedDelegateField(source, dest, mat, pass, setRT);
  }

  public static void Internal_BlitMaterialGfx6_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT,
    int destDepthSlice)
  {
    Graphics.Internal_BlitMaterialGfx6_InjectedDelegateField(source, dest, mat, pass, setRT, destDepthSlice);
  }

  public static void Internal_BlitMultiTapGfx4_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    ref ManagedSpanWrapper offsets)
  {
    Graphics.Internal_BlitMultiTapGfx4_InjectedDelegateField(source, dest, mat, (System.IntPtr) ref offsets);
  }

  public static void Internal_BlitMultiTapGfx5_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    ref ManagedSpanWrapper offsets,
    int destDepthSlice)
  {
    Graphics.Internal_BlitMultiTapGfx5_InjectedDelegateField(source, dest, mat, (System.IntPtr) ref offsets, destDepthSlice);
  }

  public static void BlitGfx2_Injected(System.IntPtr source, System.IntPtr dest)
  {
    Graphics.BlitGfx2_InjectedDelegateField(source, dest);
  }

  public static void BlitGfx3_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.BlitGfx3_InjectedDelegateField(source, dest, sourceDepthSlice, destDepthSlice);
  }

  public static void BlitGfx4_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    [In] ref Vector2 scale,
    [In] ref Vector2 offset)
  {
    Graphics.BlitGfx4_InjectedDelegateField(source, dest, (System.IntPtr) ref scale, (System.IntPtr) ref offset);
  }

  public static void BlitGfx5_Injected(
    System.IntPtr source,
    System.IntPtr dest,
    [In] ref Vector2 scale,
    [In] ref Vector2 offset,
    int sourceDepthSlice,
    int destDepthSlice)
  {
    Graphics.BlitGfx5_InjectedDelegateField(source, dest, (System.IntPtr) ref scale, (System.IntPtr) ref offset, sourceDepthSlice, destDepthSlice);
  }

  public static void ExecuteCommandBufferAsync_Injected(System.IntPtr buffer, ComputeQueueType queueType)
  {
    Graphics.ExecuteCommandBufferAsync_InjectedDelegateField(buffer, queueType);
  }

  private delegate ColorGamut GetActiveColorGamutDelegate();

  private delegate bool GetPreserveFramebufferAlphaDelegate();

  private delegate OpenGLESVersion GetMinOpenGLESVersionDelegate();

  private delegate void Internal_DrawProceduralNowDelegate(
    MeshTopology topology,
    int vertexCount,
    int instanceCount);

  private delegate System.IntPtr CreateGPUFenceImplDelegate(
    GraphicsFenceType fenceType,
    SynchronisationStageFlags stage);

  private delegate void WaitOnGPUFenceImplDelegate(System.IntPtr fencePtr, SynchronisationStageFlags stage);

  private delegate void GetActiveColorBuffer_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void GetActiveDepthBuffer_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void Internal_SetGfxRT_InjectedDelegate(
    System.IntPtr gfxTex,
    int mip,
    CubemapFace face,
    int depthSlice);

  private delegate void Internal_SetMRTSimple_InjectedDelegate(
    System.IntPtr color,
    [In] System.IntPtr depth,
    int mip,
    CubemapFace face,
    int depthSlice);

  private delegate void Internal_SetMRTFullSetup_InjectedDelegate(
    System.IntPtr color,
    [In] System.IntPtr depth,
    int mip,
    CubemapFace face,
    int depthSlice,
    System.IntPtr colorLA,
    System.IntPtr colorSA,
    RenderBufferLoadAction depthLA,
    RenderBufferStoreAction depthSA);

  private delegate void Internal_SetRandomWriteTargetRT_InjectedDelegate(int index, System.IntPtr uav);

  private delegate void Internal_SetRandomWriteTargetBuffer_InjectedDelegate(
    int index,
    System.IntPtr uav,
    bool preserveCounterValue);

  private delegate void Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegate(
    int index,
    System.IntPtr uav,
    bool preserveCounterValue);

  private delegate void CopyTexture_Full_InjectedDelegate(System.IntPtr src, System.IntPtr dst);

  private delegate void CopyTexture_Slice_AllMips_InjectedDelegate(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement);

  private delegate void CopyTexture_Full_Gfx_InjectedDelegate(System.IntPtr src, System.IntPtr dst);

  private delegate void CopyTexture_Slice_AllMips_Gfx_InjectedDelegate(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement);

  private delegate void CopyTexture_Slice_Gfx_InjectedDelegate(
    System.IntPtr src,
    int srcElement,
    int srcMip,
    System.IntPtr dst,
    int dstElement,
    int dstMip);

  private delegate void CopyTexture_Region_Gfx_InjectedDelegate(
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    System.IntPtr dst,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY);

  private delegate bool ConvertTexture_Full_InjectedDelegate(System.IntPtr src, System.IntPtr dst);

  private delegate bool ConvertTexture_Slice_InjectedDelegate(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement);

  private delegate bool ConvertTexture_Full_Gfx_InjectedDelegate(System.IntPtr src, System.IntPtr dst);

  private delegate bool ConvertTexture_Slice_Gfx_InjectedDelegate(
    System.IntPtr src,
    int srcElement,
    System.IntPtr dst,
    int dstElement);

  private delegate void CopyBufferImpl_InjectedDelegate(System.IntPtr source, System.IntPtr dest);

  private delegate void Internal_DrawMeshNow1_InjectedDelegate(
    System.IntPtr mesh,
    int subsetIndex,
    [In] System.IntPtr position,
    [In] System.IntPtr rotation);

  private delegate void Internal_DrawMeshNow2_InjectedDelegate(
    System.IntPtr mesh,
    int subsetIndex,
    [In] System.IntPtr matrix);

  private delegate void Internal_DrawMeshInstancedProcedural_InjectedDelegate(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    [In] System.IntPtr bounds,
    int count,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume);

  private delegate void Internal_DrawMeshInstancedIndirect_InjectedDelegate(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    [In] System.IntPtr bounds,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume);

  private delegate void Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate(
    System.IntPtr mesh,
    int submeshIndex,
    System.IntPtr material,
    [In] System.IntPtr bounds,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer,
    System.IntPtr camera,
    LightProbeUsage lightProbeUsage,
    System.IntPtr lightProbeProxyVolume);

  private delegate void Internal_DrawProceduralIndexedNow_InjectedDelegate(
    MeshTopology topology,
    System.IntPtr indexBuffer,
    int indexCount,
    int instanceCount);

  private delegate void Internal_DrawProceduralIndirectNow_InjectedDelegate(
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset);

  private delegate void Internal_DrawProceduralIndexedIndirectNow_InjectedDelegate(
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset);

  private delegate void Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegate(
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset);

  private delegate void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegate(
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset);

  private delegate void Internal_DrawProcedural_InjectedDelegate(
    System.IntPtr material,
    [In] System.IntPtr bounds,
    MeshTopology topology,
    int vertexCount,
    int instanceCount,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer);

  private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(
    System.IntPtr material,
    [In] System.IntPtr bounds,
    MeshTopology topology,
    System.IntPtr indexBuffer,
    int indexCount,
    int instanceCount,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer);

  private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(
    System.IntPtr material,
    [In] System.IntPtr bounds,
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer);

  private delegate void Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate(
    System.IntPtr material,
    [In] System.IntPtr bounds,
    MeshTopology topology,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer);

  private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(
    System.IntPtr material,
    [In] System.IntPtr bounds,
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer);

  private delegate void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate(
    System.IntPtr material,
    [In] System.IntPtr bounds,
    MeshTopology topology,
    System.IntPtr indexBuffer,
    System.IntPtr bufferWithArgs,
    int argsOffset,
    System.IntPtr camera,
    System.IntPtr properties,
    ShadowCastingMode castShadows,
    bool receiveShadows,
    int layer);

  private delegate void Internal_BlitMaterial6_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT,
    int destDepthSlice);

  private delegate void Internal_BlitMultiTap4_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    System.IntPtr offsets);

  private delegate void Internal_BlitMultiTap5_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    System.IntPtr offsets,
    int destDepthSlice);

  private delegate void Blit3_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    int sourceDepthSlice,
    int destDepthSlice);

  private delegate void Blit4_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    [In] System.IntPtr scale,
    [In] System.IntPtr offset);

  private delegate void Blit5_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    [In] System.IntPtr scale,
    [In] System.IntPtr offset,
    int sourceDepthSlice,
    int destDepthSlice);

  private delegate void Internal_BlitMaterialGfx5_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT);

  private delegate void Internal_BlitMaterialGfx6_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    int pass,
    bool setRT,
    int destDepthSlice);

  private delegate void Internal_BlitMultiTapGfx4_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    System.IntPtr offsets);

  private delegate void Internal_BlitMultiTapGfx5_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    System.IntPtr mat,
    System.IntPtr offsets,
    int destDepthSlice);

  private delegate void BlitGfx2_InjectedDelegate(System.IntPtr source, System.IntPtr dest);

  private delegate void BlitGfx3_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    int sourceDepthSlice,
    int destDepthSlice);

  private delegate void BlitGfx4_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    [In] System.IntPtr scale,
    [In] System.IntPtr offset);

  private delegate void BlitGfx5_InjectedDelegate(
    System.IntPtr source,
    System.IntPtr dest,
    [In] System.IntPtr scale,
    [In] System.IntPtr offset,
    int sourceDepthSlice,
    int destDepthSlice);

  private delegate void ExecuteCommandBufferAsync_InjectedDelegate(
    System.IntPtr buffer,
    ComputeQueueType queueType);
}
