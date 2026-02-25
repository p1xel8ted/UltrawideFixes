// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector2
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Vector2
{
  private static readonly System.IntPtr NativeFieldInfoPtr_x;
  private static readonly System.IntPtr NativeFieldInfoPtr_y;
  private static readonly System.IntPtr NativeFieldInfoPtr_zeroVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_oneVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_upVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_downVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_positiveInfinityVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_negativeInfinityVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilon;
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector2_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Perpendicular_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0;
  [FieldOffset(0)]
  public float x;
  [FieldOffset(4)]
  public float y;

  static Vector2()
  {
    Il2CppClassPointerStore<Vector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Vector2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2>.NativeClassPtr);
    Vector2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (x));
    Vector2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (y));
    Vector2.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (zeroVector));
    Vector2.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (oneVector));
    Vector2.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (upVector));
    Vector2.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (downVector));
    Vector2.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (leftVector));
    Vector2.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (rightVector));
    Vector2.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (positiveInfinityVector));
    Vector2.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (negativeInfinityVector));
    Vector2.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (kEpsilon));
    Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, nameof (kEpsilonNormalSqrt));
    Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667534);
    Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667535);
    Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667536 /*0x06001090*/);
    Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667537);
    Vector2.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667538);
    Vector2.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667539);
    Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667540);
    Vector2.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667541);
    Vector2.NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667542);
    Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667543);
    Vector2.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667544);
    Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667545);
    Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667546);
    Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667547);
    Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667548);
    Vector2.NativeMethodInfoPtr_Perpendicular_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667549);
    Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667550);
    Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667551);
    Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667552 /*0x060010A0*/);
    Vector2.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667553);
    Vector2.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667554);
    Vector2.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667555);
    Vector2.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667556);
    Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667557);
    Vector2.NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667558);
    Vector2.NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667559);
    Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667560);
    Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667561);
    Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667562);
    Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667563);
    Vector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667564);
    Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667565);
    Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667566);
    Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667567);
    Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667568 /*0x060010B0*/);
    Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667569);
    Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667570);
    Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667571);
    Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667572);
    Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667573);
    Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667574);
    Vector2.NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667575);
    Vector2.NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667576);
    Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667577);
    Vector2.NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100667578);
  }

  public unsafe float this[int index]
  {
    [CallerCount(29), CachedScanResults(RefRangeStart = 441019, RefRangeEnd = 441048, XrefRangeStart = 441019, XrefRangeEnd = 441019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(16 /*0x10*/), CachedScanResults(RefRangeStart = 441048, RefRangeEnd = 441064, XrefRangeStart = 441048, XrefRangeEnd = 441048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 21792, RefRangeEnd = 21797, XrefRangeStart = 21792, XrefRangeEnd = 21797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2(float x, float y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 441065, RefRangeEnd = 441067, XrefRangeStart = 441064, XrefRangeEnd = 441065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Lerp(Vector2 a, Vector2 b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441067, XrefRangeEnd = 441073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDistanceDelta;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector2_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 254094, RefRangeEnd = 254098, XrefRangeStart = 254094, XrefRangeEnd = 254098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Scale(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441073, XrefRangeEnd = 441076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Normalize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Normalize_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2 normalized
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 441084, RefRangeEnd = 441087, XrefRangeStart = 441076, XrefRangeEnd = 441084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441087, XrefRangeEnd = 441088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441088, XrefRangeEnd = 441089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string ToString(string format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(format)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_String_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441089, XrefRangeEnd = 441121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441121, XrefRangeEnd = 441123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441123, XrefRangeEnd = 441126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Vector2 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 Perpendicular(Vector2 inDirection)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inDirection
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Perpendicular_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Dot(Vector2 lhs, Vector2 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float magnitude
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441126, XrefRangeEnd = 441131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float sqrMagnitude
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441131, XrefRangeEnd = 441140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Angle(Vector2 from, Vector2 to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441150, RefRangeEnd = 441151, XrefRangeStart = 441140, XrefRangeEnd = 441150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SignedAngle(Vector2 from, Vector2 to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441151, XrefRangeEnd = 441154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Distance(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441154, XrefRangeEnd = 441160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 ClampMagnitude(Vector2 vector, float maxLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float SqrMagnitude(Vector2 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 Min(Vector2 lhs, Vector2 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 Max(Vector2 lhs, Vector2 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator +(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator -(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 254094, RefRangeEnd = 254098, XrefRangeStart = 254094, XrefRangeEnd = 254098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 operator *(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator /(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator -(Vector2 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator *(Vector2 a, float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator *(float d, Vector2 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 operator /(Vector2 a, float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Vector2 lhs, Vector2 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Vector2 lhs, Vector2 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 422045, RefRangeEnd = 422049, XrefRangeStart = 422045, XrefRangeEnd = 422049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Vector2(Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 441160, RefRangeEnd = 441170, XrefRangeStart = 441160, XrefRangeEnd = 441160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Vector3(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Vector2 zero
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441170, XrefRangeEnd = 441172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2 one
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441172, XrefRangeEnd = 441174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2 up
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441174, XrefRangeEnd = 441176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2 down
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441176, XrefRangeEnd = 441178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2 left
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441178, XrefRangeEnd = 441180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2 right
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441180, XrefRangeEnd = 441182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2 negativeInfinity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441182, XrefRangeEnd = 441184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Vector2 zeroVector
  {
    get
    {
      Vector2 zeroVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*) &zeroVector);
      return zeroVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*) &value);
    }
  }

  public static unsafe Vector2 oneVector
  {
    get
    {
      Vector2 oneVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_oneVector, (void*) &oneVector);
      return oneVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_oneVector, (void*) &value);
    }
  }

  public static unsafe Vector2 upVector
  {
    get
    {
      Vector2 upVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_upVector, (void*) &upVector);
      return upVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_upVector, (void*) &value);
    }
  }

  public static unsafe Vector2 downVector
  {
    get
    {
      Vector2 downVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_downVector, (void*) &downVector);
      return downVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_downVector, (void*) &value);
    }
  }

  public static unsafe Vector2 leftVector
  {
    get
    {
      Vector2 leftVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_leftVector, (void*) &leftVector);
      return leftVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_leftVector, (void*) &value);
    }
  }

  public static unsafe Vector2 rightVector
  {
    get
    {
      Vector2 rightVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_rightVector, (void*) &rightVector);
      return rightVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_rightVector, (void*) &value);
    }
  }

  public static unsafe Vector2 positiveInfinityVector
  {
    get
    {
      Vector2 positiveInfinityVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*) &positiveInfinityVector);
      return positiveInfinityVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*) &value);
    }
  }

  public static unsafe Vector2 negativeInfinityVector
  {
    get
    {
      Vector2 negativeInfinityVector;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*) &negativeInfinityVector);
      return negativeInfinityVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*) &value);
    }
  }

  public static unsafe float kEpsilon
  {
    get
    {
      float kEpsilon;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*) &kEpsilon);
      return kEpsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*) &value);
    }
  }

  public static unsafe float kEpsilonNormalSqrt
  {
    get
    {
      float epsilonNormalSqrt;
      IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*) &epsilonNormalSqrt);
      return epsilonNormalSqrt;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*) &value);
    }
  }

  public void Set(float newX, float newY)
  {
    this.x = newX;
    this.y = newY;
  }

  public void Scale(Vector2 scale)
  {
    this.x *= scale.x;
    this.y *= scale.y;
  }

  public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
  {
    float num = -2f * Vector2.Dot(inNormal, inDirection);
    return new Vector2(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y);
  }

  public float SqrMagnitude()
  {
    return (float) ((double) this.x * (double) this.x + (double) this.y * (double) this.y);
  }

  public static Vector2 SmoothDamp(
    Vector2 current,
    Vector2 target,
    ref Vector2 currentVelocity,
    float smoothTime,
    float maxSpeed)
  {
    float deltaTime = Time.deltaTime;
    return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
  }

  public static Vector2 SmoothDamp(
    Vector2 current,
    Vector2 target,
    ref Vector2 currentVelocity,
    float smoothTime)
  {
    float deltaTime = Time.deltaTime;
    float maxSpeed = float.PositiveInfinity;
    return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
  }

  public static Vector2 SmoothDamp(
    Vector2 current,
    Vector2 target,
    ref Vector2 currentVelocity,
    float smoothTime,
    float maxSpeed,
    float deltaTime)
  {
    smoothTime = Mathf.Max(0.0001f, smoothTime);
    float num1 = 2f / smoothTime;
    float num2 = num1 * deltaTime;
    float num3 = (float) (1.0 / (1.0 + (double) num2 + 0.47999998927116394 * (double) num2 * (double) num2 + 0.23499999940395355 * (double) num2 * (double) num2 * (double) num2));
    float num4 = current.x - target.x;
    float num5 = current.y - target.y;
    Vector2 vector2 = target;
    float num6 = maxSpeed * smoothTime;
    float num7 = num6 * num6;
    float d = (float) ((double) num4 * (double) num4 + (double) num5 * (double) num5);
    if ((double) d > (double) num7)
    {
      float num8 = (float) Il2CppSystem.Math.Sqrt((double) d);
      num4 = num4 / num8 * num6;
      num5 = num5 / num8 * num6;
    }
    target.x = current.x - num4;
    target.y = current.y - num5;
    float num9 = (currentVelocity.x + num1 * num4) * deltaTime;
    float num10 = (currentVelocity.y + num1 * num5) * deltaTime;
    currentVelocity.x = (currentVelocity.x - num1 * num9) * num3;
    currentVelocity.y = (currentVelocity.y - num1 * num10) * num3;
    float x = target.x + (num4 + num9) * num3;
    float y = target.y + (num5 + num10) * num3;
    float num11 = vector2.x - current.x;
    float num12 = vector2.y - current.y;
    float num13 = x - vector2.x;
    float num14 = y - vector2.y;
    if ((double) num11 * (double) num13 + (double) num12 * (double) num14 > 0.0)
    {
      x = vector2.x;
      y = vector2.y;
      currentVelocity.x = (x - vector2.x) / deltaTime;
      currentVelocity.y = (y - vector2.y) / deltaTime;
    }
    return new Vector2(x, y);
  }

  public static Vector2 positiveInfinity => Vector2.positiveInfinityVector;
}
