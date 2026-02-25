// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogItemInternal
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
public struct CatalogItemInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TitleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LongDescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TechnicalDetailsText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeveloperText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ItemType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementEndTimestamp;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CatalogItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_CatalogNamespace;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Id;
  [FieldOffset(24)]
  public System.IntPtr m_EntitlementName;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_TitleText;
  [FieldOffset(40)]
  public System.IntPtr m_DescriptionText;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_LongDescriptionText;
  [FieldOffset(56)]
  public System.IntPtr m_TechnicalDetailsText;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_DeveloperText;
  [FieldOffset(72)]
  public EcomItemType m_ItemType;
  [FieldOffset(80 /*0x50*/)]
  public long m_EntitlementEndTimestamp;

  static CatalogItemInternal()
  {
    Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (CatalogItemInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr);
    CatalogItemInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CatalogItemInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
    CatalogItemInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_Id));
    CatalogItemInternal.NativeFieldInfoPtr_m_EntitlementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_EntitlementName));
    CatalogItemInternal.NativeFieldInfoPtr_m_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_TitleText));
    CatalogItemInternal.NativeFieldInfoPtr_m_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_DescriptionText));
    CatalogItemInternal.NativeFieldInfoPtr_m_LongDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_LongDescriptionText));
    CatalogItemInternal.NativeFieldInfoPtr_m_TechnicalDetailsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_TechnicalDetailsText));
    CatalogItemInternal.NativeFieldInfoPtr_m_DeveloperText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_DeveloperText));
    CatalogItemInternal.NativeFieldInfoPtr_m_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_ItemType));
    CatalogItemInternal.NativeFieldInfoPtr_m_EntitlementEndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_EntitlementEndTimestamp));
    CatalogItemInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670625);
    CatalogItemInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670626);
    CatalogItemInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670627);
    CatalogItemInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670628);
    CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670629);
    CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670630);
    CatalogItemInternal.NativeMethodInfoPtr_get_TitleText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670631);
    CatalogItemInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670632);
    CatalogItemInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670633);
    CatalogItemInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670634);
    CatalogItemInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670635);
    CatalogItemInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670636);
    CatalogItemInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670637);
    CatalogItemInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670638);
    CatalogItemInternal.NativeMethodInfoPtr_get_DeveloperText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670639);
    CatalogItemInternal.NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670640);
    CatalogItemInternal.NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670641);
    CatalogItemInternal.NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670642);
    CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670643);
    CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670644);
    CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Void_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670645);
    CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670646);
    CatalogItemInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100670647);
  }

  public unsafe string CatalogNamespace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393797, XrefRangeEnd = 393801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393801, XrefRangeEnd = 393805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Id
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393805, XrefRangeEnd = 393809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393809, XrefRangeEnd = 393813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EntitlementName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393813, XrefRangeEnd = 393817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393817, XrefRangeEnd = 393821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TitleText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393821, XrefRangeEnd = 393825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_TitleText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393825, XrefRangeEnd = 393829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DescriptionText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393829, XrefRangeEnd = 393833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393833, XrefRangeEnd = 393837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LongDescriptionText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393837, XrefRangeEnd = 393841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393841, XrefRangeEnd = 393845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TechnicalDetailsText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393845, XrefRangeEnd = 393849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393849, XrefRangeEnd = 393853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeveloperText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393853, XrefRangeEnd = 393857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_DeveloperText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393857, XrefRangeEnd = 393861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EcomItemType ItemType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EcomItemType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 138917, RefRangeEnd = 138918, XrefRangeStart = 138917, XrefRangeEnd = 138918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long EntitlementEndTimestamp
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 393893, RefRangeEnd = 393894, XrefRangeStart = 393861, XrefRangeEnd = 393893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CatalogItem other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Void_CatalogItem_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393894, XrefRangeEnd = 393897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393897, XrefRangeEnd = 393908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
