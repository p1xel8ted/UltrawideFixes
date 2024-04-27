namespace LaikaAgedThroughBlood;

[Harmony]
public static class Patches
{

    private static GameObject backdrop;
    internal static GameObject LeftBar;
    internal static GameObject RightBar;

    private readonly static string[] LeftBarScreens = ["ShopScreen", "CraftingScreen"];
    private readonly static string[] ScaleScreens = ["SettingsScreen", "AdvancedCheckpointScreen", "InGameMenuScreen"];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BlackjackScreen), nameof(BlackjackScreen.UpdateNavPrompts))]
    [HarmonyPatch(typeof(BlackjackScreen), nameof(BlackjackScreen.SetUp))]
    public static void BlackjackScreen_SetUp(BlackjackScreen __instance)
    {
        __instance.gameObject.TryAddComponent<Plugin.BothBarToggler>();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable_BackDrop(CanvasScaler __instance)
    {
        if (!__instance.name.Equals("VideoPlayerCanvas")) return;
        if (backdrop) return;
        backdrop = new GameObject("Backdrop");
        backdrop.transform.SetParent(__instance.transform, false);
        backdrop.transform.SetAsFirstSibling();
        var image = backdrop.AddComponent<Image>();

        var resourceName = Plugin.MainAspect switch
        {
            >= Plugin.SuperWideAspectRatio => "LaikaAgedThroughBlood.assets.32-9.jpg",
            > Plugin.BaseAspectRatio => "LaikaAgedThroughBlood.assets.21-9.jpg",
            _ => "LaikaAgedThroughBlood.assets.16-9.jpg"
        };

        var assembly = Assembly.GetExecutingAssembly();
        var texture = new Texture2D(2, 2, TextureFormat.RGBA32, false);

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                Plugin.Log.LogError($"Embedded image resource not found: {resourceName}");
                return;
            }

            var imageData = new byte[stream.Length];
            _ = stream.Read(imageData, 0, imageData.Length);
            texture.LoadImage(imageData);

            if (texture.width != Plugin.MainWidth || texture.height != Plugin.MainHeight)
            {
                var rt = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
                Graphics.Blit(texture, rt);
                RenderTexture.active = rt;

                var resizedTexture = new Texture2D(Plugin.MainWidth, Plugin.MainHeight);
                resizedTexture.ReadPixels(new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight), 0, 0);
                resizedTexture.Apply();
                RenderTexture.active = null;
                rt.Release();

                texture = resizedTexture;
            }
        }

        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        image.rectTransform.anchorMin = Vector2.zero;
        image.rectTransform.anchorMax = Vector2.one;
        image.rectTransform.sizeDelta = Vector2.zero;
        image.rectTransform.anchoredPosition = Vector2.zero;
        image.type = Image.Type.Simple;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UITransitionsManager), nameof(UITransitionsManager.Start))]
    [HarmonyPatch(typeof(UITransitionsManager), nameof(UITransitionsManager.Awake))]
    public static void UITransitionsManager_SetUp(UITransitionsManager __instance)
    {
        foreach (Transform tr in __instance.transform)
        {
            tr.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WalkieTalkieDisplay), nameof(WalkieTalkieDisplay.Start))]
    public static void WalkieTalkieDisplay_Start(WalkieTalkieDisplay __instance)
    {
        __instance.GetComponent<RectTransform>().anchoredPosition = new Vector2(-350f, 0);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FadeBlur), nameof(FadeBlur.OnEnable))]
    public static void FadeBlur_OnEnable(FadeBlur __instance)
    {
        __instance.transform.localScale *= Plugin.PositiveScaleFactor;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        foreach(var screen in ScaleScreens)
        {
            var bg = __instance.transform.Find($"{screen}/Background");
            if (bg)
            {
                bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            }
        }

        if (LeftBarScreens.Contains(__instance.name, StringComparer.OrdinalIgnoreCase))
        {
            __instance.gameObject.TryAddComponent<Plugin.LeftBarToggler>();  
        }
        

        if (__instance.name.Equals("WeirdResolutionCanvas"))
        {
            var left = __instance.transform.Find("Left");
            if (left)
            {
                LeftBar = left.gameObject;
                left.gameObject.SetActive(false);
            }
            var right = __instance.transform.Find("Right");
            if (right)
            {
                RightBar = right.gameObject;
                right.gameObject.SetActive(false);
            }
        }
    }
}