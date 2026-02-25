// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.StatsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats;

public sealed class StatsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopystatbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopystatbynameApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetstatcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetstatscountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_IngestdataApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_IngeststatApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxIngestStats;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxQueryStats;
  private static readonly System.IntPtr NativeFieldInfoPtr_QuerystatsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_StatApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeUndefined;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyStatByIndex_Public_Result_CopyStatByIndexOptions_byref_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyStatByName_Public_Result_CopyStatByNameOptions_byref_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStatsCount_Public_UInt32_GetStatCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IngestStat_Public_Void_IngestStatOptions_Object_OnIngestStatCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryStats_Public_Void_QueryStatsOptions_Object_OnQueryStatsCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnIngestStatCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryStatsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static StatsInterface()
  {
    Il2CppClassPointerStore<StatsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Stats", nameof (StatsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr);
    StatsInterface.NativeFieldInfoPtr_CopystatbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (CopystatbyindexApiLatest));
    StatsInterface.NativeFieldInfoPtr_CopystatbynameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (CopystatbynameApiLatest));
    StatsInterface.NativeFieldInfoPtr_GetstatcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (GetstatcountApiLatest));
    StatsInterface.NativeFieldInfoPtr_GetstatscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (GetstatscountApiLatest));
    StatsInterface.NativeFieldInfoPtr_IngestdataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (IngestdataApiLatest));
    StatsInterface.NativeFieldInfoPtr_IngeststatApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (IngeststatApiLatest));
    StatsInterface.NativeFieldInfoPtr_MaxIngestStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (MaxIngestStats));
    StatsInterface.NativeFieldInfoPtr_MaxQueryStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (MaxQueryStats));
    StatsInterface.NativeFieldInfoPtr_QuerystatsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (QuerystatsApiLatest));
    StatsInterface.NativeFieldInfoPtr_StatApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (StatApiLatest));
    StatsInterface.NativeFieldInfoPtr_TimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (TimeUndefined));
    StatsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665256);
    StatsInterface.NativeMethodInfoPtr_CopyStatByIndex_Public_Result_CopyStatByIndexOptions_byref_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665258);
    StatsInterface.NativeMethodInfoPtr_CopyStatByName_Public_Result_CopyStatByNameOptions_byref_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665259);
    StatsInterface.NativeMethodInfoPtr_GetStatsCount_Public_UInt32_GetStatCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665260);
    StatsInterface.NativeMethodInfoPtr_IngestStat_Public_Void_IngestStatOptions_Object_OnIngestStatCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665261);
    StatsInterface.NativeMethodInfoPtr_QueryStats_Public_Void_QueryStatsOptions_Object_OnQueryStatsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665262);
    StatsInterface.NativeMethodInfoPtr_OnIngestStatCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665263);
    StatsInterface.NativeMethodInfoPtr_OnQueryStatsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665264 /*0x060007B0*/);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376410, XrefRangeEnd = 376483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyStatByIndex(CopyStatByIndexOptions options, out Stat outStat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_CopyStatByIndex_Public_Result_CopyStatByIndexOptions_byref_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Stat local = ref outStat;
    System.IntPtr pointer = zero;
    Stat stat = pointer == System.IntPtr.Zero ? (Stat) null : new Stat(pointer);
    local = stat;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376483, XrefRangeEnd = 376556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyStatByName(CopyStatByNameOptions options, out Stat outStat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_CopyStatByName_Public_Result_CopyStatByNameOptions_byref_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Stat local = ref outStat;
    System.IntPtr pointer = zero;
    Stat stat = pointer == System.IntPtr.Zero ? (Stat) null : new Stat(pointer);
    local = stat;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376556, XrefRangeEnd = 376625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetStatsCount(GetStatCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_GetStatsCount_Public_UInt32_GetStatCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376625, XrefRangeEnd = 376705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void IngestStat(
    IngestStatOptions options,
    Il2CppSystem.Object clientData,
    OnIngestStatCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_IngestStat_Public_Void_IngestStatOptions_Object_OnIngestStatCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376705, XrefRangeEnd = 376785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryStats(
    QueryStatsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryStatsCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_QueryStats_Public_Void_QueryStatsOptions_Object_OnQueryStatsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376785, XrefRangeEnd = 376791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnIngestStatCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_OnIngestStatCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376791, XrefRangeEnd = 376797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryStatsCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_OnQueryStatsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CopystatbyindexApiLatest
  {
    get
    {
      int copystatbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_CopystatbyindexApiLatest, (void*) &copystatbyindexApiLatest);
      return copystatbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_CopystatbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopystatbynameApiLatest
  {
    get
    {
      int copystatbynameApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_CopystatbynameApiLatest, (void*) &copystatbynameApiLatest);
      return copystatbynameApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_CopystatbynameApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetstatcountApiLatest
  {
    get
    {
      int getstatcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_GetstatcountApiLatest, (void*) &getstatcountApiLatest);
      return getstatcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_GetstatcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetstatscountApiLatest
  {
    get
    {
      int getstatscountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_GetstatscountApiLatest, (void*) &getstatscountApiLatest);
      return getstatscountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_GetstatscountApiLatest, (void*) &value);
    }
  }

  public static unsafe int IngestdataApiLatest
  {
    get
    {
      int ingestdataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_IngestdataApiLatest, (void*) &ingestdataApiLatest);
      return ingestdataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_IngestdataApiLatest, (void*) &value);
    }
  }

  public static unsafe int IngeststatApiLatest
  {
    get
    {
      int ingeststatApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_IngeststatApiLatest, (void*) &ingeststatApiLatest);
      return ingeststatApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_IngeststatApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxIngestStats
  {
    get
    {
      int maxIngestStats;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_MaxIngestStats, (void*) &maxIngestStats);
      return maxIngestStats;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_MaxIngestStats, (void*) &value);
    }
  }

  public static unsafe int MaxQueryStats
  {
    get
    {
      int maxQueryStats;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_MaxQueryStats, (void*) &maxQueryStats);
      return maxQueryStats;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_MaxQueryStats, (void*) &value);
    }
  }

  public static unsafe int QuerystatsApiLatest
  {
    get
    {
      int querystatsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_QuerystatsApiLatest, (void*) &querystatsApiLatest);
      return querystatsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_QuerystatsApiLatest, (void*) &value);
    }
  }

  public static unsafe int StatApiLatest
  {
    get
    {
      int statApiLatest;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_StatApiLatest, (void*) &statApiLatest);
      return statApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_StatApiLatest, (void*) &value);
    }
  }

  public static unsafe int TimeUndefined
  {
    get
    {
      int timeUndefined;
      IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &timeUndefined);
      return timeUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &value);
    }
  }
}
