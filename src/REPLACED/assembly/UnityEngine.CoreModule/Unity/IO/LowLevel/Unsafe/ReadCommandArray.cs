// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.ReadCommandArray
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ReadCommandArray
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ReadCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_CommandCount;
  [FieldOffset(0)]
  public System.IntPtr ReadCommands;
  [FieldOffset(8)]
  public int CommandCount;

  static ReadCommandArray()
  {
    Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (ReadCommandArray));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr);
    ReadCommandArray.NativeFieldInfoPtr_ReadCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr, nameof (ReadCommands));
    ReadCommandArray.NativeFieldInfoPtr_CommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr, nameof (CommandCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
