// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.RTCRoomConnectionChangedCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

[StructLayout(LayoutKind.Explicit)]
public struct RTCRoomConnectionChangedCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsConnected;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisconnectReason;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisconnectReason_Public_get_Result_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LobbyId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(24)]
  public int m_IsConnected;
  [FieldOffset(28)]
  public Result m_DisconnectReason;

  static RTCRoomConnectionChangedCallbackInfoInternal()
  {
    Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (RTCRoomConnectionChangedCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr);
    RTCRoomConnectionChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    RTCRoomConnectionChangedCallbackInfoInternal.NativeFieldInfoPtr_m_LobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_LobbyId));
    RTCRoomConnectionChangedCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    RTCRoomConnectionChangedCallbackInfoInternal.NativeFieldInfoPtr_m_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_IsConnected));
    RTCRoomConnectionChangedCallbackInfoInternal.NativeFieldInfoPtr_m_DisconnectReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_DisconnectReason));
    RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, 100669820);
    RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, 100669821);
    RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, 100669822);
    RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, 100669823);
    RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, 100669824);
    RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_DisconnectReason_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, 100669825);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391377, XrefRangeEnd = 391381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string LobbyId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391381, XrefRangeEnd = 391385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391385, XrefRangeEnd = 391391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe bool IsConnected
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391391, XrefRangeEnd = 391395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Result DisconnectReason
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCRoomConnectionChangedCallbackInfoInternal.NativeMethodInfoPtr_get_DisconnectReason_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTCRoomConnectionChangedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
