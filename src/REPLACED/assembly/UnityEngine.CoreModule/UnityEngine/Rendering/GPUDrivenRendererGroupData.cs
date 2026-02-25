// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenRendererGroupData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class GPUDrivenRendererGroupData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_localBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapScaleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_packedRendererData;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshStartIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialsOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_instancesOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_instancesCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_editorData;
  private static readonly System.IntPtr NativeFieldInfoPtr_invalidRendererGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_prevLocalToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshID;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDescOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialID;
  private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialData;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialFilterFlags;

  static GPUDrivenRendererGroupData()
  {
    Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenRendererGroupData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr);
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (rendererGroupID));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_localBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (localBounds));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_lightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (lightmapScaleOffset));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_gameObjectLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (gameObjectLayer));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (renderingLayerMask));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (lodGroupID));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (lightmapIndex));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_packedRendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (packedRendererData));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (rendererPriority));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_meshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (meshIndex));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (subMeshStartIndex));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (materialsOffset));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (materialsCount));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_instancesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (instancesOffset));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (instancesCount));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_editorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (editorData));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_invalidRendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (invalidRendererGroupID));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (localToWorldMatrix));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_prevLocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (prevLocalToWorldMatrix));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererGroupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (rendererGroupIndex));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (meshID));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (subMeshCount));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshDescOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (subMeshDescOffset));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (subMeshDesc));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (materialIndex));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (materialID));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_packedMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (packedMaterialData));
    GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, nameof (materialFilterFlags));
  }

  public GPUDrivenRendererGroupData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public GPUDrivenRendererGroupData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr))
  {
  }

  public NativeArray<int> rendererGroupID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererGroupID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Bounds> localBounds
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_localBounds);
      return new NativeArray<Bounds>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_localBounds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Vector4> lightmapScaleOffset
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_lightmapScaleOffset);
      return new NativeArray<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_lightmapScaleOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> gameObjectLayer
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_gameObjectLayer);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_gameObjectLayer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<uint> renderingLayerMask
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_renderingLayerMask);
      return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_renderingLayerMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> lodGroupID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_lodGroupID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_lodGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> lightmapIndex
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_lightmapIndex);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_lightmapIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<GPUDrivenPackedRendererData> packedRendererData
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_packedRendererData);
      return new NativeArray<GPUDrivenPackedRendererData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedRendererData>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_packedRendererData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedRendererData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> rendererPriority
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererPriority);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererPriority), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> meshIndex
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_meshIndex);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_meshIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<short> subMeshStartIndex
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshStartIndex);
      return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshStartIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> materialsOffset
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialsOffset);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialsOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<short> materialsCount
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialsCount);
      return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialsCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> instancesOffset
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_instancesOffset);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_instancesOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> instancesCount
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_instancesCount);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_instancesCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<GPUDrivenRendererEditorData> editorData
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_editorData);
      return new NativeArray<GPUDrivenRendererEditorData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenRendererEditorData>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_editorData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenRendererEditorData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> invalidRendererGroupID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_invalidRendererGroupID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_invalidRendererGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Matrix4x4> localToWorldMatrix
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_localToWorldMatrix);
      return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_localToWorldMatrix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Matrix4x4> prevLocalToWorldMatrix
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_prevLocalToWorldMatrix);
      return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_prevLocalToWorldMatrix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> rendererGroupIndex
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererGroupIndex);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_rendererGroupIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> meshID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_meshID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_meshID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<short> subMeshCount
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshCount);
      return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> subMeshDescOffset
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshDescOffset);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshDescOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<SubMeshDescriptor> subMeshDesc
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshDesc);
      return new NativeArray<SubMeshDescriptor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SubMeshDescriptor>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_subMeshDesc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SubMeshDescriptor>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> materialIndex
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialIndex);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> materialID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<GPUDrivenPackedMaterialData> packedMaterialData
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_packedMaterialData);
      return new NativeArray<GPUDrivenPackedMaterialData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_packedMaterialData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> materialFilterFlags
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialFilterFlags);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenRendererGroupData.NativeFieldInfoPtr_materialFilterFlags), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
