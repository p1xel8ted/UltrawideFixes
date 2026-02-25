// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineComposer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine.Utility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineComposer(System.IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TrackedObjectOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookaheadTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookaheadSmoothing;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookaheadIgnoreY;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HorizontalDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VerticalDamping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ScreenX;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ScreenY;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeadZoneWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeadZoneHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SoftZoneWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SoftZoneHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BiasX;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BiasY;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CenterOnActivate;
  private static readonly System.IntPtr NativeFieldInfoPtr__TrackedPoint_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPosPrevFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LookAtPrevFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ScreenOffsetPrevFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraOrientationPrevFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Predictor;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TrackedPoint_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TrackedPoint_Private_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLookAtPointAndSetTrackedPoint_Protected_Virtual_New_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SoftGuideRect_Internal_get_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SoftGuideRect_Internal_set_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HardGuideRect_Internal_get_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HardGuideRect_Internal_set_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateToScreenBounds_Private_Void_byref_CameraState_Rect_Vector3_byref_Quaternion_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampVerticalBounds_Private_Boolean_byref_Rect_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineComposer()
  {
    Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineComposer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr);
    CinemachineComposer.NativeFieldInfoPtr_m_TrackedObjectOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_TrackedObjectOffset));
    CinemachineComposer.NativeFieldInfoPtr_m_LookaheadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_LookaheadTime));
    CinemachineComposer.NativeFieldInfoPtr_m_LookaheadSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_LookaheadSmoothing));
    CinemachineComposer.NativeFieldInfoPtr_m_LookaheadIgnoreY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_LookaheadIgnoreY));
    CinemachineComposer.NativeFieldInfoPtr_m_HorizontalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_HorizontalDamping));
    CinemachineComposer.NativeFieldInfoPtr_m_VerticalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_VerticalDamping));
    CinemachineComposer.NativeFieldInfoPtr_m_ScreenX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_ScreenX));
    CinemachineComposer.NativeFieldInfoPtr_m_ScreenY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_ScreenY));
    CinemachineComposer.NativeFieldInfoPtr_m_DeadZoneWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_DeadZoneWidth));
    CinemachineComposer.NativeFieldInfoPtr_m_DeadZoneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_DeadZoneHeight));
    CinemachineComposer.NativeFieldInfoPtr_m_SoftZoneWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_SoftZoneWidth));
    CinemachineComposer.NativeFieldInfoPtr_m_SoftZoneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_SoftZoneHeight));
    CinemachineComposer.NativeFieldInfoPtr_m_BiasX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_BiasX));
    CinemachineComposer.NativeFieldInfoPtr_m_BiasY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_BiasY));
    CinemachineComposer.NativeFieldInfoPtr_m_CenterOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_CenterOnActivate));
    CinemachineComposer.NativeFieldInfoPtr__TrackedPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, "<TrackedPoint>k__BackingField");
    CinemachineComposer.NativeFieldInfoPtr_m_CameraPosPrevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_CameraPosPrevFrame));
    CinemachineComposer.NativeFieldInfoPtr_m_LookAtPrevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_LookAtPrevFrame));
    CinemachineComposer.NativeFieldInfoPtr_m_ScreenOffsetPrevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_ScreenOffsetPrevFrame));
    CinemachineComposer.NativeFieldInfoPtr_m_CameraOrientationPrevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_CameraOrientationPrevFrame));
    CinemachineComposer.NativeFieldInfoPtr_m_Predictor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (m_Predictor));
    CinemachineComposer.NativeFieldInfoPtr_mCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (mCache));
    CinemachineComposer.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663734);
    CinemachineComposer.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663735);
    CinemachineComposer.NativeMethodInfoPtr_get_TrackedPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663736);
    CinemachineComposer.NativeMethodInfoPtr_set_TrackedPoint_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663737);
    CinemachineComposer.NativeMethodInfoPtr_GetLookAtPointAndSetTrackedPoint_Protected_Virtual_New_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663738);
    CinemachineComposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663739);
    CinemachineComposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663740);
    CinemachineComposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663741);
    CinemachineComposer.NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663742);
    CinemachineComposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663743);
    CinemachineComposer.NativeMethodInfoPtr_get_SoftGuideRect_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663744 /*0x060001C0*/);
    CinemachineComposer.NativeMethodInfoPtr_set_SoftGuideRect_Internal_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663745);
    CinemachineComposer.NativeMethodInfoPtr_get_HardGuideRect_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663746);
    CinemachineComposer.NativeMethodInfoPtr_set_HardGuideRect_Internal_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663747);
    CinemachineComposer.NativeMethodInfoPtr_RotateToScreenBounds_Private_Void_byref_CameraState_Rect_Vector3_byref_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663748);
    CinemachineComposer.NativeMethodInfoPtr_ClampVerticalBounds_Private_Boolean_byref_Rect_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663749);
    CinemachineComposer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, 100663750);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941173, XrefRangeEnd = 941175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 TrackedPoint
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_get_TrackedPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_set_TrackedPoint_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941175, XrefRangeEnd = 941190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 GetLookAtPointAndSetTrackedPoint(
    Vector3 lookAt,
    Vector3 up,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &lookAt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_GetLookAtPointAndSetTrackedPoint_Protected_Virtual_New_Vector3_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941190, XrefRangeEnd = 941197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positionDelta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_OnTargetObjectWarped_Public_Virtual_Void_Transform_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941197, XrefRangeEnd = 941198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ForceCameraPosition(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_ForceCameraPosition_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941198, XrefRangeEnd = 941202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PrePipelineMutateCameraState(
    ref CameraState curState,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_PrePipelineMutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941245, RefRangeEnd = 941246, XrefRangeStart = 941202, XrefRangeEnd = 941245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineComposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Rect SoftGuideRect
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_get_SoftGuideRect_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941246, XrefRangeEnd = 941250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_set_SoftGuideRect_Internal_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Rect HardGuideRect
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_get_HardGuideRect_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941250, XrefRangeEnd = 941252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_set_HardGuideRect_Internal_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 941267, RefRangeEnd = 941269, XrefRangeStart = 941252, XrefRangeEnd = 941267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RotateToScreenBounds(
    ref CameraState state,
    Rect screenRect,
    Vector3 trackedPoint,
    ref Quaternion rigOrientation,
    float fov,
    float fovH,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &screenRect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &trackedPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rigOrientation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &fov;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &fovH;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_RotateToScreenBounds_Private_Void_byref_CameraState_Rect_Vector3_byref_Quaternion_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941269, XrefRangeEnd = 941270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref r;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fov;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr_ClampVerticalBounds_Private_Boolean_byref_Rect_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941270, XrefRangeEnd = 941285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineComposer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 m_TrackedObjectOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_TrackedObjectOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_TrackedObjectOffset)) = value;
    }
  }

  public unsafe float m_LookaheadTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookaheadTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookaheadTime)) = value;
    }
  }

  public unsafe float m_LookaheadSmoothing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookaheadSmoothing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookaheadSmoothing)) = value;
    }
  }

  public unsafe bool m_LookaheadIgnoreY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookaheadIgnoreY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookaheadIgnoreY)) = value;
    }
  }

  public unsafe float m_HorizontalDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_HorizontalDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_HorizontalDamping)) = value;
    }
  }

  public unsafe float m_VerticalDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_VerticalDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_VerticalDamping)) = value;
    }
  }

  public unsafe float m_ScreenX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_ScreenX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_ScreenX)) = value;
    }
  }

  public unsafe float m_ScreenY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_ScreenY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_ScreenY)) = value;
    }
  }

  public unsafe float m_DeadZoneWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_DeadZoneWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_DeadZoneWidth)) = value;
    }
  }

  public unsafe float m_DeadZoneHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_DeadZoneHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_DeadZoneHeight)) = value;
    }
  }

  public unsafe float m_SoftZoneWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_SoftZoneWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_SoftZoneWidth)) = value;
    }
  }

  public unsafe float m_SoftZoneHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_SoftZoneHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_SoftZoneHeight)) = value;
    }
  }

  public unsafe float m_BiasX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_BiasX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_BiasX)) = value;
    }
  }

  public unsafe float m_BiasY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_BiasY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_BiasY)) = value;
    }
  }

  public unsafe bool m_CenterOnActivate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_CenterOnActivate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_CenterOnActivate)) = value;
    }
  }

  public unsafe Vector3 _TrackedPoint_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr__TrackedPoint_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr__TrackedPoint_k__BackingField)) = value;
    }
  }

  public unsafe Vector3 m_CameraPosPrevFrame
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_CameraPosPrevFrame));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_CameraPosPrevFrame)) = value;
    }
  }

  public unsafe Vector3 m_LookAtPrevFrame
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookAtPrevFrame));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_LookAtPrevFrame)) = value;
    }
  }

  public unsafe Vector2 m_ScreenOffsetPrevFrame
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_ScreenOffsetPrevFrame));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_ScreenOffsetPrevFrame)) = value;
    }
  }

  public unsafe Quaternion m_CameraOrientationPrevFrame
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_CameraOrientationPrevFrame));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_CameraOrientationPrevFrame)) = value;
    }
  }

  public unsafe PositionPredictor m_Predictor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_Predictor));
      return num == System.IntPtr.Zero ? (PositionPredictor) null : Il2CppObjectPool.Get<PositionPredictor>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_m_Predictor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineComposer.FovCache mCache
  {
    get
    {
      return *(CinemachineComposer.FovCache*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_mCache));
    }
    [param: In] set
    {
      *(CinemachineComposer.FovCache*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineComposer.NativeFieldInfoPtr_mCache)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct FovCache
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_mFovSoftGuideRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_mFovHardGuideRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_mFovH;
    private static readonly System.IntPtr NativeFieldInfoPtr_mFov;
    private static readonly System.IntPtr NativeFieldInfoPtr_mOrthoSizeOverDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_mAspect;
    private static readonly System.IntPtr NativeFieldInfoPtr_mSoftGuideRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_mHardGuideRect;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCache_Public_Void_LensSettings_Rect_Rect_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToFOV_Private_Rect_Rect_Single_Single_Single_0;
    [FieldOffset(0)]
    public Rect mFovSoftGuideRect;
    [FieldOffset(16 /*0x10*/)]
    public Rect mFovHardGuideRect;
    [FieldOffset(32 /*0x20*/)]
    public float mFovH;
    [FieldOffset(36)]
    public float mFov;
    [FieldOffset(40)]
    public float mOrthoSizeOverDistance;
    [FieldOffset(44)]
    public float mAspect;
    [FieldOffset(48 /*0x30*/)]
    public Rect mSoftGuideRect;
    [FieldOffset(64 /*0x40*/)]
    public Rect mHardGuideRect;

    static FovCache()
    {
      Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineComposer>.NativeClassPtr, nameof (FovCache));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr);
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mFovSoftGuideRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mFovSoftGuideRect));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mFovHardGuideRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mFovHardGuideRect));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mFovH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mFovH));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mFov));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mOrthoSizeOverDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mOrthoSizeOverDistance));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mAspect));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mSoftGuideRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mSoftGuideRect));
      CinemachineComposer.FovCache.NativeFieldInfoPtr_mHardGuideRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, nameof (mHardGuideRect));
      CinemachineComposer.FovCache.NativeMethodInfoPtr_UpdateCache_Public_Void_LensSettings_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, 100663751);
      CinemachineComposer.FovCache.NativeMethodInfoPtr_ScreenToFOV_Private_Rect_Rect_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, 100663752);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 941144, RefRangeEnd = 941145, XrefRangeStart = 941115, XrefRangeEnd = 941144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateCache(
      LensSettings lens,
      Rect softGuide,
      Rect hardGuide,
      float targetDistance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &lens;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &softGuide;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hardGuide;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetDistance;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.FovCache.NativeMethodInfoPtr_UpdateCache_Public_Void_LensSettings_Rect_Rect_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 941171, RefRangeEnd = 941173, XrefRangeStart = 941145, XrefRangeEnd = 941171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &rScreen;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fov;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fovH;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aspect;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineComposer.FovCache.NativeMethodInfoPtr_ScreenToFOV_Private_Rect_Rect_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineComposer.FovCache>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
