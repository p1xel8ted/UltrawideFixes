// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIFinalBlitPass
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

public sealed class UIFinalBlitPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kKeywordApplyBloom;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBloom;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__material;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_FrameResultTextures_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_FrameResultTextures_byref_BloomParams_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_BloomParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static UIFinalBlitPass()
  {
    Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIFinalBlitPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr);
    UIFinalBlitPass.NativeFieldInfoPtr_kKeywordApplyBloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, nameof (kKeywordApplyBloom));
    UIFinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, nameof (kSidTexInputColor));
    UIFinalBlitPass.NativeFieldInfoPtr_kSidTexBloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, nameof (kSidTexBloom));
    UIFinalBlitPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, nameof (_cbuffer));
    UIFinalBlitPass.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, nameof (_material));
    UIFinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, 100664201);
    UIFinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_FrameResultTextures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, 100664202);
    UIFinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_FrameResultTextures_byref_BloomParams_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, 100664203);
    UIFinalBlitPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_BloomParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, 100664204);
    UIFinalBlitPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, 100664205);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934790, XrefRangeEnd = 934803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIFinalBlitPass(Shader blitShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blitShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 934808, RefRangeEnd = 934810, XrefRangeStart = 934803, XrefRangeEnd = 934808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    RenderTextureResource texInputColor,
    FrameResultTextures frameResultTextures)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_FrameResultTextures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 934851, RefRangeEnd = 934853, XrefRangeStart = 934810, XrefRangeEnd = 934851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    RenderTextureResource texInputColor,
    RenderTextureResource texBloom,
    FrameResultTextures frameResultTextures,
    [In] ref BloomParams bloom,
    bool applyBloom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBloom));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref bloom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &applyBloom;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_FrameResultTextures_byref_BloomParams_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934853, XrefRangeEnd = 934866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, [In] ref BloomParams bloom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bloom;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFinalBlitPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_BloomParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934866, XrefRangeEnd = 934874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFinalBlitPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string kKeywordApplyBloom
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UIFinalBlitPass.NativeFieldInfoPtr_kKeywordApplyBloom, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFinalBlitPass.NativeFieldInfoPtr_kKeywordApplyBloom, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int kSidTexInputColor
  {
    get
    {
      int sidTexInputColor;
      IL2CPP.il2cpp_field_static_get_value(UIFinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &sidTexInputColor);
      return sidTexInputColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBloom
  {
    get
    {
      int kSidTexBloom;
      IL2CPP.il2cpp_field_static_get_value(UIFinalBlitPass.NativeFieldInfoPtr_kSidTexBloom, (void*) &kSidTexBloom);
      return kSidTexBloom;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIFinalBlitPass.NativeFieldInfoPtr_kSidTexBloom, (void*) &value);
    }
  }

  public unsafe CBuffer<UIFinalBlitPass.UIFinalBlitCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFinalBlitPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<UIFinalBlitPass.UIFinalBlitCBufferData>) null : Il2CppObjectPool.Get<CBuffer<UIFinalBlitPass.UIFinalBlitCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFinalBlitPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFinalBlitPass.NativeFieldInfoPtr__material));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFinalBlitPass.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UIFinalBlitCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public float bloomIntensity;
    [FieldOffset(4)]
    public Vector3 padding;

    static UIFinalBlitCBufferData()
    {
      Il2CppClassPointerStore<UIFinalBlitPass.UIFinalBlitCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIFinalBlitPass>.NativeClassPtr, nameof (UIFinalBlitCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFinalBlitPass.UIFinalBlitCBufferData>.NativeClassPtr);
      UIFinalBlitPass.UIFinalBlitCBufferData.NativeFieldInfoPtr_bloomIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass.UIFinalBlitCBufferData>.NativeClassPtr, nameof (bloomIntensity));
      UIFinalBlitPass.UIFinalBlitCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFinalBlitPass.UIFinalBlitCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIFinalBlitPass.UIFinalBlitCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
