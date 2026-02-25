// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.SpriteRendererDataAccessExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.U2D;

public static class SpriteRendererDataAccessExtensions
{
  private static readonly SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate SetBatchDeformableBufferAndLocalAABBArrayDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBatchDeformableBufferAndLocalAABBArray");
  private static readonly SpriteRendererDataAccessExtensions.SetBoneTransformsArrayDelegate SetBoneTransformsArrayDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBoneTransformsArrayDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBoneTransformsArray");
  private static readonly SpriteRendererDataAccessExtensions.IsGPUSkinningEnabledDelegate IsGPUSkinningEnabledDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.IsGPUSkinningEnabledDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsGPUSkinningEnabled");
  private static readonly SpriteRendererDataAccessExtensions.DeactivateDeformableBuffer_InjectedDelegate DeactivateDeformableBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.DeactivateDeformableBuffer_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::DeactivateDeformableBuffer_Injected");
  private static readonly SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetLocalAABB_Injected");
  private static readonly SpriteRendererDataAccessExtensions.SetDeformableBuffer_InjectedDelegate SetDeformableBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetDeformableBuffer_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetDeformableBuffer_Injected");
  private static readonly SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer_InjectedDelegate IsUsingDeformableBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsUsingDeformableBuffer_Injected");
  private static readonly SpriteRendererDataAccessExtensions.SetBoneTransforms_InjectedDelegate SetBoneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBoneTransforms_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBoneTransforms_Injected");
  private static readonly SpriteRendererDataAccessExtensions.SetupMaterialProperties_InjectedDelegate SetupMaterialProperties_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetupMaterialProperties_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetupMaterialProperties_Injected");
  private static readonly SpriteRendererDataAccessExtensions.IsSRPBatchingEnabled_InjectedDelegate IsSRPBatchingEnabled_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.IsSRPBatchingEnabled_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::IsSRPBatchingEnabled_Injected");

  public static unsafe void SetDeformableBuffer(
    SpriteRenderer spriteRenderer,
    NativeArray<byte> src)
  {
    if ((UnityEngine.Object) spriteRenderer.sprite == (UnityEngine.Object) null)
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("spriteRenderer does not have a valid sprite set.", (Il2CppReferenceArray<Il2CppSystem.Object>) Il2CppSystem.Array.Empty<Il2CppSystem.Object>()));
    if (((NativeArray<byte>) ref src).Length != SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite))
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("custom sprite vertex data size must match sprite asset's vertex data size {0} {1}", (Il2CppSystem.Object) (System.ValueType) ((NativeArray<byte>) ref src).Length, (Il2CppSystem.Object) (System.ValueType) SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite)));
    SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<byte>(), ((NativeArray<byte>) ref src).Length);
  }

  public static unsafe void SetDeformableBuffer(
    SpriteRenderer spriteRenderer,
    NativeArray<Vector3> src)
  {
    if ((UnityEngine.Object) spriteRenderer.sprite == (UnityEngine.Object) null)
      throw new Il2CppSystem.InvalidOperationException("spriteRenderer does not have a valid sprite set.");
    if (((NativeArray<Vector3>) ref src).Length != SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite))
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("The src length {0} must match the vertex count of source Sprite {1}.", (Il2CppSystem.Object) (System.ValueType) ((NativeArray<Vector3>) ref src).Length, (Il2CppSystem.Object) (System.ValueType) SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite)));
    SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<Vector3>(), ((NativeArray<Vector3>) ref src).Length);
  }

  public static unsafe void SetBatchDeformableBufferAndLocalAABBArray(
    Il2CppReferenceArray<SpriteRenderer> spriteRenderers,
    NativeArray<System.IntPtr> buffers,
    NativeArray<int> bufferSizes,
    NativeArray<Bounds> bounds)
  {
    int length = ((Il2CppArrayBase) spriteRenderers).Length;
    if (length != ((NativeArray<System.IntPtr>) ref buffers).Length || length != ((NativeArray<int>) ref bufferSizes).Length || length != ((NativeArray<Bounds>) ref bounds).Length)
      throw new Il2CppSystem.ArgumentException("Input array sizes are not the same.");
    SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArray(spriteRenderers, buffers.GetUnsafeReadOnlyPtr<System.IntPtr>(), bufferSizes.GetUnsafeReadOnlyPtr<int>(), bounds.GetUnsafeReadOnlyPtr<Bounds>(), length);
  }

  public static unsafe void SetBoneTransformsArray(
    Il2CppReferenceArray<SpriteRenderer> spriteRenderers,
    NativeArray<System.IntPtr> buffers,
    NativeArray<int> bufferSizes,
    NativeArray<Bounds> bounds)
  {
    int length = ((Il2CppArrayBase) spriteRenderers).Length;
    if (length != ((NativeArray<System.IntPtr>) ref buffers).Length || length != ((NativeArray<int>) ref bufferSizes).Length || length != ((NativeArray<Bounds>) ref bounds).Length)
      throw new Il2CppSystem.ArgumentException("Input array sizes are not the same.");
    SpriteRendererDataAccessExtensions.SetBoneTransformsArray(spriteRenderers, buffers.GetUnsafeReadOnlyPtr<System.IntPtr>(), bufferSizes.GetUnsafeReadOnlyPtr<int>(), bounds.GetUnsafeReadOnlyPtr<Bounds>(), length);
  }

  public static unsafe bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, System.IntPtr buffer)
  {
    return SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer(spriteRenderer, (void*) buffer);
  }

  public static unsafe void SetBoneTransforms(
    SpriteRenderer spriteRenderer,
    NativeArray<Matrix4x4> src)
  {
    SpriteRendererDataAccessExtensions.SetBoneTransforms(spriteRenderer, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), ((NativeArray<Matrix4x4>) ref src).Length);
  }

  public static void DeactivateDeformableBuffer(SpriteRenderer renderer)
  {
    if (renderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    System.IntPtr renderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(renderer);
    if (renderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    SpriteRendererDataAccessExtensions.DeactivateDeformableBuffer_Injected(renderer1);
  }

  public static void SetLocalAABB(SpriteRenderer renderer, Bounds aabb)
  {
    if (renderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    System.IntPtr renderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(renderer);
    if (renderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) renderer, nameof (renderer));
    SpriteRendererDataAccessExtensions.SetLocalAABB_Injected(renderer1, ref aabb);
  }

  public static unsafe void SetDeformableBuffer(
    SpriteRenderer spriteRenderer,
    void* src,
    int count)
  {
    if (spriteRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    System.IntPtr spriteRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(spriteRenderer);
    if (spriteRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    SpriteRendererDataAccessExtensions.SetDeformableBuffer_Injected(spriteRenderer1, src, count);
  }

  public static unsafe void SetBatchDeformableBufferAndLocalAABBArray(
    Il2CppReferenceArray<SpriteRenderer> spriteRenderers,
    void* buffers,
    void* bufferSizes,
    void* bounds,
    int count)
  {
    SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spriteRenderers), (System.IntPtr) buffers, (System.IntPtr) bufferSizes, (System.IntPtr) bounds, count);
  }

  public static unsafe bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, void* buffer)
  {
    if (spriteRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    System.IntPtr spriteRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(spriteRenderer);
    if (spriteRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    return SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer_Injected(spriteRenderer1, buffer);
  }

  public static unsafe void SetBoneTransforms(SpriteRenderer spriteRenderer, void* src, int count)
  {
    if (spriteRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    System.IntPtr spriteRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(spriteRenderer);
    if (spriteRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    SpriteRendererDataAccessExtensions.SetBoneTransforms_Injected(spriteRenderer1, src, count);
  }

  public static unsafe void SetBoneTransformsArray(
    Il2CppReferenceArray<SpriteRenderer> spriteRenderers,
    void* buffers,
    void* bufferSizes,
    void* bounds,
    int count)
  {
    SpriteRendererDataAccessExtensions.SetBoneTransformsArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spriteRenderers), (System.IntPtr) buffers, (System.IntPtr) bufferSizes, (System.IntPtr) bounds, count);
  }

  public static void SetupMaterialProperties(SpriteRenderer spriteRenderer)
  {
    if (spriteRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    System.IntPtr spriteRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(spriteRenderer);
    if (spriteRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    SpriteRendererDataAccessExtensions.SetupMaterialProperties_Injected(spriteRenderer1);
  }

  public static bool IsGPUSkinningEnabled()
  {
    return SpriteRendererDataAccessExtensions.IsGPUSkinningEnabledDelegateField();
  }

  public static bool IsSRPBatchingEnabled(SpriteRenderer spriteRenderer)
  {
    if (spriteRenderer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    System.IntPtr spriteRenderer1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteRenderer>(spriteRenderer);
    if (spriteRenderer1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) spriteRenderer, nameof (spriteRenderer));
    return SpriteRendererDataAccessExtensions.IsSRPBatchingEnabled_Injected(spriteRenderer1);
  }

  public static void DeactivateDeformableBuffer_Injected(System.IntPtr renderer)
  {
    SpriteRendererDataAccessExtensions.DeactivateDeformableBuffer_InjectedDelegateField(renderer);
  }

  public static void SetLocalAABB_Injected(System.IntPtr renderer, [In] ref Bounds aabb)
  {
    SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegateField(renderer, (System.IntPtr) ref aabb);
  }

  public static unsafe void SetDeformableBuffer_Injected(
    System.IntPtr spriteRenderer,
    void* src,
    int count)
  {
    SpriteRendererDataAccessExtensions.SetDeformableBuffer_InjectedDelegateField(spriteRenderer, (System.IntPtr) src, count);
  }

  public static unsafe bool IsUsingDeformableBuffer_Injected(System.IntPtr spriteRenderer, void* buffer)
  {
    return SpriteRendererDataAccessExtensions.IsUsingDeformableBuffer_InjectedDelegateField(spriteRenderer, (System.IntPtr) buffer);
  }

  public static unsafe void SetBoneTransforms_Injected(System.IntPtr spriteRenderer, void* src, int count)
  {
    SpriteRendererDataAccessExtensions.SetBoneTransforms_InjectedDelegateField(spriteRenderer, (System.IntPtr) src, count);
  }

  public static void SetupMaterialProperties_Injected(System.IntPtr spriteRenderer)
  {
    SpriteRendererDataAccessExtensions.SetupMaterialProperties_InjectedDelegateField(spriteRenderer);
  }

  public static bool IsSRPBatchingEnabled_Injected(System.IntPtr spriteRenderer)
  {
    return SpriteRendererDataAccessExtensions.IsSRPBatchingEnabled_InjectedDelegateField(spriteRenderer);
  }

  private delegate void SetBatchDeformableBufferAndLocalAABBArrayDelegate(
    System.IntPtr spriteRenderers,
    System.IntPtr buffers,
    System.IntPtr bufferSizes,
    System.IntPtr bounds,
    int count);

  private delegate void SetBoneTransformsArrayDelegate(
    System.IntPtr spriteRenderers,
    System.IntPtr buffers,
    System.IntPtr bufferSizes,
    System.IntPtr bounds,
    int count);

  private delegate bool IsGPUSkinningEnabledDelegate();

  private delegate void DeactivateDeformableBuffer_InjectedDelegate(System.IntPtr renderer);

  private delegate void SetLocalAABB_InjectedDelegate(System.IntPtr renderer, [In] System.IntPtr aabb);

  private delegate void SetDeformableBuffer_InjectedDelegate(
    System.IntPtr spriteRenderer,
    System.IntPtr src,
    int count);

  private delegate bool IsUsingDeformableBuffer_InjectedDelegate(
    System.IntPtr spriteRenderer,
    System.IntPtr buffer);

  private delegate void SetBoneTransforms_InjectedDelegate(
    System.IntPtr spriteRenderer,
    System.IntPtr src,
    int count);

  private delegate void SetupMaterialProperties_InjectedDelegate(System.IntPtr spriteRenderer);

  private delegate bool IsSRPBatchingEnabled_InjectedDelegate(System.IntPtr spriteRenderer);
}
