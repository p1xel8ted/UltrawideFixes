// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.EcomInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

public sealed class EcomInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CatalogitemApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined;
  private static readonly System.IntPtr NativeFieldInfoPtr_CatalogofferApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined;
  private static readonly System.IntPtr NativeFieldInfoPtr_CatalogreleaseApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutMaxEntries;
  private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutentryApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyentitlementbyidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyentitlementbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyitembyidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferbyidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferitembyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopytransactionbyidApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_CopytransactionbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntitlementApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntitlementEndtimestampUndefined;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetentitlementscountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetitemimageinfocountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetitemreleasecountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetoffercountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetofferimageinfocountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetofferitemcountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GettransactioncountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemownershipApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_KeyimageinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryentitlementsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryoffersApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershipApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershipMaxCatalogIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershiptokenApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_RedeementitlementsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_RedeementitlementsMaxIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_TransactionidMaximumLength;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Checkout_Public_Void_CheckoutOptions_Object_OnCheckoutCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementById_Public_Result_CopyEntitlementByIdOptions_byref_Entitlement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_CopyEntitlementByIndexOptions_byref_Entitlement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementByNameAndIndex_Public_Result_CopyEntitlementByNameAndIndexOptions_byref_Entitlement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemById_Public_Result_CopyItemByIdOptions_byref_CatalogItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemImageInfoByIndex_Public_Result_CopyItemImageInfoByIndexOptions_byref_KeyImageInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemReleaseByIndex_Public_Result_CopyItemReleaseByIndexOptions_byref_CatalogRelease_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferById_Public_Result_CopyOfferByIdOptions_byref_CatalogOffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferByIndex_Public_Result_CopyOfferByIndexOptions_byref_CatalogOffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferImageInfoByIndex_Public_Result_CopyOfferImageInfoByIndexOptions_byref_KeyImageInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferItemByIndex_Public_Result_CopyOfferItemByIndexOptions_byref_CatalogItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTransactionById_Public_Result_CopyTransactionByIdOptions_byref_Transaction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTransactionByIndex_Public_Result_CopyTransactionByIndexOptions_byref_Transaction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitlementsByNameCount_Public_UInt32_GetEntitlementsByNameCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_GetEntitlementsCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetItemImageInfoCount_Public_UInt32_GetItemImageInfoCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetItemReleaseCount_Public_UInt32_GetItemReleaseCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferCount_Public_UInt32_GetOfferCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferImageInfoCount_Public_UInt32_GetOfferImageInfoCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferItemCount_Public_UInt32_GetOfferItemCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransactionCount_Public_UInt32_GetTransactionCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryEntitlements_Public_Void_QueryEntitlementsOptions_Object_OnQueryEntitlementsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryOffers_Public_Void_QueryOffersOptions_Object_OnQueryOffersCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryOwnership_Public_Void_QueryOwnershipOptions_Object_OnQueryOwnershipCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryOwnershipToken_Public_Void_QueryOwnershipTokenOptions_Object_OnQueryOwnershipTokenCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedeemEntitlements_Public_Void_RedeemEntitlementsOptions_Object_OnRedeemEntitlementsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCheckoutCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryEntitlementsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryOffersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryOwnershipCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryOwnershipTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRedeemEntitlementsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static EcomInterface()
  {
    Il2CppClassPointerStore<EcomInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (EcomInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr);
    EcomInterface.NativeFieldInfoPtr_CatalogitemApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogitemApiLatest));
    EcomInterface.NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogitemEntitlementendtimestampUndefined));
    EcomInterface.NativeFieldInfoPtr_CatalogofferApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogofferApiLatest));
    EcomInterface.NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogofferExpirationtimestampUndefined));
    EcomInterface.NativeFieldInfoPtr_CatalogreleaseApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogreleaseApiLatest));
    EcomInterface.NativeFieldInfoPtr_CheckoutApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CheckoutApiLatest));
    EcomInterface.NativeFieldInfoPtr_CheckoutMaxEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CheckoutMaxEntries));
    EcomInterface.NativeFieldInfoPtr_CheckoutentryApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CheckoutentryApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyentitlementbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyentitlementbyidApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyentitlementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyentitlementbyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyentitlementbynameandindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyitembyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyitembyidApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyitemimageinfobyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyitemreleasebyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyofferbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferbyidApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyofferbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferbyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferimageinfobyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopyofferitembyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferitembyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopytransactionbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopytransactionbyidApiLatest));
    EcomInterface.NativeFieldInfoPtr_CopytransactionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopytransactionbyindexApiLatest));
    EcomInterface.NativeFieldInfoPtr_EntitlementApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (EntitlementApiLatest));
    EcomInterface.NativeFieldInfoPtr_EntitlementEndtimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (EntitlementEndtimestampUndefined));
    EcomInterface.NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetentitlementsbynamecountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GetentitlementscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetentitlementscountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GetitemimageinfocountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetitemimageinfocountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GetitemreleasecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetitemreleasecountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GetoffercountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetoffercountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GetofferimageinfocountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetofferimageinfocountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GetofferitemcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetofferitemcountApiLatest));
    EcomInterface.NativeFieldInfoPtr_GettransactioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GettransactioncountApiLatest));
    EcomInterface.NativeFieldInfoPtr_ItemownershipApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (ItemownershipApiLatest));
    EcomInterface.NativeFieldInfoPtr_KeyimageinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (KeyimageinfoApiLatest));
    EcomInterface.NativeFieldInfoPtr_QueryentitlementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryentitlementsApiLatest));
    EcomInterface.NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryentitlementsMaxEntitlementIds));
    EcomInterface.NativeFieldInfoPtr_QueryoffersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryoffersApiLatest));
    EcomInterface.NativeFieldInfoPtr_QueryownershipApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershipApiLatest));
    EcomInterface.NativeFieldInfoPtr_QueryownershipMaxCatalogIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershipMaxCatalogIds));
    EcomInterface.NativeFieldInfoPtr_QueryownershiptokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershiptokenApiLatest));
    EcomInterface.NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershiptokenMaxCatalogitemIds));
    EcomInterface.NativeFieldInfoPtr_RedeementitlementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (RedeementitlementsApiLatest));
    EcomInterface.NativeFieldInfoPtr_RedeementitlementsMaxIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (RedeementitlementsMaxIds));
    EcomInterface.NativeFieldInfoPtr_TransactionidMaximumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (TransactionidMaximumLength));
    EcomInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670923);
    EcomInterface.NativeMethodInfoPtr_Checkout_Public_Void_CheckoutOptions_Object_OnCheckoutCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670925);
    EcomInterface.NativeMethodInfoPtr_CopyEntitlementById_Public_Result_CopyEntitlementByIdOptions_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670926);
    EcomInterface.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_CopyEntitlementByIndexOptions_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670927);
    EcomInterface.NativeMethodInfoPtr_CopyEntitlementByNameAndIndex_Public_Result_CopyEntitlementByNameAndIndexOptions_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670928);
    EcomInterface.NativeMethodInfoPtr_CopyItemById_Public_Result_CopyItemByIdOptions_byref_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670929);
    EcomInterface.NativeMethodInfoPtr_CopyItemImageInfoByIndex_Public_Result_CopyItemImageInfoByIndexOptions_byref_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670930);
    EcomInterface.NativeMethodInfoPtr_CopyItemReleaseByIndex_Public_Result_CopyItemReleaseByIndexOptions_byref_CatalogRelease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670931);
    EcomInterface.NativeMethodInfoPtr_CopyOfferById_Public_Result_CopyOfferByIdOptions_byref_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670932);
    EcomInterface.NativeMethodInfoPtr_CopyOfferByIndex_Public_Result_CopyOfferByIndexOptions_byref_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670933);
    EcomInterface.NativeMethodInfoPtr_CopyOfferImageInfoByIndex_Public_Result_CopyOfferImageInfoByIndexOptions_byref_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670934);
    EcomInterface.NativeMethodInfoPtr_CopyOfferItemByIndex_Public_Result_CopyOfferItemByIndexOptions_byref_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670935);
    EcomInterface.NativeMethodInfoPtr_CopyTransactionById_Public_Result_CopyTransactionByIdOptions_byref_Transaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670936);
    EcomInterface.NativeMethodInfoPtr_CopyTransactionByIndex_Public_Result_CopyTransactionByIndexOptions_byref_Transaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670937);
    EcomInterface.NativeMethodInfoPtr_GetEntitlementsByNameCount_Public_UInt32_GetEntitlementsByNameCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670938);
    EcomInterface.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_GetEntitlementsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670939);
    EcomInterface.NativeMethodInfoPtr_GetItemImageInfoCount_Public_UInt32_GetItemImageInfoCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670940);
    EcomInterface.NativeMethodInfoPtr_GetItemReleaseCount_Public_UInt32_GetItemReleaseCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670941);
    EcomInterface.NativeMethodInfoPtr_GetOfferCount_Public_UInt32_GetOfferCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670942);
    EcomInterface.NativeMethodInfoPtr_GetOfferImageInfoCount_Public_UInt32_GetOfferImageInfoCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670943);
    EcomInterface.NativeMethodInfoPtr_GetOfferItemCount_Public_UInt32_GetOfferItemCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670944);
    EcomInterface.NativeMethodInfoPtr_GetTransactionCount_Public_UInt32_GetTransactionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670945);
    EcomInterface.NativeMethodInfoPtr_QueryEntitlements_Public_Void_QueryEntitlementsOptions_Object_OnQueryEntitlementsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670946);
    EcomInterface.NativeMethodInfoPtr_QueryOffers_Public_Void_QueryOffersOptions_Object_OnQueryOffersCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670947);
    EcomInterface.NativeMethodInfoPtr_QueryOwnership_Public_Void_QueryOwnershipOptions_Object_OnQueryOwnershipCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670948);
    EcomInterface.NativeMethodInfoPtr_QueryOwnershipToken_Public_Void_QueryOwnershipTokenOptions_Object_OnQueryOwnershipTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670949);
    EcomInterface.NativeMethodInfoPtr_RedeemEntitlements_Public_Void_RedeemEntitlementsOptions_Object_OnRedeemEntitlementsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670950);
    EcomInterface.NativeMethodInfoPtr_OnCheckoutCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670951);
    EcomInterface.NativeMethodInfoPtr_OnQueryEntitlementsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670952);
    EcomInterface.NativeMethodInfoPtr_OnQueryOffersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670953);
    EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670954);
    EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670955);
    EcomInterface.NativeMethodInfoPtr_OnRedeemEntitlementsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100670956);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EcomInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394632, XrefRangeEnd = 394651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Checkout(
    CheckoutOptions options,
    Il2CppSystem.Object clientData,
    OnCheckoutCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_Checkout_Public_Void_CheckoutOptions_Object_OnCheckoutCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394651, XrefRangeEnd = 394663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyEntitlementById(
    CopyEntitlementByIdOptions options,
    out Entitlement outEntitlement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyEntitlementById_Public_Result_CopyEntitlementByIdOptions_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Entitlement local = ref outEntitlement;
    System.IntPtr pointer = zero;
    Entitlement entitlement = pointer == System.IntPtr.Zero ? (Entitlement) null : new Entitlement(pointer);
    local = entitlement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394663, XrefRangeEnd = 394675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyEntitlementByIndex(
    CopyEntitlementByIndexOptions options,
    out Entitlement outEntitlement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_CopyEntitlementByIndexOptions_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Entitlement local = ref outEntitlement;
    System.IntPtr pointer = zero;
    Entitlement entitlement = pointer == System.IntPtr.Zero ? (Entitlement) null : new Entitlement(pointer);
    local = entitlement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394675, XrefRangeEnd = 394687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyEntitlementByNameAndIndex(
    CopyEntitlementByNameAndIndexOptions options,
    out Entitlement outEntitlement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyEntitlementByNameAndIndex_Public_Result_CopyEntitlementByNameAndIndexOptions_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Entitlement local = ref outEntitlement;
    System.IntPtr pointer = zero;
    Entitlement entitlement = pointer == System.IntPtr.Zero ? (Entitlement) null : new Entitlement(pointer);
    local = entitlement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394687, XrefRangeEnd = 394699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyItemById(CopyItemByIdOptions options, out CatalogItem outItem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyItemById_Public_Result_CopyItemByIdOptions_byref_CatalogItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CatalogItem local = ref outItem;
    System.IntPtr pointer = zero;
    CatalogItem catalogItem = pointer == System.IntPtr.Zero ? (CatalogItem) null : new CatalogItem(pointer);
    local = catalogItem;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394699, XrefRangeEnd = 394711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyItemImageInfoByIndex(
    CopyItemImageInfoByIndexOptions options,
    out KeyImageInfo outImageInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyItemImageInfoByIndex_Public_Result_CopyItemImageInfoByIndexOptions_byref_KeyImageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref KeyImageInfo local = ref outImageInfo;
    System.IntPtr pointer = zero;
    KeyImageInfo keyImageInfo = pointer == System.IntPtr.Zero ? (KeyImageInfo) null : new KeyImageInfo(pointer);
    local = keyImageInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394711, XrefRangeEnd = 394723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyItemReleaseByIndex(
    CopyItemReleaseByIndexOptions options,
    out CatalogRelease outRelease)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyItemReleaseByIndex_Public_Result_CopyItemReleaseByIndexOptions_byref_CatalogRelease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CatalogRelease local = ref outRelease;
    System.IntPtr pointer = zero;
    CatalogRelease catalogRelease = pointer == System.IntPtr.Zero ? (CatalogRelease) null : new CatalogRelease(pointer);
    local = catalogRelease;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394723, XrefRangeEnd = 394735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyOfferById(CopyOfferByIdOptions options, out CatalogOffer outOffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferById_Public_Result_CopyOfferByIdOptions_byref_CatalogOffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CatalogOffer local = ref outOffer;
    System.IntPtr pointer = zero;
    CatalogOffer catalogOffer = pointer == System.IntPtr.Zero ? (CatalogOffer) null : new CatalogOffer(pointer);
    local = catalogOffer;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394735, XrefRangeEnd = 394747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyOfferByIndex(CopyOfferByIndexOptions options, out CatalogOffer outOffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferByIndex_Public_Result_CopyOfferByIndexOptions_byref_CatalogOffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CatalogOffer local = ref outOffer;
    System.IntPtr pointer = zero;
    CatalogOffer catalogOffer = pointer == System.IntPtr.Zero ? (CatalogOffer) null : new CatalogOffer(pointer);
    local = catalogOffer;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394747, XrefRangeEnd = 394759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyOfferImageInfoByIndex(
    CopyOfferImageInfoByIndexOptions options,
    out KeyImageInfo outImageInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferImageInfoByIndex_Public_Result_CopyOfferImageInfoByIndexOptions_byref_KeyImageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref KeyImageInfo local = ref outImageInfo;
    System.IntPtr pointer = zero;
    KeyImageInfo keyImageInfo = pointer == System.IntPtr.Zero ? (KeyImageInfo) null : new KeyImageInfo(pointer);
    local = keyImageInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394759, XrefRangeEnd = 394771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyOfferItemByIndex(
    CopyOfferItemByIndexOptions options,
    out CatalogItem outItem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferItemByIndex_Public_Result_CopyOfferItemByIndexOptions_byref_CatalogItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref CatalogItem local = ref outItem;
    System.IntPtr pointer = zero;
    CatalogItem catalogItem = pointer == System.IntPtr.Zero ? (CatalogItem) null : new CatalogItem(pointer);
    local = catalogItem;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394771, XrefRangeEnd = 394782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyTransactionById(
    CopyTransactionByIdOptions options,
    out Transaction outTransaction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyTransactionById_Public_Result_CopyTransactionByIdOptions_byref_Transaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Transaction local = ref outTransaction;
    System.IntPtr pointer = zero;
    Transaction transaction = pointer == System.IntPtr.Zero ? (Transaction) null : new Transaction(pointer);
    local = transaction;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394782, XrefRangeEnd = 394793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyTransactionByIndex(
    CopyTransactionByIndexOptions options,
    out Transaction outTransaction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyTransactionByIndex_Public_Result_CopyTransactionByIndexOptions_byref_Transaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Transaction local = ref outTransaction;
    System.IntPtr pointer = zero;
    Transaction transaction = pointer == System.IntPtr.Zero ? (Transaction) null : new Transaction(pointer);
    local = transaction;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394793, XrefRangeEnd = 394801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetEntitlementsByNameCount(GetEntitlementsByNameCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetEntitlementsByNameCount_Public_UInt32_GetEntitlementsByNameCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394801, XrefRangeEnd = 394809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetEntitlementsCount(GetEntitlementsCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_GetEntitlementsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394809, XrefRangeEnd = 394817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetItemImageInfoCount(GetItemImageInfoCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetItemImageInfoCount_Public_UInt32_GetItemImageInfoCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394817, XrefRangeEnd = 394825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetItemReleaseCount(GetItemReleaseCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetItemReleaseCount_Public_UInt32_GetItemReleaseCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394825, XrefRangeEnd = 394833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetOfferCount(GetOfferCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetOfferCount_Public_UInt32_GetOfferCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394833, XrefRangeEnd = 394841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetOfferImageInfoCount(GetOfferImageInfoCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetOfferImageInfoCount_Public_UInt32_GetOfferImageInfoCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394841, XrefRangeEnd = 394849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetOfferItemCount(GetOfferItemCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetOfferItemCount_Public_UInt32_GetOfferItemCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394849, XrefRangeEnd = 394857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetTransactionCount(GetTransactionCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetTransactionCount_Public_UInt32_GetTransactionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394857, XrefRangeEnd = 394876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryEntitlements(
    QueryEntitlementsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryEntitlementsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryEntitlements_Public_Void_QueryEntitlementsOptions_Object_OnQueryEntitlementsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394876, XrefRangeEnd = 394895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryOffers(
    QueryOffersOptions options,
    Il2CppSystem.Object clientData,
    OnQueryOffersCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryOffers_Public_Void_QueryOffersOptions_Object_OnQueryOffersCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394895, XrefRangeEnd = 394914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryOwnership(
    QueryOwnershipOptions options,
    Il2CppSystem.Object clientData,
    OnQueryOwnershipCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryOwnership_Public_Void_QueryOwnershipOptions_Object_OnQueryOwnershipCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394914, XrefRangeEnd = 394933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryOwnershipToken(
    QueryOwnershipTokenOptions options,
    Il2CppSystem.Object clientData,
    OnQueryOwnershipTokenCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryOwnershipToken_Public_Void_QueryOwnershipTokenOptions_Object_OnQueryOwnershipTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394933, XrefRangeEnd = 394952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedeemEntitlements(
    RedeemEntitlementsOptions options,
    Il2CppSystem.Object clientData,
    OnRedeemEntitlementsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_RedeemEntitlements_Public_Void_RedeemEntitlementsOptions_Object_OnRedeemEntitlementsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394952, XrefRangeEnd = 394958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCheckoutCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnCheckoutCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394958, XrefRangeEnd = 394964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryEntitlementsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryEntitlementsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394964, XrefRangeEnd = 394970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryOffersCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryOffersCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394970, XrefRangeEnd = 394976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryOwnershipCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394976, XrefRangeEnd = 394982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryOwnershipTokenCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipTokenCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394982, XrefRangeEnd = 394988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnRedeemEntitlementsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnRedeemEntitlementsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CatalogitemApiLatest
  {
    get
    {
      int catalogitemApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogitemApiLatest, (void*) &catalogitemApiLatest);
      return catalogitemApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogitemApiLatest, (void*) &value);
    }
  }

  public static unsafe int CatalogitemEntitlementendtimestampUndefined
  {
    get
    {
      int entitlementendtimestampUndefined;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined, (void*) &entitlementendtimestampUndefined);
      return entitlementendtimestampUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined, (void*) &value);
    }
  }

  public static unsafe int CatalogofferApiLatest
  {
    get
    {
      int catalogofferApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogofferApiLatest, (void*) &catalogofferApiLatest);
      return catalogofferApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogofferApiLatest, (void*) &value);
    }
  }

  public static unsafe int CatalogofferExpirationtimestampUndefined
  {
    get
    {
      int expirationtimestampUndefined;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined, (void*) &expirationtimestampUndefined);
      return expirationtimestampUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined, (void*) &value);
    }
  }

  public static unsafe int CatalogreleaseApiLatest
  {
    get
    {
      int catalogreleaseApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogreleaseApiLatest, (void*) &catalogreleaseApiLatest);
      return catalogreleaseApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogreleaseApiLatest, (void*) &value);
    }
  }

  public static unsafe int CheckoutApiLatest
  {
    get
    {
      int checkoutApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CheckoutApiLatest, (void*) &checkoutApiLatest);
      return checkoutApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CheckoutApiLatest, (void*) &value);
    }
  }

  public static unsafe int CheckoutMaxEntries
  {
    get
    {
      int checkoutMaxEntries;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CheckoutMaxEntries, (void*) &checkoutMaxEntries);
      return checkoutMaxEntries;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CheckoutMaxEntries, (void*) &value);
    }
  }

  public static unsafe int CheckoutentryApiLatest
  {
    get
    {
      int checkoutentryApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CheckoutentryApiLatest, (void*) &checkoutentryApiLatest);
      return checkoutentryApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CheckoutentryApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyentitlementbyidApiLatest
  {
    get
    {
      int copyentitlementbyidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyidApiLatest, (void*) &copyentitlementbyidApiLatest);
      return copyentitlementbyidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyentitlementbyindexApiLatest
  {
    get
    {
      int copyentitlementbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyindexApiLatest, (void*) &copyentitlementbyindexApiLatest);
      return copyentitlementbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyentitlementbynameandindexApiLatest
  {
    get
    {
      int copyentitlementbynameandindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest, (void*) &copyentitlementbynameandindexApiLatest);
      return copyentitlementbynameandindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyitembyidApiLatest
  {
    get
    {
      int copyitembyidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyitembyidApiLatest, (void*) &copyitembyidApiLatest);
      return copyitembyidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyitembyidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyitemimageinfobyindexApiLatest
  {
    get
    {
      int copyitemimageinfobyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest, (void*) &copyitemimageinfobyindexApiLatest);
      return copyitemimageinfobyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyitemreleasebyindexApiLatest
  {
    get
    {
      int copyitemreleasebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest, (void*) &copyitemreleasebyindexApiLatest);
      return copyitemreleasebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyofferbyidApiLatest
  {
    get
    {
      int copyofferbyidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyidApiLatest, (void*) &copyofferbyidApiLatest);
      return copyofferbyidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyofferbyindexApiLatest
  {
    get
    {
      int copyofferbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyindexApiLatest, (void*) &copyofferbyindexApiLatest);
      return copyofferbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyofferimageinfobyindexApiLatest
  {
    get
    {
      int copyofferimageinfobyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest, (void*) &copyofferimageinfobyindexApiLatest);
      return copyofferimageinfobyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopyofferitembyindexApiLatest
  {
    get
    {
      int copyofferitembyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferitembyindexApiLatest, (void*) &copyofferitembyindexApiLatest);
      return copyofferitembyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferitembyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopytransactionbyidApiLatest
  {
    get
    {
      int copytransactionbyidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyidApiLatest, (void*) &copytransactionbyidApiLatest);
      return copytransactionbyidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyidApiLatest, (void*) &value);
    }
  }

  public static unsafe int CopytransactionbyindexApiLatest
  {
    get
    {
      int copytransactionbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyindexApiLatest, (void*) &copytransactionbyindexApiLatest);
      return copytransactionbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int EntitlementApiLatest
  {
    get
    {
      int entitlementApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_EntitlementApiLatest, (void*) &entitlementApiLatest);
      return entitlementApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_EntitlementApiLatest, (void*) &value);
    }
  }

  public static unsafe int EntitlementEndtimestampUndefined
  {
    get
    {
      int endtimestampUndefined;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_EntitlementEndtimestampUndefined, (void*) &endtimestampUndefined);
      return endtimestampUndefined;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_EntitlementEndtimestampUndefined, (void*) &value);
    }
  }

  public static unsafe int GetentitlementsbynamecountApiLatest
  {
    get
    {
      int getentitlementsbynamecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest, (void*) &getentitlementsbynamecountApiLatest);
      return getentitlementsbynamecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetentitlementscountApiLatest
  {
    get
    {
      int getentitlementscountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetentitlementscountApiLatest, (void*) &getentitlementscountApiLatest);
      return getentitlementscountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetentitlementscountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetitemimageinfocountApiLatest
  {
    get
    {
      int getitemimageinfocountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetitemimageinfocountApiLatest, (void*) &getitemimageinfocountApiLatest);
      return getitemimageinfocountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetitemimageinfocountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetitemreleasecountApiLatest
  {
    get
    {
      int getitemreleasecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetitemreleasecountApiLatest, (void*) &getitemreleasecountApiLatest);
      return getitemreleasecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetitemreleasecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetoffercountApiLatest
  {
    get
    {
      int getoffercountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetoffercountApiLatest, (void*) &getoffercountApiLatest);
      return getoffercountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetoffercountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetofferimageinfocountApiLatest
  {
    get
    {
      int getofferimageinfocountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetofferimageinfocountApiLatest, (void*) &getofferimageinfocountApiLatest);
      return getofferimageinfocountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetofferimageinfocountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetofferitemcountApiLatest
  {
    get
    {
      int getofferitemcountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetofferitemcountApiLatest, (void*) &getofferitemcountApiLatest);
      return getofferitemcountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetofferitemcountApiLatest, (void*) &value);
    }
  }

  public static unsafe int GettransactioncountApiLatest
  {
    get
    {
      int gettransactioncountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GettransactioncountApiLatest, (void*) &gettransactioncountApiLatest);
      return gettransactioncountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GettransactioncountApiLatest, (void*) &value);
    }
  }

  public static unsafe int ItemownershipApiLatest
  {
    get
    {
      int itemownershipApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_ItemownershipApiLatest, (void*) &itemownershipApiLatest);
      return itemownershipApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_ItemownershipApiLatest, (void*) &value);
    }
  }

  public static unsafe int KeyimageinfoApiLatest
  {
    get
    {
      int keyimageinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_KeyimageinfoApiLatest, (void*) &keyimageinfoApiLatest);
      return keyimageinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_KeyimageinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryentitlementsApiLatest
  {
    get
    {
      int queryentitlementsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsApiLatest, (void*) &queryentitlementsApiLatest);
      return queryentitlementsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryentitlementsMaxEntitlementIds
  {
    get
    {
      int maxEntitlementIds;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds, (void*) &maxEntitlementIds);
      return maxEntitlementIds;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds, (void*) &value);
    }
  }

  public static unsafe int QueryoffersApiLatest
  {
    get
    {
      int queryoffersApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryoffersApiLatest, (void*) &queryoffersApiLatest);
      return queryoffersApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryoffersApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryownershipApiLatest
  {
    get
    {
      int queryownershipApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershipApiLatest, (void*) &queryownershipApiLatest);
      return queryownershipApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershipApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryownershipMaxCatalogIds
  {
    get
    {
      int queryownershipMaxCatalogIds;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershipMaxCatalogIds, (void*) &queryownershipMaxCatalogIds);
      return queryownershipMaxCatalogIds;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershipMaxCatalogIds, (void*) &value);
    }
  }

  public static unsafe int QueryownershiptokenApiLatest
  {
    get
    {
      int queryownershiptokenApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenApiLatest, (void*) &queryownershiptokenApiLatest);
      return queryownershiptokenApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryownershiptokenMaxCatalogitemIds
  {
    get
    {
      int maxCatalogitemIds;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds, (void*) &maxCatalogitemIds);
      return maxCatalogitemIds;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds, (void*) &value);
    }
  }

  public static unsafe int RedeementitlementsApiLatest
  {
    get
    {
      int redeementitlementsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsApiLatest, (void*) &redeementitlementsApiLatest);
      return redeementitlementsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsApiLatest, (void*) &value);
    }
  }

  public static unsafe int RedeementitlementsMaxIds
  {
    get
    {
      int redeementitlementsMaxIds;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsMaxIds, (void*) &redeementitlementsMaxIds);
      return redeementitlementsMaxIds;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsMaxIds, (void*) &value);
    }
  }

  public static unsafe int TransactionidMaximumLength
  {
    get
    {
      int transactionidMaximumLength;
      IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_TransactionidMaximumLength, (void*) &transactionidMaximumLength);
      return transactionidMaximumLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_TransactionidMaximumLength, (void*) &value);
    }
  }
}
