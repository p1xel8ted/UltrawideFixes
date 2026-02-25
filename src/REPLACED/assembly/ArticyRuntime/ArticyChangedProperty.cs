// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyChangedProperty
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

public sealed class ArticyChangedProperty : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Property_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OldValue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__NewValue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ObjectReference_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Property_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Property_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OldValue_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OldValue_Internal_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NewValue_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NewValue_Internal_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ObjectReference_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ObjectReference_Internal_set_Void_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArticyRef_String_Object_Object_0;

  static ArticyChangedProperty()
  {
    Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyChangedProperty));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr);
    ArticyChangedProperty.NativeFieldInfoPtr__Property_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, "<Property>k__BackingField");
    ArticyChangedProperty.NativeFieldInfoPtr__OldValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, "<OldValue>k__BackingField");
    ArticyChangedProperty.NativeFieldInfoPtr__NewValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, "<NewValue>k__BackingField");
    ArticyChangedProperty.NativeFieldInfoPtr__ObjectReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, "<ObjectReference>k__BackingField");
    ArticyChangedProperty.NativeMethodInfoPtr_get_Property_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664230);
    ArticyChangedProperty.NativeMethodInfoPtr_set_Property_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664231);
    ArticyChangedProperty.NativeMethodInfoPtr_get_OldValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664232);
    ArticyChangedProperty.NativeMethodInfoPtr_set_OldValue_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664233);
    ArticyChangedProperty.NativeMethodInfoPtr_get_NewValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664234);
    ArticyChangedProperty.NativeMethodInfoPtr_set_NewValue_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664235);
    ArticyChangedProperty.NativeMethodInfoPtr_get_ObjectReference_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664236);
    ArticyChangedProperty.NativeMethodInfoPtr_set_ObjectReference_Internal_set_Void_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664237);
    ArticyChangedProperty.NativeMethodInfoPtr__ctor_Internal_Void_ArticyRef_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr, 100664238);
  }

  public unsafe string Property
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_get_Property_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_set_Property_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Object OldValue
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_get_OldValue_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_set_OldValue_Internal_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Object NewValue
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_get_NewValue_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_set_NewValue_Internal_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyRef ObjectReference
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_get_ObjectReference_Public_get_ArticyRef_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr_set_ObjectReference_Internal_set_Void_ArticyRef_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe ArticyChangedProperty(
    ArticyRef aObjectRef,
    string aProp,
    Il2CppSystem.Object aOldValue,
    Il2CppSystem.Object aNewValue)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObjectRef);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyChangedProperty.NativeMethodInfoPtr__ctor_Internal_Void_ArticyRef_String_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ArticyChangedProperty(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ArticyChangedProperty()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyChangedProperty>.NativeClassPtr))
  {
  }

  public unsafe string _Property_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__Property_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__Property_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppSystem.Object _OldValue_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__OldValue_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__OldValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Object _NewValue_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__NewValue_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__NewValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef _ObjectReference_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__ObjectReference_k__BackingField));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyChangedProperty.NativeFieldInfoPtr__ObjectReference_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
