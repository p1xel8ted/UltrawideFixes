// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GaussianBlurPass
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

public sealed class GaussianBlurPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelFlipVert;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_0;

  static GaussianBlurPass()
  {
    Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GaussianBlurPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr);
    GaussianBlurPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (kGroupSize));
    GaussianBlurPass.NativeFieldInfoPtr_kSidTexInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (kSidTexInput));
    GaussianBlurPass.NativeFieldInfoPtr_kSidTexOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (kSidTexOutput));
    GaussianBlurPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (_cbuffer));
    GaussianBlurPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (_compute));
    GaussianBlurPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (_kernel));
    GaussianBlurPass.NativeFieldInfoPtr__kernelFlipVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (_kernelFlipVert));
    GaussianBlurPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, 100663476 /*0x060000B4*/);
    GaussianBlurPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, 100663477 /*0x060000B5*/);
    GaussianBlurPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, 100663478 /*0x060000B6*/);
    GaussianBlurPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, 100663479 /*0x060000B7*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925322, XrefRangeEnd = 925337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GaussianBlurPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GaussianBlurPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925337, XrefRangeEnd = 925365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texInput,
    RenderTextureResource texOutput,
    bool flipVert = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flipVert;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GaussianBlurPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925365, XrefRangeEnd = 925369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GaussianBlurPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925369, XrefRangeEnd = 925383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, Vector2Int texOutputSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texOutputSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GaussianBlurPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(GaussianBlurPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GaussianBlurPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexInput
  {
    get
    {
      int kSidTexInput;
      IL2CPP.il2cpp_field_static_get_value(GaussianBlurPass.NativeFieldInfoPtr_kSidTexInput, (void*) &kSidTexInput);
      return kSidTexInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GaussianBlurPass.NativeFieldInfoPtr_kSidTexInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutput
  {
    get
    {
      int kSidTexOutput;
      IL2CPP.il2cpp_field_static_get_value(GaussianBlurPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &kSidTexOutput);
      return kSidTexOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GaussianBlurPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &value);
    }
  }

  public unsafe CBuffer<GaussianBlurPass.GaussianBlurCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GaussianBlurPass.GaussianBlurCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GaussianBlurPass.GaussianBlurCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  public unsafe int _kernelFlipVert
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__kernelFlipVert));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GaussianBlurPass.NativeFieldInfoPtr__kernelFlipVert)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GaussianBlurCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputCoordToUv;
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 texOutputCoordToUv;
    [FieldOffset(16 /*0x10*/)]
    public Vector2Int texOutputSize;
    [FieldOffset(24)]
    public Vector2 padding;

    static GaussianBlurCBufferData()
    {
      Il2CppClassPointerStore<GaussianBlurPass.GaussianBlurCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GaussianBlurPass>.NativeClassPtr, nameof (GaussianBlurCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GaussianBlurPass.GaussianBlurCBufferData>.NativeClassPtr);
      GaussianBlurPass.GaussianBlurCBufferData.NativeFieldInfoPtr_texOutputCoordToUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass.GaussianBlurCBufferData>.NativeClassPtr, nameof (texOutputCoordToUv));
      GaussianBlurPass.GaussianBlurCBufferData.NativeFieldInfoPtr_texOutputSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass.GaussianBlurCBufferData>.NativeClassPtr, nameof (texOutputSize));
      GaussianBlurPass.GaussianBlurCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaussianBlurPass.GaussianBlurCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GaussianBlurPass.GaussianBlurCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
