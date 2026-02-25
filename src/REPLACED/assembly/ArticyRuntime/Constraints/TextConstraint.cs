// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.TextConstraint
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
namespace Articy.Unity.Constraints;

public sealed class TextConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__MaxLength_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Placeholder_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DisallowedChars_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsLocalized_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AllowsLineBreak_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxLength_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxLength_Private_set_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Placeholder_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Placeholder_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisallowedChars_Public_get_Il2CppStructArray_1_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisallowedChars_Private_set_Void_Il2CppStructArray_1_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalized_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLocalized_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowsLineBreak_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowsLineBreak_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_String_String_Boolean_Boolean_0;

  static TextConstraint()
  {
    Il2CppClassPointerStore<TextConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (TextConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr);
    TextConstraint.NativeFieldInfoPtr__MaxLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, "<MaxLength>k__BackingField");
    TextConstraint.NativeFieldInfoPtr__Placeholder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, "<Placeholder>k__BackingField");
    TextConstraint.NativeFieldInfoPtr__DisallowedChars_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, "<DisallowedChars>k__BackingField");
    TextConstraint.NativeFieldInfoPtr__IsLocalized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, "<IsLocalized>k__BackingField");
    TextConstraint.NativeFieldInfoPtr__AllowsLineBreak_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, "<AllowsLineBreak>k__BackingField");
    TextConstraint.NativeMethodInfoPtr_get_MaxLength_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664632);
    TextConstraint.NativeMethodInfoPtr_set_MaxLength_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664633);
    TextConstraint.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664634);
    TextConstraint.NativeMethodInfoPtr_set_Placeholder_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664635);
    TextConstraint.NativeMethodInfoPtr_get_DisallowedChars_Public_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664636);
    TextConstraint.NativeMethodInfoPtr_set_DisallowedChars_Private_set_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664637);
    TextConstraint.NativeMethodInfoPtr_get_IsLocalized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664638);
    TextConstraint.NativeMethodInfoPtr_set_IsLocalized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664639);
    TextConstraint.NativeMethodInfoPtr_get_AllowsLineBreak_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664640 /*0x06000540*/);
    TextConstraint.NativeMethodInfoPtr_set_AllowsLineBreak_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664641);
    TextConstraint.NativeMethodInfoPtr__ctor_Public_Void_Double_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr, 100664642);
  }

  public unsafe double MaxLength
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_get_MaxLength_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_set_MaxLength_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Placeholder
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_set_Placeholder_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<char> DisallowedChars
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_get_DisallowedChars_Public_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<char>) null : Il2CppObjectPool.Get<Il2CppStructArray<char>>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_set_DisallowedChars_Private_set_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsLocalized
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_get_IsLocalized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_set_IsLocalized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowsLineBreak
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_get_AllowsLineBreak_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr_set_AllowsLineBreak_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 1000139, RefRangeEnd = 1000166, XrefRangeStart = 1000137, XrefRangeEnd = 1000139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextConstraint(
    double aMaxLength,
    string aPlaceholderValue,
    string aDisallowedChars,
    bool aIsLocalized,
    bool aAllowsLineBreak)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &aMaxLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPlaceholderValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aDisallowedChars);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aIsLocalized;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aAllowsLineBreak;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextConstraint.NativeMethodInfoPtr__ctor_Public_Void_Double_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe double _MaxLength_k__BackingField
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__MaxLength_k__BackingField));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__MaxLength_k__BackingField)) = value;
    }
  }

  public unsafe string _Placeholder_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__Placeholder_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__Placeholder_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStructArray<char> _DisallowedChars_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__DisallowedChars_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<char>) null : Il2CppObjectPool.Get<Il2CppStructArray<char>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__DisallowedChars_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsLocalized_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__IsLocalized_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__IsLocalized_k__BackingField)) = value;
    }
  }

  public unsafe bool _AllowsLineBreak_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__AllowsLineBreak_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextConstraint.NativeFieldInfoPtr__AllowsLineBreak_k__BackingField)) = value;
    }
  }
}
