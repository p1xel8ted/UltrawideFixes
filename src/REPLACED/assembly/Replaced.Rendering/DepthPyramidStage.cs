// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DepthPyramidStage
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

public sealed class DepthPyramidStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__generateHizPass;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexTemp_Private_Static_RenderTextureResource_String_RenderTextureDescriptor_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeMipGeneration_Private_Void_CommandBuffer_RenderTextureResource_Int32_RenderTextureResource_RenderTextureResource_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DepthPyramidStage()
  {
    Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DepthPyramidStage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr);
    DepthPyramidStage.NativeFieldInfoPtr__generateHizPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, nameof (_generateHizPass));
    DepthPyramidStage.NativeMethodInfoPtr_MakeTexTemp_Private_Static_RenderTextureResource_String_RenderTextureDescriptor_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, 100663776 /*0x060001E0*/);
    DepthPyramidStage.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, 100663777);
    DepthPyramidStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, 100663778);
    DepthPyramidStage.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, 100663779);
    DepthPyramidStage.NativeMethodInfoPtr_EncodeMipGeneration_Private_Void_CommandBuffer_RenderTextureResource_Int32_RenderTextureResource_RenderTextureResource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, 100663780);
    DepthPyramidStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr, 100663781);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928882, XrefRangeEnd = 928888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexTemp(
    string label,
    RenderTextureDescriptor desc,
    Vector2Int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &desc;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DepthPyramidStage.NativeMethodInfoPtr_MakeTexTemp_Private_Static_RenderTextureResource_String_RenderTextureDescriptor_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928904, RefRangeEnd = 928905, XrefRangeStart = 928888, XrefRangeEnd = 928904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DepthPyramidStage(ComputeShader generateHIZCompute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthPyramidStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) generateHIZCompute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPyramidStage.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928905, XrefRangeEnd = 928914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode([In] ref ScriptableRenderContext ctx, SceneFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPyramidStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 928955, RefRangeEnd = 928958, XrefRangeStart = 928914, XrefRangeEnd = 928955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(CommandBuffer cmd, SceneFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPyramidStage.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_SceneFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 928965, RefRangeEnd = 928970, XrefRangeStart = 928958, XrefRangeEnd = 928965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeMipGeneration(
    CommandBuffer cmd,
    RenderTextureResource texMinHIZ,
    int mipmap,
    RenderTextureResource texInput,
    RenderTextureResource texOutput,
    float uvAdjustment)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMinHIZ));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipmap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &uvAdjustment;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPyramidStage.NativeMethodInfoPtr_EncodeMipGeneration_Private_Void_CommandBuffer_RenderTextureResource_Int32_RenderTextureResource_RenderTextureResource_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928974, RefRangeEnd = 928975, XrefRangeStart = 928970, XrefRangeEnd = 928974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthPyramidStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GenerateHIZPass _generateHizPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DepthPyramidStage.NativeFieldInfoPtr__generateHizPass));
      return num == System.IntPtr.Zero ? (GenerateHIZPass) null : Il2CppObjectPool.Get<GenerateHIZPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DepthPyramidStage.NativeFieldInfoPtr__generateHizPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
