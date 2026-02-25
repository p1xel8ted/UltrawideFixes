// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FrameResultTextures
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

public sealed class FrameResultTextures(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexResultColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_texColor;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Void_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FrameResultTextures()
  {
    Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FrameResultTextures));
    FrameResultTextures.NativeFieldInfoPtr_kTexResultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr, nameof (kTexResultColor));
    FrameResultTextures.NativeFieldInfoPtr_texColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr, nameof (texColor));
    FrameResultTextures.NativeMethodInfoPtr_Begin_Public_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr, 100663511 /*0x060000D7*/);
    FrameResultTextures.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr, 100663512 /*0x060000D8*/);
    FrameResultTextures.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr, 100663513 /*0x060000D9*/);
    FrameResultTextures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr, 100663514 /*0x060000DA*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925815, RefRangeEnd = 925816, XrefRangeStart = 925805, XrefRangeEnd = 925815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Begin(Vector2Int renderTargetSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &renderTargetSize
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameResultTextures.NativeMethodInfoPtr_Begin_Public_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 925845, RefRangeEnd = 925847, XrefRangeStart = 925816, XrefRangeEnd = 925845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameResultTextures.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 925845, RefRangeEnd = 925847, XrefRangeStart = 925845, XrefRangeEnd = 925847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameResultTextures.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FrameResultTextures()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameResultTextures>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameResultTextures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe RenderTextureDescriptor kTexResultColor
  {
    get
    {
      RenderTextureDescriptor kTexResultColor;
      IL2CPP.il2cpp_field_static_get_value(FrameResultTextures.NativeFieldInfoPtr_kTexResultColor, (void*) &kTexResultColor);
      return kTexResultColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameResultTextures.NativeFieldInfoPtr_kTexResultColor, (void*) &value);
    }
  }

  public RenderTextureResource texColor
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameResultTextures.NativeFieldInfoPtr_texColor);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameResultTextures.NativeFieldInfoPtr_texColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
