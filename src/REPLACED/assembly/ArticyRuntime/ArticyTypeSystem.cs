// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyTypeSystem
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
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class ArticyTypeSystem(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_sInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCSharpTypeCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyPropertyInfos;
  private static readonly System.IntPtr NativeFieldInfoPtr_mNameArticyTypeMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyTypeNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTypeArticyTypeMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyTypeTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeaturePropertyMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeatureProps;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeaturePropInfos;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeatureDisplayNameMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeatureTechnicalNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFeatureDisplayNames;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyTypes_Public_Static_get_List_1_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyPropertyInfos_Public_Static_get_List_1_ArticyPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_ArticyTypeSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyTypeSystemFileName_Internal_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyTypeSystemFolder_Internal_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyTypeSystemPath_Internal_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAsync_Internal_Static_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyTypesInternal_Internal_List_1_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyTypeInternal_Internal_ArticyType_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyTypeInternal_Internal_ArticyType_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCSharpTypeInternal_Internal_Static_Type_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDisplayName_Internal_Static_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyTypeSystem()
  {
    Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyTypeSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr);
    ArticyTypeSystem.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (Logger));
    ArticyTypeSystem.NativeFieldInfoPtr_sInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (sInstance));
    ArticyTypeSystem.NativeFieldInfoPtr_mCSharpTypeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mCSharpTypeCache));
    ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mArticyTypes));
    ArticyTypeSystem.NativeFieldInfoPtr_mArticyPropertyInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mArticyPropertyInfos));
    ArticyTypeSystem.NativeFieldInfoPtr_mNameArticyTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mNameArticyTypeMap));
    ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mArticyTypeNames));
    ArticyTypeSystem.NativeFieldInfoPtr_mTypeArticyTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mTypeArticyTypeMap));
    ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mArticyTypeTypes));
    ArticyTypeSystem.NativeFieldInfoPtr_mFeaturePropertyMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mFeaturePropertyMap));
    ArticyTypeSystem.NativeFieldInfoPtr_mFeatureProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mFeatureProps));
    ArticyTypeSystem.NativeFieldInfoPtr_mFeaturePropInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mFeaturePropInfos));
    ArticyTypeSystem.NativeFieldInfoPtr_mFeatureDisplayNameMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mFeatureDisplayNameMap));
    ArticyTypeSystem.NativeFieldInfoPtr_mFeatureTechnicalNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mFeatureTechnicalNames));
    ArticyTypeSystem.NativeFieldInfoPtr_mFeatureDisplayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, nameof (mFeatureDisplayNames));
    ArticyTypeSystem.NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100663997);
    ArticyTypeSystem.NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100663998);
    ArticyTypeSystem.NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100663999);
    ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypes_Public_Static_get_List_1_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664000 /*0x060002C0*/);
    ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyPropertyInfos_Public_Static_get_List_1_ArticyPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664001);
    ArticyTypeSystem.NativeMethodInfoPtr_get_Instance_Internal_Static_get_ArticyTypeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664002);
    ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypeSystemFileName_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664003);
    ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypeSystemFolder_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664004);
    ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypeSystemPath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664005);
    ArticyTypeSystem.NativeMethodInfoPtr_InitializeAsync_Internal_Static_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664006);
    ArticyTypeSystem.NativeMethodInfoPtr_GetArticyTypesInternal_Internal_List_1_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664007);
    ArticyTypeSystem.NativeMethodInfoPtr_GetArticyTypeInternal_Internal_ArticyType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664008);
    ArticyTypeSystem.NativeMethodInfoPtr_GetArticyTypeInternal_Internal_ArticyType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664009);
    ArticyTypeSystem.NativeMethodInfoPtr_GetCSharpTypeInternal_Internal_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664010);
    ArticyTypeSystem.NativeMethodInfoPtr_GetFeatureDisplayName_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664011);
    ArticyTypeSystem.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664012);
    ArticyTypeSystem.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664013);
    ArticyTypeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, 100664014);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 993679, RefRangeEnd = 993690, XrefRangeStart = 993661, XrefRangeEnd = 993679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyType GetArticyType(string aTypeName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTypeName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 993708, RefRangeEnd = 993711, XrefRangeStart = 993690, XrefRangeEnd = 993708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyType GetArticyType(Il2CppSystem.Type aType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 993721, RefRangeEnd = 993725, XrefRangeStart = 993711, XrefRangeEnd = 993721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyType GetArticyType<TType>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.MethodInfoStoreGeneric_GetArticyType_Public_Static_ArticyType_0<TType>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
  }

  public static unsafe List<ArticyType> ArticyTypes
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 993735, RefRangeEnd = 993737, XrefRangeStart = 993725, XrefRangeEnd = 993735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypes_Public_Static_get_List_1_ArticyType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ArticyType>) null : Il2CppObjectPool.Get<List<ArticyType>>(num3);
    }
  }

  public static unsafe List<ArticyPropertyInfo> ArticyPropertyInfos
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993737, XrefRangeEnd = 993747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyPropertyInfos_Public_Static_get_List_1_ArticyPropertyInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num3);
    }
  }

  public static unsafe ArticyTypeSystem Instance
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 993773, RefRangeEnd = 993785, XrefRangeStart = 993747, XrefRangeEnd = 993773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_get_Instance_Internal_Static_get_ArticyTypeSystem_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyTypeSystem) null : Il2CppObjectPool.Get<ArticyTypeSystem>(num3);
    }
  }

  public static unsafe string ArticyTypeSystemFileName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 993791, RefRangeEnd = 993794, XrefRangeStart = 993785, XrefRangeEnd = 993791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypeSystemFileName_Internal_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string ArticyTypeSystemFolder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993794, XrefRangeEnd = 993799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypeSystemFolder_Internal_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string ArticyTypeSystemPath
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993799, XrefRangeEnd = 993812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_get_ArticyTypeSystemPath_Internal_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993820, RefRangeEnd = 993821, XrefRangeStart = 993812, XrefRangeEnd = 993820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task InitializeAsync()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_InitializeAsync_Internal_Static_Task_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993821, XrefRangeEnd = 993827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<ArticyType> GetArticyTypesInternal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetArticyTypesInternal_Internal_List_1_ArticyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyType>) null : Il2CppObjectPool.Get<List<ArticyType>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993827, XrefRangeEnd = 993841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyType GetArticyTypeInternal(string aTypeName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTypeName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetArticyTypeInternal_Internal_ArticyType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 993855, RefRangeEnd = 993857, XrefRangeStart = 993841, XrefRangeEnd = 993855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyType GetArticyTypeInternal(Il2CppSystem.Type aType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetArticyTypeInternal_Internal_ArticyType_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993877, RefRangeEnd = 993878, XrefRangeStart = 993857, XrefRangeEnd = 993877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Type GetCSharpTypeInternal(string aTypeName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTypeName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetCSharpTypeInternal_Internal_Static_Type_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993897, RefRangeEnd = 993898, XrefRangeStart = 993878, XrefRangeEnd = 993897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetFeatureDisplayName(string aFeature, bool aReturnLocaKey = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFeature);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aReturnLocaKey;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_GetFeatureDisplayName_Internal_Static_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993898, XrefRangeEnd = 993998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993998, XrefRangeEnd = 994070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994070, XrefRangeEnd = 994133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyTypeSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyTypeSystem.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTypeSystem.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ArticyTypeSystem sInstance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyTypeSystem.NativeFieldInfoPtr_sInstance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyTypeSystem) null : Il2CppObjectPool.Get<ArticyTypeSystem>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTypeSystem.NativeFieldInfoPtr_sInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, Il2CppSystem.Type> mCSharpTypeCache
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyTypeSystem.NativeFieldInfoPtr_mCSharpTypeCache, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Type>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTypeSystem.NativeFieldInfoPtr_mCSharpTypeCache, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyType> mArticyTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypes));
      return num == System.IntPtr.Zero ? (List<ArticyType>) null : Il2CppObjectPool.Get<List<ArticyType>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyPropertyInfo> mArticyPropertyInfos
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyPropertyInfos));
      return num == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyPropertyInfos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, ArticyType> mNameArticyTypeMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mNameArticyTypeMap));
      return num == System.IntPtr.Zero ? (Dictionary<string, ArticyType>) null : Il2CppObjectPool.Get<Dictionary<string, ArticyType>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mNameArticyTypeMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mArticyTypeNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypeNames));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, ArticyType> mTypeArticyTypeMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mTypeArticyTypeMap));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, ArticyType>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, ArticyType>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mTypeArticyTypeMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mArticyTypeTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypeTypes));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mArticyTypeTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Dictionary<string, ArticyPropertyInfo>> mFeaturePropertyMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeaturePropertyMap));
      return num == System.IntPtr.Zero ? (Dictionary<string, Dictionary<string, ArticyPropertyInfo>>) null : Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, ArticyPropertyInfo>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeaturePropertyMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mFeatureProps
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureProps));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureProps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyPropertyInfo> mFeaturePropInfos
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeaturePropInfos));
      return num == System.IntPtr.Zero ? (List<ArticyPropertyInfo>) null : Il2CppObjectPool.Get<List<ArticyPropertyInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeaturePropInfos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, string> mFeatureDisplayNameMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureDisplayNameMap));
      return num == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureDisplayNameMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mFeatureTechnicalNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureTechnicalNames));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureTechnicalNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mFeatureDisplayNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureDisplayNames));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem.NativeFieldInfoPtr_mFeatureDisplayNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyTypeSystem+<InitializeAsync>d__17")]
  public sealed class _InitializeAsync_d__17 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _InitializeAsync_d__17()
    {
      Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr, "<InitializeAsync>d__17");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr);
      ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr, "<>1__state");
      ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr, "<>t__builder");
      ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr, "<>u__1");
      ArticyTypeSystem._InitializeAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr, 100664016 /*0x060002D0*/);
      ArticyTypeSystem._InitializeAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr, 100664017);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993622, XrefRangeEnd = 993657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem._InitializeAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993657, XrefRangeEnd = 993661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTypeSystem._InitializeAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _InitializeAsync_d__17(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _InitializeAsync_d__17()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTypeSystem._InitializeAsync_d__17>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppSystem.ValueTuple<ArticyTypeSystem, Il2CppSystem.Object>> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.ValueTuple<ArticyTypeSystem, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyTypeSystem, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeSystem._InitializeAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyTypeSystem, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetArticyType_Public_Static_ArticyType_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyTypeSystem.NativeMethodInfoPtr_GetArticyType_Public_Static_ArticyType_0, Il2CppClassPointerStore<ArticyTypeSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }
}
