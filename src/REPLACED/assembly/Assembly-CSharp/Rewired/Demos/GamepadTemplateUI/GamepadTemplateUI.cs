// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos.GamepadTemplateUI;

public class GamepadTemplateUI(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_stickRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftStick;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightStick;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftStickButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightStickButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionBottomRow1;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionBottomRow2;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionBottomRow3;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionTopRow1;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionTopRow2;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionTopRow3;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftShoulder;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightShoulder;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_center1;
  private static readonly System.IntPtr NativeFieldInfoPtr_center2;
  private static readonly System.IntPtr NativeFieldInfoPtr_center3;
  private static readonly System.IntPtr NativeFieldInfoPtr_dPadUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_dPadRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_dPadDown;
  private static readonly System.IntPtr NativeFieldInfoPtr_dPadLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiElementsArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiElements;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempTargetList;
  private static readonly System.IntPtr NativeFieldInfoPtr__sticks;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawActiveElements_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActivateElements_Private_Void_Player_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLabels_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLabels_Private_Void_Player_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLabel_Private_Void_ControllerUIElement_InputAction_ControllerMap_IControllerTemplate_IControllerTemplateElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStick_Private_Stick_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerConnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GamepadTemplateUI()
  {
    Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.GamepadTemplateUI", nameof (GamepadTemplateUI));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_stickRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (stickRadius));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (playerId));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (leftStick));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (rightStick));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (leftStickX));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (leftStickY));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (leftStickButton));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (rightStickX));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (rightStickY));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (rightStickButton));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (actionBottomRow1));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (actionBottomRow2));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (actionBottomRow3));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (actionTopRow1));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (actionTopRow2));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (actionTopRow3));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (leftShoulder));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (leftTrigger));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (rightShoulder));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (rightTrigger));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (center1));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (center2));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (center3));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (dPadUp));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (dPadRight));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (dPadDown));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (dPadLeft));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__uiElementsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (_uiElementsArray));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__uiElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (_uiElements));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__tempTargetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (_tempTargetList));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__sticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (_sticks));
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670483);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670484);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670485);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670486);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670487);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawActiveElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670488);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_ActivateElements_Private_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670489);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670490);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_Player_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670491);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawLabel_Private_Void_ControllerUIElement_InputAction_ControllerMap_IControllerTemplate_IControllerTemplateElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670492);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_GetStick_Private_Stick_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670493);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_OnControllerConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670494);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670495);
    Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, 100670496);
  }

  public unsafe Player player
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85084, XrefRangeEnd = 85090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85090, XrefRangeEnd = 85280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85280, XrefRangeEnd = 85288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85288, XrefRangeEnd = 85304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85304, XrefRangeEnd = 85312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85340, RefRangeEnd = 85341, XrefRangeStart = 85312, XrefRangeEnd = 85340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawActiveElements()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawActiveElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85379, RefRangeEnd = 85380, XrefRangeStart = 85341, XrefRangeEnd = 85379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActivateElements(Player player, int actionId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_ActivateElements_Private_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 85402, RefRangeEnd = 85405, XrefRangeStart = 85380, XrefRangeEnd = 85402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawLabels()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85420, RefRangeEnd = 85421, XrefRangeStart = 85405, XrefRangeEnd = 85420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawLabels(Player player, InputAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_Player_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85464, RefRangeEnd = 85465, XrefRangeStart = 85421, XrefRangeEnd = 85464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawLabel(
    ControllerUIElement uiElement,
    InputAction action,
    ControllerMap controllerMap,
    IControllerTemplate template,
    IControllerTemplateElement element)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) uiElement);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) template);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_DrawLabel_Private_Void_ControllerUIElement_InputAction_ControllerMap_IControllerTemplate_IControllerTemplateElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85470, RefRangeEnd = 85471, XrefRangeStart = 85465, XrefRangeEnd = 85470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick GetStick(int elementId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &elementId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_GetStick_Private_Stick_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick) null : Il2CppObjectPool.Get<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85471, XrefRangeEnd = 85472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerConnected(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_OnControllerConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85472, XrefRangeEnd = 85485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GamepadTemplateUI()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float stickRadius
  {
    get
    {
      float stickRadius;
      IL2CPP.il2cpp_field_static_get_value(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_stickRadius, (void*) &stickRadius);
      return stickRadius;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_stickRadius, (void*) &value);
    }
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe RectTransform leftStick
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStick));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rightStick
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStick));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement leftStickX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickX));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement leftStickY
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickY));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickY), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement leftStickButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickButton));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftStickButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement rightStickX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickX));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement rightStickY
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickY));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickY), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement rightStickButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickButton));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightStickButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement actionBottomRow1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow1));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement actionBottomRow2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow2));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement actionBottomRow3
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow3));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement actionTopRow1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow1));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement actionTopRow2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow2));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement actionTopRow3
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow3));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement leftShoulder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftShoulder));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftShoulder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement leftTrigger
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftTrigger));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_leftTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement rightShoulder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightShoulder));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightShoulder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement rightTrigger
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightTrigger));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_rightTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement center1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center1));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement center2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center2));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement center3
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center3));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_center3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement dPadUp
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadUp));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement dPadRight
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadRight));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement dPadDown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadDown));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadDown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerUIElement dPadLeft
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadLeft));
      return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr_dPadLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement> _uiElementsArray
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__uiElementsArray));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__uiElementsArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, ControllerUIElement> _uiElements
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__uiElements));
      return num == System.IntPtr.Zero ? (Dictionary<int, ControllerUIElement>) null : Il2CppObjectPool.Get<Dictionary<int, ControllerUIElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__uiElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IList<ControllerTemplateElementTarget> _tempTargetList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__tempTargetList));
      return num == System.IntPtr.Zero ? (IList<ControllerTemplateElementTarget>) null : Il2CppObjectPool.Get<IList<ControllerTemplateElementTarget>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__tempTargetList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick> _sticks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__sticks));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.NativeFieldInfoPtr__sticks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Stick(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__transform;
    private static readonly System.IntPtr NativeFieldInfoPtr__origPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__xAxisElementId;
    private static readonly System.IntPtr NativeFieldInfoPtr__yAxisElementId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsElement_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAxisPosition_Public_Void_Int32_Single_0;

    static Stick()
    {
      Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (Stick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, nameof (_transform));
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__origPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, nameof (_origPosition));
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__xAxisElementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, nameof (_xAxisElementId));
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__yAxisElementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, nameof (_yAxisElementId));
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, 100670497);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, 100670498);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, 100670499);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, 100670500);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_ContainsElement_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, 100670501);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_SetAxisPosition_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr, 100670502);
    }

    public unsafe Vector2 position
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85040, XrefRangeEnd = 85045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85045, XrefRangeEnd = 85050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85050, XrefRangeEnd = 85056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &xAxisElementId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &yAxisElementId;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85056, XrefRangeEnd = 85061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85061, XrefRangeEnd = 85065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ContainsElement(int elementId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &elementId
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_ContainsElement_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 85083, RefRangeEnd = 85084, XrefRangeStart = 85065, XrefRangeEnd = 85083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAxisPosition(int elementId, float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &elementId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeMethodInfoPtr_SetAxisPosition_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe RectTransform _transform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__transform));
        return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 _origPosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__origPosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__origPosition)) = value;
      }
    }

    public unsafe int _xAxisElementId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__xAxisElementId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__xAxisElementId)) = value;
      }
    }

    public unsafe int _yAxisElementId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__yAxisElementId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.Stick.NativeFieldInfoPtr__yAxisElementId)) = value;
      }
    }
  }

  public class UIElement(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_id;
    private static readonly System.IntPtr NativeFieldInfoPtr_element;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerUIElement_0;

    static UIElement()
    {
      Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI>.NativeClassPtr, nameof (UIElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>.NativeClassPtr);
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>.NativeClassPtr, nameof (id));
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>.NativeClassPtr, nameof (element));
      Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>.NativeClassPtr, 100670503);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 73094, RefRangeEnd = 73100, XrefRangeStart = 73094, XrefRangeEnd = 73100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIElement(int id, ControllerUIElement element)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int id
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeFieldInfoPtr_id));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeFieldInfoPtr_id)) = value;
      }
    }

    public unsafe ControllerUIElement element
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeFieldInfoPtr_element));
        return num == System.IntPtr.Zero ? (ControllerUIElement) null : Il2CppObjectPool.Get<ControllerUIElement>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Rewired.Demos.GamepadTemplateUI.GamepadTemplateUI.UIElement.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
