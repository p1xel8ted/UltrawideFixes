// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.RenderBokehPass
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

public sealed class RenderBokehPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGenerateBokehGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexGenerateBokehPointInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCoc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidBokehPointBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBokehShape;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexArrayBokehShape;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__bokehDrawIndirectArgsBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__renderBokehMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_byref_RenderTextureResource_ComputeBuffer_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_DepthOfFieldParams_0;

  static RenderBokehPass()
  {
    Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (RenderBokehPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr);
    RenderBokehPass.NativeFieldInfoPtr_kGenerateBokehGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (kGenerateBokehGroupSize));
    RenderBokehPass.NativeFieldInfoPtr_kSidTexGenerateBokehPointInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (kSidTexGenerateBokehPointInput));
    RenderBokehPass.NativeFieldInfoPtr_kSidTexCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (kSidTexCoc));
    RenderBokehPass.NativeFieldInfoPtr_kSidBokehPointBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (kSidBokehPointBuffer));
    RenderBokehPass.NativeFieldInfoPtr_kSidTexBokehShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (kSidTexBokehShape));
    RenderBokehPass.NativeFieldInfoPtr_kSidTexArrayBokehShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (kSidTexArrayBokehShape));
    RenderBokehPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (_cbuffer));
    RenderBokehPass.NativeFieldInfoPtr__bokehDrawIndirectArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (_bokehDrawIndirectArgsBuffer));
    RenderBokehPass.NativeFieldInfoPtr__renderBokehMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (_renderBokehMaterial));
    RenderBokehPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, 100664150);
    RenderBokehPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_byref_RenderTextureResource_ComputeBuffer_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, 100664151);
    RenderBokehPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, 100664152);
    RenderBokehPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_DepthOfFieldParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, 100664153);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933763, RefRangeEnd = 933764, XrefRangeStart = 933746, XrefRangeEnd = 933763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderBokehPass(Shader renderBokehShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderBokehShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderBokehPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933815, RefRangeEnd = 933816, XrefRangeStart = 933764, XrefRangeEnd = 933815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    [In] ref RenderTextureResource texCoc,
    ComputeBuffer bokehPointBuffer,
    [In] ref RenderTextureResource texBokehColorOutput)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCoc);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bokehPointBuffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBokehColorOutput);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderBokehPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_byref_RenderTextureResource_ComputeBuffer_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933821, RefRangeEnd = 933822, XrefRangeStart = 933816, XrefRangeEnd = 933821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderBokehPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933848, RefRangeEnd = 933849, XrefRangeStart = 933822, XrefRangeEnd = 933848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector2Int renderTargetSize,
    [In] ref DepthOfFieldParams dof)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderTargetSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderBokehPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_byref_DepthOfFieldParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGenerateBokehGroupSize
  {
    get
    {
      Vector2Int generateBokehGroupSize;
      IL2CPP.il2cpp_field_static_get_value(RenderBokehPass.NativeFieldInfoPtr_kGenerateBokehGroupSize, (void*) &generateBokehGroupSize);
      return generateBokehGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderBokehPass.NativeFieldInfoPtr_kGenerateBokehGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexGenerateBokehPointInput
  {
    get
    {
      int generateBokehPointInput;
      IL2CPP.il2cpp_field_static_get_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexGenerateBokehPointInput, (void*) &generateBokehPointInput);
      return generateBokehPointInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexGenerateBokehPointInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexCoc
  {
    get
    {
      int kSidTexCoc;
      IL2CPP.il2cpp_field_static_get_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &kSidTexCoc);
      return kSidTexCoc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &value);
    }
  }

  public static unsafe int kSidBokehPointBuffer
  {
    get
    {
      int bokehPointBuffer;
      IL2CPP.il2cpp_field_static_get_value(RenderBokehPass.NativeFieldInfoPtr_kSidBokehPointBuffer, (void*) &bokehPointBuffer);
      return bokehPointBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderBokehPass.NativeFieldInfoPtr_kSidBokehPointBuffer, (void*) &value);
    }
  }

  public static unsafe int kSidTexBokehShape
  {
    get
    {
      int sidTexBokehShape;
      IL2CPP.il2cpp_field_static_get_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexBokehShape, (void*) &sidTexBokehShape);
      return sidTexBokehShape;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexBokehShape, (void*) &value);
    }
  }

  public static unsafe int kSidTexArrayBokehShape
  {
    get
    {
      int texArrayBokehShape;
      IL2CPP.il2cpp_field_static_get_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexArrayBokehShape, (void*) &texArrayBokehShape);
      return texArrayBokehShape;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderBokehPass.NativeFieldInfoPtr_kSidTexArrayBokehShape, (void*) &value);
    }
  }

  public unsafe CBuffer<RenderBokehPass.RenderBokehCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderBokehPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<RenderBokehPass.RenderBokehCBufferData>) null : Il2CppObjectPool.Get<CBuffer<RenderBokehPass.RenderBokehCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderBokehPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DrawIndirectArgsBuffer _bokehDrawIndirectArgsBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderBokehPass.NativeFieldInfoPtr__bokehDrawIndirectArgsBuffer));
      return num == System.IntPtr.Zero ? (DrawIndirectArgsBuffer) null : Il2CppObjectPool.Get<DrawIndirectArgsBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderBokehPass.NativeFieldInfoPtr__bokehDrawIndirectArgsBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _renderBokehMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderBokehPass.NativeFieldInfoPtr__renderBokehMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderBokehPass.NativeFieldInfoPtr__renderBokehMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct RenderBokehCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_vertexScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMultiplierForeground;
    private static readonly System.IntPtr NativeFieldInfoPtr_bokehIntensityMultiplierBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetSizeRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_cocDifferenceThresholdForeground;
    private static readonly System.IntPtr NativeFieldInfoPtr_cocDifferenceThresholdBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_fadeRangeForeground;
    private static readonly System.IntPtr NativeFieldInfoPtr_fadeRangeBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_debugBokehColor;
    [FieldOffset(0)]
    public Vector4 vertexScale;
    [FieldOffset(16 /*0x10*/)]
    public float bokehIntensityMin;
    [FieldOffset(20)]
    public float bokehIntensityMax;
    [FieldOffset(24)]
    public float bokehIntensityMultiplierForeground;
    [FieldOffset(28)]
    public float bokehIntensityMultiplierBackground;
    [FieldOffset(32 /*0x20*/)]
    public Vector2 renderTargetSizeRcp;
    [FieldOffset(40)]
    public float cocDifferenceThresholdForeground;
    [FieldOffset(44)]
    public float cocDifferenceThresholdBackground;
    [FieldOffset(48 /*0x30*/)]
    public Vector2 fadeRangeForeground;
    [FieldOffset(56)]
    public Vector2 fadeRangeBackground;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 debugBokehColor;

    static RenderBokehCBufferData()
    {
      Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderBokehPass>.NativeClassPtr, nameof (RenderBokehCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr);
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_vertexScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (vertexScale));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_bokehIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (bokehIntensityMin));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_bokehIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (bokehIntensityMax));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_bokehIntensityMultiplierForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (bokehIntensityMultiplierForeground));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_bokehIntensityMultiplierBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (bokehIntensityMultiplierBackground));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_renderTargetSizeRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (renderTargetSizeRcp));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_cocDifferenceThresholdForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (cocDifferenceThresholdForeground));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_cocDifferenceThresholdBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (cocDifferenceThresholdBackground));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_fadeRangeForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (fadeRangeForeground));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_fadeRangeBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (fadeRangeBackground));
      RenderBokehPass.RenderBokehCBufferData.NativeFieldInfoPtr_debugBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, nameof (debugBokehColor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderBokehPass.RenderBokehCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
