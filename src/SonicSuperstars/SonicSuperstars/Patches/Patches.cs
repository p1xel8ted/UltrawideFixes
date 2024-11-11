namespace SonicSuperstars.Patches;

[Harmony]
public static class Patches
{
    private static readonly string[] RestrictResScenes = ["MovieScene", "Logo", "Mini", "Special", "Bonus"];

    private static readonly List<CompAreaCameraActivator> Activators = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneManager_Internal_SceneLoaded(Scene scene)
    {
        if (RestrictResScenes.Any(scene.name.Contains)) return;
        Console.WriteLine($"Scene '{scene.name}' loaded!");
        UpdateCameras();
        var gbc = GameScene_Helper.GetBlockController();
        if (gbc)
        {
            gbc.visibleSafeBlock = new Vector2Int(10000, 10000);
            Console.WriteLine("BlockController updated!");
        }

        if (scene.name == "Zone02_Act3")
        {
            if (GuideMaskManager.Instance)
            {
                GuideMaskManager.Instance.transform.localScale *= Plugin.PositiveScaleFactor;
                GuideMaskManager.Instance.SetArea(-1000f, 0f, 1000f, 0f);
            }
        }
    }

    private static bool ReferenceExists<T>(this List<T> list, T reference)
    {
        return list.Any(a => reference.Equals(a));
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CompAreaCameraActivator), nameof(CompAreaCameraActivator.SetActivator))]
    public static void CompAreaCameraActivator_SetActivator(CompAreaCameraActivator __instance, bool enable)
    {
        if (enable)
        {
            if (!Activators.ReferenceExists(__instance))
            {
                __instance.areaBox = __instance.areaBox with { width = __instance.areaBox.width * Plugin.PositiveScaleFactor };
                Activators.Add(__instance);
            }
        }
    }

    private static void UpdateCameras()
    {
        var csa = Resources.FindObjectsOfTypeAll<CameraStableAspect>();
        foreach (var cam in csa)
        {
            cam.m_height = Plugin.MainHeight;
            cam.m_width = Plugin.MainWidth;
            cam.height = Plugin.MainHeight;
            cam.width = Plugin.MainWidth;
        }

        //Main Camera = UI before being in-game
        //UICameraBase = don't change this one ever
        //PlayerCamera = main menu camera apparently, not sure what else
        //Camera_Main = in-game camera
        //UICameraGame = UI in-game
        var cameras = Camera.allCameras;
        foreach (var cam in cameras)
        {
            if (cam.name is not ("Camera_Main" or "UICameraGame")) continue;

            if (Mathf.Approximately(cam.aspect, 1f) || Mathf.Approximately(cam.aspect, Plugin.MainAspect)) continue;

            var newAspect = Plugin.MainAspect;
            var newRect = new Rect(0, 0, 1, 1);
            var newPixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);

            cam.aspect = newAspect;
            cam.pixelRect = newPixelRect;
            cam.rect = newRect;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.screenMatchMode == CanvasScaler.ScreenMatchMode.Expand) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}