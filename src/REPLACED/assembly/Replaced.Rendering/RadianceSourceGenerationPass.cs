// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.RadianceSourceGenerationPass
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

public sealed class RadianceSourceGenerationPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexRadianceMapInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexRadianceMapOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTextureResource_Vector2Int_Weights_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Weights_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static RadianceSourceGenerationPass()
  {
    Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (RadianceSourceGenerationPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr);
    RadianceSourceGenerationPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (kGroupSize));
    RadianceSourceGenerationPass.NativeFieldInfoPtr_kSidTexRadianceMapInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (kSidTexRadianceMapInput));
    RadianceSourceGenerationPass.NativeFieldInfoPtr_kSidTexRadianceMapOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (kSidTexRadianceMapOutput));
    RadianceSourceGenerationPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (_cbuffer));
    RadianceSourceGenerationPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (_compute));
    RadianceSourceGenerationPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (_kernel));
    RadianceSourceGenerationPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, 100663885);
    RadianceSourceGenerationPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTextureResource_Vector2Int_Weights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, 100663886);
    RadianceSourceGenerationPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Weights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, 100663887);
    RadianceSourceGenerationPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, 100663888 /*0x06000250*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930384, RefRangeEnd = 930385, XrefRangeStart = 930372, XrefRangeEnd = 930384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RadianceSourceGenerationPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceGenerationPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930385, XrefRangeEnd = 930403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTargetIdentifier texRtidRadianceMapInput,
    RenderTextureResource texRadianceMapOutput,
    Vector2Int outputMipmapSize,
    RadianceSourceGenerationPass.Weights weights)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texRtidRadianceMapInput;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texRadianceMapOutput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &outputMipmapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &weights;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceGenerationPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTextureResource_Vector2Int_Weights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930403, XrefRangeEnd = 930417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector2Int texOutputSize,
    RadianceSourceGenerationPass.Weights weights)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texOutputSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &weights;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceGenerationPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Weights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930421, RefRangeEnd = 930422, XrefRangeStart = 930417, XrefRangeEnd = 930421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RadianceSourceGenerationPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceGenerationPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceGenerationPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexRadianceMapInput
  {
    get
    {
      int radianceMapInput;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceGenerationPass.NativeFieldInfoPtr_kSidTexRadianceMapInput, (void*) &radianceMapInput);
      return radianceMapInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceGenerationPass.NativeFieldInfoPtr_kSidTexRadianceMapInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexRadianceMapOutput
  {
    get
    {
      int radianceMapOutput;
      IL2CPP.il2cpp_field_static_get_value(RadianceSourceGenerationPass.NativeFieldInfoPtr_kSidTexRadianceMapOutput, (void*) &radianceMapOutput);
      return radianceMapOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RadianceSourceGenerationPass.NativeFieldInfoPtr_kSidTexRadianceMapOutput, (void*) &value);
    }
  }

  public unsafe CBuffer<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceGenerationPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>) null : Il2CppObjectPool.Get<CBuffer<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceGenerationPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceGenerationPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceGenerationPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceGenerationPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadianceSourceGenerationPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Weights
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_w0;
    private static readonly System.IntPtr NativeFieldInfoPtr_w1;
    private static readonly System.IntPtr NativeFieldInfoPtr_w2;
    private static readonly System.IntPtr NativeFieldInfoPtr_w3;
    private static readonly System.IntPtr NativeFieldInfoPtr_w4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;
    [FieldOffset(0)]
    public float w0;
    [FieldOffset(4)]
    public float w1;
    [FieldOffset(8)]
    public float w2;
    [FieldOffset(12)]
    public float w3;
    [FieldOffset(16 /*0x10*/)]
    public float w4;

    static Weights()
    {
      Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (Weights));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr);
      RadianceSourceGenerationPass.Weights.NativeFieldInfoPtr_w0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, nameof (w0));
      RadianceSourceGenerationPass.Weights.NativeFieldInfoPtr_w1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, nameof (w1));
      RadianceSourceGenerationPass.Weights.NativeFieldInfoPtr_w2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, nameof (w2));
      RadianceSourceGenerationPass.Weights.NativeFieldInfoPtr_w3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, nameof (w3));
      RadianceSourceGenerationPass.Weights.NativeFieldInfoPtr_w4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, nameof (w4));
      RadianceSourceGenerationPass.Weights.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, 100663890);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 930367, RefRangeEnd = 930372, XrefRangeStart = 930367, XrefRangeEnd = 930367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Weights(float w0, float w1, float w2, float w3, float w4)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &w0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &w1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &w2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &w3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &w4;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RadianceSourceGenerationPass.Weights.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RadianceSourceGenerationPass.Weights>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct RadianceSourceGenerationCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    private static readonly System.IntPtr NativeFieldInfoPtr_weights;
    private static readonly System.IntPtr NativeFieldInfoPtr_weightCenter;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 weights;
    [FieldOffset(32 /*0x20*/)]
    public float weightCenter;
    [FieldOffset(36)]
    public Vector3 padding;

    static RadianceSourceGenerationCBufferData()
    {
      Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadianceSourceGenerationPass>.NativeClassPtr, nameof (RadianceSourceGenerationCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr);
      RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
      RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData.NativeFieldInfoPtr_weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr, nameof (weights));
      RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData.NativeFieldInfoPtr_weightCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr, nameof (weightCenter));
      RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RadianceSourceGenerationPass.RadianceSourceGenerationCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
