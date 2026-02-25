// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.AbilityStateController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using MessagePipe;
using SadCatStudios.Animation;
using SadCatStudios.Foundation;
using SadCatStudios.Foundation.Events;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM;

public class AbilityStateController(System.IntPtr pointer) : StateController(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AvailableAbilities;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeAbilities;
  private static readonly System.IntPtr NativeFieldInfoPtr_possibleDefaultFSM;
  private static readonly System.IntPtr NativeFieldInfoPtr_abilitiesPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_ClipCalled;
  private static readonly System.IntPtr NativeFieldInfoPtr_savedData;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TopOverrideState_Public_get_StateOverride_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AbilityAvailable_Public_Boolean_Abilities_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AbilityActive_Public_Boolean_Abilities_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInOverride_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitAbilities_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchFSM_Public_Virtual_Void_FSMGraph_MeshClip_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayClip_Public_Virtual_Void_MeshClip_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueClip_Public_Virtual_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OverridedValue_Public_Single_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceAbility_Public_Void_Abilities_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAbility_Public_Void_Abilities_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnterOverrideState_Public_Void_StateOverride_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExitOverrideState_Public_Void_StateOverride_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForClipEnd_Private_IEnumerator_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AbilityStateController()
  {
    Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (AbilityStateController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr);
    AbilityStateController.NativeFieldInfoPtr_AvailableAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (AvailableAbilities));
    AbilityStateController.NativeFieldInfoPtr_overrideStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (overrideStates));
    AbilityStateController.NativeFieldInfoPtr_activeAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (activeAbilities));
    AbilityStateController.NativeFieldInfoPtr_possibleDefaultFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (possibleDefaultFSM));
    AbilityStateController.NativeFieldInfoPtr_abilitiesPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (abilitiesPublisher));
    AbilityStateController.NativeFieldInfoPtr_ClipCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (ClipCalled));
    AbilityStateController.NativeFieldInfoPtr_savedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (savedData));
    AbilityStateController.NativeMethodInfoPtr_get_TopOverrideState_Public_get_StateOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673110);
    AbilityStateController.NativeMethodInfoPtr_AbilityAvailable_Public_Boolean_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673111);
    AbilityStateController.NativeMethodInfoPtr_AbilityActive_Public_Boolean_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673112);
    AbilityStateController.NativeMethodInfoPtr_get_IsInOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673113);
    AbilityStateController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673114);
    AbilityStateController.NativeMethodInfoPtr_InitAbilities_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673115);
    AbilityStateController.NativeMethodInfoPtr_SwitchFSM_Public_Virtual_Void_FSMGraph_MeshClip_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673116);
    AbilityStateController.NativeMethodInfoPtr_PlayClip_Public_Virtual_Void_MeshClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673117);
    AbilityStateController.NativeMethodInfoPtr_ContinueClip_Public_Virtual_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673118);
    AbilityStateController.NativeMethodInfoPtr_OverridedValue_Public_Single_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673119);
    AbilityStateController.NativeMethodInfoPtr_ForceAbility_Public_Void_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673120);
    AbilityStateController.NativeMethodInfoPtr_AddAbility_Public_Void_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673121);
    AbilityStateController.NativeMethodInfoPtr_EnterOverrideState_Public_Void_StateOverride_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673122);
    AbilityStateController.NativeMethodInfoPtr_ExitOverrideState_Public_Void_StateOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673123);
    AbilityStateController.NativeMethodInfoPtr_WaitForClipEnd_Private_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673124);
    AbilityStateController.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673125);
    AbilityStateController.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673126);
    AbilityStateController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673127);
    AbilityStateController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, 100673128);
  }

  public unsafe StateOverride TopOverrideState
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 106197, RefRangeEnd = 106208, XrefRangeStart = 106193, XrefRangeEnd = 106197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_get_TopOverrideState_Public_get_StateOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (StateOverride) null : Il2CppObjectPool.Get<StateOverride>(num3);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 106209, RefRangeEnd = 106211, XrefRangeStart = 106208, XrefRangeEnd = 106209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AbilityAvailable(Abilities ability)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ability
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_AbilityAvailable_Public_Boolean_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 106212, RefRangeEnd = 106215, XrefRangeStart = 106211, XrefRangeEnd = 106212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AbilityActive(Abilities ability)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ability
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_AbilityActive_Public_Boolean_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool IsInOverride
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 106216, RefRangeEnd = 106218, XrefRangeStart = 106215, XrefRangeEnd = 106216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_get_IsInOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106218, XrefRangeEnd = 106230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStateController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 106247, RefRangeEnd = 106251, XrefRangeStart = 106230, XrefRangeEnd = 106247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitAbilities()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_InitAbilities_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106251, XrefRangeEnd = 106270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SwitchFSM(
    FSMGraph graph,
    MeshClip transitClip = null,
    bool cancellable = false,
    bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transitClip);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cancellable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &force;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStateController.NativeMethodInfoPtr_SwitchFSM_Public_Virtual_Void_FSMGraph_MeshClip_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106270, XrefRangeEnd = 106294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PlayClip(MeshClip clip, bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &force;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStateController.NativeMethodInfoPtr_PlayClip_Public_Virtual_Void_MeshClip_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106294, XrefRangeEnd = 106318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ContinueClip(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStateController.NativeMethodInfoPtr_ContinueClip_Public_Virtual_Void_MeshClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 106337, RefRangeEnd = 106340, XrefRangeStart = 106318, XrefRangeEnd = 106337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float OverridedValue(FloatReference floatReference)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) floatReference)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_OverridedValue_Public_Single_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void ForceAbility(Abilities abilities)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &abilities
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_ForceAbility_Public_Void_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 106341, RefRangeEnd = 106342, XrefRangeStart = 106340, XrefRangeEnd = 106341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddAbility(Abilities abilities)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &abilities
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_AddAbility_Public_Void_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 106366, RefRangeEnd = 106368, XrefRangeStart = 106342, XrefRangeEnd = 106366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnterOverrideState(StateOverride overrideState, bool enterFromIdle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overrideState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enterFromIdle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_EnterOverrideState_Public_Void_StateOverride_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 106393, RefRangeEnd = 106395, XrefRangeStart = 106368, XrefRangeEnd = 106393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitOverrideState(StateOverride overrideState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overrideState)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_ExitOverrideState_Public_Void_StateOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106395, XrefRangeEnd = 106399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForClipEnd(Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_WaitForClipEnd_Private_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106399, XrefRangeEnd = 106431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106431, XrefRangeEnd = 106434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106434, XrefRangeEnd = 106445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106445, XrefRangeEnd = 106464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AbilityStateController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityStateController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Abilities AvailableAbilities
  {
    get
    {
      return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_AvailableAbilities));
    }
    [param: In] set
    {
      *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_AvailableAbilities)) = value;
    }
  }

  public unsafe List<StateOverride> overrideStates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_overrideStates));
      return num == System.IntPtr.Zero ? (List<StateOverride>) null : Il2CppObjectPool.Get<List<StateOverride>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_overrideStates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Abilities activeAbilities
  {
    get
    {
      return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_activeAbilities));
    }
    [param: In] set
    {
      *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_activeAbilities)) = value;
    }
  }

  public unsafe PossiblePlayerDefaultFSM possibleDefaultFSM
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_possibleDefaultFSM));
      return num == System.IntPtr.Zero ? (PossiblePlayerDefaultFSM) null : Il2CppObjectPool.Get<PossiblePlayerDefaultFSM>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_possibleDefaultFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<AbilitiesChangedEvent> abilitiesPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_abilitiesPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<AbilitiesChangedEvent>) null : Il2CppObjectPool.Get<IPublisher<AbilitiesChangedEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_abilitiesPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<MeshClip> ClipCalled
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_ClipCalled));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<MeshClip>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MeshClip>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_ClipCalled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AbilityStateController.SaveData savedData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_savedData));
      return num == System.IntPtr.Zero ? (AbilityStateController.SaveData) null : Il2CppObjectPool.Get<AbilityStateController.SaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.NativeFieldInfoPtr_savedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AvailableAbilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultFSM;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveFSM;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SaveData()
    {
      Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, nameof (SaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr);
      AbilityStateController.SaveData.NativeFieldInfoPtr_AvailableAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr, nameof (AvailableAbilities));
      AbilityStateController.SaveData.NativeFieldInfoPtr_DefaultFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr, nameof (DefaultFSM));
      AbilityStateController.SaveData.NativeFieldInfoPtr_ActiveFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr, nameof (ActiveFSM));
      AbilityStateController.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr, 100673129);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateController.SaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Abilities AvailableAbilities
    {
      get
      {
        return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.SaveData.NativeFieldInfoPtr_AvailableAbilities));
      }
      [param: In] set
      {
        *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.SaveData.NativeFieldInfoPtr_AvailableAbilities)) = value;
      }
    }

    public unsafe string DefaultFSM
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.SaveData.NativeFieldInfoPtr_DefaultFSM)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.SaveData.NativeFieldInfoPtr_DefaultFSM), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ActiveFSM
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.SaveData.NativeFieldInfoPtr_ActiveFSM)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.SaveData.NativeFieldInfoPtr_ActiveFSM), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.FSM.AbilityStateController+<>c__DisplayClass20_0")]
  public sealed class __c__DisplayClass20_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_overrideState;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

    static __c__DisplayClass20_0()
    {
      Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, "<>c__DisplayClass20_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr);
      AbilityStateController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
      AbilityStateController.__c__DisplayClass20_0.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr, nameof (overrideState));
      AbilityStateController.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr, 100673130);
      AbilityStateController.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr, 100673131);
      AbilityStateController.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr, 100673132);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass20_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void Method_Internal_Void_PDM_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe AbilityStateController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StateOverride overrideState
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass20_0.NativeFieldInfoPtr_overrideState));
        return num == System.IntPtr.Zero ? (StateOverride) null : Il2CppObjectPool.Get<StateOverride>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass20_0.NativeFieldInfoPtr_overrideState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.FSM.AbilityStateController+<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_overrideState;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr);
      AbilityStateController.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
      AbilityStateController.__c__DisplayClass21_0.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr, nameof (overrideState));
      AbilityStateController.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr, 100673133);
      AbilityStateController.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr, 100673134);
      AbilityStateController.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr, 100673135);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106164, XrefRangeEnd = 106165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106165, XrefRangeEnd = 106166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe AbilityStateController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StateOverride overrideState
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass21_0.NativeFieldInfoPtr_overrideState));
        return num == System.IntPtr.Zero ? (StateOverride) null : Il2CppObjectPool.Get<StateOverride>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass21_0.NativeFieldInfoPtr_overrideState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.FSM.AbilityStateController+<>c__DisplayClass25_0")]
  public sealed class __c__DisplayClass25_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gameFlowManager;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Serialize_b__0_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Serialize_b__1_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Serialize_b__2_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0;

    static __c__DisplayClass25_0()
    {
      Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, "<>c__DisplayClass25_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr);
      AbilityStateController.__c__DisplayClass25_0.NativeFieldInfoPtr_gameFlowManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr, nameof (gameFlowManager));
      AbilityStateController.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
      AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr, 100673136);
      AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__Serialize_b__0_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr, 100673137);
      AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__Serialize_b__1_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr, 100673138);
      AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__Serialize_b__2_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr, 100673139);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass25_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateController.__c__DisplayClass25_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106166, XrefRangeEnd = 106176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Serialize_b__0(KeyValuePair<string, FSMGraph> kv)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) kv))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__Serialize_b__0_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106176, XrefRangeEnd = 106182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Serialize_b__1(KeyValuePair<string, FSMGraph> kv)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) kv))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__Serialize_b__1_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106182, XrefRangeEnd = 106188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Serialize_b__2(KeyValuePair<string, FSMGraph> kv)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) kv))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController.__c__DisplayClass25_0.NativeMethodInfoPtr__Serialize_b__2_Internal_Boolean_KeyValuePair_2_String_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe GameFlowManager gameFlowManager
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass25_0.NativeFieldInfoPtr_gameFlowManager));
        return num == System.IntPtr.Zero ? (GameFlowManager) null : Il2CppObjectPool.Get<GameFlowManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass25_0.NativeFieldInfoPtr_gameFlowManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityStateController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.FSM.AbilityStateController+<WaitForClipEnd>d__22")]
  public sealed class _WaitForClipEnd_d__22(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForClipEnd_d__22()
    {
      Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateController>.NativeClassPtr, "<WaitForClipEnd>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr);
      AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, "<>1__state");
      AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, "<>2__current");
      AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, "<>4__this");
      AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, nameof (callback));
      AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, 100673140);
      AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, 100673141);
      AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, 100673142);
      AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, 100673143);
      AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, 100673144);
      AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr, 100673145);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForClipEnd_d__22(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateController._WaitForClipEnd_d__22>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106188, XrefRangeEnd = 106193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateController._WaitForClipEnd_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityStateController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStateController._WaitForClipEnd_d__22.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
