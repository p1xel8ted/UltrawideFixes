// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.BaseReferenceConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Constraints;

public class BaseReferenceConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mAllowedModelTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAllowedModelTemplates;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlaceHolder_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AssetCategory_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaceHolder_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlaceHolder_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AssetCategory_Public_get_AssetCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AssetCategory_Private_set_Void_AssetCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_ArticyObject_0;

  static BaseReferenceConstraint()
  {
    Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (BaseReferenceConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr);
    BaseReferenceConstraint.NativeFieldInfoPtr_mAllowedModelTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, nameof (mAllowedModelTypes));
    BaseReferenceConstraint.NativeFieldInfoPtr_mAllowedModelTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, nameof (mAllowedModelTemplates));
    BaseReferenceConstraint.NativeFieldInfoPtr__PlaceHolder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, "<PlaceHolder>k__BackingField");
    BaseReferenceConstraint.NativeFieldInfoPtr__AssetCategory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, "<AssetCategory>k__BackingField");
    BaseReferenceConstraint.NativeMethodInfoPtr_get_PlaceHolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664591 /*0x0600050F*/);
    BaseReferenceConstraint.NativeMethodInfoPtr_set_PlaceHolder_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664592 /*0x06000510*/);
    BaseReferenceConstraint.NativeMethodInfoPtr_get_AssetCategory_Public_get_AssetCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664593);
    BaseReferenceConstraint.NativeMethodInfoPtr_set_AssetCategory_Private_set_Void_AssetCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664594);
    BaseReferenceConstraint.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664595);
    BaseReferenceConstraint.NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664596);
    BaseReferenceConstraint.NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664597);
    BaseReferenceConstraint.NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr, 100664598);
  }

  public unsafe string PlaceHolder
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr_get_PlaceHolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr_set_PlaceHolder_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AssetCategory AssetCategory
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr_get_AssetCategory_Public_get_AssetCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AssetCategory*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr_set_AssetCategory_Private_set_Void_AssetCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 1000070, RefRangeEnd = 1000073, XrefRangeStart = 1000025, XrefRangeEnd = 1000070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseReferenceConstraint(
    string aAllowedModelTypes,
    string aPlaceholderValue,
    string aAllowedAssetCategories,
    string aAllowedModelTemplates)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aAllowedModelTypes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPlaceholderValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedAssetCategories);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedModelTemplates);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1000076, RefRangeEnd = 1000077, XrefRangeStart = 1000073, XrefRangeEnd = 1000076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanBeReferenced(Il2CppSystem.Type aModelType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aModelType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000077, XrefRangeEnd = 1000082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanBeReferenced<TModelType>() where TModelType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.MethodInfoStoreGeneric_CanBeReferenced_Public_Boolean_0<TModelType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000082, XrefRangeEnd = 1000096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanBeReferenced(ArticyObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseReferenceConstraint.NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe HashSet<string> mAllowedModelTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr_mAllowedModelTypes));
      return num == System.IntPtr.Zero ? (HashSet<string>) null : Il2CppObjectPool.Get<HashSet<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr_mAllowedModelTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<string> mAllowedModelTemplates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr_mAllowedModelTemplates));
      return num == System.IntPtr.Zero ? (HashSet<string>) null : Il2CppObjectPool.Get<HashSet<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr_mAllowedModelTemplates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _PlaceHolder_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr__PlaceHolder_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr__PlaceHolder_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe AssetCategory _AssetCategory_k__BackingField
  {
    get
    {
      return *(AssetCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr__AssetCategory_k__BackingField));
    }
    [param: In] set
    {
      *(AssetCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseReferenceConstraint.NativeFieldInfoPtr__AssetCategory_k__BackingField)) = value;
    }
  }

  private sealed class MethodInfoStoreGeneric_CanBeReferenced_Public_Boolean_0<TModelType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseReferenceConstraint.NativeMethodInfoPtr_CanBeReferenced_Public_Boolean_0, Il2CppClassPointerStore<BaseReferenceConstraint>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModelType>.NativeClassPtr))
    }))));
  }
}
