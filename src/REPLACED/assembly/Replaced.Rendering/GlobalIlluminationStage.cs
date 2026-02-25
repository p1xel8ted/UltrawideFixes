// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GlobalIlluminationStage
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

public sealed class GlobalIlluminationStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ssdoEstimatePass;
  private static readonly System.IntPtr NativeFieldInfoPtr__ssdoFilterPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__ssrTracePass;
  private static readonly System.IntPtr NativeFieldInfoPtr__ssrResolvePass;
  private static readonly System.IntPtr NativeFieldInfoPtr__ssrFilterPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__giTemporalPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__texBlankGlobalIllumination;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexSsdoTmpResult_Private_Static_RenderTextureResource_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexAmbientVisibility_Private_Static_RenderTextureResource_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexHitInfo_Private_Static_RenderTextureResource_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexSpecularGI_Private_Static_RenderTextureResource_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GlobalIlluminationStage()
  {
    Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GlobalIlluminationStage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr);
    GlobalIlluminationStage.NativeFieldInfoPtr__ssdoEstimatePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_ssdoEstimatePass));
    GlobalIlluminationStage.NativeFieldInfoPtr__ssdoFilterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_ssdoFilterPass));
    GlobalIlluminationStage.NativeFieldInfoPtr__ssrTracePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_ssrTracePass));
    GlobalIlluminationStage.NativeFieldInfoPtr__ssrResolvePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_ssrResolvePass));
    GlobalIlluminationStage.NativeFieldInfoPtr__ssrFilterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_ssrFilterPass));
    GlobalIlluminationStage.NativeFieldInfoPtr__giTemporalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_giTemporalPass));
    GlobalIlluminationStage.NativeFieldInfoPtr__texBlankGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, nameof (_texBlankGlobalIllumination));
    GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexSsdoTmpResult_Private_Static_RenderTextureResource_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663870);
    GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexAmbientVisibility_Private_Static_RenderTextureResource_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663871);
    GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexHitInfo_Private_Static_RenderTextureResource_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663872 /*0x06000240*/);
    GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexSpecularGI_Private_Static_RenderTextureResource_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663873);
    GlobalIlluminationStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663874);
    GlobalIlluminationStage.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663875);
    GlobalIlluminationStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr, 100663876);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930018, XrefRangeEnd = 930029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexSsdoTmpResult(Vector2Int texSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &texSize
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexSsdoTmpResult_Private_Static_RenderTextureResource_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930029, XrefRangeEnd = 930044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexAmbientVisibility(Vector2Int texSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &texSize
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexAmbientVisibility_Private_Static_RenderTextureResource_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930044, XrefRangeEnd = 930059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexHitInfo(Vector2Int texSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &texSize
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexHitInfo_Private_Static_RenderTextureResource_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930059, XrefRangeEnd = 930074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexSpecularGI(Vector2Int texSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &texSize
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr_MakeTexSpecularGI_Private_Static_RenderTextureResource_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930110, RefRangeEnd = 930111, XrefRangeStart = 930074, XrefRangeEnd = 930110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalIlluminationStage(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalIlluminationStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 930211, RefRangeEnd = 930213, XrefRangeStart = 930111, XrefRangeEnd = 930211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(CommandBuffer cmd, SceneFrame frame, [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930222, RefRangeEnd = 930223, XrefRangeStart = 930213, XrefRangeEnd = 930222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SsdoEstimatePass _ssdoEstimatePass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssdoEstimatePass));
      return num == System.IntPtr.Zero ? (SsdoEstimatePass) null : Il2CppObjectPool.Get<SsdoEstimatePass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssdoEstimatePass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SsdoFilterPass _ssdoFilterPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssdoFilterPass));
      return num == System.IntPtr.Zero ? (SsdoFilterPass) null : Il2CppObjectPool.Get<SsdoFilterPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssdoFilterPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SsrTracePass _ssrTracePass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssrTracePass));
      return num == System.IntPtr.Zero ? (SsrTracePass) null : Il2CppObjectPool.Get<SsrTracePass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssrTracePass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SsrResolvePass _ssrResolvePass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssrResolvePass));
      return num == System.IntPtr.Zero ? (SsrResolvePass) null : Il2CppObjectPool.Get<SsrResolvePass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssrResolvePass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SsrFilterPass _ssrFilterPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssrFilterPass));
      return num == System.IntPtr.Zero ? (SsrFilterPass) null : Il2CppObjectPool.Get<SsrFilterPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__ssrFilterPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GITemporalPass _giTemporalPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__giTemporalPass));
      return num == System.IntPtr.Zero ? (GITemporalPass) null : Il2CppObjectPool.Get<GITemporalPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__giTemporalPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2DArray _texBlankGlobalIllumination
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__texBlankGlobalIllumination));
      return num == System.IntPtr.Zero ? (Texture2DArray) null : Il2CppObjectPool.Get<Texture2DArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIlluminationStage.NativeFieldInfoPtr__texBlankGlobalIllumination), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
