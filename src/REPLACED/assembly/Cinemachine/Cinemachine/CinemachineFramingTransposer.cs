// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineFramingTransposer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine.Utility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineFramingTransposer(IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_TrackedObjectOffset;
  private static readonly IntPtr NativeFieldInfoPtr_m_LookaheadTime;
  private static readonly IntPtr NativeFieldInfoPtr_m_LookaheadSmoothing;
  private static readonly IntPtr NativeFieldInfoPtr_m_LookaheadIgnoreY;
  private static readonly IntPtr NativeFieldInfoPtr_m_XDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_YDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_ZDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_TargetMovementOnly;
  private static readonly IntPtr NativeFieldInfoPtr_m_ScreenX;
  private static readonly IntPtr NativeFieldInfoPtr_m_ScreenY;
  private static readonly IntPtr NativeFieldInfoPtr_m_CameraDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_DeadZoneWidth;
  private static readonly IntPtr NativeFieldInfoPtr_m_DeadZoneHeight;
  private static readonly IntPtr NativeFieldInfoPtr_m_DeadZoneDepth;
  private static readonly IntPtr NativeFieldInfoPtr_m_UnlimitedSoftZone;
  private static readonly IntPtr NativeFieldInfoPtr_m_SoftZoneWidth;
  private static readonly IntPtr NativeFieldInfoPtr_m_SoftZoneHeight;
  private static readonly IntPtr NativeFieldInfoPtr_m_BiasX;
  private static readonly IntPtr NativeFieldInfoPtr_m_BiasY;
  private static readonly IntPtr NativeFieldInfoPtr_m_CenterOnActivate;
  private static readonly IntPtr NativeFieldInfoPtr_m_GroupFramingMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_AdjustmentMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_GroupFramingSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaxDollyIn;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaxDollyOut;
  private static readonly IntPtr NativeFieldInfoPtr_m_MinimumDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaximumDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_MinimumFOV;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaximumFOV;
  private static readonly IntPtr NativeFieldInfoPtr_m_MinimumOrthoSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaximumOrthoSize;
  private static readonly IntPtr NativeFieldInfoPtr_kMinimumCameraDistance;
  private static readonly IntPtr NativeFieldInfoPtr_kMinimumGroupSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreviousCameraPosition;
  private static readonly IntPtr NativeFieldInfoPtr_m_Predictor;
  private static readonly IntPtr NativeFieldInfoPtr__TrackedPoint_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_m_InheritingPosition;
  private static readonly IntPtr NativeFieldInfoPtr_m_prevFOV;
  private static readonly IntPtr NativeFieldInfoPtr_m_prevRotation;
  private static readonly IntPtr NativeFieldInfoPtr__LastBounds_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_SoftGuideRect_Internal_get_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_SoftGuideRect_Internal_set_Void_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_HardGuideRect_Internal_get_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_HardGuideRect_Internal_set_Void_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BodyAppliesAfterAim_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TrackedPoint_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_TrackedPoint_Private_set_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0;
  private static readonly IntPtr NativeMethodInfoPtr_ScreenToOrtho_Private_Rect_Rect_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OrthoOffsetToScreenBounds_Private_Vector3_Vector3_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastBounds_Public_get_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LastBounds_Private_set_Void_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastBoundsMatrix_Public_get_Matrix4x4_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LastBoundsMatrix_Private_set_Void_Matrix4x4_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTargetHeight_Private_Single_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_ComputeGroupBounds_Private_Vector3_ICinemachineTargetGroup_byref_CameraState_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScreenSpaceGroupBoundingBox_Private_Static_Bounds_ICinemachineTargetGroup_byref_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineFramingTransposer()
  {
    Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineFramingTransposer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr);
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_TrackedObjectOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_TrackedObjectOffset));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_LookaheadTime));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_LookaheadSmoothing));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadIgnoreY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_LookaheadIgnoreY));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_XDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_XDamping));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_YDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_YDamping));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_ZDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_ZDamping));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_TargetMovementOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_TargetMovementOnly));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_ScreenX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_ScreenX));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_ScreenY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_ScreenY));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_CameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_CameraDistance));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_DeadZoneWidth));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_DeadZoneHeight));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_DeadZoneDepth));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_UnlimitedSoftZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_UnlimitedSoftZone));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_SoftZoneWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_SoftZoneWidth));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_SoftZoneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_SoftZoneHeight));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_BiasX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_BiasX));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_BiasY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_BiasY));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_CenterOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_CenterOnActivate));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_GroupFramingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_GroupFramingMode));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_AdjustmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_AdjustmentMode));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_GroupFramingSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_GroupFramingSize));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaxDollyIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MaxDollyIn));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaxDollyOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MaxDollyOut));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MinimumDistance));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MaximumDistance));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MinimumFOV));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MaximumFOV));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumOrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MinimumOrthoSize));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumOrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_MaximumOrthoSize));
    CinemachineFramingTransposer.NativeFieldInfoPtr_kMinimumCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (kMinimumCameraDistance));
    CinemachineFramingTransposer.NativeFieldInfoPtr_kMinimumGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (kMinimumGroupSize));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_PreviousCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_PreviousCameraPosition));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_Predictor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_Predictor));
    CinemachineFramingTransposer.NativeFieldInfoPtr__TrackedPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, "<TrackedPoint>k__BackingField");
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_InheritingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_InheritingPosition));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_prevFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_prevFOV));
    CinemachineFramingTransposer.NativeFieldInfoPtr_m_prevRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, nameof (m_prevRotation));
    CinemachineFramingTransposer.NativeFieldInfoPtr__LastBounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, "<LastBounds>k__BackingField");
    CinemachineFramingTransposer.NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, "<LastBoundsMatrix>k__BackingField");
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_SoftGuideRect_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663753);
    CinemachineFramingTransposer.NativeMethodInfoPtr_set_SoftGuideRect_Internal_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663754);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_HardGuideRect_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663755);
    CinemachineFramingTransposer.NativeMethodInfoPtr_set_HardGuideRect_Internal_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663756);
    CinemachineFramingTransposer.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663757);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663758);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663759);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_BodyAppliesAfterAim_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663760 /*0x060001D0*/);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_TrackedPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663761);
    CinemachineFramingTransposer.NativeMethodInfoPtr_set_TrackedPoint_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663762);
    CinemachineFramingTransposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663763);
    CinemachineFramingTransposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663764);
    CinemachineFramingTransposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663765);
    CinemachineFramingTransposer.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663766);
    CinemachineFramingTransposer.NativeMethodInfoPtr_ScreenToOrtho_Private_Rect_Rect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663767);
    CinemachineFramingTransposer.NativeMethodInfoPtr_OrthoOffsetToScreenBounds_Private_Vector3_Vector3_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663768);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_LastBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663769);
    CinemachineFramingTransposer.NativeMethodInfoPtr_set_LastBounds_Private_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663770);
    CinemachineFramingTransposer.NativeMethodInfoPtr_get_LastBoundsMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663771);
    CinemachineFramingTransposer.NativeMethodInfoPtr_set_LastBoundsMatrix_Private_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663772);
    CinemachineFramingTransposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663773);
    CinemachineFramingTransposer.NativeMethodInfoPtr_GetTargetHeight_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663774);
    CinemachineFramingTransposer.NativeMethodInfoPtr_ComputeGroupBounds_Private_Vector3_ICinemachineTargetGroup_byref_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663775);
    CinemachineFramingTransposer.NativeMethodInfoPtr_GetScreenSpaceGroupBoundingBox_Private_Static_Bounds_ICinemachineTargetGroup_byref_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663776 /*0x060001E0*/);
    CinemachineFramingTransposer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr, 100663777);
  }

  public unsafe Rect SoftGuideRect
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_get_SoftGuideRect_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941285, XrefRangeEnd = 941289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_set_SoftGuideRect_Internal_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Rect HardGuideRect
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_get_HardGuideRect_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941289, XrefRangeEnd = 941291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_set_HardGuideRect_Internal_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941291, XrefRangeEnd = 941292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941292, XrefRangeEnd = 941294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe bool BodyAppliesAfterAim
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_get_BodyAppliesAfterAim_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 TrackedPoint
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_get_TrackedPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_set_TrackedPoint_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941294, XrefRangeEnd = 941301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positionDelta;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941301, XrefRangeEnd = 941302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rot;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941302, XrefRangeEnd = 941314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime,
    ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &worldUp;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) transitionParams);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Boolean_ICinemachineCamera_Vector3_Single_byref_TransitionParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &rScreen;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &orthoSize;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &aspect;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_ScreenToOrtho_Private_Rect_Rect_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941314, XrefRangeEnd = 941316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &targetPos2D;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &screenRect;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_OrthoOffsetToScreenBounds_Private_Vector3_Vector3_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Bounds LastBounds
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_get_LastBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_set_LastBounds_Private_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Matrix4x4 LastBoundsMatrix
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_get_LastBoundsMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_set_LastBoundsMatrix_Private_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941316, XrefRangeEnd = 941412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFramingTransposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941412, XrefRangeEnd = 941418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetTargetHeight(Vector2 boundsSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &boundsSize
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_GetTargetHeight_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941439, RefRangeEnd = 941440, XrefRangeStart = 941418, XrefRangeEnd = 941439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_ComputeGroupBounds_Private_Vector3_ICinemachineTargetGroup_byref_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941461, RefRangeEnd = 941462, XrefRangeStart = 941440, XrefRangeEnd = 941461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Bounds GetScreenSpaceGroupBoundingBox(
    ICinemachineTargetGroup group,
    ref Vector3 pos,
    Quaternion orientation)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &orientation;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr_GetScreenSpaceGroupBoundingBox_Private_Static_Bounds_ICinemachineTargetGroup_byref_Vector3_Quaternion_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941462, XrefRangeEnd = 941469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineFramingTransposer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFramingTransposer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFramingTransposer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 m_TrackedObjectOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_TrackedObjectOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_TrackedObjectOffset)) = value;
    }
  }

  public unsafe float m_LookaheadTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadTime)) = value;
    }
  }

  public unsafe float m_LookaheadSmoothing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadSmoothing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadSmoothing)) = value;
    }
  }

  public unsafe bool m_LookaheadIgnoreY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadIgnoreY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_LookaheadIgnoreY)) = value;
    }
  }

  public unsafe float m_XDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_XDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_XDamping)) = value;
    }
  }

  public unsafe float m_YDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_YDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_YDamping)) = value;
    }
  }

  public unsafe float m_ZDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_ZDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_ZDamping)) = value;
    }
  }

  public unsafe bool m_TargetMovementOnly
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_TargetMovementOnly));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_TargetMovementOnly)) = value;
    }
  }

  public unsafe float m_ScreenX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_ScreenX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_ScreenX)) = value;
    }
  }

  public unsafe float m_ScreenY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_ScreenY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_ScreenY)) = value;
    }
  }

  public unsafe float m_CameraDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_CameraDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_CameraDistance)) = value;
    }
  }

  public unsafe float m_DeadZoneWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneWidth)) = value;
    }
  }

  public unsafe float m_DeadZoneHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneHeight)) = value;
    }
  }

  public unsafe float m_DeadZoneDepth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneDepth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_DeadZoneDepth)) = value;
    }
  }

  public unsafe bool m_UnlimitedSoftZone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_UnlimitedSoftZone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_UnlimitedSoftZone)) = value;
    }
  }

  public unsafe float m_SoftZoneWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_SoftZoneWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_SoftZoneWidth)) = value;
    }
  }

  public unsafe float m_SoftZoneHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_SoftZoneHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_SoftZoneHeight)) = value;
    }
  }

  public unsafe float m_BiasX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_BiasX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_BiasX)) = value;
    }
  }

  public unsafe float m_BiasY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_BiasY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_BiasY)) = value;
    }
  }

  public unsafe bool m_CenterOnActivate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_CenterOnActivate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_CenterOnActivate)) = value;
    }
  }

  public unsafe CinemachineFramingTransposer.FramingMode m_GroupFramingMode
  {
    get
    {
      return *(CinemachineFramingTransposer.FramingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_GroupFramingMode));
    }
    [param: In] set
    {
      *(CinemachineFramingTransposer.FramingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_GroupFramingMode)) = value;
    }
  }

  public unsafe CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode
  {
    get
    {
      return *(CinemachineFramingTransposer.AdjustmentMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_AdjustmentMode));
    }
    [param: In] set
    {
      *(CinemachineFramingTransposer.AdjustmentMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_AdjustmentMode)) = value;
    }
  }

  public unsafe float m_GroupFramingSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_GroupFramingSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_GroupFramingSize)) = value;
    }
  }

  public unsafe float m_MaxDollyIn
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaxDollyIn));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaxDollyIn)) = value;
    }
  }

  public unsafe float m_MaxDollyOut
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaxDollyOut));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaxDollyOut)) = value;
    }
  }

  public unsafe float m_MinimumDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumDistance)) = value;
    }
  }

  public unsafe float m_MaximumDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumDistance)) = value;
    }
  }

  public unsafe float m_MinimumFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumFOV)) = value;
    }
  }

  public unsafe float m_MaximumFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumFOV)) = value;
    }
  }

  public unsafe float m_MinimumOrthoSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumOrthoSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MinimumOrthoSize)) = value;
    }
  }

  public unsafe float m_MaximumOrthoSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumOrthoSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_MaximumOrthoSize)) = value;
    }
  }

  public static unsafe float kMinimumCameraDistance
  {
    get
    {
      float minimumCameraDistance;
      IL2CPP.il2cpp_field_static_get_value(CinemachineFramingTransposer.NativeFieldInfoPtr_kMinimumCameraDistance, (void*) &minimumCameraDistance);
      return minimumCameraDistance;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineFramingTransposer.NativeFieldInfoPtr_kMinimumCameraDistance, (void*) &value);
    }
  }

  public static unsafe float kMinimumGroupSize
  {
    get
    {
      float minimumGroupSize;
      IL2CPP.il2cpp_field_static_get_value(CinemachineFramingTransposer.NativeFieldInfoPtr_kMinimumGroupSize, (void*) &minimumGroupSize);
      return minimumGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineFramingTransposer.NativeFieldInfoPtr_kMinimumGroupSize, (void*) &value);
    }
  }

  public unsafe Vector3 m_PreviousCameraPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_PreviousCameraPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_PreviousCameraPosition)) = value;
    }
  }

  public unsafe PositionPredictor m_Predictor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_Predictor));
      return num == IntPtr.Zero ? (PositionPredictor) null : Il2CppObjectPool.Get<PositionPredictor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_Predictor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 _TrackedPoint_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr__TrackedPoint_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr__TrackedPoint_k__BackingField)) = value;
    }
  }

  public unsafe bool m_InheritingPosition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_InheritingPosition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_InheritingPosition)) = value;
    }
  }

  public unsafe float m_prevFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_prevFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_prevFOV)) = value;
    }
  }

  public unsafe Quaternion m_prevRotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_prevRotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr_m_prevRotation)) = value;
    }
  }

  public unsafe Bounds _LastBounds_k__BackingField
  {
    get
    {
      return *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr__LastBounds_k__BackingField));
    }
    [param: In] set
    {
      *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr__LastBounds_k__BackingField)) = value;
    }
  }

  public unsafe Matrix4x4 _LastBoundsMatrix_k__BackingField
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFramingTransposer.NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField)) = value;
    }
  }

  public enum FramingMode
  {
    Horizontal,
    Vertical,
    HorizontalAndVertical,
    None,
  }

  public enum AdjustmentMode
  {
    ZoomOnly,
    DollyOnly,
    DollyThenZoom,
  }
}
