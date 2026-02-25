// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIFrameResources
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class UIFrameResources(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexUIColorDescPrototype;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexUIDepthDescPrototype;
  private static readonly System.IntPtr NativeFieldInfoPtr_kLabelTexUIColorMsaa;
  private static readonly System.IntPtr NativeFieldInfoPtr_kLabelTexUIColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kLabelTexUIDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kLabelTexUIAndVfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_texUIColorMsaa;
  private static readonly System.IntPtr NativeFieldInfoPtr_texUIColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_texUIDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_texUIAndVfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_msaaMode;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginFrame_Public_Void_Vector2Int_MsaaMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTargets_Public_UIFrameRenderTargets_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIFrameResources()
  {
    Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIFrameResources));
    UIFrameResources.NativeFieldInfoPtr_kTexUIColorDescPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (kTexUIColorDescPrototype));
    UIFrameResources.NativeFieldInfoPtr_kTexUIDepthDescPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (kTexUIDepthDescPrototype));
    UIFrameResources.NativeFieldInfoPtr_kLabelTexUIColorMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (kLabelTexUIColorMsaa));
    UIFrameResources.NativeFieldInfoPtr_kLabelTexUIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (kLabelTexUIColor));
    UIFrameResources.NativeFieldInfoPtr_kLabelTexUIDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (kLabelTexUIDepth));
    UIFrameResources.NativeFieldInfoPtr_kLabelTexUIAndVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (kLabelTexUIAndVfx));
    UIFrameResources.NativeFieldInfoPtr_texUIColorMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (texUIColorMsaa));
    UIFrameResources.NativeFieldInfoPtr_texUIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (texUIColor));
    UIFrameResources.NativeFieldInfoPtr_texUIDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (texUIDepth));
    UIFrameResources.NativeFieldInfoPtr_texUIAndVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (texUIAndVfx));
    UIFrameResources.NativeFieldInfoPtr_msaaMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, nameof (msaaMode));
    UIFrameResources.NativeMethodInfoPtr_BeginFrame_Public_Void_Vector2Int_MsaaMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, 100664209);
    UIFrameResources.NativeMethodInfoPtr_GetRenderTargets_Public_UIFrameRenderTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, 100664210);
    UIFrameResources.NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, 100664211);
    UIFrameResources.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, 100664212);
    UIFrameResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr, 100664213);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934874, XrefRangeEnd = 934903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginFrame(Vector2Int texSizePixels, MsaaMode msaaMode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &texSizePixels;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &msaaMode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFrameResources.NativeMethodInfoPtr_BeginFrame_Public_Void_Vector2Int_MsaaMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934903, XrefRangeEnd = 934904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIFrameRenderTargets GetRenderTargets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIFrameResources.NativeMethodInfoPtr_GetRenderTargets_Public_UIFrameRenderTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UIFrameRenderTargets(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 934911, RefRangeEnd = 934915, XrefRangeStart = 934904, XrefRangeEnd = 934911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFrameResources.NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934915, XrefRangeEnd = 934965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFrameResources.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIFrameResources()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFrameResources>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFrameResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe RenderTextureDescriptor kTexUIColorDescPrototype
  {
    get
    {
      RenderTextureDescriptor colorDescPrototype;
      IL2CPP.il2cpp_field_static_get_value(UIFrameResources.NativeFieldInfoPtr_kTexUIColorDescPrototype, (void*) &colorDescPrototype);
      return colorDescPrototype;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFrameResources.NativeFieldInfoPtr_kTexUIColorDescPrototype, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexUIDepthDescPrototype
  {
    get
    {
      RenderTextureDescriptor depthDescPrototype;
      IL2CPP.il2cpp_field_static_get_value(UIFrameResources.NativeFieldInfoPtr_kTexUIDepthDescPrototype, (void*) &depthDescPrototype);
      return depthDescPrototype;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFrameResources.NativeFieldInfoPtr_kTexUIDepthDescPrototype, (void*) &value);
    }
  }

  public static unsafe string kLabelTexUIColorMsaa
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIColorMsaa, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIColorMsaa, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kLabelTexUIColor
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIColor, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIColor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kLabelTexUIDepth
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIDepth, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIDepth, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kLabelTexUIAndVfx
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIAndVfx, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFrameResources.NativeFieldInfoPtr_kLabelTexUIAndVfx, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public RenderTextureResource texUIColorMsaa
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIColorMsaa);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIColorMsaa), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public RenderTextureResource texUIColor
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIColor);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public RenderTextureResource texUIDepth
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIDepth);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIDepth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public RenderTextureResource texUIAndVfx
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIAndVfx);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_texUIAndVfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe MsaaMode msaaMode
  {
    get
    {
      return *(MsaaMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_msaaMode));
    }
    [param: In] set
    {
      *(MsaaMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameResources.NativeFieldInfoPtr_msaaMode)) = value;
    }
  }
}
