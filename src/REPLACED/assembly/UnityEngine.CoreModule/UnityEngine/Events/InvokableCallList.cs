// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.InvokableCallList
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

public class InvokableCallList(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PersistentCalls;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RuntimeCalls;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecutingCalls;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedsUpdate;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearPersistent_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvokableCallList()
  {
    Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (InvokableCallList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr);
    InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, nameof (m_PersistentCalls));
    InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, nameof (m_RuntimeCalls));
    InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, nameof (m_ExecutingCalls));
    InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, nameof (m_NeedsUpdate));
    InvokableCallList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669113);
    InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669114);
    InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669115);
    InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669116);
    InvokableCallList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669117);
    InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669118);
    InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669119);
    InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100669120);
  }

  public unsafe int Count
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473388, XrefRangeEnd = 473389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473392, RefRangeEnd = 473393, XrefRangeStart = 473389, XrefRangeEnd = 473392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPersistentInvokableCall(BaseInvokableCall call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473393, XrefRangeEnd = 473396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(BaseInvokableCall call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 473429, RefRangeEnd = 473431, XrefRangeStart = 473396, XrefRangeEnd = 473429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(Il2CppSystem.Object targetObj, MethodInfo method)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473431, XrefRangeEnd = 473439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473439, XrefRangeEnd = 473447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearPersistent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473447, XrefRangeEnd = 473454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<BaseInvokableCall> PrepareInvoke()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<BaseInvokableCall>) null : Il2CppObjectPool.Get<List<BaseInvokableCall>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473454, XrefRangeEnd = 473469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvokableCallList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<BaseInvokableCall> m_PersistentCalls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls));
      return num == System.IntPtr.Zero ? (List<BaseInvokableCall>) null : Il2CppObjectPool.Get<List<BaseInvokableCall>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<BaseInvokableCall> m_RuntimeCalls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls));
      return num == System.IntPtr.Zero ? (List<BaseInvokableCall>) null : Il2CppObjectPool.Get<List<BaseInvokableCall>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<BaseInvokableCall> m_ExecutingCalls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls));
      return num == System.IntPtr.Zero ? (List<BaseInvokableCall>) null : Il2CppObjectPool.Get<List<BaseInvokableCall>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_NeedsUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate)) = value;
    }
  }
}
