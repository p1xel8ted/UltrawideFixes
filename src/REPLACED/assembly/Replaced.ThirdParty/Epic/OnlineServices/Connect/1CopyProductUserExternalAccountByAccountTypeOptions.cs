// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.CopyProductUserExternalAccountByAccountTypeOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct CopyProductUserExternalAccountByAccountTypeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyProductUserExternalAccountByAccountTypeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(16 /*0x10*/)]
  public ExternalAccountType m_AccountIdType;

  static CopyProductUserExternalAccountByAccountTypeOptionsInternal()
  {
    Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (CopyProductUserExternalAccountByAccountTypeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr);
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, nameof (m_AccountIdType));
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, 100671511);
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, 100671512);
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyProductUserExternalAccountByAccountTypeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, 100671513);
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, 100671514);
    CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, 100671515);
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396796, XrefRangeEnd = 396800 /*0x060E00*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType AccountIdType
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396800 /*0x060E00*/, XrefRangeEnd = 396804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    CopyProductUserExternalAccountByAccountTypeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyProductUserExternalAccountByAccountTypeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396804, XrefRangeEnd = 396810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396810, XrefRangeEnd = 396814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByAccountTypeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyProductUserExternalAccountByAccountTypeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
