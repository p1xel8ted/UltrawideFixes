// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.InvokableCall`3
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

public class InvokableCall<T1, T2, T3>(System.IntPtr pointer) : BaseInvokableCall(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Delegate;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_3_T1_T2_T3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_3_T1_T2_T3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_3_T1_T2_T3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_T3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;

  static InvokableCall()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr);
    InvokableCall<T1, T2, T3>.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, nameof (Delegate));
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_3_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669086);
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_3_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669087);
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669088);
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_3_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669089);
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669090);
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669091);
    InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr, 100669092);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_Delegate(UnityAction<T1, T2, T3> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_3_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_Delegate(UnityAction<T1, T2, T3> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_3_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 473142, RefRangeEnd = 473144, XrefRangeStart = 473142, XrefRangeEnd = 473144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvokableCall(Il2CppSystem.Object target, MethodInfo theFunction)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theFunction);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 473150, RefRangeEnd = 473154, XrefRangeStart = 473150, XrefRangeEnd = 473154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvokableCall(UnityAction<T1, T2, T3> action)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2, T3>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_3_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473163, XrefRangeEnd = 473174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Invoke(Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473175, RefRangeEnd = 473176, XrefRangeStart = 473174, XrefRangeEnd = 473175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke(T1 args0, T2 args1, T3 args2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T1& local1;
    if (!typeof (T1).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T1> local2 = (object) args0;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T1&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T1&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref args0;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T2& local3;
    if (!typeof (T2).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T2> local4 = (object) args1;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (T2&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T2&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref args1;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T3& local5;
    if (!typeof (T3).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T3> local6 = (object) args2;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local5 = local6 is string ? (T3&) IL2CPP.ManagedStringToIl2Cpp(local6 as string) : (T3&) IL2CPP.Il2CppObjectBaseToPtr(local6 as Il2CppObjectBase);
    }
    else
      local5 = ref args2;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local5;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
  }

  [CallerCount(0)]
  public override unsafe bool Find(Il2CppSystem.Object targetObj, MethodInfo method)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InvokableCall<T1, T2, T3>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe UnityAction<T1, T2, T3> Delegate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2, T3>.NativeFieldInfoPtr_Delegate));
      return num == System.IntPtr.Zero ? (UnityAction<T1, T2, T3>) null : Il2CppObjectPool.Get<UnityAction<T1, T2, T3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2, T3>.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
