// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.SplineHelpers
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public static class SplineHelpers : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Bezier3_Public_Static_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BezierTangent3_Public_Static_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bezier1_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSmoothControlPoints_Public_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSmoothControlPointsLooped_Public_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_0;

  static SplineHelpers()
  {
    Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (SplineHelpers));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr);
    SplineHelpers.NativeMethodInfoPtr_Bezier3_Public_Static_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr, 100664492);
    SplineHelpers.NativeMethodInfoPtr_BezierTangent3_Public_Static_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr, 100664493);
    SplineHelpers.NativeMethodInfoPtr_Bezier1_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr, 100664494);
    SplineHelpers.NativeMethodInfoPtr_ComputeSmoothControlPoints_Public_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr, 100664495);
    SplineHelpers.NativeMethodInfoPtr_ComputeSmoothControlPointsLooped_Public_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineHelpers>.NativeClassPtr, 100664496 /*0x060004B0*/);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 947939, RefRangeEnd = 947942, XrefRangeStart = 947938, XrefRangeEnd = 947939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &p3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SplineHelpers.NativeMethodInfoPtr_Bezier3_Public_Static_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 947943, RefRangeEnd = 947945, XrefRangeStart = 947942, XrefRangeEnd = 947943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 BezierTangent3(
    float t,
    Vector3 p0,
    Vector3 p1,
    Vector3 p2,
    Vector3 p3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &p3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SplineHelpers.NativeMethodInfoPtr_BezierTangent3_Public_Static_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 947946, RefRangeEnd = 947948, XrefRangeStart = 947945, XrefRangeEnd = 947946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Bezier1(float t, float p0, float p1, float p2, float p3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &p3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SplineHelpers.NativeMethodInfoPtr_Bezier1_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 947973, RefRangeEnd = 947976, XrefRangeStart = 947948, XrefRangeEnd = 947973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ComputeSmoothControlPoints(
    ref Il2CppStructArray<Vector4> knot,
    ref Il2CppStructArray<Vector4> ctrl1,
    ref Il2CppStructArray<Vector4> ctrl2)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) knot);
    System.IntPtr* numPtr3 = &ptr1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ctrl1);
    System.IntPtr* numPtr4 = &ptr2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ctrl2);
    System.IntPtr* numPtr5 = &ptr3;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr5;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(SplineHelpers.NativeMethodInfoPtr_ComputeSmoothControlPoints_Public_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_0, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref Il2CppStructArray<Vector4> local1 = ref knot;
    System.IntPtr num4 = ptr1;
    Il2CppStructArray<Vector4> il2CppStructArray1 = num4 == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : new Il2CppStructArray<Vector4>(num4);
    local1 = il2CppStructArray1;
    ref Il2CppStructArray<Vector4> local2 = ref ctrl1;
    System.IntPtr num5 = ptr2;
    Il2CppStructArray<Vector4> il2CppStructArray2 = num5 == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : new Il2CppStructArray<Vector4>(num5);
    local2 = il2CppStructArray2;
    ref Il2CppStructArray<Vector4> local3 = ref ctrl2;
    System.IntPtr num6 = ptr3;
    Il2CppStructArray<Vector4> il2CppStructArray3 = num6 == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : new Il2CppStructArray<Vector4>(num6);
    local3 = il2CppStructArray3;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947984, RefRangeEnd = 947985, XrefRangeStart = 947976, XrefRangeEnd = 947984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ComputeSmoothControlPointsLooped(
    ref Il2CppStructArray<Vector4> knot,
    ref Il2CppStructArray<Vector4> ctrl1,
    ref Il2CppStructArray<Vector4> ctrl2)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) knot);
    System.IntPtr* numPtr3 = &ptr1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ctrl1);
    System.IntPtr* numPtr4 = &ptr2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ctrl2);
    System.IntPtr* numPtr5 = &ptr3;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr5;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(SplineHelpers.NativeMethodInfoPtr_ComputeSmoothControlPointsLooped_Public_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_byref_Il2CppStructArray_1_Vector4_0, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref Il2CppStructArray<Vector4> local1 = ref knot;
    System.IntPtr num4 = ptr1;
    Il2CppStructArray<Vector4> il2CppStructArray1 = num4 == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : new Il2CppStructArray<Vector4>(num4);
    local1 = il2CppStructArray1;
    ref Il2CppStructArray<Vector4> local2 = ref ctrl1;
    System.IntPtr num5 = ptr2;
    Il2CppStructArray<Vector4> il2CppStructArray2 = num5 == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : new Il2CppStructArray<Vector4>(num5);
    local2 = il2CppStructArray2;
    ref Il2CppStructArray<Vector4> local3 = ref ctrl2;
    System.IntPtr num6 = ptr3;
    Il2CppStructArray<Vector4> il2CppStructArray3 = num6 == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : new Il2CppStructArray<Vector4>(num6);
    local3 = il2CppStructArray3;
  }

  public SplineHelpers(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
