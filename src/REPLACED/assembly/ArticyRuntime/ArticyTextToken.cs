// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyTextToken
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyTextToken : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Token_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Expression_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Params_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TokenIndex_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ContextObject_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Token_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Token_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Expression_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Expression_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Params_Internal_set_Void_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TokenIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TokenIndex_Internal_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ContextObject_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ContextObject_Internal_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_Object_0;

  static ArticyTextToken()
  {
    Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyTextToken));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr);
    ArticyTextToken.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, "<Token>k__BackingField");
    ArticyTextToken.NativeFieldInfoPtr__Expression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, "<Expression>k__BackingField");
    ArticyTextToken.NativeFieldInfoPtr__Params_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, "<Params>k__BackingField");
    ArticyTextToken.NativeFieldInfoPtr__TokenIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, "<TokenIndex>k__BackingField");
    ArticyTextToken.NativeFieldInfoPtr__ContextObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, "<ContextObject>k__BackingField");
    ArticyTextToken.NativeMethodInfoPtr_get_Token_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663902);
    ArticyTextToken.NativeMethodInfoPtr_set_Token_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663903);
    ArticyTextToken.NativeMethodInfoPtr_get_Expression_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663904 /*0x06000260*/);
    ArticyTextToken.NativeMethodInfoPtr_set_Expression_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663905);
    ArticyTextToken.NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663906);
    ArticyTextToken.NativeMethodInfoPtr_set_Params_Internal_set_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663907);
    ArticyTextToken.NativeMethodInfoPtr_get_TokenIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663908);
    ArticyTextToken.NativeMethodInfoPtr_set_TokenIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663909);
    ArticyTextToken.NativeMethodInfoPtr_get_ContextObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663910);
    ArticyTextToken.NativeMethodInfoPtr_set_ContextObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663911);
    ArticyTextToken.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr, 100663912);
  }

  public unsafe string Token
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_get_Token_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_set_Token_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Expression
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_get_Expression_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_set_Expression_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> Params
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_set_Params_Internal_set_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int TokenIndex
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_get_TokenIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_set_TokenIndex_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Object ContextObject
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_get_ContextObject_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr_set_ContextObject_Internal_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991992, XrefRangeEnd = 991993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyTextToken(
    string aExpression,
    Il2CppReferenceArray<Il2CppSystem.Object> aParams,
    Il2CppSystem.Object aContextObject)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aExpression);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aContextObject);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextToken.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ArticyTextToken(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ArticyTextToken()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTextToken>.NativeClassPtr))
  {
  }

  public unsafe string _Token_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__Token_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__Token_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _Expression_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__Expression_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__Expression_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> _Params_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__Params_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__Params_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _TokenIndex_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__TokenIndex_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__TokenIndex_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppSystem.Object _ContextObject_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__ContextObject_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextToken.NativeFieldInfoPtr__ContextObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
