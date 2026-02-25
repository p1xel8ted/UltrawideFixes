// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.SpriteAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Animation;

public class SpriteAnimator(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_playDefaultOnAwake;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoDisable;
  private static readonly System.IntPtr NativeFieldInfoPtr_castShadows;
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_currClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_currFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_nextFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_currIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_clipFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_clipLocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_isFrameUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_isAnimationRunning;
  private static readonly System.IntPtr NativeFieldInfoPtr_ClipStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_ClipLooped;
  private static readonly System.IntPtr NativeFieldInfoPtr_FramePreUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_FramePostUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameBeforeNextUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExternalSpeedIncrement;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartupExternalSpeedIncrement;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentClip_Public_get_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentFrame_Public_get_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NextFrame_Public_get_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentFrameIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClipFinished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFrameUpdated_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClipLocked_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAnimationRunning_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Renderer_Public_get_SpriteRenderer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayDefault_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_MeshClip_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SampleFrame_Public_MeshClipFrame_MeshClip_Double_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayFrame_Public_Void_MeshClip_Double_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFrame_Public_Void_MeshClip_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitClip_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Continue_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueCurrentClip_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForPlay_Public_IEnumerator_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Animate_Private_IEnumerator_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_MeshClipFrame_PDM_0;

  static SpriteAnimator()
  {
    Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (SpriteAnimator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr);
    SpriteAnimator.NativeFieldInfoPtr_playDefaultOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (playDefaultOnAwake));
    SpriteAnimator.NativeFieldInfoPtr_defaultClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (defaultClip));
    SpriteAnimator.NativeFieldInfoPtr_autoDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (autoDisable));
    SpriteAnimator.NativeFieldInfoPtr_castShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (castShadows));
    SpriteAnimator.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (spriteRenderer));
    SpriteAnimator.NativeFieldInfoPtr_currClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (currClip));
    SpriteAnimator.NativeFieldInfoPtr_currFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (currFrame));
    SpriteAnimator.NativeFieldInfoPtr_nextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (nextFrame));
    SpriteAnimator.NativeFieldInfoPtr_currIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (currIndex));
    SpriteAnimator.NativeFieldInfoPtr_clipFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (clipFinished));
    SpriteAnimator.NativeFieldInfoPtr_clipLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (clipLocked));
    SpriteAnimator.NativeFieldInfoPtr_isFrameUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (isFrameUpdated));
    SpriteAnimator.NativeFieldInfoPtr_isAnimationRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (isAnimationRunning));
    SpriteAnimator.NativeFieldInfoPtr_ClipStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (ClipStarted));
    SpriteAnimator.NativeFieldInfoPtr_ClipLooped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (ClipLooped));
    SpriteAnimator.NativeFieldInfoPtr_FramePreUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (FramePreUpdated));
    SpriteAnimator.NativeFieldInfoPtr_FramePostUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (FramePostUpdated));
    SpriteAnimator.NativeFieldInfoPtr_FrameBeforeNextUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (FrameBeforeNextUpdated));
    SpriteAnimator.NativeFieldInfoPtr_ExternalSpeedIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (ExternalSpeedIncrement));
    SpriteAnimator.NativeFieldInfoPtr_StartupExternalSpeedIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, nameof (StartupExternalSpeedIncrement));
    SpriteAnimator.NativeMethodInfoPtr_get_CurrentClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676844);
    SpriteAnimator.NativeMethodInfoPtr_get_CurrentFrame_Public_get_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676845);
    SpriteAnimator.NativeMethodInfoPtr_get_NextFrame_Public_get_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676846);
    SpriteAnimator.NativeMethodInfoPtr_get_CurrentFrameIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676847);
    SpriteAnimator.NativeMethodInfoPtr_get_ClipFinished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676848);
    SpriteAnimator.NativeMethodInfoPtr_get_IsFrameUpdated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676849);
    SpriteAnimator.NativeMethodInfoPtr_get_ClipLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676850);
    SpriteAnimator.NativeMethodInfoPtr_get_IsAnimationRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676851);
    SpriteAnimator.NativeMethodInfoPtr_get_Renderer_Public_get_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676852);
    SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676853);
    SpriteAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676854);
    SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676855);
    SpriteAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676856);
    SpriteAnimator.NativeMethodInfoPtr_PlayDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676857);
    SpriteAnimator.NativeMethodInfoPtr_Play_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676858);
    SpriteAnimator.NativeMethodInfoPtr_Play_Public_Void_MeshClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676859);
    SpriteAnimator.NativeMethodInfoPtr_SampleFrame_Public_MeshClipFrame_MeshClip_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676860);
    SpriteAnimator.NativeMethodInfoPtr_PlayFrame_Public_Void_MeshClip_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676861);
    SpriteAnimator.NativeMethodInfoPtr_SetFrame_Public_Void_MeshClip_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676862);
    SpriteAnimator.NativeMethodInfoPtr_InitClip_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676863);
    SpriteAnimator.NativeMethodInfoPtr_Continue_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676864 /*0x06003500*/);
    SpriteAnimator.NativeMethodInfoPtr_ContinueCurrentClip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676865);
    SpriteAnimator.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676866);
    SpriteAnimator.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676867);
    SpriteAnimator.NativeMethodInfoPtr_WaitForPlay_Public_IEnumerator_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676868);
    SpriteAnimator.NativeMethodInfoPtr_Animate_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676869);
    SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676870);
    SpriteAnimator.NativeMethodInfoPtr_Method_Private_Void_MeshClipFrame_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, 100676871);
  }

  public unsafe MeshClip CurrentClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_CurrentClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe MeshClipFrame CurrentFrame
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_CurrentFrame_Public_get_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num3);
    }
  }

  public unsafe MeshClipFrame NextFrame
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_NextFrame_Public_get_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num3);
    }
  }

  public unsafe int CurrentFrameIndex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_CurrentFrameIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ClipFinished
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_ClipFinished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsFrameUpdated
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_IsFrameUpdated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ClipLocked
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_ClipLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsAnimationRunning
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_IsAnimationRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe SpriteRenderer Renderer
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_get_Renderer_Public_get_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126464, XrefRangeEnd = 126467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126467, XrefRangeEnd = 126472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126472, XrefRangeEnd = 126481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116304, RefRangeEnd = 116305, XrefRangeStart = 116304, XrefRangeEnd = 116305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 126486, RefRangeEnd = 126491, XrefRangeStart = 126481, XrefRangeEnd = 126486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayDefault()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_PlayDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126491, XrefRangeEnd = 126494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play(UnityEngine.Object anim)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anim)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Play_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 126502, RefRangeEnd = 126521, XrefRangeStart = 126494, XrefRangeEnd = 126502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play(MeshClip anim, bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anim);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &force;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Play_Public_Void_MeshClip_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 126526, RefRangeEnd = 126528, XrefRangeStart = 126521, XrefRangeEnd = 126526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipFrame SampleFrame(MeshClip anim, double time, bool ignoreLoop = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anim);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreLoop;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_SampleFrame_Public_MeshClipFrame_MeshClip_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126533, RefRangeEnd = 126536, XrefRangeStart = 126528, XrefRangeEnd = 126533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayFrame(MeshClip anim, double time, bool ignoreLoop = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anim);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreLoop;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_PlayFrame_Public_Void_MeshClip_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126549, RefRangeEnd = 126550, XrefRangeStart = 126536, XrefRangeEnd = 126549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFrame(MeshClip clip, MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_SetFrame_Public_Void_MeshClip_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126550, RefRangeEnd = 126551, XrefRangeStart = 126550, XrefRangeEnd = 126550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitClip(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_InitClip_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126556, RefRangeEnd = 126559, XrefRangeStart = 126551, XrefRangeEnd = 126556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Continue(MeshClip anim)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anim)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Continue_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126572, RefRangeEnd = 126573, XrefRangeStart = 126559, XrefRangeEnd = 126572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContinueCurrentClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_ContinueCurrentClip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 126578, RefRangeEnd = 126584, XrefRangeStart = 126573, XrefRangeEnd = 126578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop(bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &force
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 126594, RefRangeEnd = 126607, XrefRangeStart = 126584, XrefRangeEnd = 126594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126607, XrefRangeEnd = 126611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForPlay(MeshClip anim)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anim)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_WaitForPlay_Public_IEnumerator_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126615, RefRangeEnd = 126616, XrefRangeStart = 126611, XrefRangeEnd = 126615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Animate(int startingIndex = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &startingIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Animate_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpriteAnimator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126616, XrefRangeEnd = 126617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_MeshClipFrame_PDM_0(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAnimator.NativeMethodInfoPtr_Method_Private_Void_MeshClipFrame_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool playDefaultOnAwake
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_playDefaultOnAwake));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_playDefaultOnAwake)) = value;
    }
  }

  public unsafe MeshClip defaultClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_defaultClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_defaultClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool autoDisable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_autoDisable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_autoDisable)) = value;
    }
  }

  public unsafe bool castShadows
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_castShadows));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_castShadows)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_spriteRenderer));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip currClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_currClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_currClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClipFrame currFrame
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_currFrame));
      return num == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_currFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClipFrame nextFrame
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_nextFrame));
      return num == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_nextFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_currIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_currIndex)) = value;
    }
  }

  public unsafe bool clipFinished
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_clipFinished));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_clipFinished)) = value;
    }
  }

  public unsafe bool clipLocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_clipLocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_clipLocked)) = value;
    }
  }

  public unsafe bool isFrameUpdated
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_isFrameUpdated));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_isFrameUpdated)) = value;
    }
  }

  public unsafe bool isAnimationRunning
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_isAnimationRunning));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_isAnimationRunning)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<MeshClip> ClipStarted
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_ClipStarted));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<MeshClip>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MeshClip>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_ClipStarted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<MeshClip> ClipLooped
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_ClipLooped));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<MeshClip>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MeshClip>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_ClipLooped), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<MeshClipFrame> FramePreUpdated
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_FramePreUpdated));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<MeshClipFrame>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MeshClipFrame>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_FramePreUpdated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<MeshClipFrame> FramePostUpdated
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_FramePostUpdated));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<MeshClipFrame>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MeshClipFrame>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_FramePostUpdated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<MeshClipFrame> FrameBeforeNextUpdated
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_FrameBeforeNextUpdated));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<MeshClipFrame>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MeshClipFrame>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_FrameBeforeNextUpdated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float ExternalSpeedIncrement
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_ExternalSpeedIncrement));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_ExternalSpeedIncrement)) = value;
    }
  }

  public unsafe float StartupExternalSpeedIncrement
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_StartupExternalSpeedIncrement));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator.NativeFieldInfoPtr_StartupExternalSpeedIncrement)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Animation.SpriteAnimator+<Animate>d__54")]
  public sealed class _Animate_d__54(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_startingIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__index_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__frames_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__frameTimer_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Animate_d__54()
    {
      Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, "<Animate>d__54");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr);
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<>1__state");
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<>2__current");
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr_startingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, nameof (startingIndex));
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<>4__this");
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<index>5__2");
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<timer>5__3");
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__frames_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<frames>5__4");
      SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__frameTimer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, "<frameTimer>5__5");
      SpriteAnimator._Animate_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, 100676872);
      SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, 100676873);
      SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, 100676874);
      SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, 100676875);
      SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, 100676876);
      SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr, 100676877);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Animate_d__54(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAnimator._Animate_d__54>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._Animate_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126440, XrefRangeEnd = 126449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126449, XrefRangeEnd = 126454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._Animate_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int startingIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr_startingIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr_startingIndex)) = value;
      }
    }

    public unsafe SpriteAnimator __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _index_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__index_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__index_5__2)) = value;
      }
    }

    public unsafe float _timer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__timer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__timer_5__3)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<MeshClipFrame> _frames_5__4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__frames_5__4));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<MeshClipFrame>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<MeshClipFrame>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__frames_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _frameTimer_5__5
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__frameTimer_5__5));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._Animate_d__54.NativeFieldInfoPtr__frameTimer_5__5)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Animation.SpriteAnimator+<WaitForPlay>d__53")]
  public sealed class _WaitForPlay_d__53(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_anim;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForPlay_d__53()
    {
      Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAnimator>.NativeClassPtr, "<WaitForPlay>d__53");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr);
      SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, "<>1__state");
      SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, "<>2__current");
      SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, "<>4__this");
      SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, nameof (anim));
      SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, 100676878);
      SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, 100676879);
      SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, 100676880);
      SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, 100676881);
      SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, 100676882);
      SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr, 100676883);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForPlay_d__53(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAnimator._WaitForPlay_d__53>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126454, XrefRangeEnd = 126459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126459, XrefRangeEnd = 126464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAnimator._WaitForPlay_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpriteAnimator __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip anim
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr_anim));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteAnimator._WaitForPlay_d__53.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
