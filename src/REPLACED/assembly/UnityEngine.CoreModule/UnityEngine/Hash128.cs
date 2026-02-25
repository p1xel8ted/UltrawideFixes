// Decompiled with JetBrains decompiler
// Type: UnityEngine.Hash128
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Hash128
{
  private static readonly System.IntPtr NativeFieldInfoPtr_u64_0;
  private static readonly System.IntPtr NativeFieldInfoPtr_u64_1;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFromPtr_Private_Static_Void_IntPtr_Int32_Int32_Int32_byref_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Compute_Public_Static_Hash128_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShortHash4_Private_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_Void_byref_Hash128_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public ulong u64_0;
  [FieldOffset(8)]
  public ulong u64_1;
  public const ulong kConst = 16045690984833335023 /*0xDEADBEEFDEADBEEF*/;
  private static readonly Hash128.ComputeFromArrayDelegate ComputeFromArrayDelegateField;
  private static readonly Hash128.ComputeFromString_InjectedDelegate ComputeFromString_InjectedDelegateField;

  static Hash128()
  {
    Il2CppClassPointerStore<Hash128>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Hash128));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128>.NativeClassPtr);
    Hash128.NativeFieldInfoPtr_u64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, nameof (u64_0));
    Hash128.NativeFieldInfoPtr_u64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, nameof (u64_1));
    Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667161);
    Hash128.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667162);
    Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667163);
    Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667164);
    Hash128.NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667165);
    Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667166);
    Hash128.NativeMethodInfoPtr_ComputeFromPtr_Private_Static_Void_IntPtr_Int32_Int32_Int32_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667167);
    Hash128.NativeMethodInfoPtr_Compute_Public_Static_Hash128_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667168 /*0x06000F20*/);
    Hash128.NativeMethodInfoPtr_Append_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667169);
    Hash128.NativeMethodInfoPtr_Append_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667170);
    Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667171);
    Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667172);
    Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667173);
    Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667174);
    Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667175);
    Hash128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667176);
    Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667177);
    Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667178);
    Hash128.NativeMethodInfoPtr_ShortHash4_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667179);
    Hash128.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667180);
    Hash128.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667181);
    Hash128.NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667182);
    Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_Void_byref_Hash128_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100667183);
    Hash128.ComputeFromArrayDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromArrayDelegate>("UnityEngine.Hash128::ComputeFromArray");
    Hash128.ComputeFromString_InjectedDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromString_InjectedDelegate>("UnityEngine.Hash128::ComputeFromString_Injected");
  }

  [CallerCount(116)]
  [CachedScanResults(RefRangeStart = 261036, RefRangeEnd = 261152, XrefRangeStart = 261036, XrefRangeEnd = 261152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Hash128(ulong u64_0, ulong u64_1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &u64_0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &u64_1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool isValid
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 437766, RefRangeEnd = 437768, XrefRangeStart = 437766, XrefRangeEnd = 437766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe int CompareTo(Hash128 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rhs
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 437769, RefRangeEnd = 437774, XrefRangeStart = 437768, XrefRangeEnd = 437769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 437788, RefRangeEnd = 437799, XrefRangeStart = 437774, XrefRangeEnd = 437788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Hash128 Parse(string hashString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(hashString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Hash128*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437804, RefRangeEnd = 437805, XrefRangeStart = 437799, XrefRangeEnd = 437804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Hash128ToStringImpl(Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &hash
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437807, RefRangeEnd = 437808, XrefRangeStart = 437805, XrefRangeEnd = 437807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ComputeFromPtr(
    System.IntPtr data,
    int start,
    int count,
    int elemSize,
    ref Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &elemSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref hash;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ComputeFromPtr_Private_Static_Void_IntPtr_Int32_Int32_Int32_byref_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 437809, RefRangeEnd = 437812, XrefRangeStart = 437808, XrefRangeEnd = 437809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Hash128 Compute(int val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &val
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Compute_Public_Static_Hash128_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Hash128*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 437815, RefRangeEnd = 437819, XrefRangeStart = 437812, XrefRangeEnd = 437815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Append<T>(ref T val) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) val);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    IL2CPP.il2cpp_runtime_invoke(Hash128.MethodInfoStoreGeneric_Append_Public_Void_byref_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref T local = ref val;
    System.IntPtr num2 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
    local = (T) valueGeneric;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437819, XrefRangeEnd = 437820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Append(int val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &val
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Append_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437820, XrefRangeEnd = 437823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Hash128 obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &obj
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437823, XrefRangeEnd = 437825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437825, XrefRangeEnd = 437828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int CompareTo(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 437828, RefRangeEnd = 437830, XrefRangeStart = 437828, XrefRangeEnd = 437828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(Hash128 hash1, Hash128 hash2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &hash1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 437830, RefRangeEnd = 437832, XrefRangeStart = 437830, XrefRangeEnd = 437830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(Hash128 hash1, Hash128 hash2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &hash1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 437832, RefRangeEnd = 437835, XrefRangeStart = 437832, XrefRangeEnd = 437832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <(Hash128 x, Hash128 y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator >(Hash128 x, Hash128 y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 437835, RefRangeEnd = 437837, XrefRangeStart = 437835, XrefRangeEnd = 437835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShortHash4(uint data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ShortHash4_Private_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref h0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref h1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref h3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void Rot64(ref ulong x, int k)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &k;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437837, XrefRangeEnd = 437839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Parse_Injected(ref ManagedSpanWrapper hashString, out Hash128 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref hashString;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437839, XrefRangeEnd = 437841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Hash128ToStringImpl_Injected(
    [In] ref Hash128 hash,
    out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref hash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_Void_byref_Hash128_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hash128>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe void ComputeFromString(string data, ref Hash128 hash)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(data, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = data.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Hash128.ComputeFromString_Injected(ref managedSpanWrapper, ref hash);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void ComputeFromArray(
    Il2CppSystem.Array data,
    int start,
    int count,
    int elemSize,
    ref Hash128 hash)
  {
    Hash128.ComputeFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), start, count, elemSize, (System.IntPtr) ref hash);
  }

  public static Hash128 Compute(string data)
  {
    Hash128 hash = new Hash128();
    Hash128.ComputeFromString(data, ref hash);
    return hash;
  }

  public static unsafe Hash128 Compute<T>(NativeArray<T> data) where T : struct
  {
    Hash128 hash = new Hash128();
    Hash128.ComputeFromPtr((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), 0, ((NativeArray<T>) ref data).Length, UnsafeUtility.SizeOf<T>(), ref hash);
    return hash;
  }

  public static unsafe Hash128 Compute<T>(NativeArray<T> data, int start, int count) where T : struct
  {
    if (start < 0 || count < 0 || start + count > ((NativeArray<T>) ref data).Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) count));
    Hash128 hash = new Hash128();
    Hash128.ComputeFromPtr((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), start, count, UnsafeUtility.SizeOf<T>(), ref hash);
    return hash;
  }

  public static Hash128 Compute<T>(Il2CppArrayBase<T> data) where T : struct
  {
    if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array) data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Compute must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array) data)));
    Hash128 hash = new Hash128();
    Hash128.ComputeFromArray((Il2CppSystem.Array) data, 0, ((Il2CppArrayBase) data).Length, UnsafeUtility.SizeOf<T>(), ref hash);
    return hash;
  }

  public static Hash128 Compute<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
  {
    if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array) data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Compute must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array) data)));
    if (start < 0 || count < 0 || start + count > ((Il2CppArrayBase) data).Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) count));
    Hash128 hash = new Hash128();
    Hash128.ComputeFromArray((Il2CppSystem.Array) data, start, count, UnsafeUtility.SizeOf<T>(), ref hash);
    return hash;
  }

  public static Hash128 Compute<T>(List<T> data) where T : struct
  {
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) nameof (Compute), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    Hash128 hash = new Hash128();
    Hash128.ComputeFromArray((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), 0, data.Count, UnsafeUtility.SizeOf<T>(), ref hash);
    return hash;
  }

  public static Hash128 Compute<T>(List<T> data, int start, int count) where T : struct
  {
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) nameof (Compute), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    if (start < 0 || count < 0 || start + count > data.Count)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) count));
    Hash128 hash = new Hash128();
    Hash128.ComputeFromArray((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), start, count, UnsafeUtility.SizeOf<T>(), ref hash);
    return hash;
  }

  public static unsafe Hash128 Compute<T>(ref T val) where T : struct, Il2CppSystem.ValueType
  {
    fixed (T* data = &val)
    {
      Hash128 hash = new Hash128();
      Hash128.ComputeFromPtr((System.IntPtr) (void*) data, 0, 1, UnsafeUtility.SizeOf<T>(), ref hash);
      return hash;
    }
  }

  public static Hash128 Compute(float val)
  {
    Hash128 hash128 = new Hash128();
    hash128.Append(val);
    return hash128;
  }

  public static unsafe Hash128 Compute(void* data, ulong size)
  {
    Hash128 hash = new Hash128();
    Hash128.ComputeFromPtr(new System.IntPtr(data), 0, (int) size, 1, ref hash);
    return hash;
  }

  public void Append(string data) => Hash128.ComputeFromString(data, ref this);

  public unsafe void Append<T>(NativeArray<T> data) where T : struct
  {
    Hash128.ComputeFromPtr((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), 0, ((NativeArray<T>) ref data).Length, UnsafeUtility.SizeOf<T>(), ref this);
  }

  public unsafe void Append<T>(NativeArray<T> data, int start, int count) where T : struct
  {
    if (start < 0 || count < 0 || start + count > ((NativeArray<T>) ref data).Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) count));
    Hash128.ComputeFromPtr((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), start, count, UnsafeUtility.SizeOf<T>(), ref this);
  }

  public void Append<T>(Il2CppArrayBase<T> data) where T : struct
  {
    if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array) data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Append must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array) data)));
    Hash128.ComputeFromArray((Il2CppSystem.Array) data, 0, ((Il2CppArrayBase) data).Length, UnsafeUtility.SizeOf<T>(), ref this);
  }

  public void Append<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
  {
    if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array) data))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Append must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array) data)));
    if (start < 0 || count < 0 || start + count > ((Il2CppArrayBase) data).Length)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) count));
    Hash128.ComputeFromArray((Il2CppSystem.Array) data, start, count, UnsafeUtility.SizeOf<T>(), ref this);
  }

  public void Append<T>(List<T> data) where T : struct
  {
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) nameof (Append), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    Hash128.ComputeFromArray((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), 0, data.Count, UnsafeUtility.SizeOf<T>(), ref this);
  }

  public void Append<T>(List<T> data, int start, int count) where T : struct
  {
    if (!UnsafeUtility.IsGenericListBlittable<T>())
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), (Il2CppSystem.Object) nameof (Append), (Il2CppSystem.Object) UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
    if (start < 0 || count < 0 || start + count > data.Count)
      throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object) (System.ValueType) start, (Il2CppSystem.Object) (System.ValueType) count));
    Hash128.ComputeFromArray((Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), start, count, UnsafeUtility.SizeOf<T>(), ref this);
  }

  public unsafe void Append(float val) => this.ShortHash4(*(uint*) &val);

  public unsafe void Append(void* data, ulong size)
  {
    Hash128.ComputeFromPtr(new System.IntPtr(data), 0, (int) size, 1, ref this);
  }

  public static void ComputeFromString_Injected(ref ManagedSpanWrapper data, ref Hash128 hash)
  {
    Hash128.ComputeFromString_InjectedDelegateField((System.IntPtr) ref data, (System.IntPtr) ref hash);
  }

  private sealed class MethodInfoStoreGeneric_Append_Public_Void_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Hash128.NativeMethodInfoPtr_Append_Public_Void_byref_T_0, Il2CppClassPointerStore<Hash128>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate void ComputeFromArrayDelegate(
    System.IntPtr data,
    int start,
    int count,
    int elemSize,
    System.IntPtr hash);

  private delegate void ComputeFromString_InjectedDelegate(System.IntPtr data, System.IntPtr hash);
}
