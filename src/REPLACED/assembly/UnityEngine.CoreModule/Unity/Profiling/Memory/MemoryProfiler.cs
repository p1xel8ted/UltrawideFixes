// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.Memory.MemoryProfiler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.Profiling.Memory;

public static class MemoryProfiler : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SnapshotFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SaveScreenshotToDisk;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatingMetadata;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0;
  private static readonly MemoryProfiler.StartOperation_InjectedDelegate StartOperation_InjectedDelegateField;

  static MemoryProfiler()
  {
    Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.Memory", nameof (MemoryProfiler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
    MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, nameof (m_SnapshotFinished));
    MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, nameof (m_SaveScreenshotToDisk));
    MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, nameof (CreatingMetadata));
    MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663441 /*0x06000091*/);
    MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663442 /*0x06000092*/);
    MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663443 /*0x06000093*/);
    MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663444 /*0x06000094*/);
    MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663445 /*0x06000095*/);
    MemoryProfiler.StartOperation_InjectedDelegateField = IL2CPP.ResolveICall<MemoryProfiler.StartOperation_InjectedDelegate>("Unity.Profiling.Memory.MemoryProfiler::StartOperation_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413978, XrefRangeEnd = 413999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> PrepareMetadata()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  public static unsafe int WriteIntToByteArray(
    Il2CppStructArray<byte> array,
    int offset,
    int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413999, XrefRangeEnd = 414000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int WriteStringToByteArray(
    Il2CppStructArray<byte> array,
    int offset,
    string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414000, XrefRangeEnd = 414002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FinalizeSnapshot(string path, bool result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414002, XrefRangeEnd = 414007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SaveScreenshotToDisk(
    string path,
    bool result,
    System.IntPtr pixelsPtr,
    int pixelsCount,
    TextureFormat format,
    int width,
    int height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pixelsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pixelsCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public MemoryProfiler(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppSystem.Action<string, bool> m_SnapshotFinished
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<string, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, bool>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<string, bool, DebugScreenCapture>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, bool, DebugScreenCapture>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<MemorySnapshotMetadata> CreatingMetadata
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<MemorySnapshotMetadata>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MemorySnapshotMetadata>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [SpecialName]
  public static void add_m_SnapshotFinished(Il2CppSystem.Action<string, bool> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_m_SnapshotFinished(Il2CppSystem.Action<string, bool> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_m_SaveScreenshotToDisk(Il2CppSystem.Action<string, bool, DebugScreenCapture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_m_SaveScreenshotToDisk(Il2CppSystem.Action<string, bool, DebugScreenCapture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_CreatingMetadata(Il2CppSystem.Action<MemorySnapshotMetadata> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_CreatingMetadata(Il2CppSystem.Action<MemorySnapshotMetadata> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe void StartOperation(
    uint captureFlag,
    bool requestScreenshot,
    string path,
    bool isRemote)
  {
    try
    {
      int captureFlag1 = (int) captureFlag;
      int num1 = requestScreenshot ? 1 : 0;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = path.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int num2 = isRemote ? 1 : 0;
      MemoryProfiler.StartOperation_Injected((uint) captureFlag1, num1 != 0, ref local, num2 != 0);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void TakeSnapshot(
    string path,
    Il2CppSystem.Action<string, bool> finishCallback,
    CaptureFlags captureFlags = default (CaptureFlags))
  {
    MemoryProfiler.TakeSnapshot(path, finishCallback, (Il2CppSystem.Action<string, bool, DebugScreenCapture>) null, captureFlags);
  }

  public static void TakeSnapshot(
    string path,
    Il2CppSystem.Action<string, bool> finishCallback,
    Il2CppSystem.Action<string, bool, DebugScreenCapture> screenshotCallback,
    CaptureFlags captureFlags = default (CaptureFlags))
  {
    if (MemoryProfiler.m_SnapshotFinished != null)
    {
      Debug.LogWarning((Il2CppSystem.Object) "Canceling snapshot, there is another snapshot in progress.");
      finishCallback.Invoke(path, false);
    }
    else
    {
      MemoryProfiler.add_m_SnapshotFinished(finishCallback);
      MemoryProfiler.add_m_SaveScreenshotToDisk(screenshotCallback);
      MemoryProfiler.StartOperation((uint) captureFlags, MemoryProfiler.m_SaveScreenshotToDisk != null, path, false);
    }
  }

  public static void TakeTempSnapshot(
    Il2CppSystem.Action<string, bool> finishCallback,
    CaptureFlags captureFlags = default (CaptureFlags))
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void StartOperation_Injected(
    uint captureFlag,
    bool requestScreenshot,
    ref ManagedSpanWrapper path,
    bool isRemote)
  {
    MemoryProfiler.StartOperation_InjectedDelegateField(captureFlag, requestScreenshot, (System.IntPtr) ref path, isRemote);
  }

  private delegate void StartOperation_InjectedDelegate(
    uint captureFlag,
    bool requestScreenshot,
    System.IntPtr path,
    bool isRemote);
}
