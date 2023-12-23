namespace TheLastFaithUltrawideRose;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const string CinematicBlackBars = "Cinematic Black Bars";
    private const string ConfineCamera = "CONFINE CAMERA";
    private const string MainCamera = "MainCamera";


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution(ref int width, ref int height)
    {
        width = Plugin.DisplayWidth;
        height = Plugin.DisplayHeight;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadableScene), nameof(LoadableScene.Awake))]
    internal static void Fixes()
    {
        var cameraObject = GameObject.FindWithTag(MainCamera);
        if (cameraObject == null) return;

        var cameraComponent = cameraObject.GetComponent<Camera>();
        if (cameraComponent == null) return;

        CamFix(cameraComponent);

        var meshRenderer = cameraObject.GetComponentInChildren<MeshRenderer>();
        if (meshRenderer == null) return;

        var transform = meshRenderer.transform;
        var scale = transform.localScale;
        scale.x = scale.y * Plugin.CurrentAR;
        transform.localScale = scale;
        meshRenderer.material.mainTexture = cameraComponent.targetTexture;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    private static void CinemachineVirtualCamera_OnEnable(CinemachineVirtualCamera __instance)
    {
        var componentInChildren = __instance.GetComponentInChildren<CinemachineConfiner>();
        if (componentInChildren != null)
        {
            componentInChildren.enabled = false;
        }

        if (__instance.GetComponentInChildren<CinemachineConfiner2D>() == null && Plugin.CurrentAR < 2.8f)
        {
            var cinemachineConfiner2D = __instance.gameObject.AddComponent<CinemachineConfiner2D>();
            var confineCameraObject = GameObject.Find(ConfineCamera);

            if (confineCameraObject == null) return;

            var polygonCollider = confineCameraObject.GetComponent<PolygonCollider2D>();

            if (polygonCollider == null) return;

            cinemachineConfiner2D.m_BoundingShape2D = polygonCollider;
            cinemachineConfiner2D.m_MaxWindowSize = __instance.m_Lens.OrthographicSize;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void UI(ref CanvasScaler __instance)
    {
        if (__instance != null)
        {
            __instance.m_ScreenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        FixBlackBars();
    }

    internal static void FixBlackBars()
    {
        var gameObject = GameObject.Find(CinematicBlackBars);
        if (gameObject == null) return;
        var localScale = gameObject.transform.localScale;
        if (!Mathf.Approximately(localScale.x, 1f)) return;
        localScale.x *= Plugin.ARDifference;
        gameObject.transform.localScale = localScale;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(LocaleSetup), nameof(LocaleSetup.Awake))]
    private static void Res()
    {
        SetResolution();
    }
    

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.LoadScene))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.LoadSceneFullPath))]
    private static void SceneLoader_LoadScene(string scene)
    {
        Plugin.Logger.LogInfo($"Loading scene {scene}");
    }

    internal static void SetResolution()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", Plugin.DisplayIndex.Value);
        var targetDisplay = Display.displays[Plugin.DisplayIndex.Value];
        targetDisplay.Activate(Plugin.DisplayWidth, Plugin.DisplayHeight, Plugin.MaxRefresh);
        Screen.SetResolution(Plugin.DisplayWidth, Plugin.DisplayHeight, true, Plugin.MaxRefresh);
    }

    private static void CamFix(Camera cam)
    {
        if (cam.targetTexture != null)
        {
            var targetTexture = cam.targetTexture;
            var descriptor = targetTexture.descriptor;
            if (descriptor.width != Plugin.DisplayWidth || descriptor.height != Plugin.DisplayHeight)
            {
                descriptor.width = Plugin.DisplayWidth;
                descriptor.height = Plugin.DisplayHeight;
                var renderTexture = new RenderTexture(descriptor)
                {
                    filterMode = targetTexture.filterMode,
                    name = targetTexture.name
                };
                targetTexture.Release();
                cam.targetTexture = renderTexture;
            }
        }

        var component = cam.GetComponent<PixelPerfectCamera>();
        if (component == null) return;
        component.gridSnapping = PixelPerfectCamera.GridSnapping.PixelSnapping;
    }
}