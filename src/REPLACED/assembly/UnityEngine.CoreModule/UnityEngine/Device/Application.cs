// Decompiled with JetBrains decompiler
// Type: UnityEngine.Device.Application
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Threading;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

#nullable disable
namespace UnityEngine.Device;

public static class Application
{
  public static string absoluteURL => UnityEngine.Application.absoluteURL;

  public static ThreadPriority backgroundLoadingPriority
  {
    get => UnityEngine.Application.backgroundLoadingPriority;
    set => UnityEngine.Application.backgroundLoadingPriority = value;
  }

  public static string buildGUID => UnityEngine.Application.buildGUID;

  public static string cloudProjectId => UnityEngine.Application.cloudProjectId;

  public static string companyName => UnityEngine.Application.companyName;

  public static string consoleLogPath => UnityEngine.Application.consoleLogPath;

  public static string dataPath => UnityEngine.Application.dataPath;

  public static bool genuine => UnityEngine.Application.genuine;

  public static bool genuineCheckAvailable => UnityEngine.Application.genuineCheckAvailable;

  public static string identifier => UnityEngine.Application.identifier;

  public static string installerName => UnityEngine.Application.installerName;

  public static ApplicationInstallMode installMode => UnityEngine.Application.installMode;

  public static NetworkReachability internetReachability => UnityEngine.Application.internetReachability;

  public static bool isBatchMode => UnityEngine.Application.isBatchMode;

  public static bool isConsolePlatform => UnityEngine.Application.isConsolePlatform;

  public static bool isEditor => UnityEngine.Application.isEditor;

  public static bool isFocused => UnityEngine.Application.isFocused;

  public static bool isMobilePlatform => UnityEngine.Application.isMobilePlatform;

  public static bool isPlaying => UnityEngine.Application.isPlaying;

  public static string persistentDataPath => UnityEngine.Application.persistentDataPath;

  public static RuntimePlatform platform => UnityEngine.Application.platform;

  public static string productName => UnityEngine.Application.productName;

  public static bool runInBackground
  {
    get => UnityEngine.Application.runInBackground;
    set => UnityEngine.Application.runInBackground = value;
  }

  public static ApplicationSandboxType sandboxType => UnityEngine.Application.sandboxType;

  public static string streamingAssetsPath => UnityEngine.Application.streamingAssetsPath;

  public static SystemLanguage systemLanguage => UnityEngine.Application.systemLanguage;

  public static int targetFrameRate
  {
    get => UnityEngine.Application.targetFrameRate;
    set => UnityEngine.Application.targetFrameRate = value;
  }

  public static string temporaryCachePath => UnityEngine.Application.temporaryCachePath;

  public static string unityVersion => UnityEngine.Application.unityVersion;

  public static string version => UnityEngine.Application.version;

  [SpecialName]
  public static void add_deepLinkActivated(Action<string> value)
  {
    UnityEngine.Application.add_deepLinkActivated(value);
  }

  [SpecialName]
  public static void remove_deepLinkActivated(Action<string> value)
  {
    UnityEngine.Application.remove_deepLinkActivated(value);
  }

  [SpecialName]
  public static void add_focusChanged(Action<bool> value) => UnityEngine.Application.add_focusChanged(value);

  [SpecialName]
  public static void remove_focusChanged(Action<bool> value)
  {
    UnityEngine.Application.remove_focusChanged(value);
  }

  [SpecialName]
  public static void add_logMessageReceived(UnityEngine.Application.LogCallback value)
  {
    UnityEngine.Application.add_logMessageReceived(value);
  }

  [SpecialName]
  public static void remove_logMessageReceived(UnityEngine.Application.LogCallback value)
  {
    UnityEngine.Application.remove_logMessageReceived(value);
  }

  [SpecialName]
  public static void add_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value)
  {
    UnityEngine.Application.add_logMessageReceivedThreaded(value);
  }

  [SpecialName]
  public static void remove_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value)
  {
    UnityEngine.Application.remove_logMessageReceivedThreaded(value);
  }

  [SpecialName]
  public static void add_lowMemory(UnityEngine.Application.LowMemoryCallback value)
  {
    UnityEngine.Application.add_lowMemory(value);
  }

  [SpecialName]
  public static void remove_lowMemory(UnityEngine.Application.LowMemoryCallback value)
  {
    UnityEngine.Application.remove_lowMemory(value);
  }

  [SpecialName]
  public static void add_memoryUsageChanged(UnityEngine.Application.MemoryUsageChangedCallback value)
  {
    UnityEngine.Application.add_memoryUsageChanged(value);
  }

  [SpecialName]
  public static void remove_memoryUsageChanged(UnityEngine.Application.MemoryUsageChangedCallback value)
  {
    UnityEngine.Application.remove_memoryUsageChanged(value);
  }

  [SpecialName]
  public static void add_onBeforeRender(UnityAction value) => UnityEngine.Application.add_onBeforeRender(value);

  [SpecialName]
  public static void remove_onBeforeRender(UnityAction value)
  {
    UnityEngine.Application.remove_onBeforeRender(value);
  }

  [SpecialName]
  public static void add_quitting(Action value) => UnityEngine.Application.add_quitting(value);

  [SpecialName]
  public static void remove_quitting(Action value) => UnityEngine.Application.remove_quitting(value);

  [SpecialName]
  public static void add_wantsToQuit(Func<bool> value) => UnityEngine.Application.add_wantsToQuit(value);

  [SpecialName]
  public static void remove_wantsToQuit(Func<bool> value) => UnityEngine.Application.remove_wantsToQuit(value);

  [SpecialName]
  public static void add_unloading(Action value) => UnityEngine.Application.add_unloading(value);

  [SpecialName]
  public static void remove_unloading(Action value) => UnityEngine.Application.remove_unloading(value);

  public static bool CanStreamedLevelBeLoaded(int levelIndex)
  {
    return UnityEngine.Application.CanStreamedLevelBeLoaded(levelIndex);
  }

  public static bool CanStreamedLevelBeLoaded(string levelName)
  {
    return UnityEngine.Application.CanStreamedLevelBeLoaded(levelName);
  }

  public static Il2CppStringArray GetBuildTags() => UnityEngine.Application.GetBuildTags();

  public static void SetBuildTags(Il2CppStringArray buildTags)
  {
    UnityEngine.Application.SetBuildTags(buildTags);
  }

  public static StackTraceLogType GetStackTraceLogType(LogType logType)
  {
    return UnityEngine.Application.GetStackTraceLogType(logType);
  }

  public static bool HasProLicense() => UnityEngine.Application.HasProLicense();

  public static bool HasUserAuthorization(UserAuthorization mode)
  {
    return UnityEngine.Application.HasUserAuthorization(mode);
  }

  public static bool IsPlaying(UnityEngine.Object obj) => UnityEngine.Application.IsPlaying(obj);

  public static void OpenURL(string url) => UnityEngine.Application.OpenURL(url);

  public static void Quit() => UnityEngine.Application.Quit();

  public static void Quit(int exitCode) => UnityEngine.Application.Quit(exitCode);

  public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
  {
    return UnityEngine.Application.RequestUserAuthorization(mode);
  }

  public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
  {
    UnityEngine.Application.SetStackTraceLogType(logType, stackTraceType);
  }

  public static void Unload() => UnityEngine.Application.Unload();

  public static CancellationToken exitCancellationToken => UnityEngine.Application.exitCancellationToken;
}
