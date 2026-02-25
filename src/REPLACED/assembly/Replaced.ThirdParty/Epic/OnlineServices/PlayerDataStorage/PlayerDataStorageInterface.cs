// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.PlayerDataStorageInterface
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

public sealed class PlayerDataStorageInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletecacheoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletefileoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DuplicatefileoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_FileMaxSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_FilemetadataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_FilenameMaxLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryfilelistoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryfileoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReadfileoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_WritefileoptionsApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_CopyFileMetadataAtIndexOptions_byref_FileMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_CopyFileMetadataByFilenameOptions_byref_FileMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCache_Public_Result_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Void_DeleteFileOptions_Object_OnDeleteFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DuplicateFile_Public_Void_DuplicateFileOptions_Object_OnDuplicateFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFileMetadataCount_Public_Result_GetFileMetadataCountOptions_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryFile_Public_Void_QueryFileOptions_Object_OnQueryFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryFileList_Public_Void_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadFile_Public_PlayerDataStorageFileTransferRequest_ReadFileOptions_Object_OnReadFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteFile_Public_PlayerDataStorageFileTransferRequest_WriteFileOptions_Object_OnWriteFileCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDuplicateFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnWriteFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnWriteFileDataCallbackInternalImplementation_Internal_Static_WriteResult_IntPtr_IntPtr_byref_UInt32_0;

  static PlayerDataStorageInterface()
  {
    Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (PlayerDataStorageInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr);
    PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (CopyfilemetadataatindexoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (CopyfilemetadatabyfilenameoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DeletecacheoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DeletefileoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DuplicatefileoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_FileMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (FileMaxSizeBytes));
    PlayerDataStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (FilemetadataApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (FilenameMaxLengthBytes));
    PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (GetfilemetadatacountoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (QueryfilelistoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (QueryfileoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (ReadfileoptionsApiLatest));
    PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (WritefileoptionsApiLatest));
    PlayerDataStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667747);
    PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_CopyFileMetadataAtIndexOptions_byref_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667749);
    PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_CopyFileMetadataByFilenameOptions_byref_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667750);
    PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667751);
    PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteFile_Public_Void_DeleteFileOptions_Object_OnDeleteFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667752);
    PlayerDataStorageInterface.NativeMethodInfoPtr_DuplicateFile_Public_Void_DuplicateFileOptions_Object_OnDuplicateFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667753);
    PlayerDataStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_Result_GetFileMetadataCountOptions_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667754);
    PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_QueryFileOptions_Object_OnQueryFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667755);
    PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667756);
    PlayerDataStorageInterface.NativeMethodInfoPtr_ReadFile_Public_PlayerDataStorageFileTransferRequest_ReadFileOptions_Object_OnReadFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667757);
    PlayerDataStorageInterface.NativeMethodInfoPtr_WriteFile_Public_PlayerDataStorageFileTransferRequest_WriteFileOptions_Object_OnWriteFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667758);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667759);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667760);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnDuplicateFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667761);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667762);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667763);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667764);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667765);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667766);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667767);
    PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileDataCallbackInternalImplementation_Internal_Static_WriteResult_IntPtr_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100667768);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerDataStorageInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384591, XrefRangeEnd = 384603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyFileMetadataAtIndex(
    CopyFileMetadataAtIndexOptions copyFileMetadataOptions,
    out FileMetadata outMetadata)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFileMetadataOptions);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_CopyFileMetadataAtIndexOptions_byref_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref FileMetadata local = ref outMetadata;
    System.IntPtr pointer = zero;
    FileMetadata fileMetadata = pointer == System.IntPtr.Zero ? (FileMetadata) null : new FileMetadata(pointer);
    local = fileMetadata;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384603, XrefRangeEnd = 384615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyFileMetadataByFilename(
    CopyFileMetadataByFilenameOptions copyFileMetadataOptions,
    out FileMetadata outMetadata)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFileMetadataOptions);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_CopyFileMetadataByFilenameOptions_byref_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref FileMetadata local = ref outMetadata;
    System.IntPtr pointer = zero;
    FileMetadata fileMetadata = pointer == System.IntPtr.Zero ? (FileMetadata) null : new FileMetadata(pointer);
    local = fileMetadata;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384615, XrefRangeEnd = 384634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384634, XrefRangeEnd = 384653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeleteFile(
    DeleteFileOptions deleteOptions,
    Il2CppSystem.Object clientData,
    OnDeleteFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deleteOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteFile_Public_Void_DeleteFileOptions_Object_OnDeleteFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384653, XrefRangeEnd = 384672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DuplicateFile(
    DuplicateFileOptions duplicateOptions,
    Il2CppSystem.Object clientData,
    OnDuplicateFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) duplicateOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_DuplicateFile_Public_Void_DuplicateFileOptions_Object_OnDuplicateFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384672, XrefRangeEnd = 384683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetFileMetadataCount(
    GetFileMetadataCountOptions getFileMetadataCountOptions,
    out int outFileMetadataCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getFileMetadataCountOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outFileMetadataCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_Result_GetFileMetadataCountOptions_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384683, XrefRangeEnd = 384702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryFile(
    QueryFileOptions queryFileOptions,
    Il2CppSystem.Object clientData,
    OnQueryFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) queryFileOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_QueryFileOptions_Object_OnQueryFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384702, XrefRangeEnd = 384721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryFileList(
    QueryFileListOptions queryFileListOptions,
    Il2CppSystem.Object clientData,
    OnQueryFileListCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) queryFileListOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384721, XrefRangeEnd = 384749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerDataStorageFileTransferRequest ReadFile(
    ReadFileOptions readOptions,
    Il2CppSystem.Object clientData,
    OnReadFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) readOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_ReadFile_Public_PlayerDataStorageFileTransferRequest_ReadFileOptions_Object_OnReadFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PlayerDataStorageFileTransferRequest) null : Il2CppObjectPool.Get<PlayerDataStorageFileTransferRequest>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384749, XrefRangeEnd = 384777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerDataStorageFileTransferRequest WriteFile(
    WriteFileOptions writeOptions,
    Il2CppSystem.Object clientData,
    OnWriteFileCompleteCallback completionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writeOptions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_WriteFile_Public_PlayerDataStorageFileTransferRequest_WriteFileOptions_Object_OnWriteFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PlayerDataStorageFileTransferRequest) null : Il2CppObjectPool.Get<PlayerDataStorageFileTransferRequest>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384777, XrefRangeEnd = 384783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDeleteCacheCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384783, XrefRangeEnd = 384789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDeleteFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384789, XrefRangeEnd = 384795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDuplicateFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnDuplicateFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384795, XrefRangeEnd = 384806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnFileTransferProgressCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384806, XrefRangeEnd = 384812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384812, XrefRangeEnd = 384818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryFileListCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384818, XrefRangeEnd = 384824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnReadFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384824, XrefRangeEnd = 384836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ReadResult OnReadFileDataCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384836, XrefRangeEnd = 384842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnWriteFileCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384842, XrefRangeEnd = 384855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe WriteResult OnWriteFileDataCallbackInternalImplementation(
    System.IntPtr data,
    System.IntPtr outDataBuffer,
    ref uint outDataWritten)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outDataBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref outDataWritten;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileDataCallbackInternalImplementation_Internal_Static_WriteResult_IntPtr_IntPtr_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(WriteResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int CopyfilemetadataatindexoptionsApiLatest
  {
    get
    {
      int copyfilemetadataatindexoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &copyfilemetadataatindexoptionsApiLatest);
      return copyfilemetadataatindexoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyfilemetadatabyfilenameoptionsApiLatest
  {
    get
    {
      int copyfilemetadatabyfilenameoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &copyfilemetadatabyfilenameoptionsApiLatest);
      return copyfilemetadatabyfilenameoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletecacheoptionsApiLatest
  {
    get
    {
      int deletecacheoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &deletecacheoptionsApiLatest);
      return deletecacheoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletefileoptionsApiLatest
  {
    get
    {
      int deletefileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileoptionsApiLatest, (void*) &deletefileoptionsApiLatest);
      return deletefileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int DuplicatefileoptionsApiLatest
  {
    get
    {
      int duplicatefileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileoptionsApiLatest, (void*) &duplicatefileoptionsApiLatest);
      return duplicatefileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int FileMaxSizeBytes
  {
    get
    {
      int fileMaxSizeBytes;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FileMaxSizeBytes, (void*) &fileMaxSizeBytes);
      return fileMaxSizeBytes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FileMaxSizeBytes, (void*) &value);
    }
  }

  public static unsafe int FilemetadataApiLatest
  {
    get
    {
      int filemetadataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &filemetadataApiLatest);
      return filemetadataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &value);
    }
  }

  public static unsafe int FilenameMaxLengthBytes
  {
    get
    {
      int filenameMaxLengthBytes;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &filenameMaxLengthBytes);
      return filenameMaxLengthBytes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &value);
    }
  }

  public static unsafe int GetfilemetadatacountoptionsApiLatest
  {
    get
    {
      int getfilemetadatacountoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &getfilemetadatacountoptionsApiLatest);
      return getfilemetadatacountoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryfilelistoptionsApiLatest
  {
    get
    {
      int queryfilelistoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &queryfilelistoptionsApiLatest);
      return queryfilelistoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryfileoptionsApiLatest
  {
    get
    {
      int queryfileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &queryfileoptionsApiLatest);
      return queryfileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReadfileoptionsApiLatest
  {
    get
    {
      int readfileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &readfileoptionsApiLatest);
      return readfileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int WritefileoptionsApiLatest
  {
    get
    {
      int writefileoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileoptionsApiLatest, (void*) &writefileoptionsApiLatest);
      return writefileoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileoptionsApiLatest, (void*) &value);
    }
  }
}
