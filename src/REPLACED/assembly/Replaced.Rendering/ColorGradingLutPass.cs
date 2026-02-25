// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ColorGradingLutPass
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

public sealed class ColorGradingLutPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kAcesCCMidgray;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCgLut;
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__lutCompute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Int32_0;

  static ColorGradingLutPass()
  {
    Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ColorGradingLutPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr);
    ColorGradingLutPass.NativeFieldInfoPtr_kAcesCCMidgray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, nameof (kAcesCCMidgray));
    ColorGradingLutPass.NativeFieldInfoPtr_kSidTexCgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, nameof (kSidTexCgLut));
    ColorGradingLutPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, nameof (kGroupSize));
    ColorGradingLutPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, nameof (_cbuffer));
    ColorGradingLutPass.NativeFieldInfoPtr__lutCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, nameof (_lutCompute));
    ColorGradingLutPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, nameof (_kernel));
    ColorGradingLutPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100664092);
    ColorGradingLutPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100664093);
    ColorGradingLutPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100664094);
    ColorGradingLutPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100664095);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932672, RefRangeEnd = 932673, XrefRangeStart = 932660, XrefRangeEnd = 932672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorGradingLutPass(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932701, RefRangeEnd = 932702, XrefRangeStart = 932673, XrefRangeEnd = 932701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    RenderTextureResource texCgLut)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCgLut));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_FrameRenderingParams_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932706, RefRangeEnd = 932707, XrefRangeStart = 932702, XrefRangeEnd = 932706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932723, RefRangeEnd = 932724, XrefRangeStart = 932707, XrefRangeEnd = 932723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, [In] ref FrameRenderingParams frp, int lutSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lutSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorGradingLutPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_FrameRenderingParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kAcesCCMidgray
  {
    get
    {
      float kAcesCcMidgray;
      IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.NativeFieldInfoPtr_kAcesCCMidgray, (void*) &kAcesCcMidgray);
      return kAcesCcMidgray;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.NativeFieldInfoPtr_kAcesCCMidgray, (void*) &value);
    }
  }

  public static unsafe int kSidTexCgLut
  {
    get
    {
      int kSidTexCgLut;
      IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.NativeFieldInfoPtr_kSidTexCgLut, (void*) &kSidTexCgLut);
      return kSidTexCgLut;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.NativeFieldInfoPtr_kSidTexCgLut, (void*) &value);
    }
  }

  public static unsafe Vector3Int kGroupSize
  {
    get
    {
      Vector3Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(ColorGradingLutPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ColorGradingLutPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public unsafe CBuffer<ColorGradingLutCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ColorGradingLutCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ColorGradingLutCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _lutCompute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr__lutCompute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr__lutCompute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorGradingLutPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }
}
