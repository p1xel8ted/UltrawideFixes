// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PreviewCameraRenderPipeline
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

public sealed class PreviewCameraRenderPipeline(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexSceneColorDescPrototype;
  private static readonly System.IntPtr NativeFieldInfoPtr__geometryPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__finalBlitPass;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTransientTexture_Private_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderCamera_Public_Void_byref_ScriptableRenderContext_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PreviewCameraRenderPipeline()
  {
    Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PreviewCameraRenderPipeline));
    PreviewCameraRenderPipeline.NativeFieldInfoPtr_kTexSceneColorDescPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, nameof (kTexSceneColorDescPrototype));
    PreviewCameraRenderPipeline.NativeFieldInfoPtr__geometryPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, nameof (_geometryPass));
    PreviewCameraRenderPipeline.NativeFieldInfoPtr__finalBlitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, nameof (_finalBlitPass));
    PreviewCameraRenderPipeline.NativeMethodInfoPtr_MakeTransientTexture_Private_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, 100663501 /*0x060000CD*/);
    PreviewCameraRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, 100663502 /*0x060000CE*/);
    PreviewCameraRenderPipeline.NativeMethodInfoPtr_RenderCamera_Public_Void_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, 100663503 /*0x060000CF*/);
    PreviewCameraRenderPipeline.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr, 100663504 /*0x060000D0*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925632, XrefRangeEnd = 925639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTransientTexture(
    string label,
    [In] ref RenderTextureDescriptor descPrototype,
    [In] ref Vector2Int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref descPrototype;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref size;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PreviewCameraRenderPipeline.NativeMethodInfoPtr_MakeTransientTexture_Private_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_byref_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925639, XrefRangeEnd = 925668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PreviewCameraRenderPipeline(ScsRenderPipelineResources resources)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewCameraRenderPipeline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resources)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_ScsRenderPipelineResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925668, XrefRangeEnd = 925724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RenderCamera([In] ref ScriptableRenderContext ctx, Camera camera)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraRenderPipeline.NativeMethodInfoPtr_RenderCamera_Public_Void_byref_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925724, XrefRangeEnd = 925735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraRenderPipeline.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe RenderTextureDescriptor kTexSceneColorDescPrototype
  {
    get
    {
      RenderTextureDescriptor colorDescPrototype;
      IL2CPP.il2cpp_field_static_get_value(PreviewCameraRenderPipeline.NativeFieldInfoPtr_kTexSceneColorDescPrototype, (void*) &colorDescPrototype);
      return colorDescPrototype;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PreviewCameraRenderPipeline.NativeFieldInfoPtr_kTexSceneColorDescPrototype, (void*) &value);
    }
  }

  public unsafe PreviewCameraGeometryPass _geometryPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraRenderPipeline.NativeFieldInfoPtr__geometryPass));
      return num == System.IntPtr.Zero ? (PreviewCameraGeometryPass) null : Il2CppObjectPool.Get<PreviewCameraGeometryPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraRenderPipeline.NativeFieldInfoPtr__geometryPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PreviewCameraFinalBlitPass _finalBlitPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraRenderPipeline.NativeFieldInfoPtr__finalBlitPass));
      return num == System.IntPtr.Zero ? (PreviewCameraFinalBlitPass) null : Il2CppObjectPool.Get<PreviewCameraFinalBlitPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraRenderPipeline.NativeFieldInfoPtr__finalBlitPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
