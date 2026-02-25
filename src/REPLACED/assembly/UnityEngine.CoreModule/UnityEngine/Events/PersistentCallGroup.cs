// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.PersistentCallGroup
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

[Serializable]
public class PersistentCallGroup(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Calls;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0;

  static PersistentCallGroup()
  {
    Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (PersistentCallGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr);
    PersistentCallGroup.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, nameof (m_Calls));
    PersistentCallGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100669110);
    PersistentCallGroup.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100669111);
    PersistentCallGroup.NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100669112);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473358, XrefRangeEnd = 473365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PersistentCallGroup()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int Count
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473365, XrefRangeEnd = 473366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 473385, RefRangeEnd = 473388, XrefRangeStart = 473366, XrefRangeEnd = 473385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) invokableList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unityEventBase);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<PersistentCall> m_Calls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCallGroup.NativeFieldInfoPtr_m_Calls));
      return num == System.IntPtr.Zero ? (List<PersistentCall>) null : Il2CppObjectPool.Get<List<PersistentCall>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistentCallGroup.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public PersistentCall GetListener(int index) => this.m_Calls[index];

  public IEnumerable<PersistentCall> GetListeners() => (IEnumerable<PersistentCall>) this.m_Calls;

  public void AddListener() => this.m_Calls.Add(new PersistentCall());

  public void AddListener(PersistentCall call) => this.m_Calls.Add(call);

  public void RemoveListener(int index) => this.m_Calls.RemoveAt(index);

  public void Clear() => this.m_Calls.Clear();

  public void RegisterEventPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.EventDefined;
  }

  public void RegisterVoidPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.Void;
  }

  public void RegisterObjectPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    UnityEngine.Object argument,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.Object;
    listener.arguments.unityObjectArgument = argument;
  }

  public void RegisterIntPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    int argument,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.Int;
    listener.arguments.intArgument = argument;
  }

  public void RegisterFloatPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    float argument,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.Float;
    listener.arguments.floatArgument = argument;
  }

  public void RegisterStringPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    string argument,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.String;
    listener.arguments.stringArgument = argument;
  }

  public void RegisterBoolPersistentListener(
    int index,
    UnityEngine.Object targetObj,
    Il2CppSystem.Type targetObjType,
    bool argument,
    string methodName)
  {
    PersistentCall listener = this.GetListener(index);
    listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
    listener.mode = PersistentListenerMode.Bool;
    listener.arguments.boolArgument = argument;
  }

  public void UnregisterPersistentListener(int index)
  {
    this.GetListener(index).UnregisterPersistentListener();
  }

  public void RemoveListeners(UnityEngine.Object target, string methodName)
  {
    List<PersistentCall> list1 = new List<PersistentCall>();
    for (int index = 0; index < this.m_Calls.Count; ++index)
    {
      if (this.m_Calls[index].target == target && this.m_Calls[index].methodName == methodName)
        list1.Add(this.m_Calls[index]);
    }
    List<PersistentCall> mCalls = this.m_Calls;
    List<PersistentCall> list2 = list1;
    // ISSUE: virtual method pointer
    Il2CppSystem.Predicate<PersistentCall> match = new Il2CppSystem.Predicate<PersistentCall>((Il2CppSystem.Object) list2, __vmethodptr(list2, Contains));
    mCalls.RemoveAll(match);
  }
}
