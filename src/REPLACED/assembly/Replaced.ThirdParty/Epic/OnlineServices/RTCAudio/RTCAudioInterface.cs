// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.RTCAudioInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

public sealed class RTCAudioInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AudiobufferApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SendaudioApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetaudioinputsettingsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatereceivingApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesendingApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioBeforeRender_Public_UInt64_AddNotifyAudioBeforeRenderOptions_Object_OnAudioBeforeRenderCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioBeforeSend_Public_UInt64_AddNotifyAudioBeforeSendOptions_Object_OnAudioBeforeSendCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioDevicesChanged_Public_UInt64_AddNotifyAudioDevicesChangedOptions_Object_OnAudioDevicesChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioInputState_Public_UInt64_AddNotifyAudioInputStateOptions_Object_OnAudioInputStateCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioOutputState_Public_UInt64_AddNotifyAudioOutputStateOptions_Object_OnAudioOutputStateCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyParticipantUpdated_Public_UInt64_AddNotifyParticipantUpdatedOptions_Object_OnParticipantUpdatedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioInputDeviceByIndex_Public_AudioInputDeviceInfo_GetAudioInputDeviceByIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioInputDevicesCount_Public_UInt32_GetAudioInputDevicesCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioOutputDeviceByIndex_Public_AudioOutputDeviceInfo_GetAudioOutputDeviceByIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioOutputDevicesCount_Public_UInt32_GetAudioOutputDevicesCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPlatformAudioUser_Public_Result_RegisterPlatformAudioUserOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioBeforeRender_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioBeforeSend_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioDevicesChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioInputState_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioOutputState_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyParticipantUpdated_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAudio_Public_Result_SendAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAudioInputSettings_Public_Result_SetAudioInputSettingsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAudioOutputSettings_Public_Result_SetAudioOutputSettingsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPlatformAudioUser_Public_Result_UnregisterPlatformAudioUserOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateReceiving_Public_Void_UpdateReceivingOptions_Object_OnUpdateReceivingCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSending_Public_Void_UpdateSendingOptions_Object_OnUpdateSendingCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioBeforeRenderCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioBeforeSendCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioDevicesChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioInputStateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioOutputStateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnParticipantUpdatedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateReceivingCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateSendingCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static RTCAudioInterface()
  {
    Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (RTCAudioInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr);
    RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiobeforerenderApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiobeforesendApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiodeviceschangedApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudioinputstateApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiooutputstateApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyparticipantupdatedApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AudiobufferApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AudiobufferApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AudioinputdeviceinfoApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AudiooutputdeviceinfoApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudioinputdevicebyindexApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudioinputdevicescountApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudiooutputdevicebyindexApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudiooutputdevicescountApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (RegisterplatformaudiouserApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_SendaudioApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (SendaudioApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_SetaudioinputsettingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (SetaudioinputsettingsApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (SetaudiooutputsettingsApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UnregisterplatformaudiouserApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdatereceivingApiLatest));
    RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdatesendingApiLatest));
    RTCAudioInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666523);
    RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeRender_Public_UInt64_AddNotifyAudioBeforeRenderOptions_Object_OnAudioBeforeRenderCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666525);
    RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeSend_Public_UInt64_AddNotifyAudioBeforeSendOptions_Object_OnAudioBeforeSendCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666526);
    RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioDevicesChanged_Public_UInt64_AddNotifyAudioDevicesChangedOptions_Object_OnAudioDevicesChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666527);
    RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioInputState_Public_UInt64_AddNotifyAudioInputStateOptions_Object_OnAudioInputStateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666528 /*0x06000CA0*/);
    RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioOutputState_Public_UInt64_AddNotifyAudioOutputStateOptions_Object_OnAudioOutputStateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666529);
    RTCAudioInterface.NativeMethodInfoPtr_AddNotifyParticipantUpdated_Public_UInt64_AddNotifyParticipantUpdatedOptions_Object_OnParticipantUpdatedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666530);
    RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDeviceByIndex_Public_AudioInputDeviceInfo_GetAudioInputDeviceByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666531);
    RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDevicesCount_Public_UInt32_GetAudioInputDevicesCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666532);
    RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDeviceByIndex_Public_AudioOutputDeviceInfo_GetAudioOutputDeviceByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666533);
    RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDevicesCount_Public_UInt32_GetAudioOutputDevicesCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666534);
    RTCAudioInterface.NativeMethodInfoPtr_RegisterPlatformAudioUser_Public_Result_RegisterPlatformAudioUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666535);
    RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeRender_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666536);
    RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeSend_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666537);
    RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioDevicesChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666538);
    RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioInputState_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666539);
    RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioOutputState_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666540);
    RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyParticipantUpdated_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666541);
    RTCAudioInterface.NativeMethodInfoPtr_SendAudio_Public_Result_SendAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666542);
    RTCAudioInterface.NativeMethodInfoPtr_SetAudioInputSettings_Public_Result_SetAudioInputSettingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666543);
    RTCAudioInterface.NativeMethodInfoPtr_SetAudioOutputSettings_Public_Result_SetAudioOutputSettingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666544 /*0x06000CB0*/);
    RTCAudioInterface.NativeMethodInfoPtr_UnregisterPlatformAudioUser_Public_Result_UnregisterPlatformAudioUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666545);
    RTCAudioInterface.NativeMethodInfoPtr_UpdateReceiving_Public_Void_UpdateReceivingOptions_Object_OnUpdateReceivingCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666546);
    RTCAudioInterface.NativeMethodInfoPtr_UpdateSending_Public_Void_UpdateSendingOptions_Object_OnUpdateSendingCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666547);
    RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeRenderCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666548);
    RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeSendCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666549);
    RTCAudioInterface.NativeMethodInfoPtr_OnAudioDevicesChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666550);
    RTCAudioInterface.NativeMethodInfoPtr_OnAudioInputStateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666551);
    RTCAudioInterface.NativeMethodInfoPtr_OnAudioOutputStateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666552);
    RTCAudioInterface.NativeMethodInfoPtr_OnParticipantUpdatedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666553);
    RTCAudioInterface.NativeMethodInfoPtr_OnUpdateReceivingCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666554);
    RTCAudioInterface.NativeMethodInfoPtr_OnUpdateSendingCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100666555);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RTCAudioInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380828, XrefRangeEnd = 380848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAudioBeforeRender(
    AddNotifyAudioBeforeRenderOptions options,
    Il2CppSystem.Object clientData,
    OnAudioBeforeRenderCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeRender_Public_UInt64_AddNotifyAudioBeforeRenderOptions_Object_OnAudioBeforeRenderCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380848, XrefRangeEnd = 380868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAudioBeforeSend(
    AddNotifyAudioBeforeSendOptions options,
    Il2CppSystem.Object clientData,
    OnAudioBeforeSendCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeSend_Public_UInt64_AddNotifyAudioBeforeSendOptions_Object_OnAudioBeforeSendCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380868, XrefRangeEnd = 380888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAudioDevicesChanged(
    AddNotifyAudioDevicesChangedOptions options,
    Il2CppSystem.Object clientData,
    OnAudioDevicesChangedCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioDevicesChanged_Public_UInt64_AddNotifyAudioDevicesChangedOptions_Object_OnAudioDevicesChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380888, XrefRangeEnd = 380908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAudioInputState(
    AddNotifyAudioInputStateOptions options,
    Il2CppSystem.Object clientData,
    OnAudioInputStateCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioInputState_Public_UInt64_AddNotifyAudioInputStateOptions_Object_OnAudioInputStateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380908, XrefRangeEnd = 380928 /*0x05D000*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAudioOutputState(
    AddNotifyAudioOutputStateOptions options,
    Il2CppSystem.Object clientData,
    OnAudioOutputStateCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioOutputState_Public_UInt64_AddNotifyAudioOutputStateOptions_Object_OnAudioOutputStateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380928 /*0x05D000*/, XrefRangeEnd = 380948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyParticipantUpdated(
    AddNotifyParticipantUpdatedOptions options,
    Il2CppSystem.Object clientData,
    OnParticipantUpdatedCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyParticipantUpdated_Public_UInt64_AddNotifyParticipantUpdatedOptions_Object_OnParticipantUpdatedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380948, XrefRangeEnd = 380959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioInputDeviceInfo GetAudioInputDeviceByIndex(
    GetAudioInputDeviceByIndexOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDeviceByIndex_Public_AudioInputDeviceInfo_GetAudioInputDeviceByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AudioInputDeviceInfo) null : Il2CppObjectPool.Get<AudioInputDeviceInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380959, XrefRangeEnd = 380967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetAudioInputDevicesCount(GetAudioInputDevicesCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDevicesCount_Public_UInt32_GetAudioInputDevicesCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380967, XrefRangeEnd = 380978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioOutputDeviceInfo GetAudioOutputDeviceByIndex(
    GetAudioOutputDeviceByIndexOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDeviceByIndex_Public_AudioOutputDeviceInfo_GetAudioOutputDeviceByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AudioOutputDeviceInfo) null : Il2CppObjectPool.Get<AudioOutputDeviceInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380978, XrefRangeEnd = 380986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetAudioOutputDevicesCount(GetAudioOutputDevicesCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDevicesCount_Public_UInt32_GetAudioOutputDevicesCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380986, XrefRangeEnd = 380994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RegisterPlatformAudioUser(RegisterPlatformAudioUserOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RegisterPlatformAudioUser_Public_Result_RegisterPlatformAudioUserOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380994, XrefRangeEnd = 380999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAudioBeforeRender(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeRender_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380999, XrefRangeEnd = 381004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAudioBeforeSend(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeSend_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381004, XrefRangeEnd = 381009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAudioDevicesChanged(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioDevicesChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381009, XrefRangeEnd = 381014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAudioInputState(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioInputState_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381014, XrefRangeEnd = 381019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAudioOutputState(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioOutputState_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381019, XrefRangeEnd = 381024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyParticipantUpdated(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyParticipantUpdated_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381024, XrefRangeEnd = 381032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SendAudio(SendAudioOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_SendAudio_Public_Result_SendAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381032, XrefRangeEnd = 381040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetAudioInputSettings(SetAudioInputSettingsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_SetAudioInputSettings_Public_Result_SetAudioInputSettingsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381040, XrefRangeEnd = 381048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetAudioOutputSettings(SetAudioOutputSettingsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_SetAudioOutputSettings_Public_Result_SetAudioOutputSettingsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381048, XrefRangeEnd = 381056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result UnregisterPlatformAudioUser(UnregisterPlatformAudioUserOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UnregisterPlatformAudioUser_Public_Result_UnregisterPlatformAudioUserOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381056, XrefRangeEnd = 381075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateReceiving(
    UpdateReceivingOptions options,
    Il2CppSystem.Object clientData,
    OnUpdateReceivingCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateReceiving_Public_Void_UpdateReceivingOptions_Object_OnUpdateReceivingCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381075, XrefRangeEnd = 381094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSending(
    UpdateSendingOptions options,
    Il2CppSystem.Object clientData,
    OnUpdateSendingCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateSending_Public_Void_UpdateSendingOptions_Object_OnUpdateSendingCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381094, XrefRangeEnd = 381100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAudioBeforeRenderCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeRenderCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381100, XrefRangeEnd = 381106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAudioBeforeSendCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeSendCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381106, XrefRangeEnd = 381112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAudioDevicesChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioDevicesChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381112, XrefRangeEnd = 381118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAudioInputStateCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioInputStateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381118, XrefRangeEnd = 381124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAudioOutputStateCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioOutputStateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381124, XrefRangeEnd = 381130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnParticipantUpdatedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnParticipantUpdatedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381130, XrefRangeEnd = 381136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdateReceivingCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateReceivingCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381136, XrefRangeEnd = 381142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdateSendingCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateSendingCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifyaudiobeforerenderApiLatest
  {
    get
    {
      int addnotifyaudiobeforerenderApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest, (void*) &addnotifyaudiobeforerenderApiLatest);
      return addnotifyaudiobeforerenderApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyaudiobeforesendApiLatest
  {
    get
    {
      int addnotifyaudiobeforesendApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest, (void*) &addnotifyaudiobeforesendApiLatest);
      return addnotifyaudiobeforesendApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyaudiodeviceschangedApiLatest
  {
    get
    {
      int addnotifyaudiodeviceschangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest, (void*) &addnotifyaudiodeviceschangedApiLatest);
      return addnotifyaudiodeviceschangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyaudioinputstateApiLatest
  {
    get
    {
      int addnotifyaudioinputstateApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest, (void*) &addnotifyaudioinputstateApiLatest);
      return addnotifyaudioinputstateApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyaudiooutputstateApiLatest
  {
    get
    {
      int addnotifyaudiooutputstateApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest, (void*) &addnotifyaudiooutputstateApiLatest);
      return addnotifyaudiooutputstateApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyparticipantupdatedApiLatest
  {
    get
    {
      int addnotifyparticipantupdatedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest, (void*) &addnotifyparticipantupdatedApiLatest);
      return addnotifyparticipantupdatedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AudiobufferApiLatest
  {
    get
    {
      int audiobufferApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AudiobufferApiLatest, (void*) &audiobufferApiLatest);
      return audiobufferApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AudiobufferApiLatest, (void*) &value);
    }
  }

  public static unsafe int AudioinputdeviceinfoApiLatest
  {
    get
    {
      int audioinputdeviceinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest, (void*) &audioinputdeviceinfoApiLatest);
      return audioinputdeviceinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int AudiooutputdeviceinfoApiLatest
  {
    get
    {
      int audiooutputdeviceinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest, (void*) &audiooutputdeviceinfoApiLatest);
      return audiooutputdeviceinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetaudioinputdevicebyindexApiLatest
  {
    get
    {
      int getaudioinputdevicebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest, (void*) &getaudioinputdevicebyindexApiLatest);
      return getaudioinputdevicebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetaudioinputdevicescountApiLatest
  {
    get
    {
      int getaudioinputdevicescountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest, (void*) &getaudioinputdevicescountApiLatest);
      return getaudioinputdevicescountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetaudiooutputdevicebyindexApiLatest
  {
    get
    {
      int getaudiooutputdevicebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest, (void*) &getaudiooutputdevicebyindexApiLatest);
      return getaudiooutputdevicebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetaudiooutputdevicescountApiLatest
  {
    get
    {
      int getaudiooutputdevicescountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest, (void*) &getaudiooutputdevicescountApiLatest);
      return getaudiooutputdevicescountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest, (void*) &value);
    }
  }

  public static unsafe int RegisterplatformaudiouserApiLatest
  {
    get
    {
      int registerplatformaudiouserApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest, (void*) &registerplatformaudiouserApiLatest);
      return registerplatformaudiouserApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest, (void*) &value);
    }
  }

  public static unsafe int SendaudioApiLatest
  {
    get
    {
      int sendaudioApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_SendaudioApiLatest, (void*) &sendaudioApiLatest);
      return sendaudioApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_SendaudioApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetaudioinputsettingsApiLatest
  {
    get
    {
      int setaudioinputsettingsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudioinputsettingsApiLatest, (void*) &setaudioinputsettingsApiLatest);
      return setaudioinputsettingsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudioinputsettingsApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetaudiooutputsettingsApiLatest
  {
    get
    {
      int setaudiooutputsettingsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest, (void*) &setaudiooutputsettingsApiLatest);
      return setaudiooutputsettingsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnregisterplatformaudiouserApiLatest
  {
    get
    {
      int unregisterplatformaudiouserApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest, (void*) &unregisterplatformaudiouserApiLatest);
      return unregisterplatformaudiouserApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatereceivingApiLatest
  {
    get
    {
      int updatereceivingApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingApiLatest, (void*) &updatereceivingApiLatest);
      return updatereceivingApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatesendingApiLatest
  {
    get
    {
      int updatesendingApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingApiLatest, (void*) &updatesendingApiLatest);
      return updatesendingApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingApiLatest, (void*) &value);
    }
  }
}
