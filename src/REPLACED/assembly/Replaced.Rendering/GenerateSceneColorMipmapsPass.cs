// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GenerateSceneColorMipmapsPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class GenerateSceneColorMipmapsPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_RenderTextureResource_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GenerateSceneColorMipmapsPass()
  {
    Il2CppClassPointerStore<GenerateSceneColorMipmapsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GenerateSceneColorMipmapsPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateSceneColorMipmapsPass>.NativeClassPtr);
    GenerateSceneColorMipmapsPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateSceneColorMipmapsPass>.NativeClassPtr, 100663787);
    GenerateSceneColorMipmapsPass.NativeMethodInfoPtr_Encode_Public_RenderTextureResource_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateSceneColorMipmapsPass>.NativeClassPtr, 100663788);
    GenerateSceneColorMipmapsPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateSceneColorMipmapsPass>.NativeClassPtr, 100663789);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenerateSceneColorMipmapsPass()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateSceneColorMipmapsPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateSceneColorMipmapsPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929044, RefRangeEnd = 929045, XrefRangeStart = 929032, XrefRangeEnd = 929044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    RenderTextureResource texSceneColorInput,
    RenderTextureResource texSceneColorOutput)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColorInput));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColorOutput));
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GenerateSceneColorMipmapsPass.NativeMethodInfoPtr_Encode_Public_RenderTextureResource_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateSceneColorMipmapsPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
