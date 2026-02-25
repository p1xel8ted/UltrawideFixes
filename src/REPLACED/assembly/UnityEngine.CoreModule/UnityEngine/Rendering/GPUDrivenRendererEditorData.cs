// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenRendererEditorData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenRendererEditorData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;
  [FieldOffset(0)]
  public ulong sceneCullingMask;

  static GPUDrivenRendererEditorData()
  {
    Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenRendererEditorData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr);
    GPUDrivenRendererEditorData.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr, nameof (sceneCullingMask));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
