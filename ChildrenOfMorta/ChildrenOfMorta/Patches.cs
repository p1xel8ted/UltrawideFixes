using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using Zyklus.CameraManager;
using Zyklus.InputHandling;
using Zyklus.Managers;
using Zyklus.Player;
using Zyklus.UI;

namespace ChildrenOfMorta;

[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private static Vector3 ExpandScale { get; } = new(100, 1, 1);
    private static GameObject PopupMenu { get; set; }
    private static GameObject SaveIndicator { get; set; }
    private static GameObject OnlineMenuTransform { get; set; }
    private static GameObject NotificationPopupManagerTransform { get; set; }
    private static GameObject PlayerOneStaticTransform { get; set; }
    private static GameObject PlayerOneDynamicTransform { get; set; }
    private static GameObject PlayerTwoStaticTransform { get; set; }
    private static GameObject PlayerTwoDynamicTransform { get; set; }
    private static GameObject MiniMapTransformOne { get; set; }
    private static GameObject MiniMapTransformTwo { get; set; }
    private static GameObject ShowRuneTransform { get; set; }
    private static GameObject ShowCharmTransform { get; set; }
    private static GameObject ShowNormalTransform { get; set; }
    private static GameObject ShowCharacterTransform { get; set; }
    private static GameObject TooltipMenuTransform { get; set; }
    private static GameObject NotificationMenuTransform { get; set; }

    internal static Dictionary<GameObject, Vector3> OriginalPositions { get; private set; } = new();


    internal static void UpdateAll()
    {
        UpdateMiniMap();
        UpdateNotificationPopup();
        UpdateOnlineMenu();
        UpdatePlayerHud();
        UpdateTutorial();
        UpdateSaveWarning();
        UpdateTooltipMenu();
        UpdateNotificationMenu();
        UpdateSaveIndicator();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.PushMenuForAll))]
    [HarmonyPatch(typeof(CameraManagerComponent), nameof(CameraManagerComponent.ReInitializeCameras))]
    private static void Trigger_Update()
    {
        UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PopUpMenu), nameof(PopUpMenu.Show), new Type[] { })]
    [HarmonyPatch(typeof(PopUpMenu), nameof(PopUpMenu.Awake))]
    private static void PopUpMenu_Awake(ref PopUpMenu __instance)
    {
        PopupMenu ??= __instance.transform.Find("Main").gameObject;

        if (PopupMenu == null) return;

        OriginalPositions.TryAdd(PopupMenu, PopupMenu.transform.localPosition);
        UpdatePosition(PopupMenu, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConstOverlayComponent), nameof(ConstOverlayComponent.Awake))]
    private static void ConstOverlayComponent_Awake(ref ConstOverlayComponent __instance)
    {
        UpdateSaveIndicator();
    }

    private static void UpdateSaveIndicator()
    {
        SaveIndicator ??= GameObject.Find("UI Parliament/Const Overlay/Save Indicator");

        if (SaveIndicator == null) return;

        OriginalPositions.TryAdd(SaveIndicator, SaveIndicator.transform.localPosition);
        UpdatePosition(SaveIndicator, 795);
    }


    private static void UpdatePosition(GameObject gameObject, float newX)
    {
        if (!Plugin.CustomPositions.Value) return;
        if (gameObject == null)
        {
            return;
        }

        var localPosition = gameObject.transform.localPosition;
        localPosition = new Vector3(newX, localPosition.y, localPosition.z);
        gameObject.transform.localPosition = localPosition;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveWarningMenu), nameof(SaveWarningMenu.Awake))]
    private static void SaveWarningMenu_Awake(ref SaveWarningMenu __instance)
    {
        UpdateSaveWarning();
    }

    private static void UpdateSaveWarning()
    {
        var saveWarning = GameObject.Find("UI Parliament/UI Parent/Menus/Save warning menu/Main/Background");
        if (saveWarning == null) return;
        saveWarning.transform.localScale = ExpandScale;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OnlineMenu), nameof(OnlineMenu.Awake))]
    private static void OnlineMenu_Awake(ref OnlineMenu __instance)
    {
        UpdateOnlineMenu();
    }

    private static void UpdateOnlineMenu()
    {
        OnlineMenuTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Online Menu/Main");

        if (OnlineMenuTransform == null) return;

        OriginalPositions.TryAdd(OnlineMenuTransform, OnlineMenuTransform.transform.localPosition);
        UpdatePosition(OnlineMenuTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value + 10f : -220);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NotificationPopupManager), nameof(NotificationPopupManager.Awake))]
    [HarmonyPatch(typeof(NotificationPopupManager), nameof(NotificationPopupManager.Show))]
    private static void NotificationPopupManager_Awake(ref NotificationPopupManager __instance)
    {
        UpdateNotificationPopup();
    }

    private static void UpdateNotificationPopup()
    {
        NotificationPopupManagerTransform ??= GameObject.Find("UI Parliament/UI Parent/Notification Popup Manager/Main");

        if (NotificationPopupManagerTransform == null) return;

        OriginalPositions.TryAdd(NotificationPopupManagerTransform, NotificationPopupManagerTransform.transform.localPosition);
        UpdatePosition(NotificationPopupManagerTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value + 10f : -220);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerHUDComponent), nameof(PlayerHUDComponent.Awake))]
    private static void PlayerHUDComponent_Awake(ref PlayerHUDComponent __instance)
    {
        UpdatePlayerHud();
    }

    private static void UpdatePlayerHud()
    {
        PlayerOneStaticTransform ??= GameObject.Find("UI Parliament/UI Parent/Players HUD/P1/Static Canvas/Main");
        PlayerOneDynamicTransform ??= GameObject.Find("UI Parliament/UI Parent/Players HUD/P1/Dynamic Canvas/Main");
        PlayerTwoStaticTransform ??= GameObject.Find("UI Parliament/UI Parent/Players HUD/P2/Static Canvas/Main");
        PlayerTwoDynamicTransform ??= GameObject.Find("UI Parliament/UI Parent/Players HUD/P2/Dynamic Canvas/Main");

        if (PlayerOneStaticTransform == null || PlayerOneDynamicTransform == null || PlayerTwoStaticTransform == null || PlayerTwoDynamicTransform == null) return;

        OriginalPositions.TryAdd(PlayerOneStaticTransform, PlayerOneStaticTransform.transform.localPosition);
        OriginalPositions.TryAdd(PlayerOneDynamicTransform, PlayerOneDynamicTransform.transform.localPosition);
        OriginalPositions.TryAdd(PlayerTwoStaticTransform, PlayerTwoStaticTransform.transform.localPosition);
        OriginalPositions.TryAdd(PlayerTwoDynamicTransform, PlayerTwoDynamicTransform.transform.localPosition);

        UpdatePosition(PlayerOneStaticTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
        UpdatePosition(PlayerOneDynamicTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
        UpdatePosition(PlayerTwoStaticTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
        UpdatePosition(PlayerTwoDynamicTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapManagerComponent), nameof(MapManagerComponent.Awake))]
    private static void MapManagerComponent_Awake(ref MapManagerComponent __instance)
    {
        UpdateMiniMap();
    }


    private static void UpdateMiniMap()
    {
        MiniMapTransformOne = GameObject.Find("UI Parliament/Map Manager/matrix_1_minimap/Main");
        MiniMapTransformTwo = GameObject.Find("UI Parliament/Map Manager/matrix_1_maximap/Main");

        if (MiniMapTransformOne == null || MiniMapTransformTwo == null) return;

        OriginalPositions.TryAdd(MiniMapTransformOne, MiniMapTransformOne.transform.localPosition);
        OriginalPositions.TryAdd(MiniMapTransformTwo, MiniMapTransformTwo.transform.localPosition);
        
        UpdatePosition(MiniMapTransformOne, Plugin.CustomPositions.Value ? Plugin.MiniMapPosition.Value : 350);
        UpdatePosition(MiniMapTransformTwo, Plugin.CustomPositions.Value ? Plugin.MiniMapPosition.Value : 350);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Image), nameof(Image.OnEnable))]
    private static void Image_OnEnable(ref Image __instance)
    {
        if (__instance.name.Equals("overlay") || __instance.name.Equals("Legend-Back") || __instance.name.Equals("Back Grayout") || __instance.name.Equals("Hit post effect"))
        {
            if (__instance.name.Equals("Hit post effect"))
            {
                var transform = __instance.transform;
                var localScale = transform.localScale;
                localScale = new Vector3(100f, localScale.y, localScale.z);
                transform.localScale = localScale;
            }
            else
            {
                __instance.transform.localScale = ExpandScale;
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(FunctionalityTutorialWindow), nameof(FunctionalityTutorialWindow.Awake))]
    [HarmonyPatch(typeof(FunctionalityTutorialWindow), nameof(FunctionalityTutorialWindow.Start))]
    [HarmonyPatch(typeof(FunctionalityTutorialWindow), nameof(FunctionalityTutorialWindow.Show))]
    [HarmonyPatch(typeof(ItemsTutorialWindow), nameof(ItemsTutorialWindow.ShowRune))]
    [HarmonyPatch(typeof(ItemsTutorialWindow), nameof(ItemsTutorialWindow.ShowCharm))]
    [HarmonyPatch(typeof(ItemsTutorialWindow), nameof(ItemsTutorialWindow.ShowNormal))]
    [HarmonyPatch(typeof(ItemsTutorialWindow), nameof(ItemsTutorialWindow.ShowCharacterTutorial), typeof(PlayerCharacterEnum), typeof(RunTutorialsProceduralEvent.OnTutorialFinished), typeof(FloorStartAction.DoneDelegate), typeof(PlayerLocalNumber), typeof(UserUIActionEnum))]
    [HarmonyPatch(typeof(ItemsTutorialWindow), nameof(ItemsTutorialWindow.ShowCharacterTutorial), typeof(string), typeof(RunTutorialsProceduralEvent.OnTutorialFinished), typeof(FloorStartAction.DoneDelegate), typeof(PlayerLocalNumber), typeof(UserUIActionEnum))]
    private static void FunctionalityTutorialWindow_Awake(ref FunctionalityTutorialWindow __instance)
    {
        UpdateTutorial();
    }

    private static void UpdateTutorial()
    {

        ShowRuneTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Tutorial Windows menu/Rune Tutorial/Main");
        ShowCharmTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Tutorial Windows menu/Charm Tutorial/Main");
        //ShowNormalTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Tutorial Windows menu/Normal Tutorial/Main");
        ShowCharacterTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Tutorial Windows menu/Character Tutorial/Main");

        if (ShowRuneTransform == null || ShowCharmTransform == null || ShowCharacterTransform == null) return;


        OriginalPositions.TryAdd(ShowRuneTransform, ShowRuneTransform.transform.localPosition);
        OriginalPositions.TryAdd(ShowCharmTransform, ShowCharmTransform.transform.localPosition);
        //OriginalPositions.TryAdd(ShowNormalTransform, ShowNormalTransform.transform.localPosition);
        OriginalPositions.TryAdd(ShowCharacterTransform, ShowCharacterTransform.transform.localPosition);

        UpdatePosition(ShowRuneTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
        UpdatePosition(ShowCharmTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
        // UpdatePosition(ShowNormalTransform,Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
        UpdatePosition(ShowCharacterTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TooltipMenu), nameof(TooltipMenu.Awake))]
    [HarmonyPatch(typeof(TooltipMenu), nameof(TooltipMenu.Show))]
    private static void TooltipMenu_Awake(ref TooltipMenu __instance)
    {
        UpdateTooltipMenu();
    }

    private static void UpdateTooltipMenu()
    {
        TooltipMenuTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Run Tooltip Menu/Main");

        if (TooltipMenuTransform == null) return;

        OriginalPositions.TryAdd(TooltipMenuTransform, TooltipMenuTransform.transform.localPosition);

        
        UpdatePosition(TooltipMenuTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NotificationMenu), nameof(NotificationMenu.Awake))]
    [HarmonyPatch(typeof(NotificationMenu), nameof(NotificationMenu.Show))]
    private static void NotificationMenu_Awake(ref TooltipMenu __instance)
    {
        UpdateNotificationMenu();
    }

    private static void UpdateNotificationMenu()
    {
        NotificationMenuTransform ??= GameObject.Find("UI Parliament/UI Parent/Menus/Notification Menu/Main");

        if (NotificationMenuTransform == null) return;

        OriginalPositions.TryAdd(NotificationMenuTransform, NotificationMenuTransform.transform.localPosition);
        UpdatePosition(NotificationMenuTransform, Plugin.CustomPositions.Value ? Plugin.PlayerHudXPosition.Value : -230);
    }
}