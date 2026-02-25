// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public sealed class LobbyInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AttributeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AttributedataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopylobbydetailshandleApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatelobbyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatelobbysearchApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DestroylobbyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetinvitecountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetinviteidbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetrtcroomnameApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_InviteidMaxLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsrtcroomconnectedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_JoinlobbyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_KickmemberApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LeavelobbyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalrtcoptionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxLobbies;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxLobbyMembers;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxLobbyidoverrideLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxSearchResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_MinLobbyidoverrideLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_PromotememberApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryinvitesApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RejectinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchBucketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchMincurrentmembers;
  private static readonly System.IntPtr NativeFieldInfoPtr_SearchMinslotsavailable;
  private static readonly System.IntPtr NativeFieldInfoPtr_SendinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatelobbyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatelobbymodificationApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyJoinLobbyAccepted_Public_UInt64_AddNotifyJoinLobbyAcceptedOptions_Object_OnJoinLobbyAcceptedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyInviteAccepted_Public_UInt64_AddNotifyLobbyInviteAcceptedOptions_Object_OnLobbyInviteAcceptedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyInviteReceived_Public_UInt64_AddNotifyLobbyInviteReceivedOptions_Object_OnLobbyInviteReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyMemberStatusReceived_Public_UInt64_AddNotifyLobbyMemberStatusReceivedOptions_Object_OnLobbyMemberStatusReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyMemberUpdateReceived_Public_UInt64_AddNotifyLobbyMemberUpdateReceivedOptions_Object_OnLobbyMemberUpdateReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLobbyUpdateReceived_Public_UInt64_AddNotifyLobbyUpdateReceivedOptions_Object_OnLobbyUpdateReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyRTCRoomConnectionChanged_Public_UInt64_AddNotifyRTCRoomConnectionChangedOptions_Object_OnRTCRoomConnectionChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLobbyDetailsHandle_Public_Result_CopyLobbyDetailsHandleOptions_byref_LobbyDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLobbyDetailsHandleByInviteId_Public_Result_CopyLobbyDetailsHandleByInviteIdOptions_byref_LobbyDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLobbyDetailsHandleByUiEventId_Public_Result_CopyLobbyDetailsHandleByUiEventIdOptions_byref_LobbyDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateLobby_Public_Void_CreateLobbyOptions_Object_OnCreateLobbyCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateLobbySearch_Public_Result_CreateLobbySearchOptions_byref_LobbySearch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyLobby_Public_Void_DestroyLobbyOptions_Object_OnDestroyLobbyCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteCount_Public_UInt32_GetInviteCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_GetInviteIdByIndexOptions_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRTCRoomName_Public_Result_GetRTCRoomNameOptions_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRTCRoomConnected_Public_Result_IsRTCRoomConnectedOptions_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoinLobby_Public_Void_JoinLobbyOptions_Object_OnJoinLobbyCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_KickMember_Public_Void_KickMemberOptions_Object_OnKickMemberCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Void_LeaveLobbyOptions_Object_OnLeaveLobbyCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PromoteMember_Public_Void_PromoteMemberOptions_Object_OnPromoteMemberCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryInvites_Public_Void_QueryInvitesOptions_Object_OnQueryInvitesCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyJoinLobbyAccepted_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyInviteAccepted_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyInviteReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyMemberStatusReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyMemberUpdateReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLobbyUpdateReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyRTCRoomConnectionChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLobby_Public_Void_UpdateLobbyOptions_Object_OnUpdateLobbyCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLobbyModification_Public_Result_UpdateLobbyModificationOptions_byref_LobbyModification_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroyLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinLobbyAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnKickMemberCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLeaveLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyMemberStatusReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyMemberUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPromoteMemberCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRTCRoomConnectionChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static LobbyInterface()
  {
    Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr);
    LobbyInterface.NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifyjoinlobbyacceptedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyinviteacceptedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyinvitereceivedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbymemberstatusreceivedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbymemberupdatereceivedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifylobbyupdatereceivedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AddnotifyrtcroomconnectionchangedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AttributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AttributeApiLatest));
    LobbyInterface.NativeFieldInfoPtr_AttributedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (AttributedataApiLatest));
    LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandleApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CopylobbydetailshandleApiLatest));
    LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CopylobbydetailshandlebyinviteidApiLatest));
    LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CopylobbydetailshandlebyuieventidApiLatest));
    LobbyInterface.NativeFieldInfoPtr_CreatelobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CreatelobbyApiLatest));
    LobbyInterface.NativeFieldInfoPtr_CreatelobbysearchApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (CreatelobbysearchApiLatest));
    LobbyInterface.NativeFieldInfoPtr_DestroylobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (DestroylobbyApiLatest));
    LobbyInterface.NativeFieldInfoPtr_GetinvitecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (GetinvitecountApiLatest));
    LobbyInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (GetinviteidbyindexApiLatest));
    LobbyInterface.NativeFieldInfoPtr_GetrtcroomnameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (GetrtcroomnameApiLatest));
    LobbyInterface.NativeFieldInfoPtr_InviteidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (InviteidMaxLength));
    LobbyInterface.NativeFieldInfoPtr_IsrtcroomconnectedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (IsrtcroomconnectedApiLatest));
    LobbyInterface.NativeFieldInfoPtr_JoinlobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (JoinlobbyApiLatest));
    LobbyInterface.NativeFieldInfoPtr_KickmemberApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (KickmemberApiLatest));
    LobbyInterface.NativeFieldInfoPtr_LeavelobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (LeavelobbyApiLatest));
    LobbyInterface.NativeFieldInfoPtr_LocalrtcoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (LocalrtcoptionsApiLatest));
    LobbyInterface.NativeFieldInfoPtr_MaxLobbies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxLobbies));
    LobbyInterface.NativeFieldInfoPtr_MaxLobbyMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxLobbyMembers));
    LobbyInterface.NativeFieldInfoPtr_MaxLobbyidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxLobbyidoverrideLength));
    LobbyInterface.NativeFieldInfoPtr_MaxSearchResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MaxSearchResults));
    LobbyInterface.NativeFieldInfoPtr_MinLobbyidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (MinLobbyidoverrideLength));
    LobbyInterface.NativeFieldInfoPtr_PromotememberApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (PromotememberApiLatest));
    LobbyInterface.NativeFieldInfoPtr_QueryinvitesApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (QueryinvitesApiLatest));
    LobbyInterface.NativeFieldInfoPtr_RejectinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (RejectinviteApiLatest));
    LobbyInterface.NativeFieldInfoPtr_SearchBucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SearchBucketId));
    LobbyInterface.NativeFieldInfoPtr_SearchMincurrentmembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SearchMincurrentmembers));
    LobbyInterface.NativeFieldInfoPtr_SearchMinslotsavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SearchMinslotsavailable));
    LobbyInterface.NativeFieldInfoPtr_SendinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (SendinviteApiLatest));
    LobbyInterface.NativeFieldInfoPtr_UpdatelobbyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (UpdatelobbyApiLatest));
    LobbyInterface.NativeFieldInfoPtr_UpdatelobbymodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, nameof (UpdatelobbymodificationApiLatest));
    LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669282);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyJoinLobbyAccepted_Public_UInt64_AddNotifyJoinLobbyAcceptedOptions_Object_OnJoinLobbyAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669284);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteAccepted_Public_UInt64_AddNotifyLobbyInviteAcceptedOptions_Object_OnLobbyInviteAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669285);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteReceived_Public_UInt64_AddNotifyLobbyInviteReceivedOptions_Object_OnLobbyInviteReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669286);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberStatusReceived_Public_UInt64_AddNotifyLobbyMemberStatusReceivedOptions_Object_OnLobbyMemberStatusReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669287);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberUpdateReceived_Public_UInt64_AddNotifyLobbyMemberUpdateReceivedOptions_Object_OnLobbyMemberUpdateReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669288);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyUpdateReceived_Public_UInt64_AddNotifyLobbyUpdateReceivedOptions_Object_OnLobbyUpdateReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669289);
    LobbyInterface.NativeMethodInfoPtr_AddNotifyRTCRoomConnectionChanged_Public_UInt64_AddNotifyRTCRoomConnectionChangedOptions_Object_OnRTCRoomConnectionChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669290);
    LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandle_Public_Result_CopyLobbyDetailsHandleOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669291);
    LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByInviteId_Public_Result_CopyLobbyDetailsHandleByInviteIdOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669292);
    LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByUiEventId_Public_Result_CopyLobbyDetailsHandleByUiEventIdOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669293);
    LobbyInterface.NativeMethodInfoPtr_CreateLobby_Public_Void_CreateLobbyOptions_Object_OnCreateLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669294);
    LobbyInterface.NativeMethodInfoPtr_CreateLobbySearch_Public_Result_CreateLobbySearchOptions_byref_LobbySearch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669295);
    LobbyInterface.NativeMethodInfoPtr_DestroyLobby_Public_Void_DestroyLobbyOptions_Object_OnDestroyLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669296);
    LobbyInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_GetInviteCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669297);
    LobbyInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_GetInviteIdByIndexOptions_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669298);
    LobbyInterface.NativeMethodInfoPtr_GetRTCRoomName_Public_Result_GetRTCRoomNameOptions_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669299);
    LobbyInterface.NativeMethodInfoPtr_IsRTCRoomConnected_Public_Result_IsRTCRoomConnectedOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669300);
    LobbyInterface.NativeMethodInfoPtr_JoinLobby_Public_Void_JoinLobbyOptions_Object_OnJoinLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669301);
    LobbyInterface.NativeMethodInfoPtr_KickMember_Public_Void_KickMemberOptions_Object_OnKickMemberCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669302);
    LobbyInterface.NativeMethodInfoPtr_LeaveLobby_Public_Void_LeaveLobbyOptions_Object_OnLeaveLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669303);
    LobbyInterface.NativeMethodInfoPtr_PromoteMember_Public_Void_PromoteMemberOptions_Object_OnPromoteMemberCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669304);
    LobbyInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_QueryInvitesOptions_Object_OnQueryInvitesCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669305);
    LobbyInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669306);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyJoinLobbyAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669307);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669308);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669309);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberStatusReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669310);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberUpdateReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669311);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyUpdateReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669312);
    LobbyInterface.NativeMethodInfoPtr_RemoveNotifyRTCRoomConnectionChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669313);
    LobbyInterface.NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669314);
    LobbyInterface.NativeMethodInfoPtr_UpdateLobby_Public_Void_UpdateLobbyOptions_Object_OnUpdateLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669315);
    LobbyInterface.NativeMethodInfoPtr_UpdateLobbyModification_Public_Result_UpdateLobbyModificationOptions_byref_LobbyModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669316);
    LobbyInterface.NativeMethodInfoPtr_OnCreateLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669317);
    LobbyInterface.NativeMethodInfoPtr_OnDestroyLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669318);
    LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669319);
    LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669320);
    LobbyInterface.NativeMethodInfoPtr_OnKickMemberCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669321);
    LobbyInterface.NativeMethodInfoPtr_OnLeaveLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669322);
    LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669323);
    LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669324);
    LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberStatusReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669325);
    LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669326);
    LobbyInterface.NativeMethodInfoPtr_OnLobbyUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669327);
    LobbyInterface.NativeMethodInfoPtr_OnPromoteMemberCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669328);
    LobbyInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669329);
    LobbyInterface.NativeMethodInfoPtr_OnRTCRoomConnectionChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669330);
    LobbyInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669331);
    LobbyInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669332);
    LobbyInterface.NativeMethodInfoPtr_OnUpdateLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100669333);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbyInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389743, XrefRangeEnd = 389763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyJoinLobbyAccepted(
    AddNotifyJoinLobbyAcceptedOptions options,
    Il2CppSystem.Object clientData,
    OnJoinLobbyAcceptedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyJoinLobbyAccepted_Public_UInt64_AddNotifyJoinLobbyAcceptedOptions_Object_OnJoinLobbyAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389763, XrefRangeEnd = 389783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyLobbyInviteAccepted(
    AddNotifyLobbyInviteAcceptedOptions options,
    Il2CppSystem.Object clientData,
    OnLobbyInviteAcceptedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteAccepted_Public_UInt64_AddNotifyLobbyInviteAcceptedOptions_Object_OnLobbyInviteAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389783, XrefRangeEnd = 389803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyLobbyInviteReceived(
    AddNotifyLobbyInviteReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnLobbyInviteReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyInviteReceived_Public_UInt64_AddNotifyLobbyInviteReceivedOptions_Object_OnLobbyInviteReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389803, XrefRangeEnd = 389823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyLobbyMemberStatusReceived(
    AddNotifyLobbyMemberStatusReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnLobbyMemberStatusReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberStatusReceived_Public_UInt64_AddNotifyLobbyMemberStatusReceivedOptions_Object_OnLobbyMemberStatusReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389823, XrefRangeEnd = 389843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyLobbyMemberUpdateReceived(
    AddNotifyLobbyMemberUpdateReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnLobbyMemberUpdateReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyMemberUpdateReceived_Public_UInt64_AddNotifyLobbyMemberUpdateReceivedOptions_Object_OnLobbyMemberUpdateReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389843, XrefRangeEnd = 389863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyLobbyUpdateReceived(
    AddNotifyLobbyUpdateReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnLobbyUpdateReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyLobbyUpdateReceived_Public_UInt64_AddNotifyLobbyUpdateReceivedOptions_Object_OnLobbyUpdateReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389863, XrefRangeEnd = 389883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyRTCRoomConnectionChanged(
    AddNotifyRTCRoomConnectionChangedOptions options,
    Il2CppSystem.Object clientData,
    OnRTCRoomConnectionChangedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_AddNotifyRTCRoomConnectionChanged_Public_UInt64_AddNotifyRTCRoomConnectionChangedOptions_Object_OnRTCRoomConnectionChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389883, XrefRangeEnd = 389894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLobbyDetailsHandle(
    CopyLobbyDetailsHandleOptions options,
    out LobbyDetails outLobbyDetailsHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandle_Public_Result_CopyLobbyDetailsHandleOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbyDetails local = ref outLobbyDetailsHandle;
    System.IntPtr pointer = zero;
    LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
    local = lobbyDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389894, XrefRangeEnd = 389905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLobbyDetailsHandleByInviteId(
    CopyLobbyDetailsHandleByInviteIdOptions options,
    out LobbyDetails outLobbyDetailsHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByInviteId_Public_Result_CopyLobbyDetailsHandleByInviteIdOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbyDetails local = ref outLobbyDetailsHandle;
    System.IntPtr pointer = zero;
    LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
    local = lobbyDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389905, XrefRangeEnd = 389916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLobbyDetailsHandleByUiEventId(
    CopyLobbyDetailsHandleByUiEventIdOptions options,
    out LobbyDetails outLobbyDetailsHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CopyLobbyDetailsHandleByUiEventId_Public_Result_CopyLobbyDetailsHandleByUiEventIdOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbyDetails local = ref outLobbyDetailsHandle;
    System.IntPtr pointer = zero;
    LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
    local = lobbyDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389916, XrefRangeEnd = 389935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateLobby(
    CreateLobbyOptions options,
    Il2CppSystem.Object clientData,
    OnCreateLobbyCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CreateLobby_Public_Void_CreateLobbyOptions_Object_OnCreateLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389935, XrefRangeEnd = 389946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CreateLobbySearch(
    CreateLobbySearchOptions options,
    out LobbySearch outLobbySearchHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_CreateLobbySearch_Public_Result_CreateLobbySearchOptions_byref_LobbySearch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbySearch local = ref outLobbySearchHandle;
    System.IntPtr pointer = zero;
    LobbySearch lobbySearch = pointer == System.IntPtr.Zero ? (LobbySearch) null : new LobbySearch(pointer);
    local = lobbySearch;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389946, XrefRangeEnd = 389965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyLobby(
    DestroyLobbyOptions options,
    Il2CppSystem.Object clientData,
    OnDestroyLobbyCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_DestroyLobby_Public_Void_DestroyLobbyOptions_Object_OnDestroyLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389965, XrefRangeEnd = 389973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetInviteCount(GetInviteCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetInviteCount_Public_UInt32_GetInviteCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389973, XrefRangeEnd = 389984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetInviteIdByIndex_Public_Result_GetInviteIdByIndexOptions_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389984, XrefRangeEnd = 389995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetRTCRoomName(GetRTCRoomNameOptions options, out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetRTCRoomName_Public_Result_GetRTCRoomNameOptions_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389995, XrefRangeEnd = 390004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result IsRTCRoomConnected(
    IsRTCRoomConnectedOptions options,
    out bool bOutIsConnected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bOutIsConnected;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_IsRTCRoomConnected_Public_Result_IsRTCRoomConnectedOptions_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390004, XrefRangeEnd = 390023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoinLobby(
    JoinLobbyOptions options,
    Il2CppSystem.Object clientData,
    OnJoinLobbyCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_JoinLobby_Public_Void_JoinLobbyOptions_Object_OnJoinLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390023, XrefRangeEnd = 390042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void KickMember(
    KickMemberOptions options,
    Il2CppSystem.Object clientData,
    OnKickMemberCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_KickMember_Public_Void_KickMemberOptions_Object_OnKickMemberCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390042, XrefRangeEnd = 390061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LeaveLobby(
    LeaveLobbyOptions options,
    Il2CppSystem.Object clientData,
    OnLeaveLobbyCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LeaveLobby_Public_Void_LeaveLobbyOptions_Object_OnLeaveLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390061, XrefRangeEnd = 390080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PromoteMember(
    PromoteMemberOptions options,
    Il2CppSystem.Object clientData,
    OnPromoteMemberCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_PromoteMember_Public_Void_PromoteMemberOptions_Object_OnPromoteMemberCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390080, XrefRangeEnd = 390099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_QueryInvites_Public_Void_QueryInvitesOptions_Object_OnQueryInvitesCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390099, XrefRangeEnd = 390118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390118, XrefRangeEnd = 390123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyJoinLobbyAccepted(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyJoinLobbyAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390123, XrefRangeEnd = 390128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLobbyInviteAccepted(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390128, XrefRangeEnd = 390133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLobbyInviteReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyInviteReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390133, XrefRangeEnd = 390138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLobbyMemberStatusReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberStatusReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390138, XrefRangeEnd = 390143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLobbyMemberUpdateReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyMemberUpdateReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390143, XrefRangeEnd = 390148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyLobbyUpdateReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyLobbyUpdateReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390148, XrefRangeEnd = 390153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyRTCRoomConnectionChanged(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_RemoveNotifyRTCRoomConnectionChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390153, XrefRangeEnd = 390172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390172, XrefRangeEnd = 390191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateLobby(
    UpdateLobbyOptions options,
    Il2CppSystem.Object clientData,
    OnUpdateLobbyCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateLobby_Public_Void_UpdateLobbyOptions_Object_OnUpdateLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390191, XrefRangeEnd = 390202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result UpdateLobbyModification(
    UpdateLobbyModificationOptions options,
    out LobbyModification outLobbyModificationHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateLobbyModification_Public_Result_UpdateLobbyModificationOptions_byref_LobbyModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbyModification local = ref outLobbyModificationHandle;
    System.IntPtr pointer = zero;
    LobbyModification lobbyModification = pointer == System.IntPtr.Zero ? (LobbyModification) null : new LobbyModification(pointer);
    local = lobbyModification;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390202, XrefRangeEnd = 390208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCreateLobbyCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnCreateLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390208, XrefRangeEnd = 390214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDestroyLobbyCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnDestroyLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390214, XrefRangeEnd = 390220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnJoinLobbyAcceptedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390220, XrefRangeEnd = 390226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnJoinLobbyCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnJoinLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390226, XrefRangeEnd = 390232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnKickMemberCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnKickMemberCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390232, XrefRangeEnd = 390238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLeaveLobbyCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLeaveLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390238, XrefRangeEnd = 390244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLobbyInviteAcceptedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390244, XrefRangeEnd = 390250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLobbyInviteReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390250, XrefRangeEnd = 390256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLobbyMemberStatusReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberStatusReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390256, XrefRangeEnd = 390262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLobbyMemberUpdateReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyMemberUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390262, XrefRangeEnd = 390268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLobbyUpdateReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnLobbyUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390268, XrefRangeEnd = 390274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnPromoteMemberCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnPromoteMemberCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390274, XrefRangeEnd = 390280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryInvitesCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnQueryInvitesCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390280, XrefRangeEnd = 390286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRTCRoomConnectionChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnRTCRoomConnectionChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390286, XrefRangeEnd = 390292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRejectInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390292, XrefRangeEnd = 390298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSendInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390298, XrefRangeEnd = 390304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdateLobbyCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_OnUpdateLobbyCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifyjoinlobbyacceptedApiLatest
  {
    get
    {
      int addnotifyjoinlobbyacceptedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest, (void*) &addnotifyjoinlobbyacceptedApiLatest);
      return addnotifyjoinlobbyacceptedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyjoinlobbyacceptedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifylobbyinviteacceptedApiLatest
  {
    get
    {
      int addnotifylobbyinviteacceptedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest, (void*) &addnotifylobbyinviteacceptedApiLatest);
      return addnotifylobbyinviteacceptedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinviteacceptedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifylobbyinvitereceivedApiLatest
  {
    get
    {
      int addnotifylobbyinvitereceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest, (void*) &addnotifylobbyinvitereceivedApiLatest);
      return addnotifylobbyinvitereceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyinvitereceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifylobbymemberstatusreceivedApiLatest
  {
    get
    {
      int addnotifylobbymemberstatusreceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest, (void*) &addnotifylobbymemberstatusreceivedApiLatest);
      return addnotifylobbymemberstatusreceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberstatusreceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifylobbymemberupdatereceivedApiLatest
  {
    get
    {
      int addnotifylobbymemberupdatereceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest, (void*) &addnotifylobbymemberupdatereceivedApiLatest);
      return addnotifylobbymemberupdatereceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbymemberupdatereceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifylobbyupdatereceivedApiLatest
  {
    get
    {
      int addnotifylobbyupdatereceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest, (void*) &addnotifylobbyupdatereceivedApiLatest);
      return addnotifylobbyupdatereceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifylobbyupdatereceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyrtcroomconnectionchangedApiLatest
  {
    get
    {
      int addnotifyrtcroomconnectionchangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest, (void*) &addnotifyrtcroomconnectionchangedApiLatest);
      return addnotifyrtcroomconnectionchangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AddnotifyrtcroomconnectionchangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AttributeApiLatest
  {
    get
    {
      int attributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AttributeApiLatest, (void*) &attributeApiLatest);
      return attributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AttributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int AttributedataApiLatest
  {
    get
    {
      int attributedataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &attributedataApiLatest);
      return attributedataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_AttributedataApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopylobbydetailshandleApiLatest
  {
    get
    {
      int copylobbydetailshandleApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandleApiLatest, (void*) &copylobbydetailshandleApiLatest);
      return copylobbydetailshandleApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandleApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopylobbydetailshandlebyinviteidApiLatest
  {
    get
    {
      int copylobbydetailshandlebyinviteidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest, (void*) &copylobbydetailshandlebyinviteidApiLatest);
      return copylobbydetailshandlebyinviteidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyinviteidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopylobbydetailshandlebyuieventidApiLatest
  {
    get
    {
      int copylobbydetailshandlebyuieventidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest, (void*) &copylobbydetailshandlebyuieventidApiLatest);
      return copylobbydetailshandlebyuieventidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CopylobbydetailshandlebyuieventidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatelobbyApiLatest
  {
    get
    {
      int createlobbyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbyApiLatest, (void*) &createlobbyApiLatest);
      return createlobbyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbyApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatelobbysearchApiLatest
  {
    get
    {
      int createlobbysearchApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbysearchApiLatest, (void*) &createlobbysearchApiLatest);
      return createlobbysearchApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_CreatelobbysearchApiLatest, (void*) &value);
    }
  }

  public static unsafe int DestroylobbyApiLatest
  {
    get
    {
      int destroylobbyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_DestroylobbyApiLatest, (void*) &destroylobbyApiLatest);
      return destroylobbyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_DestroylobbyApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetinvitecountApiLatest
  {
    get
    {
      int getinvitecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &getinvitecountApiLatest);
      return getinvitecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_GetinvitecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetinviteidbyindexApiLatest
  {
    get
    {
      int getinviteidbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &getinviteidbyindexApiLatest);
      return getinviteidbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_GetinviteidbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetrtcroomnameApiLatest
  {
    get
    {
      int getrtcroomnameApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_GetrtcroomnameApiLatest, (void*) &getrtcroomnameApiLatest);
      return getrtcroomnameApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_GetrtcroomnameApiLatest, (void*) &value);
    }
  }

  public static unsafe int InviteidMaxLength
  {
    get
    {
      int inviteidMaxLength;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &inviteidMaxLength);
      return inviteidMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_InviteidMaxLength, (void*) &value);
    }
  }

  public static unsafe int IsrtcroomconnectedApiLatest
  {
    get
    {
      int isrtcroomconnectedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_IsrtcroomconnectedApiLatest, (void*) &isrtcroomconnectedApiLatest);
      return isrtcroomconnectedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_IsrtcroomconnectedApiLatest, (void*) &value);
    }
  }

  public static unsafe int JoinlobbyApiLatest
  {
    get
    {
      int joinlobbyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_JoinlobbyApiLatest, (void*) &joinlobbyApiLatest);
      return joinlobbyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_JoinlobbyApiLatest, (void*) &value);
    }
  }

  public static unsafe int KickmemberApiLatest
  {
    get
    {
      int kickmemberApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_KickmemberApiLatest, (void*) &kickmemberApiLatest);
      return kickmemberApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_KickmemberApiLatest, (void*) &value);
    }
  }

  public static unsafe int LeavelobbyApiLatest
  {
    get
    {
      int leavelobbyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_LeavelobbyApiLatest, (void*) &leavelobbyApiLatest);
      return leavelobbyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_LeavelobbyApiLatest, (void*) &value);
    }
  }

  public static unsafe int LocalrtcoptionsApiLatest
  {
    get
    {
      int localrtcoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_LocalrtcoptionsApiLatest, (void*) &localrtcoptionsApiLatest);
      return localrtcoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_LocalrtcoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxLobbies
  {
    get
    {
      int maxLobbies;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbies, (void*) &maxLobbies);
      return maxLobbies;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbies, (void*) &value);
    }
  }

  public static unsafe int MaxLobbyMembers
  {
    get
    {
      int maxLobbyMembers;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyMembers, (void*) &maxLobbyMembers);
      return maxLobbyMembers;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyMembers, (void*) &value);
    }
  }

  public static unsafe int MaxLobbyidoverrideLength
  {
    get
    {
      int lobbyidoverrideLength;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyidoverrideLength, (void*) &lobbyidoverrideLength);
      return lobbyidoverrideLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxLobbyidoverrideLength, (void*) &value);
    }
  }

  public static unsafe int MaxSearchResults
  {
    get
    {
      int maxSearchResults;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &maxSearchResults);
      return maxSearchResults;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MaxSearchResults, (void*) &value);
    }
  }

  public static unsafe int MinLobbyidoverrideLength
  {
    get
    {
      int lobbyidoverrideLength;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_MinLobbyidoverrideLength, (void*) &lobbyidoverrideLength);
      return lobbyidoverrideLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_MinLobbyidoverrideLength, (void*) &value);
    }
  }

  public static unsafe int PromotememberApiLatest
  {
    get
    {
      int promotememberApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_PromotememberApiLatest, (void*) &promotememberApiLatest);
      return promotememberApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_PromotememberApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryinvitesApiLatest
  {
    get
    {
      int queryinvitesApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &queryinvitesApiLatest);
      return queryinvitesApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_QueryinvitesApiLatest, (void*) &value);
    }
  }

  public static unsafe int RejectinviteApiLatest
  {
    get
    {
      int rejectinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &rejectinviteApiLatest);
      return rejectinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe string SearchBucketId
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SearchBucketId, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SearchBucketId, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SearchMincurrentmembers
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SearchMincurrentmembers, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SearchMincurrentmembers, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string SearchMinslotsavailable
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SearchMinslotsavailable, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int SendinviteApiLatest
  {
    get
    {
      int sendinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &sendinviteApiLatest);
      return sendinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatelobbyApiLatest
  {
    get
    {
      int updatelobbyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbyApiLatest, (void*) &updatelobbyApiLatest);
      return updatelobbyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbyApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatelobbymodificationApiLatest
  {
    get
    {
      int updatelobbymodificationApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbymodificationApiLatest, (void*) &updatelobbymodificationApiLatest);
      return updatelobbymodificationApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyInterface.NativeFieldInfoPtr_UpdatelobbymodificationApiLatest, (void*) &value);
    }
  }
}
