// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.QueryUserInfoByExternalAccountCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UserInfo;

[StructLayout(LayoutKind.Explicit)]
public struct QueryUserInfoByExternalAccountCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountType_Public_get_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(24)]
  public System.IntPtr m_ExternalAccountId;
  [FieldOffset(32 /*0x20*/)]
  public ExternalAccountType m_AccountType;
  [FieldOffset(40)]
  public System.IntPtr m_TargetUserId;

  static QueryUserInfoByExternalAccountCallbackInfoInternal()
  {
    Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UserInfo", nameof (QueryUserInfoByExternalAccountCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeFieldInfoPtr_m_ExternalAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, nameof (m_ExternalAccountId));
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeFieldInfoPtr_m_AccountType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, nameof (m_AccountType));
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, nameof (m_TargetUserId));
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664607);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664608 /*0x06000520*/);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664609);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664610);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664611);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_AccountType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664612);
    QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, 100664613);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 372553, RefRangeEnd = 372555, XrefRangeStart = 372544, XrefRangeEnd = 372553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372555, XrefRangeEnd = 372561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public unsafe string ExternalAccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372561, XrefRangeEnd = 372565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ExternalAccountType AccountType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_AccountType_Public_get_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EpicAccountId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372565, XrefRangeEnd = 372571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountCallbackInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryUserInfoByExternalAccountCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
