// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback
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

public sealed class GPUDrivenRendererDataNativeCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0;

  static GPUDrivenRendererDataNativeCallback()
  {
    Il2CppClassPointerStore<GPUDrivenRendererDataNativeCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenRendererDataNativeCallback));
    GPUDrivenRendererDataNativeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenRendererDataNativeCallback>.NativeClassPtr, 100670304);
    GPUDrivenRendererDataNativeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenRendererDataNativeCallback>.NativeClassPtr, 100670305);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487133, XrefRangeEnd = 487136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GPUDrivenRendererDataNativeCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenRendererDataNativeCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenRendererDataNativeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(
    [In] ref GPUDrivenRendererGroupDataNative rendererDataNative,
    List<Mesh> meshes,
    List<Material> materials,
    GPUDrivenRendererDataCallback callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref rendererDataNative;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) materials);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenRendererDataNativeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
