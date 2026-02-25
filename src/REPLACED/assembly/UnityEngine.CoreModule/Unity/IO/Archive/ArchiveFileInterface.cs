// Decompiled with JetBrains decompiler
// Type: Unity.IO.Archive.ArchiveFileInterface
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.IO.Archive;

public static class ArchiveFileInterface : Il2CppSystem.Object
{
  private static readonly ArchiveFileInterface.Archive_GetStatus_InjectedDelegate Archive_GetStatus_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegate Archive_GetJobHandle_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_IsValid_InjectedDelegate Archive_IsValid_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegate Archive_UnmountAsync_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_GetMountPath_InjectedDelegate Archive_GetMountPath_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_GetCompression_InjectedDelegate Archive_GetCompression_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_IsStreamed_InjectedDelegate Archive_IsStreamed_InjectedDelegateField;
  private static readonly ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegate Archive_GetFileInfo_InjectedDelegateField;

  static ArchiveFileInterface()
  {
    Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", nameof (ArchiveFileInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr);
    ArchiveFileInterface.Archive_GetStatus_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetStatus_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetStatus_Injected");
    ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetJobHandle_Injected");
    ArchiveFileInterface.Archive_IsValid_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_IsValid_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsValid_Injected");
    ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_UnmountAsync_Injected");
    ArchiveFileInterface.Archive_GetMountPath_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetMountPath_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetMountPath_Injected");
    ArchiveFileInterface.Archive_GetCompression_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetCompression_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetCompression_Injected");
    ArchiveFileInterface.Archive_IsStreamed_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_IsStreamed_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsStreamed_Injected");
    ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetFileInfo_Injected");
  }

  public ArchiveFileInterface(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static ArchiveStatus Archive_GetStatus(ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_GetStatus_Injected(ref handle);
  }

  public static JobHandle Archive_GetJobHandle(ArchiveHandle handle)
  {
    JobHandle ret;
    ArchiveFileInterface.Archive_GetJobHandle_Injected(ref handle, out ret);
    return ret;
  }

  public static bool Archive_IsValid(ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_IsValid_Injected(ref handle);
  }

  public static JobHandle Archive_UnmountAsync(ArchiveHandle handle)
  {
    JobHandle ret;
    ArchiveFileInterface.Archive_UnmountAsync_Injected(ref handle, out ret);
    return ret;
  }

  public static string Archive_GetMountPath(ArchiveHandle handle)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      ArchiveFileInterface.Archive_GetMountPath_Injected(ref handle, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static CompressionType Archive_GetCompression(ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_GetCompression_Injected(ref handle);
  }

  public static bool Archive_IsStreamed(ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_IsStreamed_Injected(ref handle);
  }

  public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo(ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_GetFileInfo_Injected(ref handle);
  }

  public static ArchiveStatus Archive_GetStatus_Injected([In] ref ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_GetStatus_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static void Archive_GetJobHandle_Injected([In] ref ArchiveHandle handle, out JobHandle ret)
  {
    ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegateField((System.IntPtr) ref handle, (System.IntPtr) ref ret);
  }

  public static bool Archive_IsValid_Injected([In] ref ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_IsValid_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static void Archive_UnmountAsync_Injected([In] ref ArchiveHandle handle, out JobHandle ret)
  {
    ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegateField((System.IntPtr) ref handle, (System.IntPtr) ref ret);
  }

  public static void Archive_GetMountPath_Injected(
    [In] ref ArchiveHandle handle,
    out ManagedSpanWrapper ret)
  {
    ArchiveFileInterface.Archive_GetMountPath_InjectedDelegateField((System.IntPtr) ref handle, (System.IntPtr) ref ret);
  }

  public static CompressionType Archive_GetCompression_Injected([In] ref ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_GetCompression_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static bool Archive_IsStreamed_Injected([In] ref ArchiveHandle handle)
  {
    return ArchiveFileInterface.Archive_IsStreamed_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo_Injected(
    [In] ref ArchiveHandle handle)
  {
    System.IntPtr num = ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegateField((System.IntPtr) ref handle);
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArchiveFileInfo>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArchiveFileInfo>>(num);
  }

  private delegate ArchiveStatus Archive_GetStatus_InjectedDelegate([In] System.IntPtr handle);

  private delegate void Archive_GetJobHandle_InjectedDelegate([In] System.IntPtr handle, [Out] System.IntPtr ret);

  private delegate bool Archive_IsValid_InjectedDelegate([In] System.IntPtr handle);

  private delegate void Archive_UnmountAsync_InjectedDelegate([In] System.IntPtr handle, [Out] System.IntPtr ret);

  private delegate void Archive_GetMountPath_InjectedDelegate([In] System.IntPtr handle, [Out] System.IntPtr ret);

  private delegate CompressionType Archive_GetCompression_InjectedDelegate([In] System.IntPtr handle);

  private delegate bool Archive_IsStreamed_InjectedDelegate([In] System.IntPtr handle);

  private delegate System.IntPtr Archive_GetFileInfo_InjectedDelegate([In] System.IntPtr handle);
}
