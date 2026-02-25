// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.FlyingDroneAIController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Vehicles;

public class FlyingDroneAIController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_gunshotReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_gunshotCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_gunshotDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_muzzleReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_gunshotSoundEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_searchLightTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_searchlight;
  private static readonly System.IntPtr NativeFieldInfoPtr_controlTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_headRotate;
  private static readonly System.IntPtr NativeFieldInfoPtr_spotLight;
  private static readonly System.IntPtr NativeFieldInfoPtr_spotlightQuad;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathState;
  private static readonly System.IntPtr NativeFieldInfoPtr_DetectedAimVerticalOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_DetectedAimSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_DetectedMoveFriction;
  private static readonly System.IntPtr NativeFieldInfoPtr_DetectedTimeBeforeShoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_distractionTotalTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_distractedSoundEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_vehicleController;
  private static readonly System.IntPtr NativeFieldInfoPtr_patrolTrack;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerStateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerAnimationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_detectedState;
  private static readonly System.IntPtr NativeFieldInfoPtr_transitionState;
  private static readonly System.IntPtr NativeFieldInfoPtr_distractedState;
  private static readonly System.IntPtr NativeFieldInfoPtr_detectionVelocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_transitionTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_distractionTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialSpotlightIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_distractionTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_distractedSoundEventInstance;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetControlTimeline_Public_Void_PlayableDirector_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Distract_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateHeadDown_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateHeadUp_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindTrack_Private_TrackAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MuteTrack_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnmuteTrack_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RebuildPlayable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForSearchlight_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextSegment_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlyingDroneAIController()
  {
    Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (FlyingDroneAIController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr);
    FlyingDroneAIController.NativeFieldInfoPtr_gunshotReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (gunshotReference));
    FlyingDroneAIController.NativeFieldInfoPtr_gunshotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (gunshotCount));
    FlyingDroneAIController.NativeFieldInfoPtr_gunshotDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (gunshotDelay));
    FlyingDroneAIController.NativeFieldInfoPtr_muzzleReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (muzzleReference));
    FlyingDroneAIController.NativeFieldInfoPtr_gunshotSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (gunshotSoundEvent));
    FlyingDroneAIController.NativeFieldInfoPtr_searchLightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (searchLightTrigger));
    FlyingDroneAIController.NativeFieldInfoPtr_searchlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (searchlight));
    FlyingDroneAIController.NativeFieldInfoPtr_controlTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (controlTimeline));
    FlyingDroneAIController.NativeFieldInfoPtr_headRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (headRotate));
    FlyingDroneAIController.NativeFieldInfoPtr_spotLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (spotLight));
    FlyingDroneAIController.NativeFieldInfoPtr_spotlightQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (spotlightQuad));
    FlyingDroneAIController.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (playerReference));
    FlyingDroneAIController.NativeFieldInfoPtr_deathState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (deathState));
    FlyingDroneAIController.NativeFieldInfoPtr_DetectedAimVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (DetectedAimVerticalOffset));
    FlyingDroneAIController.NativeFieldInfoPtr_DetectedAimSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (DetectedAimSpeed));
    FlyingDroneAIController.NativeFieldInfoPtr_DetectedMoveFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (DetectedMoveFriction));
    FlyingDroneAIController.NativeFieldInfoPtr_DetectedTimeBeforeShoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (DetectedTimeBeforeShoot));
    FlyingDroneAIController.NativeFieldInfoPtr_distractionTotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (distractionTotalTime));
    FlyingDroneAIController.NativeFieldInfoPtr_distractedSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (distractedSoundEvent));
    FlyingDroneAIController.NativeFieldInfoPtr_vehicleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (vehicleController));
    FlyingDroneAIController.NativeFieldInfoPtr_patrolTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (patrolTrack));
    FlyingDroneAIController.NativeFieldInfoPtr_playerStateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (playerStateController));
    FlyingDroneAIController.NativeFieldInfoPtr_playerAnimationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (playerAnimationController));
    FlyingDroneAIController.NativeFieldInfoPtr_detectedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (detectedState));
    FlyingDroneAIController.NativeFieldInfoPtr_transitionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (transitionState));
    FlyingDroneAIController.NativeFieldInfoPtr_distractedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (distractedState));
    FlyingDroneAIController.NativeFieldInfoPtr_detectionVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (detectionVelocity));
    FlyingDroneAIController.NativeFieldInfoPtr_transitionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (transitionTarget));
    FlyingDroneAIController.NativeFieldInfoPtr_distractionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (distractionTarget));
    FlyingDroneAIController.NativeFieldInfoPtr_initialSpotlightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (initialSpotlightIntensity));
    FlyingDroneAIController.NativeFieldInfoPtr_distractionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (distractionTimer));
    FlyingDroneAIController.NativeFieldInfoPtr_distractedSoundEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, nameof (distractedSoundEventInstance));
    FlyingDroneAIController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673012);
    FlyingDroneAIController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673013);
    FlyingDroneAIController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673014);
    FlyingDroneAIController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673015);
    FlyingDroneAIController.NativeMethodInfoPtr_SetControlTimeline_Public_Void_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673016);
    FlyingDroneAIController.NativeMethodInfoPtr_Distract_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673017);
    FlyingDroneAIController.NativeMethodInfoPtr_RotateHeadDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673018);
    FlyingDroneAIController.NativeMethodInfoPtr_RotateHeadUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673019);
    FlyingDroneAIController.NativeMethodInfoPtr_FindTrack_Private_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673020);
    FlyingDroneAIController.NativeMethodInfoPtr_MuteTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673021);
    FlyingDroneAIController.NativeMethodInfoPtr_UnmuteTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673022);
    FlyingDroneAIController.NativeMethodInfoPtr_RebuildPlayable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673023);
    FlyingDroneAIController.NativeMethodInfoPtr_Shoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673024 /*0x06002600*/);
    FlyingDroneAIController.NativeMethodInfoPtr_WaitForSearchlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673025);
    FlyingDroneAIController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673026);
    FlyingDroneAIController.NativeMethodInfoPtr_NextSegment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673027);
    FlyingDroneAIController.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673028);
    FlyingDroneAIController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, 100673029);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105575, XrefRangeEnd = 105586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105586, XrefRangeEnd = 105592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105592, XrefRangeEnd = 105594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105594, XrefRangeEnd = 105622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105622, XrefRangeEnd = 105623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetControlTimeline(PlayableDirector timeline)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) timeline)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_SetControlTimeline_Public_Void_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105623, XrefRangeEnd = 105630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Distract(Vector3 targetPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetPosition
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_Distract_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105630, XrefRangeEnd = 105635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RotateHeadDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_RotateHeadDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105635, XrefRangeEnd = 105640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RotateHeadUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_RotateHeadUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 105666, RefRangeEnd = 105668, XrefRangeStart = 105640, XrefRangeEnd = 105666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TrackAsset FindTrack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_FindTrack_Private_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (TrackAsset) null : Il2CppObjectPool.Get<TrackAsset>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105668, XrefRangeEnd = 105672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MuteTrack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_MuteTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105672, XrefRangeEnd = 105680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnmuteTrack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_UnmuteTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 105687, RefRangeEnd = 105691, XrefRangeStart = 105680, XrefRangeEnd = 105687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RebuildPlayable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_RebuildPlayable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105702, RefRangeEnd = 105703, XrefRangeStart = 105691, XrefRangeEnd = 105702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shoot()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_Shoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105703, XrefRangeEnd = 105707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void WaitForSearchlight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_WaitForSearchlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105707, XrefRangeEnd = 105713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105713, XrefRangeEnd = 105767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextSegment()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_NextSegment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105767, XrefRangeEnd = 105774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnNotify(Playable origin, INotification notification, Il2CppSystem.Object context)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105774, XrefRangeEnd = 105775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlyingDroneAIController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AssetReference gunshotReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotReference));
      return num == System.IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int gunshotCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotCount)) = value;
    }
  }

  public unsafe float gunshotDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotDelay)) = value;
    }
  }

  public unsafe AssetReference muzzleReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_muzzleReference));
      return num == System.IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_muzzleReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference gunshotSoundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotSoundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_gunshotSoundEvent)) = value;
    }
  }

  public unsafe SearchLightTrigger searchLightTrigger
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_searchLightTrigger));
      return num == System.IntPtr.Zero ? (SearchLightTrigger) null : Il2CppObjectPool.Get<SearchLightTrigger>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_searchLightTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform searchlight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_searchlight));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_searchlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector controlTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_controlTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_controlTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform headRotate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_headRotate));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_headRotate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Light spotLight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_spotLight));
      return num == System.IntPtr.Zero ? (Light) null : Il2CppObjectPool.Get<Light>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_spotLight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform spotlightQuad
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_spotlightQuad));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_spotlightQuad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State deathState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_deathState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_deathState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float DetectedAimVerticalOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedAimVerticalOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedAimVerticalOffset)) = value;
    }
  }

  public unsafe float DetectedAimSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedAimSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedAimSpeed)) = value;
    }
  }

  public unsafe float DetectedMoveFriction
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedMoveFriction));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedMoveFriction)) = value;
    }
  }

  public unsafe float DetectedTimeBeforeShoot
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedTimeBeforeShoot));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_DetectedTimeBeforeShoot)) = value;
    }
  }

  public unsafe float distractionTotalTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractionTotalTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractionTotalTime)) = value;
    }
  }

  public unsafe EventReference distractedSoundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractedSoundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractedSoundEvent)) = value;
    }
  }

  public unsafe FlyingVehicleController vehicleController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_vehicleController));
      return num == System.IntPtr.Zero ? (FlyingVehicleController) null : Il2CppObjectPool.Get<FlyingVehicleController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_vehicleController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TrackAsset patrolTrack
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_patrolTrack));
      return num == System.IntPtr.Zero ? (TrackAsset) null : Il2CppObjectPool.Get<TrackAsset>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_patrolTrack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController playerStateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_playerStateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_playerStateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController playerAnimationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_playerAnimationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_playerAnimationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool detectedState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_detectedState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_detectedState)) = value;
    }
  }

  public unsafe bool transitionState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_transitionState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_transitionState)) = value;
    }
  }

  public unsafe bool distractedState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractedState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractedState)) = value;
    }
  }

  public unsafe Vector3 detectionVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_detectionVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_detectionVelocity)) = value;
    }
  }

  public unsafe Vector3 transitionTarget
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_transitionTarget));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_transitionTarget)) = value;
    }
  }

  public unsafe Vector3 distractionTarget
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractionTarget));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractionTarget)) = value;
    }
  }

  public unsafe float initialSpotlightIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_initialSpotlightIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_initialSpotlightIntensity)) = value;
    }
  }

  public unsafe float distractionTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractionTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractionTimer)) = value;
    }
  }

  public unsafe EventInstance distractedSoundEventInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractedSoundEventInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController.NativeFieldInfoPtr_distractedSoundEventInstance)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Vehicles.FlyingDroneAIController+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__47_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__NextSegment_b__47_0_Internal_Double_TimelineClip_0;

    static __c()
    {
      Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr);
      FlyingDroneAIController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr, "<>9");
      FlyingDroneAIController.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr, "<>9__47_0");
      FlyingDroneAIController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr, 100673031);
      FlyingDroneAIController.__c.NativeMethodInfoPtr__NextSegment_b__47_0_Internal_Double_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr, 100673032);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyingDroneAIController.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe double _NextSegment_b__47_0(TimelineClip clip)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController.__c.NativeMethodInfoPtr__NextSegment_b__47_0_Internal_Double_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe FlyingDroneAIController.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(FlyingDroneAIController.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (FlyingDroneAIController.__c) null : Il2CppObjectPool.Get<FlyingDroneAIController.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlyingDroneAIController.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<TimelineClip, double> __9__47_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(FlyingDroneAIController.__c.NativeFieldInfoPtr___9__47_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<TimelineClip, double>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<TimelineClip, double>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlyingDroneAIController.__c.NativeFieldInfoPtr___9__47_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Vehicles.FlyingDroneAIController+<WaitForSearchlight>d__45")]
  public sealed class _WaitForSearchlight_d__45 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _WaitForSearchlight_d__45()
    {
      Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyingDroneAIController>.NativeClassPtr, "<WaitForSearchlight>d__45");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr);
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, "<>1__state");
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, "<>t__builder");
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, "<>4__this");
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, "<>u__1");
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, "<i>5__2");
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, 100673033);
      FlyingDroneAIController._WaitForSearchlight_d__45.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr, 100673034);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105508, XrefRangeEnd = 105575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController._WaitForSearchlight_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlyingDroneAIController._WaitForSearchlight_d__45.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _WaitForSearchlight_d__45(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _WaitForSearchlight_d__45()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyingDroneAIController._WaitForSearchlight_d__45>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlyingDroneAIController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlyingDroneAIController) null : Il2CppObjectPool.Get<FlyingDroneAIController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _i_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr__i_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyingDroneAIController._WaitForSearchlight_d__45.NativeFieldInfoPtr__i_5__2)) = value;
      }
    }
  }
}
