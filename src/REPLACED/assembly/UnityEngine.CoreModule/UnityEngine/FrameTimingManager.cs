// Decompiled with JetBrains decompiler
// Type: UnityEngine.FrameTimingManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public static class FrameTimingManager : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestTimings_Injected_Private_Static_UInt32_UInt32_byref_ManagedSpanWrapper_0;
  private static readonly FrameTimingManager.IsFeatureEnabledDelegate IsFeatureEnabledDelegateField;
  private static readonly FrameTimingManager.GetVSyncsPerSecondDelegate GetVSyncsPerSecondDelegateField;
  private static readonly FrameTimingManager.GetGpuTimerFrequencyDelegate GetGpuTimerFrequencyDelegateField;
  private static readonly FrameTimingManager.GetCpuTimerFrequencyDelegate GetCpuTimerFrequencyDelegateField;

  static FrameTimingManager()
  {
    Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (FrameTimingManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr);
    FrameTimingManager.NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664758);
    FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664759);
    FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Injected_Private_Static_UInt32_UInt32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664760);
    FrameTimingManager.IsFeatureEnabledDelegateField = IL2CPP.ResolveICall<FrameTimingManager.IsFeatureEnabledDelegate>("UnityEngine.FrameTimingManager::IsFeatureEnabled");
    FrameTimingManager.GetVSyncsPerSecondDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetVSyncsPerSecondDelegate>("UnityEngine.FrameTimingManager::GetVSyncsPerSecond");
    FrameTimingManager.GetGpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetGpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetGpuTimerFrequency");
    FrameTimingManager.GetCpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetCpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetCpuTimerFrequency");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423676, RefRangeEnd = 423677, XrefRangeStart = 423674, XrefRangeEnd = 423676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CaptureFrameTimings()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423686, RefRangeEnd = 423687, XrefRangeStart = 423677, XrefRangeEnd = 423686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetLatestTimings(uint numFrames, Il2CppStructArray<FrameTiming> timings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &numFrames;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) timings);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423687, XrefRangeEnd = 423689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetLatestTimings_Injected(
    uint numFrames,
    ref ManagedSpanWrapper timings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &numFrames;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref timings;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Injected_Private_Static_UInt32_UInt32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public FrameTimingManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static bool IsFeatureEnabled() => FrameTimingManager.IsFeatureEnabledDelegateField();

  public static float GetVSyncsPerSecond() => FrameTimingManager.GetVSyncsPerSecondDelegateField();

  public static ulong GetGpuTimerFrequency()
  {
    return FrameTimingManager.GetGpuTimerFrequencyDelegateField();
  }

  public static ulong GetCpuTimerFrequency()
  {
    return FrameTimingManager.GetCpuTimerFrequencyDelegateField();
  }

  private delegate bool IsFeatureEnabledDelegate();

  private delegate float GetVSyncsPerSecondDelegate();

  private delegate ulong GetGpuTimerFrequencyDelegate();

  private delegate ulong GetCpuTimerFrequencyDelegate();
}
