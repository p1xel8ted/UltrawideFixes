// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.EntitlementInternal
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
public struct EntitlementInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Redeemed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTimestamp;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CatalogItemId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogItemId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Redeemed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Redeemed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTimestamp_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTimestamp_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Entitlement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_EntitlementName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_EntitlementId;
  [FieldOffset(24)]
  public System.IntPtr m_CatalogItemId;
  [FieldOffset(32 /*0x20*/)]
  public int m_ServerIndex;
  [FieldOffset(36)]
  public int m_Redeemed;
  [FieldOffset(40)]
  public long m_EndTimestamp;

  static EntitlementInternal()
  {
    Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (EntitlementInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr);
    EntitlementInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_ApiVersion));
    EntitlementInternal.NativeFieldInfoPtr_m_EntitlementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_EntitlementName));
    EntitlementInternal.NativeFieldInfoPtr_m_EntitlementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_EntitlementId));
    EntitlementInternal.NativeFieldInfoPtr_m_CatalogItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_CatalogItemId));
    EntitlementInternal.NativeFieldInfoPtr_m_ServerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_ServerIndex));
    EntitlementInternal.NativeFieldInfoPtr_m_Redeemed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_Redeemed));
    EntitlementInternal.NativeFieldInfoPtr_m_EndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_EndTimestamp));
    EntitlementInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670972);
    EntitlementInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670973);
    EntitlementInternal.NativeMethodInfoPtr_get_EntitlementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670974);
    EntitlementInternal.NativeMethodInfoPtr_set_EntitlementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670975);
    EntitlementInternal.NativeMethodInfoPtr_get_CatalogItemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670976 /*0x06001E00*/);
    EntitlementInternal.NativeMethodInfoPtr_set_CatalogItemId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670977);
    EntitlementInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670978);
    EntitlementInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670979);
    EntitlementInternal.NativeMethodInfoPtr_get_Redeemed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670980);
    EntitlementInternal.NativeMethodInfoPtr_set_Redeemed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670981);
    EntitlementInternal.NativeMethodInfoPtr_get_EndTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670982);
    EntitlementInternal.NativeMethodInfoPtr_set_EndTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670983);
    EntitlementInternal.NativeMethodInfoPtr_Set_Public_Void_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670984);
    EntitlementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670985);
    EntitlementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100670986);
  }

  public unsafe string EntitlementName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395052, XrefRangeEnd = 395056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395056, XrefRangeEnd = 395060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EntitlementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395060, XrefRangeEnd = 395064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_EntitlementId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395064, XrefRangeEnd = 395068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_EntitlementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CatalogItemId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395068, XrefRangeEnd = 395072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_CatalogItemId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395072, XrefRangeEnd = 395076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_CatalogItemId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int ServerIndex
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool Redeemed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395076, XrefRangeEnd = 395080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_Redeemed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395080, XrefRangeEnd = 395084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_Redeemed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long EndTimestamp
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_EndTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_EndTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 395100, RefRangeEnd = 395101, XrefRangeStart = 395084, XrefRangeEnd = 395100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Entitlement other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Set_Public_Void_Entitlement_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395101, XrefRangeEnd = 395104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395104, XrefRangeEnd = 395110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
