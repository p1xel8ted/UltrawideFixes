// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.AuthInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

public sealed class AuthInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyidtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyuserauthtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CredentialsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletepersistentauthApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_IdtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LinkaccountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LoginApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LogoutApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PingrantinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryidtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_TokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_VerifyidtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_VerifyuserauthApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyIdToken_Public_Result_CopyIdTokenOptions_byref_IdToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserAuthToken_Public_Result_CopyUserAuthTokenOptions_EpicAccountId_byref_Token_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeletePersistentAuth_Public_Void_DeletePersistentAuthOptions_Object_OnDeletePersistentAuthCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInAccountByIndex_Public_EpicAccountId_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInAccountsCount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedAccountByIndex_Public_EpicAccountId_EpicAccountId_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedAccountsCount_Public_UInt32_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedAccountId_Public_Result_EpicAccountId_byref_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LinkAccount_Public_Void_LinkAccountOptions_Object_OnLinkAccountCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Login_Public_Void_LoginOptions_Object_OnLoginCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Logout_Public_Void_LogoutOptions_Object_OnLogoutCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryIdToken_Public_Void_QueryIdTokenOptions_Object_OnQueryIdTokenCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIdToken_Public_Void_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VerifyUserAuth_Public_Void_VerifyUserAuthOptions_Object_OnVerifyUserAuthCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeletePersistentAuthCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLogoutCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnVerifyUserAuthCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static AuthInterface()
  {
    Il2CppClassPointerStore<AuthInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (AuthInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr);
    AuthInterface.NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (AccountfeaturerestrictedinfoApiLatest));
    AuthInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (AddnotifyloginstatuschangedApiLatest));
    AuthInterface.NativeFieldInfoPtr_CopyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (CopyidtokenApiLatest));
    AuthInterface.NativeFieldInfoPtr_CopyuserauthtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (CopyuserauthtokenApiLatest));
    AuthInterface.NativeFieldInfoPtr_CredentialsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (CredentialsApiLatest));
    AuthInterface.NativeFieldInfoPtr_DeletepersistentauthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (DeletepersistentauthApiLatest));
    AuthInterface.NativeFieldInfoPtr_IdtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (IdtokenApiLatest));
    AuthInterface.NativeFieldInfoPtr_LinkaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (LinkaccountApiLatest));
    AuthInterface.NativeFieldInfoPtr_LoginApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (LoginApiLatest));
    AuthInterface.NativeFieldInfoPtr_LogoutApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (LogoutApiLatest));
    AuthInterface.NativeFieldInfoPtr_PingrantinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (PingrantinfoApiLatest));
    AuthInterface.NativeFieldInfoPtr_QueryidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (QueryidtokenApiLatest));
    AuthInterface.NativeFieldInfoPtr_TokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (TokenApiLatest));
    AuthInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (VerifyidtokenApiLatest));
    AuthInterface.NativeFieldInfoPtr_VerifyuserauthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (VerifyuserauthApiLatest));
    AuthInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672012);
    AuthInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672014);
    AuthInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_CopyIdTokenOptions_byref_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672015);
    AuthInterface.NativeMethodInfoPtr_CopyUserAuthToken_Public_Result_CopyUserAuthTokenOptions_EpicAccountId_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672016);
    AuthInterface.NativeMethodInfoPtr_DeletePersistentAuth_Public_Void_DeletePersistentAuthOptions_Object_OnDeletePersistentAuthCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672017);
    AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountByIndex_Public_EpicAccountId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672018);
    AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672019);
    AuthInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672020);
    AuthInterface.NativeMethodInfoPtr_GetMergedAccountByIndex_Public_EpicAccountId_EpicAccountId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672021);
    AuthInterface.NativeMethodInfoPtr_GetMergedAccountsCount_Public_UInt32_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672022);
    AuthInterface.NativeMethodInfoPtr_GetSelectedAccountId_Public_Result_EpicAccountId_byref_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672023);
    AuthInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_LinkAccountOptions_Object_OnLinkAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672024);
    AuthInterface.NativeMethodInfoPtr_Login_Public_Void_LoginOptions_Object_OnLoginCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672025);
    AuthInterface.NativeMethodInfoPtr_Logout_Public_Void_LogoutOptions_Object_OnLogoutCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672026);
    AuthInterface.NativeMethodInfoPtr_QueryIdToken_Public_Void_QueryIdTokenOptions_Object_OnQueryIdTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672027);
    AuthInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672028);
    AuthInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672029);
    AuthInterface.NativeMethodInfoPtr_VerifyUserAuth_Public_Void_VerifyUserAuthOptions_Object_OnVerifyUserAuthCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672030);
    AuthInterface.NativeMethodInfoPtr_OnDeletePersistentAuthCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672031);
    AuthInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672032);
    AuthInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672033);
    AuthInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672034);
    AuthInterface.NativeMethodInfoPtr_OnLogoutCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672035);
    AuthInterface.NativeMethodInfoPtr_OnQueryIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672036);
    AuthInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672037);
    AuthInterface.NativeMethodInfoPtr_OnVerifyUserAuthCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100672038);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AuthInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398089, XrefRangeEnd = 398109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398109, XrefRangeEnd = 398121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_CopyIdTokenOptions_byref_IdToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref IdToken local = ref outIdToken;
    System.IntPtr pointer = zero;
    IdToken idToken = pointer == System.IntPtr.Zero ? (IdToken) null : new IdToken(pointer);
    local = idToken;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398121, XrefRangeEnd = 398134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyUserAuthToken(
    CopyUserAuthTokenOptions options,
    EpicAccountId localUserId,
    out Token outUserAuthToken)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_CopyUserAuthToken_Public_Result_CopyUserAuthTokenOptions_EpicAccountId_byref_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Token local = ref outUserAuthToken;
    System.IntPtr pointer = zero;
    Token token = pointer == System.IntPtr.Zero ? (Token) null : new Token(pointer);
    local = token;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398134, XrefRangeEnd = 398153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeletePersistentAuth(
    DeletePersistentAuthOptions options,
    Il2CppSystem.Object clientData,
    OnDeletePersistentAuthCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_DeletePersistentAuth_Public_Void_DeletePersistentAuthOptions_Object_OnDeletePersistentAuthCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398153, XrefRangeEnd = 398160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EpicAccountId GetLoggedInAccountByIndex(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountByIndex_Public_EpicAccountId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398160, XrefRangeEnd = 398161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetLoggedInAccountsCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398161, XrefRangeEnd = 398166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LoginStatus GetLoginStatus(EpicAccountId localUserId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LoginStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398166, XrefRangeEnd = 398174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EpicAccountId GetMergedAccountByIndex(EpicAccountId localUserId, uint index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetMergedAccountByIndex_Public_EpicAccountId_EpicAccountId_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398174, XrefRangeEnd = 398179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetMergedAccountsCount(EpicAccountId localUserId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetMergedAccountsCount_Public_UInt32_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398179, XrefRangeEnd = 398187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetSelectedAccountId(
    EpicAccountId localUserId,
    out EpicAccountId outSelectedAccountId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetSelectedAccountId_Public_Result_EpicAccountId_byref_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref EpicAccountId local = ref outSelectedAccountId;
    System.IntPtr pointer = zero;
    EpicAccountId epicAccountId = pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
    local = epicAccountId;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398187, XrefRangeEnd = 398206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_LinkAccountOptions_Object_OnLinkAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398206, XrefRangeEnd = 398225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_Login_Public_Void_LoginOptions_Object_OnLoginCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398225, XrefRangeEnd = 398244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Logout(
    LogoutOptions options,
    Il2CppSystem.Object clientData,
    OnLogoutCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_Logout_Public_Void_LogoutOptions_Object_OnLogoutCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398244, XrefRangeEnd = 398263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryIdToken(
    QueryIdTokenOptions options,
    Il2CppSystem.Object clientData,
    OnQueryIdTokenCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_QueryIdToken_Public_Void_QueryIdTokenOptions_Object_OnQueryIdTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398263, XrefRangeEnd = 398268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLoginStatusChanged(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398268, XrefRangeEnd = 398287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398287, XrefRangeEnd = 398306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VerifyUserAuth(
    VerifyUserAuthOptions options,
    Il2CppSystem.Object clientData,
    OnVerifyUserAuthCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_VerifyUserAuth_Public_Void_VerifyUserAuthOptions_Object_OnVerifyUserAuthCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398306, XrefRangeEnd = 398312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDeletePersistentAuthCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnDeletePersistentAuthCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398312, XrefRangeEnd = 398318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLinkAccountCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398318, XrefRangeEnd = 398324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLoginCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398324, XrefRangeEnd = 398330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLoginStatusChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398330, XrefRangeEnd = 398336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLogoutCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLogoutCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398336, XrefRangeEnd = 398342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryIdTokenCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnQueryIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398342, XrefRangeEnd = 398348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnVerifyIdTokenCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398348, XrefRangeEnd = 398354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnVerifyUserAuthCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnVerifyUserAuthCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AccountfeaturerestrictedinfoApiLatest
  {
    get
    {
      int accountfeaturerestrictedinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest, (void*) &accountfeaturerestrictedinfoApiLatest);
      return accountfeaturerestrictedinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyloginstatuschangedApiLatest
  {
    get
    {
      int addnotifyloginstatuschangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &addnotifyloginstatuschangedApiLatest);
      return addnotifyloginstatuschangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyidtokenApiLatest
  {
    get
    {
      int copyidtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &copyidtokenApiLatest);
      return copyidtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyuserauthtokenApiLatest
  {
    get
    {
      int copyuserauthtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_CopyuserauthtokenApiLatest, (void*) &copyuserauthtokenApiLatest);
      return copyuserauthtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_CopyuserauthtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int CredentialsApiLatest
  {
    get
    {
      int credentialsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &credentialsApiLatest);
      return credentialsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletepersistentauthApiLatest
  {
    get
    {
      int deletepersistentauthApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_DeletepersistentauthApiLatest, (void*) &deletepersistentauthApiLatest);
      return deletepersistentauthApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_DeletepersistentauthApiLatest, (void*) &value);
    }
  }

  public static unsafe int IdtokenApiLatest
  {
    get
    {
      int idtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &idtokenApiLatest);
      return idtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int LinkaccountApiLatest
  {
    get
    {
      int linkaccountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &linkaccountApiLatest);
      return linkaccountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LoginApiLatest
  {
    get
    {
      int loginApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &loginApiLatest);
      return loginApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &value);
    }
  }

  public static unsafe int LogoutApiLatest
  {
    get
    {
      int logoutApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_LogoutApiLatest, (void*) &logoutApiLatest);
      return logoutApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_LogoutApiLatest, (void*) &value);
    }
  }

  public static unsafe int PingrantinfoApiLatest
  {
    get
    {
      int pingrantinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_PingrantinfoApiLatest, (void*) &pingrantinfoApiLatest);
      return pingrantinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_PingrantinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryidtokenApiLatest
  {
    get
    {
      int queryidtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_QueryidtokenApiLatest, (void*) &queryidtokenApiLatest);
      return queryidtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_QueryidtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int TokenApiLatest
  {
    get
    {
      int tokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_TokenApiLatest, (void*) &tokenApiLatest);
      return tokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_TokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int VerifyidtokenApiLatest
  {
    get
    {
      int verifyidtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &verifyidtokenApiLatest);
      return verifyidtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int VerifyuserauthApiLatest
  {
    get
    {
      int verifyuserauthApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_VerifyuserauthApiLatest, (void*) &verifyuserauthApiLatest);
      return verifyuserauthApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_VerifyuserauthApiLatest, (void*) &value);
    }
  }
}
