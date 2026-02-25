// Decompiled with JetBrains decompiler
// Type: UnityEngineInternal.GIDebugVisualisation
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngineInternal;

public static class GIDebugVisualisation
{
  private static readonly GIDebugVisualisation.ResetRuntimeInputTexturesDelegate ResetRuntimeInputTexturesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.ResetRuntimeInputTexturesDelegate>("UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures");
  private static readonly GIDebugVisualisation.PlayCycleModeDelegate PlayCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PlayCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PlayCycleMode");
  private static readonly GIDebugVisualisation.PauseCycleModeDelegate PauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PauseCycleMode");
  private static readonly GIDebugVisualisation.StopCycleModeDelegate StopCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.StopCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::StopCycleMode");
  private static readonly GIDebugVisualisation.CycleSkipSystemsDelegate CycleSkipSystemsDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipSystemsDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems");
  private static readonly GIDebugVisualisation.CycleSkipInstancesDelegate CycleSkipInstancesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipInstancesDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances");
  private static readonly GIDebugVisualisation.get_cycleModeDelegate get_cycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_cycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_cycleMode");
  private static readonly GIDebugVisualisation.get_pauseCycleModeDelegate get_pauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_pauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode");
  private static readonly GIDebugVisualisation.get_texTypeDelegate get_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_texType");
  private static readonly GIDebugVisualisation.set_texTypeDelegate set_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.set_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::set_texType");

  public static void ResetRuntimeInputTextures()
  {
    GIDebugVisualisation.ResetRuntimeInputTexturesDelegateField();
  }

  public static void PlayCycleMode() => GIDebugVisualisation.PlayCycleModeDelegateField();

  public static void PauseCycleMode() => GIDebugVisualisation.PauseCycleModeDelegateField();

  public static void StopCycleMode() => GIDebugVisualisation.StopCycleModeDelegateField();

  public static void CycleSkipSystems(int skip)
  {
    GIDebugVisualisation.CycleSkipSystemsDelegateField(skip);
  }

  public static void CycleSkipInstances(int skip)
  {
    GIDebugVisualisation.CycleSkipInstancesDelegateField(skip);
  }

  public static bool cycleMode => GIDebugVisualisation.get_cycleModeDelegateField();

  public static bool pauseCycleMode => GIDebugVisualisation.get_pauseCycleModeDelegateField();

  public static GITextureType texType
  {
    get => GIDebugVisualisation.get_texTypeDelegateField();
    set => GIDebugVisualisation.set_texTypeDelegateField(value);
  }

  private delegate void ResetRuntimeInputTexturesDelegate();

  private delegate void PlayCycleModeDelegate();

  private delegate void PauseCycleModeDelegate();

  private delegate void StopCycleModeDelegate();

  private delegate void CycleSkipSystemsDelegate(int skip);

  private delegate void CycleSkipInstancesDelegate(int skip);

  private delegate bool get_cycleModeDelegate();

  private delegate bool get_pauseCycleModeDelegate();

  private delegate GITextureType get_texTypeDelegate();

  private delegate void set_texTypeDelegate(GITextureType value);
}
