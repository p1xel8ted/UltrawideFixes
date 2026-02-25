// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CopyDepthPass
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

public sealed class CopyDepthPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kCopyDepthPassIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCopyDepthInEditorPassIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDepthInput;
  private static readonly System.IntPtr NativeFieldInfoPtr__copyDepthMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeToCurrentRenderTarget_Public_Void_CommandBuffer_byref_RenderTextureResource_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static CopyDepthPass()
  {
    Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CopyDepthPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr);
    CopyDepthPass.NativeFieldInfoPtr_kCopyDepthPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, nameof (kCopyDepthPassIndex));
    CopyDepthPass.NativeFieldInfoPtr_kCopyDepthInEditorPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, nameof (kCopyDepthInEditorPassIndex));
    CopyDepthPass.NativeFieldInfoPtr_kSidTexDepthInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, nameof (kSidTexDepthInput));
    CopyDepthPass.NativeFieldInfoPtr__copyDepthMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, nameof (_copyDepthMaterial));
    CopyDepthPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100664097);
    CopyDepthPass.NativeMethodInfoPtr_EncodeToCurrentRenderTarget_Public_Void_CommandBuffer_byref_RenderTextureResource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100664098);
    CopyDepthPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr, 100664099);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932729, RefRangeEnd = 932730, XrefRangeStart = 932724, XrefRangeEnd = 932729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CopyDepthPass(Shader copyDepthShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyDepthPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyDepthShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932730, XrefRangeEnd = 932748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeToCurrentRenderTarget(
    CommandBuffer cmd,
    [In] ref RenderTextureResource texDepthInput,
    bool flipUvY)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDepthInput);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flipUvY;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_EncodeToCurrentRenderTarget_Public_Void_CommandBuffer_byref_RenderTextureResource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyDepthPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kCopyDepthPassIndex
  {
    get
    {
      int copyDepthPassIndex;
      IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.NativeFieldInfoPtr_kCopyDepthPassIndex, (void*) &copyDepthPassIndex);
      return copyDepthPassIndex;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.NativeFieldInfoPtr_kCopyDepthPassIndex, (void*) &value);
    }
  }

  public static unsafe int kCopyDepthInEditorPassIndex
  {
    get
    {
      int inEditorPassIndex;
      IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.NativeFieldInfoPtr_kCopyDepthInEditorPassIndex, (void*) &inEditorPassIndex);
      return inEditorPassIndex;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.NativeFieldInfoPtr_kCopyDepthInEditorPassIndex, (void*) &value);
    }
  }

  public static unsafe int kSidTexDepthInput
  {
    get
    {
      int sidTexDepthInput;
      IL2CPP.il2cpp_field_static_get_value(CopyDepthPass.NativeFieldInfoPtr_kSidTexDepthInput, (void*) &sidTexDepthInput);
      return sidTexDepthInput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CopyDepthPass.NativeFieldInfoPtr_kSidTexDepthInput, (void*) &value);
    }
  }

  public unsafe Material _copyDepthMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__copyDepthMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopyDepthPass.NativeFieldInfoPtr__copyDepthMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
