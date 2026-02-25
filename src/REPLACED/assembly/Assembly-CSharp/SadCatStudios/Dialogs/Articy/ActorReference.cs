// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.ActorReference
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class ActorReference(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_actor;
  private static readonly IntPtr NativeFieldInfoPtr_spriteAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_speechController;
  private static readonly IntPtr NativeMethodInfoPtr_get_Actor_Public_get_ActorObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpriteAnimator_Public_get_SpriteAnimator_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpeechController_Public_get_SpeechController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ActorReference()
  {
    Il2CppClassPointerStore<ActorReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (ActorReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorReference>.NativeClassPtr);
    ActorReference.NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, nameof (actor));
    ActorReference.NativeFieldInfoPtr_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, nameof (spriteAnimator));
    ActorReference.NativeFieldInfoPtr_speechController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, nameof (speechController));
    ActorReference.NativeMethodInfoPtr_get_Actor_Public_get_ActorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, 100672680);
    ActorReference.NativeMethodInfoPtr_get_SpriteAnimator_Public_get_SpriteAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, 100672681);
    ActorReference.NativeMethodInfoPtr_get_SpeechController_Public_get_SpeechController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, 100672682);
    ActorReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorReference>.NativeClassPtr, 100672683);
  }

  public unsafe ActorObject Actor
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorReference.NativeMethodInfoPtr_get_Actor_Public_get_ActorObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ActorObject) null : Il2CppObjectPool.Get<ActorObject>(num3);
    }
  }

  public unsafe SpriteAnimator SpriteAnimator
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorReference.NativeMethodInfoPtr_get_SpriteAnimator_Public_get_SpriteAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num3);
    }
  }

  public unsafe SpeechController SpeechController
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 102754, RefRangeEnd = 102757, XrefRangeStart = 102747, XrefRangeEnd = 102754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorReference.NativeMethodInfoPtr_get_SpeechController_Public_get_SpeechController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (SpeechController) null : Il2CppObjectPool.Get<SpeechController>(num3);
    }
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActorReference()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorReference>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActorReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ActorObject actor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorReference.NativeFieldInfoPtr_actor));
      return num == IntPtr.Zero ? (ActorObject) null : Il2CppObjectPool.Get<ActorObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActorReference.NativeFieldInfoPtr_actor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteAnimator spriteAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorReference.NativeFieldInfoPtr_spriteAnimator));
      return num == IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActorReference.NativeFieldInfoPtr_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpeechController speechController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorReference.NativeFieldInfoPtr_speechController));
      return num == IntPtr.Zero ? (SpeechController) null : Il2CppObjectPool.Get<SpeechController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActorReference.NativeFieldInfoPtr_speechController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
