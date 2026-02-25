// Decompiled with JetBrains decompiler
// Type: UnityEngine.ManagedStreamHelpers
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;

#nullable disable
namespace UnityEngine;

public static class ManagedStreamHelpers : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0;

  static ManagedStreamHelpers()
  {
    Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ManagedStreamHelpers));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr);
    ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100668182);
    ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100668183);
    ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100668184);
    ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100668185);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 452079, RefRangeEnd = 452082, XrefRangeStart = 452079, XrefRangeEnd = 452079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ValidateLoadFromStream(Stream stream)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452082, XrefRangeEnd = 452084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ManagedStreamRead(
    Il2CppStructArray<byte> buffer,
    int offset,
    int count,
    Stream stream,
    System.IntPtr returnValueAddress)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &returnValueAddress;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452084, XrefRangeEnd = 452086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ManagedStreamSeek(
    long offset,
    uint origin,
    Stream stream,
    System.IntPtr returnValueAddress)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &returnValueAddress;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452086, XrefRangeEnd = 452088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ManagedStreamLength(Stream stream, System.IntPtr returnValueAddress)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &returnValueAddress;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ManagedStreamHelpers(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
