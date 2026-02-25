// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyDetailsInfoInternal
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

[StructLayout(LayoutKind.Explicit)]
public struct LobbyDetailsInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyOwnerUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionLevel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableSlots;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxMembers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowInvites;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BucketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowHostMigration;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RTCRoomEnabled;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LobbyDetailsInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LobbyId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LobbyOwnerUserId;
  [FieldOffset(24)]
  public LobbyPermissionLevel m_PermissionLevel;
  [FieldOffset(28)]
  public uint m_AvailableSlots;
  [FieldOffset(32 /*0x20*/)]
  public uint m_MaxMembers;
  [FieldOffset(36)]
  public int m_AllowInvites;
  [FieldOffset(40)]
  public System.IntPtr m_BucketId;
  [FieldOffset(48 /*0x30*/)]
  public int m_AllowHostMigration;
  [FieldOffset(52)]
  public int m_RTCRoomEnabled;

  static LobbyDetailsInfoInternal()
  {
    Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyDetailsInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr);
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_LobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_LobbyId));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_LobbyOwnerUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_LobbyOwnerUserId));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_PermissionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_PermissionLevel));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_AvailableSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_AvailableSlots));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_MaxMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_MaxMembers));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_AllowInvites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_AllowInvites));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_BucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_BucketId));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_AllowHostMigration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_AllowHostMigration));
    LobbyDetailsInfoInternal.NativeFieldInfoPtr_m_RTCRoomEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, nameof (m_RTCRoomEnabled));
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669261);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669262);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_LobbyOwnerUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669263);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_LobbyOwnerUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669264);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669265);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669266);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_AvailableSlots_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669267);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_AvailableSlots_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669268);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_MaxMembers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669269);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669270);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669271);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669272);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_BucketId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669273);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669274);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_AllowHostMigration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669275);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_AllowHostMigration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669276);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_RTCRoomEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669277);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_RTCRoomEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669278);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669279);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669280);
    LobbyDetailsInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, 100669281);
  }

  public unsafe string LobbyId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389659, XrefRangeEnd = 389663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_LobbyId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389663, XrefRangeEnd = 389667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LobbyOwnerUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389667, XrefRangeEnd = 389673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_LobbyOwnerUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389673, XrefRangeEnd = 389677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_LobbyOwnerUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LobbyPermissionLevel PermissionLevel
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LobbyPermissionLevel*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint AvailableSlots
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_AvailableSlots_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_AvailableSlots_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint MaxMembers
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_MaxMembers_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_MaxMembers_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowInvites
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389677, XrefRangeEnd = 389681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389681, XrefRangeEnd = 389685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string BucketId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389685, XrefRangeEnd = 389689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_BucketId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389689, XrefRangeEnd = 389693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowHostMigration
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389693, XrefRangeEnd = 389697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_AllowHostMigration_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389697, XrefRangeEnd = 389701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_AllowHostMigration_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool RTCRoomEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389701, XrefRangeEnd = 389705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_get_RTCRoomEnabled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389705, XrefRangeEnd = 389709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_set_RTCRoomEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 389733, RefRangeEnd = 389734, XrefRangeStart = 389709, XrefRangeEnd = 389733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LobbyDetailsInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389734, XrefRangeEnd = 389737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389737, XrefRangeEnd = 389743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyDetailsInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
