// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GenerateDofInputPass
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

public sealed class GenerateDofInputPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneColorInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCoc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDofColorInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDofCocInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidBokehPointBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GenerateDofInputPass()
  {
    Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GenerateDofInputPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr);
    GenerateDofInputPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (kGroupSize));
    GenerateDofInputPass.NativeFieldInfoPtr_kSidTexSceneColorInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (kSidTexSceneColorInput));
    GenerateDofInputPass.NativeFieldInfoPtr_kSidTexCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (kSidTexCoc));
    GenerateDofInputPass.NativeFieldInfoPtr_kSidTexDofColorInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (kSidTexDofColorInput));
    GenerateDofInputPass.NativeFieldInfoPtr_kSidTexDofCocInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (kSidTexDofCocInput));
    GenerateDofInputPass.NativeFieldInfoPtr_kSidBokehPointBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (kSidBokehPointBuffer));
    GenerateDofInputPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (_cbuffer));
    GenerateDofInputPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (_compute));
    GenerateDofInputPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (_kernel));
    GenerateDofInputPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, 100664145);
    GenerateDofInputPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, 100664146);
    GenerateDofInputPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, 100664147);
    GenerateDofInputPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, 100664148);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933669, XrefRangeEnd = 933681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenerateDofInputPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDofInputPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933681, XrefRangeEnd = 933716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref RenderTextureResource texSceneColor,
    [In] ref RenderTextureResource texStableCoc,
    [In] ref RenderTextureResource texDofColorInput,
    [In] ref RenderTextureResource texDofCocInput,
    ComputeBuffer bokehPointBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texStableCoc);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDofColorInput);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDofCocInput);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bokehPointBuffer);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDofInputPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933716, XrefRangeEnd = 933742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    Vector2Int texSceneColorSize,
    Vector2Int texDofColorInputSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &texSceneColorSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &texDofColorInputSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDofInputPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933742, XrefRangeEnd = 933746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateDofInputPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(GenerateDofInputPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDofInputPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneColorInput
  {
    get
    {
      int texSceneColorInput;
      IL2CPP.il2cpp_field_static_get_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexSceneColorInput, (void*) &texSceneColorInput);
      return texSceneColorInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexSceneColorInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexCoc
  {
    get
    {
      int kSidTexCoc;
      IL2CPP.il2cpp_field_static_get_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &kSidTexCoc);
      return kSidTexCoc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &value);
    }
  }

  public static unsafe int kSidTexDofColorInput
  {
    get
    {
      int texDofColorInput;
      IL2CPP.il2cpp_field_static_get_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexDofColorInput, (void*) &texDofColorInput);
      return texDofColorInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexDofColorInput, (void*) &value);
    }
  }

  public static unsafe int kSidTexDofCocInput
  {
    get
    {
      int sidTexDofCocInput;
      IL2CPP.il2cpp_field_static_get_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexDofCocInput, (void*) &sidTexDofCocInput);
      return sidTexDofCocInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidTexDofCocInput, (void*) &value);
    }
  }

  public static unsafe int kSidBokehPointBuffer
  {
    get
    {
      int bokehPointBuffer;
      IL2CPP.il2cpp_field_static_get_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidBokehPointBuffer, (void*) &bokehPointBuffer);
      return bokehPointBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateDofInputPass.NativeFieldInfoPtr_kSidBokehPointBuffer, (void*) &value);
    }
  }

  public unsafe CBuffer<GenerateDofInputPass.GenerateDofInputCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDofInputPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GenerateDofInputPass.GenerateDofInputCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GenerateDofInputPass.GenerateDofInputCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDofInputPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDofInputPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateDofInputPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDofInputPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateDofInputPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GenerateDofInputCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texSceneColorInputTexelScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_texDofColorInputTexelScaleOffset;
    [FieldOffset(0)]
    public Vector4 texSceneColorInputTexelScaleOffset;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 texDofColorInputTexelScaleOffset;

    static GenerateDofInputCBufferData()
    {
      Il2CppClassPointerStore<GenerateDofInputPass.GenerateDofInputCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateDofInputPass>.NativeClassPtr, nameof (GenerateDofInputCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateDofInputPass.GenerateDofInputCBufferData>.NativeClassPtr);
      GenerateDofInputPass.GenerateDofInputCBufferData.NativeFieldInfoPtr_texSceneColorInputTexelScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass.GenerateDofInputCBufferData>.NativeClassPtr, nameof (texSceneColorInputTexelScaleOffset));
      GenerateDofInputPass.GenerateDofInputCBufferData.NativeFieldInfoPtr_texDofColorInputTexelScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateDofInputPass.GenerateDofInputCBufferData>.NativeClassPtr, nameof (texDofColorInputTexelScaleOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateDofInputPass.GenerateDofInputCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
