// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class RenderSettings(IntPtr pointer) : Object(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyboxAmount_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyboxAmount_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fogStartDistance_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fogEndDistance_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fogMode_Public_Static_get_FogMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fogMode_Public_Static_set_Void_FogMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fogColor_Public_Static_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fogDensity_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientMode_Public_Static_get_AmbientMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientIntensity_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_subtractiveShadowColor_Public_Static_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_skybox_Public_Static_set_Void_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientProbe_Public_Static_set_Void_SphericalHarmonicsL2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_customReflection_Public_Static_get_Cubemap_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_customReflection_Public_Static_set_Void_Cubemap_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_customReflectionTexture_Public_Static_get_Texture_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_customReflectionTexture_Public_Static_set_Void_Texture_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_reflectionIntensity_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_reflectionBounces_Public_Static_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_reflectionBounces_Public_Static_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflection_Internal_Static_get_Cubemap_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflectionMode_Public_Static_get_DefaultReflectionMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_defaultReflectionMode_Public_Static_set_Void_DefaultReflectionMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflectionResolution_Public_Static_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_defaultReflectionResolution_Public_Static_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_haloStrength_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_haloStrength_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flareStrength_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_flareStrength_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flareFadeSpeed_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_flareFadeSpeed_Public_Static_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRenderSettings_Internal_Static_Object_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_fogColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_skybox_Injected_Private_Static_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_skybox_Injected_Private_Static_Void_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sun_Injected_Private_Static_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sun_Injected_Private_Static_Void_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_customReflectionTexture_Injected_Private_Static_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_customReflectionTexture_Injected_Private_Static_Void_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflection_Injected_Private_Static_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRenderSettings_Injected_Private_Static_IntPtr_0;

  static RenderSettings()
  {
    Il2CppClassPointerStore<RenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RenderSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr);
    RenderSettings.NativeMethodInfoPtr_get_ambientSkyboxAmount_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665164);
    RenderSettings.NativeMethodInfoPtr_set_ambientSkyboxAmount_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665165);
    RenderSettings.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665166);
    RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665167);
    RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665168 /*0x06000750*/);
    RenderSettings.NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665169);
    RenderSettings.NativeMethodInfoPtr_set_fogStartDistance_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665170);
    RenderSettings.NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665171);
    RenderSettings.NativeMethodInfoPtr_set_fogEndDistance_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665172);
    RenderSettings.NativeMethodInfoPtr_get_fogMode_Public_Static_get_FogMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665173);
    RenderSettings.NativeMethodInfoPtr_set_fogMode_Public_Static_set_Void_FogMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665174);
    RenderSettings.NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665175);
    RenderSettings.NativeMethodInfoPtr_set_fogColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665176);
    RenderSettings.NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665177);
    RenderSettings.NativeMethodInfoPtr_set_fogDensity_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665178);
    RenderSettings.NativeMethodInfoPtr_get_ambientMode_Public_Static_get_AmbientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665179);
    RenderSettings.NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665180);
    RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665181);
    RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665182);
    RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665183);
    RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665184 /*0x06000760*/);
    RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665185);
    RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665186);
    RenderSettings.NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665187);
    RenderSettings.NativeMethodInfoPtr_set_ambientIntensity_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665188);
    RenderSettings.NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665189);
    RenderSettings.NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665190);
    RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665191);
    RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665192);
    RenderSettings.NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665193);
    RenderSettings.NativeMethodInfoPtr_set_skybox_Public_Static_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665194);
    RenderSettings.NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665195);
    RenderSettings.NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665196);
    RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665197);
    RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Public_Static_set_Void_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665198);
    RenderSettings.NativeMethodInfoPtr_get_customReflection_Public_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665199);
    RenderSettings.NativeMethodInfoPtr_set_customReflection_Public_Static_set_Void_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665200 /*0x06000770*/);
    RenderSettings.NativeMethodInfoPtr_get_customReflectionTexture_Public_Static_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665201);
    RenderSettings.NativeMethodInfoPtr_set_customReflectionTexture_Public_Static_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665202);
    RenderSettings.NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665203);
    RenderSettings.NativeMethodInfoPtr_set_reflectionIntensity_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665204);
    RenderSettings.NativeMethodInfoPtr_get_reflectionBounces_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665205);
    RenderSettings.NativeMethodInfoPtr_set_reflectionBounces_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665206);
    RenderSettings.NativeMethodInfoPtr_get_defaultReflection_Internal_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665207);
    RenderSettings.NativeMethodInfoPtr_get_defaultReflectionMode_Public_Static_get_DefaultReflectionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665208);
    RenderSettings.NativeMethodInfoPtr_set_defaultReflectionMode_Public_Static_set_Void_DefaultReflectionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665209);
    RenderSettings.NativeMethodInfoPtr_get_defaultReflectionResolution_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665210);
    RenderSettings.NativeMethodInfoPtr_set_defaultReflectionResolution_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665211);
    RenderSettings.NativeMethodInfoPtr_get_haloStrength_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665212);
    RenderSettings.NativeMethodInfoPtr_set_haloStrength_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665213);
    RenderSettings.NativeMethodInfoPtr_get_flareStrength_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665214);
    RenderSettings.NativeMethodInfoPtr_set_flareStrength_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665215);
    RenderSettings.NativeMethodInfoPtr_get_flareFadeSpeed_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665216 /*0x06000780*/);
    RenderSettings.NativeMethodInfoPtr_set_flareFadeSpeed_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665217);
    RenderSettings.NativeMethodInfoPtr_GetRenderSettings_Internal_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665218);
    RenderSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665219);
    RenderSettings.NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665220);
    RenderSettings.NativeMethodInfoPtr_set_fogColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665221);
    RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665222);
    RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665223);
    RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665224);
    RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665225);
    RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665226);
    RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665227);
    RenderSettings.NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665228);
    RenderSettings.NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665229);
    RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665230);
    RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665231);
    RenderSettings.NativeMethodInfoPtr_get_skybox_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665232 /*0x06000790*/);
    RenderSettings.NativeMethodInfoPtr_set_skybox_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665233);
    RenderSettings.NativeMethodInfoPtr_get_sun_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665234);
    RenderSettings.NativeMethodInfoPtr_set_sun_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665235);
    RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665236);
    RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665237);
    RenderSettings.NativeMethodInfoPtr_get_customReflectionTexture_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665238);
    RenderSettings.NativeMethodInfoPtr_set_customReflectionTexture_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665239);
    RenderSettings.NativeMethodInfoPtr_get_defaultReflection_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665240);
    RenderSettings.NativeMethodInfoPtr_GetRenderSettings_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100665241);
  }

  public static unsafe float ambientSkyboxAmount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425598, XrefRangeEnd = 425600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyboxAmount_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425600, XrefRangeEnd = 425602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyboxAmount_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425602, XrefRangeEnd = 425606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool fog
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425606, XrefRangeEnd = 425608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425608, XrefRangeEnd = 425610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float fogStartDistance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425610, XrefRangeEnd = 425612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425612, XrefRangeEnd = 425614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogStartDistance_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float fogEndDistance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425614, XrefRangeEnd = 425616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425616, XrefRangeEnd = 425618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogEndDistance_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe FogMode fogMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425618, XrefRangeEnd = 425620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogMode_Public_Static_get_FogMode_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FogMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425620, XrefRangeEnd = 425622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogMode_Public_Static_set_Void_FogMode_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Color fogColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425622, XrefRangeEnd = 425624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425624, XrefRangeEnd = 425626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogColor_Public_Static_set_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float fogDensity
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 425628, RefRangeEnd = 425629, XrefRangeStart = 425626, XrefRangeEnd = 425628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 425631, RefRangeEnd = 425632, XrefRangeStart = 425629, XrefRangeEnd = 425631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogDensity_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe AmbientMode ambientMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425632, XrefRangeEnd = 425634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientMode_Public_Static_get_AmbientMode_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AmbientMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425634, XrefRangeEnd = 425636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Color ambientSkyColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425636, XrefRangeEnd = 425638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425638, XrefRangeEnd = 425640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Color ambientEquatorColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425640, XrefRangeEnd = 425642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425642, XrefRangeEnd = 425644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Color ambientGroundColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425644, XrefRangeEnd = 425646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425646, XrefRangeEnd = 425648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float ambientIntensity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientIntensity_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Color ambientLight
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425648, XrefRangeEnd = 425650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425650, XrefRangeEnd = 425652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Color subtractiveShadowColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425652, XrefRangeEnd = 425654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425654, XrefRangeEnd = 425656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Public_Static_set_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Material skybox
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425656, XrefRangeEnd = 425661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425661, XrefRangeEnd = 425666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_skybox_Public_Static_set_Void_Material_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Light sun
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425666, XrefRangeEnd = 425671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Light) null : Il2CppObjectPool.Get<Light>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425671, XrefRangeEnd = 425676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe SphericalHarmonicsL2 ambientProbe
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 425678, RefRangeEnd = 425679, XrefRangeStart = 425676, XrefRangeEnd = 425678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SphericalHarmonicsL2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425679, XrefRangeEnd = 425681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Public_Static_set_Void_SphericalHarmonicsL2_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Cubemap customReflection
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425681, XrefRangeEnd = 425688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_customReflection_Public_Static_get_Cubemap_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Cubemap) null : Il2CppObjectPool.Get<Cubemap>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425688, XrefRangeEnd = 425693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_customReflection_Public_Static_set_Void_Cubemap_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Texture customReflectionTexture
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425693, XrefRangeEnd = 425698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_customReflectionTexture_Public_Static_get_Texture_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_customReflectionTexture_Public_Static_set_Void_Texture_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float reflectionIntensity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425698, XrefRangeEnd = 425700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425700, XrefRangeEnd = 425702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_reflectionIntensity_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe int reflectionBounces
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425702, XrefRangeEnd = 425704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_reflectionBounces_Public_Static_get_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425704, XrefRangeEnd = 425706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_reflectionBounces_Public_Static_set_Void_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Cubemap defaultReflection
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425706, XrefRangeEnd = 425711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflection_Internal_Static_get_Cubemap_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Cubemap) null : Il2CppObjectPool.Get<Cubemap>(num3);
    }
  }

  public static unsafe DefaultReflectionMode defaultReflectionMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425711, XrefRangeEnd = 425713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflectionMode_Public_Static_get_DefaultReflectionMode_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(DefaultReflectionMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425713, XrefRangeEnd = 425715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_defaultReflectionMode_Public_Static_set_Void_DefaultReflectionMode_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe int defaultReflectionResolution
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425715, XrefRangeEnd = 425717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflectionResolution_Public_Static_get_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425717, XrefRangeEnd = 425719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_defaultReflectionResolution_Public_Static_set_Void_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float haloStrength
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425719, XrefRangeEnd = 425721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_haloStrength_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425721, XrefRangeEnd = 425723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_haloStrength_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float flareStrength
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425723, XrefRangeEnd = 425725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_flareStrength_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425725, XrefRangeEnd = 425727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_flareStrength_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe float flareFadeSpeed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425727, XrefRangeEnd = 425729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_flareFadeSpeed_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425729, XrefRangeEnd = 425731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_flareFadeSpeed_Public_Static_set_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425731, XrefRangeEnd = 425736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Object GetRenderSettings()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_GetRenderSettings_Internal_Static_Object_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425736, XrefRangeEnd = 425738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425738, XrefRangeEnd = 425740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_fogColor_Injected(out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425740, XrefRangeEnd = 425742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_fogColor_Injected([In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425742, XrefRangeEnd = 425744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_ambientSkyColor_Injected(out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425744, XrefRangeEnd = 425746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_ambientSkyColor_Injected([In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425746, XrefRangeEnd = 425748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_ambientEquatorColor_Injected(out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425748, XrefRangeEnd = 425750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_ambientEquatorColor_Injected([In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425750, XrefRangeEnd = 425752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_ambientGroundColor_Injected(out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425752, XrefRangeEnd = 425754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_ambientGroundColor_Injected([In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425754, XrefRangeEnd = 425756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_ambientLight_Injected(out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425756, XrefRangeEnd = 425758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_ambientLight_Injected([In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425758, XrefRangeEnd = 425760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_subtractiveShadowColor_Injected(out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425760, XrefRangeEnd = 425762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_subtractiveShadowColor_Injected([In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425762, XrefRangeEnd = 425764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_skybox_Injected()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_skybox_Injected_Private_Static_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425764, XrefRangeEnd = 425766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_skybox_Injected(IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_skybox_Injected_Private_Static_Void_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425766, XrefRangeEnd = 425768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_sun_Injected()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_sun_Injected_Private_Static_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425768, XrefRangeEnd = 425770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_sun_Injected(IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_sun_Injected_Private_Static_Void_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425770, XrefRangeEnd = 425772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref ret
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425772, XrefRangeEnd = 425774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_ambientProbe_Injected([In] ref SphericalHarmonicsL2 value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425774, XrefRangeEnd = 425776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_customReflectionTexture_Injected()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_customReflectionTexture_Injected_Private_Static_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425776, XrefRangeEnd = 425778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_customReflectionTexture_Injected(IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_customReflectionTexture_Injected_Private_Static_Void_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425778, XrefRangeEnd = 425780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_defaultReflection_Injected()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflection_Injected_Private_Static_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425780, XrefRangeEnd = 425782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetRenderSettings_Injected()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_GetRenderSettings_Injected_Private_Static_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
