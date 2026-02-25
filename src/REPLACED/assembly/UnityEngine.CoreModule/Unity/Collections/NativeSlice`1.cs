// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeSlice`1
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
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace Unity.Collections;

public sealed class NativeSlice<T> : Il2CppSystem.ValueType where T : new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Stride;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_NativeSlice_1_T_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_NativeSlice_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Stride_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeSlice_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

  static NativeSlice()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSlice`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr);
    NativeSlice<T>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, nameof (m_Buffer));
    NativeSlice<T>.NativeFieldInfoPtr_m_Stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, nameof (m_Stride));
    NativeSlice<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, nameof (m_Length));
    NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663539 /*0x060000F3*/);
    NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663540 /*0x060000F4*/);
    NativeSlice<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_NativeSlice_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663541 /*0x060000F5*/);
    NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663542 /*0x060000F6*/);
    NativeSlice<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663543 /*0x060000F7*/);
    NativeSlice<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663544 /*0x060000F8*/);
    NativeSlice<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663545 /*0x060000F9*/);
    NativeSlice<T>.NativeMethodInfoPtr_get_Stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663546 /*0x060000FA*/);
    NativeSlice<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663547 /*0x060000FB*/);
    NativeSlice<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663548 /*0x060000FC*/);
    NativeSlice<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663549 /*0x060000FD*/);
    NativeSlice<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663550 /*0x060000FE*/);
    NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663551 /*0x060000FF*/);
    NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663552 /*0x06000100*/);
    NativeSlice<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, 100663553 /*0x06000101*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414597, RefRangeEnd = 414598, XrefRangeStart = 414597, XrefRangeEnd = 414597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeSlice(NativeSlice<T> slice, int start, int length)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) slice));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414598, XrefRangeEnd = 414600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeSlice(NativeArray<T> array)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414600, XrefRangeEnd = 414603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator NativeSlice<T>(NativeArray<T> array)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_NativeSlice_1_T_NativeArray_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeSlice<T>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414604, RefRangeEnd = 414605, XrefRangeStart = 414603, XrefRangeEnd = 414604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeSlice(NativeArray<T> array, int start, int length)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe T this[int index]
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 414607, RefRangeEnd = 414608, XrefRangeStart = 414605, XrefRangeEnd = 414607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414608, XrefRangeEnd = 414609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
      IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414609, XrefRangeEnd = 414617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyFrom(NativeSlice<T> slice)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) slice))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeSlice_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int Stride
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_get_Stride_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int Length
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 327414, RefRangeEnd = 327527, XrefRangeStart = 327414, XrefRangeEnd = 327527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414617, XrefRangeEnd = 414619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeSlice<T>.Enumerator GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeSlice<T>.Enumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414619, XrefRangeEnd = 414623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator<T>) null : Il2CppObjectPool.Get<IEnumerator<T>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414623, XrefRangeEnd = 414628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(NativeSlice<T> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeSlice_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414628, XrefRangeEnd = 414635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public NativeSlice(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public NativeSlice()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr))
  {
  }

  public unsafe byte* m_Buffer
  {
    get
    {
      return (byte*) *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Buffer));
    }
    [param: In] set
    {
      *(byte**) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Buffer)) = value;
    }
  }

  public unsafe int m_Stride
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Stride));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Stride)) = value;
    }
  }

  public unsafe int m_Length
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Length));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.NativeFieldInfoPtr_m_Length)) = value;
    }
  }

  public unsafe NativeSlice<U> SliceConvert<U>() where U : struct
  {
    int num = UnsafeUtility.SizeOf<U>();
    NativeSlice<U> nativeSlice;
    ((NativeSlice<>) ref nativeSlice).m_Buffer = ((NativeSlice<>) this).m_Buffer;
    ((NativeSlice<>) ref nativeSlice).m_Stride = num;
    ((NativeSlice<>) ref nativeSlice).m_Length = ((NativeSlice<>) this).m_Length * ((NativeSlice<>) this).m_Stride / num;
    return nativeSlice;
  }

  public unsafe NativeSlice<U> SliceWithStride<U>(int offset) where U : struct
  {
    NativeSlice<U> nativeSlice;
    ((NativeSlice<>) ref nativeSlice).m_Buffer = ((NativeSlice<>) this).m_Buffer + offset;
    ((NativeSlice<>) ref nativeSlice).m_Stride = ((NativeSlice<>) this).m_Stride;
    ((NativeSlice<>) ref nativeSlice).m_Length = ((NativeSlice<>) this).m_Length;
    return nativeSlice;
  }

  public NativeSlice<U> SliceWithStride<U>() where U : struct => this.SliceWithStride<U>(0);

  public void CheckReadIndex(int index)
  {
  }

  public void CheckWriteIndex(int index)
  {
  }

  public void CopyFrom(Il2CppArrayBase<T> array)
  {
    // ISSUE: unable to decompile the method.
  }

  public void CopyTo(NativeArray<T> array)
  {
    // ISSUE: unable to decompile the method.
  }

  public void CopyTo(Il2CppArrayBase<T> array)
  {
    // ISSUE: unable to decompile the method.
  }

  public Il2CppArrayBase<T> ToArray()
  {
    Il2CppArrayBase<T> array = (Il2CppArrayBase<T>) new Il2CppReferenceArray<T>((long) this.Length);
    this.CopyTo(array);
    return array;
  }

  public static bool operator ==(NativeSlice<T> left, NativeSlice<T> right)
  {
    return ((NativeSlice<T>) ref left).Equals(right);
  }

  public static bool operator !=(NativeSlice<T> left, NativeSlice<T> right)
  {
    return !((NativeSlice<T>) ref left).Equals(right);
  }

  public sealed class Enumerator : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Array;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeSlice_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static Enumerator()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, nameof (Enumerator<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr);
      NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, nameof (m_Array));
      NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, nameof (m_Index));
      NativeSlice<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663554 /*0x06000102*/);
      NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663555 /*0x06000103*/);
      NativeSlice<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663556 /*0x06000104*/);
      NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663557 /*0x06000105*/);
      NativeSlice<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663558 /*0x06000106*/);
      NativeSlice<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr, 100663559 /*0x06000107*/);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 414586, RefRangeEnd = 414589, XrefRangeStart = 414586, XrefRangeEnd = 414586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Enumerator(ref NativeSlice<T> array)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeSlice_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414589, XrefRangeEnd = 414591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe T Current
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414591, XrefRangeEnd = 414593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
      }
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414593, XrefRangeEnd = 414597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NativeSlice<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
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
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSlice<T>.Enumerator>.NativeClassPtr))
    {
    }

    public NativeSlice<T> m_Array
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Array);
        return new NativeSlice<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int m_Index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeSlice<T>.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
      }
    }
  }
}
