// Decompiled with JetBrains decompiler
// Type: SadCatStudios.ListSerializationWrapper`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios;

public class ListSerializationWrapper<T, SelfT>(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  where SelfT : ListSerializationWrapper<T, SelfT>, new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromList_Public_Static_SelfT_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ListSerializationWrapper()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios", "ListSerializationWrapper`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SelfT>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr);
    ListSerializationWrapper<T, SelfT>.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, nameof (Entries));
    ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, 100670748);
    ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, 100670749);
    ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, 100670750);
    ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, 100670751);
    ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_FromList_Public_Static_SelfT_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, 100670752);
    ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr, 100670753);
  }

  public unsafe int Length
  {
    [CallerCount(89), CachedScanResults(RefRangeStart = 73100, RefRangeEnd = 73189, XrefRangeStart = 73100, XrefRangeEnd = 73189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe T this[int i]
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 87936, RefRangeEnd = 87947, XrefRangeStart = 87936, XrefRangeEnd = 87936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 87950, RefRangeEnd = 87954, XrefRangeStart = 87947, XrefRangeEnd = 87950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator<T> GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator<T>) null : Il2CppObjectPool.Get<IEnumerator<T>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87954, XrefRangeEnd = 87960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87960, XrefRangeEnd = 87962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SelfT FromList(Il2CppArrayBase<T> entries)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr_FromList_Public_Static_SelfT_Il2CppArrayBase_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<SelfT>(num2, false, true);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ListSerializationWrapper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListSerializationWrapper<T, SelfT>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ListSerializationWrapper<T, SelfT>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppArrayBase<T> Entries
  {
    get
    {
      return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ListSerializationWrapper<T, SelfT>.NativeFieldInfoPtr_Entries)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ListSerializationWrapper<T, SelfT>.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
