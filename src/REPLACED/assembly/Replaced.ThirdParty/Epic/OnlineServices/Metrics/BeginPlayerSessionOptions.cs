// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.BeginPlayerSessionOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics;

public class BeginPlayerSessionOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AccountId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DisplayName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ControllerType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ServerIp_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__GameSessionId_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_BeginPlayerSessionOptionsAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_BeginPlayerSessionOptionsAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ControllerType_Public_get_UserControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ControllerType_Public_set_Void_UserControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerIp_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerIp_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameSessionId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_GameSessionId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BeginPlayerSessionOptions()
  {
    Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (BeginPlayerSessionOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr);
    BeginPlayerSessionOptions.NativeFieldInfoPtr__AccountId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, "<AccountId>k__BackingField");
    BeginPlayerSessionOptions.NativeFieldInfoPtr__DisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, "<DisplayName>k__BackingField");
    BeginPlayerSessionOptions.NativeFieldInfoPtr__ControllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, "<ControllerType>k__BackingField");
    BeginPlayerSessionOptions.NativeFieldInfoPtr__ServerIp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, "<ServerIp>k__BackingField");
    BeginPlayerSessionOptions.NativeFieldInfoPtr__GameSessionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, "<GameSessionId>k__BackingField");
    BeginPlayerSessionOptions.NativeMethodInfoPtr_get_AccountId_Public_get_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668749);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_set_AccountId_Public_set_Void_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668750);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668751);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668752);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_get_ControllerType_Public_get_UserControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668753);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_set_ControllerType_Public_set_Void_UserControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668754);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_get_ServerIp_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668755);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_set_ServerIp_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668756);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_get_GameSessionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668757);
    BeginPlayerSessionOptions.NativeMethodInfoPtr_set_GameSessionId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668758);
    BeginPlayerSessionOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr, 100668759);
  }

  public unsafe BeginPlayerSessionOptionsAccountId AccountId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_get_AccountId_Public_get_BeginPlayerSessionOptionsAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (BeginPlayerSessionOptionsAccountId) null : Il2CppObjectPool.Get<BeginPlayerSessionOptionsAccountId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_set_AccountId_Public_set_Void_BeginPlayerSessionOptionsAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe UserControllerType ControllerType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_get_ControllerType_Public_get_UserControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(UserControllerType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_set_ControllerType_Public_set_Void_UserControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ServerIp
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_get_ServerIp_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_set_ServerIp_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string GameSessionId
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_get_GameSessionId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr_set_GameSessionId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BeginPlayerSessionOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeginPlayerSessionOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BeginPlayerSessionOptionsAccountId _AccountId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__AccountId_k__BackingField));
      return num == System.IntPtr.Zero ? (BeginPlayerSessionOptionsAccountId) null : Il2CppObjectPool.Get<BeginPlayerSessionOptionsAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__AccountId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _DisplayName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__DisplayName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__DisplayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe UserControllerType _ControllerType_k__BackingField
  {
    get
    {
      return *(UserControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__ControllerType_k__BackingField));
    }
    [param: In] set
    {
      *(UserControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__ControllerType_k__BackingField)) = value;
    }
  }

  public unsafe string _ServerIp_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__ServerIp_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__ServerIp_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _GameSessionId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__GameSessionId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptions.NativeFieldInfoPtr__GameSessionId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
