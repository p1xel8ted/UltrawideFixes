// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.ReadHandle
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
public struct ReadHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_version;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelInternal_Private_Static_Void_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_ReadStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReadStatus_Private_Static_ReadStatus_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseReadHandle_Private_Static_Void_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsReadHandleValid_Private_Static_Boolean_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Private_Static_JobHandle_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelInternal_Injected_Private_Static_Void_byref_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReadStatus_Injected_Private_Static_ReadStatus_byref_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseReadHandle_Injected_Private_Static_Void_byref_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsReadHandleValid_Injected_Private_Static_Boolean_byref_ReadHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Injected_Private_Static_Void_byref_ReadHandle_byref_JobHandle_0;
  [FieldOffset(0)]
  public System.IntPtr ptr;
  [FieldOffset(8)]
  public int version;
  private static readonly ReadHandle.GetReadCount_InjectedDelegate GetReadCount_InjectedDelegateField;
  private static readonly ReadHandle.GetBytesRead_InjectedDelegate GetBytesRead_InjectedDelegateField;
  private static readonly ReadHandle.GetBytesReadForCommand_InjectedDelegate GetBytesReadForCommand_InjectedDelegateField;
  private static readonly ReadHandle.GetBytesReadArray_InjectedDelegate GetBytesReadArray_InjectedDelegateField;

  static ReadHandle()
  {
    Il2CppClassPointerStore<ReadHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (ReadHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr);
    ReadHandle.NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, nameof (ptr));
    ReadHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, nameof (version));
    ReadHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663452 /*0x0600009C*/);
    ReadHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663453 /*0x0600009D*/);
    ReadHandle.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663454 /*0x0600009E*/);
    ReadHandle.NativeMethodInfoPtr_CancelInternal_Private_Static_Void_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663455 /*0x0600009F*/);
    ReadHandle.NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663456 /*0x060000A0*/);
    ReadHandle.NativeMethodInfoPtr_get_Status_Public_get_ReadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663457 /*0x060000A1*/);
    ReadHandle.NativeMethodInfoPtr_GetReadStatus_Private_Static_ReadStatus_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663458 /*0x060000A2*/);
    ReadHandle.NativeMethodInfoPtr_ReleaseReadHandle_Private_Static_Void_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663459 /*0x060000A3*/);
    ReadHandle.NativeMethodInfoPtr_IsReadHandleValid_Private_Static_Boolean_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663460 /*0x060000A4*/);
    ReadHandle.NativeMethodInfoPtr_GetJobHandle_Private_Static_JobHandle_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663461 /*0x060000A5*/);
    ReadHandle.NativeMethodInfoPtr_CancelInternal_Injected_Private_Static_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663462 /*0x060000A6*/);
    ReadHandle.NativeMethodInfoPtr_GetReadStatus_Injected_Private_Static_ReadStatus_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663463 /*0x060000A7*/);
    ReadHandle.NativeMethodInfoPtr_ReleaseReadHandle_Injected_Private_Static_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663464 /*0x060000A8*/);
    ReadHandle.NativeMethodInfoPtr_IsReadHandleValid_Injected_Private_Static_Boolean_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663465 /*0x060000A9*/);
    ReadHandle.NativeMethodInfoPtr_GetJobHandle_Injected_Private_Static_Void_byref_ReadHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663466 /*0x060000AA*/);
    ReadHandle.GetReadCount_InjectedDelegateField = IL2CPP.ResolveICall<ReadHandle.GetReadCount_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetReadCount_Injected");
    ReadHandle.GetBytesRead_InjectedDelegateField = IL2CPP.ResolveICall<ReadHandle.GetBytesRead_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesRead_Injected");
    ReadHandle.GetBytesReadForCommand_InjectedDelegateField = IL2CPP.ResolveICall<ReadHandle.GetBytesReadForCommand_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesReadForCommand_Injected");
    ReadHandle.GetBytesReadArray_InjectedDelegateField = IL2CPP.ResolveICall<ReadHandle.GetBytesReadArray_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesReadArray_Injected");
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 414032, RefRangeEnd = 414061, XrefRangeStart = 414030, XrefRangeEnd = 414032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414061, XrefRangeEnd = 414066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 414070, RefRangeEnd = 414077, XrefRangeStart = 414066, XrefRangeEnd = 414070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Cancel()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_Cancel_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414077, XrefRangeEnd = 414079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CancelInternal(ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_CancelInternal_Private_Static_Void_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe JobHandle JobHandle
  {
    [CallerCount(16 /*0x10*/), CachedScanResults(RefRangeStart = 414083, RefRangeEnd = 414099, XrefRangeStart = 414079, XrefRangeEnd = 414083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ReadStatus Status
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 414103, RefRangeEnd = 414112, XrefRangeStart = 414099, XrefRangeEnd = 414103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_get_Status_Public_get_ReadStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ReadStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414112, XrefRangeEnd = 414114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadStatus GetReadStatus(ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_GetReadStatus_Private_Static_ReadStatus_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414114, XrefRangeEnd = 414116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReleaseReadHandle(ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_ReleaseReadHandle_Private_Static_Void_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414116, XrefRangeEnd = 414118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsReadHandleValid(ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_IsReadHandleValid_Private_Static_Boolean_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414118, XrefRangeEnd = 414120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle GetJobHandle(ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_GetJobHandle_Private_Static_JobHandle_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414120, XrefRangeEnd = 414122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CancelInternal_Injected([In] ref ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_CancelInternal_Injected_Private_Static_Void_byref_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414122, XrefRangeEnd = 414124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadStatus GetReadStatus_Injected([In] ref ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_GetReadStatus_Injected_Private_Static_ReadStatus_byref_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414124, XrefRangeEnd = 414126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReleaseReadHandle_Injected([In] ref ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_ReleaseReadHandle_Injected_Private_Static_Void_byref_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414126, XrefRangeEnd = 414128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsReadHandleValid_Injected([In] ref ReadHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_IsReadHandleValid_Injected_Private_Static_Boolean_byref_ReadHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414128, XrefRangeEnd = 414130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetJobHandle_Injected([In] ref ReadHandle handle, out JobHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadHandle.NativeMethodInfoPtr_GetJobHandle_Injected_Private_Static_Void_byref_ReadHandle_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public long ReadCount
  {
    get
    {
      if (!ReadHandle.IsReadHandleValid(this))
        throw new Il2CppSystem.InvalidOperationException("Cannot use a ReadHandle that has been disposed");
      return ReadHandle.GetReadCount(this);
    }
  }

  public long GetBytesRead()
  {
    if (!ReadHandle.IsReadHandleValid(this))
      throw new Il2CppSystem.InvalidOperationException("ReadHandle.GetBytesRead cannot be called after the ReadHandle has been disposed");
    return ReadHandle.GetBytesRead(this);
  }

  public long GetBytesRead(uint readCommandIndex)
  {
    if (!ReadHandle.IsReadHandleValid(this))
      throw new Il2CppSystem.InvalidOperationException("ReadHandle.GetBytesRead cannot be called after the ReadHandle has been disposed");
    return ReadHandle.GetBytesReadForCommand(this, readCommandIndex);
  }

  public unsafe ulong* GetBytesReadArray()
  {
    if (!ReadHandle.IsReadHandleValid(this))
      throw new Il2CppSystem.InvalidOperationException("ReadHandle.GetBytesReadArray cannot be called after the ReadHandle has been disposed");
    return ReadHandle.GetBytesReadArray(this);
  }

  public static long GetReadCount(ReadHandle handle)
  {
    return ReadHandle.GetReadCount_Injected(ref handle);
  }

  public static long GetBytesRead(ReadHandle handle)
  {
    return ReadHandle.GetBytesRead_Injected(ref handle);
  }

  public static long GetBytesReadForCommand(ReadHandle handle, uint readCommandIndex)
  {
    return ReadHandle.GetBytesReadForCommand_Injected(ref handle, readCommandIndex);
  }

  public static unsafe ulong* GetBytesReadArray(ReadHandle handle)
  {
    return ReadHandle.GetBytesReadArray_Injected(ref handle);
  }

  public static long GetReadCount_Injected([In] ref ReadHandle handle)
  {
    return ReadHandle.GetReadCount_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static long GetBytesRead_Injected([In] ref ReadHandle handle)
  {
    return ReadHandle.GetBytesRead_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static long GetBytesReadForCommand_Injected([In] ref ReadHandle handle, uint readCommandIndex)
  {
    return ReadHandle.GetBytesReadForCommand_InjectedDelegateField((System.IntPtr) ref handle, readCommandIndex);
  }

  public static unsafe ulong* GetBytesReadArray_Injected([In] ref ReadHandle handle)
  {
    return (ulong*) ReadHandle.GetBytesReadArray_InjectedDelegateField((System.IntPtr) ref handle);
  }

  private delegate long GetReadCount_InjectedDelegate([In] System.IntPtr handle);

  private delegate long GetBytesRead_InjectedDelegate([In] System.IntPtr handle);

  private delegate long GetBytesReadForCommand_InjectedDelegate(
    [In] System.IntPtr handle,
    uint readCommandIndex);

  private delegate System.IntPtr GetBytesReadArray_InjectedDelegate([In] System.IntPtr handle);
}
