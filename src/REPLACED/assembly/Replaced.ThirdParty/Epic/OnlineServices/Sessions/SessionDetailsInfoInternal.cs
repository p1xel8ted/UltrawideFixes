// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct SessionDetailsInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HostAddress;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NumOpenPublicConnections;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Settings;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HostAddress_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HostAddress_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_SessionDetailsSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_SessionDetailsSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionDetailsInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_HostAddress;
  [FieldOffset(24)]
  public uint m_NumOpenPublicConnections;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_Settings;

  static SessionDetailsInfoInternal()
  {
    Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr);
    SessionDetailsInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionDetailsInfoInternal.NativeFieldInfoPtr_m_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_SessionId));
    SessionDetailsInfoInternal.NativeFieldInfoPtr_m_HostAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_HostAddress));
    SessionDetailsInfoInternal.NativeFieldInfoPtr_m_NumOpenPublicConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_NumOpenPublicConnections));
    SessionDetailsInfoInternal.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_Settings));
    SessionDetailsInfoInternal.NativeMethodInfoPtr_get_SessionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665784);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_set_SessionId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665785);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_get_HostAddress_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665786);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665787);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665788);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665789);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_get_Settings_Public_get_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665790);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_set_Settings_Public_set_Void_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665791);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665792 /*0x060009C0*/);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665793);
    SessionDetailsInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100665794);
  }

  public unsafe string SessionId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378433, XrefRangeEnd = 378437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_SessionId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378437, XrefRangeEnd = 378441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_SessionId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string HostAddress
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378441, XrefRangeEnd = 378445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_HostAddress_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378445, XrefRangeEnd = 378449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint NumOpenPublicConnections
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SessionDetailsSettings Settings
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378449, XrefRangeEnd = 378455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_Settings_Public_get_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SessionDetailsSettings) null : Il2CppObjectPool.Get<SessionDetailsSettings>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 378461, RefRangeEnd = 378462, XrefRangeStart = 378455, XrefRangeEnd = 378461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_Settings_Public_set_Void_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 378471, RefRangeEnd = 378472, XrefRangeStart = 378462, XrefRangeEnd = 378471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionDetailsInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378472, XrefRangeEnd = 378475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378475, XrefRangeEnd = 378481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
