// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PreviewCameraFinalBlitPass
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

public sealed class PreviewCameraFinalBlitPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__blitMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PreviewCameraFinalBlitPass()
  {
    Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PreviewCameraFinalBlitPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr);
    PreviewCameraFinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr, nameof (kSidTexInputColor));
    PreviewCameraFinalBlitPass.NativeFieldInfoPtr__blitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr, nameof (_blitMaterial));
    PreviewCameraFinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr, 100663488 /*0x060000C0*/);
    PreviewCameraFinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr, 100663489 /*0x060000C1*/);
    PreviewCameraFinalBlitPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr, 100663490 /*0x060000C2*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925428, XrefRangeEnd = 925433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PreviewCameraFinalBlitPass(Shader blitShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewCameraFinalBlitPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blitShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraFinalBlitPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925461, RefRangeEnd = 925462, XrefRangeStart = 925433, XrefRangeEnd = 925461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    RenderTextureResource texInputColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputColor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraFinalBlitPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925462, XrefRangeEnd = 925471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraFinalBlitPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexInputColor
  {
    get
    {
      int sidTexInputColor;
      IL2CPP.il2cpp_field_static_get_value(PreviewCameraFinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &sidTexInputColor);
      return sidTexInputColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PreviewCameraFinalBlitPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &value);
    }
  }

  public unsafe Material _blitMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFinalBlitPass.NativeFieldInfoPtr__blitMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFinalBlitPass.NativeFieldInfoPtr__blitMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
