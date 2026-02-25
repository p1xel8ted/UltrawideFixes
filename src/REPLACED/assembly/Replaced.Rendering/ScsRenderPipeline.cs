// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ScsRenderPipeline
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ScsRenderPipeline(System.IntPtr pointer) : RenderPipeline(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kPipelineTag;
  private static readonly System.IntPtr NativeFieldInfoPtr__config;
  private static readonly System.IntPtr NativeFieldInfoPtr__frameStatsReport;
  private static readonly System.IntPtr NativeFieldInfoPtr__frameManager;
  private static readonly System.IntPtr NativeFieldInfoPtr__frameResultTextures;
  private static readonly System.IntPtr NativeFieldInfoPtr__globalCBuffers;
  private static readonly System.IntPtr NativeFieldInfoPtr__sceneRP;
  private static readonly System.IntPtr NativeFieldInfoPtr__dofAutofocusTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr__playerCharacterBoundsWs;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiRenderPipeline;
  private static readonly System.IntPtr NativeFieldInfoPtr__presentPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__devdbgRP;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeforeRendering_Private_Static_Void_byref_ScriptableRenderContext_byref_CoreParams_FrameResultTextures_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindPreviewCamera_Private_Static_Camera_List_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderGizmos_Private_Static_Void_byref_ScriptableRenderContext_List_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ScsRenderPipelineConfig_ParticipatingMediumManager_DecalManager_ClusteredLightListHeatmapSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DofAutofocusTarget_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DofAutofocusTarget_Public_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCharacterBounds_Public_get_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerCharacterBounds_Public_set_Void_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameStatsReport_Public_get_FrameStatsReport_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RenderPipelineDevdbg_Public_get_IDevdbgRenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFrameManager_Private_SceneFrameManager_CameraType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderSceneCamera_Private_Void_byref_ScriptableRenderContext_Camera_SceneFrameManager_byref_CoreParams_byref_UserPreferences_0;

  static ScsRenderPipeline()
  {
    Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ScsRenderPipeline));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr);
    ScsRenderPipeline.NativeFieldInfoPtr_kPipelineTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (kPipelineTag));
    ScsRenderPipeline.NativeFieldInfoPtr__config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_config));
    ScsRenderPipeline.NativeFieldInfoPtr__frameStatsReport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_frameStatsReport));
    ScsRenderPipeline.NativeFieldInfoPtr__frameManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_frameManager));
    ScsRenderPipeline.NativeFieldInfoPtr__frameResultTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_frameResultTextures));
    ScsRenderPipeline.NativeFieldInfoPtr__globalCBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_globalCBuffers));
    ScsRenderPipeline.NativeFieldInfoPtr__sceneRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_sceneRP));
    ScsRenderPipeline.NativeFieldInfoPtr__dofAutofocusTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_dofAutofocusTarget));
    ScsRenderPipeline.NativeFieldInfoPtr__playerCharacterBoundsWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_playerCharacterBoundsWs));
    ScsRenderPipeline.NativeFieldInfoPtr__uiRenderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_uiRenderPipeline));
    ScsRenderPipeline.NativeFieldInfoPtr__presentPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_presentPass));
    ScsRenderPipeline.NativeFieldInfoPtr__devdbgRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, nameof (_devdbgRP));
    ScsRenderPipeline.NativeMethodInfoPtr_BeforeRendering_Private_Static_Void_byref_ScriptableRenderContext_byref_CoreParams_FrameResultTextures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664293);
    ScsRenderPipeline.NativeMethodInfoPtr_FindPreviewCamera_Private_Static_Camera_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664294);
    ScsRenderPipeline.NativeMethodInfoPtr_RenderGizmos_Private_Static_Void_byref_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664295);
    ScsRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ScsRenderPipelineConfig_ParticipatingMediumManager_DecalManager_ClusteredLightListHeatmapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664296);
    ScsRenderPipeline.NativeMethodInfoPtr_get_DofAutofocusTarget_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664297);
    ScsRenderPipeline.NativeMethodInfoPtr_set_DofAutofocusTarget_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664298);
    ScsRenderPipeline.NativeMethodInfoPtr_get_PlayerCharacterBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664299);
    ScsRenderPipeline.NativeMethodInfoPtr_set_PlayerCharacterBounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664300);
    ScsRenderPipeline.NativeMethodInfoPtr_get_FrameStatsReport_Public_get_FrameStatsReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664301);
    ScsRenderPipeline.NativeMethodInfoPtr_get_RenderPipelineDevdbg_Public_get_IDevdbgRenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664302);
    ScsRenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664303);
    ScsRenderPipeline.NativeMethodInfoPtr_GetFrameManager_Private_SceneFrameManager_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664304 /*0x060003F0*/);
    ScsRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664305);
    ScsRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664306);
    ScsRenderPipeline.NativeMethodInfoPtr_RenderSceneCamera_Private_Void_byref_ScriptableRenderContext_Camera_SceneFrameManager_byref_CoreParams_byref_UserPreferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, 100664307);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936219, XrefRangeEnd = 936233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BeforeRendering(
    [In] ref ScriptableRenderContext ctx,
    [In] ref CoreParams coreParams,
    FrameResultTextures frameResultTextures)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_BeforeRendering_Private_Static_Void_byref_ScriptableRenderContext_byref_CoreParams_FrameResultTextures_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Camera FindPreviewCamera(List<Camera> cameras)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_FindPreviewCamera_Private_Static_Camera_List_1_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num3);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RenderGizmos([In] ref ScriptableRenderContext ctx, List<Camera> cameras)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_RenderGizmos_Private_Static_Void_byref_ScriptableRenderContext_List_1_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936285, RefRangeEnd = 936286, XrefRangeStart = 936233, XrefRangeEnd = 936285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScsRenderPipeline(
    ScsRenderPipelineResources resources,
    ScsRenderPipelineConfig config,
    ParticipatingMediumManager mediumManager,
    DecalManager decalManager,
    ClusteredLightListHeatmapSettings cllHeatmapSettings)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mediumManager);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decalManager);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cllHeatmapSettings);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_ScsRenderPipelineConfig_ParticipatingMediumManager_DecalManager_ClusteredLightListHeatmapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform DofAutofocusTarget
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_get_DofAutofocusTarget_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_set_DofAutofocusTarget_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Bounds PlayerCharacterBounds
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_get_PlayerCharacterBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_set_PlayerCharacterBounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe FrameStatsReport FrameStatsReport
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_get_FrameStatsReport_Public_get_FrameStatsReport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FrameStatsReport) null : Il2CppObjectPool.Get<FrameStatsReport>(num3);
    }
  }

  public unsafe IDevdbgRenderPipeline RenderPipelineDevdbg
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_get_RenderPipelineDevdbg_Public_get_IDevdbgRenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IDevdbgRenderPipeline) null : Il2CppObjectPool.Get<IDevdbgRenderPipeline>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936286, XrefRangeEnd = 936311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disposing
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneFrameManager GetFrameManager(CameraType cameraType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &cameraType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_GetFrameManager_Private_SceneFrameManager_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (SceneFrameManager) null : Il2CppObjectPool.Get<SceneFrameManager>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936311, XrefRangeEnd = 936317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Render(
    ScriptableRenderContext ctx,
    Il2CppReferenceArray<Camera> cameras)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936317, XrefRangeEnd = 936378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Render(ScriptableRenderContext ctx, List<Camera> cameras)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936378, XrefRangeEnd = 936384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RenderSceneCamera(
    [In] ref ScriptableRenderContext ctx,
    Camera camera,
    SceneFrameManager frameManager,
    [In] ref CoreParams coreParams,
    [In] ref UserPreferences userPreferences)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameManager);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref userPreferences;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.NativeMethodInfoPtr_RenderSceneCamera_Private_Void_byref_ScriptableRenderContext_Camera_SceneFrameManager_byref_CoreParams_byref_UserPreferences_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string kPipelineTag
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ScsRenderPipeline.NativeFieldInfoPtr_kPipelineTag, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScsRenderPipeline.NativeFieldInfoPtr_kPipelineTag, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ScsRenderPipelineConfig _config
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__config));
      return num == System.IntPtr.Zero ? (ScsRenderPipelineConfig) null : Il2CppObjectPool.Get<ScsRenderPipelineConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__config), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FrameStatsReport _frameStatsReport
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__frameStatsReport));
      return num == System.IntPtr.Zero ? (FrameStatsReport) null : Il2CppObjectPool.Get<FrameStatsReport>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__frameStatsReport), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SceneFrameManager _frameManager
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__frameManager));
      return num == System.IntPtr.Zero ? (SceneFrameManager) null : Il2CppObjectPool.Get<SceneFrameManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__frameManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FrameResultTextures _frameResultTextures
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__frameResultTextures));
      return num == System.IntPtr.Zero ? (FrameResultTextures) null : Il2CppObjectPool.Get<FrameResultTextures>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__frameResultTextures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GlobalCBuffers _globalCBuffers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__globalCBuffers));
      return num == System.IntPtr.Zero ? (GlobalCBuffers) null : Il2CppObjectPool.Get<GlobalCBuffers>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__globalCBuffers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SceneRenderPipeline _sceneRP
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__sceneRP));
      return num == System.IntPtr.Zero ? (SceneRenderPipeline) null : Il2CppObjectPool.Get<SceneRenderPipeline>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__sceneRP), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform _dofAutofocusTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__dofAutofocusTarget));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__dofAutofocusTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Bounds _playerCharacterBoundsWs
  {
    get
    {
      return *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__playerCharacterBoundsWs));
    }
    [param: In] set
    {
      *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__playerCharacterBoundsWs)) = value;
    }
  }

  public unsafe UIRenderPipeline _uiRenderPipeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__uiRenderPipeline));
      return num == System.IntPtr.Zero ? (UIRenderPipeline) null : Il2CppObjectPool.Get<UIRenderPipeline>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__uiRenderPipeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PresentToCameraRTPass _presentPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__presentPass));
      return num == System.IntPtr.Zero ? (PresentToCameraRTPass) null : Il2CppObjectPool.Get<PresentToCameraRTPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__presentPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IDevdbgRenderPipeline _devdbgRP
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__devdbgRP));
      return num == System.IntPtr.Zero ? (IDevdbgRenderPipeline) null : Il2CppObjectPool.Get<IDevdbgRenderPipeline>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipeline.NativeFieldInfoPtr__devdbgRP), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Rendering.ScsRenderPipeline+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__29_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Render_b__29_0_Internal_Int32_Camera_Camera_0;

    static __c()
    {
      Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScsRenderPipeline>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr);
      ScsRenderPipeline.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr, "<>9");
      ScsRenderPipeline.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr, "<>9__29_0");
      ScsRenderPipeline.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr, 100664309);
      ScsRenderPipeline.__c.NativeMethodInfoPtr__Render_b__29_0_Internal_Int32_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr, 100664310);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScsRenderPipeline.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936217, XrefRangeEnd = 936219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Render_b__29_0(Camera c1, Camera c2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipeline.__c.NativeMethodInfoPtr__Render_b__29_0_Internal_Int32_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe ScsRenderPipeline.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ScsRenderPipeline.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (ScsRenderPipeline.__c) null : Il2CppObjectPool.Get<ScsRenderPipeline.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScsRenderPipeline.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<Camera> __9__29_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ScsRenderPipeline.__c.NativeFieldInfoPtr___9__29_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<Camera>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<Camera>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScsRenderPipeline.__c.NativeFieldInfoPtr___9__29_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
