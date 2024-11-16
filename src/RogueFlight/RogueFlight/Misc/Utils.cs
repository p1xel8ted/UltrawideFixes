using Il2CppInterop.Runtime;
using Object = UnityEngine.Object;

namespace RogueFlight.Misc;

public static class Utils
{
    private static float NativeAspectRatio => 16f / 9f; // 1.77777777778
    private static float CameraWidth => Plugin.MainHeight * NativeAspectRatio; // 1440 * 16/9 = 2560
    private static float BlackBarSize => (Plugin.MainWidth - CameraWidth) / 2f; // (3440 - 2560) / 2 = 440
    private static GameObject BlackBarCanvas { get; set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }

    internal static string GetPath(this GameObject go)
    {
        var path = go.name;
        while (go.transform.parent != null)
        {
            go = go.transform.parent.gameObject;
            path = go.name + "/" + path;
        }

        return path;
    }
    
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        var component = go.GetComponent<T>();
        if (component == null)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }


    private static void CreateBlackBars()
    {
        if (!BlackBarCanvas)
        {
            BlackBarCanvas = new GameObject("BlackBarCanvas");
            var canvas = BlackBarCanvas.TryAddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            if (!LeftBlackBar)
            {
                LeftBlackBar = new GameObject("LeftBlackBar");
                LeftBlackBar.transform.SetParent(canvas.transform, false);
                var leftImage = LeftBlackBar.TryAddComponent<Image>();
                leftImage.color = Color.black;
                var leftRect = leftImage.GetComponent<RectTransform>();
                leftRect.anchorMin = new Vector2(0, 0);
                leftRect.anchorMax = new Vector2(0, 1);
                leftRect.offsetMin = new Vector2(0, 0);
                leftRect.offsetMax = new Vector2(BlackBarSize, 0);
            }

            if (!RightBlackBar)
            {
                RightBlackBar = new GameObject("RightBlackBar");
                RightBlackBar.transform.SetParent(canvas.transform, false);
                var rightImage = RightBlackBar.TryAddComponent<Image>();
                rightImage.color = Color.black;
                var rightRect = rightImage.GetComponent<RectTransform>();
                rightRect.anchorMin = new Vector2(1, 0);
                rightRect.anchorMax = new Vector2(1, 1);
                rightRect.offsetMin = new Vector2(-BlackBarSize, 0);
                rightRect.offsetMax = new Vector2(0, 0);
            }
        }
    }

    public static List<T> FindIl2CppType<T>() where T : Object
    {
        var list = new List<T>();
        list.AddRange(Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }
    
    public static void EnablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(true);
            BlackBarCanvas.transform.SetAsLastSibling();
        }
    }


    internal static void DisablePillarBoxing()
    {
        if (!BlackBarCanvas) return;

        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(false);
        }
    }
}