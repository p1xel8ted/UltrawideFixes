// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.FileInfoResult
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct FileInfoResult
{
  private static readonly System.IntPtr NativeFieldInfoPtr_FileSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_FileState;
  [FieldOffset(0)]
  public long FileSize;
  [FieldOffset(8)]
  public FileState FileState;

  static FileInfoResult()
  {
    Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (FileInfoResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr);
    FileInfoResult.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr, nameof (FileSize));
    FileInfoResult.NativeFieldInfoPtr_FileState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr, nameof (FileState));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileInfoResult>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
