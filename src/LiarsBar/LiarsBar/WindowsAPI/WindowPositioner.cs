namespace LiarsBar.WindowsAPI;

public class WindowPositioner : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string className, string windowName);

    public void Start()
    {
        var res = Plugin.SelectedResolution;
        PlayerPrefs.SetInt("UnitySelectMonitor", Plugin.DisplayToUse.Value);
        Display.displays[Plugin.DisplayToUse.Value].Activate(res.width, res.height, Plugin.RefreshRateRatio);
        MoveWindowToDisplay(Plugin.DisplayToUse.Value);
    }

    private static void MoveWindowToDisplay(int displayIndex)
    {
        var res = Plugin.SelectedResolution;
        Display.displays[Plugin.DisplayToUse.Value].Activate();

        var width = res.width;
        var height = res.height;
        var x = res.width * displayIndex;
        const int y = 0;

        var window = FindWindow(null, "Liar's Bar");
        SetWindowPos(window, 0, x, y, width, height, 0);
    }
}