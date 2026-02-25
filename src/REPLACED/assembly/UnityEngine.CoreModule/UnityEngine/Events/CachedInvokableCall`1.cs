// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.CachedInvokableCall`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

public class CachedInvokableCall<T>(System.IntPtr pointer) : InvokableCall<T>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Arg1;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_T_0;

  static CachedInvokableCall()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "CachedInvokableCall`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr);
    CachedInvokableCall<T>.NativeFieldInfoPtr_m_Arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, nameof (m_Arg1));
    CachedInvokableCall<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, 100669096);
    CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, 100669097);
    CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, 100669098);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473200, RefRangeEnd = 473201, XrefRangeStart = 473199, XrefRangeEnd = 473200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CachedInvokableCall(UnityEngine.Object target, MethodInfo theFunction, T argument)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theFunction);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) argument;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref argument;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(CachedInvokableCall<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473201, XrefRangeEnd = 473208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Invoke(Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Invoke(T arg0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) arg0;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref arg0;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe T m_Arg1
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CachedInvokableCall<T>.NativeFieldInfoPtr_m_Arg1), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CachedInvokableCall<T>.NativeFieldInfoPtr_m_Arg1);
      System.Type type = typeof (T);
      if (!type.IsValueType)
      {
        if (!string.Equals(type.FullName, "System.String"))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
          if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
          {
            System.IntPtr num2 = ptr;
            System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
            int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
            __memcpy(num1, num3, num4);
          }
          else
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
        }
        else
        {
          System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
        }
      }
      else
      {
        T obj = value;
        *(T*) num1 = obj;
      }
    }
  }
}
