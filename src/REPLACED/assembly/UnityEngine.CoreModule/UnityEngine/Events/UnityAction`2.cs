// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityAction`2
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

public sealed class UnityAction<T0, T1>(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_0;

  static UnityAction()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
    }))).TypeHandle).value);
    UnityAction<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr, 100669156);
    UnityAction<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr, 100669157);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 474369, RefRangeEnd = 474377, XrefRangeStart = 474367, XrefRangeEnd = 474369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityAction(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(T0 arg0, T1 arg1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
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
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  public static implicit operator UnityAction<T0, T1>([In] System.Action<T0, T1> obj0)
  {
    return DelegateSupport.ConvertDelegate<UnityAction<T0, T1>>((System.Delegate) obj0);
  }

  public static UnityAction<T0, T1> operator +([In] UnityAction<T0, T1> obj0, [In] UnityAction<T0, T1> obj1)
  {
    return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<UnityAction<T0, T1>>();
  }

  public static UnityAction<T0, T1> operator -([In] UnityAction<T0, T1> obj0, [In] UnityAction<T0, T1> obj1)
  {
    Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
    return (object) @delegate == null ? (UnityAction<T0, T1>) @delegate : @delegate.Cast<UnityAction<T0, T1>>();
  }
}
