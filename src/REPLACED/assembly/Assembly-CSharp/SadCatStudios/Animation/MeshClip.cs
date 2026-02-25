// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Animation;

public class MeshClip(System.IntPtr pointer) : SerializedScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_loop;
  private static readonly System.IntPtr NativeFieldInfoPtr_loopStartIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoDisable;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshClipEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_animSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_startupSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_recoverySpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_slicesDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_frames;
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteSheet;
  private static readonly System.IntPtr NativeFieldInfoPtr_normalSheet;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_scale;
  private static readonly System.IntPtr NativeFieldInfoPtr_lerpOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreCollision;
  private static readonly System.IntPtr NativeFieldInfoPtr_UseClipSizedBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_SupportPivotBlending;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshClipEventNames;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AutoDisable_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IgnoreCollision_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Frames_Public_get_Il2CppReferenceArray_1_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SlicesDictionary_Public_get_SlicesDict_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpriteSheet_Public_get_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalSheet_Public_get_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimSpeed_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartupSpeed_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveSpeed_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RecoverySpeed_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LoopStartIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LerpOffset_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MeshClipEvents_Public_get_MeshClipEventDict_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Duration_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StateDuration_Public_Single_FrameState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameRuntimeDuration_Public_Single_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameRuntimeSpeedMultiplier_Public_Single_MeshClipFrame_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshClipEvent_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InEventRange_Private_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HurtboxEnabled_Public_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InParryWindow_Public_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InPoiseFrames_Public_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InPerfectFrames_Public_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InTrailFrames_Public_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InPerfectParryWindow_Public_Boolean_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshClip()
  {
    Il2CppClassPointerStore<MeshClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshClip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClip>.NativeClassPtr);
    MeshClip.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (loop));
    MeshClip.NativeFieldInfoPtr_loopStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (loopStartIndex));
    MeshClip.NativeFieldInfoPtr_autoDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (autoDisable));
    MeshClip.NativeFieldInfoPtr_meshClipEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (meshClipEvents));
    MeshClip.NativeFieldInfoPtr_animSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (animSpeed));
    MeshClip.NativeFieldInfoPtr_startupSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (startupSpeed));
    MeshClip.NativeFieldInfoPtr_activeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (activeSpeed));
    MeshClip.NativeFieldInfoPtr_recoverySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (recoverySpeed));
    MeshClip.NativeFieldInfoPtr_slicesDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (slicesDictionary));
    MeshClip.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (frames));
    MeshClip.NativeFieldInfoPtr_spriteSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (spriteSheet));
    MeshClip.NativeFieldInfoPtr_normalSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (normalSheet));
    MeshClip.NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (positionOffset));
    MeshClip.NativeFieldInfoPtr_rotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (rotationOffset));
    MeshClip.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (scale));
    MeshClip.NativeFieldInfoPtr_lerpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (lerpOffset));
    MeshClip.NativeFieldInfoPtr_ignoreCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (ignoreCollision));
    MeshClip.NativeFieldInfoPtr_UseClipSizedBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (UseClipSizedBounds));
    MeshClip.NativeFieldInfoPtr_SupportPivotBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (SupportPivotBlending));
    MeshClip.NativeFieldInfoPtr_meshClipEventNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (meshClipEventNames));
    MeshClip.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676774);
    MeshClip.NativeMethodInfoPtr_get_AutoDisable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676775);
    MeshClip.NativeMethodInfoPtr_get_IgnoreCollision_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676776);
    MeshClip.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppReferenceArray_1_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676777);
    MeshClip.NativeMethodInfoPtr_get_SlicesDictionary_Public_get_SlicesDict_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676778);
    MeshClip.NativeMethodInfoPtr_get_SpriteSheet_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676779);
    MeshClip.NativeMethodInfoPtr_get_NormalSheet_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676780);
    MeshClip.NativeMethodInfoPtr_get_AnimSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676781);
    MeshClip.NativeMethodInfoPtr_get_StartupSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676782);
    MeshClip.NativeMethodInfoPtr_get_ActiveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676783);
    MeshClip.NativeMethodInfoPtr_get_RecoverySpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676784);
    MeshClip.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676785);
    MeshClip.NativeMethodInfoPtr_get_LoopStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676786);
    MeshClip.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676787);
    MeshClip.NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676788);
    MeshClip.NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676789);
    MeshClip.NativeMethodInfoPtr_get_LerpOffset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676790);
    MeshClip.NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676791);
    MeshClip.NativeMethodInfoPtr_get_MeshClipEvents_Public_get_MeshClipEventDict_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676792);
    MeshClip.NativeMethodInfoPtr_Duration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676793);
    MeshClip.NativeMethodInfoPtr_StateDuration_Public_Single_FrameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676794);
    MeshClip.NativeMethodInfoPtr_FrameRuntimeDuration_Public_Single_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676795);
    MeshClip.NativeMethodInfoPtr_FrameRuntimeSpeedMultiplier_Public_Single_MeshClipFrame_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676796);
    MeshClip.NativeMethodInfoPtr_GetMeshClipEvent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676797);
    MeshClip.NativeMethodInfoPtr_InEventRange_Private_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676798);
    MeshClip.NativeMethodInfoPtr_HurtboxEnabled_Public_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676799);
    MeshClip.NativeMethodInfoPtr_InParryWindow_Public_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676800);
    MeshClip.NativeMethodInfoPtr_InPoiseFrames_Public_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676801);
    MeshClip.NativeMethodInfoPtr_InPerfectFrames_Public_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676802);
    MeshClip.NativeMethodInfoPtr_InTrailFrames_Public_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676803);
    MeshClip.NativeMethodInfoPtr_InPerfectParryWindow_Public_Boolean_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676804);
    MeshClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, 100676805);
  }

  public unsafe bool Loop
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool AutoDisable
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_AutoDisable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IgnoreCollision
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_IgnoreCollision_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppReferenceArray<MeshClipFrame> Frames
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppReferenceArray_1_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<MeshClipFrame>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<MeshClipFrame>>(num3);
    }
  }

  public unsafe MeshClip.SlicesDict SlicesDictionary
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_SlicesDictionary_Public_get_SlicesDict_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClip.SlicesDict) null : Il2CppObjectPool.Get<MeshClip.SlicesDict>(num3);
    }
  }

  public unsafe Texture2D SpriteSheet
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_SpriteSheet_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num3);
    }
  }

  public unsafe Texture2D NormalSheet
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_NormalSheet_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num3);
    }
  }

  public unsafe float AnimSpeed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_AnimSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float StartupSpeed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_StartupSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float ActiveSpeed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_ActiveSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float RecoverySpeed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_RecoverySpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int Length
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 126278, RefRangeEnd = 126279, XrefRangeStart = 126278, XrefRangeEnd = 126278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int LoopStartIndex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_LoopStartIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 PositionOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 RotationOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 Scale
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool LerpOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_LerpOffset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float TotalDuration
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126279, XrefRangeEnd = 126286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MeshClip.MeshClipEventDict MeshClipEvents
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_get_MeshClipEvents_Public_get_MeshClipEventDict_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClip.MeshClipEventDict) null : Il2CppObjectPool.Get<MeshClip.MeshClipEventDict>(num3);
    }
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 126290, RefRangeEnd = 126319, XrefRangeStart = 126286, XrefRangeEnd = 126290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Duration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_Duration_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 126321, RefRangeEnd = 126330, XrefRangeStart = 126319, XrefRangeEnd = 126321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float StateDuration(FrameState frameState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &frameState
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_StateDuration_Public_Single_FrameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126331, RefRangeEnd = 126332, XrefRangeStart = 126330, XrefRangeEnd = 126331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float FrameRuntimeDuration(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_FrameRuntimeDuration_Public_Single_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 126332, RefRangeEnd = 126334, XrefRangeStart = 126332, XrefRangeEnd = 126332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float FrameRuntimeSpeedMultiplier(
    MeshClipFrame frame,
    float externalSpeedIncrement = 0.0f,
    float startupExternalSpeedIncrement = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &externalSpeedIncrement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startupExternalSpeedIncrement;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_FrameRuntimeSpeedMultiplier_Public_Single_MeshClipFrame_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 126364, RefRangeEnd = 126366, XrefRangeStart = 126334, XrefRangeEnd = 126364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetMeshClipEvent<T>() where T : MeshClipEvent
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.MethodInfoStoreGeneric_GetMeshClipEvent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 126369, RefRangeEnd = 126375, XrefRangeStart = 126366, XrefRangeEnd = 126369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InEventRange<T>(MeshClipFrame frame) where T : MeshClipEvent
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.MethodInfoStoreGeneric_InEventRange_Private_Boolean_MeshClipFrame_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126378, RefRangeEnd = 126381, XrefRangeStart = 126375, XrefRangeEnd = 126378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HurtboxEnabled(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_HurtboxEnabled_Public_Boolean_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126384, RefRangeEnd = 126387, XrefRangeStart = 126381, XrefRangeEnd = 126384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InParryWindow(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_InParryWindow_Public_Boolean_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126390, RefRangeEnd = 126391, XrefRangeStart = 126387, XrefRangeEnd = 126390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InPoiseFrames(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_InPoiseFrames_Public_Boolean_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126391, XrefRangeEnd = 126394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InPerfectFrames(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_InPerfectFrames_Public_Boolean_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126394, XrefRangeEnd = 126397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InTrailFrames(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_InTrailFrames_Public_Boolean_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126400, RefRangeEnd = 126403, XrefRangeStart = 126397, XrefRangeEnd = 126400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InPerfectParryWindow(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr_InPerfectParryWindow_Public_Boolean_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126403, XrefRangeEnd = 126406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClip>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool loop
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_loop));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_loop)) = value;
    }
  }

  public unsafe int loopStartIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_loopStartIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_loopStartIndex)) = value;
    }
  }

  public unsafe bool autoDisable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_autoDisable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_autoDisable)) = value;
    }
  }

  public unsafe MeshClip.MeshClipEventDict meshClipEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_meshClipEvents));
      return num == System.IntPtr.Zero ? (MeshClip.MeshClipEventDict) null : Il2CppObjectPool.Get<MeshClip.MeshClipEventDict>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_meshClipEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float animSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_animSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_animSpeed)) = value;
    }
  }

  public unsafe float startupSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_startupSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_startupSpeed)) = value;
    }
  }

  public unsafe float activeSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_activeSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_activeSpeed)) = value;
    }
  }

  public unsafe float recoverySpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_recoverySpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_recoverySpeed)) = value;
    }
  }

  public unsafe MeshClip.SlicesDict slicesDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_slicesDictionary));
      return num == System.IntPtr.Zero ? (MeshClip.SlicesDict) null : Il2CppObjectPool.Get<MeshClip.SlicesDict>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_slicesDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MeshClipFrame> frames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_frames));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<MeshClipFrame>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<MeshClipFrame>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D spriteSheet
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_spriteSheet));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_spriteSheet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D normalSheet
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_normalSheet));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_normalSheet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 positionOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_positionOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_positionOffset)) = value;
    }
  }

  public unsafe Vector3 rotationOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_rotationOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_rotationOffset)) = value;
    }
  }

  public unsafe Vector3 scale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_scale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_scale)) = value;
    }
  }

  public unsafe bool lerpOffset
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_lerpOffset));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_lerpOffset)) = value;
    }
  }

  public unsafe bool ignoreCollision
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_ignoreCollision));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_ignoreCollision)) = value;
    }
  }

  public unsafe bool UseClipSizedBounds
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_UseClipSizedBounds));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_UseClipSizedBounds)) = value;
    }
  }

  public unsafe bool SupportPivotBlending
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_SupportPivotBlending));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_SupportPivotBlending)) = value;
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, string> meshClipEventNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_meshClipEventNames));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, string>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClip.NativeFieldInfoPtr_meshClipEventNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class MeshClipEventDict(System.IntPtr pointer) : 
    UnitySerializedReferenceDictionary<string, MeshClipEvent>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MeshClipEventDict()
    {
      Il2CppClassPointerStore<MeshClip.MeshClipEventDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (MeshClipEventDict));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClip.MeshClipEventDict>.NativeClassPtr);
      MeshClip.MeshClipEventDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip.MeshClipEventDict>.NativeClassPtr, 100676806);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126272, XrefRangeEnd = 126275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MeshClipEventDict()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClip.MeshClipEventDict>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshClip.MeshClipEventDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class SlicesDict(System.IntPtr pointer) : UnitySerializedDictionary<string, SliceObject>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SlicesDict()
    {
      Il2CppClassPointerStore<MeshClip.SlicesDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshClip>.NativeClassPtr, nameof (SlicesDict));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClip.SlicesDict>.NativeClassPtr);
      MeshClip.SlicesDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClip.SlicesDict>.NativeClassPtr, 100676807);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126275, XrefRangeEnd = 126278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SlicesDict()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClip.SlicesDict>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshClip.SlicesDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  private sealed class MethodInfoStoreGeneric_GetMeshClipEvent_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MeshClip.NativeMethodInfoPtr_GetMeshClipEvent_Public_T_0, Il2CppClassPointerStore<MeshClip>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InEventRange_Private_Boolean_MeshClipFrame_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MeshClip.NativeMethodInfoPtr_InEventRange_Private_Boolean_MeshClipFrame_0, Il2CppClassPointerStore<MeshClip>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
