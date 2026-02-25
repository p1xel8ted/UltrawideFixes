// Decompiled with JetBrains decompiler
// Type: Articy.Unity.TextExtensionResolvedToken
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public class TextExtensionResolvedToken(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Expression_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PurgedExpression_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ResolvedValue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Type_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PropertyInfo_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Expression_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Expression_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PurgedExpression_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PurgedExpression_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResolvedValue_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ResolvedValue_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_TokenType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Internal_set_Void_TokenType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyInfo_Public_get_TextExtensionPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PropertyInfo_Internal_set_Void_TextExtensionPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_TokenType_String_TextExtensionPropertyInfo_0;

  static TextExtensionResolvedToken()
  {
    Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (TextExtensionResolvedToken));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr);
    TextExtensionResolvedToken.NativeFieldInfoPtr__Expression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, "<Expression>k__BackingField");
    TextExtensionResolvedToken.NativeFieldInfoPtr__PurgedExpression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, "<PurgedExpression>k__BackingField");
    TextExtensionResolvedToken.NativeFieldInfoPtr__ResolvedValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, "<ResolvedValue>k__BackingField");
    TextExtensionResolvedToken.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, "<Type>k__BackingField");
    TextExtensionResolvedToken.NativeFieldInfoPtr__PropertyInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, "<PropertyInfo>k__BackingField");
    TextExtensionResolvedToken.NativeMethodInfoPtr_get_Expression_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663882);
    TextExtensionResolvedToken.NativeMethodInfoPtr_set_Expression_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663883);
    TextExtensionResolvedToken.NativeMethodInfoPtr_get_PurgedExpression_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663884);
    TextExtensionResolvedToken.NativeMethodInfoPtr_set_PurgedExpression_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663885);
    TextExtensionResolvedToken.NativeMethodInfoPtr_get_ResolvedValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663886);
    TextExtensionResolvedToken.NativeMethodInfoPtr_set_ResolvedValue_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663887);
    TextExtensionResolvedToken.NativeMethodInfoPtr_get_Type_Public_get_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663888 /*0x06000250*/);
    TextExtensionResolvedToken.NativeMethodInfoPtr_set_Type_Internal_set_Void_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663889);
    TextExtensionResolvedToken.NativeMethodInfoPtr_get_PropertyInfo_Public_get_TextExtensionPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663890);
    TextExtensionResolvedToken.NativeMethodInfoPtr_set_PropertyInfo_Internal_set_Void_TextExtensionPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663891);
    TextExtensionResolvedToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_TokenType_String_TextExtensionPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr, 100663892);
  }

  public unsafe string Expression
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_get_Expression_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_set_Expression_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string PurgedExpression
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_get_PurgedExpression_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_set_PurgedExpression_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ResolvedValue
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_get_ResolvedValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_set_ResolvedValue_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe TokenType Type
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_get_Type_Public_get_TokenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TokenType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_set_Type_Internal_set_Void_TokenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe TextExtensionPropertyInfo PropertyInfo
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_get_PropertyInfo_Public_get_TextExtensionPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextExtensionPropertyInfo) null : Il2CppObjectPool.Get<TextExtensionPropertyInfo>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr_set_PropertyInfo_Internal_set_Void_TextExtensionPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 991987, RefRangeEnd = 991988, XrefRangeStart = 991982, XrefRangeEnd = 991987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextExtensionResolvedToken(
    string aToken,
    string aPurgedToken = null,
    TokenType aType = TokenType.Unknown,
    string aValue = null,
    TextExtensionPropertyInfo aPropInfo = null)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextExtensionResolvedToken>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aToken);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPurgedToken);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPropInfo);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextExtensionResolvedToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_TokenType_String_TextExtensionPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _Expression_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__Expression_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__Expression_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _PurgedExpression_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__PurgedExpression_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__PurgedExpression_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _ResolvedValue_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__ResolvedValue_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__ResolvedValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe TokenType _Type_k__BackingField
  {
    get
    {
      return *(TokenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__Type_k__BackingField));
    }
    [param: In] set
    {
      *(TokenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__Type_k__BackingField)) = value;
    }
  }

  public unsafe TextExtensionPropertyInfo _PropertyInfo_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__PropertyInfo_k__BackingField));
      return num == System.IntPtr.Zero ? (TextExtensionPropertyInfo) null : Il2CppObjectPool.Get<TextExtensionPropertyInfo>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionResolvedToken.NativeFieldInfoPtr__PropertyInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
