// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.RegisterPeerOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterPeerOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PeerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientPlatform;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IpAddress;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RegisterPeerOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PeerHandle;
  [FieldOffset(16 /*0x10*/)]
  public AntiCheatCommonClientType m_ClientType;
  [FieldOffset(20)]
  public AntiCheatCommonClientPlatform m_ClientPlatform;
  [FieldOffset(24)]
  public System.IntPtr m_AccountId;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_IpAddress;

  static RegisterPeerOptionsInternal()
  {
    Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (RegisterPeerOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr);
    RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_PeerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_PeerHandle));
    RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_ClientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ClientType));
    RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_ClientPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ClientPlatform));
    RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_AccountId));
    RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_IpAddress));
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673163);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673164);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673165);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673166);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673167);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673168);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673169);
    RegisterPeerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100673170);
  }

  public unsafe System.IntPtr PeerHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientType ClientType
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientPlatform ClientPlatform
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401448, XrefRangeEnd = 401452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string IpAddress
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401452, XrefRangeEnd = 401456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 401464, RefRangeEnd = 401465, XrefRangeStart = 401456, XrefRangeEnd = 401464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RegisterPeerOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterPeerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401465, XrefRangeEnd = 401468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401468, XrefRangeEnd = 401474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
