// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.CopyExternalUserInfoByAccountIdOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UserInfo;

[StructLayout(LayoutKind.Explicit)]
public struct CopyExternalUserInfoByAccountIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyExternalUserInfoByAccountIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(24)]
  public System.IntPtr m_AccountId;

  static CopyExternalUserInfoByAccountIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UserInfo", nameof (CopyExternalUserInfoByAccountIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr);
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, nameof (m_AccountId));
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, 100664467);
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, 100664468);
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, 100664469);
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyExternalUserInfoByAccountIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, 100664470);
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, 100664471);
    CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, 100664472);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371848, XrefRangeEnd = 371854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371854, XrefRangeEnd = 371860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371860, XrefRangeEnd = 371864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 371880, RefRangeEnd = 371881, XrefRangeStart = 371864, XrefRangeEnd = 371880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CopyExternalUserInfoByAccountIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyExternalUserInfoByAccountIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371881, XrefRangeEnd = 371884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371884, XrefRangeEnd = 371899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyExternalUserInfoByAccountIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyExternalUserInfoByAccountIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
