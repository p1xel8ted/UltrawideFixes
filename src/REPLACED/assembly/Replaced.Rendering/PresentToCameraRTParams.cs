// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PresentToCameraRTParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class PresentToCameraRTParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_filmGrain;
  private static readonly System.IntPtr NativeFieldInfoPtr_lensDistortion;
  private static readonly System.IntPtr NativeFieldInfoPtr_vignette;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeFilmGrainParams_Private_Static_FilmGrainParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeLensDistortionParams_Private_Static_LensDistortionParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVignetteParams_Private_Static_VignetteParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CoreParams_0;

  static PresentToCameraRTParams()
  {
    Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PresentToCameraRTParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr);
    PresentToCameraRTParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, nameof (on));
    PresentToCameraRTParams.NativeFieldInfoPtr_filmGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, nameof (filmGrain));
    PresentToCameraRTParams.NativeFieldInfoPtr_lensDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, nameof (lensDistortion));
    PresentToCameraRTParams.NativeFieldInfoPtr_vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, nameof (vignette));
    PresentToCameraRTParams.NativeMethodInfoPtr_MakeFilmGrainParams_Private_Static_FilmGrainParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, 100663645);
    PresentToCameraRTParams.NativeMethodInfoPtr_MakeLensDistortionParams_Private_Static_LensDistortionParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, 100663646);
    PresentToCameraRTParams.NativeMethodInfoPtr_MakeVignetteParams_Private_Static_VignetteParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, 100663647);
    PresentToCameraRTParams.NativeMethodInfoPtr__ctor_Public_Void_CoreParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr, 100663648 /*0x06000160*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927062, RefRangeEnd = 927063, XrefRangeStart = 927052, XrefRangeEnd = 927062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FilmGrainParams MakeFilmGrainParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTParams.NativeMethodInfoPtr_MakeFilmGrainParams_Private_Static_FilmGrainParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new FilmGrainParams(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927063, XrefRangeEnd = 927066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LensDistortionParams MakeLensDistortionParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTParams.NativeMethodInfoPtr_MakeLensDistortionParams_Private_Static_LensDistortionParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LensDistortionParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927066, XrefRangeEnd = 927069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe VignetteParams MakeVignetteParams(bool makeDefault, VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTParams.NativeMethodInfoPtr_MakeVignetteParams_Private_Static_VignetteParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(VignetteParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927082, RefRangeEnd = 927083, XrefRangeStart = 927069, XrefRangeEnd = 927082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresentToCameraRTParams(CoreParams coreParams)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &coreParams
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTParams.NativeMethodInfoPtr__ctor_Public_Void_CoreParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PresentToCameraRTParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PresentToCameraRTParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresentToCameraRTParams>.NativeClassPtr))
  {
  }

  public unsafe bool on
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_on));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_on)) = value;
    }
  }

  public FilmGrainParams filmGrain
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_filmGrain);
      return new FilmGrainParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_filmGrain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe LensDistortionParams lensDistortion
  {
    get
    {
      return *(LensDistortionParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_lensDistortion));
    }
    [param: In] set
    {
      *(LensDistortionParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_lensDistortion)) = value;
    }
  }

  public unsafe VignetteParams vignette
  {
    get
    {
      return *(VignetteParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_vignette));
    }
    [param: In] set
    {
      *(VignetteParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTParams.NativeFieldInfoPtr_vignette)) = value;
    }
  }
}
