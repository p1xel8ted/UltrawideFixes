// Decompiled with JetBrains decompiler
// Type: Unity.Collections.CollectionExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Collections;

public static class CollectionExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0;

  static CollectionExtensions()
  {
    Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", nameof (CollectionExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr);
    CollectionExtensions.NativeMethodInfoPtr_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100663478 /*0x060000B6*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414217, RefRangeEnd = 414218, XrefRangeStart = 414184, XrefRangeEnd = 414217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string SerializedView<T>(
    this IEnumerable<T> collection,
    Il2CppSystem.Func<T, string> serializeElement)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializeElement);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public CollectionExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static void AddSorted<T>(List<T> list, T item, IComparer<T> comparer = null)
  {
    if (list == null)
      throw new Il2CppSystem.ArgumentNullException("list must not be null.");
    if (comparer == null)
      comparer = (IComparer<T>) Comparer<T>.Default;
    if (list.Count == 0)
    {
      list.Add(item);
    }
    else
    {
      IComparer<T> icomparer = comparer;
      List<T> list1 = list;
      T x = list1[list1.Count - 1];
      T y = item;
      if (icomparer.Compare(x, y) <= 0)
        list.Add(item);
      else if (comparer.Compare(list[0], item) >= 0)
      {
        list.Insert(0, item);
      }
      else
      {
        int index = list.BinarySearch(item, comparer);
        if (index < 0)
          index = ~index;
        list.Insert(index, item);
      }
    }
  }

  public static void Fill<T>(List<T> dest, T value, int count)
  {
    if (dest == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (dest));
    dest.Capacity = Il2CppSystem.Math.Max(dest.Capacity, dest.Count + count);
    while (count-- > 0)
      dest.Add(value);
  }

  public static T FirstOrDefaultSorted<T>(IEnumerable<T> collection, IComparer<T> comparer = null)
  {
    if (collection == null)
      throw new Il2CppSystem.ArgumentNullException("collection must not be null.");
    if (comparer == null)
      comparer = (IComparer<T>) Comparer<T>.Default;
    bool flag = false;
    T y = default (T);
    IEnumerator<T> enumerator = collection.GetEnumerator();
    try
    {
      while (((IEnumerator) enumerator).MoveNext())
      {
        T current = enumerator.Current;
        if (!flag)
        {
          y = current;
          flag = true;
        }
        if (comparer.Compare(current, y) < 0)
          y = current;
      }
    }
    finally
    {
      ((Il2CppSystem.IDisposable) enumerator)?.Dispose();
    }
    return y;
  }

  public static bool ContainsByEquals<T>(IEnumerable<T> collection, T element)
  {
    IEnumerator<T> ienumerator = collection != null ? collection.GetEnumerator() : throw new Il2CppSystem.ArgumentNullException("collection must not be null.");
    try
    {
      while (((IEnumerator) ienumerator).MoveNext())
      {
        if (ienumerator.Current.Equals((Il2CppSystem.Object) (object) element))
          return true;
      }
    }
    finally
    {
      ((Il2CppSystem.IDisposable) ienumerator)?.Dispose();
    }
    return false;
  }

  [ObfuscatedName("Unity.Collections.CollectionExtensions+<>c__DisplayClass3_0`1")]
  public sealed class __c__DisplayClass3_0<T>(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_serializeElement;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SerializedView_b__0_Internal_String_T_0;

    static __c__DisplayClass3_0()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<CollectionExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, "<>c__DisplayClass3_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr);
      CollectionExtensions.__c__DisplayClass3_0<T>.NativeFieldInfoPtr_serializeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr, nameof (serializeElement));
      CollectionExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr, 100663479 /*0x060000B7*/);
      CollectionExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__SerializedView_b__0_Internal_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr, 100663480 /*0x060000B8*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass3_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionExtensions.__c__DisplayClass3_0<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414182, XrefRangeEnd = 414184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _SerializedView_b__0(T t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) t;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref t;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.__c__DisplayClass3_0<T>.NativeMethodInfoPtr__SerializedView_b__0_Internal_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    public unsafe Il2CppSystem.Func<T, string> serializeElement
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectionExtensions.__c__DisplayClass3_0<T>.NativeFieldInfoPtr_serializeElement));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<T, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<T, string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollectionExtensions.__c__DisplayClass3_0<T>.NativeFieldInfoPtr_serializeElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_SerializedView_Internal_Static_String_IEnumerable_1_T_Func_2_T_String_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
