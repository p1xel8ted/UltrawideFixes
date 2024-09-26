namespace Ufouria2;

[Harmony]
public static class Patches
{
    private static readonly List<GameObject> Letterbox = [];
    private static readonly Dictionary<CinemachineVirtualCamera, float> Cameras = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    internal static void UpdateLetterbox()
    {
        foreach (var box in Letterbox.Where(box => box))
        {
            box.SetActive(Plugin.Letterbox.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EventViewController), nameof(EventViewController.Initialize))]
    [HarmonyPatch(typeof(EventViewController), nameof(EventViewController.Setup))]
    public static void EventViewController_OnEnable(ref EventViewController __instance)
    {
        foreach (var comp in __instance.m_letterBoxFadeComponents)
        {
            Letterbox.Add(comp.gameObject);
            comp.transform.localScale = new Vector3(Plugin.ScaleFactor, 0.5f, 1f);
            comp.gameObject.SetActive(Plugin.Letterbox.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(ref CinemachineVirtualCamera __instance)
    {
        var cam = __instance;
        var fov = __instance.m_Lens.FieldOfView;
        Cameras.TryAdd(cam, fov);
    }

    private static void UpdateCamera(CinemachineVirtualCamera cam, float originalFov)
    {
        var fov = Plugin.FieldOfView.Value / 100f;
        var newFov = originalFov + originalFov * fov;
        if (cam)
        {
            cam.m_Lens = cam.m_Lens with { FieldOfView = newFov };
        }
    }

    internal static void UpdateCameras()
    {
        foreach (var (key, originalFov) in Cameras)
        {
            UpdateCamera(key, originalFov);
        }
    }
}