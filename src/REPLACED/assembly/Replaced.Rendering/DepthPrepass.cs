// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DepthPrepass
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

public sealed class DepthPrepass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kShaderPassName;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPixelizationShaderPassName;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexLowResDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr__blitMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_CullingResults_Camera_ShaderTagId_SortingCriteria_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_Camera_byref_CullingResults_byref_PixelizationParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_Camera_byref_CullingResults_byref_PixelizationParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePixelizationDepthPrepass_Private_Void_byref_ScriptableRenderContext_CommandBuffer_Camera_byref_CullingResults_byref_PixelizationParams_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DepthPrepass()
  {
    Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DepthPrepass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr);
    DepthPrepass.NativeFieldInfoPtr_kShaderPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, nameof (kShaderPassName));
    DepthPrepass.NativeFieldInfoPtr_kPixelizationShaderPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, nameof (kPixelizationShaderPassName));
    DepthPrepass.NativeFieldInfoPtr_kSidTexLowResDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, nameof (kSidTexLowResDepth));
    DepthPrepass.NativeFieldInfoPtr__blitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, nameof (_blitMaterial));
    DepthPrepass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_CullingResults_Camera_ShaderTagId_SortingCriteria_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, 100663769);
    DepthPrepass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, 100663770);
    DepthPrepass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_Camera_byref_CullingResults_byref_PixelizationParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, 100663771);
    DepthPrepass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_Camera_byref_CullingResults_byref_PixelizationParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, 100663772);
    DepthPrepass.NativeMethodInfoPtr_EncodePixelizationDepthPrepass_Private_Void_byref_ScriptableRenderContext_CommandBuffer_Camera_byref_CullingResults_byref_PixelizationParams_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, 100663773);
    DepthPrepass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr, 100663774);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 928790, RefRangeEnd = 928792, XrefRangeStart = 928781, XrefRangeEnd = 928790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererList MakeRendererList(
    [In] ref ScriptableRenderContext ctx,
    [In] ref CullingResults cullingResults,
    Camera camera,
    ShaderTagId shaderPass,
    SortingCriteria sortingCriteria,
    RenderQueueRange renderQueueRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shaderPass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &renderQueueRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DepthPrepass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_CullingResults_Camera_ShaderTagId_SortingCriteria_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928797, RefRangeEnd = 928798, XrefRangeStart = 928792, XrefRangeEnd = 928797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DepthPrepass(Shader pixelizatinBlitShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthPrepass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pixelizatinBlitShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPrepass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928798, XrefRangeEnd = 928807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    Camera camera,
    [In] ref CullingResults cullingResults,
    [In] ref PixelizationParams pixp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref pixp;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPrepass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_Camera_byref_CullingResults_byref_PixelizationParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 928837, RefRangeEnd = 928840, XrefRangeStart = 928807, XrefRangeEnd = 928837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    Camera camera,
    [In] ref CullingResults cullingResults,
    [In] ref PixelizationParams pixp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref pixp;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPrepass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_Camera_byref_CullingResults_byref_PixelizationParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928881, RefRangeEnd = 928882, XrefRangeStart = 928840, XrefRangeEnd = 928881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePixelizationDepthPrepass(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    Camera camera,
    [In] ref CullingResults cullingResults,
    [In] ref PixelizationParams pixp,
    RenderTextureResource texSceneDepth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref pixp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPrepass.NativeMethodInfoPtr_EncodePixelizationDepthPrepass_Private_Void_byref_ScriptableRenderContext_CommandBuffer_Camera_byref_CullingResults_byref_PixelizationParams_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPrepass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ShaderTagId kShaderPassName
  {
    get
    {
      ShaderTagId kShaderPassName;
      IL2CPP.il2cpp_field_static_get_value(DepthPrepass.NativeFieldInfoPtr_kShaderPassName, (void*) &kShaderPassName);
      return kShaderPassName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthPrepass.NativeFieldInfoPtr_kShaderPassName, (void*) &value);
    }
  }

  public static unsafe ShaderTagId kPixelizationShaderPassName
  {
    get
    {
      ShaderTagId pixelizationShaderPassName;
      IL2CPP.il2cpp_field_static_get_value(DepthPrepass.NativeFieldInfoPtr_kPixelizationShaderPassName, (void*) &pixelizationShaderPassName);
      return pixelizationShaderPassName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthPrepass.NativeFieldInfoPtr_kPixelizationShaderPassName, (void*) &value);
    }
  }

  public static unsafe int kSidTexLowResDepth
  {
    get
    {
      int sidTexLowResDepth;
      IL2CPP.il2cpp_field_static_get_value(DepthPrepass.NativeFieldInfoPtr_kSidTexLowResDepth, (void*) &sidTexLowResDepth);
      return sidTexLowResDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DepthPrepass.NativeFieldInfoPtr_kSidTexLowResDepth, (void*) &value);
    }
  }

  public unsafe Material _blitMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthPrepass.NativeFieldInfoPtr__blitMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthPrepass.NativeFieldInfoPtr__blitMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
