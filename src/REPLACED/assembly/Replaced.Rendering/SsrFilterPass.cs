// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SsrFilterPass
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

public sealed class SsrFilterPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputGlobalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMinHINormal;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutputSpecularGI;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelNormalWeight;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelAverage;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static SsrFilterPass()
  {
    Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SsrFilterPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr);
    SsrFilterPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (kGroupSize));
    SsrFilterPass.NativeFieldInfoPtr_kSidTexInputGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (kSidTexInputGlobalIllumination));
    SsrFilterPass.NativeFieldInfoPtr_kSidTexMinHINormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (kSidTexMinHINormal));
    SsrFilterPass.NativeFieldInfoPtr_kSidTexOutputSpecularGI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (kSidTexOutputSpecularGI));
    SsrFilterPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (_compute));
    SsrFilterPass.NativeFieldInfoPtr__kernelNormalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (_kernelNormalWeight));
    SsrFilterPass.NativeFieldInfoPtr__kernelAverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (_kernelAverage));
    SsrFilterPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (_cbuffer));
    SsrFilterPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, 100663901);
    SsrFilterPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, 100663902);
    SsrFilterPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, 100663903);
    SsrFilterPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, 100663904 /*0x06000260*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930576, RefRangeEnd = 930577, XrefRangeStart = 930561, XrefRangeEnd = 930576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SsrFilterPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrFilterPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930612, RefRangeEnd = 930613, XrefRangeStart = 930577, XrefRangeEnd = 930612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texGlobalIllumination,
    RenderTextureResource texMinHINormal,
    RenderTextureResource texOutputSpecularGI,
    Vector4 depthProjectionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHINormal));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputSpecularGI));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrFilterPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930613, XrefRangeEnd = 930631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector2Int texSize,
    Vector4 depthProjectionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrFilterPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930635, RefRangeEnd = 930636, XrefRangeStart = 930631, XrefRangeEnd = 930635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsrFilterPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(SsrFilterPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrFilterPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputGlobalIllumination
  {
    get
    {
      int globalIllumination;
      IL2CPP.il2cpp_field_static_get_value(SsrFilterPass.NativeFieldInfoPtr_kSidTexInputGlobalIllumination, (void*) &globalIllumination);
      return globalIllumination;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrFilterPass.NativeFieldInfoPtr_kSidTexInputGlobalIllumination, (void*) &value);
    }
  }

  public static unsafe int kSidTexMinHINormal
  {
    get
    {
      int sidTexMinHiNormal;
      IL2CPP.il2cpp_field_static_get_value(SsrFilterPass.NativeFieldInfoPtr_kSidTexMinHINormal, (void*) &sidTexMinHiNormal);
      return sidTexMinHiNormal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrFilterPass.NativeFieldInfoPtr_kSidTexMinHINormal, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutputSpecularGI
  {
    get
    {
      int outputSpecularGi;
      IL2CPP.il2cpp_field_static_get_value(SsrFilterPass.NativeFieldInfoPtr_kSidTexOutputSpecularGI, (void*) &outputSpecularGi);
      return outputSpecularGi;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsrFilterPass.NativeFieldInfoPtr_kSidTexOutputSpecularGI, (void*) &value);
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernelNormalWeight
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__kernelNormalWeight));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__kernelNormalWeight)) = value;
    }
  }

  public unsafe int _kernelAverage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__kernelAverage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__kernelAverage)) = value;
    }
  }

  public unsafe CBuffer<SsrFilterPass.SsrFilterCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<SsrFilterPass.SsrFilterCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SsrFilterPass.SsrFilterCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsrFilterPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SsrFilterCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
    [FieldOffset(0)]
    public Vector2Int padding;
    [FieldOffset(8)]
    public Vector2Int texOutputSize;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 depthProjectionParams;

    static SsrFilterCBufferData()
    {
      Il2CppClassPointerStore<SsrFilterPass.SsrFilterCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SsrFilterPass>.NativeClassPtr, nameof (SsrFilterCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsrFilterPass.SsrFilterCBufferData>.NativeClassPtr);
      SsrFilterPass.SsrFilterCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass.SsrFilterCBufferData>.NativeClassPtr, nameof (padding));
      SsrFilterPass.SsrFilterCBufferData.NativeFieldInfoPtr_texOutputSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass.SsrFilterCBufferData>.NativeClassPtr, nameof (texOutputSize));
      SsrFilterPass.SsrFilterCBufferData.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsrFilterPass.SsrFilterCBufferData>.NativeClassPtr, nameof (depthProjectionParams));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SsrFilterPass.SsrFilterCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
