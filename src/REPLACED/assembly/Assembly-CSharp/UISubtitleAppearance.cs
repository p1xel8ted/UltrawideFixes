// Decompiled with JetBrains decompiler
// Type: UISubtitleAppearance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class UISubtitleAppearance(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_textMesh;
  private static readonly System.IntPtr NativeFieldInfoPtr_background;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAppearance_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__3_0_Private_Void_GameSettingsUpdateEvent_0;

  static UISubtitleAppearance()
  {
    Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UISubtitleAppearance));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr);
    UISubtitleAppearance.NativeFieldInfoPtr_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, nameof (textMesh));
    UISubtitleAppearance.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, nameof (background));
    UISubtitleAppearance.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, nameof (eventDisposable));
    UISubtitleAppearance.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, 100663515 /*0x060000DB*/);
    UISubtitleAppearance.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, 100663516 /*0x060000DC*/);
    UISubtitleAppearance.NativeMethodInfoPtr_UpdateAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, 100663517 /*0x060000DD*/);
    UISubtitleAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, 100663518 /*0x060000DE*/);
    UISubtitleAppearance.NativeMethodInfoPtr__Start_b__3_0_Private_Void_GameSettingsUpdateEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr, 100663519 /*0x060000DF*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20153, XrefRangeEnd = 20172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleAppearance.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20172, XrefRangeEnd = 20176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleAppearance.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20176, XrefRangeEnd = 20185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateAppearance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleAppearance.NativeMethodInfoPtr_UpdateAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISubtitleAppearance()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISubtitleAppearance>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20185, XrefRangeEnd = 20194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__3_0(GameSettingsUpdateEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleAppearance.NativeMethodInfoPtr__Start_b__3_0_Private_Void_GameSettingsUpdateEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TextMeshProUGUI textMesh
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleAppearance.NativeFieldInfoPtr_textMesh));
      return num == System.IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleAppearance.NativeFieldInfoPtr_textMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image background
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleAppearance.NativeFieldInfoPtr_background));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleAppearance.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleAppearance.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleAppearance.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
