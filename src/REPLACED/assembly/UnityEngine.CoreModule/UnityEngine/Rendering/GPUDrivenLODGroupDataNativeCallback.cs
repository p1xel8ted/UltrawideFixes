// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class GPUDrivenLODGroupDataNativeCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0;

  static GPUDrivenLODGroupDataNativeCallback()
  {
    Il2CppClassPointerStore<GPUDrivenLODGroupDataNativeCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenLODGroupDataNativeCallback));
    GPUDrivenLODGroupDataNativeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenLODGroupDataNativeCallback>.NativeClassPtr, 100670300);
    GPUDrivenLODGroupDataNativeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenLODGroupDataNativeCallback>.NativeClassPtr, 100670301);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 162040, RefRangeEnd = 162055, XrefRangeStart = 162040, XrefRangeEnd = 162055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GPUDrivenLODGroupDataNativeCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenLODGroupDataNativeCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenLODGroupDataNativeCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(
    [In] ref GPUDrivenLODGroupDataNative lodGroupDataNative,
    GPUDrivenLODGroupDataCallback callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref lodGroupDataNative;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenLODGroupDataNativeCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
