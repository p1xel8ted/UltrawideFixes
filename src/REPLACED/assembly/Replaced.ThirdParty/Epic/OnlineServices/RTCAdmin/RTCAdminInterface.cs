// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAdmin.RTCAdminInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAdmin;

public sealed class RTCAdminInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyusertokenbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_KickApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryjoinroomtokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetparticipanthardmuteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UsertokenApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserTokenByIndex_Public_Result_CopyUserTokenByIndexOptions_byref_UserToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserTokenByUserId_Public_Result_CopyUserTokenByUserIdOptions_byref_UserToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Kick_Public_Void_KickOptions_Object_OnKickCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryJoinRoomToken_Public_Void_QueryJoinRoomTokenOptions_Object_OnQueryJoinRoomTokenCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParticipantHardMute_Public_Void_SetParticipantHardMuteOptions_Object_OnSetParticipantHardMuteCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnKickCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryJoinRoomTokenCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSetParticipantHardMuteCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static RTCAdminInterface()
  {
    Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAdmin", nameof (RTCAdminInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr);
    RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (CopyusertokenbyindexApiLatest));
    RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (CopyusertokenbyuseridApiLatest));
    RTCAdminInterface.NativeFieldInfoPtr_KickApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (KickApiLatest));
    RTCAdminInterface.NativeFieldInfoPtr_QueryjoinroomtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (QueryjoinroomtokenApiLatest));
    RTCAdminInterface.NativeFieldInfoPtr_SetparticipanthardmuteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (SetparticipanthardmuteApiLatest));
    RTCAdminInterface.NativeFieldInfoPtr_UsertokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (UsertokenApiLatest));
    RTCAdminInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666781);
    RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByIndex_Public_Result_CopyUserTokenByIndexOptions_byref_UserToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666783);
    RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByUserId_Public_Result_CopyUserTokenByUserIdOptions_byref_UserToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666784 /*0x06000DA0*/);
    RTCAdminInterface.NativeMethodInfoPtr_Kick_Public_Void_KickOptions_Object_OnKickCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666785);
    RTCAdminInterface.NativeMethodInfoPtr_QueryJoinRoomToken_Public_Void_QueryJoinRoomTokenOptions_Object_OnQueryJoinRoomTokenCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666786);
    RTCAdminInterface.NativeMethodInfoPtr_SetParticipantHardMute_Public_Void_SetParticipantHardMuteOptions_Object_OnSetParticipantHardMuteCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666787);
    RTCAdminInterface.NativeMethodInfoPtr_OnKickCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666788);
    RTCAdminInterface.NativeMethodInfoPtr_OnQueryJoinRoomTokenCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666789);
    RTCAdminInterface.NativeMethodInfoPtr_OnSetParticipantHardMuteCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100666790);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RTCAdminInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381653, XrefRangeEnd = 381665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyUserTokenByIndex(
    CopyUserTokenByIndexOptions options,
    out UserToken outUserToken)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByIndex_Public_Result_CopyUserTokenByIndexOptions_byref_UserToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref UserToken local = ref outUserToken;
    System.IntPtr pointer = zero;
    UserToken userToken = pointer == System.IntPtr.Zero ? (UserToken) null : new UserToken(pointer);
    local = userToken;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381665, XrefRangeEnd = 381677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyUserTokenByUserId(
    CopyUserTokenByUserIdOptions options,
    out UserToken outUserToken)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByUserId_Public_Result_CopyUserTokenByUserIdOptions_byref_UserToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref UserToken local = ref outUserToken;
    System.IntPtr pointer = zero;
    UserToken userToken = pointer == System.IntPtr.Zero ? (UserToken) null : new UserToken(pointer);
    local = userToken;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381677, XrefRangeEnd = 381696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Kick(
    KickOptions options,
    Il2CppSystem.Object clientData,
    OnKickCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_Kick_Public_Void_KickOptions_Object_OnKickCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381696, XrefRangeEnd = 381715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryJoinRoomToken(
    QueryJoinRoomTokenOptions options,
    Il2CppSystem.Object clientData,
    OnQueryJoinRoomTokenCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_QueryJoinRoomToken_Public_Void_QueryJoinRoomTokenOptions_Object_OnQueryJoinRoomTokenCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381715, XrefRangeEnd = 381734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetParticipantHardMute(
    SetParticipantHardMuteOptions options,
    Il2CppSystem.Object clientData,
    OnSetParticipantHardMuteCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_SetParticipantHardMute_Public_Void_SetParticipantHardMuteOptions_Object_OnSetParticipantHardMuteCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381734, XrefRangeEnd = 381740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnKickCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_OnKickCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381740, XrefRangeEnd = 381746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryJoinRoomTokenCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_OnQueryJoinRoomTokenCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381746, XrefRangeEnd = 381752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSetParticipantHardMuteCompleteCallbackInternalImplementation(
    System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_OnSetParticipantHardMuteCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CopyusertokenbyindexApiLatest
  {
    get
    {
      int copyusertokenbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyindexApiLatest, (void*) &copyusertokenbyindexApiLatest);
      return copyusertokenbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyusertokenbyuseridApiLatest
  {
    get
    {
      int copyusertokenbyuseridApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest, (void*) &copyusertokenbyuseridApiLatest);
      return copyusertokenbyuseridApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest, (void*) &value);
    }
  }

  public static unsafe int KickApiLatest
  {
    get
    {
      int kickApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_KickApiLatest, (void*) &kickApiLatest);
      return kickApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_KickApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryjoinroomtokenApiLatest
  {
    get
    {
      int queryjoinroomtokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_QueryjoinroomtokenApiLatest, (void*) &queryjoinroomtokenApiLatest);
      return queryjoinroomtokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_QueryjoinroomtokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetparticipanthardmuteApiLatest
  {
    get
    {
      int setparticipanthardmuteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_SetparticipanthardmuteApiLatest, (void*) &setparticipanthardmuteApiLatest);
      return setparticipanthardmuteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_SetparticipanthardmuteApiLatest, (void*) &value);
    }
  }

  public static unsafe int UsertokenApiLatest
  {
    get
    {
      int usertokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_UsertokenApiLatest, (void*) &usertokenApiLatest);
      return usertokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_UsertokenApiLatest, (void*) &value);
    }
  }
}
