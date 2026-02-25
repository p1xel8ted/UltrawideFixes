// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ResolveMsaaPass
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

public class ResolveMsaaPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kColorResolveX4Pass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kColorResolveX8Pass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDepthResolveX4Pass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDepthResolveX8Pass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexColorMsaa;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMotionVectorsMsaa;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDepthMsaa;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__resolveColorMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__resolveDepthMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_MsaaMode_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector2Int_0;

  static ResolveMsaaPass()
  {
    Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ResolveMsaaPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr);
    ResolveMsaaPass.NativeFieldInfoPtr_kColorResolveX4Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kColorResolveX4Pass));
    ResolveMsaaPass.NativeFieldInfoPtr_kColorResolveX8Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kColorResolveX8Pass));
    ResolveMsaaPass.NativeFieldInfoPtr_kDepthResolveX4Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kDepthResolveX4Pass));
    ResolveMsaaPass.NativeFieldInfoPtr_kDepthResolveX8Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kDepthResolveX8Pass));
    ResolveMsaaPass.NativeFieldInfoPtr_kSidTexColorMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kSidTexColorMsaa));
    ResolveMsaaPass.NativeFieldInfoPtr_kSidTexMotionVectorsMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kSidTexMotionVectorsMsaa));
    ResolveMsaaPass.NativeFieldInfoPtr_kSidTexDepthMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (kSidTexDepthMsaa));
    ResolveMsaaPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (_cbuffer));
    ResolveMsaaPass.NativeFieldInfoPtr__resolveColorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (_resolveColorMaterial));
    ResolveMsaaPass.NativeFieldInfoPtr__resolveDepthMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, nameof (_resolveDepthMaterial));
    ResolveMsaaPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, 100664179);
    ResolveMsaaPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_MsaaMode_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, 100664180);
    ResolveMsaaPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, 100664181);
    ResolveMsaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr, 100664182);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934301, XrefRangeEnd = 934315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResolveMsaaPass(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveMsaaPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResolveMsaaPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934315, XrefRangeEnd = 934350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    MsaaMode msaaMode,
    [In] ref RenderTextureResource texColorMsaa,
    [In] ref RenderTextureResource texMotionVectorsMsaa,
    [In] ref RenderTextureResource texDepthMsaa,
    [In] ref RenderTextureResource texColorResolveTarget,
    [In] ref RenderTextureResource texMotionVectorsResoulveTarget,
    [In] ref RenderTextureResource texDepthResolveTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &msaaMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColorMsaa);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMotionVectorsMsaa);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDepthMsaa);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColorResolveTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMotionVectorsResoulveTarget);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDepthResolveTarget);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResolveMsaaPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_MsaaMode_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934350, XrefRangeEnd = 934359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResolveMsaaPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934359, XrefRangeEnd = 934376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, [In] ref Vector2Int viewportSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewportSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResolveMsaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kColorResolveX4Pass
  {
    get
    {
      int colorResolveX4Pass;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kColorResolveX4Pass, (void*) &colorResolveX4Pass);
      return colorResolveX4Pass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kColorResolveX4Pass, (void*) &value);
    }
  }

  public static unsafe int kColorResolveX8Pass
  {
    get
    {
      int colorResolveX8Pass;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kColorResolveX8Pass, (void*) &colorResolveX8Pass);
      return colorResolveX8Pass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kColorResolveX8Pass, (void*) &value);
    }
  }

  public static unsafe int kDepthResolveX4Pass
  {
    get
    {
      int depthResolveX4Pass;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kDepthResolveX4Pass, (void*) &depthResolveX4Pass);
      return depthResolveX4Pass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kDepthResolveX4Pass, (void*) &value);
    }
  }

  public static unsafe int kDepthResolveX8Pass
  {
    get
    {
      int depthResolveX8Pass;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kDepthResolveX8Pass, (void*) &depthResolveX8Pass);
      return depthResolveX8Pass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kDepthResolveX8Pass, (void*) &value);
    }
  }

  public static unsafe int kSidTexColorMsaa
  {
    get
    {
      int kSidTexColorMsaa;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kSidTexColorMsaa, (void*) &kSidTexColorMsaa);
      return kSidTexColorMsaa;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kSidTexColorMsaa, (void*) &value);
    }
  }

  public static unsafe int kSidTexMotionVectorsMsaa
  {
    get
    {
      int motionVectorsMsaa;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kSidTexMotionVectorsMsaa, (void*) &motionVectorsMsaa);
      return motionVectorsMsaa;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kSidTexMotionVectorsMsaa, (void*) &value);
    }
  }

  public static unsafe int kSidTexDepthMsaa
  {
    get
    {
      int kSidTexDepthMsaa;
      IL2CPP.il2cpp_field_static_get_value(ResolveMsaaPass.NativeFieldInfoPtr_kSidTexDepthMsaa, (void*) &kSidTexDepthMsaa);
      return kSidTexDepthMsaa;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResolveMsaaPass.NativeFieldInfoPtr_kSidTexDepthMsaa, (void*) &value);
    }
  }

  public unsafe CBuffer<ResolveMsaaCBuffer> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResolveMsaaPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ResolveMsaaCBuffer>) null : Il2CppObjectPool.Get<CBuffer<ResolveMsaaCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResolveMsaaPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _resolveColorMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResolveMsaaPass.NativeFieldInfoPtr__resolveColorMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResolveMsaaPass.NativeFieldInfoPtr__resolveColorMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _resolveDepthMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResolveMsaaPass.NativeFieldInfoPtr__resolveDepthMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResolveMsaaPass.NativeFieldInfoPtr__resolveDepthMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
