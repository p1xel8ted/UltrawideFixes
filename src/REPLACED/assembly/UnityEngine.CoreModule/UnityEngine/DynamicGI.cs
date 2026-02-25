// Decompiled with JetBrains decompiler
// Type: UnityEngine.DynamicGI
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class DynamicGI
{
  private static readonly DynamicGI.get_indirectScaleDelegate get_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.get_indirectScaleDelegate>("UnityEngine.DynamicGI::get_indirectScale");
  private static readonly DynamicGI.set_indirectScaleDelegate set_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.set_indirectScaleDelegate>("UnityEngine.DynamicGI::set_indirectScale");
  private static readonly DynamicGI.get_updateThresholdDelegate get_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.get_updateThresholdDelegate>("UnityEngine.DynamicGI::get_updateThreshold");
  private static readonly DynamicGI.set_updateThresholdDelegate set_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.set_updateThresholdDelegate>("UnityEngine.DynamicGI::set_updateThreshold");
  private static readonly DynamicGI.get_materialUpdateTimeSliceDelegate get_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.get_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::get_materialUpdateTimeSlice");
  private static readonly DynamicGI.set_materialUpdateTimeSliceDelegate set_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.set_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::set_materialUpdateTimeSlice");
  private static readonly DynamicGI.get_synchronousModeDelegate get_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.get_synchronousModeDelegate>("UnityEngine.DynamicGI::get_synchronousMode");
  private static readonly DynamicGI.set_synchronousModeDelegate set_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.set_synchronousModeDelegate>("UnityEngine.DynamicGI::set_synchronousMode");
  private static readonly DynamicGI.get_isConvergedDelegate get_isConvergedDelegateField = IL2CPP.ResolveICall<DynamicGI.get_isConvergedDelegate>("UnityEngine.DynamicGI::get_isConverged");
  private static readonly DynamicGI.get_scheduledMaterialUpdatesCountDelegate get_scheduledMaterialUpdatesCountDelegateField = IL2CPP.ResolveICall<DynamicGI.get_scheduledMaterialUpdatesCountDelegate>("UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount");
  private static readonly DynamicGI.get_asyncMaterialUpdatesDelegate get_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.get_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::get_asyncMaterialUpdates");
  private static readonly DynamicGI.set_asyncMaterialUpdatesDelegate set_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.set_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::set_asyncMaterialUpdates");
  private static readonly DynamicGI.UpdateEnvironmentDelegate UpdateEnvironmentDelegateField = IL2CPP.ResolveICall<DynamicGI.UpdateEnvironmentDelegate>("UnityEngine.DynamicGI::UpdateEnvironment");
  private static readonly DynamicGI.SetEmissive_InjectedDelegate SetEmissive_InjectedDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEmissive_InjectedDelegate>("UnityEngine.DynamicGI::SetEmissive_Injected");
  private static readonly DynamicGI.SetEnvironmentData_InjectedDelegate SetEnvironmentData_InjectedDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEnvironmentData_InjectedDelegate>("UnityEngine.DynamicGI::SetEnvironmentData_Injected");

  public static float indirectScale
  {
    get => DynamicGI.get_indirectScaleDelegateField();
    set => DynamicGI.set_indirectScaleDelegateField(value);
  }

  public static float updateThreshold
  {
    get => DynamicGI.get_updateThresholdDelegateField();
    set => DynamicGI.set_updateThresholdDelegateField(value);
  }

  public static int materialUpdateTimeSlice
  {
    get => DynamicGI.get_materialUpdateTimeSliceDelegateField();
    set => DynamicGI.set_materialUpdateTimeSliceDelegateField(value);
  }

  public static void SetEmissive(Renderer renderer, Color color)
  {
    DynamicGI.SetEmissive_Injected(Object.MarshalledUnityObject.Marshal<Renderer>(renderer), ref color);
  }

  public static unsafe void SetEnvironmentData(Il2CppStructArray<float> input)
  {
    if (input == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) input, nameof (input));
    Il2CppSystem.Span<float> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<float>) ref span).\u002Ector((Il2CppArrayBase<float>) input);
    fixed (float* begin = &((Il2CppSystem.Span<float>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper input1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<float>) ref span).Length);
      DynamicGI.SetEnvironmentData_Injected(ref input1);
    }
  }

  public static bool synchronousMode
  {
    get => DynamicGI.get_synchronousModeDelegateField();
    set => DynamicGI.set_synchronousModeDelegateField(value);
  }

  public static bool isConverged => DynamicGI.get_isConvergedDelegateField();

  public static int scheduledMaterialUpdatesCount
  {
    get => DynamicGI.get_scheduledMaterialUpdatesCountDelegateField();
  }

  public static bool asyncMaterialUpdates
  {
    get => DynamicGI.get_asyncMaterialUpdatesDelegateField();
    set => DynamicGI.set_asyncMaterialUpdatesDelegateField(value);
  }

  public static void UpdateEnvironment() => DynamicGI.UpdateEnvironmentDelegateField();

  public static void UpdateMaterials(Renderer renderer)
  {
  }

  public static void UpdateMaterials(Object renderer)
  {
  }

  public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
  {
  }

  public static void SetEmissive_Injected(System.IntPtr renderer, [In] ref Color color)
  {
    DynamicGI.SetEmissive_InjectedDelegateField(renderer, (System.IntPtr) ref color);
  }

  public static void SetEnvironmentData_Injected(ref ManagedSpanWrapper input)
  {
    DynamicGI.SetEnvironmentData_InjectedDelegateField((System.IntPtr) ref input);
  }

  private delegate float get_indirectScaleDelegate();

  private delegate void set_indirectScaleDelegate(float value);

  private delegate float get_updateThresholdDelegate();

  private delegate void set_updateThresholdDelegate(float value);

  private delegate int get_materialUpdateTimeSliceDelegate();

  private delegate void set_materialUpdateTimeSliceDelegate(int value);

  private delegate bool get_synchronousModeDelegate();

  private delegate void set_synchronousModeDelegate(bool value);

  private delegate bool get_isConvergedDelegate();

  private delegate int get_scheduledMaterialUpdatesCountDelegate();

  private delegate bool get_asyncMaterialUpdatesDelegate();

  private delegate void set_asyncMaterialUpdatesDelegate(bool value);

  private delegate void UpdateEnvironmentDelegate();

  private delegate void SetEmissive_InjectedDelegate(System.IntPtr renderer, [In] System.IntPtr color);

  private delegate void SetEnvironmentData_InjectedDelegate(System.IntPtr input);
}
