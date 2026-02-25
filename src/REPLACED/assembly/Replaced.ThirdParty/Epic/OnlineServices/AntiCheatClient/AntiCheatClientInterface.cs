// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.AntiCheatClientInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient;

public sealed class AntiCheatClientInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndsessionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PeerSelf;
  private static readonly System.IntPtr NativeFieldInfoPtr_PollstatusApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProtectmessageApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReceivemessagefromserverApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RegisterpeerApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnprotectmessageApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterpeerApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddExternalIntegrityCatalog_Public_Result_AddExternalIntegrityCatalogOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyMessageToPeer_Public_UInt64_AddNotifyMessageToPeerOptions_Object_OnMessageToPeerCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyMessageToServer_Public_UInt64_AddNotifyMessageToServerOptions_Object_OnMessageToServerCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerActionRequired_Public_UInt64_AddNotifyPeerActionRequiredOptions_Object_OnPeerActionRequiredCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerAuthStatusChanged_Public_UInt64_AddNotifyPeerAuthStatusChangedOptions_Object_OnPeerAuthStatusChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginSession_Public_Result_BeginSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndSession_Public_Result_EndSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_GetProtectMessageOutputLengthOptions_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PollStatus_Public_Result_PollStatusOptions_byref_AntiCheatClientViolationType_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProtectMessage_Public_Result_ProtectMessageOptions_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessageFromPeer_Public_Result_ReceiveMessageFromPeerOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessageFromServer_Public_Result_ReceiveMessageFromServerOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPeer_Public_Result_RegisterPeerOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyMessageToPeer_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyMessageToServer_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerActionRequired_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerAuthStatusChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnprotectMessage_Public_Result_UnprotectMessageOptions_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPeer_Public_Result_UnregisterPeerOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnMessageToPeerCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnMessageToServerCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerActionRequiredCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static AntiCheatClientInterface()
  {
    Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (AntiCheatClientInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr);
    AntiCheatClientInterface.NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddexternalintegritycatalogApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifymessagetopeerApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifymessagetoserverApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifypeeractionrequiredApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifypeerauthstatuschangedApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_BeginsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (BeginsessionApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_EndsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (EndsessionApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (GetprotectmessageoutputlengthApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_PeerSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (PeerSelf));
    AntiCheatClientInterface.NativeFieldInfoPtr_PollstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (PollstatusApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_ProtectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (ProtectmessageApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (ReceivemessagefrompeerApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefromserverApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (ReceivemessagefromserverApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (RegisterpeerApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (UnprotectmessageApiLatest));
    AntiCheatClientInterface.NativeFieldInfoPtr_UnregisterpeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (UnregisterpeerApiLatest));
    AntiCheatClientInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673029);
    AntiCheatClientInterface.NativeMethodInfoPtr_AddExternalIntegrityCatalog_Public_Result_AddExternalIntegrityCatalogOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673031);
    AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToPeer_Public_UInt64_AddNotifyMessageToPeerOptions_Object_OnMessageToPeerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673032);
    AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToServer_Public_UInt64_AddNotifyMessageToServerOptions_Object_OnMessageToServerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673033);
    AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerActionRequired_Public_UInt64_AddNotifyPeerActionRequiredOptions_Object_OnPeerActionRequiredCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673034);
    AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerAuthStatusChanged_Public_UInt64_AddNotifyPeerAuthStatusChangedOptions_Object_OnPeerAuthStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673035);
    AntiCheatClientInterface.NativeMethodInfoPtr_BeginSession_Public_Result_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673036);
    AntiCheatClientInterface.NativeMethodInfoPtr_EndSession_Public_Result_EndSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673037);
    AntiCheatClientInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_GetProtectMessageOutputLengthOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673038);
    AntiCheatClientInterface.NativeMethodInfoPtr_PollStatus_Public_Result_PollStatusOptions_byref_AntiCheatClientViolationType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673039);
    AntiCheatClientInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_ProtectMessageOptions_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673040);
    AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromPeer_Public_Result_ReceiveMessageFromPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673041);
    AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromServer_Public_Result_ReceiveMessageFromServerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673042);
    AntiCheatClientInterface.NativeMethodInfoPtr_RegisterPeer_Public_Result_RegisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673043);
    AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToPeer_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673044);
    AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToServer_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673045);
    AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerActionRequired_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673046);
    AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerAuthStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673047);
    AntiCheatClientInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_UnprotectMessageOptions_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673048);
    AntiCheatClientInterface.NativeMethodInfoPtr_UnregisterPeer_Public_Result_UnregisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673049);
    AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToPeerCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673050);
    AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToServerCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673051);
    AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerActionRequiredCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673052);
    AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100673053);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401100, XrefRangeEnd = 401102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AntiCheatClientInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401102, XrefRangeEnd = 401110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AddExternalIntegrityCatalog(AddExternalIntegrityCatalogOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddExternalIntegrityCatalog_Public_Result_AddExternalIntegrityCatalogOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401110, XrefRangeEnd = 401129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyMessageToPeer(
    AddNotifyMessageToPeerOptions options,
    Il2CppSystem.Object clientData,
    OnMessageToPeerCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToPeer_Public_UInt64_AddNotifyMessageToPeerOptions_Object_OnMessageToPeerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401129, XrefRangeEnd = 401148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyMessageToServer(
    AddNotifyMessageToServerOptions options,
    Il2CppSystem.Object clientData,
    OnMessageToServerCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToServer_Public_UInt64_AddNotifyMessageToServerOptions_Object_OnMessageToServerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401148, XrefRangeEnd = 401167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyPeerActionRequired(
    AddNotifyPeerActionRequiredOptions options,
    Il2CppSystem.Object clientData,
    OnPeerActionRequiredCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerActionRequired_Public_UInt64_AddNotifyPeerActionRequiredOptions_Object_OnPeerActionRequiredCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401167, XrefRangeEnd = 401186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyPeerAuthStatusChanged(
    AddNotifyPeerAuthStatusChangedOptions options,
    Il2CppSystem.Object clientData,
    OnPeerAuthStatusChangedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerAuthStatusChanged_Public_UInt64_AddNotifyPeerAuthStatusChangedOptions_Object_OnPeerAuthStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401186, XrefRangeEnd = 401194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result BeginSession(BeginSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_BeginSession_Public_Result_BeginSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401194, XrefRangeEnd = 401202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result EndSession(EndSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_EndSession_Public_Result_EndSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401202, XrefRangeEnd = 401213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetProtectMessageOutputLength(
    GetProtectMessageOutputLengthOptions options,
    out uint outBufferSizeBytes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBufferSizeBytes;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_GetProtectMessageOutputLengthOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401213, XrefRangeEnd = 401227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result PollStatus(
    PollStatusOptions options,
    out AntiCheatClientViolationType outViolationType,
    out string outMessage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outViolationType;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_PollStatus_Public_Result_PollStatusOptions_byref_AntiCheatClientViolationType_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outMessage = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401227, XrefRangeEnd = 401240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_ProtectMessageOptions_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref outBuffer;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401240, XrefRangeEnd = 401248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ReceiveMessageFromPeer(ReceiveMessageFromPeerOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromPeer_Public_Result_ReceiveMessageFromPeerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401248, XrefRangeEnd = 401256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ReceiveMessageFromServer(ReceiveMessageFromServerOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromServer_Public_Result_ReceiveMessageFromServerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401256, XrefRangeEnd = 401264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RegisterPeer(RegisterPeerOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RegisterPeer_Public_Result_RegisterPeerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401264, XrefRangeEnd = 401269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyMessageToPeer(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToPeer_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401269, XrefRangeEnd = 401274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyMessageToServer(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToServer_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401274, XrefRangeEnd = 401279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyPeerActionRequired(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerActionRequired_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401279, XrefRangeEnd = 401284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyPeerAuthStatusChanged(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerAuthStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401284, XrefRangeEnd = 401297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_UnprotectMessageOptions_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref outBuffer;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401297, XrefRangeEnd = 401305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result UnregisterPeer(UnregisterPeerOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_UnregisterPeer_Public_Result_UnregisterPeerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401305, XrefRangeEnd = 401311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnMessageToPeerCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToPeerCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401311, XrefRangeEnd = 401317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnMessageToServerCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToServerCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401317, XrefRangeEnd = 401323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnPeerActionRequiredCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerActionRequiredCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401323, XrefRangeEnd = 401329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnPeerAuthStatusChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddexternalintegritycatalogApiLatest
  {
    get
    {
      int addexternalintegritycatalogApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest, (void*) &addexternalintegritycatalogApiLatest);
      return addexternalintegritycatalogApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifymessagetopeerApiLatest
  {
    get
    {
      int addnotifymessagetopeerApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest, (void*) &addnotifymessagetopeerApiLatest);
      return addnotifymessagetopeerApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifymessagetoserverApiLatest
  {
    get
    {
      int addnotifymessagetoserverApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest, (void*) &addnotifymessagetoserverApiLatest);
      return addnotifymessagetoserverApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifypeeractionrequiredApiLatest
  {
    get
    {
      int addnotifypeeractionrequiredApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest, (void*) &addnotifypeeractionrequiredApiLatest);
      return addnotifypeeractionrequiredApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifypeerauthstatuschangedApiLatest
  {
    get
    {
      int addnotifypeerauthstatuschangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest, (void*) &addnotifypeerauthstatuschangedApiLatest);
      return addnotifypeerauthstatuschangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int BeginsessionApiLatest
  {
    get
    {
      int beginsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &beginsessionApiLatest);
      return beginsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int EndsessionApiLatest
  {
    get
    {
      int endsessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &endsessionApiLatest);
      return endsessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetprotectmessageoutputlengthApiLatest
  {
    get
    {
      int getprotectmessageoutputlengthApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &getprotectmessageoutputlengthApiLatest);
      return getprotectmessageoutputlengthApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &value);
    }
  }

  public unsafe System.IntPtr PeerSelf
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiCheatClientInterface.NativeFieldInfoPtr_PeerSelf));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiCheatClientInterface.NativeFieldInfoPtr_PeerSelf)) = value;
    }
  }

  public static unsafe int PollstatusApiLatest
  {
    get
    {
      int pollstatusApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_PollstatusApiLatest, (void*) &pollstatusApiLatest);
      return pollstatusApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_PollstatusApiLatest, (void*) &value);
    }
  }

  public static unsafe int ProtectmessageApiLatest
  {
    get
    {
      int protectmessageApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &protectmessageApiLatest);
      return protectmessageApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReceivemessagefrompeerApiLatest
  {
    get
    {
      int receivemessagefrompeerApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest, (void*) &receivemessagefrompeerApiLatest);
      return receivemessagefrompeerApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReceivemessagefromserverApiLatest
  {
    get
    {
      int receivemessagefromserverApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefromserverApiLatest, (void*) &receivemessagefromserverApiLatest);
      return receivemessagefromserverApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefromserverApiLatest, (void*) &value);
    }
  }

  public static unsafe int RegisterpeerApiLatest
  {
    get
    {
      int registerpeerApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerApiLatest, (void*) &registerpeerApiLatest);
      return registerpeerApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnprotectmessageApiLatest
  {
    get
    {
      int unprotectmessageApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &unprotectmessageApiLatest);
      return unprotectmessageApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnregisterpeerApiLatest
  {
    get
    {
      int unregisterpeerApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnregisterpeerApiLatest, (void*) &unregisterpeerApiLatest);
      return unregisterpeerApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnregisterpeerApiLatest, (void*) &value);
    }
  }
}
