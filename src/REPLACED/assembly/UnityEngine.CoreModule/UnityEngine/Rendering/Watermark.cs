// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.Watermark
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public class Watermark
{
  private static readonly Watermark.IsVisibleDelegate IsVisibleDelegateField = IL2CPP.ResolveICall<Watermark.IsVisibleDelegate>("UnityEngine.Rendering.Watermark::IsVisible");

  public static bool IsVisible() => Watermark.IsVisibleDelegateField();

  private delegate bool IsVisibleDelegate();
}
