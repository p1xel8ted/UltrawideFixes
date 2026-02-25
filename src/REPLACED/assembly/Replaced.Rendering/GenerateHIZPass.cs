// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GenerateHIZPass
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

public sealed class GenerateHIZPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepthInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Vector2Int_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GenerateHIZPass()
  {
    Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GenerateHIZPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr);
    GenerateHIZPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (kGroupSize));
    GenerateHIZPass.NativeFieldInfoPtr_kSidTexSceneDepthInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (kSidTexSceneDepthInput));
    GenerateHIZPass.NativeFieldInfoPtr_kSidTexOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (kSidTexOutput));
    GenerateHIZPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (_cbuffer));
    GenerateHIZPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (_compute));
    GenerateHIZPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (_kernel));
    GenerateHIZPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, 100663782);
    GenerateHIZPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, 100663783);
    GenerateHIZPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, 100663784);
    GenerateHIZPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, 100663785);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928975, XrefRangeEnd = 928987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenerateHIZPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateHIZPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929012, RefRangeEnd = 929014, XrefRangeStart = 928987, XrefRangeEnd = 929012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    RenderTextureResource texDepthInput,
    RenderTextureResource texDephtOutput,
    Vector2Int outputMipmapSize,
    float uvAdjustment = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDepthInput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDephtOutput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &outputMipmapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &uvAdjustment;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateHIZPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_RenderTextureResource_RenderTextureResource_Vector2Int_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929014, XrefRangeEnd = 929028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, Vector2Int texOutputSize, float uvAdjustment)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texOutputSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &uvAdjustment;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateHIZPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929028, XrefRangeEnd = 929032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateHIZPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(GenerateHIZPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateHIZPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepthInput
  {
    get
    {
      int texSceneDepthInput;
      IL2CPP.il2cpp_field_static_get_value(GenerateHIZPass.NativeFieldInfoPtr_kSidTexSceneDepthInput, (void*) &texSceneDepthInput);
      return texSceneDepthInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateHIZPass.NativeFieldInfoPtr_kSidTexSceneDepthInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutput
  {
    get
    {
      int kSidTexOutput;
      IL2CPP.il2cpp_field_static_get_value(GenerateHIZPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &kSidTexOutput);
      return kSidTexOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateHIZPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &value);
    }
  }

  public unsafe CBuffer<GenerateHIZPass.GenerateHizCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateHIZPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GenerateHIZPass.GenerateHizCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GenerateHIZPass.GenerateHizCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateHIZPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateHIZPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateHIZPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateHIZPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateHIZPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GenerateHizCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texOutputTc2Uv;
    [FieldOffset(0)]
    public Vector4 texOutputTc2Uv;

    static GenerateHizCBufferData()
    {
      Il2CppClassPointerStore<GenerateHIZPass.GenerateHizCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateHIZPass>.NativeClassPtr, nameof (GenerateHizCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateHIZPass.GenerateHizCBufferData>.NativeClassPtr);
      GenerateHIZPass.GenerateHizCBufferData.NativeFieldInfoPtr_texOutputTc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHIZPass.GenerateHizCBufferData>.NativeClassPtr, nameof (texOutputTc2Uv));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateHIZPass.GenerateHizCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
