// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineNoiseExtensionConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CinemachineNoiseExtensionConfig(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerState;
  private static readonly IntPtr NativeFieldInfoPtr_cameraDistanceDelta;
  private static readonly IntPtr NativeFieldInfoPtr_blendingOffsetCurve;
  private static readonly IntPtr NativeFieldInfoPtr_noiseAmplitudeDelta;
  private static readonly IntPtr NativeFieldInfoPtr_noiseFrequencyDelta;
  private static readonly IntPtr NativeFieldInfoPtr_easingTime;
  private static readonly IntPtr NativeFieldInfoPtr_noiseSmoothBackTime;
  private static readonly IntPtr NativeFieldInfoPtr_blendingNoiseCurve;
  private static readonly IntPtr NativeFieldInfoPtr_dampingEasingTime;
  private static readonly IntPtr NativeFieldInfoPtr_blendingDampingCurve;
  private static readonly IntPtr NativeFieldInfoPtr_dampingReverseEasingTime;
  private static readonly IntPtr NativeFieldInfoPtr_blendingDampingCurveReverse;
  private static readonly IntPtr NativeFieldInfoPtr_enableBodyXDamping;
  private static readonly IntPtr NativeFieldInfoPtr_enableBodyYDamping;
  private static readonly IntPtr NativeFieldInfoPtr_enableBodyZDamping;
  private static readonly IntPtr NativeFieldInfoPtr_bodyXDamping;
  private static readonly IntPtr NativeFieldInfoPtr_bodyYDamping;
  private static readonly IntPtr NativeFieldInfoPtr_bodyZDamping;
  private static readonly IntPtr NativeFieldInfoPtr_enableAimHorizontalDamping;
  private static readonly IntPtr NativeFieldInfoPtr_enableAimVerticalDamping;
  private static readonly IntPtr NativeFieldInfoPtr_aimHorizontalDamping;
  private static readonly IntPtr NativeFieldInfoPtr_aimVerticalDamping;
  private static readonly IntPtr NativeFieldInfoPtr_additionalAmplitude;
  private static readonly IntPtr NativeFieldInfoPtr_additionalFrequency;
  private static readonly IntPtr NativeMethodInfoPtr_get_PlayerState_Public_get_State_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CameraDistanceDelta_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BlendingOffsetCurve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NoiseAmplitudeDelta_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NoiseFrequencyDelta_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EasingTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DampingEasingTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DampingReverseEasingTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NoiseSmoothBackTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BlendingNoiseCurve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BlendingDampingCurve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BlendingDampingCurveReverse_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AimHorizontalDamping_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnableBodyXDamping_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AimVerticalDamping_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnableBodyYDamping_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnableBodyZDamping_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BodyXDamping_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BodyYDamping_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BodyZDamping_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnableAimHorizontalDamping_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnableAimVerticalDamping_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalAmplitude_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalFrequency_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineNoiseExtensionConfig()
  {
    Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineNoiseExtensionConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr);
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_playerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (playerState));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_cameraDistanceDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (cameraDistanceDelta));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingOffsetCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (blendingOffsetCurve));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseAmplitudeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (noiseAmplitudeDelta));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseFrequencyDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (noiseFrequencyDelta));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_easingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (easingTime));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseSmoothBackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (noiseSmoothBackTime));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingNoiseCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (blendingNoiseCurve));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_dampingEasingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (dampingEasingTime));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingDampingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (blendingDampingCurve));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_dampingReverseEasingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (dampingReverseEasingTime));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingDampingCurveReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (blendingDampingCurveReverse));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyXDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (enableBodyXDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyYDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (enableBodyYDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyZDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (enableBodyZDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyXDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (bodyXDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyYDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (bodyYDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyZDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (bodyZDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableAimHorizontalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (enableAimHorizontalDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableAimVerticalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (enableAimVerticalDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_aimHorizontalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (aimHorizontalDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_aimVerticalDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (aimVerticalDamping));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_additionalAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (additionalAmplitude));
    CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_additionalFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, nameof (additionalFrequency));
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_PlayerState_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676364);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_CameraDistanceDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676365);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingOffsetCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676366);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_NoiseAmplitudeDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676367);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_NoiseFrequencyDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676368);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EasingTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676369);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_DampingEasingTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676370);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_DampingReverseEasingTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676371);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_NoiseSmoothBackTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676372);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingNoiseCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676373);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingDampingCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676374);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingDampingCurveReverse_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676375);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AimHorizontalDamping_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676376);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableBodyXDamping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676377);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AimVerticalDamping_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676378);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableBodyYDamping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676379);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableBodyZDamping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676380);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BodyXDamping_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676381);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BodyYDamping_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676382);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BodyZDamping_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676383);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableAimHorizontalDamping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676384);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableAimVerticalDamping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676385);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AdditionalAmplitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676386);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AdditionalFrequency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676387);
    CinemachineNoiseExtensionConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr, 100676388);
  }

  public unsafe SadCatStudios.FSM.State PlayerState
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_PlayerState_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num3);
    }
  }

  public unsafe float CameraDistanceDelta
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_CameraDistanceDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AnimationCurve BlendingOffsetCurve
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingOffsetCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe float NoiseAmplitudeDelta
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_NoiseAmplitudeDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float NoiseFrequencyDelta
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_NoiseFrequencyDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float EasingTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EasingTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float DampingEasingTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_DampingEasingTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float DampingReverseEasingTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_DampingReverseEasingTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float NoiseSmoothBackTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_NoiseSmoothBackTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AnimationCurve BlendingNoiseCurve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingNoiseCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe AnimationCurve BlendingDampingCurve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingDampingCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe AnimationCurve BlendingDampingCurveReverse
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BlendingDampingCurveReverse_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe float AimHorizontalDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AimHorizontalDamping_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool EnableBodyXDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableBodyXDamping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AimVerticalDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AimVerticalDamping_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool EnableBodyYDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableBodyYDamping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool EnableBodyZDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableBodyZDamping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float BodyXDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BodyXDamping_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float BodyYDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BodyYDamping_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float BodyZDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_BodyZDamping_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool EnableAimHorizontalDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableAimHorizontalDamping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool EnableAimVerticalDamping
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_EnableAimVerticalDamping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AdditionalAmplitude
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AdditionalAmplitude_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AdditionalFrequency
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr_get_AdditionalFrequency_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123141, XrefRangeEnd = 123142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineNoiseExtensionConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineNoiseExtensionConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineNoiseExtensionConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SadCatStudios.FSM.State playerState
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_playerState));
      return num == IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_playerState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float cameraDistanceDelta
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_cameraDistanceDelta));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_cameraDistanceDelta)) = value;
    }
  }

  public unsafe AnimationCurve blendingOffsetCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingOffsetCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingOffsetCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float noiseAmplitudeDelta
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseAmplitudeDelta));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseAmplitudeDelta)) = value;
    }
  }

  public unsafe float noiseFrequencyDelta
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseFrequencyDelta));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseFrequencyDelta)) = value;
    }
  }

  public unsafe float easingTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_easingTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_easingTime)) = value;
    }
  }

  public unsafe float noiseSmoothBackTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseSmoothBackTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_noiseSmoothBackTime)) = value;
    }
  }

  public unsafe AnimationCurve blendingNoiseCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingNoiseCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingNoiseCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float dampingEasingTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_dampingEasingTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_dampingEasingTime)) = value;
    }
  }

  public unsafe AnimationCurve blendingDampingCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingDampingCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingDampingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float dampingReverseEasingTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_dampingReverseEasingTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_dampingReverseEasingTime)) = value;
    }
  }

  public unsafe AnimationCurve blendingDampingCurveReverse
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingDampingCurveReverse));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_blendingDampingCurveReverse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool enableBodyXDamping
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyXDamping));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyXDamping)) = value;
    }
  }

  public unsafe bool enableBodyYDamping
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyYDamping));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyYDamping)) = value;
    }
  }

  public unsafe bool enableBodyZDamping
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyZDamping));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableBodyZDamping)) = value;
    }
  }

  public unsafe float bodyXDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyXDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyXDamping)) = value;
    }
  }

  public unsafe float bodyYDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyYDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyYDamping)) = value;
    }
  }

  public unsafe float bodyZDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyZDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_bodyZDamping)) = value;
    }
  }

  public unsafe bool enableAimHorizontalDamping
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableAimHorizontalDamping));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableAimHorizontalDamping)) = value;
    }
  }

  public unsafe bool enableAimVerticalDamping
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableAimVerticalDamping));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_enableAimVerticalDamping)) = value;
    }
  }

  public unsafe float aimHorizontalDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_aimHorizontalDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_aimHorizontalDamping)) = value;
    }
  }

  public unsafe float aimVerticalDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_aimVerticalDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_aimVerticalDamping)) = value;
    }
  }

  public unsafe float additionalAmplitude
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_additionalAmplitude));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_additionalAmplitude)) = value;
    }
  }

  public unsafe float additionalFrequency
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_additionalFrequency));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineNoiseExtensionConfig.NativeFieldInfoPtr_additionalFrequency)) = value;
    }
  }
}
