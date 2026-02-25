// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Reports.SendPlayerBehaviorReportOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Reports;

public class SendPlayerBehaviorReportOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ReporterUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReportedUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Category_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Message_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Context_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReporterUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReportedUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_get_PlayerReportsCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Context_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SendPlayerBehaviorReportOptions()
  {
    Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Reports", nameof (SendPlayerBehaviorReportOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr);
    SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReporterUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<ReporterUserId>k__BackingField");
    SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReportedUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<ReportedUserId>k__BackingField");
    SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<Category>k__BackingField");
    SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<Message>k__BackingField");
    SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<Context>k__BackingField");
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReporterUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667120 /*0x06000EF0*/);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667121);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReportedUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667122);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667123);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Category_Public_get_PlayerReportsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667124);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667125);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667126);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667127);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Context_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667128);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Context_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667129);
    SendPlayerBehaviorReportOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100667130);
  }

  public unsafe ProductUserId ReporterUserId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReporterUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId ReportedUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReportedUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PlayerReportsCategory Category
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Category_Public_get_PlayerReportsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayerReportsCategory*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Message
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Context
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Context_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Context_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SendPlayerBehaviorReportOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ProductUserId _ReporterUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReporterUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReporterUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _ReportedUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReportedUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReportedUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerReportsCategory _Category_k__BackingField
  {
    get
    {
      return *(PlayerReportsCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Category_k__BackingField));
    }
    [param: In] set
    {
      *(PlayerReportsCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Category_k__BackingField)) = value;
    }
  }

  public unsafe string _Message_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Message_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _Context_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Context_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Context_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
