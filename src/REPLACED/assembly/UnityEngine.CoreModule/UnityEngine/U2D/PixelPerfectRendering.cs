// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.PixelPerfectRendering
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.U2D;

public static class PixelPerfectRendering
{
  private static readonly PixelPerfectRendering.get_pixelSnapSpacingDelegate get_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.get_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing");
  private static readonly PixelPerfectRendering.set_pixelSnapSpacingDelegate set_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.set_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::set_pixelSnapSpacing");

  public static float pixelSnapSpacing
  {
    get => PixelPerfectRendering.get_pixelSnapSpacingDelegateField();
    set => PixelPerfectRendering.set_pixelSnapSpacingDelegateField(value);
  }

  private delegate float get_pixelSnapSpacingDelegate();

  private delegate void set_pixelSnapSpacingDelegate(float value);
}
