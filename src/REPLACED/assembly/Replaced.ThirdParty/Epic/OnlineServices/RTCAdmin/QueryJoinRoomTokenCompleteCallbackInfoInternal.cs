// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAdmin.QueryJoinRoomTokenCompleteCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAdmin;

[StructLayout(LayoutKind.Explicit)]
public struct QueryJoinRoomTokenCompleteCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientBaseUrl;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_QueryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TokenCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientBaseUrl_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_QueryId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TokenCount_Public_get_UInt32_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public System.IntPtr m_ClientBaseUrl;
  [FieldOffset(32 /*0x20*/)]
  public uint m_QueryId;
  [FieldOffset(36)]
  public uint m_TokenCount;

  static QueryJoinRoomTokenCompleteCallbackInfoInternal()
  {
    Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAdmin", nameof (QueryJoinRoomTokenCompleteCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_ClientBaseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientBaseUrl));
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_QueryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_QueryId));
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_TokenCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_TokenCount));
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666758);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666759);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666760);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666761);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientBaseUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666762);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_QueryId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666763);
    QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_TokenCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, 100666764);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381598, XrefRangeEnd = 381602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381602, XrefRangeEnd = 381606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string ClientBaseUrl
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381606, XrefRangeEnd = 381610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientBaseUrl_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe uint QueryId
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_QueryId_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe uint TokenCount
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_TokenCount_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryJoinRoomTokenCompleteCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
