// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterCameraTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Animation;
using SadCatStudios.CameraMovement.Configs;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterCameraTarget(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraTargetReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_vertOffsetMult;
  private static readonly System.IntPtr NativeFieldInfoPtr_lerpSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_lerpSpeedInLockedStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_lockedStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathState;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundariesController;
  private static readonly System.IntPtr NativeFieldInfoPtr_body;
  private static readonly System.IntPtr NativeFieldInfoPtr_center;
  private static readonly System.IntPtr NativeFieldInfoPtr_vertSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_currLerpSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_lockTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_lockStateTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_pivotTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetRestriction;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_offsetConfig;
  private static readonly System.IntPtr NativeFieldInfoPtr_currOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_offsetVelocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_currDutch;
  private static readonly System.IntPtr NativeFieldInfoPtr_dutchVelocity;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameUpdated_Private_Void_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStateChaged_Private_Void_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetOffset_Public_Void_CameraTargetOffsetConfig_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetOffset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLock_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetRestriction_Public_Void_TargetRestriction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveImmediately_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallToMyself_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DutchUpdate_Private_Void_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OffsetUpdate_Private_IEnumerator_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterCameraTarget()
  {
    Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterCameraTarget));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr);
    CharacterCameraTarget.NativeFieldInfoPtr_cameraTargetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (cameraTargetReference));
    CharacterCameraTarget.NativeFieldInfoPtr_vertOffsetMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (vertOffsetMult));
    CharacterCameraTarget.NativeFieldInfoPtr_lerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (lerpSpeed));
    CharacterCameraTarget.NativeFieldInfoPtr_lerpSpeedInLockedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (lerpSpeedInLockedStates));
    CharacterCameraTarget.NativeFieldInfoPtr_lockedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (lockedStates));
    CharacterCameraTarget.NativeFieldInfoPtr_deathState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (deathState));
    CharacterCameraTarget.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (stateController));
    CharacterCameraTarget.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (animationController));
    CharacterCameraTarget.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (rotationController));
    CharacterCameraTarget.NativeFieldInfoPtr_boundariesController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (boundariesController));
    CharacterCameraTarget.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (body));
    CharacterCameraTarget.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (center));
    CharacterCameraTarget.NativeFieldInfoPtr_vertSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (vertSize));
    CharacterCameraTarget.NativeFieldInfoPtr_currLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (currLerpSpeed));
    CharacterCameraTarget.NativeFieldInfoPtr_lockTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (lockTarget));
    CharacterCameraTarget.NativeFieldInfoPtr_lockStateTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (lockStateTarget));
    CharacterCameraTarget.NativeFieldInfoPtr_pivotTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (pivotTarget));
    CharacterCameraTarget.NativeFieldInfoPtr_targetRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (targetRestriction));
    CharacterCameraTarget.NativeFieldInfoPtr_lastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (lastTarget));
    CharacterCameraTarget.NativeFieldInfoPtr_cameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (cameraTarget));
    CharacterCameraTarget.NativeFieldInfoPtr_offsetConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (offsetConfig));
    CharacterCameraTarget.NativeFieldInfoPtr_currOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (currOffset));
    CharacterCameraTarget.NativeFieldInfoPtr_offsetVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (offsetVelocity));
    CharacterCameraTarget.NativeFieldInfoPtr_currDutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (currDutch));
    CharacterCameraTarget.NativeFieldInfoPtr_dutchVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, nameof (dutchVelocity));
    CharacterCameraTarget.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674901);
    CharacterCameraTarget.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674902);
    CharacterCameraTarget.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674903);
    CharacterCameraTarget.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674904);
    CharacterCameraTarget.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674905);
    CharacterCameraTarget.NativeMethodInfoPtr_FrameUpdated_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674906);
    CharacterCameraTarget.NativeMethodInfoPtr_OnStateChaged_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674907);
    CharacterCameraTarget.NativeMethodInfoPtr_SetOffset_Public_Void_CameraTargetOffsetConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674908);
    CharacterCameraTarget.NativeMethodInfoPtr_ResetOffset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674909);
    CharacterCameraTarget.NativeMethodInfoPtr_SetLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674910);
    CharacterCameraTarget.NativeMethodInfoPtr_SetTargetRestriction_Public_Void_TargetRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674911);
    CharacterCameraTarget.NativeMethodInfoPtr_MoveImmediately_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674912);
    CharacterCameraTarget.NativeMethodInfoPtr_CallToMyself_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674913);
    CharacterCameraTarget.NativeMethodInfoPtr_DutchUpdate_Private_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674914);
    CharacterCameraTarget.NativeMethodInfoPtr_OffsetUpdate_Private_IEnumerator_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674915);
    CharacterCameraTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, 100674916);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114095, XrefRangeEnd = 114107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114107, XrefRangeEnd = 114113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114113, XrefRangeEnd = 114137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114137, XrefRangeEnd = 114161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114161, XrefRangeEnd = 114183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void FrameUpdated(MeshClipFrame currentFrame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentFrame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_FrameUpdated_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114183, XrefRangeEnd = 114186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnStateChaged(SadCatStudios.FSM.State state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_OnStateChaged_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114186, XrefRangeEnd = 114193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetOffset(CameraTargetOffsetConfig offsetConfig)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) offsetConfig)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_SetOffset_Public_Void_CameraTargetOffsetConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114193, XrefRangeEnd = 114201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetOffset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_ResetOffset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetLock(bool lockTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &lockTarget
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_SetLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetTargetRestriction(
    CharacterCameraTarget.TargetRestriction targetRestriction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetRestriction
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_SetTargetRestriction_Public_Void_TargetRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114211, RefRangeEnd = 114212, XrefRangeStart = 114201, XrefRangeEnd = 114211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveImmediately()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_MoveImmediately_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114212, XrefRangeEnd = 114222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallToMyself()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_CallToMyself_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114231, RefRangeEnd = 114232, XrefRangeStart = 114222, XrefRangeEnd = 114231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DutchUpdate(Vector3 offsetTarget, float dutchTarget, float offsetSmoothTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &offsetTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dutchTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetSmoothTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_DutchUpdate_Private_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114232, XrefRangeEnd = 114236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator OffsetUpdate(
    Vector3 offsetTarget,
    float dutchTarget,
    float offsetSmoothTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &offsetTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dutchTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetSmoothTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr_OffsetUpdate_Private_IEnumerator_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114236, XrefRangeEnd = 114237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterCameraTarget()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference cameraTargetReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_cameraTargetReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_cameraTargetReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float vertOffsetMult
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_vertOffsetMult));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_vertOffsetMult)) = value;
    }
  }

  public unsafe float lerpSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lerpSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lerpSpeed)) = value;
    }
  }

  public unsafe float lerpSpeedInLockedStates
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lerpSpeedInLockedStates));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lerpSpeedInLockedStates)) = value;
    }
  }

  public unsafe List<SadCatStudios.FSM.State> lockedStates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lockedStates));
      return num == System.IntPtr.Zero ? (List<SadCatStudios.FSM.State>) null : Il2CppObjectPool.Get<List<SadCatStudios.FSM.State>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lockedStates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State deathState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_deathState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_deathState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterBoundariesController boundariesController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_boundariesController));
      return num == System.IntPtr.Zero ? (CharacterBoundariesController) null : Il2CppObjectPool.Get<CharacterBoundariesController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_boundariesController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody body
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_body));
      return num == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 center
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_center));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_center)) = value;
    }
  }

  public unsafe float vertSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_vertSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_vertSize)) = value;
    }
  }

  public unsafe float currLerpSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_currLerpSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_currLerpSpeed)) = value;
    }
  }

  public unsafe bool lockTarget
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lockTarget));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lockTarget)) = value;
    }
  }

  public unsafe bool lockStateTarget
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lockStateTarget));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lockStateTarget)) = value;
    }
  }

  public unsafe bool pivotTarget
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_pivotTarget));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_pivotTarget)) = value;
    }
  }

  public unsafe CharacterCameraTarget.TargetRestriction targetRestriction
  {
    get
    {
      return *(CharacterCameraTarget.TargetRestriction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_targetRestriction));
    }
    [param: In] set
    {
      *(CharacterCameraTarget.TargetRestriction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_targetRestriction)) = value;
    }
  }

  public unsafe Vector3 lastTarget
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lastTarget));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_lastTarget)) = value;
    }
  }

  public unsafe Transform cameraTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_cameraTarget));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_cameraTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CameraTargetOffsetConfig offsetConfig
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_offsetConfig));
      return num == System.IntPtr.Zero ? (CameraTargetOffsetConfig) null : Il2CppObjectPool.Get<CameraTargetOffsetConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_offsetConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 currOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_currOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_currOffset)) = value;
    }
  }

  public unsafe Vector3 offsetVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_offsetVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_offsetVelocity)) = value;
    }
  }

  public unsafe float currDutch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_currDutch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_currDutch)) = value;
    }
  }

  public unsafe float dutchVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_dutchVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget.NativeFieldInfoPtr_dutchVelocity)) = value;
    }
  }

  public enum TargetRestriction
  {
    None,
    Left,
    Right,
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterCameraTarget+<OffsetUpdate>d__40")]
  public sealed class _OffsetUpdate_d__40(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_dutchTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_offsetTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_offsetSmoothTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _OffsetUpdate_d__40()
    {
      Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCameraTarget>.NativeClassPtr, "<OffsetUpdate>d__40");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr);
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, "<>1__state");
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, "<>2__current");
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, "<>4__this");
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_dutchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, nameof (dutchTarget));
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_offsetTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, nameof (offsetTarget));
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_offsetSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, nameof (offsetSmoothTime));
      CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr__target_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, "<target>5__2");
      CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, 100674917);
      CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, 100674918);
      CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, 100674919);
      CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, 100674920);
      CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, 100674921);
      CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr, 100674922);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _OffsetUpdate_d__40(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCameraTarget._OffsetUpdate_d__40>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114085, XrefRangeEnd = 114090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114090, XrefRangeEnd = 114095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterCameraTarget._OffsetUpdate_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterCameraTarget __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterCameraTarget) null : Il2CppObjectPool.Get<CharacterCameraTarget>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float dutchTarget
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_dutchTarget));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_dutchTarget)) = value;
      }
    }

    public unsafe Vector3 offsetTarget
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_offsetTarget));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_offsetTarget)) = value;
      }
    }

    public unsafe float offsetSmoothTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_offsetSmoothTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr_offsetSmoothTime)) = value;
      }
    }

    public unsafe float _target_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr__target_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCameraTarget._OffsetUpdate_d__40.NativeFieldInfoPtr__target_5__2)) = value;
      }
    }
  }
}
