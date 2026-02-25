// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.PIX
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public class PIX
{
  private static readonly PIX.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.BeginGPUCaptureDelegate>("UnityEngine.Rendering.PIX::BeginGPUCapture");
  private static readonly PIX.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.EndGPUCaptureDelegate>("UnityEngine.Rendering.PIX::EndGPUCapture");
  private static readonly PIX.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<PIX.IsAttachedDelegate>("UnityEngine.Rendering.PIX::IsAttached");

  public static void BeginGPUCapture() => PIX.BeginGPUCaptureDelegateField();

  public static void EndGPUCapture() => PIX.EndGPUCaptureDelegateField();

  public static bool IsAttached() => PIX.IsAttachedDelegateField();

  private delegate void BeginGPUCaptureDelegate();

  private delegate void EndGPUCaptureDelegate();

  private delegate bool IsAttachedDelegate();
}
