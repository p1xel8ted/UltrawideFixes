// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public class WindowsOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Reserved_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ProductId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SandboxId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientCredentials_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsServer_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EncryptionKey_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OverrideCountryCode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DeploymentId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Flags_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CacheDirectory_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RTCOptions_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SandboxId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientCredentials_Public_get_ClientCredentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EncryptionKey_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideCountryCode_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideLocaleCode_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_PlatformFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheDirectory_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TickBudgetInMilliseconds_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RTCOptions_Public_get_WindowsRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_WindowsRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static WindowsOptions()
  {
    Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (WindowsOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr);
    WindowsOptions.NativeFieldInfoPtr__Reserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<Reserved>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__ProductId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<ProductId>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__SandboxId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<SandboxId>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__ClientCredentials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<ClientCredentials>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__IsServer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<IsServer>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__EncryptionKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<EncryptionKey>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__OverrideCountryCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<OverrideCountryCode>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<OverrideLocaleCode>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__DeploymentId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<DeploymentId>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__Flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<Flags>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__CacheDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<CacheDirectory>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<TickBudgetInMilliseconds>k__BackingField");
    WindowsOptions.NativeFieldInfoPtr__RTCOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<RTCOptions>k__BackingField");
    WindowsOptions.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668100);
    WindowsOptions.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668101);
    WindowsOptions.NativeMethodInfoPtr_get_ProductId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668102);
    WindowsOptions.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668103);
    WindowsOptions.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668104);
    WindowsOptions.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668105);
    WindowsOptions.NativeMethodInfoPtr_get_ClientCredentials_Public_get_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668106);
    WindowsOptions.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668107);
    WindowsOptions.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668108);
    WindowsOptions.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668109);
    WindowsOptions.NativeMethodInfoPtr_get_EncryptionKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668110);
    WindowsOptions.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668111);
    WindowsOptions.NativeMethodInfoPtr_get_OverrideCountryCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668112);
    WindowsOptions.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668113);
    WindowsOptions.NativeMethodInfoPtr_get_OverrideLocaleCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668114);
    WindowsOptions.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668115);
    WindowsOptions.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668116);
    WindowsOptions.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668117);
    WindowsOptions.NativeMethodInfoPtr_get_Flags_Public_get_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668118);
    WindowsOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668119);
    WindowsOptions.NativeMethodInfoPtr_get_CacheDirectory_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668120);
    WindowsOptions.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668121);
    WindowsOptions.NativeMethodInfoPtr_get_TickBudgetInMilliseconds_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668122);
    WindowsOptions.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668123);
    WindowsOptions.NativeMethodInfoPtr_get_RTCOptions_Public_get_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668124);
    WindowsOptions.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668125);
    WindowsOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100668126);
  }

  public unsafe System.IntPtr Reserved
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_ProductId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string SandboxId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ClientCredentials ClientCredentials
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_ClientCredentials_Public_get_ClientCredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClientCredentials) null : Il2CppObjectPool.Get<ClientCredentials>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsServer
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EncryptionKey
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_EncryptionKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideCountryCode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_OverrideCountryCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideLocaleCode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_OverrideLocaleCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeploymentId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PlatformFlags Flags
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_Flags_Public_get_PlatformFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlatformFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CacheDirectory
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_CacheDirectory_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint TickBudgetInMilliseconds
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_TickBudgetInMilliseconds_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 298986, RefRangeEnd = 298987, XrefRangeStart = 298986, XrefRangeEnd = 298987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe WindowsRTCOptions RTCOptions
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_RTCOptions_Public_get_WindowsRTCOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (WindowsRTCOptions) null : Il2CppObjectPool.Get<WindowsRTCOptions>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_WindowsRTCOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WindowsOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _Reserved_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Reserved_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Reserved_k__BackingField)) = value;
    }
  }

  public unsafe string _ProductId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ProductId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ProductId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _SandboxId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__SandboxId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__SandboxId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ClientCredentials _ClientCredentials_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ClientCredentials_k__BackingField));
      return num == System.IntPtr.Zero ? (ClientCredentials) null : Il2CppObjectPool.Get<ClientCredentials>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ClientCredentials_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsServer_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__IsServer_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__IsServer_k__BackingField)) = value;
    }
  }

  public unsafe string _EncryptionKey_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__EncryptionKey_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__EncryptionKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _OverrideCountryCode_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideCountryCode_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideCountryCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _OverrideLocaleCode_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _DeploymentId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__DeploymentId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__DeploymentId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe PlatformFlags _Flags_k__BackingField
  {
    get
    {
      return *(PlatformFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Flags_k__BackingField));
    }
    [param: In] set
    {
      *(PlatformFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Flags_k__BackingField)) = value;
    }
  }

  public unsafe string _CacheDirectory_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__CacheDirectory_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__CacheDirectory_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe uint _TickBudgetInMilliseconds_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField)) = value;
    }
  }

  public unsafe WindowsRTCOptions _RTCOptions_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__RTCOptions_k__BackingField));
      return num == System.IntPtr.Zero ? (WindowsRTCOptions) null : Il2CppObjectPool.Get<WindowsRTCOptions>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__RTCOptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
