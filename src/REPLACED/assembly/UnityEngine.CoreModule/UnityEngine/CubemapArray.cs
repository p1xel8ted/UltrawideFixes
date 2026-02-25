// Decompiled with JetBrains decompiler
// Type: UnityEngine.CubemapArray
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class CubemapArray(System.IntPtr pointer) : Texture(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CubemapFace_Int32_Int32_0;
  private static readonly CubemapArray.get_cubemapCount_InjectedDelegate get_cubemapCount_InjectedDelegateField;
  private static readonly CubemapArray.get_format_InjectedDelegate get_format_InjectedDelegateField;
  private static readonly CubemapArray.GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;
  private static readonly CubemapArray.GetPixels32_InjectedDelegate GetPixels32_InjectedDelegateField;
  private static readonly CubemapArray.SetPixels32_InjectedDelegate SetPixels32_InjectedDelegateField;
  private static readonly CubemapArray.SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;
  private static readonly CubemapArray.SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;
  private static readonly CubemapArray.CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;
  private static readonly CubemapArray.CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;
  private static readonly CubemapArray.CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;
  private static readonly CubemapArray.GetImageData_InjectedDelegate GetImageData_InjectedDelegateField;

  static CubemapArray()
  {
    Il2CppClassPointerStore<CubemapArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CubemapArray));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr);
    CubemapArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666905);
    CubemapArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666906);
    CubemapArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666907);
    CubemapArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666908);
    CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666909);
    CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666910);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666911);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666912 /*0x06000E20*/);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666913);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666914);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666915);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666916);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666917);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666918);
    CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666919);
    CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666920);
    CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666921);
    CubemapArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666922);
    CubemapArray.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666923);
    CubemapArray.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666924);
    CubemapArray.NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CubemapFace_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100666925);
    CubemapArray.get_cubemapCount_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.get_cubemapCount_InjectedDelegate>("UnityEngine.CubemapArray::get_cubemapCount_Injected");
    CubemapArray.get_format_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.get_format_InjectedDelegate>("UnityEngine.CubemapArray::get_format_Injected");
    CubemapArray.GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.GetPixels_InjectedDelegate>("UnityEngine.CubemapArray::GetPixels_Injected");
    CubemapArray.GetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.GetPixels32_InjectedDelegate>("UnityEngine.CubemapArray::GetPixels32_Injected");
    CubemapArray.SetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixels32_InjectedDelegate>("UnityEngine.CubemapArray::SetPixels32_Injected");
    CubemapArray.SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelDataImplArray_InjectedDelegate>("UnityEngine.CubemapArray::SetPixelDataImplArray_Injected");
    CubemapArray.SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.SetPixelDataImpl_InjectedDelegate>("UnityEngine.CubemapArray::SetPixelDataImpl_Injected");
    CubemapArray.CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.CopyPixels_Full_InjectedDelegate>("UnityEngine.CubemapArray::CopyPixels_Full_Injected");
    CubemapArray.CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.CopyPixels_Slice_InjectedDelegate>("UnityEngine.CubemapArray::CopyPixels_Slice_Injected");
    CubemapArray.CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.CopyPixels_Region_InjectedDelegate>("UnityEngine.CubemapArray::CopyPixels_Region_Injected");
    CubemapArray.GetImageData_InjectedDelegateField = IL2CPP.ResolveICall<CubemapArray.GetImageData_InjectedDelegate>("UnityEngine.CubemapArray::GetImageData_Injected");
  }

  public override unsafe bool isReadable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436262, XrefRangeEnd = 436267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436267, XrefRangeEnd = 436269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_CreateImpl(
    CubemapArray mono,
    int ext,
    int count,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ext;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 436271, RefRangeEnd = 436273, XrefRangeStart = 436269, XrefRangeEnd = 436271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Create(
    CubemapArray mono,
    int ext,
    int count,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ext;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436273, XrefRangeEnd = 436278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436278, XrefRangeEnd = 436289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels(
    Il2CppStructArray<Color> colors,
    CubemapFace face,
    int arrayElement,
    int miplevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 436300, RefRangeEnd = 436301, XrefRangeStart = 436289, XrefRangeEnd = 436300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436301, XrefRangeEnd = 436307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    DefaultFormat format,
    TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436307, XrefRangeEnd = 436309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    DefaultFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 436314, RefRangeEnd = 436315, XrefRangeStart = 436309, XrefRangeEnd = 436314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    GraphicsFormat format,
    TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 436330, RefRangeEnd = 436333, XrefRangeStart = 436315, XrefRangeEnd = 436330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    GraphicsFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 436351, RefRangeEnd = 436355, XrefRangeStart = 436333, XrefRangeEnd = 436351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    TextureFormat textureFormat,
    int mipCount,
    bool linear,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436355, XrefRangeEnd = 436356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    TextureFormat textureFormat,
    int mipCount,
    bool linear)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436356, XrefRangeEnd = 436362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    TextureFormat textureFormat,
    bool mipChain,
    bool linear,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436362, XrefRangeEnd = 436368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    TextureFormat textureFormat,
    bool mipChain,
    bool linear)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &linear;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436368, XrefRangeEnd = 436374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CubemapArray(
    int width,
    int cubemapCount,
    TextureFormat textureFormat,
    bool mipChain)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436374, XrefRangeEnd = 436381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 436388, RefRangeEnd = 436389, XrefRangeStart = 436381, XrefRangeEnd = 436388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436389, XrefRangeEnd = 436391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new static unsafe bool get_isReadable_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436391, XrefRangeEnd = 436393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436393, XrefRangeEnd = 436395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPixels_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    CubemapFace face,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref colors;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &face;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayElement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CubemapArray.NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CubemapFace_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public int cubemapCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CubemapArray.get_cubemapCount_Injected(_unity_self);
    }
  }

  public TextureFormat format
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return CubemapArray.get_format_Injected(_unity_self);
    }
  }

  public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement, int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CubemapArray.GetPixels_Injected(_unity_self, face, arrayElement, miplevel);
  }

  public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement)
  {
    return this.GetPixels(face, arrayElement, 0);
  }

  public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement, int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CubemapArray.GetPixels32_Injected(_unity_self, face, arrayElement, miplevel);
  }

  public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement)
  {
    return this.GetPixels32(face, arrayElement, 0);
  }

  public unsafe void SetPixels32(
    Il2CppStructArray<Color32> colors,
    CubemapFace face,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<Color32> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Color32>) ref span).\u002Ector((Il2CppArrayBase<Color32>) colors);
    fixed (Color32* begin = &((Il2CppSystem.Span<Color32>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper colors1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Color32>) ref span).Length);
      CubemapArray.SetPixels32_Injected(_unity_self, ref colors1, face, arrayElement, miplevel);
    }
  }

  public void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement)
  {
    this.SetPixels32(colors, face, arrayElement, 0);
  }

  public bool SetPixelDataImplArray(
    Il2CppSystem.Array data,
    int mipLevel,
    int face,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = default (int))
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CubemapArray.SetPixelDataImplArray_Injected(_unity_self, data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public bool SetPixelDataImpl(
    System.IntPtr data,
    int mipLevel,
    int face,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = default (int))
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CubemapArray.SetPixelDataImpl_Injected(_unity_self, data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public void CopyPixels_Full(Texture src)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CubemapArray.CopyPixels_Full_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src));
  }

  public void CopyPixels_Slice(
    Texture src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CubemapArray.CopyPixels_Slice_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, srcMip, dstElement, dstMip);
  }

  public void CopyPixels_Region(
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
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    CubemapArray.CopyPixels_Region_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
  }

  public System.IntPtr GetImageData()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<CubemapArray>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return CubemapArray.GetImageData_Injected(_unity_self);
  }

  public void Apply(bool updateMipmaps) => this.Apply(updateMipmaps, false);

  public void SetPixelData<T>(
    Il2CppArrayBase<T> data,
    int mipLevel,
    CubemapFace face,
    int element,
    int sourceDataStartIndex = default (int))
  {
    if (sourceDataStartIndex < 0)
      throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (data == null || ((Il2CppArrayBase) data).Length == 0)
      throw new UnityException("No texture data provided to SetPixelData.");
    this.SetPixelDataImplArray((Il2CppSystem.Array) data, mipLevel, (int) face, element, Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase) data).Length, sourceDataStartIndex);
  }

  public unsafe void SetPixelData<T>(
    NativeArray<T> data,
    int mipLevel,
    CubemapFace face,
    int element,
    int sourceDataStartIndex = default (int))
    where T : struct
  {
    if (sourceDataStartIndex < 0)
      throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!((NativeArray<T>) ref data).IsCreated || ((NativeArray<T>) ref data).Length == 0)
      throw new UnityException("No texture data provided to SetPixelData.");
    this.SetPixelDataImpl((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int) face, element, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>) ref data).Length, sourceDataStartIndex);
  }

  public unsafe NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face, int element) where T : struct
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (mipLevel < 0 || mipLevel >= this.mipmapCount)
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through ", (this.mipmapCount - 1).ToString()));
    if (face < CubemapFace.PositiveX || face >= (CubemapFace.PositiveY | CubemapFace.PositiveZ))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in face ", face.ToString(), " is invalid.  The valid range is 0 through 5"));
    if (element < 0 || element >= this.cubemapCount)
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in element ", element.ToString(), " is invalid. The valid range is 0 through ", (this.cubemapCount - 1).ToString()));
    int element1 = (int) (element * 6 + face);
    ulong pixelDataOffset1 = this.GetPixelDataOffset(this.mipmapCount, element1);
    ulong pixelDataOffset2 = this.GetPixelDataOffset(mipLevel, element1);
    ulong length = this.GetPixelDataSize(mipLevel, element1) / (ulong) UnsafeUtility.SizeOf<T>();
    if (length > (ulong) int.MaxValue)
      throw this.CreateNativeArrayLengthOverflowException();
    return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*) new System.IntPtr((long) this.GetImageData() + ((long) pixelDataOffset1 * (long) element1 + (long) pixelDataOffset2)), (int) length, Allocator.None);
  }

  public void CopyPixels(Texture src)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!src.isReadable)
      throw this.CreateNonReadableException(src);
    this.CopyPixels_Full(src);
  }

  public void CopyPixels(Texture src, int srcElement, int srcMip, int dstElement, int dstMip)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!src.isReadable)
      throw this.CreateNonReadableException(src);
    this.CopyPixels_Slice(src, srcElement, srcMip, dstElement, dstMip);
  }

  public void CopyPixels(
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
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!src.isReadable)
      throw this.CreateNonReadableException(src);
    this.CopyPixels_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
  }

  public static int get_cubemapCount_Injected(System.IntPtr _unity_self)
  {
    return CubemapArray.get_cubemapCount_InjectedDelegateField(_unity_self);
  }

  public static TextureFormat get_format_Injected(System.IntPtr _unity_self)
  {
    return CubemapArray.get_format_InjectedDelegateField(_unity_self);
  }

  public static Il2CppStructArray<Color> GetPixels_Injected(
    System.IntPtr _unity_self,
    CubemapFace face,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr num = CubemapArray.GetPixels_InjectedDelegateField(_unity_self, face, arrayElement, miplevel);
    return num == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num);
  }

  public static Il2CppStructArray<Color32> GetPixels32_Injected(
    System.IntPtr _unity_self,
    CubemapFace face,
    int arrayElement,
    int miplevel)
  {
    System.IntPtr num = CubemapArray.GetPixels32_InjectedDelegateField(_unity_self, face, arrayElement, miplevel);
    return num == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(num);
  }

  public static void SetPixels32_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    CubemapFace face,
    int arrayElement,
    int miplevel)
  {
    CubemapArray.SetPixels32_InjectedDelegateField(_unity_self, (System.IntPtr) ref colors, face, arrayElement, miplevel);
  }

  public static bool SetPixelDataImplArray_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int mipLevel,
    int face,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    return CubemapArray.SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public static bool SetPixelDataImpl_Injected(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int face,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    return CubemapArray.SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public static void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
  {
    CubemapArray.CopyPixels_Full_InjectedDelegateField(_unity_self, src);
  }

  public static void CopyPixels_Slice_Injected(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    CubemapArray.CopyPixels_Slice_InjectedDelegateField(_unity_self, src, srcElement, srcMip, dstElement, dstMip);
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
    int dstElement,
    int dstMip,
    int dstX,
    int dstY)
  {
    CubemapArray.CopyPixels_Region_InjectedDelegateField(_unity_self, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
  }

  public static System.IntPtr GetImageData_Injected(System.IntPtr _unity_self)
  {
    return CubemapArray.GetImageData_InjectedDelegateField(_unity_self);
  }

  private delegate int get_cubemapCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TextureFormat get_format_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetPixels_InjectedDelegate(
    System.IntPtr _unity_self,
    CubemapFace face,
    int arrayElement,
    int miplevel);

  private delegate System.IntPtr GetPixels32_InjectedDelegate(
    System.IntPtr _unity_self,
    CubemapFace face,
    int arrayElement,
    int miplevel);

  private delegate void SetPixels32_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr colors,
    CubemapFace face,
    int arrayElement,
    int miplevel);

  private delegate bool SetPixelDataImplArray_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int face,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex);

  private delegate bool SetPixelDataImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int face,
    int element,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex);

  private delegate void CopyPixels_Full_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src);

  private delegate void CopyPixels_Slice_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int dstElement,
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
    int dstElement,
    int dstMip,
    int dstX,
    int dstY);

  private delegate System.IntPtr GetImageData_InjectedDelegate(System.IntPtr _unity_self);
}
