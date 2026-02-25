// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SplashScreen
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public class SplashScreen
{
  private static readonly SplashScreen.get_isFinishedDelegate get_isFinishedDelegateField = IL2CPP.ResolveICall<SplashScreen.get_isFinishedDelegate>("UnityEngine.Rendering.SplashScreen::get_isFinished");
  private static readonly SplashScreen.CancelSplashScreenDelegate CancelSplashScreenDelegateField = IL2CPP.ResolveICall<SplashScreen.CancelSplashScreenDelegate>("UnityEngine.Rendering.SplashScreen::CancelSplashScreen");
  private static readonly SplashScreen.BeginSplashScreenFadeDelegate BeginSplashScreenFadeDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginSplashScreenFadeDelegate>("UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade");
  private static readonly SplashScreen.BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginDelegate>("UnityEngine.Rendering.SplashScreen::Begin");
  private static readonly SplashScreen.DrawDelegate DrawDelegateField = IL2CPP.ResolveICall<SplashScreen.DrawDelegate>("UnityEngine.Rendering.SplashScreen::Draw");
  private static readonly SplashScreen.SetTimeDelegate SetTimeDelegateField = IL2CPP.ResolveICall<SplashScreen.SetTimeDelegate>("UnityEngine.Rendering.SplashScreen::SetTime");

  public static bool isFinished => SplashScreen.get_isFinishedDelegateField();

  public static void CancelSplashScreen() => SplashScreen.CancelSplashScreenDelegateField();

  public static void BeginSplashScreenFade() => SplashScreen.BeginSplashScreenFadeDelegateField();

  public static void Begin() => SplashScreen.BeginDelegateField();

  public static void Stop(SplashScreen.StopBehavior stopBehavior)
  {
    if (stopBehavior == SplashScreen.StopBehavior.FadeOut)
      SplashScreen.BeginSplashScreenFade();
    else
      SplashScreen.CancelSplashScreen();
  }

  public static void Draw() => SplashScreen.DrawDelegateField();

  public static void SetTime(float time) => SplashScreen.SetTimeDelegateField(time);

  public enum StopBehavior
  {
    StopImmediate,
    FadeOut,
  }

  private delegate bool get_isFinishedDelegate();

  private delegate void CancelSplashScreenDelegate();

  private delegate void BeginSplashScreenFadeDelegate();

  private delegate void BeginDelegate();

  private delegate void DrawDelegate();

  private delegate void SetTimeDelegate(float time);
}
