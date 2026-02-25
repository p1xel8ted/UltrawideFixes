// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.RTCInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Epic.OnlineServices.RTCAudio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC;

public sealed class RTCInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifydisconnectedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_BlockparticipantApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_JoinroomApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LeaveroomApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ParticipantmetadataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount;
  private static readonly System.IntPtr NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetroomsettingApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetsettingApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyDisconnected_Public_UInt64_AddNotifyDisconnectedOptions_Object_OnDisconnectedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyParticipantStatusChanged_Public_UInt64_AddNotifyParticipantStatusChangedOptions_Object_OnParticipantStatusChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlockParticipant_Public_Void_BlockParticipantOptions_Object_OnBlockParticipantCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioInterface_Public_RTCAudioInterface_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoinRoom_Public_Void_JoinRoomOptions_Object_OnJoinRoomCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeaveRoom_Public_Void_LeaveRoomOptions_Object_OnLeaveRoomCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyDisconnected_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyParticipantStatusChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRoomSetting_Public_Result_SetRoomSettingOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSetting_Public_Result_SetSettingOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBlockParticipantCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisconnectedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinRoomCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLeaveRoomCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnParticipantStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static RTCInterface()
  {
    Il2CppClassPointerStore<RTCInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTC", nameof (RTCInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr);
    RTCInterface.NativeFieldInfoPtr_AddnotifydisconnectedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (AddnotifydisconnectedApiLatest));
    RTCInterface.NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (AddnotifyparticipantstatuschangedApiLatest));
    RTCInterface.NativeFieldInfoPtr_BlockparticipantApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (BlockparticipantApiLatest));
    RTCInterface.NativeFieldInfoPtr_JoinroomApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (JoinroomApiLatest));
    RTCInterface.NativeFieldInfoPtr_LeaveroomApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (LeaveroomApiLatest));
    RTCInterface.NativeFieldInfoPtr_ParticipantmetadataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (ParticipantmetadataApiLatest));
    RTCInterface.NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (ParticipantmetadataKeyMaxcharcount));
    RTCInterface.NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (ParticipantmetadataValueMaxcharcount));
    RTCInterface.NativeFieldInfoPtr_SetroomsettingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (SetroomsettingApiLatest));
    RTCInterface.NativeFieldInfoPtr_SetsettingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, nameof (SetsettingApiLatest));
    RTCInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667054);
    RTCInterface.NativeMethodInfoPtr_AddNotifyDisconnected_Public_UInt64_AddNotifyDisconnectedOptions_Object_OnDisconnectedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667056 /*0x06000EB0*/);
    RTCInterface.NativeMethodInfoPtr_AddNotifyParticipantStatusChanged_Public_UInt64_AddNotifyParticipantStatusChangedOptions_Object_OnParticipantStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667057);
    RTCInterface.NativeMethodInfoPtr_BlockParticipant_Public_Void_BlockParticipantOptions_Object_OnBlockParticipantCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667058);
    RTCInterface.NativeMethodInfoPtr_GetAudioInterface_Public_RTCAudioInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667059);
    RTCInterface.NativeMethodInfoPtr_JoinRoom_Public_Void_JoinRoomOptions_Object_OnJoinRoomCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667060);
    RTCInterface.NativeMethodInfoPtr_LeaveRoom_Public_Void_LeaveRoomOptions_Object_OnLeaveRoomCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667061);
    RTCInterface.NativeMethodInfoPtr_RemoveNotifyDisconnected_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667062);
    RTCInterface.NativeMethodInfoPtr_RemoveNotifyParticipantStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667063);
    RTCInterface.NativeMethodInfoPtr_SetRoomSetting_Public_Result_SetRoomSettingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667064);
    RTCInterface.NativeMethodInfoPtr_SetSetting_Public_Result_SetSettingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667065);
    RTCInterface.NativeMethodInfoPtr_OnBlockParticipantCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667066);
    RTCInterface.NativeMethodInfoPtr_OnDisconnectedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667067);
    RTCInterface.NativeMethodInfoPtr_OnJoinRoomCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667068);
    RTCInterface.NativeMethodInfoPtr_OnLeaveRoomCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667069);
    RTCInterface.NativeMethodInfoPtr_OnParticipantStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr, 100667070);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RTCInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382487, XrefRangeEnd = 382507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyDisconnected(
    AddNotifyDisconnectedOptions options,
    Il2CppSystem.Object clientData,
    OnDisconnectedCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_AddNotifyDisconnected_Public_UInt64_AddNotifyDisconnectedOptions_Object_OnDisconnectedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382507, XrefRangeEnd = 382527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyParticipantStatusChanged(
    AddNotifyParticipantStatusChangedOptions options,
    Il2CppSystem.Object clientData,
    OnParticipantStatusChangedCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_AddNotifyParticipantStatusChanged_Public_UInt64_AddNotifyParticipantStatusChangedOptions_Object_OnParticipantStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382527, XrefRangeEnd = 382546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BlockParticipant(
    BlockParticipantOptions options,
    Il2CppSystem.Object clientData,
    OnBlockParticipantCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_BlockParticipant_Public_Void_BlockParticipantOptions_Object_OnBlockParticipantCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382546, XrefRangeEnd = 382553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RTCAudioInterface GetAudioInterface()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_GetAudioInterface_Public_RTCAudioInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (RTCAudioInterface) null : Il2CppObjectPool.Get<RTCAudioInterface>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382553, XrefRangeEnd = 382572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoinRoom(
    JoinRoomOptions options,
    Il2CppSystem.Object clientData,
    OnJoinRoomCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_JoinRoom_Public_Void_JoinRoomOptions_Object_OnJoinRoomCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382572, XrefRangeEnd = 382591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LeaveRoom(
    LeaveRoomOptions options,
    Il2CppSystem.Object clientData,
    OnLeaveRoomCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_LeaveRoom_Public_Void_LeaveRoomOptions_Object_OnLeaveRoomCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382591, XrefRangeEnd = 382596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyDisconnected(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_RemoveNotifyDisconnected_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382596, XrefRangeEnd = 382601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyParticipantStatusChanged(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_RemoveNotifyParticipantStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382601, XrefRangeEnd = 382609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetRoomSetting(SetRoomSettingOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_SetRoomSetting_Public_Result_SetRoomSettingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382609, XrefRangeEnd = 382617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetSetting(SetSettingOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_SetSetting_Public_Result_SetSettingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382617, XrefRangeEnd = 382623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnBlockParticipantCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnBlockParticipantCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382623, XrefRangeEnd = 382629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDisconnectedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnDisconnectedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382629, XrefRangeEnd = 382635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnJoinRoomCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnJoinRoomCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382635, XrefRangeEnd = 382641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnLeaveRoomCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnLeaveRoomCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382641, XrefRangeEnd = 382647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnParticipantStatusChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCInterface.NativeMethodInfoPtr_OnParticipantStatusChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifydisconnectedApiLatest
  {
    get
    {
      int addnotifydisconnectedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_AddnotifydisconnectedApiLatest, (void*) &addnotifydisconnectedApiLatest);
      return addnotifydisconnectedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_AddnotifydisconnectedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyparticipantstatuschangedApiLatest
  {
    get
    {
      int addnotifyparticipantstatuschangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest, (void*) &addnotifyparticipantstatuschangedApiLatest);
      return addnotifyparticipantstatuschangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_AddnotifyparticipantstatuschangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int BlockparticipantApiLatest
  {
    get
    {
      int blockparticipantApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_BlockparticipantApiLatest, (void*) &blockparticipantApiLatest);
      return blockparticipantApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_BlockparticipantApiLatest, (void*) &value);
    }
  }

  public static unsafe int JoinroomApiLatest
  {
    get
    {
      int joinroomApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_JoinroomApiLatest, (void*) &joinroomApiLatest);
      return joinroomApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_JoinroomApiLatest, (void*) &value);
    }
  }

  public static unsafe int LeaveroomApiLatest
  {
    get
    {
      int leaveroomApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_LeaveroomApiLatest, (void*) &leaveroomApiLatest);
      return leaveroomApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_LeaveroomApiLatest, (void*) &value);
    }
  }

  public static unsafe int ParticipantmetadataApiLatest
  {
    get
    {
      int participantmetadataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataApiLatest, (void*) &participantmetadataApiLatest);
      return participantmetadataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataApiLatest, (void*) &value);
    }
  }

  public static unsafe int ParticipantmetadataKeyMaxcharcount
  {
    get
    {
      int participantmetadataKeyMaxcharcount;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount, (void*) &participantmetadataKeyMaxcharcount);
      return participantmetadataKeyMaxcharcount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataKeyMaxcharcount, (void*) &value);
    }
  }

  public static unsafe int ParticipantmetadataValueMaxcharcount
  {
    get
    {
      int valueMaxcharcount;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount, (void*) &valueMaxcharcount);
      return valueMaxcharcount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_ParticipantmetadataValueMaxcharcount, (void*) &value);
    }
  }

  public static unsafe int SetroomsettingApiLatest
  {
    get
    {
      int setroomsettingApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_SetroomsettingApiLatest, (void*) &setroomsettingApiLatest);
      return setroomsettingApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_SetroomsettingApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetsettingApiLatest
  {
    get
    {
      int setsettingApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCInterface.NativeFieldInfoPtr_SetsettingApiLatest, (void*) &setsettingApiLatest);
      return setsettingApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCInterface.NativeFieldInfoPtr_SetsettingApiLatest, (void*) &value);
    }
  }
}
