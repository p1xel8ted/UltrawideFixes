// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.InvadersSpriteAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class InvadersSpriteAnimator(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_sprites;
  private static readonly IntPtr NativeFieldInfoPtr_frameTiming;
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NextSprite_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvadersSpriteAnimator()
  {
    Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (InvadersSpriteAnimator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr);
    InvadersSpriteAnimator.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, nameof (sprites));
    InvadersSpriteAnimator.NativeFieldInfoPtr_frameTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, nameof (frameTiming));
    InvadersSpriteAnimator.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, nameof (spriteRenderer));
    InvadersSpriteAnimator.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, nameof (timer));
    InvadersSpriteAnimator.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, nameof (spriteIndex));
    InvadersSpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, 100676658);
    InvadersSpriteAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, 100676659);
    InvadersSpriteAnimator.NativeMethodInfoPtr_NextSprite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, 100676660);
    InvadersSpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr, 100676661);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125153, XrefRangeEnd = 125156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersSpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125156, XrefRangeEnd = 125158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersSpriteAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125158, XrefRangeEnd = 125161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersSpriteAnimator.NativeMethodInfoPtr_NextSprite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125161, XrefRangeEnd = 125162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvadersSpriteAnimator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersSpriteAnimator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersSpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Sprite> sprites
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_sprites));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float frameTiming
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_frameTiming));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_frameTiming)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_spriteRenderer));
      return num == IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_timer)) = value;
    }
  }

  public unsafe int spriteIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_spriteIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersSpriteAnimator.NativeFieldInfoPtr_spriteIndex)) = value;
    }
  }
}
