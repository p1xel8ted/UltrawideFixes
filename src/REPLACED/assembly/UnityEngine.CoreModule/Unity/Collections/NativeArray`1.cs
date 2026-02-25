// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeArray`1
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
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

#nullable disable
namespace Unity.Collections;

public sealed class NativeArray<T> : Il2CppSystem.ValueType where T : new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocatorLabel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Allocator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AsReadOnlySpan_Public_ReadOnlySpan_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_T_byref_NativeArray_1_T_0;

  static NativeArray()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArray`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr);
    NativeArray<T>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, nameof (m_Buffer));
    NativeArray<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, nameof (m_Length));
    NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, nameof (m_AllocatorLabel));
    NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663484 /*0x060000BC*/);
    NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663485 /*0x060000BD*/);
    NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663486 /*0x060000BE*/);
    NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663487 /*0x060000BF*/);
    NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663488 /*0x060000C0*/);
    NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663489 /*0x060000C1*/);
    NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663490 /*0x060000C2*/);
    NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663491 /*0x060000C3*/);
    NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663492 /*0x060000C4*/);
    NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663493 /*0x060000C5*/);
    NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663494 /*0x060000C6*/);
    NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663495 /*0x060000C7*/);
    NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663496 /*0x060000C8*/);
    NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663497 /*0x060000C9*/);
    NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663498 /*0x060000CA*/);
    NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663499 /*0x060000CB*/);
    NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663500 /*0x060000CC*/);
    NativeArray<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663501 /*0x060000CD*/);
    NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663502 /*0x060000CE*/);
    NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663503 /*0x060000CF*/);
    NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663504 /*0x060000D0*/);
    NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663505 /*0x060000D1*/);
    NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663506 /*0x060000D2*/);
    NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663507 /*0x060000D3*/);
    NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663508 /*0x060000D4*/);
    NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663509 /*0x060000D5*/);
    NativeArray<T>.NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663510 /*0x060000D6*/);
    NativeArray<T>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663511 /*0x060000D7*/);
    NativeArray<T>.NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663512 /*0x060000D8*/);
    NativeArray<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663513 /*0x060000D9*/);
    NativeArray<T>.NativeMethodInfoPtr_AsReadOnlySpan_Public_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663514 /*0x060000DA*/);
    NativeArray<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_T_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663515 /*0x060000DB*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414239, RefRangeEnd = 414240, XrefRangeStart = 414235, XrefRangeEnd = 414239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &length;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Allocator_NativeArrayOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414240, XrefRangeEnd = 414252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray(Il2CppArrayBase<T> array, Allocator allocator)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414252, XrefRangeEnd = 414260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray(NativeArray<T> array, Allocator allocator)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414260, XrefRangeEnd = 414264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Allocate(int length, Allocator allocator, out NativeArray<T> array)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = (System.IntPtr) &length;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref NativeArray<T> local = ref array;
    System.IntPtr pointer = zero;
    NativeArray<T> nativeArray = pointer == System.IntPtr.Zero ? (NativeArray<T>) null : new NativeArray<T>(pointer);
    local = nativeArray;
  }

  public unsafe int Length
  {
    [CallerCount(34), CachedScanResults(RefRangeStart = 327541, RefRangeEnd = 327575, XrefRangeStart = 327541, XrefRangeEnd = 327575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe T this[int index]
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414264, XrefRangeEnd = 414265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      T& local1;
      if (!typeof (T).IsValueType)
      {
        __Boxed<T> local2 = (object) value;
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2;
      IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
    }
  }

  public unsafe bool IsCreated
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 150430, RefRangeEnd = 150434, XrefRangeStart = 150430, XrefRangeEnd = 150434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(94)]
  [CachedScanResults(RefRangeStart = 414267, RefRangeEnd = 414361, XrefRangeStart = 414265, XrefRangeEnd = 414267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414361, XrefRangeEnd = 414401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyFrom(NativeArray<T> array)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414401, XrefRangeEnd = 414414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> ToArray()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414414, XrefRangeEnd = 414416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T>.Enumerator GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>.Enumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414416, XrefRangeEnd = 414420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator<T>) null : Il2CppObjectPool.Get<IEnumerator<T>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414420, XrefRangeEnd = 414425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(NativeArray<T> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414432, RefRangeEnd = 414433, XrefRangeStart = 414425, XrefRangeEnd = 414432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414433, RefRangeEnd = 414434, XrefRangeStart = 414433, XrefRangeEnd = 414433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414435, RefRangeEnd = 414437, XrefRangeStart = 414434, XrefRangeEnd = 414435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(NativeArray<T> left, NativeArray<T> right)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) left));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) right));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_NativeArray_1_T_NativeArray_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414437, XrefRangeEnd = 414451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Copy(NativeArray<T> src, NativeArray<T> dst)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) src));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dst));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414451, XrefRangeEnd = 414460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dst));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414460, XrefRangeEnd = 414489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) src));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dst));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_NativeArray_1_T_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414489, XrefRangeEnd = 414498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst, int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) src));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dst);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414498, XrefRangeEnd = 414518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Copy(
    NativeArray<T> src,
    int srcIndex,
    NativeArray<T> dst,
    int dstIndex,
    int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) src));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dst));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dstIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414518, XrefRangeEnd = 414530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopySafe(
    NativeArray<T> src,
    int srcIndex,
    NativeArray<T> dst,
    int dstIndex,
    int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) src));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dst));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dstIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_NativeArray_1_T_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414530, XrefRangeEnd = 414538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopySafe(
    Il2CppArrayBase<T> src,
    int srcIndex,
    NativeArray<T> dst,
    int dstIndex,
    int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dst));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dstIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414538, XrefRangeEnd = 414546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopySafe(
    NativeArray<T> src,
    int srcIndex,
    Il2CppArrayBase<T> dst,
    int dstIndex,
    int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) src));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dst);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dstIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_CopySafe_Private_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414546, XrefRangeEnd = 414548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<U> InternalReinterpret<U>(int length) where U : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &length
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<U>.MethodInfoStoreGeneric_InternalReinterpret_Private_NativeArray_1_U_Int32_0\u00601.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<U>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 414552, RefRangeEnd = 414555, XrefRangeStart = 414548, XrefRangeEnd = 414552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &expectedTypeSize
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<U>.MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_Int32_0\u00601.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<U>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414555, XrefRangeEnd = 414558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> GetSubArray(int start, int length)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414560, RefRangeEnd = 414562, XrefRangeStart = 414558, XrefRangeEnd = 414560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T>.ReadOnly AsReadOnly()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>.ReadOnly(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414562, XrefRangeEnd = 414564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.ReadOnlySpan<T> AsReadOnlySpan()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_AsReadOnlySpan_Public_ReadOnlySpan_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.ReadOnlySpan<T>(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 414567, RefRangeEnd = 414571, XrefRangeStart = 414564, XrefRangeEnd = 414567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Il2CppSystem.ReadOnlySpan<T>([In] ref NativeArray<T> source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_T_byref_NativeArray_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.ReadOnlySpan<T>(pointer);
  }

  public NativeArray(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public NativeArray()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
  {
  }

  public unsafe void* m_Buffer
  {
    get
    {
      return (void*) *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer));
    }
    [param: In] set
    {
      *(void**) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer)) = value;
    }
  }

  public unsafe int m_Length
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length)) = value;
    }
  }

  public unsafe Allocator m_AllocatorLabel
  {
    get
    {
      return *(Allocator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel));
    }
    [param: In] set
    {
      *(Allocator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel)) = value;
    }
  }

  public static void CheckAllocateArguments(int length, Allocator allocator)
  {
    if (allocator <= Allocator.None)
      throw new Il2CppSystem.ArgumentException("Allocator must be Temp, TempJob or Persistent", nameof (allocator));
    if (allocator >= Allocator.FirstUserIndex)
      throw new Il2CppSystem.ArgumentException("Use CollectionHelper.CreateNativeArray in com.unity.collections package for custom allocator", nameof (allocator));
    if (length < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (length), "Length must be >= 0");
  }

  public static void IsUnmanagedAndThrow()
  {
    if (!UnsafeUtility.IsUnmanaged<T>())
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("{0} used in NativeArray<{1}> must be unmanaged (contain no managed types).", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
  }

  public void CheckElementReadAccess(int index)
  {
  }

  public void CheckElementWriteAccess(int index)
  {
  }

  public unsafe JobHandle Dispose(JobHandle inputDeps)
  {
    if (!this.IsCreated)
      return inputDeps;
    if (((NativeArray<>) this).m_AllocatorLabel >= Allocator.FirstUserIndex)
      throw new Il2CppSystem.InvalidOperationException("The NativeArray can not be Disposed because it was allocated with a custom allocator, use CollectionHelper.Dispose in com.unity.collections package.");
    if (((NativeArray<>) this).m_AllocatorLabel > Allocator.None)
    {
      JobHandle jobHandle = IJobExtensions.Schedule<NativeArrayDisposeJob>(new NativeArrayDisposeJob()
      {
        Data = new NativeArrayDispose()
        {
          m_Buffer = (System.IntPtr) ((NativeArray<>) this).m_Buffer,
          m_AllocatorLabel = ((NativeArray<>) this).m_AllocatorLabel
        }
      }, inputDeps);
      ((NativeArray<>) this).m_Buffer = (void*) null;
      ((NativeArray<>) this).m_AllocatorLabel = Allocator.Invalid;
      return jobHandle;
    }
    ((NativeArray<>) this).m_Buffer = (void*) null;
    return inputDeps;
  }

  public void CopyFrom(Il2CppArrayBase<T> array)
  {
    // ISSUE: unable to decompile the method.
  }

  public void CopyTo(Il2CppArrayBase<T> array)
  {
    // ISSUE: unable to decompile the method.
  }

  public void CopyTo(NativeArray<T> array)
  {
    // ISSUE: unable to decompile the method.
  }

  public static bool operator !=(NativeArray<T> left, NativeArray<T> right)
  {
    return !((NativeArray<T>) ref left).Equals(right);
  }

  public static void Copy(NativeArray<T>.ReadOnly src, NativeArray<T> dst)
  {
    NativeArray<T>.CopySafe(src, 0, dst, 0, ((NativeArray<T>.ReadOnly) ref src).Length);
  }

  public static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst)
  {
    NativeArray<T>.CopySafe(src, 0, dst, 0, ((NativeArray<T>) ref src).Length);
  }

  public static void Copy(NativeArray<T>.ReadOnly src, Il2CppArrayBase<T> dst)
  {
    NativeArray<T>.CopySafe(src, 0, dst, 0, ((NativeArray<T>.ReadOnly) ref src).Length);
  }

  public static void Copy(NativeArray<T>.ReadOnly src, NativeArray<T> dst, int length)
  {
    NativeArray<T>.CopySafe(src, 0, dst, 0, length);
  }

  public static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst, int length)
  {
    NativeArray<T>.CopySafe(src, 0, dst, 0, length);
  }

  public static void Copy(NativeArray<T>.ReadOnly src, Il2CppArrayBase<T> dst, int length)
  {
    NativeArray<T>.CopySafe(src, 0, dst, 0, length);
  }

  public static void Copy(
    NativeArray<T>.ReadOnly src,
    int srcIndex,
    NativeArray<T> dst,
    int dstIndex,
    int length)
  {
    NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
  }

  public static void Copy(
    Il2CppArrayBase<T> src,
    int srcIndex,
    NativeArray<T> dst,
    int dstIndex,
    int length)
  {
    NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
  }

  public static void Copy(
    NativeArray<T> src,
    int srcIndex,
    Il2CppArrayBase<T> dst,
    int dstIndex,
    int length)
  {
    NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
  }

  public static void Copy(
    NativeArray<T>.ReadOnly src,
    int srcIndex,
    Il2CppArrayBase<T> dst,
    int dstIndex,
    int length)
  {
    NativeArray<T>.CopySafe(src, srcIndex, dst, dstIndex, length);
  }

  public static unsafe void CopySafe(
    NativeArray<T>.ReadOnly src,
    int srcIndex,
    NativeArray<T> dst,
    int dstIndex,
    int length)
  {
    UnsafeUtility.MemCpy((void*) ((System.IntPtr) ((NativeArray<>) dst).m_Buffer + dstIndex * UnsafeUtility.SizeOf<T>()), (void*) ((System.IntPtr) ((NativeArray<>.ReadOnly) src).m_Buffer + srcIndex * UnsafeUtility.SizeOf<T>()), (long) (length * UnsafeUtility.SizeOf<T>()));
  }

  public static unsafe void CopySafe(
    NativeArray<T>.ReadOnly src,
    int srcIndex,
    Il2CppArrayBase<T> dst,
    int dstIndex,
    int length)
  {
    Il2CppSystem.Runtime.InteropServices.GCHandle gcHandle = Il2CppSystem.Runtime.InteropServices.GCHandle.Alloc((Il2CppSystem.Object) dst, Il2CppSystem.Runtime.InteropServices.GCHandleType.Pinned);
    UnsafeUtility.MemCpy((void*) ((System.IntPtr) (void*) gcHandle.AddrOfPinnedObject() + dstIndex * UnsafeUtility.SizeOf<T>()), (void*) ((System.IntPtr) ((NativeArray<>.ReadOnly) src).m_Buffer + srcIndex * UnsafeUtility.SizeOf<T>()), (long) (length * UnsafeUtility.SizeOf<T>()));
    gcHandle.Free();
  }

  public static void CheckCopyPtr(Il2CppArrayBase<T> ptr)
  {
    if (ptr == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (ptr));
  }

  public static void CheckCopyLengths(int srcLength, int dstLength)
  {
    if (srcLength != dstLength)
      throw new Il2CppSystem.ArgumentException("source and destination length must be the same");
  }

  public static void CheckCopyArguments(
    int srcLength,
    int srcIndex,
    int dstLength,
    int dstIndex,
    int length)
  {
    if (length < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (length), "length must be equal or greater than zero.");
    if (srcIndex < 0 || srcIndex > srcLength || srcIndex == srcLength && srcLength > 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (srcIndex), "srcIndex is outside the range of valid indexes for the source NativeArray.");
    if (dstIndex < 0 || dstIndex > dstLength || dstIndex == dstLength && dstLength > 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (dstIndex), "dstIndex is outside the range of valid indexes for the destination NativeArray.");
    if (srcIndex + length > srcLength)
      throw new Il2CppSystem.ArgumentException("length is greater than the number of elements from srcIndex to the end of the source NativeArray.", nameof (length));
    if (srcIndex + length < 0)
      throw new Il2CppSystem.ArgumentException("srcIndex + length causes an integer overflow");
    if (dstIndex + length > dstLength)
      throw new Il2CppSystem.ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination NativeArray.", nameof (length));
    if (dstIndex + length < 0)
      throw new Il2CppSystem.ArgumentException("dstIndex + length causes an integer overflow");
  }

  public void CheckReinterpretLoadRange<U>(int sourceIndex) where U : struct
  {
  }

  public void CheckReinterpretStoreRange<U>(int destIndex) where U : struct
  {
  }

  public unsafe U ReinterpretLoad<U>(int sourceIndex) where U : struct
  {
    return UnsafeUtility.ReadArrayElement<U>((void*) ((System.IntPtr) ((NativeArray<>) this).m_Buffer + (System.IntPtr) ((long) UnsafeUtility.SizeOf<T>() * (long) sourceIndex)), 0);
  }

  public unsafe void ReinterpretStore<U>(int destIndex, U data) where U : struct
  {
    UnsafeUtility.WriteArrayElement<U>((void*) ((System.IntPtr) ((NativeArray<>) this).m_Buffer + (System.IntPtr) ((long) UnsafeUtility.SizeOf<T>() * (long) destIndex)), 0, data);
  }

  public static void CheckReinterpretSize<U>() where U : struct
  {
    if (UnsafeUtility.SizeOf<T>() != UnsafeUtility.SizeOf<U>())
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("Types {0} and {1} are different sizes - direct reinterpretation is not possible. If this is what you intended, use Reinterpret(<type size>)", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
  }

  public NativeArray<U> Reinterpret<U>() where U : struct
  {
    return this.InternalReinterpret<U>(this.Length);
  }

  public void CheckReinterpretSize<U>(
    long tSize,
    long uSize,
    int expectedTypeSize,
    long byteLen,
    long uLen)
  {
    if (tSize != (long) expectedTypeSize)
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("Type {0} was expected to be {1} but is {2} bytes", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) (System.ValueType) expectedTypeSize, (Il2CppSystem.Object) (System.ValueType) tSize));
    if (uLen * uSize != byteLen)
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("Types {0} (array length {1}) and {2} cannot be aliased due to size constraints. The size of the types and lengths involved must line up.", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) (System.ValueType) this.Length, (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
  }

  public void CheckGetSubArrayArguments(int start, int length)
  {
    if (start < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (start), "start must be >= 0");
    if (start + length > this.Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (length), Il2CppSystem.String.Format("sub array range {0}-{1} is outside the range of the native array 0-{2}", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) (start + length - 1), (Il2CppSystem.Object) (System.ValueType) (this.Length - 1)));
    if (start + length < 0)
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("sub array range {0}-{1} caused an integer overflow and is outside the range of the native array 0-{2}", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) (start + length - 1), (Il2CppSystem.Object) (System.ValueType) (this.Length - 1)));
  }

  public unsafe Il2CppSystem.Span<T> AsSpan()
  {
    return new Il2CppSystem.Span<T>(((NativeArray<>) this).m_Buffer, ((NativeArray<>) this).m_Length);
  }

  public sealed class Enumerator : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Array;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static Enumerator()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, nameof (Enumerator<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr);
      NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, nameof (m_Array));
      NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, nameof (m_Index));
      NativeArray<T>.Enumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, nameof (value));
      NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663516 /*0x060000DC*/);
      NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663517 /*0x060000DD*/);
      NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663518 /*0x060000DE*/);
      NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663519 /*0x060000DF*/);
      NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663520 /*0x060000E0*/);
      NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663521 /*0x060000E1*/);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 414218, RefRangeEnd = 414224, XrefRangeStart = 414218, XrefRangeEnd = 414218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Enumerator(ref NativeArray<T> array)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe T Current
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
      }
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414224, XrefRangeEnd = 414227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public Enumerator(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Enumerator()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
    {
    }

    public NativeArray<T> m_Array
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array);
        return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int m_Index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
      }
    }

    public unsafe T value
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_value), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_value);
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

  public sealed class ReadOnly : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

    static ReadOnly()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, nameof (ReadOnly<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr);
      NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, nameof (m_Buffer));
      NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, nameof (m_Length));
      NativeArray<T>.ReadOnly.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663522 /*0x060000E2*/);
      NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663523 /*0x060000E3*/);
      NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663524 /*0x060000E4*/);
      NativeArray<T>.ReadOnly.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663525 /*0x060000E5*/);
      NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663526 /*0x060000E6*/);
      NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, 100663527 /*0x060000E7*/);
    }

    [CallerCount(529)]
    [CachedScanResults(RefRangeStart = 232843, RefRangeEnd = 233372, XrefRangeStart = 232843, XrefRangeEnd = 233372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReadOnly(void* buffer, int length)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int Length
    {
      [CallerCount(34), CachedScanResults(RefRangeStart = 327541, RefRangeEnd = 327575, XrefRangeStart = 327541, XrefRangeEnd = 327575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe T this[int index]
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414227, XrefRangeEnd = 414228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &index
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414228, XrefRangeEnd = 414230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<T>.ReadOnly.Enumerator GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new NativeArray<T>.ReadOnly.Enumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414230, XrefRangeEnd = 414235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator<T>) null : Il2CppObjectPool.Get<IEnumerator<T>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public ReadOnly(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ReadOnly()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr))
    {
    }

    public unsafe void* m_Buffer
    {
      get
      {
        return (void*) *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer));
      }
      [param: In] set
      {
        *(void**) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Buffer)) = value;
      }
    }

    public unsafe int m_Length
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.NativeFieldInfoPtr_m_Length)) = value;
      }
    }

    public sealed class Enumerator : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_m_Array;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
      private static readonly System.IntPtr NativeFieldInfoPtr_value;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static Enumerator()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, nameof (Enumerator<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr);
        NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, nameof (m_Array));
        NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, nameof (m_Index));
        NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, nameof (value));
        NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663528 /*0x060000E8*/);
        NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663529 /*0x060000E9*/);
        NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663530 /*0x060000EA*/);
        NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663531 /*0x060000EB*/);
        NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663532 /*0x060000EC*/);
        NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr, 100663533 /*0x060000ED*/);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 414218, RefRangeEnd = 414224, XrefRangeStart = 414218, XrefRangeEnd = 414224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Enumerator([In] ref NativeArray<T>.ReadOnly array)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_ReadOnly_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      public virtual unsafe void Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe T Current
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
        }
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.ReadOnly.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public Enumerator(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Enumerator()
        : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.ReadOnly.Enumerator>.NativeClassPtr))
      {
      }

      public NativeArray<T>.ReadOnly m_Array
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array);
          return new NativeArray<T>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>.ReadOnly>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe int m_Index
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
        }
      }

      public unsafe T value
      {
        get
        {
          return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value), true, false);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeArray<T>.ReadOnly.Enumerator.NativeFieldInfoPtr_value);
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
  }

  private sealed class MethodInfoStoreGeneric_InternalReinterpret_Private_NativeArray_1_U_Int32_0\u00601
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_InternalReinterpret_Private_NativeArray_1_U_Int32_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Reinterpret_Public_NativeArray_1_U_Int32_0\u00601
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArray<U>.NativeMethodInfoPtr_Reinterpret_Public_NativeArray_1_U_Int32_0, Il2CppClassPointerStore<NativeArray<U>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
    }))));
  }
}
