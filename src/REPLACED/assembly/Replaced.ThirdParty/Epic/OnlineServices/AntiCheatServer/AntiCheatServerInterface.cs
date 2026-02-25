// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.AntiCheatServerInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer;

public sealed class AntiCheatServerInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionMaxRegistertimeout;
  private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionMinRegistertimeout;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProtectmessageApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReceivemessagefromclientApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RegisterclientApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetclientnetworkstateApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnprotectmessageApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterclientApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyClientActionRequired_Public_UInt64_AddNotifyClientActionRequiredOptions_Object_OnClientActionRequiredCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyClientAuthStatusChanged_Public_UInt64_AddNotifyClientAuthStatusChangedOptions_Object_OnClientAuthStatusChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyMessageToClient_Public_UInt64_AddNotifyMessageToClientOptions_Object_OnMessageToClientCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginSession_Public_Result_BeginSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndSession_Public_Result_EndSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_GetProtectMessageOutputLengthOptions_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogEvent_Public_Result_LogEventOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogGameRoundEnd_Public_Result_LogGameRoundEndOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogGameRoundStart_Public_Result_LogGameRoundStartOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerDespawn_Public_Result_LogPlayerDespawnOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerRevive_Public_Result_LogPlayerReviveOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerSpawn_Public_Result_LogPlayerSpawnOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerTakeDamage_Public_Result_LogPlayerTakeDamageOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerTick_Public_Result_LogPlayerTickOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerUseAbility_Public_Result_LogPlayerUseAbilityOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerUseWeapon_Public_Result_LogPlayerUseWeaponOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProtectMessage_Public_Result_ProtectMessageOptions_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessageFromClient_Public_Result_ReceiveMessageFromClientOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterClient_Public_Result_RegisterClientOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEvent_Public_Result_RegisterEventOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyClientActionRequired_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyClientAuthStatusChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyMessageToClient_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetClientDetails_Public_Result_SetClientDetailsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetClientNetworkState_Public_Result_SetClientNetworkStateOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGameSessionId_Public_Result_SetGameSessionIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnprotectMessage_Public_Result_UnprotectMessageOptions_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterClient_Public_Result_UnregisterClientOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnClientActionRequiredCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnClientAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnMessageToClientCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static AntiCheatServerInterface()
  {
    Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatServer", nameof (AntiCheatServerInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr);
    AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (AddnotifyclientactionrequiredApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (AddnotifyclientauthstatuschangedApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (AddnotifymessagetoclientApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (BeginsessionApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMaxRegistertimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (BeginsessionMaxRegistertimeout));
    AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMinRegistertimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (BeginsessionMinRegistertimeout));
    AntiCheatServerInterface.NativeFieldInfoPtr_EndsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (EndsessionApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (GetprotectmessageoutputlengthApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_ProtectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (ProtectmessageApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_ReceivemessagefromclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (ReceivemessagefromclientApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_RegisterclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (RegisterclientApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_SetclientnetworkstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (SetclientnetworkstateApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (UnprotectmessageApiLatest));
    AntiCheatServerInterface.NativeFieldInfoPtr_UnregisterclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (UnregisterclientApiLatest));
    AntiCheatServerInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672455);
    AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientActionRequired_Public_UInt64_AddNotifyClientActionRequiredOptions_Object_OnClientActionRequiredCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672457);
    AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientAuthStatusChanged_Public_UInt64_AddNotifyClientAuthStatusChangedOptions_Object_OnClientAuthStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672458);
    AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyMessageToClient_Public_UInt64_AddNotifyMessageToClientOptions_Object_OnMessageToClientCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672459);
    AntiCheatServerInterface.NativeMethodInfoPtr_BeginSession_Public_Result_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672460);
    AntiCheatServerInterface.NativeMethodInfoPtr_EndSession_Public_Result_EndSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672461);
    AntiCheatServerInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_GetProtectMessageOutputLengthOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672462);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogEvent_Public_Result_LogEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672463);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundEnd_Public_Result_LogGameRoundEndOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672464);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundStart_Public_Result_LogGameRoundStartOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672465);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerDespawn_Public_Result_LogPlayerDespawnOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672466);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerRevive_Public_Result_LogPlayerReviveOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672467);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerSpawn_Public_Result_LogPlayerSpawnOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672468);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTakeDamage_Public_Result_LogPlayerTakeDamageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672469);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTick_Public_Result_LogPlayerTickOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672470);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseAbility_Public_Result_LogPlayerUseAbilityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672471);
    AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseWeapon_Public_Result_LogPlayerUseWeaponOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672472);
    AntiCheatServerInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_ProtectMessageOptions_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672473);
    AntiCheatServerInterface.NativeMethodInfoPtr_ReceiveMessageFromClient_Public_Result_ReceiveMessageFromClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672474);
    AntiCheatServerInterface.NativeMethodInfoPtr_RegisterClient_Public_Result_RegisterClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672475);
    AntiCheatServerInterface.NativeMethodInfoPtr_RegisterEvent_Public_Result_RegisterEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672476);
    AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientActionRequired_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672477);
    AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientAuthStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672478);
    AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyMessageToClient_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672479);
    AntiCheatServerInterface.NativeMethodInfoPtr_SetClientDetails_Public_Result_SetClientDetailsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672480);
    AntiCheatServerInterface.NativeMethodInfoPtr_SetClientNetworkState_Public_Result_SetClientNetworkStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672481);
    AntiCheatServerInterface.NativeMethodInfoPtr_SetGameSessionId_Public_Result_SetGameSessionIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672482);
    AntiCheatServerInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_UnprotectMessageOptions_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672483);
    AntiCheatServerInterface.NativeMethodInfoPtr_UnregisterClient_Public_Result_UnregisterClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672484);
    AntiCheatServerInterface.NativeMethodInfoPtr_OnClientActionRequiredCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672485);
    AntiCheatServerInterface.NativeMethodInfoPtr_OnClientAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672486);
    AntiCheatServerInterface.NativeMethodInfoPtr_OnMessageToClientCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100672487);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AntiCheatServerInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399474, XrefRangeEnd = 399494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyClientActionRequired(
    AddNotifyClientActionRequiredOptions options,
    Il2CppSystem.Object clientData,
    OnClientActionRequiredCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientActionRequired_Public_UInt64_AddNotifyClientActionRequiredOptions_Object_OnClientActionRequiredCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399494, XrefRangeEnd = 399514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyClientAuthStatusChanged(
    AddNotifyClientAuthStatusChangedOptions options,
    Il2CppSystem.Object clientData,
    OnClientAuthStatusChangedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientAuthStatusChanged_Public_UInt64_AddNotifyClientAuthStatusChangedOptions_Object_OnClientAuthStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399514, XrefRangeEnd = 399534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyMessageToClient(
    AddNotifyMessageToClientOptions options,
    Il2CppSystem.Object clientData,
    OnMessageToClientCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyMessageToClient_Public_UInt64_AddNotifyMessageToClientOptions_Object_OnMessageToClientCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399534, XrefRangeEnd = 399542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result BeginSession(BeginSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_BeginSession_Public_Result_BeginSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399542, XrefRangeEnd = 399550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result EndSession(EndSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_EndSession_Public_Result_EndSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399550, XrefRangeEnd = 399561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetProtectMessageOutputLength(
    GetProtectMessageOutputLengthOptions options,
    out uint outBufferSizeBytes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBufferSizeBytes;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_GetProtectMessageOutputLengthOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399561, XrefRangeEnd = 399569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogEvent(LogEventOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogEvent_Public_Result_LogEventOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399569, XrefRangeEnd = 399577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogGameRoundEnd(LogGameRoundEndOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundEnd_Public_Result_LogGameRoundEndOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399577, XrefRangeEnd = 399585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogGameRoundStart(LogGameRoundStartOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundStart_Public_Result_LogGameRoundStartOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399585, XrefRangeEnd = 399593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerDespawn(LogPlayerDespawnOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerDespawn_Public_Result_LogPlayerDespawnOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399593, XrefRangeEnd = 399601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerRevive(LogPlayerReviveOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerRevive_Public_Result_LogPlayerReviveOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399601, XrefRangeEnd = 399609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerSpawn(LogPlayerSpawnOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerSpawn_Public_Result_LogPlayerSpawnOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399609, XrefRangeEnd = 399617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerTakeDamage(LogPlayerTakeDamageOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTakeDamage_Public_Result_LogPlayerTakeDamageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399617, XrefRangeEnd = 399625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerTick(LogPlayerTickOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTick_Public_Result_LogPlayerTickOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399625, XrefRangeEnd = 399633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerUseAbility(LogPlayerUseAbilityOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseAbility_Public_Result_LogPlayerUseAbilityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399633, XrefRangeEnd = 399641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result LogPlayerUseWeapon(LogPlayerUseWeaponOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseWeapon_Public_Result_LogPlayerUseWeaponOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399641, XrefRangeEnd = 399654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ProtectMessage(
    ProtectMessageOptions options,
    out Il2CppStructArray<byte> outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_ProtectMessageOptions_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref outBuffer;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399654, XrefRangeEnd = 399662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ReceiveMessageFromClient(ReceiveMessageFromClientOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_ReceiveMessageFromClient_Public_Result_ReceiveMessageFromClientOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399662, XrefRangeEnd = 399670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RegisterClient(RegisterClientOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RegisterClient_Public_Result_RegisterClientOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399670, XrefRangeEnd = 399678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RegisterEvent(RegisterEventOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RegisterEvent_Public_Result_RegisterEventOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399678, XrefRangeEnd = 399683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyClientActionRequired(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientActionRequired_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399683, XrefRangeEnd = 399688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyClientAuthStatusChanged(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientAuthStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399688, XrefRangeEnd = 399693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyMessageToClient(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyMessageToClient_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399693, XrefRangeEnd = 399701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetClientDetails(SetClientDetailsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_SetClientDetails_Public_Result_SetClientDetailsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399701, XrefRangeEnd = 399709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetClientNetworkState(SetClientNetworkStateOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_SetClientNetworkState_Public_Result_SetClientNetworkStateOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399709, XrefRangeEnd = 399717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetGameSessionId(SetGameSessionIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_SetGameSessionId_Public_Result_SetGameSessionIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399717, XrefRangeEnd = 399730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result UnprotectMessage(
    UnprotectMessageOptions options,
    out Il2CppStructArray<byte> outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_UnprotectMessageOptions_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref outBuffer;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399730, XrefRangeEnd = 399738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result UnregisterClient(UnregisterClientOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_UnregisterClient_Public_Result_UnregisterClientOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399738, XrefRangeEnd = 399744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnClientActionRequiredCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_OnClientActionRequiredCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399744, XrefRangeEnd = 399750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnClientAuthStatusChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_OnClientAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399750, XrefRangeEnd = 399756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnMessageToClientCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_OnMessageToClientCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifyclientactionrequiredApiLatest
  {
    get
    {
      int addnotifyclientactionrequiredApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest, (void*) &addnotifyclientactionrequiredApiLatest);
      return addnotifyclientactionrequiredApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyclientauthstatuschangedApiLatest
  {
    get
    {
      int addnotifyclientauthstatuschangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest, (void*) &addnotifyclientauthstatuschangedApiLatest);
      return addnotifyclientauthstatuschangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifymessagetoclientApiLatest
  {
    get
    {
      int addnotifymessagetoclientApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest, (void*) &addnotifymessagetoclientApiLatest);
      return addnotifymessagetoclientApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest, (void*) &value);
    }
  }

  public static unsafe int BeginsessionApiLatest
  {
    get
    {
      int beginsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &beginsessionApiLatest);
      return beginsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int BeginsessionMaxRegistertimeout
  {
    get
    {
      int maxRegistertimeout;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMaxRegistertimeout, (void*) &maxRegistertimeout);
      return maxRegistertimeout;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMaxRegistertimeout, (void*) &value);
    }
  }

  public static unsafe int BeginsessionMinRegistertimeout
  {
    get
    {
      int minRegistertimeout;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMinRegistertimeout, (void*) &minRegistertimeout);
      return minRegistertimeout;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMinRegistertimeout, (void*) &value);
    }
  }

  public static unsafe int EndsessionApiLatest
  {
    get
    {
      int endsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &endsessionApiLatest);
      return endsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetprotectmessageoutputlengthApiLatest
  {
    get
    {
      int getprotectmessageoutputlengthApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &getprotectmessageoutputlengthApiLatest);
      return getprotectmessageoutputlengthApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &value);
    }
  }

  public static unsafe int ProtectmessageApiLatest
  {
    get
    {
      int protectmessageApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &protectmessageApiLatest);
      return protectmessageApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReceivemessagefromclientApiLatest
  {
    get
    {
      int receivemessagefromclientApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_ReceivemessagefromclientApiLatest, (void*) &receivemessagefromclientApiLatest);
      return receivemessagefromclientApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_ReceivemessagefromclientApiLatest, (void*) &value);
    }
  }

  public static unsafe int RegisterclientApiLatest
  {
    get
    {
      int registerclientApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_RegisterclientApiLatest, (void*) &registerclientApiLatest);
      return registerclientApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_RegisterclientApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetclientnetworkstateApiLatest
  {
    get
    {
      int setclientnetworkstateApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_SetclientnetworkstateApiLatest, (void*) &setclientnetworkstateApiLatest);
      return setclientnetworkstateApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_SetclientnetworkstateApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnprotectmessageApiLatest
  {
    get
    {
      int unprotectmessageApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &unprotectmessageApiLatest);
      return unprotectmessageApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnregisterclientApiLatest
  {
    get
    {
      int unregisterclientApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnregisterclientApiLatest, (void*) &unregisterclientApiLatest);
      return unregisterclientApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnregisterclientApiLatest, (void*) &value);
    }
  }
}
