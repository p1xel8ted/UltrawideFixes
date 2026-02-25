// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.VerifyIdTokenCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct VerifyIdTokenCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsAccountInfoPresent;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Platform;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SandboxId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeploymentId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAccountInfoPresent_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceType_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SandboxId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ProductUserId;
  [FieldOffset(24)]
  public int m_IsAccountInfoPresent;
  [FieldOffset(28)]
  public ExternalAccountType m_AccountIdType;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_AccountId;
  [FieldOffset(40)]
  public System.IntPtr m_Platform;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_DeviceType;
  [FieldOffset(56)]
  public System.IntPtr m_ClientId;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_ProductId;
  [FieldOffset(72)]
  public System.IntPtr m_SandboxId;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr m_DeploymentId;

  static VerifyIdTokenCallbackInfoInternal()
  {
    Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (VerifyIdTokenCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr);
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ProductUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ProductUserId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_IsAccountInfoPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_IsAccountInfoPresent));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_AccountIdType));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_AccountId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_Platform));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_DeviceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_DeviceType));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ProductId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_SandboxId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_SandboxId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_DeploymentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_DeploymentId));
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671978);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671979);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671980);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671981);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_IsAccountInfoPresent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671982);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671983);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_AccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671984);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671985);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DeviceType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671986);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671987);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671988);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671989);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100671990);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397987, XrefRangeEnd = 397991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId ProductUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397991, XrefRangeEnd = 397997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe bool IsAccountInfoPresent
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397997, XrefRangeEnd = 398001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_IsAccountInfoPresent_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ExternalAccountType AccountIdType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398001, XrefRangeEnd = 398005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_AccountId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string Platform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398005, XrefRangeEnd = 398009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string DeviceType
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398009, XrefRangeEnd = 398013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DeviceType_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string ClientId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398013, XrefRangeEnd = 398017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string ProductId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398017, XrefRangeEnd = 398021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string SandboxId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398021, XrefRangeEnd = 398025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string DeploymentId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398025, XrefRangeEnd = 398029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
