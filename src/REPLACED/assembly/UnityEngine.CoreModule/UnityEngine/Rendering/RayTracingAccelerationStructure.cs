// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RayTracingAccelerationStructure
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class RayTracingAccelerationStructure(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_RayTracingAccelerationStructure_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_0;
  public const string obsoleteBuildMsg1 = "Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build()";
  public const string obsoleteBuildMsg2 = "Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build(*)";
  public const string obsoleteRendererMsg = "This AddInstance method is deprecated and will be removed and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding Renderers to the acceleration structure.";
  public const string obsoleteAABBMsg1 = "This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.";
  public const string obsoleteAABBMsg2 = "This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.";
  private static readonly RayTracingAccelerationStructure.Build_InjectedDelegate Build_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.AddVFXInstances_InjectedDelegate AddVFXInstances_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.RemoveVFXInstances_InjectedDelegate RemoveVFXInstances_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstancePropertyBlock_InjectedDelegate UpdateInstancePropertyBlock_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.GetSize_InjectedDelegate GetSize_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.GetInstanceCount_InjectedDelegate GetInstanceCount_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.ClearInstances_InjectedDelegate ClearInstances_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.RemoveInstance_Renderer_InjectedDelegate RemoveInstance_Renderer_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.RemoveInstance_InstanceID_InjectedDelegate RemoveInstance_InstanceID_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstanceTransform_Renderer_InjectedDelegate UpdateInstanceTransform_Renderer_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstanceTransform_Handle_InjectedDelegate UpdateInstanceTransform_Handle_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstanceMask_Renderer_InjectedDelegate UpdateInstanceMask_Renderer_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstanceMask_Handle_InjectedDelegate UpdateInstanceMask_Handle_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstanceID_Renderer_InjectedDelegate UpdateInstanceID_Renderer_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.UpdateInstanceID_Handle_InjectedDelegate UpdateInstanceID_Handle_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArray_InjectedDelegate AddInstanceSubMeshFlagsArray_InjectedDelegateField;
  private static readonly RayTracingAccelerationStructure.CheckMaterialEnablesInstancing_InjectedDelegate CheckMaterialEnablesInstancing_InjectedDelegateField;

  static RayTracingAccelerationStructure()
  {
    Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RayTracingAccelerationStructure));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr);
    RayTracingAccelerationStructure.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, nameof (m_Ptr));
    RayTracingAccelerationStructure.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100669711);
    RayTracingAccelerationStructure.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100669712);
    RayTracingAccelerationStructure.NativeMethodInfoPtr_Destroy_Private_Static_Void_RayTracingAccelerationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100669713);
    RayTracingAccelerationStructure.NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, 100669714);
    RayTracingAccelerationStructure.Build_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Build_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::Build_Injected");
    RayTracingAccelerationStructure.AddVFXInstances_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddVFXInstances_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::AddVFXInstances_Injected");
    RayTracingAccelerationStructure.RemoveVFXInstances_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveVFXInstances_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::RemoveVFXInstances_Injected");
    RayTracingAccelerationStructure.UpdateInstancePropertyBlock_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstancePropertyBlock_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstancePropertyBlock_Injected");
    RayTracingAccelerationStructure.GetSize_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetSize_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::GetSize_Injected");
    RayTracingAccelerationStructure.GetInstanceCount_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetInstanceCount_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::GetInstanceCount_Injected");
    RayTracingAccelerationStructure.ClearInstances_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.ClearInstances_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::ClearInstances_Injected");
    RayTracingAccelerationStructure.RemoveInstance_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstance_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::RemoveInstance_Renderer_Injected");
    RayTracingAccelerationStructure.RemoveInstance_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstance_InstanceID_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::RemoveInstance_InstanceID_Injected");
    RayTracingAccelerationStructure.UpdateInstanceTransform_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransform_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_Renderer_Injected");
    RayTracingAccelerationStructure.UpdateInstanceTransform_Handle_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransform_Handle_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_Handle_Injected");
    RayTracingAccelerationStructure.UpdateInstanceMask_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceMask_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask_Renderer_Injected");
    RayTracingAccelerationStructure.UpdateInstanceMask_Handle_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceMask_Handle_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask_Handle_Injected");
    RayTracingAccelerationStructure.UpdateInstanceID_Renderer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceID_Renderer_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceID_Renderer_Injected");
    RayTracingAccelerationStructure.UpdateInstanceID_Handle_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceID_Handle_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::UpdateInstanceID_Handle_Injected");
    RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArray_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::AddInstanceSubMeshFlagsArray_Injected");
    RayTracingAccelerationStructure.CheckMaterialEnablesInstancing_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.CheckMaterialEnablesInstancing_InjectedDelegate>("UnityEngine.Rendering.RayTracingAccelerationStructure::CheckMaterialEnablesInstancing_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482571, XrefRangeEnd = 482578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482578, XrefRangeEnd = 482581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disposing
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482581, XrefRangeEnd = 482584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Destroy(RayTracingAccelerationStructure accelStruct)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) accelStruct)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.NativeMethodInfoPtr_Destroy_Private_Static_Void_RayTracingAccelerationStructure_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482584, XrefRangeEnd = 482586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Destroy_Injected(System.IntPtr accelStruct)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &accelStruct
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.NativeMethodInfoPtr_Destroy_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracingAccelerationStructure.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracingAccelerationStructure.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public new virtual void Finalize()
  {
    try
    {
      this.Dispose(false);
    }
    finally
    {
      base.Finalize();
    }
  }

  public void Release() => this.Dispose();

  public void Build() => this.Build(new RayTracingAccelerationStructure.BuildSettings());

  public void Build(Vector3 relativeOrigin)
  {
    this.Build(new RayTracingAccelerationStructure.BuildSettings()
    {
      relativeOrigin = relativeOrigin
    });
  }

  public int AddInstance(
    Renderer targetRenderer,
    Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags,
    bool enableTriangleCulling = default (bool),
    bool frontTriangleCounterClockwise = default (bool),
    uint mask = default (uint),
    uint id = default (uint))
  {
    return this.AddInstanceSubMeshFlagsArray(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
  }

  public void RemoveInstance(Renderer targetRenderer)
  {
    this.RemoveInstance_Renderer(targetRenderer);
  }

  public void RemoveInstance(int handle) => this.RemoveInstance_InstanceID(handle);

  public void UpdateInstanceTransform(Renderer renderer)
  {
    this.UpdateInstanceTransform_Renderer(renderer);
  }

  public void UpdateInstanceTransform(int handle, Matrix4x4 matrix)
  {
    this.UpdateInstanceTransform_Handle(handle, matrix);
  }

  public void UpdateInstanceID(Renderer renderer, uint instanceID)
  {
    this.UpdateInstanceID_Renderer(renderer, instanceID);
  }

  public void UpdateInstanceID(int handle, uint instanceID)
  {
    this.UpdateInstanceID_Handle(handle, instanceID);
  }

  public void UpdateInstanceMask(Renderer renderer, uint mask)
  {
    this.UpdateInstanceMask_Renderer(renderer, mask);
  }

  public void UpdateInstanceMask(int handle, uint mask)
  {
    this.UpdateInstanceMask_Handle(handle, mask);
  }

  public void Build(
    RayTracingAccelerationStructure.BuildSettings buildSettings)
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.Build_Injected(native, ref buildSettings);
  }

  public unsafe void AddVFXInstances(
    Renderer targetRenderer,
    Il2CppStructArray<uint> vfxSystemMasks)
  {
    if (targetRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr targetRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(targetRenderer);
    if (targetRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    Il2CppSystem.Span<uint> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<uint>) ref span).\u002Ector((Il2CppArrayBase<uint>) vfxSystemMasks);
    fixed (uint* begin = &((Il2CppSystem.Span<uint>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper vfxSystemMasks1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<uint>) ref span).Length);
      RayTracingAccelerationStructure.AddVFXInstances_Injected(native, targetRenderer1, ref vfxSystemMasks1);
    }
  }

  public void RemoveVFXInstances(Renderer targetRenderer)
  {
    if (targetRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr targetRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(targetRenderer);
    if (targetRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    RayTracingAccelerationStructure.RemoveVFXInstances_Injected(native, targetRenderer1);
  }

  public void UpdateInstancePropertyBlock(int handle, MaterialPropertyBlock properties)
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.UpdateInstancePropertyBlock_Injected(native, handle, properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties));
  }

  public ulong GetSize()
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return RayTracingAccelerationStructure.GetSize_Injected(native);
  }

  public uint GetInstanceCount()
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return RayTracingAccelerationStructure.GetInstanceCount_Injected(native);
  }

  public void ClearInstances()
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.ClearInstances_Injected(native);
  }

  public void RemoveInstance_Renderer(Renderer targetRenderer)
  {
    if (targetRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr targetRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(targetRenderer);
    if (targetRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    RayTracingAccelerationStructure.RemoveInstance_Renderer_Injected(native, targetRenderer1);
  }

  public void RemoveInstance_InstanceID(int instanceID)
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.RemoveInstance_InstanceID_Injected(native, instanceID);
  }

  public void UpdateInstanceTransform_Renderer(Renderer renderer)
  {
    if (renderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr renderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(renderer);
    if (renderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    RayTracingAccelerationStructure.UpdateInstanceTransform_Renderer_Injected(native, renderer1);
  }

  public void UpdateInstanceTransform_Handle(int handle, Matrix4x4 matrix)
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.UpdateInstanceTransform_Handle_Injected(native, handle, ref matrix);
  }

  public void UpdateInstanceMask_Renderer(Renderer renderer, uint mask)
  {
    if (renderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr renderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(renderer);
    if (renderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    RayTracingAccelerationStructure.UpdateInstanceMask_Renderer_Injected(native, renderer1, mask);
  }

  public void UpdateInstanceMask_Handle(int handle, uint mask)
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.UpdateInstanceMask_Handle_Injected(native, handle, mask);
  }

  public void UpdateInstanceID_Renderer(Renderer renderer, uint id)
  {
    if (renderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr renderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(renderer);
    if (renderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    RayTracingAccelerationStructure.UpdateInstanceID_Renderer_Injected(native, renderer1, id);
  }

  public void UpdateInstanceID_Handle(int handle, uint id)
  {
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingAccelerationStructure.UpdateInstanceID_Handle_Injected(native, handle, id);
  }

  public unsafe int AddInstanceSubMeshFlagsArray(
    Renderer targetRenderer,
    Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags,
    bool enableTriangleCulling = default (bool),
    bool frontTriangleCounterClockwise = default (bool),
    uint mask = default (uint),
    uint id = default (uint))
  {
    if (targetRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    System.IntPtr targetRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Renderer>(targetRenderer);
    if (targetRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) targetRenderer, nameof (targetRenderer));
    Il2CppSystem.Span<RayTracingSubMeshFlags> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<RayTracingSubMeshFlags>) ref span).\u002Ector((Il2CppArrayBase<RayTracingSubMeshFlags>) subMeshFlags);
    int num;
    fixed (RayTracingSubMeshFlags* begin = &((Il2CppSystem.Span<RayTracingSubMeshFlags>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper subMeshFlags1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<RayTracingSubMeshFlags>) ref span).Length);
      num = RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArray_Injected(native, targetRenderer1, ref subMeshFlags1, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
    }
    return num;
  }

  public static bool CheckMaterialEnablesInstancing(Material material)
  {
    return RayTracingAccelerationStructure.CheckMaterialEnablesInstancing_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material));
  }

  public void Update()
  {
    Il2CppSystem.NotSupportedException supportedException = new Il2CppSystem.NotSupportedException("Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build()");
  }

  public void Update(Vector3 relativeOrigin)
  {
    Il2CppSystem.NotSupportedException supportedException = new Il2CppSystem.NotSupportedException("Method Update is deprecated and it will be removed in Unity 2024.1. Use Build instead (UnityUpgradable) -> Build(*)");
  }

  public void AddInstance(
    Renderer targetRenderer,
    Il2CppStructArray<bool> subMeshMask = null,
    Il2CppStructArray<bool> subMeshTransparencyFlags = null,
    bool enableTriangleCulling = default (bool),
    bool frontTriangleCounterClockwise = default (bool),
    uint mask = default (uint),
    uint id = default (uint))
  {
    Il2CppSystem.NotSupportedException supportedException = new Il2CppSystem.NotSupportedException("This AddInstance method is deprecated and will be removed and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding Renderers to the acceleration structure.");
  }

  public void AddInstance(
    GraphicsBuffer aabbBuffer,
    uint numElements,
    Material material,
    bool isCutOff,
    bool enableTriangleCulling = default (bool),
    bool frontTriangleCounterClockwise = default (bool),
    uint mask = default (uint),
    bool reuseBounds = default (bool),
    uint id = default (uint))
  {
    Il2CppSystem.NotSupportedException supportedException = new Il2CppSystem.NotSupportedException("This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.");
  }

  public int AddInstance(
    GraphicsBuffer aabbBuffer,
    uint aabbCount,
    bool dynamicData,
    Matrix4x4 matrix,
    Material material,
    bool opaqueMaterial,
    MaterialPropertyBlock properties,
    uint mask = default (uint),
    uint id = default (uint))
  {
    throw new Il2CppSystem.NotSupportedException("This AddInstance method is deprecated and it will be removed in Unity 2024.1. Please use the alternative AddInstance method for adding procedural geometry (AABBs) to the acceleration structure.");
  }

  public static void Build_Injected(
    System.IntPtr _unity_self,
    [In] ref RayTracingAccelerationStructure.BuildSettings buildSettings)
  {
    RayTracingAccelerationStructure.Build_InjectedDelegateField(_unity_self, (System.IntPtr) ref buildSettings);
  }

  public static void AddVFXInstances_Injected(
    System.IntPtr _unity_self,
    System.IntPtr targetRenderer,
    ref ManagedSpanWrapper vfxSystemMasks)
  {
    RayTracingAccelerationStructure.AddVFXInstances_InjectedDelegateField(_unity_self, targetRenderer, (System.IntPtr) ref vfxSystemMasks);
  }

  public static void RemoveVFXInstances_Injected(System.IntPtr _unity_self, System.IntPtr targetRenderer)
  {
    RayTracingAccelerationStructure.RemoveVFXInstances_InjectedDelegateField(_unity_self, targetRenderer);
  }

  public static void UpdateInstancePropertyBlock_Injected(
    System.IntPtr _unity_self,
    int handle,
    System.IntPtr properties)
  {
    RayTracingAccelerationStructure.UpdateInstancePropertyBlock_InjectedDelegateField(_unity_self, handle, properties);
  }

  public static ulong GetSize_Injected(System.IntPtr _unity_self)
  {
    return RayTracingAccelerationStructure.GetSize_InjectedDelegateField(_unity_self);
  }

  public static uint GetInstanceCount_Injected(System.IntPtr _unity_self)
  {
    return RayTracingAccelerationStructure.GetInstanceCount_InjectedDelegateField(_unity_self);
  }

  public static void ClearInstances_Injected(System.IntPtr _unity_self)
  {
    RayTracingAccelerationStructure.ClearInstances_InjectedDelegateField(_unity_self);
  }

  public static void RemoveInstance_Renderer_Injected(System.IntPtr _unity_self, System.IntPtr targetRenderer)
  {
    RayTracingAccelerationStructure.RemoveInstance_Renderer_InjectedDelegateField(_unity_self, targetRenderer);
  }

  public static void RemoveInstance_InstanceID_Injected(System.IntPtr _unity_self, int instanceID)
  {
    RayTracingAccelerationStructure.RemoveInstance_InstanceID_InjectedDelegateField(_unity_self, instanceID);
  }

  public static void UpdateInstanceTransform_Renderer_Injected(System.IntPtr _unity_self, System.IntPtr renderer)
  {
    RayTracingAccelerationStructure.UpdateInstanceTransform_Renderer_InjectedDelegateField(_unity_self, renderer);
  }

  public static void UpdateInstanceTransform_Handle_Injected(
    System.IntPtr _unity_self,
    int handle,
    [In] ref Matrix4x4 matrix)
  {
    RayTracingAccelerationStructure.UpdateInstanceTransform_Handle_InjectedDelegateField(_unity_self, handle, (System.IntPtr) ref matrix);
  }

  public static void UpdateInstanceMask_Renderer_Injected(
    System.IntPtr _unity_self,
    System.IntPtr renderer,
    uint mask)
  {
    RayTracingAccelerationStructure.UpdateInstanceMask_Renderer_InjectedDelegateField(_unity_self, renderer, mask);
  }

  public static void UpdateInstanceMask_Handle_Injected(System.IntPtr _unity_self, int handle, uint mask)
  {
    RayTracingAccelerationStructure.UpdateInstanceMask_Handle_InjectedDelegateField(_unity_self, handle, mask);
  }

  public static void UpdateInstanceID_Renderer_Injected(
    System.IntPtr _unity_self,
    System.IntPtr renderer,
    uint id)
  {
    RayTracingAccelerationStructure.UpdateInstanceID_Renderer_InjectedDelegateField(_unity_self, renderer, id);
  }

  public static void UpdateInstanceID_Handle_Injected(System.IntPtr _unity_self, int handle, uint id)
  {
    RayTracingAccelerationStructure.UpdateInstanceID_Handle_InjectedDelegateField(_unity_self, handle, id);
  }

  public static int AddInstanceSubMeshFlagsArray_Injected(
    System.IntPtr _unity_self,
    System.IntPtr targetRenderer,
    ref ManagedSpanWrapper subMeshFlags,
    bool enableTriangleCulling,
    bool frontTriangleCounterClockwise,
    uint mask,
    uint id)
  {
    return RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArray_InjectedDelegateField(_unity_self, targetRenderer, (System.IntPtr) ref subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
  }

  public static bool CheckMaterialEnablesInstancing_Injected(System.IntPtr material)
  {
    return RayTracingAccelerationStructure.CheckMaterialEnablesInstancing_InjectedDelegateField(material);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct BuildSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__buildFlags_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__relativeOrigin_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_buildFlags_Public_set_Void_RayTracingAccelerationStructureBuildFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_relativeOrigin_Public_set_Void_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    [FieldOffset(0)]
    public RayTracingAccelerationStructureBuildFlags _buildFlags_k__BackingField;
    [FieldOffset(4)]
    public Vector3 _relativeOrigin_k__BackingField;

    static BuildSettings()
    {
      Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, nameof (BuildSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr);
      RayTracingAccelerationStructure.BuildSettings.NativeFieldInfoPtr__buildFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr, "<buildFlags>k__BackingField");
      RayTracingAccelerationStructure.BuildSettings.NativeFieldInfoPtr__relativeOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr, "<relativeOrigin>k__BackingField");
      RayTracingAccelerationStructure.BuildSettings.NativeMethodInfoPtr_set_buildFlags_Public_set_Void_RayTracingAccelerationStructureBuildFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr, 100669715);
      RayTracingAccelerationStructure.BuildSettings.NativeMethodInfoPtr_set_relativeOrigin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr, 100669716);
      RayTracingAccelerationStructure.BuildSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr, 100669717);
    }

    public unsafe RayTracingAccelerationStructureBuildFlags buildFlags
    {
      [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.BuildSettings.NativeMethodInfoPtr_set_buildFlags_Public_set_Void_RayTracingAccelerationStructureBuildFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Vector3 relativeOrigin
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.BuildSettings.NativeMethodInfoPtr_set_relativeOrigin_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482569, XrefRangeEnd = 482571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.BuildSettings.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayTracingAccelerationStructure.BuildSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RayTracingAccelerationStructure_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<RayTracingAccelerationStructure.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RayTracingAccelerationStructure>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingAccelerationStructure.BindingsMarshaller>.NativeClassPtr);
      RayTracingAccelerationStructure.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RayTracingAccelerationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructure.BindingsMarshaller>.NativeClassPtr, 100669718);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(
      RayTracingAccelerationStructure rayTracingAccelerationStructure)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rayTracingAccelerationStructure)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RayTracingAccelerationStructure.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RayTracingAccelerationStructure_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public enum RayTracingModeMask
  {
    Nothing = 0,
    Static = 2,
    DynamicTransform = 4,
    DynamicGeometry = 8,
    Everything = 14, // 0x0000000E
  }

  public enum ManagementMode
  {
    Manual,
    Automatic,
  }

  private delegate void Build_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr buildSettings);

  private delegate void AddVFXInstances_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr targetRenderer,
    System.IntPtr vfxSystemMasks);

  private delegate void RemoveVFXInstances_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr targetRenderer);

  private delegate void UpdateInstancePropertyBlock_InjectedDelegate(
    System.IntPtr _unity_self,
    int handle,
    System.IntPtr properties);

  private delegate ulong GetSize_InjectedDelegate(System.IntPtr _unity_self);

  private delegate uint GetInstanceCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ClearInstances_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void RemoveInstance_Renderer_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr targetRenderer);

  private delegate void RemoveInstance_InstanceID_InjectedDelegate(
    System.IntPtr _unity_self,
    int instanceID);

  private delegate void UpdateInstanceTransform_Renderer_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr renderer);

  private delegate void UpdateInstanceTransform_Handle_InjectedDelegate(
    System.IntPtr _unity_self,
    int handle,
    [In] System.IntPtr matrix);

  private delegate void UpdateInstanceMask_Renderer_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr renderer,
    uint mask);

  private delegate void UpdateInstanceMask_Handle_InjectedDelegate(
    System.IntPtr _unity_self,
    int handle,
    uint mask);

  private delegate void UpdateInstanceID_Renderer_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr renderer,
    uint id);

  private delegate void UpdateInstanceID_Handle_InjectedDelegate(
    System.IntPtr _unity_self,
    int handle,
    uint id);

  private delegate int AddInstanceSubMeshFlagsArray_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr targetRenderer,
    System.IntPtr subMeshFlags,
    bool enableTriangleCulling,
    bool frontTriangleCounterClockwise,
    uint mask,
    uint id);

  private delegate bool CheckMaterialEnablesInstancing_InjectedDelegate(System.IntPtr material);
}
