// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

public sealed class PresenceInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopypresenceApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CreatepresencemodificationApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DataMaxKeyLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_DataMaxKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_DataMaxValueLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_DatarecordApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletedataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetjoininfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_HaspresenceApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_InfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QuerypresenceApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RichTextMaxValueLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetdataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetpresenceApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetrawrichtextApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetstatusApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyJoinGameAccepted_Public_UInt64_AddNotifyJoinGameAcceptedOptions_Object_OnJoinGameAcceptedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyOnPresenceChanged_Public_UInt64_AddNotifyOnPresenceChangedOptions_Object_OnPresenceChangedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPresence_Public_Result_CopyPresenceOptions_byref_Info_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePresenceModification_Public_Result_CreatePresenceModificationOptions_byref_PresenceModification_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJoinInfo_Public_Result_GetJoinInfoOptions_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasPresence_Public_Boolean_HasPresenceOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryPresence_Public_Void_QueryPresenceOptions_Object_OnQueryPresenceCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyJoinGameAccepted_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyOnPresenceChanged_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPresence_Public_Void_SetPresenceOptions_Object_SetPresenceCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinGameAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPresenceChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static PresenceInterface()
  {
    Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr);
    PresenceInterface.NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (AddnotifyjoingameacceptedApiLatest));
    PresenceInterface.NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (AddnotifyonpresencechangedApiLatest));
    PresenceInterface.NativeFieldInfoPtr_CopypresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (CopypresenceApiLatest));
    PresenceInterface.NativeFieldInfoPtr_CreatepresencemodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (CreatepresencemodificationApiLatest));
    PresenceInterface.NativeFieldInfoPtr_DataMaxKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DataMaxKeyLength));
    PresenceInterface.NativeFieldInfoPtr_DataMaxKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DataMaxKeys));
    PresenceInterface.NativeFieldInfoPtr_DataMaxValueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DataMaxValueLength));
    PresenceInterface.NativeFieldInfoPtr_DatarecordApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DatarecordApiLatest));
    PresenceInterface.NativeFieldInfoPtr_DeletedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DeletedataApiLatest));
    PresenceInterface.NativeFieldInfoPtr_GetjoininfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (GetjoininfoApiLatest));
    PresenceInterface.NativeFieldInfoPtr_HaspresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (HaspresenceApiLatest));
    PresenceInterface.NativeFieldInfoPtr_InfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (InfoApiLatest));
    PresenceInterface.NativeFieldInfoPtr_QuerypresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (QuerypresenceApiLatest));
    PresenceInterface.NativeFieldInfoPtr_RichTextMaxValueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (RichTextMaxValueLength));
    PresenceInterface.NativeFieldInfoPtr_SetdataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetdataApiLatest));
    PresenceInterface.NativeFieldInfoPtr_SetpresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetpresenceApiLatest));
    PresenceInterface.NativeFieldInfoPtr_SetrawrichtextApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetrawrichtextApiLatest));
    PresenceInterface.NativeFieldInfoPtr_SetstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetstatusApiLatest));
    PresenceInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667388);
    PresenceInterface.NativeMethodInfoPtr_AddNotifyJoinGameAccepted_Public_UInt64_AddNotifyJoinGameAcceptedOptions_Object_OnJoinGameAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667390);
    PresenceInterface.NativeMethodInfoPtr_AddNotifyOnPresenceChanged_Public_UInt64_AddNotifyOnPresenceChangedOptions_Object_OnPresenceChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667391);
    PresenceInterface.NativeMethodInfoPtr_CopyPresence_Public_Result_CopyPresenceOptions_byref_Info_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667392 /*0x06001000*/);
    PresenceInterface.NativeMethodInfoPtr_CreatePresenceModification_Public_Result_CreatePresenceModificationOptions_byref_PresenceModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667393 /*0x06001001*/);
    PresenceInterface.NativeMethodInfoPtr_GetJoinInfo_Public_Result_GetJoinInfoOptions_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667394 /*0x06001002*/);
    PresenceInterface.NativeMethodInfoPtr_HasPresence_Public_Boolean_HasPresenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667395 /*0x06001003*/);
    PresenceInterface.NativeMethodInfoPtr_QueryPresence_Public_Void_QueryPresenceOptions_Object_OnQueryPresenceCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667396 /*0x06001004*/);
    PresenceInterface.NativeMethodInfoPtr_RemoveNotifyJoinGameAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667397 /*0x06001005*/);
    PresenceInterface.NativeMethodInfoPtr_RemoveNotifyOnPresenceChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667398 /*0x06001006*/);
    PresenceInterface.NativeMethodInfoPtr_SetPresence_Public_Void_SetPresenceOptions_Object_SetPresenceCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667399 /*0x06001007*/);
    PresenceInterface.NativeMethodInfoPtr_OnJoinGameAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667400 /*0x06001008*/);
    PresenceInterface.NativeMethodInfoPtr_OnPresenceChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667401 /*0x06001009*/);
    PresenceInterface.NativeMethodInfoPtr_OnQueryPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667402 /*0x0600100A*/);
    PresenceInterface.NativeMethodInfoPtr_SetPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100667403 /*0x0600100B*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresenceInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383520, XrefRangeEnd = 383540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyJoinGameAccepted(
    AddNotifyJoinGameAcceptedOptions options,
    Il2CppSystem.Object clientData,
    OnJoinGameAcceptedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_AddNotifyJoinGameAccepted_Public_UInt64_AddNotifyJoinGameAcceptedOptions_Object_OnJoinGameAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383540, XrefRangeEnd = 383560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyOnPresenceChanged(
    AddNotifyOnPresenceChangedOptions options,
    Il2CppSystem.Object clientData,
    OnPresenceChangedCallback notificationHandler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationHandler);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_AddNotifyOnPresenceChanged_Public_UInt64_AddNotifyOnPresenceChangedOptions_Object_OnPresenceChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383560, XrefRangeEnd = 383572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyPresence(CopyPresenceOptions options, out Info outPresence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_CopyPresence_Public_Result_CopyPresenceOptions_byref_Info_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Info local = ref outPresence;
    System.IntPtr pointer = zero;
    Info info = pointer == System.IntPtr.Zero ? (Info) null : new Info(pointer);
    local = info;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383572, XrefRangeEnd = 383583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CreatePresenceModification(
    CreatePresenceModificationOptions options,
    out PresenceModification outPresenceModificationHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_CreatePresenceModification_Public_Result_CreatePresenceModificationOptions_byref_PresenceModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PresenceModification local = ref outPresenceModificationHandle;
    System.IntPtr pointer = zero;
    PresenceModification presenceModification = pointer == System.IntPtr.Zero ? (PresenceModification) null : new PresenceModification(pointer);
    local = presenceModification;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383583, XrefRangeEnd = 383594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetJoinInfo(GetJoinInfoOptions options, out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_GetJoinInfo_Public_Result_GetJoinInfoOptions_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383594, XrefRangeEnd = 383603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasPresence(HasPresenceOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_HasPresence_Public_Boolean_HasPresenceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383603, XrefRangeEnd = 383622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryPresence(
    QueryPresenceOptions options,
    Il2CppSystem.Object clientData,
    OnQueryPresenceCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_QueryPresence_Public_Void_QueryPresenceOptions_Object_OnQueryPresenceCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383622, XrefRangeEnd = 383627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyJoinGameAccepted(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_RemoveNotifyJoinGameAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383627, XrefRangeEnd = 383632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyOnPresenceChanged(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_RemoveNotifyOnPresenceChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383632, XrefRangeEnd = 383651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPresence(
    SetPresenceOptions options,
    Il2CppSystem.Object clientData,
    SetPresenceCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_SetPresence_Public_Void_SetPresenceOptions_Object_SetPresenceCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383651, XrefRangeEnd = 383657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnJoinGameAcceptedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_OnJoinGameAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383657, XrefRangeEnd = 383663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnPresenceChangedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_OnPresenceChangedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383663, XrefRangeEnd = 383669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryPresenceCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_OnQueryPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383669, XrefRangeEnd = 383675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPresenceCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_SetPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifyjoingameacceptedApiLatest
  {
    get
    {
      int addnotifyjoingameacceptedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest, (void*) &addnotifyjoingameacceptedApiLatest);
      return addnotifyjoingameacceptedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyonpresencechangedApiLatest
  {
    get
    {
      int addnotifyonpresencechangedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest, (void*) &addnotifyonpresencechangedApiLatest);
      return addnotifyonpresencechangedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopypresenceApiLatest
  {
    get
    {
      int copypresenceApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_CopypresenceApiLatest, (void*) &copypresenceApiLatest);
      return copypresenceApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_CopypresenceApiLatest, (void*) &value);
    }
  }

  public static unsafe int CreatepresencemodificationApiLatest
  {
    get
    {
      int createpresencemodificationApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_CreatepresencemodificationApiLatest, (void*) &createpresencemodificationApiLatest);
      return createpresencemodificationApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_CreatepresencemodificationApiLatest, (void*) &value);
    }
  }

  public static unsafe int DataMaxKeyLength
  {
    get
    {
      int dataMaxKeyLength;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeyLength, (void*) &dataMaxKeyLength);
      return dataMaxKeyLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeyLength, (void*) &value);
    }
  }

  public static unsafe int DataMaxKeys
  {
    get
    {
      int dataMaxKeys;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeys, (void*) &dataMaxKeys);
      return dataMaxKeys;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeys, (void*) &value);
    }
  }

  public static unsafe int DataMaxValueLength
  {
    get
    {
      int dataMaxValueLength;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DataMaxValueLength, (void*) &dataMaxValueLength);
      return dataMaxValueLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DataMaxValueLength, (void*) &value);
    }
  }

  public static unsafe int DatarecordApiLatest
  {
    get
    {
      int datarecordApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DatarecordApiLatest, (void*) &datarecordApiLatest);
      return datarecordApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DatarecordApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletedataApiLatest
  {
    get
    {
      int deletedataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DeletedataApiLatest, (void*) &deletedataApiLatest);
      return deletedataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DeletedataApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetjoininfoApiLatest
  {
    get
    {
      int getjoininfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_GetjoininfoApiLatest, (void*) &getjoininfoApiLatest);
      return getjoininfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_GetjoininfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int HaspresenceApiLatest
  {
    get
    {
      int haspresenceApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_HaspresenceApiLatest, (void*) &haspresenceApiLatest);
      return haspresenceApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_HaspresenceApiLatest, (void*) &value);
    }
  }

  public static unsafe int InfoApiLatest
  {
    get
    {
      int infoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_InfoApiLatest, (void*) &infoApiLatest);
      return infoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_InfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int QuerypresenceApiLatest
  {
    get
    {
      int querypresenceApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_QuerypresenceApiLatest, (void*) &querypresenceApiLatest);
      return querypresenceApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_QuerypresenceApiLatest, (void*) &value);
    }
  }

  public static unsafe int RichTextMaxValueLength
  {
    get
    {
      int textMaxValueLength;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_RichTextMaxValueLength, (void*) &textMaxValueLength);
      return textMaxValueLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_RichTextMaxValueLength, (void*) &value);
    }
  }

  public static unsafe int SetdataApiLatest
  {
    get
    {
      int setdataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetdataApiLatest, (void*) &setdataApiLatest);
      return setdataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetdataApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetpresenceApiLatest
  {
    get
    {
      int setpresenceApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetpresenceApiLatest, (void*) &setpresenceApiLatest);
      return setpresenceApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetpresenceApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetrawrichtextApiLatest
  {
    get
    {
      int setrawrichtextApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetrawrichtextApiLatest, (void*) &setrawrichtextApiLatest);
      return setrawrichtextApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetrawrichtextApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetstatusApiLatest
  {
    get
    {
      int setstatusApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetstatusApiLatest, (void*) &setstatusApiLatest);
      return setstatusApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetstatusApiLatest, (void*) &value);
    }
  }
}
