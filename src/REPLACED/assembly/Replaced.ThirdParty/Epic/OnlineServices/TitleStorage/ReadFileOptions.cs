// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.ReadFileOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.TitleStorage;

public class ReadFileOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Filename_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReadChunkLengthBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReadFileDataCallback_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__FileTransferProgressCallback_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Filename_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReadChunkLengthBytes_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReadFileDataCallback_Public_get_OnReadFileDataCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReadFileDataCallback_Public_set_Void_OnReadFileDataCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_get_OnFileTransferProgressCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FileTransferProgressCallback_Public_set_Void_OnFileTransferProgressCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ReadFileOptions()
  {
    Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.TitleStorage", nameof (ReadFileOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr);
    ReadFileOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
    ReadFileOptions.NativeFieldInfoPtr__Filename_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, "<Filename>k__BackingField");
    ReadFileOptions.NativeFieldInfoPtr__ReadChunkLengthBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, "<ReadChunkLengthBytes>k__BackingField");
    ReadFileOptions.NativeFieldInfoPtr__ReadFileDataCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, "<ReadFileDataCallback>k__BackingField");
    ReadFileOptions.NativeFieldInfoPtr__FileTransferProgressCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, "<FileTransferProgressCallback>k__BackingField");
    ReadFileOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665071);
    ReadFileOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665072 /*0x060006F0*/);
    ReadFileOptions.NativeMethodInfoPtr_get_Filename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665073);
    ReadFileOptions.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665074);
    ReadFileOptions.NativeMethodInfoPtr_get_ReadChunkLengthBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665075);
    ReadFileOptions.NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665076);
    ReadFileOptions.NativeMethodInfoPtr_get_ReadFileDataCallback_Public_get_OnReadFileDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665077);
    ReadFileOptions.NativeMethodInfoPtr_set_ReadFileDataCallback_Public_set_Void_OnReadFileDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665078);
    ReadFileOptions.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_get_OnFileTransferProgressCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665079);
    ReadFileOptions.NativeMethodInfoPtr_set_FileTransferProgressCallback_Public_set_Void_OnFileTransferProgressCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665080);
    ReadFileOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr, 100665081);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Filename
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_get_Filename_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint ReadChunkLengthBytes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_get_ReadChunkLengthBytes_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe OnReadFileDataCallback ReadFileDataCallback
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_get_ReadFileDataCallback_Public_get_OnReadFileDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (OnReadFileDataCallback) null : Il2CppObjectPool.Get<OnReadFileDataCallback>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_set_ReadFileDataCallback_Public_set_Void_OnReadFileDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe OnFileTransferProgressCallback FileTransferProgressCallback
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_get_OnFileTransferProgressCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (OnFileTransferProgressCallback) null : Il2CppObjectPool.Get<OnFileTransferProgressCallback>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr_set_FileTransferProgressCallback_Public_set_Void_OnFileTransferProgressCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ReadFileOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadFileOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadFileOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ProductUserId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _Filename_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__Filename_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__Filename_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe uint _ReadChunkLengthBytes_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__ReadChunkLengthBytes_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__ReadChunkLengthBytes_k__BackingField)) = value;
    }
  }

  public unsafe OnReadFileDataCallback _ReadFileDataCallback_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__ReadFileDataCallback_k__BackingField));
      return num == System.IntPtr.Zero ? (OnReadFileDataCallback) null : Il2CppObjectPool.Get<OnReadFileDataCallback>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__ReadFileDataCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe OnFileTransferProgressCallback _FileTransferProgressCallback_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__FileTransferProgressCallback_k__BackingField));
      return num == System.IntPtr.Zero ? (OnFileTransferProgressCallback) null : Il2CppObjectPool.Get<OnFileTransferProgressCallback>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileOptions.NativeFieldInfoPtr__FileTransferProgressCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
