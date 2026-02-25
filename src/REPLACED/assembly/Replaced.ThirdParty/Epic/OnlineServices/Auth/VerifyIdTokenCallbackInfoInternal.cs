// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyIdTokenCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

[StructLayout(LayoutKind.Explicit)]
public struct VerifyIdTokenCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApplicationId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SandboxId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeploymentId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsExternalAccountInfoPresent;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Platform;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ApplicationId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SandboxId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExternalAccountInfoPresent_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountIdType_Public_get_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountDisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Public_get_String_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ApplicationId;
  [FieldOffset(24)]
  public System.IntPtr m_ClientId;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ProductId;
  [FieldOffset(40)]
  public System.IntPtr m_SandboxId;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_DeploymentId;
  [FieldOffset(56)]
  public System.IntPtr m_DisplayName;
  [FieldOffset(64 /*0x40*/)]
  public int m_IsExternalAccountInfoPresent;
  [FieldOffset(68)]
  public ExternalAccountType m_ExternalAccountIdType;
  [FieldOffset(72)]
  public System.IntPtr m_ExternalAccountId;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr m_ExternalAccountDisplayName;
  [FieldOffset(88)]
  public System.IntPtr m_Platform;

  static VerifyIdTokenCallbackInfoInternal()
  {
    Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (VerifyIdTokenCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr);
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ApplicationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ApplicationId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ProductId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_SandboxId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_SandboxId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_DeploymentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_DeploymentId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_DisplayName));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_IsExternalAccountInfoPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_IsExternalAccountInfoPresent));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ExternalAccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ExternalAccountIdType));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ExternalAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ExternalAccountId));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_ExternalAccountDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_ExternalAccountDisplayName));
    VerifyIdTokenCallbackInfoInternal.NativeFieldInfoPtr_m_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, nameof (m_Platform));
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672404);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672405);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672406);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ApplicationId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672407);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672408);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672409);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672410);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672411);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672412);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_IsExternalAccountInfoPresent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672413);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountIdType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672414);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672415);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672416);
    VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, 100672417);
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399361, XrefRangeEnd = 399365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
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

  public unsafe string ApplicationId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399365, XrefRangeEnd = 399369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ApplicationId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string ClientId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399369, XrefRangeEnd = 399373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399373, XrefRangeEnd = 399377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399377, XrefRangeEnd = 399381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399381, XrefRangeEnd = 399385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399385, XrefRangeEnd = 399389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe bool IsExternalAccountInfoPresent
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399389, XrefRangeEnd = 399393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_IsExternalAccountInfoPresent_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ExternalAccountType ExternalAccountIdType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountIdType_Public_get_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string ExternalAccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399393, XrefRangeEnd = 399397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string ExternalAccountDisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399397, XrefRangeEnd = 399401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_ExternalAccountDisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string Platform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399401, XrefRangeEnd = 399405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerifyIdTokenCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
