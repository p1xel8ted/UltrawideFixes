// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAdmin.SetParticipantHardMuteOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAdmin;

[StructLayout(LayoutKind.Explicit)]
public struct SetParticipantHardMuteOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mute;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mute_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetParticipantHardMuteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_RoomName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(24)]
  public int m_Mute;

  static SetParticipantHardMuteOptionsInternal()
  {
    Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAdmin", nameof (SetParticipantHardMuteOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr);
    SetParticipantHardMuteOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetParticipantHardMuteOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
    SetParticipantHardMuteOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    SetParticipantHardMuteOptionsInternal.NativeFieldInfoPtr_m_Mute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, nameof (m_Mute));
    SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, 100666809);
    SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, 100666810);
    SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_set_Mute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, 100666811);
    SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetParticipantHardMuteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, 100666812);
    SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, 100666813);
    SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, 100666814);
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381783, XrefRangeEnd = 381787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381787, XrefRangeEnd = 381791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool Mute
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381791, XrefRangeEnd = 381795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_set_Mute_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 381807, RefRangeEnd = 381808, XrefRangeStart = 381795, XrefRangeEnd = 381807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SetParticipantHardMuteOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetParticipantHardMuteOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381808, XrefRangeEnd = 381811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381811, XrefRangeEnd = 381816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetParticipantHardMuteOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetParticipantHardMuteOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
