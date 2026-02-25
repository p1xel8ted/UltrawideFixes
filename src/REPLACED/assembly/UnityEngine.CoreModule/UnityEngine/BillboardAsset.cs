// Decompiled with JetBrains decompiler
// Type: UnityEngine.BillboardAsset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class BillboardAsset : Object
{
  private static readonly BillboardAsset.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<BillboardAsset.Internal_CreateDelegate>("UnityEngine.BillboardAsset::Internal_Create");
  private static readonly BillboardAsset.get_width_InjectedDelegate get_width_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_width_InjectedDelegate>("UnityEngine.BillboardAsset::get_width_Injected");
  private static readonly BillboardAsset.set_width_InjectedDelegate set_width_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_width_InjectedDelegate>("UnityEngine.BillboardAsset::set_width_Injected");
  private static readonly BillboardAsset.get_height_InjectedDelegate get_height_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_height_InjectedDelegate>("UnityEngine.BillboardAsset::get_height_Injected");
  private static readonly BillboardAsset.set_height_InjectedDelegate set_height_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_height_InjectedDelegate>("UnityEngine.BillboardAsset::set_height_Injected");
  private static readonly BillboardAsset.get_bottom_InjectedDelegate get_bottom_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_bottom_InjectedDelegate>("UnityEngine.BillboardAsset::get_bottom_Injected");
  private static readonly BillboardAsset.set_bottom_InjectedDelegate set_bottom_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_bottom_InjectedDelegate>("UnityEngine.BillboardAsset::set_bottom_Injected");
  private static readonly BillboardAsset.get_imageCount_InjectedDelegate get_imageCount_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_imageCount_InjectedDelegate>("UnityEngine.BillboardAsset::get_imageCount_Injected");
  private static readonly BillboardAsset.get_vertexCount_InjectedDelegate get_vertexCount_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_vertexCount_InjectedDelegate>("UnityEngine.BillboardAsset::get_vertexCount_Injected");
  private static readonly BillboardAsset.get_indexCount_InjectedDelegate get_indexCount_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_indexCount_InjectedDelegate>("UnityEngine.BillboardAsset::get_indexCount_Injected");
  private static readonly BillboardAsset.get_material_InjectedDelegate get_material_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_material_InjectedDelegate>("UnityEngine.BillboardAsset::get_material_Injected");
  private static readonly BillboardAsset.set_material_InjectedDelegate set_material_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_material_InjectedDelegate>("UnityEngine.BillboardAsset::set_material_Injected");
  private static readonly BillboardAsset.GetImageTexCoords_InjectedDelegate GetImageTexCoords_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoords_InjectedDelegate>("UnityEngine.BillboardAsset::GetImageTexCoords_Injected");
  private static readonly BillboardAsset.GetImageTexCoordsInternal_InjectedDelegate GetImageTexCoordsInternal_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsInternal_InjectedDelegate>("UnityEngine.BillboardAsset::GetImageTexCoordsInternal_Injected");
  private static readonly BillboardAsset.SetImageTexCoords_InjectedDelegate SetImageTexCoords_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoords_InjectedDelegate>("UnityEngine.BillboardAsset::SetImageTexCoords_Injected");
  private static readonly BillboardAsset.SetImageTexCoordsInternalList_InjectedDelegate SetImageTexCoordsInternalList_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsInternalList_InjectedDelegate>("UnityEngine.BillboardAsset::SetImageTexCoordsInternalList_Injected");
  private static readonly BillboardAsset.GetVertices_InjectedDelegate GetVertices_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVertices_InjectedDelegate>("UnityEngine.BillboardAsset::GetVertices_Injected");
  private static readonly BillboardAsset.GetVerticesInternal_InjectedDelegate GetVerticesInternal_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesInternal_InjectedDelegate>("UnityEngine.BillboardAsset::GetVerticesInternal_Injected");
  private static readonly BillboardAsset.SetVertices_InjectedDelegate SetVertices_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVertices_InjectedDelegate>("UnityEngine.BillboardAsset::SetVertices_Injected");
  private static readonly BillboardAsset.SetVerticesInternalList_InjectedDelegate SetVerticesInternalList_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesInternalList_InjectedDelegate>("UnityEngine.BillboardAsset::SetVerticesInternalList_Injected");
  private static readonly BillboardAsset.GetIndices_InjectedDelegate GetIndices_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndices_InjectedDelegate>("UnityEngine.BillboardAsset::GetIndices_Injected");
  private static readonly BillboardAsset.GetIndicesInternal_InjectedDelegate GetIndicesInternal_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesInternal_InjectedDelegate>("UnityEngine.BillboardAsset::GetIndicesInternal_Injected");
  private static readonly BillboardAsset.SetIndices_InjectedDelegate SetIndices_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndices_InjectedDelegate>("UnityEngine.BillboardAsset::SetIndices_Injected");
  private static readonly BillboardAsset.SetIndicesInternalList_InjectedDelegate SetIndicesInternalList_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesInternalList_InjectedDelegate>("UnityEngine.BillboardAsset::SetIndicesInternalList_Injected");
  private static readonly BillboardAsset.MakeMaterialProperties_InjectedDelegate MakeMaterialProperties_InjectedDelegateField = IL2CPP.ResolveICall<BillboardAsset.MakeMaterialProperties_InjectedDelegate>("UnityEngine.BillboardAsset::MakeMaterialProperties_Injected");

  public static void Internal_Create(BillboardAsset obj)
  {
    BillboardAsset.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj));
  }

  public float width
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return BillboardAsset.get_width_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.set_width_Injected(_unity_self, value);
    }
  }

  public float height
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return BillboardAsset.get_height_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.set_height_Injected(_unity_self, value);
    }
  }

  public float bottom
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return BillboardAsset.get_bottom_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.set_bottom_Injected(_unity_self, value);
    }
  }

  public int imageCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return BillboardAsset.get_imageCount_Injected(_unity_self);
    }
  }

  public int vertexCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return BillboardAsset.get_vertexCount_Injected(_unity_self);
    }
  }

  public int indexCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return BillboardAsset.get_indexCount_Injected(_unity_self);
    }
  }

  public Material material
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Material>(BillboardAsset.get_material_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.set_material_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Material>(value));
    }
  }

  public void GetImageTexCoords(List<Vector4> imageTexCoords)
  {
    if (imageTexCoords == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (imageTexCoords));
    this.GetImageTexCoordsInternal((Il2CppSystem.Object) imageTexCoords);
  }

  public Il2CppStructArray<Vector4> GetImageTexCoords()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Vector4> imageTexCoords;
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.GetImageTexCoords_Injected(_unity_self, out ret);
    }
    finally
    {
      Il2CppStructArray<Vector4> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Vector4>((Il2CppArrayBase<Vector4>&) ref il2CppStructArray);
      imageTexCoords = il2CppStructArray;
    }
    return imageTexCoords;
  }

  public void GetImageTexCoordsInternal(Il2CppSystem.Object list)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.GetImageTexCoordsInternal_Injected(_unity_self, list);
  }

  public void SetImageTexCoords(List<Vector4> imageTexCoords)
  {
    if (imageTexCoords == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (imageTexCoords));
    this.SetImageTexCoordsInternalList((Il2CppSystem.Object) imageTexCoords);
  }

  public unsafe void SetImageTexCoords(Il2CppStructArray<Vector4> imageTexCoords)
  {
    if (imageTexCoords == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) imageTexCoords, nameof (imageTexCoords));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<Vector4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector4>) ref span).\u002Ector((Il2CppArrayBase<Vector4>) imageTexCoords);
    fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper imageTexCoords1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector4>) ref span).Length);
      BillboardAsset.SetImageTexCoords_Injected(_unity_self, ref imageTexCoords1);
    }
  }

  public void SetImageTexCoordsInternalList(Il2CppSystem.Object list)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.SetImageTexCoordsInternalList_Injected(_unity_self, list);
  }

  public void GetVertices(List<Vector2> vertices)
  {
    if (vertices == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (vertices));
    this.GetVerticesInternal((Il2CppSystem.Object) vertices);
  }

  public Il2CppStructArray<Vector2> GetVertices()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Vector2> vertices;
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.GetVertices_Injected(_unity_self, out ret);
    }
    finally
    {
      Il2CppStructArray<Vector2> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Vector2>((Il2CppArrayBase<Vector2>&) ref il2CppStructArray);
      vertices = il2CppStructArray;
    }
    return vertices;
  }

  public void GetVerticesInternal(Il2CppSystem.Object list)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.GetVerticesInternal_Injected(_unity_self, list);
  }

  public void SetVertices(List<Vector2> vertices)
  {
    if (vertices == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (vertices));
    this.SetVerticesInternalList((Il2CppSystem.Object) vertices);
  }

  public unsafe void SetVertices(Il2CppStructArray<Vector2> vertices)
  {
    if (vertices == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) vertices, nameof (vertices));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<Vector2> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector2>) ref span).\u002Ector((Il2CppArrayBase<Vector2>) vertices);
    fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper vertices1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector2>) ref span).Length);
      BillboardAsset.SetVertices_Injected(_unity_self, ref vertices1);
    }
  }

  public void SetVerticesInternalList(Il2CppSystem.Object list)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.SetVerticesInternalList_Injected(_unity_self, list);
  }

  public void GetIndices(List<ushort> indices)
  {
    if (indices == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indices));
    this.GetIndicesInternal((Il2CppSystem.Object) indices);
  }

  public Il2CppStructArray<ushort> GetIndices()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<ushort> indices;
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardAsset.GetIndices_Injected(_unity_self, out ret);
    }
    finally
    {
      Il2CppStructArray<ushort> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<ushort>((Il2CppArrayBase<ushort>&) ref il2CppStructArray);
      indices = il2CppStructArray;
    }
    return indices;
  }

  public void GetIndicesInternal(Il2CppSystem.Object list)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.GetIndicesInternal_Injected(_unity_self, list);
  }

  public void SetIndices(List<ushort> indices)
  {
    if (indices == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (indices));
    this.SetIndicesInternalList((Il2CppSystem.Object) indices);
  }

  public unsafe void SetIndices(Il2CppStructArray<ushort> indices)
  {
    if (indices == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) indices, nameof (indices));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<ushort> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<ushort>) ref span).\u002Ector((Il2CppArrayBase<ushort>) indices);
    fixed (ushort* begin = &((Il2CppSystem.Span<ushort>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper indices1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<ushort>) ref span).Length);
      BillboardAsset.SetIndices_Injected(_unity_self, ref indices1);
    }
  }

  public void SetIndicesInternalList(Il2CppSystem.Object list)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.SetIndicesInternalList_Injected(_unity_self, list);
  }

  public void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardAsset>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    BillboardAsset.MakeMaterialProperties_Injected(_unity_self, properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), Object.MarshalledUnityObject.Marshal<Camera>(camera));
  }

  public static float get_width_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_width_InjectedDelegateField(_unity_self);
  }

  public static void set_width_Injected(System.IntPtr _unity_self, float value)
  {
    BillboardAsset.set_width_InjectedDelegateField(_unity_self, value);
  }

  public static float get_height_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_height_InjectedDelegateField(_unity_self);
  }

  public static void set_height_Injected(System.IntPtr _unity_self, float value)
  {
    BillboardAsset.set_height_InjectedDelegateField(_unity_self, value);
  }

  public static float get_bottom_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_bottom_InjectedDelegateField(_unity_self);
  }

  public static void set_bottom_Injected(System.IntPtr _unity_self, float value)
  {
    BillboardAsset.set_bottom_InjectedDelegateField(_unity_self, value);
  }

  public static int get_imageCount_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_imageCount_InjectedDelegateField(_unity_self);
  }

  public static int get_vertexCount_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_vertexCount_InjectedDelegateField(_unity_self);
  }

  public static int get_indexCount_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_indexCount_InjectedDelegateField(_unity_self);
  }

  public static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
  {
    return BillboardAsset.get_material_InjectedDelegateField(_unity_self);
  }

  public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    BillboardAsset.set_material_InjectedDelegateField(_unity_self, value);
  }

  public static void GetImageTexCoords_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    BillboardAsset.GetImageTexCoords_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void GetImageTexCoordsInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
  {
    BillboardAsset.GetImageTexCoordsInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list));
  }

  public static void SetImageTexCoords_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper imageTexCoords)
  {
    BillboardAsset.SetImageTexCoords_InjectedDelegateField(_unity_self, (System.IntPtr) ref imageTexCoords);
  }

  public static void SetImageTexCoordsInternalList_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
  {
    BillboardAsset.SetImageTexCoordsInternalList_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list));
  }

  public static void GetVertices_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    BillboardAsset.GetVertices_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void GetVerticesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
  {
    BillboardAsset.GetVerticesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list));
  }

  public static void SetVertices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper vertices)
  {
    BillboardAsset.SetVertices_InjectedDelegateField(_unity_self, (System.IntPtr) ref vertices);
  }

  public static void SetVerticesInternalList_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
  {
    BillboardAsset.SetVerticesInternalList_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list));
  }

  public static void GetIndices_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
  {
    BillboardAsset.GetIndices_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void GetIndicesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
  {
    BillboardAsset.GetIndicesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list));
  }

  public static void SetIndices_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper indices)
  {
    BillboardAsset.SetIndices_InjectedDelegateField(_unity_self, (System.IntPtr) ref indices);
  }

  public static void SetIndicesInternalList_Injected(System.IntPtr _unity_self, Il2CppSystem.Object list)
  {
    BillboardAsset.SetIndicesInternalList_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list));
  }

  public static void MakeMaterialProperties_Injected(
    System.IntPtr _unity_self,
    System.IntPtr properties,
    System.IntPtr camera)
  {
    BillboardAsset.MakeMaterialProperties_InjectedDelegateField(_unity_self, properties, camera);
  }

  private delegate void Internal_CreateDelegate(System.IntPtr obj);

  private delegate float get_width_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_width_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_height_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_height_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate float get_bottom_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_bottom_InjectedDelegate(System.IntPtr _unity_self, float value);

  private delegate int get_imageCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_vertexCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_indexCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr get_material_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

  private delegate void GetImageTexCoords_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void GetImageTexCoordsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

  private delegate void SetImageTexCoords_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr imageTexCoords);

  private delegate void SetImageTexCoordsInternalList_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr list);

  private delegate void GetVertices_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void GetVerticesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

  private delegate void SetVertices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr vertices);

  private delegate void SetVerticesInternalList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

  private delegate void GetIndices_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void GetIndicesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

  private delegate void SetIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices);

  private delegate void SetIndicesInternalList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr list);

  private delegate void MakeMaterialProperties_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr properties,
    System.IntPtr camera);
}
