// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.WriteFileOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(LayoutKind.Explicit)]
public struct WriteFileOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ChunkLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteFileDataCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FileTransferProgressCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_WriteFileDataCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_FileTransferProgressCallback;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ChunkLengthBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WriteFileDataCallback_Public_Static_get_OnWriteFileDataCallbackInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_WriteFileOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Filename;
  [FieldOffset(24)]
  public uint m_ChunkLengthBytes;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_WriteFileDataCallback;
  [FieldOffset(40)]
  public System.IntPtr m_FileTransferProgressCallback;

  static WriteFileOptionsInternal()
  {
    Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (WriteFileOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr);
    WriteFileOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    WriteFileOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    WriteFileOptionsInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_Filename));
    WriteFileOptionsInternal.NativeFieldInfoPtr_m_ChunkLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_ChunkLengthBytes));
    WriteFileOptionsInternal.NativeFieldInfoPtr_m_WriteFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_WriteFileDataCallback));
    WriteFileOptionsInternal.NativeFieldInfoPtr_m_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_FileTransferProgressCallback));
    WriteFileOptionsInternal.NativeFieldInfoPtr_s_WriteFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (s_WriteFileDataCallback));
    WriteFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (s_FileTransferProgressCallback));
    WriteFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667921);
    WriteFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667922);
    WriteFileOptionsInternal.NativeMethodInfoPtr_set_ChunkLengthBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667923);
    WriteFileOptionsInternal.NativeMethodInfoPtr_get_WriteFileDataCallback_Public_Static_get_OnWriteFileDataCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667924);
    WriteFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667925);
    WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WriteFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667926);
    WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667927);
    WriteFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100667928);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385347, XrefRangeEnd = 385351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Filename
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385351, XrefRangeEnd = 385355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint ChunkLengthBytes
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_set_ChunkLengthBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe OnWriteFileDataCallbackInternal WriteFileDataCallback
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 385366, RefRangeEnd = 385368, XrefRangeStart = 385355, XrefRangeEnd = 385366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_get_WriteFileDataCallback_Public_Static_get_OnWriteFileDataCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (OnWriteFileDataCallbackInternal) null : Il2CppObjectPool.Get<OnWriteFileDataCallbackInternal>(num3);
    }
  }

  public static unsafe OnFileTransferProgressCallbackInternal FileTransferProgressCallback
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 385379, RefRangeEnd = 385381, XrefRangeStart = 385368, XrefRangeEnd = 385379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : Il2CppObjectPool.Get<OnFileTransferProgressCallbackInternal>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 385403, RefRangeEnd = 385404, XrefRangeStart = 385381, XrefRangeEnd = 385403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(WriteFileOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WriteFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385404, XrefRangeEnd = 385407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385407, XrefRangeEnd = 385414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe OnWriteFileDataCallbackInternal s_WriteFileDataCallback
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_WriteFileDataCallback, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (OnWriteFileDataCallbackInternal) null : Il2CppObjectPool.Get<OnWriteFileDataCallbackInternal>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_WriteFileDataCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : Il2CppObjectPool.Get<OnFileTransferProgressCallbackInternal>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
