// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.SpriteDataAccessExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.U2D;

public static class SpriteDataAccessExtensions
{
  private static readonly SpriteDataAccessExtensions.HasVertexAttribute_InjectedDelegate HasVertexAttribute_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.HasVertexAttribute_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::HasVertexAttribute_Injected");
  private static readonly SpriteDataAccessExtensions.SetVertexCount_InjectedDelegate SetVertexCount_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetVertexCount_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount_Injected");
  private static readonly SpriteDataAccessExtensions.GetVertexCount_InjectedDelegate GetVertexCount_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetVertexCount_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetVertexCount_Injected");
  private static readonly SpriteDataAccessExtensions.SetBindPoseData_InjectedDelegate SetBindPoseData_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBindPoseData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData_Injected");
  private static readonly SpriteDataAccessExtensions.SetIndicesData_InjectedDelegate SetIndicesData_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetIndicesData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData_Injected");
  private static readonly SpriteDataAccessExtensions.SetChannelData_InjectedDelegate SetChannelData_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetChannelData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData_Injected");
  private static readonly SpriteDataAccessExtensions.GetBoneInfo_InjectedDelegate GetBoneInfo_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBoneInfo_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBoneInfo_Injected");
  private static readonly SpriteDataAccessExtensions.SetBoneData_InjectedDelegate SetBoneData_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBoneData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData_Injected");
  private static readonly SpriteDataAccessExtensions.GetPrimaryVertexStreamSize_InjectedDelegate GetPrimaryVertexStreamSize_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetPrimaryVertexStreamSize_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetPrimaryVertexStreamSize_Injected");

  public static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel)
  {
    bool flag;
    switch (channel)
    {
      case VertexAttribute.Position:
      case VertexAttribute.Normal:
        flag = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector3>());
        break;
      case VertexAttribute.Tangent:
        flag = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector4>());
        break;
      case VertexAttribute.Color:
        flag = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color32>());
        break;
      case VertexAttribute.TexCoord0:
      case VertexAttribute.TexCoord1:
      case VertexAttribute.TexCoord2:
      case VertexAttribute.TexCoord3:
      case VertexAttribute.TexCoord4:
      case VertexAttribute.TexCoord5:
      case VertexAttribute.TexCoord6:
      case VertexAttribute.TexCoord7:
        flag = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector2>());
        break;
      case VertexAttribute.BlendWeight:
        flag = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<BoneWeight>());
        break;
      default:
        throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("The requested channel '{0}' is unknown.", (Il2CppSystem.Object) (System.Enum) channel));
    }
    if (!flag)
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("The requested channel '{0}' does not match the return type {1}.", (Il2CppSystem.Object) (System.Enum) channel, (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).Name));
  }

  public static NativeSlice<T> GetVertexAttribute<T>(Sprite sprite, VertexAttribute channel) where T : struct
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe void SetVertexAttribute<T>(
    Sprite sprite,
    VertexAttribute channel,
    NativeArray<T> src)
    where T : struct
  {
    SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
    SpriteDataAccessExtensions.SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr<T>());
  }

  public static NativeArray<Matrix4x4> GetBindPoses(Sprite sprite)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe void SetBindPoses(Sprite sprite, NativeArray<Matrix4x4> src)
  {
    SpriteDataAccessExtensions.SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), ((NativeArray<Matrix4x4>) ref src).Length);
  }

  public static NativeArray<ushort> GetIndices(Sprite sprite)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe void SetIndices(Sprite sprite, NativeArray<ushort> src)
  {
    SpriteDataAccessExtensions.SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr<ushort>(), ((NativeArray<ushort>) ref src).Length);
  }

  public static Il2CppReferenceArray<SpriteBone> GetBones(Sprite sprite)
  {
    return SpriteDataAccessExtensions.GetBoneInfo(sprite);
  }

  public static void SetBones(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
  {
    SpriteDataAccessExtensions.SetBoneData(sprite, src);
  }

  public static bool HasVertexAttribute(Sprite sprite, VertexAttribute channel)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    return SpriteDataAccessExtensions.HasVertexAttribute_Injected(sprite1, channel);
  }

  public static void SetVertexCount(Sprite sprite, int count)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    SpriteDataAccessExtensions.SetVertexCount_Injected(sprite1, count);
  }

  public static int GetVertexCount(Sprite sprite)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    return SpriteDataAccessExtensions.GetVertexCount_Injected(sprite1);
  }

  public static unsafe void SetBindPoseData(Sprite sprite, void* src, int count)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    SpriteDataAccessExtensions.SetBindPoseData_Injected(sprite1, src, count);
  }

  public static unsafe void SetIndicesData(Sprite sprite, void* src, int count)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    SpriteDataAccessExtensions.SetIndicesData_Injected(sprite1, src, count);
  }

  public static unsafe void SetChannelData(Sprite sprite, VertexAttribute channel, void* src)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    SpriteDataAccessExtensions.SetChannelData_Injected(sprite1, channel, src);
  }

  public static Il2CppReferenceArray<SpriteBone> GetBoneInfo(Sprite sprite)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    return SpriteDataAccessExtensions.GetBoneInfo_Injected(sprite1);
  }

  public static void SetBoneData(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
  {
    if (sprite == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    System.IntPtr sprite1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Sprite>(sprite);
    if (sprite1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sprite, nameof (sprite));
    SpriteDataAccessExtensions.SetBoneData_Injected(sprite1, src);
  }

  public static int GetPrimaryVertexStreamSize(Sprite sprite)
  {
    return SpriteDataAccessExtensions.GetPrimaryVertexStreamSize_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<Sprite>(sprite));
  }

  public static bool HasVertexAttribute_Injected(System.IntPtr sprite, VertexAttribute channel)
  {
    return SpriteDataAccessExtensions.HasVertexAttribute_InjectedDelegateField(sprite, channel);
  }

  public static void SetVertexCount_Injected(System.IntPtr sprite, int count)
  {
    SpriteDataAccessExtensions.SetVertexCount_InjectedDelegateField(sprite, count);
  }

  public static int GetVertexCount_Injected(System.IntPtr sprite)
  {
    return SpriteDataAccessExtensions.GetVertexCount_InjectedDelegateField(sprite);
  }

  public static unsafe void SetBindPoseData_Injected(System.IntPtr sprite, void* src, int count)
  {
    SpriteDataAccessExtensions.SetBindPoseData_InjectedDelegateField(sprite, (System.IntPtr) src, count);
  }

  public static unsafe void SetIndicesData_Injected(System.IntPtr sprite, void* src, int count)
  {
    SpriteDataAccessExtensions.SetIndicesData_InjectedDelegateField(sprite, (System.IntPtr) src, count);
  }

  public static unsafe void SetChannelData_Injected(
    System.IntPtr sprite,
    VertexAttribute channel,
    void* src)
  {
    SpriteDataAccessExtensions.SetChannelData_InjectedDelegateField(sprite, channel, (System.IntPtr) src);
  }

  public static Il2CppReferenceArray<SpriteBone> GetBoneInfo_Injected(System.IntPtr sprite)
  {
    System.IntPtr num = SpriteDataAccessExtensions.GetBoneInfo_InjectedDelegateField(sprite);
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SpriteBone>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(num);
  }

  public static void SetBoneData_Injected(System.IntPtr sprite, Il2CppReferenceArray<SpriteBone> src)
  {
    SpriteDataAccessExtensions.SetBoneData_InjectedDelegateField(sprite, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src));
  }

  public static int GetPrimaryVertexStreamSize_Injected(System.IntPtr sprite)
  {
    return SpriteDataAccessExtensions.GetPrimaryVertexStreamSize_InjectedDelegateField(sprite);
  }

  private delegate bool HasVertexAttribute_InjectedDelegate(System.IntPtr sprite, VertexAttribute channel);

  private delegate void SetVertexCount_InjectedDelegate(System.IntPtr sprite, int count);

  private delegate int GetVertexCount_InjectedDelegate(System.IntPtr sprite);

  private delegate void SetBindPoseData_InjectedDelegate(System.IntPtr sprite, System.IntPtr src, int count);

  private delegate void SetIndicesData_InjectedDelegate(System.IntPtr sprite, System.IntPtr src, int count);

  private delegate void SetChannelData_InjectedDelegate(
    System.IntPtr sprite,
    VertexAttribute channel,
    System.IntPtr src);

  private delegate System.IntPtr GetBoneInfo_InjectedDelegate(System.IntPtr sprite);

  private delegate void SetBoneData_InjectedDelegate(System.IntPtr sprite, System.IntPtr src);

  private delegate int GetPrimaryVertexStreamSize_InjectedDelegate(System.IntPtr sprite);
}
