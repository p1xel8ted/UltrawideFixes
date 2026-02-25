// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.ParticipantMetadataInternal
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
public struct ParticipantMetadataInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ParticipantMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Key;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Value;

  static ParticipantMetadataInternal()
  {
    Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTC", nameof (ParticipantMetadataInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr);
    ParticipantMetadataInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ParticipantMetadataInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, nameof (m_Key));
    ParticipantMetadataInternal.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, nameof (m_Value));
    ParticipantMetadataInternal.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667024 /*0x06000E90*/);
    ParticipantMetadataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667025);
    ParticipantMetadataInternal.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667026);
    ParticipantMetadataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667027);
    ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Void_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667028);
    ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667029);
    ParticipantMetadataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667030);
  }

  public unsafe string Key
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382382, XrefRangeEnd = 382386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_get_Key_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382386, XrefRangeEnd = 382390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Value
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382390, XrefRangeEnd = 382394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_get_Value_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382394, XrefRangeEnd = 382398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 382406, RefRangeEnd = 382407, XrefRangeStart = 382398, XrefRangeEnd = 382406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ParticipantMetadata other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Void_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382407, XrefRangeEnd = 382410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382410, XrefRangeEnd = 382415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
