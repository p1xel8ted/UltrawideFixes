// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.PDAInputAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Animation;

public class PDAInputAnimation(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_PDAPressOk;
  private static readonly IntPtr NativeFieldInfoPtr_PDAPressBack;
  private static readonly IntPtr NativeFieldInfoPtr_PDAScroll;
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_scrollEvent;
  private static readonly IntPtr NativeFieldInfoPtr_scrollInstance;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayScrollSound_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAInputAnimation()
  {
    Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (PDAInputAnimation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr);
    PDAInputAnimation.NativeFieldInfoPtr_PDAPressOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, nameof (PDAPressOk));
    PDAInputAnimation.NativeFieldInfoPtr_PDAPressBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, nameof (PDAPressBack));
    PDAInputAnimation.NativeFieldInfoPtr_PDAScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, nameof (PDAScroll));
    PDAInputAnimation.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, nameof (animator));
    PDAInputAnimation.NativeFieldInfoPtr_scrollEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, nameof (scrollEvent));
    PDAInputAnimation.NativeFieldInfoPtr_scrollInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, nameof (scrollInstance));
    PDAInputAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, 100676884);
    PDAInputAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, 100676885);
    PDAInputAnimation.NativeMethodInfoPtr_PlayScrollSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, 100676886);
    PDAInputAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, 100676887);
    PDAInputAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr, 100676888);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126617, XrefRangeEnd = 126624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAInputAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126624, XrefRangeEnd = 126657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAInputAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayScrollSound()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAInputAnimation.NativeMethodInfoPtr_PlayScrollSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126657, XrefRangeEnd = 126658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAInputAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAInputAnimation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAInputAnimation>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAInputAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int PDAPressOk
  {
    get
    {
      int pdaPressOk;
      IL2CPP.il2cpp_field_static_get_value(PDAInputAnimation.NativeFieldInfoPtr_PDAPressOk, (void*) &pdaPressOk);
      return pdaPressOk;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PDAInputAnimation.NativeFieldInfoPtr_PDAPressOk, (void*) &value);
    }
  }

  public static unsafe int PDAPressBack
  {
    get
    {
      int pdaPressBack;
      IL2CPP.il2cpp_field_static_get_value(PDAInputAnimation.NativeFieldInfoPtr_PDAPressBack, (void*) &pdaPressBack);
      return pdaPressBack;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PDAInputAnimation.NativeFieldInfoPtr_PDAPressBack, (void*) &value);
    }
  }

  public static unsafe int PDAScroll
  {
    get
    {
      int pdaScroll;
      IL2CPP.il2cpp_field_static_get_value(PDAInputAnimation.NativeFieldInfoPtr_PDAScroll, (void*) &pdaScroll);
      return pdaScroll;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PDAInputAnimation.NativeFieldInfoPtr_PDAScroll, (void*) &value);
    }
  }

  public unsafe Animator animator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAInputAnimation.NativeFieldInfoPtr_animator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAInputAnimation.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference scrollEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAInputAnimation.NativeFieldInfoPtr_scrollEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAInputAnimation.NativeFieldInfoPtr_scrollEvent)) = value;
    }
  }

  public unsafe EventInstance scrollInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAInputAnimation.NativeFieldInfoPtr_scrollInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAInputAnimation.NativeFieldInfoPtr_scrollInstance)) = value;
    }
  }
}
