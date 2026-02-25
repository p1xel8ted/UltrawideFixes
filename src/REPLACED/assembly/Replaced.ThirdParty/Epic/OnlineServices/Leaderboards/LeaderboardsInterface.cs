// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.LeaderboardsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

public sealed class LeaderboardsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefinitionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LeaderboardrecordApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_LeaderboarduserscoreApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryleaderboardranksApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeUndefined;
  private static readonly System.IntPtr NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardDefinitionByIndex_Public_Result_CopyLeaderboardDefinitionByIndexOptions_byref_Definition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardDefinitionByLeaderboardId_Public_Result_CopyLeaderboardDefinitionByLeaderboardIdOptions_byref_Definition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardRecordByIndex_Public_Result_CopyLeaderboardRecordByIndexOptions_byref_LeaderboardRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardRecordByUserId_Public_Result_CopyLeaderboardRecordByUserIdOptions_byref_LeaderboardRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardUserScoreByIndex_Public_Result_CopyLeaderboardUserScoreByIndexOptions_byref_LeaderboardUserScore_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardUserScoreByUserId_Public_Result_CopyLeaderboardUserScoreByUserIdOptions_byref_LeaderboardUserScore_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardDefinitionCount_Public_UInt32_GetLeaderboardDefinitionCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardRecordCount_Public_UInt32_GetLeaderboardRecordCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardUserScoreCount_Public_UInt32_GetLeaderboardUserScoreCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryLeaderboardDefinitions_Public_Void_QueryLeaderboardDefinitionsOptions_Object_OnQueryLeaderboardDefinitionsCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryLeaderboardRanks_Public_Void_QueryLeaderboardRanksOptions_Object_OnQueryLeaderboardRanksCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryLeaderboardUserScores_Public_Void_QueryLeaderboardUserScoresOptions_Object_OnQueryLeaderboardUserScoresCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryLeaderboardRanksCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static LeaderboardsInterface()
  {
    Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (LeaderboardsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr);
    LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarddefinitionbyindexApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarddefinitionbyleaderboardidApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboardrecordbyindexApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboardrecordbyuseridApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarduserscorebyindexApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarduserscorebyuseridApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_DefinitionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (DefinitionApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (GetleaderboarddefinitioncountApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (GetleaderboardrecordcountApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (GetleaderboarduserscorecountApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_LeaderboardrecordApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (LeaderboardrecordApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_LeaderboarduserscoreApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (LeaderboarduserscoreApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (QueryleaderboarddefinitionsApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboardranksApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (QueryleaderboardranksApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (QueryleaderboarduserscoresApiLatest));
    LeaderboardsInterface.NativeFieldInfoPtr_TimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (TimeUndefined));
    LeaderboardsInterface.NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (UserscoresquerystatinfoApiLatest));
    LeaderboardsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100669995);
    LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByIndex_Public_Result_CopyLeaderboardDefinitionByIndexOptions_byref_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100669997);
    LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByLeaderboardId_Public_Result_CopyLeaderboardDefinitionByLeaderboardIdOptions_byref_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100669998);
    LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByIndex_Public_Result_CopyLeaderboardRecordByIndexOptions_byref_LeaderboardRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100669999);
    LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByUserId_Public_Result_CopyLeaderboardRecordByUserIdOptions_byref_LeaderboardRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670000);
    LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByIndex_Public_Result_CopyLeaderboardUserScoreByIndexOptions_byref_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670001);
    LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByUserId_Public_Result_CopyLeaderboardUserScoreByUserIdOptions_byref_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670002);
    LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardDefinitionCount_Public_UInt32_GetLeaderboardDefinitionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670003);
    LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardRecordCount_Public_UInt32_GetLeaderboardRecordCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670004);
    LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardUserScoreCount_Public_UInt32_GetLeaderboardUserScoreCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670005);
    LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardDefinitions_Public_Void_QueryLeaderboardDefinitionsOptions_Object_OnQueryLeaderboardDefinitionsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670006);
    LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardRanks_Public_Void_QueryLeaderboardRanksOptions_Object_OnQueryLeaderboardRanksCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670007);
    LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardUserScores_Public_Void_QueryLeaderboardUserScoresOptions_Object_OnQueryLeaderboardUserScoresCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670008);
    LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670009);
    LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardRanksCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670010);
    LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670011);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderboardsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391841, XrefRangeEnd = 391853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLeaderboardDefinitionByIndex(
    CopyLeaderboardDefinitionByIndexOptions options,
    out Definition outLeaderboardDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByIndex_Public_Result_CopyLeaderboardDefinitionByIndexOptions_byref_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Definition local = ref outLeaderboardDefinition;
    System.IntPtr pointer = zero;
    Definition definition = pointer == System.IntPtr.Zero ? (Definition) null : new Definition(pointer);
    local = definition;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391853, XrefRangeEnd = 391865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLeaderboardDefinitionByLeaderboardId(
    CopyLeaderboardDefinitionByLeaderboardIdOptions options,
    out Definition outLeaderboardDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByLeaderboardId_Public_Result_CopyLeaderboardDefinitionByLeaderboardIdOptions_byref_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Definition local = ref outLeaderboardDefinition;
    System.IntPtr pointer = zero;
    Definition definition = pointer == System.IntPtr.Zero ? (Definition) null : new Definition(pointer);
    local = definition;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391865, XrefRangeEnd = 391877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLeaderboardRecordByIndex(
    CopyLeaderboardRecordByIndexOptions options,
    out LeaderboardRecord outLeaderboardRecord)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByIndex_Public_Result_CopyLeaderboardRecordByIndexOptions_byref_LeaderboardRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LeaderboardRecord local = ref outLeaderboardRecord;
    System.IntPtr pointer = zero;
    LeaderboardRecord leaderboardRecord = pointer == System.IntPtr.Zero ? (LeaderboardRecord) null : new LeaderboardRecord(pointer);
    local = leaderboardRecord;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391877, XrefRangeEnd = 391889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLeaderboardRecordByUserId(
    CopyLeaderboardRecordByUserIdOptions options,
    out LeaderboardRecord outLeaderboardRecord)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByUserId_Public_Result_CopyLeaderboardRecordByUserIdOptions_byref_LeaderboardRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LeaderboardRecord local = ref outLeaderboardRecord;
    System.IntPtr pointer = zero;
    LeaderboardRecord leaderboardRecord = pointer == System.IntPtr.Zero ? (LeaderboardRecord) null : new LeaderboardRecord(pointer);
    local = leaderboardRecord;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391889, XrefRangeEnd = 391901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLeaderboardUserScoreByIndex(
    CopyLeaderboardUserScoreByIndexOptions options,
    out LeaderboardUserScore outLeaderboardUserScore)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByIndex_Public_Result_CopyLeaderboardUserScoreByIndexOptions_byref_LeaderboardUserScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LeaderboardUserScore local = ref outLeaderboardUserScore;
    System.IntPtr pointer = zero;
    LeaderboardUserScore leaderboardUserScore = pointer == System.IntPtr.Zero ? (LeaderboardUserScore) null : new LeaderboardUserScore(pointer);
    local = leaderboardUserScore;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391901, XrefRangeEnd = 391913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyLeaderboardUserScoreByUserId(
    CopyLeaderboardUserScoreByUserIdOptions options,
    out LeaderboardUserScore outLeaderboardUserScore)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByUserId_Public_Result_CopyLeaderboardUserScoreByUserIdOptions_byref_LeaderboardUserScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LeaderboardUserScore local = ref outLeaderboardUserScore;
    System.IntPtr pointer = zero;
    LeaderboardUserScore leaderboardUserScore = pointer == System.IntPtr.Zero ? (LeaderboardUserScore) null : new LeaderboardUserScore(pointer);
    local = leaderboardUserScore;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391913, XrefRangeEnd = 391921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetLeaderboardDefinitionCount(GetLeaderboardDefinitionCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardDefinitionCount_Public_UInt32_GetLeaderboardDefinitionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391921, XrefRangeEnd = 391929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetLeaderboardRecordCount(GetLeaderboardRecordCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardRecordCount_Public_UInt32_GetLeaderboardRecordCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391929, XrefRangeEnd = 391937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetLeaderboardUserScoreCount(GetLeaderboardUserScoreCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardUserScoreCount_Public_UInt32_GetLeaderboardUserScoreCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391937, XrefRangeEnd = 391956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryLeaderboardDefinitions(
    QueryLeaderboardDefinitionsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardDefinitions_Public_Void_QueryLeaderboardDefinitionsOptions_Object_OnQueryLeaderboardDefinitionsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391956, XrefRangeEnd = 391975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryLeaderboardRanks(
    QueryLeaderboardRanksOptions options,
    Il2CppSystem.Object clientData,
    OnQueryLeaderboardRanksCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardRanks_Public_Void_QueryLeaderboardRanksOptions_Object_OnQueryLeaderboardRanksCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391975, XrefRangeEnd = 391994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryLeaderboardUserScores(
    QueryLeaderboardUserScoresOptions options,
    Il2CppSystem.Object clientData,
    OnQueryLeaderboardUserScoresCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardUserScores_Public_Void_QueryLeaderboardUserScoresOptions_Object_OnQueryLeaderboardUserScoresCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391994, XrefRangeEnd = 392000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(
    System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392000, XrefRangeEnd = 392006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(
    System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardRanksCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392006, XrefRangeEnd = 392012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(
    System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CopyleaderboarddefinitionbyindexApiLatest
  {
    get
    {
      int copyleaderboarddefinitionbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest, (void*) &copyleaderboarddefinitionbyindexApiLatest);
      return copyleaderboarddefinitionbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyleaderboarddefinitionbyleaderboardidApiLatest
  {
    get
    {
      int copyleaderboarddefinitionbyleaderboardidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest, (void*) &copyleaderboarddefinitionbyleaderboardidApiLatest);
      return copyleaderboarddefinitionbyleaderboardidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyleaderboardrecordbyindexApiLatest
  {
    get
    {
      int copyleaderboardrecordbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest, (void*) &copyleaderboardrecordbyindexApiLatest);
      return copyleaderboardrecordbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyleaderboardrecordbyuseridApiLatest
  {
    get
    {
      int copyleaderboardrecordbyuseridApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest, (void*) &copyleaderboardrecordbyuseridApiLatest);
      return copyleaderboardrecordbyuseridApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyleaderboarduserscorebyindexApiLatest
  {
    get
    {
      int copyleaderboarduserscorebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest, (void*) &copyleaderboarduserscorebyindexApiLatest);
      return copyleaderboarduserscorebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyleaderboarduserscorebyuseridApiLatest
  {
    get
    {
      int copyleaderboarduserscorebyuseridApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest, (void*) &copyleaderboarduserscorebyuseridApiLatest);
      return copyleaderboarduserscorebyuseridApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest, (void*) &value);
    }
  }

  public static unsafe int DefinitionApiLatest
  {
    get
    {
      int definitionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &definitionApiLatest);
      return definitionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetleaderboarddefinitioncountApiLatest
  {
    get
    {
      int getleaderboarddefinitioncountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest, (void*) &getleaderboarddefinitioncountApiLatest);
      return getleaderboarddefinitioncountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetleaderboardrecordcountApiLatest
  {
    get
    {
      int getleaderboardrecordcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest, (void*) &getleaderboardrecordcountApiLatest);
      return getleaderboardrecordcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetleaderboarduserscorecountApiLatest
  {
    get
    {
      int getleaderboarduserscorecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest, (void*) &getleaderboarduserscorecountApiLatest);
      return getleaderboarduserscorecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LeaderboardrecordApiLatest
  {
    get
    {
      int leaderboardrecordApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboardrecordApiLatest, (void*) &leaderboardrecordApiLatest);
      return leaderboardrecordApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboardrecordApiLatest, (void*) &value);
    }
  }

  public static unsafe int LeaderboarduserscoreApiLatest
  {
    get
    {
      int leaderboarduserscoreApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboarduserscoreApiLatest, (void*) &leaderboarduserscoreApiLatest);
      return leaderboarduserscoreApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboarduserscoreApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryleaderboarddefinitionsApiLatest
  {
    get
    {
      int queryleaderboarddefinitionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest, (void*) &queryleaderboarddefinitionsApiLatest);
      return queryleaderboarddefinitionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryleaderboardranksApiLatest
  {
    get
    {
      int queryleaderboardranksApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboardranksApiLatest, (void*) &queryleaderboardranksApiLatest);
      return queryleaderboardranksApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboardranksApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryleaderboarduserscoresApiLatest
  {
    get
    {
      int queryleaderboarduserscoresApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest, (void*) &queryleaderboarduserscoresApiLatest);
      return queryleaderboarduserscoresApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest, (void*) &value);
    }
  }

  public static unsafe int TimeUndefined
  {
    get
    {
      int timeUndefined;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &timeUndefined);
      return timeUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &value);
    }
  }

  public static unsafe int UserscoresquerystatinfoApiLatest
  {
    get
    {
      int userscoresquerystatinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest, (void*) &userscoresquerystatinfoApiLatest);
      return userscoresquerystatinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest, (void*) &value);
    }
  }
}
