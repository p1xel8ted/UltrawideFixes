// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchRendererGroup
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public class BatchRendererGroup(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_GroupHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PerformCulling;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FinishedCulling;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnFinishedCulling_Private_Static_Void_BatchRendererGroup_IntPtr_0;
  private static readonly BatchRendererGroup.GetBufferTargetDelegate GetBufferTargetDelegateField;
  private static readonly BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegate GetConstantBufferMaxWindowSizeDelegateField;
  private static readonly BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegate GetConstantBufferOffsetAlignmentDelegateField;
  private static readonly BatchRendererGroup.CreateDelegate CreateDelegateField;
  private static readonly BatchRendererGroup.DestroyDelegate DestroyDelegateField;
  private static readonly BatchRendererGroup.AddDrawCommandBatch_InjectedDelegate AddDrawCommandBatch_InjectedDelegateField;
  private static readonly BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegate RemoveDrawCommandBatch_InjectedDelegateField;
  private static readonly BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegate SetDrawCommandBatchBuffer_InjectedDelegateField;
  private static readonly BatchRendererGroup.RegisterMaterial_InjectedDelegate RegisterMaterial_InjectedDelegateField;
  private static readonly BatchRendererGroup.RegisterMaterials_InjectedDelegate RegisterMaterials_InjectedDelegateField;
  private static readonly BatchRendererGroup.UnregisterMaterial_InjectedDelegate UnregisterMaterial_InjectedDelegateField;
  private static readonly BatchRendererGroup.GetRegisteredMaterial_InjectedDelegate GetRegisteredMaterial_InjectedDelegateField;
  private static readonly BatchRendererGroup.RegisterMesh_InjectedDelegate RegisterMesh_InjectedDelegateField;
  private static readonly BatchRendererGroup.RegisterMeshes_InjectedDelegate RegisterMeshes_InjectedDelegateField;
  private static readonly BatchRendererGroup.UnregisterMesh_InjectedDelegate UnregisterMesh_InjectedDelegateField;
  private static readonly BatchRendererGroup.GetRegisteredMesh_InjectedDelegate GetRegisteredMesh_InjectedDelegateField;
  private static readonly BatchRendererGroup.SetGlobalBounds_InjectedDelegate SetGlobalBounds_InjectedDelegateField;
  private static readonly BatchRendererGroup.SetPickingMaterial_InjectedDelegate SetPickingMaterial_InjectedDelegateField;
  private static readonly BatchRendererGroup.SetErrorMaterial_InjectedDelegate SetErrorMaterial_InjectedDelegateField;
  private static readonly BatchRendererGroup.SetLoadingMaterial_InjectedDelegate SetLoadingMaterial_InjectedDelegateField;
  private static readonly BatchRendererGroup.SetEnabledViewTypes_InjectedDelegate SetEnabledViewTypes_InjectedDelegateField;
  private static readonly BatchRendererGroup.OcclusionTestAABB_InjectedDelegate OcclusionTestAABB_InjectedDelegateField;

  static BatchRendererGroup()
  {
    Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchRendererGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr);
    BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, nameof (m_GroupHandle));
    BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, nameof (m_PerformCulling));
    BatchRendererGroup.NativeFieldInfoPtr_m_FinishedCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, nameof (m_FinishedCulling));
    BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100670292);
    BatchRendererGroup.NativeMethodInfoPtr_InvokeOnFinishedCulling_Private_Static_Void_BatchRendererGroup_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100670293);
    BatchRendererGroup.GetBufferTargetDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBufferTargetDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBufferTarget");
    BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferMaxWindowSize");
    BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferOffsetAlignment");
    BatchRendererGroup.CreateDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.CreateDelegate>("UnityEngine.Rendering.BatchRendererGroup::Create");
    BatchRendererGroup.DestroyDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.DestroyDelegate>("UnityEngine.Rendering.BatchRendererGroup::Destroy");
    BatchRendererGroup.AddDrawCommandBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.AddDrawCommandBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::AddDrawCommandBatch_Injected");
    BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RemoveDrawCommandBatch_Injected");
    BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetDrawCommandBatchBuffer_Injected");
    BatchRendererGroup.RegisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterial_Injected");
    BatchRendererGroup.RegisterMaterials_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMaterials_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterials_Injected");
    BatchRendererGroup.UnregisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.UnregisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::UnregisterMaterial_Injected");
    BatchRendererGroup.GetRegisteredMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetRegisteredMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMaterial_Injected");
    BatchRendererGroup.RegisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMesh_Injected");
    BatchRendererGroup.RegisterMeshes_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMeshes_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMeshes_Injected");
    BatchRendererGroup.UnregisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.UnregisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::UnregisterMesh_Injected");
    BatchRendererGroup.GetRegisteredMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetRegisteredMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMesh_Injected");
    BatchRendererGroup.SetGlobalBounds_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetGlobalBounds_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetGlobalBounds_Injected");
    BatchRendererGroup.SetPickingMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetPickingMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetPickingMaterial_Injected");
    BatchRendererGroup.SetErrorMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetErrorMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetErrorMaterial_Injected");
    BatchRendererGroup.SetLoadingMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetLoadingMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetLoadingMaterial_Injected");
    BatchRendererGroup.SetEnabledViewTypes_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetEnabledViewTypes_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetEnabledViewTypes_Injected");
    BatchRendererGroup.OcclusionTestAABB_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.OcclusionTestAABB_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::OcclusionTestAABB_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487109, XrefRangeEnd = 487124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnPerformCulling(
    BatchRendererGroup group,
    ref BatchRendererCullingOutput context,
    ref LODParameters lodParameters,
    System.IntPtr userContext)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lodParameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userContext;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487124, XrefRangeEnd = 487128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnFinishedCulling(
    BatchRendererGroup group,
    System.IntPtr customCullingResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &customCullingResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.NativeMethodInfoPtr_InvokeOnFinishedCulling_Private_Static_Void_BatchRendererGroup_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_GroupHandle
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle)) = value;
    }
  }

  public unsafe BatchRendererGroup.OnPerformCulling m_PerformCulling
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling));
      return num == System.IntPtr.Zero ? (BatchRendererGroup.OnPerformCulling) null : Il2CppObjectPool.Get<BatchRendererGroup.OnPerformCulling>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BatchRendererGroup.OnFinishedCulling m_FinishedCulling
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_FinishedCulling));
      return num == System.IntPtr.Zero ? (BatchRendererGroup.OnFinishedCulling) null : Il2CppObjectPool.Get<BatchRendererGroup.OnFinishedCulling>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_FinishedCulling), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public void Dispose()
  {
    BatchRendererGroup.Destroy(this.m_GroupHandle);
    this.m_GroupHandle = Il2CppSystem.IntPtr.Zero;
  }

  public BatchID AddDrawCommandBatch(
    System.IntPtr values,
    int count,
    GraphicsBufferHandle buffer,
    uint bufferOffset,
    uint windowSize)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchID ret;
    BatchRendererGroup.AddDrawCommandBatch_Injected(native, values, count, ref buffer, bufferOffset, windowSize, out ret);
    return ret;
  }

  public void RemoveDrawCommandBatch(BatchID batchID)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.RemoveDrawCommandBatch_Injected(native, ref batchID);
  }

  public void RemoveBatch(BatchID batchID) => this.RemoveDrawCommandBatch(batchID);

  public void SetDrawCommandBatchBuffer(BatchID batchID, GraphicsBufferHandle buffer)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.SetDrawCommandBatchBuffer_Injected(native, ref batchID, ref buffer);
  }

  public void SetBatchBuffer(BatchID batchID, GraphicsBufferHandle buffer)
  {
    this.SetDrawCommandBatchBuffer(batchID, buffer);
  }

  public BatchMaterialID RegisterMaterial(Material material)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchMaterialID ret;
    BatchRendererGroup.RegisterMaterial_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material), out ret);
    return ret;
  }

  public unsafe void RegisterMaterials(
    Il2CppSystem.ReadOnlySpan<int> materialID,
    Il2CppSystem.Span<BatchMaterialID> batchMaterialID)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.ReadOnlySpan<int> readOnlySpan = materialID;
    fixed (int* begin1 = &((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin1, ((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).Length);
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      Il2CppSystem.Span<BatchMaterialID> span = batchMaterialID;
      fixed (BatchMaterialID* begin2 = &((Il2CppSystem.Span<BatchMaterialID>) ref span).GetPinnableReference())
      {
        ManagedSpanWrapper managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin2, ((Il2CppSystem.Span<BatchMaterialID>) ref span).Length);
        ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
        BatchRendererGroup.RegisterMaterials_Injected(native, ref local1, ref local2);
      }
    }
  }

  public void UnregisterMaterial(BatchMaterialID material)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.UnregisterMaterial_Injected(native, ref material);
  }

  public Material GetRegisteredMaterial(BatchMaterialID material)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Unmarshal.UnmarshalUnityObject<Material>(BatchRendererGroup.GetRegisteredMaterial_Injected(native, ref material));
  }

  public BatchMeshID RegisterMesh(Mesh mesh)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchMeshID ret;
    BatchRendererGroup.RegisterMesh_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Mesh>(mesh), out ret);
    return ret;
  }

  public unsafe void RegisterMeshes(Il2CppSystem.ReadOnlySpan<int> meshID, Il2CppSystem.Span<BatchMeshID> batchMeshID)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.ReadOnlySpan<int> readOnlySpan = meshID;
    fixed (int* begin1 = &((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin1, ((Il2CppSystem.ReadOnlySpan<int>) ref readOnlySpan).Length);
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      Il2CppSystem.Span<BatchMeshID> span = batchMeshID;
      fixed (BatchMeshID* begin2 = &((Il2CppSystem.Span<BatchMeshID>) ref span).GetPinnableReference())
      {
        ManagedSpanWrapper managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin2, ((Il2CppSystem.Span<BatchMeshID>) ref span).Length);
        ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
        BatchRendererGroup.RegisterMeshes_Injected(native, ref local1, ref local2);
      }
    }
  }

  public void UnregisterMesh(BatchMeshID mesh)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.UnregisterMesh_Injected(native, ref mesh);
  }

  public Mesh GetRegisteredMesh(BatchMeshID mesh)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Unmarshal.UnmarshalUnityObject<Mesh>(BatchRendererGroup.GetRegisteredMesh_Injected(native, ref mesh));
  }

  public void SetGlobalBounds(Bounds bounds)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.SetGlobalBounds_Injected(native, ref bounds);
  }

  public void SetPickingMaterial(Material material)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.SetPickingMaterial_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material));
  }

  public void SetErrorMaterial(Material material)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.SetErrorMaterial_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material));
  }

  public void SetLoadingMaterial(Material material)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BatchRendererGroup.SetLoadingMaterial_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material));
  }

  public unsafe void SetEnabledViewTypes(Il2CppStructArray<BatchCullingViewType> viewTypes)
  {
    System.IntPtr native = BatchRendererGroup.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<BatchCullingViewType> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<BatchCullingViewType>) ref span).\u002Ector((Il2CppArrayBase<BatchCullingViewType>) viewTypes);
    fixed (BatchCullingViewType* begin = &((Il2CppSystem.Span<BatchCullingViewType>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper viewTypes1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<BatchCullingViewType>) ref span).Length);
      BatchRendererGroup.SetEnabledViewTypes_Injected(native, ref viewTypes1);
    }
  }

  public static BatchBufferTarget GetBufferTarget()
  {
    return BatchRendererGroup.GetBufferTargetDelegateField();
  }

  public static BatchBufferTarget BufferTarget => BatchRendererGroup.GetBufferTarget();

  public static int GetConstantBufferMaxWindowSize()
  {
    return BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegateField();
  }

  public static int GetConstantBufferOffsetAlignment()
  {
    return BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegateField();
  }

  public static unsafe System.IntPtr Create(BatchRendererGroup group, void* userContext)
  {
    return BatchRendererGroup.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group), (System.IntPtr) userContext);
  }

  public static void Destroy(System.IntPtr groupHandle)
  {
    BatchRendererGroup.DestroyDelegateField(groupHandle);
  }

  public static bool OcclusionTestAABB(System.IntPtr occlusionBuffer, Bounds aabb)
  {
    return BatchRendererGroup.OcclusionTestAABB_Injected(occlusionBuffer, ref aabb);
  }

  public static void AddDrawCommandBatch_Injected(
    System.IntPtr _unity_self,
    System.IntPtr values,
    int count,
    [In] ref GraphicsBufferHandle buffer,
    uint bufferOffset,
    uint windowSize,
    out BatchID ret)
  {
    BatchRendererGroup.AddDrawCommandBatch_InjectedDelegateField(_unity_self, values, count, (System.IntPtr) ref buffer, bufferOffset, windowSize, (System.IntPtr) ref ret);
  }

  public static void RemoveDrawCommandBatch_Injected(System.IntPtr _unity_self, [In] ref BatchID batchID)
  {
    BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegateField(_unity_self, (System.IntPtr) ref batchID);
  }

  public static void SetDrawCommandBatchBuffer_Injected(
    System.IntPtr _unity_self,
    [In] ref BatchID batchID,
    [In] ref GraphicsBufferHandle buffer)
  {
    BatchRendererGroup.SetDrawCommandBatchBuffer_InjectedDelegateField(_unity_self, (System.IntPtr) ref batchID, (System.IntPtr) ref buffer);
  }

  public static void RegisterMaterial_Injected(
    System.IntPtr _unity_self,
    System.IntPtr material,
    out BatchMaterialID ret)
  {
    BatchRendererGroup.RegisterMaterial_InjectedDelegateField(_unity_self, material, (System.IntPtr) ref ret);
  }

  public static void RegisterMaterials_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper materialID,
    ref ManagedSpanWrapper batchMaterialID)
  {
    BatchRendererGroup.RegisterMaterials_InjectedDelegateField(_unity_self, (System.IntPtr) ref materialID, (System.IntPtr) ref batchMaterialID);
  }

  public static void UnregisterMaterial_Injected(System.IntPtr _unity_self, [In] ref BatchMaterialID material)
  {
    BatchRendererGroup.UnregisterMaterial_InjectedDelegateField(_unity_self, (System.IntPtr) ref material);
  }

  public static System.IntPtr GetRegisteredMaterial_Injected(
    System.IntPtr _unity_self,
    [In] ref BatchMaterialID material)
  {
    return BatchRendererGroup.GetRegisteredMaterial_InjectedDelegateField(_unity_self, (System.IntPtr) ref material);
  }

  public static void RegisterMesh_Injected(System.IntPtr _unity_self, System.IntPtr mesh, out BatchMeshID ret)
  {
    BatchRendererGroup.RegisterMesh_InjectedDelegateField(_unity_self, mesh, (System.IntPtr) ref ret);
  }

  public static void RegisterMeshes_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper meshID,
    ref ManagedSpanWrapper batchMeshID)
  {
    BatchRendererGroup.RegisterMeshes_InjectedDelegateField(_unity_self, (System.IntPtr) ref meshID, (System.IntPtr) ref batchMeshID);
  }

  public static void UnregisterMesh_Injected(System.IntPtr _unity_self, [In] ref BatchMeshID mesh)
  {
    BatchRendererGroup.UnregisterMesh_InjectedDelegateField(_unity_self, (System.IntPtr) ref mesh);
  }

  public static System.IntPtr GetRegisteredMesh_Injected(System.IntPtr _unity_self, [In] ref BatchMeshID mesh)
  {
    return BatchRendererGroup.GetRegisteredMesh_InjectedDelegateField(_unity_self, (System.IntPtr) ref mesh);
  }

  public static void SetGlobalBounds_Injected(System.IntPtr _unity_self, [In] ref Bounds bounds)
  {
    BatchRendererGroup.SetGlobalBounds_InjectedDelegateField(_unity_self, (System.IntPtr) ref bounds);
  }

  public static void SetPickingMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material)
  {
    BatchRendererGroup.SetPickingMaterial_InjectedDelegateField(_unity_self, material);
  }

  public static void SetErrorMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material)
  {
    BatchRendererGroup.SetErrorMaterial_InjectedDelegateField(_unity_self, material);
  }

  public static void SetLoadingMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material)
  {
    BatchRendererGroup.SetLoadingMaterial_InjectedDelegateField(_unity_self, material);
  }

  public static void SetEnabledViewTypes_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper viewTypes)
  {
    BatchRendererGroup.SetEnabledViewTypes_InjectedDelegateField(_unity_self, (System.IntPtr) ref viewTypes);
  }

  public static bool OcclusionTestAABB_Injected(System.IntPtr occlusionBuffer, [In] ref Bounds aabb)
  {
    return BatchRendererGroup.OcclusionTestAABB_InjectedDelegateField(occlusionBuffer, (System.IntPtr) ref aabb);
  }

  public sealed class OnPerformCulling(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0;

    static OnPerformCulling()
    {
      Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, nameof (OnPerformCulling));
      BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100670294);
      BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100670295);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487100, XrefRangeEnd = 487109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnPerformCulling(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe JobHandle Invoke(
      BatchRendererGroup rendererGroup,
      BatchCullingContext cullingContext,
      BatchCullingOutput cullingOutput,
      System.IntPtr userContext)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rendererGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cullingContext));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cullingOutput));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userContext;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static implicit operator BatchRendererGroup.OnPerformCulling(
      [In] System.Func<BatchRendererGroup, BatchCullingContext, BatchCullingOutput, System.IntPtr, JobHandle> obj0)
    {
      return DelegateSupport.ConvertDelegate<BatchRendererGroup.OnPerformCulling>((System.Delegate) obj0);
    }

    public static BatchRendererGroup.OnPerformCulling operator +(
      [In] BatchRendererGroup.OnPerformCulling obj0,
      [In] BatchRendererGroup.OnPerformCulling obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<BatchRendererGroup.OnPerformCulling>();
    }

    public static BatchRendererGroup.OnPerformCulling operator -(
      [In] BatchRendererGroup.OnPerformCulling obj0,
      [In] BatchRendererGroup.OnPerformCulling obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (BatchRendererGroup.OnPerformCulling) @delegate : @delegate.Cast<BatchRendererGroup.OnPerformCulling>();
    }
  }

  public sealed class OnFinishedCulling(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

    static OnFinishedCulling()
    {
      Il2CppClassPointerStore<BatchRendererGroup.OnFinishedCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, nameof (OnFinishedCulling));
      BatchRendererGroup.OnFinishedCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnFinishedCulling>.NativeClassPtr, 100670296);
      BatchRendererGroup.OnFinishedCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnFinishedCulling>.NativeClassPtr, 100670297);
    }

    [CallerCount(44)]
    [CachedScanResults(RefRangeStart = 372301, RefRangeEnd = 372345, XrefRangeStart = 372301, XrefRangeEnd = 372345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnFinishedCulling(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup.OnFinishedCulling>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnFinishedCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(System.IntPtr customCullingResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &customCullingResult
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnFinishedCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator BatchRendererGroup.OnFinishedCulling([In] System.Action<System.IntPtr> obj0)
    {
      return DelegateSupport.ConvertDelegate<BatchRendererGroup.OnFinishedCulling>((System.Delegate) obj0);
    }

    public static BatchRendererGroup.OnFinishedCulling operator +(
      [In] BatchRendererGroup.OnFinishedCulling obj0,
      [In] BatchRendererGroup.OnFinishedCulling obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<BatchRendererGroup.OnFinishedCulling>();
    }

    public static BatchRendererGroup.OnFinishedCulling operator -(
      [In] BatchRendererGroup.OnFinishedCulling obj0,
      [In] BatchRendererGroup.OnFinishedCulling obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (BatchRendererGroup.OnFinishedCulling) @delegate : @delegate.Cast<BatchRendererGroup.OnFinishedCulling>();
    }
  }

  public static class BindingsMarshaller
  {
  }

  private delegate BatchBufferTarget GetBufferTargetDelegate();

  private delegate int GetConstantBufferMaxWindowSizeDelegate();

  private delegate int GetConstantBufferOffsetAlignmentDelegate();

  private delegate System.IntPtr CreateDelegate(System.IntPtr group, System.IntPtr userContext);

  private delegate void DestroyDelegate(System.IntPtr groupHandle);

  private delegate void AddDrawCommandBatch_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr values,
    int count,
    [In] System.IntPtr buffer,
    uint bufferOffset,
    uint windowSize,
    [Out] System.IntPtr ret);

  private delegate void RemoveDrawCommandBatch_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr batchID);

  private delegate void SetDrawCommandBatchBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr batchID,
    [In] System.IntPtr buffer);

  private delegate void RegisterMaterial_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr material,
    [Out] System.IntPtr ret);

  private delegate void RegisterMaterials_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr materialID,
    System.IntPtr batchMaterialID);

  private delegate void UnregisterMaterial_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr material);

  private delegate System.IntPtr GetRegisteredMaterial_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr material);

  private delegate void RegisterMesh_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr mesh, [Out] System.IntPtr ret);

  private delegate void RegisterMeshes_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr meshID,
    System.IntPtr batchMeshID);

  private delegate void UnregisterMesh_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr mesh);

  private delegate System.IntPtr GetRegisteredMesh_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr mesh);

  private delegate void SetGlobalBounds_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr bounds);

  private delegate void SetPickingMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

  private delegate void SetErrorMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

  private delegate void SetLoadingMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

  private delegate void SetEnabledViewTypes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr viewTypes);

  private delegate bool OcclusionTestAABB_InjectedDelegate(System.IntPtr occlusionBuffer, [In] System.IntPtr aabb);
}
