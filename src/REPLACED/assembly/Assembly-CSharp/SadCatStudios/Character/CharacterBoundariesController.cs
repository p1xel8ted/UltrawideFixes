// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterBoundariesController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.Combat;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterBoundariesController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_hurtbox;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreColliderDisablingOnDeath;
  private static readonly IntPtr NativeFieldInfoPtr_pixelsPerUnit;
  private static readonly IntPtr NativeFieldInfoPtr_defaultPivot;
  private static readonly IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly IntPtr NativeFieldInfoPtr_col;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_deathController;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_spriteAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_currPivot;
  private static readonly IntPtr NativeFieldInfoPtr_currSize;
  private static readonly IntPtr NativeFieldInfoPtr_currCenter;
  private static readonly IntPtr NativeFieldInfoPtr_lastPivot;
  private static readonly IntPtr NativeFieldInfoPtr_boundsDefaultCenter;
  private static readonly IntPtr NativeFieldInfoPtr_boundsDefaultSize;
  private static readonly IntPtr NativeFieldInfoPtr_hurtboxDefaultCenter;
  private static readonly IntPtr NativeFieldInfoPtr_hurtboxDefaultSize;
  private static readonly IntPtr NativeFieldInfoPtr_frameSize;
  private static readonly IntPtr NativeFieldInfoPtr_frameCenter;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastPivot_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrPivot_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrSize_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrCenter_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCenter_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSize_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameSize_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameCenter_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnFramePreUpdated_Private_Void_MeshClipFrame_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnClipStarted_Private_Void_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetImmediate_Public_Void_Vector3_Vector3_Vector2_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BlendToFSM_Public_Void_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_Blend_Public_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapToBounds_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EnableBoundaries_Public_Void_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterBoundariesController()
  {
    Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterBoundariesController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr);
    CharacterBoundariesController.NativeFieldInfoPtr_hurtbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (hurtbox));
    CharacterBoundariesController.NativeFieldInfoPtr_ignoreColliderDisablingOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (ignoreColliderDisablingOnDeath));
    CharacterBoundariesController.NativeFieldInfoPtr_pixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (pixelsPerUnit));
    CharacterBoundariesController.NativeFieldInfoPtr_defaultPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (defaultPivot));
    CharacterBoundariesController.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (personPhysics));
    CharacterBoundariesController.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (col));
    CharacterBoundariesController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (rotationController));
    CharacterBoundariesController.NativeFieldInfoPtr_deathController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (deathController));
    CharacterBoundariesController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (stateController));
    CharacterBoundariesController.NativeFieldInfoPtr_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (spriteAnimator));
    CharacterBoundariesController.NativeFieldInfoPtr_currPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (currPivot));
    CharacterBoundariesController.NativeFieldInfoPtr_currSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (currSize));
    CharacterBoundariesController.NativeFieldInfoPtr_currCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (currCenter));
    CharacterBoundariesController.NativeFieldInfoPtr_lastPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (lastPivot));
    CharacterBoundariesController.NativeFieldInfoPtr_boundsDefaultCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (boundsDefaultCenter));
    CharacterBoundariesController.NativeFieldInfoPtr_boundsDefaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (boundsDefaultSize));
    CharacterBoundariesController.NativeFieldInfoPtr_hurtboxDefaultCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (hurtboxDefaultCenter));
    CharacterBoundariesController.NativeFieldInfoPtr_hurtboxDefaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (hurtboxDefaultSize));
    CharacterBoundariesController.NativeFieldInfoPtr_frameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (frameSize));
    CharacterBoundariesController.NativeFieldInfoPtr_frameCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, nameof (frameCenter));
    CharacterBoundariesController.NativeMethodInfoPtr_get_LastPivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674872);
    CharacterBoundariesController.NativeMethodInfoPtr_get_CurrPivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674873);
    CharacterBoundariesController.NativeMethodInfoPtr_get_CurrSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674874);
    CharacterBoundariesController.NativeMethodInfoPtr_get_CurrCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674875);
    CharacterBoundariesController.NativeMethodInfoPtr_get_DefaultCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674876);
    CharacterBoundariesController.NativeMethodInfoPtr_get_DefaultSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674877);
    CharacterBoundariesController.NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674878);
    CharacterBoundariesController.NativeMethodInfoPtr_get_FrameSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674879);
    CharacterBoundariesController.NativeMethodInfoPtr_get_FrameCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674880);
    CharacterBoundariesController.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674881);
    CharacterBoundariesController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674882);
    CharacterBoundariesController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674883);
    CharacterBoundariesController.NativeMethodInfoPtr_OnFramePreUpdated_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674884);
    CharacterBoundariesController.NativeMethodInfoPtr_OnClipStarted_Private_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674885);
    CharacterBoundariesController.NativeMethodInfoPtr_ResetImmediate_Public_Void_Vector3_Vector3_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674886);
    CharacterBoundariesController.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674887);
    CharacterBoundariesController.NativeMethodInfoPtr_BlendToFSM_Public_Void_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674888);
    CharacterBoundariesController.NativeMethodInfoPtr_Blend_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674889);
    CharacterBoundariesController.NativeMethodInfoPtr_SnapToBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674890);
    CharacterBoundariesController.NativeMethodInfoPtr_EnableBoundaries_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674891);
    CharacterBoundariesController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674892);
    CharacterBoundariesController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674893);
    CharacterBoundariesController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr, 100674894);
  }

  public unsafe Vector3 LastPivot
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_LastPivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 CurrPivot
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_CurrPivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 CurrSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_CurrSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 CurrCenter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_CurrCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 DefaultCenter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_DefaultCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 DefaultSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_DefaultSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Bounds Bounds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113928, XrefRangeEnd = 113929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 FrameSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_FrameSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 FrameCenter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_get_FrameCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113935, RefRangeEnd = 113936, XrefRangeStart = 113929, XrefRangeEnd = 113935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ClosestPoint(Vector3 pos, float offset = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &offset;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113936, XrefRangeEnd = 113985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113985, XrefRangeEnd = 114009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114009, XrefRangeEnd = 114020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnFramePreUpdated(MeshClipFrame currentFrame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentFrame)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_OnFramePreUpdated_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114020, XrefRangeEnd = 114022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnClipStarted(MeshClip currentClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentClip)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_OnClipStarted_Private_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 114035, RefRangeEnd = 114037, XrefRangeStart = 114022, XrefRangeEnd = 114035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetImmediate(
    Vector3 center,
    Vector3 size,
    Vector2 pivot,
    bool resetBoundaries)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &center;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &size;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &resetBoundaries;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_ResetImmediate_Public_Void_Vector3_Vector3_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114037, XrefRangeEnd = 114038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114038, XrefRangeEnd = 114045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BlendToFSM(FSMGraph targetGraph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetGraph)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_BlendToFSM_Public_Void_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114049, RefRangeEnd = 114050, XrefRangeStart = 114045, XrefRangeEnd = 114049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Blend(Vector2 blendOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &blendOffset
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_Blend_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114050, XrefRangeEnd = 114056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapToBounds()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_SnapToBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 114057, RefRangeEnd = 114062, XrefRangeStart = 114056, XrefRangeEnd = 114057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableBoundaries(bool enable, bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &enable;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &force;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_EnableBoundaries_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114062, XrefRangeEnd = 114063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnKill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &deathType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114063, XrefRangeEnd = 114065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnRespawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114065, XrefRangeEnd = 114066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterBoundariesController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBoundariesController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBoundariesController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform hurtbox
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_hurtbox));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_hurtbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ignoreColliderDisablingOnDeath
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_ignoreColliderDisablingOnDeath));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_ignoreColliderDisablingOnDeath)) = value;
    }
  }

  public static unsafe float pixelsPerUnit
  {
    get
    {
      float pixelsPerUnit;
      IL2CPP.il2cpp_field_static_get_value(CharacterBoundariesController.NativeFieldInfoPtr_pixelsPerUnit, (void*) &pixelsPerUnit);
      return pixelsPerUnit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterBoundariesController.NativeFieldInfoPtr_pixelsPerUnit, (void*) &value);
    }
  }

  public unsafe Vector2 defaultPivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_defaultPivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_defaultPivot)) = value;
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_personPhysics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoxCollider col
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_col));
      return num == IntPtr.Zero ? (BoxCollider) null : Il2CppObjectPool.Get<BoxCollider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterDeathController deathController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_deathController));
      return num == IntPtr.Zero ? (CharacterDeathController) null : Il2CppObjectPool.Get<CharacterDeathController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_deathController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteAnimator spriteAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_spriteAnimator));
      return num == IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 currPivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_currPivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_currPivot)) = value;
    }
  }

  public unsafe Vector2 currSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_currSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_currSize)) = value;
    }
  }

  public unsafe Vector2 currCenter
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_currCenter));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_currCenter)) = value;
    }
  }

  public unsafe Vector2 lastPivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_lastPivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_lastPivot)) = value;
    }
  }

  public unsafe Vector3 boundsDefaultCenter
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_boundsDefaultCenter));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_boundsDefaultCenter)) = value;
    }
  }

  public unsafe Vector3 boundsDefaultSize
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_boundsDefaultSize));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_boundsDefaultSize)) = value;
    }
  }

  public unsafe Vector3 hurtboxDefaultCenter
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_hurtboxDefaultCenter));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_hurtboxDefaultCenter)) = value;
    }
  }

  public unsafe Vector3 hurtboxDefaultSize
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_hurtboxDefaultSize));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_hurtboxDefaultSize)) = value;
    }
  }

  public unsafe Vector3 frameSize
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_frameSize));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_frameSize)) = value;
    }
  }

  public unsafe Vector3 frameCenter
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_frameCenter));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBoundariesController.NativeFieldInfoPtr_frameCenter)) = value;
    }
  }
}
