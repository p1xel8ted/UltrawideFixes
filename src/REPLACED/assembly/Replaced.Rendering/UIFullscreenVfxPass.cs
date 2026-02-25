// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIFullscreenVfxPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class UIFullscreenVfxPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBloom;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_RenderTextureResource_Material_BloomParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_BloomParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static UIFullscreenVfxPass()
  {
    Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIFullscreenVfxPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr);
    UIFullscreenVfxPass.NativeFieldInfoPtr_kSidTexInputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, nameof (kSidTexInputColor));
    UIFullscreenVfxPass.NativeFieldInfoPtr_kSidTexBloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, nameof (kSidTexBloom));
    UIFullscreenVfxPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, nameof (_cbuffer));
    UIFullscreenVfxPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, 100664214);
    UIFullscreenVfxPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_RenderTextureResource_Material_BloomParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, 100664215);
    UIFullscreenVfxPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_BloomParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, 100664216);
    UIFullscreenVfxPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, 100664217);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934965, XrefRangeEnd = 934974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIFullscreenVfxPass()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFullscreenVfxPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935012, RefRangeEnd = 935013, XrefRangeStart = 934974, XrefRangeEnd = 935012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    RenderTextureResource texInputColor,
    RenderTextureResource texBloom,
    RenderTextureResource texUIAndVfx,
    Material fullscreenVfxMaterial,
    BloomParams bloom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBloom));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIAndVfx));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fullscreenVfxMaterial);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &bloom;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFullscreenVfxPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_RenderTextureResource_Material_BloomParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935013, XrefRangeEnd = 935029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, BloomParams bloom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bloom;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFullscreenVfxPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_BloomParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935029, XrefRangeEnd = 935033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFullscreenVfxPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexInputColor
  {
    get
    {
      int sidTexInputColor;
      IL2CPP.il2cpp_field_static_get_value(UIFullscreenVfxPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &sidTexInputColor);
      return sidTexInputColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFullscreenVfxPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBloom
  {
    get
    {
      int kSidTexBloom;
      IL2CPP.il2cpp_field_static_get_value(UIFullscreenVfxPass.NativeFieldInfoPtr_kSidTexBloom, (void*) &kSidTexBloom);
      return kSidTexBloom;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFullscreenVfxPass.NativeFieldInfoPtr_kSidTexBloom, (void*) &value);
    }
  }

  public unsafe CBuffer<UIFullscreenVfxPass.FullscreenVfxCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFullscreenVfxPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<UIFullscreenVfxPass.FullscreenVfxCBufferData>) null : Il2CppObjectPool.Get<CBuffer<UIFullscreenVfxPass.FullscreenVfxCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFullscreenVfxPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct FullscreenVfxCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    [FieldOffset(0)]
    public float bloomIntensity;
    [FieldOffset(4)]
    public Vector3 padding;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 timeParameters;

    static FullscreenVfxCBufferData()
    {
      Il2CppClassPointerStore<UIFullscreenVfxPass.FullscreenVfxCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIFullscreenVfxPass>.NativeClassPtr, nameof (FullscreenVfxCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFullscreenVfxPass.FullscreenVfxCBufferData>.NativeClassPtr);
      UIFullscreenVfxPass.FullscreenVfxCBufferData.NativeFieldInfoPtr_bloomIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFullscreenVfxPass.FullscreenVfxCBufferData>.NativeClassPtr, nameof (bloomIntensity));
      UIFullscreenVfxPass.FullscreenVfxCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFullscreenVfxPass.FullscreenVfxCBufferData>.NativeClassPtr, nameof (padding));
      UIFullscreenVfxPass.FullscreenVfxCBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFullscreenVfxPass.FullscreenVfxCBufferData>.NativeClassPtr, nameof (timeParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIFullscreenVfxPass.FullscreenVfxCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
