// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SsdoFilterPass
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

public sealed class SsdoFilterPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputGlobalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSsdoResult;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupBlurDiffuseCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector4_0;

  static SsdoFilterPass()
  {
    Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SsdoFilterPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr);
    SsdoFilterPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (kGroupSize));
    SsdoFilterPass.NativeFieldInfoPtr_kSidTexInputGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (kSidTexInputGlobalIllumination));
    SsdoFilterPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    SsdoFilterPass.NativeFieldInfoPtr_kSidTexSsdoResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (kSidTexSsdoResult));
    SsdoFilterPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (_cbuffer));
    SsdoFilterPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (_compute));
    SsdoFilterPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (_kernel));
    SsdoFilterPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, 100663896);
    SsdoFilterPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, 100663897);
    SsdoFilterPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, 100663898);
    SsdoFilterPass.NativeMethodInfoPtr_SetupBlurDiffuseCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, 100663899);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930508, RefRangeEnd = 930509, XrefRangeStart = 930496, XrefRangeEnd = 930508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SsdoFilterPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoFilterPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930537, RefRangeEnd = 930538, XrefRangeStart = 930509, XrefRangeEnd = 930537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texInputGlobalIllumination,
    RenderTextureResource texMinHIZ,
    RenderTextureResource texSsdoResult,
    Vector4 depthProjectionParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputGlobalIllumination));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSsdoResult));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthProjectionParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoFilterPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930542, RefRangeEnd = 930543, XrefRangeStart = 930538, XrefRangeEnd = 930542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SsdoFilterPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930543, XrefRangeEnd = 930561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupBlurDiffuseCBuffer(
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
    IL2CPP.il2cpp_runtime_invoke(SsdoFilterPass.NativeMethodInfoPtr_SetupBlurDiffuseCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(SsdoFilterPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoFilterPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputGlobalIllumination
  {
    get
    {
      int globalIllumination;
      IL2CPP.il2cpp_field_static_get_value(SsdoFilterPass.NativeFieldInfoPtr_kSidTexInputGlobalIllumination, (void*) &globalIllumination);
      return globalIllumination;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoFilterPass.NativeFieldInfoPtr_kSidTexInputGlobalIllumination, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(SsdoFilterPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoFilterPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexSsdoResult
  {
    get
    {
      int sidTexSsdoResult;
      IL2CPP.il2cpp_field_static_get_value(SsdoFilterPass.NativeFieldInfoPtr_kSidTexSsdoResult, (void*) &sidTexSsdoResult);
      return sidTexSsdoResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SsdoFilterPass.NativeFieldInfoPtr_kSidTexSsdoResult, (void*) &value);
    }
  }

  public unsafe CBuffer<SsdoFilterPass.SsdoFilterCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoFilterPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<SsdoFilterPass.SsdoFilterCBufferData>) null : Il2CppObjectPool.Get<CBuffer<SsdoFilterPass.SsdoFilterCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsdoFilterPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoFilterPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SsdoFilterPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoFilterPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SsdoFilterPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SsdoFilterCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texCoordToUv;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
    [FieldOffset(0)]
    public Vector4 texCoordToUv;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 depthProjectionParams;

    static SsdoFilterCBufferData()
    {
      Il2CppClassPointerStore<SsdoFilterPass.SsdoFilterCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SsdoFilterPass>.NativeClassPtr, nameof (SsdoFilterCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SsdoFilterPass.SsdoFilterCBufferData>.NativeClassPtr);
      SsdoFilterPass.SsdoFilterCBufferData.NativeFieldInfoPtr_texCoordToUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass.SsdoFilterCBufferData>.NativeClassPtr, nameof (texCoordToUv));
      SsdoFilterPass.SsdoFilterCBufferData.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SsdoFilterPass.SsdoFilterCBufferData>.NativeClassPtr, nameof (depthProjectionParams));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SsdoFilterPass.SsdoFilterCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
