// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LightingStageFrameStats
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class LightingStageFrameStats : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_directionalLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_cloudDirectionalLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_punctualLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_lineLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_spotlightWithPatternCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_directionalLightCastsShadows;
  private static readonly System.IntPtr NativeFieldInfoPtr_directionalLightShadowCascadeCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_pointLightWithShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_pointLightWithCacheableShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_spotlightWithShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_spotlightWithCacheableShadowCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_cacheMissRate01;

  static LightingStageFrameStats()
  {
    Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LightingStageFrameStats));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr);
    LightingStageFrameStats.NativeFieldInfoPtr_directionalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (directionalLightCount));
    LightingStageFrameStats.NativeFieldInfoPtr_cloudDirectionalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (cloudDirectionalLightCount));
    LightingStageFrameStats.NativeFieldInfoPtr_punctualLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (punctualLightCount));
    LightingStageFrameStats.NativeFieldInfoPtr_lineLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (lineLightCount));
    LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithPatternCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (spotlightWithPatternCount));
    LightingStageFrameStats.NativeFieldInfoPtr_directionalLightCastsShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (directionalLightCastsShadows));
    LightingStageFrameStats.NativeFieldInfoPtr_directionalLightShadowCascadeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (directionalLightShadowCascadeCount));
    LightingStageFrameStats.NativeFieldInfoPtr_pointLightWithShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (pointLightWithShadowCount));
    LightingStageFrameStats.NativeFieldInfoPtr_pointLightWithCacheableShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (pointLightWithCacheableShadowCount));
    LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (spotlightWithShadowCount));
    LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithCacheableShadowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (spotlightWithCacheableShadowCount));
    LightingStageFrameStats.NativeFieldInfoPtr_cacheMissRate01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr, nameof (cacheMissRate01));
  }

  public LightingStageFrameStats(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public LightingStageFrameStats()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingStageFrameStats>.NativeClassPtr))
  {
  }

  public unsafe int directionalLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_directionalLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_directionalLightCount)) = value;
    }
  }

  public unsafe int cloudDirectionalLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_cloudDirectionalLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_cloudDirectionalLightCount)) = value;
    }
  }

  public unsafe int punctualLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_punctualLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_punctualLightCount)) = value;
    }
  }

  public unsafe int lineLightCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_lineLightCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_lineLightCount)) = value;
    }
  }

  public unsafe int spotlightWithPatternCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithPatternCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithPatternCount)) = value;
    }
  }

  public unsafe bool directionalLightCastsShadows
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_directionalLightCastsShadows));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_directionalLightCastsShadows)) = value;
    }
  }

  public unsafe int directionalLightShadowCascadeCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_directionalLightShadowCascadeCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_directionalLightShadowCascadeCount)) = value;
    }
  }

  public unsafe int pointLightWithShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_pointLightWithShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_pointLightWithShadowCount)) = value;
    }
  }

  public unsafe int pointLightWithCacheableShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_pointLightWithCacheableShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_pointLightWithCacheableShadowCount)) = value;
    }
  }

  public unsafe int spotlightWithShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithShadowCount)) = value;
    }
  }

  public unsafe int spotlightWithCacheableShadowCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithCacheableShadowCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_spotlightWithCacheableShadowCount)) = value;
    }
  }

  public Il2CppSystem.Nullable<float> cacheMissRate01
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_cacheMissRate01);
      return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStageFrameStats.NativeFieldInfoPtr_cacheMissRate01), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
