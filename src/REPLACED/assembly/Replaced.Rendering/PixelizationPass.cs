// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PixelizationPass
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

public sealed class PixelizationPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kPerObjectDataFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexLowResColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexLowResDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kShaderPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__blitMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbufferBlit;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_byref_RenderTargetBinding_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffers_Private_Void_CommandBuffer_Vector2Int_byref_PixelizationParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PixelizationPass()
  {
    Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PixelizationPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr);
    PixelizationPass.NativeFieldInfoPtr_kPerObjectDataFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (kPerObjectDataFlags));
    PixelizationPass.NativeFieldInfoPtr_kSidTexLowResColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (kSidTexLowResColor));
    PixelizationPass.NativeFieldInfoPtr_kSidTexLowResDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (kSidTexLowResDepth));
    PixelizationPass.NativeFieldInfoPtr_kShaderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (kShaderPass));
    PixelizationPass.NativeFieldInfoPtr__blitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (_blitMaterial));
    PixelizationPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (_cbuffer));
    PixelizationPass.NativeFieldInfoPtr__cbufferBlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (_cbufferBlit));
    PixelizationPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, 100663802);
    PixelizationPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_byref_RenderTargetBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, 100663803);
    PixelizationPass.NativeMethodInfoPtr_SetupCBuffers_Private_Void_CommandBuffer_Vector2Int_byref_PixelizationParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, 100663804);
    PixelizationPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, 100663805);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929296, XrefRangeEnd = 929317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PixelizationPass(Shader blitShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blitShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PixelizationPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929383, RefRangeEnd = 929384, XrefRangeStart = 929317, XrefRangeEnd = 929383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp,
    [In] ref RenderTargetBinding renderTargetBinding)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) renderTargetBinding);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PixelizationPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_byref_RenderTargetBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929384, XrefRangeEnd = 929406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffers(
    CommandBuffer cmd,
    Vector2Int fullResPixels,
    [In] ref PixelizationParams pixelizationParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fullResPixels;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pixelizationParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PixelizationPass.NativeMethodInfoPtr_SetupCBuffers_Private_Void_CommandBuffer_Vector2Int_byref_PixelizationParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929406, XrefRangeEnd = 929417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PixelizationPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe PerObjectData kPerObjectDataFlags
  {
    get
    {
      PerObjectData perObjectDataFlags;
      IL2CPP.il2cpp_field_static_get_value(PixelizationPass.NativeFieldInfoPtr_kPerObjectDataFlags, (void*) &perObjectDataFlags);
      return perObjectDataFlags;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PixelizationPass.NativeFieldInfoPtr_kPerObjectDataFlags, (void*) &value);
    }
  }

  public static unsafe int kSidTexLowResColor
  {
    get
    {
      int sidTexLowResColor;
      IL2CPP.il2cpp_field_static_get_value(PixelizationPass.NativeFieldInfoPtr_kSidTexLowResColor, (void*) &sidTexLowResColor);
      return sidTexLowResColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PixelizationPass.NativeFieldInfoPtr_kSidTexLowResColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexLowResDepth
  {
    get
    {
      int sidTexLowResDepth;
      IL2CPP.il2cpp_field_static_get_value(PixelizationPass.NativeFieldInfoPtr_kSidTexLowResDepth, (void*) &sidTexLowResDepth);
      return sidTexLowResDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PixelizationPass.NativeFieldInfoPtr_kSidTexLowResDepth, (void*) &value);
    }
  }

  public static unsafe ShaderTagId kShaderPass
  {
    get
    {
      ShaderTagId kShaderPass;
      IL2CPP.il2cpp_field_static_get_value(PixelizationPass.NativeFieldInfoPtr_kShaderPass, (void*) &kShaderPass);
      return kShaderPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PixelizationPass.NativeFieldInfoPtr_kShaderPass, (void*) &value);
    }
  }

  public unsafe Material _blitMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PixelizationPass.NativeFieldInfoPtr__blitMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PixelizationPass.NativeFieldInfoPtr__blitMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<PixelizationPass.PixelizationCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PixelizationPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<PixelizationPass.PixelizationCBufferData>) null : Il2CppObjectPool.Get<CBuffer<PixelizationPass.PixelizationCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PixelizationPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<PixelizationPass.PixelizationBlitCBufferData> _cbufferBlit
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PixelizationPass.NativeFieldInfoPtr__cbufferBlit));
      return num == System.IntPtr.Zero ? (CBuffer<PixelizationPass.PixelizationBlitCBufferData>) null : Il2CppObjectPool.Get<CBuffer<PixelizationPass.PixelizationBlitCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PixelizationPass.NativeFieldInfoPtr__cbufferBlit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PixelizationCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_lowRes2FullRes;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector2 lowRes2FullRes;
    [FieldOffset(8)]
    public Vector2 padding;

    static PixelizationCBufferData()
    {
      Il2CppClassPointerStore<PixelizationPass.PixelizationCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (PixelizationCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelizationPass.PixelizationCBufferData>.NativeClassPtr);
      PixelizationPass.PixelizationCBufferData.NativeFieldInfoPtr_lowRes2FullRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass.PixelizationCBufferData>.NativeClassPtr, nameof (lowRes2FullRes));
      PixelizationPass.PixelizationCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass.PixelizationCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PixelizationPass.PixelizationCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PixelizationBlitCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_posterizationLevels;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public float posterizationLevels;
    [FieldOffset(4)]
    public Vector3 padding;

    static PixelizationBlitCBufferData()
    {
      Il2CppClassPointerStore<PixelizationPass.PixelizationBlitCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PixelizationPass>.NativeClassPtr, nameof (PixelizationBlitCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelizationPass.PixelizationBlitCBufferData>.NativeClassPtr);
      PixelizationPass.PixelizationBlitCBufferData.NativeFieldInfoPtr_posterizationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass.PixelizationBlitCBufferData>.NativeClassPtr, nameof (posterizationLevels));
      PixelizationPass.PixelizationBlitCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelizationPass.PixelizationBlitCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PixelizationPass.PixelizationBlitCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
