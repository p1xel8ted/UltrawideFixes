// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenCallbacks
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public static class GPUDrivenCallbacks : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeGPUDrivenLODGroupDataNativeCallback_Public_Static_Void_GPUDrivenLODGroupDataNativeCallback_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeGPUDrivenRendererDataNativeCallback_Public_Static_Void_GPUDrivenRendererDataNativeCallback_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0;

  static GPUDrivenCallbacks()
  {
    Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenCallbacks));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr);
    GPUDrivenCallbacks.NativeMethodInfoPtr_InvokeGPUDrivenLODGroupDataNativeCallback_Public_Static_Void_GPUDrivenLODGroupDataNativeCallback_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr, 100670306);
    GPUDrivenCallbacks.NativeMethodInfoPtr_InvokeGPUDrivenRendererDataNativeCallback_Public_Static_Void_GPUDrivenRendererDataNativeCallback_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenCallbacks>.NativeClassPtr, 100670307);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487136, XrefRangeEnd = 487137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeGPUDrivenLODGroupDataNativeCallback(
    GPUDrivenLODGroupDataNativeCallback callback,
    [In] ref GPUDrivenLODGroupDataNative lodGroupDataNative,
    GPUDrivenLODGroupDataCallback target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lodGroupDataNative;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenCallbacks.NativeMethodInfoPtr_InvokeGPUDrivenLODGroupDataNativeCallback_Public_Static_Void_GPUDrivenLODGroupDataNativeCallback_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487137, XrefRangeEnd = 487162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeGPUDrivenRendererDataNativeCallback(
    GPUDrivenRendererDataNativeCallback callback,
    [In] ref GPUDrivenRendererGroupDataNative rendererDataNative,
    List<Mesh> meshes,
    List<Material> materials,
    GPUDrivenRendererDataCallback target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rendererDataNative;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) materials);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenCallbacks.NativeMethodInfoPtr_InvokeGPUDrivenRendererDataNativeCallback_Public_Static_Void_GPUDrivenRendererDataNativeCallback_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public GPUDrivenCallbacks(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
