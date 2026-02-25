// Decompiled with JetBrains decompiler
// Type: UnityEngine.Scripting.GarbageCollector
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.CompilerServices;

#nullable disable
namespace UnityEngine.Scripting;

public static class GarbageCollector
{
  private static readonly GarbageCollector.SetModeDelegate SetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.SetModeDelegate>("UnityEngine.Scripting.GarbageCollector::SetMode");
  private static readonly GarbageCollector.GetModeDelegate GetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.GetModeDelegate>("UnityEngine.Scripting.GarbageCollector::GetMode");
  private static readonly GarbageCollector.get_isIncrementalDelegate get_isIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_isIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::get_isIncremental");
  private static readonly GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate get_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds");
  private static readonly GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate set_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds");
  private static readonly GarbageCollector.CollectIncrementalDelegate CollectIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.CollectIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::CollectIncremental");

  [SpecialName]
  public static void add_GCModeChanged(Il2CppSystem.Action<GarbageCollector.Mode> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_GCModeChanged(Il2CppSystem.Action<GarbageCollector.Mode> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static GarbageCollector.Mode GCMode
  {
    get => GarbageCollector.GetMode();
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void SetMode(GarbageCollector.Mode mode)
  {
    GarbageCollector.SetModeDelegateField(mode);
  }

  public static GarbageCollector.Mode GetMode() => GarbageCollector.GetModeDelegateField();

  public static bool isIncremental => GarbageCollector.get_isIncrementalDelegateField();

  public static ulong incrementalTimeSliceNanoseconds
  {
    get => GarbageCollector.get_incrementalTimeSliceNanosecondsDelegateField();
    set => GarbageCollector.set_incrementalTimeSliceNanosecondsDelegateField(value);
  }

  public static bool CollectIncremental(ulong nanoseconds = default (ulong))
  {
    return GarbageCollector.CollectIncrementalDelegateField(nanoseconds);
  }

  public enum Mode
  {
    Disabled,
    Enabled,
    Manual,
  }

  private delegate void SetModeDelegate(GarbageCollector.Mode mode);

  private delegate GarbageCollector.Mode GetModeDelegate();

  private delegate bool get_isIncrementalDelegate();

  private delegate ulong get_incrementalTimeSliceNanosecondsDelegate();

  private delegate void set_incrementalTimeSliceNanosecondsDelegate(ulong value);

  private delegate bool CollectIncrementalDelegate(ulong nanoseconds = default (ulong));
}
