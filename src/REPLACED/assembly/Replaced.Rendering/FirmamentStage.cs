// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FirmamentStage
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

public sealed class FirmamentStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__downsampleMaxDepthPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__skyAndCloudsPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__upscaleSkyAndCloudsPass;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexture_Private_Static_RenderTextureResource_String_RenderTextureDescriptor_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static FirmamentStage()
  {
    Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FirmamentStage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr);
    FirmamentStage.NativeFieldInfoPtr__downsampleMaxDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, nameof (_downsampleMaxDepthPass));
    FirmamentStage.NativeFieldInfoPtr__skyAndCloudsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, nameof (_skyAndCloudsPass));
    FirmamentStage.NativeFieldInfoPtr__upscaleSkyAndCloudsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, nameof (_upscaleSkyAndCloudsPass));
    FirmamentStage.NativeMethodInfoPtr_MakeTexture_Private_Static_RenderTextureResource_String_RenderTextureDescriptor_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, 100663747);
    FirmamentStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, 100663748);
    FirmamentStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, 100663749);
    FirmamentStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, 100663750);
    FirmamentStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr, 100663751);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928417, XrefRangeEnd = 928422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexture(
    string label,
    RenderTextureDescriptor desc,
    Vector2Int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &desc;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FirmamentStage.NativeMethodInfoPtr_MakeTexture_Private_Static_RenderTextureResource_String_RenderTextureDescriptor_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928481, RefRangeEnd = 928482, XrefRangeStart = 928422, XrefRangeEnd = 928481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FirmamentStage(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirmamentStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FirmamentStage.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928482, XrefRangeEnd = 928491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FirmamentStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 928530, RefRangeEnd = 928533, XrefRangeStart = 928491, XrefRangeEnd = 928530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FirmamentStage.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928546, RefRangeEnd = 928547, XrefRangeStart = 928533, XrefRangeEnd = 928546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FirmamentStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DownsampleMaxDepthPass _downsampleMaxDepthPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FirmamentStage.NativeFieldInfoPtr__downsampleMaxDepthPass));
      return num == System.IntPtr.Zero ? (DownsampleMaxDepthPass) null : Il2CppObjectPool.Get<DownsampleMaxDepthPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FirmamentStage.NativeFieldInfoPtr__downsampleMaxDepthPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SkyAndCloudsPass _skyAndCloudsPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FirmamentStage.NativeFieldInfoPtr__skyAndCloudsPass));
      return num == System.IntPtr.Zero ? (SkyAndCloudsPass) null : Il2CppObjectPool.Get<SkyAndCloudsPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FirmamentStage.NativeFieldInfoPtr__skyAndCloudsPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UpscaleSkyAndCloudsPass _upscaleSkyAndCloudsPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FirmamentStage.NativeFieldInfoPtr__upscaleSkyAndCloudsPass));
      return num == System.IntPtr.Zero ? (UpscaleSkyAndCloudsPass) null : Il2CppObjectPool.Get<UpscaleSkyAndCloudsPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FirmamentStage.NativeFieldInfoPtr__upscaleSkyAndCloudsPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
