// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerLoop.EarlyUpdate
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct EarlyUpdate
{
  static EarlyUpdate()
  {
    Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", nameof (EarlyUpdate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, (System.IntPtr) ref this));
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PollPlayerConnection
  {
    static PollPlayerConnection()
    {
      Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (PollPlayerConnection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PollHtcsPlayerConnection
  {
    static PollHtcsPlayerConnection()
    {
      Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (PollHtcsPlayerConnection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GpuTimestamp
  {
    static GpuTimestamp()
    {
      Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (GpuTimestamp));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct AnalyticsCoreStatsUpdate
  {
    static AnalyticsCoreStatsUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (AnalyticsCoreStatsUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UnityWebRequestUpdate
  {
    static UnityWebRequestUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UnityWebRequestUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateStreamingManager
  {
    static UpdateStreamingManager()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateStreamingManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ExecuteMainThreadJobs
  {
    static ExecuteMainThreadJobs()
    {
      Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ExecuteMainThreadJobs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ProcessMouseInWindow
  {
    static ProcessMouseInWindow()
    {
      Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ProcessMouseInWindow));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClearIntermediateRenderers
  {
    static ClearIntermediateRenderers()
    {
      Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ClearIntermediateRenderers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ClearLines
  {
    static ClearLines()
    {
      Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ClearLines));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PresentBeforeUpdate
  {
    static PresentBeforeUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (PresentBeforeUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ResetFrameStatsAfterPresent
  {
    static ResetFrameStatsAfterPresent()
    {
      Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ResetFrameStatsAfterPresent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateAsyncReadbackManager
  {
    static UpdateAsyncReadbackManager()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateAsyncReadbackManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateTextureStreamingManager
  {
    static UpdateTextureStreamingManager()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateTextureStreamingManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdatePreloading
  {
    static UpdatePreloading()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdatePreloading));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateContentLoading
  {
    static UpdateContentLoading()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateContentLoading));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateContentLoading>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateAsyncInstantiate
  {
    static UpdateAsyncInstantiate()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateAsyncInstantiate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncInstantiate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct RendererNotifyInvisible
  {
    static RendererNotifyInvisible()
    {
      Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (RendererNotifyInvisible));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerCleanupCachedData
  {
    static PlayerCleanupCachedData()
    {
      Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (PlayerCleanupCachedData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateMainGameViewRect
  {
    static UpdateMainGameViewRect()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateMainGameViewRect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateCanvasRectTransform
  {
    static UpdateCanvasRectTransform()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateCanvasRectTransform));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateInputManager
  {
    static UpdateInputManager()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateInputManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ProcessRemoteInput
  {
    static ProcessRemoteInput()
    {
      Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ProcessRemoteInput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct XRUpdate
  {
    static XRUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (XRUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ScriptRunDelayedStartupFrame
  {
    static ScriptRunDelayedStartupFrame()
    {
      Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ScriptRunDelayedStartupFrame));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateKinect
  {
    static UpdateKinect()
    {
      Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (UpdateKinect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DeliverIosPlatformEvents
  {
    static DeliverIosPlatformEvents()
    {
      Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (DeliverIosPlatformEvents));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DispatchEventQueueEvents
  {
    static DispatchEventQueueEvents()
    {
      Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (DispatchEventQueueEvents));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Physics2DEarlyUpdate
  {
    static Physics2DEarlyUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (Physics2DEarlyUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.Physics2DEarlyUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PhysicsResetInterpolatedTransformPosition
  {
    static PhysicsResetInterpolatedTransformPosition()
    {
      Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (PhysicsResetInterpolatedTransformPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SpriteAtlasManagerUpdate
  {
    static SpriteAtlasManagerUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (SpriteAtlasManagerUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TangoUpdate
  {
    static TangoUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (TangoUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ARCoreUpdate
  {
    static ARCoreUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (ARCoreUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PerformanceAnalyticsUpdate
  {
    static PerformanceAnalyticsUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (PerformanceAnalyticsUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TilemapRendererEarlyUpdate
  {
    static TilemapRendererEarlyUpdate()
    {
      Il2CppClassPointerStore<EarlyUpdate.TilemapRendererEarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, nameof (TilemapRendererEarlyUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.TilemapRendererEarlyUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.TilemapRendererEarlyUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public struct ProfilerStartFrame
  {
  }
}
