// Decompiled with JetBrains decompiler
// Type: UnityEngine.Time
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.IntegerTime;

#nullable disable
namespace UnityEngine;

public class Time(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsDouble_Public_Static_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsRational_Public_Static_get_RationalTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsRational_Injected_Private_Static_Void_byref_RationalTime_0;
  private static readonly Time.get_timeSinceLevelLoadDelegate get_timeSinceLevelLoadDelegateField;
  private static readonly Time.get_timeSinceLevelLoadAsDoubleDelegate get_timeSinceLevelLoadAsDoubleDelegateField;
  private static readonly Time.get_fixedTimeAsDoubleDelegate get_fixedTimeAsDoubleDelegateField;
  private static readonly Time.get_unscaledTimeAsDoubleDelegate get_unscaledTimeAsDoubleDelegateField;
  private static readonly Time.get_fixedUnscaledTimeDelegate get_fixedUnscaledTimeDelegateField;
  private static readonly Time.get_fixedUnscaledTimeAsDoubleDelegate get_fixedUnscaledTimeAsDoubleDelegateField;
  private static readonly Time.get_fixedUnscaledDeltaTimeDelegate get_fixedUnscaledDeltaTimeDelegateField;
  private static readonly Time.set_fixedDeltaTimeDelegate set_fixedDeltaTimeDelegateField;
  private static readonly Time.set_maximumDeltaTimeDelegate set_maximumDeltaTimeDelegateField;
  private static readonly Time.get_maximumParticleDeltaTimeDelegate get_maximumParticleDeltaTimeDelegateField;
  private static readonly Time.set_maximumParticleDeltaTimeDelegate set_maximumParticleDeltaTimeDelegateField;
  private static readonly Time.get_renderedFrameCountDelegate get_renderedFrameCountDelegateField;
  private static readonly Time.get_captureDeltaTimeDelegate get_captureDeltaTimeDelegateField;
  private static readonly Time.set_captureDeltaTimeDelegate set_captureDeltaTimeDelegateField;
  private static readonly Time.get_inFixedTimeStepDelegate get_inFixedTimeStepDelegateField;
  private static readonly Time.get_captureDeltaTimeRational_InjectedDelegate get_captureDeltaTimeRational_InjectedDelegateField;
  private static readonly Time.set_captureDeltaTimeRational_InjectedDelegate set_captureDeltaTimeRational_InjectedDelegateField;

  static Time()
  {
    Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Time));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
    Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668588);
    Time.NativeMethodInfoPtr_get_timeAsDouble_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668589);
    Time.NativeMethodInfoPtr_get_timeAsRational_Public_Static_get_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668590);
    Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668591);
    Time.NativeMethodInfoPtr_get_fixedTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668592);
    Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668593);
    Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668594);
    Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668595);
    Time.NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668596);
    Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668597);
    Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668598);
    Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668599);
    Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668600);
    Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668601);
    Time.NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668602);
    Time.NativeMethodInfoPtr_get_timeAsRational_Injected_Private_Static_Void_byref_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100668603);
    Time.get_timeSinceLevelLoadDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadDelegate>("UnityEngine.Time::get_timeSinceLevelLoad");
    Time.get_timeSinceLevelLoadAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadAsDoubleDelegate>("UnityEngine.Time::get_timeSinceLevelLoadAsDouble");
    Time.get_fixedTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedTimeAsDouble");
    Time.get_unscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_unscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_unscaledTimeAsDouble");
    Time.get_fixedUnscaledTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeDelegate>("UnityEngine.Time::get_fixedUnscaledTime");
    Time.get_fixedUnscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedUnscaledTimeAsDouble");
    Time.get_fixedUnscaledDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledDeltaTimeDelegate>("UnityEngine.Time::get_fixedUnscaledDeltaTime");
    Time.set_fixedDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_fixedDeltaTimeDelegate>("UnityEngine.Time::set_fixedDeltaTime");
    Time.set_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumDeltaTimeDelegate>("UnityEngine.Time::set_maximumDeltaTime");
    Time.get_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::get_maximumParticleDeltaTime");
    Time.set_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::set_maximumParticleDeltaTime");
    Time.get_renderedFrameCountDelegateField = IL2CPP.ResolveICall<Time.get_renderedFrameCountDelegate>("UnityEngine.Time::get_renderedFrameCount");
    Time.get_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_captureDeltaTimeDelegate>("UnityEngine.Time::get_captureDeltaTime");
    Time.set_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_captureDeltaTimeDelegate>("UnityEngine.Time::set_captureDeltaTime");
    Time.get_inFixedTimeStepDelegateField = IL2CPP.ResolveICall<Time.get_inFixedTimeStepDelegate>("UnityEngine.Time::get_inFixedTimeStep");
    Time.get_captureDeltaTimeRational_InjectedDelegateField = IL2CPP.ResolveICall<Time.get_captureDeltaTimeRational_InjectedDelegate>("UnityEngine.Time::get_captureDeltaTimeRational_Injected");
    Time.set_captureDeltaTimeRational_InjectedDelegateField = IL2CPP.ResolveICall<Time.set_captureDeltaTimeRational_InjectedDelegate>("UnityEngine.Time::set_captureDeltaTimeRational_Injected");
  }

  public static unsafe float time
  {
    [CallerCount(71), CachedScanResults(RefRangeStart = 465212, RefRangeEnd = 465283, XrefRangeStart = 465210, XrefRangeEnd = 465212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe double timeAsDouble
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465283, XrefRangeEnd = 465285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeAsDouble_Public_Static_get_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RationalTime timeAsRational
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 465287, RefRangeEnd = 465293, XrefRangeStart = 465285, XrefRangeEnd = 465287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeAsRational_Public_Static_get_RationalTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RationalTime*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float deltaTime
  {
    [CallerCount(251), CachedScanResults(RefRangeStart = 465295, RefRangeEnd = 465546, XrefRangeStart = 465293, XrefRangeEnd = 465295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float fixedTime
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 465548, RefRangeEnd = 465549, XrefRangeStart = 465546, XrefRangeEnd = 465548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float unscaledTime
  {
    [CallerCount(41), CachedScanResults(RefRangeStart = 465551, RefRangeEnd = 465592, XrefRangeStart = 465549, XrefRangeEnd = 465551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float unscaledDeltaTime
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 465594, RefRangeEnd = 465653, XrefRangeStart = 465592, XrefRangeEnd = 465594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float fixedDeltaTime
  {
    [CallerCount(36), CachedScanResults(RefRangeStart = 465655, RefRangeEnd = 465691, XrefRangeStart = 465653, XrefRangeEnd = 465655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => Time.set_fixedDeltaTimeDelegateField(value);
  }

  public static unsafe float maximumDeltaTime
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 465693, RefRangeEnd = 465695, XrefRangeStart = 465691, XrefRangeEnd = 465693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => Time.set_maximumDeltaTimeDelegateField(value);
  }

  public static unsafe float smoothDeltaTime
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 465697, RefRangeEnd = 465704, XrefRangeStart = 465695, XrefRangeEnd = 465697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float timeScale
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 465706, RefRangeEnd = 465718, XrefRangeStart = 465704, XrefRangeEnd = 465706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(51), CachedScanResults(RefRangeStart = 465720, RefRangeEnd = 465771, XrefRangeStart = 465718, XrefRangeEnd = 465720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe int frameCount
  {
    [CallerCount(100), CachedScanResults(RefRangeStart = 465773, RefRangeEnd = 465873, XrefRangeStart = 465771, XrefRangeEnd = 465773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float realtimeSinceStartup
  {
    [CallerCount(76), CachedScanResults(RefRangeStart = 465875, RefRangeEnd = 465951, XrefRangeStart = 465873, XrefRangeEnd = 465875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe double realtimeSinceStartupAsDouble
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465951, XrefRangeEnd = 465953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465953, XrefRangeEnd = 465955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_timeAsRational_Injected(out RationalTime ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeAsRational_Injected_Private_Static_Void_byref_RationalTime_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static float timeSinceLevelLoad => Time.get_timeSinceLevelLoadDelegateField();

  public static double timeSinceLevelLoadAsDouble
  {
    get => Time.get_timeSinceLevelLoadAsDoubleDelegateField();
  }

  public static double fixedTimeAsDouble => Time.get_fixedTimeAsDoubleDelegateField();

  public static double unscaledTimeAsDouble => Time.get_unscaledTimeAsDoubleDelegateField();

  public static float fixedUnscaledTime => Time.get_fixedUnscaledTimeDelegateField();

  public static double fixedUnscaledTimeAsDouble
  {
    get => Time.get_fixedUnscaledTimeAsDoubleDelegateField();
  }

  public static float fixedUnscaledDeltaTime => Time.get_fixedUnscaledDeltaTimeDelegateField();

  public static float maximumParticleDeltaTime
  {
    get => Time.get_maximumParticleDeltaTimeDelegateField();
    set => Time.set_maximumParticleDeltaTimeDelegateField(value);
  }

  public static int renderedFrameCount => Time.get_renderedFrameCountDelegateField();

  public static float captureDeltaTime
  {
    get => Time.get_captureDeltaTimeDelegateField();
    set => Time.set_captureDeltaTimeDelegateField(value);
  }

  public static RationalTime captureDeltaTimeRational
  {
    get
    {
      RationalTime ret;
      Time.get_captureDeltaTimeRational_Injected(out ret);
      return ret;
    }
    set => Time.set_captureDeltaTimeRational_Injected(ref value);
  }

  public static int captureFramerate
  {
    get
    {
      return (double) Time.captureDeltaTime == 0.0 ? 0 : (int) Mathf.Round(1f / Time.captureDeltaTime);
    }
    set => Time.captureDeltaTime = value == 0 ? 0.0f : 1f / (float) value;
  }

  public static bool inFixedTimeStep => Time.get_inFixedTimeStepDelegateField();

  public static void get_captureDeltaTimeRational_Injected(out RationalTime ret)
  {
    Time.get_captureDeltaTimeRational_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void set_captureDeltaTimeRational_Injected([In] ref RationalTime value)
  {
    Time.set_captureDeltaTimeRational_InjectedDelegateField((System.IntPtr) ref value);
  }

  private delegate float get_timeSinceLevelLoadDelegate();

  private delegate double get_timeSinceLevelLoadAsDoubleDelegate();

  private delegate double get_fixedTimeAsDoubleDelegate();

  private delegate double get_unscaledTimeAsDoubleDelegate();

  private delegate float get_fixedUnscaledTimeDelegate();

  private delegate double get_fixedUnscaledTimeAsDoubleDelegate();

  private delegate float get_fixedUnscaledDeltaTimeDelegate();

  private delegate void set_fixedDeltaTimeDelegate(float value);

  private delegate void set_maximumDeltaTimeDelegate(float value);

  private delegate float get_maximumParticleDeltaTimeDelegate();

  private delegate void set_maximumParticleDeltaTimeDelegate(float value);

  private delegate int get_renderedFrameCountDelegate();

  private delegate float get_captureDeltaTimeDelegate();

  private delegate void set_captureDeltaTimeDelegate(float value);

  private delegate bool get_inFixedTimeStepDelegate();

  private delegate void get_captureDeltaTimeRational_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void set_captureDeltaTimeRational_InjectedDelegate([In] System.IntPtr value);
}
