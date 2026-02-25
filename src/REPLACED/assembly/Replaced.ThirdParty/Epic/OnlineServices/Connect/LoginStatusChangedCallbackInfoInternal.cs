// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.LoginStatusChangedCallbackInfoInternal
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
public struct LoginStatusChangedCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentStatus;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousStatus_Public_get_LoginStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStatus_Public_get_LoginStatus_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public LoginStatus m_PreviousStatus;
  [FieldOffset(20)]
  public LoginStatus m_CurrentStatus;

  static LoginStatusChangedCallbackInfoInternal()
  {
    Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (LoginStatusChangedCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr);
    LoginStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    LoginStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    LoginStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_PreviousStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_PreviousStatus));
    LoginStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_CurrentStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_CurrentStatus));
    LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, 100671737);
    LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, 100671738);
    LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, 100671739);
    LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_PreviousStatus_Public_get_LoginStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, 100671740);
    LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_CurrentStatus_Public_get_LoginStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, 100671741);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397536, XrefRangeEnd = 397540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397540, XrefRangeEnd = 397546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe LoginStatus PreviousStatus
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_PreviousStatus_Public_get_LoginStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LoginStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe LoginStatus CurrentStatus
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_CurrentStatus_Public_get_LoginStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LoginStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoginStatusChangedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
