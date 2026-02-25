// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.AmbientCube
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class AmbientCube(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_leftColor;
  private static readonly IntPtr NativeFieldInfoPtr_rightColor;
  private static readonly IntPtr NativeFieldInfoPtr_bottomColor;
  private static readonly IntPtr NativeFieldInfoPtr_topColor;
  private static readonly IntPtr NativeFieldInfoPtr_frontColor;
  private static readonly IntPtr NativeFieldInfoPtr_backColor;
  private static readonly IntPtr NativeFieldInfoPtr_intensityMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_volumetricIntensityMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_dependsOnDirection;
  private static readonly IntPtr NativeFieldInfoPtr_dirRotation;
  private static readonly IntPtr NativeFieldInfoPtr_minMaxIntensity;
  private static readonly IntPtr NativeMethodInfoPtr_GetConstantDirectionWs_Public_Static_Vector3_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AmbientCube()
  {
    Il2CppClassPointerStore<AmbientCube>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (AmbientCube));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr);
    AmbientCube.NativeFieldInfoPtr_leftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (leftColor));
    AmbientCube.NativeFieldInfoPtr_rightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (rightColor));
    AmbientCube.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (bottomColor));
    AmbientCube.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (topColor));
    AmbientCube.NativeFieldInfoPtr_frontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (frontColor));
    AmbientCube.NativeFieldInfoPtr_backColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (backColor));
    AmbientCube.NativeFieldInfoPtr_intensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (intensityMultiplier));
    AmbientCube.NativeFieldInfoPtr_volumetricIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (volumetricIntensityMultiplier));
    AmbientCube.NativeFieldInfoPtr_dependsOnDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (dependsOnDirection));
    AmbientCube.NativeFieldInfoPtr_dirRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (dirRotation));
    AmbientCube.NativeFieldInfoPtr_minMaxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, nameof (minMaxIntensity));
    AmbientCube.NativeMethodInfoPtr_GetConstantDirectionWs_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, 100663573);
    AmbientCube.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr, 100663574);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926304, XrefRangeEnd = 926310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetConstantDirectionWs(Vector2 rotXY)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &rotXY
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AmbientCube.NativeMethodInfoPtr_GetConstantDirectionWs_Public_Static_Vector3_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926310, XrefRangeEnd = 926351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AmbientCube()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientCube>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AmbientCube.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ColorParameter leftColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_leftColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_leftColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter rightColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_rightColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_rightColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter bottomColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_bottomColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_bottomColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter topColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_topColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_topColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter frontColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_frontColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_frontColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter backColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_backColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_backColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter intensityMultiplier
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_intensityMultiplier));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_intensityMultiplier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter volumetricIntensityMultiplier
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_volumetricIntensityMultiplier));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_volumetricIntensityMultiplier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter dependsOnDirection
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_dependsOnDirection));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_dependsOnDirection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Parameter dirRotation
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_dirRotation));
      return num == IntPtr.Zero ? (Vector2Parameter) null : Il2CppObjectPool.Get<Vector2Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_dirRotation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatRangeParameter minMaxIntensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_minMaxIntensity));
      return num == IntPtr.Zero ? (FloatRangeParameter) null : Il2CppObjectPool.Get<FloatRangeParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbientCube.NativeFieldInfoPtr_minMaxIntensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
