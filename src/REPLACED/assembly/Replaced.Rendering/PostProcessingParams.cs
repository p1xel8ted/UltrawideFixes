// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PostProcessingParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class PostProcessingParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_antiAliasing;
  private static readonly System.IntPtr NativeFieldInfoPtr_bloom;
  private static readonly System.IntPtr NativeFieldInfoPtr_channelMixer;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorAdjustments;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthOfField;
  private static readonly System.IntPtr NativeFieldInfoPtr_offsetGammaGain;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowsMidtonesHighlights;
  private static readonly System.IntPtr NativeFieldInfoPtr_toneMapping;
  private static readonly System.IntPtr NativeFieldInfoPtr_whiteBalance;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTaaSubpixelOffsetUV_Public_Static_Vector2_Int32_byref_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeAntiAliasingParams_Private_Static_AntiAliasingParams_Boolean_VolumeStack_Int32_Vector2Int_Vector2Int_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeBloomParams_Private_Static_BloomParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeColorAdjustmentsParams_Private_Static_ColorAdjustmentsParams_Boolean_VolumeStack_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeChannelMixerParams_Private_Static_ChannelMixerParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeDepthOfFieldParams_Private_Static_DepthOfFieldParams_Boolean_VolumeStack_Vector2Int_Vector2Int_Boolean_Transform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeOffsetGammaGainParams_Private_Static_OffsetGammaGainParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeShadowsMidtonesHighlightsParams_Private_Static_ShadowsMidtonesHighlightsParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeToneMappingParams_Private_Static_ToneMappingParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeWhiteBalanceParams_Private_Static_WhiteBalanceParams_Boolean_VolumeStack_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_byref_UserPreferences_Int32_Vector2Int_Vector2Int_Boolean_Boolean_Transform_Transform_0;

  static PostProcessingParams()
  {
    Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PostProcessingParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr);
    PostProcessingParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (on));
    PostProcessingParams.NativeFieldInfoPtr_antiAliasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (antiAliasing));
    PostProcessingParams.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (bloom));
    PostProcessingParams.NativeFieldInfoPtr_channelMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (channelMixer));
    PostProcessingParams.NativeFieldInfoPtr_colorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (colorAdjustments));
    PostProcessingParams.NativeFieldInfoPtr_depthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (depthOfField));
    PostProcessingParams.NativeFieldInfoPtr_offsetGammaGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (offsetGammaGain));
    PostProcessingParams.NativeFieldInfoPtr_shadowsMidtonesHighlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (shadowsMidtonesHighlights));
    PostProcessingParams.NativeFieldInfoPtr_toneMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (toneMapping));
    PostProcessingParams.NativeFieldInfoPtr_whiteBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, nameof (whiteBalance));
    PostProcessingParams.NativeMethodInfoPtr_GenerateTaaSubpixelOffsetUV_Public_Static_Vector2_Int32_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663616 /*0x06000140*/);
    PostProcessingParams.NativeMethodInfoPtr_MakeAntiAliasingParams_Private_Static_AntiAliasingParams_Boolean_VolumeStack_Int32_Vector2Int_Vector2Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663617);
    PostProcessingParams.NativeMethodInfoPtr_MakeBloomParams_Private_Static_BloomParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663618);
    PostProcessingParams.NativeMethodInfoPtr_MakeColorAdjustmentsParams_Private_Static_ColorAdjustmentsParams_Boolean_VolumeStack_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663619);
    PostProcessingParams.NativeMethodInfoPtr_MakeChannelMixerParams_Private_Static_ChannelMixerParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663620);
    PostProcessingParams.NativeMethodInfoPtr_MakeDepthOfFieldParams_Private_Static_DepthOfFieldParams_Boolean_VolumeStack_Vector2Int_Vector2Int_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663621);
    PostProcessingParams.NativeMethodInfoPtr_MakeOffsetGammaGainParams_Private_Static_OffsetGammaGainParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663622);
    PostProcessingParams.NativeMethodInfoPtr_MakeShadowsMidtonesHighlightsParams_Private_Static_ShadowsMidtonesHighlightsParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663623);
    PostProcessingParams.NativeMethodInfoPtr_MakeToneMappingParams_Private_Static_ToneMappingParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663624);
    PostProcessingParams.NativeMethodInfoPtr_MakeWhiteBalanceParams_Private_Static_WhiteBalanceParams_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663625);
    PostProcessingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_byref_UserPreferences_Int32_Vector2Int_Vector2Int_Boolean_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr, 100663626);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926923, XrefRangeEnd = 926925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GenerateTaaSubpixelOffsetUV(
    int jitterIndex,
    [In] ref Vector2Int viewportSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &jitterIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewportSize;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_GenerateTaaSubpixelOffsetUV_Public_Static_Vector2_Int32_byref_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926935, RefRangeEnd = 926936, XrefRangeStart = 926925, XrefRangeEnd = 926935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AntiAliasingParams MakeAntiAliasingParams(
    bool makeDefault,
    VolumeStack volumeStack,
    int jitterIndex,
    Vector2Int viewportSize,
    Vector2Int previousViewportSize,
    bool isPerspectiveCamera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jitterIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &viewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &previousViewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isPerspectiveCamera;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeAntiAliasingParams_Private_Static_AntiAliasingParams_Boolean_VolumeStack_Int32_Vector2Int_Vector2Int_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AntiAliasingParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926936, XrefRangeEnd = 926940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BloomParams MakeBloomParams(bool makeDefault, VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeBloomParams_Private_Static_BloomParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(BloomParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926940, XrefRangeEnd = 926943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorAdjustmentsParams MakeColorAdjustmentsParams(
    bool makeDefault,
    VolumeStack volumeStack,
    float brightnessOffset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &brightnessOffset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeColorAdjustmentsParams_Private_Static_ColorAdjustmentsParams_Boolean_VolumeStack_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ColorAdjustmentsParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926946, RefRangeEnd = 926947, XrefRangeStart = 926943, XrefRangeEnd = 926946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ChannelMixerParams MakeChannelMixerParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeChannelMixerParams_Private_Static_ChannelMixerParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ChannelMixerParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926971, RefRangeEnd = 926972, XrefRangeStart = 926947, XrefRangeEnd = 926971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DepthOfFieldParams MakeDepthOfFieldParams(
    bool makeDefault,
    VolumeStack volumeStack,
    Vector2Int viewportSize,
    Vector2Int previousViewportSize,
    bool isSceneView,
    Transform cameraTransform,
    Transform autofocusTarget)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &viewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &previousViewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isSceneView;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameraTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) autofocusTarget);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeDepthOfFieldParams_Private_Static_DepthOfFieldParams_Boolean_VolumeStack_Vector2Int_Vector2Int_Boolean_Transform_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new DepthOfFieldParams(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926972, XrefRangeEnd = 926975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe OffsetGammaGainParams MakeOffsetGammaGainParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeOffsetGammaGainParams_Private_Static_OffsetGammaGainParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(OffsetGammaGainParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926979, RefRangeEnd = 926980, XrefRangeStart = 926975, XrefRangeEnd = 926979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ShadowsMidtonesHighlightsParams MakeShadowsMidtonesHighlightsParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeShadowsMidtonesHighlightsParams_Private_Static_ShadowsMidtonesHighlightsParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ShadowsMidtonesHighlightsParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926980, XrefRangeEnd = 926983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ToneMappingParams MakeToneMappingParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeToneMappingParams_Private_Static_ToneMappingParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ToneMappingParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926983, XrefRangeEnd = 926986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe WhiteBalanceParams MakeWhiteBalanceParams(
    bool makeDefault,
    VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &makeDefault;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr_MakeWhiteBalanceParams_Private_Static_WhiteBalanceParams_Boolean_VolumeStack_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(WhiteBalanceParams*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927016, RefRangeEnd = 927017, XrefRangeStart = 926986, XrefRangeEnd = 927016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PostProcessingParams(
    bool on,
    VolumeStack volumeStack,
    [In] ref UserPreferences userPreferences,
    int taaJitterIndex,
    Vector2Int viewportSize,
    Vector2Int previousViewportSize,
    bool isSceneView,
    bool isPerspectiveCamera,
    Transform cameraTransform,
    Transform dofAutofocusTarget)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = (System.IntPtr) &on;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref userPreferences;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &taaJitterIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &viewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &previousViewportSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &isSceneView;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isPerspectiveCamera;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameraTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dofAutofocusTarget);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_byref_UserPreferences_Int32_Vector2Int_Vector2Int_Boolean_Boolean_Transform_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PostProcessingParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PostProcessingParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingParams>.NativeClassPtr))
  {
  }

  public unsafe bool on
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_on));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_on)) = value;
    }
  }

  public unsafe AntiAliasingParams antiAliasing
  {
    get
    {
      return *(AntiAliasingParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_antiAliasing));
    }
    [param: In] set
    {
      *(AntiAliasingParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_antiAliasing)) = value;
    }
  }

  public unsafe BloomParams bloom
  {
    get
    {
      return *(BloomParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_bloom));
    }
    [param: In] set
    {
      *(BloomParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_bloom)) = value;
    }
  }

  public unsafe ChannelMixerParams channelMixer
  {
    get
    {
      return *(ChannelMixerParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_channelMixer));
    }
    [param: In] set
    {
      *(ChannelMixerParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_channelMixer)) = value;
    }
  }

  public unsafe ColorAdjustmentsParams colorAdjustments
  {
    get
    {
      return *(ColorAdjustmentsParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_colorAdjustments));
    }
    [param: In] set
    {
      *(ColorAdjustmentsParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_colorAdjustments)) = value;
    }
  }

  public DepthOfFieldParams depthOfField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_depthOfField);
      return new DepthOfFieldParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_depthOfField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DepthOfFieldParams>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe OffsetGammaGainParams offsetGammaGain
  {
    get
    {
      return *(OffsetGammaGainParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_offsetGammaGain));
    }
    [param: In] set
    {
      *(OffsetGammaGainParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_offsetGammaGain)) = value;
    }
  }

  public unsafe ShadowsMidtonesHighlightsParams shadowsMidtonesHighlights
  {
    get
    {
      return *(ShadowsMidtonesHighlightsParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_shadowsMidtonesHighlights));
    }
    [param: In] set
    {
      *(ShadowsMidtonesHighlightsParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_shadowsMidtonesHighlights)) = value;
    }
  }

  public unsafe ToneMappingParams toneMapping
  {
    get
    {
      return *(ToneMappingParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_toneMapping));
    }
    [param: In] set
    {
      *(ToneMappingParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_toneMapping)) = value;
    }
  }

  public unsafe WhiteBalanceParams whiteBalance
  {
    get
    {
      return *(WhiteBalanceParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_whiteBalance));
    }
    [param: In] set
    {
      *(WhiteBalanceParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingParams.NativeFieldInfoPtr_whiteBalance)) = value;
    }
  }
}
