#if WIN
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DisplayTweaks;

internal class WindowPositioner : MonoBehaviour
{
    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string className, string windowName);

    public void Start()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", Plugin.DisplayToUse.Value);
        
        MoveWindowToDisplay(Plugin.DisplayToUse.Value); 
    }

    private static void MoveWindowToDisplay(int displayIndex)
    {
        if (displayIndex >= 0 && displayIndex < Display.displays.Length)
        {
            Display.displays[displayIndex].Activate();

            var width = Display.displays[displayIndex].systemWidth;
            var height = Display.displays[displayIndex].systemHeight;
            var x = Display.displays[displayIndex].systemWidth * displayIndex;
            const int y = 0;

            var window = FindWindow(null, "BlueOakBridge");
            SetWindowPos(window, 0, x, y, width, height, 0);
        }
    }
}
#endif