// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.LoginCallbackInfoInternal
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
public struct LoginCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PinGrantInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ContinuanceToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountFeatureRestrictedInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedAccountId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PinGrantInfo_Public_get_PinGrantInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ContinuanceToken_Public_get_ContinuanceToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountFeatureRestrictedInfo_Public_get_AccountFeatureRestrictedInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedAccountId_Public_get_EpicAccountId_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(24)]
  public System.IntPtr m_PinGrantInfo;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ContinuanceToken;
  [FieldOffset(40)]
  public System.IntPtr m_AccountFeatureRestrictedInfo;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_SelectedAccountId;

  static LoginCallbackInfoInternal()
  {
    Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (LoginCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr);
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_PinGrantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_PinGrantInfo));
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_ContinuanceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_ContinuanceToken));
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_AccountFeatureRestrictedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_AccountFeatureRestrictedInfo));
    LoginCallbackInfoInternal.NativeFieldInfoPtr_m_SelectedAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, nameof (m_SelectedAccountId));
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672159);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672160);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672161);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672162);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_PinGrantInfo_Public_get_PinGrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672163);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ContinuanceToken_Public_get_ContinuanceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672164);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_AccountFeatureRestrictedInfo_Public_get_AccountFeatureRestrictedInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672165);
    LoginCallbackInfoInternal.NativeMethodInfoPtr_get_SelectedAccountId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, 100672166);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398753, XrefRangeEnd = 398757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398757, XrefRangeEnd = 398763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public unsafe PinGrantInfo PinGrantInfo
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398763, XrefRangeEnd = 398769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_PinGrantInfo_Public_get_PinGrantInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (PinGrantInfo) null : Il2CppObjectPool.Get<PinGrantInfo>(num3);
    }
  }

  public unsafe ContinuanceToken ContinuanceToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398769, XrefRangeEnd = 398775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_ContinuanceToken_Public_get_ContinuanceToken_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ContinuanceToken) null : Il2CppObjectPool.Get<ContinuanceToken>(num3);
    }
  }

  public unsafe AccountFeatureRestrictedInfo AccountFeatureRestrictedInfo
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398775, XrefRangeEnd = 398781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_AccountFeatureRestrictedInfo_Public_get_AccountFeatureRestrictedInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AccountFeatureRestrictedInfo) null : Il2CppObjectPool.Get<AccountFeatureRestrictedInfo>(num3);
    }
  }

  public unsafe EpicAccountId SelectedAccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398781, XrefRangeEnd = 398787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginCallbackInfoInternal.NativeMethodInfoPtr_get_SelectedAccountId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoginCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
