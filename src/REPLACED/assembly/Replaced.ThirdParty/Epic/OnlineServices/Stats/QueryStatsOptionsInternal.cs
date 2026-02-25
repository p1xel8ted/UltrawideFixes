// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.QueryStatsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats;

[StructLayout(LayoutKind.Explicit)]
public struct QueryStatsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatNamesCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatNames_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryStatsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public long m_StartTime;
  [FieldOffset(24)]
  public long m_EndTime;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_StatNames;
  [FieldOffset(40)]
  public uint m_StatNamesCount;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_TargetUserId;

  static QueryStatsOptionsInternal()
  {
    Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Stats", nameof (QueryStatsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr);
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_StartTime));
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_EndTime));
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_StatNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_StatNames));
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_StatNamesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_StatNamesCount));
    QueryStatsOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    QueryStatsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665226);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665227);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665228);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StatNames_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665229);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665230);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryStatsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665231);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665232 /*0x06000790*/);
    QueryStatsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665233);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376248, XrefRangeEnd = 376254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> StartTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376254, XrefRangeEnd = 376258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> EndTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376258, XrefRangeEnd = 376262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray StatNames
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 376268, RefRangeEnd = 376269, XrefRangeStart = 376262, XrefRangeEnd = 376268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StatNames_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376269, XrefRangeEnd = 376275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 376296, RefRangeEnd = 376297, XrefRangeStart = 376275, XrefRangeEnd = 376296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryStatsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryStatsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376297, XrefRangeEnd = 376300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376300, XrefRangeEnd = 376315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
