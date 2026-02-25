// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipelineManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public static class RenderPipelineManager : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_CleanUpPipeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentPipelineType;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentPipelineAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentPipeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineTypeChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineAssetChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineCreated;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineDisposed;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecreateCurrentPipeline_Internal_Static_Void_RenderPipelineAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryPrepareRenderPipeline_Internal_Static_Boolean_RenderPipelineAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isCurrentPipelineValid_Private_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0;
  public const string k_BuiltinPipelineName = "Built-in Pipeline";

  static RenderPipelineManager()
  {
    Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderPipelineManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr);
    RenderPipelineManager.NativeFieldInfoPtr_s_CleanUpPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (s_CleanUpPipeline));
    RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (s_CurrentPipelineType));
    RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (s_CurrentPipelineAsset));
    RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (s_CurrentPipeline));
    RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (activeRenderPipelineTypeChanged));
    RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (activeRenderPipelineAssetChanged));
    RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (activeRenderPipelineCreated));
    RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, nameof (activeRenderPipelineDisposed));
    RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670470);
    RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670471);
    RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670472);
    RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670473);
    RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670474);
    RenderPipelineManager.NativeMethodInfoPtr_RecreateCurrentPipeline_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670475);
    RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670476);
    RenderPipelineManager.NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670477);
    RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670478);
    RenderPipelineManager.NativeMethodInfoPtr_TryPrepareRenderPipeline_Internal_Static_Boolean_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670479);
    RenderPipelineManager.NativeMethodInfoPtr_get_isCurrentPipelineValid_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670480);
    RenderPipelineManager.NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100670481);
  }

  public static unsafe RenderPipeline currentPipeline
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487951, XrefRangeEnd = 487955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RenderPipeline) null : Il2CppObjectPool.Get<RenderPipeline>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 487964, RefRangeEnd = 487965, XrefRangeStart = 487955, XrefRangeEnd = 487964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487965, XrefRangeEnd = 487969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnActiveRenderPipelineTypeChanged()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487969, XrefRangeEnd = 487976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnActiveRenderPipelineAssetChanged(
    ScriptableObject from,
    ScriptableObject to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487976, XrefRangeEnd = 487983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pipelineAsset)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487983, XrefRangeEnd = 487994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pipelineAsset)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_RecreateCurrentPipeline_Internal_Static_Void_RenderPipelineAsset_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 488043, RefRangeEnd = 488046, XrefRangeStart = 487994, XrefRangeEnd = 488043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CleanupRenderPipeline()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488046, XrefRangeEnd = 488050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetCurrentPipelineAssetType()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488050, XrefRangeEnd = 488094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DoRenderLoop_Internal(
    RenderPipelineAsset pipelineAsset,
    System.IntPtr loopPtr,
    UnityEngine.Object renderRequest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pipelineAsset);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loopPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderRequest);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488139, RefRangeEnd = 488140, XrefRangeStart = 488094, XrefRangeEnd = 488139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pipelineAsset)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_TryPrepareRenderPipeline_Internal_Static_Boolean_RenderPipelineAsset_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe bool isCurrentPipelineValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488140, XrefRangeEnd = 488147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_get_isCurrentPipelineValid_Private_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488147, XrefRangeEnd = 488155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsPipelineRequireCreation()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public RenderPipelineManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool s_CleanUpPipeline
  {
    get
    {
      bool sCleanUpPipeline;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CleanUpPipeline, (void*) &sCleanUpPipeline);
      return sCleanUpPipeline;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CleanUpPipeline, (void*) &value);
    }
  }

  public static unsafe string s_CurrentPipelineType
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe RenderPipelineAsset s_CurrentPipelineAsset
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (RenderPipelineAsset) null : Il2CppObjectPool.Get<RenderPipelineAsset>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe RenderPipeline s_CurrentPipeline
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (RenderPipeline) null : Il2CppObjectPool.Get<RenderPipeline>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action activeRenderPipelineTypeChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action activeRenderPipelineCreated
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action activeRenderPipelineDisposed
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static RenderPipelineAsset currentPipelineAsset
  {
    get => RenderPipelineManager.s_CurrentPipelineAsset;
  }

  [SpecialName]
  public static void add_beginContextRendering(
    Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_beginContextRendering(
    Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_endContextRendering(
    Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_endContextRendering(
    Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_beginCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_beginCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_endCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_endCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_activeRenderPipelineTypeChanged(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_activeRenderPipelineTypeChanged(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_activeRenderPipelineAssetChanged(
    Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_activeRenderPipelineAssetChanged(
    Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_activeRenderPipelineCreated(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_activeRenderPipelineCreated(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_activeRenderPipelineDisposed(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_activeRenderPipelineDisposed(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool pipelineSwitchCompleted
  {
    get
    {
      return RenderPipelineManager.s_CurrentPipelineAsset == GraphicsSettings.currentRenderPipeline && !RenderPipelineManager.IsPipelineRequireCreation();
    }
  }

  public static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_beginFrameRendering(
    Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_beginFrameRendering(
    Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_endFrameRendering(
    Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_endFrameRendering(
    Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
