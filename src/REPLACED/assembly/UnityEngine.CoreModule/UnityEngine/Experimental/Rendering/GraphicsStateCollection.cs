// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.GraphicsStateCollection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public sealed class GraphicsStateCollection : UnityEngine.Object
{
  private static readonly GraphicsStateCollection.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.Internal_CreateDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::Internal_Create");
  private static readonly GraphicsStateCollection.BeginTrace_InjectedDelegate BeginTrace_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.BeginTrace_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::BeginTrace_Injected");
  private static readonly GraphicsStateCollection.EndTrace_InjectedDelegate EndTrace_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.EndTrace_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::EndTrace_Injected");
  private static readonly GraphicsStateCollection.get_isTracing_InjectedDelegate get_isTracing_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_isTracing_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_isTracing_Injected");
  private static readonly GraphicsStateCollection.get_version_InjectedDelegate get_version_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_version_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_version_Injected");
  private static readonly GraphicsStateCollection.set_version_InjectedDelegate set_version_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.set_version_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_version_Injected");
  private static readonly GraphicsStateCollection.get_graphicsDeviceType_InjectedDelegate get_graphicsDeviceType_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_graphicsDeviceType_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_graphicsDeviceType_Injected");
  private static readonly GraphicsStateCollection.set_graphicsDeviceType_InjectedDelegate set_graphicsDeviceType_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.set_graphicsDeviceType_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_graphicsDeviceType_Injected");
  private static readonly GraphicsStateCollection.get_runtimePlatform_InjectedDelegate get_runtimePlatform_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_runtimePlatform_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_runtimePlatform_Injected");
  private static readonly GraphicsStateCollection.set_runtimePlatform_InjectedDelegate set_runtimePlatform_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.set_runtimePlatform_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_runtimePlatform_Injected");
  private static readonly GraphicsStateCollection.get_qualityLevelName_InjectedDelegate get_qualityLevelName_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_qualityLevelName_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_qualityLevelName_Injected");
  private static readonly GraphicsStateCollection.set_qualityLevelName_InjectedDelegate set_qualityLevelName_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.set_qualityLevelName_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_qualityLevelName_Injected");
  private static readonly GraphicsStateCollection.LoadFromFile_InjectedDelegate LoadFromFile_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.LoadFromFile_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::LoadFromFile_Injected");
  private static readonly GraphicsStateCollection.SaveToFile_InjectedDelegate SaveToFile_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.SaveToFile_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::SaveToFile_Injected");
  private static readonly GraphicsStateCollection.SendToEditor_InjectedDelegate SendToEditor_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.SendToEditor_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::SendToEditor_Injected");
  private static readonly GraphicsStateCollection.WarmUp_InjectedDelegate WarmUp_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.WarmUp_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::WarmUp_Injected");
  private static readonly GraphicsStateCollection.WarmUpProgressively_InjectedDelegate WarmUpProgressively_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.WarmUpProgressively_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::WarmUpProgressively_Injected");
  private static readonly GraphicsStateCollection.get_totalGraphicsStateCount_InjectedDelegate get_totalGraphicsStateCount_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_totalGraphicsStateCount_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_totalGraphicsStateCount_Injected");
  private static readonly GraphicsStateCollection.get_completedWarmupCount_InjectedDelegate get_completedWarmupCount_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_completedWarmupCount_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_completedWarmupCount_Injected");
  private static readonly GraphicsStateCollection.get_isWarmedUp_InjectedDelegate get_isWarmedUp_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_isWarmedUp_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_isWarmedUp_Injected");
  private static readonly GraphicsStateCollection.get_variantCount_InjectedDelegate get_variantCount_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.get_variantCount_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_variantCount_Injected");
  private static readonly GraphicsStateCollection.ClearVariants_InjectedDelegate ClearVariants_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsStateCollection.ClearVariants_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::ClearVariants_Injected");

  public bool BeginTrace()
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return GraphicsStateCollection.BeginTrace_Injected(_unity_self);
  }

  public void EndTrace()
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsStateCollection.EndTrace_Injected(_unity_self);
  }

  public bool isTracing
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_isTracing_Injected(_unity_self);
    }
  }

  public int version
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_version_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      GraphicsStateCollection.set_version_Injected(_unity_self, value);
    }
  }

  public GraphicsDeviceType graphicsDeviceType
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_graphicsDeviceType_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      GraphicsStateCollection.set_graphicsDeviceType_Injected(_unity_self, value);
    }
  }

  public RuntimePlatform runtimePlatform
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_runtimePlatform_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      GraphicsStateCollection.set_runtimePlatform_Injected(_unity_self, value);
    }
  }

  public unsafe string qualityLevelName
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        GraphicsStateCollection.get_qualityLevelName_Injected(_unity_self, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
    set
    {
      try
      {
        System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        ManagedSpanWrapper managedSpanWrapper;
        if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
        {
          Il2CppSystem.ReadOnlySpan<char> readOnlySpan = value.AsSpan();
          fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
            managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
        }
        GraphicsStateCollection.set_qualityLevelName_Injected(_unity_self, ref managedSpanWrapper);
      }
      finally
      {
        __unpin(begin);
      }
    }
  }

  public unsafe bool LoadFromFile(string filePath)
  {
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(filePath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = filePath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return GraphicsStateCollection.LoadFromFile_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public unsafe bool SaveToFile(string filePath)
  {
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(filePath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = filePath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return GraphicsStateCollection.SaveToFile_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public unsafe bool SendToEditor(string fileName)
  {
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(fileName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = fileName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return GraphicsStateCollection.SendToEditor_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public JobHandle WarmUp(JobHandle dependency = default (JobHandle))
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    JobHandle ret;
    GraphicsStateCollection.WarmUp_Injected(_unity_self, ref dependency, out ret);
    return ret;
  }

  public JobHandle WarmUpProgressively(int count, JobHandle dependency = default (JobHandle))
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    JobHandle ret;
    GraphicsStateCollection.WarmUpProgressively_Injected(_unity_self, count, ref dependency, out ret);
    return ret;
  }

  public int totalGraphicsStateCount
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_totalGraphicsStateCount_Injected(_unity_self);
    }
  }

  public int completedWarmupCount
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_completedWarmupCount_Injected(_unity_self);
    }
  }

  public bool isWarmedUp
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_isWarmedUp_Injected(_unity_self);
    }
  }

  public int variantCount
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsStateCollection.get_variantCount_Injected(_unity_self);
    }
  }

  public void ClearVariants()
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<GraphicsStateCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsStateCollection.ClearVariants_Injected(_unity_self);
  }

  public static void Internal_Create(GraphicsStateCollection gsc)
  {
    GraphicsStateCollection.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gsc));
  }

  public static bool BeginTrace_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.BeginTrace_InjectedDelegateField(_unity_self);
  }

  public static void EndTrace_Injected(System.IntPtr _unity_self)
  {
    GraphicsStateCollection.EndTrace_InjectedDelegateField(_unity_self);
  }

  public static bool get_isTracing_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_isTracing_InjectedDelegateField(_unity_self);
  }

  public static int get_version_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_version_InjectedDelegateField(_unity_self);
  }

  public static void set_version_Injected(System.IntPtr _unity_self, int value)
  {
    GraphicsStateCollection.set_version_InjectedDelegateField(_unity_self, value);
  }

  public static GraphicsDeviceType get_graphicsDeviceType_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_graphicsDeviceType_InjectedDelegateField(_unity_self);
  }

  public static void set_graphicsDeviceType_Injected(System.IntPtr _unity_self, GraphicsDeviceType value)
  {
    GraphicsStateCollection.set_graphicsDeviceType_InjectedDelegateField(_unity_self, value);
  }

  public static RuntimePlatform get_runtimePlatform_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_runtimePlatform_InjectedDelegateField(_unity_self);
  }

  public static void set_runtimePlatform_Injected(System.IntPtr _unity_self, RuntimePlatform value)
  {
    GraphicsStateCollection.set_runtimePlatform_InjectedDelegateField(_unity_self, value);
  }

  public static void get_qualityLevelName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    GraphicsStateCollection.get_qualityLevelName_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void set_qualityLevelName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
  {
    GraphicsStateCollection.set_qualityLevelName_InjectedDelegateField(_unity_self, (System.IntPtr) ref value);
  }

  public static bool LoadFromFile_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper filePath)
  {
    return GraphicsStateCollection.LoadFromFile_InjectedDelegateField(_unity_self, (System.IntPtr) ref filePath);
  }

  public static bool SaveToFile_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper filePath)
  {
    return GraphicsStateCollection.SaveToFile_InjectedDelegateField(_unity_self, (System.IntPtr) ref filePath);
  }

  public static bool SendToEditor_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper fileName)
  {
    return GraphicsStateCollection.SendToEditor_InjectedDelegateField(_unity_self, (System.IntPtr) ref fileName);
  }

  public static void WarmUp_Injected(
    System.IntPtr _unity_self,
    [In] ref JobHandle dependency,
    out JobHandle ret)
  {
    GraphicsStateCollection.WarmUp_InjectedDelegateField(_unity_self, (System.IntPtr) ref dependency, (System.IntPtr) ref ret);
  }

  public static void WarmUpProgressively_Injected(
    System.IntPtr _unity_self,
    int count,
    [In] ref JobHandle dependency,
    out JobHandle ret)
  {
    GraphicsStateCollection.WarmUpProgressively_InjectedDelegateField(_unity_self, count, (System.IntPtr) ref dependency, (System.IntPtr) ref ret);
  }

  public static int get_totalGraphicsStateCount_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_totalGraphicsStateCount_InjectedDelegateField(_unity_self);
  }

  public static int get_completedWarmupCount_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_completedWarmupCount_InjectedDelegateField(_unity_self);
  }

  public static bool get_isWarmedUp_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_isWarmedUp_InjectedDelegateField(_unity_self);
  }

  public static int get_variantCount_Injected(System.IntPtr _unity_self)
  {
    return GraphicsStateCollection.get_variantCount_InjectedDelegateField(_unity_self);
  }

  public static void ClearVariants_Injected(System.IntPtr _unity_self)
  {
    GraphicsStateCollection.ClearVariants_InjectedDelegateField(_unity_self);
  }

  private delegate void Internal_CreateDelegate(System.IntPtr gsc);

  private delegate bool BeginTrace_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void EndTrace_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_isTracing_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_version_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_version_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate GraphicsDeviceType get_graphicsDeviceType_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_graphicsDeviceType_InjectedDelegate(
    System.IntPtr _unity_self,
    GraphicsDeviceType value);

  private delegate RuntimePlatform get_runtimePlatform_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_runtimePlatform_InjectedDelegate(
    System.IntPtr _unity_self,
    RuntimePlatform value);

  private delegate void get_qualityLevelName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void set_qualityLevelName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate bool LoadFromFile_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr filePath);

  private delegate bool SaveToFile_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr filePath);

  private delegate bool SendToEditor_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr fileName);

  private delegate void WarmUp_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr dependency, [Out] System.IntPtr ret);

  private delegate void WarmUpProgressively_InjectedDelegate(
    System.IntPtr _unity_self,
    int count,
    [In] System.IntPtr dependency,
    [Out] System.IntPtr ret);

  private delegate int get_totalGraphicsStateCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_completedWarmupCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_isWarmedUp_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_variantCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ClearVariants_InjectedDelegate(System.IntPtr _unity_self);
}
