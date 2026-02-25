// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsOptionsInternal
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
public struct WindowsOptionsInternal
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
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_WindowsRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_WindowsOptions_0;
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

  static WindowsOptionsInternal()
  {
    Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (WindowsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr);
    WindowsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_Reserved));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_ProductId));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_SandboxId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_SandboxId));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_ClientCredentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_ClientCredentials));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_IsServer));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_EncryptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_EncryptionKey));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_OverrideCountryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_OverrideCountryCode));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_OverrideLocaleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_OverrideLocaleCode));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_DeploymentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_DeploymentId));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_Flags));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_CacheDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_CacheDirectory));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_TickBudgetInMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_TickBudgetInMilliseconds));
    WindowsOptionsInternal.NativeFieldInfoPtr_m_RTCOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_RTCOptions));
    WindowsOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668127);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668128);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668129);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668130);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668131);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668132);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668133);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668134);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668135);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668136);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668137);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668138);
    WindowsOptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668139);
    WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WindowsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668140);
    WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668141);
    WindowsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100668142);
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
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385980, XrefRangeEnd = 385984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string SandboxId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385984, XrefRangeEnd = 385988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ClientCredentials ClientCredentials
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 385994, RefRangeEnd = 385995, XrefRangeStart = 385988, XrefRangeEnd = 385994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsServer
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385995, XrefRangeEnd = 385999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EncryptionKey
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385999, XrefRangeEnd = 386003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideCountryCode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386003, XrefRangeEnd = 386007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideLocaleCode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386007, XrefRangeEnd = 386011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeploymentId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386011, XrefRangeEnd = 386015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CacheDirectory
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386015, XrefRangeEnd = 386019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe WindowsRTCOptions RTCOptions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 386025, RefRangeEnd = 386026, XrefRangeStart = 386019, XrefRangeEnd = 386025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_WindowsRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 386060, RefRangeEnd = 386061, XrefRangeStart = 386026, XrefRangeEnd = 386060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(WindowsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WindowsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386061, XrefRangeEnd = 386064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386064, XrefRangeEnd = 386079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
