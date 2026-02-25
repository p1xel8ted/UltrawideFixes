// Decompiled with JetBrains decompiler
// Type: UnityEngine.Mathf
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Mathf
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Epsilon;
  private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0;
  public const float PI = 3.14159274f;
  public const float Infinity = float.PositiveInfinity;
  public const float NegativeInfinity = float.NegativeInfinity;
  public const float Deg2Rad = 0.0174532924f;
  public const float Rad2Deg = 57.29578f;
  public const int kMaxDecimals = 15;
  private static readonly Mathf.HalfToFloatDelegate HalfToFloatDelegateField;
  private static readonly Mathf.PerlinNoise1DDelegate PerlinNoise1DDelegateField;

  static Mathf()
  {
    Il2CppClassPointerStore<Mathf>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Mathf));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mathf>.NativeClassPtr);
    Mathf.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mathf>.NativeClassPtr, nameof (Epsilon));
    Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667474);
    Mathf.NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667475);
    Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667476);
    Mathf.NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667477);
    Mathf.NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667478);
    Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667479);
    Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667480);
    Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667481);
    Mathf.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667482);
    Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667483);
    Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667484);
    Mathf.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667485);
    Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667486);
    Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667487);
    Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667488 /*0x06001060*/);
    Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667489);
    Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667490);
    Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667491);
    Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667492);
    Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667493);
    Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667494);
    Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667495);
    Mathf.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667496);
    Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667497);
    Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667498);
    Mathf.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667499);
    Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667500);
    Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667501);
    Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667502);
    Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667503);
    Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667504 /*0x06001070*/);
    Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667505);
    Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667506);
    Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667507);
    Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667508);
    Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667509);
    Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667510);
    Mathf.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667511);
    Mathf.NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667512);
    Mathf.NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667513);
    Mathf.NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667514);
    Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667515);
    Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667516);
    Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667517);
    Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667518);
    Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667519);
    Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667520 /*0x06001080*/);
    Mathf.NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667521);
    Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667522);
    Mathf.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667523);
    Mathf.NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667524);
    Mathf.NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667525);
    Mathf.NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667526);
    Mathf.NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667527);
    Mathf.NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667528);
    Mathf.NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667529);
    Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667530);
    Mathf.NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667531);
    Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100667533);
    Mathf.HalfToFloatDelegateField = IL2CPP.ResolveICall<Mathf.HalfToFloatDelegate>("UnityEngine.Mathf::HalfToFloat");
    Mathf.PerlinNoise1DDelegateField = IL2CPP.ResolveICall<Mathf.PerlinNoise1DDelegate>("UnityEngine.Mathf::PerlinNoise1D");
  }

  [CallerCount(130)]
  [CachedScanResults(RefRangeStart = 440646, RefRangeEnd = 440776, XrefRangeStart = 440644, XrefRangeEnd = 440646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GammaToLinearSpace(float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440776, XrefRangeEnd = 440778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float LinearToGammaSpace(float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 440780, RefRangeEnd = 440786, XrefRangeStart = 440778, XrefRangeEnd = 440780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color CorrelatedColorTemperatureToRGB(float kelvin)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &kelvin
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(42)]
  [CachedScanResults(RefRangeStart = 440788, RefRangeEnd = 440830, XrefRangeStart = 440786, XrefRangeEnd = 440788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ushort FloatToHalf(float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &val
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 440832, RefRangeEnd = 440840, XrefRangeStart = 440830, XrefRangeEnd = 440832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float PerlinNoise(float x, float y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440840, XrefRangeEnd = 440844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Sin(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440844, XrefRangeEnd = 440848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Cos(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440848, XrefRangeEnd = 440852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Tan(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440852, XrefRangeEnd = 440856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Asin(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440856, XrefRangeEnd = 440860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Acos(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440860, XrefRangeEnd = 440864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Atan(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440864, XrefRangeEnd = 440868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Atan2(float y, float x)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440868, XrefRangeEnd = 440871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Sqrt(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440871, XrefRangeEnd = 440874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Abs(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440874, XrefRangeEnd = 440877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Abs(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Min(float a, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Min([Optional] Il2CppStructArray<float> values)
  {
    if (values == null)
      values = new Il2CppStructArray<float>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Il2CppStructArray_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int Min(int a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Max(float a, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Max([Optional] Il2CppStructArray<float> values)
  {
    if (values == null)
      values = new Il2CppStructArray<float>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int Max(int a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440877, XrefRangeEnd = 440881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Pow(float f, float p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &f;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440881, XrefRangeEnd = 440885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Exp(float power)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &power
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440885, XrefRangeEnd = 440889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Log(float f, float p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &f;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440889, XrefRangeEnd = 440893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Log(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440893, XrefRangeEnd = 440897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Log10(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440897, XrefRangeEnd = 440901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Ceil(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440901, XrefRangeEnd = 440905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Floor(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440905, XrefRangeEnd = 440909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Round(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440909, XrefRangeEnd = 440913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CeilToInt(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440913, XrefRangeEnd = 440917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int FloorToInt(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440917, XrefRangeEnd = 440921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int RoundToInt(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Sign(float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(114)]
  [CachedScanResults(RefRangeStart = 239274, RefRangeEnd = 239388, XrefRangeStart = 239274, XrefRangeEnd = 239388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Clamp(float value, float min, float max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int Clamp(int value, int min, int max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(30)]
  [CachedScanResults(RefRangeStart = 239388, RefRangeEnd = 239418, XrefRangeStart = 239388, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Clamp01(float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Lerp(float a, float b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float LerpUnclamped(float a, float b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440921, XrefRangeEnd = 440924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float LerpAngle(float a, float b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float MoveTowards(float current, float target, float maxDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDelta;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440924, XrefRangeEnd = 440925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SmoothStep(float from, float to, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440925, XrefRangeEnd = 440927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Approximately(float a, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 440929, RefRangeEnd = 440932, XrefRangeStart = 440927, XrefRangeEnd = 440929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SmoothDamp(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 440934, RefRangeEnd = 440961, XrefRangeStart = 440932, XrefRangeEnd = 440934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SmoothDamp(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed,
    float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440965, RefRangeEnd = 440967, XrefRangeStart = 440961, XrefRangeEnd = 440965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SmoothDampAngle(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440967, XrefRangeEnd = 440970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SmoothDampAngle(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed,
    float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440970, XrefRangeEnd = 440971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Repeat(float t, float length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440973, RefRangeEnd = 440975, XrefRangeStart = 440971, XrefRangeEnd = 440973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float PingPong(float t, float length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &t;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float InverseLerp(float a, float b, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 440977, RefRangeEnd = 440978, XrefRangeStart = 440975, XrefRangeEnd = 440977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float DeltaAngle(float current, float target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440978, RefRangeEnd = 440980, XrefRangeStart = 440978, XrefRangeEnd = 440978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ClampToFloat(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440980, RefRangeEnd = 440982, XrefRangeStart = 440980, XrefRangeEnd = 440980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int ClampToInt(long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 440982, RefRangeEnd = 440984, XrefRangeStart = 440982, XrefRangeEnd = 440982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint ClampToUInt(long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440984, XrefRangeEnd = 440990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetNumberOfDecimalsForMinimumDifference(double minDifference)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &minDifference
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 441002, RefRangeEnd = 441004, XrefRangeStart = 440990, XrefRangeEnd = 441002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double RoundBasedOnMinimumDifference(
    double valueToRound,
    double minDifference)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &valueToRound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minDifference;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441016, RefRangeEnd = 441017, XrefRangeStart = 441004, XrefRangeEnd = 441016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double DiscardLeastSignificantDecimal(double v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int NextPowerOfTwo(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsPowerOfTwo(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441017, XrefRangeEnd = 441019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &kelvin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static float Min(params float[] values) => Mathf.Min(new Il2CppStructArray<float>(values));

  public static float Max(params float[] values) => Mathf.Max(new Il2CppStructArray<float>(values));

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mathf>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe float Epsilon
  {
    get
    {
      float epsilon;
      IL2CPP.il2cpp_field_static_get_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*) &epsilon);
      return epsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*) &value);
    }
  }

  public static float HalfToFloat(ushort val) => Mathf.HalfToFloatDelegateField(val);

  public static float PerlinNoise1D(float x) => Mathf.PerlinNoise1DDelegateField(x);

  public static int Min(Il2CppStructArray<int> values)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static int Min(params int[] values) => Mathf.Min(new Il2CppStructArray<int>(values));

  public static int Max(Il2CppStructArray<int> values)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static int Max(params int[] values) => Mathf.Max(new Il2CppStructArray<int>(values));

  public static float MoveTowardsAngle(float current, float target, float maxDelta)
  {
    float num = Mathf.DeltaAngle(current, target);
    if (-(double) maxDelta < (double) num && (double) num < (double) maxDelta)
      return target;
    target = current + num;
    return Mathf.MoveTowards(current, target, maxDelta);
  }

  public static float Gamma(float value, float absmax, float gamma)
  {
    bool flag = (double) value < 0.0;
    float num1 = Mathf.Abs(value);
    if ((double) num1 > (double) absmax)
      return flag ? -num1 : num1;
    float num2 = Mathf.Pow(num1 / absmax, gamma) * absmax;
    return flag ? -num2 : num2;
  }

  public static float SmoothDamp(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed)
  {
    float deltaTime = Time.deltaTime;
    return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
  }

  public static float SmoothDampAngle(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed)
  {
    float deltaTime = Time.deltaTime;
    return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
  }

  public static bool LineIntersection(
    Vector2 p1,
    Vector2 p2,
    Vector2 p3,
    Vector2 p4,
    ref Vector2 result)
  {
    float num1 = p2.x - p1.x;
    float num2 = p2.y - p1.y;
    float num3 = p4.x - p3.x;
    float num4 = p4.y - p3.y;
    float num5 = (float) ((double) num1 * (double) num4 - (double) num2 * (double) num3);
    if ((double) num5 == 0.0)
      return false;
    float num6 = p3.x - p1.x;
    float num7 = p3.y - p1.y;
    float num8 = (float) ((double) num6 * (double) num4 - (double) num7 * (double) num3) / num5;
    result.x = p1.x + num8 * num1;
    result.y = p1.y + num8 * num2;
    return true;
  }

  public static bool LineSegmentIntersection(
    Vector2 p1,
    Vector2 p2,
    Vector2 p3,
    Vector2 p4,
    ref Vector2 result)
  {
    float num1 = p2.x - p1.x;
    float num2 = p2.y - p1.y;
    float num3 = p4.x - p3.x;
    float num4 = p4.y - p3.y;
    float num5 = (float) ((double) num1 * (double) num4 - (double) num2 * (double) num3);
    if ((double) num5 == 0.0)
      return false;
    float num6 = p3.x - p1.x;
    float num7 = p3.y - p1.y;
    float num8 = (float) ((double) num6 * (double) num4 - (double) num7 * (double) num3) / num5;
    if ((double) num8 < 0.0 || (double) num8 > 1.0)
      return false;
    float num9 = (float) ((double) num6 * (double) num2 - (double) num7 * (double) num1) / num5;
    if ((double) num9 < 0.0 || (double) num9 > 1.0)
      return false;
    result.x = p1.x + num8 * num1;
    result.y = p1.y + num8 * num2;
    return true;
  }

  public static long RandomToLong(Il2CppSystem.Random r)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static float RoundToMultipleOf(float value, float roundingValue)
  {
    return (double) roundingValue == 0.0 ? value : Mathf.Round(value / roundingValue) * roundingValue;
  }

  public static float GetClosestPowerOfTen(float positiveNumber)
  {
    return (double) positiveNumber <= 0.0 ? 1f : Mathf.Pow(10f, (float) Mathf.RoundToInt(Mathf.Log10(positiveNumber)));
  }

  public static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
  {
    return Mathf.Clamp(-Mathf.FloorToInt(Mathf.Log10(Mathf.Abs(minDifference))), 0, 15);
  }

  public static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
  {
    return (double) minDifference == 0.0 ? Mathf.DiscardLeastSignificantDecimal(valueToRound) : (float) Il2CppSystem.Math.Round((double) valueToRound, Mathf.GetNumberOfDecimalsForMinimumDifference(minDifference), Il2CppSystem.MidpointRounding.AwayFromZero);
  }

  public static float DiscardLeastSignificantDecimal(float v)
  {
    int digits = Mathf.Clamp((int) (5.0 - (double) Mathf.Log10(Mathf.Abs(v))), 0, 15);
    return (float) Il2CppSystem.Math.Round((double) v, digits, Il2CppSystem.MidpointRounding.AwayFromZero);
  }

  public static int ClosestPowerOfTwo(int value)
  {
    int num1 = Mathf.NextPowerOfTwo(value);
    int num2 = num1 >> 1;
    return value - num2 < num1 - value ? num2 : num1;
  }

  private delegate float HalfToFloatDelegate(ushort val);

  private delegate float PerlinNoise1DDelegate(float x);
}
