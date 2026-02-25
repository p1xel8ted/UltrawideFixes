// Decompiled with JetBrains decompiler
// Type: UnityEngine.FrameTiming
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct FrameTiming
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cpuFrameTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_cpuMainThreadFrameTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_cpuMainThreadPresentWaitTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_cpuRenderThreadFrameTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_gpuFrameTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameStartTimestamp;
  private static readonly System.IntPtr NativeFieldInfoPtr_firstSubmitTimestamp;
  private static readonly System.IntPtr NativeFieldInfoPtr_cpuTimePresentCalled;
  private static readonly System.IntPtr NativeFieldInfoPtr_cpuTimeFrameComplete;
  private static readonly System.IntPtr NativeFieldInfoPtr_heightScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_widthScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_syncInterval;
  [FieldOffset(0)]
  public double cpuFrameTime;
  [FieldOffset(8)]
  public double cpuMainThreadFrameTime;
  [FieldOffset(16 /*0x10*/)]
  public double cpuMainThreadPresentWaitTime;
  [FieldOffset(24)]
  public double cpuRenderThreadFrameTime;
  [FieldOffset(32 /*0x20*/)]
  public double gpuFrameTime;
  [FieldOffset(40)]
  public ulong frameStartTimestamp;
  [FieldOffset(48 /*0x30*/)]
  public ulong firstSubmitTimestamp;
  [FieldOffset(56)]
  public ulong cpuTimePresentCalled;
  [FieldOffset(64 /*0x40*/)]
  public ulong cpuTimeFrameComplete;
  [FieldOffset(72)]
  public float heightScale;
  [FieldOffset(76)]
  public float widthScale;
  [FieldOffset(80 /*0x50*/)]
  public uint syncInterval;

  static FrameTiming()
  {
    Il2CppClassPointerStore<FrameTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (FrameTiming));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr);
    FrameTiming.NativeFieldInfoPtr_cpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (cpuFrameTime));
    FrameTiming.NativeFieldInfoPtr_cpuMainThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (cpuMainThreadFrameTime));
    FrameTiming.NativeFieldInfoPtr_cpuMainThreadPresentWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (cpuMainThreadPresentWaitTime));
    FrameTiming.NativeFieldInfoPtr_cpuRenderThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (cpuRenderThreadFrameTime));
    FrameTiming.NativeFieldInfoPtr_gpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (gpuFrameTime));
    FrameTiming.NativeFieldInfoPtr_frameStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (frameStartTimestamp));
    FrameTiming.NativeFieldInfoPtr_firstSubmitTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (firstSubmitTimestamp));
    FrameTiming.NativeFieldInfoPtr_cpuTimePresentCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (cpuTimePresentCalled));
    FrameTiming.NativeFieldInfoPtr_cpuTimeFrameComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (cpuTimeFrameComplete));
    FrameTiming.NativeFieldInfoPtr_heightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (heightScale));
    FrameTiming.NativeFieldInfoPtr_widthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (widthScale));
    FrameTiming.NativeFieldInfoPtr_syncInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, nameof (syncInterval));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
