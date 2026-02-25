// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SupportedOnRenderPipelineAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public class SupportedOnRenderPipelineAttribute : Il2CppSystem.Attribute
{
  private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultRenderPipelineAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderPipelineTypes_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPipelineTypes_Public_get_Il2CppReferenceArray_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSupportedMode_Public_SupportedMode_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSupportedMode_Internal_Static_SupportedMode_Il2CppReferenceArray_1_Type_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTypeSupportedOnRenderPipeline_Public_Static_Boolean_Type_Type_0;

  static SupportedOnRenderPipelineAttribute()
  {
    Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SupportedOnRenderPipelineAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr);
    SupportedOnRenderPipelineAttribute.NativeFieldInfoPtr_k_DefaultRenderPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, nameof (k_DefaultRenderPipelineAsset));
    SupportedOnRenderPipelineAttribute.NativeFieldInfoPtr__renderPipelineTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, "<renderPipelineTypes>k__BackingField");
    SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_get_renderPipelineTypes_Public_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, 100670259);
    SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, 100670260);
    SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, 100670261);
    SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_GetSupportedMode_Public_SupportedMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, 100670262);
    SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_GetSupportedMode_Internal_Static_SupportedMode_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, 100670263);
    SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_IsTypeSupportedOnRenderPipeline_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, 100670264);
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Type> renderPipelineTypes
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_get_renderPipelineTypes_Public_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486885, XrefRangeEnd = 486894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SupportedOnRenderPipelineAttribute(Il2CppSystem.Type renderPipeline)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipeline)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 486932, RefRangeEnd = 486933, XrefRangeStart = 486894, XrefRangeEnd = 486932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SupportedOnRenderPipelineAttribute([Optional] Il2CppReferenceArray<Il2CppSystem.Type> renderPipeline)
  {
    if (renderPipeline == null)
      renderPipeline = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipeline)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486933, XrefRangeEnd = 486943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(
    Il2CppSystem.Type renderPipelineAssetType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipelineAssetType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_GetSupportedMode_Public_SupportedMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SupportedOnRenderPipelineAttribute.SupportedMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486943, XrefRangeEnd = 486950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(
    Il2CppReferenceArray<Il2CppSystem.Type> renderPipelineTypes,
    Il2CppSystem.Type renderPipelineAssetType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipelineTypes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipelineAssetType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_GetSupportedMode_Internal_Static_SupportedMode_Il2CppReferenceArray_1_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SupportedOnRenderPipelineAttribute.SupportedMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 486953, RefRangeEnd = 486954, XrefRangeStart = 486950, XrefRangeEnd = 486953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsTypeSupportedOnRenderPipeline(Il2CppSystem.Type type, Il2CppSystem.Type renderPipelineAssetType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderPipelineAssetType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.NativeMethodInfoPtr_IsTypeSupportedOnRenderPipeline_Public_Static_Boolean_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public SupportedOnRenderPipelineAttribute(params Il2CppSystem.Type[] renderPipeline)
    : this(new Il2CppReferenceArray<Il2CppSystem.Type>(renderPipeline))
  {
  }

  public SupportedOnRenderPipelineAttribute(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppSystem.Lazy<Il2CppReferenceArray<Il2CppSystem.Type>> k_DefaultRenderPipelineAsset
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SupportedOnRenderPipelineAttribute.NativeFieldInfoPtr_k_DefaultRenderPipelineAsset, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Lazy<Il2CppReferenceArray<Il2CppSystem.Type>>) null : Il2CppObjectPool.Get<Il2CppSystem.Lazy<Il2CppReferenceArray<Il2CppSystem.Type>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SupportedOnRenderPipelineAttribute.NativeFieldInfoPtr_k_DefaultRenderPipelineAsset, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Type> _renderPipelineTypes_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SupportedOnRenderPipelineAttribute.NativeFieldInfoPtr__renderPipelineTypes_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SupportedOnRenderPipelineAttribute.NativeFieldInfoPtr__renderPipelineTypes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public bool isSupportedOnCurrentPipeline
  {
    get
    {
      return SupportedOnRenderPipelineAttribute.GetSupportedMode(this.renderPipelineTypes, GraphicsSettings.currentRenderPipelineAssetType) != 0;
    }
  }

  public enum SupportedMode
  {
    Unsupported,
    Supported,
    SupportedByBaseClass,
  }

  [ObfuscatedName("UnityEngine.Rendering.SupportedOnRenderPipelineAttribute+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_String_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__12_0_Internal_Il2CppReferenceArray_1_Type_0;

    static __c()
    {
      Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr);
      SupportedOnRenderPipelineAttribute.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr, "<>9");
      SupportedOnRenderPipelineAttribute.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr, "<>9__6_0");
      SupportedOnRenderPipelineAttribute.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr, 100670267);
      SupportedOnRenderPipelineAttribute.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr, 100670268);
      SupportedOnRenderPipelineAttribute.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr, 100670269);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedOnRenderPipelineAttribute.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string __ctor_b__6_0(Il2CppSystem.Type t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486876, XrefRangeEnd = 486885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<Il2CppSystem.Type> __cctor_b__12_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SupportedOnRenderPipelineAttribute.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
    }

    public static unsafe SupportedOnRenderPipelineAttribute.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(SupportedOnRenderPipelineAttribute.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (SupportedOnRenderPipelineAttribute.__c) null : Il2CppObjectPool.Get<SupportedOnRenderPipelineAttribute.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SupportedOnRenderPipelineAttribute.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Type, string> __9__6_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(SupportedOnRenderPipelineAttribute.__c.NativeFieldInfoPtr___9__6_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Type, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Type, string>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SupportedOnRenderPipelineAttribute.__c.NativeFieldInfoPtr___9__6_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }
}
