namespace Anodyne2UltraWide;

[Harmony]
public static class Patches
{
    private const string Language = "language";
    private const string Brightness = "brightness";
    private const string Volume = "volume";
    private const string Fullscreen = "fullscreen";
    private const string InfiniteFly = "infiniteFly";
    private const string Sensitivity = "sensitivity";
    private const string FieldOfView = "fieldOfView";
    private const string InvertConfirmCancel = "invertConfirmCancel";
    private const string CustomUiScaling = "customUIScaling";
    private const string DoubleHealth = "doubleHealth";
    private const string HealthUpgrades = "healthUpgrades";
    private const string DialogueSkip = "dialogueSkip";
    private const string KeepSkipOnUntilLoadingFromTitle = "keepSkipOnUntilLoadingFromTitle";
    private const string ControllerDisable = "controllerDisable";
    private const string ShadowQuality = "shadowQuality";
    private const string CameraDistance = "cameraDistance";
    private const string ScreenShake = "screenshake";
    private const string Invincibility = "invincibility";
    private const string TerrainQuality = "terrainQuality";
    private const string ButtonLabelType = "buttonLabelType";
    private const string Extracamrotwithcontrollermovestrength = "extraCamRotWithControllerMoveStrength";
    private const string InstantText = "instantText";
    private const string SettingsRestoredSuccessfully = "Settings restored successfully.";
    private const string ErrorRestoringSettings = $"Error restoring settings:";
    private const string SettingSaved = "settingSaved";
    private const string WinResX = "winResX";
    private const string WinResY = "winResY";
    private const string RestoringSettings = "Restoring settings...";
    private const string NoSettingsSavedSkippingRestore = "No settings saved, skipping restore.";
    private const string SavePoint = "savePoint";
    private const string GitHub = "GitHub\n";
    private const string UltraWideByP1xel8Ted = "\nUltra-Wide by p1xel8ted";

    /// <summary>
    /// Sets the appropriate options to skip the intro stuff
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.UpdateIntroAnimation))]
    public static void TitleScreen_UpdateIntroAnimation(ref TitleScreen __instance)
    {
        __instance.animMode = 0;
        __instance.animT = 1;
        MyInput.jpConfirm = true;
        __instance.playedsong = true;
    }


    /// <summary>
    /// Saves settings to registry when a setting is changed. The games default behaviour is to save them against the loaded save...which is useless if no save is loaded.
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.SettingsChoiceLogic))]
    public static void PauseMenu_SettingsChoiceLogic(ref PauseMenu __instance)
    {
        SaveSettings();
    }

    private static GameObject BlackBackground { get; set; }
    private static GameObject Vision1 { get; set; }
    private static GameObject Vision2 { get; set; }
    private static GameObject Vision3 { get; set; }
    private static GameObject[] Visions { get; set; } = [Vision1, Vision2, Vision3];
    // private static float NegativeScaleFactor { get; set; }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.OnEnterInventory))]
    public static void PauseMenu_OnEnterInventory(ref PauseMenu __instance)
    {
        // var currentAspect = (float) Display.main.systemWidth / Display.main.systemHeight;
        // const float baseAspect = 16f / 9f;
        //
        // if (!(currentAspect > baseAspect)) return;
        //
        // var positiveScaleFactor = currentAspect / baseAspect;
        // NegativeScaleFactor = 1f / positiveScaleFactor;

        Vision1 = GameObject.Find("UI/Dialogue/palvision1");
        Vision2 = GameObject.Find("UI/Dialogue/palvision2");
        Vision3 = GameObject.Find("UI/Dialogue/palvision3");
        Visions = [Vision1, Vision2, Vision3];

        if (!BlackBackground && Vision1)
        {
            Plugin.Log.LogInfo("BlackBackground instance is null - creating now.");
            BlackBackground = UnityEngine.Object.Instantiate(Vision1, Vision1.transform.parent);
            BlackBackground.name = "blackBackground";
            var image = BlackBackground.GetComponent<Image>();
            image.sprite = null;
            image.color = Color.black;
            BlackBackground.transform.localScale = new Vector3(10, 10, 1);
            BlackBackground.SetActive(false);
            BlackBackground.transform.SetAsFirstSibling();
        }

        foreach (var v in Visions.Where(a => a))
        {
            BlackBackground.SetActive(true);
            v.transform.localScale = v.transform.localScale with {x = Plugin.NegativeScaleFactor, y = Plugin.NegativeScaleFactor};
        }
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(EntityState2D), nameof(EntityState2D.SetVelocityTowardsDestination))]
    // public static void EntityState2D_SetVelocityTowardsDestination(Rigidbody2D rb, Transform destinationTransform, float magnitude)
    // {
    //     Plugin.Log.LogWarning($"RB: {rb.name}, Transform: {destinationTransform}, Magnitude: {magnitude}");
    // }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.Update))]
    public static void PauseMenu_Update(ref PauseMenu __instance)
    {
        if (!__instance) return;
        if (!BlackBackground) return;
        if (__instance.doingInvVision)
        {
            // Vision1 = GameObject.Find("UI/Dialogue/palvision1");
            // Vision2 = GameObject.Find("UI/Dialogue/palvision2");
            // Vision3 = GameObject.Find("UI/Dialogue/palvision3");
            // Visions = [Vision1, Vision2, Vision3];
            BlackBackground.SetActive(true);
            foreach (var v in Visions.Where(a => a))
            {
                v.transform.localScale = v.transform.localScale with {x = Plugin.NegativeScaleFactor, y = Plugin.NegativeScaleFactor};
            }
        }
        else
        {
            BlackBackground.SetActive(false);
        }
    }

    /// <summary>
    /// Save settings to registry when the game is closed and force garbage collection to allow quicker exit.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Application), nameof(Application.Quit))]
    public static void Application_Quit()
    {
        SaveSettings();
        GC.Collect(int.MaxValue, GCCollectionMode.Forced);
    }

    /// <summary>
    /// Restores settings from registry when the game is loaded.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveManager), nameof(SaveManager._Load))]
    public static void SaveManager__Load()
    {
        RestoreSettings();
    }

    /// <summary>
    /// Restores settings from registry.
    /// </summary>
    private static void RestoreSettings()
    {
        if (PlayerPrefs.GetInt(SettingSaved) != 1)
        {
            Plugin.Log.LogInfo(NoSettingsSavedSkippingRestore);
            return;
        }

        try
        {
            Plugin.Log.LogInfo(RestoringSettings);

            // Utility method for converting int to boolean
            bool IntToBool(int value) => value == 1;

            SaveManager.language = PlayerPrefs.GetString(Language);
            SaveManager.brightness = PlayerPrefs.GetInt(Brightness);
            SaveManager.volume = PlayerPrefs.GetInt(Volume);
            SaveManager.fullscreen = IntToBool(PlayerPrefs.GetInt(Fullscreen));
            SaveManager.winResX = PlayerPrefs.GetInt(WinResX);
            SaveManager.winResY = PlayerPrefs.GetInt(WinResY);
            SaveManager.infiniteFly = IntToBool(PlayerPrefs.GetInt(InfiniteFly));
            SaveManager.sensitivity = PlayerPrefs.GetInt(Sensitivity);
            SaveManager.fieldOfView = PlayerPrefs.GetInt(FieldOfView);
            SaveManager.invertConfirmCancel = IntToBool(PlayerPrefs.GetInt(InvertConfirmCancel));
            SaveManager.customUIScaling = PlayerPrefs.GetInt(CustomUiScaling);
            SaveManager.doubleHealth = IntToBool(PlayerPrefs.GetInt(DoubleHealth));
            SaveManager.healthUpgrades = PlayerPrefs.GetInt(HealthUpgrades);
            SaveManager.dialogueSkip = IntToBool(PlayerPrefs.GetInt(DialogueSkip));
            SaveManager.keepSkipOnUntilLoadingFromTitle = IntToBool(PlayerPrefs.GetInt(KeepSkipOnUntilLoadingFromTitle));
            SaveManager.controllerDisable = IntToBool(PlayerPrefs.GetInt(ControllerDisable));
            SaveManager.shadowQuality = PlayerPrefs.GetInt(ShadowQuality);
            SaveManager.cameraDistance = PlayerPrefs.GetInt(CameraDistance);
            SaveManager.screenshake = IntToBool(PlayerPrefs.GetInt(ScreenShake));
            SaveManager.invincibility = IntToBool(PlayerPrefs.GetInt(Invincibility));
            SaveManager.terrainQuality = PlayerPrefs.GetInt(TerrainQuality);
            SaveManager.buttonLabelType = PlayerPrefs.GetInt(ButtonLabelType);
            SaveManager.extraCamRotWithControllerMoveStrength = PlayerPrefs.GetInt(Extracamrotwithcontrollermovestrength);
            SaveManager.instantText = IntToBool(PlayerPrefs.GetInt(InstantText));

            Plugin.Log.LogInfo(SettingsRestoredSuccessfully);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"{ErrorRestoringSettings} {ex.Message}");
        }
    }


    /// <summary>
    /// Saves settings to registry.
    /// </summary>
    private static void SaveSettings()
    {
        // Directly use SaveManager properties and Display.main properties
        PlayerPrefs.SetString(Language, SaveManager.language);
        PlayerPrefs.SetInt(Brightness, (int) SaveManager.brightness);
        PlayerPrefs.SetInt(Volume, (int) SaveManager.volume);
        PlayerPrefs.SetInt(Fullscreen, BoolToInt(SaveManager.fullscreen));
        PlayerPrefs.SetInt(WinResX, SaveManager.winResX);
        PlayerPrefs.SetInt(WinResY, SaveManager.winResY);
        PlayerPrefs.SetInt(InfiniteFly, BoolToInt(SaveManager.infiniteFly));
        PlayerPrefs.SetInt(Sensitivity, SaveManager.sensitivity);
        PlayerPrefs.SetInt(FieldOfView, (int) SaveManager.fieldOfView);
        PlayerPrefs.SetInt(InvertConfirmCancel, BoolToInt(SaveManager.invertConfirmCancel));
        PlayerPrefs.SetInt(CustomUiScaling, SaveManager.customUIScaling);
        PlayerPrefs.SetInt(DoubleHealth, BoolToInt(SaveManager.doubleHealth));
        PlayerPrefs.SetInt(HealthUpgrades, SaveManager.healthUpgrades);
        PlayerPrefs.SetInt(DialogueSkip, BoolToInt(SaveManager.dialogueSkip));
        PlayerPrefs.SetInt(KeepSkipOnUntilLoadingFromTitle, BoolToInt(SaveManager.keepSkipOnUntilLoadingFromTitle));
        PlayerPrefs.SetInt(ControllerDisable, BoolToInt(SaveManager.controllerDisable));
        PlayerPrefs.SetInt(ShadowQuality, SaveManager.shadowQuality);
        PlayerPrefs.SetInt(CameraDistance, (int) SaveManager.cameraDistance);
        PlayerPrefs.SetInt(ScreenShake, BoolToInt(SaveManager.screenshake));
        PlayerPrefs.SetInt(Invincibility, BoolToInt(SaveManager.invincibility));
        PlayerPrefs.SetInt(TerrainQuality, SaveManager.terrainQuality);
        PlayerPrefs.SetInt(ButtonLabelType, SaveManager.buttonLabelType);
        PlayerPrefs.SetInt(Extracamrotwithcontrollermovestrength, (int) SaveManager.extraCamRotWithControllerMoveStrength);
        PlayerPrefs.SetInt(InstantText, BoolToInt(SaveManager.instantText));

        PlayerPrefs.SetInt(SettingSaved, 1);
        PlayerPrefs.Save();
        return;

        // Utility method for converting boolean to int
        int BoolToInt(bool value) => value ? 1 : 0;
    }


    /// <summary>
    ///  Appends the version text with the name of the mod and its author.
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.setVersionPressKeyText))]
    public static void TitleScreen_setVersionPressKeyText(ref TitleScreen __instance)
    {
        __instance.version.text += UltraWideByP1xel8Ted;
        __instance.version.transform.position += new Vector3(0, 6f, 0);
    }

    /// <summary>
    /// Removes all the extra menu items (credits, twitter, etc.) from the main menu.
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveModule), nameof(SaveModule.loadMainMenuText))]
    [HarmonyPatch(typeof(SaveModule), nameof(SaveModule.Start))]
    public static void SaveModule_loadMainMenuText(ref SaveModule __instance)
    {
        var text = string.Empty;

        if (!__instance.inTitleScreen) return;
        text += DataLoader.instance.getRaw(SavePoint, 7) + "\n";
        text += DataLoader.instance.getRaw(SavePoint, 1) + "\n";
        text += DataLoader.instance.getRaw(SavePoint, 10) + "\n";
        text += GitHub;
        text += DataLoader.instance.getRaw(SavePoint, 15);

        __instance.mainChoiceArray = new int[5];
        __instance.mainChoiceArray[0] = __instance.MODE_NEW;
        __instance.mainChoiceArray[1] = __instance.MODE_LOAD;
        __instance.mainChoiceArray[2] = __instance.MODE_SETTINGS;
        __instance.mainChoiceArray[3] = __instance.MODE_TWITTER;
        __instance.mainChoiceArray[4] = __instance.MODE_QUIT;
        __instance.index = 1;
        __instance.text.text = text;
    }
}