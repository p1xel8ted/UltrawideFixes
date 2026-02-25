// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.RegisterClientOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterClientOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientPlatform;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IpAddress;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RegisterClientOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(16 /*0x10*/)]
  public AntiCheatCommonClientType m_ClientType;
  [FieldOffset(20)]
  public AntiCheatCommonClientPlatform m_ClientPlatform;
  [FieldOffset(24)]
  public System.IntPtr m_AccountId;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_IpAddress;

  static RegisterClientOptionsInternal()
  {
    Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatServer", nameof (RegisterClientOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr);
    RegisterClientOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RegisterClientOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
    RegisterClientOptionsInternal.NativeFieldInfoPtr_m_ClientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, nameof (m_ClientType));
    RegisterClientOptionsInternal.NativeFieldInfoPtr_m_ClientPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, nameof (m_ClientPlatform));
    RegisterClientOptionsInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, nameof (m_AccountId));
    RegisterClientOptionsInternal.NativeFieldInfoPtr_m_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, nameof (m_IpAddress));
    RegisterClientOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672573);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672574);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672575);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672576);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672577);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672578);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672579);
    RegisterClientOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, 100672580);
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399827, XrefRangeEnd = 399831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string IpAddress
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399831, XrefRangeEnd = 399835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 399843, RefRangeEnd = 399844, XrefRangeStart = 399835, XrefRangeEnd = 399843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RegisterClientOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterClientOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399844, XrefRangeEnd = 399847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399847, XrefRangeEnd = 399853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterClientOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterClientOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
