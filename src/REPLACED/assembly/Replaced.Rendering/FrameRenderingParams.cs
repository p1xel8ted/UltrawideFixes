// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FrameRenderingParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class FrameRenderingParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_renderCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_coreParams;
  private static readonly System.IntPtr NativeFieldInfoPtr_camera;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_nonJitteredProjectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_nonJitteredProjectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerCharacterAabbWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_character;
  private static readonly System.IntPtr NativeFieldInfoPtr_celestialBody;
  private static readonly System.IntPtr NativeFieldInfoPtr_skyAndClouds;
  private static readonly System.IntPtr NativeFieldInfoPtr_ambientCube;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowMapping;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetric;
  private static readonly System.IntPtr NativeFieldInfoPtr_postProcessing;
  private static readonly System.IntPtr NativeFieldInfoPtr_pixelizationParams;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Private_Static_ValueTuple_2_Boolean_CullingResults_byref_ScriptableRenderContext_Camera_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeVector3FromLinearColor_Private_Static_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCharacterParams_Public_Static_CharacterParams_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCelestialBodyParams_Public_Static_CelestialBodyParams_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeSkyAndCloudsParams_Public_Static_SkyAndCloudsParams_VolumeStack_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeAmbientCubeParams_Private_Static_AmbientCubeParams_VolumeStack_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakePixelizationParams_Public_Static_PixelizationParams_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeGlobalIlluminationParams_Private_Static_GlobalIlluminationParams_VolumeStack_Boolean_AmbientCubeParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_CoreParams_byref_UserPreferences_Int32_Vector2Int_Transform_Bounds_0;

  static FrameRenderingParams()
  {
    Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FrameRenderingParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr);
    FrameRenderingParams.NativeFieldInfoPtr_renderCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (renderCamera));
    FrameRenderingParams.NativeFieldInfoPtr_coreParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (coreParams));
    FrameRenderingParams.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (camera));
    FrameRenderingParams.NativeFieldInfoPtr_renderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (renderTargetSize));
    FrameRenderingParams.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (viewMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (projectionMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (projectionViewMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_invProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (invProjectionMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (invProjectionViewMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (nonJitteredProjectionMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (nonJitteredProjectionViewMatrix));
    FrameRenderingParams.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (depthProjectionParams));
    FrameRenderingParams.NativeFieldInfoPtr_playerCharacterAabbWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (playerCharacterAabbWs));
    FrameRenderingParams.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (character));
    FrameRenderingParams.NativeFieldInfoPtr_celestialBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (celestialBody));
    FrameRenderingParams.NativeFieldInfoPtr_skyAndClouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (skyAndClouds));
    FrameRenderingParams.NativeFieldInfoPtr_ambientCube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (ambientCube));
    FrameRenderingParams.NativeFieldInfoPtr_globalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (globalIllumination));
    FrameRenderingParams.NativeFieldInfoPtr_shadowMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (shadowMapping));
    FrameRenderingParams.NativeFieldInfoPtr_cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (cullingResults));
    FrameRenderingParams.NativeFieldInfoPtr_volumetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (volumetric));
    FrameRenderingParams.NativeFieldInfoPtr_postProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (postProcessing));
    FrameRenderingParams.NativeFieldInfoPtr_pixelizationParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, nameof (pixelizationParams));
    FrameRenderingParams.NativeMethodInfoPtr_Cull_Private_Static_ValueTuple_2_Boolean_CullingResults_byref_ScriptableRenderContext_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663594);
    FrameRenderingParams.NativeMethodInfoPtr_MakeVector3FromLinearColor_Private_Static_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663595);
    FrameRenderingParams.NativeMethodInfoPtr_MakeCharacterParams_Public_Static_CharacterParams_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663596);
    FrameRenderingParams.NativeMethodInfoPtr_MakeCelestialBodyParams_Public_Static_CelestialBodyParams_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663597);
    FrameRenderingParams.NativeMethodInfoPtr_MakeSkyAndCloudsParams_Public_Static_SkyAndCloudsParams_VolumeStack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663598);
    FrameRenderingParams.NativeMethodInfoPtr_MakeAmbientCubeParams_Private_Static_AmbientCubeParams_VolumeStack_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663599);
    FrameRenderingParams.NativeMethodInfoPtr_MakePixelizationParams_Public_Static_PixelizationParams_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663600 /*0x06000130*/);
    FrameRenderingParams.NativeMethodInfoPtr_MakeGlobalIlluminationParams_Private_Static_GlobalIlluminationParams_VolumeStack_Boolean_AmbientCubeParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663601);
    FrameRenderingParams.NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_CoreParams_byref_UserPreferences_Int32_Vector2Int_Transform_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr, 100663602);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926644, XrefRangeEnd = 926651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.ValueTuple<bool, CullingResults> Cull(
    [In] ref ScriptableRenderContext ctx,
    Camera camera,
    float maxShadowDistance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxShadowDistance;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_Cull_Private_Static_ValueTuple_2_Boolean_CullingResults_byref_ScriptableRenderContext_Camera_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.ValueTuple<bool, CullingResults>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926651, XrefRangeEnd = 926654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 MakeVector3FromLinearColor(Color color, float multiplier)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiplier;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakeVector3FromLinearColor_Private_Static_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926663, RefRangeEnd = 926664, XrefRangeStart = 926654, XrefRangeEnd = 926663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CharacterParams MakeCharacterParams(VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakeCharacterParams_Public_Static_CharacterParams_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CharacterParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926670, RefRangeEnd = 926671, XrefRangeStart = 926664, XrefRangeEnd = 926670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CelestialBodyParams MakeCelestialBodyParams(VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakeCelestialBodyParams_Public_Static_CelestialBodyParams_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CelestialBodyParams(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926676, RefRangeEnd = 926678, XrefRangeStart = 926671, XrefRangeEnd = 926676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SkyAndCloudsParams MakeSkyAndCloudsParams(
    VolumeStack volumeStack,
    bool doFirmamentPass)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &doFirmamentPass;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakeSkyAndCloudsParams_Public_Static_SkyAndCloudsParams_VolumeStack_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new SkyAndCloudsParams(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926730, RefRangeEnd = 926731, XrefRangeStart = 926678, XrefRangeEnd = 926730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AmbientCubeParams MakeAmbientCubeParams(
    VolumeStack volumeStack,
    float mainIntensity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mainIntensity;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakeAmbientCubeParams_Private_Static_AmbientCubeParams_VolumeStack_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AmbientCubeParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926731, XrefRangeEnd = 926735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PixelizationParams MakePixelizationParams(VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakePixelizationParams_Public_Static_PixelizationParams_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PixelizationParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926762, RefRangeEnd = 926763, XrefRangeStart = 926735, XrefRangeEnd = 926762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GlobalIlluminationParams MakeGlobalIlluminationParams(
    VolumeStack volumeStack,
    bool doGlobalIllumination,
    AmbientCubeParams ac)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &doGlobalIllumination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ac;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr_MakeGlobalIlluminationParams_Private_Static_GlobalIlluminationParams_VolumeStack_Boolean_AmbientCubeParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GlobalIlluminationParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926822, RefRangeEnd = 926824, XrefRangeStart = 926763, XrefRangeEnd = 926822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FrameRenderingParams(
    [In] ref ScriptableRenderContext ctx,
    Camera camera,
    CoreParams coreParams,
    [In] ref UserPreferences userPreferences,
    int taaJitterIndex,
    Vector2Int previousViewportSize,
    Transform dofAutofocusTarget,
    Bounds playerCharacterAabbWs)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref userPreferences;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &taaJitterIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &previousViewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dofAutofocusTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &playerCharacterAabbWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameRenderingParams.NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_CoreParams_byref_UserPreferences_Int32_Vector2Int_Transform_Bounds_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public FrameRenderingParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public FrameRenderingParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameRenderingParams>.NativeClassPtr))
  {
  }

  public unsafe bool renderCamera
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_renderCamera));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_renderCamera)) = value;
    }
  }

  public unsafe CoreParams coreParams
  {
    get
    {
      return *(CoreParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_coreParams));
    }
    [param: In] set
    {
      *(CoreParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_coreParams)) = value;
    }
  }

  public unsafe Camera camera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_camera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int renderTargetSize
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_renderTargetSize));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_renderTargetSize)) = value;
    }
  }

  public unsafe Matrix4x4 viewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_viewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_viewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 projectionMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_projectionMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_projectionMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 projectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_projectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_projectionViewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 invProjectionMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_invProjectionMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_invProjectionMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 invProjectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_invProjectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_invProjectionViewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 nonJitteredProjectionMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 nonJitteredProjectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix)) = value;
    }
  }

  public unsafe Vector4 depthProjectionParams
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_depthProjectionParams));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_depthProjectionParams)) = value;
    }
  }

  public unsafe Bounds playerCharacterAabbWs
  {
    get
    {
      return *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_playerCharacterAabbWs));
    }
    [param: In] set
    {
      *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_playerCharacterAabbWs)) = value;
    }
  }

  public unsafe CharacterParams character
  {
    get
    {
      return *(CharacterParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_character));
    }
    [param: In] set
    {
      *(CharacterParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_character)) = value;
    }
  }

  public CelestialBodyParams celestialBody
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_celestialBody);
      return new CelestialBodyParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_celestialBody), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public SkyAndCloudsParams skyAndClouds
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_skyAndClouds);
      return new SkyAndCloudsParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_skyAndClouds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SkyAndCloudsParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe AmbientCubeParams ambientCube
  {
    get
    {
      return *(AmbientCubeParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_ambientCube));
    }
    [param: In] set
    {
      *(AmbientCubeParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_ambientCube)) = value;
    }
  }

  public unsafe GlobalIlluminationParams globalIllumination
  {
    get
    {
      return *(GlobalIlluminationParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_globalIllumination));
    }
    [param: In] set
    {
      *(GlobalIlluminationParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_globalIllumination)) = value;
    }
  }

  public unsafe ShadowMappingParams shadowMapping
  {
    get
    {
      return *(ShadowMappingParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_shadowMapping));
    }
    [param: In] set
    {
      *(ShadowMappingParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_shadowMapping)) = value;
    }
  }

  public unsafe CullingResults cullingResults
  {
    get
    {
      return *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_cullingResults));
    }
    [param: In] set
    {
      *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_cullingResults)) = value;
    }
  }

  public unsafe VolumetricParams volumetric
  {
    get
    {
      return *(VolumetricParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_volumetric));
    }
    [param: In] set
    {
      *(VolumetricParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_volumetric)) = value;
    }
  }

  public PostProcessingParams postProcessing
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_postProcessing);
      return new PostProcessingParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_postProcessing), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe PixelizationParams pixelizationParams
  {
    get
    {
      return *(PixelizationParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_pixelizationParams));
    }
    [param: In] set
    {
      *(PixelizationParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameRenderingParams.NativeFieldInfoPtr_pixelizationParams)) = value;
    }
  }
}
