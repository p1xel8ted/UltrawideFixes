namespace RuinedKingLoL.MonoBehaviours;

public class WindowPositioner : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string className, string windowName);

    public void Start()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", Plugin.DisplayToUse.Value);
        Display.displays[Plugin.DisplayToUse.Value].Activate(Plugin.GetCustomRes().width, Plugin.GetCustomRes().height, Plugin.GetCustomRes().refreshRate);
        MoveWindowToDisplay(Plugin.DisplayToUse.Value);
    }

    private static void MoveWindowToDisplay(int displayIndex)
    {
        Display.displays[Plugin.DisplayToUse.Value].Activate();
        var resolution = Plugin.GetCustomRes();
        var width = resolution.width;
        var height = resolution.height;
        var x = resolution.width * displayIndex;
        const int y = 0;

        var window = FindWindow(null, "Ruined King");
        SetWindowPos(window, 0, x, y, width, height, 0);
    }
}