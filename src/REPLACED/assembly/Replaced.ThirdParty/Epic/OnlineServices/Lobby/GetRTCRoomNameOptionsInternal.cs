// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.GetRTCRoomNameOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

[StructLayout(LayoutKind.Explicit)]
public struct GetRTCRoomNameOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_GetRTCRoomNameOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LobbyId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;

  static GetRTCRoomNameOptionsInternal()
  {
    Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (GetRTCRoomNameOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr);
    GetRTCRoomNameOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    GetRTCRoomNameOptionsInternal.NativeFieldInfoPtr_m_LobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, nameof (m_LobbyId));
    GetRTCRoomNameOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, 100669053);
    GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, 100669054);
    GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetRTCRoomNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, 100669055);
    GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, 100669056);
    GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, 100669057);
  }

  public unsafe string LobbyId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389067, XrefRangeEnd = 389071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389071, XrefRangeEnd = 389075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 389083, RefRangeEnd = 389084, XrefRangeStart = 389075, XrefRangeEnd = 389083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(GetRTCRoomNameOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetRTCRoomNameOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389084, XrefRangeEnd = 389087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389087, XrefRangeEnd = 389092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetRTCRoomNameOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetRTCRoomNameOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
