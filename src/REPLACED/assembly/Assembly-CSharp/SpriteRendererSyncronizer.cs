// Decompiled with JetBrains decompiler
// Type: SpriteRendererSyncronizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SpriteRendererSyncronizer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_mat;
  private static readonly IntPtr NativeFieldInfoPtr_currSprite;
  private static readonly IntPtr NativeFieldInfoPtr_lastSprite;
  private static readonly IntPtr NativeFieldInfoPtr_sprites;
  private static readonly IntPtr NativeFieldInfoPtr_normals;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpriteRendererSyncronizer()
  {
    Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpriteRendererSyncronizer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr);
    SpriteRendererSyncronizer.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, nameof (spriteRenderer));
    SpriteRendererSyncronizer.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, nameof (mat));
    SpriteRendererSyncronizer.NativeFieldInfoPtr_currSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, nameof (currSprite));
    SpriteRendererSyncronizer.NativeFieldInfoPtr_lastSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, nameof (lastSprite));
    SpriteRendererSyncronizer.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, nameof (sprites));
    SpriteRendererSyncronizer.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, nameof (normals));
    SpriteRendererSyncronizer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, 100663378 /*0x06000052*/);
    SpriteRendererSyncronizer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, 100663379 /*0x06000053*/);
    SpriteRendererSyncronizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr, 100663380 /*0x06000054*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16092, XrefRangeEnd = 16096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRendererSyncronizer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16096, XrefRangeEnd = 16111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRendererSyncronizer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16111, XrefRangeEnd = 16122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpriteRendererSyncronizer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRendererSyncronizer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRendererSyncronizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_spriteRenderer));
      return num == IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material mat
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_mat));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D currSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_currSprite));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_currSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D lastSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_lastSprite));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_lastSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Texture2D> sprites
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_sprites));
      return num == IntPtr.Zero ? (List<Texture2D>) null : Il2CppObjectPool.Get<List<Texture2D>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Texture2D> normals
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_normals));
      return num == IntPtr.Zero ? (List<Texture2D>) null : Il2CppObjectPool.Get<List<Texture2D>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRendererSyncronizer.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
