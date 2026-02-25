// Decompiled with JetBrains decompiler
// Type: UnityEngine.ExpressionEvaluator
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class ExpressionEvaluator(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Random;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Operators;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0;

  static ExpressionEvaluator()
  {
    Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ExpressionEvaluator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr);
    ExpressionEvaluator.NativeFieldInfoPtr_s_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, nameof (s_Random));
    ExpressionEvaluator.NativeFieldInfoPtr_s_Operators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, nameof (s_Operators));
    ExpressionEvaluator.NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664411);
    ExpressionEvaluator.NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664412);
    ExpressionEvaluator.NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664413);
    ExpressionEvaluator.NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664414);
    ExpressionEvaluator.NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664415);
    ExpressionEvaluator.NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664416 /*0x06000460*/);
    ExpressionEvaluator.NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664417);
    ExpressionEvaluator.NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664418);
    ExpressionEvaluator.NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664419);
    ExpressionEvaluator.NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664420);
    ExpressionEvaluator.NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664421);
    ExpressionEvaluator.NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664422);
    ExpressionEvaluator.NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664423);
    ExpressionEvaluator.NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664424);
    ExpressionEvaluator.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100664425);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421192, RefRangeEnd = 421193, XrefRangeStart = 421178, XrefRangeEnd = 421192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Evaluate<T>(
    string expression,
    out T value,
    out ExpressionEvaluator.Expression delayed)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(expression);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero1 = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero1);
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr2;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref value;
      System.IntPtr num5 = zero1;
      // ISSUE: variable of the null type
      __Null valueGeneric = num5 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num5, false, false);
      local2 = (T) valueGeneric;
    }
    ref ExpressionEvaluator.Expression local3 = ref delayed;
    System.IntPtr pointer = zero2;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local3 = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421247, RefRangeEnd = 421249, XrefRangeStart = 421193, XrefRangeEnd = 421247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool EvaluateTokens<T>(
    Il2CppStringArray tokens,
    ref T value,
    int index,
    int count)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tokens);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref T local = ref value;
    System.IntPtr num4 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
    local = (T) valueGeneric;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 421330, RefRangeEnd = 421335, XrefRangeStart = 421249, XrefRangeEnd = 421330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool EvaluateDouble(
    Il2CppStringArray tokens,
    ref double value,
    int index,
    int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tokens);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421422, RefRangeEnd = 421423, XrefRangeStart = 421335, XrefRangeEnd = 421422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray InfixToRPN(Il2CppStringArray tokens)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tokens)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421431, RefRangeEnd = 421432, XrefRangeStart = 421423, XrefRangeEnd = 421431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool NeedToPop(
    Stack<string> operatorStack,
    ExpressionEvaluator.Operator newOperator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) operatorStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newOperator);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421490, RefRangeEnd = 421491, XrefRangeStart = 421432, XrefRangeEnd = 421490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray ExpressionToTokens(
    string expression,
    out bool hasVariables)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(expression);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasVariables;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 421493, RefRangeEnd = 421496, XrefRangeStart = 421491, XrefRangeEnd = 421493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCommand(string token)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(token)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsVariable(string token)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(token)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421500, RefRangeEnd = 421502, XrefRangeStart = 421496, XrefRangeEnd = 421500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDelayedFunction(string token)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(token)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 421510, RefRangeEnd = 421514, XrefRangeStart = 421502, XrefRangeEnd = 421510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsOperator(string token)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(token)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 421521, RefRangeEnd = 421526, XrefRangeStart = 421514, XrefRangeEnd = 421521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ExpressionEvaluator.Operator TokenToOperator(string token)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(token)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ExpressionEvaluator.Operator) null : Il2CppObjectPool.Get<ExpressionEvaluator.Operator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421553, RefRangeEnd = 421554, XrefRangeStart = 421526, XrefRangeEnd = 421553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string PreFormatExpression(string expression)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(expression)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421554, XrefRangeEnd = 421570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray FixUnaryOperators(Il2CppStringArray tokens)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tokens)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421619, RefRangeEnd = 421620, XrefRangeStart = 421570, XrefRangeEnd = 421619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double EvaluateOp(
    Il2CppStructArray<double> values,
    ExpressionEvaluator.Op op,
    int index,
    int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &op;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 421720, RefRangeEnd = 421723, XrefRangeStart = 421620, XrefRangeEnd = 421720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryParse<T>(string expression, out T result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(expression);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref result;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_TryParse_Private_Static_Boolean_String_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref result;
      System.IntPtr num4 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
      local2 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  public static unsafe ExpressionEvaluator.PcgRandom s_Random
  {
    get
    {
      ExpressionEvaluator.PcgRandom sRandom;
      IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Random, (void*) &sRandom);
      return sRandom;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Random, (void*) &value);
    }
  }

  public static unsafe Dictionary<string, ExpressionEvaluator.Operator> s_Operators
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Operators, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, ExpressionEvaluator.Operator>) null : Il2CppObjectPool.Get<Dictionary<string, ExpressionEvaluator.Operator>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Operators, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static bool Evaluate<T>(string expression, out T value)
  {
    return ExpressionEvaluator.Evaluate<T>(expression, out value, out ExpressionEvaluator.Expression _);
  }

  public static void SetRandomState(uint state)
  {
    ExpressionEvaluator.s_Random = new ExpressionEvaluator.PcgRandom((ulong) state);
  }

  public class Expression(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_rpnTokens;
    private static readonly System.IntPtr NativeFieldInfoPtr_hasVariables;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    static Expression()
    {
      Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, nameof (Expression));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr);
      ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, nameof (rpnTokens));
      ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, nameof (hasVariables));
      ExpressionEvaluator.Expression.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664427);
      ExpressionEvaluator.Expression.NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664428);
      ExpressionEvaluator.Expression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664429);
      ExpressionEvaluator.Expression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664430);
      ExpressionEvaluator.Expression.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100664431);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 421140, RefRangeEnd = 421141, XrefRangeStart = 421117, XrefRangeEnd = 421140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Expression(string expression)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(expression)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Expression.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 421155, RefRangeEnd = 421157, XrefRangeStart = 421141, XrefRangeEnd = 421155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Evaluate<T>(ref T value, int index = 0, int count = 1)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Expression.MethodInfoStoreGeneric_Evaluate_Public_Boolean_byref_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      ref T local = ref value;
      System.IntPtr num3 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
      local = (T) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421157, XrefRangeEnd = 421162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421162, XrefRangeEnd = 421163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421163, XrefRangeEnd = 421166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    public unsafe Il2CppStringArray rpnTokens
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens));
        return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool hasVariables
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables)) = value;
      }
    }

    private sealed class MethodInfoStoreGeneric_Evaluate_Public_Boolean_byref_T_Int32_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.Expression.NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PcgRandom
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_increment;
    private static readonly System.IntPtr NativeFieldInfoPtr_state;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUInt_Public_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Step_Private_Void_0;
    [FieldOffset(0)]
    public readonly ulong increment;
    [FieldOffset(8)]
    public ulong state;

    static PcgRandom()
    {
      Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, nameof (PcgRandom));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr);
      ExpressionEvaluator.PcgRandom.NativeFieldInfoPtr_increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, nameof (increment));
      ExpressionEvaluator.PcgRandom.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, nameof (state));
      ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664432 /*0x06000470*/);
      ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_GetUInt_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664433);
      ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664434);
      ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664435);
      ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_Step_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100664436);
    }

    [CallerCount(0)]
    public unsafe PcgRandom(ulong state = 0, ulong sequence = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &state;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sequence;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe uint GetUInt()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_GetUInt_Public_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe uint RotateRight(uint v, int rot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &v;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe uint XshRr(ulong s)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &s
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void Step()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_Step_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public enum Op
  {
    Add,
    Sub,
    Mul,
    Div,
    Mod,
    Neg,
    Pow,
    Sqrt,
    Sin,
    Cos,
    Tan,
    Floor,
    Ceil,
    Round,
    Rand,
    Linear,
  }

  public enum Associativity
  {
    Left,
    Right,
  }

  public class Operator(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_op;
    private static readonly System.IntPtr NativeFieldInfoPtr_precedence;
    private static readonly System.IntPtr NativeFieldInfoPtr_associativity;
    private static readonly System.IntPtr NativeFieldInfoPtr_inputs;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0;

    static Operator()
    {
      Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, nameof (Operator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr);
      ExpressionEvaluator.Operator.NativeFieldInfoPtr_op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, nameof (op));
      ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, nameof (precedence));
      ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, nameof (associativity));
      ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, nameof (inputs));
      ExpressionEvaluator.Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, 100664437);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421166, XrefRangeEnd = 421167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Operator(
      ExpressionEvaluator.Op op,
      int precedence,
      int inputs,
      ExpressionEvaluator.Associativity associativity)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &op;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &precedence;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inputs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &associativity;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ExpressionEvaluator.Op op
    {
      get
      {
        return *(ExpressionEvaluator.Op*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_op));
      }
      [param: In] set
      {
        *(ExpressionEvaluator.Op*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_op)) = value;
      }
    }

    public unsafe int precedence
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence)) = value;
      }
    }

    public unsafe ExpressionEvaluator.Associativity associativity
    {
      get
      {
        return *(ExpressionEvaluator.Associativity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity));
      }
      [param: In] set
      {
        *(ExpressionEvaluator.Associativity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity)) = value;
      }
    }

    public unsafe int inputs
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs)) = value;
      }
    }
  }

  [ObfuscatedName("UnityEngine.ExpressionEvaluator+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0;

    static __c()
    {
      Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr);
      ExpressionEvaluator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, "<>9");
      ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, "<>9__14_0");
      ExpressionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, 100664439);
      ExpressionEvaluator.__c.NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, 100664440);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421167, XrefRangeEnd = 421178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ExpressionToTokens_b__14_0(string f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(f)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.__c.NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe ExpressionEvaluator.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (ExpressionEvaluator.__c) null : Il2CppObjectPool.Get<ExpressionEvaluator.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<string, bool> __9__14_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<string, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<string, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_TryParse_Private_Static_Boolean_String_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }
}
