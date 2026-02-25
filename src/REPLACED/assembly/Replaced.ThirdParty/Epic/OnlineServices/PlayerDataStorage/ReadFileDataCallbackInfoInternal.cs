// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.ReadFileDataCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(LayoutKind.Explicit)]
public struct ReadFileDataCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalFileSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsLastChunk;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DataChunkLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DataChunk;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Filename_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalFileSizeBytes_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLastChunk_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DataChunk_Public_get_Il2CppStructArray_1_Byte_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Filename;
  [FieldOffset(24)]
  public uint m_TotalFileSizeBytes;
  [FieldOffset(28)]
  public int m_IsLastChunk;
  [FieldOffset(32 /*0x20*/)]
  public uint m_DataChunkLengthBytes;
  [FieldOffset(40)]
  public System.IntPtr m_DataChunk;

  static ReadFileDataCallbackInfoInternal()
  {
    Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (ReadFileDataCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr);
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_Filename));
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_TotalFileSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_TotalFileSizeBytes));
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_IsLastChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_IsLastChunk));
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_DataChunkLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_DataChunkLengthBytes));
    ReadFileDataCallbackInfoInternal.NativeFieldInfoPtr_m_DataChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, nameof (m_DataChunk));
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667850);
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667851);
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667852);
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_Filename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667853);
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_TotalFileSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667854);
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_IsLastChunk_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667855);
    ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_DataChunk_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, 100667856);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385121, XrefRangeEnd = 385125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385125, XrefRangeEnd = 385131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe string Filename
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385131, XrefRangeEnd = 385135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_Filename_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe uint TotalFileSizeBytes
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_TotalFileSizeBytes_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsLastChunk
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385135, XrefRangeEnd = 385139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_IsLastChunk_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppStructArray<byte> DataChunk
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385139, XrefRangeEnd = 385145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfoInternal.NativeMethodInfoPtr_get_DataChunk_Public_get_Il2CppStructArray_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadFileDataCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
