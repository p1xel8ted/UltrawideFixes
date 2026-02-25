// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.BokehTaaPass
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

public sealed class BokehTaaPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBokehColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexStabeBokehColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexHistoryBokehColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0;

  static BokehTaaPass()
  {
    Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (BokehTaaPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr);
    BokehTaaPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (kGroupSize));
    BokehTaaPass.NativeFieldInfoPtr_kSidTexBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (kSidTexBokehColor));
    BokehTaaPass.NativeFieldInfoPtr_kSidTexStabeBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (kSidTexStabeBokehColor));
    BokehTaaPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    BokehTaaPass.NativeFieldInfoPtr_kSidTexHistoryBokehColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (kSidTexHistoryBokehColor));
    BokehTaaPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (_cbuffer));
    BokehTaaPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (_compute));
    BokehTaaPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (_kernel));
    BokehTaaPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, 100664101);
    BokehTaaPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, 100664102);
    BokehTaaPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, 100664103);
    BokehTaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, 100664104);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932748, XrefRangeEnd = 932760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BokehTaaPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BokehTaaPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932791, RefRangeEnd = 932792, XrefRangeStart = 932760, XrefRangeEnd = 932791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    RenderTextureResource texBokehColor,
    RenderTextureResource texStableBokehColor,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texHistoryBokehColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texBokehColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texStableBokehColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHistoryBokehColor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BokehTaaPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_DepthOfFieldParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932792, XrefRangeEnd = 932796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BokehTaaPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932796, XrefRangeEnd = 932818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(BokehTaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(BokehTaaPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BokehTaaPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexBokehColor
  {
    get
    {
      int sidTexBokehColor;
      IL2CPP.il2cpp_field_static_get_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexBokehColor, (void*) &sidTexBokehColor);
      return sidTexBokehColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexBokehColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexStabeBokehColor
  {
    get
    {
      int texStabeBokehColor;
      IL2CPP.il2cpp_field_static_get_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexStabeBokehColor, (void*) &texStabeBokehColor);
      return texStabeBokehColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexStabeBokehColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexHistoryBokehColor
  {
    get
    {
      int historyBokehColor;
      IL2CPP.il2cpp_field_static_get_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexHistoryBokehColor, (void*) &historyBokehColor);
      return historyBokehColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BokehTaaPass.NativeFieldInfoPtr_kSidTexHistoryBokehColor, (void*) &value);
    }
  }

  public unsafe CBuffer<BokehTaaPass.BokehTaaCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BokehTaaPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<BokehTaaPass.BokehTaaCBufferData>) null : Il2CppObjectPool.Get<CBuffer<BokehTaaPass.BokehTaaCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BokehTaaPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BokehTaaPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BokehTaaPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BokehTaaPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BokehTaaPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct BokehTaaCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texelScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_movementThresholdCurves;
    private static readonly System.IntPtr NativeFieldInfoPtr_stabilization0;
    private static readonly System.IntPtr NativeFieldInfoPtr_stabilization1;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 texelScaleOffset;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 movementThresholdCurves;
    [FieldOffset(32 /*0x20*/)]
    public float stabilization0;
    [FieldOffset(36)]
    public float stabilization1;
    [FieldOffset(40)]
    public Vector2 padding;

    static BokehTaaCBufferData()
    {
      Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BokehTaaPass>.NativeClassPtr, nameof (BokehTaaCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr);
      BokehTaaPass.BokehTaaCBufferData.NativeFieldInfoPtr_texelScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr, nameof (texelScaleOffset));
      BokehTaaPass.BokehTaaCBufferData.NativeFieldInfoPtr_movementThresholdCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr, nameof (movementThresholdCurves));
      BokehTaaPass.BokehTaaCBufferData.NativeFieldInfoPtr_stabilization0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr, nameof (stabilization0));
      BokehTaaPass.BokehTaaCBufferData.NativeFieldInfoPtr_stabilization1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr, nameof (stabilization1));
      BokehTaaPass.BokehTaaCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BokehTaaPass.BokehTaaCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
