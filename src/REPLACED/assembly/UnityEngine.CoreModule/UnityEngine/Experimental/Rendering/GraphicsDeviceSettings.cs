// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.GraphicsDeviceSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public static class GraphicsDeviceSettings
{
  private static readonly GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate get_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint");
  private static readonly GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate set_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint");
  private static readonly GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate get_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint");
  private static readonly GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate set_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint");

  public static WaitForPresentSyncPoint waitForPresentSyncPoint
  {
    get => GraphicsDeviceSettings.get_waitForPresentSyncPointDelegateField();
    set => GraphicsDeviceSettings.set_waitForPresentSyncPointDelegateField(value);
  }

  public static GraphicsJobsSyncPoint graphicsJobsSyncPoint
  {
    get => GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegateField();
    set => GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegateField(value);
  }

  private delegate WaitForPresentSyncPoint get_waitForPresentSyncPointDelegate();

  private delegate void set_waitForPresentSyncPointDelegate(WaitForPresentSyncPoint value);

  private delegate GraphicsJobsSyncPoint get_graphicsJobsSyncPointDelegate();

  private delegate void set_graphicsJobsSyncPointDelegate(GraphicsJobsSyncPoint value);
}
