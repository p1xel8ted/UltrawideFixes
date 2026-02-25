// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Foundation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatZone(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_leftBacklineOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightBacklineOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_onCombatStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_onCombatEnded;
  private static readonly System.IntPtr NativeFieldInfoPtr_combatEventEmitter;
  private static readonly System.IntPtr NativeFieldInfoPtr_virtualCameraZoneVCam;
  private static readonly System.IntPtr NativeFieldInfoPtr_virtualCameraZoneVCamPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveAfterCombat;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_boxCollider;
  private static readonly System.IntPtr NativeFieldInfoPtr_sequencer;
  private static readonly System.IntPtr NativeFieldInfoPtr_placers;
  private static readonly System.IntPtr NativeFieldInfoPtr_additionalEventEmitters;
  private static readonly System.IntPtr NativeFieldInfoPtr_triggered;
  private static readonly System.IntPtr NativeFieldInfoPtr_defeated;
  private static readonly System.IntPtr NativeFieldInfoPtr_wallLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_walls;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RightBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftBacklineBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RightBacklineBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvisibleWall_Private_GameObject_String_Vector3_Quaternion_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActivateZone_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueCombat_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWalls_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCombatZoneDefeated_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatZone()
  {
    Il2CppClassPointerStore<CombatZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatZone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatZone>.NativeClassPtr);
    CombatZone.NativeFieldInfoPtr_leftBacklineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (leftBacklineOffset));
    CombatZone.NativeFieldInfoPtr_rightBacklineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (rightBacklineOffset));
    CombatZone.NativeFieldInfoPtr_onCombatStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (onCombatStarted));
    CombatZone.NativeFieldInfoPtr_onCombatEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (onCombatEnded));
    CombatZone.NativeFieldInfoPtr_combatEventEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (combatEventEmitter));
    CombatZone.NativeFieldInfoPtr_virtualCameraZoneVCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (virtualCameraZoneVCam));
    CombatZone.NativeFieldInfoPtr_virtualCameraZoneVCamPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (virtualCameraZoneVCamPriority));
    CombatZone.NativeFieldInfoPtr_saveAfterCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (saveAfterCombat));
    CombatZone.NativeFieldInfoPtr_playerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (playerTransform));
    CombatZone.NativeFieldInfoPtr_boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (boxCollider));
    CombatZone.NativeFieldInfoPtr_sequencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (sequencer));
    CombatZone.NativeFieldInfoPtr_placers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (placers));
    CombatZone.NativeFieldInfoPtr_additionalEventEmitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (additionalEventEmitters));
    CombatZone.NativeFieldInfoPtr_triggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (triggered));
    CombatZone.NativeFieldInfoPtr_defeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (defeated));
    CombatZone.NativeFieldInfoPtr_wallLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (wallLayer));
    CombatZone.NativeFieldInfoPtr_walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (walls));
    CombatZone.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (saveData));
    CombatZone.NativeMethodInfoPtr_get_LeftBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677010);
    CombatZone.NativeMethodInfoPtr_get_RightBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677011);
    CombatZone.NativeMethodInfoPtr_get_LeftBacklineBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677012);
    CombatZone.NativeMethodInfoPtr_get_RightBacklineBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677013);
    CombatZone.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677014);
    CombatZone.NativeMethodInfoPtr_CreateInvisibleWall_Private_GameObject_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677015);
    CombatZone.NativeMethodInfoPtr_ActivateZone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677016);
    CombatZone.NativeMethodInfoPtr_ContinueCombat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677017);
    CombatZone.NativeMethodInfoPtr_DestroyWalls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677018);
    CombatZone.NativeMethodInfoPtr_OnCombatZoneDefeated_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677019);
    CombatZone.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677020);
    CombatZone.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677021);
    CombatZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677022);
    CombatZone.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677023);
    CombatZone.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677024);
    CombatZone.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677025);
    CombatZone.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677026);
    CombatZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, 100677027);
  }

  public unsafe float LeftBorder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127577, XrefRangeEnd = 127578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_get_LeftBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float RightBorder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127578, XrefRangeEnd = 127579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_get_RightBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float LeftBacklineBorder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127579, XrefRangeEnd = 127580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_get_LeftBacklineBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float RightBacklineBorder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127580, XrefRangeEnd = 127581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_get_RightBacklineBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127581, XrefRangeEnd = 127606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 127643, RefRangeEnd = 127645, XrefRangeStart = 127606, XrefRangeEnd = 127643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject CreateInvisibleWall(
    string name,
    Vector3 position,
    Quaternion rotation,
    bool xIsX)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &xIsX;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_CreateInvisibleWall_Private_GameObject_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127645, XrefRangeEnd = 127692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActivateZone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_ActivateZone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127692, XrefRangeEnd = 127697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContinueCombat()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_ContinueCombat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 127705, RefRangeEnd = 127707, XrefRangeStart = 127697, XrefRangeEnd = 127705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyWalls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_DestroyWalls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 127729, RefRangeEnd = 127732, XrefRangeStart = 127707, XrefRangeEnd = 127729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCombatZoneDefeated()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_OnCombatZoneDefeated_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127732, XrefRangeEnd = 127737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127737, XrefRangeEnd = 127741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127741, XrefRangeEnd = 127759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127759, XrefRangeEnd = 127764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 PlayerPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
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
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127764, XrefRangeEnd = 127766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127766, XrefRangeEnd = 127813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127813, XrefRangeEnd = 127817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatZone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatZone>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float leftBacklineOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_leftBacklineOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_leftBacklineOffset)) = value;
    }
  }

  public unsafe float rightBacklineOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_rightBacklineOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_rightBacklineOffset)) = value;
    }
  }

  public unsafe UnityEvent onCombatStarted
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_onCombatStarted));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_onCombatStarted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onCombatEnded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_onCombatEnded));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_onCombatEnded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StudioEventEmitter combatEventEmitter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_combatEventEmitter));
      return num == System.IntPtr.Zero ? (StudioEventEmitter) null : Il2CppObjectPool.Get<StudioEventEmitter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_combatEventEmitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase virtualCameraZoneVCam
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_virtualCameraZoneVCam));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_virtualCameraZoneVCam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int virtualCameraZoneVCamPriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_virtualCameraZoneVCamPriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_virtualCameraZoneVCamPriority)) = value;
    }
  }

  public unsafe bool saveAfterCombat
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_saveAfterCombat));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_saveAfterCombat)) = value;
    }
  }

  public unsafe Transform playerTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_playerTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_playerTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoxCollider boxCollider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_boxCollider));
      return num == System.IntPtr.Zero ? (BoxCollider) null : Il2CppObjectPool.Get<BoxCollider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_boxCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CombatSequencerBase sequencer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_sequencer));
      return num == System.IntPtr.Zero ? (CombatSequencerBase) null : Il2CppObjectPool.Get<CombatSequencerBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_sequencer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CombatZoneEnemyPlacer> placers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_placers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CombatZoneEnemyPlacer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CombatZoneEnemyPlacer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_placers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StudioEventEmitter> additionalEventEmitters
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_additionalEventEmitters));
      return num == System.IntPtr.Zero ? (List<StudioEventEmitter>) null : Il2CppObjectPool.Get<List<StudioEventEmitter>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_additionalEventEmitters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool triggered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_triggered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_triggered)) = value;
    }
  }

  public unsafe bool defeated
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_defeated));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_defeated)) = value;
    }
  }

  public static unsafe string wallLayer
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CombatZone.NativeFieldInfoPtr_wallLayer, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CombatZone.NativeFieldInfoPtr_wallLayer, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<GameObject> walls
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_walls));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_walls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CombatZone.CombatZoneSaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (CombatZone.CombatZoneSaveData) null : Il2CppObjectPool.Get<CombatZone.CombatZoneSaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class CombatZoneSaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Defeated;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static CombatZoneSaveData()
    {
      Il2CppClassPointerStore<CombatZone.CombatZoneSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatZone>.NativeClassPtr, nameof (CombatZoneSaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatZone.CombatZoneSaveData>.NativeClassPtr);
      CombatZone.CombatZoneSaveData.NativeFieldInfoPtr_Defeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZone.CombatZoneSaveData>.NativeClassPtr, nameof (Defeated));
      CombatZone.CombatZoneSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZone.CombatZoneSaveData>.NativeClassPtr, 100677029);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CombatZoneSaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatZone.CombatZoneSaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatZone.CombatZoneSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool Defeated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.CombatZoneSaveData.NativeFieldInfoPtr_Defeated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZone.CombatZoneSaveData.NativeFieldInfoPtr_Defeated)) = value;
      }
    }
  }
}
