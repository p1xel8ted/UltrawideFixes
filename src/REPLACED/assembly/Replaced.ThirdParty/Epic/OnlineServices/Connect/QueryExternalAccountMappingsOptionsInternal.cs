// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.QueryExternalAccountMappingsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct QueryExternalAccountMappingsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountIdCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalAccountIds_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryExternalAccountMappingsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public ExternalAccountType m_AccountIdType;
  [FieldOffset(24)]
  public System.IntPtr m_ExternalAccountIds;
  [FieldOffset(32 /*0x20*/)]
  public uint m_ExternalAccountIdCount;

  static QueryExternalAccountMappingsOptionsInternal()
  {
    Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (QueryExternalAccountMappingsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr);
    QueryExternalAccountMappingsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryExternalAccountMappingsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryExternalAccountMappingsOptionsInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, nameof (m_AccountIdType));
    QueryExternalAccountMappingsOptionsInternal.NativeFieldInfoPtr_m_ExternalAccountIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, nameof (m_ExternalAccountIds));
    QueryExternalAccountMappingsOptionsInternal.NativeFieldInfoPtr_m_ExternalAccountIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, nameof (m_ExternalAccountIdCount));
    QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, 100671859);
    QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, 100671860);
    QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_set_ExternalAccountIds_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, 100671861);
    QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryExternalAccountMappingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, 100671862);
    QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, 100671863);
    QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, 100671864);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397599, XrefRangeEnd = 397603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType AccountIdType
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray ExternalAccountIds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 397609, RefRangeEnd = 397611, XrefRangeStart = 397603, XrefRangeEnd = 397609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_set_ExternalAccountIds_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397611, XrefRangeEnd = 397616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryExternalAccountMappingsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryExternalAccountMappingsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397616, XrefRangeEnd = 397623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397623, XrefRangeEnd = 397628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryExternalAccountMappingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryExternalAccountMappingsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
