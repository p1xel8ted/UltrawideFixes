// Decompiled with JetBrains decompiler
// Type: CinemachineRecomposer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CinemachineRecomposer(IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_ApplyAfter;
  private static readonly IntPtr NativeFieldInfoPtr_m_Tilt;
  private static readonly IntPtr NativeFieldInfoPtr_m_Pan;
  private static readonly IntPtr NativeFieldInfoPtr_m_Dutch;
  private static readonly IntPtr NativeFieldInfoPtr_m_ZoomScale;
  private static readonly IntPtr NativeFieldInfoPtr_m_FollowAttachment;
  private static readonly IntPtr NativeFieldInfoPtr_m_LookAtAttachment;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PrePipelineMutateCameraStateCallback_Public_Virtual_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineRecomposer()
  {
    Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineRecomposer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr);
    CinemachineRecomposer.NativeFieldInfoPtr_m_ApplyAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_ApplyAfter));
    CinemachineRecomposer.NativeFieldInfoPtr_m_Tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_Tilt));
    CinemachineRecomposer.NativeFieldInfoPtr_m_Pan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_Pan));
    CinemachineRecomposer.NativeFieldInfoPtr_m_Dutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_Dutch));
    CinemachineRecomposer.NativeFieldInfoPtr_m_ZoomScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_ZoomScale));
    CinemachineRecomposer.NativeFieldInfoPtr_m_FollowAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_FollowAttachment));
    CinemachineRecomposer.NativeFieldInfoPtr_m_LookAtAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, nameof (m_LookAtAttachment));
    CinemachineRecomposer.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, 100663299 /*0x06000003*/);
    CinemachineRecomposer.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, 100663300 /*0x06000004*/);
    CinemachineRecomposer.NativeMethodInfoPtr_PrePipelineMutateCameraStateCallback_Public_Virtual_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, 100663301 /*0x06000005*/);
    CinemachineRecomposer.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, 100663302 /*0x06000006*/);
    CinemachineRecomposer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr, 100663303 /*0x06000007*/);
  }

  [CallerCount(0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineRecomposer.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936551, XrefRangeEnd = 936552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineRecomposer.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void PrePipelineMutateCameraStateCallback(
    CinemachineVirtualCameraBase vcam,
    ref CameraState curState,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineRecomposer.NativeMethodInfoPtr_PrePipelineMutateCameraStateCallback_Public_Virtual_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936552, XrefRangeEnd = 936561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stage;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineRecomposer.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineRecomposer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineRecomposer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineRecomposer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineCore.Stage m_ApplyAfter
  {
    get
    {
      return *(CinemachineCore.Stage*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_ApplyAfter));
    }
    [param: In] set
    {
      *(CinemachineCore.Stage*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_ApplyAfter)) = value;
    }
  }

  public unsafe float m_Tilt
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_Tilt));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_Tilt)) = value;
    }
  }

  public unsafe float m_Pan
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_Pan));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_Pan)) = value;
    }
  }

  public unsafe float m_Dutch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_Dutch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_Dutch)) = value;
    }
  }

  public unsafe float m_ZoomScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_ZoomScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_ZoomScale)) = value;
    }
  }

  public unsafe float m_FollowAttachment
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_FollowAttachment));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_FollowAttachment)) = value;
    }
  }

  public unsafe float m_LookAtAttachment
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_LookAtAttachment));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineRecomposer.NativeFieldInfoPtr_m_LookAtAttachment)) = value;
    }
  }
}
