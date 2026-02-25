// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Reports.SendPlayerBehaviorReportOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Reports;

[StructLayout(LayoutKind.Explicit)]
public struct SendPlayerBehaviorReportOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReporterUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReportedUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Category;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Message;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Context;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SendPlayerBehaviorReportOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ReporterUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ReportedUserId;
  [FieldOffset(24)]
  public PlayerReportsCategory m_Category;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_Message;
  [FieldOffset(40)]
  public System.IntPtr m_Context;

  static SendPlayerBehaviorReportOptionsInternal()
  {
    Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Reports", nameof (SendPlayerBehaviorReportOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr);
    SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_ReporterUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_ReporterUserId));
    SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_ReportedUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_ReportedUserId));
    SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_Category));
    SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_Message));
    SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_Context));
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667131);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667132);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667133);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667134);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Context_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667135);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendPlayerBehaviorReportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667136 /*0x06000F00*/);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667137 /*0x06000F01*/);
    SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100667138 /*0x06000F02*/);
  }

  public unsafe ProductUserId ReporterUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382771, XrefRangeEnd = 382775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId ReportedUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382775, XrefRangeEnd = 382779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PlayerReportsCategory Category
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Message
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382779, XrefRangeEnd = 382783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Context
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382783, XrefRangeEnd = 382787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Context_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 382803, RefRangeEnd = 382804, XrefRangeStart = 382787, XrefRangeEnd = 382803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SendPlayerBehaviorReportOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendPlayerBehaviorReportOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382804, XrefRangeEnd = 382807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382807, XrefRangeEnd = 382814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
