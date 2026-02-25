// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RendererListParams
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class RendererListParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Invalid;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_filteringSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_tagName;
  private static readonly System.IntPtr NativeFieldInfoPtr_isPassTagName;
  private static readonly System.IntPtr NativeFieldInfoPtr_tagValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateBlocks;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

  static RendererListParams()
  {
    Il2CppClassPointerStore<RendererListParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RendererListParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr);
    RendererListParams.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (Invalid));
    RendererListParams.NativeFieldInfoPtr_cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (cullingResults));
    RendererListParams.NativeFieldInfoPtr_drawSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (drawSettings));
    RendererListParams.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (filteringSettings));
    RendererListParams.NativeFieldInfoPtr_tagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (tagName));
    RendererListParams.NativeFieldInfoPtr_isPassTagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (isPassTagName));
    RendererListParams.NativeFieldInfoPtr_tagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (tagValues));
    RendererListParams.NativeFieldInfoPtr_stateBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, nameof (stateBlocks));
    RendererListParams.NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670405);
    RendererListParams.NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670406);
    RendererListParams.NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670407);
    RendererListParams.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670408);
    RendererListParams.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670409);
    RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670410);
    RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670411);
    RendererListParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100670412);
  }

  public unsafe int numStateBlocks
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487670, XrefRangeEnd = 487672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe System.IntPtr stateBlocksPtr
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 487680, RefRangeEnd = 487681, XrefRangeStart = 487672, XrefRangeEnd = 487680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe System.IntPtr tagsValuePtr
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 487689, RefRangeEnd = 487690, XrefRangeStart = 487681, XrefRangeEnd = 487689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487704, RefRangeEnd = 487705, XrefRangeStart = 487690, XrefRangeEnd = 487704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487714, RefRangeEnd = 487715, XrefRangeStart = 487705, XrefRangeEnd = 487714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Validate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Validate_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487740, RefRangeEnd = 487741, XrefRangeStart = 487715, XrefRangeEnd = 487740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(RendererListParams other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487741, XrefRangeEnd = 487747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487747, XrefRangeEnd = 487762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public RendererListParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public RendererListParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr))
  {
  }

  public static unsafe RendererListParams Invalid
  {
    get
    {
      System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(RendererListParams.NativeFieldInfoPtr_Invalid, (void*) num);
      return new RendererListParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RendererListParams.NativeFieldInfoPtr_Invalid, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public unsafe CullingResults cullingResults
  {
    get
    {
      return *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_cullingResults));
    }
    [param: In] set
    {
      *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_cullingResults)) = value;
    }
  }

  public unsafe DrawingSettings drawSettings
  {
    get
    {
      return *(DrawingSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_drawSettings));
    }
    [param: In] set
    {
      *(DrawingSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_drawSettings)) = value;
    }
  }

  public unsafe FilteringSettings filteringSettings
  {
    get
    {
      return *(FilteringSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_filteringSettings));
    }
    [param: In] set
    {
      *(FilteringSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_filteringSettings)) = value;
    }
  }

  public unsafe ShaderTagId tagName
  {
    get
    {
      return *(ShaderTagId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagName));
    }
    [param: In] set
    {
      *(ShaderTagId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagName)) = value;
    }
  }

  public unsafe bool isPassTagName
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_isPassTagName));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_isPassTagName)) = value;
    }
  }

  public Il2CppSystem.Nullable<NativeArray<ShaderTagId>> tagValues
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagValues);
      return new Il2CppSystem.Nullable<NativeArray<ShaderTagId>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<NativeArray<ShaderTagId>>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagValues), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<NativeArray<ShaderTagId>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<NativeArray<RenderStateBlock>> stateBlocks
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_stateBlocks);
      return new Il2CppSystem.Nullable<NativeArray<RenderStateBlock>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<NativeArray<RenderStateBlock>>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_stateBlocks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<NativeArray<RenderStateBlock>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public static bool operator ==(RendererListParams left, RendererListParams right)
  {
    return ((RendererListParams) ref left).Equals(right);
  }

  public static bool operator !=(RendererListParams left, RendererListParams right)
  {
    return !((RendererListParams) ref left).Equals(right);
  }
}
