// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CocTaaPass
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

public sealed class CocTaaPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCoc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexHistoryColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexHistoryCoc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexStableColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexStableCoc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidBokehPointBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelCocTaaGenerateBokehPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelCocTaa;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernelCocGenerateBokehPoints;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_DepthOfFieldParams_Boolean_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0;

  static CocTaaPass()
  {
    Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CocTaaPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr);
    CocTaaPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kGroupSize));
    CocTaaPass.NativeFieldInfoPtr_kSidTexColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexColor));
    CocTaaPass.NativeFieldInfoPtr_kSidTexCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexCoc));
    CocTaaPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    CocTaaPass.NativeFieldInfoPtr_kSidTexHistoryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexHistoryColor));
    CocTaaPass.NativeFieldInfoPtr_kSidTexHistoryCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexHistoryCoc));
    CocTaaPass.NativeFieldInfoPtr_kSidTexStableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexStableColor));
    CocTaaPass.NativeFieldInfoPtr_kSidTexStableCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidTexStableCoc));
    CocTaaPass.NativeFieldInfoPtr_kSidBokehPointBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (kSidBokehPointBuffer));
    CocTaaPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (_cbuffer));
    CocTaaPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (_compute));
    CocTaaPass.NativeFieldInfoPtr__kernelCocTaaGenerateBokehPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (_kernelCocTaaGenerateBokehPoints));
    CocTaaPass.NativeFieldInfoPtr__kernelCocTaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (_kernelCocTaa));
    CocTaaPass.NativeFieldInfoPtr__kernelCocGenerateBokehPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (_kernelCocGenerateBokehPoints));
    CocTaaPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, 100664106);
    CocTaaPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_DepthOfFieldParams_Boolean_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, 100664107);
    CocTaaPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, 100664108);
    CocTaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, 100664109);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932818, XrefRangeEnd = 932836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CocTaaPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CocTaaPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932951, RefRangeEnd = 932952, XrefRangeStart = 932836, XrefRangeEnd = 932951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    bool colorTaaEnabled,
    RenderTextureResource texColor,
    RenderTextureResource texCoc,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texHistoryColor,
    RenderTextureResource texHistoryCoc,
    RenderTextureResource texStableColor,
    RenderTextureResource texStableCoc,
    ComputeBuffer bokehPointBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[11];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorTaaEnabled;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCoc));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHistoryColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHistoryCoc));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texStableColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texStableCoc));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bokehPointBuffer);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CocTaaPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_DepthOfFieldParams_Boolean_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932952, XrefRangeEnd = 932956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CocTaaPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932956, XrefRangeEnd = 932998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    Vector2Int textureSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CocTaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexColor
  {
    get
    {
      int kSidTexColor;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexColor, (void*) &kSidTexColor);
      return kSidTexColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexCoc
  {
    get
    {
      int kSidTexCoc;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &kSidTexCoc);
      return kSidTexCoc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexHistoryColor
  {
    get
    {
      int sidTexHistoryColor;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexHistoryColor, (void*) &sidTexHistoryColor);
      return sidTexHistoryColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexHistoryColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexHistoryCoc
  {
    get
    {
      int sidTexHistoryCoc;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexHistoryCoc, (void*) &sidTexHistoryCoc);
      return sidTexHistoryCoc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexHistoryCoc, (void*) &value);
    }
  }

  public static unsafe int kSidTexStableColor
  {
    get
    {
      int sidTexStableColor;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexStableColor, (void*) &sidTexStableColor);
      return sidTexStableColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexStableColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexStableCoc
  {
    get
    {
      int kSidTexStableCoc;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidTexStableCoc, (void*) &kSidTexStableCoc);
      return kSidTexStableCoc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidTexStableCoc, (void*) &value);
    }
  }

  public static unsafe int kSidBokehPointBuffer
  {
    get
    {
      int bokehPointBuffer;
      IL2CPP.il2cpp_field_static_get_value(CocTaaPass.NativeFieldInfoPtr_kSidBokehPointBuffer, (void*) &bokehPointBuffer);
      return bokehPointBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CocTaaPass.NativeFieldInfoPtr_kSidBokehPointBuffer, (void*) &value);
    }
  }

  public unsafe CBuffer<CocTaaPass.CocStabilizationCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<CocTaaPass.CocStabilizationCBufferData>) null : Il2CppObjectPool.Get<CBuffer<CocTaaPass.CocStabilizationCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernelCocTaaGenerateBokehPoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__kernelCocTaaGenerateBokehPoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__kernelCocTaaGenerateBokehPoints)) = value;
    }
  }

  public unsafe int _kernelCocTaa
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__kernelCocTaa));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__kernelCocTaa)) = value;
    }
  }

  public unsafe int _kernelCocGenerateBokehPoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__kernelCocGenerateBokehPoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CocTaaPass.NativeFieldInfoPtr__kernelCocGenerateBokehPoints)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct CocStabilizationCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texColorTexelScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_lumaThresholdCurve;
    [FieldOffset(0)]
    public Vector4 texColorTexelScaleOffset;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 lumaThresholdCurve;

    static CocStabilizationCBufferData()
    {
      Il2CppClassPointerStore<CocTaaPass.CocStabilizationCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CocTaaPass>.NativeClassPtr, nameof (CocStabilizationCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocTaaPass.CocStabilizationCBufferData>.NativeClassPtr);
      CocTaaPass.CocStabilizationCBufferData.NativeFieldInfoPtr_texColorTexelScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass.CocStabilizationCBufferData>.NativeClassPtr, nameof (texColorTexelScaleOffset));
      CocTaaPass.CocStabilizationCBufferData.NativeFieldInfoPtr_lumaThresholdCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocTaaPass.CocStabilizationCBufferData>.NativeClassPtr, nameof (lumaThresholdCurve));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CocTaaPass.CocStabilizationCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
