// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyType
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
public sealed class ArticyType(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr__CSharpType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTechnicalName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBaseType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCSharpType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsEnum;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHasTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeatures;
  private static readonly System.IntPtr NativeFieldInfoPtr_mProperties;
  private static readonly System.IntPtr NativeFieldInfoPtr_mEnumValues;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalName_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocaKey_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseType_Public_get_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BaseType_Internal_set_Void_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CSharpType_Public_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CSharpType_Internal_set_Void_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnum_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsEnum_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EnumValues_Public_get_List_1_ArticyEnumValueInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasTemplate_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HasTemplate_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Features_Public_get_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Properties_Public_get_List_1_ArticyPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProperty_Public_ArticyPropertyInfo_String_ArticyTypeProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_ArticyPropertyInfo_String_ArticyTypeProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertiesInFeature_Public_IList_1_ArticyPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertiesInFeature_Public_List_1_ArticyPropertyInfo_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertiesInFeature_Public_List_1_ArticyPropertyInfo_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumValue_Public_ArticyEnumValueInfo_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumValue_Public_ArticyEnumValueInfo_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCSharpType_Internal_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureNameFromType_Private_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

  static ArticyType()
  {
    Il2CppClassPointerStore<ArticyType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyType>.NativeClassPtr);
    ArticyType.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (Logger));
    ArticyType.NativeFieldInfoPtr__CSharpType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, "<CSharpType>k__BackingField");
    ArticyType.NativeFieldInfoPtr_mTechnicalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mTechnicalName));
    ArticyType.NativeFieldInfoPtr_mDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mDisplayName));
    ArticyType.NativeFieldInfoPtr_mBaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mBaseType));
    ArticyType.NativeFieldInfoPtr_mCSharpType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mCSharpType));
    ArticyType.NativeFieldInfoPtr_mIsEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mIsEnum));
    ArticyType.NativeFieldInfoPtr_mHasTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mHasTemplate));
    ArticyType.NativeFieldInfoPtr_mFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mFeatures));
    ArticyType.NativeFieldInfoPtr_mProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mProperties));
    ArticyType.NativeFieldInfoPtr_mEnumValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, nameof (mEnumValues));
    ArticyType.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663958);
    ArticyType.NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663959);
    ArticyType.NativeMethodInfoPtr_set_TechnicalName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663960);
    ArticyType.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663961);
    ArticyType.NativeMethodInfoPtr_set_DisplayName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663962);
    ArticyType.NativeMethodInfoPtr_get_LocaKey_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663963);
    ArticyType.NativeMethodInfoPtr_get_BaseType_Public_get_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663964);
    ArticyType.NativeMethodInfoPtr_set_BaseType_Internal_set_Void_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663965);
    ArticyType.NativeMethodInfoPtr_get_CSharpType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663966);
    ArticyType.NativeMethodInfoPtr_set_CSharpType_Internal_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663967);
    ArticyType.NativeMethodInfoPtr_get_IsEnum_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663968 /*0x060002A0*/);
    ArticyType.NativeMethodInfoPtr_set_IsEnum_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663969);
    ArticyType.NativeMethodInfoPtr_get_EnumValues_Public_get_List_1_ArticyEnumValueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663970);
    ArticyType.NativeMethodInfoPtr_get_HasTemplate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663971);
    ArticyType.NativeMethodInfoPtr_set_HasTemplate_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663972);
    ArticyType.NativeMethodInfoPtr_get_Features_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663973);
    ArticyType.NativeMethodInfoPtr_get_Properties_Public_get_List_1_ArticyPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663974);
    ArticyType.NativeMethodInfoPtr_GetProperty_Public_ArticyPropertyInfo_String_ArticyTypeProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663975);
    ArticyType.NativeMethodInfoPtr_GetProperties_Public_List_1_ArticyPropertyInfo_String_ArticyTypeProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663976);
    ArticyType.NativeMethodInfoPtr_GetPropertiesInFeature_Public_IList_1_ArticyPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663977);
    ArticyType.NativeMethodInfoPtr_GetPropertiesInFeature_Public_List_1_ArticyPropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663978);
    ArticyType.NativeMethodInfoPtr_GetPropertiesInFeature_Public_List_1_ArticyPropertyInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663979);
    ArticyType.NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663980);
    ArticyType.NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663981);
    ArticyType.NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663982);
    ArticyType.NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663983);
    ArticyType.NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663984 /*0x060002B0*/);
    ArticyType.NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663985);
    ArticyType.NativeMethodInfoPtr_GetEnumValue_Public_ArticyEnumValueInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663986);
    ArticyType.NativeMethodInfoPtr_GetEnumValue_Public_ArticyEnumValueInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663987);
    ArticyType.NativeMethodInfoPtr_SetCSharpType_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663988);
    ArticyType.NativeMethodInfoPtr_GetFeatureNameFromType_Private_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663989);
    ArticyType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663990);
    ArticyType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663991);
    ArticyType.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663992);
    ArticyType.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyType>.NativeClassPtr, 100663993);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993080, XrefRangeEnd = 993099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyType>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string TechnicalName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_set_TechnicalName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993099, XrefRangeEnd = 993104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_set_DisplayName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LocaKey_DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993104, XrefRangeEnd = 993109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_LocaKey_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ArticyType BaseType
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_BaseType_Public_get_ArticyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_set_BaseType_Internal_set_Void_ArticyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Type CSharpType
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_CSharpType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_set_CSharpType_Internal_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsEnum
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_IsEnum_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_set_IsEnum_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<ArticyEnumValueInfo> EnumValues
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993109, XrefRangeEnd = 993115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_EnumValues_Public_get_List_1_ArticyEnumValueInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ArticyEnumValueInfo>) null : Il2CppObjectPool.Get<List<ArticyEnumValueInfo>>(num3);
    }
  }

  public unsafe bool HasTemplate
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_HasTemplate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_set_HasTemplate_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<string> Features
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 993121, RefRangeEnd = 993124, XrefRangeStart = 993115, XrefRangeEnd = 993121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_Features_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
    }
  }

  public unsafe List<ArticyPropertyInfo> Properties
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 993130, RefRangeEnd = 993135, XrefRangeStart = 993124, XrefRangeEnd = 993130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_get_Properties_Public_get_List_1_ArticyPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num3);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 993151, RefRangeEnd = 993153, XrefRangeStart = 993135, XrefRangeEnd = 993151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyPropertyInfo GetProperty(string aFilter, ArticyTypeProperties aFlags = ArticyTypeProperties.All)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetProperty_Public_ArticyPropertyInfo_String_ArticyTypeProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyPropertyInfo) null : Il2CppObjectPool.Get<ArticyPropertyInfo>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 993338, RefRangeEnd = 993345, XrefRangeStart = 993153, XrefRangeEnd = 993338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<ArticyPropertyInfo> GetProperties(string aFilter, ArticyTypeProperties aFlags = ArticyTypeProperties.All)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetProperties_Public_List_1_ArticyPropertyInfo_String_ArticyTypeProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993345, XrefRangeEnd = 993366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IList<ArticyPropertyInfo> GetPropertiesInFeature<TFeatureType>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.MethodInfoStoreGeneric_GetPropertiesInFeature_Public_IList_1_ArticyPropertyInfo_0<TFeatureType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<IList<ArticyPropertyInfo>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993389, RefRangeEnd = 993390, XrefRangeStart = 993366, XrefRangeEnd = 993389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<ArticyPropertyInfo> GetPropertiesInFeature(Il2CppSystem.Type aFeatureType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFeatureType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetPropertiesInFeature_Public_List_1_ArticyPropertyInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993390, XrefRangeEnd = 993419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<ArticyPropertyInfo> GetPropertiesInFeature(string aFeatureName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aFeatureName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetPropertiesInFeature_Public_List_1_ArticyPropertyInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993419, XrefRangeEnd = 993424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureDisplayName<TFeatureType>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.MethodInfoStoreGeneric_GetFeatureDisplayName_Public_String_0<TFeatureType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993441, RefRangeEnd = 993442, XrefRangeStart = 993424, XrefRangeEnd = 993441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureDisplayName(Il2CppSystem.Type aFeature)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFeature)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993442, XrefRangeEnd = 993464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureDisplayName(string aFeature)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aFeature)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993464, XrefRangeEnd = 993469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureDisplayNameLocaKey<TFeatureType>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.MethodInfoStoreGeneric_GetFeatureDisplayNameLocaKey_Public_String_0<TFeatureType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993486, RefRangeEnd = 993487, XrefRangeStart = 993469, XrefRangeEnd = 993486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureDisplayNameLocaKey(Il2CppSystem.Type aFeature)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFeature)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993487, XrefRangeEnd = 993510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureDisplayNameLocaKey(string aFeature)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aFeature)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993530, RefRangeEnd = 993531, XrefRangeStart = 993510, XrefRangeEnd = 993530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyEnumValueInfo GetEnumValue(string aValueName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aValueName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetEnumValue_Public_ArticyEnumValueInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyEnumValueInfo) null : Il2CppObjectPool.Get<ArticyEnumValueInfo>(num3);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 993550, RefRangeEnd = 993562, XrefRangeStart = 993531, XrefRangeEnd = 993550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyEnumValueInfo GetEnumValue(int aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aValue
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetEnumValue_Public_ArticyEnumValueInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyEnumValueInfo) null : Il2CppObjectPool.Get<ArticyEnumValueInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993562, XrefRangeEnd = 993583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCSharpType(string aTypeName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTypeName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_SetCSharpType_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 993589, RefRangeEnd = 993592, XrefRangeStart = 993583, XrefRangeEnd = 993589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetFeatureNameFromType(Il2CppSystem.Type aFeatureType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFeatureType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetFeatureNameFromType_Private_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object aOther)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOther)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993592, XrefRangeEnd = 993595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993595, XrefRangeEnd = 993622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyType.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyType.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyType.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Type _CSharpType_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr__CSharpType_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr__CSharpType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mTechnicalName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mTechnicalName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mTechnicalName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string mDisplayName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mDisplayName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ArticyType mBaseType
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mBaseType));
      return num == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mBaseType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mCSharpType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mCSharpType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mCSharpType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool mIsEnum
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mIsEnum));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mIsEnum)) = value;
    }
  }

  public unsafe bool mHasTemplate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mHasTemplate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mHasTemplate)) = value;
    }
  }

  public unsafe List<string> mFeatures
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mFeatures));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mFeatures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyPropertyInfo> mProperties
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mProperties));
      return num == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mProperties), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyEnumValueInfo> mEnumValues
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mEnumValues));
      return num == System.IntPtr.Zero ? (List<ArticyEnumValueInfo>) null : Il2CppObjectPool.Get<List<ArticyEnumValueInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyType.NativeFieldInfoPtr_mEnumValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetPropertiesInFeature_Public_IList_1_ArticyPropertyInfo_0<TFeatureType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyType.NativeMethodInfoPtr_GetPropertiesInFeature_Public_IList_1_ArticyPropertyInfo_0, Il2CppClassPointerStore<ArticyType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFeatureType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetFeatureDisplayName_Public_String_0<TFeatureType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyType.NativeMethodInfoPtr_GetFeatureDisplayName_Public_String_0, Il2CppClassPointerStore<ArticyType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFeatureType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetFeatureDisplayNameLocaKey_Public_String_0<TFeatureType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyType.NativeMethodInfoPtr_GetFeatureDisplayNameLocaKey_Public_String_0, Il2CppClassPointerStore<ArticyType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFeatureType>.NativeClassPtr))
    }))));
  }
}
