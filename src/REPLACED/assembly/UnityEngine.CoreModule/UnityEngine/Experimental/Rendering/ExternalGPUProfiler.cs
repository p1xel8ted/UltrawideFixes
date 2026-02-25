// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.ExternalGPUProfiler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public static class ExternalGPUProfiler
{
  private static readonly ExternalGPUProfiler.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.BeginGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture");
  private static readonly ExternalGPUProfiler.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.EndGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture");
  private static readonly ExternalGPUProfiler.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.IsAttachedDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached");

  public static void BeginGPUCapture() => ExternalGPUProfiler.BeginGPUCaptureDelegateField();

  public static void EndGPUCapture() => ExternalGPUProfiler.EndGPUCaptureDelegateField();

  public static bool IsAttached() => ExternalGPUProfiler.IsAttachedDelegateField();

  private delegate void BeginGPUCaptureDelegate();

  private delegate void EndGPUCaptureDelegate();

  private delegate bool IsAttachedDelegate();
}
