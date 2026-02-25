// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenLODGroupDataCallback
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class GPUDrivenLODGroupDataCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenLODGroupData_0;

  static GPUDrivenLODGroupDataCallback()
  {
    Il2CppClassPointerStore<GPUDrivenLODGroupDataCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenLODGroupDataCallback));
    GPUDrivenLODGroupDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenLODGroupDataCallback>.NativeClassPtr, 100670298);
    GPUDrivenLODGroupDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenLODGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenLODGroupDataCallback>.NativeClassPtr, 100670299);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 416874, RefRangeEnd = 416875, XrefRangeStart = 416874, XrefRangeEnd = 416875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GPUDrivenLODGroupDataCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenLODGroupDataCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenLODGroupDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke([In] ref GPUDrivenLODGroupData lodGroupData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) lodGroupData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenLODGroupDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_GPUDrivenLODGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
