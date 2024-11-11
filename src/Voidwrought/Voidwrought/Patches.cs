namespace Voidwrought;

[Harmony]
public static class Patches
{
    private const string RootCanvas = "RootCanvas";
    private const string ScreenFade = "Screen Fade";
    private const string Sinai = "sinai";
    private static readonly List<ContentSizeFitter> Fitters = [];

    internal static void UpdateFitters()
    {
        foreach (var fitter in Fitters.Where(fitter => fitter))
        {
            fitter.horizontalFit = Plugin.ExpandHUD.Value ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize;
        }

        if (MenuCanvas && MenuCanvas.gameObject.activeSelf)
        {
            if (Plugin.ExpandHUD.Value)
            {
                Utils.DisablePillarBoxing();
            }
            else
            {
                Utils.EnablePillarBoxing();
            }
        }
        else
        {
            Utils.DisablePillarBoxing();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name == RootCanvas)
        {
            AddContentSizeFitter(__instance.gameObject);

            var fader = __instance.transform.Find(ScreenFade);
            if (fader)
            {
                fader.transform.localScale = fader.transform.localScale with { x = 50 };
            }
        }

        if (__instance.name.ToLower().Contains(Sinai, StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DialogueSystem), nameof(DialogueSystem.Start))]
    public static void DialogueSystem_Start(DialogueSystem __instance)
    {
        AddContentSizeFitter(__instance.canvas.gameObject);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Start))]
    public static void Menu_Start(Menu __instance)
    {
        AddContentSizeFitter(__instance.canvas.gameObject);
    }

    private static Canvas MenuCanvas { get; set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Update))]
    public static void Menu_Update(Menu __instance)
    {
        MenuCanvas = __instance.canvas;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Open), typeof(int))]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Open), typeof(InputActionEventData))]
    public static void Menu_Open(Menu __instance)
    {
        if (Plugin.ExpandHUD.Value)
        {
            Utils.DisablePillarBoxing();
        }
        else
        {
            Utils.EnablePillarBoxing();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Close))]
    public static void Menu_Close(Menu __instance)
    {
        Utils.DisablePillarBoxing();
    }

    private static void AddContentSizeFitter(GameObject go)
    {
        var le = go.TryAddComponent<LayoutElement>();
        var csf = go.TryAddComponent<ContentSizeFitter>();

        if (le)
        {
            le.preferredWidth = 1920;
        }

        if (!csf) return;

        csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        Fitters.Add(csf);
    }
}