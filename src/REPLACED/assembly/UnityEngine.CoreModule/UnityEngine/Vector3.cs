// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector3
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
public struct Vector3
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilon;
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;
  private static readonly System.IntPtr NativeFieldInfoPtr_x;
  private static readonly System.IntPtr NativeFieldInfoPtr_y;
  private static readonly System.IntPtr NativeFieldInfoPtr_z;
  private static readonly System.IntPtr NativeFieldInfoPtr_zeroVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_oneVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_upVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_downVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_forwardVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_backVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_positiveInfinityVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_negativeInfinityVector;
  private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OrthoNormalize2_Private_Static_Void_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OrthoNormalize_Public_Static_Void_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateTowards_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_Single_byref_Vector3_0;
  [FieldOffset(0)]
  public float x;
  [FieldOffset(4)]
  public float y;
  [FieldOffset(8)]
  public float z;
  private static readonly Vector3.OrthoNormalize3Delegate OrthoNormalize3DelegateField;
  private static readonly Vector3.SlerpUnclamped_InjectedDelegate SlerpUnclamped_InjectedDelegateField;

  static Vector3()
  {
    Il2CppClassPointerStore<Vector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Vector3));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3>.NativeClassPtr);
    Vector3.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (kEpsilon));
    Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (kEpsilonNormalSqrt));
    Vector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (x));
    Vector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (y));
    Vector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (z));
    Vector3.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (zeroVector));
    Vector3.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (oneVector));
    Vector3.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (upVector));
    Vector3.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (downVector));
    Vector3.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (leftVector));
    Vector3.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (rightVector));
    Vector3.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (forwardVector));
    Vector3.NativeFieldInfoPtr_backVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (backVector));
    Vector3.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (positiveInfinityVector));
    Vector3.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, nameof (negativeInfinityVector));
    Vector3.NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667373);
    Vector3.NativeMethodInfoPtr_OrthoNormalize2_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667374);
    Vector3.NativeMethodInfoPtr_OrthoNormalize_Public_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667375);
    Vector3.NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667376 /*0x06000FF0*/);
    Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667377);
    Vector3.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667378);
    Vector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667379);
    Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667380);
    Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667381);
    Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667382);
    Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667383);
    Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667384);
    Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667385);
    Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667386);
    Vector3.NativeMethodInfoPtr_Scale_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667387);
    Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667388);
    Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667389);
    Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667390);
    Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667391);
    Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667392 /*0x06001000*/);
    Vector3.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667393 /*0x06001001*/);
    Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667394 /*0x06001002*/);
    Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667395 /*0x06001003*/);
    Vector3.NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667396 /*0x06001004*/);
    Vector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667397 /*0x06001005*/);
    Vector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667398 /*0x06001006*/);
    Vector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667399 /*0x06001007*/);
    Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667400 /*0x06001008*/);
    Vector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667401 /*0x06001009*/);
    Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667402 /*0x0600100A*/);
    Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667403 /*0x0600100B*/);
    Vector3.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667404 /*0x0600100C*/);
    Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667405 /*0x0600100D*/);
    Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667406 /*0x0600100E*/);
    Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667407 /*0x0600100F*/);
    Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667408 /*0x06001010*/);
    Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667409);
    Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667410);
    Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667411);
    Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667412);
    Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667413);
    Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667414);
    Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667415);
    Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667416);
    Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667417);
    Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667418);
    Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667419);
    Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667420);
    Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667421);
    Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667422);
    Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667423);
    Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667424 /*0x06001020*/);
    Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667425);
    Vector3.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667427);
    Vector3.NativeMethodInfoPtr_RotateTowards_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100667428);
    Vector3.OrthoNormalize3DelegateField = IL2CPP.ResolveICall<Vector3.OrthoNormalize3Delegate>("UnityEngine.Vector3::OrthoNormalize3");
    Vector3.SlerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Vector3.SlerpUnclamped_InjectedDelegate>("UnityEngine.Vector3::SlerpUnclamped_Injected");
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 439034, RefRangeEnd = 439052, XrefRangeStart = 439032, XrefRangeEnd = 439034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Slerp(Vector3 a, Vector3 b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(28)]
  [CachedScanResults(RefRangeStart = 439054, RefRangeEnd = 439082, XrefRangeStart = 439052, XrefRangeEnd = 439054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OrthoNormalize2(ref Vector3 a, ref Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_OrthoNormalize2_Private_Static_Void_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(28)]
  [CachedScanResults(RefRangeStart = 439054, RefRangeEnd = 439082, XrefRangeStart = 439054, XrefRangeEnd = 439082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref normal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tangent;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_OrthoNormalize_Public_Static_Void_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 439084, RefRangeEnd = 439091, XrefRangeStart = 439082, XrefRangeEnd = 439084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 RotateTowards(
    Vector3 current,
    Vector3 target,
    float maxRadiansDelta,
    float maxMagnitudeDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxRadiansDelta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxMagnitudeDelta;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439091, XrefRangeEnd = 439092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Lerp(Vector3 a, Vector3 b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439092, XrefRangeEnd = 439098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDistanceDelta;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439098, XrefRangeEnd = 439100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 SmoothDamp(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 439105, RefRangeEnd = 439115, XrefRangeStart = 439100, XrefRangeEnd = 439105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 SmoothDamp(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed,
    float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float this[int index]
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 439115, RefRangeEnd = 439129, XrefRangeStart = 439115, XrefRangeEnd = 439115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 439129, RefRangeEnd = 439132, XrefRangeStart = 439129, XrefRangeEnd = 439129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 245823, RefRangeEnd = 245824, XrefRangeStart = 245823, XrefRangeEnd = 245824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3(float x, float y, float z)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Vector3(float x, float y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Scale(Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void Scale(Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scale
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Cross(Vector3 lhs, Vector3 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439132, XrefRangeEnd = 439135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439135, XrefRangeEnd = 439138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Vector3 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(93)]
  [CachedScanResults(RefRangeStart = 439145, RefRangeEnd = 439238, XrefRangeStart = 439138, XrefRangeEnd = 439145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Normalize(Vector3 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 439245, RefRangeEnd = 439264, XrefRangeStart = 439238, XrefRangeEnd = 439245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Normalize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 normalized
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439264, XrefRangeEnd = 439265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe float Dot(Vector3 lhs, Vector3 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439265, XrefRangeEnd = 439267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Project(Vector3 vector, Vector3 onNormal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onNormal;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439267, XrefRangeEnd = 439270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &planeNormal;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439270, XrefRangeEnd = 439279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Angle(Vector3 from, Vector3 to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 239719, RefRangeEnd = 239721, XrefRangeStart = 239719, XrefRangeEnd = 239721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439279, XrefRangeEnd = 439284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Distance(Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439284, XrefRangeEnd = 439290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 ClampMagnitude(Vector3 vector, float maxLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439290, XrefRangeEnd = 439295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Magnitude(Vector3 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vector
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float magnitude
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439295, XrefRangeEnd = 439300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe float SqrMagnitude(Vector3 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vector
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float sqrMagnitude
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe Vector3 Min(Vector3 lhs, Vector3 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Max(Vector3 lhs, Vector3 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Vector3 zero
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439300, XrefRangeEnd = 439302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 one
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439302, XrefRangeEnd = 439304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 forward
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439304, XrefRangeEnd = 439306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 back
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439306, XrefRangeEnd = 439308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 up
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439308, XrefRangeEnd = 439310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 down
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439310, XrefRangeEnd = 439312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 left
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439312, XrefRangeEnd = 439314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3 right
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439314, XrefRangeEnd = 439316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(58)]
  [CachedScanResults(RefRangeStart = 439316, RefRangeEnd = 439374, XrefRangeStart = 439316, XrefRangeEnd = 439316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 operator +(Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 439374, RefRangeEnd = 439386, XrefRangeStart = 439374, XrefRangeEnd = 439374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 operator -(Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 operator -(Vector3 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 operator *(Vector3 a, float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 operator *(float d, Vector3 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 439386, RefRangeEnd = 439395, XrefRangeStart = 439386, XrefRangeEnd = 439386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 operator /(Vector3 a, float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Vector3 lhs, Vector3 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Vector3 lhs, Vector3 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439395, XrefRangeEnd = 439433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439433, XrefRangeEnd = 439435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Slerp_Injected([In] ref Vector3 a, [In] ref Vector3 b, float t, out Vector3 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439435, XrefRangeEnd = 439437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RotateTowards_Injected(
    [In] ref Vector3 current,
    [In] ref Vector3 target,
    float maxRadiansDelta,
    float maxMagnitudeDelta,
    out Vector3 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxRadiansDelta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxMagnitudeDelta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_RotateTowards_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_Single_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe float kEpsilon
  {
    get
    {
      float kEpsilon;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*) &kEpsilon);
      return kEpsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*) &value);
    }
  }

  public static unsafe float kEpsilonNormalSqrt
  {
    get
    {
      float epsilonNormalSqrt;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*) &epsilonNormalSqrt);
      return epsilonNormalSqrt;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*) &value);
    }
  }

  public static unsafe Vector3 zeroVector
  {
    get
    {
      Vector3 zeroVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*) &zeroVector);
      return zeroVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*) &value);
    }
  }

  public static unsafe Vector3 oneVector
  {
    get
    {
      Vector3 oneVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_oneVector, (void*) &oneVector);
      return oneVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_oneVector, (void*) &value);
    }
  }

  public static unsafe Vector3 upVector
  {
    get
    {
      Vector3 upVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_upVector, (void*) &upVector);
      return upVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_upVector, (void*) &value);
    }
  }

  public static unsafe Vector3 downVector
  {
    get
    {
      Vector3 downVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_downVector, (void*) &downVector);
      return downVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_downVector, (void*) &value);
    }
  }

  public static unsafe Vector3 leftVector
  {
    get
    {
      Vector3 leftVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_leftVector, (void*) &leftVector);
      return leftVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_leftVector, (void*) &value);
    }
  }

  public static unsafe Vector3 rightVector
  {
    get
    {
      Vector3 rightVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_rightVector, (void*) &rightVector);
      return rightVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_rightVector, (void*) &value);
    }
  }

  public static unsafe Vector3 forwardVector
  {
    get
    {
      Vector3 forwardVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*) &forwardVector);
      return forwardVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*) &value);
    }
  }

  public static unsafe Vector3 backVector
  {
    get
    {
      Vector3 backVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_backVector, (void*) &backVector);
      return backVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_backVector, (void*) &value);
    }
  }

  public static unsafe Vector3 positiveInfinityVector
  {
    get
    {
      Vector3 positiveInfinityVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*) &positiveInfinityVector);
      return positiveInfinityVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*) &value);
    }
  }

  public static unsafe Vector3 negativeInfinityVector
  {
    get
    {
      Vector3 negativeInfinityVector;
      IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*) &negativeInfinityVector);
      return negativeInfinityVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*) &value);
    }
  }

  public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
  {
    Vector3 ret;
    Vector3.SlerpUnclamped_Injected(ref a, ref b, t, out ret);
    return ret;
  }

  public static void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
  {
    Vector3.OrthoNormalize3DelegateField((System.IntPtr) ref a, (System.IntPtr) ref b, (System.IntPtr) ref c);
  }

  public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
  {
    Vector3.OrthoNormalize3(ref normal, ref tangent, ref binormal);
  }

  public static Vector3 SmoothDamp(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed)
  {
    float deltaTime = Time.deltaTime;
    return Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
  }

  public void Set(float newX, float newY, float newZ)
  {
    this.x = newX;
    this.y = newY;
    this.z = newZ;
  }

  public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
  {
    float num = -2f * Vector3.Dot(inNormal, inDirection);
    return new Vector3(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y, num * inNormal.z + inDirection.z);
  }

  public static Vector3 positiveInfinity => Vector3.positiveInfinityVector;

  public static Vector3 negativeInfinity => Vector3.negativeInfinityVector;

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static Vector3 fwd => new Vector3(0.0f, 0.0f, 1f);

  public static float AngleBetween(Vector3 from, Vector3 to)
  {
    return (float) Il2CppSystem.Math.Acos((double) Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
  }

  public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
  {
    return Vector3.ProjectOnPlane(fromThat, excludeThis);
  }

  public static void SlerpUnclamped_Injected(
    [In] ref Vector3 a,
    [In] ref Vector3 b,
    float t,
    out Vector3 ret)
  {
    Vector3.SlerpUnclamped_InjectedDelegateField((System.IntPtr) ref a, (System.IntPtr) ref b, t, (System.IntPtr) ref ret);
  }

  private delegate void OrthoNormalize3Delegate(System.IntPtr a, System.IntPtr b, System.IntPtr c);

  private delegate void SlerpUnclamped_InjectedDelegate([In] System.IntPtr a, [In] System.IntPtr b, float t, [Out] System.IntPtr ret);
}
