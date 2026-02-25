// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public sealed class SessionsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AttributedataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyactivesessionhandleApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatesessionmodificationApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatesessionsearchApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DestroysessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DumpsessionstateApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetinvitecountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetinviteidbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_InviteidMaxLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsuserinsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_JoinsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxSearchResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_Maxregisteredplayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryinvitesApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RegisterplayersApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RejectinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchBucketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchEmptyServersOnly;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchMinslotsavailable;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchNonemptyServersOnly;
  private static readonly System.IntPtr NativeFieldInfoPtr_SendinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionattributeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionattributedataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterplayersApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesessionmodificationApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyJoinSessionAccepted_Public_UInt64_AddNotifyJoinSessionAcceptedOptions_Object_OnJoinSessionAcceptedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifySessionInviteAccepted_Public_UInt64_AddNotifySessionInviteAcceptedOptions_Object_OnSessionInviteAcceptedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifySessionInviteReceived_Public_UInt64_AddNotifySessionInviteReceivedOptions_Object_OnSessionInviteReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyActiveSessionHandle_Public_Result_CopyActiveSessionHandleOptions_byref_ActiveSession_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionHandleByInviteId_Public_Result_CopySessionHandleByInviteIdOptions_byref_SessionDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionHandleByUiEventId_Public_Result_CopySessionHandleByUiEventIdOptions_byref_SessionDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionHandleForPresence_Public_Result_CopySessionHandleForPresenceOptions_byref_SessionDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionModification_Public_Result_CreateSessionModificationOptions_byref_SessionModification_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionSearch_Public_Result_CreateSessionSearchOptions_byref_SessionSearch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroySession_Public_Void_DestroySessionOptions_Object_OnDestroySessionCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DumpSessionState_Public_Result_DumpSessionStateOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndSession_Public_Void_EndSessionOptions_Object_OnEndSessionCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteCount_Public_UInt32_GetInviteCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_GetInviteIdByIndexOptions_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsUserInSession_Public_Result_IsUserInSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoinSession_Public_Void_JoinSessionOptions_Object_OnJoinSessionCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryInvites_Public_Void_QueryInvitesOptions_Object_OnQueryInvitesCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPlayers_Public_Void_RegisterPlayersOptions_Object_OnRegisterPlayersCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyJoinSessionAccepted_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifySessionInviteAccepted_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifySessionInviteReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartSession_Public_Void_StartSessionOptions_Object_OnStartSessionCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPlayers_Public_Void_UnregisterPlayersOptions_Object_OnUnregisterPlayersCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSession_Public_Void_UpdateSessionOptions_Object_OnUpdateSessionCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSessionModification_Public_Result_UpdateSessionModificationOptions_byref_SessionModification_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroySessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEndSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinSessionAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRegisterPlayersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSessionInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSessionInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStartSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUnregisterPlayersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static SessionsInterface()
  {
    Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr);
    SessionsInterface.NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AddnotifyjoinsessionacceptedApiLatest));
    SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AddnotifysessioninviteacceptedApiLatest));
    SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AddnotifysessioninvitereceivedApiLatest));
    SessionsInterface.NativeFieldInfoPtr_AttributedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (AttributedataApiLatest));
    SessionsInterface.NativeFieldInfoPtr_CopyactivesessionhandleApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopyactivesessionhandleApiLatest));
    SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopysessionhandlebyinviteidApiLatest));
    SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopysessionhandlebyuieventidApiLatest));
    SessionsInterface.NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CopysessionhandleforpresenceApiLatest));
    SessionsInterface.NativeFieldInfoPtr_CreatesessionmodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CreatesessionmodificationApiLatest));
    SessionsInterface.NativeFieldInfoPtr_CreatesessionsearchApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (CreatesessionsearchApiLatest));
    SessionsInterface.NativeFieldInfoPtr_DestroysessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (DestroysessionApiLatest));
    SessionsInterface.NativeFieldInfoPtr_DumpsessionstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (DumpsessionstateApiLatest));
    SessionsInterface.NativeFieldInfoPtr_EndsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (EndsessionApiLatest));
    SessionsInterface.NativeFieldInfoPtr_GetinvitecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (GetinvitecountApiLatest));
    SessionsInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (GetinviteidbyindexApiLatest));
    SessionsInterface.NativeFieldInfoPtr_InviteidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (InviteidMaxLength));
    SessionsInterface.NativeFieldInfoPtr_IsuserinsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (IsuserinsessionApiLatest));
    SessionsInterface.NativeFieldInfoPtr_JoinsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (JoinsessionApiLatest));
    SessionsInterface.NativeFieldInfoPtr_MaxSearchResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (MaxSearchResults));
    SessionsInterface.NativeFieldInfoPtr_Maxregisteredplayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (Maxregisteredplayers));
    SessionsInterface.NativeFieldInfoPtr_QueryinvitesApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (QueryinvitesApiLatest));
    SessionsInterface.NativeFieldInfoPtr_RegisterplayersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (RegisterplayersApiLatest));
    SessionsInterface.NativeFieldInfoPtr_RejectinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (RejectinviteApiLatest));
    SessionsInterface.NativeFieldInfoPtr_SearchBucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchBucketId));
    SessionsInterface.NativeFieldInfoPtr_SearchEmptyServersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchEmptyServersOnly));
    SessionsInterface.NativeFieldInfoPtr_SearchMinslotsavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchMinslotsavailable));
    SessionsInterface.NativeFieldInfoPtr_SearchNonemptyServersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SearchNonemptyServersOnly));
    SessionsInterface.NativeFieldInfoPtr_SendinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SendinviteApiLatest));
    SessionsInterface.NativeFieldInfoPtr_SessionattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SessionattributeApiLatest));
    SessionsInterface.NativeFieldInfoPtr_SessionattributedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (SessionattributedataApiLatest));
    SessionsInterface.NativeFieldInfoPtr_StartsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (StartsessionApiLatest));
    SessionsInterface.NativeFieldInfoPtr_UnregisterplayersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (UnregisterplayersApiLatest));
    SessionsInterface.NativeFieldInfoPtr_UpdatesessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (UpdatesessionApiLatest));
    SessionsInterface.NativeFieldInfoPtr_UpdatesessionmodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, nameof (UpdatesessionmodificationApiLatest));
    SessionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666022);
    SessionsInterface.NativeMethodInfoPtr_AddNotifyJoinSessionAccepted_Public_UInt64_AddNotifyJoinSessionAcceptedOptions_Object_OnJoinSessionAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666024);
    SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteAccepted_Public_UInt64_AddNotifySessionInviteAcceptedOptions_Object_OnSessionInviteAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666025);
    SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteReceived_Public_UInt64_AddNotifySessionInviteReceivedOptions_Object_OnSessionInviteReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666026);
    SessionsInterface.NativeMethodInfoPtr_CopyActiveSessionHandle_Public_Result_CopyActiveSessionHandleOptions_byref_ActiveSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666027);
    SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByInviteId_Public_Result_CopySessionHandleByInviteIdOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666028);
    SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByUiEventId_Public_Result_CopySessionHandleByUiEventIdOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666029);
    SessionsInterface.NativeMethodInfoPtr_CopySessionHandleForPresence_Public_Result_CopySessionHandleForPresenceOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666030);
    SessionsInterface.NativeMethodInfoPtr_CreateSessionModification_Public_Result_CreateSessionModificationOptions_byref_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666031);
    SessionsInterface.NativeMethodInfoPtr_CreateSessionSearch_Public_Result_CreateSessionSearchOptions_byref_SessionSearch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666032 /*0x06000AB0*/);
    SessionsInterface.NativeMethodInfoPtr_DestroySession_Public_Void_DestroySessionOptions_Object_OnDestroySessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666033);
    SessionsInterface.NativeMethodInfoPtr_DumpSessionState_Public_Result_DumpSessionStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666034);
    SessionsInterface.NativeMethodInfoPtr_EndSession_Public_Void_EndSessionOptions_Object_OnEndSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666035);
    SessionsInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_GetInviteCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666036);
    SessionsInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_GetInviteIdByIndexOptions_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666037);
    SessionsInterface.NativeMethodInfoPtr_IsUserInSession_Public_Result_IsUserInSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666038);
    SessionsInterface.NativeMethodInfoPtr_JoinSession_Public_Void_JoinSessionOptions_Object_OnJoinSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666039);
    SessionsInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_QueryInvitesOptions_Object_OnQueryInvitesCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666040);
    SessionsInterface.NativeMethodInfoPtr_RegisterPlayers_Public_Void_RegisterPlayersOptions_Object_OnRegisterPlayersCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666041);
    SessionsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666042);
    SessionsInterface.NativeMethodInfoPtr_RemoveNotifyJoinSessionAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666043);
    SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666044);
    SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666045);
    SessionsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666046);
    SessionsInterface.NativeMethodInfoPtr_StartSession_Public_Void_StartSessionOptions_Object_OnStartSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666047);
    SessionsInterface.NativeMethodInfoPtr_UnregisterPlayers_Public_Void_UnregisterPlayersOptions_Object_OnUnregisterPlayersCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666048 /*0x06000AC0*/);
    SessionsInterface.NativeMethodInfoPtr_UpdateSession_Public_Void_UpdateSessionOptions_Object_OnUpdateSessionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666049);
    SessionsInterface.NativeMethodInfoPtr_UpdateSessionModification_Public_Result_UpdateSessionModificationOptions_byref_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666050);
    SessionsInterface.NativeMethodInfoPtr_OnDestroySessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666051);
    SessionsInterface.NativeMethodInfoPtr_OnEndSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666052);
    SessionsInterface.NativeMethodInfoPtr_OnJoinSessionAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666053);
    SessionsInterface.NativeMethodInfoPtr_OnJoinSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666054);
    SessionsInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666055);
    SessionsInterface.NativeMethodInfoPtr_OnRegisterPlayersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666056);
    SessionsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666057);
    SessionsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666058);
    SessionsInterface.NativeMethodInfoPtr_OnSessionInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666059);
    SessionsInterface.NativeMethodInfoPtr_OnSessionInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666060);
    SessionsInterface.NativeMethodInfoPtr_OnStartSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666061);
    SessionsInterface.NativeMethodInfoPtr_OnUnregisterPlayersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666062);
    SessionsInterface.NativeMethodInfoPtr_OnUpdateSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr, 100666063);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SessionsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379128, XrefRangeEnd = 379147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyJoinSessionAccepted(
    AddNotifyJoinSessionAcceptedOptions options,
    Il2CppSystem.Object clientData,
    OnJoinSessionAcceptedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_AddNotifyJoinSessionAccepted_Public_UInt64_AddNotifyJoinSessionAcceptedOptions_Object_OnJoinSessionAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379147, XrefRangeEnd = 379166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifySessionInviteAccepted(
    AddNotifySessionInviteAcceptedOptions options,
    Il2CppSystem.Object clientData,
    OnSessionInviteAcceptedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteAccepted_Public_UInt64_AddNotifySessionInviteAcceptedOptions_Object_OnSessionInviteAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379166, XrefRangeEnd = 379185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifySessionInviteReceived(
    AddNotifySessionInviteReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnSessionInviteReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_AddNotifySessionInviteReceived_Public_UInt64_AddNotifySessionInviteReceivedOptions_Object_OnSessionInviteReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379185, XrefRangeEnd = 379196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyActiveSessionHandle(
    CopyActiveSessionHandleOptions options,
    out ActiveSession outSessionHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopyActiveSessionHandle_Public_Result_CopyActiveSessionHandleOptions_byref_ActiveSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ActiveSession local = ref outSessionHandle;
    System.IntPtr pointer = zero;
    ActiveSession activeSession = pointer == System.IntPtr.Zero ? (ActiveSession) null : new ActiveSession(pointer);
    local = activeSession;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379196, XrefRangeEnd = 379207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySessionHandleByInviteId(
    CopySessionHandleByInviteIdOptions options,
    out SessionDetails outSessionHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByInviteId_Public_Result_CopySessionHandleByInviteIdOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetails local = ref outSessionHandle;
    System.IntPtr pointer = zero;
    SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
    local = sessionDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379207, XrefRangeEnd = 379218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySessionHandleByUiEventId(
    CopySessionHandleByUiEventIdOptions options,
    out SessionDetails outSessionHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopySessionHandleByUiEventId_Public_Result_CopySessionHandleByUiEventIdOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetails local = ref outSessionHandle;
    System.IntPtr pointer = zero;
    SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
    local = sessionDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379218, XrefRangeEnd = 379229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySessionHandleForPresence(
    CopySessionHandleForPresenceOptions options,
    out SessionDetails outSessionHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CopySessionHandleForPresence_Public_Result_CopySessionHandleForPresenceOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetails local = ref outSessionHandle;
    System.IntPtr pointer = zero;
    SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
    local = sessionDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379229, XrefRangeEnd = 379240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CreateSessionModification(
    CreateSessionModificationOptions options,
    out SessionModification outSessionModificationHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CreateSessionModification_Public_Result_CreateSessionModificationOptions_byref_SessionModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionModification local = ref outSessionModificationHandle;
    System.IntPtr pointer = zero;
    SessionModification sessionModification = pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
    local = sessionModification;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379240, XrefRangeEnd = 379251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CreateSessionSearch(
    CreateSessionSearchOptions options,
    out SessionSearch outSessionSearchHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_CreateSessionSearch_Public_Result_CreateSessionSearchOptions_byref_SessionSearch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionSearch local = ref outSessionSearchHandle;
    System.IntPtr pointer = zero;
    SessionSearch sessionSearch = pointer == System.IntPtr.Zero ? (SessionSearch) null : new SessionSearch(pointer);
    local = sessionSearch;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379251, XrefRangeEnd = 379269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroySession(
    DestroySessionOptions options,
    Il2CppSystem.Object clientData,
    OnDestroySessionCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_DestroySession_Public_Void_DestroySessionOptions_Object_OnDestroySessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379269, XrefRangeEnd = 379277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result DumpSessionState(DumpSessionStateOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_DumpSessionState_Public_Result_DumpSessionStateOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379277, XrefRangeEnd = 379295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndSession(
    EndSessionOptions options,
    Il2CppSystem.Object clientData,
    OnEndSessionCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_EndSession_Public_Void_EndSessionOptions_Object_OnEndSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379295, XrefRangeEnd = 379303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetInviteCount(GetInviteCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_GetInviteCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379303, XrefRangeEnd = 379314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetInviteIdByIndex(GetInviteIdByIndexOptions options, out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_GetInviteIdByIndexOptions_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379314, XrefRangeEnd = 379322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result IsUserInSession(IsUserInSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_IsUserInSession_Public_Result_IsUserInSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379322, XrefRangeEnd = 379340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoinSession(
    JoinSessionOptions options,
    Il2CppSystem.Object clientData,
    OnJoinSessionCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_JoinSession_Public_Void_JoinSessionOptions_Object_OnJoinSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379340, XrefRangeEnd = 379358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryInvites(
    QueryInvitesOptions options,
    Il2CppSystem.Object clientData,
    OnQueryInvitesCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_QueryInvitesOptions_Object_OnQueryInvitesCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379358, XrefRangeEnd = 379376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterPlayers(
    RegisterPlayersOptions options,
    Il2CppSystem.Object clientData,
    OnRegisterPlayersCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RegisterPlayers_Public_Void_RegisterPlayersOptions_Object_OnRegisterPlayersCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379376, XrefRangeEnd = 379394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RejectInvite(
    RejectInviteOptions options,
    Il2CppSystem.Object clientData,
    OnRejectInviteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379394, XrefRangeEnd = 379399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyJoinSessionAccepted(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RemoveNotifyJoinSessionAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379399, XrefRangeEnd = 379404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifySessionInviteAccepted(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379404, XrefRangeEnd = 379409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifySessionInviteReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_RemoveNotifySessionInviteReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379409, XrefRangeEnd = 379427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendInvite(
    SendInviteOptions options,
    Il2CppSystem.Object clientData,
    OnSendInviteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379427, XrefRangeEnd = 379445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartSession(
    StartSessionOptions options,
    Il2CppSystem.Object clientData,
    OnStartSessionCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_StartSession_Public_Void_StartSessionOptions_Object_OnStartSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379445, XrefRangeEnd = 379464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterPlayers(
    UnregisterPlayersOptions options,
    Il2CppSystem.Object clientData,
    OnUnregisterPlayersCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_UnregisterPlayers_Public_Void_UnregisterPlayersOptions_Object_OnUnregisterPlayersCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379464, XrefRangeEnd = 379483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSession(
    UpdateSessionOptions options,
    Il2CppSystem.Object clientData,
    OnUpdateSessionCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_UpdateSession_Public_Void_UpdateSessionOptions_Object_OnUpdateSessionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379483, XrefRangeEnd = 379494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result UpdateSessionModification(
    UpdateSessionModificationOptions options,
    out SessionModification outSessionModificationHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_UpdateSessionModification_Public_Result_UpdateSessionModificationOptions_byref_SessionModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionModification local = ref outSessionModificationHandle;
    System.IntPtr pointer = zero;
    SessionModification sessionModification = pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
    local = sessionModification;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379494, XrefRangeEnd = 379500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDestroySessionCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnDestroySessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379500, XrefRangeEnd = 379506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnEndSessionCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnEndSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379506, XrefRangeEnd = 379512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnJoinSessionAcceptedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnJoinSessionAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379512, XrefRangeEnd = 379518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnJoinSessionCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnJoinSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379518, XrefRangeEnd = 379524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryInvitesCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379524, XrefRangeEnd = 379530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRegisterPlayersCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnRegisterPlayersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379530, XrefRangeEnd = 379536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRejectInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379536, XrefRangeEnd = 379542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSendInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379542, XrefRangeEnd = 379548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSessionInviteAcceptedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnSessionInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379548, XrefRangeEnd = 379554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSessionInviteReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnSessionInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379554, XrefRangeEnd = 379560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnStartSessionCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnStartSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379560, XrefRangeEnd = 379566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUnregisterPlayersCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnUnregisterPlayersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379566, XrefRangeEnd = 379572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdateSessionCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionsInterface.NativeMethodInfoPtr_OnUpdateSessionCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifyjoinsessionacceptedApiLatest
  {
    get
    {
      int addnotifyjoinsessionacceptedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest, (void*) &addnotifyjoinsessionacceptedApiLatest);
      return addnotifyjoinsessionacceptedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AddnotifyjoinsessionacceptedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifysessioninviteacceptedApiLatest
  {
    get
    {
      int addnotifysessioninviteacceptedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest, (void*) &addnotifysessioninviteacceptedApiLatest);
      return addnotifysessioninviteacceptedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninviteacceptedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifysessioninvitereceivedApiLatest
  {
    get
    {
      int addnotifysessioninvitereceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest, (void*) &addnotifysessioninvitereceivedApiLatest);
      return addnotifysessioninvitereceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AddnotifysessioninvitereceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AttributedataApiLatest
  {
    get
    {
      int attributedataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &attributedataApiLatest);
      return attributedataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyactivesessionhandleApiLatest
  {
    get
    {
      int copyactivesessionhandleApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopyactivesessionhandleApiLatest, (void*) &copyactivesessionhandleApiLatest);
      return copyactivesessionhandleApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopyactivesessionhandleApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopysessionhandlebyinviteidApiLatest
  {
    get
    {
      int copysessionhandlebyinviteidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest, (void*) &copysessionhandlebyinviteidApiLatest);
      return copysessionhandlebyinviteidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyinviteidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopysessionhandlebyuieventidApiLatest
  {
    get
    {
      int copysessionhandlebyuieventidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest, (void*) &copysessionhandlebyuieventidApiLatest);
      return copysessionhandlebyuieventidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandlebyuieventidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopysessionhandleforpresenceApiLatest
  {
    get
    {
      int copysessionhandleforpresenceApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest, (void*) &copysessionhandleforpresenceApiLatest);
      return copysessionhandleforpresenceApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CopysessionhandleforpresenceApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatesessionmodificationApiLatest
  {
    get
    {
      int createsessionmodificationApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionmodificationApiLatest, (void*) &createsessionmodificationApiLatest);
      return createsessionmodificationApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionmodificationApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatesessionsearchApiLatest
  {
    get
    {
      int createsessionsearchApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionsearchApiLatest, (void*) &createsessionsearchApiLatest);
      return createsessionsearchApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_CreatesessionsearchApiLatest, (void*) &value);
    }
  }

  public static unsafe int DestroysessionApiLatest
  {
    get
    {
      int destroysessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_DestroysessionApiLatest, (void*) &destroysessionApiLatest);
      return destroysessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_DestroysessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int DumpsessionstateApiLatest
  {
    get
    {
      int dumpsessionstateApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_DumpsessionstateApiLatest, (void*) &dumpsessionstateApiLatest);
      return dumpsessionstateApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_DumpsessionstateApiLatest, (void*) &value);
    }
  }

  public static unsafe int EndsessionApiLatest
  {
    get
    {
      int endsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &endsessionApiLatest);
      return endsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetinvitecountApiLatest
  {
    get
    {
      int getinvitecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &getinvitecountApiLatest);
      return getinvitecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetinviteidbyindexApiLatest
  {
    get
    {
      int getinviteidbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &getinviteidbyindexApiLatest);
      return getinviteidbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int InviteidMaxLength
  {
    get
    {
      int inviteidMaxLength;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &inviteidMaxLength);
      return inviteidMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &value);
    }
  }

  public static unsafe int IsuserinsessionApiLatest
  {
    get
    {
      int isuserinsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_IsuserinsessionApiLatest, (void*) &isuserinsessionApiLatest);
      return isuserinsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_IsuserinsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int JoinsessionApiLatest
  {
    get
    {
      int joinsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_JoinsessionApiLatest, (void*) &joinsessionApiLatest);
      return joinsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_JoinsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxSearchResults
  {
    get
    {
      int maxSearchResults;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &maxSearchResults);
      return maxSearchResults;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &value);
    }
  }

  public static unsafe int Maxregisteredplayers
  {
    get
    {
      int maxregisteredplayers;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_Maxregisteredplayers, (void*) &maxregisteredplayers);
      return maxregisteredplayers;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_Maxregisteredplayers, (void*) &value);
    }
  }

  public static unsafe int QueryinvitesApiLatest
  {
    get
    {
      int queryinvitesApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &queryinvitesApiLatest);
      return queryinvitesApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &value);
    }
  }

  public static unsafe int RegisterplayersApiLatest
  {
    get
    {
      int registerplayersApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_RegisterplayersApiLatest, (void*) &registerplayersApiLatest);
      return registerplayersApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_RegisterplayersApiLatest, (void*) &value);
    }
  }

  public static unsafe int RejectinviteApiLatest
  {
    get
    {
      int rejectinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &rejectinviteApiLatest);
      return rejectinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe string SearchBucketId
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchBucketId, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchBucketId, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SearchEmptyServersOnly
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchEmptyServersOnly, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchEmptyServersOnly, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SearchMinslotsavailable
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SearchNonemptyServersOnly
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SearchNonemptyServersOnly, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SearchNonemptyServersOnly, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int SendinviteApiLatest
  {
    get
    {
      int sendinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &sendinviteApiLatest);
      return sendinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionattributeApiLatest
  {
    get
    {
      int sessionattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SessionattributeApiLatest, (void*) &sessionattributeApiLatest);
      return sessionattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SessionattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionattributedataApiLatest
  {
    get
    {
      int sessionattributedataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_SessionattributedataApiLatest, (void*) &sessionattributedataApiLatest);
      return sessionattributedataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_SessionattributedataApiLatest, (void*) &value);
    }
  }

  public static unsafe int StartsessionApiLatest
  {
    get
    {
      int startsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_StartsessionApiLatest, (void*) &startsessionApiLatest);
      return startsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_StartsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnregisterplayersApiLatest
  {
    get
    {
      int unregisterplayersApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_UnregisterplayersApiLatest, (void*) &unregisterplayersApiLatest);
      return unregisterplayersApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_UnregisterplayersApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatesessionApiLatest
  {
    get
    {
      int updatesessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionApiLatest, (void*) &updatesessionApiLatest);
      return updatesessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatesessionmodificationApiLatest
  {
    get
    {
      int updatesessionmodificationApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionmodificationApiLatest, (void*) &updatesessionmodificationApiLatest);
      return updatesessionmodificationApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionsInterface.NativeFieldInfoPtr_UpdatesessionmodificationApiLatest, (void*) &value);
    }
  }
}
