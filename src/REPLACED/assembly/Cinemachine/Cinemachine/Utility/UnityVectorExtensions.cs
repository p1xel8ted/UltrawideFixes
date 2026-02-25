// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.UnityVectorExtensions
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public static class UnityVectorExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnSegment_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnSegment_Public_Static_Single_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProjectOntoPlane_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsUniform_Public_Static_Boolean_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AlmostZero_Public_Static_Boolean_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConservativeSetPositionAndRotation_Internal_Static_Void_Transform_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SafeFromToRotation_Public_Static_Quaternion_Vector3_Vector3_Vector3_0;

  static UnityVectorExtensions()
  {
    Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (UnityVectorExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr);
    UnityVectorExtensions.NativeMethodInfoPtr_ClosestPointOnSegment_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664497);
    UnityVectorExtensions.NativeMethodInfoPtr_ClosestPointOnSegment_Public_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664498);
    UnityVectorExtensions.NativeMethodInfoPtr_ProjectOntoPlane_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664499);
    UnityVectorExtensions.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664500);
    UnityVectorExtensions.NativeMethodInfoPtr_IsUniform_Public_Static_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664501);
    UnityVectorExtensions.NativeMethodInfoPtr_AlmostZero_Public_Static_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664502);
    UnityVectorExtensions.NativeMethodInfoPtr_ConservativeSetPositionAndRotation_Internal_Static_Void_Transform_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664503);
    UnityVectorExtensions.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664504);
    UnityVectorExtensions.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664505);
    UnityVectorExtensions.NativeMethodInfoPtr_SafeFromToRotation_Public_Static_Quaternion_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityVectorExtensions>.NativeClassPtr, 100664506);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947985, RefRangeEnd = 947986, XrefRangeStart = 947985, XrefRangeEnd = 947985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ClosestPointOnSegment(this Vector3 p, Vector3 s0, Vector3 s1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &p;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &s0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &s1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_ClosestPointOnSegment_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947986, RefRangeEnd = 947987, XrefRangeStart = 947986, XrefRangeEnd = 947986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ClosestPointOnSegment(this Vector2 p, Vector2 s0, Vector2 s1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &p;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &s0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &s1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_ClosestPointOnSegment_Public_Static_Single_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 947987, RefRangeEnd = 948005, XrefRangeStart = 947987, XrefRangeEnd = 947987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 ProjectOntoPlane(this Vector3 vector, Vector3 planeNormal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &planeNormal;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_ProjectOntoPlane_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924679, RefRangeEnd = 924680, XrefRangeStart = 924679, XrefRangeEnd = 924680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Abs(this Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 948008, RefRangeEnd = 948009, XrefRangeStart = 948005, XrefRangeEnd = 948008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsUniform(this Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_IsUniform_Public_Static_Boolean_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(30)]
  [CachedScanResults(RefRangeStart = 948009, RefRangeEnd = 948039, XrefRangeStart = 948009, XrefRangeEnd = 948009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AlmostZero(this Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_AlmostZero_Public_Static_Boolean_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 948040, RefRangeEnd = 948046, XrefRangeStart = 948039, XrefRangeEnd = 948040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConservativeSetPositionAndRotation(
    this Transform t,
    Vector3 pos,
    Quaternion rot)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_ConservativeSetPositionAndRotation_Internal_Static_Void_Transform_Vector3_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 948051, RefRangeEnd = 948056, XrefRangeStart = 948046, XrefRangeEnd = 948051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Angle(Vector3 v1, Vector3 v2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &v1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 948061, RefRangeEnd = 948070, XrefRangeStart = 948056, XrefRangeEnd = 948061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &v1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 948076, RefRangeEnd = 948080, XrefRangeStart = 948070, XrefRangeEnd = 948076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &v1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityVectorExtensions.NativeMethodInfoPtr_SafeFromToRotation_Public_Static_Quaternion_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public UnityVectorExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
