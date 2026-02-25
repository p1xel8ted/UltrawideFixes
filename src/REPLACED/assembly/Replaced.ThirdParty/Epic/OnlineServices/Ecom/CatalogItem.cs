// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogItem
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

public class CatalogItem(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__CatalogNamespace_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Id_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EntitlementName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TitleText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DescriptionText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LongDescriptionText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TechnicalDetailsText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DeveloperText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ItemType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EntitlementEndTimestamp_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TitleText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeveloperText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CatalogItemInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CatalogItem()
  {
    Il2CppClassPointerStore<CatalogItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (CatalogItem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr);
    CatalogItem.NativeFieldInfoPtr__CatalogNamespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<CatalogNamespace>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<Id>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__EntitlementName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<EntitlementName>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__TitleText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<TitleText>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__DescriptionText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<DescriptionText>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__LongDescriptionText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<LongDescriptionText>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__TechnicalDetailsText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<TechnicalDetailsText>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__DeveloperText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<DeveloperText>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__ItemType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<ItemType>k__BackingField");
    CatalogItem.NativeFieldInfoPtr__EntitlementEndTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, "<EntitlementEndTimestamp>k__BackingField");
    CatalogItem.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670602);
    CatalogItem.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670603);
    CatalogItem.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670604);
    CatalogItem.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670605);
    CatalogItem.NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670606);
    CatalogItem.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670607);
    CatalogItem.NativeMethodInfoPtr_get_TitleText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670608);
    CatalogItem.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670609);
    CatalogItem.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670610);
    CatalogItem.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670611);
    CatalogItem.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670612);
    CatalogItem.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670613);
    CatalogItem.NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670614);
    CatalogItem.NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670615);
    CatalogItem.NativeMethodInfoPtr_get_DeveloperText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670616);
    CatalogItem.NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670617);
    CatalogItem.NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670618);
    CatalogItem.NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670619);
    CatalogItem.NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670620);
    CatalogItem.NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670621);
    CatalogItem.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CatalogItemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670622);
    CatalogItem.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670623);
    CatalogItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr, 100670624);
  }

  public unsafe string CatalogNamespace
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Id
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EntitlementName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_TitleText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TechnicalDetailsText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeveloperText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_DeveloperText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EcomItemType ItemType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EcomItemType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long EntitlementEndTimestamp
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 393791, RefRangeEnd = 393792, XrefRangeStart = 393737, XrefRangeEnd = 393791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<CatalogItemInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CatalogItemInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393792, XrefRangeEnd = 393797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CatalogItem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CatalogItem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _CatalogNamespace_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__CatalogNamespace_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__CatalogNamespace_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _Id_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__Id_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _EntitlementName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__EntitlementName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__EntitlementName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _TitleText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__TitleText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__TitleText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _DescriptionText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__DescriptionText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__DescriptionText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _LongDescriptionText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__LongDescriptionText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__LongDescriptionText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _TechnicalDetailsText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__TechnicalDetailsText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__TechnicalDetailsText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _DeveloperText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__DeveloperText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__DeveloperText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe EcomItemType _ItemType_k__BackingField
  {
    get
    {
      return *(EcomItemType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__ItemType_k__BackingField));
    }
    [param: In] set
    {
      *(EcomItemType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__ItemType_k__BackingField)) = value;
    }
  }

  public unsafe long _EntitlementEndTimestamp_k__BackingField
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__EntitlementEndTimestamp_k__BackingField));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogItem.NativeFieldInfoPtr__EntitlementEndTimestamp_k__BackingField)) = value;
    }
  }
}
