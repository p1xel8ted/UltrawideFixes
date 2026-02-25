// Decompiled with JetBrains decompiler
// Type: UnityEngine.Component
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class Component(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppReferenceArray_1_Component_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_transform_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameObject_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsForListInternal_Injected_Private_Static_Void_IntPtr_Type_Object_0;
  private static readonly Component.GetComponent_InjectedDelegate GetComponent_InjectedDelegateField;
  private static readonly Component.GetComponentIndex_InjectedDelegate GetComponentIndex_InjectedDelegateField;
  private static readonly Component.SendMessageUpwards_InjectedDelegate SendMessageUpwards_InjectedDelegateField;
  private static readonly Component.SendMessage_InjectedDelegate SendMessage_InjectedDelegateField;
  private static readonly Component.BroadcastMessage_InjectedDelegate BroadcastMessage_InjectedDelegateField;

  static Component()
  {
    Il2CppClassPointerStore<Component>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Component));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Component>.NativeClassPtr);
    Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667965);
    Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667966);
    Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667967);
    Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667968);
    Component.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667969);
    Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667970);
    Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667971);
    Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667972);
    Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667973);
    Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667974);
    Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667975);
    Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667976);
    Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667977);
    Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667978);
    Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667979);
    Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667980);
    Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667981);
    Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667982);
    Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667983);
    Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667984);
    Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667985);
    Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667986);
    Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667987);
    Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667988);
    Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppReferenceArray_1_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667989);
    Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667990);
    Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667991);
    Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667992);
    Component.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667993);
    Component.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667994);
    Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667995);
    Component.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667996);
    Component.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667997);
    Component.NativeMethodInfoPtr_get_transform_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667998);
    Component.NativeMethodInfoPtr_get_gameObject_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100667999);
    Component.NativeMethodInfoPtr_GetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100668000);
    Component.NativeMethodInfoPtr_GetComponentsForListInternal_Injected_Private_Static_Void_IntPtr_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100668001);
    Component.GetComponent_InjectedDelegateField = IL2CPP.ResolveICall<Component.GetComponent_InjectedDelegate>("UnityEngine.Component::GetComponent_Injected");
    Component.GetComponentIndex_InjectedDelegateField = IL2CPP.ResolveICall<Component.GetComponentIndex_InjectedDelegate>("UnityEngine.Component::GetComponentIndex_Injected");
    Component.SendMessageUpwards_InjectedDelegateField = IL2CPP.ResolveICall<Component.SendMessageUpwards_InjectedDelegate>("UnityEngine.Component::SendMessageUpwards_Injected");
    Component.SendMessage_InjectedDelegateField = IL2CPP.ResolveICall<Component.SendMessage_InjectedDelegate>("UnityEngine.Component::SendMessage_Injected");
    Component.BroadcastMessage_InjectedDelegateField = IL2CPP.ResolveICall<Component.BroadcastMessage_InjectedDelegate>("UnityEngine.Component::BroadcastMessage_Injected");
  }

  public unsafe Transform transform
  {
    [CallerCount(1743), CachedScanResults(RefRangeStart = 444644, RefRangeEnd = 446387, XrefRangeStart = 444636, XrefRangeEnd = 444644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public unsafe GameObject gameObject
  {
    [CallerCount(1092), CachedScanResults(RefRangeStart = 446395, RefRangeEnd = 447487, XrefRangeStart = 446387, XrefRangeEnd = 446395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 447502, RefRangeEnd = 447511, XrefRangeStart = 447487, XrefRangeEnd = 447502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Component GetComponent(Il2CppSystem.Type type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 447516, RefRangeEnd = 447519, XrefRangeStart = 447511, XrefRangeEnd = 447516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponentFastPath(Il2CppSystem.Type type, System.IntPtr oneFurtherThanResultValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oneFurtherThanResultValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(809)]
  [CachedScanResults(RefRangeStart = 447524, RefRangeEnd = 448333, XrefRangeStart = 447519, XrefRangeEnd = 447524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetComponent<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448356, RefRangeEnd = 448357, XrefRangeStart = 448333, XrefRangeEnd = 448356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetComponent(Il2CppSystem.Type type, out Component component)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Component local = ref component;
    System.IntPtr pointer = zero;
    Component component1 = pointer == System.IntPtr.Zero ? (Component) null : new Component(pointer);
    local = component1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(91)]
  [CachedScanResults(RefRangeStart = 448361, RefRangeEnd = 448452, XrefRangeStart = 448357, XrefRangeEnd = 448361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetComponent<T>(out T component)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref component;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref component;
      System.IntPtr num3 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
      local2 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 448467, RefRangeEnd = 448476, XrefRangeStart = 448452, XrefRangeEnd = 448467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Component GetComponentInChildren(Il2CppSystem.Type t, bool includeInactive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeInactive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448491, RefRangeEnd = 448492, XrefRangeStart = 448476, XrefRangeEnd = 448491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Component GetComponentInChildren(Il2CppSystem.Type t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 448498, RefRangeEnd = 448501, XrefRangeStart = 448492, XrefRangeEnd = 448498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetComponentInChildren<T>(bool includeInactive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &includeInactive
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 448507, RefRangeEnd = 448551, XrefRangeStart = 448501, XrefRangeEnd = 448507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetComponentInChildren<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448560, RefRangeEnd = 448561, XrefRangeStart = 448551, XrefRangeEnd = 448560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Component> GetComponentsInChildren(Il2CppSystem.Type t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Component>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 448565, RefRangeEnd = 448572, XrefRangeStart = 448561, XrefRangeEnd = 448565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &includeInactive
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448572, XrefRangeEnd = 448576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &includeInactive;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 448581, RefRangeEnd = 448612, XrefRangeStart = 448576, XrefRangeEnd = 448581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 448617, RefRangeEnd = 448619, XrefRangeStart = 448612, XrefRangeEnd = 448617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponentsInChildren<T>(List<T> results)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448634, RefRangeEnd = 448635, XrefRangeStart = 448619, XrefRangeEnd = 448634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Component GetComponentInParent(Il2CppSystem.Type t, bool includeInactive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeInactive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448650, RefRangeEnd = 448651, XrefRangeStart = 448635, XrefRangeEnd = 448650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Component GetComponentInParent(Il2CppSystem.Type t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num3);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 448657, RefRangeEnd = 448681, XrefRangeStart = 448651, XrefRangeEnd = 448657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetComponentInParent<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448681, XrefRangeEnd = 448690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Component> GetComponentsInParent(Il2CppSystem.Type t, bool includeInactive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeInactive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Component>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448699, RefRangeEnd = 448700, XrefRangeStart = 448690, XrefRangeEnd = 448699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Component> GetComponentsInParent(Il2CppSystem.Type t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Component>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 448704, RefRangeEnd = 448706, XrefRangeStart = 448700, XrefRangeEnd = 448704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &includeInactive
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 448710, RefRangeEnd = 448715, XrefRangeStart = 448706, XrefRangeEnd = 448710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &includeInactive;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 448720, RefRangeEnd = 448722, XrefRangeStart = 448715, XrefRangeEnd = 448720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 448736, RefRangeEnd = 448737, XrefRangeStart = 448722, XrefRangeEnd = 448736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Component> GetComponents(Il2CppSystem.Type type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppReferenceArray_1_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Component>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(num3);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 448742, RefRangeEnd = 448751, XrefRangeStart = 448737, XrefRangeEnd = 448742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponentsForListInternal(Il2CppSystem.Type searchType, Il2CppSystem.Object resultList)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultList);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 448742, RefRangeEnd = 448751, XrefRangeStart = 448742, XrefRangeEnd = 448751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponents(Il2CppSystem.Type type, List<Component> results)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 448759, RefRangeEnd = 448773, XrefRangeStart = 448751, XrefRangeEnd = 448759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetComponents<T>(List<T> results)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string tag
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 448782, RefRangeEnd = 448796, XrefRangeStart = 448773, XrefRangeEnd = 448782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448796, XrefRangeEnd = 448805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(42)]
  [CachedScanResults(RefRangeStart = 448812, RefRangeEnd = 448854, XrefRangeStart = 448805, XrefRangeEnd = 448812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetComponents<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(124)]
  [CachedScanResults(RefRangeStart = 448863, RefRangeEnd = 448987, XrefRangeStart = 448854, XrefRangeEnd = 448863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CompareTag(string tag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(tag)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(753)]
  [CachedScanResults(RefRangeStart = 443820, RefRangeEnd = 444573, XrefRangeStart = 443820, XrefRangeEnd = 444573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Component()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Component>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448987, XrefRangeEnd = 448989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr get_transform_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_transform_Injected_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448989, XrefRangeEnd = 448991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr get_gameObject_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_gameObject_Injected_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448991, XrefRangeEnd = 448993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetComponentFastPath_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Type type,
    System.IntPtr oneFurtherThanResultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oneFurtherThanResultValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentFastPath_Injected_Private_Static_Void_IntPtr_Type_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448993, XrefRangeEnd = 448995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetComponentsForListInternal_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Type searchType,
    Il2CppSystem.Object resultList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultList);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsForListInternal_Injected_Private_Static_Void_IntPtr_Type_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Component GetComponent(string type)
  {
    System.IntPtr componentInjected;
    Component component;
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Component>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(type, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = type.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      componentInjected = Component.GetComponent_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      component = Unmarshal.UnmarshalUnityObject<Component>(componentInjected);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
    return component;
  }

  public Il2CppReferenceArray<Component> GetComponentsInChildren(Il2CppSystem.Type t, bool includeInactive)
  {
    return this.gameObject.GetComponentsInChildren(t, includeInactive);
  }

  public T GetComponentInParent<T>(bool includeInactive)
  {
    return this.GetComponentInParent(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive).Cast<T>();
  }

  public int GetComponentIndex()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Component>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Component.GetComponentIndex_Injected(_unity_self);
  }

  public bool CompareTag(TagHandle tag) => this.gameObject.CompareTag(tag);

  public unsafe void SendMessageUpwards(
    string methodName,
    Il2CppSystem.Object value,
    SendMessageOptions options)
  {
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Component>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(methodName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = methodName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Component.SendMessageUpwards_Injected(_unity_self, ref managedSpanWrapper, value, options);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void SendMessageUpwards(string methodName, Il2CppSystem.Object value)
  {
    this.SendMessageUpwards(methodName, value, SendMessageOptions.RequireReceiver);
  }

  public void SendMessageUpwards(string methodName)
  {
    this.SendMessageUpwards(methodName, (Il2CppSystem.Object) null, SendMessageOptions.RequireReceiver);
  }

  public void SendMessageUpwards(string methodName, SendMessageOptions options)
  {
    this.SendMessageUpwards(methodName, (Il2CppSystem.Object) null, options);
  }

  public void SendMessage(string methodName, Il2CppSystem.Object value)
  {
    this.SendMessage(methodName, value, SendMessageOptions.RequireReceiver);
  }

  public void SendMessage(string methodName)
  {
    this.SendMessage(methodName, (Il2CppSystem.Object) null, SendMessageOptions.RequireReceiver);
  }

  public unsafe void SendMessage(string methodName, Il2CppSystem.Object value, SendMessageOptions options)
  {
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Component>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(methodName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = methodName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Component.SendMessage_Injected(_unity_self, ref managedSpanWrapper, value, options);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void SendMessage(string methodName, SendMessageOptions options)
  {
    this.SendMessage(methodName, (Il2CppSystem.Object) null, options);
  }

  public unsafe void BroadcastMessage(
    string methodName,
    Il2CppSystem.Object parameter,
    SendMessageOptions options)
  {
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Component>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(methodName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = methodName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Component.BroadcastMessage_Injected(_unity_self, ref managedSpanWrapper, parameter, options);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void BroadcastMessage(string methodName, Il2CppSystem.Object parameter)
  {
    this.BroadcastMessage(methodName, parameter, SendMessageOptions.RequireReceiver);
  }

  public void BroadcastMessage(string methodName)
  {
    this.BroadcastMessage(methodName, (Il2CppSystem.Object) null, SendMessageOptions.RequireReceiver);
  }

  public void BroadcastMessage(string methodName, SendMessageOptions options)
  {
    this.BroadcastMessage(methodName, (Il2CppSystem.Object) null, options);
  }

  public static System.IntPtr GetComponent_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper type)
  {
    return Component.GetComponent_InjectedDelegateField(_unity_self, (System.IntPtr) ref type);
  }

  public static int GetComponentIndex_Injected(System.IntPtr _unity_self)
  {
    return Component.GetComponentIndex_InjectedDelegateField(_unity_self);
  }

  public static void SendMessageUpwards_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper methodName,
    Il2CppSystem.Object value,
    SendMessageOptions options)
  {
    Component.SendMessageUpwards_InjectedDelegateField(_unity_self, (System.IntPtr) ref methodName, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value), options);
  }

  public static void SendMessage_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper methodName,
    Il2CppSystem.Object value,
    SendMessageOptions options)
  {
    Component.SendMessage_InjectedDelegateField(_unity_self, (System.IntPtr) ref methodName, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value), options);
  }

  public static void BroadcastMessage_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper methodName,
    Il2CppSystem.Object parameter,
    SendMessageOptions options)
  {
    Component.BroadcastMessage_InjectedDelegateField(_unity_self, (System.IntPtr) ref methodName, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameter), options);
  }

  private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate System.IntPtr GetComponent_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr type);

  private delegate int GetComponentIndex_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void SendMessageUpwards_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr methodName,
    System.IntPtr value,
    SendMessageOptions options);

  private delegate void SendMessage_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr methodName,
    System.IntPtr value,
    SendMessageOptions options);

  private delegate void BroadcastMessage_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr methodName,
    System.IntPtr parameter,
    SendMessageOptions options);
}
