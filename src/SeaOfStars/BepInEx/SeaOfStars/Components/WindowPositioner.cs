// WindowPositioner.cs

namespace SeaOfStars.Components;

public class WindowPositioner : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string className, string windowName);

    public static WindowPositioner Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", Configuration.Configuration.DisplayToUse.Value);
        Display.displays[Configuration.Configuration.DisplayToUse.Value].Activate(DisplayManager.MainWidth, DisplayManager.MainHeight, DisplayManager.MaxRefresh);
        MoveWindowToDisplay(Configuration.Configuration.DisplayToUse.Value);
    }

    private static void MoveWindowToDisplay(int displayIndex)
    {
        Display.displays[Configuration.Configuration.DisplayToUse.Value].Activate();

        var width = DisplayManager.MainWidth;
        var height = DisplayManager.MainHeight;
        var x = DisplayManager.MainWidth * displayIndex;
        const int y = 0;

        var window = FindWindow(null, "Sea of Stars");
        SetWindowPos(window, 0, x, y, width, height, 0);
    }
}