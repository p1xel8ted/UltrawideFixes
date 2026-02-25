// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VBufferParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VBufferParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDepthSliceCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kExtraHalfAngleDegrees;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTanExtraVertFov;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewPositionWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewForwardWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumeSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_nearClipPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_farClipPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneLeftTopWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneRightSpanWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneDownSpanWs;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcTanHalfVertFov_Private_Static_Single_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CeilToNearest8Alignment_Private_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVolumeSize_Public_Static_Vector3Int_RenderTargetInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVolumeSize_Private_Static_Vector3Int_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeProjectionMatrix_Private_Static_Matrix4x4_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_Vector3Int_Single_Single_0;
  [FieldOffset(0)]
  public readonly Matrix4x4 projectionViewMatrix;
  [FieldOffset(64 /*0x40*/)]
  public readonly Vector3 viewPositionWs;
  [FieldOffset(76)]
  public readonly Vector3 viewForwardWs;
  [FieldOffset(88)]
  public readonly Vector3Int volumeSize;
  [FieldOffset(100)]
  public readonly float nearClipPlane;
  [FieldOffset(104)]
  public readonly float farClipPlane;
  [FieldOffset(108)]
  public readonly Vector3 nearPlaneLeftTopWs;
  [FieldOffset(120)]
  public readonly Vector3 nearPlaneRightSpanWs;
  [FieldOffset(132)]
  public readonly Vector3 nearPlaneDownSpanWs;

  static VBufferParams()
  {
    Il2CppClassPointerStore<VBufferParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VBufferParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr);
    VBufferParams.NativeFieldInfoPtr_kDepthSliceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (kDepthSliceCount));
    VBufferParams.NativeFieldInfoPtr_kExtraHalfAngleDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (kExtraHalfAngleDegrees));
    VBufferParams.NativeFieldInfoPtr_kTanExtraVertFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (kTanExtraVertFov));
    VBufferParams.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (projectionViewMatrix));
    VBufferParams.NativeFieldInfoPtr_viewPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (viewPositionWs));
    VBufferParams.NativeFieldInfoPtr_viewForwardWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (viewForwardWs));
    VBufferParams.NativeFieldInfoPtr_volumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (volumeSize));
    VBufferParams.NativeFieldInfoPtr_nearClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (nearClipPlane));
    VBufferParams.NativeFieldInfoPtr_farClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (farClipPlane));
    VBufferParams.NativeFieldInfoPtr_nearPlaneLeftTopWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (nearPlaneLeftTopWs));
    VBufferParams.NativeFieldInfoPtr_nearPlaneRightSpanWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (nearPlaneRightSpanWs));
    VBufferParams.NativeFieldInfoPtr_nearPlaneDownSpanWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, nameof (nearPlaneDownSpanWs));
    VBufferParams.NativeMethodInfoPtr_CalcTanHalfVertFov_Private_Static_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, 100664277);
    VBufferParams.NativeMethodInfoPtr_CeilToNearest8Alignment_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, 100664278);
    VBufferParams.NativeMethodInfoPtr_MakeVolumeSize_Public_Static_Vector3Int_RenderTargetInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, 100664279);
    VBufferParams.NativeMethodInfoPtr_MakeVolumeSize_Private_Static_Vector3Int_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, 100664280);
    VBufferParams.NativeMethodInfoPtr_MakeProjectionMatrix_Private_Static_Matrix4x4_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, 100664281);
    VBufferParams.NativeMethodInfoPtr__ctor_Public_Void_Camera_Vector3Int_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, 100664282);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935969, XrefRangeEnd = 935977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcTanHalfVertFov(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VBufferParams.NativeMethodInfoPtr_CalcTanHalfVertFov_Private_Static_Single_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int CeilToNearest8Alignment(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VBufferParams.NativeMethodInfoPtr_CeilToNearest8Alignment_Private_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935977, XrefRangeEnd = 935984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3Int MakeVolumeSize(RenderTargetInfo rti)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rti
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VBufferParams.NativeMethodInfoPtr_MakeVolumeSize_Public_Static_Vector3Int_RenderTargetInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935984, XrefRangeEnd = 935991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3Int MakeVolumeSize(
    int renderTargetWidth,
    int depthSliceCount,
    float heightWidthAspect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &renderTargetWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSliceCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightWidthAspect;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VBufferParams.NativeMethodInfoPtr_MakeVolumeSize_Private_Static_Vector3Int_Int32_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935991, XrefRangeEnd = 935992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 MakeProjectionMatrix(float tanHalfVertFov, float whAspectRatio)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &tanHalfVertFov;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &whAspectRatio;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VBufferParams.NativeMethodInfoPtr_MakeProjectionMatrix_Private_Static_Matrix4x4_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 936023, RefRangeEnd = 936024, XrefRangeStart = 935992, XrefRangeEnd = 936023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VBufferParams(
    Camera camera,
    Vector3Int volumeSize,
    float nearPlaneDistanceWs,
    float farPlaneDistanceWs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &volumeSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nearPlaneDistanceWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &farPlaneDistanceWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VBufferParams.NativeMethodInfoPtr__ctor_Public_Void_Camera_Vector3Int_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBufferParams>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int kDepthSliceCount
  {
    get
    {
      int kDepthSliceCount;
      IL2CPP.il2cpp_field_static_get_value(VBufferParams.NativeFieldInfoPtr_kDepthSliceCount, (void*) &kDepthSliceCount);
      return kDepthSliceCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VBufferParams.NativeFieldInfoPtr_kDepthSliceCount, (void*) &value);
    }
  }

  public static unsafe float kExtraHalfAngleDegrees
  {
    get
    {
      float halfAngleDegrees;
      IL2CPP.il2cpp_field_static_get_value(VBufferParams.NativeFieldInfoPtr_kExtraHalfAngleDegrees, (void*) &halfAngleDegrees);
      return halfAngleDegrees;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VBufferParams.NativeFieldInfoPtr_kExtraHalfAngleDegrees, (void*) &value);
    }
  }

  public static unsafe float kTanExtraVertFov
  {
    get
    {
      float kTanExtraVertFov;
      IL2CPP.il2cpp_field_static_get_value(VBufferParams.NativeFieldInfoPtr_kTanExtraVertFov, (void*) &kTanExtraVertFov);
      return kTanExtraVertFov;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VBufferParams.NativeFieldInfoPtr_kTanExtraVertFov, (void*) &value);
    }
  }
}
