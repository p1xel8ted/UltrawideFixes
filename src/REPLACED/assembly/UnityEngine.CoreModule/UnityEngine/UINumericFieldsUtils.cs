// Decompiled with JetBrains decompiler
// Type: UnityEngine.UINumericFieldsUtils
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class UINumericFieldsUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_k_AllowedCharactersForFloat;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_AllowedCharactersForInt;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_DoubleFieldFormatString;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_FloatFieldFormatString;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_IntFieldFormatString;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0;

  static UINumericFieldsUtils()
  {
    Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (UINumericFieldsUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr);
    UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, nameof (k_AllowedCharactersForFloat));
    UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, nameof (k_AllowedCharactersForInt));
    UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, nameof (k_DoubleFieldFormatString));
    UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, nameof (k_FloatFieldFormatString));
    UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, nameof (k_IntFieldFormatString));
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668639);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668640);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668641);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668642);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668643);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668644);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668645);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668646);
    UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100668647);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 466249, RefRangeEnd = 466253, XrefRangeStart = 466224, XrefRangeEnd = 466249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToDouble(
    string str,
    out double value,
    out ExpressionEvaluator.Expression expr)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expr;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 466264, RefRangeEnd = 466265, XrefRangeStart = 466253, XrefRangeEnd = 466264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToDouble(
    string str,
    string initialValueAsString,
    out double value,
    out ExpressionEvaluator.Expression expression)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expression;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 466280, RefRangeEnd = 466282, XrefRangeStart = 466265, XrefRangeEnd = 466280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToFloat(
    string str,
    string initialValueAsString,
    out float value,
    out ExpressionEvaluator.Expression expression)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expression;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 466288, RefRangeEnd = 466289, XrefRangeStart = 466282, XrefRangeEnd = 466288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToLong(
    string str,
    out long value,
    out ExpressionEvaluator.Expression expr)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expr;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 466305, RefRangeEnd = 466308, XrefRangeStart = 466289, XrefRangeEnd = 466305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToLong(
    string str,
    string initialValueAsString,
    out long value,
    out ExpressionEvaluator.Expression expression)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expression;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 466314, RefRangeEnd = 466315, XrefRangeStart = 466308, XrefRangeEnd = 466314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToULong(
    string str,
    out ulong value,
    out ExpressionEvaluator.Expression expr)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expr;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 466331, RefRangeEnd = 466332, XrefRangeStart = 466315, XrefRangeEnd = 466331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToULong(
    string str,
    string initialValueAsString,
    out ulong value,
    out ExpressionEvaluator.Expression expression)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expression;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 466337, RefRangeEnd = 466339, XrefRangeStart = 466332, XrefRangeEnd = 466337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToInt(
    string str,
    string initialValueAsString,
    out int value,
    out ExpressionEvaluator.Expression expression)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expression;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 466344, RefRangeEnd = 466345, XrefRangeStart = 466339, XrefRangeEnd = 466344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryConvertStringToUInt(
    string str,
    string initialValueAsString,
    out uint value,
    out ExpressionEvaluator.Expression expression)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExpressionEvaluator.Expression local = ref expression;
    System.IntPtr pointer = zero;
    ExpressionEvaluator.Expression expression1 = pointer == System.IntPtr.Zero ? (ExpressionEvaluator.Expression) null : new ExpressionEvaluator.Expression(pointer);
    local = expression1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  public UINumericFieldsUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string k_AllowedCharactersForFloat
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string k_AllowedCharactersForInt
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string k_DoubleFieldFormatString
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string k_FloatFieldFormatString
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string k_IntFieldFormatString
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static bool TryConvertStringToDouble(string str, out double value)
  {
    return UINumericFieldsUtils.TryConvertStringToDouble(str, out value, out ExpressionEvaluator.Expression _);
  }

  public static bool TryConvertStringToLong(string str, out long value)
  {
    return ExpressionEvaluator.Evaluate<long>(str, out value, out ExpressionEvaluator.Expression _);
  }
}
