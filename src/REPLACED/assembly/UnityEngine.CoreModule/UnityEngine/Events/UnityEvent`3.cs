// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityEvent`3
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

[Serializable]
public class UnityEvent<T0, T1, T2>(System.IntPtr pointer) : UnityEventBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InvokeArray;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0;

  static UnityEvent()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr);
    UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, nameof (m_InvokeArray));
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669166);
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669167);
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669168);
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669169);
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669170);
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669171);
    UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100669172);
  }

  [CallerCount(101)]
  [CachedScanResults(RefRangeStart = 473975, RefRangeEnd = 474076, XrefRangeStart = 473975, XrefRangeEnd = 474076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 474526, RefRangeEnd = 474527, XrefRangeStart = 474499, XrefRangeEnd = 474526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(UnityAction<T0, T1, T2> call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 474270, RefRangeEnd = 474301, XrefRangeStart = 474270, XrefRangeEnd = 474301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(UnityAction<T0, T1, T2> call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474527, XrefRangeEnd = 474547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe MethodInfo FindMethod_Impl(string name, Il2CppSystem.Type targetObjType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObjType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474547, XrefRangeEnd = 474550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe BaseInvokableCall GetDelegate(Il2CppSystem.Object target, MethodInfo theFunction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theFunction);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474550, XrefRangeEnd = 474555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 474580, RefRangeEnd = 474583, XrefRangeStart = 474555, XrefRangeEnd = 474580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T0& local1;
    if (!typeof (T0).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T0> local2 = (object) arg0;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T0&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T0&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref arg0;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T1& local3;
    if (!typeof (T1).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T1> local4 = (object) arg1;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (T1&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T1&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref arg1;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T2& local5;
    if (!typeof (T2).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T2> local6 = (object) arg2;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local5 = local6 is string ? (T2&) IL2CPP.ManagedStringToIl2Cpp(local6 as string) : (T2&) IL2CPP.Il2CppObjectBaseToPtr(local6 as Il2CppObjectBase);
    }
    else
      local5 = ref arg2;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local5;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> m_InvokeArray
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
