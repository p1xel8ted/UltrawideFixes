// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.FileMetadataInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(LayoutKind.Explicit)]
public struct FileMetadataInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FileSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MD5Hash;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastModifiedTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnencryptedDataSizeBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FileSizeBytes_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FileSizeBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MD5Hash_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MD5Hash_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Filename_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastModifiedTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LastModifiedTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnencryptedDataSizeBytes_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnencryptedDataSizeBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_FileMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_FileSizeBytes;
  [FieldOffset(8)]
  public System.IntPtr m_MD5Hash;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Filename;
  [FieldOffset(24)]
  public long m_LastModifiedTime;
  [FieldOffset(32 /*0x20*/)]
  public uint m_UnencryptedDataSizeBytes;

  static FileMetadataInternal()
  {
    Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (FileMetadataInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr);
    FileMetadataInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, nameof (m_ApiVersion));
    FileMetadataInternal.NativeFieldInfoPtr_m_FileSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, nameof (m_FileSizeBytes));
    FileMetadataInternal.NativeFieldInfoPtr_m_MD5Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, nameof (m_MD5Hash));
    FileMetadataInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, nameof (m_Filename));
    FileMetadataInternal.NativeFieldInfoPtr_m_LastModifiedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, nameof (m_LastModifiedTime));
    FileMetadataInternal.NativeFieldInfoPtr_m_UnencryptedDataSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, nameof (m_UnencryptedDataSizeBytes));
    FileMetadataInternal.NativeMethodInfoPtr_get_FileSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667621);
    FileMetadataInternal.NativeMethodInfoPtr_set_FileSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667622);
    FileMetadataInternal.NativeMethodInfoPtr_get_MD5Hash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667623);
    FileMetadataInternal.NativeMethodInfoPtr_set_MD5Hash_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667624);
    FileMetadataInternal.NativeMethodInfoPtr_get_Filename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667625);
    FileMetadataInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667626);
    FileMetadataInternal.NativeMethodInfoPtr_get_LastModifiedTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667627);
    FileMetadataInternal.NativeMethodInfoPtr_set_LastModifiedTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667628);
    FileMetadataInternal.NativeMethodInfoPtr_get_UnencryptedDataSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667629);
    FileMetadataInternal.NativeMethodInfoPtr_set_UnencryptedDataSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667630);
    FileMetadataInternal.NativeMethodInfoPtr_Set_Public_Void_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667631);
    FileMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667632 /*0x060010F0*/);
    FileMetadataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, 100667633);
  }

  public unsafe uint FileSizeBytes
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_get_FileSizeBytes_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_set_FileSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string MD5Hash
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384337, XrefRangeEnd = 384341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_get_MD5Hash_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384341, XrefRangeEnd = 384345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_set_MD5Hash_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Filename
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384345, XrefRangeEnd = 384349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_get_Filename_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384349, XrefRangeEnd = 384353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> LastModifiedTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384353, XrefRangeEnd = 384357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_get_LastModifiedTime_Public_get_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384357, XrefRangeEnd = 384361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_set_LastModifiedTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint UnencryptedDataSizeBytes
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_get_UnencryptedDataSizeBytes_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_set_UnencryptedDataSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 384373, RefRangeEnd = 384374, XrefRangeStart = 384361, XrefRangeEnd = 384373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(FileMetadata other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_Set_Public_Void_FileMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384374, XrefRangeEnd = 384377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384377, XrefRangeEnd = 384382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FileMetadataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileMetadataInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
