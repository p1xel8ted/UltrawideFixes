// Decompiled with JetBrains decompiler
// Type: UnityEngine.Cubemap
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class Cubemap(System.IntPtr pointer) : Texture(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0;
  private static readonly Cubemap.get_format_InjectedDelegate get_format_InjectedDelegateField;
  private static readonly Cubemap.UpdateExternalTexture_InjectedDelegate UpdateExternalTexture_InjectedDelegateField;
  private static readonly Cubemap.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;
  private static readonly Cubemap.SmoothEdges_InjectedDelegate SmoothEdges_InjectedDelegateField;
  private static readonly Cubemap.GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;
  private static readonly Cubemap.SetPixels_InjectedDelegate SetPixels_InjectedDelegateField;
  private static readonly Cubemap.SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;
  private static readonly Cubemap.SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;
  private static readonly Cubemap.CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;
  private static readonly Cubemap.CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;
  private static readonly Cubemap.CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;
  private static readonly Cubemap.GetWritableImageData_InjectedDelegate GetWritableImageData_InjectedDelegateField;
  private static readonly Cubemap.get_isPreProcessed_InjectedDelegate get_isPreProcessed_InjectedDelegateField;
  private static readonly Cubemap.get_streamingMipmaps_InjectedDelegate get_streamingMipmaps_InjectedDelegateField;
  private static readonly Cubemap.get_streamingMipmapsPriority_InjectedDelegate get_streamingMipmapsPriority_InjectedDelegateField;
  private static readonly Cubemap.get_requestedMipmapLevel_InjectedDelegate get_requestedMipmapLevel_InjectedDelegateField;
  private static readonly Cubemap.set_requestedMipmapLevel_InjectedDelegate set_requestedMipmapLevel_InjectedDelegateField;
  private static readonly Cubemap.get_loadAllMips_InjectedDelegate get_loadAllMips_InjectedDelegateField;
  private static readonly Cubemap.set_loadAllMips_InjectedDelegate set_loadAllMips_InjectedDelegateField;
  private static readonly Cubemap.get_desiredMipmapLevel_InjectedDelegate get_desiredMipmapLevel_InjectedDelegateField;
  private static readonly Cubemap.get_loadingMipmapLevel_InjectedDelegate get_loadingMipmapLevel_InjectedDelegateField;
  private static readonly Cubemap.get_loadedMipmapLevel_InjectedDelegate get_loadedMipmapLevel_InjectedDelegateField;
  private static readonly Cubemap.ClearRequestedMipmapLevel_InjectedDelegate ClearRequestedMipmapLevel_InjectedDelegateField;
  private static readonly Cubemap.IsRequestedMipmapLevelLoaded_InjectedDelegate IsRequestedMipmapLevelLoaded_InjectedDelegateField;

  static Cubemap()
  {
    Il2CppClassPointerStore<Cubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Cubemap));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cubemap>.NativeClassPtr);
    Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666783);
    Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666784 /*0x06000DA0*/);
    Cubemap.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666785);
    Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666786);
    Cubemap.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666787);
    Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666788);
    Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666789);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666790);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666791);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666792);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666793);
    Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666794);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666795);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666796);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666797);
    Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666798);
    Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666799);
    Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666800 /*0x06000DB0*/);
    Cubemap.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666801);
    Cubemap.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666802);
    Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666803);
    Cubemap.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666804);
    Cubemap.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666805);
    Cubemap.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100666806);
    Cubemap.get_format_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_format_InjectedDelegate>("UnityEngine.Cubemap::get_format_Injected");
    Cubemap.UpdateExternalTexture_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.UpdateExternalTexture_InjectedDelegate>("UnityEngine.Cubemap::UpdateExternalTexture_Injected");
    Cubemap.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::GetPixelImpl_Injected");
    Cubemap.SmoothEdges_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.SmoothEdges_InjectedDelegate>("UnityEngine.Cubemap::SmoothEdges_Injected");
    Cubemap.GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixels_InjectedDelegate>("UnityEngine.Cubemap::GetPixels_Injected");
    Cubemap.SetPixels_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixels_InjectedDelegate>("UnityEngine.Cubemap::SetPixels_Injected");
    Cubemap.SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplArray_InjectedDelegate>("UnityEngine.Cubemap::SetPixelDataImplArray_Injected");
    Cubemap.SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImpl_InjectedDelegate>("UnityEngine.Cubemap::SetPixelDataImpl_Injected");
    Cubemap.CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.CopyPixels_Full_InjectedDelegate>("UnityEngine.Cubemap::CopyPixels_Full_Injected");
    Cubemap.CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.CopyPixels_Slice_InjectedDelegate>("UnityEngine.Cubemap::CopyPixels_Slice_Injected");
    Cubemap.CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.CopyPixels_Region_InjectedDelegate>("UnityEngine.Cubemap::CopyPixels_Region_Injected");
    Cubemap.GetWritableImageData_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.GetWritableImageData_InjectedDelegate>("UnityEngine.Cubemap::GetWritableImageData_Injected");
    Cubemap.get_isPreProcessed_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_isPreProcessed_InjectedDelegate>("UnityEngine.Cubemap::get_isPreProcessed_Injected");
    Cubemap.get_streamingMipmaps_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmaps_InjectedDelegate>("UnityEngine.Cubemap::get_streamingMipmaps_Injected");
    Cubemap.get_streamingMipmapsPriority_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsPriority_InjectedDelegate>("UnityEngine.Cubemap::get_streamingMipmapsPriority_Injected");
    Cubemap.get_requestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_requestedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_requestedMipmapLevel_Injected");
    Cubemap.set_requestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.set_requestedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::set_requestedMipmapLevel_Injected");
    Cubemap.get_loadAllMips_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadAllMips_InjectedDelegate>("UnityEngine.Cubemap::get_loadAllMips_Injected");
    Cubemap.set_loadAllMips_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.set_loadAllMips_InjectedDelegate>("UnityEngine.Cubemap::set_loadAllMips_Injected");
    Cubemap.get_desiredMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_desiredMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_desiredMipmapLevel_Injected");
    Cubemap.get_loadingMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadingMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_loadingMipmapLevel_Injected");
    Cubemap.get_loadedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_loadedMipmapLevel_Injected");
    Cubemap.ClearRequestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.ClearRequestedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::ClearRequestedMipmapLevel_Injected");
    Cubemap.IsRequestedMipmapLevelLoaded_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.IsRequestedMipmapLevelLoaded_InjectedDelegate>("UnityEngine.Cubemap::IsRequestedMipmapLevelLoaded_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435583, XrefRangeEnd = 435585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_CreateImpl(
    Cubemap mono,
    int ext,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    System.IntPtr nativeTex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ext;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435587, RefRangeEnd = 435589, XrefRangeStart = 435585, XrefRangeEnd = 435587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Create(
    Cubemap mono,
    int ext,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    System.IntPtr nativeTex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ext;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435589, XrefRangeEnd = 435594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe bool isReadable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435594, XrefRangeEnd = 435599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435599, XrefRangeEnd = 435603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixelImpl(int image, int mip, int x, int y, Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &image;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435603, XrefRangeEnd = 435604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateFormat(TextureFormat format, int width)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435604, XrefRangeEnd = 435609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateFormat(GraphicsFormat format, int width)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435609, XrefRangeEnd = 435615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435615, XrefRangeEnd = 435617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 435622, RefRangeEnd = 435625, XrefRangeStart = 435617, XrefRangeEnd = 435622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 435644, RefRangeEnd = 435647, XrefRangeStart = 435625, XrefRangeEnd = 435644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(
    int width,
    GraphicsFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 435665, RefRangeEnd = 435669, XrefRangeStart = 435647, XrefRangeEnd = 435665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(
    int width,
    TextureFormat textureFormat,
    int mipCount,
    System.IntPtr nativeTex,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435669, XrefRangeEnd = 435675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435675, XrefRangeEnd = 435681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(
    int width,
    TextureFormat textureFormat,
    bool mipChain,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435681, XrefRangeEnd = 435682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(int width, TextureFormat format, int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435682, XrefRangeEnd = 435683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 435687, RefRangeEnd = 435690, XrefRangeStart = 435683, XrefRangeEnd = 435687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixel(CubemapFace face, int x, int y, Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435690, XrefRangeEnd = 435694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixel(CubemapFace face, int x, int y, Color color, int mip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435694, XrefRangeEnd = 435701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 435708, RefRangeEnd = 435711, XrefRangeStart = 435701, XrefRangeEnd = 435708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void ValidateIsNotCrunched(TextureCreationFlags flags)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flags
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435711, XrefRangeEnd = 435713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435713, XrefRangeEnd = 435715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new static unsafe bool get_isReadable_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435715, XrefRangeEnd = 435717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPixelImpl_Injected(
    System.IntPtr _unity_self,
    int image,
    int mip,
    int x,
    int y,
    [In] ref Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &image;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public TextureFormat format
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_format_Injected(_unity_self);
    }
  }

  public void UpdateExternalTexture(System.IntPtr nativeTexture)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Cubemap.UpdateExternalTexture_Injected(_unity_self, nativeTexture);
  }

  public Color GetPixelImpl(int image, int mip, int x, int y)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Color ret;
    Cubemap.GetPixelImpl_Injected(_unity_self, image, mip, x, y, out ret);
    return ret;
  }

  public void SmoothEdges(int smoothRegionWidthInPixels)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Cubemap.SmoothEdges_Injected(_unity_self, smoothRegionWidthInPixels);
  }

  public void SmoothEdges() => this.SmoothEdges(1);

  public Il2CppStructArray<Color> GetPixels(CubemapFace face, int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Cubemap.GetPixels_Injected(_unity_self, face, miplevel);
  }

  public Il2CppStructArray<Color> GetPixels(CubemapFace face) => this.GetPixels(face, 0);

  public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<Color> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Color>) ref span).\u002Ector((Il2CppArrayBase<Color>) colors);
    fixed (Color* begin = &((Il2CppSystem.Span<Color>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper colors1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Color>) ref span).Length);
      Cubemap.SetPixels_Injected(_unity_self, ref colors1, face, miplevel);
    }
  }

  public bool SetPixelDataImplArray(
    Il2CppSystem.Array data,
    int mipLevel,
    int face,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = default (int))
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Cubemap.SetPixelDataImplArray_Injected(_unity_self, data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public bool SetPixelDataImpl(
    System.IntPtr data,
    int mipLevel,
    int face,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = default (int))
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Cubemap.SetPixelDataImpl_Injected(_unity_self, data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face)
  {
    this.SetPixels(colors, face, 0);
  }

  public void CopyPixels_Full(Texture src)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Cubemap.CopyPixels_Full_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src));
  }

  public void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstFace, int dstMip)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Cubemap.CopyPixels_Slice_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, srcMip, dstFace, dstMip);
  }

  public void CopyPixels_Region(
    Texture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    int dstFace,
    int dstMip,
    int dstX,
    int dstY)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Cubemap.CopyPixels_Region_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstFace, dstMip, dstX, dstY);
  }

  public System.IntPtr GetWritableImageData(int frame)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Cubemap.GetWritableImageData_Injected(_unity_self, frame);
  }

  public bool isPreProcessed
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_isPreProcessed_Injected(_unity_self);
    }
  }

  public bool streamingMipmaps
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_streamingMipmaps_Injected(_unity_self);
    }
  }

  public int streamingMipmapsPriority
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_streamingMipmapsPriority_Injected(_unity_self);
    }
  }

  public int requestedMipmapLevel
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_requestedMipmapLevel_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Cubemap.set_requestedMipmapLevel_Injected(_unity_self, value);
    }
  }

  public bool loadAllMips
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_loadAllMips_Injected(_unity_self);
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Cubemap.set_loadAllMips_Injected(_unity_self, value);
    }
  }

  public int desiredMipmapLevel
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_desiredMipmapLevel_Injected(_unity_self);
    }
  }

  public int loadingMipmapLevel
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_loadingMipmapLevel_Injected(_unity_self);
    }
  }

  public int loadedMipmapLevel
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Cubemap.get_loadedMipmapLevel_Injected(_unity_self);
    }
  }

  public void ClearRequestedMipmapLevel()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Cubemap.ClearRequestedMipmapLevel_Injected(_unity_self);
  }

  public bool IsRequestedMipmapLevelLoaded()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Cubemap>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Cubemap.IsRequestedMipmapLevelLoaded_Injected(_unity_self);
  }

  public static Cubemap CreateExternalTexture(
    int width,
    TextureFormat format,
    bool mipmap,
    System.IntPtr nativeTex)
  {
    if (nativeTex == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ArgumentException("nativeTex can not be null");
    return new Cubemap(width, format, mipmap ? Texture.GenerateAllMips : 1, nativeTex, false);
  }

  public void SetPixelData<T>(
    Il2CppArrayBase<T> data,
    int mipLevel,
    CubemapFace face,
    int sourceDataStartIndex = default (int))
  {
    if (sourceDataStartIndex < 0)
      throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (data == null || ((Il2CppArrayBase) data).Length == 0)
      throw new UnityException("No texture data provided to SetPixelData.");
    this.SetPixelDataImplArray((Il2CppSystem.Array) data, mipLevel, (int) face, Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase) data).Length, sourceDataStartIndex);
  }

  public unsafe void SetPixelData<T>(
    NativeArray<T> data,
    int mipLevel,
    CubemapFace face,
    int sourceDataStartIndex = default (int))
    where T : struct
  {
    if (sourceDataStartIndex < 0)
      throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!((NativeArray<T>) ref data).IsCreated || ((NativeArray<T>) ref data).Length == 0)
      throw new UnityException("No texture data provided to SetPixelData.");
    this.SetPixelDataImpl((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int) face, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>) ref data).Length, sourceDataStartIndex);
  }

  public unsafe NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) where T : struct
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (mipLevel < 0 || mipLevel >= this.mipmapCount)
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through ", (this.mipmapCount - 1).ToString()));
    if (face < CubemapFace.PositiveX || face >= (CubemapFace.PositiveY | CubemapFace.PositiveZ))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in face ", face.ToString(), " is invalid. The valid range is 0 through 5."));
    if (this.GetWritableImageData(0).ToInt64() == 0L)
      throw new UnityException(Il2CppSystem.String.Concat("Texture '", this.name, "' has no data."));
    ulong pixelDataOffset1 = this.GetPixelDataOffset(this.mipmapCount, (int) face);
    ulong pixelDataOffset2 = this.GetPixelDataOffset(mipLevel, (int) face);
    ulong length = this.GetPixelDataSize(mipLevel, (int) face) / (ulong) UnsafeUtility.SizeOf<T>();
    if (length > (ulong) int.MaxValue)
      throw this.CreateNativeArrayLengthOverflowException();
    return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*) new System.IntPtr((long) this.GetWritableImageData(0) + ((long) pixelDataOffset1 * (long) face + (long) pixelDataOffset2)), (int) length, Allocator.None);
  }

  public Color GetPixel(CubemapFace face, int x, int y) => this.GetPixel(face, x, y, 0);

  public Color GetPixel(CubemapFace face, int x, int y, int mip)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    return this.GetPixelImpl((int) face, mip, x, y);
  }

  public void Apply(bool updateMipmaps) => this.Apply(updateMipmaps, false);

  public void CopyPixels(Texture src)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!src.isReadable)
      throw this.CreateNonReadableException(src);
    this.CopyPixels_Full(src);
  }

  public void CopyPixels(
    Texture src,
    int srcElement,
    int srcMip,
    CubemapFace dstFace,
    int dstMip)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!src.isReadable)
      throw this.CreateNonReadableException(src);
    this.CopyPixels_Slice(src, srcElement, srcMip, (int) dstFace, dstMip);
  }

  public void CopyPixels(
    Texture src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    CubemapFace dstFace,
    int dstMip,
    int dstX,
    int dstY)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!src.isReadable)
      throw this.CreateNonReadableException(src);
    this.CopyPixels_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, (int) dstFace, dstMip, dstX, dstY);
  }

  public static TextureFormat get_format_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_format_InjectedDelegateField(_unity_self);
  }

  public static void UpdateExternalTexture_Injected(System.IntPtr _unity_self, System.IntPtr nativeTexture)
  {
    Cubemap.UpdateExternalTexture_InjectedDelegateField(_unity_self, nativeTexture);
  }

  public static void GetPixelImpl_Injected(
    System.IntPtr _unity_self,
    int image,
    int mip,
    int x,
    int y,
    out Color ret)
  {
    Cubemap.GetPixelImpl_InjectedDelegateField(_unity_self, image, mip, x, y, (System.IntPtr) ref ret);
  }

  public static void SmoothEdges_Injected(System.IntPtr _unity_self, int smoothRegionWidthInPixels)
  {
    Cubemap.SmoothEdges_InjectedDelegateField(_unity_self, smoothRegionWidthInPixels);
  }

  public static Il2CppStructArray<Color> GetPixels_Injected(
    System.IntPtr _unity_self,
    CubemapFace face,
    int miplevel)
  {
    System.IntPtr num = Cubemap.GetPixels_InjectedDelegateField(_unity_self, face, miplevel);
    return num == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num);
  }

  public static void SetPixels_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    CubemapFace face,
    int miplevel)
  {
    Cubemap.SetPixels_InjectedDelegateField(_unity_self, (System.IntPtr) ref colors, face, miplevel);
  }

  public static bool SetPixelDataImplArray_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int mipLevel,
    int face,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    return Cubemap.SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public static bool SetPixelDataImpl_Injected(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int face,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    return Cubemap.SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public static void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
  {
    Cubemap.CopyPixels_Full_InjectedDelegateField(_unity_self, src);
  }

  public static void CopyPixels_Slice_Injected(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int dstFace,
    int dstMip)
  {
    Cubemap.CopyPixels_Slice_InjectedDelegateField(_unity_self, src, srcElement, srcMip, dstFace, dstMip);
  }

  public static void CopyPixels_Region_Injected(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    int dstFace,
    int dstMip,
    int dstX,
    int dstY)
  {
    Cubemap.CopyPixels_Region_InjectedDelegateField(_unity_self, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstFace, dstMip, dstX, dstY);
  }

  public static System.IntPtr GetWritableImageData_Injected(System.IntPtr _unity_self, int frame)
  {
    return Cubemap.GetWritableImageData_InjectedDelegateField(_unity_self, frame);
  }

  public static bool get_isPreProcessed_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_isPreProcessed_InjectedDelegateField(_unity_self);
  }

  public static bool get_streamingMipmaps_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_streamingMipmaps_InjectedDelegateField(_unity_self);
  }

  public static int get_streamingMipmapsPriority_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_streamingMipmapsPriority_InjectedDelegateField(_unity_self);
  }

  public static int get_requestedMipmapLevel_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_requestedMipmapLevel_InjectedDelegateField(_unity_self);
  }

  public static void set_requestedMipmapLevel_Injected(System.IntPtr _unity_self, int value)
  {
    Cubemap.set_requestedMipmapLevel_InjectedDelegateField(_unity_self, value);
  }

  public static bool get_loadAllMips_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_loadAllMips_InjectedDelegateField(_unity_self);
  }

  public static void set_loadAllMips_Injected(System.IntPtr _unity_self, bool value)
  {
    Cubemap.set_loadAllMips_InjectedDelegateField(_unity_self, value);
  }

  public static int get_desiredMipmapLevel_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_desiredMipmapLevel_InjectedDelegateField(_unity_self);
  }

  public static int get_loadingMipmapLevel_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_loadingMipmapLevel_InjectedDelegateField(_unity_self);
  }

  public static int get_loadedMipmapLevel_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.get_loadedMipmapLevel_InjectedDelegateField(_unity_self);
  }

  public static void ClearRequestedMipmapLevel_Injected(System.IntPtr _unity_self)
  {
    Cubemap.ClearRequestedMipmapLevel_InjectedDelegateField(_unity_self);
  }

  public static bool IsRequestedMipmapLevelLoaded_Injected(System.IntPtr _unity_self)
  {
    return Cubemap.IsRequestedMipmapLevelLoaded_InjectedDelegateField(_unity_self);
  }

  private delegate TextureFormat get_format_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void UpdateExternalTexture_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr nativeTexture);

  private delegate void GetPixelImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int image,
    int mip,
    int x,
    int y,
    [Out] System.IntPtr ret);

  private delegate void SmoothEdges_InjectedDelegate(
    System.IntPtr _unity_self,
    int smoothRegionWidthInPixels);

  private delegate System.IntPtr GetPixels_InjectedDelegate(
    System.IntPtr _unity_self,
    CubemapFace face,
    int miplevel);

  private delegate void SetPixels_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr colors,
    CubemapFace face,
    int miplevel);

  private delegate bool SetPixelDataImplArray_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int face,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex);

  private delegate bool SetPixelDataImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int face,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex);

  private delegate void CopyPixels_Full_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src);

  private delegate void CopyPixels_Slice_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int dstFace,
    int dstMip);

  private delegate void CopyPixels_Region_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int srcX,
    int srcY,
    int srcWidth,
    int srcHeight,
    int dstFace,
    int dstMip,
    int dstX,
    int dstY);

  private delegate System.IntPtr GetWritableImageData_InjectedDelegate(
    System.IntPtr _unity_self,
    int frame);

  private delegate bool get_isPreProcessed_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_streamingMipmaps_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_streamingMipmapsPriority_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_requestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_requestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self, int value);

  private delegate bool get_loadAllMips_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_loadAllMips_InjectedDelegate(System.IntPtr _unity_self, bool value);

  private delegate int get_desiredMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_loadingMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_loadedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ClearRequestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool IsRequestedMipmapLevelLoaded_InjectedDelegate(System.IntPtr _unity_self);
}
