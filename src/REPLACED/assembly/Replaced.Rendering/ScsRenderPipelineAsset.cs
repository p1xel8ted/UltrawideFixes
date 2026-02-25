// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ScsRenderPipelineAsset
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ScsRenderPipelineAsset(IntPtr pointer) : RenderPipelineAsset<ScsRenderPipeline>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_renderPipelineResources;
  private static readonly IntPtr NativeFieldInfoPtr_renderPipelineConfig;
  private static readonly IntPtr NativeFieldInfoPtr_litDefaultMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_particleDefaultMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_proBuilderDefaultMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_decalDefaultMaterial;
  private static readonly IntPtr NativeFieldInfoPtr__renderPipeline;
  private static readonly IntPtr NativeFieldInfoPtr__mediumManager;
  private static readonly IntPtr NativeFieldInfoPtr__decalManager;
  private static readonly IntPtr NativeFieldInfoPtr__heatmapSettings;
  private static readonly IntPtr NativeFieldInfoPtr__PinkOverlayEnabled_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_get_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_get_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_get_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultShader_Public_Virtual_get_Shader_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameStatsReport_Public_get_FrameStatsReport_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CllHeatmapSettings_Public_get_ClusteredLightListHeatmapSettings_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RenderPipelineDevdbg_Public_get_IDevdbgRenderPipeline_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCharacterBounds_Public_get_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_PlayerCharacterBounds_Public_set_Void_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PinkOverlayEnabled_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_PinkOverlayEnabled_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0;
  private static readonly IntPtr NativeMethodInfoPtr_RegisterSceneObject_Public_Void_ParticipatingMedium_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_ParticipatingMedium_0;
  private static readonly IntPtr NativeMethodInfoPtr_RegisterSceneObject_Public_Void_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_Decal_0;
  private static readonly IntPtr NativeMethodInfoPtr_RegisterSceneObject_Public_Void_MaskDecal_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_MaskDecal_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DofAutofocusTarget_Public_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_DofAutofocusTarget_Public_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_Validate_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ScsRenderPipelineAsset()
  {
    Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ScsRenderPipelineAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr);
    ScsRenderPipelineAsset.NativeFieldInfoPtr_renderPipelineResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (renderPipelineResources));
    ScsRenderPipelineAsset.NativeFieldInfoPtr_renderPipelineConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (renderPipelineConfig));
    ScsRenderPipelineAsset.NativeFieldInfoPtr_litDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (litDefaultMaterial));
    ScsRenderPipelineAsset.NativeFieldInfoPtr_particleDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (particleDefaultMaterial));
    ScsRenderPipelineAsset.NativeFieldInfoPtr_proBuilderDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (proBuilderDefaultMaterial));
    ScsRenderPipelineAsset.NativeFieldInfoPtr_decalDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (decalDefaultMaterial));
    ScsRenderPipelineAsset.NativeFieldInfoPtr__renderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (_renderPipeline));
    ScsRenderPipelineAsset.NativeFieldInfoPtr__mediumManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (_mediumManager));
    ScsRenderPipelineAsset.NativeFieldInfoPtr__decalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (_decalManager));
    ScsRenderPipelineAsset.NativeFieldInfoPtr__heatmapSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, nameof (_heatmapSettings));
    ScsRenderPipelineAsset.NativeFieldInfoPtr__PinkOverlayEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, "<PinkOverlayEnabled>k__BackingField");
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664311);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664312);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664313);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664314);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664315);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_FrameStatsReport_Public_get_FrameStatsReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664316);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_CllHeatmapSettings_Public_get_ClusteredLightListHeatmapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664317);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_RenderPipelineDevdbg_Public_get_IDevdbgRenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664318);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_PlayerCharacterBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664319);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_set_PlayerCharacterBounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664320 /*0x06000400*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_PinkOverlayEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664321 /*0x06000401*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_set_PinkOverlayEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664322 /*0x06000402*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664323 /*0x06000403*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_RegisterSceneObject_Public_Void_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664324 /*0x06000404*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_ParticipatingMedium_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664325 /*0x06000405*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_RegisterSceneObject_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664326 /*0x06000406*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664327 /*0x06000407*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_RegisterSceneObject_Public_Void_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664328 /*0x06000408*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664329 /*0x06000409*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_get_DofAutofocusTarget_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664330 /*0x0600040A*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_set_DofAutofocusTarget_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664331 /*0x0600040B*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr_Validate_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664332 /*0x0600040C*/);
    ScsRenderPipelineAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr, 100664333 /*0x0600040D*/);
  }

  public override unsafe Material defaultMaterial
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public override unsafe Material defaultLineMaterial
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public override unsafe Material defaultParticleMaterial
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public override unsafe Shader defaultShader
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936384, XrefRangeEnd = 936387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public override unsafe string renderPipelineShaderTag
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936387, XrefRangeEnd = 936389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe FrameStatsReport FrameStatsReport
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_FrameStatsReport_Public_get_FrameStatsReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FrameStatsReport) null : Il2CppObjectPool.Get<FrameStatsReport>(num3);
    }
  }

  public unsafe ClusteredLightListHeatmapSettings CllHeatmapSettings
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_CllHeatmapSettings_Public_get_ClusteredLightListHeatmapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ClusteredLightListHeatmapSettings) null : Il2CppObjectPool.Get<ClusteredLightListHeatmapSettings>(num3);
    }
  }

  public unsafe IDevdbgRenderPipeline RenderPipelineDevdbg
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_RenderPipelineDevdbg_Public_get_IDevdbgRenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (IDevdbgRenderPipeline) null : Il2CppObjectPool.Get<IDevdbgRenderPipeline>(num3);
    }
  }

  public unsafe Bounds PlayerCharacterBounds
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_PlayerCharacterBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 936389, RefRangeEnd = 936390, XrefRangeStart = 936389, XrefRangeEnd = 936389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_set_PlayerCharacterBounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PinkOverlayEnabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_PinkOverlayEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_set_PinkOverlayEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936390, XrefRangeEnd = 936395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe RenderPipeline CreatePipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (RenderPipeline) null : Il2CppObjectPool.Get<RenderPipeline>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936395, XrefRangeEnd = 936400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterSceneObject(ParticipatingMedium medium)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_RegisterSceneObject_Public_Void_ParticipatingMedium_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936400, XrefRangeEnd = 936404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterSceneObject(ParticipatingMedium medium)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) medium)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_ParticipatingMedium_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936406, RefRangeEnd = 936407, XrefRangeStart = 936404, XrefRangeEnd = 936406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterSceneObject(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_RegisterSceneObject_Public_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936409, RefRangeEnd = 936410, XrefRangeStart = 936407, XrefRangeEnd = 936409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterSceneObject(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936412, RefRangeEnd = 936413, XrefRangeStart = 936410, XrefRangeEnd = 936412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterSceneObject(MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_RegisterSceneObject_Public_Void_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936415, RefRangeEnd = 936416, XrefRangeStart = 936413, XrefRangeEnd = 936415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterSceneObject(MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_UnregisterSceneObject_Public_Void_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform DofAutofocusTarget
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 936416, RefRangeEnd = 936417, XrefRangeStart = 936416, XrefRangeEnd = 936416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_get_DofAutofocusTarget_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 936417, RefRangeEnd = 936418, XrefRangeStart = 936417, XrefRangeEnd = 936417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_set_DofAutofocusTarget_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936461, RefRangeEnd = 936462, XrefRangeStart = 936418, XrefRangeEnd = 936461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Validate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr_Validate_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936462, XrefRangeEnd = 936498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScsRenderPipelineAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScsRenderPipelineAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ScsRenderPipelineResources renderPipelineResources
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_renderPipelineResources));
      return num == IntPtr.Zero ? (ScsRenderPipelineResources) null : Il2CppObjectPool.Get<ScsRenderPipelineResources>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_renderPipelineResources), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScsRenderPipelineConfig renderPipelineConfig
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_renderPipelineConfig));
      return num == IntPtr.Zero ? (ScsRenderPipelineConfig) null : Il2CppObjectPool.Get<ScsRenderPipelineConfig>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_renderPipelineConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material litDefaultMaterial
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_litDefaultMaterial));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_litDefaultMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material particleDefaultMaterial
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_particleDefaultMaterial));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_particleDefaultMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material proBuilderDefaultMaterial
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_proBuilderDefaultMaterial));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_proBuilderDefaultMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material decalDefaultMaterial
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_decalDefaultMaterial));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr_decalDefaultMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScsRenderPipeline _renderPipeline
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__renderPipeline));
      return num == IntPtr.Zero ? (ScsRenderPipeline) null : Il2CppObjectPool.Get<ScsRenderPipeline>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__renderPipeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticipatingMediumManager _mediumManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__mediumManager));
      return num == IntPtr.Zero ? (ParticipatingMediumManager) null : Il2CppObjectPool.Get<ParticipatingMediumManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__mediumManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DecalManager _decalManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__decalManager));
      return num == IntPtr.Zero ? (DecalManager) null : Il2CppObjectPool.Get<DecalManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__decalManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClusteredLightListHeatmapSettings _heatmapSettings
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__heatmapSettings));
      return num == IntPtr.Zero ? (ClusteredLightListHeatmapSettings) null : Il2CppObjectPool.Get<ClusteredLightListHeatmapSettings>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__heatmapSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _PinkOverlayEnabled_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__PinkOverlayEnabled_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineAsset.NativeFieldInfoPtr__PinkOverlayEnabled_k__BackingField)) = value;
    }
  }
}
