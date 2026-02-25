// Decompiled with JetBrains decompiler
// Type: UnityEngine.Texture3D
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class Texture3D(System.IntPtr pointer) : Texture(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetImageData_Private_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Int32_Color_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetImageData_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly Texture3D.get_depth_InjectedDelegate get_depth_InjectedDelegateField;
  private static readonly Texture3D.get_format_InjectedDelegate get_format_InjectedDelegateField;
  private static readonly Texture3D.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;
  private static readonly Texture3D.GetPixelBilinearImpl_InjectedDelegate GetPixelBilinearImpl_InjectedDelegateField;
  private static readonly Texture3D.UpdateExternalTexture_InjectedDelegate UpdateExternalTexture_InjectedDelegateField;
  private static readonly Texture3D.GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;
  private static readonly Texture3D.GetPixels32_InjectedDelegate GetPixels32_InjectedDelegateField;
  private static readonly Texture3D.SetPixels32_InjectedDelegate SetPixels32_InjectedDelegateField;
  private static readonly Texture3D.SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;
  private static readonly Texture3D.SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;
  private static readonly Texture3D.CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;
  private static readonly Texture3D.CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;
  private static readonly Texture3D.CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;

  static Texture3D()
  {
    Il2CppClassPointerStore<Texture3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Texture3D));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture3D>.NativeClassPtr);
    Texture3D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666807);
    Texture3D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666808);
    Texture3D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666809);
    Texture3D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666810);
    Texture3D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666811);
    Texture3D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666812);
    Texture3D.NativeMethodInfoPtr_GetImageData_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666813);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666814);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666815);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666816 /*0x06000DC0*/);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666817);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666818);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666819);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666820);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666821);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666822);
    Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666823);
    Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666824);
    Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666825);
    Texture3D.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666826);
    Texture3D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Int32_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666827);
    Texture3D.NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666828);
    Texture3D.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666829);
    Texture3D.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666830);
    Texture3D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666831);
    Texture3D.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666832 /*0x06000DD0*/);
    Texture3D.NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666833);
    Texture3D.NativeMethodInfoPtr_GetImageData_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3D>.NativeClassPtr, 100666834);
    Texture3D.get_depth_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.get_depth_InjectedDelegate>("UnityEngine.Texture3D::get_depth_Injected");
    Texture3D.get_format_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.get_format_InjectedDelegate>("UnityEngine.Texture3D::get_format_Injected");
    Texture3D.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelImpl_InjectedDelegate>("UnityEngine.Texture3D::GetPixelImpl_Injected");
    Texture3D.GetPixelBilinearImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixelBilinearImpl_InjectedDelegate>("UnityEngine.Texture3D::GetPixelBilinearImpl_Injected");
    Texture3D.UpdateExternalTexture_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.UpdateExternalTexture_InjectedDelegate>("UnityEngine.Texture3D::UpdateExternalTexture_Injected");
    Texture3D.GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixels_InjectedDelegate>("UnityEngine.Texture3D::GetPixels_Injected");
    Texture3D.GetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.GetPixels32_InjectedDelegate>("UnityEngine.Texture3D::GetPixels32_Injected");
    Texture3D.SetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixels32_InjectedDelegate>("UnityEngine.Texture3D::SetPixels32_Injected");
    Texture3D.SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelDataImplArray_InjectedDelegate>("UnityEngine.Texture3D::SetPixelDataImplArray_Injected");
    Texture3D.SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.SetPixelDataImpl_InjectedDelegate>("UnityEngine.Texture3D::SetPixelDataImpl_Injected");
    Texture3D.CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.CopyPixels_Full_InjectedDelegate>("UnityEngine.Texture3D::CopyPixels_Full_Injected");
    Texture3D.CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.CopyPixels_Slice_InjectedDelegate>("UnityEngine.Texture3D::CopyPixels_Slice_Injected");
    Texture3D.CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<Texture3D.CopyPixels_Region_InjectedDelegate>("UnityEngine.Texture3D::CopyPixels_Region_Injected");
  }

  public override unsafe bool isReadable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435717, XrefRangeEnd = 435722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435722, XrefRangeEnd = 435726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixelImpl(int mip, int x, int y, int z, Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &mip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435726, XrefRangeEnd = 435728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Internal_CreateImpl(
    Texture3D mono,
    int w,
    int h,
    int d,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    System.IntPtr nativeTex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435730, RefRangeEnd = 435732, XrefRangeStart = 435728, XrefRangeEnd = 435730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Create(
    Texture3D mono,
    int w,
    int h,
    int d,
    int mipCount,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    TextureCreationFlags flags,
    System.IntPtr nativeTex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &colorSpace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture3D_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435732, XrefRangeEnd = 435737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435748, RefRangeEnd = 435750, XrefRangeStart = 435737, XrefRangeEnd = 435748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435755, RefRangeEnd = 435757, XrefRangeStart = 435750, XrefRangeEnd = 435755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe System.IntPtr GetImageData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_GetImageData_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435757, XrefRangeEnd = 435763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    DefaultFormat format,
    TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435763, XrefRangeEnd = 435765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    DefaultFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 435770, RefRangeEnd = 435774, XrefRangeStart = 435765, XrefRangeEnd = 435770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    TextureCreationFlags flags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 435789, RefRangeEnd = 435793, XrefRangeStart = 435774, XrefRangeEnd = 435789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    TextureCreationFlags flags,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435793, XrefRangeEnd = 435794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    int mipCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435794, XrefRangeEnd = 435795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    int mipCount,
    System.IntPtr nativeTex)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 435813, RefRangeEnd = 435818, XrefRangeStart = 435795, XrefRangeEnd = 435813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    int mipCount,
    System.IntPtr nativeTex,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435818, XrefRangeEnd = 435824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    bool mipChain)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435824, XrefRangeEnd = 435830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    bool mipChain,
    bool createUninitialized)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &createUninitialized;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435830, XrefRangeEnd = 435836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture3D(
    int width,
    int height,
    int depth,
    TextureFormat textureFormat,
    bool mipChain,
    System.IntPtr nativeTex)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &textureFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipChain;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &nativeTex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435843, RefRangeEnd = 435845, XrefRangeStart = 435836, XrefRangeEnd = 435843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &updateMipmaps;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &makeNoLongerReadable;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435846, RefRangeEnd = 435848, XrefRangeStart = 435845, XrefRangeEnd = 435846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(bool updateMipmaps)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &updateMipmaps
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 435849, RefRangeEnd = 435853, XrefRangeStart = 435848, XrefRangeEnd = 435849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 435857, RefRangeEnd = 435859, XrefRangeStart = 435853, XrefRangeEnd = 435857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPixel(int x, int y, int z, Color color, int mipLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Int32_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 435870, RefRangeEnd = 435871, XrefRangeStart = 435859, XrefRangeEnd = 435870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> GetPixelData<T>(int mipLevel) where T : new()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mipLevel
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Texture3D.MethodInfoStoreGeneric_GetPixelData_Public_NativeArray_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(0)]
  public static unsafe void ValidateIsNotCrunched(TextureCreationFlags flags)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flags
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435871, XrefRangeEnd = 435873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new static unsafe bool get_isReadable_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435873, XrefRangeEnd = 435875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPixelImpl_Injected(
    System.IntPtr _unity_self,
    int mip,
    int x,
    int y,
    int z,
    [In] ref Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435875, XrefRangeEnd = 435877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435877, XrefRangeEnd = 435879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPixels_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    int miplevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref colors;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &miplevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 435879, XrefRangeEnd = 435881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetImageData_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Texture3D.NativeMethodInfoPtr_GetImageData_Injected_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public int depth
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Texture3D.get_depth_Injected(_unity_self);
    }
  }

  public TextureFormat format
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Texture3D.get_format_Injected(_unity_self);
    }
  }

  public Color GetPixelImpl(int mip, int x, int y, int z)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Color ret;
    Texture3D.GetPixelImpl_Injected(_unity_self, mip, x, y, z, out ret);
    return ret;
  }

  public Color GetPixelBilinearImpl(int mip, float u, float v, float w)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Color ret;
    Texture3D.GetPixelBilinearImpl_Injected(_unity_self, mip, u, v, w, out ret);
    return ret;
  }

  public void UpdateExternalTexture(System.IntPtr nativeTex)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Texture3D.UpdateExternalTexture_Injected(_unity_self, nativeTex);
  }

  public Il2CppStructArray<Color> GetPixels(int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Texture3D.GetPixels_Injected(_unity_self, miplevel);
  }

  public Il2CppStructArray<Color> GetPixels() => this.GetPixels(0);

  public Il2CppStructArray<Color32> GetPixels32(int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Texture3D.GetPixels32_Injected(_unity_self, miplevel);
  }

  public Il2CppStructArray<Color32> GetPixels32() => this.GetPixels32(0);

  public void SetPixels(Il2CppStructArray<Color> colors) => this.SetPixels(colors, 0);

  public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<Color32> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Color32>) ref span).\u002Ector((Il2CppArrayBase<Color32>) colors);
    fixed (Color32* begin = &((Il2CppSystem.Span<Color32>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper colors1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Color32>) ref span).Length);
      Texture3D.SetPixels32_Injected(_unity_self, ref colors1, miplevel);
    }
  }

  public void SetPixels32(Il2CppStructArray<Color32> colors) => this.SetPixels32(colors, 0);

  public bool SetPixelDataImplArray(
    Il2CppSystem.Array data,
    int mipLevel,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = default (int))
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Texture3D.SetPixelDataImplArray_Injected(_unity_self, data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public bool SetPixelDataImpl(
    System.IntPtr data,
    int mipLevel,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex = default (int))
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return Texture3D.SetPixelDataImpl_Injected(_unity_self, data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public void CopyPixels_Full(Texture src)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Texture3D.CopyPixels_Full_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src));
  }

  public void CopyPixels_Slice(
    Texture src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Texture3D.CopyPixels_Slice_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, srcMip, dstElement, dstMip);
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
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Texture3D>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Texture3D.CopyPixels_Region_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Texture>(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
  }

  public static Texture3D CreateExternalTexture(
    int width,
    int height,
    int depth,
    TextureFormat format,
    bool mipChain,
    System.IntPtr nativeTex)
  {
    if (nativeTex == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ArgumentException("nativeTex may not be zero");
    return new Texture3D(width, height, depth, format, mipChain ? -1 : 1, nativeTex, false);
  }

  public void SetPixel(int x, int y, int z, Color color)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    this.SetPixelImpl(0, x, y, z, color);
  }

  public Color GetPixel(int x, int y, int z)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    return this.GetPixelImpl(0, x, y, z);
  }

  public Color GetPixel(int x, int y, int z, int mipLevel)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    return this.GetPixelImpl(mipLevel, x, y, z);
  }

  public Color GetPixelBilinear(float u, float v, float w)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    return this.GetPixelBilinearImpl(0, u, v, w);
  }

  public Color GetPixelBilinear(float u, float v, float w, int mipLevel)
  {
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    return this.GetPixelBilinearImpl(mipLevel, u, v, w);
  }

  public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, int sourceDataStartIndex = default (int))
  {
    if (sourceDataStartIndex < 0)
      throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (data == null || ((Il2CppArrayBase) data).Length == 0)
      throw new UnityException("No texture data provided to SetPixelData.");
    this.SetPixelDataImplArray((Il2CppSystem.Array) data, mipLevel, Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase) data).Length, sourceDataStartIndex);
  }

  public unsafe void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = default (int)) where T : struct
  {
    if (sourceDataStartIndex < 0)
      throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
    if (!this.isReadable)
      throw this.CreateNonReadableException((Texture) this);
    if (!((NativeArray<T>) ref data).IsCreated || ((NativeArray<T>) ref data).Length == 0)
      throw new UnityException("No texture data provided to SetPixelData.");
    this.SetPixelDataImpl((System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), mipLevel, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>) ref data).Length, sourceDataStartIndex);
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

  public static int get_depth_Injected(System.IntPtr _unity_self)
  {
    return Texture3D.get_depth_InjectedDelegateField(_unity_self);
  }

  public static TextureFormat get_format_Injected(System.IntPtr _unity_self)
  {
    return Texture3D.get_format_InjectedDelegateField(_unity_self);
  }

  public static void GetPixelImpl_Injected(
    System.IntPtr _unity_self,
    int mip,
    int x,
    int y,
    int z,
    out Color ret)
  {
    Texture3D.GetPixelImpl_InjectedDelegateField(_unity_self, mip, x, y, z, (System.IntPtr) ref ret);
  }

  public static void GetPixelBilinearImpl_Injected(
    System.IntPtr _unity_self,
    int mip,
    float u,
    float v,
    float w,
    out Color ret)
  {
    Texture3D.GetPixelBilinearImpl_InjectedDelegateField(_unity_self, mip, u, v, w, (System.IntPtr) ref ret);
  }

  public static void UpdateExternalTexture_Injected(System.IntPtr _unity_self, System.IntPtr nativeTex)
  {
    Texture3D.UpdateExternalTexture_InjectedDelegateField(_unity_self, nativeTex);
  }

  public static Il2CppStructArray<Color> GetPixels_Injected(System.IntPtr _unity_self, int miplevel)
  {
    System.IntPtr num = Texture3D.GetPixels_InjectedDelegateField(_unity_self, miplevel);
    return num == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color>>(num);
  }

  public static Il2CppStructArray<Color32> GetPixels32_Injected(System.IntPtr _unity_self, int miplevel)
  {
    System.IntPtr num = Texture3D.GetPixels32_InjectedDelegateField(_unity_self, miplevel);
    return num == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(num);
  }

  public static void SetPixels32_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper colors,
    int miplevel)
  {
    Texture3D.SetPixels32_InjectedDelegateField(_unity_self, (System.IntPtr) ref colors, miplevel);
  }

  public static bool SetPixelDataImplArray_Injected(
    System.IntPtr _unity_self,
    Il2CppSystem.Array data,
    int mipLevel,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    return Texture3D.SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public static bool SetPixelDataImpl_Injected(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex)
  {
    return Texture3D.SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
  }

  public static void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
  {
    Texture3D.CopyPixels_Full_InjectedDelegateField(_unity_self, src);
  }

  public static void CopyPixels_Slice_Injected(
    System.IntPtr _unity_self,
    System.IntPtr src,
    int srcElement,
    int srcMip,
    int dstElement,
    int dstMip)
  {
    Texture3D.CopyPixels_Slice_InjectedDelegateField(_unity_self, src, srcElement, srcMip, dstElement, dstMip);
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
    Texture3D.CopyPixels_Region_InjectedDelegateField(_unity_self, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
  }

  private sealed class MethodInfoStoreGeneric_GetPixelData_Public_NativeArray_1_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture3D.NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<Texture3D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate int get_depth_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TextureFormat get_format_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void GetPixelImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int mip,
    int x,
    int y,
    int z,
    [Out] System.IntPtr ret);

  private delegate void GetPixelBilinearImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int mip,
    float u,
    float v,
    float w,
    [Out] System.IntPtr ret);

  private delegate void UpdateExternalTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nativeTex);

  private delegate System.IntPtr GetPixels_InjectedDelegate(System.IntPtr _unity_self, int miplevel);

  private delegate System.IntPtr GetPixels32_InjectedDelegate(System.IntPtr _unity_self, int miplevel);

  private delegate void SetPixels32_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr colors,
    int miplevel);

  private delegate bool SetPixelDataImplArray_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
    int elementSize,
    int dataArraySize,
    int sourceDataStartIndex);

  private delegate bool SetPixelDataImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr data,
    int mipLevel,
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
}
