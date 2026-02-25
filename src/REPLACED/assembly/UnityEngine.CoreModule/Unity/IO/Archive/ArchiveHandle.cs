// Decompiled with JetBrains decompiler
// Type: Unity.IO.Archive.ArchiveHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;

#nullable disable
namespace Unity.IO.Archive;

[StructLayout(LayoutKind.Explicit)]
public struct ArchiveHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Handle;
  [FieldOffset(0)]
  public ulong Handle;

  static ArchiveHandle()
  {
    Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", nameof (ArchiveHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr);
    ArchiveHandle.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, nameof (Handle));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public ArchiveStatus Status
  {
    get
    {
      this.ThrowIfInvalid();
      return ArchiveFileInterface.Archive_GetStatus(this);
    }
  }

  public JobHandle JobHandle
  {
    get
    {
      this.ThrowIfInvalid();
      return ArchiveFileInterface.Archive_GetJobHandle(this);
    }
  }

  public JobHandle Unmount()
  {
    this.ThrowIfInvalid();
    return ArchiveFileInterface.Archive_UnmountAsync(this);
  }

  public void ThrowIfInvalid()
  {
    if (!ArchiveFileInterface.Archive_IsValid(this))
      throw new Il2CppSystem.InvalidOperationException("The archive has already been unmounted.");
  }

  public string GetMountPath()
  {
    this.ThrowIfInvalid();
    return ArchiveFileInterface.Archive_GetMountPath(this);
  }

  public CompressionType Compression
  {
    get
    {
      this.ThrowIfInvalid();
      return ArchiveFileInterface.Archive_GetCompression(this);
    }
  }

  public bool IsStreamed
  {
    get
    {
      this.ThrowIfInvalid();
      return ArchiveFileInterface.Archive_IsStreamed(this);
    }
  }

  public Il2CppReferenceArray<ArchiveFileInfo> GetFileInfo()
  {
    this.ThrowIfInvalid();
    return ArchiveFileInterface.Archive_GetFileInfo(this);
  }
}
