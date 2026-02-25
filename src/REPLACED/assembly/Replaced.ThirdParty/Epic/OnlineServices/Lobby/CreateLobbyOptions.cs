// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.CreateLobbyOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class CreateLobbyOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PermissionLevel_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PresenceEnabled_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AllowInvites_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__BucketId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DisableHostMigration_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EnableRTCRoom_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalRTCOptions_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LobbyId_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxLobbyMembers_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BucketId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisableHostMigration_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableRTCRoom_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_LocalRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CreateLobbyOptions()
  {
    Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (CreateLobbyOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr);
    CreateLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<MaxLobbyMembers>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__PermissionLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<PermissionLevel>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<PresenceEnabled>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__AllowInvites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<AllowInvites>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__BucketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<BucketId>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__DisableHostMigration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<DisableHostMigration>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__EnableRTCRoom_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<EnableRTCRoom>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<LocalRTCOptions>k__BackingField");
    CreateLobbyOptions.NativeFieldInfoPtr__LobbyId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<LobbyId>k__BackingField");
    CreateLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668966);
    CreateLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668967);
    CreateLobbyOptions.NativeMethodInfoPtr_get_MaxLobbyMembers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668968);
    CreateLobbyOptions.NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668969);
    CreateLobbyOptions.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668970);
    CreateLobbyOptions.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668971);
    CreateLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668972);
    CreateLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668973);
    CreateLobbyOptions.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668974);
    CreateLobbyOptions.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668975);
    CreateLobbyOptions.NativeMethodInfoPtr_get_BucketId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668976);
    CreateLobbyOptions.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668977);
    CreateLobbyOptions.NativeMethodInfoPtr_get_DisableHostMigration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668978);
    CreateLobbyOptions.NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668979);
    CreateLobbyOptions.NativeMethodInfoPtr_get_EnableRTCRoom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668980);
    CreateLobbyOptions.NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668981);
    CreateLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668982);
    CreateLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668983);
    CreateLobbyOptions.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668984);
    CreateLobbyOptions.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668985);
    CreateLobbyOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100668986);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint MaxLobbyMembers
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_MaxLobbyMembers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LobbyPermissionLevel PermissionLevel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LobbyPermissionLevel*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PresenceEnabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowInvites
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string BucketId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_BucketId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool DisableHostMigration
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_DisableHostMigration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool EnableRTCRoom
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_EnableRTCRoom_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LocalRTCOptions LocalRTCOptions
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_LocalRTCOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (LocalRTCOptions) null : Il2CppObjectPool.Get<LocalRTCOptions>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LobbyId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CreateLobbyOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ProductUserId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe uint _MaxLobbyMembers_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField)) = value;
    }
  }

  public unsafe LobbyPermissionLevel _PermissionLevel_k__BackingField
  {
    get
    {
      return *(LobbyPermissionLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PermissionLevel_k__BackingField));
    }
    [param: In] set
    {
      *(LobbyPermissionLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PermissionLevel_k__BackingField)) = value;
    }
  }

  public unsafe bool _PresenceEnabled_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField)) = value;
    }
  }

  public unsafe bool _AllowInvites_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__AllowInvites_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__AllowInvites_k__BackingField)) = value;
    }
  }

  public unsafe string _BucketId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__BucketId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__BucketId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _DisableHostMigration_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__DisableHostMigration_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__DisableHostMigration_k__BackingField)) = value;
    }
  }

  public unsafe bool _EnableRTCRoom_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__EnableRTCRoom_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__EnableRTCRoom_k__BackingField)) = value;
    }
  }

  public unsafe LocalRTCOptions _LocalRTCOptions_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField));
      return num == System.IntPtr.Zero ? (LocalRTCOptions) null : Il2CppObjectPool.Get<LocalRTCOptions>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _LobbyId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LobbyId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LobbyId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
