// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogOfferInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

[StructLayout(LayoutKind.Explicit)]
public struct CatalogOfferInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TitleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LongDescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TechnicalDetailsText_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrencyCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PriceResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPrice_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentPrice_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DiscountPercentage;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpirationTimestamp;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PurchasedCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PurchaseLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableForPurchase;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPrice64;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentPrice64;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DecimalPoint;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CatalogOffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public int m_ServerIndex;
  [FieldOffset(8)]
  public System.IntPtr m_CatalogNamespace;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Id;
  [FieldOffset(24)]
  public System.IntPtr m_TitleText;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_DescriptionText;
  [FieldOffset(40)]
  public System.IntPtr m_LongDescriptionText;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_TechnicalDetailsText_DEPRECATED;
  [FieldOffset(56)]
  public System.IntPtr m_CurrencyCode;
  [FieldOffset(64 /*0x40*/)]
  public Result m_PriceResult;
  [FieldOffset(68)]
  public uint m_OriginalPrice_DEPRECATED;
  [FieldOffset(72)]
  public uint m_CurrentPrice_DEPRECATED;
  [FieldOffset(76)]
  public byte m_DiscountPercentage;
  [FieldOffset(80 /*0x50*/)]
  public long m_ExpirationTimestamp;
  [FieldOffset(88)]
  public uint m_PurchasedCount;
  [FieldOffset(92)]
  public int m_PurchaseLimit;
  [FieldOffset(96 /*0x60*/)]
  public int m_AvailableForPurchase;
  [FieldOffset(104)]
  public ulong m_OriginalPrice64;
  [FieldOffset(112 /*0x70*/)]
  public ulong m_CurrentPrice64;
  [FieldOffset(120)]
  public uint m_DecimalPoint;

  static CatalogOfferInternal()
  {
    Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (CatalogOfferInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr);
    CatalogOfferInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CatalogOfferInternal.NativeFieldInfoPtr_m_ServerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ServerIndex));
    CatalogOfferInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
    CatalogOfferInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_Id));
    CatalogOfferInternal.NativeFieldInfoPtr_m_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_TitleText));
    CatalogOfferInternal.NativeFieldInfoPtr_m_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_DescriptionText));
    CatalogOfferInternal.NativeFieldInfoPtr_m_LongDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_LongDescriptionText));
    CatalogOfferInternal.NativeFieldInfoPtr_m_TechnicalDetailsText_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_TechnicalDetailsText_DEPRECATED));
    CatalogOfferInternal.NativeFieldInfoPtr_m_CurrencyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CurrencyCode));
    CatalogOfferInternal.NativeFieldInfoPtr_m_PriceResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_PriceResult));
    CatalogOfferInternal.NativeFieldInfoPtr_m_OriginalPrice_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_OriginalPrice_DEPRECATED));
    CatalogOfferInternal.NativeFieldInfoPtr_m_CurrentPrice_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CurrentPrice_DEPRECATED));
    CatalogOfferInternal.NativeFieldInfoPtr_m_DiscountPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_DiscountPercentage));
    CatalogOfferInternal.NativeFieldInfoPtr_m_ExpirationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ExpirationTimestamp));
    CatalogOfferInternal.NativeFieldInfoPtr_m_PurchasedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_PurchasedCount));
    CatalogOfferInternal.NativeFieldInfoPtr_m_PurchaseLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_PurchaseLimit));
    CatalogOfferInternal.NativeFieldInfoPtr_m_AvailableForPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_AvailableForPurchase));
    CatalogOfferInternal.NativeFieldInfoPtr_m_OriginalPrice64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_OriginalPrice64));
    CatalogOfferInternal.NativeFieldInfoPtr_m_CurrentPrice64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CurrentPrice64));
    CatalogOfferInternal.NativeFieldInfoPtr_m_DecimalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_DecimalPoint));
    CatalogOfferInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670689);
    CatalogOfferInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670690);
    CatalogOfferInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670691);
    CatalogOfferInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670692);
    CatalogOfferInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670693);
    CatalogOfferInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670694);
    CatalogOfferInternal.NativeMethodInfoPtr_get_TitleText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670695);
    CatalogOfferInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670696);
    CatalogOfferInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670697);
    CatalogOfferInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670698);
    CatalogOfferInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670699);
    CatalogOfferInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670700);
    CatalogOfferInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670701);
    CatalogOfferInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670702);
    CatalogOfferInternal.NativeMethodInfoPtr_get_CurrencyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670703);
    CatalogOfferInternal.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670704);
    CatalogOfferInternal.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670705);
    CatalogOfferInternal.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670706);
    CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670707);
    CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670708);
    CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670709);
    CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670710);
    CatalogOfferInternal.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670711);
    CatalogOfferInternal.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670712);
    CatalogOfferInternal.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670713);
    CatalogOfferInternal.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670714);
    CatalogOfferInternal.NativeMethodInfoPtr_get_PurchasedCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670715);
    CatalogOfferInternal.NativeMethodInfoPtr_set_PurchasedCount_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670716);
    CatalogOfferInternal.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670717);
    CatalogOfferInternal.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670718);
    CatalogOfferInternal.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670719);
    CatalogOfferInternal.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670720 /*0x06001D00*/);
    CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670721);
    CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670722);
    CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670723);
    CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670724);
    CatalogOfferInternal.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670725);
    CatalogOfferInternal.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670726);
    CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Void_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670727);
    CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670728);
    CatalogOfferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100670729);
  }

  public unsafe int ServerIndex
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CatalogNamespace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393986, XrefRangeEnd = 393990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393990, XrefRangeEnd = 393994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Id
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393994, XrefRangeEnd = 393998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393998, XrefRangeEnd = 394002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TitleText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394002, XrefRangeEnd = 394006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_TitleText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394006, XrefRangeEnd = 394010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DescriptionText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394010, XrefRangeEnd = 394014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394014, XrefRangeEnd = 394018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LongDescriptionText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394018, XrefRangeEnd = 394022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394022, XrefRangeEnd = 394026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TechnicalDetailsText_DEPRECATED
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394026, XrefRangeEnd = 394030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394030, XrefRangeEnd = 394034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CurrencyCode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394034, XrefRangeEnd = 394038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CurrencyCode_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394038, XrefRangeEnd = 394042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Result PriceResult
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139338, RefRangeEnd = 139339, XrefRangeStart = 139338, XrefRangeEnd = 139339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OriginalPrice_DEPRECATED
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 394042, RefRangeEnd = 394043, XrefRangeStart = 394042, XrefRangeEnd = 394042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint CurrentPrice_DEPRECATED
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 138917, RefRangeEnd = 138918, XrefRangeStart = 138917, XrefRangeEnd = 138918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe byte DiscountPercentage
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long ExpirationTimestamp
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint PurchasedCount
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_PurchasedCount_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_PurchasedCount_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int PurchaseLimit
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AvailableForPurchase
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394043, XrefRangeEnd = 394047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394047, XrefRangeEnd = 394051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OriginalPrice64
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong CurrentPrice64
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint DecimalPoint
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 394083, RefRangeEnd = 394084, XrefRangeStart = 394051, XrefRangeEnd = 394083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CatalogOffer other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Void_CatalogOffer_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394084, XrefRangeEnd = 394087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394087, XrefRangeEnd = 394097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
