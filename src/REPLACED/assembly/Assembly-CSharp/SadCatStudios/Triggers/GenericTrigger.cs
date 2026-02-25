// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.GenericTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using SadCatStudios.Foundation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Triggers;

public class GenericTrigger(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_activatorTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_onEnterEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_onExitEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_playOnce;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkToPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_activationPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopAtPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_turnToPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_col;
  private static readonly System.IntPtr NativeFieldInfoPtr_played;
  private static readonly System.IntPtr NativeFieldInfoPtr_exitPlayed;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_nonInteractionStates;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryInvoke_Private_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Private_Void_CharacterInteractionController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GenericTrigger()
  {
    Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (GenericTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr);
    GenericTrigger.NativeFieldInfoPtr_activatorTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (activatorTag));
    GenericTrigger.NativeFieldInfoPtr_onEnterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (onEnterEvent));
    GenericTrigger.NativeFieldInfoPtr_onExitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (onExitEvent));
    GenericTrigger.NativeFieldInfoPtr_playOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (playOnce));
    GenericTrigger.NativeFieldInfoPtr_walkToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (walkToPoint));
    GenericTrigger.NativeFieldInfoPtr_activationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (activationPoint));
    GenericTrigger.NativeFieldInfoPtr_stopAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (stopAtPoint));
    GenericTrigger.NativeFieldInfoPtr_turnToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (turnToPoint));
    GenericTrigger.NativeFieldInfoPtr_debugColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (debugColor));
    GenericTrigger.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (col));
    GenericTrigger.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (played));
    GenericTrigger.NativeFieldInfoPtr_exitPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (exitPlayed));
    GenericTrigger.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (saveData));
    GenericTrigger.NativeFieldInfoPtr_nonInteractionStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (nonInteractionStates));
    GenericTrigger.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671589);
    GenericTrigger.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671590);
    GenericTrigger.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671591);
    GenericTrigger.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671592);
    GenericTrigger.NativeMethodInfoPtr_TryInvoke_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671593);
    GenericTrigger.NativeMethodInfoPtr_Invoke_Private_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671594);
    GenericTrigger.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671595);
    GenericTrigger.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671596);
    GenericTrigger.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671597);
    GenericTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, 100671598);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95345, XrefRangeEnd = 95348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95348, XrefRangeEnd = 95364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerStay(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95364, XrefRangeEnd = 95366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerExit(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95383, RefRangeEnd = 95384, XrefRangeStart = 95366, XrefRangeEnd = 95383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryInvoke(Transform playerTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerTransform)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_TryInvoke_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95384, XrefRangeEnd = 95385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_Invoke_Private_Void_CharacterInteractionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95385, XrefRangeEnd = 95405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95405, XrefRangeEnd = 95410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95410, XrefRangeEnd = 95425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenericTrigger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string activatorTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_activatorTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_activatorTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe UnityEvent onEnterEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_onEnterEvent));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_onEnterEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onExitEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_onExitEvent));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_onExitEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool playOnce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_playOnce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_playOnce)) = value;
    }
  }

  public unsafe bool walkToPoint
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_walkToPoint));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_walkToPoint)) = value;
    }
  }

  public unsafe Transform activationPoint
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_activationPoint));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_activationPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool stopAtPoint
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_stopAtPoint));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_stopAtPoint)) = value;
    }
  }

  public unsafe Transform turnToPoint
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_turnToPoint));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_turnToPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color debugColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_debugColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_debugColor)) = value;
    }
  }

  public unsafe Collider col
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_col));
      return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool played
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_played));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_played)) = value;
    }
  }

  public unsafe bool exitPlayed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_exitPlayed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_exitPlayed)) = value;
    }
  }

  public unsafe GenericTrigger.SaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (GenericTrigger.SaveData) null : Il2CppObjectPool.Get<GenericTrigger.SaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<GameStateManager.GameState> nonInteractionStates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_nonInteractionStates));
      return num == System.IntPtr.Zero ? (HashSet<GameStateManager.GameState>) null : Il2CppObjectPool.Get<HashSet<GameStateManager.GameState>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.NativeFieldInfoPtr_nonInteractionStates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Played;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitPlayed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SaveData()
    {
      Il2CppClassPointerStore<GenericTrigger.SaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, nameof (SaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericTrigger.SaveData>.NativeClassPtr);
      GenericTrigger.SaveData.NativeFieldInfoPtr_Played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger.SaveData>.NativeClassPtr, nameof (Played));
      GenericTrigger.SaveData.NativeFieldInfoPtr_ExitPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger.SaveData>.NativeClassPtr, nameof (ExitPlayed));
      GenericTrigger.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger.SaveData>.NativeClassPtr, 100671599);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericTrigger.SaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GenericTrigger.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool Played
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.SaveData.NativeFieldInfoPtr_Played));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.SaveData.NativeFieldInfoPtr_Played)) = value;
      }
    }

    public unsafe bool ExitPlayed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.SaveData.NativeFieldInfoPtr_ExitPlayed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.SaveData.NativeFieldInfoPtr_ExitPlayed)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Triggers.GenericTrigger+<>c__DisplayClass19_0")]
  public sealed class __c__DisplayClass19_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryInvoke_b__0_Internal_Void_0;

    static __c__DisplayClass19_0()
    {
      Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericTrigger>.NativeClassPtr, "<>c__DisplayClass19_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr);
      GenericTrigger.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
      GenericTrigger.__c__DisplayClass19_0.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr, nameof (interactionController));
      GenericTrigger.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr, 100671600 /*0x06002070*/);
      GenericTrigger.__c__DisplayClass19_0.NativeMethodInfoPtr__TryInvoke_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr, 100671601);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass19_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericTrigger.__c__DisplayClass19_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GenericTrigger.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95344, XrefRangeEnd = 95345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryInvoke_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GenericTrigger.__c__DisplayClass19_0.NativeMethodInfoPtr__TryInvoke_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GenericTrigger __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GenericTrigger) null : Il2CppObjectPool.Get<GenericTrigger>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.__c__DisplayClass19_0.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericTrigger.__c__DisplayClass19_0.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
