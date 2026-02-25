// Decompiled with JetBrains decompiler
// Type: UnityEngine.Matrix4x4
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
public struct Matrix4x4
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m00;
  private static readonly System.IntPtr NativeFieldInfoPtr_m10;
  private static readonly System.IntPtr NativeFieldInfoPtr_m20;
  private static readonly System.IntPtr NativeFieldInfoPtr_m30;
  private static readonly System.IntPtr NativeFieldInfoPtr_m01;
  private static readonly System.IntPtr NativeFieldInfoPtr_m11;
  private static readonly System.IntPtr NativeFieldInfoPtr_m21;
  private static readonly System.IntPtr NativeFieldInfoPtr_m31;
  private static readonly System.IntPtr NativeFieldInfoPtr_m02;
  private static readonly System.IntPtr NativeFieldInfoPtr_m12;
  private static readonly System.IntPtr NativeFieldInfoPtr_m22;
  private static readonly System.IntPtr NativeFieldInfoPtr_m32;
  private static readonly System.IntPtr NativeFieldInfoPtr_m03;
  private static readonly System.IntPtr NativeFieldInfoPtr_m13;
  private static readonly System.IntPtr NativeFieldInfoPtr_m23;
  private static readonly System.IntPtr NativeFieldInfoPtr_m33;
  private static readonly System.IntPtr NativeFieldInfoPtr_zeroMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_identityMatrix;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRotation_Private_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRotation_Injected_Private_Static_Void_byref_Matrix4x4_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0;
  [FieldOffset(0)]
  public float m00;
  [FieldOffset(4)]
  public float m10;
  [FieldOffset(8)]
  public float m20;
  [FieldOffset(12)]
  public float m30;
  [FieldOffset(16 /*0x10*/)]
  public float m01;
  [FieldOffset(20)]
  public float m11;
  [FieldOffset(24)]
  public float m21;
  [FieldOffset(28)]
  public float m31;
  [FieldOffset(32 /*0x20*/)]
  public float m02;
  [FieldOffset(36)]
  public float m12;
  [FieldOffset(40)]
  public float m22;
  [FieldOffset(44)]
  public float m32;
  [FieldOffset(48 /*0x30*/)]
  public float m03;
  [FieldOffset(52)]
  public float m13;
  [FieldOffset(56)]
  public float m23;
  [FieldOffset(60)]
  public float m33;
  private static readonly Matrix4x4.IsIdentityDelegate IsIdentityDelegateField;
  private static readonly Matrix4x4.GetDeterminantDelegate GetDeterminantDelegateField;
  private static readonly Matrix4x4.ValidTRSDelegate ValidTRSDelegateField;
  private static readonly Matrix4x4.Frustum_InjectedDelegate Frustum_InjectedDelegateField;
  private static readonly Matrix4x4.CompareApproximately_InjectedDelegate CompareApproximately_InjectedDelegateField;

  static Matrix4x4()
  {
    Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Matrix4x4));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr);
    Matrix4x4.NativeFieldInfoPtr_m00 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m00));
    Matrix4x4.NativeFieldInfoPtr_m10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m10));
    Matrix4x4.NativeFieldInfoPtr_m20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m20));
    Matrix4x4.NativeFieldInfoPtr_m30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m30));
    Matrix4x4.NativeFieldInfoPtr_m01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m01));
    Matrix4x4.NativeFieldInfoPtr_m11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m11));
    Matrix4x4.NativeFieldInfoPtr_m21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m21));
    Matrix4x4.NativeFieldInfoPtr_m31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m31));
    Matrix4x4.NativeFieldInfoPtr_m02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m02));
    Matrix4x4.NativeFieldInfoPtr_m12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m12));
    Matrix4x4.NativeFieldInfoPtr_m22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m22));
    Matrix4x4.NativeFieldInfoPtr_m32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m32));
    Matrix4x4.NativeFieldInfoPtr_m03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m03));
    Matrix4x4.NativeFieldInfoPtr_m13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m13));
    Matrix4x4.NativeFieldInfoPtr_m23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m23));
    Matrix4x4.NativeFieldInfoPtr_m33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (m33));
    Matrix4x4.NativeFieldInfoPtr_zeroMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (zeroMatrix));
    Matrix4x4.NativeFieldInfoPtr_identityMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, nameof (identityMatrix));
    Matrix4x4.NativeMethodInfoPtr_GetRotation_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667322);
    Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667323);
    Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667324);
    Matrix4x4.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667325);
    Matrix4x4.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667326);
    Matrix4x4.NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667327);
    Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667328 /*0x06000FC0*/);
    Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667329);
    Matrix4x4.NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667330);
    Matrix4x4.NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667331);
    Matrix4x4.NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667332);
    Matrix4x4.NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667333);
    Matrix4x4.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667334);
    Matrix4x4.NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667335);
    Matrix4x4.NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667336);
    Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667337);
    Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667338);
    Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667339);
    Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667340);
    Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667341);
    Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667342);
    Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667343);
    Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667344 /*0x06000FD0*/);
    Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667345);
    Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667346);
    Matrix4x4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667347);
    Matrix4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667348);
    Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667349);
    Matrix4x4.NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667350);
    Matrix4x4.NativeMethodInfoPtr_GetPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667351);
    Matrix4x4.NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667352);
    Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667353);
    Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667354);
    Matrix4x4.NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667355);
    Matrix4x4.NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667356);
    Matrix4x4.NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667357);
    Matrix4x4.NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667358);
    Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667359);
    Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667360 /*0x06000FE0*/);
    Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667361);
    Matrix4x4.NativeMethodInfoPtr_GetRotation_Injected_Private_Static_Void_byref_Matrix4x4_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667363);
    Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667364);
    Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667365);
    Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667366);
    Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667367);
    Matrix4x4.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667368);
    Matrix4x4.NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667369);
    Matrix4x4.NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667370);
    Matrix4x4.NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667371);
    Matrix4x4.NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100667372);
    Matrix4x4.IsIdentityDelegateField = IL2CPP.ResolveICall<Matrix4x4.IsIdentityDelegate>("UnityEngine.Matrix4x4::IsIdentity");
    Matrix4x4.GetDeterminantDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetDeterminantDelegate>("UnityEngine.Matrix4x4::GetDeterminant");
    Matrix4x4.ValidTRSDelegateField = IL2CPP.ResolveICall<Matrix4x4.ValidTRSDelegate>("UnityEngine.Matrix4x4::ValidTRS");
    Matrix4x4.Frustum_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.Frustum_InjectedDelegate>("UnityEngine.Matrix4x4::Frustum_Injected");
    Matrix4x4.CompareApproximately_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.CompareApproximately_InjectedDelegate>("UnityEngine.Matrix4x4::CompareApproximately_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438519, XrefRangeEnd = 438521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Quaternion GetRotation()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetRotation_Private_Quaternion_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438521, XrefRangeEnd = 438523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetLossyScale()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Private_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438523, XrefRangeEnd = 438525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FrustumPlanes DecomposeProjection()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FrustumPlanes*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Quaternion rotation
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 438527, RefRangeEnd = 438528, XrefRangeStart = 438525, XrefRangeEnd = 438527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 lossyScale
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 438530, RefRangeEnd = 438533, XrefRangeStart = 438528, XrefRangeEnd = 438530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FrustumPlanes decomposeProjection
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 438535, RefRangeEnd = 438537, XrefRangeStart = 438533, XrefRangeEnd = 438535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrustumPlanes*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 438539, RefRangeEnd = 438561, XrefRangeStart = 438537, XrefRangeEnd = 438539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &q;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &s;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 438563, RefRangeEnd = 438567, XrefRangeStart = 438561, XrefRangeEnd = 438563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438569, RefRangeEnd = 438570, XrefRangeStart = 438567, XrefRangeEnd = 438569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Inverse(Matrix4x4 m)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &m
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Matrix4x4 inverse
  {
    [CallerCount(26), CachedScanResults(RefRangeStart = 438572, RefRangeEnd = 438598, XrefRangeStart = 438570, XrefRangeEnd = 438572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438600, RefRangeEnd = 438601, XrefRangeStart = 438598, XrefRangeEnd = 438600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Transpose(Matrix4x4 m)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &m
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Matrix4x4 transpose
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 438603, RefRangeEnd = 438605, XrefRangeStart = 438601, XrefRangeEnd = 438603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 438607, RefRangeEnd = 438609, XrefRangeStart = 438605, XrefRangeEnd = 438607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Ortho(
    float left,
    float right,
    float bottom,
    float top,
    float zNear,
    float zFar)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bottom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &top;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &zNear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &zFar;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 438611, RefRangeEnd = 438613, XrefRangeStart = 438609, XrefRangeEnd = 438611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &fov;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aspect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zNear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &zFar;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438615, RefRangeEnd = 438616, XrefRangeStart = 438613, XrefRangeEnd = 438615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 438616, RefRangeEnd = 438630, XrefRangeStart = 438616, XrefRangeEnd = 438616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &column0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &column1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &column2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &column3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float this[int row, int column]
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438630, XrefRangeEnd = 438631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &row;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &column;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438631, XrefRangeEnd = 438632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &row;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &column;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float this[int index]
  {
    [CallerCount(25), CachedScanResults(RefRangeStart = 438632, RefRangeEnd = 438657, XrefRangeStart = 438632, XrefRangeEnd = 438632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(25), CachedScanResults(RefRangeStart = 438657, RefRangeEnd = 438682, XrefRangeStart = 438657, XrefRangeEnd = 438657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438682, XrefRangeEnd = 438698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438698, XrefRangeEnd = 438702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Matrix4x4 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(53)]
  [CachedScanResults(RefRangeStart = 438702, RefRangeEnd = 438755, XrefRangeStart = 438702, XrefRangeEnd = 438702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 438755, RefRangeEnd = 438773, XrefRangeStart = 438755, XrefRangeEnd = 438755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vector;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 438773, RefRangeEnd = 438777, XrefRangeStart = 438773, XrefRangeEnd = 438773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438777, XrefRangeEnd = 438778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(32 /*0x20*/)]
  [CachedScanResults(RefRangeStart = 438778, RefRangeEnd = 438810, XrefRangeStart = 438778, XrefRangeEnd = 438778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetColumn(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 438813, RefRangeEnd = 438827, XrefRangeStart = 438810, XrefRangeEnd = 438813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetRow(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438827, RefRangeEnd = 438828, XrefRangeStart = 438827, XrefRangeEnd = 438827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPosition()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetPosition_Public_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 438832, RefRangeEnd = 438836, XrefRangeStart = 438828, XrefRangeEnd = 438832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColumn(int index, Vector4 column)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &column;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 438836, RefRangeEnd = 438858, XrefRangeStart = 438836, XrefRangeEnd = 438836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 MultiplyPoint(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 438858, RefRangeEnd = 438902, XrefRangeStart = 438858, XrefRangeEnd = 438858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 MultiplyPoint3x4(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 438902, RefRangeEnd = 438913, XrefRangeStart = 438902, XrefRangeEnd = 438902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 MultiplyVector(Vector3 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vector
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 438913, RefRangeEnd = 438915, XrefRangeStart = 438913, XrefRangeEnd = 438913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Scale(Vector3 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vector
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 438915, RefRangeEnd = 438924, XrefRangeStart = 438915, XrefRangeEnd = 438915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Translate(Vector3 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vector
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 438924, RefRangeEnd = 438930, XrefRangeStart = 438924, XrefRangeEnd = 438924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 Rotate(Quaternion q)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &q
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Matrix4x4 identity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438930, XrefRangeEnd = 438932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438932, XrefRangeEnd = 438933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438933, XrefRangeEnd = 439012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439012, XrefRangeEnd = 439014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetRotation_Injected_Private_Static_Void_byref_Matrix4x4_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439014, XrefRangeEnd = 439016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetLossyScale_Injected_Private_Static_Void_byref_Matrix4x4_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439016, XrefRangeEnd = 439018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DecomposeProjection_Injected(
    ref Matrix4x4 _unity_self,
    out FrustumPlanes ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439018, XrefRangeEnd = 439020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TRS_Injected(
    [In] ref Vector3 pos,
    [In] ref Quaternion q,
    [In] ref Vector3 s,
    out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref q;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref s;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439020, XrefRangeEnd = 439022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Inverse3DAffine_Injected([In] ref Matrix4x4 input, ref Matrix4x4 result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439022, XrefRangeEnd = 439024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Inverse_Injected([In] ref Matrix4x4 m, out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref m;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439024, XrefRangeEnd = 439026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Transpose_Injected([In] ref Matrix4x4 m, out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref m;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439026, XrefRangeEnd = 439028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Ortho_Injected(
    float left,
    float right,
    float bottom,
    float top,
    float zNear,
    float zFar,
    out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bottom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &top;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &zNear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &zFar;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439028, XrefRangeEnd = 439030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Perspective_Injected(
    float fov,
    float aspect,
    float zNear,
    float zFar,
    out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &fov;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aspect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zNear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &zFar;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439030, XrefRangeEnd = 439032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LookAt_Injected(
    [In] ref Vector3 from,
    [In] ref Vector3 to,
    [In] ref Vector3 up,
    out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Matrix4x4 zeroMatrix
  {
    get
    {
      Matrix4x4 zeroMatrix;
      IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*) &zeroMatrix);
      return zeroMatrix;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*) &value);
    }
  }

  public static unsafe Matrix4x4 identityMatrix
  {
    get
    {
      Matrix4x4 identityMatrix;
      IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*) &identityMatrix);
      return identityMatrix;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*) &value);
    }
  }

  public bool IsIdentity()
  {
    return Matrix4x4.IsIdentityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public float GetDeterminant()
  {
    return Matrix4x4.GetDeterminantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool isIdentity => this.IsIdentity();

  public float determinant => this.GetDeterminant();

  public bool ValidTRS()
  {
    return Matrix4x4.ValidTRSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public static float Determinant(Matrix4x4 m) => m.determinant;

  public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) => this = Matrix4x4.TRS(pos, q, s);

  public static Matrix4x4 Frustum(
    float left,
    float right,
    float bottom,
    float top,
    float zNear,
    float zFar)
  {
    Matrix4x4 ret;
    Matrix4x4.Frustum_Injected(left, right, bottom, top, zNear, zFar, out ret);
    return ret;
  }

  public static Matrix4x4 Frustum(FrustumPlanes fp)
  {
    return Matrix4x4.Frustum(fp.left, fp.right, fp.bottom, fp.top, fp.zNear, fp.zFar);
  }

  public static bool CompareApproximately(Matrix4x4 a, Matrix4x4 b, float threshold)
  {
    return Matrix4x4.CompareApproximately_Injected(ref a, ref b, threshold);
  }

  public void SetRow(int index, Vector4 row)
  {
    this[index, 0] = row.x;
    this[index, 1] = row.y;
    this[index, 2] = row.z;
    this[index, 3] = row.w;
  }

  public Plane TransformPlane(Plane plane)
  {
    Matrix4x4 inverse = this.inverse;
    float x = plane.normal.x;
    float y = plane.normal.y;
    float z = plane.normal.z;
    float distance = plane.distance;
    return new Plane(new Vector3((float) ((double) inverse.m00 * (double) x + (double) inverse.m10 * (double) y + (double) inverse.m20 * (double) z + (double) inverse.m30 * (double) distance), (float) ((double) inverse.m01 * (double) x + (double) inverse.m11 * (double) y + (double) inverse.m21 * (double) z + (double) inverse.m31 * (double) distance), (float) ((double) inverse.m02 * (double) x + (double) inverse.m12 * (double) y + (double) inverse.m22 * (double) z + (double) inverse.m32 * (double) distance)), (float) ((double) inverse.m03 * (double) x + (double) inverse.m13 * (double) y + (double) inverse.m23 * (double) z + (double) inverse.m33 * (double) distance));
  }

  public static Matrix4x4 zero => Matrix4x4.zeroMatrix;

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static void Frustum_Injected(
    float left,
    float right,
    float bottom,
    float top,
    float zNear,
    float zFar,
    out Matrix4x4 ret)
  {
    Matrix4x4.Frustum_InjectedDelegateField(left, right, bottom, top, zNear, zFar, (System.IntPtr) ref ret);
  }

  public static bool CompareApproximately_Injected(
    [In] ref Matrix4x4 a,
    [In] ref Matrix4x4 b,
    float threshold)
  {
    return Matrix4x4.CompareApproximately_InjectedDelegateField((System.IntPtr) ref a, (System.IntPtr) ref b, threshold);
  }

  private delegate bool IsIdentityDelegate(System.IntPtr _param1);

  private delegate float GetDeterminantDelegate(System.IntPtr _param1);

  private delegate bool ValidTRSDelegate(System.IntPtr _param1);

  private delegate void Frustum_InjectedDelegate(
    float left,
    float right,
    float bottom,
    float top,
    float zNear,
    float zFar,
    [Out] System.IntPtr ret);

  private delegate bool CompareApproximately_InjectedDelegate([In] System.IntPtr a, [In] System.IntPtr b, float threshold);
}
