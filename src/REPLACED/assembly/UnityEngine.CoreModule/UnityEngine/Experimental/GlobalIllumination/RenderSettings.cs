// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.RenderSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

public class RenderSettings
{
  private static readonly RenderSettings.get_useRadianceAmbientProbeDelegate get_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::get_useRadianceAmbientProbe");
  private static readonly RenderSettings.set_useRadianceAmbientProbeDelegate set_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::set_useRadianceAmbientProbe");

  public static bool useRadianceAmbientProbe
  {
    get => RenderSettings.get_useRadianceAmbientProbeDelegateField();
    set => RenderSettings.set_useRadianceAmbientProbeDelegateField(value);
  }

  private delegate bool get_useRadianceAmbientProbeDelegate();

  private delegate void set_useRadianceAmbientProbeDelegate(bool value);
}
