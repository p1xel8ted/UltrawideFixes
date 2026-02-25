// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyObjectNotificationManager
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
public sealed class ArticyObjectNotificationManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_mObjectRegistry;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTypeRegistry;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRemoveAllBlackListedTypes;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_ArticyType_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_ArticyObject_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyType_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyObject_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReportChanged_Public_Void_UInt64_UInt32_String_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListenerInternal_Private_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListenerInternal_Private_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllListenersInternal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReportChangedInternal_Private_Void_UInt64_UInt32_String_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddFuncToRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFuncFromRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyObjectNotificationManager()
  {
    Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyObjectNotificationManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr);
    ArticyObjectNotificationManager.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, nameof (Logger));
    ArticyObjectNotificationManager.NativeFieldInfoPtr_mObjectRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, nameof (mObjectRegistry));
    ArticyObjectNotificationManager.NativeFieldInfoPtr_mTypeRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, nameof (mTypeRegistry));
    ArticyObjectNotificationManager.NativeFieldInfoPtr_mRemoveAllBlackListedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, nameof (mRemoveAllBlackListedTypes));
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664239);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664240 /*0x060003B0*/);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664241);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664242);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664243);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyType_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664244);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664245);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyObject_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664246);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664247);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664248);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664249);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664250);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664251);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyType_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664252);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664253);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyObject_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664254);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664255);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_ReportChanged_Public_Void_UInt64_UInt32_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664256 /*0x060003C0*/);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664257);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664258);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664259);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664260);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664261);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664262);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664263);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664264);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveAllListenersInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664265);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_ReportChangedInternal_Private_Void_UInt64_UInt32_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664266);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_AddFuncToRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664267);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveFuncFromRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664268);
    ArticyObjectNotificationManager.NativeMethodInfoPtr_ClearRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664269);
    ArticyObjectNotificationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, 100664270);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997482, XrefRangeEnd = 997483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997483, XrefRangeEnd = 997484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(string aFilter, Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997484, XrefRangeEnd = 997486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener<TType>(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
    where TType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997486, XrefRangeEnd = 997488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener<TType>(string aFilter, Il2CppSystem.Action<ArticyChangedProperty> aFunc) where TType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997488, XrefRangeEnd = 997489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(
    ArticyType aArticyType,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997489, XrefRangeEnd = 997490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(
    ArticyType aArticyType,
    string aFilter,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyType_String_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997490, XrefRangeEnd = 997491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(
    ArticyObject aArticyObject,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997491, XrefRangeEnd = 997492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(
    ArticyObject aArticyObject,
    string aFilter,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_ArticyObject_String_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997492, XrefRangeEnd = 997493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997493, XrefRangeEnd = 997494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(string aFilter, Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997494, XrefRangeEnd = 997496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener<TType>(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
    where TType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997496, XrefRangeEnd = 997498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener<TType>(string aFilter, Il2CppSystem.Action<ArticyChangedProperty> aFunc) where TType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997498, XrefRangeEnd = 997499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(
    ArticyType aArticyType,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997499, XrefRangeEnd = 997500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(
    ArticyType aArticyType,
    string aFilter,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyType_String_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997500, XrefRangeEnd = 997501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(
    ArticyObject aArticyObject,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997501, XrefRangeEnd = 997502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(
    ArticyObject aArticyObject,
    string aFilter,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_ArticyObject_String_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 997508, RefRangeEnd = 997509, XrefRangeStart = 997502, XrefRangeEnd = 997508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveAllListeners()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(122)]
  [CachedScanResults(RefRangeStart = 997516, RefRangeEnd = 997638, XrefRangeStart = 997509, XrefRangeEnd = 997516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReportChanged(
    ulong aArticyObjectId,
    uint aArticyObjectInstanceId,
    string aProperty,
    Il2CppSystem.Object aOldValue,
    Il2CppSystem.Object aNewValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &aArticyObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aArticyObjectInstanceId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_ReportChanged_Public_Void_UInt64_UInt32_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 997714, RefRangeEnd = 997716, XrefRangeStart = 997638, XrefRangeEnd = 997714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListenerInternal(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997716, XrefRangeEnd = 997725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListenerInternal<TType>(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
    where TType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 997757, RefRangeEnd = 997761, XrefRangeStart = 997725, XrefRangeEnd = 997757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListenerInternal(
    ArticyType aArticyType,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 997794, RefRangeEnd = 997797, XrefRangeStart = 997761, XrefRangeEnd = 997794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListenerInternal(
    ArticyObject aArticyObject,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 997864, RefRangeEnd = 997866, XrefRangeStart = 997797, XrefRangeEnd = 997864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListenerInternal(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 997883, RefRangeEnd = 997885, XrefRangeStart = 997866, XrefRangeEnd = 997883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListenerInternal<TType>(
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
    where TType : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 997906, RefRangeEnd = 997911, XrefRangeStart = 997885, XrefRangeEnd = 997906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListenerInternal(
    ArticyType aArticyType,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_ArticyType_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 997933, RefRangeEnd = 997937, XrefRangeStart = 997911, XrefRangeEnd = 997933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListenerInternal(
    ArticyObject aArticyObject,
    string aFilter,
    ArticyTypeProperties aFlags,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_ArticyObject_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 997508, RefRangeEnd = 997509, XrefRangeStart = 997508, XrefRangeEnd = 997509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveAllListenersInternal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveAllListenersInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998007, RefRangeEnd = 998009, XrefRangeStart = 997937, XrefRangeEnd = 998007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReportChangedInternal(
    ulong aArticyObjectId,
    uint aArticyObjectInstanceId,
    string aProperty,
    Il2CppSystem.Object aOldValue,
    Il2CppSystem.Object aNewValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &aArticyObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aArticyObjectInstanceId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr_ReportChangedInternal_Private_Void_UInt64_UInt32_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998042, RefRangeEnd = 998044, XrefRangeStart = 998009, XrefRangeEnd = 998042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddFuncToRegistry<TKeyType>(
    Dictionary<TKeyType, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>> aRegistry,
    TKeyType aKey,
    string aProp,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRegistry);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TKeyType& local1;
    if (!typeof (TKeyType).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TKeyType> local2 = (object) aKey;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TKeyType&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKeyType&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref aKey;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_AddFuncToRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0<TKeyType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998066, RefRangeEnd = 998068, XrefRangeStart = 998044, XrefRangeEnd = 998066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveFuncFromRegistry<TKeyType>(
    Dictionary<TKeyType, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>> aRegistry,
    TKeyType aKey,
    string aProp,
    Il2CppSystem.Action<ArticyChangedProperty> aFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRegistry);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TKeyType& local1;
    if (!typeof (TKeyType).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TKeyType> local2 = (object) aKey;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TKeyType&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKeyType&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref aKey;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_RemoveFuncFromRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0<TKeyType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998154, RefRangeEnd = 998156, XrefRangeStart = 998068, XrefRangeEnd = 998154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearRegistry<TKeyType>(
    Dictionary<TKeyType, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>> aRegistry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRegistry)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.MethodInfoStoreGeneric_ClearRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_0<TKeyType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998182, RefRangeEnd = 998184, XrefRangeStart = 998156, XrefRangeEnd = 998182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObjectNotificationManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyObjectNotificationManager.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyObjectNotificationManager.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ulong, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>> mObjectRegistry
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.NativeFieldInfoPtr_mObjectRegistry));
      return num == System.IntPtr.Zero ? (Dictionary<ulong, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>>) null : Il2CppObjectPool.Get<Dictionary<ulong, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.NativeFieldInfoPtr_mObjectRegistry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ArticyType, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>> mTypeRegistry
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.NativeFieldInfoPtr_mTypeRegistry));
      return num == System.IntPtr.Zero ? (Dictionary<ArticyType, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>>) null : Il2CppObjectPool.Get<Dictionary<ArticyType, Dictionary<string, List<ArticyObjectNotificationManager.WeakDelegate>>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.NativeFieldInfoPtr_mTypeRegistry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Type> mRemoveAllBlackListedTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.NativeFieldInfoPtr_mRemoveAllBlackListedTypes));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.NativeFieldInfoPtr_mRemoveAllBlackListedTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class WeakDelegate(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sGetMethodInfoMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_sCreateDelegateMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_sActionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_sGetMethodInfoFunc;
    private static readonly System.IntPtr NativeFieldInfoPtr_sCreateDelegateFunc;
    private static readonly System.IntPtr NativeFieldInfoPtr_mReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_mMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_mMethodInfo;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_ArticyChangedProperty_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Reference_Public_get_WeakReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Boolean_ArticyChangedProperty_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Action_1_ArticyChangedProperty_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0;

    static WeakDelegate()
    {
      Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr, nameof (WeakDelegate));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sGetMethodInfoMethod));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sCreateDelegateMethod));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sActionType));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sGetMethodInfoFunc));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sCreateDelegateFunc));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (mReference));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (mMethod));
      ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, nameof (mMethodInfo));
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664273);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664274);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664275);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664276);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_Reference_Public_get_WeakReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664277);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Boolean_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664278);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664279);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Action_1_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664280);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664281);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664282);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664283);
      ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr, 100664284);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997421, XrefRangeEnd = 997423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object aOther)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOther)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 997426, RefRangeEnd = 997429, XrefRangeStart = 997423, XrefRangeEnd = 997426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WeakDelegate(
      Il2CppSystem.Action<ArticyChangedProperty> aStrongReferenceAction)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyObjectNotificationManager.WeakDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStrongReferenceAction)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Action_1_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool IsAlive
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Il2CppSystem.WeakReference Reference
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_Reference_Public_get_WeakReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.WeakReference) null : Il2CppObjectPool.Get<Il2CppSystem.WeakReference>(num3);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 997432, RefRangeEnd = 997434, XrefRangeStart = 997429, XrefRangeEnd = 997432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Invoke(ArticyChangedProperty aChangedProp)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aChangedProp))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Boolean_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997434, XrefRangeEnd = 997439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Action<ArticyChangedProperty> CreateDelegate(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<ArticyChangedProperty>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ArticyChangedProperty>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997439, XrefRangeEnd = 997444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfo(Il2CppSystem.Action<ArticyChangedProperty> aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Action_1_ArticyChangedProperty_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997444, XrefRangeEnd = 997451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Action<ArticyChangedProperty> CreateDelegateNormal(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<ArticyChangedProperty>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ArticyChangedProperty>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfoNormal(Il2CppSystem.Delegate aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997451, XrefRangeEnd = 997471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Action<ArticyChangedProperty> CreateDelegateUwp(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Action_1_ArticyChangedProperty_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<ArticyChangedProperty>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ArticyChangedProperty>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997471, XrefRangeEnd = 997482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfoUwp(Il2CppSystem.Delegate aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObjectNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    public static unsafe MethodInfo sGetMethodInfoMethod
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MethodInfo sCreateDelegateMethod
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Type sActionType
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sActionType, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sActionType, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo> sGetMethodInfoFunc
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Action<ArticyChangedProperty>> sCreateDelegateFunc
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Action<ArticyChangedProperty>>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Action<ArticyChangedProperty>>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.WeakReference mReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mReference));
        return num == System.IntPtr.Zero ? (Il2CppSystem.WeakReference) null : Il2CppObjectPool.Get<Il2CppSystem.WeakReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<ArticyChangedProperty> mMethod
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethod));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<ArticyChangedProperty>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ArticyChangedProperty>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MethodInfo mMethodInfo
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethodInfo));
        return num == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObjectNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethodInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveListenerInternal_Private_Void_String_ArticyTypeProperties_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddFuncToRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0<TKeyType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_AddFuncToRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKeyType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RemoveFuncFromRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0<TKeyType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_RemoveFuncFromRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_TKeyType_String_Action_1_ArticyChangedProperty_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKeyType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ClearRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_0<TKeyType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObjectNotificationManager.NativeMethodInfoPtr_ClearRegistry_Private_Void_Dictionary_2_TKeyType_Dictionary_2_String_List_1_WeakDelegate_0, Il2CppClassPointerStore<ArticyObjectNotificationManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKeyType>.NativeClassPtr))
    }))));
  }
}
