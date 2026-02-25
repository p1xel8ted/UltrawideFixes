// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyString
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyString(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwner;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPropertyPath;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Owner_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyPath_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnresolvedValue_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnresolvedValue_Public_Virtual_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyRef_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyString_String_0;

  static ArticyString()
  {
    Il2CppClassPointerStore<ArticyString>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyString));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyString>.NativeClassPtr);
    ArticyString.NativeFieldInfoPtr_mValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, nameof (mValue));
    ArticyString.NativeFieldInfoPtr_mOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, nameof (mOwner));
    ArticyString.NativeFieldInfoPtr_mPropertyPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, nameof (mPropertyPath));
    ArticyString.NativeMethodInfoPtr_get_Owner_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663842);
    ArticyString.NativeMethodInfoPtr_get_PropertyPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663843);
    ArticyString.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663844);
    ArticyString.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663845);
    ArticyString.NativeMethodInfoPtr_get_UnresolvedValue_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663846);
    ArticyString.NativeMethodInfoPtr_set_UnresolvedValue_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663847);
    ArticyString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663848);
    ArticyString.NativeMethodInfoPtr__ctor_Public_Void_ArticyRef_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663849);
    ArticyString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663850);
    ArticyString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663851);
    ArticyString.NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyString>.NativeClassPtr, 100663852);
  }

  public unsafe ArticyRef Owner
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyString.NativeMethodInfoPtr_get_Owner_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
  }

  public unsafe string PropertyPath
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyString.NativeMethodInfoPtr_get_PropertyPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string Value
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 991289, RefRangeEnd = 991290, XrefRangeStart = 991279, XrefRangeEnd = 991289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyString.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 152955, RefRangeEnd = 152957, XrefRangeStart = 152955, XrefRangeEnd = 152957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyString.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string UnresolvedValue
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyString.NativeMethodInfoPtr_get_UnresolvedValue_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991290, XrefRangeEnd = 991295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyString.NativeMethodInfoPtr_set_UnresolvedValue_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyString()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyString>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 991296, RefRangeEnd = 991297, XrefRangeStart = 991295, XrefRangeEnd = 991296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyString(ArticyRef aOwner, string aPropertyName, string aValue)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyString>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOwner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPropertyName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyString.NativeMethodInfoPtr__ctor_Public_Void_ArticyRef_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(42)]
  [CachedScanResults(RefRangeStart = 991298, RefRangeEnd = 991340, XrefRangeStart = 991297, XrefRangeEnd = 991298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(42)]
  [CachedScanResults(RefRangeStart = 991298, RefRangeEnd = 991340, XrefRangeStart = 991298, XrefRangeEnd = 991340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator string(ArticyString aArticyString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ArticyString_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 991344, RefRangeEnd = 991360, XrefRangeStart = 991340, XrefRangeEnd = 991344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ArticyString(string aStr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aStr)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyString.NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyString_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyString) null : Il2CppObjectPool.Get<ArticyString>(num3);
  }

  public unsafe string mValue
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyString.NativeFieldInfoPtr_mValue)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyString.NativeFieldInfoPtr_mValue), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ArticyRef mOwner
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyString.NativeFieldInfoPtr_mOwner));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyString.NativeFieldInfoPtr_mOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mPropertyPath
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyString.NativeFieldInfoPtr_mPropertyPath)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyString.NativeFieldInfoPtr_mPropertyPath), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
