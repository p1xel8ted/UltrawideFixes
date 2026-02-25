// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.FileHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Jobs;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct FileHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_fileCommandPtr;
  private static readonly System.IntPtr NativeFieldInfoPtr_version;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_JobHandle_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsFileHandleValid_Private_Static_Boolean_byref_FileHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Internal_Private_Static_JobHandle_byref_FileHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Internal_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_0;
  [FieldOffset(0)]
  public readonly System.IntPtr fileCommandPtr;
  [FieldOffset(8)]
  public readonly int version;
  private static readonly FileHandle.GetFileStatus_InternalDelegate GetFileStatus_InternalDelegateField;

  static FileHandle()
  {
    Il2CppClassPointerStore<FileHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (FileHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileHandle>.NativeClassPtr);
    FileHandle.NativeFieldInfoPtr_fileCommandPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, nameof (fileCommandPtr));
    FileHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, nameof (version));
    FileHandle.NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663446 /*0x06000096*/);
    FileHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663447 /*0x06000097*/);
    FileHandle.NativeMethodInfoPtr_Close_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663448 /*0x06000098*/);
    FileHandle.NativeMethodInfoPtr_IsFileHandleValid_Private_Static_Boolean_byref_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663449 /*0x06000099*/);
    FileHandle.NativeMethodInfoPtr_GetJobHandle_Internal_Private_Static_JobHandle_byref_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663450 /*0x0600009A*/);
    FileHandle.NativeMethodInfoPtr_GetJobHandle_Internal_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663451 /*0x0600009B*/);
    FileHandle.GetFileStatus_InternalDelegateField = IL2CPP.ResolveICall<FileHandle.GetFileStatus_InternalDelegate>("Unity.IO.LowLevel.Unsafe.FileHandle::GetFileStatus_Internal");
  }

  public unsafe JobHandle JobHandle
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 414011, RefRangeEnd = 414012, XrefRangeStart = 414007, XrefRangeEnd = 414011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileHandle.NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 414014, RefRangeEnd = 414019, XrefRangeStart = 414012, XrefRangeEnd = 414014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 414023, RefRangeEnd = 414026, XrefRangeStart = 414019, XrefRangeEnd = 414023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JobHandle Close(JobHandle dependency = default (JobHandle))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dependency
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileHandle.NativeMethodInfoPtr_Close_Public_JobHandle_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 414014, RefRangeEnd = 414019, XrefRangeStart = 414014, XrefRangeEnd = 414019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsFileHandleValid([In] ref FileHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileHandle.NativeMethodInfoPtr_IsFileHandleValid_Private_Static_Boolean_byref_FileHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414026, XrefRangeEnd = 414028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle GetJobHandle_Internal([In] ref FileHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileHandle.NativeMethodInfoPtr_GetJobHandle_Internal_Private_Static_JobHandle_byref_FileHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414028, XrefRangeEnd = 414030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetJobHandle_Internal_Injected([In] ref FileHandle handle, out JobHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FileHandle.NativeMethodInfoPtr_GetJobHandle_Internal_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public FileStatus Status
  {
    get
    {
      if (!FileHandle.IsFileHandleValid(ref this))
        throw new Il2CppSystem.InvalidOperationException("FileHandle.Status cannot be called on a closed FileHandle");
      return FileHandle.GetFileStatus_Internal(ref this);
    }
  }

  public static FileStatus GetFileStatus_Internal([In] ref FileHandle handle)
  {
    return FileHandle.GetFileStatus_InternalDelegateField((System.IntPtr) ref handle);
  }

  private delegate FileStatus GetFileStatus_InternalDelegate([In] System.IntPtr handle);
}
