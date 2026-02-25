// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIFrameRenderTargets
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class UIFrameRenderTargets : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_texUIColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_texUIDepth;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureResource_RenderTextureResource_0;

  static UIFrameRenderTargets()
  {
    Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIFrameRenderTargets));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr);
    UIFrameRenderTargets.NativeFieldInfoPtr_texUIColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr, nameof (texUIColor));
    UIFrameRenderTargets.NativeFieldInfoPtr_texUIDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr, nameof (texUIDepth));
    UIFrameRenderTargets.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr, 100664207);
  }

  [CallerCount(0)]
  public unsafe UIFrameRenderTargets(
    RenderTextureResource texUIColor,
    RenderTextureResource texUIDepth)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIDepth));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFrameRenderTargets.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureResource_RenderTextureResource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public UIFrameRenderTargets(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public UIFrameRenderTargets()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFrameRenderTargets>.NativeClassPtr))
  {
  }

  public RenderTextureResource texUIColor
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameRenderTargets.NativeFieldInfoPtr_texUIColor);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameRenderTargets.NativeFieldInfoPtr_texUIColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public RenderTextureResource texUIDepth
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameRenderTargets.NativeFieldInfoPtr_texUIDepth);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFrameRenderTargets.NativeFieldInfoPtr_texUIDepth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
