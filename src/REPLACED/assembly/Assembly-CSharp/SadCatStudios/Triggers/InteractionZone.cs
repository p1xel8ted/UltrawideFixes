// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.InteractionZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Triggers;

public class InteractionZone(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionSoundEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_InteractionTextOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideInteractionIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_customInteractionIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_InteractionMarkerAnchor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Reactivated;
  private static readonly System.IntPtr NativeFieldInfoPtr_DisablePlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_WalkToPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_WalkPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_TurnToPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_floorRayDist;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_skinWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_smoothSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_smoothThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_anchorPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionTextArticyIDs;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastInteractionController;
  private static readonly System.IntPtr NativeFieldInfoPtr_zoneCollider;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_New_get_InteractionIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InteractionType_Public_get_InteractionIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InteractionIconToText_Public_Static_String_InteractionIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InteractionText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NeedMarker_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InteractionPos_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interact_Public_Virtual_Final_New_Void_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interaction_Protected_Virtual_New_IEnumerator_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasInteracted_Public_Abstract_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_New_Boolean_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsColliderActive_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetColliderActive_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static InteractionZone()
  {
    Il2CppClassPointerStore<InteractionZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (InteractionZone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr);
    InteractionZone.NativeFieldInfoPtr_interactionSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (interactionSoundEvent));
    InteractionZone.NativeFieldInfoPtr_InteractionTextOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (InteractionTextOffset));
    InteractionZone.NativeFieldInfoPtr_overrideInteractionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (overrideInteractionIcon));
    InteractionZone.NativeFieldInfoPtr_customInteractionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (customInteractionIcon));
    InteractionZone.NativeFieldInfoPtr_InteractionMarkerAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (InteractionMarkerAnchor));
    InteractionZone.NativeFieldInfoPtr_Reactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (Reactivated));
    InteractionZone.NativeFieldInfoPtr_DisablePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (DisablePlayer));
    InteractionZone.NativeFieldInfoPtr_IgnoreDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (IgnoreDistance));
    InteractionZone.NativeFieldInfoPtr_WalkToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (WalkToPoint));
    InteractionZone.NativeFieldInfoPtr_WalkPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (WalkPoint));
    InteractionZone.NativeFieldInfoPtr_TurnToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (TurnToPoint));
    InteractionZone.NativeFieldInfoPtr_floorRayDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (floorRayDist));
    InteractionZone.NativeFieldInfoPtr_defaultLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (defaultLayerMask));
    InteractionZone.NativeFieldInfoPtr_skinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (skinWidth));
    InteractionZone.NativeFieldInfoPtr_smoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (smoothSpeed));
    InteractionZone.NativeFieldInfoPtr_smoothThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (smoothThreshold));
    InteractionZone.NativeFieldInfoPtr_anchorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (anchorPos));
    InteractionZone.NativeFieldInfoPtr_interactionTextArticyIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (interactionTextArticyIDs));
    InteractionZone.NativeFieldInfoPtr_lastInteractionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (lastInteractionController));
    InteractionZone.NativeFieldInfoPtr_zoneCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, nameof (zoneCollider));
    InteractionZone.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_New_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671757);
    InteractionZone.NativeMethodInfoPtr_get_InteractionType_Public_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671758);
    InteractionZone.NativeMethodInfoPtr_InteractionIconToText_Public_Static_String_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671759);
    InteractionZone.NativeMethodInfoPtr_get_InteractionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671760);
    InteractionZone.NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671761);
    InteractionZone.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671762);
    InteractionZone.NativeMethodInfoPtr_get_NeedMarker_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671763);
    InteractionZone.NativeMethodInfoPtr_get_InteractionPos_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671764);
    InteractionZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671765);
    InteractionZone.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671766);
    InteractionZone.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671767);
    InteractionZone.NativeMethodInfoPtr_Interact_Public_Virtual_Final_New_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671768);
    InteractionZone.NativeMethodInfoPtr_PlaySound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671769);
    InteractionZone.NativeMethodInfoPtr_Interaction_Protected_Virtual_New_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671770);
    InteractionZone.NativeMethodInfoPtr_HasInteracted_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671771);
    InteractionZone.NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_New_Boolean_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671772);
    InteractionZone.NativeMethodInfoPtr_IsColliderActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671773);
    InteractionZone.NativeMethodInfoPtr_SetColliderActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671774);
    InteractionZone.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, 100671775);
  }

  public virtual unsafe InteractionZone.InteractionIcon ZoneInteractionType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_New_get_InteractionIcon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe InteractionZone.InteractionIcon InteractionType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_get_InteractionType_Public_get_InteractionIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95959, RefRangeEnd = 95960, XrefRangeStart = 95943, XrefRangeEnd = 95959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string InteractionIconToText(InteractionZone.InteractionIcon icon)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &icon
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_InteractionIconToText_Public_Static_String_InteractionIcon_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public unsafe string InteractionText
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 95980, RefRangeEnd = 95981, XrefRangeStart = 95960, XrefRangeEnd = 95980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_get_InteractionText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe bool PlayerMustBeInside
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_get_PlayerMustBeInside_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe int Priority
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe bool NeedMarker
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_get_NeedMarker_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 InteractionPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_get_InteractionPos_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95984, RefRangeEnd = 95986, XrefRangeStart = 95981, XrefRangeEnd = 95984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95986, XrefRangeEnd = 95995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95995, XrefRangeEnd = 96003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 96021, RefRangeEnd = 96022, XrefRangeStart = 96003, XrefRangeEnd = 96021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Interact(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_Interact_Public_Virtual_Final_New_Void_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 96029, RefRangeEnd = 96035, XrefRangeStart = 96022, XrefRangeEnd = 96029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlaySound()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_PlaySound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 95567, RefRangeEnd = 95570, XrefRangeStart = 95567, XrefRangeEnd = 95570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Interaction(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_Interaction_Protected_Virtual_New_IEnumerator_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_HasInteracted_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 96039, RefRangeEnd = 96040, XrefRangeStart = 96035, XrefRangeEnd = 96039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CanBeInteracted(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionZone.NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_New_Boolean_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 96042, RefRangeEnd = 96043, XrefRangeStart = 96040, XrefRangeEnd = 96042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsColliderActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_IsColliderActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 96049, RefRangeEnd = 96055, XrefRangeStart = 96043, XrefRangeEnd = 96049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColliderActive(bool status)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &status
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr_SetColliderActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96057, RefRangeEnd = 96059, XrefRangeStart = 96055, XrefRangeEnd = 96057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InteractionZone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZone.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference interactionSoundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_interactionSoundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_interactionSoundEvent)) = value;
    }
  }

  public unsafe Vector3 InteractionTextOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_InteractionTextOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_InteractionTextOffset)) = value;
    }
  }

  public unsafe bool overrideInteractionIcon
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_overrideInteractionIcon));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_overrideInteractionIcon)) = value;
    }
  }

  public unsafe InteractionZone.InteractionIcon customInteractionIcon
  {
    get
    {
      return *(InteractionZone.InteractionIcon*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_customInteractionIcon));
    }
    [param: In] set
    {
      *(InteractionZone.InteractionIcon*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_customInteractionIcon)) = value;
    }
  }

  public unsafe Transform InteractionMarkerAnchor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_InteractionMarkerAnchor));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_InteractionMarkerAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Reactivated
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_Reactivated));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_Reactivated)) = value;
    }
  }

  public unsafe bool DisablePlayer
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_DisablePlayer));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_DisablePlayer)) = value;
    }
  }

  public unsafe bool IgnoreDistance
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_IgnoreDistance));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_IgnoreDistance)) = value;
    }
  }

  public unsafe bool WalkToPoint
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_WalkToPoint));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_WalkToPoint)) = value;
    }
  }

  public unsafe Transform WalkPoint
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_WalkPoint));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_WalkPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform TurnToPoint
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_TurnToPoint));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_TurnToPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float floorRayDist
  {
    get
    {
      float floorRayDist;
      IL2CPP.il2cpp_field_static_get_value(InteractionZone.NativeFieldInfoPtr_floorRayDist, (void*) &floorRayDist);
      return floorRayDist;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InteractionZone.NativeFieldInfoPtr_floorRayDist, (void*) &value);
    }
  }

  public unsafe LayerMask defaultLayerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_defaultLayerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_defaultLayerMask)) = value;
    }
  }

  public static unsafe float skinWidth
  {
    get
    {
      float skinWidth;
      IL2CPP.il2cpp_field_static_get_value(InteractionZone.NativeFieldInfoPtr_skinWidth, (void*) &skinWidth);
      return skinWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InteractionZone.NativeFieldInfoPtr_skinWidth, (void*) &value);
    }
  }

  public static unsafe float smoothSpeed
  {
    get
    {
      float smoothSpeed;
      IL2CPP.il2cpp_field_static_get_value(InteractionZone.NativeFieldInfoPtr_smoothSpeed, (void*) &smoothSpeed);
      return smoothSpeed;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InteractionZone.NativeFieldInfoPtr_smoothSpeed, (void*) &value);
    }
  }

  public static unsafe float smoothThreshold
  {
    get
    {
      float smoothThreshold;
      IL2CPP.il2cpp_field_static_get_value(InteractionZone.NativeFieldInfoPtr_smoothThreshold, (void*) &smoothThreshold);
      return smoothThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InteractionZone.NativeFieldInfoPtr_smoothThreshold, (void*) &value);
    }
  }

  public unsafe Vector3 anchorPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_anchorPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_anchorPos)) = value;
    }
  }

  public static unsafe Dictionary<InteractionZone.InteractionIcon, ulong> interactionTextArticyIDs
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(InteractionZone.NativeFieldInfoPtr_interactionTextArticyIDs, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<InteractionZone.InteractionIcon, ulong>) null : Il2CppObjectPool.Get<Dictionary<InteractionZone.InteractionIcon, ulong>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InteractionZone.NativeFieldInfoPtr_interactionTextArticyIDs, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterInteractionController lastInteractionController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_lastInteractionController));
      return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_lastInteractionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider zoneCollider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_zoneCollider));
      return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone.NativeFieldInfoPtr_zoneCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum InteractionIcon
  {
    Interact,
    ClimbUp,
    ClimbDown,
    Talk,
    Enter,
    Grab,
    Scan,
    Hack,
    Insert,
    PickUp,
    Hide,
    Look,
    Check,
    Unhide,
  }

  [ObfuscatedName("SadCatStudios.Triggers.InteractionZone+<Interaction>d__41")]
  public sealed class _Interaction_d__41(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Interaction_d__41()
    {
      Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionZone>.NativeClassPtr, "<Interaction>d__41");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr);
      InteractionZone._Interaction_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, "<>1__state");
      InteractionZone._Interaction_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, "<>2__current");
      InteractionZone._Interaction_d__41.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, nameof (interactionController));
      InteractionZone._Interaction_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, 100671777);
      InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, 100671778);
      InteractionZone._Interaction_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, 100671779);
      InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, 100671780);
      InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, 100671781);
      InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr, 100671782);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Interaction_d__41(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionZone._Interaction_d__41>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionZone._Interaction_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95936, XrefRangeEnd = 95938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone._Interaction_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95938, XrefRangeEnd = 95943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZone._Interaction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone._Interaction_d__41.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone._Interaction_d__41.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone._Interaction_d__41.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone._Interaction_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone._Interaction_d__41.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZone._Interaction_d__41.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
