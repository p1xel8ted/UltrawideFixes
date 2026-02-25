// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.UIInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI;

public sealed class UIInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AcknowledgeeventidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EventidInvalid;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendsvisibleApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GettogglefriendskeyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_HidefriendsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PrepresentApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReportkeyeventApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetdisplaypreferenceApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SettogglefriendskeyApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShowfriendsApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AcknowledgeEventId_Public_Result_AcknowledgeEventIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyDisplaySettingsUpdated_Public_UInt64_AddNotifyDisplaySettingsUpdatedOptions_Object_OnDisplaySettingsUpdatedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendsVisible_Public_Boolean_GetFriendsVisibleOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNotificationLocationPreference_Public_NotificationLocation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetToggleFriendsKey_Public_KeyCombination_GetToggleFriendsKeyOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HideFriends_Public_Void_HideFriendsOptions_Object_OnHideFriendsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidKeyCombination_Public_Boolean_KeyCombination_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyDisplaySettingsUpdated_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayPreference_Public_Result_SetDisplayPreferenceOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetToggleFriendsKey_Public_Result_SetToggleFriendsKeyOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowFriends_Public_Void_ShowFriendsOptions_Object_OnShowFriendsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisplaySettingsUpdatedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnHideFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnShowFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static UIInterface()
  {
    Il2CppClassPointerStore<UIInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UI", nameof (UIInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIInterface>.NativeClassPtr);
    UIInterface.NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (AcknowledgecorrelationidApiLatest));
    UIInterface.NativeFieldInfoPtr_AcknowledgeeventidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (AcknowledgeeventidApiLatest));
    UIInterface.NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (AddnotifydisplaysettingsupdatedApiLatest));
    UIInterface.NativeFieldInfoPtr_EventidInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (EventidInvalid));
    UIInterface.NativeFieldInfoPtr_GetfriendsvisibleApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (GetfriendsvisibleApiLatest));
    UIInterface.NativeFieldInfoPtr_GettogglefriendskeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (GettogglefriendskeyApiLatest));
    UIInterface.NativeFieldInfoPtr_HidefriendsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (HidefriendsApiLatest));
    UIInterface.NativeFieldInfoPtr_PrepresentApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (PrepresentApiLatest));
    UIInterface.NativeFieldInfoPtr_ReportkeyeventApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (ReportkeyeventApiLatest));
    UIInterface.NativeFieldInfoPtr_SetdisplaypreferenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (SetdisplaypreferenceApiLatest));
    UIInterface.NativeFieldInfoPtr_SettogglefriendskeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (SettogglefriendskeyApiLatest));
    UIInterface.NativeFieldInfoPtr_ShowfriendsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (ShowfriendsApiLatest));
    UIInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664826);
    UIInterface.NativeMethodInfoPtr_AcknowledgeEventId_Public_Result_AcknowledgeEventIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664828);
    UIInterface.NativeMethodInfoPtr_AddNotifyDisplaySettingsUpdated_Public_UInt64_AddNotifyDisplaySettingsUpdatedOptions_Object_OnDisplaySettingsUpdatedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664829);
    UIInterface.NativeMethodInfoPtr_GetFriendsVisible_Public_Boolean_GetFriendsVisibleOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664830);
    UIInterface.NativeMethodInfoPtr_GetNotificationLocationPreference_Public_NotificationLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664831);
    UIInterface.NativeMethodInfoPtr_GetToggleFriendsKey_Public_KeyCombination_GetToggleFriendsKeyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664832 /*0x06000600*/);
    UIInterface.NativeMethodInfoPtr_HideFriends_Public_Void_HideFriendsOptions_Object_OnHideFriendsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664833 /*0x06000601*/);
    UIInterface.NativeMethodInfoPtr_IsValidKeyCombination_Public_Boolean_KeyCombination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664834 /*0x06000602*/);
    UIInterface.NativeMethodInfoPtr_RemoveNotifyDisplaySettingsUpdated_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664835 /*0x06000603*/);
    UIInterface.NativeMethodInfoPtr_SetDisplayPreference_Public_Result_SetDisplayPreferenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664836 /*0x06000604*/);
    UIInterface.NativeMethodInfoPtr_SetToggleFriendsKey_Public_Result_SetToggleFriendsKeyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664837 /*0x06000605*/);
    UIInterface.NativeMethodInfoPtr_ShowFriends_Public_Void_ShowFriendsOptions_Object_OnShowFriendsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664838 /*0x06000606*/);
    UIInterface.NativeMethodInfoPtr_OnDisplaySettingsUpdatedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664839 /*0x06000607*/);
    UIInterface.NativeMethodInfoPtr_OnHideFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664840 /*0x06000608*/);
    UIInterface.NativeMethodInfoPtr_OnShowFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100664841 /*0x06000609*/);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373748, XrefRangeEnd = 373817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AcknowledgeEventId(AcknowledgeEventIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_AcknowledgeEventId_Public_Result_AcknowledgeEventIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373817, XrefRangeEnd = 373965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyDisplaySettingsUpdated(
    AddNotifyDisplaySettingsUpdatedOptions options,
    Il2CppSystem.Object clientData,
    OnDisplaySettingsUpdatedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_AddNotifyDisplaySettingsUpdated_Public_UInt64_AddNotifyDisplaySettingsUpdatedOptions_Object_OnDisplaySettingsUpdatedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373965, XrefRangeEnd = 374037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetFriendsVisible(GetFriendsVisibleOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetFriendsVisible_Public_Boolean_GetFriendsVisibleOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374037, XrefRangeEnd = 374039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NotificationLocation GetNotificationLocationPreference()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetNotificationLocationPreference_Public_NotificationLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(NotificationLocation*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374039, XrefRangeEnd = 374108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe KeyCombination GetToggleFriendsKey(GetToggleFriendsKeyOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetToggleFriendsKey_Public_KeyCombination_GetToggleFriendsKeyOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(KeyCombination*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374108, XrefRangeEnd = 374188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HideFriends(
    HideFriendsOptions options,
    Il2CppSystem.Object clientData,
    OnHideFriendsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_HideFriends_Public_Void_HideFriendsOptions_Object_OnHideFriendsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374188, XrefRangeEnd = 374196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValidKeyCombination(KeyCombination keyCombination)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &keyCombination
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_IsValidKeyCombination_Public_Boolean_KeyCombination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374196, XrefRangeEnd = 374232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyDisplaySettingsUpdated(ulong id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_RemoveNotifyDisplaySettingsUpdated_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374232, XrefRangeEnd = 374301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetDisplayPreference(SetDisplayPreferenceOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_SetDisplayPreference_Public_Result_SetDisplayPreferenceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374301, XrefRangeEnd = 374370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetToggleFriendsKey(SetToggleFriendsKeyOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_SetToggleFriendsKey_Public_Result_SetToggleFriendsKeyOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374370, XrefRangeEnd = 374450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowFriends(
    ShowFriendsOptions options,
    Il2CppSystem.Object clientData,
    OnShowFriendsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_ShowFriends_Public_Void_ShowFriendsOptions_Object_OnShowFriendsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374450, XrefRangeEnd = 374456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDisplaySettingsUpdatedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnDisplaySettingsUpdatedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374456, XrefRangeEnd = 374462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnHideFriendsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnHideFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374462, XrefRangeEnd = 374468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnShowFriendsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnShowFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AcknowledgecorrelationidApiLatest
  {
    get
    {
      int acknowledgecorrelationidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest, (void*) &acknowledgecorrelationidApiLatest);
      return acknowledgecorrelationidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest, (void*) &value);
    }
  }

  public static unsafe int AcknowledgeeventidApiLatest
  {
    get
    {
      int acknowledgeeventidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_AcknowledgeeventidApiLatest, (void*) &acknowledgeeventidApiLatest);
      return acknowledgeeventidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_AcknowledgeeventidApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifydisplaysettingsupdatedApiLatest
  {
    get
    {
      int addnotifydisplaysettingsupdatedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest, (void*) &addnotifydisplaysettingsupdatedApiLatest);
      return addnotifydisplaysettingsupdatedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest, (void*) &value);
    }
  }

  public static unsafe int EventidInvalid
  {
    get
    {
      int eventidInvalid;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_EventidInvalid, (void*) &eventidInvalid);
      return eventidInvalid;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_EventidInvalid, (void*) &value);
    }
  }

  public static unsafe int GetfriendsvisibleApiLatest
  {
    get
    {
      int getfriendsvisibleApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_GetfriendsvisibleApiLatest, (void*) &getfriendsvisibleApiLatest);
      return getfriendsvisibleApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_GetfriendsvisibleApiLatest, (void*) &value);
    }
  }

  public static unsafe int GettogglefriendskeyApiLatest
  {
    get
    {
      int gettogglefriendskeyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_GettogglefriendskeyApiLatest, (void*) &gettogglefriendskeyApiLatest);
      return gettogglefriendskeyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_GettogglefriendskeyApiLatest, (void*) &value);
    }
  }

  public static unsafe int HidefriendsApiLatest
  {
    get
    {
      int hidefriendsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_HidefriendsApiLatest, (void*) &hidefriendsApiLatest);
      return hidefriendsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_HidefriendsApiLatest, (void*) &value);
    }
  }

  public static unsafe int PrepresentApiLatest
  {
    get
    {
      int prepresentApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_PrepresentApiLatest, (void*) &prepresentApiLatest);
      return prepresentApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_PrepresentApiLatest, (void*) &value);
    }
  }

  public static unsafe int ReportkeyeventApiLatest
  {
    get
    {
      int reportkeyeventApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_ReportkeyeventApiLatest, (void*) &reportkeyeventApiLatest);
      return reportkeyeventApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_ReportkeyeventApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetdisplaypreferenceApiLatest
  {
    get
    {
      int setdisplaypreferenceApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_SetdisplaypreferenceApiLatest, (void*) &setdisplaypreferenceApiLatest);
      return setdisplaypreferenceApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_SetdisplaypreferenceApiLatest, (void*) &value);
    }
  }

  public static unsafe int SettogglefriendskeyApiLatest
  {
    get
    {
      int settogglefriendskeyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_SettogglefriendskeyApiLatest, (void*) &settogglefriendskeyApiLatest);
      return settogglefriendskeyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_SettogglefriendskeyApiLatest, (void*) &value);
    }
  }

  public static unsafe int ShowfriendsApiLatest
  {
    get
    {
      int showfriendsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_ShowfriendsApiLatest, (void*) &showfriendsApiLatest);
      return showfriendsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_ShowfriendsApiLatest, (void*) &value);
    }
  }
}
