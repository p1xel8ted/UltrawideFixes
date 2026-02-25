// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenProcessor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public class GPUDrivenProcessor(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_NativeRendererCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_NativeLODGroupCallback;
  private static readonly GPUDrivenProcessor.Internal_CreateDelegate Internal_CreateDelegateField;
  private static readonly GPUDrivenProcessor.Internal_DestroyDelegate Internal_DestroyDelegateField;
  private static readonly GPUDrivenProcessor.EnableGPUDrivenRenderingAndDispatchRendererData_InjectedDelegate EnableGPUDrivenRenderingAndDispatchRendererData_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.DisableGPUDrivenRendering_InjectedDelegate DisableGPUDrivenRendering_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.DispatchLODGroupData_InjectedDelegate DispatchLODGroupData_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.set_enablePartialRendering_InjectedDelegate set_enablePartialRendering_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.get_enablePartialRendering_InjectedDelegate get_enablePartialRendering_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.set_enableMaterialFilters_InjectedDelegate set_enableMaterialFilters_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.get_enableMaterialFilters_InjectedDelegate get_enableMaterialFilters_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.ClearMaterialFilters_InjectedDelegate ClearMaterialFilters_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.GetMaterialFilterFlags_InjectedDelegate GetMaterialFilterFlags_InjectedDelegateField;
  private static readonly GPUDrivenProcessor.ClassifyMaterialsImpl_InjectedDelegate ClassifyMaterialsImpl_InjectedDelegateField;

  static GPUDrivenProcessor()
  {
    Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenProcessor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr);
    GPUDrivenProcessor.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, nameof (m_Ptr));
    GPUDrivenProcessor.NativeFieldInfoPtr_s_NativeRendererCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, nameof (s_NativeRendererCallback));
    GPUDrivenProcessor.NativeFieldInfoPtr_s_NativeLODGroupCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, nameof (s_NativeLODGroupCallback));
    GPUDrivenProcessor.Internal_CreateDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.Internal_CreateDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::Internal_Create");
    GPUDrivenProcessor.Internal_DestroyDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.Internal_DestroyDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::Internal_Destroy");
    GPUDrivenProcessor.EnableGPUDrivenRenderingAndDispatchRendererData_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.EnableGPUDrivenRenderingAndDispatchRendererData_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::EnableGPUDrivenRenderingAndDispatchRendererData_Injected");
    GPUDrivenProcessor.DisableGPUDrivenRendering_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.DisableGPUDrivenRendering_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::DisableGPUDrivenRendering_Injected");
    GPUDrivenProcessor.DispatchLODGroupData_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.DispatchLODGroupData_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::DispatchLODGroupData_Injected");
    GPUDrivenProcessor.set_enablePartialRendering_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.set_enablePartialRendering_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::set_enablePartialRendering_Injected");
    GPUDrivenProcessor.get_enablePartialRendering_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.get_enablePartialRendering_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::get_enablePartialRendering_Injected");
    GPUDrivenProcessor.set_enableMaterialFilters_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.set_enableMaterialFilters_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::set_enableMaterialFilters_Injected");
    GPUDrivenProcessor.get_enableMaterialFilters_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.get_enableMaterialFilters_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::get_enableMaterialFilters_Injected");
    GPUDrivenProcessor.ClearMaterialFilters_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.ClearMaterialFilters_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::ClearMaterialFilters_Injected");
    GPUDrivenProcessor.GetMaterialFilterFlags_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.GetMaterialFilterFlags_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::GetMaterialFilterFlags_Injected");
    GPUDrivenProcessor.ClassifyMaterialsImpl_InjectedDelegateField = IL2CPP.ResolveICall<GPUDrivenProcessor.ClassifyMaterialsImpl_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::ClassifyMaterialsImpl_Injected");
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenProcessor.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenProcessor.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public static unsafe GPUDrivenRendererDataNativeCallback s_NativeRendererCallback
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GPUDrivenProcessor.NativeFieldInfoPtr_s_NativeRendererCallback, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (GPUDrivenRendererDataNativeCallback) null : Il2CppObjectPool.Get<GPUDrivenRendererDataNativeCallback>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GPUDrivenProcessor.NativeFieldInfoPtr_s_NativeRendererCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GPUDrivenProcessor.NativeFieldInfoPtr_s_NativeLODGroupCallback, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (GPUDrivenLODGroupDataNativeCallback) null : Il2CppObjectPool.Get<GPUDrivenLODGroupDataNativeCallback>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GPUDrivenProcessor.NativeFieldInfoPtr_s_NativeLODGroupCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public List<Mesh> scratchMeshes
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public List<Material> scratchMaterials
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public new virtual void Finalize()
  {
    try
    {
      this.Destroy();
    }
    finally
    {
      base.Finalize();
    }
  }

  public void Dispose()
  {
    this.scratchMeshes = (List<Mesh>) null;
    this.scratchMaterials = (List<Material>) null;
    this.Destroy();
    Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object) this);
  }

  public void Destroy()
  {
    if (!(this.m_Ptr != Il2CppSystem.IntPtr.Zero))
      return;
    GPUDrivenProcessor.Internal_Destroy(this.m_Ptr);
    this.m_Ptr = Il2CppSystem.IntPtr.Zero;
  }

  public static System.IntPtr Internal_Create()
  {
    return GPUDrivenProcessor.Internal_CreateDelegateField();
  }

  public static void Internal_Destroy(System.IntPtr ptr)
  {
    GPUDrivenProcessor.Internal_DestroyDelegateField(ptr);
  }

  public unsafe void EnableGPUDrivenRenderingAndDispatchRendererData(
    Il2CppSystem.ReadOnlySpan<int> renderersID,
    GPUDrivenRendererDataNativeCallback callback,
    List<Mesh> meshes,
    List<Material> materials,
    GPUDrivenRendererDataCallback param,
    bool materialUpdateOnly)
  {
    System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.ReadOnlySpan<int> readOnlySpan = renderersID;
    fixed (int* begin = &((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper renderersID1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).Length);
      GPUDrivenProcessor.EnableGPUDrivenRenderingAndDispatchRendererData_Injected(native, ref renderersID1, callback, meshes, materials, param, materialUpdateOnly);
    }
  }

  public void EnableGPUDrivenRenderingAndDispatchRendererData(
    Il2CppSystem.ReadOnlySpan<int> renderersID,
    GPUDrivenRendererDataCallback callback,
    bool materialUpdateOnly = default (bool))
  {
    this.scratchMeshes.Clear();
    this.scratchMaterials.Clear();
    this.EnableGPUDrivenRenderingAndDispatchRendererData(renderersID, GPUDrivenProcessor.s_NativeRendererCallback, this.scratchMeshes, this.scratchMaterials, callback, materialUpdateOnly);
  }

  public unsafe void DisableGPUDrivenRendering(Il2CppSystem.ReadOnlySpan<int> renderersID)
  {
    System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.ReadOnlySpan<int> readOnlySpan = renderersID;
    fixed (int* begin = &((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper renderersID1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).Length);
      GPUDrivenProcessor.DisableGPUDrivenRendering_Injected(native, ref renderersID1);
    }
  }

  public unsafe void DispatchLODGroupData(
    Il2CppSystem.ReadOnlySpan<int> lodGroupID,
    GPUDrivenLODGroupDataNativeCallback callback,
    GPUDrivenLODGroupDataCallback param)
  {
    System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.ReadOnlySpan<int> readOnlySpan = lodGroupID;
    fixed (int* begin = &((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper lodGroupID1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).Length);
      GPUDrivenProcessor.DispatchLODGroupData_Injected(native, ref lodGroupID1, callback, param);
    }
  }

  public void DispatchLODGroupData(
    Il2CppSystem.ReadOnlySpan<int> lodGroupID,
    GPUDrivenLODGroupDataCallback callback)
  {
    this.DispatchLODGroupData(lodGroupID, GPUDrivenProcessor.s_NativeLODGroupCallback, callback);
  }

  public bool enablePartialRendering
  {
    set
    {
      System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      GPUDrivenProcessor.set_enablePartialRendering_Injected(native, value);
    }
    get
    {
      System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GPUDrivenProcessor.get_enablePartialRendering_Injected(native);
    }
  }

  public bool enableMaterialFilters
  {
    set
    {
      System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      GPUDrivenProcessor.set_enableMaterialFilters_Injected(native, value);
    }
    get
    {
      System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GPUDrivenProcessor.get_enableMaterialFilters_Injected(native);
    }
  }

  public void ClearMaterialFilters()
  {
    System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GPUDrivenProcessor.ClearMaterialFilters_Injected(native);
  }

  public int GetMaterialFilterFlags(Material material)
  {
    System.IntPtr native = GPUDrivenProcessor.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return GPUDrivenProcessor.GetMaterialFilterFlags_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material));
  }

  public static unsafe int ClassifyMaterialsImpl(
    Il2CppSystem.ReadOnlySpan<int> materialIDs,
    Il2CppSystem.Span<int> unsupportedMaterialIDs,
    Il2CppSystem.Span<int> supportedMaterialIDs,
    Il2CppSystem.Span<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
  {
    Il2CppSystem.ReadOnlySpan<int> readOnlySpan = materialIDs;
    int num;
    fixed (int* begin1 = &((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin1, ((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).Length);
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      Il2CppSystem.Span<int> span1 = unsupportedMaterialIDs;
      fixed (int* begin2 = &((Il2CppSystem.Span<int>) ref span1).GetPinnableReference())
      {
        ManagedSpanWrapper managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin2, ((Il2CppSystem.Span<int>) ref span1).Length);
        ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
        Il2CppSystem.Span<int> span2 = supportedMaterialIDs;
        fixed (int* begin3 = &((Il2CppSystem.Span<int>) ref span2).GetPinnableReference())
        {
          ManagedSpanWrapper managedSpanWrapper3 = new ManagedSpanWrapper((void*) begin3, ((Il2CppSystem.Span<int>) ref span2).Length);
          ref ManagedSpanWrapper local3 = ref managedSpanWrapper3;
          Il2CppSystem.Span<GPUDrivenPackedMaterialData> span3 = supportedPackedMaterialDatas;
          fixed (GPUDrivenPackedMaterialData* begin4 = &((Il2CppSystem.Span<GPUDrivenPackedMaterialData>) ref span3).GetPinnableReference())
          {
            ManagedSpanWrapper managedSpanWrapper4 = new ManagedSpanWrapper((void*) begin4, ((Il2CppSystem.Span<GPUDrivenPackedMaterialData>) ref span3).Length);
            ref ManagedSpanWrapper local4 = ref managedSpanWrapper4;
            num = GPUDrivenProcessor.ClassifyMaterialsImpl_Injected(ref local1, ref local2, ref local3, ref local4);
          }
        }
      }
    }
    return num;
  }

  public static int ClassifyMaterials(
    NativeArray<int> materialIDs,
    NativeArray<int> unsupportedMaterialIDs,
    NativeArray<int> supportedMaterialIDs,
    NativeArray<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
  {
    return GPUDrivenProcessor.ClassifyMaterialsImpl((Il2CppSystem.ReadOnlySpan<int>) ref materialIDs, NativeArray<int>.op_Implicit(ref unsupportedMaterialIDs), NativeArray<int>.op_Implicit(ref supportedMaterialIDs), NativeArray<GPUDrivenPackedMaterialData>.op_Implicit(ref supportedPackedMaterialDatas));
  }

  public static void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper renderersID,
    GPUDrivenRendererDataNativeCallback callback,
    List<Mesh> meshes,
    List<Material> materials,
    GPUDrivenRendererDataCallback param,
    bool materialUpdateOnly)
  {
    GPUDrivenProcessor.EnableGPUDrivenRenderingAndDispatchRendererData_InjectedDelegateField(_unity_self, (System.IntPtr) ref renderersID, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) materials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) param), materialUpdateOnly);
  }

  public static void DisableGPUDrivenRendering_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper renderersID)
  {
    GPUDrivenProcessor.DisableGPUDrivenRendering_InjectedDelegateField(_unity_self, (System.IntPtr) ref renderersID);
  }

  public static void DispatchLODGroupData_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper lodGroupID,
    GPUDrivenLODGroupDataNativeCallback callback,
    GPUDrivenLODGroupDataCallback param)
  {
    GPUDrivenProcessor.DispatchLODGroupData_InjectedDelegateField(_unity_self, (System.IntPtr) ref lodGroupID, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) param));
  }

  public static void set_enablePartialRendering_Injected(System.IntPtr _unity_self, bool value)
  {
    GPUDrivenProcessor.set_enablePartialRendering_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_enablePartialRendering_Injected(System.IntPtr _unity_self)
  {
    return GPUDrivenProcessor.get_enablePartialRendering_InjectedDelegateField(_unity_self);
  }

  public static void set_enableMaterialFilters_Injected(System.IntPtr _unity_self, bool value)
  {
    GPUDrivenProcessor.set_enableMaterialFilters_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_enableMaterialFilters_Injected(System.IntPtr _unity_self)
  {
    return GPUDrivenProcessor.get_enableMaterialFilters_InjectedDelegateField(_unity_self);
  }

  public static void ClearMaterialFilters_Injected(System.IntPtr _unity_self)
  {
    GPUDrivenProcessor.ClearMaterialFilters_InjectedDelegateField(_unity_self);
  }

  public static int GetMaterialFilterFlags_Injected(System.IntPtr _unity_self, System.IntPtr material)
  {
    return GPUDrivenProcessor.GetMaterialFilterFlags_InjectedDelegateField(_unity_self, material);
  }

  public static int ClassifyMaterialsImpl_Injected(
    ref ManagedSpanWrapper materialIDs,
    ref ManagedSpanWrapper unsupportedMaterialIDs,
    ref ManagedSpanWrapper supportedMaterialIDs,
    ref ManagedSpanWrapper supportedPackedMaterialDatas)
  {
    return GPUDrivenProcessor.ClassifyMaterialsImpl_InjectedDelegateField((System.IntPtr) ref materialIDs, (System.IntPtr) ref unsupportedMaterialIDs, (System.IntPtr) ref supportedMaterialIDs, (System.IntPtr) ref supportedPackedMaterialDatas);
  }

  [ObfuscatedName("UnityEngine.Rendering.GPUDrivenProcessor+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__34_0_Internal_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__34_1_Internal_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0;

    static __c()
    {
      Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr);
      GPUDrivenProcessor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr, "<>9");
      GPUDrivenProcessor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr, 100670310);
      GPUDrivenProcessor.__c.NativeMethodInfoPtr___cctor_b__34_0_Internal_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr, 100670311);
      GPUDrivenProcessor.__c.NativeMethodInfoPtr___cctor_b__34_1_Internal_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr, 100670312);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenProcessor.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GPUDrivenProcessor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487162, XrefRangeEnd = 487228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __cctor_b__34_0(
      [In] ref GPUDrivenRendererGroupDataNative nativeData,
      List<Mesh> meshes,
      List<Material> materials,
      GPUDrivenRendererDataCallback callback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref nativeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) materials);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GPUDrivenProcessor.__c.NativeMethodInfoPtr___cctor_b__34_0_Internal_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487228, XrefRangeEnd = 487261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __cctor_b__34_1(
      [In] ref GPUDrivenLODGroupDataNative nativeData,
      GPUDrivenLODGroupDataCallback callback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref nativeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GPUDrivenProcessor.__c.NativeMethodInfoPtr___cctor_b__34_1_Internal_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe GPUDrivenProcessor.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GPUDrivenProcessor.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GPUDrivenProcessor.__c) null : Il2CppObjectPool.Get<GPUDrivenProcessor.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GPUDrivenProcessor.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public static class BindingsMarshaller
  {
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }

  private delegate System.IntPtr Internal_CreateDelegate();

  private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

  private delegate void EnableGPUDrivenRenderingAndDispatchRendererData_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr renderersID,
    System.IntPtr callback,
    System.IntPtr meshes,
    System.IntPtr materials,
    System.IntPtr param,
    bool materialUpdateOnly);

  private delegate void DisableGPUDrivenRendering_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr renderersID);

  private delegate void DispatchLODGroupData_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr lodGroupID,
    System.IntPtr callback,
    System.IntPtr param);

  private delegate void set_enablePartialRendering_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate bool get_enablePartialRendering_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_enableMaterialFilters_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate bool get_enableMaterialFilters_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ClearMaterialFilters_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int GetMaterialFilterFlags_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

  private delegate int ClassifyMaterialsImpl_InjectedDelegate(
    System.IntPtr materialIDs,
    System.IntPtr unsupportedMaterialIDs,
    System.IntPtr supportedMaterialIDs,
    System.IntPtr supportedPackedMaterialDatas);
}
