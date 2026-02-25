// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.OptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

[StructLayout(LayoutKind.Explicit)]
public struct OptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Reserved;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SandboxId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientCredentials;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsServer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EncryptionKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideCountryCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideLocaleCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeploymentId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CacheDirectory;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TickBudgetInMilliseconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RTCOptions;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_RTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Options_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Reserved;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ProductId;
  [FieldOffset(24)]
  public System.IntPtr m_SandboxId;
  [FieldOffset(32 /*0x20*/)]
  public ClientCredentialsInternal m_ClientCredentials;
  [FieldOffset(48 /*0x30*/)]
  public int m_IsServer;
  [FieldOffset(56)]
  public System.IntPtr m_EncryptionKey;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_OverrideCountryCode;
  [FieldOffset(72)]
  public System.IntPtr m_OverrideLocaleCode;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr m_DeploymentId;
  [FieldOffset(88)]
  public PlatformFlags m_Flags;
  [FieldOffset(96 /*0x60*/)]
  public System.IntPtr m_CacheDirectory;
  [FieldOffset(104)]
  public uint m_TickBudgetInMilliseconds;
  [FieldOffset(112 /*0x70*/)]
  public System.IntPtr m_RTCOptions;

  static OptionsInternal()
  {
    Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (OptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr);
    OptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    OptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_Reserved));
    OptionsInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ProductId));
    OptionsInternal.NativeFieldInfoPtr_m_SandboxId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_SandboxId));
    OptionsInternal.NativeFieldInfoPtr_m_ClientCredentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ClientCredentials));
    OptionsInternal.NativeFieldInfoPtr_m_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_IsServer));
    OptionsInternal.NativeFieldInfoPtr_m_EncryptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_EncryptionKey));
    OptionsInternal.NativeFieldInfoPtr_m_OverrideCountryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_OverrideCountryCode));
    OptionsInternal.NativeFieldInfoPtr_m_OverrideLocaleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_OverrideLocaleCode));
    OptionsInternal.NativeFieldInfoPtr_m_DeploymentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_DeploymentId));
    OptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_Flags));
    OptionsInternal.NativeFieldInfoPtr_m_CacheDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_CacheDirectory));
    OptionsInternal.NativeFieldInfoPtr_m_TickBudgetInMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_TickBudgetInMilliseconds));
    OptionsInternal.NativeFieldInfoPtr_m_RTCOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_RTCOptions));
    OptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668025);
    OptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668026);
    OptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668027);
    OptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668028);
    OptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668029);
    OptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668030);
    OptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668031);
    OptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668032);
    OptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668033);
    OptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668034);
    OptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668035);
    OptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668036);
    OptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_RTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668037);
    OptionsInternal.NativeMethodInfoPtr_Set_Public_Void_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668038);
    OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668039);
    OptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100668040);
  }

  public unsafe System.IntPtr Reserved
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385596, XrefRangeEnd = 385600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string SandboxId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385600, XrefRangeEnd = 385604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ClientCredentials ClientCredentials
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 385610, RefRangeEnd = 385611, XrefRangeStart = 385604, XrefRangeEnd = 385610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsServer
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385611, XrefRangeEnd = 385615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EncryptionKey
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385615, XrefRangeEnd = 385619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideCountryCode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385619, XrefRangeEnd = 385623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideLocaleCode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385623, XrefRangeEnd = 385627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeploymentId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385627, XrefRangeEnd = 385631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PlatformFlags Flags
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CacheDirectory
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385631, XrefRangeEnd = 385635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint TickBudgetInMilliseconds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 298986, RefRangeEnd = 298987, XrefRangeStart = 298986, XrefRangeEnd = 298987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RTCOptions RTCOptions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 385641, RefRangeEnd = 385642, XrefRangeStart = 385635, XrefRangeEnd = 385641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_RTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 385676, RefRangeEnd = 385677, XrefRangeStart = 385642, XrefRangeEnd = 385676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Options other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Set_Public_Void_Options_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385677, XrefRangeEnd = 385680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385680, XrefRangeEnd = 385695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
