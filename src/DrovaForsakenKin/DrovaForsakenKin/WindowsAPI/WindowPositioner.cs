namespace DrovaForsakenKin.WindowsAPI;

public class WindowPositioner : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string className, string windowName);

    public void Start()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", Plugin.DisplayToUse.Value);
        Display.displays[Plugin.DisplayToUse.Value].Activate(Plugin.MainWidth, Plugin.MainHeight, Plugin.MaxRefresh);
        MoveWindowToDisplay(Plugin.DisplayToUse.Value);
    }

    private static void MoveWindowToDisplay(int displayIndex)
    {
        Display.displays[Plugin.DisplayToUse.Value].Activate();

        var width = Plugin.MainWidth;
        var height = Plugin.MainHeight;
        var x = Plugin.MainWidth * displayIndex;
        const int y = 0;

        var window = FindWindow(null, "Drova");
        SetWindowPos(window, 0, x, y, width, height, 0);
    }
}