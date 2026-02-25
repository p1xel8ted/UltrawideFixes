// Decompiled with JetBrains decompiler
// Type: UnityEngine.LightProbes
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

#nullable disable
namespace UnityEngine;

public sealed class LightProbes(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lightProbesUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_tetrahedralizationCompleted;
  private static readonly System.IntPtr NativeFieldInfoPtr_needsRetetrahedralization;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0;
  private static readonly LightProbes.TetrahedralizeDelegate TetrahedralizeDelegateField;
  private static readonly LightProbes.TetrahedralizeAsyncDelegate TetrahedralizeAsyncDelegateField;
  private static readonly LightProbes.GetCountDelegate GetCountDelegateField;
  private static readonly LightProbes.GetInterpolatedProbe_InjectedDelegate GetInterpolatedProbe_InjectedDelegateField;
  private static readonly LightProbes.AreLightProbesAllowed_InjectedDelegate AreLightProbesAllowed_InjectedDelegateField;
  private static readonly LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegate CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegateField;
  private static readonly LightProbes.GetSharedLightProbesForScene_InjectedDelegate GetSharedLightProbesForScene_InjectedDelegateField;
  private static readonly LightProbes.GetInstantiatedLightProbesForScene_InjectedDelegate GetInstantiatedLightProbesForScene_InjectedDelegateField;
  private static readonly LightProbes.get_positions_InjectedDelegate get_positions_InjectedDelegateField;
  private static readonly LightProbes.GetPositionsSelf_InjectedDelegate GetPositionsSelf_InjectedDelegateField;
  private static readonly LightProbes.SetPositionsSelf_InjectedDelegate SetPositionsSelf_InjectedDelegateField;
  private static readonly LightProbes.get_bakedProbes_InjectedDelegate get_bakedProbes_InjectedDelegateField;
  private static readonly LightProbes.set_bakedProbes_InjectedDelegate set_bakedProbes_InjectedDelegateField;
  private static readonly LightProbes.get_count_InjectedDelegate get_count_InjectedDelegateField;
  private static readonly LightProbes.get_countSelf_InjectedDelegate get_countSelf_InjectedDelegateField;
  private static readonly LightProbes.get_cellCount_InjectedDelegate get_cellCount_InjectedDelegateField;
  private static readonly LightProbes.get_cellCountSelf_InjectedDelegate get_cellCountSelf_InjectedDelegateField;

  static LightProbes()
  {
    Il2CppClassPointerStore<LightProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LightProbes));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbes>.NativeClassPtr);
    LightProbes.NativeFieldInfoPtr_lightProbesUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, nameof (lightProbesUpdated));
    LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, nameof (tetrahedralizationCompleted));
    LightProbes.NativeFieldInfoPtr_needsRetetrahedralization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, nameof (needsRetetrahedralization));
    LightProbes.NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664776);
    LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664777);
    LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664778);
    LightProbes.TetrahedralizeDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeDelegate>("UnityEngine.LightProbes::Tetrahedralize");
    LightProbes.TetrahedralizeAsyncDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeAsyncDelegate>("UnityEngine.LightProbes::TetrahedralizeAsync");
    LightProbes.GetCountDelegateField = IL2CPP.ResolveICall<LightProbes.GetCountDelegate>("UnityEngine.LightProbes::GetCount");
    LightProbes.GetInterpolatedProbe_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.GetInterpolatedProbe_InjectedDelegate>("UnityEngine.LightProbes::GetInterpolatedProbe_Injected");
    LightProbes.AreLightProbesAllowed_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.AreLightProbesAllowed_InjectedDelegate>("UnityEngine.LightProbes::AreLightProbesAllowed_Injected");
    LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegate>("UnityEngine.LightProbes::CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected");
    LightProbes.GetSharedLightProbesForScene_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.GetSharedLightProbesForScene_InjectedDelegate>("UnityEngine.LightProbes::GetSharedLightProbesForScene_Injected");
    LightProbes.GetInstantiatedLightProbesForScene_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.GetInstantiatedLightProbesForScene_InjectedDelegate>("UnityEngine.LightProbes::GetInstantiatedLightProbesForScene_Injected");
    LightProbes.get_positions_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.get_positions_InjectedDelegate>("UnityEngine.LightProbes::get_positions_Injected");
    LightProbes.GetPositionsSelf_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.GetPositionsSelf_InjectedDelegate>("UnityEngine.LightProbes::GetPositionsSelf_Injected");
    LightProbes.SetPositionsSelf_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.SetPositionsSelf_InjectedDelegate>("UnityEngine.LightProbes::SetPositionsSelf_Injected");
    LightProbes.get_bakedProbes_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.get_bakedProbes_InjectedDelegate>("UnityEngine.LightProbes::get_bakedProbes_Injected");
    LightProbes.set_bakedProbes_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.set_bakedProbes_InjectedDelegate>("UnityEngine.LightProbes::set_bakedProbes_Injected");
    LightProbes.get_count_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.get_count_InjectedDelegate>("UnityEngine.LightProbes::get_count_Injected");
    LightProbes.get_countSelf_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.get_countSelf_InjectedDelegate>("UnityEngine.LightProbes::get_countSelf_Injected");
    LightProbes.get_cellCount_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.get_cellCount_InjectedDelegate>("UnityEngine.LightProbes::get_cellCount_Injected");
    LightProbes.get_cellCountSelf_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.get_cellCountSelf_InjectedDelegate>("UnityEngine.LightProbes::get_cellCountSelf_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423719, XrefRangeEnd = 423721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CallLightProbesUpdatedFunction()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423721, XrefRangeEnd = 423723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CallTetrahedralizationCompletedFunction()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423723, XrefRangeEnd = 423725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CallNeedsRetetrahedralizationFunction()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppSystem.Action lightProbesUpdated
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_lightProbesUpdated, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_lightProbesUpdated, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action tetrahedralizationCompleted
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action needsRetetrahedralization
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [SpecialName]
  public static void add_lightProbesUpdated(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_lightProbesUpdated(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_tetrahedralizationCompleted(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_tetrahedralizationCompleted(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_needsRetetrahedralization(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_needsRetetrahedralization(Il2CppSystem.Action value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void Tetrahedralize() => LightProbes.TetrahedralizeDelegateField();

  public static void TetrahedralizeAsync() => LightProbes.TetrahedralizeAsyncDelegateField();

  public static void GetInterpolatedProbe(
    Vector3 position,
    Renderer renderer,
    out SphericalHarmonicsL2 probe)
  {
    LightProbes.GetInterpolatedProbe_Injected(ref position, Object.MarshalledUnityObject.Marshal<Renderer>(renderer), out probe);
  }

  public static bool AreLightProbesAllowed(Renderer renderer)
  {
    return LightProbes.AreLightProbesAllowed_Injected(Object.MarshalledUnityObject.Marshal<Renderer>(renderer));
  }

  public static void CalculateInterpolatedLightAndOcclusionProbes(
    Il2CppStructArray<Vector3> positions,
    Il2CppStructArray<SphericalHarmonicsL2> lightProbes,
    Il2CppStructArray<Vector4> occlusionProbes)
  {
    if (positions == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (positions));
    if (lightProbes == null && occlusionProbes == null)
      throw new Il2CppSystem.ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
    if (lightProbes != null && ((Il2CppArrayBase) lightProbes).Length < ((Il2CppArrayBase) positions).Length)
      throw new Il2CppSystem.ArgumentException(nameof (lightProbes), "Argument lightProbes has less elements than positions");
    if (occlusionProbes != null && ((Il2CppArrayBase) occlusionProbes).Length < ((Il2CppArrayBase) positions).Length)
      throw new Il2CppSystem.ArgumentException(nameof (occlusionProbes), "Argument occlusionProbes has less elements than positions");
    LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal(positions, ((Il2CppArrayBase) positions).Length, lightProbes, occlusionProbes);
  }

  public static void CalculateInterpolatedLightAndOcclusionProbes(
    List<Vector3> positions,
    List<SphericalHarmonicsL2> lightProbes,
    List<Vector4> occlusionProbes)
  {
    if (positions == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (positions));
    if (lightProbes == null && occlusionProbes == null)
      throw new Il2CppSystem.ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
    if (lightProbes != null)
      NoAllocHelpers.EnsureListElemCount<SphericalHarmonicsL2>(lightProbes, positions.Count);
    if (occlusionProbes != null)
      NoAllocHelpers.EnsureListElemCount<Vector4>(occlusionProbes, positions.Count);
    LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal((Il2CppStructArray<Vector3>) NoAllocHelpers.ExtractArrayFromList<Vector3>(positions), positions.Count, (Il2CppStructArray<SphericalHarmonicsL2>) NoAllocHelpers.ExtractArrayFromList<SphericalHarmonicsL2>(lightProbes), (Il2CppStructArray<Vector4>) NoAllocHelpers.ExtractArrayFromList<Vector4>(occlusionProbes));
  }

  public static unsafe void CalculateInterpolatedLightAndOcclusionProbes_Internal(
    Il2CppStructArray<Vector3> positions,
    int positionsCount,
    Il2CppStructArray<SphericalHarmonicsL2> lightProbes,
    Il2CppStructArray<Vector4> occlusionProbes)
  {
    Il2CppSystem.Span<Vector3> span1;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector3>) ref span1).\u002Ector((Il2CppArrayBase<Vector3>) positions);
    fixed (Vector3* begin1 = &((Il2CppSystem.Span<Vector3>) ref span1).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin1, ((Il2CppSystem.Span<Vector3>) ref span1).Length);
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      int positionsCount1 = positionsCount;
      Il2CppSystem.Span<SphericalHarmonicsL2> span2;
      // ISSUE: explicit constructor call
      ((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span2).\u002Ector((Il2CppArrayBase<SphericalHarmonicsL2>) lightProbes);
      fixed (SphericalHarmonicsL2* begin2 = &((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span2).GetPinnableReference())
      {
        ManagedSpanWrapper managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin2, ((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span2).Length);
        ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
        Il2CppSystem.Span<Vector4> span3;
        // ISSUE: explicit constructor call
        ((Il2CppSystem.Span<Vector4>) ref span3).\u002Ector((Il2CppArrayBase<Vector4>) occlusionProbes);
        fixed (Vector4* begin3 = &((Il2CppSystem.Span<Vector4>) ref span3).GetPinnableReference())
        {
          ManagedSpanWrapper managedSpanWrapper3 = new ManagedSpanWrapper((void*) begin3, ((Il2CppSystem.Span<Vector4>) ref span3).Length);
          ref ManagedSpanWrapper local3 = ref managedSpanWrapper3;
          LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected(ref local1, positionsCount1, ref local2, ref local3);
        }
      }
    }
  }

  public static LightProbes GetSharedLightProbesForScene(Scene scene)
  {
    return Unmarshal.UnmarshalUnityObject<LightProbes>(LightProbes.GetSharedLightProbesForScene_Injected(ref scene));
  }

  public static LightProbes GetInstantiatedLightProbesForScene(Scene scene)
  {
    return Unmarshal.UnmarshalUnityObject<LightProbes>(LightProbes.GetInstantiatedLightProbesForScene_Injected(ref scene));
  }

  public Il2CppStructArray<Vector3> positions
  {
    get
    {
      BlittableArrayWrapper ret;
      Il2CppStructArray<Vector3> positions;
      try
      {
        System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        LightProbes.get_positions_Injected(_unity_self, out ret);
      }
      finally
      {
        Il2CppStructArray<Vector3> il2CppStructArray;
        ret.Unmarshal<Vector3>((Il2CppArrayBase<Vector3>&) ref il2CppStructArray);
        positions = il2CppStructArray;
      }
      return positions;
    }
  }

  public Il2CppStructArray<Vector3> GetPositionsSelf()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Vector3> positionsSelf;
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      LightProbes.GetPositionsSelf_Injected(_unity_self, out ret);
    }
    finally
    {
      Il2CppStructArray<Vector3> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Vector3>((Il2CppArrayBase<Vector3>&) ref il2CppStructArray);
      positionsSelf = il2CppStructArray;
    }
    return positionsSelf;
  }

  public unsafe bool SetPositionsSelf(
    Il2CppStructArray<Vector3> positions,
    bool checkForDuplicatePositions)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<Vector3> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector3>) ref span).\u002Ector((Il2CppArrayBase<Vector3>) positions);
    int num;
    fixed (Vector3* begin = &((Il2CppSystem.Span<Vector3>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper positions1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector3>) ref span).Length);
      num = LightProbes.SetPositionsSelf_Injected(_unity_self, ref positions1, checkForDuplicatePositions) ? 1 : 0;
    }
    return num != 0;
  }

  public unsafe Il2CppStructArray<SphericalHarmonicsL2> bakedProbes
  {
    get
    {
      BlittableArrayWrapper ret;
      Il2CppStructArray<SphericalHarmonicsL2> bakedProbes;
      try
      {
        System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        LightProbes.get_bakedProbes_Injected(_unity_self, out ret);
      }
      finally
      {
        Il2CppStructArray<SphericalHarmonicsL2> il2CppStructArray;
        ret.Unmarshal<SphericalHarmonicsL2>((Il2CppArrayBase<SphericalHarmonicsL2>&) ref il2CppStructArray);
        bakedProbes = il2CppStructArray;
      }
      return bakedProbes;
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Il2CppSystem.Span<SphericalHarmonicsL2> span;
      ((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span).\u002Ector((Il2CppArrayBase<SphericalHarmonicsL2>) value);
      fixed (SphericalHarmonicsL2* begin = &((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span).GetPinnableReference())
      {
        ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span).Length);
        LightProbes.set_bakedProbes_Injected(_unity_self, ref managedSpanWrapper);
      }
    }
  }

  public int count
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbes.get_count_Injected(_unity_self);
    }
  }

  public int countSelf
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbes.get_countSelf_Injected(_unity_self);
    }
  }

  public int cellCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbes.get_cellCount_Injected(_unity_self);
    }
  }

  public int cellCountSelf
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<LightProbes>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return LightProbes.get_cellCountSelf_Injected(_unity_self);
    }
  }

  public static int GetCount() => LightProbes.GetCountDelegateField();

  public void GetInterpolatedLightProbe(
    Vector3 position,
    Renderer renderer,
    Il2CppStructArray<float> coefficients)
  {
  }

  public Il2CppStructArray<float> coefficients
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set
    {
    }
  }

  public static void GetInterpolatedProbe_Injected(
    [In] ref Vector3 position,
    System.IntPtr renderer,
    out SphericalHarmonicsL2 probe)
  {
    LightProbes.GetInterpolatedProbe_InjectedDelegateField((System.IntPtr) ref position, renderer, (System.IntPtr) ref probe);
  }

  public static bool AreLightProbesAllowed_Injected(System.IntPtr renderer)
  {
    return LightProbes.AreLightProbesAllowed_InjectedDelegateField(renderer);
  }

  public static void CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected(
    ref ManagedSpanWrapper positions,
    int positionsCount,
    ref ManagedSpanWrapper lightProbes,
    ref ManagedSpanWrapper occlusionProbes)
  {
    LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegateField((System.IntPtr) ref positions, positionsCount, (System.IntPtr) ref lightProbes, (System.IntPtr) ref occlusionProbes);
  }

  public static System.IntPtr GetSharedLightProbesForScene_Injected([In] ref Scene scene)
  {
    return LightProbes.GetSharedLightProbesForScene_InjectedDelegateField((System.IntPtr) ref scene);
  }

  public static System.IntPtr GetInstantiatedLightProbesForScene_Injected([In] ref Scene scene)
  {
    return LightProbes.GetInstantiatedLightProbesForScene_InjectedDelegateField((System.IntPtr) ref scene);
  }

  public static void get_positions_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    LightProbes.get_positions_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void GetPositionsSelf_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    LightProbes.GetPositionsSelf_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static bool SetPositionsSelf_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper positions,
    bool checkForDuplicatePositions)
  {
    return LightProbes.SetPositionsSelf_InjectedDelegateField(_unity_self, (System.IntPtr) ref positions, checkForDuplicatePositions);
  }

  public static void get_bakedProbes_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    LightProbes.get_bakedProbes_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_bakedProbes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
  {
    LightProbes.set_bakedProbes_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static int get_count_Injected(System.IntPtr _unity_self)
  {
    return LightProbes.get_count_InjectedDelegateField(_unity_self);
  }

  public static int get_countSelf_Injected(System.IntPtr _unity_self)
  {
    return LightProbes.get_countSelf_InjectedDelegateField(_unity_self);
  }

  public static int get_cellCount_Injected(System.IntPtr _unity_self)
  {
    return LightProbes.get_cellCount_InjectedDelegateField(_unity_self);
  }

  public static int get_cellCountSelf_Injected(System.IntPtr _unity_self)
  {
    return LightProbes.get_cellCountSelf_InjectedDelegateField(_unity_self);
  }

  private delegate void TetrahedralizeDelegate();

  private delegate void TetrahedralizeAsyncDelegate();

  private delegate int GetCountDelegate();

  private delegate void GetInterpolatedProbe_InjectedDelegate(
    [In] System.IntPtr position,
    System.IntPtr renderer,
    [Out] System.IntPtr probe);

  private delegate bool AreLightProbesAllowed_InjectedDelegate(System.IntPtr renderer);

  private delegate void CalculateInterpolatedLightAndOcclusionProbes_Internal_InjectedDelegate(
    System.IntPtr positions,
    int positionsCount,
    System.IntPtr lightProbes,
    System.IntPtr occlusionProbes);

  private delegate System.IntPtr GetSharedLightProbesForScene_InjectedDelegate([In] System.IntPtr scene);

  private delegate System.IntPtr GetInstantiatedLightProbesForScene_InjectedDelegate([In] System.IntPtr scene);

  private delegate void get_positions_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void GetPositionsSelf_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate bool SetPositionsSelf_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr positions,
    bool checkForDuplicatePositions);

  private delegate void get_bakedProbes_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_bakedProbes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate int get_count_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_countSelf_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_cellCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_cellCountSelf_InjectedDelegate(System.IntPtr _unity_self);
}
