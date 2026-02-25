// Decompiled with JetBrains decompiler
// Type: UnityEngine.Texture2DArray
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class Texture2DArray(System.IntPtr pointer) : Texture(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depth_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreMipmapLimit_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIgnoreMipmapLimitAndReload_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mipmapLimitGroup_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_activeMipmapLimit_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelDataImplArray_Private_Boolean_Array_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Full_Private_Void_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Slice_Private_Void_Texture_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Region_Private_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetImageData_Private_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_MipmapLimitDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ignoreMipmapLimit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ignoreMipmapLimit_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depth_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Injected_Private_Static_TextureFormat_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IgnoreMipmapLimit_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIgnoreMipmapLimitAndReload_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mipmapLimitGroup_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_activeMipmapLimit_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Injected_Private_Static_Il2CppStructArray_1_Color_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelDataImplArray_Injected_Private_Static_Boolean_IntPtr_Array_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelDataImpl_Injected_Private_Static_Boolean_IntPtr_IntPtr_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels32_Injected_Private_Static_Il2CppStructArray_1_Color32_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels32_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Full_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Slice_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPixels_Region_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetImageData_Injected_Private_Static_IntPtr_IntPtr_0;

  static Texture2DArray()
  {
    Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Texture2DArray));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr);
    Texture2DArray.NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666835);
    Texture2DArray.NativeMethodInfoPtr_get_depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666836);
    Texture2DArray.NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666837);
    Texture2DArray.NativeMethodInfoPtr_IgnoreMipmapLimit_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666838);
    Texture2DArray.NativeMethodInfoPtr_SetIgnoreMipmapLimitAndReload_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666839);
    Texture2DArray.NativeMethodInfoPtr_get_mipmapLimitGroup_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666840);
    Texture2DArray.NativeMethodInfoPtr_get_activeMipmapLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666841);
    Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666842);
    Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666843);
    Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666844);
    Texture2DArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666845);
    Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666846);
    Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666847);
    Texture2DArray.NativeMethodInfoPtr_SetPixelDataImplArray_Private_Boolean_Array_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666848 /*0x06000DE0*/);
    Texture2DArray.NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666849);
    Texture2DArray.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666850);
    Texture2DArray.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666851);
    Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666852);
    Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666853);
    Texture2DArray.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666854);
    Texture2DArray.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666855);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Full_Private_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666856);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Slice_Private_Void_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666857);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Region_Private_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666858);
    Texture2DArray.NativeMethodInfoPtr_GetImageData_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666859);
    Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666860);
    Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666861);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666862);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666863);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666864 /*0x06000DF0*/);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666865);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666866);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666867);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666868);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666869);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666870);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666871);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666872);
    Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666873);
    Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666874);
    Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666875);
    Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666876);
    Texture2DArray.NativeMethodInfoPtr_SetPixelData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666877);
    Texture2DArray.NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666878);
    Texture2DArray.NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666879);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666880 /*0x06000E00*/);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666881 /*0x06000E01*/);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666882 /*0x06000E02*/);
    Texture2DArray.NativeMethodInfoPtr_get_ignoreMipmapLimit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666883 /*0x06000E03*/);
    Texture2DArray.NativeMethodInfoPtr_set_ignoreMipmapLimit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666884 /*0x06000E04*/);
    Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666885 /*0x06000E05*/);
    Texture2DArray.NativeMethodInfoPtr_get_depth_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666886 /*0x06000E06*/);
    Texture2DArray.NativeMethodInfoPtr_get_format_Injected_Private_Static_TextureFormat_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666887 /*0x06000E07*/);
    Texture2DArray.NativeMethodInfoPtr_IgnoreMipmapLimit_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666888 /*0x06000E08*/);
    Texture2DArray.NativeMethodInfoPtr_SetIgnoreMipmapLimitAndReload_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666889 /*0x06000E09*/);
    Texture2DArray.NativeMethodInfoPtr_get_mipmapLimitGroup_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666890 /*0x06000E0A*/);
    Texture2DArray.NativeMethodInfoPtr_get_activeMipmapLimit_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666891 /*0x06000E0B*/);
    Texture2DArray.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666892 /*0x06000E0C*/);
    Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666893 /*0x06000E0D*/);
    Texture2DArray.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666894 /*0x06000E0E*/);
    Texture2DArray.NativeMethodInfoPtr_GetPixels_Injected_Private_Static_Il2CppStructArray_1_Color_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666895 /*0x06000E0F*/);
    Texture2DArray.NativeMethodInfoPtr_SetPixelDataImplArray_Injected_Private_Static_Boolean_IntPtr_Array_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666896 /*0x06000E10*/);
    Texture2DArray.NativeMethodInfoPtr_SetPixelDataImpl_Injected_Private_Static_Boolean_IntPtr_IntPtr_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666897);
    Texture2DArray.NativeMethodInfoPtr_GetPixels32_Injected_Private_Static_Il2CppStructArray_1_Color32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666898);
    Texture2DArray.NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666899);
    Texture2DArray.NativeMethodInfoPtr_SetPixels32_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666900);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Full_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666901);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Slice_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666902);
    Texture2DArray.NativeMethodInfoPtr_CopyPixels_Region_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666903);
    Texture2DArray.NativeMethodInfoPtr_GetImageData_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100666904);
  }

  public static unsafe int allSlices
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 435883, RefRangeEnd = 435886, XrefRangeStart = 435881, XrefRangeEnd = 435883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int depth
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 435891, RefRangeEnd = 435892, XrefRangeStart = 435886, XrefRangeEnd = 435891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe TextureFormat format
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435892, XrefRangeEnd = 435897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TextureFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435897, XrefRangeEnd = 435902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IgnoreMipmapLimit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_IgnoreMipmapLimit_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435902, XrefRangeEnd = 435907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetIgnoreMipmapLimitAndReload(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetIgnoreMipmapLimitAndReload_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string mipmapLimitGroup
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435907, XrefRangeEnd = 435914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_mipmapLimitGroup_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe int activeMipmapLimit
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435914, XrefRangeEnd = 435919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_activeMipmapLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe bool isReadable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435919, XrefRangeEnd = 435924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 435938, RefRangeEnd = 435939, XrefRangeStart = 435924, XrefRangeEnd = 435938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_CreateImpl(
    Texture2DArray mono,
    int w,
    int h,
    int d,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    bool ignoreMipmapLimit,
    string mipmapLimitGroupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreMipmapLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435940, RefRangeEnd = 435942, XrefRangeStart = 435939, XrefRangeEnd = 435940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Create(
    Texture2DArray mono,
    int w,
    int h,
    int d,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    bool ignoreMipmapLimit,
    string mipmapLimitGroupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreMipmapLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435942, XrefRangeEnd = 435947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435947, XrefRangeEnd = 435952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<Color> GetPixels(int arrayElement, int miplevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435952, XrefRangeEnd = 435957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<Color> GetPixels(int arrayElement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &arrayElement
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 435962, RefRangeEnd = 435963, XrefRangeStart = 435957, XrefRangeEnd = 435962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool SetPixelDataImplArray(
    Il2CppSystem.Array data,
    int mipLevel,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &elementSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dataArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceDataStartIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixelDataImplArray_Private_Boolean_Array_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 435968, RefRangeEnd = 435969, XrefRangeStart = 435963, XrefRangeEnd = 435968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool SetPixelDataImpl(
    System.IntPtr data,
    int mipLevel,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &elementSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dataArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceDataStartIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435969, XrefRangeEnd = 435974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<Color32> GetPixels32(int arrayElement, int miplevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435974, XrefRangeEnd = 435979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<Color32> GetPixels32(int arrayElement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &arrayElement
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435979, XrefRangeEnd = 435990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels(Il2CppStructArray<Color> colors, int arrayElement, int miplevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435990, XrefRangeEnd = 436001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels(Il2CppStructArray<Color> colors, int arrayElement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436001, XrefRangeEnd = 436012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement, int miplevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436012, XrefRangeEnd = 436023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436023, XrefRangeEnd = 436031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyPixels_Full(Texture src)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Full_Private_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436031, XrefRangeEnd = 436039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyPixels_Slice(
    Texture src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Slice_Private_Void_Texture_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436039, XrefRangeEnd = 436047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyPixels_Region(
    Texture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[11];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &srcY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &srcHeight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dstX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dstY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Region_Private_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 436052, RefRangeEnd = 436053, XrefRangeStart = 436047, XrefRangeEnd = 436052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe System.IntPtr GetImageData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetImageData_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436053, XrefRangeEnd = 436054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateFormat(TextureFormat format, int width, int height)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436054, XrefRangeEnd = 436059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateFormat(GraphicsFormat format, int width, int height)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436059, XrefRangeEnd = 436065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    DefaultFormat format,
    TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436065, XrefRangeEnd = 436067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    DefaultFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436067, XrefRangeEnd = 436069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    DefaultFormat format,
    TextureCreationFlags flags,
    int mipCount,
    MipmapLimitDescriptor mipmapLimitDescriptor)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mipmapLimitDescriptor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436069, XrefRangeEnd = 436074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436074, XrefRangeEnd = 436075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 436094, RefRangeEnd = 436099, XrefRangeStart = 436075, XrefRangeEnd = 436094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    TextureCreationFlags flags,
    int mipCount,
    MipmapLimitDescriptor mipmapLimitDescriptor)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mipmapLimitDescriptor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 436117, RefRangeEnd = 436122, XrefRangeStart = 436099, XrefRangeEnd = 436117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    int mipCount,
    bool linear,
    bool createUninitialized,
    MipmapLimitDescriptor mipmapLimitDescriptor)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) mipmapLimitDescriptor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436122, XrefRangeEnd = 436123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    int mipCount,
    bool linear,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436123, XrefRangeEnd = 436124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    int mipCount,
    bool linear)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436124, XrefRangeEnd = 436130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    bool mipChain,
    bool linear,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436130, XrefRangeEnd = 436136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    bool mipChain,
    bool linear)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 436142, RefRangeEnd = 436143, XrefRangeStart = 436136, XrefRangeEnd = 436142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2DArray(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    bool mipChain)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 436150, RefRangeEnd = 436152, XrefRangeStart = 436143, XrefRangeEnd = 436150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436152, XrefRangeEnd = 436153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(bool updateMipmaps)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &updateMipmaps
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436153, XrefRangeEnd = 436154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436154, XrefRangeEnd = 436161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixelData<T>(
    Il2CppArrayBase<T> data,
    int mipLevel,
    int element,
    int sourceDataStartIndex = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceDataStartIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.MethodInfoStoreGeneric_SetPixelData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436161, XrefRangeEnd = 436164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixelData<T>(
    NativeArray<T> data,
    int mipLevel,
    int element,
    int sourceDataStartIndex = 0)
    where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceDataStartIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.MethodInfoStoreGeneric_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436164, XrefRangeEnd = 436175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> GetPixelData<T>(int mipLevel, int element) where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.MethodInfoStoreGeneric_GetPixelData_Public_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436175, XrefRangeEnd = 436189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyPixels(Texture src)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436189, XrefRangeEnd = 436203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyPixels(
    Texture src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436203, XrefRangeEnd = 436217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyPixels(
    Texture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[11];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &srcY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &srcHeight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dstX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dstY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Public_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool ignoreMipmapLimit
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_ignoreMipmapLimit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436217, XrefRangeEnd = 436224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_set_ignoreMipmapLimit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public static unsafe void ValidateIsNotCrunched(TextureCreationFlags flags)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flags
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436224, XrefRangeEnd = 436226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_depth_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_depth_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436226, XrefRangeEnd = 436228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TextureFormat get_format_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_format_Injected_Private_Static_TextureFormat_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TextureFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436228, XrefRangeEnd = 436230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IgnoreMipmapLimit_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_IgnoreMipmapLimit_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436230, XrefRangeEnd = 436232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetIgnoreMipmapLimitAndReload_Injected(System.IntPtr _unity_self, bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetIgnoreMipmapLimitAndReload_Injected_Private_Static_Void_IntPtr_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436232, XrefRangeEnd = 436234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_mipmapLimitGroup_Injected(
    System.IntPtr _unity_self,
    out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_mipmapLimitGroup_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436234, XrefRangeEnd = 436236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_activeMipmapLimit_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_activeMipmapLimit_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436236, XrefRangeEnd = 436238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new static unsafe bool get_isReadable_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436238, XrefRangeEnd = 436240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_CreateImpl_Injected(
    Texture2DArray mono,
    int w,
    int h,
    int d,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    bool ignoreMipmapLimit,
    ref ManagedSpanWrapper mipmapLimitGroupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[10];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreMipmapLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref mipmapLimitGroupName;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436240, XrefRangeEnd = 436242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ApplyImpl_Injected(
    System.IntPtr _unity_self,
    bool updateMipmaps,
    bool makeNoLongerReadable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436242, XrefRangeEnd = 436244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<Color> GetPixels_Injected(
    System.IntPtr _unity_self,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels_Injected_Private_Static_Il2CppStructArray_1_Color_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436244, XrefRangeEnd = 436246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetPixelDataImplArray_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int mipLevel,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elementSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dataArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceDataStartIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixelDataImplArray_Injected_Private_Static_Boolean_IntPtr_Array_Int32_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436246, XrefRangeEnd = 436248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetPixelDataImpl_Injected(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elementSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dataArraySize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceDataStartIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixelDataImpl_Injected_Private_Static_Boolean_IntPtr_IntPtr_Int32_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436248, XrefRangeEnd = 436250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<Color32> GetPixels32_Injected(
    System.IntPtr _unity_self,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels32_Injected_Private_Static_Il2CppStructArray_1_Color32_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436250, XrefRangeEnd = 436252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPixels_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref colors;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436252, XrefRangeEnd = 436254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPixels32_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref colors;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels32_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436254, XrefRangeEnd = 436256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &src;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Full_Injected_Private_Static_Void_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436256, XrefRangeEnd = 436258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyPixels_Slice_Injected(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Slice_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436258, XrefRangeEnd = 436260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyPixels_Region_Injected(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &srcMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &srcX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &srcY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &srcWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &srcHeight;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &dstElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dstMip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dstX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &dstY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_CopyPixels_Region_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436260, XrefRangeEnd = 436262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetImageData_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetImageData_Injected_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  private sealed class MethodInfoStoreGeneric_SetPixelData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2DArray.NativeMethodInfoPtr_SetPixelData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2DArray.NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetPixelData_Public_NativeArray_1_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2DArray.NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
