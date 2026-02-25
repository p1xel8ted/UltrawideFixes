// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.P2PInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

public sealed class P2PInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AcceptconnectionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ClearpacketqueueApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CloseconnectionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CloseconnectionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetnattypeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetpacketqueueinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetportrangeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetrelaycontrolApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxConnections;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxPacketSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxQueueSizeUnlimited;
  private static readonly System.IntPtr NativeFieldInfoPtr_QuerynattypeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReceivepacketApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SendpacketApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetpacketqueuesizeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetportrangeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetrelaycontrolApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SocketidApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AcceptConnection_Public_Result_AcceptConnectionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyIncomingPacketQueueFull_Public_UInt64_AddNotifyIncomingPacketQueueFullOptions_Object_OnIncomingPacketQueueFullCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionClosed_Public_UInt64_AddNotifyPeerConnectionClosedOptions_Object_OnRemoteConnectionClosedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionEstablished_Public_UInt64_AddNotifyPeerConnectionEstablishedOptions_Object_OnPeerConnectionEstablishedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionRequest_Public_UInt64_AddNotifyPeerConnectionRequestOptions_Object_OnIncomingConnectionRequestCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearPacketQueue_Public_Result_ClearPacketQueueOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloseConnection_Public_Result_CloseConnectionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloseConnections_Public_Result_CloseConnectionsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNATType_Public_Result_GetNATTypeOptions_byref_NATType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNextReceivedPacketSize_Public_Result_GetNextReceivedPacketSizeOptions_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPacketQueueInfo_Public_Result_GetPacketQueueInfoOptions_byref_PacketQueueInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPortRange_Public_Result_GetPortRangeOptions_byref_UInt16_byref_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRelayControl_Public_Result_GetRelayControlOptions_byref_RelayControl_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryNATType_Public_Void_QueryNATTypeOptions_Object_OnQueryNATTypeCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePacket_Public_Result_ReceivePacketOptions_byref_ProductUserId_byref_SocketId_byref_Byte_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyIncomingPacketQueueFull_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionClosed_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionEstablished_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionRequest_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendPacket_Public_Result_SendPacketOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPacketQueueSize_Public_Result_SetPacketQueueSizeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPortRange_Public_Result_SetPortRangeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRelayControl_Public_Result_SetRelayControlOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnIncomingConnectionRequestCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnIncomingPacketQueueFullCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerConnectionEstablishedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryNATTypeCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteConnectionClosedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static P2PInterface()
  {
    Il2CppClassPointerStore<P2PInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (P2PInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr);
    P2PInterface.NativeFieldInfoPtr_AcceptconnectionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AcceptconnectionApiLatest));
    P2PInterface.NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifyincomingpacketqueuefullApiLatest));
    P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectionclosedApiLatest));
    P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectionestablishedApiLatest));
    P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectionrequestApiLatest));
    P2PInterface.NativeFieldInfoPtr_ClearpacketqueueApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (ClearpacketqueueApiLatest));
    P2PInterface.NativeFieldInfoPtr_CloseconnectionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (CloseconnectionApiLatest));
    P2PInterface.NativeFieldInfoPtr_CloseconnectionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (CloseconnectionsApiLatest));
    P2PInterface.NativeFieldInfoPtr_GetnattypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetnattypeApiLatest));
    P2PInterface.NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetnextreceivedpacketsizeApiLatest));
    P2PInterface.NativeFieldInfoPtr_GetpacketqueueinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetpacketqueueinfoApiLatest));
    P2PInterface.NativeFieldInfoPtr_GetportrangeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetportrangeApiLatest));
    P2PInterface.NativeFieldInfoPtr_GetrelaycontrolApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetrelaycontrolApiLatest));
    P2PInterface.NativeFieldInfoPtr_MaxConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (MaxConnections));
    P2PInterface.NativeFieldInfoPtr_MaxPacketSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (MaxPacketSize));
    P2PInterface.NativeFieldInfoPtr_MaxQueueSizeUnlimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (MaxQueueSizeUnlimited));
    P2PInterface.NativeFieldInfoPtr_QuerynattypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (QuerynattypeApiLatest));
    P2PInterface.NativeFieldInfoPtr_ReceivepacketApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (ReceivepacketApiLatest));
    P2PInterface.NativeFieldInfoPtr_SendpacketApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SendpacketApiLatest));
    P2PInterface.NativeFieldInfoPtr_SetpacketqueuesizeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SetpacketqueuesizeApiLatest));
    P2PInterface.NativeFieldInfoPtr_SetportrangeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SetportrangeApiLatest));
    P2PInterface.NativeFieldInfoPtr_SetrelaycontrolApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SetrelaycontrolApiLatest));
    P2PInterface.NativeFieldInfoPtr_SocketidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SocketidApiLatest));
    P2PInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668406);
    P2PInterface.NativeMethodInfoPtr_AcceptConnection_Public_Result_AcceptConnectionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668408);
    P2PInterface.NativeMethodInfoPtr_AddNotifyIncomingPacketQueueFull_Public_UInt64_AddNotifyIncomingPacketQueueFullOptions_Object_OnIncomingPacketQueueFullCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668409);
    P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionClosed_Public_UInt64_AddNotifyPeerConnectionClosedOptions_Object_OnRemoteConnectionClosedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668410);
    P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionEstablished_Public_UInt64_AddNotifyPeerConnectionEstablishedOptions_Object_OnPeerConnectionEstablishedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668411);
    P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionRequest_Public_UInt64_AddNotifyPeerConnectionRequestOptions_Object_OnIncomingConnectionRequestCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668412);
    P2PInterface.NativeMethodInfoPtr_ClearPacketQueue_Public_Result_ClearPacketQueueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668413);
    P2PInterface.NativeMethodInfoPtr_CloseConnection_Public_Result_CloseConnectionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668414);
    P2PInterface.NativeMethodInfoPtr_CloseConnections_Public_Result_CloseConnectionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668415);
    P2PInterface.NativeMethodInfoPtr_GetNATType_Public_Result_GetNATTypeOptions_byref_NATType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668416 /*0x06001400*/);
    P2PInterface.NativeMethodInfoPtr_GetNextReceivedPacketSize_Public_Result_GetNextReceivedPacketSizeOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668417);
    P2PInterface.NativeMethodInfoPtr_GetPacketQueueInfo_Public_Result_GetPacketQueueInfoOptions_byref_PacketQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668418);
    P2PInterface.NativeMethodInfoPtr_GetPortRange_Public_Result_GetPortRangeOptions_byref_UInt16_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668419);
    P2PInterface.NativeMethodInfoPtr_GetRelayControl_Public_Result_GetRelayControlOptions_byref_RelayControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668420);
    P2PInterface.NativeMethodInfoPtr_QueryNATType_Public_Void_QueryNATTypeOptions_Object_OnQueryNATTypeCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668421);
    P2PInterface.NativeMethodInfoPtr_ReceivePacket_Public_Result_ReceivePacketOptions_byref_ProductUserId_byref_SocketId_byref_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668422);
    P2PInterface.NativeMethodInfoPtr_RemoveNotifyIncomingPacketQueueFull_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668423);
    P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionClosed_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668424);
    P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionEstablished_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668425);
    P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionRequest_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668426);
    P2PInterface.NativeMethodInfoPtr_SendPacket_Public_Result_SendPacketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668427);
    P2PInterface.NativeMethodInfoPtr_SetPacketQueueSize_Public_Result_SetPacketQueueSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668428);
    P2PInterface.NativeMethodInfoPtr_SetPortRange_Public_Result_SetPortRangeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668429);
    P2PInterface.NativeMethodInfoPtr_SetRelayControl_Public_Result_SetRelayControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668430);
    P2PInterface.NativeMethodInfoPtr_OnIncomingConnectionRequestCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668431);
    P2PInterface.NativeMethodInfoPtr_OnIncomingPacketQueueFullCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668432);
    P2PInterface.NativeMethodInfoPtr_OnPeerConnectionEstablishedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668433);
    P2PInterface.NativeMethodInfoPtr_OnQueryNATTypeCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668434);
    P2PInterface.NativeMethodInfoPtr_OnRemoteConnectionClosedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100668435);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe P2PInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386800, XrefRangeEnd = 386808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AcceptConnection(AcceptConnectionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AcceptConnection_Public_Result_AcceptConnectionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386808, XrefRangeEnd = 386828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyIncomingPacketQueueFull(
    AddNotifyIncomingPacketQueueFullOptions options,
    Il2CppSystem.Object clientData,
    OnIncomingPacketQueueFullCallback incomingPacketQueueFullHandler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) incomingPacketQueueFullHandler);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyIncomingPacketQueueFull_Public_UInt64_AddNotifyIncomingPacketQueueFullOptions_Object_OnIncomingPacketQueueFullCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386828, XrefRangeEnd = 386848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyPeerConnectionClosed(
    AddNotifyPeerConnectionClosedOptions options,
    Il2CppSystem.Object clientData,
    OnRemoteConnectionClosedCallback connectionClosedHandler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionClosedHandler);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionClosed_Public_UInt64_AddNotifyPeerConnectionClosedOptions_Object_OnRemoteConnectionClosedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386848, XrefRangeEnd = 386868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyPeerConnectionEstablished(
    AddNotifyPeerConnectionEstablishedOptions options,
    Il2CppSystem.Object clientData,
    OnPeerConnectionEstablishedCallback connectionEstablishedHandler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionEstablishedHandler);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionEstablished_Public_UInt64_AddNotifyPeerConnectionEstablishedOptions_Object_OnPeerConnectionEstablishedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386868, XrefRangeEnd = 386888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyPeerConnectionRequest(
    AddNotifyPeerConnectionRequestOptions options,
    Il2CppSystem.Object clientData,
    OnIncomingConnectionRequestCallback connectionRequestHandler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionRequestHandler);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionRequest_Public_UInt64_AddNotifyPeerConnectionRequestOptions_Object_OnIncomingConnectionRequestCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386888, XrefRangeEnd = 386896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ClearPacketQueue(ClearPacketQueueOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_ClearPacketQueue_Public_Result_ClearPacketQueueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386896, XrefRangeEnd = 386904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CloseConnection(CloseConnectionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_CloseConnection_Public_Result_CloseConnectionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386904, XrefRangeEnd = 386912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CloseConnections(CloseConnectionsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_CloseConnections_Public_Result_CloseConnectionsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386912, XrefRangeEnd = 386923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetNATType(GetNATTypeOptions options, out NATType outNATType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outNATType;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetNATType_Public_Result_GetNATTypeOptions_byref_NATType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386923, XrefRangeEnd = 386934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetNextReceivedPacketSize(
    GetNextReceivedPacketSizeOptions options,
    out uint outPacketSizeBytes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPacketSizeBytes;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetNextReceivedPacketSize_Public_Result_GetNextReceivedPacketSizeOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386934, XrefRangeEnd = 386948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetPacketQueueInfo(
    GetPacketQueueInfoOptions options,
    out PacketQueueInfo outPacketQueueInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetPacketQueueInfo_Public_Result_GetPacketQueueInfoOptions_byref_PacketQueueInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PacketQueueInfo local = ref outPacketQueueInfo;
    System.IntPtr pointer = zero;
    PacketQueueInfo packetQueueInfo = pointer == System.IntPtr.Zero ? (PacketQueueInfo) null : new PacketQueueInfo(pointer);
    local = packetQueueInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386948, XrefRangeEnd = 386961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetPortRange(
    GetPortRangeOptions options,
    out ushort outPort,
    out ushort outNumAdditionalPortsToTry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPort;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref outNumAdditionalPortsToTry;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetPortRange_Public_Result_GetPortRangeOptions_byref_UInt16_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386961, XrefRangeEnd = 386972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetRelayControl(
    GetRelayControlOptions options,
    out RelayControl outRelayControl)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outRelayControl;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetRelayControl_Public_Result_GetRelayControlOptions_byref_RelayControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386972, XrefRangeEnd = 386991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryNATType(
    QueryNATTypeOptions options,
    Il2CppSystem.Object clientData,
    OnQueryNATTypeCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_QueryNATType_Public_Void_QueryNATTypeOptions_Object_OnQueryNATTypeCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386991, XrefRangeEnd = 387016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ReceivePacket(
    ReceivePacketOptions options,
    out ProductUserId outPeerId,
    out SocketId outSocketId,
    out byte outChannel,
    out Il2CppStructArray<byte> outData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref outChannel;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_ReceivePacket_Public_Result_ReceivePacketOptions_byref_ProductUserId_byref_SocketId_byref_Byte_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref ProductUserId local1 = ref outPeerId;
    System.IntPtr pointer1 = zero1;
    ProductUserId productUserId = pointer1 == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer1);
    local1 = productUserId;
    ref SocketId local2 = ref outSocketId;
    System.IntPtr pointer2 = zero2;
    SocketId socketId = pointer2 == System.IntPtr.Zero ? (SocketId) null : new SocketId(pointer2);
    local2 = socketId;
    ref Il2CppStructArray<byte> local3 = ref outData;
    System.IntPtr num6 = zero3;
    Il2CppStructArray<byte> il2CppStructArray = num6 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num6);
    local3 = il2CppStructArray;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387016, XrefRangeEnd = 387021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyIncomingPacketQueueFull(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyIncomingPacketQueueFull_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387021, XrefRangeEnd = 387026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyPeerConnectionClosed(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionClosed_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387026, XrefRangeEnd = 387031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyPeerConnectionEstablished(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionEstablished_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387031, XrefRangeEnd = 387036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyPeerConnectionRequest(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionRequest_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387036, XrefRangeEnd = 387044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SendPacket(SendPacketOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SendPacket_Public_Result_SendPacketOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387044, XrefRangeEnd = 387052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetPacketQueueSize(SetPacketQueueSizeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SetPacketQueueSize_Public_Result_SetPacketQueueSizeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387052, XrefRangeEnd = 387060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetPortRange(SetPortRangeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SetPortRange_Public_Result_SetPortRangeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387060, XrefRangeEnd = 387068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetRelayControl(SetRelayControlOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SetRelayControl_Public_Result_SetRelayControlOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387068, XrefRangeEnd = 387074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnIncomingConnectionRequestCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnIncomingConnectionRequestCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387074, XrefRangeEnd = 387080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnIncomingPacketQueueFullCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnIncomingPacketQueueFullCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387080, XrefRangeEnd = 387086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnPeerConnectionEstablishedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnPeerConnectionEstablishedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387086, XrefRangeEnd = 387092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryNATTypeCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnQueryNATTypeCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387092, XrefRangeEnd = 387098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRemoteConnectionClosedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnRemoteConnectionClosedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AcceptconnectionApiLatest
  {
    get
    {
      int acceptconnectionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AcceptconnectionApiLatest, (void*) &acceptconnectionApiLatest);
      return acceptconnectionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AcceptconnectionApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyincomingpacketqueuefullApiLatest
  {
    get
    {
      int addnotifyincomingpacketqueuefullApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest, (void*) &addnotifyincomingpacketqueuefullApiLatest);
      return addnotifyincomingpacketqueuefullApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifypeerconnectionclosedApiLatest
  {
    get
    {
      int addnotifypeerconnectionclosedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest, (void*) &addnotifypeerconnectionclosedApiLatest);
      return addnotifypeerconnectionclosedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifypeerconnectionestablishedApiLatest
  {
    get
    {
      int addnotifypeerconnectionestablishedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest, (void*) &addnotifypeerconnectionestablishedApiLatest);
      return addnotifypeerconnectionestablishedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifypeerconnectionrequestApiLatest
  {
    get
    {
      int addnotifypeerconnectionrequestApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest, (void*) &addnotifypeerconnectionrequestApiLatest);
      return addnotifypeerconnectionrequestApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest, (void*) &value);
    }
  }

  public static unsafe int ClearpacketqueueApiLatest
  {
    get
    {
      int clearpacketqueueApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_ClearpacketqueueApiLatest, (void*) &clearpacketqueueApiLatest);
      return clearpacketqueueApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_ClearpacketqueueApiLatest, (void*) &value);
    }
  }

  public static unsafe int CloseconnectionApiLatest
  {
    get
    {
      int closeconnectionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionApiLatest, (void*) &closeconnectionApiLatest);
      return closeconnectionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionApiLatest, (void*) &value);
    }
  }

  public static unsafe int CloseconnectionsApiLatest
  {
    get
    {
      int closeconnectionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionsApiLatest, (void*) &closeconnectionsApiLatest);
      return closeconnectionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetnattypeApiLatest
  {
    get
    {
      int getnattypeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetnattypeApiLatest, (void*) &getnattypeApiLatest);
      return getnattypeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetnattypeApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetnextreceivedpacketsizeApiLatest
  {
    get
    {
      int getnextreceivedpacketsizeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest, (void*) &getnextreceivedpacketsizeApiLatest);
      return getnextreceivedpacketsizeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetpacketqueueinfoApiLatest
  {
    get
    {
      int getpacketqueueinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetpacketqueueinfoApiLatest, (void*) &getpacketqueueinfoApiLatest);
      return getpacketqueueinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetpacketqueueinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetportrangeApiLatest
  {
    get
    {
      int getportrangeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetportrangeApiLatest, (void*) &getportrangeApiLatest);
      return getportrangeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetportrangeApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetrelaycontrolApiLatest
  {
    get
    {
      int getrelaycontrolApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetrelaycontrolApiLatest, (void*) &getrelaycontrolApiLatest);
      return getrelaycontrolApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetrelaycontrolApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxConnections
  {
    get
    {
      int maxConnections;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_MaxConnections, (void*) &maxConnections);
      return maxConnections;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_MaxConnections, (void*) &value);
    }
  }

  public static unsafe int MaxPacketSize
  {
    get
    {
      int maxPacketSize;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_MaxPacketSize, (void*) &maxPacketSize);
      return maxPacketSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_MaxPacketSize, (void*) &value);
    }
  }

  public static unsafe int MaxQueueSizeUnlimited
  {
    get
    {
      int queueSizeUnlimited;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_MaxQueueSizeUnlimited, (void*) &queueSizeUnlimited);
      return queueSizeUnlimited;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_MaxQueueSizeUnlimited, (void*) &value);
    }
  }

  public static unsafe int QuerynattypeApiLatest
  {
    get
    {
      int querynattypeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_QuerynattypeApiLatest, (void*) &querynattypeApiLatest);
      return querynattypeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_QuerynattypeApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReceivepacketApiLatest
  {
    get
    {
      int receivepacketApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_ReceivepacketApiLatest, (void*) &receivepacketApiLatest);
      return receivepacketApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_ReceivepacketApiLatest, (void*) &value);
    }
  }

  public static unsafe int SendpacketApiLatest
  {
    get
    {
      int sendpacketApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SendpacketApiLatest, (void*) &sendpacketApiLatest);
      return sendpacketApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SendpacketApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetpacketqueuesizeApiLatest
  {
    get
    {
      int setpacketqueuesizeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SetpacketqueuesizeApiLatest, (void*) &setpacketqueuesizeApiLatest);
      return setpacketqueuesizeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SetpacketqueuesizeApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetportrangeApiLatest
  {
    get
    {
      int setportrangeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SetportrangeApiLatest, (void*) &setportrangeApiLatest);
      return setportrangeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SetportrangeApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetrelaycontrolApiLatest
  {
    get
    {
      int setrelaycontrolApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SetrelaycontrolApiLatest, (void*) &setrelaycontrolApiLatest);
      return setrelaycontrolApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SetrelaycontrolApiLatest, (void*) &value);
    }
  }

  public static unsafe int SocketidApiLatest
  {
    get
    {
      int socketidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SocketidApiLatest, (void*) &socketidApiLatest);
      return socketidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SocketidApiLatest, (void*) &value);
    }
  }
}
