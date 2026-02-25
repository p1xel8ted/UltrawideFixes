// Decompiled with JetBrains decompiler
// Type: UnityEngine.Apple.FrameCapture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Apple;

public class FrameCapture
{
  private static readonly FrameCapture.IsDestinationSupportedImplDelegate IsDestinationSupportedImplDelegateField = IL2CPP.ResolveICall<FrameCapture.IsDestinationSupportedImplDelegate>("UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl");
  private static readonly FrameCapture.EndCaptureImplDelegate EndCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.EndCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::EndCaptureImpl");
  private static readonly FrameCapture.BeginCaptureImpl_InjectedDelegate BeginCaptureImpl_InjectedDelegateField = IL2CPP.ResolveICall<FrameCapture.BeginCaptureImpl_InjectedDelegate>("UnityEngine.Apple.FrameCapture::BeginCaptureImpl_Injected");
  private static readonly FrameCapture.CaptureNextFrameImpl_InjectedDelegate CaptureNextFrameImpl_InjectedDelegateField = IL2CPP.ResolveICall<FrameCapture.CaptureNextFrameImpl_InjectedDelegate>("UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl_Injected");

  public static bool IsDestinationSupportedImpl(FrameCaptureDestination dest)
  {
    return FrameCapture.IsDestinationSupportedImplDelegateField(dest);
  }

  public static unsafe void BeginCaptureImpl(FrameCaptureDestination dest, string path)
  {
    try
    {
      int dest1 = (int) dest;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = path.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      FrameCapture.BeginCaptureImpl_Injected((FrameCaptureDestination) dest1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void EndCaptureImpl() => FrameCapture.EndCaptureImplDelegateField();

  public static unsafe void CaptureNextFrameImpl(FrameCaptureDestination dest, string path)
  {
    try
    {
      int dest1 = (int) dest;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = path.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      FrameCapture.CaptureNextFrameImpl_Injected((FrameCaptureDestination) dest1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static bool IsDestinationSupported(FrameCaptureDestination dest)
  {
    return dest == FrameCaptureDestination.DevTools || dest == FrameCaptureDestination.GPUTraceDocument ? FrameCapture.IsDestinationSupportedImpl(dest) : throw new Il2CppSystem.ArgumentException(nameof (dest), "Argument dest has bad value (not one of FrameCaptureDestination enum values)");
  }

  public static void BeginCaptureToXcode()
  {
    if (!FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools))
      throw new Il2CppSystem.InvalidOperationException("Frame Capture with DevTools is not supported.");
    FrameCapture.BeginCaptureImpl(FrameCaptureDestination.DevTools, (string) null);
  }

  public static void BeginCaptureToFile(string path)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void EndCapture() => FrameCapture.EndCaptureImpl();

  public static void CaptureNextFrameToXcode()
  {
    if (!FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools))
      throw new Il2CppSystem.InvalidOperationException("Frame Capture with DevTools is not supported.");
    FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.DevTools, (string) null);
  }

  public static void CaptureNextFrameToFile(string path)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void BeginCaptureImpl_Injected(
    FrameCaptureDestination dest,
    ref ManagedSpanWrapper path)
  {
    FrameCapture.BeginCaptureImpl_InjectedDelegateField(dest, (System.IntPtr) ref path);
  }

  public static void CaptureNextFrameImpl_Injected(
    FrameCaptureDestination dest,
    ref ManagedSpanWrapper path)
  {
    FrameCapture.CaptureNextFrameImpl_InjectedDelegateField(dest, (System.IntPtr) ref path);
  }

  private delegate bool IsDestinationSupportedImplDelegate(FrameCaptureDestination dest);

  private delegate void EndCaptureImplDelegate();

  private delegate void BeginCaptureImpl_InjectedDelegate(FrameCaptureDestination dest, System.IntPtr path);

  private delegate void CaptureNextFrameImpl_InjectedDelegate(
    FrameCaptureDestination dest,
    System.IntPtr path);
}
