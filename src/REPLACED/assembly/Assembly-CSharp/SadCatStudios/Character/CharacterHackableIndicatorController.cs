// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterHackableIndicatorController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.Environment.Hacking;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterHackableIndicatorController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_rootAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_animations;
  private static readonly IntPtr NativeFieldInfoPtr_playableGraph;
  private static readonly IntPtr NativeFieldInfoPtr_playableOutput;
  private static readonly IntPtr NativeFieldInfoPtr_hackableSelector;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnClipStarted_Private_Void_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterHackableIndicatorController()
  {
    Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterHackableIndicatorController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr);
    CharacterHackableIndicatorController.NativeFieldInfoPtr_rootAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (rootAnimator));
    CharacterHackableIndicatorController.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (animator));
    CharacterHackableIndicatorController.NativeFieldInfoPtr_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (animations));
    CharacterHackableIndicatorController.NativeFieldInfoPtr_playableGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (playableGraph));
    CharacterHackableIndicatorController.NativeFieldInfoPtr_playableOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (playableOutput));
    CharacterHackableIndicatorController.NativeFieldInfoPtr_hackableSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (hackableSelector));
    CharacterHackableIndicatorController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, 100675151);
    CharacterHackableIndicatorController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, 100675152);
    CharacterHackableIndicatorController.NativeMethodInfoPtr_OnClipStarted_Private_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, 100675153);
    CharacterHackableIndicatorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, 100675154);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115644, XrefRangeEnd = 115677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableIndicatorController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115677, XrefRangeEnd = 115705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableIndicatorController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115705, XrefRangeEnd = 115718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnClipStarted(MeshClip rootClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootClip)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableIndicatorController.NativeMethodInfoPtr_OnClipStarted_Private_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterHackableIndicatorController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHackableIndicatorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteAnimator rootAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_rootAnimator));
      return num == IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_rootAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Animator animator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_animator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHackableIndicatorController.AnimatorClipsDictionary animations
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_animations));
      return num == IntPtr.Zero ? (CharacterHackableIndicatorController.AnimatorClipsDictionary) null : Il2CppObjectPool.Get<CharacterHackableIndicatorController.AnimatorClipsDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_animations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableGraph playableGraph
  {
    get
    {
      return *(PlayableGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_playableGraph));
    }
    [param: In] set
    {
      *(PlayableGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_playableGraph)) = value;
    }
  }

  public unsafe PlayableOutput playableOutput
  {
    get
    {
      return *(PlayableOutput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_playableOutput));
    }
    [param: In] set
    {
      *(PlayableOutput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_playableOutput)) = value;
    }
  }

  public unsafe CharacterHackableSelector hackableSelector
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_hackableSelector));
      return num == IntPtr.Zero ? (CharacterHackableSelector) null : Il2CppObjectPool.Get<CharacterHackableSelector>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHackableIndicatorController.NativeFieldInfoPtr_hackableSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class AnimatorClipsDictionary(IntPtr pointer) : 
    UnitySerializedDictionary<MeshClip, AnimationClip>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static AnimatorClipsDictionary()
    {
      Il2CppClassPointerStore<CharacterHackableIndicatorController.AnimatorClipsDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHackableIndicatorController>.NativeClassPtr, nameof (AnimatorClipsDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHackableIndicatorController.AnimatorClipsDictionary>.NativeClassPtr);
      CharacterHackableIndicatorController.AnimatorClipsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHackableIndicatorController.AnimatorClipsDictionary>.NativeClassPtr, 100675155);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115641, XrefRangeEnd = 115644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimatorClipsDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHackableIndicatorController.AnimatorClipsDictionary>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHackableIndicatorController.AnimatorClipsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
