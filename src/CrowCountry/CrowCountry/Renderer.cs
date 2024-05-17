namespace CrowCountry;

internal static class Renderer
{
    internal static void PixelationAdjust(CrowCountryCamEffect __instance)
    {
        QualitySettings.antiAliasing = Plugin.PixelationAmount.Value > 0 ? 0 : 4;

        ReleaseRenderTexture(ref __instance.midBuffer);
        ReleaseRenderTexture(ref __instance.psxRenderTexture);
        ReleaseRenderTexture(ref __instance.camRenderTexture1);
        ReleaseRenderTexture(ref __instance.camRenderTexture2);
        ReleaseRenderTexture(ref __instance.camRenderTexture3);
        ReleaseRenderTexture(ref __instance.camRenderTexture4);
        ReleaseRenderTexture(ref __instance.camRenderTexture5);
        ReleaseRenderTexture(ref __instance.crtBlurTexture);
        ReleaseRenderTexture(ref __instance.fbBuffer);

        __instance.midBuffer = new RenderTexture(Adjust(1248), Adjust(702, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.psxRenderTexture = new RenderTexture(Adjust(550), Adjust(400, true), 16, RenderTextureFormat.ARGB32)
        {
            filterMode = Plugin.PixelationAmount.Value == 0 ? FilterMode.Trilinear : FilterMode.Point
        };
        __instance.camRenderTexture1 = new RenderTexture(Adjust(1248), Adjust(702, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture2 = new RenderTexture(Adjust(624), Adjust(351, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture3 = new RenderTexture(Adjust(416), Adjust(234, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture4 = new RenderTexture(Adjust(550), Adjust(400, true), 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.camRenderTexture5 = new RenderTexture(1, 1, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.sRGB);
        __instance.crtBlurTexture = new RenderTexture(Adjust(1248), Adjust(702, true), 0);
        __instance.fbBuffer = new RenderTexture(Adjust(416), Adjust(234, true), 0)
        {
            filterMode = Plugin.PixelationAmount.Value == 0 ? FilterMode.Trilinear : FilterMode.Point
        };

        __instance.UpdateColorMatrices();
        return;

        void ReleaseRenderTexture(ref RenderTexture rt)
        {
            if (!rt) return;
            rt.Release();
            rt = null;
        }
    }


    private static int Adjust(int value, bool height = false)
    {
        return Plugin.PixelationAmount.Value switch
        {
            0 => height ? Plugin.MainHeight : Plugin.MainWidth,
            1 =>
                //100% resolution increase
                Mathf.RoundToInt(value * 2),
            2 =>
                //75% resolution increase
                Mathf.RoundToInt(value * 1.75f),
            3 =>
                // 50% resolution increase
                Mathf.RoundToInt(value * 1.5f),
            4 =>
                // 25% resolution increase
                Mathf.RoundToInt(value * 1.25f),
            _ => value
        };
    }
}