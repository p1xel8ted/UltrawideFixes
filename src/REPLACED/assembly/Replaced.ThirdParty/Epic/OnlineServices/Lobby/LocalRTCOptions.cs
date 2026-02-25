// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LocalRTCOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class LocalRTCOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Flags_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UseManualAudioInput_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UseManualAudioOutput_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalAudioDeviceInputStartsMuted_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LocalRTCOptionsInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalRTCOptions()
  {
    Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LocalRTCOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr);
    LocalRTCOptions.NativeFieldInfoPtr__Flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<Flags>k__BackingField");
    LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<UseManualAudioInput>k__BackingField");
    LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<UseManualAudioOutput>k__BackingField");
    LocalRTCOptions.NativeFieldInfoPtr__LocalAudioDeviceInputStartsMuted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<LocalAudioDeviceInputStartsMuted>k__BackingField");
    LocalRTCOptions.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669576);
    LocalRTCOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669577);
    LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669578);
    LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669579);
    LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669580);
    LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669581);
    LocalRTCOptions.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669582);
    LocalRTCOptions.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669583);
    LocalRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LocalRTCOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669584);
    LocalRTCOptions.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669585);
    LocalRTCOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100669586);
  }

  public unsafe uint Flags
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UseManualAudioInput
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UseManualAudioOutput
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool LocalAudioDeviceInputStartsMuted
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391001, XrefRangeEnd = 391023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<LocalRTCOptionsInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LocalRTCOptionsInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391023, XrefRangeEnd = 391049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalRTCOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint _Flags_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__Flags_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__Flags_k__BackingField)) = value;
    }
  }

  public unsafe bool _UseManualAudioInput_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioInput_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioInput_k__BackingField)) = value;
    }
  }

  public unsafe bool _UseManualAudioOutput_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioOutput_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioOutput_k__BackingField)) = value;
    }
  }

  public unsafe bool _LocalAudioDeviceInputStartsMuted_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__LocalAudioDeviceInputStartsMuted_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalRTCOptions.NativeFieldInfoPtr__LocalAudioDeviceInputStartsMuted_k__BackingField)) = value;
    }
  }
}
