// Decompiled with JetBrains decompiler
// Type: UnityEngine.Device.Screen
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Device;

public static class Screen
{
  public static float brightness
  {
    get => UnityEngine.Screen.brightness;
    set => UnityEngine.Screen.brightness = value;
  }

  public static bool autorotateToLandscapeLeft
  {
    get => UnityEngine.Screen.autorotateToLandscapeLeft;
    set => UnityEngine.Screen.autorotateToLandscapeLeft = value;
  }

  public static bool autorotateToLandscapeRight
  {
    get => UnityEngine.Screen.autorotateToLandscapeRight;
    set => UnityEngine.Screen.autorotateToLandscapeRight = value;
  }

  public static bool autorotateToPortrait
  {
    get => UnityEngine.Screen.autorotateToPortrait;
    set => UnityEngine.Screen.autorotateToPortrait = value;
  }

  public static bool autorotateToPortraitUpsideDown
  {
    get => UnityEngine.Screen.autorotateToPortraitUpsideDown;
    set => UnityEngine.Screen.autorotateToPortraitUpsideDown = value;
  }

  public static Resolution currentResolution => UnityEngine.Screen.currentResolution;

  public static Il2CppStructArray<Rect> cutouts => UnityEngine.Screen.cutouts;

  public static float dpi => UnityEngine.Screen.dpi;

  public static bool fullScreen
  {
    get => UnityEngine.Screen.fullScreen;
    set => UnityEngine.Screen.fullScreen = value;
  }

  public static FullScreenMode fullScreenMode
  {
    get => UnityEngine.Screen.fullScreenMode;
    set => UnityEngine.Screen.fullScreenMode = value;
  }

  public static int height => UnityEngine.Screen.height;

  public static int width => UnityEngine.Screen.width;

  public static ScreenOrientation orientation
  {
    get => UnityEngine.Screen.orientation;
    set => UnityEngine.Screen.orientation = value;
  }

  public static Il2CppStructArray<Resolution> resolutions => UnityEngine.Screen.resolutions;

  public static Rect safeArea => UnityEngine.Screen.safeArea;

  public static int sleepTimeout
  {
    get => UnityEngine.Screen.sleepTimeout;
    set => UnityEngine.Screen.sleepTimeout = value;
  }

  public static void SetResolution(
    int width,
    int height,
    FullScreenMode fullscreenMode,
    RefreshRate preferredRefreshRate)
  {
    UnityEngine.Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
  }

  public static void SetResolution(
    int width,
    int height,
    FullScreenMode fullscreenMode,
    int preferredRefreshRate)
  {
    if (preferredRefreshRate < 0)
      preferredRefreshRate = 0;
    UnityEngine.Screen.SetResolution(width, height, fullscreenMode, new RefreshRate()
    {
      numerator = (uint) preferredRefreshRate,
      denominator = 1U
    });
  }

  public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
  {
    Screen.SetResolution(width, height, fullscreenMode, new RefreshRate()
    {
      numerator = 0U,
      denominator = 1U
    });
  }

  public static void SetResolution(
    int width,
    int height,
    bool fullscreen,
    int preferredRefreshRate)
  {
    if (preferredRefreshRate < 0)
      preferredRefreshRate = 0;
    Screen.SetResolution(width, height, (FullScreenMode) (fullscreen ? 1 : 3), new RefreshRate()
    {
      numerator = (uint) preferredRefreshRate,
      denominator = 1U
    });
  }

  public static void SetResolution(int width, int height, bool fullscreen)
  {
    Screen.SetResolution(width, height, (FullScreenMode) (fullscreen ? 1 : 3), new RefreshRate()
    {
      numerator = 0U,
      denominator = 1U
    });
  }

  public static Vector2Int mainWindowPosition => UnityEngine.Screen.mainWindowPosition;

  public static DisplayInfo mainWindowDisplayInfo => UnityEngine.Screen.mainWindowDisplayInfo;

  public static void GetDisplayLayout(List<DisplayInfo> displayLayout)
  {
    UnityEngine.Screen.GetDisplayLayout(displayLayout);
  }

  public static AsyncOperation MoveMainWindowTo([In] ref DisplayInfo display, Vector2Int position)
  {
    return UnityEngine.Screen.MoveMainWindowTo(ref display, position);
  }

  public static void SetMSAASamples(int numSamples) => UnityEngine.Screen.SetMSAASamples(numSamples);

  public static int msaaSamples => UnityEngine.Screen.msaaSamples;
}
