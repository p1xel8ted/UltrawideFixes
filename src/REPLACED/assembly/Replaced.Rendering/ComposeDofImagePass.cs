// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ComposeDofImagePass
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

public sealed class ComposeDofImagePass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneColorInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCocFullRes;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurForegroundColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurForegroundCoverage;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDofResultImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBokehColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__material;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ComposeDofImagePass()
  {
    Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ComposeDofImagePass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr);
    ComposeDofImagePass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kGroupSize));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexSceneColorInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexSceneColorInput));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexCocFullRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexCocFullRes));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurForegroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexBlurForegroundColor));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurForegroundCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexBlurForegroundCoverage));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexBlurInFocusBackgroundColor));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexDofResultImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexDofResultImage));
    ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (kSidTexBokehColor));
    ComposeDofImagePass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (_cbuffer));
    ComposeDofImagePass.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (_material));
    ComposeDofImagePass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, 100664111);
    ComposeDofImagePass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, 100664112 /*0x06000330*/);
    ComposeDofImagePass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, 100664113);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932998, XrefRangeEnd = 933011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComposeDofImagePass(Shader shader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComposeDofImagePass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933051, RefRangeEnd = 933052, XrefRangeStart = 933011, XrefRangeEnd = 933051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref RenderTextureResource texSceneColorInput,
    [In] ref RenderTextureResource texCocFullRes,
    [In] ref RenderTextureResource texBlurForegroundColor,
    [In] ref RenderTextureResource texBlurForegroundCoverage,
    [In] ref RenderTextureResource texBlurInFocusBackgroundColor,
    [In] ref RenderTextureResource texBokehColor,
    [In] ref RenderTextureResource texSceneColorOutput)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColorInput);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCocFullRes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBlurForegroundColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBlurForegroundCoverage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBlurInFocusBackgroundColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBokehColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColorOutput);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComposeDofImagePass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933052, XrefRangeEnd = 933086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComposeDofImagePass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneColorInput
  {
    get
    {
      int texSceneColorInput;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexSceneColorInput, (void*) &texSceneColorInput);
      return texSceneColorInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexSceneColorInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexCocFullRes
  {
    get
    {
      int sidTexCocFullRes;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexCocFullRes, (void*) &sidTexCocFullRes);
      return sidTexCocFullRes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexCocFullRes, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurForegroundColor
  {
    get
    {
      int blurForegroundColor;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurForegroundColor, (void*) &blurForegroundColor);
      return blurForegroundColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurForegroundColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurForegroundCoverage
  {
    get
    {
      int foregroundCoverage;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurForegroundCoverage, (void*) &foregroundCoverage);
      return foregroundCoverage;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurForegroundCoverage, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurInFocusBackgroundColor
  {
    get
    {
      int focusBackgroundColor;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor, (void*) &focusBackgroundColor);
      return focusBackgroundColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexDofResultImage
  {
    get
    {
      int texDofResultImage;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexDofResultImage, (void*) &texDofResultImage);
      return texDofResultImage;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexDofResultImage, (void*) &value);
    }
  }

  public static unsafe int kSidTexBokehColor
  {
    get
    {
      int sidTexBokehColor;
      IL2CPP.il2cpp_field_static_get_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBokehColor, (void*) &sidTexBokehColor);
      return sidTexBokehColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComposeDofImagePass.NativeFieldInfoPtr_kSidTexBokehColor, (void*) &value);
    }
  }

  public unsafe CBuffer<ComposeDofImagePass.ComposeDfoImageCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComposeDofImagePass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ComposeDofImagePass.ComposeDfoImageCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ComposeDofImagePass.ComposeDfoImageCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ComposeDofImagePass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComposeDofImagePass.NativeFieldInfoPtr__material));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ComposeDofImagePass.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ComposeDfoImageCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texBlurForegroundCoverageSizeInfo;
    [FieldOffset(0)]
    public Vector4 texBlurForegroundCoverageSizeInfo;

    static ComposeDfoImageCBufferData()
    {
      Il2CppClassPointerStore<ComposeDofImagePass.ComposeDfoImageCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComposeDofImagePass>.NativeClassPtr, nameof (ComposeDfoImageCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposeDofImagePass.ComposeDfoImageCBufferData>.NativeClassPtr);
      ComposeDofImagePass.ComposeDfoImageCBufferData.NativeFieldInfoPtr_texBlurForegroundCoverageSizeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposeDofImagePass.ComposeDfoImageCBufferData>.NativeClassPtr, nameof (texBlurForegroundCoverageSizeInfo));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ComposeDofImagePass.ComposeDfoImageCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
