// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.AchievementsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

public sealed class AchievementsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AchievementUnlocktimeUndefined;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopydefinitionbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefinitionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_Definitionv2ApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetplayerachievementcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetunlockedachievementcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayerachievementApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayerstatinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QuerydefinitionsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryplayerachievementsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_StatthresholdApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_StatthresholdsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnlockachievementsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedachievementApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAchievementsUnlocked_Public_UInt64_AddNotifyAchievementsUnlockedOptions_Object_OnAchievementsUnlockedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAchievementsUnlockedV2_Public_UInt64_AddNotifyAchievementsUnlockedV2Options_Object_OnAchievementsUnlockedCallbackV2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionByAchievementId_Public_Result_CopyAchievementDefinitionByAchievementIdOptions_byref_Definition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionByIndex_Public_Result_CopyAchievementDefinitionByIndexOptions_byref_Definition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionV2ByAchievementId_Public_Result_CopyAchievementDefinitionV2ByAchievementIdOptions_byref_DefinitionV2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionV2ByIndex_Public_Result_CopyAchievementDefinitionV2ByIndexOptions_byref_DefinitionV2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPlayerAchievementByAchievementId_Public_Result_CopyPlayerAchievementByAchievementIdOptions_byref_PlayerAchievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPlayerAchievementByIndex_Public_Result_CopyPlayerAchievementByIndexOptions_byref_PlayerAchievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyUnlockedAchievementByAchievementId_Public_Result_CopyUnlockedAchievementByAchievementIdOptions_byref_UnlockedAchievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyUnlockedAchievementByIndex_Public_Result_CopyUnlockedAchievementByIndexOptions_byref_UnlockedAchievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAchievementDefinitionCount_Public_UInt32_GetAchievementDefinitionCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerAchievementCount_Public_UInt32_GetPlayerAchievementCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockedAchievementCount_Public_UInt32_GetUnlockedAchievementCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryDefinitions_Public_Void_QueryDefinitionsOptions_Object_OnQueryDefinitionsCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryPlayerAchievements_Public_Void_QueryPlayerAchievementsOptions_Object_OnQueryPlayerAchievementsCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAchievementsUnlocked_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAchievements_Public_Void_UnlockAchievementsOptions_Object_OnUnlockAchievementsCompleteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAchievementsUnlockedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAchievementsUnlockedCallbackV2InternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryPlayerAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUnlockAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static AchievementsInterface()
  {
    Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (AchievementsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr);
    AchievementsInterface.NativeFieldInfoPtr_AchievementUnlocktimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (AchievementUnlocktimeUndefined));
    AchievementsInterface.NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (AddnotifyachievementsunlockedApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Addnotifyachievementsunlockedv2ApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copyachievementdefinitionv2ByachievementidApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copyachievementdefinitionv2ByindexApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopydefinitionbyachievementidApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopydefinitionbyindexApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copydefinitionv2ByachievementidApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copydefinitionv2ByindexApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyplayerachievementbyachievementidApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyplayerachievementbyindexApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyunlockedachievementbyachievementidApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyunlockedachievementbyindexApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_DefinitionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (DefinitionApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_Definitionv2ApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Definitionv2ApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (GetachievementdefinitioncountApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_GetplayerachievementcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (GetplayerachievementcountApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_GetunlockedachievementcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (GetunlockedachievementcountApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_PlayerachievementApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (PlayerachievementApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_PlayerstatinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (PlayerstatinfoApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_QuerydefinitionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (QuerydefinitionsApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_QueryplayerachievementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (QueryplayerachievementsApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_StatthresholdApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (StatthresholdApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_StatthresholdsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (StatthresholdsApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_UnlockachievementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (UnlockachievementsApiLatest));
    AchievementsInterface.NativeFieldInfoPtr_UnlockedachievementApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (UnlockedachievementApiLatest));
    AchievementsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673188);
    AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlocked_Public_UInt64_AddNotifyAchievementsUnlockedOptions_Object_OnAchievementsUnlockedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673190);
    AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlockedV2_Public_UInt64_AddNotifyAchievementsUnlockedV2Options_Object_OnAchievementsUnlockedCallbackV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673191);
    AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByAchievementId_Public_Result_CopyAchievementDefinitionByAchievementIdOptions_byref_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673192);
    AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByIndex_Public_Result_CopyAchievementDefinitionByIndexOptions_byref_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673193);
    AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByAchievementId_Public_Result_CopyAchievementDefinitionV2ByAchievementIdOptions_byref_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673194);
    AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByIndex_Public_Result_CopyAchievementDefinitionV2ByIndexOptions_byref_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673195);
    AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByAchievementId_Public_Result_CopyPlayerAchievementByAchievementIdOptions_byref_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673196);
    AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByIndex_Public_Result_CopyPlayerAchievementByIndexOptions_byref_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673197);
    AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByAchievementId_Public_Result_CopyUnlockedAchievementByAchievementIdOptions_byref_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673198);
    AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByIndex_Public_Result_CopyUnlockedAchievementByIndexOptions_byref_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673199);
    AchievementsInterface.NativeMethodInfoPtr_GetAchievementDefinitionCount_Public_UInt32_GetAchievementDefinitionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673200);
    AchievementsInterface.NativeMethodInfoPtr_GetPlayerAchievementCount_Public_UInt32_GetPlayerAchievementCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673201);
    AchievementsInterface.NativeMethodInfoPtr_GetUnlockedAchievementCount_Public_UInt32_GetUnlockedAchievementCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673202);
    AchievementsInterface.NativeMethodInfoPtr_QueryDefinitions_Public_Void_QueryDefinitionsOptions_Object_OnQueryDefinitionsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673203);
    AchievementsInterface.NativeMethodInfoPtr_QueryPlayerAchievements_Public_Void_QueryPlayerAchievementsOptions_Object_OnQueryPlayerAchievementsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673204);
    AchievementsInterface.NativeMethodInfoPtr_RemoveNotifyAchievementsUnlocked_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673205);
    AchievementsInterface.NativeMethodInfoPtr_UnlockAchievements_Public_Void_UnlockAchievementsOptions_Object_OnUnlockAchievementsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673206);
    AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673207);
    AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackV2InternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673208);
    AchievementsInterface.NativeMethodInfoPtr_OnQueryDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673209);
    AchievementsInterface.NativeMethodInfoPtr_OnQueryPlayerAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673210);
    AchievementsInterface.NativeMethodInfoPtr_OnUnlockAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100673211);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AchievementsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401496, XrefRangeEnd = 401516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAchievementsUnlocked(
    AddNotifyAchievementsUnlockedOptions options,
    Il2CppSystem.Object clientData,
    OnAchievementsUnlockedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlocked_Public_UInt64_AddNotifyAchievementsUnlockedOptions_Object_OnAchievementsUnlockedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401516, XrefRangeEnd = 401536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyAchievementsUnlockedV2(
    AddNotifyAchievementsUnlockedV2Options options,
    Il2CppSystem.Object clientData,
    OnAchievementsUnlockedCallbackV2 notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlockedV2_Public_UInt64_AddNotifyAchievementsUnlockedV2Options_Object_OnAchievementsUnlockedCallbackV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401536, XrefRangeEnd = 401548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyAchievementDefinitionByAchievementId(
    CopyAchievementDefinitionByAchievementIdOptions options,
    out Definition outDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByAchievementId_Public_Result_CopyAchievementDefinitionByAchievementIdOptions_byref_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Definition local = ref outDefinition;
    System.IntPtr pointer = zero;
    Definition definition = pointer == System.IntPtr.Zero ? (Definition) null : new Definition(pointer);
    local = definition;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401548, XrefRangeEnd = 401560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyAchievementDefinitionByIndex(
    CopyAchievementDefinitionByIndexOptions options,
    out Definition outDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByIndex_Public_Result_CopyAchievementDefinitionByIndexOptions_byref_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Definition local = ref outDefinition;
    System.IntPtr pointer = zero;
    Definition definition = pointer == System.IntPtr.Zero ? (Definition) null : new Definition(pointer);
    local = definition;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401560, XrefRangeEnd = 401572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyAchievementDefinitionV2ByAchievementId(
    CopyAchievementDefinitionV2ByAchievementIdOptions options,
    out DefinitionV2 outDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByAchievementId_Public_Result_CopyAchievementDefinitionV2ByAchievementIdOptions_byref_DefinitionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref DefinitionV2 local = ref outDefinition;
    System.IntPtr pointer = zero;
    DefinitionV2 definitionV2 = pointer == System.IntPtr.Zero ? (DefinitionV2) null : new DefinitionV2(pointer);
    local = definitionV2;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401572, XrefRangeEnd = 401584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyAchievementDefinitionV2ByIndex(
    CopyAchievementDefinitionV2ByIndexOptions options,
    out DefinitionV2 outDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByIndex_Public_Result_CopyAchievementDefinitionV2ByIndexOptions_byref_DefinitionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref DefinitionV2 local = ref outDefinition;
    System.IntPtr pointer = zero;
    DefinitionV2 definitionV2 = pointer == System.IntPtr.Zero ? (DefinitionV2) null : new DefinitionV2(pointer);
    local = definitionV2;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401584, XrefRangeEnd = 401596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyPlayerAchievementByAchievementId(
    CopyPlayerAchievementByAchievementIdOptions options,
    out PlayerAchievement outAchievement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByAchievementId_Public_Result_CopyPlayerAchievementByAchievementIdOptions_byref_PlayerAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PlayerAchievement local = ref outAchievement;
    System.IntPtr pointer = zero;
    PlayerAchievement playerAchievement = pointer == System.IntPtr.Zero ? (PlayerAchievement) null : new PlayerAchievement(pointer);
    local = playerAchievement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401596, XrefRangeEnd = 401608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyPlayerAchievementByIndex(
    CopyPlayerAchievementByIndexOptions options,
    out PlayerAchievement outAchievement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByIndex_Public_Result_CopyPlayerAchievementByIndexOptions_byref_PlayerAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PlayerAchievement local = ref outAchievement;
    System.IntPtr pointer = zero;
    PlayerAchievement playerAchievement = pointer == System.IntPtr.Zero ? (PlayerAchievement) null : new PlayerAchievement(pointer);
    local = playerAchievement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401608, XrefRangeEnd = 401620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyUnlockedAchievementByAchievementId(
    CopyUnlockedAchievementByAchievementIdOptions options,
    out UnlockedAchievement outAchievement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByAchievementId_Public_Result_CopyUnlockedAchievementByAchievementIdOptions_byref_UnlockedAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref UnlockedAchievement local = ref outAchievement;
    System.IntPtr pointer = zero;
    UnlockedAchievement unlockedAchievement = pointer == System.IntPtr.Zero ? (UnlockedAchievement) null : new UnlockedAchievement(pointer);
    local = unlockedAchievement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401620, XrefRangeEnd = 401632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyUnlockedAchievementByIndex(
    CopyUnlockedAchievementByIndexOptions options,
    out UnlockedAchievement outAchievement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByIndex_Public_Result_CopyUnlockedAchievementByIndexOptions_byref_UnlockedAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref UnlockedAchievement local = ref outAchievement;
    System.IntPtr pointer = zero;
    UnlockedAchievement unlockedAchievement = pointer == System.IntPtr.Zero ? (UnlockedAchievement) null : new UnlockedAchievement(pointer);
    local = unlockedAchievement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401632, XrefRangeEnd = 401640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetAchievementDefinitionCount(GetAchievementDefinitionCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_GetAchievementDefinitionCount_Public_UInt32_GetAchievementDefinitionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401640, XrefRangeEnd = 401648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetPlayerAchievementCount(GetPlayerAchievementCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_GetPlayerAchievementCount_Public_UInt32_GetPlayerAchievementCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401648, XrefRangeEnd = 401656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetUnlockedAchievementCount(GetUnlockedAchievementCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_GetUnlockedAchievementCount_Public_UInt32_GetUnlockedAchievementCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401656, XrefRangeEnd = 401675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryDefinitions(
    QueryDefinitionsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryDefinitionsCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_QueryDefinitions_Public_Void_QueryDefinitionsOptions_Object_OnQueryDefinitionsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401675, XrefRangeEnd = 401694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryPlayerAchievements(
    QueryPlayerAchievementsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryPlayerAchievementsCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_QueryPlayerAchievements_Public_Void_QueryPlayerAchievementsOptions_Object_OnQueryPlayerAchievementsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401694, XrefRangeEnd = 401699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyAchievementsUnlocked(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_RemoveNotifyAchievementsUnlocked_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401699, XrefRangeEnd = 401718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnlockAchievements(
    UnlockAchievementsOptions options,
    Il2CppSystem.Object clientData,
    OnUnlockAchievementsCompleteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_UnlockAchievements_Public_Void_UnlockAchievementsOptions_Object_OnUnlockAchievementsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401718, XrefRangeEnd = 401724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAchievementsUnlockedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401724, XrefRangeEnd = 401730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAchievementsUnlockedCallbackV2InternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackV2InternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401730, XrefRangeEnd = 401736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryDefinitionsCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnQueryDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401736, XrefRangeEnd = 401742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryPlayerAchievementsCompleteCallbackInternalImplementation(
    System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnQueryPlayerAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401742, XrefRangeEnd = 401748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUnlockAchievementsCompleteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnUnlockAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AchievementUnlocktimeUndefined
  {
    get
    {
      int unlocktimeUndefined;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_AchievementUnlocktimeUndefined, (void*) &unlocktimeUndefined);
      return unlocktimeUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_AchievementUnlocktimeUndefined, (void*) &value);
    }
  }

  public static unsafe int AddnotifyachievementsunlockedApiLatest
  {
    get
    {
      int addnotifyachievementsunlockedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest, (void*) &addnotifyachievementsunlockedApiLatest);
      return addnotifyachievementsunlockedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest, (void*) &value);
    }
  }

  public static unsafe int Addnotifyachievementsunlockedv2ApiLatest
  {
    get
    {
      int addnotifyachievementsunlockedv2ApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest, (void*) &addnotifyachievementsunlockedv2ApiLatest);
      return addnotifyachievementsunlockedv2ApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest, (void*) &value);
    }
  }

  public static unsafe int Copyachievementdefinitionv2ByachievementidApiLatest
  {
    get
    {
      int byachievementidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest, (void*) &byachievementidApiLatest);
      return byachievementidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest, (void*) &value);
    }
  }

  public static unsafe int Copyachievementdefinitionv2ByindexApiLatest
  {
    get
    {
      int byindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest, (void*) &byindexApiLatest);
      return byindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopydefinitionbyachievementidApiLatest
  {
    get
    {
      int copydefinitionbyachievementidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest, (void*) &copydefinitionbyachievementidApiLatest);
      return copydefinitionbyachievementidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopydefinitionbyindexApiLatest
  {
    get
    {
      int copydefinitionbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyindexApiLatest, (void*) &copydefinitionbyindexApiLatest);
      return copydefinitionbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int Copydefinitionv2ByachievementidApiLatest
  {
    get
    {
      int byachievementidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest, (void*) &byachievementidApiLatest);
      return byachievementidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest, (void*) &value);
    }
  }

  public static unsafe int Copydefinitionv2ByindexApiLatest
  {
    get
    {
      int byindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest, (void*) &byindexApiLatest);
      return byindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyplayerachievementbyachievementidApiLatest
  {
    get
    {
      int copyplayerachievementbyachievementidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest, (void*) &copyplayerachievementbyachievementidApiLatest);
      return copyplayerachievementbyachievementidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyplayerachievementbyindexApiLatest
  {
    get
    {
      int copyplayerachievementbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest, (void*) &copyplayerachievementbyindexApiLatest);
      return copyplayerachievementbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyunlockedachievementbyachievementidApiLatest
  {
    get
    {
      int copyunlockedachievementbyachievementidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest, (void*) &copyunlockedachievementbyachievementidApiLatest);
      return copyunlockedachievementbyachievementidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyunlockedachievementbyindexApiLatest
  {
    get
    {
      int copyunlockedachievementbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest, (void*) &copyunlockedachievementbyindexApiLatest);
      return copyunlockedachievementbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int DefinitionApiLatest
  {
    get
    {
      int definitionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &definitionApiLatest);
      return definitionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &value);
    }
  }

  public static unsafe int Definitionv2ApiLatest
  {
    get
    {
      int definitionv2ApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Definitionv2ApiLatest, (void*) &definitionv2ApiLatest);
      return definitionv2ApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Definitionv2ApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetachievementdefinitioncountApiLatest
  {
    get
    {
      int getachievementdefinitioncountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest, (void*) &getachievementdefinitioncountApiLatest);
      return getachievementdefinitioncountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetplayerachievementcountApiLatest
  {
    get
    {
      int getplayerachievementcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_GetplayerachievementcountApiLatest, (void*) &getplayerachievementcountApiLatest);
      return getplayerachievementcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_GetplayerachievementcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetunlockedachievementcountApiLatest
  {
    get
    {
      int getunlockedachievementcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_GetunlockedachievementcountApiLatest, (void*) &getunlockedachievementcountApiLatest);
      return getunlockedachievementcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_GetunlockedachievementcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int PlayerachievementApiLatest
  {
    get
    {
      int playerachievementApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_PlayerachievementApiLatest, (void*) &playerachievementApiLatest);
      return playerachievementApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_PlayerachievementApiLatest, (void*) &value);
    }
  }

  public static unsafe int PlayerstatinfoApiLatest
  {
    get
    {
      int playerstatinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_PlayerstatinfoApiLatest, (void*) &playerstatinfoApiLatest);
      return playerstatinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_PlayerstatinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int QuerydefinitionsApiLatest
  {
    get
    {
      int querydefinitionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_QuerydefinitionsApiLatest, (void*) &querydefinitionsApiLatest);
      return querydefinitionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_QuerydefinitionsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryplayerachievementsApiLatest
  {
    get
    {
      int queryplayerachievementsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_QueryplayerachievementsApiLatest, (void*) &queryplayerachievementsApiLatest);
      return queryplayerachievementsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_QueryplayerachievementsApiLatest, (void*) &value);
    }
  }

  public static unsafe int StatthresholdApiLatest
  {
    get
    {
      int statthresholdApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdApiLatest, (void*) &statthresholdApiLatest);
      return statthresholdApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdApiLatest, (void*) &value);
    }
  }

  public static unsafe int StatthresholdsApiLatest
  {
    get
    {
      int statthresholdsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdsApiLatest, (void*) &statthresholdsApiLatest);
      return statthresholdsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdsApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnlockachievementsApiLatest
  {
    get
    {
      int unlockachievementsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_UnlockachievementsApiLatest, (void*) &unlockachievementsApiLatest);
      return unlockachievementsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_UnlockachievementsApiLatest, (void*) &value);
    }
  }

  public static unsafe int UnlockedachievementApiLatest
  {
    get
    {
      int unlockedachievementApiLatest;
      IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_UnlockedachievementApiLatest, (void*) &unlockedachievementApiLatest);
      return unlockedachievementApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_UnlockedachievementApiLatest, (void*) &value);
    }
  }
}
