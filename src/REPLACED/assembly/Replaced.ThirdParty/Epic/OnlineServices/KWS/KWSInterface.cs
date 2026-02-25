// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.KWS.KWSInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.KWS;

public sealed class KWSInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopypermissionbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreateuserApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetpermissionbykeyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetpermissionscountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxPermissionLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxPermissions;
  private static readonly System.IntPtr NativeFieldInfoPtr_PermissionstatusApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryagegateApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QuerypermissionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RequestpermissionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdateparentemailApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPermissionsUpdateReceived_Public_UInt64_AddNotifyPermissionsUpdateReceivedOptions_Object_OnPermissionsUpdateReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPermissionByIndex_Public_Result_CopyPermissionByIndexOptions_byref_PermissionStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUser_Public_Void_CreateUserOptions_Object_OnCreateUserCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPermissionByKey_Public_Result_GetPermissionByKeyOptions_byref_KWSPermissionStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPermissionsCount_Public_Int32_GetPermissionsCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryAgeGate_Public_Void_QueryAgeGateOptions_Object_OnQueryAgeGateCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryPermissions_Public_Void_QueryPermissionsOptions_Object_OnQueryPermissionsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPermissionsUpdateReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequestPermissions_Public_Void_RequestPermissionsOptions_Object_OnRequestPermissionsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParentEmail_Public_Void_UpdateParentEmailOptions_Object_OnUpdateParentEmailCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPermissionsUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryAgeGateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryPermissionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRequestPermissionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateParentEmailCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static KWSInterface()
  {
    Il2CppClassPointerStore<KWSInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.KWS", nameof (KWSInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr);
    KWSInterface.NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (AddnotifypermissionsupdatereceivedApiLatest));
    KWSInterface.NativeFieldInfoPtr_CopypermissionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (CopypermissionbyindexApiLatest));
    KWSInterface.NativeFieldInfoPtr_CreateuserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (CreateuserApiLatest));
    KWSInterface.NativeFieldInfoPtr_GetpermissionbykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (GetpermissionbykeyApiLatest));
    KWSInterface.NativeFieldInfoPtr_GetpermissionscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (GetpermissionscountApiLatest));
    KWSInterface.NativeFieldInfoPtr_MaxPermissionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (MaxPermissionLength));
    KWSInterface.NativeFieldInfoPtr_MaxPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (MaxPermissions));
    KWSInterface.NativeFieldInfoPtr_PermissionstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (PermissionstatusApiLatest));
    KWSInterface.NativeFieldInfoPtr_QueryagegateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (QueryagegateApiLatest));
    KWSInterface.NativeFieldInfoPtr_QuerypermissionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (QuerypermissionsApiLatest));
    KWSInterface.NativeFieldInfoPtr_RequestpermissionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (RequestpermissionsApiLatest));
    KWSInterface.NativeFieldInfoPtr_UpdateparentemailApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (UpdateparentemailApiLatest));
    KWSInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670203);
    KWSInterface.NativeMethodInfoPtr_AddNotifyPermissionsUpdateReceived_Public_UInt64_AddNotifyPermissionsUpdateReceivedOptions_Object_OnPermissionsUpdateReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670205);
    KWSInterface.NativeMethodInfoPtr_CopyPermissionByIndex_Public_Result_CopyPermissionByIndexOptions_byref_PermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670206);
    KWSInterface.NativeMethodInfoPtr_CreateUser_Public_Void_CreateUserOptions_Object_OnCreateUserCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670207);
    KWSInterface.NativeMethodInfoPtr_GetPermissionByKey_Public_Result_GetPermissionByKeyOptions_byref_KWSPermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670208 /*0x06001B00*/);
    KWSInterface.NativeMethodInfoPtr_GetPermissionsCount_Public_Int32_GetPermissionsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670209);
    KWSInterface.NativeMethodInfoPtr_QueryAgeGate_Public_Void_QueryAgeGateOptions_Object_OnQueryAgeGateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670210);
    KWSInterface.NativeMethodInfoPtr_QueryPermissions_Public_Void_QueryPermissionsOptions_Object_OnQueryPermissionsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670211);
    KWSInterface.NativeMethodInfoPtr_RemoveNotifyPermissionsUpdateReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670212);
    KWSInterface.NativeMethodInfoPtr_RequestPermissions_Public_Void_RequestPermissionsOptions_Object_OnRequestPermissionsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670213);
    KWSInterface.NativeMethodInfoPtr_UpdateParentEmail_Public_Void_UpdateParentEmailOptions_Object_OnUpdateParentEmailCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670214);
    KWSInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670215);
    KWSInterface.NativeMethodInfoPtr_OnPermissionsUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670216);
    KWSInterface.NativeMethodInfoPtr_OnQueryAgeGateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670217);
    KWSInterface.NativeMethodInfoPtr_OnQueryPermissionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670218);
    KWSInterface.NativeMethodInfoPtr_OnRequestPermissionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670219);
    KWSInterface.NativeMethodInfoPtr_OnUpdateParentEmailCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100670220);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe KWSInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392492, XrefRangeEnd = 392512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyPermissionsUpdateReceived(
    AddNotifyPermissionsUpdateReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnPermissionsUpdateReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_AddNotifyPermissionsUpdateReceived_Public_UInt64_AddNotifyPermissionsUpdateReceivedOptions_Object_OnPermissionsUpdateReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392512, XrefRangeEnd = 392524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyPermissionByIndex(
    CopyPermissionByIndexOptions options,
    out PermissionStatus outPermission)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_CopyPermissionByIndex_Public_Result_CopyPermissionByIndexOptions_byref_PermissionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PermissionStatus local = ref outPermission;
    System.IntPtr pointer = zero;
    PermissionStatus permissionStatus = pointer == System.IntPtr.Zero ? (PermissionStatus) null : new PermissionStatus(pointer);
    local = permissionStatus;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392524, XrefRangeEnd = 392543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateUser(
    CreateUserOptions options,
    Il2CppSystem.Object clientData,
    OnCreateUserCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_CreateUser_Public_Void_CreateUserOptions_Object_OnCreateUserCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392543, XrefRangeEnd = 392554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetPermissionByKey(
    GetPermissionByKeyOptions options,
    out KWSPermissionStatus outPermission)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPermission;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_GetPermissionByKey_Public_Result_GetPermissionByKeyOptions_byref_KWSPermissionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392554, XrefRangeEnd = 392562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPermissionsCount(GetPermissionsCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_GetPermissionsCount_Public_Int32_GetPermissionsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392562, XrefRangeEnd = 392581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryAgeGate(
    QueryAgeGateOptions options,
    Il2CppSystem.Object clientData,
    OnQueryAgeGateCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_QueryAgeGate_Public_Void_QueryAgeGateOptions_Object_OnQueryAgeGateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392581, XrefRangeEnd = 392600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryPermissions(
    QueryPermissionsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryPermissionsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_QueryPermissions_Public_Void_QueryPermissionsOptions_Object_OnQueryPermissionsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392600, XrefRangeEnd = 392605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyPermissionsUpdateReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_RemoveNotifyPermissionsUpdateReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392605, XrefRangeEnd = 392624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RequestPermissions(
    RequestPermissionsOptions options,
    Il2CppSystem.Object clientData,
    OnRequestPermissionsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_RequestPermissions_Public_Void_RequestPermissionsOptions_Object_OnRequestPermissionsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392624, XrefRangeEnd = 392643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParentEmail(
    UpdateParentEmailOptions options,
    Il2CppSystem.Object clientData,
    OnUpdateParentEmailCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_UpdateParentEmail_Public_Void_UpdateParentEmailOptions_Object_OnUpdateParentEmailCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392643, XrefRangeEnd = 392649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCreateUserCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392649, XrefRangeEnd = 392655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnPermissionsUpdateReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnPermissionsUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392655, XrefRangeEnd = 392661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryAgeGateCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnQueryAgeGateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392661, XrefRangeEnd = 392667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryPermissionsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnQueryPermissionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392667, XrefRangeEnd = 392673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRequestPermissionsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnRequestPermissionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392673, XrefRangeEnd = 392679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdateParentEmailCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnUpdateParentEmailCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifypermissionsupdatereceivedApiLatest
  {
    get
    {
      int addnotifypermissionsupdatereceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest, (void*) &addnotifypermissionsupdatereceivedApiLatest);
      return addnotifypermissionsupdatereceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopypermissionbyindexApiLatest
  {
    get
    {
      int copypermissionbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_CopypermissionbyindexApiLatest, (void*) &copypermissionbyindexApiLatest);
      return copypermissionbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_CopypermissionbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreateuserApiLatest
  {
    get
    {
      int createuserApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &createuserApiLatest);
      return createuserApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetpermissionbykeyApiLatest
  {
    get
    {
      int getpermissionbykeyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_GetpermissionbykeyApiLatest, (void*) &getpermissionbykeyApiLatest);
      return getpermissionbykeyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_GetpermissionbykeyApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetpermissionscountApiLatest
  {
    get
    {
      int getpermissionscountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_GetpermissionscountApiLatest, (void*) &getpermissionscountApiLatest);
      return getpermissionscountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_GetpermissionscountApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxPermissionLength
  {
    get
    {
      int permissionLength;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_MaxPermissionLength, (void*) &permissionLength);
      return permissionLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_MaxPermissionLength, (void*) &value);
    }
  }

  public static unsafe int MaxPermissions
  {
    get
    {
      int maxPermissions;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_MaxPermissions, (void*) &maxPermissions);
      return maxPermissions;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_MaxPermissions, (void*) &value);
    }
  }

  public static unsafe int PermissionstatusApiLatest
  {
    get
    {
      int permissionstatusApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_PermissionstatusApiLatest, (void*) &permissionstatusApiLatest);
      return permissionstatusApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_PermissionstatusApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryagegateApiLatest
  {
    get
    {
      int queryagegateApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_QueryagegateApiLatest, (void*) &queryagegateApiLatest);
      return queryagegateApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_QueryagegateApiLatest, (void*) &value);
    }
  }

  public static unsafe int QuerypermissionsApiLatest
  {
    get
    {
      int querypermissionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_QuerypermissionsApiLatest, (void*) &querypermissionsApiLatest);
      return querypermissionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_QuerypermissionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int RequestpermissionsApiLatest
  {
    get
    {
      int requestpermissionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_RequestpermissionsApiLatest, (void*) &requestpermissionsApiLatest);
      return requestpermissionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_RequestpermissionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdateparentemailApiLatest
  {
    get
    {
      int updateparentemailApiLatest;
      IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_UpdateparentemailApiLatest, (void*) &updateparentemailApiLatest);
      return updateparentemailApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_UpdateparentemailApiLatest, (void*) &value);
    }
  }
}
