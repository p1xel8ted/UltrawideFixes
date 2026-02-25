// Decompiled with JetBrains decompiler
// Type: UnityEngine.Assertions.Assert
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine.Assertions.Comparers;

#nullable disable
namespace UnityEngine.Assertions;

public static class Assert : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_raiseExceptions;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0;
  public const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";

  static Assert()
  {
    Il2CppClassPointerStore<Assert>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", nameof (Assert));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assert>.NativeClassPtr);
    Assert.NativeFieldInfoPtr_raiseExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assert>.NativeClassPtr, nameof (raiseExceptions));
    Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669573);
    Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669574);
    Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669575);
    Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669576);
    Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669577);
    Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669578);
    Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669579);
    Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669580);
    Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669581);
    Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669582);
    Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669583);
    Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669584);
    Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669585);
    Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669586);
    Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669587);
    Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100669588);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 481432, RefRangeEnd = 481444, XrefRangeStart = 481419, XrefRangeEnd = 481432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Fail(string message, string userMessage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(message);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(userMessage);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 481459, RefRangeEnd = 481473, XrefRangeStart = 481444, XrefRangeEnd = 481459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsTrue(bool condition)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &condition
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 481485, RefRangeEnd = 481489, XrefRangeStart = 481473, XrefRangeEnd = 481485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsTrue(bool condition, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &condition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481504, RefRangeEnd = 481505, XrefRangeStart = 481489, XrefRangeEnd = 481504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsFalse(bool condition)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &condition
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 481517, RefRangeEnd = 481523, XrefRangeStart = 481505, XrefRangeEnd = 481517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsFalse(bool condition, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &condition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481543, RefRangeEnd = 481544, XrefRangeStart = 481523, XrefRangeEnd = 481543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AreEqual<T>(T expected, T actual)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) expected;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref expected;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local3;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local4 = (object) actual;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref actual;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481559, RefRangeEnd = 481560, XrefRangeStart = 481544, XrefRangeEnd = 481559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AreEqual<T>(T expected, T actual, string message)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) expected;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref expected;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local3;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local4 = (object) actual;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref actual;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481577, RefRangeEnd = 481579, XrefRangeStart = 481560, XrefRangeEnd = 481577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AreEqual<T>(
    T expected,
    T actual,
    string message,
    IEqualityComparer<T> comparer)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) expected;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref expected;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local3;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local4 = (object) actual;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref actual;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comparer);
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481579, XrefRangeEnd = 481588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) expected);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actual);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481605, RefRangeEnd = 481607, XrefRangeStart = 481588, XrefRangeEnd = 481605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsNull<T>(T value) where T : class
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481607, XrefRangeEnd = 481620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsNull<T>(T value, string message) where T : class
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481620, XrefRangeEnd = 481629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsNull(UnityEngine.Object value, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 481646, RefRangeEnd = 481649, XrefRangeStart = 481629, XrefRangeEnd = 481646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsNotNull<T>(T value) where T : class
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481662, RefRangeEnd = 481663, XrefRangeStart = 481649, XrefRangeEnd = 481662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsNotNull<T>(T value, string message) where T : class
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481663, XrefRangeEnd = 481672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IsNotNull(UnityEngine.Object value, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481678, RefRangeEnd = 481680, XrefRangeStart = 481672, XrefRangeEnd = 481678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AreEqual(int expected, int actual)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &expected;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actual;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Assert(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool raiseExceptions
  {
    get
    {
      bool raiseExceptions;
      IL2CPP.il2cpp_field_static_get_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*) &raiseExceptions);
      return raiseExceptions;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*) &value);
    }
  }

  public new static bool Equals(Il2CppSystem.Object obj1, Il2CppSystem.Object obj2)
  {
    throw new Il2CppSystem.InvalidOperationException("Assert.Equals should not be used for Assertions");
  }

  public new static bool ReferenceEquals(Il2CppSystem.Object obj1, Il2CppSystem.Object obj2)
  {
    throw new Il2CppSystem.InvalidOperationException("Assert.ReferenceEquals should not be used for Assertions");
  }

  public static void AreApproximatelyEqual(float expected, float actual)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void AreApproximatelyEqual(float expected, float actual, string message)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
  {
    Assert.AreApproximatelyEqual(expected, actual, tolerance, (string) null);
  }

  public static void AreApproximatelyEqual(
    float expected,
    float actual,
    float tolerance,
    string message)
  {
    Assert.AreEqual<float>(expected, actual, message, (IEqualityComparer<float>) new FloatComparer(tolerance));
  }

  public static void AreNotApproximatelyEqual(float expected, float actual)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void AreNotApproximatelyEqual(float expected, float actual, string message)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
  {
    Assert.AreNotApproximatelyEqual(expected, actual, tolerance, (string) null);
  }

  public static void AreNotApproximatelyEqual(
    float expected,
    float actual,
    float tolerance,
    string message)
  {
    Assert.AreNotEqual<float>(expected, actual, message, (IEqualityComparer<float>) new FloatComparer(tolerance));
  }

  public static void AreNotEqual<T>(T expected, T actual)
  {
    Assert.AreNotEqual<T>(expected, actual, (string) null);
  }

  public static void AreNotEqual<T>(T expected, T actual, string message)
  {
    Assert.AreNotEqual<T>(expected, actual, message, (IEqualityComparer<T>) EqualityComparer<T>.Default);
  }

  public static void AreNotEqual<T>(
    T expected,
    T actual,
    string message,
    IEqualityComparer<T> comparer)
  {
    if (Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<UnityEngine.Object>()).IsAssignableFrom(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))
    {
      Assert.AreNotEqual(((Il2CppObjectBase) (object) expected).TryCast<UnityEngine.Object>(), ((Il2CppObjectBase) (object) actual).TryCast<UnityEngine.Object>(), message);
    }
    else
    {
      if (!comparer.Equals(actual, expected))
        return;
      Assert.Fail(AssertionMessageUtil.GetEqualityMessage((Il2CppSystem.Object) (object) actual, (Il2CppSystem.Object) (object) expected, false), message);
    }
  }

  public static void AreNotEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message)
  {
    if (!(actual == expected))
      return;
    Assert.Fail(AssertionMessageUtil.GetEqualityMessage((Il2CppSystem.Object) actual, (Il2CppSystem.Object) expected, false), message);
  }

  public static void AreEqual(sbyte expected, sbyte actual)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<sbyte>(expected, actual, (string) null);
  }

  public static void AreEqual(sbyte expected, sbyte actual, string message)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<sbyte>(expected, actual, message);
  }

  public static void AreNotEqual(sbyte expected, sbyte actual)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<sbyte>(expected, actual, (string) null);
  }

  public static void AreNotEqual(sbyte expected, sbyte actual, string message)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<sbyte>(expected, actual, message);
  }

  public static void AreEqual(byte expected, byte actual)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<byte>(expected, actual, (string) null);
  }

  public static void AreEqual(byte expected, byte actual, string message)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<byte>(expected, actual, message);
  }

  public static void AreNotEqual(byte expected, byte actual)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<byte>(expected, actual, (string) null);
  }

  public static void AreNotEqual(byte expected, byte actual, string message)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<byte>(expected, actual, message);
  }

  public static void AreEqual(char expected, char actual)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<char>(expected, actual, (string) null);
  }

  public static void AreEqual(char expected, char actual, string message)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<char>(expected, actual, message);
  }

  public static void AreNotEqual(char expected, char actual)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<char>(expected, actual, (string) null);
  }

  public static void AreNotEqual(char expected, char actual, string message)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<char>(expected, actual, message);
  }

  public static void AreEqual(short expected, short actual)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<short>(expected, actual, (string) null);
  }

  public static void AreEqual(short expected, short actual, string message)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<short>(expected, actual, message);
  }

  public static void AreNotEqual(short expected, short actual)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<short>(expected, actual, (string) null);
  }

  public static void AreNotEqual(short expected, short actual, string message)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<short>(expected, actual, message);
  }

  public static void AreEqual(ushort expected, ushort actual)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<ushort>(expected, actual, (string) null);
  }

  public static void AreEqual(ushort expected, ushort actual, string message)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<ushort>(expected, actual, message);
  }

  public static void AreNotEqual(ushort expected, ushort actual)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<ushort>(expected, actual, (string) null);
  }

  public static void AreNotEqual(ushort expected, ushort actual, string message)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<ushort>(expected, actual, message);
  }

  public static void AreEqual(int expected, int actual, string message)
  {
    if (expected == actual)
      return;
    Assert.AreEqual<int>(expected, actual, message);
  }

  public static void AreNotEqual(int expected, int actual)
  {
    if (expected != actual)
      return;
    Assert.AreNotEqual<int>(expected, actual, (string) null);
  }

  public static void AreNotEqual(int expected, int actual, string message)
  {
    if (expected != actual)
      return;
    Assert.AreNotEqual<int>(expected, actual, message);
  }

  public static void AreEqual(uint expected, uint actual)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<uint>(expected, actual, (string) null);
  }

  public static void AreEqual(uint expected, uint actual, string message)
  {
    if ((int) expected == (int) actual)
      return;
    Assert.AreEqual<uint>(expected, actual, message);
  }

  public static void AreNotEqual(uint expected, uint actual)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<uint>(expected, actual, (string) null);
  }

  public static void AreNotEqual(uint expected, uint actual, string message)
  {
    if ((int) expected != (int) actual)
      return;
    Assert.AreNotEqual<uint>(expected, actual, message);
  }

  public static void AreEqual(long expected, long actual)
  {
    if (expected == actual)
      return;
    Assert.AreEqual<long>(expected, actual, (string) null);
  }

  public static void AreEqual(long expected, long actual, string message)
  {
    if (expected == actual)
      return;
    Assert.AreEqual<long>(expected, actual, message);
  }

  public static void AreNotEqual(long expected, long actual)
  {
    if (expected != actual)
      return;
    Assert.AreNotEqual<long>(expected, actual, (string) null);
  }

  public static void AreNotEqual(long expected, long actual, string message)
  {
    if (expected != actual)
      return;
    Assert.AreNotEqual<long>(expected, actual, message);
  }

  public static void AreEqual(ulong expected, ulong actual)
  {
    if ((long) expected == (long) actual)
      return;
    Assert.AreEqual<ulong>(expected, actual, (string) null);
  }

  public static void AreEqual(ulong expected, ulong actual, string message)
  {
    if ((long) expected == (long) actual)
      return;
    Assert.AreEqual<ulong>(expected, actual, message);
  }

  public static void AreNotEqual(ulong expected, ulong actual)
  {
    if ((long) expected != (long) actual)
      return;
    Assert.AreNotEqual<ulong>(expected, actual, (string) null);
  }

  public static void AreNotEqual(ulong expected, ulong actual, string message)
  {
    if ((long) expected != (long) actual)
      return;
    Assert.AreNotEqual<ulong>(expected, actual, message);
  }

  private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
