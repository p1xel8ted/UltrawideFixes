// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PunctualLightTexShadowMapData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class PunctualLightTexShadowMapData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowMapCacheKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionView;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionOld;
  private static readonly System.IntPtr NativeFieldInfoPtr_view;
  private static readonly System.IntPtr NativeFieldInfoPtr_biasValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightDir;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitData;

  static PunctualLightTexShadowMapData()
  {
    Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PunctualLightTexShadowMapData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr);
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_visibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (visibleLightIndex));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_shadowMapCacheKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (shadowMapCacheKey));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_projectionView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (projectionView));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_projectionOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (projectionOld));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (view));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_biasValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (biasValues));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_lightDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (lightDir));
    PunctualLightTexShadowMapData.NativeFieldInfoPtr_splitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr, nameof (splitData));
  }

  public PunctualLightTexShadowMapData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PunctualLightTexShadowMapData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunctualLightTexShadowMapData>.NativeClassPtr))
  {
  }

  public unsafe int visibleLightIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_visibleLightIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_visibleLightIndex)) = value;
    }
  }

  public Il2CppSystem.Nullable<ulong> shadowMapCacheKey
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_shadowMapCacheKey);
      return new Il2CppSystem.Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_shadowMapCacheKey), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Matrix4x4 projectionView
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_projectionView));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_projectionView)) = value;
    }
  }

  public unsafe Matrix4x4 projectionOld
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_projectionOld));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_projectionOld)) = value;
    }
  }

  public unsafe Matrix4x4 view
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_view));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_view)) = value;
    }
  }

  public unsafe Vector4 biasValues
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_biasValues));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_biasValues)) = value;
    }
  }

  public unsafe Vector3 lightDir
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_lightDir));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_lightDir)) = value;
    }
  }

  public unsafe ShadowSplitData splitData
  {
    get
    {
      return *(ShadowSplitData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_splitData));
    }
    [param: In] set
    {
      *(ShadowSplitData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PunctualLightTexShadowMapData.NativeFieldInfoPtr_splitData)) = value;
    }
  }
}
