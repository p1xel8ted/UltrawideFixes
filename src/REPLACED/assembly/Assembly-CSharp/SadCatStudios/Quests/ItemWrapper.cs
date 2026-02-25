// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Quests.ItemWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Quests;

public class ItemWrapper(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_itemRef;
  private static readonly IntPtr NativeFieldInfoPtr_disallowPlayingSound;
  private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ItemWrapper()
  {
    Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Quests", nameof (ItemWrapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr);
    ItemWrapper.NativeFieldInfoPtr_itemRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr, nameof (itemRef));
    ItemWrapper.NativeFieldInfoPtr_disallowPlayingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr, nameof (disallowPlayingSound));
    ItemWrapper.NativeMethodInfoPtr_AddItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr, 100671495 /*0x06002007*/);
    ItemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr, 100671496 /*0x06002008*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94613, XrefRangeEnd = 94617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddItem()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ItemWrapper.NativeMethodInfoPtr_AddItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ItemWrapper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemWrapper>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ItemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef itemRef
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemWrapper.NativeFieldInfoPtr_itemRef));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemWrapper.NativeFieldInfoPtr_itemRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool disallowPlayingSound
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemWrapper.NativeFieldInfoPtr_disallowPlayingSound));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemWrapper.NativeFieldInfoPtr_disallowPlayingSound)) = value;
    }
  }
}
