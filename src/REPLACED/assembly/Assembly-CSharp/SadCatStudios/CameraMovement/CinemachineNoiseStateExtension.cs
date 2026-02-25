// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineNoiseStateExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CinemachineNoiseStateExtension(IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_targetCharacterReference;
  private static readonly IntPtr NativeFieldInfoPtr_config;
  private static readonly IntPtr NativeFieldInfoPtr_dollyPathOffset;
  private static readonly IntPtr NativeFieldInfoPtr_transposer;
  private static readonly IntPtr NativeFieldInfoPtr_composer;
  private static readonly IntPtr NativeFieldInfoPtr_dolly;
  private static readonly IntPtr NativeFieldInfoPtr_noise;
  private static readonly IntPtr NativeFieldInfoPtr_playerStateController;
  private static readonly IntPtr NativeFieldInfoPtr_originalOffset;
  private static readonly IntPtr NativeFieldInfoPtr_originalXDamping;
  private static readonly IntPtr NativeFieldInfoPtr_originalYDamping;
  private static readonly IntPtr NativeFieldInfoPtr_originalZDamping;
  private static readonly IntPtr NativeFieldInfoPtr_originalHorizontalDamping;
  private static readonly IntPtr NativeFieldInfoPtr_originalVerticalDamping;
  private static readonly IntPtr NativeFieldInfoPtr_originalAmplitude;
  private static readonly IntPtr NativeFieldInfoPtr_originalFrequency;
  private static readonly IntPtr NativeFieldInfoPtr_blendingValue;
  private static readonly IntPtr NativeFieldInfoPtr_dampBlendingValue;
  private static readonly IntPtr NativeFieldInfoPtr_blendingNoiseValue;
  private static readonly IntPtr NativeFieldInfoPtr_amplitudeVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_frequencyVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_fixedEasingTime;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PrePipelineMutateCameraStateCallback_Public_Virtual_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineNoiseStateExtension()
  {
    Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineNoiseStateExtension));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr);
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_targetCharacterReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (targetCharacterReference));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (config));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_dollyPathOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (dollyPathOffset));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_transposer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (transposer));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_composer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (composer));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_dolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (dolly));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (noise));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_playerStateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (playerStateController));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalOffset));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalXDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalXDamping));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalYDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalYDamping));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalZDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalZDamping));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalHorizontalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalHorizontalDamping));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalVerticalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalVerticalDamping));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalAmplitude));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (originalFrequency));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_blendingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (blendingValue));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_dampBlendingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (dampBlendingValue));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_blendingNoiseValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (blendingNoiseValue));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_amplitudeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (amplitudeVelocity));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_frequencyVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (frequencyVelocity));
    CinemachineNoiseStateExtension.NativeFieldInfoPtr_fixedEasingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, nameof (fixedEasingTime));
    CinemachineNoiseStateExtension.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, 100676360);
    CinemachineNoiseStateExtension.NativeMethodInfoPtr_PrePipelineMutateCameraStateCallback_Public_Virtual_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, 100676361);
    CinemachineNoiseStateExtension.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, 100676362);
    CinemachineNoiseStateExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr, 100676363);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123050, XrefRangeEnd = 123083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseStateExtension.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123083, XrefRangeEnd = 123141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineNoiseStateExtension.NativeMethodInfoPtr_PrePipelineMutateCameraStateCallback_Public_Virtual_Void_CinemachineVirtualCameraBase_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineNoiseStateExtension.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineNoiseStateExtension()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineNoiseStateExtension>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseStateExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference targetCharacterReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_targetCharacterReference));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_targetCharacterReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineNoiseExtensionConfig config
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_config));
      return num == IntPtr.Zero ? (CinemachineNoiseExtensionConfig) null : Il2CppObjectPool.Get<CinemachineNoiseExtensionConfig>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineNoiseStateExtension.DollyPathOffset dollyPathOffset
  {
    get
    {
      return *(CinemachineNoiseStateExtension.DollyPathOffset*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_dollyPathOffset));
    }
    [param: In] set
    {
      *(CinemachineNoiseStateExtension.DollyPathOffset*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_dollyPathOffset)) = value;
    }
  }

  public unsafe CinemachineFramingTransposer transposer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_transposer));
      return num == IntPtr.Zero ? (CinemachineFramingTransposer) null : Il2CppObjectPool.Get<CinemachineFramingTransposer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_transposer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineComposer composer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_composer));
      return num == IntPtr.Zero ? (CinemachineComposer) null : Il2CppObjectPool.Get<CinemachineComposer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_composer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineTrackedDolly dolly
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_dolly));
      return num == IntPtr.Zero ? (CinemachineTrackedDolly) null : Il2CppObjectPool.Get<CinemachineTrackedDolly>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_dolly), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineBasicMultiChannelPerlin noise
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_noise));
      return num == IntPtr.Zero ? (CinemachineBasicMultiChannelPerlin) null : Il2CppObjectPool.Get<CinemachineBasicMultiChannelPerlin>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_noise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController playerStateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_playerStateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_playerStateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float originalOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalOffset)) = value;
    }
  }

  public unsafe float originalXDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalXDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalXDamping)) = value;
    }
  }

  public unsafe float originalYDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalYDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalYDamping)) = value;
    }
  }

  public unsafe float originalZDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalZDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalZDamping)) = value;
    }
  }

  public unsafe float originalHorizontalDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalHorizontalDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalHorizontalDamping)) = value;
    }
  }

  public unsafe float originalVerticalDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalVerticalDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalVerticalDamping)) = value;
    }
  }

  public unsafe float originalAmplitude
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalAmplitude));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalAmplitude)) = value;
    }
  }

  public unsafe float originalFrequency
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalFrequency));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_originalFrequency)) = value;
    }
  }

  public unsafe float blendingValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_blendingValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_blendingValue)) = value;
    }
  }

  public unsafe float dampBlendingValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_dampBlendingValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_dampBlendingValue)) = value;
    }
  }

  public unsafe float blendingNoiseValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_blendingNoiseValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_blendingNoiseValue)) = value;
    }
  }

  public unsafe float amplitudeVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_amplitudeVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_amplitudeVelocity)) = value;
    }
  }

  public unsafe float frequencyVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_frequencyVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_frequencyVelocity)) = value;
    }
  }

  public unsafe float fixedEasingTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_fixedEasingTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseStateExtension.NativeFieldInfoPtr_fixedEasingTime)) = value;
    }
  }

  public enum DollyPathOffset
  {
    OnlyZ,
    targetDirection,
    reverseTargetDirection,
  }
}
