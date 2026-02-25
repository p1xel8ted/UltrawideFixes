// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RendererUtils.RendererListDesc
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering.RendererUtils;

public sealed class RendererListDesc : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sortingCriteria;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererConfiguration;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderQueueRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateBlock;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideShader;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_excludeObjectMotionVectors;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr__batchLayerMask_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideMaterialPassIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideShaderPassIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr__cullingResult_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__camera_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__passName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__passNames_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_EmptyName;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_batchLayerMask_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingResult_Private_set_Void_CullingResults_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_camera_Internal_get_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_camera_Internal_set_Void_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_passName_Private_set_Void_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_passNames_Private_set_Void_Il2CppStructArray_1_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_CullingResults_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_ShaderTagId_CullingResults_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0;

  static RendererListDesc()
  {
    Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering.RendererUtils", nameof (RendererListDesc));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr);
    RendererListDesc.NativeFieldInfoPtr_sortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (sortingCriteria));
    RendererListDesc.NativeFieldInfoPtr_rendererConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (rendererConfiguration));
    RendererListDesc.NativeFieldInfoPtr_renderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (renderQueueRange));
    RendererListDesc.NativeFieldInfoPtr_stateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (stateBlock));
    RendererListDesc.NativeFieldInfoPtr_overrideShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (overrideShader));
    RendererListDesc.NativeFieldInfoPtr_overrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (overrideMaterial));
    RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (excludeObjectMotionVectors));
    RendererListDesc.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (layerMask));
    RendererListDesc.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (renderingLayerMask));
    RendererListDesc.NativeFieldInfoPtr__batchLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<batchLayerMask>k__BackingField");
    RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (overrideMaterialPassIndex));
    RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (overrideShaderPassIndex));
    RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<cullingResult>k__BackingField");
    RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<camera>k__BackingField");
    RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passName>k__BackingField");
    RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passNames>k__BackingField");
    RendererListDesc.NativeFieldInfoPtr_s_EmptyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, nameof (s_EmptyName));
    RendererListDesc.NativeMethodInfoPtr_get_batchLayerMask_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670678);
    RendererListDesc.NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670679);
    RendererListDesc.NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670680);
    RendererListDesc.NativeMethodInfoPtr_set_cullingResult_Private_set_Void_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670681);
    RendererListDesc.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670682);
    RendererListDesc.NativeMethodInfoPtr_set_camera_Internal_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670683);
    RendererListDesc.NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670684);
    RendererListDesc.NativeMethodInfoPtr_set_passName_Private_set_Void_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670685);
    RendererListDesc.NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670686);
    RendererListDesc.NativeMethodInfoPtr_set_passNames_Private_set_Void_Il2CppStructArray_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670687);
    RendererListDesc.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_CullingResults_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670688);
    RendererListDesc.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_ShaderTagId_CullingResults_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670689);
    RendererListDesc.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670690);
    RendererListDesc.NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100670691);
  }

  public unsafe uint batchLayerMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_batchLayerMask_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe CullingResults cullingResult
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CullingResults*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_set_cullingResult_Private_set_Void_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Camera camera
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_set_camera_Internal_set_Void_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ShaderTagId passName
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ShaderTagId*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_set_passName_Private_set_Void_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<ShaderTagId> passNames
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<ShaderTagId>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_set_passNames_Private_set_Void_Il2CppStructArray_1_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489238, RefRangeEnd = 489240, XrefRangeStart = 489234, XrefRangeEnd = 489238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &passName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cullingResult;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_CullingResults_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 489246, RefRangeEnd = 489251, XrefRangeStart = 489240, XrefRangeEnd = 489246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RendererListDesc(
    Il2CppStructArray<ShaderTagId> passNames,
    CullingResults cullingResult,
    Camera camera)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) passNames);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cullingResult;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_ShaderTagId_CullingResults_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489263, RefRangeEnd = 489265, XrefRangeStart = 489251, XrefRangeEnd = 489263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489359, RefRangeEnd = 489361, XrefRangeStart = 489265, XrefRangeEnd = 489359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererListParams ConvertToParameters([In] ref RendererListDesc desc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) desc)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RendererListParams(pointer);
  }

  public RendererListDesc(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public RendererListDesc()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr))
  {
  }

  public unsafe SortingCriteria sortingCriteria
  {
    get
    {
      return *(SortingCriteria*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_sortingCriteria));
    }
    [param: In] set
    {
      *(SortingCriteria*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_sortingCriteria)) = value;
    }
  }

  public unsafe PerObjectData rendererConfiguration
  {
    get
    {
      return *(PerObjectData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_rendererConfiguration));
    }
    [param: In] set
    {
      *(PerObjectData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_rendererConfiguration)) = value;
    }
  }

  public unsafe RenderQueueRange renderQueueRange
  {
    get
    {
      return *(RenderQueueRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderQueueRange));
    }
    [param: In] set
    {
      *(RenderQueueRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderQueueRange)) = value;
    }
  }

  public Il2CppSystem.Nullable<RenderStateBlock> stateBlock
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_stateBlock);
      return new Il2CppSystem.Nullable<RenderStateBlock>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<RenderStateBlock>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_stateBlock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<RenderStateBlock>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Shader overrideShader
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShader));
      return num == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material overrideMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool excludeObjectMotionVectors
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors)) = value;
    }
  }

  public unsafe int layerMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe uint renderingLayerMask
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderingLayerMask));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderingLayerMask)) = value;
    }
  }

  public unsafe uint _batchLayerMask_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__batchLayerMask_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__batchLayerMask_k__BackingField)) = value;
    }
  }

  public unsafe int overrideMaterialPassIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex)) = value;
    }
  }

  public unsafe int overrideShaderPassIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex)) = value;
    }
  }

  public unsafe CullingResults _cullingResult_k__BackingField
  {
    get
    {
      return *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField));
    }
    [param: In] set
    {
      *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField)) = value;
    }
  }

  public unsafe Camera _camera_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ShaderTagId _passName_k__BackingField
  {
    get
    {
      return *(ShaderTagId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField));
    }
    [param: In] set
    {
      *(ShaderTagId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppStructArray<ShaderTagId> _passNames_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ShaderTagId>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ShaderTagId s_EmptyName
  {
    get
    {
      ShaderTagId sEmptyName;
      IL2CPP.il2cpp_field_static_get_value(RendererListDesc.NativeFieldInfoPtr_s_EmptyName, (void*) &sEmptyName);
      return sEmptyName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RendererListDesc.NativeFieldInfoPtr_s_EmptyName, (void*) &value);
    }
  }
}
