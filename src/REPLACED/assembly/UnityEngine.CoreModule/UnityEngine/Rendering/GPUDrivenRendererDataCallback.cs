// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenRendererDataCallback
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

public sealed class GPUDrivenRendererDataCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0;

  static GPUDrivenRendererDataCallback()
  {
    Il2CppClassPointerStore<GPUDrivenRendererDataCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenRendererDataCallback));
    GPUDrivenRendererDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenRendererDataCallback>.NativeClassPtr, 100670302);
    GPUDrivenRendererDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenRendererDataCallback>.NativeClassPtr, 100670303);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487131, RefRangeEnd = 487133, XrefRangeStart = 487128, XrefRangeEnd = 487131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GPUDrivenRendererDataCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenRendererDataCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenRendererDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(
    [In] ref GPUDrivenRendererGroupData rendererData,
    IList<Mesh> meshes,
    IList<Material> materials)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) rendererData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) materials);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenRendererDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
