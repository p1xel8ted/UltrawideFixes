// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyPropertyInfo
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyPropertyInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PropertyType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTechnicalName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsTemplateProperty;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPropertyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraintNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraintValues;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PropertyType_Internal_set_Void_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalName_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocaKey_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTemplateProperty_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsTemplateProperty_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_get_Dictionary_2_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetConstraint_Public_String_ArticyPropertyConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetConstraint_Public_TValue_ArticyPropertyConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_ArticyObject_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_TValue_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVariableType_Internal_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyPropertyInfo()
  {
    Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyPropertyInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr);
    ArticyPropertyInfo.NativeFieldInfoPtr__PropertyType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, "<PropertyType>k__BackingField");
    ArticyPropertyInfo.NativeFieldInfoPtr_mTechnicalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mTechnicalName));
    ArticyPropertyInfo.NativeFieldInfoPtr_mDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mDisplayName));
    ArticyPropertyInfo.NativeFieldInfoPtr_mIsTemplateProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mIsTemplateProperty));
    ArticyPropertyInfo.NativeFieldInfoPtr_mPropertyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mPropertyType));
    ArticyPropertyInfo.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mConstraints));
    ArticyPropertyInfo.NativeFieldInfoPtr_mConstraintNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mConstraintNames));
    ArticyPropertyInfo.NativeFieldInfoPtr_mConstraintValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, nameof (mConstraintValues));
    ArticyPropertyInfo.NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663636);
    ArticyPropertyInfo.NativeMethodInfoPtr_set_PropertyType_Internal_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663637);
    ArticyPropertyInfo.NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663638);
    ArticyPropertyInfo.NativeMethodInfoPtr_set_TechnicalName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663639);
    ArticyPropertyInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663640);
    ArticyPropertyInfo.NativeMethodInfoPtr_set_DisplayName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663641);
    ArticyPropertyInfo.NativeMethodInfoPtr_get_LocaKey_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663642);
    ArticyPropertyInfo.NativeMethodInfoPtr_get_IsTemplateProperty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663643);
    ArticyPropertyInfo.NativeMethodInfoPtr_set_IsTemplateProperty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663644);
    ArticyPropertyInfo.NativeMethodInfoPtr_get_Constraints_Public_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663645);
    ArticyPropertyInfo.NativeMethodInfoPtr_GetConstraint_Public_String_ArticyPropertyConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663646);
    ArticyPropertyInfo.NativeMethodInfoPtr_GetConstraint_Public_TValue_ArticyPropertyConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663647);
    ArticyPropertyInfo.NativeMethodInfoPtr_SetValue_Public_Void_ArticyObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663648 /*0x06000160*/);
    ArticyPropertyInfo.NativeMethodInfoPtr_GetValue_Public_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663649);
    ArticyPropertyInfo.NativeMethodInfoPtr_GetValue_Public_TValue_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663650);
    ArticyPropertyInfo.NativeMethodInfoPtr_SetVariableType_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663651);
    ArticyPropertyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663652);
    ArticyPropertyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663653);
    ArticyPropertyInfo.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663654);
    ArticyPropertyInfo.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663655);
    ArticyPropertyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr, 100663656);
  }

  public unsafe Il2CppSystem.Type PropertyType
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_set_PropertyType_Internal_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TechnicalName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_set_TechnicalName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 989227, RefRangeEnd = 989229, XrefRangeStart = 989218, XrefRangeEnd = 989227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_set_DisplayName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LocaKey_DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989229, XrefRangeEnd = 989238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_get_LocaKey_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe bool IsTemplateProperty
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_get_IsTemplateProperty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_set_IsTemplateProperty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Dictionary<int, string> Constraints
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_get_Constraints_Public_get_Dictionary_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<int, string>) null : Il2CppObjectPool.Get<Dictionary<int, string>>(num3);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 989242, RefRangeEnd = 989244, XrefRangeStart = 989238, XrefRangeEnd = 989242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetConstraint(ArticyPropertyConstraint aConstraint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aConstraint
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_GetConstraint_Public_String_ArticyPropertyConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989244, XrefRangeEnd = 989257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TValue GetConstraint<TValue>(ArticyPropertyConstraint aConstraint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aConstraint
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.MethodInfoStoreGeneric_GetConstraint_Public_TValue_ArticyPropertyConstraint_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TValue>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989257, XrefRangeEnd = 989258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(ArticyObject aTarget, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_SetValue_Public_Void_ArticyObject_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 989260, RefRangeEnd = 989266, XrefRangeStart = 989258, XrefRangeEnd = 989260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Object GetValue(ArticyObject aTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_GetValue_Public_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989266, XrefRangeEnd = 989284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TValue GetValue<TValue>(ArticyObject aTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTarget)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.MethodInfoStoreGeneric_GetValue_Public_TValue_ArticyObject_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TValue>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989284, XrefRangeEnd = 989369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVariableType(string aTypeName, string aGenericParam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTypeName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aGenericParam);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_SetVariableType_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989369, XrefRangeEnd = 989370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyPropertyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989370, XrefRangeEnd = 989375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object aOther)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOther)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyPropertyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989375, XrefRangeEnd = 989405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989405, XrefRangeEnd = 989427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989427, XrefRangeEnd = 989446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyPropertyInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPropertyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Type _PropertyType_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr__PropertyType_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr__PropertyType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mTechnicalName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mTechnicalName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mTechnicalName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string mDisplayName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mDisplayName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool mIsTemplateProperty
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mIsTemplateProperty));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mIsTemplateProperty)) = value;
    }
  }

  public unsafe string mPropertyType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mPropertyType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mPropertyType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Dictionary<int, string> mConstraints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mConstraints));
      return num == System.IntPtr.Zero ? (Dictionary<int, string>) null : Il2CppObjectPool.Get<Dictionary<int, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mConstraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> mConstraintNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mConstraintNames));
      return num == System.IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mConstraintNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mConstraintValues
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mConstraintValues));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPropertyInfo.NativeFieldInfoPtr_mConstraintValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetConstraint_Public_TValue_ArticyPropertyConstraint_0<TValue>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyPropertyInfo.NativeMethodInfoPtr_GetConstraint_Public_TValue_ArticyPropertyConstraint_0, Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetValue_Public_TValue_ArticyObject_0<TValue>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyPropertyInfo.NativeMethodInfoPtr_GetValue_Public_TValue_ArticyObject_0, Il2CppClassPointerStore<ArticyPropertyInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
    }))));
  }
}
