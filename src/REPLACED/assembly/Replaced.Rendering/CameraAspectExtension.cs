// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CameraAspectExtension
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

public static class CameraAspectExtension : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_TargetWidthAspect;
  private static readonly System.IntPtr NativeFieldInfoPtr_TargetHeightAspect;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTargetSize_Public_Static_Vector2Int_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCustomAspectRequired_Private_Static_Boolean_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRenderTargetInfo_Public_Static_RenderTargetInfo_Camera_0;

  static CameraAspectExtension()
  {
    Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CameraAspectExtension));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr);
    CameraAspectExtension.NativeFieldInfoPtr_TargetWidthAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr, nameof (TargetWidthAspect));
    CameraAspectExtension.NativeFieldInfoPtr_TargetHeightAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr, nameof (TargetHeightAspect));
    CameraAspectExtension.NativeMethodInfoPtr_GetRenderTargetSize_Public_Static_Vector2Int_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr, 100663414 /*0x06000076*/);
    CameraAspectExtension.NativeMethodInfoPtr_IsCustomAspectRequired_Private_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr, 100663415 /*0x06000077*/);
    CameraAspectExtension.NativeMethodInfoPtr_MakeRenderTargetInfo_Public_Static_RenderTargetInfo_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAspectExtension>.NativeClassPtr, 100663416 /*0x06000078*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924825, XrefRangeEnd = 924827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2Int GetRenderTargetSize(this Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraAspectExtension.NativeMethodInfoPtr_GetRenderTargetSize_Public_Static_Vector2Int_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924827, XrefRangeEnd = 924830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCustomAspectRequired(this Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraAspectExtension.NativeMethodInfoPtr_IsCustomAspectRequired_Private_Static_Boolean_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 924840, RefRangeEnd = 924841, XrefRangeStart = 924830, XrefRangeEnd = 924840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTargetInfo MakeRenderTargetInfo(this Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraAspectExtension.NativeMethodInfoPtr_MakeRenderTargetInfo_Public_Static_RenderTargetInfo_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderTargetInfo*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public CameraAspectExtension(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float TargetWidthAspect
  {
    get
    {
      float targetWidthAspect;
      IL2CPP.il2cpp_field_static_get_value(CameraAspectExtension.NativeFieldInfoPtr_TargetWidthAspect, (void*) &targetWidthAspect);
      return targetWidthAspect;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraAspectExtension.NativeFieldInfoPtr_TargetWidthAspect, (void*) &value);
    }
  }

  public static unsafe float TargetHeightAspect
  {
    get
    {
      float targetHeightAspect;
      IL2CPP.il2cpp_field_static_get_value(CameraAspectExtension.NativeFieldInfoPtr_TargetHeightAspect, (void*) &targetHeightAspect);
      return targetHeightAspect;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraAspectExtension.NativeFieldInfoPtr_TargetHeightAspect, (void*) &value);
    }
  }
}
