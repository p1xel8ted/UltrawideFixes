// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.QueryUserInfoByExternalAccountOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UserInfo;

[StructLayout(LayoutKind.Explicit)]
public struct QueryUserInfoByExternalAccountOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountType;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalAccountId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountType_Public_set_Void_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryUserInfoByExternalAccountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ExternalAccountId;
  [FieldOffset(24)]
  public ExternalAccountType m_AccountType;

  static QueryUserInfoByExternalAccountOptionsInternal()
  {
    Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UserInfo", nameof (QueryUserInfoByExternalAccountOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr);
    QueryUserInfoByExternalAccountOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryUserInfoByExternalAccountOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryUserInfoByExternalAccountOptionsInternal.NativeFieldInfoPtr_m_ExternalAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, nameof (m_ExternalAccountId));
    QueryUserInfoByExternalAccountOptionsInternal.NativeFieldInfoPtr_m_AccountType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, nameof (m_AccountType));
    QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, 100664621);
    QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_set_ExternalAccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, 100664622);
    QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_set_AccountType_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, 100664623);
    QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryUserInfoByExternalAccountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, 100664624 /*0x06000530*/);
    QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, 100664625);
    QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, 100664626);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372571, XrefRangeEnd = 372577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ExternalAccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372577, XrefRangeEnd = 372581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_set_ExternalAccountId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType AccountType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_set_AccountType_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 372591, RefRangeEnd = 372592, XrefRangeStart = 372581, XrefRangeEnd = 372591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryUserInfoByExternalAccountOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryUserInfoByExternalAccountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372592, XrefRangeEnd = 372595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372595, XrefRangeEnd = 372606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryUserInfoByExternalAccountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryUserInfoByExternalAccountOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
