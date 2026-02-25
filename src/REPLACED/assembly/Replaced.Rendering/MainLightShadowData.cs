// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MainLightShadowData
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class MainLightShadowData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowMapResolution;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadeCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadeSplitRatio;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightDir;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadesProjectionView;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadesProjectionOld;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadesView;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadesBiases;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadesSplitData;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadedProjectionViewReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset0;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset1;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric0;
  private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric1;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowTint;

  static MainLightShadowData()
  {
    Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MainLightShadowData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr);
    MainLightShadowData.NativeFieldInfoPtr_visibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (visibleLightIndex));
    MainLightShadowData.NativeFieldInfoPtr_shadowMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (shadowMapResolution));
    MainLightShadowData.NativeFieldInfoPtr_cascadeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadeCount));
    MainLightShadowData.NativeFieldInfoPtr_cascadeSplitRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadeSplitRatio));
    MainLightShadowData.NativeFieldInfoPtr_lightDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (lightDir));
    MainLightShadowData.NativeFieldInfoPtr_cascadesProjectionView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadesProjectionView));
    MainLightShadowData.NativeFieldInfoPtr_cascadesProjectionOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadesProjectionOld));
    MainLightShadowData.NativeFieldInfoPtr_cascadesView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadesView));
    MainLightShadowData.NativeFieldInfoPtr_cascadesBiases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadesBiases));
    MainLightShadowData.NativeFieldInfoPtr_cascadesSplitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadesSplitData));
    MainLightShadowData.NativeFieldInfoPtr_cascadedProjectionViewReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (cascadedProjectionViewReceiver));
    MainLightShadowData.NativeFieldInfoPtr_uvOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (uvOffset0));
    MainLightShadowData.NativeFieldInfoPtr_uvOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (uvOffset1));
    MainLightShadowData.NativeFieldInfoPtr_uvOffsetVolumetric0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (uvOffsetVolumetric0));
    MainLightShadowData.NativeFieldInfoPtr_uvOffsetVolumetric1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (uvOffsetVolumetric1));
    MainLightShadowData.NativeFieldInfoPtr_shadowTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr, nameof (shadowTint));
  }

  public MainLightShadowData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public MainLightShadowData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainLightShadowData>.NativeClassPtr))
  {
  }

  public unsafe int visibleLightIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_visibleLightIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_visibleLightIndex)) = value;
    }
  }

  public unsafe int shadowMapResolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_shadowMapResolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_shadowMapResolution)) = value;
    }
  }

  public unsafe int cascadeCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadeCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadeCount)) = value;
    }
  }

  public unsafe Vector3 cascadeSplitRatio
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadeSplitRatio));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadeSplitRatio)) = value;
    }
  }

  public unsafe Vector3 lightDir
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_lightDir));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_lightDir)) = value;
    }
  }

  public unsafe Il2CppStructArray<Matrix4x4> cascadesProjectionView
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesProjectionView));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Matrix4x4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesProjectionView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Matrix4x4> cascadesProjectionOld
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesProjectionOld));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Matrix4x4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesProjectionOld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Matrix4x4> cascadesView
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesView));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Matrix4x4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector4> cascadesBiases
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesBiases));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesBiases), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<ShadowSplitData> cascadesSplitData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesSplitData));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ShadowSplitData>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShadowSplitData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadesSplitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Matrix4x4> cascadedProjectionViewReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadedProjectionViewReceiver));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Matrix4x4>) null : Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_cascadedProjectionViewReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4 uvOffset0
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffset0));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffset0)) = value;
    }
  }

  public unsafe Vector4 uvOffset1
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffset1));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffset1)) = value;
    }
  }

  public unsafe Vector4 uvOffsetVolumetric0
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffsetVolumetric0));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffsetVolumetric0)) = value;
    }
  }

  public unsafe Vector4 uvOffsetVolumetric1
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffsetVolumetric1));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_uvOffsetVolumetric1)) = value;
    }
  }

  public unsafe Vector4 shadowTint
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_shadowTint));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainLightShadowData.NativeFieldInfoPtr_shadowTint)) = value;
    }
  }
}
