// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.FriendsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Friends;

public sealed class FriendsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AcceptinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendatindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendscountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetstatusApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryfriendsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RejectinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SendinviteApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AcceptInvite_Public_Void_AcceptInviteOptions_Object_OnAcceptInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyFriendsUpdate_Public_UInt64_AddNotifyFriendsUpdateOptions_Object_OnFriendsUpdateCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendAtIndex_Public_EpicAccountId_GetFriendAtIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendsCount_Public_Int32_GetFriendsCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStatus_Public_FriendsStatus_GetStatusOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryFriends_Public_Void_QueryFriendsOptions_Object_OnQueryFriendsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyFriendsUpdate_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAcceptInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFriendsUpdateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static FriendsInterface()
  {
    Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Friends", nameof (FriendsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr);
    FriendsInterface.NativeFieldInfoPtr_AcceptinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (AcceptinviteApiLatest));
    FriendsInterface.NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (AddnotifyfriendsupdateApiLatest));
    FriendsInterface.NativeFieldInfoPtr_GetfriendatindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (GetfriendatindexApiLatest));
    FriendsInterface.NativeFieldInfoPtr_GetfriendscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (GetfriendscountApiLatest));
    FriendsInterface.NativeFieldInfoPtr_GetstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (GetstatusApiLatest));
    FriendsInterface.NativeFieldInfoPtr_QueryfriendsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (QueryfriendsApiLatest));
    FriendsInterface.NativeFieldInfoPtr_RejectinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (RejectinviteApiLatest));
    FriendsInterface.NativeFieldInfoPtr_SendinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (SendinviteApiLatest));
    FriendsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670424);
    FriendsInterface.NativeMethodInfoPtr_AcceptInvite_Public_Void_AcceptInviteOptions_Object_OnAcceptInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670426);
    FriendsInterface.NativeMethodInfoPtr_AddNotifyFriendsUpdate_Public_UInt64_AddNotifyFriendsUpdateOptions_Object_OnFriendsUpdateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670427);
    FriendsInterface.NativeMethodInfoPtr_GetFriendAtIndex_Public_EpicAccountId_GetFriendAtIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670428);
    FriendsInterface.NativeMethodInfoPtr_GetFriendsCount_Public_Int32_GetFriendsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670429);
    FriendsInterface.NativeMethodInfoPtr_GetStatus_Public_FriendsStatus_GetStatusOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670430);
    FriendsInterface.NativeMethodInfoPtr_QueryFriends_Public_Void_QueryFriendsOptions_Object_OnQueryFriendsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670431);
    FriendsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670432);
    FriendsInterface.NativeMethodInfoPtr_RemoveNotifyFriendsUpdate_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670433);
    FriendsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670434);
    FriendsInterface.NativeMethodInfoPtr_OnAcceptInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670435);
    FriendsInterface.NativeMethodInfoPtr_OnFriendsUpdateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670436);
    FriendsInterface.NativeMethodInfoPtr_OnQueryFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670437);
    FriendsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670438);
    FriendsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100670439);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FriendsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393171, XrefRangeEnd = 393190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AcceptInvite(
    AcceptInviteOptions options,
    Il2CppSystem.Object clientData,
    OnAcceptInviteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_AcceptInvite_Public_Void_AcceptInviteOptions_Object_OnAcceptInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393190, XrefRangeEnd = 393210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyFriendsUpdate(
    AddNotifyFriendsUpdateOptions options,
    Il2CppSystem.Object clientData,
    OnFriendsUpdateCallback friendsUpdateHandler)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) friendsUpdateHandler);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_AddNotifyFriendsUpdate_Public_UInt64_AddNotifyFriendsUpdateOptions_Object_OnFriendsUpdateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393210, XrefRangeEnd = 393221 /*0x060005*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EpicAccountId GetFriendAtIndex(GetFriendAtIndexOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_GetFriendAtIndex_Public_EpicAccountId_GetFriendAtIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393221 /*0x060005*/, XrefRangeEnd = 393229 /*0x06000D*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetFriendsCount(GetFriendsCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_GetFriendsCount_Public_Int32_GetFriendsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393229 /*0x06000D*/, XrefRangeEnd = 393237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FriendsStatus GetStatus(GetStatusOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_GetStatus_Public_FriendsStatus_GetStatusOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FriendsStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393237, XrefRangeEnd = 393256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryFriends(
    QueryFriendsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryFriendsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_QueryFriends_Public_Void_QueryFriendsOptions_Object_OnQueryFriendsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393256, XrefRangeEnd = 393275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_RejectInviteOptions_Object_OnRejectInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393275, XrefRangeEnd = 393280 /*0x060040*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyFriendsUpdate(ulong notificationId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &notificationId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_RemoveNotifyFriendsUpdate_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393280 /*0x060040*/, XrefRangeEnd = 393299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_SendInviteOptions_Object_OnSendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393299, XrefRangeEnd = 393305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAcceptInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnAcceptInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393305, XrefRangeEnd = 393311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnFriendsUpdateCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnFriendsUpdateCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393311, XrefRangeEnd = 393317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryFriendsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnQueryFriendsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393317, XrefRangeEnd = 393323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRejectInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393323, XrefRangeEnd = 393329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSendInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AcceptinviteApiLatest
  {
    get
    {
      int acceptinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_AcceptinviteApiLatest, (void*) &acceptinviteApiLatest);
      return acceptinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_AcceptinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifyfriendsupdateApiLatest
  {
    get
    {
      int addnotifyfriendsupdateApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest, (void*) &addnotifyfriendsupdateApiLatest);
      return addnotifyfriendsupdateApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetfriendatindexApiLatest
  {
    get
    {
      int getfriendatindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_GetfriendatindexApiLatest, (void*) &getfriendatindexApiLatest);
      return getfriendatindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_GetfriendatindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetfriendscountApiLatest
  {
    get
    {
      int getfriendscountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_GetfriendscountApiLatest, (void*) &getfriendscountApiLatest);
      return getfriendscountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_GetfriendscountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetstatusApiLatest
  {
    get
    {
      int getstatusApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_GetstatusApiLatest, (void*) &getstatusApiLatest);
      return getstatusApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_GetstatusApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryfriendsApiLatest
  {
    get
    {
      int queryfriendsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_QueryfriendsApiLatest, (void*) &queryfriendsApiLatest);
      return queryfriendsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_QueryfriendsApiLatest, (void*) &value);
    }
  }

  public static unsafe int RejectinviteApiLatest
  {
    get
    {
      int rejectinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &rejectinviteApiLatest);
      return rejectinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe int SendinviteApiLatest
  {
    get
    {
      int sendinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &sendinviteApiLatest);
      return sendinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &value);
    }
  }
}
