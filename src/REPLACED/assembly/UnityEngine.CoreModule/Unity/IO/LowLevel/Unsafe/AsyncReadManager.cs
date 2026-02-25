// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.AsyncReadManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

public static class AsyncReadManager : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInfoInternal_Private_Static_ReadHandle_String_ptr_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInfo_Public_Static_ReadHandle_String_ptr_FileInfoResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Private_Static_ReadHandle_byref_FileHandle_ptr_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_ReadHandle_byref_FileHandle_ReadCommandArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenFileAsync_Internal_Private_Static_FileHandle_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenFileAsync_Public_Static_FileHandle_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloseFileAsync_Internal_Static_JobHandle_byref_FileHandle_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInfoInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_ptr_Void_byref_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Injected_Private_Static_Void_byref_FileHandle_ptr_Void_byref_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenFileAsync_Internal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_FileHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloseFileAsync_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_byref_JobHandle_0;
  private static readonly AsyncReadManager.ReadInternal_InjectedDelegate ReadInternal_InjectedDelegateField;
  private static readonly AsyncReadManager.ReadWithHandlesInternal_NativePtr_InjectedDelegate ReadWithHandlesInternal_NativePtr_InjectedDelegateField;
  private static readonly AsyncReadManager.CloseCachedFileAsync_InjectedDelegate CloseCachedFileAsync_InjectedDelegateField;

  static AsyncReadManager()
  {
    Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (AsyncReadManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr);
    AsyncReadManager.NativeMethodInfoPtr_GetFileInfoInternal_Private_Static_ReadHandle_String_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663467 /*0x060000AB*/);
    AsyncReadManager.NativeMethodInfoPtr_GetFileInfo_Public_Static_ReadHandle_String_ptr_FileInfoResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663468 /*0x060000AC*/);
    AsyncReadManager.NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Private_Static_ReadHandle_byref_FileHandle_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663469 /*0x060000AD*/);
    AsyncReadManager.NativeMethodInfoPtr_Read_Public_Static_ReadHandle_byref_FileHandle_ReadCommandArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663470 /*0x060000AE*/);
    AsyncReadManager.NativeMethodInfoPtr_OpenFileAsync_Internal_Private_Static_FileHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663471 /*0x060000AF*/);
    AsyncReadManager.NativeMethodInfoPtr_OpenFileAsync_Public_Static_FileHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663472 /*0x060000B0*/);
    AsyncReadManager.NativeMethodInfoPtr_CloseFileAsync_Internal_Static_JobHandle_byref_FileHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663473 /*0x060000B1*/);
    AsyncReadManager.NativeMethodInfoPtr_GetFileInfoInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_ptr_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663474 /*0x060000B2*/);
    AsyncReadManager.NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Injected_Private_Static_Void_byref_FileHandle_ptr_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663475 /*0x060000B3*/);
    AsyncReadManager.NativeMethodInfoPtr_OpenFileAsync_Internal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663476 /*0x060000B4*/);
    AsyncReadManager.NativeMethodInfoPtr_CloseFileAsync_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663477 /*0x060000B5*/);
    AsyncReadManager.ReadInternal_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManager.ReadInternal_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadInternal_Injected");
    AsyncReadManager.ReadWithHandlesInternal_NativePtr_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManager.ReadWithHandlesInternal_NativePtr_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadWithHandlesInternal_NativePtr_Injected");
    AsyncReadManager.CloseCachedFileAsync_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManager.CloseCachedFileAsync_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::CloseCachedFileAsync_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414144, RefRangeEnd = 414145, XrefRangeStart = 414130, XrefRangeEnd = 414144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadHandle GetFileInfoInternal(string filename, void* cmd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(filename);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) cmd;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_GetFileInfoInternal_Private_Static_ReadHandle_String_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 414146, RefRangeEnd = 414148, XrefRangeStart = 414145, XrefRangeEnd = 414146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadHandle GetFileInfo(string filename, FileInfoResult* result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(filename);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) result;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_GetFileInfo_Public_Static_ReadHandle_String_ptr_FileInfoResult_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414148, XrefRangeEnd = 414150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadHandle ReadWithHandlesInternal_NativeCopy(
    [In] ref FileHandle fileHandle,
    void* readCmdArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref fileHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) readCmdArray;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Private_Static_ReadHandle_byref_FileHandle_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414154, RefRangeEnd = 414155, XrefRangeStart = 414150, XrefRangeEnd = 414154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadHandle Read([In] ref FileHandle fileHandle, ReadCommandArray readCmdArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref fileHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &readCmdArray;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_Read_Public_Static_ReadHandle_byref_FileHandle_ReadCommandArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414169, RefRangeEnd = 414170, XrefRangeStart = 414155, XrefRangeEnd = 414169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FileHandle OpenFileAsync_Internal(string fileName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(fileName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_OpenFileAsync_Internal_Private_Static_FileHandle_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FileHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414171, RefRangeEnd = 414172, XrefRangeStart = 414170, XrefRangeEnd = 414171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FileHandle OpenFileAsync(string fileName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(fileName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_OpenFileAsync_Public_Static_FileHandle_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FileHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414172, XrefRangeEnd = 414174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle CloseFileAsync([In] ref FileHandle fileHandle, JobHandle dependency)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref fileHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dependency;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_CloseFileAsync_Internal_Static_JobHandle_byref_FileHandle_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414174, XrefRangeEnd = 414176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetFileInfoInternal_Injected(
    ref ManagedSpanWrapper filename,
    void* cmd,
    out ReadHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref filename;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) cmd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_GetFileInfoInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_ptr_Void_byref_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414176, XrefRangeEnd = 414178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReadWithHandlesInternal_NativeCopy_Injected(
    [In] ref FileHandle fileHandle,
    void* readCmdArray,
    out ReadHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref fileHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) readCmdArray;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Injected_Private_Static_Void_byref_FileHandle_ptr_Void_byref_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414178, XrefRangeEnd = 414180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OpenFileAsync_Internal_Injected(
    ref ManagedSpanWrapper fileName,
    out FileHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref fileName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_OpenFileAsync_Internal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_FileHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414180, XrefRangeEnd = 414182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CloseFileAsync_Injected(
    [In] ref FileHandle fileHandle,
    [In] ref JobHandle dependency,
    out JobHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref fileHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dependency;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncReadManager.NativeMethodInfoPtr_CloseFileAsync_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public AsyncReadManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ReadHandle ReadInternal(
    string filename,
    void* cmds,
    uint cmdCount,
    string assetName,
    ulong typeID,
    AssetLoadingSubsystem subsystem)
  {
    ReadHandle readHandle1;
    ReadHandle readHandle2;
    try
    {
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = filename.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      void* cmds1 = cmds;
      int cmdCount1 = (int) cmdCount;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(assetName, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = assetName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      long typeID1 = (long) typeID;
      int subsystem1 = (int) subsystem;
      ref ReadHandle local3 = ref readHandle1;
      AsyncReadManager.ReadInternal_Injected(ref local1, cmds1, (uint) cmdCount1, ref local2, (ulong) typeID1, (AssetLoadingSubsystem) subsystem1, out local3);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      readHandle2 = readHandle1;
    }
    return readHandle2;
  }

  public static unsafe ReadHandle Read(
    string filename,
    ReadCommand* readCmds,
    uint readCmdCount,
    string assetName = null,
    ulong typeID = default (ulong),
    AssetLoadingSubsystem subsystem = default (AssetLoadingSubsystem))
  {
    return AsyncReadManager.ReadInternal(filename, (void*) readCmds, readCmdCount, assetName, typeID, subsystem);
  }

  public static unsafe ReadHandle ReadWithHandlesInternal_NativePtr(
    [In] ref FileHandle fileHandle,
    void* readCmdArray,
    JobHandle dependency)
  {
    ReadHandle ret;
    AsyncReadManager.ReadWithHandlesInternal_NativePtr_Injected(ref fileHandle, readCmdArray, ref dependency, out ret);
    return ret;
  }

  public static unsafe ReadHandle ReadDeferred(
    [In] ref FileHandle fileHandle,
    ReadCommandArray* readCmdArray,
    JobHandle dependency)
  {
    if (!fileHandle.IsValid())
      throw new Il2CppSystem.InvalidOperationException("FileHandle is invalid and may not be read from.");
    return AsyncReadManager.ReadWithHandlesInternal_NativePtr(ref fileHandle, (void*) readCmdArray, dependency);
  }

  public static unsafe JobHandle CloseCachedFileAsync(string fileName, JobHandle dependency = default (JobHandle))
  {
    JobHandle ret;
    JobHandle jobHandle;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(fileName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = fileName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      AsyncReadManager.CloseCachedFileAsync_Injected(ref managedSpanWrapper, ref dependency, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      jobHandle = ret;
    }
    return jobHandle;
  }

  public static unsafe void ReadInternal_Injected(
    ref ManagedSpanWrapper filename,
    void* cmds,
    uint cmdCount,
    ref ManagedSpanWrapper assetName,
    ulong typeID,
    AssetLoadingSubsystem subsystem,
    out ReadHandle ret)
  {
    AsyncReadManager.ReadInternal_InjectedDelegateField((System.IntPtr) ref filename, (System.IntPtr) cmds, cmdCount, (System.IntPtr) ref assetName, typeID, subsystem, (System.IntPtr) ref ret);
  }

  public static unsafe void ReadWithHandlesInternal_NativePtr_Injected(
    [In] ref FileHandle fileHandle,
    void* readCmdArray,
    [In] ref JobHandle dependency,
    out ReadHandle ret)
  {
    AsyncReadManager.ReadWithHandlesInternal_NativePtr_InjectedDelegateField((System.IntPtr) ref fileHandle, (System.IntPtr) readCmdArray, (System.IntPtr) ref dependency, (System.IntPtr) ref ret);
  }

  public static void CloseCachedFileAsync_Injected(
    ref ManagedSpanWrapper fileName,
    [In] ref JobHandle dependency,
    out JobHandle ret)
  {
    AsyncReadManager.CloseCachedFileAsync_InjectedDelegateField((System.IntPtr) ref fileName, (System.IntPtr) ref dependency, (System.IntPtr) ref ret);
  }

  private delegate void ReadInternal_InjectedDelegate(
    System.IntPtr filename,
    System.IntPtr cmds,
    uint cmdCount,
    System.IntPtr assetName,
    ulong typeID,
    AssetLoadingSubsystem subsystem,
    [Out] System.IntPtr ret);

  private delegate void ReadWithHandlesInternal_NativePtr_InjectedDelegate(
    [In] System.IntPtr fileHandle,
    System.IntPtr readCmdArray,
    [In] System.IntPtr dependency,
    [Out] System.IntPtr ret);

  private delegate void CloseCachedFileAsync_InjectedDelegate(
    System.IntPtr fileName,
    [In] System.IntPtr dependency,
    [Out] System.IntPtr ret);
}
