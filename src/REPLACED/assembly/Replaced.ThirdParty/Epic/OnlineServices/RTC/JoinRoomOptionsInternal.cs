// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.JoinRoomOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC;

[StructLayout(LayoutKind.Explicit)]
public struct JoinRoomOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientBaseUrl;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ManualAudioInputEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ManualAudioOutputEnabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientBaseUrl_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantToken_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_JoinRoomFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ManualAudioInputEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ManualAudioOutputEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_JoinRoomOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public System.IntPtr m_ClientBaseUrl;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ParticipantToken;
  [FieldOffset(40)]
  public System.IntPtr m_ParticipantId;
  [FieldOffset(48 /*0x30*/)]
  public JoinRoomFlags m_Flags;
  [FieldOffset(52)]
  public int m_ManualAudioInputEnabled;
  [FieldOffset(56)]
  public int m_ManualAudioOutputEnabled;

  static JoinRoomOptionsInternal()
  {
    Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTC", nameof (JoinRoomOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr);
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ClientBaseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ClientBaseUrl));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ParticipantToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ParticipantToken));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ParticipantId));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_Flags));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ManualAudioInputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ManualAudioInputEnabled));
    JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ManualAudioOutputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ManualAudioOutputEnabled));
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666939);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666940);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ClientBaseUrl_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666941);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666942);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666943);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_JoinRoomFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666944 /*0x06000E40*/);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioInputEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666945);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioOutputEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666946);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_JoinRoomOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666947);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666948);
    JoinRoomOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100666949);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382188, XrefRangeEnd = 382192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382192, XrefRangeEnd = 382196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ClientBaseUrl
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382196, XrefRangeEnd = 382200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ClientBaseUrl_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ParticipantToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382200, XrefRangeEnd = 382204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantToken_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId ParticipantId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382204, XrefRangeEnd = 382208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe JoinRoomFlags Flags
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_JoinRoomFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool ManualAudioInputEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382208, XrefRangeEnd = 382212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioInputEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool ManualAudioOutputEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382212, XrefRangeEnd = 382216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioOutputEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 382244, RefRangeEnd = 382245, XrefRangeStart = 382216, XrefRangeEnd = 382244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(JoinRoomOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_JoinRoomOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382245, XrefRangeEnd = 382248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382248, XrefRangeEnd = 382256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
