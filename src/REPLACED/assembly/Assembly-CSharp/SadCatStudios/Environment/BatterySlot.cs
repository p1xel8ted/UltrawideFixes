// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.BatterySlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using SadCatStudios.Foundation;
using SadCatStudios.Triggers;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Environment;

public class BatterySlot(System.IntPtr pointer) : InteractionZone(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_interactionAnchorOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_batteryPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_batteryRot;
  private static readonly System.IntPtr NativeFieldInfoPtr_slotFilled;
  private static readonly System.IntPtr NativeFieldInfoPtr_originalBattery;
  private static readonly System.IntPtr NativeFieldInfoPtr_onTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_offTimeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_attachCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_detachCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_batteryWorkingSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_currBattery;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AttachBattery_Public_Void_CarryableBattery_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetachBattery_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AttachBatteryPosition_Private_Void_CarryableBattery_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SnapCarryableToOrigin_Private_Void_CarryableBattery_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_Boolean_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InitializePriority_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0;

  static BatterySlot()
  {
    Il2CppClassPointerStore<BatterySlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (BatterySlot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr);
    BatterySlot.NativeFieldInfoPtr_interactionAnchorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (interactionAnchorOffset));
    BatterySlot.NativeFieldInfoPtr_batteryPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (batteryPos));
    BatterySlot.NativeFieldInfoPtr_batteryRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (batteryRot));
    BatterySlot.NativeFieldInfoPtr_slotFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (slotFilled));
    BatterySlot.NativeFieldInfoPtr_originalBattery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (originalBattery));
    BatterySlot.NativeFieldInfoPtr_onTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (onTimeline));
    BatterySlot.NativeFieldInfoPtr_offTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (offTimeline));
    BatterySlot.NativeFieldInfoPtr_attachCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (attachCallback));
    BatterySlot.NativeFieldInfoPtr_detachCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (detachCallback));
    BatterySlot.NativeFieldInfoPtr_batteryWorkingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (batteryWorkingSound));
    BatterySlot.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (saveData));
    BatterySlot.NativeFieldInfoPtr_currBattery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (currBattery));
    BatterySlot.NativeMethodInfoPtr_get_Priority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675834);
    BatterySlot.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675835);
    BatterySlot.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675836);
    BatterySlot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675837);
    BatterySlot.NativeMethodInfoPtr_AttachBattery_Public_Void_CarryableBattery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675838);
    BatterySlot.NativeMethodInfoPtr_DetachBattery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675839);
    BatterySlot.NativeMethodInfoPtr_AttachBatteryPosition_Private_Void_CarryableBattery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675840 /*0x06003100*/);
    BatterySlot.NativeMethodInfoPtr_SnapCarryableToOrigin_Private_Void_CarryableBattery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675841);
    BatterySlot.NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_Boolean_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675842);
    BatterySlot.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675843);
    BatterySlot.NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675844);
    BatterySlot.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675845);
    BatterySlot.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675846);
    BatterySlot.NativeMethodInfoPtr_get_InitializePriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675847);
    BatterySlot.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675848);
    BatterySlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675849);
    BatterySlot.NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, 100675850);
  }

  public override unsafe int Priority
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BatterySlot.NativeMethodInfoPtr_get_Priority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe InteractionZone.InteractionIcon ZoneInteractionType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BatterySlot.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119976, XrefRangeEnd = 119981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119981, XrefRangeEnd = 119999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BatterySlot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119999, XrefRangeEnd = 120008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AttachBattery(CarryableBattery battery)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battery)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_AttachBattery_Public_Void_CarryableBattery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120008, XrefRangeEnd = 120017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DetachBattery()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_DetachBattery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 120029, RefRangeEnd = 120032, XrefRangeStart = 120017, XrefRangeEnd = 120029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AttachBatteryPosition(CarryableBattery battery)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battery)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_AttachBatteryPosition_Private_Void_CarryableBattery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 120041, RefRangeEnd = 120044, XrefRangeStart = 120032, XrefRangeEnd = 120041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapCarryableToOrigin(CarryableBattery battery)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battery)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_SnapCarryableToOrigin_Private_Void_CarryableBattery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120044, XrefRangeEnd = 120045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanBeInteracted(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BatterySlot.NativeMethodInfoPtr_CanBeInteracted_Public_Virtual_Boolean_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120045, XrefRangeEnd = 120050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BatterySlot.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120050, XrefRangeEnd = 120054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Interaction(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BatterySlot.NativeMethodInfoPtr_Interaction_Protected_Virtual_IEnumerator_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120054, XrefRangeEnd = 120058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120058, XrefRangeEnd = 120064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe int InitializePriority
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_get_InitializePriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120064, XrefRangeEnd = 120080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120080, XrefRangeEnd = 120085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BatterySlot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120085, XrefRangeEnd = 120086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator __n__0(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.NativeMethodInfoPtr___n__0_Private_IEnumerator_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  public unsafe Vector3 interactionAnchorOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_interactionAnchorOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_interactionAnchorOffset)) = value;
    }
  }

  public unsafe Vector3 batteryPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_batteryPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_batteryPos)) = value;
    }
  }

  public unsafe Quaternion batteryRot
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_batteryRot));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_batteryRot)) = value;
    }
  }

  public unsafe bool slotFilled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_slotFilled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_slotFilled)) = value;
    }
  }

  public unsafe CarryableBattery originalBattery
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_originalBattery));
      return num == System.IntPtr.Zero ? (CarryableBattery) null : Il2CppObjectPool.Get<CarryableBattery>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_originalBattery), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector onTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_onTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_onTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector offTimeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_offTimeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_offTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent attachCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_attachCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_attachCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent detachCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_detachCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_detachCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StudioEventEmitter batteryWorkingSound
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_batteryWorkingSound));
      return num == System.IntPtr.Zero ? (StudioEventEmitter) null : Il2CppObjectPool.Get<StudioEventEmitter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_batteryWorkingSound), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BatterySlot.SaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (BatterySlot.SaveData) null : Il2CppObjectPool.Get<BatterySlot.SaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CarryableBattery currBattery
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_currBattery));
      return num == System.IntPtr.Zero ? (CarryableBattery) null : Il2CppObjectPool.Get<CarryableBattery>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.NativeFieldInfoPtr_currBattery), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Filled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilledBy;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SaveData()
    {
      Il2CppClassPointerStore<BatterySlot.SaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, nameof (SaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatterySlot.SaveData>.NativeClassPtr);
      BatterySlot.SaveData.NativeFieldInfoPtr_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.SaveData>.NativeClassPtr, nameof (Filled));
      BatterySlot.SaveData.NativeFieldInfoPtr_FilledBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.SaveData>.NativeClassPtr, nameof (FilledBy));
      BatterySlot.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.SaveData>.NativeClassPtr, 100675851);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatterySlot.SaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatterySlot.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool Filled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.SaveData.NativeFieldInfoPtr_Filled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.SaveData.NativeFieldInfoPtr_Filled)) = value;
      }
    }

    public unsafe GuidReference FilledBy
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.SaveData.NativeFieldInfoPtr_FilledBy));
        return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.SaveData.NativeFieldInfoPtr_FilledBy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.BatterySlot+<>c__DisplayClass25_0")]
  public sealed class __c__DisplayClass25_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

    static __c__DisplayClass25_0()
    {
      Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, "<>c__DisplayClass25_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr);
      BatterySlot.__c__DisplayClass25_0.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr, nameof (interactionController));
      BatterySlot.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
      BatterySlot.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr, 100675852);
      BatterySlot.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr, 100675853);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass25_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119966, XrefRangeEnd = 119970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BatterySlot __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BatterySlot) null : Il2CppObjectPool.Get<BatterySlot>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Environment.BatterySlot+<>c__DisplayClass25_0+<<Interaction>g__WaitForPlugIn|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
      {
        Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0>.NativeClassPtr, "<<Interaction>g__WaitForPlugIn|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675854);
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675855);
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675856);
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675857);
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675858);
        BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675859);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119943, XrefRangeEnd = 119961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119961, XrefRangeEnd = 119966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BatterySlot.__c__DisplayClass25_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (BatterySlot.__c__DisplayClass25_0) null : Il2CppObjectPool.Get<BatterySlot.__c__DisplayClass25_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.BatterySlot+<Interaction>d__25")]
  public sealed class _Interaction_d__25(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Interaction_d__25()
    {
      Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatterySlot>.NativeClassPtr, "<Interaction>d__25");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr);
      BatterySlot._Interaction_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, "<>1__state");
      BatterySlot._Interaction_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, "<>2__current");
      BatterySlot._Interaction_d__25.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, nameof (interactionController));
      BatterySlot._Interaction_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, "<>4__this");
      BatterySlot._Interaction_d__25.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, "<>8__1");
      BatterySlot._Interaction_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, 100675860);
      BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, 100675861);
      BatterySlot._Interaction_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, 100675862);
      BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, 100675863);
      BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, 100675864);
      BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr, 100675865);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Interaction_d__25(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatterySlot._Interaction_d__25>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatterySlot._Interaction_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119970, XrefRangeEnd = 119971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot._Interaction_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119971, XrefRangeEnd = 119976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatterySlot._Interaction_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BatterySlot __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BatterySlot) null : Il2CppObjectPool.Get<BatterySlot>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BatterySlot.__c__DisplayClass25_0 __8__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___8__1));
        return num == System.IntPtr.Zero ? (BatterySlot.__c__DisplayClass25_0) null : Il2CppObjectPool.Get<BatterySlot.__c__DisplayClass25_0>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatterySlot._Interaction_d__25.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
