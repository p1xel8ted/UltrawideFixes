// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsSettingsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct SessionDetailsSettingsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BucketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NumPublicConnections;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowJoinInProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionLevel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InvitesAllowed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SanctionsEnabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BucketId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NumPublicConnections_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NumPublicConnections_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_OnlineSessionPermissionLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SanctionsEnabled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionDetailsSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_BucketId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_NumPublicConnections;
  [FieldOffset(20)]
  public int m_AllowJoinInProgress;
  [FieldOffset(24)]
  public OnlineSessionPermissionLevel m_PermissionLevel;
  [FieldOffset(28)]
  public int m_InvitesAllowed;
  [FieldOffset(32 /*0x20*/)]
  public int m_SanctionsEnabled;

  static SessionDetailsSettingsInternal()
  {
    Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsSettingsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr);
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_BucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_BucketId));
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_NumPublicConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_NumPublicConnections));
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_AllowJoinInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_AllowJoinInProgress));
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_PermissionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_PermissionLevel));
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_InvitesAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_InvitesAllowed));
    SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_SanctionsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_SanctionsEnabled));
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_BucketId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665810);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665811);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_NumPublicConnections_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665812);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_NumPublicConnections_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665813);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665814);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665815);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665816);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_OnlineSessionPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665817);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665818);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665819);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_SanctionsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665820);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665821);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665822);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665823);
    SessionDetailsSettingsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100665824 /*0x060009E0*/);
  }

  public unsafe string BucketId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378545, XrefRangeEnd = 378549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_BucketId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378549, XrefRangeEnd = 378553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint NumPublicConnections
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_NumPublicConnections_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_NumPublicConnections_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowJoinInProgress
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378553, XrefRangeEnd = 378557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378557, XrefRangeEnd = 378561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe OnlineSessionPermissionLevel PermissionLevel
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(OnlineSessionPermissionLevel*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_OnlineSessionPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool InvitesAllowed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378561, XrefRangeEnd = 378565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378565, XrefRangeEnd = 378569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool SanctionsEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378569, XrefRangeEnd = 378573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_SanctionsEnabled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378573, XrefRangeEnd = 378577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 378593, RefRangeEnd = 378594, XrefRangeStart = 378577, XrefRangeEnd = 378593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionDetailsSettings other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378594, XrefRangeEnd = 378597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378597, XrefRangeEnd = 378601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
