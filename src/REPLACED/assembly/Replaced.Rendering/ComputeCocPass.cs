// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ComputeCocPass
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

public sealed class ComputeCocPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCocFullRes;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexColorHalfRes;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCocHalfRes;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_DepthOfFieldParams_byref_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0;

  static ComputeCocPass()
  {
    Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ComputeCocPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr);
    ComputeCocPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (kGroupSize));
    ComputeCocPass.NativeFieldInfoPtr_kSidTexSceneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (kSidTexSceneColor));
    ComputeCocPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    ComputeCocPass.NativeFieldInfoPtr_kSidTexCocFullRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (kSidTexCocFullRes));
    ComputeCocPass.NativeFieldInfoPtr_kSidTexColorHalfRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (kSidTexColorHalfRes));
    ComputeCocPass.NativeFieldInfoPtr_kSidTexCocHalfRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (kSidTexCocHalfRes));
    ComputeCocPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (_cbuffer));
    ComputeCocPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (_compute));
    ComputeCocPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (_kernel));
    ComputeCocPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, 100664115);
    ComputeCocPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_DepthOfFieldParams_byref_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, 100664116);
    ComputeCocPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, 100664117);
    ComputeCocPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, 100664118);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933086, XrefRangeEnd = 933098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComputeCocPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeCocPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933130, RefRangeEnd = 933131, XrefRangeStart = 933098, XrefRangeEnd = 933130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    [In] ref RenderTextureResource texSceneColor,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texCocFullRes,
    RenderTextureResource texColorHalfRes,
    RenderTextureResource texCocHalfRes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCocFullRes));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColorHalfRes));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCocHalfRes));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeCocPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_DepthOfFieldParams_byref_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933131, XrefRangeEnd = 933135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeCocPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933135, XrefRangeEnd = 933161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    Vector2Int halfResSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &halfResSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeCocPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(ComputeCocPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComputeCocPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneColor
  {
    get
    {
      int sidTexSceneColor;
      IL2CPP.il2cpp_field_static_get_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexSceneColor, (void*) &sidTexSceneColor);
      return sidTexSceneColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexSceneColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexCocFullRes
  {
    get
    {
      int sidTexCocFullRes;
      IL2CPP.il2cpp_field_static_get_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexCocFullRes, (void*) &sidTexCocFullRes);
      return sidTexCocFullRes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexCocFullRes, (void*) &value);
    }
  }

  public static unsafe int kSidTexColorHalfRes
  {
    get
    {
      int sidTexColorHalfRes;
      IL2CPP.il2cpp_field_static_get_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexColorHalfRes, (void*) &sidTexColorHalfRes);
      return sidTexColorHalfRes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexColorHalfRes, (void*) &value);
    }
  }

  public static unsafe int kSidTexCocHalfRes
  {
    get
    {
      int sidTexCocHalfRes;
      IL2CPP.il2cpp_field_static_get_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexCocHalfRes, (void*) &sidTexCocHalfRes);
      return sidTexCocHalfRes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ComputeCocPass.NativeFieldInfoPtr_kSidTexCocHalfRes, (void*) &value);
    }
  }

  public unsafe CBuffer<ComputeCocPass.ComputeCocCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComputeCocPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<ComputeCocPass.ComputeCocCBufferData>) null : Il2CppObjectPool.Get<CBuffer<ComputeCocPass.ComputeCocCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ComputeCocPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComputeCocPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ComputeCocPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComputeCocPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ComputeCocPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ComputeCocCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texCocTexelOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_cocParams;
    [FieldOffset(0)]
    public Vector4 texCocTexelOffset;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 cocParams;

    static ComputeCocCBufferData()
    {
      Il2CppClassPointerStore<ComputeCocPass.ComputeCocCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeCocPass>.NativeClassPtr, nameof (ComputeCocCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCocPass.ComputeCocCBufferData>.NativeClassPtr);
      ComputeCocPass.ComputeCocCBufferData.NativeFieldInfoPtr_texCocTexelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass.ComputeCocCBufferData>.NativeClassPtr, nameof (texCocTexelOffset));
      ComputeCocPass.ComputeCocCBufferData.NativeFieldInfoPtr_cocParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCocPass.ComputeCocCBufferData>.NativeClassPtr, nameof (cocParams));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ComputeCocPass.ComputeCocCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
