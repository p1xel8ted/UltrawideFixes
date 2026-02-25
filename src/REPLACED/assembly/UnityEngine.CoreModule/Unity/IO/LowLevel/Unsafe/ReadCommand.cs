// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.ReadCommand
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ReadCommand
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Buffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
  private static readonly System.IntPtr NativeFieldInfoPtr_Size;
  [FieldOffset(0)]
  public System.IntPtr Buffer;
  [FieldOffset(8)]
  public long Offset;
  [FieldOffset(16 /*0x10*/)]
  public long Size;

  static ReadCommand()
  {
    Il2CppClassPointerStore<ReadCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (ReadCommand));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr);
    ReadCommand.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, nameof (Buffer));
    ReadCommand.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, nameof (Offset));
    ReadCommand.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, nameof (Size));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
