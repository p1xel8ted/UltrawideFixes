// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.CreateLobbyOptionsInternal
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
public struct CreateLobbyOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxLobbyMembers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionLevel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PresenceEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowInvites;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BucketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisableHostMigration;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableRTCRoom;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalRTCOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CreateLobbyOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_MaxLobbyMembers;
  [FieldOffset(20)]
  public LobbyPermissionLevel m_PermissionLevel;
  [FieldOffset(24)]
  public int m_PresenceEnabled;
  [FieldOffset(28)]
  public int m_AllowInvites;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_BucketId;
  [FieldOffset(40)]
  public int m_DisableHostMigration;
  [FieldOffset(44)]
  public int m_EnableRTCRoom;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_LocalRTCOptions;
  [FieldOffset(56)]
  public System.IntPtr m_LobbyId;

  static CreateLobbyOptionsInternal()
  {
    Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (CreateLobbyOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr);
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_MaxLobbyMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_MaxLobbyMembers));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_PermissionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_PermissionLevel));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_PresenceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_PresenceEnabled));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_AllowInvites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_AllowInvites));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_BucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_BucketId));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_DisableHostMigration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_DisableHostMigration));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_EnableRTCRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_EnableRTCRoom));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_LocalRTCOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_LocalRTCOptions));
    CreateLobbyOptionsInternal.NativeFieldInfoPtr_m_LobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, nameof (m_LobbyId));
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668987);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668988);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668989);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668990);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668991);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668992);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668993);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668994);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668995);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668996);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateLobbyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668997);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668998);
    CreateLobbyOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, 100668999);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388882, XrefRangeEnd = 388886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint MaxLobbyMembers
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LobbyPermissionLevel PermissionLevel
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PresenceEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388886, XrefRangeEnd = 388890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowInvites
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388890, XrefRangeEnd = 388894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string BucketId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388894, XrefRangeEnd = 388898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool DisableHostMigration
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388898, XrefRangeEnd = 388902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool EnableRTCRoom
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388902, XrefRangeEnd = 388906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LocalRTCOptions LocalRTCOptions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 388912, RefRangeEnd = 388913, XrefRangeStart = 388906, XrefRangeEnd = 388912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LobbyId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388913, XrefRangeEnd = 388917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 388946, RefRangeEnd = 388947, XrefRangeStart = 388917, XrefRangeEnd = 388946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CreateLobbyOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateLobbyOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388947, XrefRangeEnd = 388950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388950, XrefRangeEnd = 388957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateLobbyOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
