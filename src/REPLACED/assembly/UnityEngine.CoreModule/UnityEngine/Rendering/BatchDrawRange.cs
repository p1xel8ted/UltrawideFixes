// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchDrawRange
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawRange
{
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandsType;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandsBegin;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_filterSettings;
  [FieldOffset(0)]
  public BatchDrawCommandType drawCommandsType;
  [FieldOffset(4)]
  public uint drawCommandsBegin;
  [FieldOffset(8)]
  public uint drawCommandsCount;
  [FieldOffset(16 /*0x10*/)]
  public BatchFilterSettings filterSettings;

  static BatchDrawRange()
  {
    Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchDrawRange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr);
    BatchDrawRange.NativeFieldInfoPtr_drawCommandsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, nameof (drawCommandsType));
    BatchDrawRange.NativeFieldInfoPtr_drawCommandsBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, nameof (drawCommandsBegin));
    BatchDrawRange.NativeFieldInfoPtr_drawCommandsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, nameof (drawCommandsCount));
    BatchDrawRange.NativeFieldInfoPtr_filterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, nameof (filterSettings));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
