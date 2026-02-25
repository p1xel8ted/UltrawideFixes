// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PreviewCameraGeometryPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class PreviewCameraGeometryPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kPerObjectDataFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_kKeywordRenderPreviewCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_kRenderStateCullingOff;
  private static readonly System.IntPtr NativeFieldInfoPtr_kShaderPassArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__globalCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightingCBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_PreviewCameraFrameParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_byref_PreviewCameraFrameParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffers_Private_Void_CommandBuffer_byref_PreviewCameraFrameParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PreviewCameraGeometryPass()
  {
    Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PreviewCameraGeometryPass));
    PreviewCameraGeometryPass.NativeFieldInfoPtr_kPerObjectDataFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (kPerObjectDataFlags));
    PreviewCameraGeometryPass.NativeFieldInfoPtr_kKeywordRenderPreviewCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (kKeywordRenderPreviewCamera));
    PreviewCameraGeometryPass.NativeFieldInfoPtr_kRenderStateCullingOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (kRenderStateCullingOff));
    PreviewCameraGeometryPass.NativeFieldInfoPtr_kShaderPassArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (kShaderPassArray));
    PreviewCameraGeometryPass.NativeFieldInfoPtr__globalCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (_globalCBuffer));
    PreviewCameraGeometryPass.NativeFieldInfoPtr__lightingCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (_lightingCBuffer));
    PreviewCameraGeometryPass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_PreviewCameraFrameParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, 100663494 /*0x060000C6*/);
    PreviewCameraGeometryPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, 100663496 /*0x060000C8*/);
    PreviewCameraGeometryPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_byref_PreviewCameraFrameParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, 100663497 /*0x060000C9*/);
    PreviewCameraGeometryPass.NativeMethodInfoPtr_SetupCBuffers_Private_Void_CommandBuffer_byref_PreviewCameraFrameParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, 100663498 /*0x060000CA*/);
    PreviewCameraGeometryPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, 100663499 /*0x060000CB*/);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 925538, RefRangeEnd = 925542, XrefRangeStart = 925522, XrefRangeEnd = 925538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererList MakeRendererList(
    [In] ref ScriptableRenderContext ctx,
    [In] ref PreviewCameraFrameParams fp,
    Il2CppStructArray<ShaderTagId> shaderPassArray,
    SortingCriteria sortingCriteria,
    RenderQueueRange renderQueueRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) fp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shaderPassArray);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &renderQueueRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PreviewCameraGeometryPass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_PreviewCameraFrameParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925542, XrefRangeEnd = 925559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PreviewCameraGeometryPass()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraGeometryPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925612, RefRangeEnd = 925613, XrefRangeStart = 925559, XrefRangeEnd = 925612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    RenderTextureResource texSceneColor,
    [In] ref PreviewCameraFrameParams fp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) fp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraGeometryPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_byref_PreviewCameraFrameParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925624, RefRangeEnd = 925625, XrefRangeStart = 925613, XrefRangeEnd = 925624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffers(CommandBuffer cmd, [In] ref PreviewCameraFrameParams fp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) fp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraGeometryPass.NativeMethodInfoPtr_SetupCBuffers_Private_Void_CommandBuffer_byref_PreviewCameraFrameParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925625, XrefRangeEnd = 925632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraGeometryPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe PerObjectData kPerObjectDataFlags
  {
    get
    {
      PerObjectData perObjectDataFlags;
      IL2CPP.il2cpp_field_static_get_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kPerObjectDataFlags, (void*) &perObjectDataFlags);
      return perObjectDataFlags;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kPerObjectDataFlags, (void*) &value);
    }
  }

  public static unsafe GlobalKeyword kKeywordRenderPreviewCamera
  {
    get
    {
      System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kKeywordRenderPreviewCamera, (void*) num);
      return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, num));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kKeywordRenderPreviewCamera, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public static unsafe RenderStateBlock kRenderStateCullingOff
  {
    get
    {
      RenderStateBlock renderStateCullingOff;
      IL2CPP.il2cpp_field_static_get_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kRenderStateCullingOff, (void*) &renderStateCullingOff);
      return renderStateCullingOff;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kRenderStateCullingOff, (void*) &value);
    }
  }

  public static unsafe Il2CppStructArray<ShaderTagId> kShaderPassArray
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kShaderPassArray, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<ShaderTagId>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PreviewCameraGeometryPass.NativeFieldInfoPtr_kShaderPassArray, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData> _globalCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraGeometryPass.NativeFieldInfoPtr__globalCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>) null : Il2CppObjectPool.Get<CBuffer<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraGeometryPass.NativeFieldInfoPtr__globalCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData> _lightingCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraGeometryPass.NativeFieldInfoPtr__lightingCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>) null : Il2CppObjectPool.Get<CBuffer<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraGeometryPass.NativeFieldInfoPtr__lightingCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PreviewCameraGlobalCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrixInv;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraPositionWs;
    [FieldOffset(0)]
    public Matrix4x4 projectionViewMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Matrix4x4 projectionMatrix;
    [FieldOffset(128 /*0x80*/)]
    public Matrix4x4 viewMatrix;
    [FieldOffset(192 /*0xC0*/)]
    public Matrix4x4 viewMatrixInv;
    [FieldOffset(256 /*0x0100*/)]
    public Vector4 depthProjectionParams;
    [FieldOffset(272)]
    public Vector4 cameraPositionWs;

    static PreviewCameraGlobalCBufferData()
    {
      Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (PreviewCameraGlobalCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr);
      PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, nameof (projectionViewMatrix));
      PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, nameof (projectionMatrix));
      PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, nameof (viewMatrix));
      PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData.NativeFieldInfoPtr_viewMatrixInv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, nameof (viewMatrixInv));
      PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, nameof (depthProjectionParams));
      PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData.NativeFieldInfoPtr_cameraPositionWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, nameof (cameraPositionWs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraGlobalCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PreviewCameraLightingCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraLightTint;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraLightIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraLightNeagativeForward;
    [FieldOffset(0)]
    public Vector3 cameraLightTint;
    [FieldOffset(12)]
    public float cameraLightIntensity;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 cameraLightNeagativeForward;

    static PreviewCameraLightingCBufferData()
    {
      Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreviewCameraGeometryPass>.NativeClassPtr, nameof (PreviewCameraLightingCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>.NativeClassPtr);
      PreviewCameraGeometryPass.PreviewCameraLightingCBufferData.NativeFieldInfoPtr_cameraLightTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>.NativeClassPtr, nameof (cameraLightTint));
      PreviewCameraGeometryPass.PreviewCameraLightingCBufferData.NativeFieldInfoPtr_cameraLightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>.NativeClassPtr, nameof (cameraLightIntensity));
      PreviewCameraGeometryPass.PreviewCameraLightingCBufferData.NativeFieldInfoPtr_cameraLightNeagativeForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>.NativeClassPtr, nameof (cameraLightNeagativeForward));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreviewCameraGeometryPass.PreviewCameraLightingCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
