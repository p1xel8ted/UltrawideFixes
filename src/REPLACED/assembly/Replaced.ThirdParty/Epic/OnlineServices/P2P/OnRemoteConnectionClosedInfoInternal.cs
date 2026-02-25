// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnRemoteConnectionClosedInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

[StructLayout(LayoutKind.Explicit)]
public struct OnRemoteConnectionClosedInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RemoteUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SocketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Reason;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Reason_Public_get_ConnectionClosedReason_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RemoteUserId;
  [FieldOffset(24)]
  public System.IntPtr m_SocketId;
  [FieldOffset(32 /*0x20*/)]
  public ConnectionClosedReason m_Reason;

  static OnRemoteConnectionClosedInfoInternal()
  {
    Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (OnRemoteConnectionClosedInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr);
    OnRemoteConnectionClosedInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnRemoteConnectionClosedInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    OnRemoteConnectionClosedInfoInternal.NativeFieldInfoPtr_m_RemoteUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, nameof (m_RemoteUserId));
    OnRemoteConnectionClosedInfoInternal.NativeFieldInfoPtr_m_SocketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, nameof (m_SocketId));
    OnRemoteConnectionClosedInfoInternal.NativeFieldInfoPtr_m_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, nameof (m_Reason));
    OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, 100668400);
    OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, 100668401);
    OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, 100668402);
    OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, 100668403);
    OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, 100668404);
    OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_Reason_Public_get_ConnectionClosedReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, 100668405);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386778, XrefRangeEnd = 386782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386782, XrefRangeEnd = 386788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe ProductUserId RemoteUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386788, XrefRangeEnd = 386794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe SocketId SocketId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386794, XrefRangeEnd = 386800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SocketId) null : Il2CppObjectPool.Get<SocketId>(num3);
    }
  }

  public unsafe ConnectionClosedReason Reason
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfoInternal.NativeMethodInfoPtr_get_Reason_Public_get_ConnectionClosedReason_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ConnectionClosedReason*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnRemoteConnectionClosedInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
