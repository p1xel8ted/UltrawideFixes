// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.IsRTCRoomConnectedOptionsInternal
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
public struct IsRTCRoomConnectedOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_IsRTCRoomConnectedOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LobbyId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;

  static IsRTCRoomConnectedOptionsInternal()
  {
    Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (IsRTCRoomConnectedOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr);
    IsRTCRoomConnectedOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    IsRTCRoomConnectedOptionsInternal.NativeFieldInfoPtr_m_LobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, nameof (m_LobbyId));
    IsRTCRoomConnectedOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, 100669063);
    IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, 100669064);
    IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_IsRTCRoomConnectedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, 100669065);
    IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, 100669066);
    IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, 100669067);
  }

  public unsafe string LobbyId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389092, XrefRangeEnd = 389096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389096, XrefRangeEnd = 389100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 389108, RefRangeEnd = 389109, XrefRangeStart = 389100, XrefRangeEnd = 389108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(IsRTCRoomConnectedOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_IsRTCRoomConnectedOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389109, XrefRangeEnd = 389112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389112, XrefRangeEnd = 389117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IsRTCRoomConnectedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IsRTCRoomConnectedOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
