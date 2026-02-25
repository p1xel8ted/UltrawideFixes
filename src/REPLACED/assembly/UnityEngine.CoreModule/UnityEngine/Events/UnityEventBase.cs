// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityEventBase
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

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
namespace UnityEngine.Events;

[Serializable]
public class UnityEventBase(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Calls;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PersistentCalls;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CallsDirty;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPersistentEventCount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;

  static UnityEventBase()
  {
    Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (UnityEventBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr);
    UnityEventBase.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, nameof (m_Calls));
    UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, nameof (m_PersistentCalls));
    UnityEventBase.NativeFieldInfoPtr_m_CallsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, nameof (m_CallsDirty));
    UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669121);
    UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669122);
    UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669123);
    UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669124);
    UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669125);
    UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669126);
    UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669127);
    UnityEventBase.NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669128);
    UnityEventBase.NativeMethodInfoPtr_GetPersistentEventCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669129);
    UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669130);
    UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669131);
    UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669132);
    UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669133);
    UnityEventBase.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669134);
    UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669135);
    UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669136);
    UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100669137);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 473498, RefRangeEnd = 473502, XrefRangeStart = 473469, XrefRangeEnd = 473498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityEventBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473502, XrefRangeEnd = 473503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe MethodInfo FindMethod_Impl(string name, Il2CppSystem.Type targetObjType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObjType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe BaseInvokableCall GetDelegate(Il2CppSystem.Object target, MethodInfo theFunction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theFunction);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473533, RefRangeEnd = 473534, XrefRangeStart = 473503, XrefRangeEnd = 473533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MethodInfo FindMethod(PersistentCall call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473582, RefRangeEnd = 473583, XrefRangeStart = 473534, XrefRangeEnd = 473582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MethodInfo FindMethod(
    string name,
    Il2CppSystem.Type listenerType,
    PersistentListenerMode mode,
    Il2CppSystem.Type argumentType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) listenerType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) argumentType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473584, RefRangeEnd = 473585, XrefRangeStart = 473583, XrefRangeEnd = 473584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetCallsCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473586, RefRangeEnd = 473587, XrefRangeStart = 473585, XrefRangeEnd = 473586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPersistentEventCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetPersistentEventCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 473595, RefRangeEnd = 473597, XrefRangeStart = 473587, XrefRangeEnd = 473595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DirtyPersistentCalls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473597, XrefRangeEnd = 473598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RebuildPersistentCallsIfNeeded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 473601, RefRangeEnd = 473606, XrefRangeStart = 473598, XrefRangeEnd = 473601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCall(BaseInvokableCall call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 473608, RefRangeEnd = 473611, XrefRangeStart = 473606, XrefRangeEnd = 473608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(Il2CppSystem.Object targetObj, MethodInfo method)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(40)]
  [CachedScanResults(RefRangeStart = 473619, RefRangeEnd = 473659, XrefRangeStart = 473611, XrefRangeEnd = 473619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveAllListeners()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 473667, RefRangeEnd = 473670, XrefRangeStart = 473659, XrefRangeEnd = 473667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<BaseInvokableCall> PrepareInvoke()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<BaseInvokableCall>) null : Il2CppObjectPool.Get<List<BaseInvokableCall>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473670, XrefRangeEnd = 473676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 473691, RefRangeEnd = 473711, XrefRangeStart = 473676, XrefRangeEnd = 473691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe MethodInfo GetValidMethodInfo(
    Il2CppSystem.Type objectType,
    string functionName,
    Il2CppReferenceArray<Il2CppSystem.Type> argumentTypes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objectType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(functionName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) argumentTypes);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  public unsafe InvokableCallList m_Calls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls));
      return num == System.IntPtr.Zero ? (InvokableCallList) null : Il2CppObjectPool.Get<InvokableCallList>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersistentCallGroup m_PersistentCalls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls));
      return num == System.IntPtr.Zero ? (PersistentCallGroup) null : Il2CppObjectPool.Get<PersistentCallGroup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_CallsDirty
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty)) = value;
    }
  }

  public MethodInfo FindMethod_Impl(string name, Il2CppSystem.Object targetObj)
  {
    return this.FindMethod_Impl(name, targetObj.GetType());
  }

  public UnityEngine.Object GetPersistentTarget(int index)
  {
    return this.m_PersistentCalls.GetListener(index)?.target;
  }

  public string GetPersistentMethodName(int index)
  {
    PersistentCall listener = this.m_PersistentCalls.GetListener(index);
    return listener != null ? listener.methodName : Il2CppSystem.String.Empty;
  }

  public void SetPersistentListenerState(int index, UnityEventCallState state)
  {
    PersistentCall listener = this.m_PersistentCalls.GetListener(index);
    if (listener != null)
      listener.callState = state;
    this.DirtyPersistentCalls();
  }

  public UnityEventCallState GetPersistentListenerState(int index)
  {
    if (index < 0 || index > this.m_PersistentCalls.Count)
      throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("Index {0} is out of range of the {1} persistent listeners.", (Il2CppSystem.Object) (System.ValueType) index, (Il2CppSystem.Object) (System.ValueType) this.GetPersistentEventCount()));
    return this.m_PersistentCalls.GetListener(index).callState;
  }

  public void AddListener(Il2CppSystem.Object targetObj, MethodInfo method)
  {
    this.m_Calls.AddListener(this.GetDelegate(targetObj, method));
  }

  public void Invoke(Il2CppReferenceArray<Il2CppSystem.Object> parameters)
  {
    List<BaseInvokableCall> list = this.PrepareInvoke();
    for (int index = 0; index < list.Count; ++index)
      list[index].Invoke(parameters);
  }

  public static MethodInfo GetValidMethodInfo(
    Il2CppSystem.Object obj,
    string functionName,
    Il2CppReferenceArray<Il2CppSystem.Type> argumentTypes)
  {
    return UnityEventBase.GetValidMethodInfo(obj.GetType(), functionName, argumentTypes);
  }
}
