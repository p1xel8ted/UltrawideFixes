// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.QueryLeaderboardDefinitionsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

[StructLayout(LayoutKind.Explicit)]
public struct QueryLeaderboardDefinitionsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryLeaderboardDefinitionsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public long m_StartTime;
  [FieldOffset(16 /*0x10*/)]
  public long m_EndTime;
  [FieldOffset(24)]
  public System.IntPtr m_LocalUserId;

  static QueryLeaderboardDefinitionsOptionsInternal()
  {
    Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (QueryLeaderboardDefinitionsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr);
    QueryLeaderboardDefinitionsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryLeaderboardDefinitionsOptionsInternal.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_StartTime));
    QueryLeaderboardDefinitionsOptionsInternal.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_EndTime));
    QueryLeaderboardDefinitionsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, 100670090);
    QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, 100670091);
    QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, 100670092);
    QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryLeaderboardDefinitionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, 100670093);
    QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, 100670094);
    QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, 100670095);
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> StartTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392157, XrefRangeEnd = 392161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> EndTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392161, XrefRangeEnd = 392165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392165, XrefRangeEnd = 392169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 392181, RefRangeEnd = 392182, XrefRangeStart = 392169, XrefRangeEnd = 392181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryLeaderboardDefinitionsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryLeaderboardDefinitionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392182, XrefRangeEnd = 392185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392185, XrefRangeEnd = 392189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
