// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionSearch
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public sealed class SessionSearch(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchFindApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSetparameterApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_SessionSearchCopySearchResultByIndexOptions_byref_SessionDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Void_SessionSearchFindOptions_Object_SessionSearchOnFindCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_SessionSearchGetSearchResultCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveParameter_Public_Result_SessionSearchRemoveParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxResults_Public_Result_SessionSearchSetMaxResultsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParameter_Public_Result_SessionSearchSetParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSessionId_Public_Result_SessionSearchSetSessionIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetUserId_Public_Result_SessionSearchSetTargetUserIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static SessionSearch()
  {
    Il2CppClassPointerStore<SessionSearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionSearch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr);
    SessionSearch.NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchCopysearchresultbyindexApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchFindApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchFindApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchGetsearchresultcountApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchRemoveparameterApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSetmaxsearchresultsApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchSetparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSetparameterApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSetsessionidApiLatest));
    SessionSearch.NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSettargetuseridApiLatest));
    SessionSearch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665932);
    SessionSearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_SessionSearchCopySearchResultByIndexOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665934);
    SessionSearch.NativeMethodInfoPtr_Find_Public_Void_SessionSearchFindOptions_Object_SessionSearchOnFindCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665935);
    SessionSearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_SessionSearchGetSearchResultCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665936 /*0x06000A50*/);
    SessionSearch.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665937);
    SessionSearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_SessionSearchRemoveParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665938);
    SessionSearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_SessionSearchSetMaxResultsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665939);
    SessionSearch.NativeMethodInfoPtr_SetParameter_Public_Result_SessionSearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665940);
    SessionSearch.NativeMethodInfoPtr_SetSessionId_Public_Result_SessionSearchSetSessionIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665941);
    SessionSearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_SessionSearchSetTargetUserIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665942);
    SessionSearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100665943);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SessionSearch()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378918, XrefRangeEnd = 378929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySearchResultByIndex(
    SessionSearchCopySearchResultByIndexOptions options,
    out SessionDetails outSessionHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_SessionSearchCopySearchResultByIndexOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetails local = ref outSessionHandle;
    System.IntPtr pointer = zero;
    SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
    local = sessionDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378929, XrefRangeEnd = 378948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Find(
    SessionSearchFindOptions options,
    Il2CppSystem.Object clientData,
    SessionSearchOnFindCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_Find_Public_Void_SessionSearchFindOptions_Object_SessionSearchOnFindCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378948, XrefRangeEnd = 378956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetSearchResultCount(SessionSearchGetSearchResultCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_SessionSearchGetSearchResultCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378956, XrefRangeEnd = 378957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378957, XrefRangeEnd = 378965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RemoveParameter(SessionSearchRemoveParameterOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_SessionSearchRemoveParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378965, XrefRangeEnd = 378973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetMaxResults(SessionSearchSetMaxResultsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_SessionSearchSetMaxResultsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378973, XrefRangeEnd = 378981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetParameter(SessionSearchSetParameterOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetParameter_Public_Result_SessionSearchSetParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378981, XrefRangeEnd = 378989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetSessionId(SessionSearchSetSessionIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetSessionId_Public_Result_SessionSearchSetSessionIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378989, XrefRangeEnd = 378997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetTargetUserId(SessionSearchSetTargetUserIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_SessionSearchSetTargetUserIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378997, XrefRangeEnd = 379003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnFindCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int SessionsearchCopysearchresultbyindexApiLatest
  {
    get
    {
      int copysearchresultbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest, (void*) &copysearchresultbyindexApiLatest);
      return copysearchresultbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchFindApiLatest
  {
    get
    {
      int sessionsearchFindApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchFindApiLatest, (void*) &sessionsearchFindApiLatest);
      return sessionsearchFindApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchFindApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchGetsearchresultcountApiLatest
  {
    get
    {
      int getsearchresultcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest, (void*) &getsearchresultcountApiLatest);
      return getsearchresultcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchRemoveparameterApiLatest
  {
    get
    {
      int removeparameterApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest, (void*) &removeparameterApiLatest);
      return removeparameterApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchSetmaxsearchresultsApiLatest
  {
    get
    {
      int setmaxsearchresultsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest, (void*) &setmaxsearchresultsApiLatest);
      return setmaxsearchresultsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchSetparameterApiLatest
  {
    get
    {
      int setparameterApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetparameterApiLatest, (void*) &setparameterApiLatest);
      return setparameterApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetparameterApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchSetsessionidApiLatest
  {
    get
    {
      int setsessionidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest, (void*) &setsessionidApiLatest);
      return setsessionidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionsearchSettargetuseridApiLatest
  {
    get
    {
      int settargetuseridApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest, (void*) &settargetuseridApiLatest);
      return settargetuseridApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest, (void*) &value);
    }
  }
}
