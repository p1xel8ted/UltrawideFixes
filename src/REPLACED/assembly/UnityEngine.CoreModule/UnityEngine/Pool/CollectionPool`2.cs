// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pool.CollectionPool`2
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

public class CollectionPool<TCollection, TItem>(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  where TCollection : class, new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Pool;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_TCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0;

  static CollectionPool()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "CollectionPool`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr);
    CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, nameof (s_Pool));
    CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100669282);
    CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100669283);
    CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100669284);
  }

  [CallerCount(55)]
  [CachedScanResults(RefRangeStart = 479127, RefRangeEnd = 479182, XrefRangeStart = 479119, XrefRangeEnd = 479127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TCollection Get()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TCollection>(num2, false, true);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 479189, RefRangeEnd = 479218, XrefRangeStart = 479182, XrefRangeEnd = 479189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PooledObject<TCollection> Get(out TCollection value)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TCollection& local1;
    if (!typeof (TCollection).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TCollection*) &zero);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    if (!typeof (TCollection).IsValueType)
    {
      ref TCollection local2 = ref value;
      System.IntPtr num2 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCollection>(num2, false, false);
      local2 = (TCollection) valueGeneric;
    }
    return new PooledObject<TCollection>(pointer);
  }

  [CallerCount(54)]
  [CachedScanResults(RefRangeStart = 479254, RefRangeEnd = 479308, XrefRangeStart = 479218, XrefRangeEnd = 479254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Release(TCollection toRelease)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    TCollection& local1;
    if (!typeof (TCollection).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TCollection> local2 = (object) toRelease;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TCollection&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TCollection&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref toRelease;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ObjectPool<TCollection> s_Pool
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ObjectPool<TCollection>) null : Il2CppObjectPool.Get<ObjectPool<TCollection>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("UnityEngine.Pool.CollectionPool`2+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0;

    static __c()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr);
      CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, "<>9");
      CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100669287);
      CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100669288);
      CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100669289);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TCollection __cctor_b__5_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<TCollection>(num2, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479116, XrefRangeEnd = 479119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __cctor_b__5_1(TCollection l)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TCollection& local1;
      if (!typeof (TCollection).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TCollection> local2 = (object) l;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TCollection&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TCollection&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref l;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe CollectionPool<TCollection, TItem>.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CollectionPool<TCollection, TItem>.__c) null : Il2CppObjectPool.Get<CollectionPool<TCollection, TItem>.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
