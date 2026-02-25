// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DepthOfFieldParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class DepthOfFieldParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kMaxCocRadiusPixels;
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_focusFieldStartDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_focusFieldEndDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_foregroundTotalBlurDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundTotalBlurDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxCocRadiusUv;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxCocRadiusPixels;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundBlurBellFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_foregroundBlurBellFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_visualizeDistances;
  private static readonly System.IntPtr NativeFieldInfoPtr_enableBokeh;
  private static readonly System.IntPtr NativeFieldInfoPtr_lumaThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_texBokehShape;
  private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_bokehSizeMultiplierForeground;
  private static readonly System.IntPtr NativeFieldInfoPtr_cocDifferenceThresholdForeground;
  private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMultiplierForeground;
  private static readonly System.IntPtr NativeFieldInfoPtr_bokehSizeMultiplierBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_cocDifferenceThresholdBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMultiplierBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementThreshold0Min;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementThreshold0Max;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementThreshold1Min;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementThreshold1Max;
  private static readonly System.IntPtr NativeFieldInfoPtr_stabilization0;
  private static readonly System.IntPtr NativeFieldInfoPtr_stabilization1;
  private static readonly System.IntPtr NativeFieldInfoPtr_showBokehSprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugBokehColor;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Single_Int32_Single_Single_Boolean_Single_Texture_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Boolean_Vector4_0;

  static DepthOfFieldParams()
  {
    Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DepthOfFieldParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr);
    DepthOfFieldParams.NativeFieldInfoPtr_kMaxCocRadiusPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (kMaxCocRadiusPixels));
    DepthOfFieldParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (on));
    DepthOfFieldParams.NativeFieldInfoPtr_focusFieldStartDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (focusFieldStartDistance));
    DepthOfFieldParams.NativeFieldInfoPtr_focusFieldEndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (focusFieldEndDistance));
    DepthOfFieldParams.NativeFieldInfoPtr_foregroundTotalBlurDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (foregroundTotalBlurDistance));
    DepthOfFieldParams.NativeFieldInfoPtr_backgroundTotalBlurDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (backgroundTotalBlurDistance));
    DepthOfFieldParams.NativeFieldInfoPtr_maxCocRadiusUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (maxCocRadiusUv));
    DepthOfFieldParams.NativeFieldInfoPtr_maxCocRadiusPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (maxCocRadiusPixels));
    DepthOfFieldParams.NativeFieldInfoPtr_backgroundBlurBellFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (backgroundBlurBellFactor));
    DepthOfFieldParams.NativeFieldInfoPtr_foregroundBlurBellFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (foregroundBlurBellFactor));
    DepthOfFieldParams.NativeFieldInfoPtr_visualizeDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (visualizeDistances));
    DepthOfFieldParams.NativeFieldInfoPtr_enableBokeh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (enableBokeh));
    DepthOfFieldParams.NativeFieldInfoPtr_lumaThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (lumaThreshold));
    DepthOfFieldParams.NativeFieldInfoPtr_texBokehShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (texBokehShape));
    DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (bokehIntensityMin));
    DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (bokehIntensityMax));
    DepthOfFieldParams.NativeFieldInfoPtr_bokehSizeMultiplierForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (bokehSizeMultiplierForeground));
    DepthOfFieldParams.NativeFieldInfoPtr_cocDifferenceThresholdForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (cocDifferenceThresholdForeground));
    DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMultiplierForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (bokehIntensityMultiplierForeground));
    DepthOfFieldParams.NativeFieldInfoPtr_bokehSizeMultiplierBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (bokehSizeMultiplierBackground));
    DepthOfFieldParams.NativeFieldInfoPtr_cocDifferenceThresholdBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (cocDifferenceThresholdBackground));
    DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMultiplierBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (bokehIntensityMultiplierBackground));
    DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold0Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (movementThreshold0Min));
    DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold0Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (movementThreshold0Max));
    DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold1Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (movementThreshold1Min));
    DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold1Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (movementThreshold1Max));
    DepthOfFieldParams.NativeFieldInfoPtr_stabilization0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (stabilization0));
    DepthOfFieldParams.NativeFieldInfoPtr_stabilization1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (stabilization1));
    DepthOfFieldParams.NativeFieldInfoPtr_showBokehSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (showBokehSprites));
    DepthOfFieldParams.NativeFieldInfoPtr_debugBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, nameof (debugBokehColor));
    DepthOfFieldParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Single_Int32_Single_Single_Boolean_Single_Texture_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Boolean_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, 100663637);
  }

  [CallerCount(0)]
  public unsafe DepthOfFieldParams(
    bool on,
    float focusFieldStartDistance,
    float focusFieldEndDistance,
    float foregroundTotalBlurDistance,
    float backgroundTotalBlurDistance,
    bool visualizeDistances,
    float maxCocRadiusUv,
    int maxCocRadiusPixels,
    float backgroundBlurBellFactor,
    float foregroundBlurBellFactor,
    bool enableBokeh,
    float lumaThreshold,
    Texture texBokehShape,
    float bokehIntensityMin,
    float bokehIntensityMax,
    float bokehSizeMultiplierForeground,
    float cocDifferenceThresholdForeground,
    float bokehIntensityMultiplierForeground,
    float bokehSizeMultiplierBackground,
    float cocDifferenceThresholdBackground,
    float bokehIntensityMultiplierBackground,
    float movementThreshold0Min,
    float movementThreshold0Max,
    float movementThreshold1Min,
    float movementThreshold1Max,
    float stabilization0,
    float stabilization1,
    bool showBokehSprites,
    Vector4 debugBokehColor)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[29];
    numPtr[0] = (System.IntPtr) &on;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &focusFieldStartDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &focusFieldEndDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &foregroundTotalBlurDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &backgroundTotalBlurDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &visualizeDistances;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxCocRadiusUv;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &maxCocRadiusPixels;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &backgroundBlurBellFactor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &foregroundBlurBellFactor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &enableBokeh;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &lumaThreshold;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texBokehShape);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &bokehIntensityMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = (System.IntPtr) &bokehIntensityMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &bokehSizeMultiplierForeground;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(16) * sizeof (System.IntPtr))) = (System.IntPtr) &cocDifferenceThresholdForeground;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(17) * sizeof (System.IntPtr))) = (System.IntPtr) &bokehIntensityMultiplierForeground;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(18) * sizeof (System.IntPtr))) = (System.IntPtr) &bokehSizeMultiplierBackground;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(19) * sizeof (System.IntPtr))) = (System.IntPtr) &cocDifferenceThresholdBackground;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(20) * sizeof (System.IntPtr))) = (System.IntPtr) &bokehIntensityMultiplierBackground;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(21) * sizeof (System.IntPtr))) = (System.IntPtr) &movementThreshold0Min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(22) * sizeof (System.IntPtr))) = (System.IntPtr) &movementThreshold0Max;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(23) * sizeof (System.IntPtr))) = (System.IntPtr) &movementThreshold1Min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(24) * sizeof (System.IntPtr))) = (System.IntPtr) &movementThreshold1Max;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(25) * sizeof (System.IntPtr))) = (System.IntPtr) &stabilization0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(26) * sizeof (System.IntPtr))) = (System.IntPtr) &stabilization1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(27) * sizeof (System.IntPtr))) = (System.IntPtr) &showBokehSprites;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(28) * sizeof (System.IntPtr))) = (System.IntPtr) &debugBokehColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthOfFieldParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Boolean_Single_Int32_Single_Single_Boolean_Single_Texture_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Boolean_Vector4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public DepthOfFieldParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public DepthOfFieldParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr))
  {
  }

  public static unsafe int kMaxCocRadiusPixels
  {
    get
    {
      int maxCocRadiusPixels;
      IL2CPP.il2cpp_field_static_get_value(DepthOfFieldParams.NativeFieldInfoPtr_kMaxCocRadiusPixels, (void*) &maxCocRadiusPixels);
      return maxCocRadiusPixels;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthOfFieldParams.NativeFieldInfoPtr_kMaxCocRadiusPixels, (void*) &value);
    }
  }

  public unsafe bool on
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_on));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_on)) = value;
    }
  }

  public unsafe float focusFieldStartDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_focusFieldStartDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_focusFieldStartDistance)) = value;
    }
  }

  public unsafe float focusFieldEndDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_focusFieldEndDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_focusFieldEndDistance)) = value;
    }
  }

  public unsafe float foregroundTotalBlurDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_foregroundTotalBlurDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_foregroundTotalBlurDistance)) = value;
    }
  }

  public unsafe float backgroundTotalBlurDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_backgroundTotalBlurDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_backgroundTotalBlurDistance)) = value;
    }
  }

  public unsafe float maxCocRadiusUv
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_maxCocRadiusUv));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_maxCocRadiusUv)) = value;
    }
  }

  public unsafe int maxCocRadiusPixels
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_maxCocRadiusPixels));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_maxCocRadiusPixels)) = value;
    }
  }

  public unsafe float backgroundBlurBellFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_backgroundBlurBellFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_backgroundBlurBellFactor)) = value;
    }
  }

  public unsafe float foregroundBlurBellFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_foregroundBlurBellFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_foregroundBlurBellFactor)) = value;
    }
  }

  public unsafe bool visualizeDistances
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_visualizeDistances));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_visualizeDistances)) = value;
    }
  }

  public unsafe bool enableBokeh
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_enableBokeh));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_enableBokeh)) = value;
    }
  }

  public unsafe float lumaThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_lumaThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_lumaThreshold)) = value;
    }
  }

  public unsafe Texture texBokehShape
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_texBokehShape));
      return num == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_texBokehShape), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float bokehIntensityMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMin)) = value;
    }
  }

  public unsafe float bokehIntensityMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMax)) = value;
    }
  }

  public unsafe float bokehSizeMultiplierForeground
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehSizeMultiplierForeground));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehSizeMultiplierForeground)) = value;
    }
  }

  public unsafe float cocDifferenceThresholdForeground
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_cocDifferenceThresholdForeground));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_cocDifferenceThresholdForeground)) = value;
    }
  }

  public unsafe float bokehIntensityMultiplierForeground
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMultiplierForeground));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMultiplierForeground)) = value;
    }
  }

  public unsafe float bokehSizeMultiplierBackground
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehSizeMultiplierBackground));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehSizeMultiplierBackground)) = value;
    }
  }

  public unsafe float cocDifferenceThresholdBackground
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_cocDifferenceThresholdBackground));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_cocDifferenceThresholdBackground)) = value;
    }
  }

  public unsafe float bokehIntensityMultiplierBackground
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMultiplierBackground));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_bokehIntensityMultiplierBackground)) = value;
    }
  }

  public unsafe float movementThreshold0Min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold0Min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold0Min)) = value;
    }
  }

  public unsafe float movementThreshold0Max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold0Max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold0Max)) = value;
    }
  }

  public unsafe float movementThreshold1Min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold1Min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold1Min)) = value;
    }
  }

  public unsafe float movementThreshold1Max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold1Max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_movementThreshold1Max)) = value;
    }
  }

  public unsafe float stabilization0
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_stabilization0));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_stabilization0)) = value;
    }
  }

  public unsafe float stabilization1
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_stabilization1));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_stabilization1)) = value;
    }
  }

  public unsafe bool showBokehSprites
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_showBokehSprites));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_showBokehSprites)) = value;
    }
  }

  public unsafe Vector4 debugBokehColor
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_debugBokehColor));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthOfFieldParams.NativeFieldInfoPtr_debugBokehColor)) = value;
    }
  }
}
