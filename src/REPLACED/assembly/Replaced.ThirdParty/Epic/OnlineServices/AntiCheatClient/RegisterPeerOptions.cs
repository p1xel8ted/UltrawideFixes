// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.RegisterPeerOptions
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

public class RegisterPeerOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PeerHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientPlatform_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AccountId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IpAddress_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PeerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientType_Public_get_AntiCheatCommonClientType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientPlatform_Public_get_AntiCheatCommonClientPlatform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IpAddress_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RegisterPeerOptions()
  {
    Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (RegisterPeerOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr);
    RegisterPeerOptions.NativeFieldInfoPtr__PeerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, "<PeerHandle>k__BackingField");
    RegisterPeerOptions.NativeFieldInfoPtr__ClientType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, "<ClientType>k__BackingField");
    RegisterPeerOptions.NativeFieldInfoPtr__ClientPlatform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, "<ClientPlatform>k__BackingField");
    RegisterPeerOptions.NativeFieldInfoPtr__AccountId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, "<AccountId>k__BackingField");
    RegisterPeerOptions.NativeFieldInfoPtr__IpAddress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, "<IpAddress>k__BackingField");
    RegisterPeerOptions.NativeMethodInfoPtr_get_PeerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673152);
    RegisterPeerOptions.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673153);
    RegisterPeerOptions.NativeMethodInfoPtr_get_ClientType_Public_get_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673154);
    RegisterPeerOptions.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673155);
    RegisterPeerOptions.NativeMethodInfoPtr_get_ClientPlatform_Public_get_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673156);
    RegisterPeerOptions.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673157);
    RegisterPeerOptions.NativeMethodInfoPtr_get_AccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673158);
    RegisterPeerOptions.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673159);
    RegisterPeerOptions.NativeMethodInfoPtr_get_IpAddress_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673160);
    RegisterPeerOptions.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673161);
    RegisterPeerOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr, 100673162);
  }

  public unsafe System.IntPtr PeerHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_get_PeerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientType ClientType
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_get_ClientType_Public_get_AntiCheatCommonClientType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientPlatform ClientPlatform
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_get_ClientPlatform_Public_get_AntiCheatCommonClientPlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientPlatform*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_get_AccountId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string IpAddress
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_get_IpAddress_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RegisterPeerOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterPeerOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _PeerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__PeerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__PeerHandle_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonClientType _ClientType_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonClientType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__ClientType_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonClientType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__ClientType_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonClientPlatform _ClientPlatform_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonClientPlatform*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__ClientPlatform_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonClientPlatform*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__ClientPlatform_k__BackingField)) = value;
    }
  }

  public unsafe string _AccountId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__AccountId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__AccountId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _IpAddress_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__IpAddress_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterPeerOptions.NativeFieldInfoPtr__IpAddress_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
