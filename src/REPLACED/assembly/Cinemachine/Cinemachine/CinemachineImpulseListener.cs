// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineImpulseListener
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineImpulseListener(System.IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApplyAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ChannelMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Gain;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Use2DDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UseCameraSpace;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReactionSettings;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineImpulseListener()
  {
    Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineImpulseListener));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr);
    CinemachineImpulseListener.NativeFieldInfoPtr_m_ApplyAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (m_ApplyAfter));
    CinemachineImpulseListener.NativeFieldInfoPtr_m_ChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (m_ChannelMask));
    CinemachineImpulseListener.NativeFieldInfoPtr_m_Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (m_Gain));
    CinemachineImpulseListener.NativeFieldInfoPtr_m_Use2DDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (m_Use2DDistance));
    CinemachineImpulseListener.NativeFieldInfoPtr_m_UseCameraSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (m_UseCameraSpace));
    CinemachineImpulseListener.NativeFieldInfoPtr_m_ReactionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (m_ReactionSettings));
    CinemachineImpulseListener.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, 100664266);
    CinemachineImpulseListener.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, 100664267);
    CinemachineImpulseListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, 100664268);
  }

  [CallerCount(0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseListener.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945620, XrefRangeEnd = 945631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineImpulseListener.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945631, XrefRangeEnd = 945632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseListener()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineCore.Stage m_ApplyAfter
  {
    get
    {
      return *(CinemachineCore.Stage*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_ApplyAfter));
    }
    [param: In] set
    {
      *(CinemachineCore.Stage*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_ApplyAfter)) = value;
    }
  }

  public unsafe int m_ChannelMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_ChannelMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_ChannelMask)) = value;
    }
  }

  public unsafe float m_Gain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_Gain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_Gain)) = value;
    }
  }

  public unsafe bool m_Use2DDistance
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_Use2DDistance));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_Use2DDistance)) = value;
    }
  }

  public unsafe bool m_UseCameraSpace
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_UseCameraSpace));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_UseCameraSpace)) = value;
    }
  }

  public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_ReactionSettings);
      return new CinemachineImpulseListener.ImpulseReaction(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.NativeFieldInfoPtr_m_ReactionSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  [Serializable]
  public sealed class ImpulseReaction : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SecondaryNoise;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AmplitudeGain;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FrequencyGain;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentDamping;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NoiseOffsets;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReSeed_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetReaction_Public_Boolean_Single_Vector3_byref_Vector3_byref_Quaternion_0;

    static ImpulseReaction()
    {
      Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineImpulseListener>.NativeClassPtr, nameof (ImpulseReaction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr);
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_SecondaryNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_SecondaryNoise));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_AmplitudeGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_AmplitudeGain));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_FrequencyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_FrequencyGain));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_Duration));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_CurrentAmount));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_CurrentTime));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_CurrentDamping));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_Initialized));
      CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_NoiseOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, nameof (m_NoiseOffsets));
      CinemachineImpulseListener.ImpulseReaction.NativeMethodInfoPtr_ReSeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, 100664269);
      CinemachineImpulseListener.ImpulseReaction.NativeMethodInfoPtr_GetReaction_Public_Boolean_Single_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, 100664270);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945586, RefRangeEnd = 945587, XrefRangeStart = 945583, XrefRangeEnd = 945586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReSeed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseListener.ImpulseReaction.NativeMethodInfoPtr_ReSeed_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 945618, RefRangeEnd = 945620, XrefRangeStart = 945587, XrefRangeEnd = 945618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetReaction(
      float deltaTime,
      Vector3 impulsePos,
      out Vector3 pos,
      out Quaternion rot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &impulsePos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rot;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseListener.ImpulseReaction.NativeMethodInfoPtr_GetReaction_Public_Boolean_Single_Vector3_byref_Vector3_byref_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public ImpulseReaction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ImpulseReaction()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr))
    {
    }

    public unsafe NoiseSettings m_SecondaryNoise
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_SecondaryNoise));
        return num == System.IntPtr.Zero ? (NoiseSettings) null : Il2CppObjectPool.Get<NoiseSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_SecondaryNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float m_AmplitudeGain
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_AmplitudeGain));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_AmplitudeGain)) = value;
      }
    }

    public unsafe float m_FrequencyGain
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_FrequencyGain));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_FrequencyGain)) = value;
      }
    }

    public unsafe float m_Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_Duration)) = value;
      }
    }

    public unsafe float m_CurrentAmount
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentAmount));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentAmount)) = value;
      }
    }

    public unsafe float m_CurrentTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentTime)) = value;
      }
    }

    public unsafe float m_CurrentDamping
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentDamping));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_CurrentDamping)) = value;
      }
    }

    public unsafe bool m_Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_Initialized)) = value;
      }
    }

    public unsafe Vector3 m_NoiseOffsets
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_NoiseOffsets));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseListener.ImpulseReaction.NativeFieldInfoPtr_m_NoiseOffsets)) = value;
      }
    }
  }
}
