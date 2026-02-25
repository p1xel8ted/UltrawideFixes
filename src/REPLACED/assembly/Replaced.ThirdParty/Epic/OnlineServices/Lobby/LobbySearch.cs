// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbySearch
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public sealed class LobbySearch(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchFindApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSetparameterApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_LobbySearchCopySearchResultByIndexOptions_byref_LobbyDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Void_LobbySearchFindOptions_Object_LobbySearchOnFindCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_LobbySearchGetSearchResultCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveParameter_Public_Result_LobbySearchRemoveParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLobbyId_Public_Result_LobbySearchSetLobbyIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxResults_Public_Result_LobbySearchSetMaxResultsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParameter_Public_Result_LobbySearchSetParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetUserId_Public_Result_LobbySearchSetTargetUserIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static LobbySearch()
  {
    Il2CppClassPointerStore<LobbySearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbySearch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr);
    LobbySearch.NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchCopysearchresultbyindexApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchFindApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchFindApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchGetsearchresultcountApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchRemoveparameterApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSetlobbyidApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSetmaxresultsApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchSetparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSetparameterApiLatest));
    LobbySearch.NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSettargetuseridApiLatest));
    LobbySearch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669475);
    LobbySearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_LobbySearchCopySearchResultByIndexOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669477);
    LobbySearch.NativeMethodInfoPtr_Find_Public_Void_LobbySearchFindOptions_Object_LobbySearchOnFindCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669478);
    LobbySearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_LobbySearchGetSearchResultCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669479);
    LobbySearch.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669480);
    LobbySearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_LobbySearchRemoveParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669481);
    LobbySearch.NativeMethodInfoPtr_SetLobbyId_Public_Result_LobbySearchSetLobbyIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669482);
    LobbySearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_LobbySearchSetMaxResultsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669483);
    LobbySearch.NativeMethodInfoPtr_SetParameter_Public_Result_LobbySearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669484);
    LobbySearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_LobbySearchSetTargetUserIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669485);
    LobbySearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100669486);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbySearch()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390751, XrefRangeEnd = 390762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySearchResultByIndex(
    LobbySearchCopySearchResultByIndexOptions options,
    out LobbyDetails outLobbyDetailsHandle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_LobbySearchCopySearchResultByIndexOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbyDetails local = ref outLobbyDetailsHandle;
    System.IntPtr pointer = zero;
    LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
    local = lobbyDetails;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390762, XrefRangeEnd = 390781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Find(
    LobbySearchFindOptions options,
    Il2CppSystem.Object clientData,
    LobbySearchOnFindCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_Find_Public_Void_LobbySearchFindOptions_Object_LobbySearchOnFindCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390781, XrefRangeEnd = 390789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetSearchResultCount(LobbySearchGetSearchResultCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_LobbySearchGetSearchResultCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390789, XrefRangeEnd = 390790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390790, XrefRangeEnd = 390798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RemoveParameter(LobbySearchRemoveParameterOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_LobbySearchRemoveParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390798, XrefRangeEnd = 390806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetLobbyId(LobbySearchSetLobbyIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetLobbyId_Public_Result_LobbySearchSetLobbyIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390806, XrefRangeEnd = 390814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetMaxResults(LobbySearchSetMaxResultsOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_LobbySearchSetMaxResultsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390814, XrefRangeEnd = 390822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetParameter(LobbySearchSetParameterOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetParameter_Public_Result_LobbySearchSetParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390822, XrefRangeEnd = 390830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetTargetUserId(LobbySearchSetTargetUserIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_LobbySearchSetTargetUserIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390830, XrefRangeEnd = 390836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnFindCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int LobbysearchCopysearchresultbyindexApiLatest
  {
    get
    {
      int copysearchresultbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest, (void*) &copysearchresultbyindexApiLatest);
      return copysearchresultbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchFindApiLatest
  {
    get
    {
      int lobbysearchFindApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchFindApiLatest, (void*) &lobbysearchFindApiLatest);
      return lobbysearchFindApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchFindApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchGetsearchresultcountApiLatest
  {
    get
    {
      int getsearchresultcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest, (void*) &getsearchresultcountApiLatest);
      return getsearchresultcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchRemoveparameterApiLatest
  {
    get
    {
      int removeparameterApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest, (void*) &removeparameterApiLatest);
      return removeparameterApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchSetlobbyidApiLatest
  {
    get
    {
      int setlobbyidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest, (void*) &setlobbyidApiLatest);
      return setlobbyidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchSetmaxresultsApiLatest
  {
    get
    {
      int setmaxresultsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest, (void*) &setmaxresultsApiLatest);
      return setmaxresultsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchSetparameterApiLatest
  {
    get
    {
      int setparameterApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetparameterApiLatest, (void*) &setparameterApiLatest);
      return setparameterApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetparameterApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbysearchSettargetuseridApiLatest
  {
    get
    {
      int settargetuseridApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest, (void*) &settargetuseridApiLatest);
      return settargetuseridApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest, (void*) &value);
    }
  }
}
