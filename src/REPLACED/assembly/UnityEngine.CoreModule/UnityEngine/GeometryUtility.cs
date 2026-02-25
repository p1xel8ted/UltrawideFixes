// Decompiled with JetBrains decompiler
// Type: UnityEngine.GeometryUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class GeometryUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_Il2CppStructArray_1_Vector3_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalculateBounds_Private_Static_Bounds_Il2CppStructArray_1_Vector3_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_byref_BlittableArrayWrapper_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalculateBounds_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Matrix4x4_byref_Bounds_0;

  static GeometryUtility()
  {
    Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (GeometryUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr);
    GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664482);
    GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664483);
    GeometryUtility.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_Il2CppStructArray_1_Vector3_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664484);
    GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664485);
    GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664486);
    GeometryUtility.NativeMethodInfoPtr_Internal_CalculateBounds_Private_Static_Bounds_Il2CppStructArray_1_Vector3_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664487);
    GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664488);
    GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_byref_BlittableArrayWrapper_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664489);
    GeometryUtility.NativeMethodInfoPtr_Internal_CalculateBounds_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Matrix4x4_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100664490);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 421933, RefRangeEnd = 421937, XrefRangeStart = 421923, XrefRangeEnd = 421933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CalculateFrustumPlanes(Camera camera, Il2CppStructArray<Plane> planes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planes);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421937, XrefRangeEnd = 421938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CalculateFrustumPlanes(
    Matrix4x4 worldToProjectionMatrix,
    Il2CppStructArray<Plane> planes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldToProjectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planes);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421946, RefRangeEnd = 421947, XrefRangeStart = 421938, XrefRangeEnd = 421946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Bounds CalculateBounds(
    Il2CppStructArray<Vector3> positions,
    Matrix4x4 transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transform;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_Il2CppStructArray_1_Vector3_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 421956, RefRangeEnd = 421961, XrefRangeStart = 421947, XrefRangeEnd = 421956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TestPlanesAABB(Il2CppStructArray<Plane> planes, Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421967, RefRangeEnd = 421969, XrefRangeStart = 421961, XrefRangeEnd = 421967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static void Internal_ExtractPlanes(
    [Out] Il2CppStructArray<Plane> planes,
    Matrix4x4 worldToProjectionMatrix)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421969, XrefRangeEnd = 421978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Bounds Internal_CalculateBounds(
    Il2CppStructArray<Vector3> positions,
    Matrix4x4 transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transform;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_CalculateBounds_Private_Static_Bounds_Il2CppStructArray_1_Vector3_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421978, XrefRangeEnd = 421980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TestPlanesAABB_Injected(
    ref ManagedSpanWrapper planes,
    [In] ref Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref planes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bounds;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421980, XrefRangeEnd = 421982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ExtractPlanes_Injected(
    out BlittableArrayWrapper planes,
    [In] ref Matrix4x4 worldToProjectionMatrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref planes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldToProjectionMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_byref_BlittableArrayWrapper_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421982, XrefRangeEnd = 421984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CalculateBounds_Injected(
    ref ManagedSpanWrapper positions,
    [In] ref Matrix4x4 transform,
    out Bounds ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref positions;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref transform;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_CalculateBounds_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Matrix4x4_byref_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Camera camera)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool TryCreatePlaneFromPolygon(Il2CppStructArray<Vector3> vertices, out Plane plane)
  {
    if (vertices == null || ((Il2CppArrayBase) vertices).Length < 3)
    {
      plane = new Plane(Vector3.up, 0.0f);
      return false;
    }
    if (((Il2CppArrayBase) vertices).Length == 3)
    {
      Vector3 vertex1 = ((Il2CppArrayBase<Vector3>) vertices)[0];
      Vector3 vertex2 = ((Il2CppArrayBase<Vector3>) vertices)[1];
      Vector3 vertex3 = ((Il2CppArrayBase<Vector3>) vertices)[2];
      plane = new Plane(vertex1, vertex2, vertex3);
      return (double) plane.normal.sqrMagnitude > 0.0;
    }
    Vector3 zero = Vector3.zero;
    int num1 = ((Il2CppArrayBase) vertices).Length - 1;
    Vector3 vector3 = ((Il2CppArrayBase<Vector3>) vertices)[num1];
    for (int index = 0; index < ((Il2CppArrayBase) vertices).Length; ++index)
    {
      Vector3 vertex = ((Il2CppArrayBase<Vector3>) vertices)[index];
      zero.x += (float) (((double) vector3.y - (double) vertex.y) * ((double) vector3.z + (double) vertex.z));
      zero.y += (float) (((double) vector3.z - (double) vertex.z) * ((double) vector3.x + (double) vertex.x));
      zero.z += (float) (((double) vector3.x - (double) vertex.x) * ((double) vector3.y + (double) vertex.y));
      vector3 = vertex;
    }
    zero.Normalize();
    float num2 = 0.0f;
    for (int index = 0; index < ((Il2CppArrayBase) vertices).Length; ++index)
    {
      Vector3 vertex = ((Il2CppArrayBase<Vector3>) vertices)[index];
      num2 -= Vector3.Dot(zero, vertex);
    }
    float num3 = num2 / (float) ((Il2CppArrayBase) vertices).Length;
    plane = new Plane(zero, num3);
    return (double) plane.normal.sqrMagnitude > 0.0;
  }
}
