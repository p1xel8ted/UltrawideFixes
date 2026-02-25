// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.TitleStorageInterface
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

public sealed class TitleStorageInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletecacheoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_FilemetadataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_FilenameMaxLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryfilelistoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryfileoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReadfileoptionsApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_CopyFileMetadataAtIndexOptions_byref_FileMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_CopyFileMetadataByFilenameOptions_byref_FileMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCache_Public_Result_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFileMetadataCount_Public_UInt32_GetFileMetadataCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryFile_Public_Void_QueryFileOptions_Object_OnQueryFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryFileList_Public_Void_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadFile_Public_TitleStorageFileTransferRequest_ReadFileOptions_Object_OnReadFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_IntPtr_0;

  static TitleStorageInterface()
  {
    Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.TitleStorage", nameof (TitleStorageInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr);
    TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (CopyfilemetadataatindexoptionsApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (CopyfilemetadatabyfilenameoptionsApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (DeletecacheoptionsApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (FilemetadataApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (FilenameMaxLengthBytes));
    TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (GetfilemetadatacountoptionsApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (QueryfilelistoptionsApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (QueryfileoptionsApiLatest));
    TitleStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (ReadfileoptionsApiLatest));
    TitleStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665096 /*0x06000708*/);
    TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_CopyFileMetadataAtIndexOptions_byref_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665098 /*0x0600070A*/);
    TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_CopyFileMetadataByFilenameOptions_byref_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665099 /*0x0600070B*/);
    TitleStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665100 /*0x0600070C*/);
    TitleStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_UInt32_GetFileMetadataCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665101 /*0x0600070D*/);
    TitleStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_QueryFileOptions_Object_OnQueryFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665102 /*0x0600070E*/);
    TitleStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665103 /*0x0600070F*/);
    TitleStorageInterface.NativeMethodInfoPtr_ReadFile_Public_TitleStorageFileTransferRequest_ReadFileOptions_Object_OnReadFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665104 /*0x06000710*/);
    TitleStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665105);
    TitleStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665106);
    TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665107);
    TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665108);
    TitleStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665109);
    TitleStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665110);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TitleStorageInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375322, XrefRangeEnd = 375395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyFileMetadataAtIndex(
    CopyFileMetadataAtIndexOptions options,
    out FileMetadata outMetadata)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_CopyFileMetadataAtIndexOptions_byref_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref FileMetadata local = ref outMetadata;
    System.IntPtr pointer = zero;
    FileMetadata fileMetadata = pointer == System.IntPtr.Zero ? (FileMetadata) null : new FileMetadata(pointer);
    local = fileMetadata;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375395, XrefRangeEnd = 375468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyFileMetadataByFilename(
    CopyFileMetadataByFilenameOptions options,
    out FileMetadata outMetadata)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_CopyFileMetadataByFilenameOptions_byref_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref FileMetadata local = ref outMetadata;
    System.IntPtr pointer = zero;
    FileMetadata fileMetadata = pointer == System.IntPtr.Zero ? (FileMetadata) null : new FileMetadata(pointer);
    local = fileMetadata;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375468, XrefRangeEnd = 375549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result DeleteCache(
    DeleteCacheOptions options,
    Il2CppSystem.Object clientData,
    OnDeleteCacheCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375549, XrefRangeEnd = 375618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetFileMetadataCount(GetFileMetadataCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_UInt32_GetFileMetadataCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375618, XrefRangeEnd = 375698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryFile(
    QueryFileOptions options,
    Il2CppSystem.Object clientData,
    OnQueryFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_QueryFileOptions_Object_OnQueryFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375698, XrefRangeEnd = 375778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryFileList(
    QueryFileListOptions options,
    Il2CppSystem.Object clientData,
    OnQueryFileListCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375778, XrefRangeEnd = 375868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TitleStorageFileTransferRequest ReadFile(
    ReadFileOptions options,
    Il2CppSystem.Object clientData,
    OnReadFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_ReadFile_Public_TitleStorageFileTransferRequest_ReadFileOptions_Object_OnReadFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (TitleStorageFileTransferRequest) null : Il2CppObjectPool.Get<TitleStorageFileTransferRequest>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375868, XrefRangeEnd = 375874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDeleteCacheCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375874, XrefRangeEnd = 375885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnFileTransferProgressCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375885, XrefRangeEnd = 375891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375891, XrefRangeEnd = 375897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryFileListCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375897, XrefRangeEnd = 375903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnReadFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375903, XrefRangeEnd = 375915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadResult OnReadFileDataCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int CopyfilemetadataatindexoptionsApiLatest
  {
    get
    {
      int copyfilemetadataatindexoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &copyfilemetadataatindexoptionsApiLatest);
      return copyfilemetadataatindexoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyfilemetadatabyfilenameoptionsApiLatest
  {
    get
    {
      int copyfilemetadatabyfilenameoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &copyfilemetadatabyfilenameoptionsApiLatest);
      return copyfilemetadatabyfilenameoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletecacheoptionsApiLatest
  {
    get
    {
      int deletecacheoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &deletecacheoptionsApiLatest);
      return deletecacheoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int FilemetadataApiLatest
  {
    get
    {
      int filemetadataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &filemetadataApiLatest);
      return filemetadataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &value);
    }
  }

  public static unsafe int FilenameMaxLengthBytes
  {
    get
    {
      int filenameMaxLengthBytes;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &filenameMaxLengthBytes);
      return filenameMaxLengthBytes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &value);
    }
  }

  public static unsafe int GetfilemetadatacountoptionsApiLatest
  {
    get
    {
      int getfilemetadatacountoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &getfilemetadatacountoptionsApiLatest);
      return getfilemetadatacountoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryfilelistoptionsApiLatest
  {
    get
    {
      int queryfilelistoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &queryfilelistoptionsApiLatest);
      return queryfilelistoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryfileoptionsApiLatest
  {
    get
    {
      int queryfileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &queryfileoptionsApiLatest);
      return queryfileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReadfileoptionsApiLatest
  {
    get
    {
      int readfileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &readfileoptionsApiLatest);
      return readfileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &value);
    }
  }
}
