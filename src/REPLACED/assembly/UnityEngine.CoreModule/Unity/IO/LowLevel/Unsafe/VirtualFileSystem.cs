// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.VirtualFileSystem
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

public static class VirtualFileSystem
{
  private static readonly VirtualFileSystem.GetLocalFileSystemName_InjectedDelegate GetLocalFileSystemName_InjectedDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.GetLocalFileSystemName_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName_Injected");
  private static readonly VirtualFileSystem.ToLogicalPath_InjectedDelegate ToLogicalPath_InjectedDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.ToLogicalPath_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::ToLogicalPath_Injected");

  public static unsafe bool GetLocalFileSystemName(
    string vfsFileName,
    out string localFileName,
    out ulong localFileOffset,
    out ulong localFileSize)
  {
    ManagedSpanWrapper localFileName1;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(vfsFileName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = vfsFileName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return VirtualFileSystem.GetLocalFileSystemName_Injected(ref managedSpanWrapper, out localFileName1, out localFileOffset, out localFileSize);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      localFileName = OutStringMarshaller.GetStringAndDispose(localFileName1);
    }
  }

  public static unsafe string ToLogicalPath(string physicalPath)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(physicalPath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = physicalPath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      VirtualFileSystem.ToLogicalPath_Injected(ref managedSpanWrapper, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static bool GetLocalFileSystemName_Injected(
    ref ManagedSpanWrapper vfsFileName,
    out ManagedSpanWrapper localFileName,
    out ulong localFileOffset,
    out ulong localFileSize)
  {
    return VirtualFileSystem.GetLocalFileSystemName_InjectedDelegateField((System.IntPtr) ref vfsFileName, (System.IntPtr) ref localFileName, (System.IntPtr) ref localFileOffset, (System.IntPtr) ref localFileSize);
  }

  public static void ToLogicalPath_Injected(
    ref ManagedSpanWrapper physicalPath,
    out ManagedSpanWrapper ret)
  {
    VirtualFileSystem.ToLogicalPath_InjectedDelegateField((System.IntPtr) ref physicalPath, (System.IntPtr) ref ret);
  }

  private delegate bool GetLocalFileSystemName_InjectedDelegate(
    System.IntPtr vfsFileName,
    [Out] System.IntPtr localFileName,
    [Out] System.IntPtr localFileOffset,
    [Out] System.IntPtr localFileSize);

  private delegate void ToLogicalPath_InjectedDelegate(System.IntPtr physicalPath, [Out] System.IntPtr ret);
}
