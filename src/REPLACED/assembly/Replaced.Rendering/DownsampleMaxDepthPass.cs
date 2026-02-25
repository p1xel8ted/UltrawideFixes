// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DownsampleMaxDepthPass
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

public sealed class DownsampleMaxDepthPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__material;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_0;

  static DownsampleMaxDepthPass()
  {
    Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DownsampleMaxDepthPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr);
    DownsampleMaxDepthPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    DownsampleMaxDepthPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, nameof (_cbuffer));
    DownsampleMaxDepthPass.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, nameof (_material));
    DownsampleMaxDepthPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, 100663742);
    DownsampleMaxDepthPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, 100663743);
    DownsampleMaxDepthPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, 100663744 /*0x060001C0*/);
    DownsampleMaxDepthPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, 100663745);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928359, XrefRangeEnd = 928372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DownsampleMaxDepthPass(Shader downsampleMaxDepth4x4Shader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) downsampleMaxDepth4x4Shader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleMaxDepthPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928403, RefRangeEnd = 928404, XrefRangeStart = 928372, XrefRangeEnd = 928403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    RenderTextureResource texSceneDepthInput,
    RenderTextureResource texSceneDepthOutput)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepthInput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepthOutput));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleMaxDepthPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928404, XrefRangeEnd = 928408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleMaxDepthPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928408, XrefRangeEnd = 928417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, Vector2Int renderTargetSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderTargetSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DownsampleMaxDepthPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(DownsampleMaxDepthPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DownsampleMaxDepthPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public unsafe CBuffer<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleMaxDepthPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>) null : Il2CppObjectPool.Get<CBuffer<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleMaxDepthPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DownsampleMaxDepthPass.NativeFieldInfoPtr__material));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DownsampleMaxDepthPass.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DownsampleMaxDepth4x4CBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_uvMainDiagonalOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvMinorDiagonalOffset;
    [FieldOffset(0)]
    public Vector2 uvMainDiagonalOffset;
    [FieldOffset(8)]
    public Vector2 uvMinorDiagonalOffset;

    static DownsampleMaxDepth4x4CBufferData()
    {
      Il2CppClassPointerStore<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DownsampleMaxDepthPass>.NativeClassPtr, nameof (DownsampleMaxDepth4x4CBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>.NativeClassPtr);
      DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData.NativeFieldInfoPtr_uvMainDiagonalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>.NativeClassPtr, nameof (uvMainDiagonalOffset));
      DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData.NativeFieldInfoPtr_uvMinorDiagonalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>.NativeClassPtr, nameof (uvMinorDiagonalOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownsampleMaxDepthPass.DownsampleMaxDepth4x4CBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
