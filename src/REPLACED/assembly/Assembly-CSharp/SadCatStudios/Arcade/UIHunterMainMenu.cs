// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.UIHunterMainMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class UIHunterMainMenu(IntPtr pointer) : UISubmenuHandler(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_topLevel;
  private static readonly IntPtr NativeFieldInfoPtr_controlElements;
  private static readonly IntPtr NativeFieldInfoPtr_highscoreControls;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialControls;
  private static readonly IntPtr NativeFieldInfoPtr_startButton;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FromTopLevel_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToTopLevel_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ExitMenu_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowHighscoreControls_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowTutorialControls_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIHunterMainMenu()
  {
    Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (UIHunterMainMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr);
    UIHunterMainMenu.NativeFieldInfoPtr_topLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, nameof (topLevel));
    UIHunterMainMenu.NativeFieldInfoPtr_controlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, nameof (controlElements));
    UIHunterMainMenu.NativeFieldInfoPtr_highscoreControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, nameof (highscoreControls));
    UIHunterMainMenu.NativeFieldInfoPtr_tutorialControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, nameof (tutorialControls));
    UIHunterMainMenu.NativeFieldInfoPtr_startButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, nameof (startButton));
    UIHunterMainMenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676578);
    UIHunterMainMenu.NativeMethodInfoPtr_FromTopLevel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676579);
    UIHunterMainMenu.NativeMethodInfoPtr_ToTopLevel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676580);
    UIHunterMainMenu.NativeMethodInfoPtr_ExitMenu_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676581);
    UIHunterMainMenu.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676582);
    UIHunterMainMenu.NativeMethodInfoPtr_ShowHighscoreControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676583);
    UIHunterMainMenu.NativeMethodInfoPtr_ShowTutorialControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676584);
    UIHunterMainMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr, 100676585);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124495, XrefRangeEnd = 124501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHunterMainMenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124501, XrefRangeEnd = 124503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void FromTopLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHunterMainMenu.NativeMethodInfoPtr_FromTopLevel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124503, XrefRangeEnd = 124509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ToTopLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHunterMainMenu.NativeMethodInfoPtr_ToTopLevel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124509, XrefRangeEnd = 124514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ExitMenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHunterMainMenu.NativeMethodInfoPtr_ExitMenu_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHunterMainMenu.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124514, XrefRangeEnd = 124519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowHighscoreControls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHunterMainMenu.NativeMethodInfoPtr_ShowHighscoreControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124519, XrefRangeEnd = 124524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowTutorialControls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHunterMainMenu.NativeMethodInfoPtr_ShowTutorialControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIHunterMainMenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHunterMainMenu>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHunterMainMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject topLevel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_topLevel));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_topLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> controlElements
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_controlElements));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_controlElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> highscoreControls
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_highscoreControls));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_highscoreControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ArcadeGameManager.ControlElement> tutorialControls
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_tutorialControls));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ArcadeGameManager.ControlElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeGameManager.ControlElement>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_tutorialControls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject startButton
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_startButton));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHunterMainMenu.NativeFieldInfoPtr_startButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
