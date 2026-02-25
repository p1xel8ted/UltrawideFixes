// Decompiled with JetBrains decompiler
// Type: UnityEngine.Texture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public class Texture(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_GenerateAllMips;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataWidth_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataHeight_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IncrementUpdateCount_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_GraphicsFormatUsage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreMipmapLimitCannotBeToggledException_Internal_UnityException_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mipmapCount_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataWidth_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataHeight_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDimension_Injected_Private_Static_TextureDimension_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapMode_Injected_Private_Static_TextureWrapMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapMode_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeU_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeV_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeW_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_filterMode_Injected_Private_Static_FilterMode_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_filterMode_Injected_Private_Static_Void_IntPtr_FilterMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anisoLevel_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anisoLevel_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mipMapBias_Injected_Private_Static_Single_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mipMapBias_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_texelSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_updateCount_Injected_Private_Static_UInt32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IncrementUpdateCount_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataSize_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataOffset_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0;
  private static readonly Texture.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;
  private static readonly Texture.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;
  private static readonly Texture.get_globalMipmapLimitDelegate get_globalMipmapLimitDelegateField;
  private static readonly Texture.set_globalMipmapLimitDelegate set_globalMipmapLimitDelegateField;
  private static readonly Texture.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;
  private static readonly Texture.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;
  private static readonly Texture.SetGlobalAnisotropicFilteringLimitsDelegate SetGlobalAnisotropicFilteringLimitsDelegateField;
  private static readonly Texture.get_totalTextureMemoryDelegate get_totalTextureMemoryDelegateField;
  private static readonly Texture.get_desiredTextureMemoryDelegate get_desiredTextureMemoryDelegateField;
  private static readonly Texture.get_targetTextureMemoryDelegate get_targetTextureMemoryDelegateField;
  private static readonly Texture.get_currentTextureMemoryDelegate get_currentTextureMemoryDelegateField;
  private static readonly Texture.get_nonStreamingTextureMemoryDelegate get_nonStreamingTextureMemoryDelegateField;
  private static readonly Texture.get_streamingMipmapUploadCountDelegate get_streamingMipmapUploadCountDelegateField;
  private static readonly Texture.get_streamingRendererCountDelegate get_streamingRendererCountDelegateField;
  private static readonly Texture.get_streamingTextureCountDelegate get_streamingTextureCountDelegateField;
  private static readonly Texture.get_nonStreamingTextureCountDelegate get_nonStreamingTextureCountDelegateField;
  private static readonly Texture.get_streamingTexturePendingLoadCountDelegate get_streamingTexturePendingLoadCountDelegateField;
  private static readonly Texture.get_streamingTextureLoadingCountDelegate get_streamingTextureLoadingCountDelegateField;
  private static readonly Texture.SetStreamingTextureMaterialDebugPropertiesDelegate SetStreamingTextureMaterialDebugPropertiesDelegateField;
  private static readonly Texture.SetStreamingTextureMaterialDebugPropertiesWithSlotDelegate SetStreamingTextureMaterialDebugPropertiesWithSlotDelegateField;
  private static readonly Texture.get_streamingTextureForceLoadAllDelegate get_streamingTextureForceLoadAllDelegateField;
  private static readonly Texture.set_streamingTextureForceLoadAllDelegate set_streamingTextureForceLoadAllDelegateField;
  private static readonly Texture.get_streamingTextureDiscardUnusedMipsDelegate get_streamingTextureDiscardUnusedMipsDelegateField;
  private static readonly Texture.set_streamingTextureDiscardUnusedMipsDelegate set_streamingTextureDiscardUnusedMipsDelegateField;
  private static readonly Texture.get_allowThreadedTextureCreationDelegate get_allowThreadedTextureCreationDelegateField;
  private static readonly Texture.set_allowThreadedTextureCreationDelegate set_allowThreadedTextureCreationDelegateField;
  private static readonly Texture.get_isNativeTexture_InjectedDelegate get_isNativeTexture_InjectedDelegateField;
  private static readonly Texture.get_wrapModeU_InjectedDelegate get_wrapModeU_InjectedDelegateField;
  private static readonly Texture.get_wrapModeV_InjectedDelegate get_wrapModeV_InjectedDelegateField;
  private static readonly Texture.get_wrapModeW_InjectedDelegate get_wrapModeW_InjectedDelegateField;
  private static readonly Texture.GetNativeTexturePtr_InjectedDelegate GetNativeTexturePtr_InjectedDelegateField;
  private static readonly Texture.Internal_GetStoredColorSpace_InjectedDelegate Internal_GetStoredColorSpace_InjectedDelegateField;
  private static readonly Texture.get_graphicsTexture_InjectedDelegate get_graphicsTexture_InjectedDelegateField;

  static Texture()
  {
    Il2CppClassPointerStore<Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Texture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture>.NativeClassPtr);
    Texture.NativeFieldInfoPtr_GenerateAllMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture>.NativeClassPtr, nameof (GenerateAllMips));
    Texture.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666541);
    Texture.NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666542);
    Texture.NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666543);
    Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666544 /*0x06000CB0*/);
    Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666545);
    Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666546);
    Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666547);
    Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666548);
    Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666549);
    Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666550);
    Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666551);
    Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666552);
    Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666553);
    Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666554);
    Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666555);
    Texture.NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666556);
    Texture.NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666557);
    Texture.NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666558);
    Texture.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666559);
    Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666560 /*0x06000CC0*/);
    Texture.NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666561);
    Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666562);
    Texture.NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666563);
    Texture.NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666564);
    Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666565);
    Texture.NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666566);
    Texture.NativeMethodInfoPtr_IncrementUpdateCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666567);
    Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666568);
    Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666569);
    Texture.NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666570);
    Texture.NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666571);
    Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666572);
    Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666573);
    Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666574);
    Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_GraphicsFormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666575);
    Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666576 /*0x06000CD0*/);
    Texture.NativeMethodInfoPtr_IgnoreMipmapLimitCannotBeToggledException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666577);
    Texture.NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666578);
    Texture.NativeMethodInfoPtr_get_mipmapCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666580);
    Texture.NativeMethodInfoPtr_GetDataWidth_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666581);
    Texture.NativeMethodInfoPtr_GetDataHeight_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666582);
    Texture.NativeMethodInfoPtr_GetDimension_Injected_Private_Static_TextureDimension_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666583);
    Texture.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666584);
    Texture.NativeMethodInfoPtr_get_wrapMode_Injected_Private_Static_TextureWrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666585);
    Texture.NativeMethodInfoPtr_set_wrapMode_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666586);
    Texture.NativeMethodInfoPtr_set_wrapModeU_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666587);
    Texture.NativeMethodInfoPtr_set_wrapModeV_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666588);
    Texture.NativeMethodInfoPtr_set_wrapModeW_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666589);
    Texture.NativeMethodInfoPtr_get_filterMode_Injected_Private_Static_FilterMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666590);
    Texture.NativeMethodInfoPtr_set_filterMode_Injected_Private_Static_Void_IntPtr_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666591);
    Texture.NativeMethodInfoPtr_get_anisoLevel_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666592 /*0x06000CE0*/);
    Texture.NativeMethodInfoPtr_set_anisoLevel_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666593);
    Texture.NativeMethodInfoPtr_get_mipMapBias_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666594);
    Texture.NativeMethodInfoPtr_set_mipMapBias_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666595);
    Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666596);
    Texture.NativeMethodInfoPtr_get_updateCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666597);
    Texture.NativeMethodInfoPtr_IncrementUpdateCount_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666598);
    Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666599);
    Texture.NativeMethodInfoPtr_GetPixelDataSize_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666600);
    Texture.NativeMethodInfoPtr_GetPixelDataOffset_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100666601);
    Texture.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.get_masterTextureLimitDelegate>("UnityEngine.Texture::get_masterTextureLimit");
    Texture.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.set_masterTextureLimitDelegate>("UnityEngine.Texture::set_masterTextureLimit");
    Texture.get_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture.get_globalMipmapLimitDelegate>("UnityEngine.Texture::get_globalMipmapLimit");
    Texture.set_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture.set_globalMipmapLimitDelegate>("UnityEngine.Texture::set_globalMipmapLimit");
    Texture.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.get_anisotropicFilteringDelegate>("UnityEngine.Texture::get_anisotropicFiltering");
    Texture.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.set_anisotropicFilteringDelegate>("UnityEngine.Texture::set_anisotropicFiltering");
    Texture.SetGlobalAnisotropicFilteringLimitsDelegateField = IL2CPP.ResolveICall<Texture.SetGlobalAnisotropicFilteringLimitsDelegate>("UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits");
    Texture.get_totalTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_totalTextureMemoryDelegate>("UnityEngine.Texture::get_totalTextureMemory");
    Texture.get_desiredTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_desiredTextureMemoryDelegate>("UnityEngine.Texture::get_desiredTextureMemory");
    Texture.get_targetTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_targetTextureMemoryDelegate>("UnityEngine.Texture::get_targetTextureMemory");
    Texture.get_currentTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_currentTextureMemoryDelegate>("UnityEngine.Texture::get_currentTextureMemory");
    Texture.get_nonStreamingTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureMemoryDelegate>("UnityEngine.Texture::get_nonStreamingTextureMemory");
    Texture.get_streamingMipmapUploadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingMipmapUploadCountDelegate>("UnityEngine.Texture::get_streamingMipmapUploadCount");
    Texture.get_streamingRendererCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingRendererCountDelegate>("UnityEngine.Texture::get_streamingRendererCount");
    Texture.get_streamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureCountDelegate>("UnityEngine.Texture::get_streamingTextureCount");
    Texture.get_nonStreamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureCountDelegate>("UnityEngine.Texture::get_nonStreamingTextureCount");
    Texture.get_streamingTexturePendingLoadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTexturePendingLoadCountDelegate>("UnityEngine.Texture::get_streamingTexturePendingLoadCount");
    Texture.get_streamingTextureLoadingCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureLoadingCountDelegate>("UnityEngine.Texture::get_streamingTextureLoadingCount");
    Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField = IL2CPP.ResolveICall<Texture.SetStreamingTextureMaterialDebugPropertiesDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties");
    Texture.SetStreamingTextureMaterialDebugPropertiesWithSlotDelegateField = IL2CPP.ResolveICall<Texture.SetStreamingTextureMaterialDebugPropertiesWithSlotDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugPropertiesWithSlot");
    Texture.get_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::get_streamingTextureForceLoadAll");
    Texture.set_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::set_streamingTextureForceLoadAll");
    Texture.get_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::get_streamingTextureDiscardUnusedMips");
    Texture.set_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::set_streamingTextureDiscardUnusedMips");
    Texture.get_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.get_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::get_allowThreadedTextureCreation");
    Texture.set_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.set_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::set_allowThreadedTextureCreation");
    Texture.get_isNativeTexture_InjectedDelegateField = IL2CPP.ResolveICall<Texture.get_isNativeTexture_InjectedDelegate>("UnityEngine.Texture::get_isNativeTexture_Injected");
    Texture.get_wrapModeU_InjectedDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeU_InjectedDelegate>("UnityEngine.Texture::get_wrapModeU_Injected");
    Texture.get_wrapModeV_InjectedDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeV_InjectedDelegate>("UnityEngine.Texture::get_wrapModeV_Injected");
    Texture.get_wrapModeW_InjectedDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeW_InjectedDelegate>("UnityEngine.Texture::get_wrapModeW_Injected");
    Texture.GetNativeTexturePtr_InjectedDelegateField = IL2CPP.ResolveICall<Texture.GetNativeTexturePtr_InjectedDelegate>("UnityEngine.Texture::GetNativeTexturePtr_Injected");
    Texture.Internal_GetStoredColorSpace_InjectedDelegateField = IL2CPP.ResolveICall<Texture.Internal_GetStoredColorSpace_InjectedDelegate>("UnityEngine.Texture::Internal_GetStoredColorSpace_Injected");
    Texture.get_graphicsTexture_InjectedDelegateField = IL2CPP.ResolveICall<Texture.get_graphicsTexture_InjectedDelegate>("UnityEngine.Texture::get_graphicsTexture_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434230, XrefRangeEnd = 434234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int mipmapCount
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 434242, RefRangeEnd = 434251, XrefRangeStart = 434234, XrefRangeEnd = 434242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe GraphicsFormat graphicsFormat
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434251, XrefRangeEnd = 434255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434255, XrefRangeEnd = 434263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetDataWidth()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434263, XrefRangeEnd = 434271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetDataHeight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434271, XrefRangeEnd = 434279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextureDimension GetDimension()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TextureDimension*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe int width
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434279, XrefRangeEnd = 434284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe int height
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434284, XrefRangeEnd = 434289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe TextureDimension dimension
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TextureDimension*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434289, XrefRangeEnd = 434294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool isReadable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434294, XrefRangeEnd = 434302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe TextureWrapMode wrapMode
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 434310, RefRangeEnd = 434317, XrefRangeStart = 434302, XrefRangeEnd = 434310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TextureWrapMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 434337, RefRangeEnd = 434341, XrefRangeStart = 434317, XrefRangeEnd = 434337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe TextureWrapMode wrapModeU
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 434349, RefRangeEnd = 434350, XrefRangeStart = 434341, XrefRangeEnd = 434349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Texture.get_wrapModeU_Injected(_unity_self);
    }
  }

  public unsafe TextureWrapMode wrapModeV
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 434358, RefRangeEnd = 434359, XrefRangeStart = 434350, XrefRangeEnd = 434358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Texture.get_wrapModeV_Injected(_unity_self);
    }
  }

  public unsafe TextureWrapMode wrapModeW
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 434367, RefRangeEnd = 434368, XrefRangeStart = 434359, XrefRangeEnd = 434367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Texture.get_wrapModeW_Injected(_unity_self);
    }
  }

  public unsafe FilterMode filterMode
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 434376, RefRangeEnd = 434383, XrefRangeStart = 434368, XrefRangeEnd = 434376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FilterMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 434391, RefRangeEnd = 434402, XrefRangeStart = 434383, XrefRangeEnd = 434391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int anisoLevel
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 434410, RefRangeEnd = 434415, XrefRangeStart = 434402, XrefRangeEnd = 434410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 434423, RefRangeEnd = 434427, XrefRangeStart = 434415, XrefRangeEnd = 434423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float mipMapBias
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 434435, RefRangeEnd = 434437, XrefRangeStart = 434427, XrefRangeEnd = 434435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 434445, RefRangeEnd = 434446, XrefRangeStart = 434437, XrefRangeEnd = 434445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 texelSize
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 434453, RefRangeEnd = 434454, XrefRangeStart = 434446, XrefRangeEnd = 434453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe uint updateCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 434462, RefRangeEnd = 434463, XrefRangeStart = 434454, XrefRangeEnd = 434462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 434471, RefRangeEnd = 434472, XrefRangeStart = 434463, XrefRangeEnd = 434471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void IncrementUpdateCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_IncrementUpdateCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434472, XrefRangeEnd = 434480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Internal_GetActiveTextureColorSpace()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe ColorSpace activeTextureColorSpace
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 434487, RefRangeEnd = 434488, XrefRangeStart = 434480, XrefRangeEnd = 434487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 434496, RefRangeEnd = 434499, XrefRangeStart = 434488, XrefRangeEnd = 434496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong GetPixelDataSize(int mipLevel, int element = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 434507, RefRangeEnd = 434511, XrefRangeStart = 434499, XrefRangeEnd = 434507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong GetPixelDataOffset(int mipLevel, int element = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe TextureColorSpace GetTextureColorSpace(bool linear)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &linear
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TextureColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434511, XrefRangeEnd = 434515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TextureColorSpace*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 434535, RefRangeEnd = 434542, XrefRangeStart = 434515, XrefRangeEnd = 434535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateFormat(TextureFormat format)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 434556, RefRangeEnd = 434567, XrefRangeStart = 434542, XrefRangeEnd = 434556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usage;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_GraphicsFormatUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 434575, RefRangeEnd = 434598, XrefRangeStart = 434567, XrefRangeEnd = 434575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityException CreateNonReadableException(Texture t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityException) null : Il2CppObjectPool.Get<UnityException>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 434606, RefRangeEnd = 434608, XrefRangeStart = 434598, XrefRangeEnd = 434606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityException IgnoreMipmapLimitCannotBeToggledException(Texture t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_IgnoreMipmapLimitCannotBeToggledException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityException) null : Il2CppObjectPool.Get<UnityException>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434608, XrefRangeEnd = 434614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityException CreateNativeArrayLengthOverflowException()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityException) null : Il2CppObjectPool.Get<UnityException>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434614, XrefRangeEnd = 434616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_mipmapCount_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipmapCount_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434616, XrefRangeEnd = 434618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetDataWidth_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataWidth_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434618, XrefRangeEnd = 434620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetDataHeight_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataHeight_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434620, XrefRangeEnd = 434622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TextureDimension GetDimension_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDimension_Injected_Private_Static_TextureDimension_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TextureDimension*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434622, XrefRangeEnd = 434624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_isReadable_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434624, XrefRangeEnd = 434626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TextureWrapMode get_wrapMode_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_wrapMode_Injected_Private_Static_TextureWrapMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TextureWrapMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434626, XrefRangeEnd = 434628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_wrapMode_Injected(System.IntPtr _unity_self, TextureWrapMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapMode_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434628, XrefRangeEnd = 434630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_wrapModeU_Injected(System.IntPtr _unity_self, TextureWrapMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeU_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434630, XrefRangeEnd = 434632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_wrapModeV_Injected(System.IntPtr _unity_self, TextureWrapMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeV_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434632, XrefRangeEnd = 434634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_wrapModeW_Injected(System.IntPtr _unity_self, TextureWrapMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeW_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434634, XrefRangeEnd = 434636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FilterMode get_filterMode_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_filterMode_Injected_Private_Static_FilterMode_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FilterMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434636, XrefRangeEnd = 434638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_filterMode_Injected(System.IntPtr _unity_self, FilterMode value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_filterMode_Injected_Private_Static_Void_IntPtr_FilterMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434638, XrefRangeEnd = 434640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_anisoLevel_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_anisoLevel_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434640, XrefRangeEnd = 434642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_anisoLevel_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_anisoLevel_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434642, XrefRangeEnd = 434644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_mipMapBias_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipMapBias_Injected_Private_Static_Single_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434644, XrefRangeEnd = 434646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_mipMapBias_Injected(System.IntPtr _unity_self, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_mipMapBias_Injected_Private_Static_Void_IntPtr_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434646, XrefRangeEnd = 434648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_texelSize_Injected(System.IntPtr _unity_self, out Vector2 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434648, XrefRangeEnd = 434650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint get_updateCount_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_updateCount_Injected_Private_Static_UInt32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434650, XrefRangeEnd = 434652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IncrementUpdateCount_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_IncrementUpdateCount_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434652, XrefRangeEnd = 434654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Internal_GetActiveTextureColorSpace_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434654, XrefRangeEnd = 434656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ulong GetPixelDataSize_Injected(
    System.IntPtr _unity_self,
    int mipLevel,
    int element)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataSize_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434656, XrefRangeEnd = 434658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ulong GetPixelDataOffset_Injected(
    System.IntPtr _unity_self,
    int mipLevel,
    int element)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataOffset_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int GenerateAllMips
  {
    get
    {
      int generateAllMips;
      IL2CPP.il2cpp_field_static_get_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*) &generateAllMips);
      return generateAllMips;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*) &value);
    }
  }

  public static int masterTextureLimit
  {
    get => Texture.get_masterTextureLimitDelegateField();
    set => Texture.set_masterTextureLimitDelegateField(value);
  }

  public static int globalMipmapLimit
  {
    get => Texture.get_globalMipmapLimitDelegateField();
    set => Texture.set_globalMipmapLimitDelegateField(value);
  }

  public static AnisotropicFiltering anisotropicFiltering
  {
    get => Texture.get_anisotropicFilteringDelegateField();
    set => Texture.set_anisotropicFilteringDelegateField(value);
  }

  public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
  {
    Texture.SetGlobalAnisotropicFilteringLimitsDelegateField(forcedMin, globalMax);
  }

  public bool isNativeTexture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Texture.get_isNativeTexture_Injected(_unity_self);
    }
  }

  public System.IntPtr GetNativeTexturePtr()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Texture.GetNativeTexturePtr_Injected(_unity_self);
  }

  public int GetNativeTextureID() => (int) this.GetNativeTexturePtr();

  public TextureColorSpace Internal_GetStoredColorSpace()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Texture.Internal_GetStoredColorSpace_Injected(_unity_self);
  }

  public bool isDataSRGB => this.Internal_GetStoredColorSpace() == TextureColorSpace.sRGB;

  public static ulong totalTextureMemory => Texture.get_totalTextureMemoryDelegateField();

  public static ulong desiredTextureMemory => Texture.get_desiredTextureMemoryDelegateField();

  public static ulong targetTextureMemory => Texture.get_targetTextureMemoryDelegateField();

  public static ulong currentTextureMemory => Texture.get_currentTextureMemoryDelegateField();

  public static ulong nonStreamingTextureMemory
  {
    get => Texture.get_nonStreamingTextureMemoryDelegateField();
  }

  public static ulong streamingMipmapUploadCount
  {
    get => Texture.get_streamingMipmapUploadCountDelegateField();
  }

  public static ulong streamingRendererCount => Texture.get_streamingRendererCountDelegateField();

  public static ulong streamingTextureCount => Texture.get_streamingTextureCountDelegateField();

  public static ulong nonStreamingTextureCount
  {
    get => Texture.get_nonStreamingTextureCountDelegateField();
  }

  public static ulong streamingTexturePendingLoadCount
  {
    get => Texture.get_streamingTexturePendingLoadCountDelegateField();
  }

  public static ulong streamingTextureLoadingCount
  {
    get => Texture.get_streamingTextureLoadingCountDelegateField();
  }

  public static void SetStreamingTextureMaterialDebugProperties()
  {
    Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField();
  }

  public static void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot)
  {
    Texture.SetStreamingTextureMaterialDebugPropertiesWithSlotDelegateField(materialTextureSlot);
  }

  public static void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot)
  {
    Texture.SetStreamingTextureMaterialDebugPropertiesWithSlot(materialTextureSlot);
  }

  public static bool streamingTextureForceLoadAll
  {
    get => Texture.get_streamingTextureForceLoadAllDelegateField();
    set => Texture.set_streamingTextureForceLoadAllDelegateField(value);
  }

  public static bool streamingTextureDiscardUnusedMips
  {
    get => Texture.get_streamingTextureDiscardUnusedMipsDelegateField();
    set => Texture.set_streamingTextureDiscardUnusedMipsDelegateField(value);
  }

  public static bool allowThreadedTextureCreation
  {
    get => Texture.get_allowThreadedTextureCreationDelegateField();
    set => Texture.set_allowThreadedTextureCreationDelegateField(value);
  }

  public GraphicsTexture graphicsTexture
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      System.IntPtr graphicsTextureInjected = Texture.get_graphicsTexture_Injected(_unity_self);
      return graphicsTextureInjected != System.IntPtr.Zero ? GraphicsTexture.BindingsMarshaller.ConvertToManaged(graphicsTextureInjected) : (GraphicsTexture) null;
    }
  }

  public bool ValidateFormat(RenderTextureFormat format)
  {
    if (SystemInfo.SupportsRenderTextureFormat(format))
      return true;
    Debug.LogError((Il2CppSystem.Object) Il2CppSystem.String.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", (Il2CppSystem.Object) format.ToString()), (Object) this);
    return false;
  }

  public static bool get_isNativeTexture_Injected(System.IntPtr _unity_self)
  {
    return Texture.get_isNativeTexture_InjectedDelegateField(_unity_self);
  }

  public static TextureWrapMode get_wrapModeU_Injected(System.IntPtr _unity_self)
  {
    return Texture.get_wrapModeU_InjectedDelegateField(_unity_self);
  }

  public static TextureWrapMode get_wrapModeV_Injected(System.IntPtr _unity_self)
  {
    return Texture.get_wrapModeV_InjectedDelegateField(_unity_self);
  }

  public static TextureWrapMode get_wrapModeW_Injected(System.IntPtr _unity_self)
  {
    return Texture.get_wrapModeW_InjectedDelegateField(_unity_self);
  }

  public static System.IntPtr GetNativeTexturePtr_Injected(System.IntPtr _unity_self)
  {
    return Texture.GetNativeTexturePtr_InjectedDelegateField(_unity_self);
  }

  public static TextureColorSpace Internal_GetStoredColorSpace_Injected(System.IntPtr _unity_self)
  {
    return Texture.Internal_GetStoredColorSpace_InjectedDelegateField(_unity_self);
  }

  public static System.IntPtr get_graphicsTexture_Injected(System.IntPtr _unity_self)
  {
    return Texture.get_graphicsTexture_InjectedDelegateField(_unity_self);
  }

  private delegate int get_masterTextureLimitDelegate();

  private delegate void set_masterTextureLimitDelegate(int value);

  private delegate int get_globalMipmapLimitDelegate();

  private delegate void set_globalMipmapLimitDelegate(int value);

  private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

  private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

  private delegate void SetGlobalAnisotropicFilteringLimitsDelegate(int forcedMin, int globalMax);

  private delegate ulong get_totalTextureMemoryDelegate();

  private delegate ulong get_desiredTextureMemoryDelegate();

  private delegate ulong get_targetTextureMemoryDelegate();

  private delegate ulong get_currentTextureMemoryDelegate();

  private delegate ulong get_nonStreamingTextureMemoryDelegate();

  private delegate ulong get_streamingMipmapUploadCountDelegate();

  private delegate ulong get_streamingRendererCountDelegate();

  private delegate ulong get_streamingTextureCountDelegate();

  private delegate ulong get_nonStreamingTextureCountDelegate();

  private delegate ulong get_streamingTexturePendingLoadCountDelegate();

  private delegate ulong get_streamingTextureLoadingCountDelegate();

  private delegate void SetStreamingTextureMaterialDebugPropertiesDelegate();

  private delegate void SetStreamingTextureMaterialDebugPropertiesWithSlotDelegate(
    int materialTextureSlot);

  private delegate bool get_streamingTextureForceLoadAllDelegate();

  private delegate void set_streamingTextureForceLoadAllDelegate(bool value);

  private delegate bool get_streamingTextureDiscardUnusedMipsDelegate();

  private delegate void set_streamingTextureDiscardUnusedMipsDelegate(bool value);

  private delegate bool get_allowThreadedTextureCreationDelegate();

  private delegate void set_allowThreadedTextureCreationDelegate(bool value);

  private delegate bool get_isNativeTexture_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TextureWrapMode get_wrapModeU_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TextureWrapMode get_wrapModeV_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TextureWrapMode get_wrapModeW_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetNativeTexturePtr_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TextureColorSpace Internal_GetStoredColorSpace_InjectedDelegate(
    System.IntPtr _unity_self);

  private delegate System.IntPtr get_graphicsTexture_InjectedDelegate(System.IntPtr _unity_self);
}
