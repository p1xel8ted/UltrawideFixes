// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.UserInfoInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UserInfo;

public sealed class UserInfoInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyuserinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ExternaluserinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetexternaluserinfocountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxDisplaynameCharacters;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxDisplaynameUtf8Length;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryuserinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyExternalUserInfoByAccountId_Public_Result_CopyExternalUserInfoByAccountIdOptions_byref_ExternalUserInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyExternalUserInfoByAccountType_Public_Result_CopyExternalUserInfoByAccountTypeOptions_byref_ExternalUserInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyExternalUserInfoByIndex_Public_Result_CopyExternalUserInfoByIndexOptions_byref_ExternalUserInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserInfo_Public_Result_CopyUserInfoOptions_byref_UserInfoData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalUserInfoCount_Public_UInt32_GetExternalUserInfoCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryUserInfo_Public_Void_QueryUserInfoOptions_Object_OnQueryUserInfoCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryUserInfoByDisplayName_Public_Void_QueryUserInfoByDisplayNameOptions_Object_OnQueryUserInfoByDisplayNameCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryUserInfoByExternalAccount_Public_Void_QueryUserInfoByExternalAccountOptions_Object_OnQueryUserInfoByExternalAccountCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryUserInfoByDisplayNameCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryUserInfoByExternalAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryUserInfoCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static UserInfoInterface()
  {
    Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UserInfo", nameof (UserInfoInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr);
    UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyexternaluserinfobyaccountidApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyexternaluserinfobyaccounttypeApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyexternaluserinfobyindexApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_CopyuserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyuserinfoApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_ExternaluserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (ExternaluserinfoApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_GetexternaluserinfocountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (GetexternaluserinfocountApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (MaxDisplaynameCharacters));
    UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameUtf8Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (MaxDisplaynameUtf8Length));
    UserInfoInterface.NativeFieldInfoPtr_QueryuserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (QueryuserinfoApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (QueryuserinfobydisplaynameApiLatest));
    UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (QueryuserinfobyexternalaccountApiLatest));
    UserInfoInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664680);
    UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountId_Public_Result_CopyExternalUserInfoByAccountIdOptions_byref_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664682);
    UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountType_Public_Result_CopyExternalUserInfoByAccountTypeOptions_byref_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664683);
    UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByIndex_Public_Result_CopyExternalUserInfoByIndexOptions_byref_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664684);
    UserInfoInterface.NativeMethodInfoPtr_CopyUserInfo_Public_Result_CopyUserInfoOptions_byref_UserInfoData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664685);
    UserInfoInterface.NativeMethodInfoPtr_GetExternalUserInfoCount_Public_UInt32_GetExternalUserInfoCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664686);
    UserInfoInterface.NativeMethodInfoPtr_QueryUserInfo_Public_Void_QueryUserInfoOptions_Object_OnQueryUserInfoCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664687);
    UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByDisplayName_Public_Void_QueryUserInfoByDisplayNameOptions_Object_OnQueryUserInfoByDisplayNameCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664688 /*0x06000570*/);
    UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByExternalAccount_Public_Void_QueryUserInfoByExternalAccountOptions_Object_OnQueryUserInfoByExternalAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664689);
    UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByDisplayNameCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664690);
    UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByExternalAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664691);
    UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100664692);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UserInfoInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372854, XrefRangeEnd = 372927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyExternalUserInfoByAccountId(
    CopyExternalUserInfoByAccountIdOptions options,
    out ExternalUserInfo outExternalUserInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountId_Public_Result_CopyExternalUserInfoByAccountIdOptions_byref_ExternalUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalUserInfo local = ref outExternalUserInfo;
    System.IntPtr pointer = zero;
    ExternalUserInfo externalUserInfo = pointer == System.IntPtr.Zero ? (ExternalUserInfo) null : new ExternalUserInfo(pointer);
    local = externalUserInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372927, XrefRangeEnd = 373000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyExternalUserInfoByAccountType(
    CopyExternalUserInfoByAccountTypeOptions options,
    out ExternalUserInfo outExternalUserInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountType_Public_Result_CopyExternalUserInfoByAccountTypeOptions_byref_ExternalUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalUserInfo local = ref outExternalUserInfo;
    System.IntPtr pointer = zero;
    ExternalUserInfo externalUserInfo = pointer == System.IntPtr.Zero ? (ExternalUserInfo) null : new ExternalUserInfo(pointer);
    local = externalUserInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373000, XrefRangeEnd = 373073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyExternalUserInfoByIndex(
    CopyExternalUserInfoByIndexOptions options,
    out ExternalUserInfo outExternalUserInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByIndex_Public_Result_CopyExternalUserInfoByIndexOptions_byref_ExternalUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ExternalUserInfo local = ref outExternalUserInfo;
    System.IntPtr pointer = zero;
    ExternalUserInfo externalUserInfo = pointer == System.IntPtr.Zero ? (ExternalUserInfo) null : new ExternalUserInfo(pointer);
    local = externalUserInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373073, XrefRangeEnd = 373147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyUserInfo(CopyUserInfoOptions options, out UserInfoData outUserInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyUserInfo_Public_Result_CopyUserInfoOptions_byref_UserInfoData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref UserInfoData local = ref outUserInfo;
    System.IntPtr pointer = zero;
    UserInfoData userInfoData = pointer == System.IntPtr.Zero ? (UserInfoData) null : new UserInfoData(pointer);
    local = userInfoData;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373147, XrefRangeEnd = 373216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetExternalUserInfoCount(GetExternalUserInfoCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_GetExternalUserInfoCount_Public_UInt32_GetExternalUserInfoCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373216, XrefRangeEnd = 373296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryUserInfo(
    QueryUserInfoOptions options,
    Il2CppSystem.Object clientData,
    OnQueryUserInfoCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_QueryUserInfo_Public_Void_QueryUserInfoOptions_Object_OnQueryUserInfoCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373296, XrefRangeEnd = 373376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryUserInfoByDisplayName(
    QueryUserInfoByDisplayNameOptions options,
    Il2CppSystem.Object clientData,
    OnQueryUserInfoByDisplayNameCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByDisplayName_Public_Void_QueryUserInfoByDisplayNameOptions_Object_OnQueryUserInfoByDisplayNameCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373376, XrefRangeEnd = 373456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryUserInfoByExternalAccount(
    QueryUserInfoByExternalAccountOptions options,
    Il2CppSystem.Object clientData,
    OnQueryUserInfoByExternalAccountCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByExternalAccount_Public_Void_QueryUserInfoByExternalAccountOptions_Object_OnQueryUserInfoByExternalAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373456, XrefRangeEnd = 373462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryUserInfoByDisplayNameCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByDisplayNameCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373462, XrefRangeEnd = 373468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryUserInfoByExternalAccountCallbackInternalImplementation(
    System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByExternalAccountCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373468, XrefRangeEnd = 373474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryUserInfoCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CopyexternaluserinfobyaccountidApiLatest
  {
    get
    {
      int copyexternaluserinfobyaccountidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest, (void*) &copyexternaluserinfobyaccountidApiLatest);
      return copyexternaluserinfobyaccountidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyexternaluserinfobyaccounttypeApiLatest
  {
    get
    {
      int copyexternaluserinfobyaccounttypeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest, (void*) &copyexternaluserinfobyaccounttypeApiLatest);
      return copyexternaluserinfobyaccounttypeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyexternaluserinfobyindexApiLatest
  {
    get
    {
      int copyexternaluserinfobyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest, (void*) &copyexternaluserinfobyindexApiLatest);
      return copyexternaluserinfobyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyuserinfoApiLatest
  {
    get
    {
      int copyuserinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyuserinfoApiLatest, (void*) &copyuserinfoApiLatest);
      return copyuserinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyuserinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int ExternaluserinfoApiLatest
  {
    get
    {
      int externaluserinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_ExternaluserinfoApiLatest, (void*) &externaluserinfoApiLatest);
      return externaluserinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_ExternaluserinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetexternaluserinfocountApiLatest
  {
    get
    {
      int getexternaluserinfocountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_GetexternaluserinfocountApiLatest, (void*) &getexternaluserinfocountApiLatest);
      return getexternaluserinfocountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_GetexternaluserinfocountApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxDisplaynameCharacters
  {
    get
    {
      int displaynameCharacters;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameCharacters, (void*) &displaynameCharacters);
      return displaynameCharacters;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameCharacters, (void*) &value);
    }
  }

  public static unsafe int MaxDisplaynameUtf8Length
  {
    get
    {
      int displaynameUtf8Length;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameUtf8Length, (void*) &displaynameUtf8Length);
      return displaynameUtf8Length;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameUtf8Length, (void*) &value);
    }
  }

  public static unsafe int QueryuserinfoApiLatest
  {
    get
    {
      int queryuserinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfoApiLatest, (void*) &queryuserinfoApiLatest);
      return queryuserinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryuserinfobydisplaynameApiLatest
  {
    get
    {
      int queryuserinfobydisplaynameApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest, (void*) &queryuserinfobydisplaynameApiLatest);
      return queryuserinfobydisplaynameApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryuserinfobyexternalaccountApiLatest
  {
    get
    {
      int queryuserinfobyexternalaccountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest, (void*) &queryuserinfobyexternalaccountApiLatest);
      return queryuserinfobyexternalaccountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest, (void*) &value);
    }
  }
}
