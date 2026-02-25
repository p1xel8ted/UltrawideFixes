// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

public class GetAudioInputDeviceByIndexOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__DeviceInfoIndex_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceInfoIndex_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceInfoIndex_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GetAudioInputDeviceByIndexOptions()
  {
    Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (GetAudioInputDeviceByIndexOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr);
    GetAudioInputDeviceByIndexOptions.NativeFieldInfoPtr__DeviceInfoIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, "<DeviceInfoIndex>k__BackingField");
    GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_get_DeviceInfoIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, 100666407);
    GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_set_DeviceInfoIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, 100666408);
    GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, 100666409);
  }

  public unsafe uint DeviceInfoIndex
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_get_DeviceInfoIndex_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_set_DeviceInfoIndex_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GetAudioInputDeviceByIndexOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint _DeviceInfoIndex_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetAudioInputDeviceByIndexOptions.NativeFieldInfoPtr__DeviceInfoIndex_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetAudioInputDeviceByIndexOptions.NativeFieldInfoPtr__DeviceInfoIndex_k__BackingField)) = value;
    }
  }
}
