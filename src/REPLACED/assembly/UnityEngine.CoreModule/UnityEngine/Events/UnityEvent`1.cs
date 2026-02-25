// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityEvent`1
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
public class UnityEvent<T0>(System.IntPtr pointer) : UnityEventBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InvokeArray;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_0;

  static UnityEvent()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr);
    UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, nameof (m_InvokeArray));
    UnityEvent<T0>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669149);
    UnityEvent<T0>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669150);
    UnityEvent<T0>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669151);
    UnityEvent<T0>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669152);
    UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669153);
    UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669154);
    UnityEvent<T0>.NativeMethodInfoPtr_Invoke_Public_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100669155);
  }

  [CallerCount(101)]
  [CachedScanResults(RefRangeStart = 473975, RefRangeEnd = 474076, XrefRangeStart = 473974, XrefRangeEnd = 473975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(98)]
  [CachedScanResults(RefRangeStart = 474169, RefRangeEnd = 474267, XrefRangeStart = 474076, XrefRangeEnd = 474169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(UnityAction<T0> call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 474270, RefRangeEnd = 474301, XrefRangeStart = 474267, XrefRangeEnd = 474270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(UnityAction<T0> call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474301, XrefRangeEnd = 474337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe MethodInfo FindMethod_Impl(string name, Il2CppSystem.Type targetObjType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObjType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEvent<T0>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474337, XrefRangeEnd = 474340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe BaseInvokableCall GetDelegate(Il2CppSystem.Object target, MethodInfo theFunction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theFunction);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474340, XrefRangeEnd = 474345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BaseInvokableCall GetDelegate(UnityAction<T0> action)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 474366, RefRangeEnd = 474367, XrefRangeStart = 474345, XrefRangeEnd = 474366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke(T0 arg0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
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
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_Invoke_Public_Void_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> m_InvokeArray
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
