// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.PlatformInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.AntiCheatClient;
using Epic.OnlineServices.AntiCheatServer;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.CustomInvites;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Metrics;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public sealed class PlatformInterface(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_CountrycodeMaxBufferLen;
  private static readonly IntPtr NativeFieldInfoPtr_CountrycodeMaxLength;
  private static readonly IntPtr NativeFieldInfoPtr_InitializeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_InitializeThreadaffinityApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LocalecodeMaxBufferLen;
  private static readonly IntPtr NativeFieldInfoPtr_LocalecodeMaxLength;
  private static readonly IntPtr NativeFieldInfoPtr_OptionsApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_RtcoptionsApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForLauncherAndRestart_Public_Result_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_Options_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAchievementsInterface_Public_AchievementsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetActiveCountryCode_Public_Result_EpicAccountId_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetActiveLocaleCode_Public_Result_EpicAccountId_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAntiCheatClientInterface_Public_AntiCheatClientInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAntiCheatServerInterface_Public_AntiCheatServerInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAuthInterface_Public_AuthInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetConnectInterface_Public_ConnectInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCustomInvitesInterface_Public_CustomInvitesInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetEcomInterface_Public_EcomInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetFriendsInterface_Public_FriendsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetKWSInterface_Public_KWSInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardsInterface_Public_LeaderboardsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetLobbyInterface_Public_LobbyInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMetricsInterface_Public_MetricsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetModsInterface_Public_ModsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOverrideCountryCode_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOverrideLocaleCode_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetP2PInterface_Public_P2PInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDataStorageInterface_Public_PlayerDataStorageInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPresenceInterface_Public_PresenceInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetProgressionSnapshotInterface_Public_ProgressionSnapshotInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRTCAdminInterface_Public_RTCAdminInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRTCInterface_Public_RTCInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetReportsInterface_Public_ReportsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSanctionsInterface_Public_SanctionsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSessionsInterface_Public_SessionsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetStatsInterface_Public_StatsInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTitleStorageInterface_Public_TitleStorageInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetUIInterface_Public_UIInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetUserInfoInterface_Public_UserInfoInterface_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Result_InitializeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetOverrideCountryCode_Public_Result_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetOverrideLocaleCode_Public_Result_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Result_0;
  private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_WindowsOptions_0;

  static PlatformInterface()
  {
    Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (PlatformInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr);
    PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxBufferLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (CountrycodeMaxBufferLen));
    PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (CountrycodeMaxLength));
    PlatformInterface.NativeFieldInfoPtr_InitializeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (InitializeApiLatest));
    PlatformInterface.NativeFieldInfoPtr_InitializeThreadaffinityApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (InitializeThreadaffinityApiLatest));
    PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxBufferLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (LocalecodeMaxBufferLen));
    PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (LocalecodeMaxLength));
    PlatformInterface.NativeFieldInfoPtr_OptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (OptionsApiLatest));
    PlatformInterface.NativeFieldInfoPtr_RtcoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (RtcoptionsApiLatest));
    PlatformInterface.NativeFieldInfoPtr_PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, nameof (PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest));
    PlatformInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668041);
    PlatformInterface.NativeMethodInfoPtr_CheckForLauncherAndRestart_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668043);
    PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668044);
    PlatformInterface.NativeMethodInfoPtr_GetAchievementsInterface_Public_AchievementsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668045);
    PlatformInterface.NativeMethodInfoPtr_GetActiveCountryCode_Public_Result_EpicAccountId_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668046);
    PlatformInterface.NativeMethodInfoPtr_GetActiveLocaleCode_Public_Result_EpicAccountId_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668047);
    PlatformInterface.NativeMethodInfoPtr_GetAntiCheatClientInterface_Public_AntiCheatClientInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668048);
    PlatformInterface.NativeMethodInfoPtr_GetAntiCheatServerInterface_Public_AntiCheatServerInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668049);
    PlatformInterface.NativeMethodInfoPtr_GetAuthInterface_Public_AuthInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668050);
    PlatformInterface.NativeMethodInfoPtr_GetConnectInterface_Public_ConnectInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668051);
    PlatformInterface.NativeMethodInfoPtr_GetCustomInvitesInterface_Public_CustomInvitesInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668052);
    PlatformInterface.NativeMethodInfoPtr_GetEcomInterface_Public_EcomInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668053);
    PlatformInterface.NativeMethodInfoPtr_GetFriendsInterface_Public_FriendsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668054);
    PlatformInterface.NativeMethodInfoPtr_GetKWSInterface_Public_KWSInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668055);
    PlatformInterface.NativeMethodInfoPtr_GetLeaderboardsInterface_Public_LeaderboardsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668056);
    PlatformInterface.NativeMethodInfoPtr_GetLobbyInterface_Public_LobbyInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668057);
    PlatformInterface.NativeMethodInfoPtr_GetMetricsInterface_Public_MetricsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668058);
    PlatformInterface.NativeMethodInfoPtr_GetModsInterface_Public_ModsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668059);
    PlatformInterface.NativeMethodInfoPtr_GetOverrideCountryCode_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668060);
    PlatformInterface.NativeMethodInfoPtr_GetOverrideLocaleCode_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668061);
    PlatformInterface.NativeMethodInfoPtr_GetP2PInterface_Public_P2PInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668062);
    PlatformInterface.NativeMethodInfoPtr_GetPlayerDataStorageInterface_Public_PlayerDataStorageInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668063);
    PlatformInterface.NativeMethodInfoPtr_GetPresenceInterface_Public_PresenceInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668064);
    PlatformInterface.NativeMethodInfoPtr_GetProgressionSnapshotInterface_Public_ProgressionSnapshotInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668065);
    PlatformInterface.NativeMethodInfoPtr_GetRTCAdminInterface_Public_RTCAdminInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668066);
    PlatformInterface.NativeMethodInfoPtr_GetRTCInterface_Public_RTCInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668067);
    PlatformInterface.NativeMethodInfoPtr_GetReportsInterface_Public_ReportsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668068);
    PlatformInterface.NativeMethodInfoPtr_GetSanctionsInterface_Public_SanctionsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668069);
    PlatformInterface.NativeMethodInfoPtr_GetSessionsInterface_Public_SessionsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668070);
    PlatformInterface.NativeMethodInfoPtr_GetStatsInterface_Public_StatsInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668071);
    PlatformInterface.NativeMethodInfoPtr_GetTitleStorageInterface_Public_TitleStorageInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668072);
    PlatformInterface.NativeMethodInfoPtr_GetUIInterface_Public_UIInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668073);
    PlatformInterface.NativeMethodInfoPtr_GetUserInfoInterface_Public_UserInfoInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668074);
    PlatformInterface.NativeMethodInfoPtr_Initialize_Public_Static_Result_InitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668075);
    PlatformInterface.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668076);
    PlatformInterface.NativeMethodInfoPtr_SetOverrideCountryCode_Public_Result_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668077);
    PlatformInterface.NativeMethodInfoPtr_SetOverrideLocaleCode_Public_Result_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668078);
    PlatformInterface.NativeMethodInfoPtr_Shutdown_Public_Static_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668079);
    PlatformInterface.NativeMethodInfoPtr_Tick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668080);
    PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_WindowsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr, 100668081);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlatformInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformInterface>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385695, XrefRangeEnd = 385696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CheckForLauncherAndRestart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_CheckForLauncherAndRestart_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385696, XrefRangeEnd = 385707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlatformInterface Create(Options options)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_Options_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (PlatformInterface) null : Il2CppObjectPool.Get<PlatformInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385707, XrefRangeEnd = 385714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AchievementsInterface GetAchievementsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAchievementsInterface_Public_AchievementsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AchievementsInterface) null : Il2CppObjectPool.Get<AchievementsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385714, XrefRangeEnd = 385722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetActiveCountryCode(EpicAccountId localUserId, out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetActiveCountryCode_Public_Result_EpicAccountId_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385722, XrefRangeEnd = 385730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetActiveLocaleCode(EpicAccountId localUserId, out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetActiveLocaleCode_Public_Result_EpicAccountId_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385730, XrefRangeEnd = 385737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AntiCheatClientInterface GetAntiCheatClientInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAntiCheatClientInterface_Public_AntiCheatClientInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AntiCheatClientInterface) null : Il2CppObjectPool.Get<AntiCheatClientInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385737, XrefRangeEnd = 385744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AntiCheatServerInterface GetAntiCheatServerInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAntiCheatServerInterface_Public_AntiCheatServerInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AntiCheatServerInterface) null : Il2CppObjectPool.Get<AntiCheatServerInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385744, XrefRangeEnd = 385751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AuthInterface GetAuthInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetAuthInterface_Public_AuthInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AuthInterface) null : Il2CppObjectPool.Get<AuthInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385751, XrefRangeEnd = 385758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ConnectInterface GetConnectInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetConnectInterface_Public_ConnectInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ConnectInterface) null : Il2CppObjectPool.Get<ConnectInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385758, XrefRangeEnd = 385765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomInvitesInterface GetCustomInvitesInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetCustomInvitesInterface_Public_CustomInvitesInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (CustomInvitesInterface) null : Il2CppObjectPool.Get<CustomInvitesInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385765, XrefRangeEnd = 385772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EcomInterface GetEcomInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetEcomInterface_Public_EcomInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (EcomInterface) null : Il2CppObjectPool.Get<EcomInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385772, XrefRangeEnd = 385779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FriendsInterface GetFriendsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetFriendsInterface_Public_FriendsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FriendsInterface) null : Il2CppObjectPool.Get<FriendsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385779, XrefRangeEnd = 385786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe KWSInterface GetKWSInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetKWSInterface_Public_KWSInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (KWSInterface) null : Il2CppObjectPool.Get<KWSInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385786, XrefRangeEnd = 385793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderboardsInterface GetLeaderboardsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetLeaderboardsInterface_Public_LeaderboardsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (LeaderboardsInterface) null : Il2CppObjectPool.Get<LeaderboardsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385793, XrefRangeEnd = 385800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbyInterface GetLobbyInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetLobbyInterface_Public_LobbyInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (LobbyInterface) null : Il2CppObjectPool.Get<LobbyInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385800, XrefRangeEnd = 385807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MetricsInterface GetMetricsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetMetricsInterface_Public_MetricsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MetricsInterface) null : Il2CppObjectPool.Get<MetricsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385807, XrefRangeEnd = 385814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModsInterface GetModsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetModsInterface_Public_ModsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ModsInterface) null : Il2CppObjectPool.Get<ModsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385814, XrefRangeEnd = 385821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetOverrideCountryCode(out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetOverrideCountryCode_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385821, XrefRangeEnd = 385828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetOverrideLocaleCode(out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetOverrideLocaleCode_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385828, XrefRangeEnd = 385835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe P2PInterface GetP2PInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetP2PInterface_Public_P2PInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (P2PInterface) null : Il2CppObjectPool.Get<P2PInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385835, XrefRangeEnd = 385842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerDataStorageInterface GetPlayerDataStorageInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetPlayerDataStorageInterface_Public_PlayerDataStorageInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (PlayerDataStorageInterface) null : Il2CppObjectPool.Get<PlayerDataStorageInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385842, XrefRangeEnd = 385849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresenceInterface GetPresenceInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetPresenceInterface_Public_PresenceInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (PresenceInterface) null : Il2CppObjectPool.Get<PresenceInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385849, XrefRangeEnd = 385856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProgressionSnapshotInterface GetProgressionSnapshotInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetProgressionSnapshotInterface_Public_ProgressionSnapshotInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ProgressionSnapshotInterface) null : Il2CppObjectPool.Get<ProgressionSnapshotInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385856, XrefRangeEnd = 385863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RTCAdminInterface GetRTCAdminInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetRTCAdminInterface_Public_RTCAdminInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (RTCAdminInterface) null : Il2CppObjectPool.Get<RTCAdminInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385863, XrefRangeEnd = 385870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RTCInterface GetRTCInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetRTCInterface_Public_RTCInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (RTCInterface) null : Il2CppObjectPool.Get<RTCInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385870, XrefRangeEnd = 385877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ReportsInterface GetReportsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetReportsInterface_Public_ReportsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ReportsInterface) null : Il2CppObjectPool.Get<ReportsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385877, XrefRangeEnd = 385884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SanctionsInterface GetSanctionsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetSanctionsInterface_Public_SanctionsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SanctionsInterface) null : Il2CppObjectPool.Get<SanctionsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385884, XrefRangeEnd = 385891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SessionsInterface GetSessionsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetSessionsInterface_Public_SessionsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SessionsInterface) null : Il2CppObjectPool.Get<SessionsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385891, XrefRangeEnd = 385898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsInterface GetStatsInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetStatsInterface_Public_StatsInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (StatsInterface) null : Il2CppObjectPool.Get<StatsInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385898, XrefRangeEnd = 385905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TitleStorageInterface GetTitleStorageInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetTitleStorageInterface_Public_TitleStorageInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (TitleStorageInterface) null : Il2CppObjectPool.Get<TitleStorageInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385905, XrefRangeEnd = 385912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIInterface GetUIInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetUIInterface_Public_UIInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (UIInterface) null : Il2CppObjectPool.Get<UIInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385912, XrefRangeEnd = 385919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UserInfoInterface GetUserInfoInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_GetUserInfoInterface_Public_UserInfoInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (UserInfoInterface) null : Il2CppObjectPool.Get<UserInfoInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385919, XrefRangeEnd = 385927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Result Initialize(InitializeOptions options)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Initialize_Public_Static_Result_InitializeOptions_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385927, XrefRangeEnd = 385928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385928, XrefRangeEnd = 385934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetOverrideCountryCode(string newCountryCode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(newCountryCode)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_SetOverrideCountryCode_Public_Result_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385934, XrefRangeEnd = 385940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetOverrideLocaleCode(string newLocaleCode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(newLocaleCode)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_SetOverrideLocaleCode_Public_Result_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385940, XrefRangeEnd = 385941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Result Shutdown()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Shutdown_Public_Static_Result_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385941, XrefRangeEnd = 385942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Tick()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Tick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385942, XrefRangeEnd = 385953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlatformInterface Create(WindowsOptions options)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformInterface.NativeMethodInfoPtr_Create_Public_Static_PlatformInterface_WindowsOptions_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (PlatformInterface) null : Il2CppObjectPool.Get<PlatformInterface>(num3);
  }

  public static unsafe int CountrycodeMaxBufferLen
  {
    get
    {
      int countrycodeMaxBufferLen;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxBufferLen, (void*) &countrycodeMaxBufferLen);
      return countrycodeMaxBufferLen;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxBufferLen, (void*) &value);
    }
  }

  public static unsafe int CountrycodeMaxLength
  {
    get
    {
      int countrycodeMaxLength;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxLength, (void*) &countrycodeMaxLength);
      return countrycodeMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_CountrycodeMaxLength, (void*) &value);
    }
  }

  public static unsafe int InitializeApiLatest
  {
    get
    {
      int initializeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_InitializeApiLatest, (void*) &initializeApiLatest);
      return initializeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_InitializeApiLatest, (void*) &value);
    }
  }

  public static unsafe int InitializeThreadaffinityApiLatest
  {
    get
    {
      int threadaffinityApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_InitializeThreadaffinityApiLatest, (void*) &threadaffinityApiLatest);
      return threadaffinityApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_InitializeThreadaffinityApiLatest, (void*) &value);
    }
  }

  public static unsafe int LocalecodeMaxBufferLen
  {
    get
    {
      int localecodeMaxBufferLen;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxBufferLen, (void*) &localecodeMaxBufferLen);
      return localecodeMaxBufferLen;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxBufferLen, (void*) &value);
    }
  }

  public static unsafe int LocalecodeMaxLength
  {
    get
    {
      int localecodeMaxLength;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxLength, (void*) &localecodeMaxLength);
      return localecodeMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_LocalecodeMaxLength, (void*) &value);
    }
  }

  public static unsafe int OptionsApiLatest
  {
    get
    {
      int optionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_OptionsApiLatest, (void*) &optionsApiLatest);
      return optionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_OptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int RtcoptionsApiLatest
  {
    get
    {
      int rtcoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_RtcoptionsApiLatest, (void*) &rtcoptionsApiLatest);
      return rtcoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_RtcoptionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest
  {
    get
    {
      int windowsrtcoptionsplatformspecificoptionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PlatformInterface.NativeFieldInfoPtr_PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest, (void*) &windowsrtcoptionsplatformspecificoptionsApiLatest);
      return windowsrtcoptionsplatformspecificoptionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformInterface.NativeFieldInfoPtr_PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest, (void*) &value);
    }
  }
}
