// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineCollider
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineCollider(System.IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CollideAgainst;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IgnoreTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TransparentLayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MinimumDistanceFromTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AvoidObstacles;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DistanceLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MinimumOcclusionTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Strategy;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaximumEffort;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SmoothingTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Damping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DampingWhenOccluded;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OptimalTargetDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_PrecisionSlush;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CornerBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_AngleThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_ColliderBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetObscured_Public_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CameraWasDisplaced_Public_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraDisplacementDistance_Public_Single_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugPaths_Public_get_List_1_List_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreserveLineOfSight_Private_Vector3_byref_CameraState_byref_VcamExtraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullCameraInFrontOfNearestObstacle_Private_Vector3_Vector3_Vector3_Int32_byref_RaycastHit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushCameraBack_Private_Vector3_Vector3_Vector3_RaycastHit_Vector3_Plane_Single_Int32_byref_VcamExtraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWalkingDirection_Private_Boolean_Vector3_Vector3_RaycastHit_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPushBackDistance_Private_Single_Ray_Plane_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampRayToBounds_Private_Static_Single_Ray_Single_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RespectCameraRadius_Private_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckForTargetObstructions_Private_Boolean_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetOffscreen_Private_Static_Boolean_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineCollider()
  {
    Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineCollider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr);
    CinemachineCollider.NativeFieldInfoPtr_m_CollideAgainst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_CollideAgainst));
    CinemachineCollider.NativeFieldInfoPtr_m_IgnoreTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_IgnoreTag));
    CinemachineCollider.NativeFieldInfoPtr_m_TransparentLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_TransparentLayers));
    CinemachineCollider.NativeFieldInfoPtr_m_MinimumDistanceFromTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_MinimumDistanceFromTarget));
    CinemachineCollider.NativeFieldInfoPtr_m_AvoidObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_AvoidObstacles));
    CinemachineCollider.NativeFieldInfoPtr_m_DistanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_DistanceLimit));
    CinemachineCollider.NativeFieldInfoPtr_m_MinimumOcclusionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_MinimumOcclusionTime));
    CinemachineCollider.NativeFieldInfoPtr_m_CameraRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_CameraRadius));
    CinemachineCollider.NativeFieldInfoPtr_m_Strategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_Strategy));
    CinemachineCollider.NativeFieldInfoPtr_m_MaximumEffort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_MaximumEffort));
    CinemachineCollider.NativeFieldInfoPtr_m_SmoothingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_SmoothingTime));
    CinemachineCollider.NativeFieldInfoPtr_m_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_Damping));
    CinemachineCollider.NativeFieldInfoPtr_m_DampingWhenOccluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_DampingWhenOccluded));
    CinemachineCollider.NativeFieldInfoPtr_m_OptimalTargetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_OptimalTargetDistance));
    CinemachineCollider.NativeFieldInfoPtr_k_PrecisionSlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (k_PrecisionSlush));
    CinemachineCollider.NativeFieldInfoPtr_m_CornerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (m_CornerBuffer));
    CinemachineCollider.NativeFieldInfoPtr_k_AngleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (k_AngleThreshold));
    CinemachineCollider.NativeFieldInfoPtr_s_ColliderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (s_ColliderBuffer));
    CinemachineCollider.NativeMethodInfoPtr_IsTargetObscured_Public_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663435 /*0x0600008B*/);
    CinemachineCollider.NativeMethodInfoPtr_CameraWasDisplaced_Public_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663436 /*0x0600008C*/);
    CinemachineCollider.NativeMethodInfoPtr_GetCameraDisplacementDistance_Public_Single_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663437 /*0x0600008D*/);
    CinemachineCollider.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663438 /*0x0600008E*/);
    CinemachineCollider.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663439 /*0x0600008F*/);
    CinemachineCollider.NativeMethodInfoPtr_get_DebugPaths_Public_get_List_1_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663440 /*0x06000090*/);
    CinemachineCollider.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663441 /*0x06000091*/);
    CinemachineCollider.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663442 /*0x06000092*/);
    CinemachineCollider.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663443 /*0x06000093*/);
    CinemachineCollider.NativeMethodInfoPtr_PreserveLineOfSight_Private_Vector3_byref_CameraState_byref_VcamExtraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663444 /*0x06000094*/);
    CinemachineCollider.NativeMethodInfoPtr_PullCameraInFrontOfNearestObstacle_Private_Vector3_Vector3_Vector3_Int32_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663445 /*0x06000095*/);
    CinemachineCollider.NativeMethodInfoPtr_PushCameraBack_Private_Vector3_Vector3_Vector3_RaycastHit_Vector3_Plane_Single_Int32_byref_VcamExtraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663446 /*0x06000096*/);
    CinemachineCollider.NativeMethodInfoPtr_GetWalkingDirection_Private_Boolean_Vector3_Vector3_RaycastHit_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663447 /*0x06000097*/);
    CinemachineCollider.NativeMethodInfoPtr_GetPushBackDistance_Private_Single_Ray_Plane_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663448 /*0x06000098*/);
    CinemachineCollider.NativeMethodInfoPtr_ClampRayToBounds_Private_Static_Single_Ray_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663449 /*0x06000099*/);
    CinemachineCollider.NativeMethodInfoPtr_RespectCameraRadius_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663450 /*0x0600009A*/);
    CinemachineCollider.NativeMethodInfoPtr_CheckForTargetObstructions_Private_Boolean_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663451 /*0x0600009B*/);
    CinemachineCollider.NativeMethodInfoPtr_IsTargetOffscreen_Private_Static_Boolean_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663452 /*0x0600009C*/);
    CinemachineCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, 100663453 /*0x0600009D*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938097, XrefRangeEnd = 938100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsTargetObscured(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_IsTargetObscured_Public_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938100, XrefRangeEnd = 938104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CameraWasDisplaced(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_CameraWasDisplaced_Public_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938104, XrefRangeEnd = 938109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetCameraDisplacementDistance(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_GetCameraDisplacementDistance_Public_Single_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938109, XrefRangeEnd = 938114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineCollider.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<List<Vector3>> DebugPaths
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938114, XrefRangeEnd = 938141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_get_DebugPaths_Public_get_List_1_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<List<Vector3>>) null : Il2CppObjectPool.Get<List<List<Vector3>>>(num3);
    }
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineCollider.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938141, XrefRangeEnd = 938149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineCollider.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938149, XrefRangeEnd = 938214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineCollider.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938237, RefRangeEnd = 938238, XrefRangeStart = 938214, XrefRangeEnd = 938237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 PreserveLineOfSight(
    ref CameraState state,
    ref CinemachineCollider.VcamExtraState extra)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) extra);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_PreserveLineOfSight_Private_Vector3_byref_CameraState_byref_VcamExtraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CinemachineCollider.VcamExtraState local = ref extra;
    System.IntPtr pointer = ptr;
    CinemachineCollider.VcamExtraState vcamExtraState = pointer == System.IntPtr.Zero ? (CinemachineCollider.VcamExtraState) null : new CinemachineCollider.VcamExtraState(pointer);
    local = vcamExtraState;
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938248, RefRangeEnd = 938249, XrefRangeStart = 938238, XrefRangeEnd = 938248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 PullCameraInFrontOfNearestObstacle(
    Vector3 cameraPos,
    Vector3 lookAtPos,
    int layerMask,
    ref RaycastHit hitInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &cameraPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lookAtPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitInfo;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_PullCameraInFrontOfNearestObstacle_Private_Vector3_Vector3_Vector3_Int32_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 938287, RefRangeEnd = 938289, XrefRangeStart = 938249, XrefRangeEnd = 938287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 PushCameraBack(
    Vector3 currentPos,
    Vector3 pushDir,
    RaycastHit obstacle,
    Vector3 lookAtPos,
    Plane startPlane,
    float targetDistance,
    int iterations,
    ref CinemachineCollider.VcamExtraState extra)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
    numPtr1[0] = (System.IntPtr) &currentPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pushDir;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &obstacle;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lookAtPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startPlane;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &targetDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &iterations;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) extra);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_PushCameraBack_Private_Vector3_Vector3_Vector3_RaycastHit_Vector3_Plane_Single_Int32_byref_VcamExtraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CinemachineCollider.VcamExtraState local = ref extra;
    System.IntPtr pointer = ptr;
    CinemachineCollider.VcamExtraState vcamExtraState = pointer == System.IntPtr.Zero ? (CinemachineCollider.VcamExtraState) null : new CinemachineCollider.VcamExtraState(pointer);
    local = vcamExtraState;
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938345, RefRangeEnd = 938346, XrefRangeStart = 938289, XrefRangeEnd = 938345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetWalkingDirection(
    Vector3 pos,
    Vector3 pushDir,
    RaycastHit obstacle,
    ref Vector3 outDir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pushDir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &obstacle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref outDir;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_GetWalkingDirection_Private_Boolean_Vector3_Vector3_RaycastHit_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 938352, RefRangeEnd = 938354, XrefRangeStart = 938346, XrefRangeEnd = 938352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetPushBackDistance(
    Ray ray,
    Plane startPlane,
    float targetDistance,
    Vector3 lookAtPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &ray;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPlane;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lookAtPos;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_GetPushBackDistance_Private_Single_Ray_Plane_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938399, RefRangeEnd = 938400, XrefRangeStart = 938354, XrefRangeEnd = 938399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ClampRayToBounds(Ray ray, float distance, Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &ray;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_ClampRayToBounds_Private_Static_Single_Ray_Single_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938452, RefRangeEnd = 938453, XrefRangeStart = 938400, XrefRangeEnd = 938452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cameraPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lookAtPos;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_RespectCameraRadius_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938453, XrefRangeEnd = 938470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckForTargetObstructions(CameraState state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_CheckForTargetObstructions_Private_Boolean_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938470, XrefRangeEnd = 938501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsTargetOffscreen(CameraState state)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr_IsTargetOffscreen_Private_Static_Boolean_CameraState_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938501, XrefRangeEnd = 938508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineCollider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask m_CollideAgainst
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_CollideAgainst));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_CollideAgainst)) = value;
    }
  }

  public unsafe string m_IgnoreTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_IgnoreTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_IgnoreTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LayerMask m_TransparentLayers
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_TransparentLayers));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_TransparentLayers)) = value;
    }
  }

  public unsafe float m_MinimumDistanceFromTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_MinimumDistanceFromTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_MinimumDistanceFromTarget)) = value;
    }
  }

  public unsafe bool m_AvoidObstacles
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_AvoidObstacles));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_AvoidObstacles)) = value;
    }
  }

  public unsafe float m_DistanceLimit
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_DistanceLimit));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_DistanceLimit)) = value;
    }
  }

  public unsafe float m_MinimumOcclusionTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_MinimumOcclusionTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_MinimumOcclusionTime)) = value;
    }
  }

  public unsafe float m_CameraRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_CameraRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_CameraRadius)) = value;
    }
  }

  public unsafe CinemachineCollider.ResolutionStrategy m_Strategy
  {
    get
    {
      return *(CinemachineCollider.ResolutionStrategy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_Strategy));
    }
    [param: In] set
    {
      *(CinemachineCollider.ResolutionStrategy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_Strategy)) = value;
    }
  }

  public unsafe int m_MaximumEffort
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_MaximumEffort));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_MaximumEffort)) = value;
    }
  }

  public unsafe float m_SmoothingTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_SmoothingTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_SmoothingTime)) = value;
    }
  }

  public unsafe float m_Damping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_Damping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_Damping)) = value;
    }
  }

  public unsafe float m_DampingWhenOccluded
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_DampingWhenOccluded));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_DampingWhenOccluded)) = value;
    }
  }

  public unsafe float m_OptimalTargetDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_OptimalTargetDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_OptimalTargetDistance)) = value;
    }
  }

  public static unsafe float k_PrecisionSlush
  {
    get
    {
      float kPrecisionSlush;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCollider.NativeFieldInfoPtr_k_PrecisionSlush, (void*) &kPrecisionSlush);
      return kPrecisionSlush;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCollider.NativeFieldInfoPtr_k_PrecisionSlush, (void*) &value);
    }
  }

  public unsafe Il2CppStructArray<RaycastHit> m_CornerBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_CornerBuffer));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RaycastHit>) null : Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.NativeFieldInfoPtr_m_CornerBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float k_AngleThreshold
  {
    get
    {
      float kAngleThreshold;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCollider.NativeFieldInfoPtr_k_AngleThreshold, (void*) &kAngleThreshold);
      return kAngleThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCollider.NativeFieldInfoPtr_k_AngleThreshold, (void*) &value);
    }
  }

  public static unsafe Il2CppReferenceArray<Collider> s_ColliderBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCollider.NativeFieldInfoPtr_s_ColliderBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCollider.NativeFieldInfoPtr_s_ColliderBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum ResolutionStrategy
  {
    PullCameraForward,
    PreserveCameraHeight,
    PreserveCameraDistance,
  }

  public class VcamExtraState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_previousDisplacement;
    private static readonly System.IntPtr NativeFieldInfoPtr_previousCameraOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_previousCameraPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_previousDampTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetObscured;
    private static readonly System.IntPtr NativeFieldInfoPtr_occlusionStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_debugResolutionPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SmoothedDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SmoothedTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPointToDebugPath_Public_Void_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDistanceSmoothing_Public_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDistanceSmoothing_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetDistanceSmoothing_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VcamExtraState()
    {
      Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineCollider>.NativeClassPtr, nameof (VcamExtraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr);
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (previousDisplacement));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (previousCameraOffset));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (previousCameraPosition));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousDampTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (previousDampTime));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_targetObscured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (targetObscured));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_occlusionStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (occlusionStartTime));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_debugResolutionPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (debugResolutionPath));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_m_SmoothedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (m_SmoothedDistance));
      CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_m_SmoothedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, nameof (m_SmoothedTime));
      CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_AddPointToDebugPath_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, 100663455 /*0x0600009F*/);
      CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_ApplyDistanceSmoothing_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, 100663456 /*0x060000A0*/);
      CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_UpdateDistanceSmoothing_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, 100663457 /*0x060000A1*/);
      CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_ResetDistanceSmoothing_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, 100663458 /*0x060000A2*/);
      CinemachineCollider.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr, 100663459 /*0x060000A3*/);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddPointToDebugPath(Vector3 p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &p
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_AddPointToDebugPath_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938085, XrefRangeEnd = 938089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float ApplyDistanceSmoothing(float distance, float smoothingTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &distance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothingTime;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_ApplyDistanceSmoothing_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938089, XrefRangeEnd = 938093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateDistanceSmoothing(float distance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &distance
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_UpdateDistanceSmoothing_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938093, XrefRangeEnd = 938097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetDistanceSmoothing(float smoothingTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &smoothingTime
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.VcamExtraState.NativeMethodInfoPtr_ResetDistanceSmoothing_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VcamExtraState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCollider.VcamExtraState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCollider.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 previousDisplacement
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousDisplacement));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousDisplacement)) = value;
      }
    }

    public unsafe Vector3 previousCameraOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousCameraOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousCameraOffset)) = value;
      }
    }

    public unsafe Vector3 previousCameraPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousCameraPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousCameraPosition)) = value;
      }
    }

    public unsafe float previousDampTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousDampTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_previousDampTime)) = value;
      }
    }

    public unsafe bool targetObscured
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_targetObscured));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_targetObscured)) = value;
      }
    }

    public unsafe float occlusionStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_occlusionStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_occlusionStartTime)) = value;
      }
    }

    public unsafe List<Vector3> debugResolutionPath
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_debugResolutionPath));
        return num == System.IntPtr.Zero ? (List<Vector3>) null : Il2CppObjectPool.Get<List<Vector3>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_debugResolutionPath), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float m_SmoothedDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_m_SmoothedDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_m_SmoothedDistance)) = value;
      }
    }

    public unsafe float m_SmoothedTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_m_SmoothedTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollider.VcamExtraState.NativeFieldInfoPtr_m_SmoothedTime)) = value;
      }
    }
  }
}
