// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogOffer
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

public class CatalogOffer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ServerIndex_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CatalogNamespace_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Id_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TitleText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DescriptionText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LongDescriptionText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrencyCode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PriceResult_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DiscountPercentage_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PurchasedCount_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PurchaseLimit_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AvailableForPurchase_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OriginalPrice64_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPrice64_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DecimalPoint_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TitleText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrencyCode_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PurchasedCount_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PurchasedCount_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CatalogOfferInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CatalogOffer()
  {
    Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (CatalogOffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr);
    CatalogOffer.NativeFieldInfoPtr__ServerIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<ServerIndex>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__CatalogNamespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CatalogNamespace>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<Id>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__TitleText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<TitleText>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__DescriptionText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<DescriptionText>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__LongDescriptionText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<LongDescriptionText>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<TechnicalDetailsText_DEPRECATED>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__CurrencyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CurrencyCode>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__PriceResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<PriceResult>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<OriginalPrice_DEPRECATED>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CurrentPrice_DEPRECATED>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__DiscountPercentage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<DiscountPercentage>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<ExpirationTimestamp>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__PurchasedCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<PurchasedCount>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__PurchaseLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<PurchaseLimit>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__AvailableForPurchase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<AvailableForPurchase>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__OriginalPrice64_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<OriginalPrice64>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__CurrentPrice64_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CurrentPrice64>k__BackingField");
    CatalogOffer.NativeFieldInfoPtr__DecimalPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<DecimalPoint>k__BackingField");
    CatalogOffer.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670648);
    CatalogOffer.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670649);
    CatalogOffer.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670650);
    CatalogOffer.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670651);
    CatalogOffer.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670652);
    CatalogOffer.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670653);
    CatalogOffer.NativeMethodInfoPtr_get_TitleText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670654);
    CatalogOffer.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670655);
    CatalogOffer.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670656);
    CatalogOffer.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670657);
    CatalogOffer.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670658);
    CatalogOffer.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670659);
    CatalogOffer.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670660);
    CatalogOffer.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670661);
    CatalogOffer.NativeMethodInfoPtr_get_CurrencyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670662);
    CatalogOffer.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670663);
    CatalogOffer.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670664);
    CatalogOffer.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670665);
    CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670666);
    CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670667);
    CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670668);
    CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670669);
    CatalogOffer.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670670);
    CatalogOffer.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670671);
    CatalogOffer.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670672);
    CatalogOffer.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670673);
    CatalogOffer.NativeMethodInfoPtr_get_PurchasedCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670674);
    CatalogOffer.NativeMethodInfoPtr_set_PurchasedCount_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670675);
    CatalogOffer.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670676);
    CatalogOffer.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670677);
    CatalogOffer.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670678);
    CatalogOffer.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670679);
    CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670680);
    CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670681);
    CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670682);
    CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670683);
    CatalogOffer.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670684);
    CatalogOffer.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670685);
    CatalogOffer.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CatalogOfferInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670686);
    CatalogOffer.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670687);
    CatalogOffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100670688);
  }

  public unsafe int ServerIndex
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CatalogNamespace
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Id
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TitleText
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_TitleText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DescriptionText
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LongDescriptionText
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TechnicalDetailsText_DEPRECATED
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CurrencyCode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CurrencyCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Result PriceResult
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OriginalPrice_DEPRECATED
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint CurrentPrice_DEPRECATED
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe byte DiscountPercentage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long ExpirationTimestamp
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint PurchasedCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_PurchasedCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 298986, RefRangeEnd = 298987, XrefRangeStart = 298986, XrefRangeEnd = 298987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_PurchasedCount_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int PurchaseLimit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AvailableForPurchase
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OriginalPrice64
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong CurrentPrice64
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint DecimalPoint
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 393980, RefRangeEnd = 393981, XrefRangeStart = 393908, XrefRangeEnd = 393980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<CatalogOfferInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CatalogOfferInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393981, XrefRangeEnd = 393986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CatalogOffer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _ServerIndex_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ServerIndex_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ServerIndex_k__BackingField)) = value;
    }
  }

  public unsafe string _CatalogNamespace_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CatalogNamespace_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CatalogNamespace_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _Id_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__Id_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _TitleText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TitleText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TitleText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _DescriptionText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DescriptionText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DescriptionText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _LongDescriptionText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__LongDescriptionText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__LongDescriptionText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _TechnicalDetailsText_DEPRECATED_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _CurrencyCode_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrencyCode_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrencyCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Result _PriceResult_k__BackingField
  {
    get
    {
      return *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PriceResult_k__BackingField));
    }
    [param: In] set
    {
      *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PriceResult_k__BackingField)) = value;
    }
  }

  public unsafe uint _OriginalPrice_DEPRECATED_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField)) = value;
    }
  }

  public unsafe uint _CurrentPrice_DEPRECATED_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField)) = value;
    }
  }

  public unsafe byte _DiscountPercentage_k__BackingField
  {
    get
    {
      return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DiscountPercentage_k__BackingField));
    }
    [param: In] set
    {
      *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DiscountPercentage_k__BackingField)) = value;
    }
  }

  public unsafe long _ExpirationTimestamp_k__BackingField
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField)) = value;
    }
  }

  public unsafe uint _PurchasedCount_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchasedCount_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchasedCount_k__BackingField)) = value;
    }
  }

  public unsafe int _PurchaseLimit_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchaseLimit_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchaseLimit_k__BackingField)) = value;
    }
  }

  public unsafe bool _AvailableForPurchase_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__AvailableForPurchase_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__AvailableForPurchase_k__BackingField)) = value;
    }
  }

  public unsafe ulong _OriginalPrice64_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice64_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice64_k__BackingField)) = value;
    }
  }

  public unsafe ulong _CurrentPrice64_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice64_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice64_k__BackingField)) = value;
    }
  }

  public unsafe uint _DecimalPoint_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DecimalPoint_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DecimalPoint_k__BackingField)) = value;
    }
  }
}
