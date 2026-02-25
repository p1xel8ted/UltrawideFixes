// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SubPassDescriptor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SubPassDescriptor
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inputs;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorOutputs;
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  [FieldOffset(0)]
  public AttachmentIndexArray inputs;
  [FieldOffset(36)]
  public AttachmentIndexArray colorOutputs;
  [FieldOffset(72)]
  public SubPassFlags flags;

  static SubPassDescriptor()
  {
    Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SubPassDescriptor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr);
    SubPassDescriptor.NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, nameof (inputs));
    SubPassDescriptor.NativeFieldInfoPtr_colorOutputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, nameof (colorOutputs));
    SubPassDescriptor.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, nameof (flags));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
