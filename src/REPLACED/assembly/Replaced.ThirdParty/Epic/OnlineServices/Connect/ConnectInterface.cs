// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.ConnectInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

public sealed class ConnectInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyidtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatedeviceidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreateuserApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CredentialsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletedeviceidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExternalAccountIdMaxLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExternalaccountinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetexternalaccountmappingApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetproductuseridmappingApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_IdtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LinkaccountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LoginApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeUndefined;
  private static readonly System.IntPtr NativeFieldInfoPtr_TransferdeviceidaccountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnlinkaccountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UserlogininfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_VerifyidtokenApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAuthExpiration_Public_UInt64_AddNotifyAuthExpirationOptions_Object_OnAuthExpirationCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyIdToken_Public_Result_CopyIdTokenOptions_byref_IdToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountId_Public_Result_CopyProductUserExternalAccountByAccountIdOptions_byref_ExternalAccountInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountType_Public_Result_CopyProductUserExternalAccountByAccountTypeOptions_byref_ExternalAccountInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserExternalAccountByIndex_Public_Result_CopyProductUserExternalAccountByIndexOptions_byref_ExternalAccountInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserInfo_Public_Result_CopyProductUserInfoOptions_byref_ExternalAccountInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateDeviceId_Public_Void_CreateDeviceIdOptions_Object_OnCreateDeviceIdCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUser_Public_Void_CreateUserOptions_Object_OnCreateUserCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDeviceId_Public_Void_DeleteDeviceIdOptions_Object_OnDeleteDeviceIdCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalAccountMapping_Public_ProductUserId_GetExternalAccountMappingsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInUserByIndex_Public_ProductUserId_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInUsersCount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProductUserExternalAccountCount_Public_UInt32_GetProductUserExternalAccountCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProductUserIdMapping_Public_Result_GetProductUserIdMappingOptions_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LinkAccount_Public_Void_LinkAccountOptions_Object_OnLinkAccountCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Login_Public_Void_LoginOptions_Object_OnLoginCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryExternalAccountMappings_Public_Void_QueryExternalAccountMappingsOptions_Object_OnQueryExternalAccountMappingsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryProductUserIdMappings_Public_Void_QueryProductUserIdMappingsOptions_Object_OnQueryProductUserIdMappingsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAuthExpiration_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransferDeviceIdAccount_Public_Void_TransferDeviceIdAccountOptions_Object_OnTransferDeviceIdAccountCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnlinkAccount_Public_Void_UnlinkAccountOptions_Object_OnUnlinkAccountCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIdToken_Public_Void_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAuthExpirationCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDeviceIdCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteDeviceIdCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryExternalAccountMappingsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryProductUserIdMappingsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransferDeviceIdAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUnlinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static ConnectInterface()
  {
    Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (ConnectInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr);
    ConnectInterface.NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (AddnotifyauthexpirationApiLatest));
    ConnectInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (AddnotifyloginstatuschangedApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CopyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyidtokenApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserexternalaccountbyaccountidApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserexternalaccountbyaccounttypeApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserexternalaccountbyindexApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CopyproductuserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserinfoApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CreatedeviceidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CreatedeviceidApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CreatedeviceidDevicemodelMaxLength));
    ConnectInterface.NativeFieldInfoPtr_CreateuserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CreateuserApiLatest));
    ConnectInterface.NativeFieldInfoPtr_CredentialsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CredentialsApiLatest));
    ConnectInterface.NativeFieldInfoPtr_DeletedeviceidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (DeletedeviceidApiLatest));
    ConnectInterface.NativeFieldInfoPtr_ExternalAccountIdMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (ExternalAccountIdMaxLength));
    ConnectInterface.NativeFieldInfoPtr_ExternalaccountinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (ExternalaccountinfoApiLatest));
    ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetexternalaccountmappingApiLatest));
    ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetexternalaccountmappingsApiLatest));
    ConnectInterface.NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetproductuserexternalaccountcountApiLatest));
    ConnectInterface.NativeFieldInfoPtr_GetproductuseridmappingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetproductuseridmappingApiLatest));
    ConnectInterface.NativeFieldInfoPtr_IdtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (IdtokenApiLatest));
    ConnectInterface.NativeFieldInfoPtr_LinkaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (LinkaccountApiLatest));
    ConnectInterface.NativeFieldInfoPtr_LoginApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (LoginApiLatest));
    ConnectInterface.NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (OnauthexpirationcallbackApiLatest));
    ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (QueryexternalaccountmappingsApiLatest));
    ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (QueryexternalaccountmappingsMaxAccountIds));
    ConnectInterface.NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (QueryproductuseridmappingsApiLatest));
    ConnectInterface.NativeFieldInfoPtr_TimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (TimeUndefined));
    ConnectInterface.NativeFieldInfoPtr_TransferdeviceidaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (TransferdeviceidaccountApiLatest));
    ConnectInterface.NativeFieldInfoPtr_UnlinkaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (UnlinkaccountApiLatest));
    ConnectInterface.NativeFieldInfoPtr_UserlogininfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (UserlogininfoApiLatest));
    ConnectInterface.NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (UserlogininfoDisplaynameMaxLength));
    ConnectInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (VerifyidtokenApiLatest));
    ConnectInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671450);
    ConnectInterface.NativeMethodInfoPtr_AddNotifyAuthExpiration_Public_UInt64_AddNotifyAuthExpirationOptions_Object_OnAuthExpirationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671452);
    ConnectInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671453);
    ConnectInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_CopyIdTokenOptions_byref_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671454);
    ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountId_Public_Result_CopyProductUserExternalAccountByAccountIdOptions_byref_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671455);
    ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountType_Public_Result_CopyProductUserExternalAccountByAccountTypeOptions_byref_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671456);
    ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByIndex_Public_Result_CopyProductUserExternalAccountByIndexOptions_byref_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671457);
    ConnectInterface.NativeMethodInfoPtr_CopyProductUserInfo_Public_Result_CopyProductUserInfoOptions_byref_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671458);
    ConnectInterface.NativeMethodInfoPtr_CreateDeviceId_Public_Void_CreateDeviceIdOptions_Object_OnCreateDeviceIdCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671459);
    ConnectInterface.NativeMethodInfoPtr_CreateUser_Public_Void_CreateUserOptions_Object_OnCreateUserCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671460);
    ConnectInterface.NativeMethodInfoPtr_DeleteDeviceId_Public_Void_DeleteDeviceIdOptions_Object_OnDeleteDeviceIdCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671461);
    ConnectInterface.NativeMethodInfoPtr_GetExternalAccountMapping_Public_ProductUserId_GetExternalAccountMappingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671462);
    ConnectInterface.NativeMethodInfoPtr_GetLoggedInUserByIndex_Public_ProductUserId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671463);
    ConnectInterface.NativeMethodInfoPtr_GetLoggedInUsersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671464);
    ConnectInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671465);
    ConnectInterface.NativeMethodInfoPtr_GetProductUserExternalAccountCount_Public_UInt32_GetProductUserExternalAccountCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671466);
    ConnectInterface.NativeMethodInfoPtr_GetProductUserIdMapping_Public_Result_GetProductUserIdMappingOptions_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671467);
    ConnectInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_LinkAccountOptions_Object_OnLinkAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671468);
    ConnectInterface.NativeMethodInfoPtr_Login_Public_Void_LoginOptions_Object_OnLoginCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671469);
    ConnectInterface.NativeMethodInfoPtr_QueryExternalAccountMappings_Public_Void_QueryExternalAccountMappingsOptions_Object_OnQueryExternalAccountMappingsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671470);
    ConnectInterface.NativeMethodInfoPtr_QueryProductUserIdMappings_Public_Void_QueryProductUserIdMappingsOptions_Object_OnQueryProductUserIdMappingsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671471);
    ConnectInterface.NativeMethodInfoPtr_RemoveNotifyAuthExpiration_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671472);
    ConnectInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671473);
    ConnectInterface.NativeMethodInfoPtr_TransferDeviceIdAccount_Public_Void_TransferDeviceIdAccountOptions_Object_OnTransferDeviceIdAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671474);
    ConnectInterface.NativeMethodInfoPtr_UnlinkAccount_Public_Void_UnlinkAccountOptions_Object_OnUnlinkAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671475);
    ConnectInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671476);
    ConnectInterface.NativeMethodInfoPtr_OnAuthExpirationCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671477);
    ConnectInterface.NativeMethodInfoPtr_OnCreateDeviceIdCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671478);
    ConnectInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671479);
    ConnectInterface.NativeMethodInfoPtr_OnDeleteDeviceIdCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671480);
    ConnectInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671481);
    ConnectInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671482);
    ConnectInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671483);
    ConnectInterface.NativeMethodInfoPtr_OnQueryExternalAccountMappingsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671484);
    ConnectInterface.NativeMethodInfoPtr_OnQueryProductUserIdMappingsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671485);
    ConnectInterface.NativeMethodInfoPtr_OnTransferDeviceIdAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671486);
    ConnectInterface.NativeMethodInfoPtr_OnUnlinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671487);
    ConnectInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100671488 /*0x06002000*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ConnectInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396350, XrefRangeEnd = 396369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAuthExpiration(
    AddNotifyAuthExpirationOptions options,
    Il2CppSystem.Object clientData,
    OnAuthExpirationCallback notification)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_AddNotifyAuthExpiration_Public_UInt64_AddNotifyAuthExpirationOptions_Object_OnAuthExpirationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396369, XrefRangeEnd = 396388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyLoginStatusChanged(
    AddNotifyLoginStatusChangedOptions options,
    Il2CppSystem.Object clientData,
    OnLoginStatusChangedCallback notification)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396388, XrefRangeEnd = 396400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyIdToken(CopyIdTokenOptions options, out IdToken outIdToken)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_CopyIdTokenOptions_byref_IdToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref IdToken local = ref outIdToken;
    System.IntPtr pointer = zero;
    IdToken idToken = pointer == System.IntPtr.Zero ? (IdToken) null : new IdToken(pointer);
    local = idToken;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396400, XrefRangeEnd = 396412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyProductUserExternalAccountByAccountId(
    CopyProductUserExternalAccountByAccountIdOptions options,
    out ExternalAccountInfo outExternalAccountInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountId_Public_Result_CopyProductUserExternalAccountByAccountIdOptions_byref_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalAccountInfo local = ref outExternalAccountInfo;
    System.IntPtr pointer = zero;
    ExternalAccountInfo externalAccountInfo = pointer == System.IntPtr.Zero ? (ExternalAccountInfo) null : new ExternalAccountInfo(pointer);
    local = externalAccountInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396412, XrefRangeEnd = 396424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyProductUserExternalAccountByAccountType(
    CopyProductUserExternalAccountByAccountTypeOptions options,
    out ExternalAccountInfo outExternalAccountInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountType_Public_Result_CopyProductUserExternalAccountByAccountTypeOptions_byref_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalAccountInfo local = ref outExternalAccountInfo;
    System.IntPtr pointer = zero;
    ExternalAccountInfo externalAccountInfo = pointer == System.IntPtr.Zero ? (ExternalAccountInfo) null : new ExternalAccountInfo(pointer);
    local = externalAccountInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396424, XrefRangeEnd = 396436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyProductUserExternalAccountByIndex(
    CopyProductUserExternalAccountByIndexOptions options,
    out ExternalAccountInfo outExternalAccountInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByIndex_Public_Result_CopyProductUserExternalAccountByIndexOptions_byref_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalAccountInfo local = ref outExternalAccountInfo;
    System.IntPtr pointer = zero;
    ExternalAccountInfo externalAccountInfo = pointer == System.IntPtr.Zero ? (ExternalAccountInfo) null : new ExternalAccountInfo(pointer);
    local = externalAccountInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396436, XrefRangeEnd = 396448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyProductUserInfo(
    CopyProductUserInfoOptions options,
    out ExternalAccountInfo outExternalAccountInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserInfo_Public_Result_CopyProductUserInfoOptions_byref_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalAccountInfo local = ref outExternalAccountInfo;
    System.IntPtr pointer = zero;
    ExternalAccountInfo externalAccountInfo = pointer == System.IntPtr.Zero ? (ExternalAccountInfo) null : new ExternalAccountInfo(pointer);
    local = externalAccountInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396448, XrefRangeEnd = 396466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateDeviceId(
    CreateDeviceIdOptions options,
    Il2CppSystem.Object clientData,
    OnCreateDeviceIdCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CreateDeviceId_Public_Void_CreateDeviceIdOptions_Object_OnCreateDeviceIdCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396466, XrefRangeEnd = 396484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CreateUser_Public_Void_CreateUserOptions_Object_OnCreateUserCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396484, XrefRangeEnd = 396502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeleteDeviceId(
    DeleteDeviceIdOptions options,
    Il2CppSystem.Object clientData,
    OnDeleteDeviceIdCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_DeleteDeviceId_Public_Void_DeleteDeviceIdOptions_Object_OnDeleteDeviceIdCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396502, XrefRangeEnd = 396513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProductUserId GetExternalAccountMapping(GetExternalAccountMappingsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetExternalAccountMapping_Public_ProductUserId_GetExternalAccountMappingsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396513, XrefRangeEnd = 396520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProductUserId GetLoggedInUserByIndex(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetLoggedInUserByIndex_Public_ProductUserId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396520, XrefRangeEnd = 396521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetLoggedInUsersCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetLoggedInUsersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396521, XrefRangeEnd = 396526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LoginStatus GetLoginStatus(ProductUserId localUserId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LoginStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396526, XrefRangeEnd = 396534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetProductUserExternalAccountCount(
    GetProductUserExternalAccountCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetProductUserExternalAccountCount_Public_UInt32_GetProductUserExternalAccountCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396534, XrefRangeEnd = 396545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetProductUserIdMapping(
    GetProductUserIdMappingOptions options,
    out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetProductUserIdMapping_Public_Result_GetProductUserIdMappingOptions_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396545, XrefRangeEnd = 396563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LinkAccount(
    LinkAccountOptions options,
    Il2CppSystem.Object clientData,
    OnLinkAccountCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_LinkAccountOptions_Object_OnLinkAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396563, XrefRangeEnd = 396581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Login(
    LoginOptions options,
    Il2CppSystem.Object clientData,
    OnLoginCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_Login_Public_Void_LoginOptions_Object_OnLoginCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396581, XrefRangeEnd = 396599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryExternalAccountMappings(
    QueryExternalAccountMappingsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryExternalAccountMappingsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_QueryExternalAccountMappings_Public_Void_QueryExternalAccountMappingsOptions_Object_OnQueryExternalAccountMappingsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396599, XrefRangeEnd = 396617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryProductUserIdMappings(
    QueryProductUserIdMappingsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryProductUserIdMappingsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_QueryProductUserIdMappings_Public_Void_QueryProductUserIdMappingsOptions_Object_OnQueryProductUserIdMappingsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396617, XrefRangeEnd = 396622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAuthExpiration(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_RemoveNotifyAuthExpiration_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396622, XrefRangeEnd = 396627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLoginStatusChanged(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396627, XrefRangeEnd = 396645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransferDeviceIdAccount(
    TransferDeviceIdAccountOptions options,
    Il2CppSystem.Object clientData,
    OnTransferDeviceIdAccountCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_TransferDeviceIdAccount_Public_Void_TransferDeviceIdAccountOptions_Object_OnTransferDeviceIdAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396645, XrefRangeEnd = 396663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnlinkAccount(
    UnlinkAccountOptions options,
    Il2CppSystem.Object clientData,
    OnUnlinkAccountCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_UnlinkAccount_Public_Void_UnlinkAccountOptions_Object_OnUnlinkAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396663, XrefRangeEnd = 396681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VerifyIdToken(
    VerifyIdTokenOptions options,
    Il2CppSystem.Object clientData,
    OnVerifyIdTokenCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396681, XrefRangeEnd = 396687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAuthExpirationCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnAuthExpirationCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396687, XrefRangeEnd = 396693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCreateDeviceIdCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnCreateDeviceIdCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396693, XrefRangeEnd = 396699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCreateUserCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396699, XrefRangeEnd = 396705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDeleteDeviceIdCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnDeleteDeviceIdCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396705, XrefRangeEnd = 396711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLinkAccountCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396711, XrefRangeEnd = 396717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLoginCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396717, XrefRangeEnd = 396723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLoginStatusChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396723, XrefRangeEnd = 396729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryExternalAccountMappingsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnQueryExternalAccountMappingsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396729, XrefRangeEnd = 396735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryProductUserIdMappingsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnQueryProductUserIdMappingsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396735, XrefRangeEnd = 396741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnTransferDeviceIdAccountCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnTransferDeviceIdAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396741, XrefRangeEnd = 396747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUnlinkAccountCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnUnlinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396747, XrefRangeEnd = 396753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnVerifyIdTokenCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifyauthexpirationApiLatest
  {
    get
    {
      int addnotifyauthexpirationApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest, (void*) &addnotifyauthexpirationApiLatest);
      return addnotifyauthexpirationApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyloginstatuschangedApiLatest
  {
    get
    {
      int addnotifyloginstatuschangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &addnotifyloginstatuschangedApiLatest);
      return addnotifyloginstatuschangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyidtokenApiLatest
  {
    get
    {
      int copyidtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &copyidtokenApiLatest);
      return copyidtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyproductuserexternalaccountbyaccountidApiLatest
  {
    get
    {
      int copyproductuserexternalaccountbyaccountidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest, (void*) &copyproductuserexternalaccountbyaccountidApiLatest);
      return copyproductuserexternalaccountbyaccountidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyproductuserexternalaccountbyaccounttypeApiLatest
  {
    get
    {
      int copyproductuserexternalaccountbyaccounttypeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest, (void*) &copyproductuserexternalaccountbyaccounttypeApiLatest);
      return copyproductuserexternalaccountbyaccounttypeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyproductuserexternalaccountbyindexApiLatest
  {
    get
    {
      int copyproductuserexternalaccountbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest, (void*) &copyproductuserexternalaccountbyindexApiLatest);
      return copyproductuserexternalaccountbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyproductuserinfoApiLatest
  {
    get
    {
      int copyproductuserinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserinfoApiLatest, (void*) &copyproductuserinfoApiLatest);
      return copyproductuserinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatedeviceidApiLatest
  {
    get
    {
      int createdeviceidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidApiLatest, (void*) &createdeviceidApiLatest);
      return createdeviceidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatedeviceidDevicemodelMaxLength
  {
    get
    {
      int devicemodelMaxLength;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength, (void*) &devicemodelMaxLength);
      return devicemodelMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength, (void*) &value);
    }
  }

  public static unsafe int CreateuserApiLatest
  {
    get
    {
      int createuserApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &createuserApiLatest);
      return createuserApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &value);
    }
  }

  public static unsafe int CredentialsApiLatest
  {
    get
    {
      int credentialsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &credentialsApiLatest);
      return credentialsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletedeviceidApiLatest
  {
    get
    {
      int deletedeviceidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_DeletedeviceidApiLatest, (void*) &deletedeviceidApiLatest);
      return deletedeviceidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_DeletedeviceidApiLatest, (void*) &value);
    }
  }

  public static unsafe int ExternalAccountIdMaxLength
  {
    get
    {
      int accountIdMaxLength;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_ExternalAccountIdMaxLength, (void*) &accountIdMaxLength);
      return accountIdMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_ExternalAccountIdMaxLength, (void*) &value);
    }
  }

  public static unsafe int ExternalaccountinfoApiLatest
  {
    get
    {
      int externalaccountinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_ExternalaccountinfoApiLatest, (void*) &externalaccountinfoApiLatest);
      return externalaccountinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_ExternalaccountinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetexternalaccountmappingApiLatest
  {
    get
    {
      int getexternalaccountmappingApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingApiLatest, (void*) &getexternalaccountmappingApiLatest);
      return getexternalaccountmappingApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetexternalaccountmappingsApiLatest
  {
    get
    {
      int getexternalaccountmappingsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest, (void*) &getexternalaccountmappingsApiLatest);
      return getexternalaccountmappingsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetproductuserexternalaccountcountApiLatest
  {
    get
    {
      int getproductuserexternalaccountcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest, (void*) &getproductuserexternalaccountcountApiLatest);
      return getproductuserexternalaccountcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetproductuseridmappingApiLatest
  {
    get
    {
      int getproductuseridmappingApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetproductuseridmappingApiLatest, (void*) &getproductuseridmappingApiLatest);
      return getproductuseridmappingApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetproductuseridmappingApiLatest, (void*) &value);
    }
  }

  public static unsafe int IdtokenApiLatest
  {
    get
    {
      int idtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &idtokenApiLatest);
      return idtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int LinkaccountApiLatest
  {
    get
    {
      int linkaccountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &linkaccountApiLatest);
      return linkaccountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LoginApiLatest
  {
    get
    {
      int loginApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &loginApiLatest);
      return loginApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &value);
    }
  }

  public static unsafe int OnauthexpirationcallbackApiLatest
  {
    get
    {
      int onauthexpirationcallbackApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest, (void*) &onauthexpirationcallbackApiLatest);
      return onauthexpirationcallbackApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryexternalaccountmappingsApiLatest
  {
    get
    {
      int queryexternalaccountmappingsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest, (void*) &queryexternalaccountmappingsApiLatest);
      return queryexternalaccountmappingsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryexternalaccountmappingsMaxAccountIds
  {
    get
    {
      int queryexternalaccountmappingsMaxAccountIds;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds, (void*) &queryexternalaccountmappingsMaxAccountIds);
      return queryexternalaccountmappingsMaxAccountIds;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds, (void*) &value);
    }
  }

  public static unsafe int QueryproductuseridmappingsApiLatest
  {
    get
    {
      int queryproductuseridmappingsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest, (void*) &queryproductuseridmappingsApiLatest);
      return queryproductuseridmappingsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest, (void*) &value);
    }
  }

  public static unsafe int TimeUndefined
  {
    get
    {
      int timeUndefined;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &timeUndefined);
      return timeUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &value);
    }
  }

  public static unsafe int TransferdeviceidaccountApiLatest
  {
    get
    {
      int transferdeviceidaccountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_TransferdeviceidaccountApiLatest, (void*) &transferdeviceidaccountApiLatest);
      return transferdeviceidaccountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_TransferdeviceidaccountApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnlinkaccountApiLatest
  {
    get
    {
      int unlinkaccountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_UnlinkaccountApiLatest, (void*) &unlinkaccountApiLatest);
      return unlinkaccountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_UnlinkaccountApiLatest, (void*) &value);
    }
  }

  public static unsafe int UserlogininfoApiLatest
  {
    get
    {
      int userlogininfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoApiLatest, (void*) &userlogininfoApiLatest);
      return userlogininfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int UserlogininfoDisplaynameMaxLength
  {
    get
    {
      int displaynameMaxLength;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength, (void*) &displaynameMaxLength);
      return displaynameMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength, (void*) &value);
    }
  }

  public static unsafe int VerifyidtokenApiLatest
  {
    get
    {
      int verifyidtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &verifyidtokenApiLatest);
      return verifyidtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &value);
    }
  }
}
