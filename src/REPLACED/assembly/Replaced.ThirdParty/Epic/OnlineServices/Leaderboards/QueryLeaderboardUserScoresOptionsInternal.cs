// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.QueryLeaderboardUserScoresOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

[StructLayout(LayoutKind.Explicit)]
public struct QueryLeaderboardUserScoresOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserIdsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfoCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_UserScoresQueryStatInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryLeaderboardUserScoresOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_UserIds;
  [FieldOffset(16 /*0x10*/)]
  public uint m_UserIdsCount;
  [FieldOffset(24)]
  public System.IntPtr m_StatInfo;
  [FieldOffset(32 /*0x20*/)]
  public uint m_StatInfoCount;
  [FieldOffset(40)]
  public long m_StartTime;
  [FieldOffset(48 /*0x30*/)]
  public long m_EndTime;
  [FieldOffset(56)]
  public System.IntPtr m_LocalUserId;

  static QueryLeaderboardUserScoresOptionsInternal()
  {
    Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (QueryLeaderboardUserScoresOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr);
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_UserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_UserIds));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_UserIdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_UserIdsCount));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_StatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_StatInfo));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_StatInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_StatInfoCount));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_StartTime));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_EndTime));
    QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_UserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670117);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_UserScoresQueryStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670118);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670119);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670120);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670121);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryLeaderboardUserScoresOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670122);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670123);
    QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100670124);
  }

  public unsafe Il2CppReferenceArray<ProductUserId> UserIds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 392220, RefRangeEnd = 392221, XrefRangeStart = 392214, XrefRangeEnd = 392220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_UserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<UserScoresQueryStatInfo> StatInfo
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 392227, RefRangeEnd = 392228, XrefRangeStart = 392221, XrefRangeEnd = 392227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_UserScoresQueryStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> StartTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392228, XrefRangeEnd = 392232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> EndTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392232, XrefRangeEnd = 392236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392236, XrefRangeEnd = 392240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 392254, RefRangeEnd = 392255, XrefRangeStart = 392240, XrefRangeEnd = 392254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryLeaderboardUserScoresOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryLeaderboardUserScoresOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392255, XrefRangeEnd = 392258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392258, XrefRangeEnd = 392264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
