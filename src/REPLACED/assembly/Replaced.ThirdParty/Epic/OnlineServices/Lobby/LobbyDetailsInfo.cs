// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyDetailsInfo
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

public class LobbyDetailsInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LobbyId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LobbyOwnerUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PermissionLevel_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AvailableSlots_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MaxMembers_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AllowInvites_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__BucketId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AllowHostMigration_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RTCRoomEnabled_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyOwnerUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyOwnerUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableSlots_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AvailableSlots_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxMembers_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BucketId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowHostMigration_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowHostMigration_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RTCRoomEnabled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCRoomEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LobbyDetailsInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LobbyDetailsInfo()
  {
    Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyDetailsInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr);
    LobbyDetailsInfo.NativeFieldInfoPtr__LobbyId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<LobbyId>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__LobbyOwnerUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<LobbyOwnerUserId>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__PermissionLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<PermissionLevel>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__AvailableSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<AvailableSlots>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__MaxMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<MaxMembers>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__AllowInvites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<AllowInvites>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__BucketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<BucketId>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__AllowHostMigration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<AllowHostMigration>k__BackingField");
    LobbyDetailsInfo.NativeFieldInfoPtr__RTCRoomEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, "<RTCRoomEnabled>k__BackingField");
    LobbyDetailsInfo.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669240);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669241);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_LobbyOwnerUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669242);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_LobbyOwnerUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669243);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669244);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669245);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_AvailableSlots_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669246);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_AvailableSlots_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669247);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_MaxMembers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669248);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669249);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669250);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669251);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_BucketId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669252);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669253);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_AllowHostMigration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669254);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_AllowHostMigration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669255);
    LobbyDetailsInfo.NativeMethodInfoPtr_get_RTCRoomEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669256);
    LobbyDetailsInfo.NativeMethodInfoPtr_set_RTCRoomEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669257);
    LobbyDetailsInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LobbyDetailsInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669258);
    LobbyDetailsInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669259);
    LobbyDetailsInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr, 100669260);
  }

  public unsafe string LobbyId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LobbyOwnerUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_LobbyOwnerUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_LobbyOwnerUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LobbyPermissionLevel*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint AvailableSlots
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_AvailableSlots_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_AvailableSlots_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint MaxMembers
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_MaxMembers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string BucketId
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_BucketId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowHostMigration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_AllowHostMigration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_AllowHostMigration_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool RTCRoomEnabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_get_RTCRoomEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_set_RTCRoomEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 389653, RefRangeEnd = 389654, XrefRangeStart = 389607, XrefRangeEnd = 389653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<LobbyDetailsInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LobbyDetailsInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389654, XrefRangeEnd = 389659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbyDetailsInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyDetailsInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _LobbyId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__LobbyId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__LobbyId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ProductUserId _LobbyOwnerUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__LobbyOwnerUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__LobbyOwnerUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LobbyPermissionLevel _PermissionLevel_k__BackingField
  {
    get
    {
      return *(LobbyPermissionLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__PermissionLevel_k__BackingField));
    }
    [param: In] set
    {
      *(LobbyPermissionLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__PermissionLevel_k__BackingField)) = value;
    }
  }

  public unsafe uint _AvailableSlots_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__AvailableSlots_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__AvailableSlots_k__BackingField)) = value;
    }
  }

  public unsafe uint _MaxMembers_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__MaxMembers_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__MaxMembers_k__BackingField)) = value;
    }
  }

  public unsafe bool _AllowInvites_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__AllowInvites_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__AllowInvites_k__BackingField)) = value;
    }
  }

  public unsafe string _BucketId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__BucketId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__BucketId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _AllowHostMigration_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__AllowHostMigration_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__AllowHostMigration_k__BackingField)) = value;
    }
  }

  public unsafe bool _RTCRoomEnabled_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__RTCRoomEnabled_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyDetailsInfo.NativeFieldInfoPtr__RTCRoomEnabled_k__BackingField)) = value;
    }
  }
}
