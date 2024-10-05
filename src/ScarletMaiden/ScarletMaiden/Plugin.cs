namespace ScarletMaiden
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.scarletmaiden.uwfixes";
        private const string PluginName = "Scarlet Maiden Ultra-Wide";
        private const string PluginVersion = "0.1.0";


        private static readonly int[] CustomRefreshRates =
        [
            30, // Uncommon
            50, // Uncommon
            60, // Common
            72, // Uncommon
            75, // Common
            90, // Uncommon
            100, // Uncommon
            120, // Common
            144, // Common
            165, // Common
            180, // Common
            200, // Uncommon
            240, // Common
            300, // Uncommon
            360, // Uncommon
            480 // Uncommon
        ];

        private static ManualLogSource Log { get; set; }
        internal static ConfigEntry<bool> EnableCustomOrthographicSize { get; private set; }
        internal static ConfigEntry<float> CustomOrthographicSize { get; private set; }
        internal static ConfigEntry<KeyboardShortcut> IncreaseZoom { get; private set; }
        internal static ConfigEntry<KeyboardShortcut> DecreaseZoom { get; private set; }
        internal static ConfigEntry<KeyboardShortcut> Reset { get; private set; }
        public static float OriginalZoom { get; set; }
        internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
        private static ConfigEntry<bool> RunInBackground { get; set; }
        private static ConfigEntry<bool> MuteInBackground { get; set; }
        private static ConfigEntry<int> CustomRefreshRate { get; set; }
        private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
        internal static ConfigEntry<int> DisplayToUse { get; private set; }
        private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
        internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
        internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
        private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
        private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
        internal static ConfigEntry<bool> AlternateCameraMode { get; set; }
        internal static ConfigEntry<bool> BlackBars { get; private set; }
        private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
        private static WindowPositioner WindowPositioner { get; set; }
        private static ConfigEntry<int> TargetFramerate { get; set; }
        private static float NativeAspectRatio => 16f / 9f;
        private static float CameraWidth => MainHeight * NativeAspectRatio;
        internal static float BlackBarSize => (MainWidth - CameraWidth) / 2f;
        internal static ConfigEntry<bool> RestrictHUD { get; private set; }
        internal static ConfigEntry<int> CameraVerticality { get; private set; }
        private static GameObject HUD1 => GameObject.Find("HUD/UI/StatusMeterBG");
        private static GameObject HUD2 => GameObject.Find("HUD/UI/SinDisplay");
        private static GameObject HUD3 => GameObject.Find("HUD/UI/MinimapImage");

        private void Awake()
        {
            var customRates = MergeUnityRefreshRates();
            Log = Logger;

            FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
            FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

            DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
            DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

            if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
            {
                WindowPositioner = gameObject.AddComponent<WindowPositioner>();
            }

            UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
            UseCustomRefreshRate.SettingChanged += (_, _) =>
            {
                UpdateDisplay();
                UpdateFixedDeltaTime();
            };

            CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
            CustomRefreshRate.SettingChanged += (_, _) =>
            {
                UpdateDisplay();
                UpdateFixedDeltaTime();
            };

            TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
            TargetFramerate.SettingChanged += (_, _) =>
            {
                UpdateDisplay();
                UpdateFixedDeltaTime();
            };

            CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
                new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 94 }));
            CorrectFixedUpdateRate.SettingChanged += (_, _) =>
            {
                UpdateDisplay();
                UpdateFixedDeltaTime();
            };

            UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
                new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 93 }));
            UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
            {
                UpdateDisplay();
                UpdateFixedDeltaTime();
            };
            AlternateCameraMode = Config.Bind("03. Camera", "Enable Alternate Camera Mode", false, new ConfigDescription("Changes the behaviour of the follow camera. Camera will stick to you with this enabled.", null, new ConfigurationManagerAttributes { Order =92 }));
            AlternateCameraMode.SettingChanged += (_, _) => { UpdateCameras(); };
            
            CameraVerticality = Config.Bind("03. Camera", "Camera Vertical Position", 4, new ConfigDescription("Adjust the vertical position of the camera when using Alternate Mode.", new AcceptableValueRange<int>(-10, 10), new ConfigurationManagerAttributes { Order = 91 }));
            CameraVerticality.SettingChanged += (_, _) => { UpdateCameras(); };
            
            EnableCustomOrthographicSize = Config.Bind("03. Camera", "Enable Custom Camera Zoom", false, new ConfigDescription("Enable this if you are using an ultra-wide monitor and the camera is too close/far away for your liking.", null, new ConfigurationManagerAttributes { Order = 90 }));
            EnableCustomOrthographicSize.SettingChanged += (_, _) => { UpdateZoom(); };

            CustomOrthographicSize = Config.Bind("03. Camera", "Custom Custom Camera Zoom", 0f, new ConfigDescription("Adjust this number to your personal preference. Use Num+, Num- to control in game.", new AcceptableValueRange<float>(-50f, 50f), new ConfigurationManagerAttributes { Order = 89 }));
            CustomOrthographicSize.SettingChanged += (_, _) => { UpdateZoom(); };
            
            IncreaseZoom = Config.Bind("03. Camera", "Increase Zoom Shortcut", new KeyboardShortcut(KeyCode.KeypadPlus), new ConfigDescription("Increase the camera zoom.", null, new ConfigurationManagerAttributes { Order = 88 }));
            DecreaseZoom = Config.Bind("03. Camera", "Decrease Zoom Shortcut", new KeyboardShortcut(KeyCode.KeypadMinus), new ConfigDescription("Decrease the camera zoom.", null, new ConfigurationManagerAttributes { Order = 87 }));
            Reset = Config.Bind("03. Camera", "Reset Camera Zoom Shortcut", new KeyboardShortcut(KeyCode.KeypadMultiply), new ConfigDescription("Reset to original zoom level.", null, new ConfigurationManagerAttributes { Order = 86 }));
            
            BlackBars = Config.Bind("04. UI", "Enable Black Bars", true, new ConfigDescription("Enable black bars on the sides of the screen where necessary.", null, new ConfigurationManagerAttributes { Order = 85 }));
            BlackBars.SettingChanged += (_, _) =>
            {
                if (BlackBars.Value)
                {
                    EnablePillarBoxing();
                }
                else
                {
                    DisablePillarBoxing();
                }
                
                Patches.UpdateHUD();
            };
            
            RestrictHUD = Config.Bind("04. UI", "Restrict HUD", false, new ConfigDescription("Restrict the HUD to 16:9.", null, new ConfigurationManagerAttributes { Order = 84}));
            RestrictHUD.SettingChanged += (_, _) => { Patches.UpdateHUD(); };

            
            RunInBackground = Config.Bind("05. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 83 }));
            RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

            MuteInBackground = Config.Bind("05. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));

            SceneManager.sceneLoaded += OnSceneLoaded;
            Application.focusChanged += FocusChanged;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            Log.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private static void UpdateCameras()
        {
            var cameraFollowers = Resources.FindObjectsOfTypeAll<CameraFollow>();
            foreach (var cam in cameraFollowers)
            {
                cam.useCamBoundsOverride = AlternateCameraMode.Value;
                cam.verticalOffset = CameraVerticality.Value;
            }
        }

        private static int[] MergeUnityRefreshRates()
        {
            var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
            var customRates = new List<int>();
            customRates.AddRange(unityRates);
            customRates.AddRange(CustomRefreshRates);
            return customRates.Distinct().OrderBy(a => a).ToArray();
        }


        private static void UpdateZoom()
        {
            CustomOrthographicSize.Value = Mathf.Round(CustomOrthographicSize.Value * 4) / 4;
            GetCameraFix().UpdateOrthographicSize();
        }

        private static void FocusChanged(bool focus)
        {
            Application.runInBackground = RunInBackground.Value;
            var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
            foreach (var audioSource in audioSources)
            {
                audioSource.mute = !focus && MuteInBackground.Value;
            }
        }

        public static void EnablePillarBoxing()
        {
            Patches.CreateBlackBars();
            if (Patches.BlackBarCanvas)
            {
                Patches.BlackBarCanvas.SetActive(BlackBars.Value);
                Patches.BlackBarCanvas.transform.SetAsLastSibling();
                ToggleHud();
            }
        }

        internal static void ToggleHud()
        {
            if (!RestrictHUD.Value && BlackBars.Value && Patches.BlackBarCanvas?.activeSelf == true)
            {
                HUD1?.SetActive(false);
                HUD2?.SetActive(false);
                HUD3?.SetActive(false); 
            }
            else
            {
                HUD1?.SetActive(true);
                HUD2?.SetActive(true);
                HUD3?.SetActive(true);   
            }
      
        }

        internal static void DisablePillarBoxing()
        {
            if (!Patches.BlackBarCanvas) return;
            
            Patches.CreateBlackBars();
            if (Patches.BlackBarCanvas)
            {
                Patches.BlackBarCanvas.SetActive(false);
                ToggleHud();
            }
        }

        private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            Log.LogInfo($"Scene loaded: {arg0.name}");
            UpdateDisplay();
            
            if(arg0.name.Contains("Title"))
            {
                EnablePillarBoxing();
            }
            else
            {
                DisablePillarBoxing();
            }
            
            Patches.UpdateHUD();
            UpdateCameras();
        }

        internal static void ResetZoom(bool disable = false)
        {
            EnableCustomOrthographicSize.Value = !disable;
            CustomOrthographicSize.Value = OriginalZoom;
            GetCameraFix().UpdateOrthographicSize();
        }

        private static CameraFix GetCameraFix()
        {
            return GameObject.FindGameObjectWithTag("MainCamera")?.GetComponent<CameraFix>();
        }

        private static void UpdateFixedDeltaTime()
        {
            OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
            var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
            if (targetRefresh <= 0)
            {
                Log.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
                return;
            }

            if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
            {
                Log.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
                return;
            }

            if (CorrectFixedUpdateRate.Value)
            {
                if (UseRefreshRateForFixedUpdateRate.Value)
                {
                    Time.fixedDeltaTime = 1f / targetRefresh;
                }
                else
                {
                    Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
                }
            }
            else
            {
                Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
            }

            Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
        }


        private static void UpdateDisplay()
        {
            if (WindowPositioner)
            {
                WindowPositioner.Start();
            }

            Application.runInBackground = RunInBackground.Value;

            Display.displays[DisplayToUse.Value].Activate();

            Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);

            Application.targetFrameRate = TargetFramerate.Value;
        }
    }
}