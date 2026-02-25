// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.PDAManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Articy.Unity;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class PDAManager(IntPtr pointer) : LocalSingletonBehaviour<PDAManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_topText;
  private static readonly IntPtr NativeFieldInfoPtr_scrollRect;
  private static readonly IntPtr NativeFieldInfoPtr_topLevelMenu;
  private static readonly IntPtr NativeFieldInfoPtr_mailMenu;
  private static readonly IntPtr NativeFieldInfoPtr_scansMenu;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialsMenu;
  private static readonly IntPtr NativeFieldInfoPtr_objectivesMenu;
  private static readonly IntPtr NativeFieldInfoPtr_musicMenu;
  private static readonly IntPtr NativeFieldInfoPtr_entryView;
  private static readonly IntPtr NativeFieldInfoPtr_entryHeader;
  private static readonly IntPtr NativeFieldInfoPtr_entryImage;
  private static readonly IntPtr NativeFieldInfoPtr_entryText;
  private static readonly IntPtr NativeFieldInfoPtr_entryTextTMP;
  private static readonly IntPtr NativeFieldInfoPtr_musicView;
  private static readonly IntPtr NativeFieldInfoPtr_playButton;
  private static readonly IntPtr NativeFieldInfoPtr_backgroundSound;
  private static readonly IntPtr NativeFieldInfoPtr_confirmSound;
  private static readonly IntPtr NativeFieldInfoPtr_cancelSound;
  private static readonly IntPtr NativeFieldInfoPtr_pdaOpenSound;
  private static readonly IntPtr NativeFieldInfoPtr_pdaOpenMuteEvent;
  private static readonly IntPtr NativeFieldInfoPtr_pdaCloseSound;
  private static readonly IntPtr NativeFieldInfoPtr_scrollTimerTarget;
  private static readonly IntPtr NativeFieldInfoPtr_entryTitleCharactersCount;
  private static readonly IntPtr NativeFieldInfoPtr_scrollTimer;
  private static readonly IntPtr NativeFieldInfoPtr_submenuEntries;
  private static readonly IntPtr NativeFieldInfoPtr_folderIdsToTransform;
  private static readonly IntPtr NativeFieldInfoPtr_topSeparator;
  private static readonly IntPtr NativeFieldInfoPtr_bottomSeparator;
  private static readonly IntPtr NativeFieldInfoPtr_musicPlayer;
  private static readonly IntPtr NativeFieldInfoPtr_entryScroll;
  private static readonly IntPtr NativeFieldInfoPtr_menuEntry;
  private static readonly IntPtr NativeFieldInfoPtr_submenuStack;
  private static readonly IntPtr NativeFieldInfoPtr_textBuilder;
  private static readonly IntPtr NativeFieldInfoPtr_topLevelText;
  private static readonly IntPtr NativeFieldInfoPtr_backgroundSoundInstance;
  private static readonly IntPtr NativeFieldInfoPtr_muteSoundInstance;
  private static readonly IntPtr NativeFieldInfoPtr_possibleProgressValues;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SiblingTrack_Public_PDAMenuEntry_Int32_Boolean_byref_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_EnsureEntryVisibility_Public_Void_PDAMenuEntry_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindAndOpenEntry_Public_Void_ArticyObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_EnterSubmenu_Public_Void_PDAMenuEntry_0;
  private static readonly IntPtr NativeMethodInfoPtr_ExitPDA_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ExitSubmenu_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitializeObjectives_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAManager()
  {
    Il2CppClassPointerStore<PDAManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (PDAManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAManager>.NativeClassPtr);
    PDAManager.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryPrefab));
    PDAManager.NativeFieldInfoPtr_topText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (topText));
    PDAManager.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (scrollRect));
    PDAManager.NativeFieldInfoPtr_topLevelMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (topLevelMenu));
    PDAManager.NativeFieldInfoPtr_mailMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (mailMenu));
    PDAManager.NativeFieldInfoPtr_scansMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (scansMenu));
    PDAManager.NativeFieldInfoPtr_tutorialsMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (tutorialsMenu));
    PDAManager.NativeFieldInfoPtr_objectivesMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (objectivesMenu));
    PDAManager.NativeFieldInfoPtr_musicMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (musicMenu));
    PDAManager.NativeFieldInfoPtr_entryView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryView));
    PDAManager.NativeFieldInfoPtr_entryHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryHeader));
    PDAManager.NativeFieldInfoPtr_entryImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryImage));
    PDAManager.NativeFieldInfoPtr_entryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryText));
    PDAManager.NativeFieldInfoPtr_entryTextTMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryTextTMP));
    PDAManager.NativeFieldInfoPtr_musicView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (musicView));
    PDAManager.NativeFieldInfoPtr_playButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (playButton));
    PDAManager.NativeFieldInfoPtr_backgroundSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (backgroundSound));
    PDAManager.NativeFieldInfoPtr_confirmSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (confirmSound));
    PDAManager.NativeFieldInfoPtr_cancelSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (cancelSound));
    PDAManager.NativeFieldInfoPtr_pdaOpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (pdaOpenSound));
    PDAManager.NativeFieldInfoPtr_pdaOpenMuteEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (pdaOpenMuteEvent));
    PDAManager.NativeFieldInfoPtr_pdaCloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (pdaCloseSound));
    PDAManager.NativeFieldInfoPtr_scrollTimerTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (scrollTimerTarget));
    PDAManager.NativeFieldInfoPtr_entryTitleCharactersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryTitleCharactersCount));
    PDAManager.NativeFieldInfoPtr_scrollTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (scrollTimer));
    PDAManager.NativeFieldInfoPtr_submenuEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (submenuEntries));
    PDAManager.NativeFieldInfoPtr_folderIdsToTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (folderIdsToTransform));
    PDAManager.NativeFieldInfoPtr_topSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (topSeparator));
    PDAManager.NativeFieldInfoPtr_bottomSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (bottomSeparator));
    PDAManager.NativeFieldInfoPtr_musicPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (musicPlayer));
    PDAManager.NativeFieldInfoPtr_entryScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (entryScroll));
    PDAManager.NativeFieldInfoPtr_menuEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (menuEntry));
    PDAManager.NativeFieldInfoPtr_submenuStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (submenuStack));
    PDAManager.NativeFieldInfoPtr_textBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (textBuilder));
    PDAManager.NativeFieldInfoPtr_topLevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (topLevelText));
    PDAManager.NativeFieldInfoPtr_backgroundSoundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (backgroundSoundInstance));
    PDAManager.NativeFieldInfoPtr_muteSoundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (muteSoundInstance));
    PDAManager.NativeFieldInfoPtr_possibleProgressValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (possibleProgressValues));
    PDAManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672045);
    PDAManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672046);
    PDAManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672047);
    PDAManager.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672048);
    PDAManager.NativeMethodInfoPtr_SiblingTrack_Public_PDAMenuEntry_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672049);
    PDAManager.NativeMethodInfoPtr_EnsureEntryVisibility_Public_Void_PDAMenuEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672050);
    PDAManager.NativeMethodInfoPtr_FindAndOpenEntry_Public_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672051);
    PDAManager.NativeMethodInfoPtr_EnterSubmenu_Public_Void_PDAMenuEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672052);
    PDAManager.NativeMethodInfoPtr_ExitPDA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672053);
    PDAManager.NativeMethodInfoPtr_ExitSubmenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672054);
    PDAManager.NativeMethodInfoPtr_InitializeObjectives_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672055);
    PDAManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, 100672056);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97622, XrefRangeEnd = 97676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97676, XrefRangeEnd = 97685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97685, XrefRangeEnd = 97688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97688, XrefRangeEnd = 97707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAManager.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 97726, RefRangeEnd = 97728, XrefRangeStart = 97707, XrefRangeEnd = 97726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAMenuEntry SiblingTrack(int currIndex, bool next, out int newIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &currIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &next;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref newIndex;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_SiblingTrack_Public_PDAMenuEntry_Int32_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (PDAMenuEntry) null : Il2CppObjectPool.Get<PDAMenuEntry>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97728, XrefRangeEnd = 97734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnsureEntryVisibility(PDAMenuEntry entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_EnsureEntryVisibility_Public_Void_PDAMenuEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 97780, RefRangeEnd = 97781, XrefRangeStart = 97734, XrefRangeEnd = 97780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FindAndOpenEntry(ArticyObject item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_FindAndOpenEntry_Public_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 97915, RefRangeEnd = 97918, XrefRangeStart = 97781, XrefRangeEnd = 97915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnterSubmenu(PDAMenuEntry entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_EnterSubmenu_Public_Void_PDAMenuEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 97928, RefRangeEnd = 97929, XrefRangeStart = 97918, XrefRangeEnd = 97928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitPDA()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_ExitPDA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 97989, RefRangeEnd = 97992, XrefRangeStart = 97929, XrefRangeEnd = 97989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitSubmenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_ExitSubmenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98032, RefRangeEnd = 98033, XrefRangeStart = 97992, XrefRangeEnd = 98032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeObjectives()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr_InitializeObjectives_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98033, XrefRangeEnd = 98046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PDAMenuEntry entryPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryPrefab));
      return num == IntPtr.Zero ? (PDAMenuEntry) null : Il2CppObjectPool.Get<PDAMenuEntry>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text topText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topText));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScrollRect scrollRect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scrollRect));
      return num == IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform topLevelMenu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topLevelMenu));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topLevelMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform mailMenu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_mailMenu));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_mailMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform scansMenu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scansMenu));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scansMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform tutorialsMenu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_tutorialsMenu));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_tutorialsMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform objectivesMenu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_objectivesMenu));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_objectivesMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform musicMenu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_musicMenu));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_musicMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform entryView
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryView));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text entryHeader
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryHeader));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image entryImage
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryImage));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PDAEntryText entryText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryText));
      return num == IntPtr.Zero ? (PDAEntryText) null : Il2CppObjectPool.Get<PDAEntryText>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text entryTextTMP
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryTextTMP));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryTextTMP), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform musicView
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_musicView));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_musicView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PDAPlayerButton playButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_playButton));
      return num == IntPtr.Zero ? (PDAPlayerButton) null : Il2CppObjectPool.Get<PDAPlayerButton>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_playButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference backgroundSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_backgroundSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_backgroundSound)) = value;
    }
  }

  public unsafe EventReference confirmSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_confirmSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_confirmSound)) = value;
    }
  }

  public unsafe EventReference cancelSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_cancelSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_cancelSound)) = value;
    }
  }

  public unsafe EventReference pdaOpenSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_pdaOpenSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_pdaOpenSound)) = value;
    }
  }

  public unsafe EventReference pdaOpenMuteEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_pdaOpenMuteEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_pdaOpenMuteEvent)) = value;
    }
  }

  public unsafe EventReference pdaCloseSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_pdaCloseSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_pdaCloseSound)) = value;
    }
  }

  public unsafe float scrollTimerTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scrollTimerTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scrollTimerTarget)) = value;
    }
  }

  public unsafe int entryTitleCharactersCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryTitleCharactersCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryTitleCharactersCount)) = value;
    }
  }

  public unsafe float scrollTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scrollTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_scrollTimer)) = value;
    }
  }

  public unsafe PDAManager.SubmenuDict submenuEntries
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_submenuEntries));
      return num == IntPtr.Zero ? (PDAManager.SubmenuDict) null : Il2CppObjectPool.Get<PDAManager.SubmenuDict>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_submenuEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PDAManager.EntryFolderIDDict folderIdsToTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_folderIdsToTransform));
      return num == IntPtr.Zero ? (PDAManager.EntryFolderIDDict) null : Il2CppObjectPool.Get<PDAManager.EntryFolderIDDict>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_folderIdsToTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image topSeparator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topSeparator));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topSeparator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image bottomSeparator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_bottomSeparator));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_bottomSeparator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PDAMusicPlayer musicPlayer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_musicPlayer));
      return num == IntPtr.Zero ? (PDAMusicPlayer) null : Il2CppObjectPool.Get<PDAMusicPlayer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_musicPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScrollRect entryScroll
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryScroll));
      return num == IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_entryScroll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PDAMenuEntry menuEntry
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_menuEntry));
      return num == IntPtr.Zero ? (PDAMenuEntry) null : Il2CppObjectPool.Get<PDAMenuEntry>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_menuEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Stack<PDAMenuEntry> submenuStack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_submenuStack));
      return num == IntPtr.Zero ? (Stack<PDAMenuEntry>) null : Il2CppObjectPool.Get<Stack<PDAMenuEntry>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_submenuStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder textBuilder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_textBuilder));
      return num == IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_textBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string topLevelText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topLevelText)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_topLevelText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe EventInstance backgroundSoundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_backgroundSoundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_backgroundSoundInstance)) = value;
    }
  }

  public unsafe EventInstance muteSoundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_muteSoundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAManager.NativeFieldInfoPtr_muteSoundInstance)) = value;
    }
  }

  public static unsafe List<QuestProgress> possibleProgressValues
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PDAManager.NativeFieldInfoPtr_possibleProgressValues, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (List<QuestProgress>) null : Il2CppObjectPool.Get<List<QuestProgress>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PDAManager.NativeFieldInfoPtr_possibleProgressValues, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class EntryWrapper(IntPtr pointer) : 
    ListSerializationWrapper<PDAMenuEntry, PDAManager.EntryWrapper>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static EntryWrapper()
    {
      Il2CppClassPointerStore<PDAManager.EntryWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (EntryWrapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAManager.EntryWrapper>.NativeClassPtr);
      PDAManager.EntryWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager.EntryWrapper>.NativeClassPtr, 100672057);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97613, XrefRangeEnd = 97616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntryWrapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAManager.EntryWrapper>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PDAManager.EntryWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class SubmenuDict(IntPtr pointer) : 
    UnitySerializedDictionary<Transform, PDAManager.EntryWrapper>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SubmenuDict()
    {
      Il2CppClassPointerStore<PDAManager.SubmenuDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (SubmenuDict));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAManager.SubmenuDict>.NativeClassPtr);
      PDAManager.SubmenuDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager.SubmenuDict>.NativeClassPtr, 100672058);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97616, XrefRangeEnd = 97619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubmenuDict()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAManager.SubmenuDict>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PDAManager.SubmenuDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class EntryFolderIDDict(IntPtr pointer) : UnitySerializedDictionary<ulong, Transform>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static EntryFolderIDDict()
    {
      Il2CppClassPointerStore<PDAManager.EntryFolderIDDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PDAManager>.NativeClassPtr, nameof (EntryFolderIDDict));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAManager.EntryFolderIDDict>.NativeClassPtr);
      PDAManager.EntryFolderIDDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAManager.EntryFolderIDDict>.NativeClassPtr, 100672059);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97619, XrefRangeEnd = 97622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntryFolderIDDict()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAManager.EntryFolderIDDict>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PDAManager.EntryFolderIDDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
