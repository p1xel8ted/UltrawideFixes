using CrowCountry.Generics;

namespace CrowCountry;

internal static class ScalingCorrections
{
    private readonly static Dictionary<RectTransform, WriteOnce<Vector3>> MapScales = new();
    private readonly static WriteOnce<float> CreditsSkyY = new();


    internal readonly static WriteOnce<Vector3> PoisonScale = new();

    private readonly static WriteOnce<float> CreditsHeaderFooterX = new();
    private readonly static WriteOnce<float> CreditsBackgroundX = new();
    private readonly static WriteOnce<float> CreditsTransitionX = new();

    private readonly static WriteOnce<float> PauseScreenBackgroundX = new();

    internal static void CorrectResultsScreen(Transform transform)
    {
        var results = transform.Find(Const.ResultsScreen);
        if (results)
        {
            var gradients = transform.FindAllDeepChildren(Const.ResultsGradients);
            foreach (var gradient in gradients)
            {
                gradient.gameObject.SetActive(false);
            }
        }

        var ground = GameObject.Find(Const.ResultsScreenGround);
        if (ground)
        {
            ground.gameObject.TryAddComponent<ResultsScreen>();
        }

        var coverOff = transform.Find(Const.ResultsScreenBlackOverlays);
        if (coverOff)
        {
            coverOff.gameObject.SetActive(false);
        }
    }

    public static void CorrectCreditsScreen(Transform transform)
    {
        var blur = transform.Find(Const.CreditsHeaderFooter);
        if (blur)
        {
            CreditsHeaderFooterX.Value = blur.localScale.x;
            var x = CreditsHeaderFooterX.Value * Plugin.PositiveScaleFactor;
            blur.localScale = blur.localScale with {x = x};
        }

        var creditsBg = transform.Find(Const.CreditsBackground);
        if (creditsBg)
        {
            CreditsBackgroundX.Value = creditsBg.localScale.x;
            var x = CreditsBackgroundX.Value * Plugin.PositiveScaleFactor;
            creditsBg.localScale = creditsBg.localScale with {x = x};
        }

        var transition = transform.Find(Const.CreditsTransition);
        if (transition)
        {
            CreditsTransitionX.Value = transition.localScale.x;
            var x = CreditsTransitionX.Value * Plugin.PositiveScaleFactor;
            transition.localScale = transition.localScale with {x = x};
        }
    }

    internal static void CorrectBlackBackground(Transform transform)
    {
        var black = transform.Find(Const.BlackBackground);
        if (black)
        {
            black.gameObject.SetActive(false);
        }
    }

    private readonly static WriteOnce<float> DrivingRoadX = new();
    private readonly static WriteOnce<float> DrivingRoadZ = new();
    internal static void CorrectDrivingIntroRoad()
    {
        var road = GameObject.Find("level/level/road");
        if (!road) return;
        DrivingRoadX.Value = road.transform.localScale.x;
        DrivingRoadZ.Value = road.transform.localScale.z;
        var x = DrivingRoadX.Value * Plugin.PositiveScaleFactor;
        var y = road.transform.localScale.y;
        var z = DrivingRoadZ.Value * Plugin.PositiveScaleFactor;
        road.transform.localScale = new Vector3(x, y, z);
    }

    internal static void CorrectPauseScreen(Transform transform)
    {
        var pause = transform.Find(Const.PauseScreenBackground);
        if (!pause) return;

        PauseScreenBackgroundX.Value = pause.localScale.x;
        var x = PauseScreenBackgroundX.Value * Plugin.PositiveScaleFactor;
        pause.localScale = pause.localScale with {x = x};
    }
   
    private static void ResizePoison()
    {
        var originalScale = PoisonScale.Value;
        var originalFov = Plugin.GetDefaultCameraFov();

        var newFov = originalFov + originalFov * Plugin.FieldOfView.Value / 100f;
        var newX = originalScale.x * (newFov / originalFov);

        newX -= (newX * 0.05f);

        var newY = originalScale.y * (newFov / originalFov);
        var newZ = originalScale.z;

        var newScale = new Vector3(newX, newY, newZ);
        Instances.PoisonInstance.transform.DOScale(newScale, 1f).SetEase(Ease.InOutQuad);
    }

    internal static void UpdatePoison()
    {
        if (!Instances.PoisonInstance) return;

        Instances.PoisonInstance.gameObject.SetActive(Plugin.PoisonOverlay.Value);
        ResizePoison();
    }

    internal static void CorrectMapBackground()
    {
        var rectTransforms = Resources.FindObjectsOfTypeAll<RectTransform>()
            .Where(t => t.name == "fg" && t.parent?.name == "map")
            .ToList();

        foreach (var rt in rectTransforms)
        {
            if (!MapScales.TryGetValue(rt, out var originalScale))
            {
                originalScale = new WriteOnce<Vector3> {Value = rt.localScale};
                MapScales[rt] = originalScale;
            }

            var scaleFactor = Plugin.PositiveScaleFactor;
            rt.localScale = new Vector3(originalScale.Value.x * scaleFactor, originalScale.Value.y * scaleFactor, originalScale.Value.z);
        }
    }
    internal static void CorrectCreditsSky()
    {
        var sky = GameObject.Find("level/level/bg/sky");
        if (!sky) return;

        CreditsSkyY.Value = sky.transform.localScale.y;

        var y = CreditsSkyY.Value * Plugin.PositiveScaleFactor;
        sky.transform.localScale = sky.transform.localScale with {y = y + y * 0.25f};
    }

    private readonly static WriteOnce<float> FooterX = new();

    internal static void CorrectFooter(Transform transform)
    {
        // var footer = GameObject.Find("level/Canvas/Menu Set (OFF)/Footer/Image");
        var footer = transform.Find("Menu Set (OFF)/Footer/Image");
        if (!footer) return;
        FooterX.Value = footer.transform.localScale.x;
        var x = FooterX.Value * Plugin.PositiveScaleFactor;
        footer.transform.localScale = footer.transform.localScale with {x = x};
    }
}