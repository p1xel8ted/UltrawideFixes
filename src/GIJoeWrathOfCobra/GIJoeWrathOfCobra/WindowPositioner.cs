﻿namespace GIJoeWrathOfCobra;

public class WindowPositioner : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string className, string windowName);

    public void Start()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", 0);
        Display._mainDisplay.Activate(Plugin.MainWidth, Plugin.MainHeight, Screen.currentResolution.refreshRateRatio);
        MoveWindowToDisplay(0);
    }

    private static void MoveWindowToDisplay(int displayIndex)
    {
        Display._mainDisplay.Activate();

        var width = Plugin.MainWidth;
        var height = Plugin.MainHeight;
        var x = Plugin.MainWidth * displayIndex;
        const int y = 0;

        var window = FindWindow(null, "GI Joe Wrath of Cobra");
        SetWindowPos(window, 0, x, y, width, height, 0);
    }
}