// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pool.GenericPool`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Pool;

public class GenericPool<T>(System.IntPtr pointer) : Il2CppSystem.Object(pointer) where T : class, new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Pool;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_T_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_T_0;

  static GenericPool()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "GenericPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr);
    GenericPool<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, nameof (s_Pool));
    GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100669290);
    GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100669291);
    GenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, 100669292);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 479318, RefRangeEnd = 479320, XrefRangeStart = 479308, XrefRangeEnd = 479318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Get()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 479189, RefRangeEnd = 479218, XrefRangeStart = 479189, XrefRangeEnd = 479218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PooledObject<T> Get(out T value)
  {
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
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_T_byref_T_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref value;
      System.IntPtr num2 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
      local2 = (T) valueGeneric;
    }
    return new PooledObject<T>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 479327, RefRangeEnd = 479330, XrefRangeStart = 479320, XrefRangeEnd = 479327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Release(T toRelease)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) toRelease;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref toRelease;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_T_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ObjectPool<T> s_Pool
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GenericPool<T>.NativeFieldInfoPtr_s_Pool, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ObjectPool<T>) null : Il2CppObjectPool.Get<ObjectPool<T>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenericPool<T>.NativeFieldInfoPtr_s_Pool, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("UnityEngine.Pool.GenericPool`1+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_T_0;

    static __c()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr);
      GenericPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr, "<>9");
      GenericPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr, 100669295);
      GenericPool<T>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr, 100669296);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPool<T>.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T __cctor_b__5_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenericPool<T>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }

    public static unsafe GenericPool<T>.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GenericPool<T>.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GenericPool<T>.__c) null : Il2CppObjectPool.Get<GenericPool<T>.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GenericPool<T>.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
