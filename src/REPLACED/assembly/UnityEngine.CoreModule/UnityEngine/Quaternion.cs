// Decompiled with JetBrains decompiler
// Type: UnityEngine.Quaternion
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
public struct Quaternion
{
  private static readonly System.IntPtr NativeFieldInfoPtr_x;
  private static readonly System.IntPtr NativeFieldInfoPtr_y;
  private static readonly System.IntPtr NativeFieldInfoPtr_z;
  private static readonly System.IntPtr NativeFieldInfoPtr_w;
  private static readonly System.IntPtr NativeFieldInfoPtr_identityQuaternion;
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilon;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;
  [FieldOffset(0)]
  public float x;
  [FieldOffset(4)]
  public float y;
  [FieldOffset(8)]
  public float z;
  [FieldOffset(12)]
  public float w;
  private static readonly Quaternion.LerpUnclamped_InjectedDelegate LerpUnclamped_InjectedDelegateField;

  static Quaternion()
  {
    Il2CppClassPointerStore<Quaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Quaternion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quaternion>.NativeClassPtr);
    Quaternion.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, nameof (x));
    Quaternion.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, nameof (y));
    Quaternion.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, nameof (z));
    Quaternion.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, nameof (w));
    Quaternion.NativeFieldInfoPtr_identityQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, nameof (identityQuaternion));
    Quaternion.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, nameof (kEpsilon));
    Quaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667429);
    Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667430);
    Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667431);
    Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667432);
    Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667433);
    Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667434);
    Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667435);
    Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667436);
    Quaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667437);
    Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667438);
    Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667439);
    Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667440 /*0x06001030*/);
    Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667441);
    Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667442);
    Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667443);
    Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667444);
    Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667445);
    Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667446);
    Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667447);
    Quaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667448);
    Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667449);
    Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667450);
    Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667451);
    Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667452);
    Quaternion.NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667453);
    Quaternion.NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667454);
    Quaternion.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667455);
    Quaternion.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667456 /*0x06001040*/);
    Quaternion.NativeMethodInfoPtr_get_normalized_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667457);
    Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667458);
    Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667459);
    Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667460);
    Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667461);
    Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667462);
    Quaternion.NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667464);
    Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667465);
    Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667466);
    Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667467);
    Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667468);
    Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667469);
    Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667470);
    Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667471);
    Quaternion.NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667472 /*0x06001050*/);
    Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100667473);
    Quaternion.LerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<Quaternion.LerpUnclamped_InjectedDelegate>("UnityEngine.Quaternion::LerpUnclamped_Injected");
  }

  [CallerCount(62)]
  [CachedScanResults(RefRangeStart = 439439, RefRangeEnd = 439501, XrefRangeStart = 439437, XrefRangeEnd = 439439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &fromDirection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toDirection;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(142)]
  [CachedScanResults(RefRangeStart = 439503, RefRangeEnd = 439645, XrefRangeStart = 439501, XrefRangeEnd = 439503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Inverse(Quaternion rotation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rotation
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(39)]
  [CachedScanResults(RefRangeStart = 439647, RefRangeEnd = 439686, XrefRangeStart = 439645, XrefRangeEnd = 439647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Slerp(Quaternion a, Quaternion b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 439688, RefRangeEnd = 439700, XrefRangeStart = 439686, XrefRangeEnd = 439688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(57)]
  [CachedScanResults(RefRangeStart = 439702, RefRangeEnd = 439759, XrefRangeStart = 439700, XrefRangeEnd = 439702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Lerp(Quaternion a, Quaternion b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(105)]
  [CachedScanResults(RefRangeStart = 439761, RefRangeEnd = 439866, XrefRangeStart = 439759, XrefRangeEnd = 439761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Internal_FromEulerRad(Vector3 euler)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &euler
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(39)]
  [CachedScanResults(RefRangeStart = 439868, RefRangeEnd = 439907, XrefRangeStart = 439866, XrefRangeEnd = 439868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Internal_ToEulerRad(Quaternion rotation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rotation
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 439909, RefRangeEnd = 439913, XrefRangeStart = 439907, XrefRangeEnd = 439909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ToAxisAngleRad(
    Quaternion q,
    out Vector3 axis,
    out float angle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &q;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref angle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(62)]
  [CachedScanResults(RefRangeStart = 439915, RefRangeEnd = 439977, XrefRangeStart = 439913, XrefRangeEnd = 439915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion AngleAxis(float angle, Vector3 axis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(81)]
  [CachedScanResults(RefRangeStart = 439979, RefRangeEnd = 440060, XrefRangeStart = 439977, XrefRangeEnd = 439979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion LookRotation(Vector3 forward, Vector3 upwards)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &forward;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &upwards;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 440064, RefRangeEnd = 440079, XrefRangeStart = 440060, XrefRangeEnd = 440064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion LookRotation(Vector3 forward)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &forward
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245814, XrefRangeStart = 245806, XrefRangeEnd = 245814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Quaternion(float x, float y, float z, float w)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Quaternion identity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440079, XrefRangeEnd = 440081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440081, RefRangeEnd = 440083, XrefRangeStart = 440081, XrefRangeEnd = 440081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion operator *(Quaternion lhs, Quaternion rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(420)]
  [CachedScanResults(RefRangeStart = 440083, RefRangeEnd = 440503, XrefRangeStart = 440083, XrefRangeEnd = 440083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 operator *(Quaternion rotation, Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &point;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsEqualUsingDot(float dot)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dot
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Quaternion lhs, Quaternion rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440503, RefRangeEnd = 440505, XrefRangeStart = 440503, XrefRangeEnd = 440503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(Quaternion lhs, Quaternion rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Dot(Quaternion a, Quaternion b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Angle(Quaternion a, Quaternion b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(39)]
  [CachedScanResults(RefRangeStart = 440508, RefRangeEnd = 440547, XrefRangeStart = 440505, XrefRangeEnd = 440508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Internal_MakePositive(Vector3 euler)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &euler
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector3 eulerAngles
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440547, XrefRangeEnd = 440552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this = Quaternion.Internal_FromEulerRad(value * ((float) System.Math.PI / 180f));
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440552, XrefRangeEnd = 440554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Euler(float x, float y, float z)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440554, XrefRangeEnd = 440556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Euler(Vector3 euler)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &euler
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440556, XrefRangeEnd = 440558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToAngleAxis(out float angle, out Vector3 axis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref axis;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440558, XrefRangeEnd = 440562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion RotateTowards(
    Quaternion from,
    Quaternion to,
    float maxDegreesDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDegreesDelta;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440562, XrefRangeEnd = 440566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Normalize(Quaternion q)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &q
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440566, XrefRangeEnd = 440567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Normalize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Normalize_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Quaternion normalized
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440567, XrefRangeEnd = 440568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_normalized_Public_get_Quaternion_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 440572, RefRangeEnd = 440583, XrefRangeStart = 440568, XrefRangeEnd = 440572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440583, XrefRangeEnd = 440590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Quaternion other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440590, XrefRangeEnd = 440593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440593, XrefRangeEnd = 440624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440624, XrefRangeEnd = 440626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FromToRotation_Injected(
    [In] ref Vector3 fromDirection,
    [In] ref Vector3 toDirection,
    out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref fromDirection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref toDirection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440626, XrefRangeEnd = 440628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Inverse_Injected([In] ref Quaternion rotation, out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440628, XrefRangeEnd = 440630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Slerp_Injected(
    [In] ref Quaternion a,
    [In] ref Quaternion b,
    float t,
    out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440630, XrefRangeEnd = 440632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SlerpUnclamped_Injected(
    [In] ref Quaternion a,
    [In] ref Quaternion b,
    float t,
    out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440632, XrefRangeEnd = 440634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Lerp_Injected(
    [In] ref Quaternion a,
    [In] ref Quaternion b,
    float t,
    out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440634, XrefRangeEnd = 440636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_FromEulerRad_Injected([In] ref Vector3 euler, out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref euler;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440636, XrefRangeEnd = 440638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ToEulerRad_Injected([In] ref Quaternion rotation, out Vector3 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440638, XrefRangeEnd = 440640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ToAxisAngleRad_Injected(
    [In] ref Quaternion q,
    out Vector3 axis,
    out float angle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref q;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref angle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440640, XrefRangeEnd = 440642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AngleAxis_Injected(float angle, [In] ref Vector3 axis, out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440642, XrefRangeEnd = 440644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LookRotation_Injected(
    [In] ref Vector3 forward,
    [In] ref Vector3 upwards,
    out Quaternion ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref forward;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upwards;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Quaternion identityQuaternion
  {
    get
    {
      Quaternion identityQuaternion;
      IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*) &identityQuaternion);
      return identityQuaternion;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*) &value);
    }
  }

  public static unsafe float kEpsilon
  {
    get
    {
      float kEpsilon;
      IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*) &kEpsilon);
      return kEpsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*) &value);
    }
  }

  public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
  {
    Quaternion ret;
    Quaternion.LerpUnclamped_Injected(ref a, ref b, t, out ret);
    return ret;
  }

  public float this[int index]
  {
    get
    {
      switch (index)
      {
        case 0:
          return this.x;
        case 1:
          return this.y;
        case 2:
          return this.z;
        case 3:
          return this.w;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException("Invalid Quaternion index!");
      }
    }
    set
    {
      switch (index)
      {
        case 0:
          this.x = value;
          break;
        case 1:
          this.y = value;
          break;
        case 2:
          this.z = value;
          break;
        case 3:
          this.w = value;
          break;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException("Invalid Quaternion index!");
      }
    }
  }

  public void Set(float newX, float newY, float newZ, float newW)
  {
    this.x = newX;
    this.y = newY;
    this.z = newZ;
    this.w = newW;
  }

  public void SetLookRotation(Vector3 view)
  {
    Vector3 up = Vector3.up;
    this.SetLookRotation(view, up);
  }

  public void SetLookRotation(Vector3 view, Vector3 up) => this = Quaternion.LookRotation(view, up);

  public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
  {
    this = Quaternion.FromToRotation(fromDirection, toDirection);
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static Quaternion EulerRotation(float x, float y, float z)
  {
    return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
  }

  public static Quaternion EulerRotation(Vector3 euler) => Quaternion.Internal_FromEulerRad(euler);

  public void SetEulerRotation(float x, float y, float z)
  {
    this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
  }

  public void SetEulerRotation(Vector3 euler) => this = Quaternion.Internal_FromEulerRad(euler);

  public Vector3 ToEuler() => Quaternion.Internal_ToEulerRad(this);

  public static Quaternion EulerAngles(float x, float y, float z)
  {
    return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
  }

  public static Quaternion EulerAngles(Vector3 euler) => Quaternion.Internal_FromEulerRad(euler);

  public void ToAxisAngle(out Vector3 axis, out float angle)
  {
    Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
  }

  public void SetEulerAngles(float x, float y, float z)
  {
    this.SetEulerRotation(new Vector3(x, y, z));
  }

  public void SetEulerAngles(Vector3 euler) => this = Quaternion.EulerRotation(euler);

  public static Vector3 ToEulerAngles(Quaternion rotation)
  {
    return Quaternion.Internal_ToEulerRad(rotation);
  }

  public Vector3 ToEulerAngles() => Quaternion.Internal_ToEulerRad(this);

  public void SetAxisAngle(Vector3 axis, float angle) => this = Quaternion.AxisAngle(axis, angle);

  public static Quaternion AxisAngle(Vector3 axis, float angle)
  {
    return Quaternion.AngleAxis(57.29578f * angle, axis);
  }

  public static void LerpUnclamped_Injected(
    [In] ref Quaternion a,
    [In] ref Quaternion b,
    float t,
    out Quaternion ret)
  {
    Quaternion.LerpUnclamped_InjectedDelegateField((System.IntPtr) ref a, (System.IntPtr) ref b, t, (System.IntPtr) ref ret);
  }

  private delegate void LerpUnclamped_InjectedDelegate([In] System.IntPtr a, [In] System.IntPtr b, float t, [Out] System.IntPtr ret);
}
