// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ScsMath
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public static class ScsMath : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kCubeVericesOs;
  private static readonly System.IntPtr NativeFieldInfoPtr_vec4UnitX;
  private static readonly System.IntPtr NativeFieldInfoPtr_vec4UnitY;
  private static readonly System.IntPtr NativeFieldInfoPtr_vec4UnitZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_vec4UnitW;
  private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApproxEqual_Public_Static_Boolean_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeBoxAabb_Public_Static_Bounds_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeOrthonormalBasis_Public_Static_Void_Vector3_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVector2_Public_Static_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVector3_Public_Static_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVector4_Public_Static_Vector4_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVector4_Public_Static_Vector4_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTranslationMatrix_Public_Static_Matrix4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRotationMatrix_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeScaleMatrix_Public_Static_Matrix4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTrsMatrix_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApproxEqual_Public_Static_Boolean_Vector4_Vector4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector4_Vector4_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Distance2_Public_Static_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IntersectRaySphereSimple_Public_Static_Single_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max3_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max3_Public_Static_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min3_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min3_Public_Static_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Mul_Public_Static_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Mul_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rcp_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rcp_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rcp_Public_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConcentricSampleDisk_Public_Static_Vector2_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UniformSampleHemisphere_Public_Static_Vector3_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Saturate_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Saturate_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Saturate_Public_Static_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Smoothstep_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

  static ScsMath()
  {
    Il2CppClassPointerStore<ScsMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ScsMath));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScsMath>.NativeClassPtr);
    ScsMath.NativeFieldInfoPtr_kCubeVericesOs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, nameof (kCubeVericesOs));
    ScsMath.NativeFieldInfoPtr_vec4UnitX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, nameof (vec4UnitX));
    ScsMath.NativeFieldInfoPtr_vec4UnitY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, nameof (vec4UnitY));
    ScsMath.NativeFieldInfoPtr_vec4UnitZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, nameof (vec4UnitZ));
    ScsMath.NativeFieldInfoPtr_vec4UnitW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, nameof (vec4UnitW));
    ScsMath.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663376 /*0x06000050*/);
    ScsMath.NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663377 /*0x06000051*/);
    ScsMath.NativeMethodInfoPtr_ApproxEqual_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663378 /*0x06000052*/);
    ScsMath.NativeMethodInfoPtr_MakeBoxAabb_Public_Static_Bounds_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663379 /*0x06000053*/);
    ScsMath.NativeMethodInfoPtr_MakeOrthonormalBasis_Public_Static_Void_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663380 /*0x06000054*/);
    ScsMath.NativeMethodInfoPtr_MakeVector2_Public_Static_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663381 /*0x06000055*/);
    ScsMath.NativeMethodInfoPtr_MakeVector3_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663382 /*0x06000056*/);
    ScsMath.NativeMethodInfoPtr_MakeVector4_Public_Static_Vector4_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663383 /*0x06000057*/);
    ScsMath.NativeMethodInfoPtr_MakeVector4_Public_Static_Vector4_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663384 /*0x06000058*/);
    ScsMath.NativeMethodInfoPtr_MakeTranslationMatrix_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663385 /*0x06000059*/);
    ScsMath.NativeMethodInfoPtr_MakeRotationMatrix_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663386 /*0x0600005A*/);
    ScsMath.NativeMethodInfoPtr_MakeScaleMatrix_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663387 /*0x0600005B*/);
    ScsMath.NativeMethodInfoPtr_MakeTrsMatrix_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663388 /*0x0600005C*/);
    ScsMath.NativeMethodInfoPtr_ApproxEqual_Public_Static_Boolean_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663389 /*0x0600005D*/);
    ScsMath.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663390 /*0x0600005E*/);
    ScsMath.NativeMethodInfoPtr_Clamp_Public_Static_Vector4_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663391 /*0x0600005F*/);
    ScsMath.NativeMethodInfoPtr_Distance2_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663392 /*0x06000060*/);
    ScsMath.NativeMethodInfoPtr_IntersectRaySphereSimple_Public_Static_Single_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663393 /*0x06000061*/);
    ScsMath.NativeMethodInfoPtr_Max3_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663394 /*0x06000062*/);
    ScsMath.NativeMethodInfoPtr_Max3_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663395 /*0x06000063*/);
    ScsMath.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663396 /*0x06000064*/);
    ScsMath.NativeMethodInfoPtr_Min3_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663397 /*0x06000065*/);
    ScsMath.NativeMethodInfoPtr_Min3_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663398 /*0x06000066*/);
    ScsMath.NativeMethodInfoPtr_Mul_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663399 /*0x06000067*/);
    ScsMath.NativeMethodInfoPtr_Mul_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663400 /*0x06000068*/);
    ScsMath.NativeMethodInfoPtr_Rcp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663401 /*0x06000069*/);
    ScsMath.NativeMethodInfoPtr_Rcp_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663402 /*0x0600006A*/);
    ScsMath.NativeMethodInfoPtr_Rcp_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663403 /*0x0600006B*/);
    ScsMath.NativeMethodInfoPtr_ConcentricSampleDisk_Public_Static_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663404 /*0x0600006C*/);
    ScsMath.NativeMethodInfoPtr_UniformSampleHemisphere_Public_Static_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663405 /*0x0600006D*/);
    ScsMath.NativeMethodInfoPtr_Saturate_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663406 /*0x0600006E*/);
    ScsMath.NativeMethodInfoPtr_Saturate_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663407 /*0x0600006F*/);
    ScsMath.NativeMethodInfoPtr_Saturate_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663408 /*0x06000070*/);
    ScsMath.NativeMethodInfoPtr_Smoothstep_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663409 /*0x06000071*/);
    ScsMath.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsMath>.NativeClassPtr, 100663410 /*0x06000072*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924679, RefRangeEnd = 924680, XrefRangeStart = 924679, XrefRangeEnd = 924679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Abs(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Abs(Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 924680, RefRangeEnd = 924686, XrefRangeStart = 924680, XrefRangeEnd = 924680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ApproxEqual(float a, float b, float maxAbsDiff = 1E-05f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxAbsDiff;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_ApproxEqual_Public_Static_Boolean_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 924692, RefRangeEnd = 924695, XrefRangeStart = 924686, XrefRangeEnd = 924692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Bounds MakeBoxAabb(Transform transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeBoxAabb_Public_Static_Bounds_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924702, RefRangeEnd = 924703, XrefRangeStart = 924695, XrefRangeEnd = 924702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MakeOrthonormalBasis(Vector3 v, out Vector3 second, out Vector3 third)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &v;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref second;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref third;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeOrthonormalBasis_Public_Static_Void_Vector3_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe Vector2 MakeVector2(float v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeVector2_Public_Static_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 MakeVector3(float v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeVector3_Public_Static_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 924703, RefRangeEnd = 924707, XrefRangeStart = 924703, XrefRangeEnd = 924703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 MakeVector4(Vector2 xy, Vector2 zw)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &xy;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &zw;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeVector4_Public_Static_Vector4_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 924707, RefRangeEnd = 924709, XrefRangeStart = 924707, XrefRangeEnd = 924707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 MakeVector4(Vector3 v3, float w = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &v3;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeVector4_Public_Static_Vector4_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924714, RefRangeEnd = 924715, XrefRangeStart = 924709, XrefRangeEnd = 924714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 MakeTranslationMatrix(Vector3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &position
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeTranslationMatrix_Public_Static_Matrix4x4_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924720, RefRangeEnd = 924721, XrefRangeStart = 924715, XrefRangeEnd = 924720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 MakeRotationMatrix(
    Vector3 rightAxis,
    Vector3 upAxis,
    Vector3 fwdAxis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &rightAxis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &upAxis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fwdAxis;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeRotationMatrix_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924726, RefRangeEnd = 924727, XrefRangeStart = 924721, XrefRangeEnd = 924726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 MakeScaleMatrix(Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scale
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeScaleMatrix_Public_Static_Matrix4x4_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924727, XrefRangeEnd = 924748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 MakeTrsMatrix(
    Vector3 position,
    Vector3 rightAxis,
    Vector3 upAxis,
    Vector3 fwdAxis,
    Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rightAxis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &upAxis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fwdAxis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_MakeTrsMatrix_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924748, XrefRangeEnd = 924758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ApproxEqual(Vector4 a, Vector4 b, float maxAbsDiff = 1E-05f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxAbsDiff;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_ApproxEqual_Public_Static_Boolean_Vector4_Vector4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 Clamp(Vector2 v, Vector2 min, Vector2 max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &v;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Clamp_Public_Static_Vector2_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924758, XrefRangeEnd = 924759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 Clamp(Vector4 v, Vector4 min, Vector4 max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &v;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Clamp_Public_Static_Vector4_Vector4_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Distance2(Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Distance2_Public_Static_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924759, XrefRangeEnd = 924761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float IntersectRaySphereSimple(Vector3 start, Vector3 dir, float radius)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_IntersectRaySphereSimple_Public_Static_Single_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Max3(float a, float b, float c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Max3_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924761, XrefRangeEnd = 924764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Max3(Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Max3_Public_Static_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Max(Vector3 vec, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vec;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Min3(float a, float b, float c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Min3_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 924767, RefRangeEnd = 924769, XrefRangeStart = 924764, XrefRangeEnd = 924767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Min3(Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Min3_Public_Static_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 254094, RefRangeEnd = 254098, XrefRangeStart = 254094, XrefRangeEnd = 254098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Mul(Vector2 a, Vector2 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Mul_Public_Static_Vector2_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 254196, RefRangeEnd = 254197, XrefRangeStart = 254196, XrefRangeEnd = 254197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Mul(Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Mul_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 924769, RefRangeEnd = 924777, XrefRangeStart = 924769, XrefRangeEnd = 924769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Rcp(float v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Rcp_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2 Rcp(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Rcp_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 924777, RefRangeEnd = 924782, XrefRangeStart = 924777, XrefRangeEnd = 924777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Rcp(Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Rcp_Public_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924793, RefRangeEnd = 924794, XrefRangeStart = 924782, XrefRangeEnd = 924793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 ConcentricSampleDisk(int sampleIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sampleIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_ConcentricSampleDisk_Public_Static_Vector2_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924794, XrefRangeEnd = 924801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 UniformSampleHemisphere(int sampleIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sampleIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_UniformSampleHemisphere_Public_Static_Vector3_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(30)]
  [CachedScanResults(RefRangeStart = 239388, RefRangeEnd = 239418, XrefRangeStart = 239388, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Saturate(float v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Saturate_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924801, XrefRangeEnd = 924811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Saturate(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Saturate_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924820, RefRangeEnd = 924821, XrefRangeStart = 924811, XrefRangeEnd = 924820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 Saturate(Vector4 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Saturate_Public_Static_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924821, XrefRangeEnd = 924825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Smoothstep(float from, float to, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsMath.NativeMethodInfoPtr_Smoothstep_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Swap<T>(ref T x, ref T y)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    System.IntPtr* numPtr3 = &ptr1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
    System.IntPtr* numPtr4 = &ptr2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(ScsMath.MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref T local1 = ref x;
    System.IntPtr num3 = ptr1;
    // ISSUE: variable of the null type
    __Null valueGeneric1 = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num3, false, false);
    local1 = (T) valueGeneric1;
    ref T local2 = ref y;
    System.IntPtr num4 = ptr2;
    // ISSUE: variable of the null type
    __Null valueGeneric2 = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
    local2 = (T) valueGeneric2;
  }

  public ScsMath(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStructArray<Vector3> kCubeVericesOs
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ScsMath.NativeFieldInfoPtr_kCubeVericesOs, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScsMath.NativeFieldInfoPtr_kCubeVericesOs, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Vector4 vec4UnitX
  {
    get
    {
      Vector4 vec4UnitX;
      IL2CPP.il2cpp_field_static_get_value(ScsMath.NativeFieldInfoPtr_vec4UnitX, (void*) &vec4UnitX);
      return vec4UnitX;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScsMath.NativeFieldInfoPtr_vec4UnitX, (void*) &value);
    }
  }

  public static unsafe Vector4 vec4UnitY
  {
    get
    {
      Vector4 vec4UnitY;
      IL2CPP.il2cpp_field_static_get_value(ScsMath.NativeFieldInfoPtr_vec4UnitY, (void*) &vec4UnitY);
      return vec4UnitY;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScsMath.NativeFieldInfoPtr_vec4UnitY, (void*) &value);
    }
  }

  public static unsafe Vector4 vec4UnitZ
  {
    get
    {
      Vector4 vec4UnitZ;
      IL2CPP.il2cpp_field_static_get_value(ScsMath.NativeFieldInfoPtr_vec4UnitZ, (void*) &vec4UnitZ);
      return vec4UnitZ;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScsMath.NativeFieldInfoPtr_vec4UnitZ, (void*) &value);
    }
  }

  public static unsafe Vector4 vec4UnitW
  {
    get
    {
      Vector4 vec4UnitW;
      IL2CPP.il2cpp_field_static_get_value(ScsMath.NativeFieldInfoPtr_vec4UnitW, (void*) &vec4UnitW);
      return vec4UnitW;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScsMath.NativeFieldInfoPtr_vec4UnitW, (void*) &value);
    }
  }

  private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ScsMath.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<ScsMath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
