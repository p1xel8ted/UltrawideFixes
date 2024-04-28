using System.Runtime.InteropServices;

namespace LastCloudia.Misc;

internal static class KeyPressSimulator
{
    [DllImport("user32.dll")]
    private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
    private const int KEYEVENTF_KEYUP = 0x0002;
    private const byte VK_ESCAPE = 0x1B;

    internal static void PressESC()
    {
        keybd_event(VK_ESCAPE, 0, 0, 0);
        keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, 0);
    }
}