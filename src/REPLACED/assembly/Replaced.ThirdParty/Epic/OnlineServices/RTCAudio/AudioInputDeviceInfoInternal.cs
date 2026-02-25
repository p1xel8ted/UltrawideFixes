// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioInputDeviceInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

[StructLayout(LayoutKind.Explicit)]
public struct AudioInputDeviceInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultDevice;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceName;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AudioInputDeviceInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public int m_DefaultDevice;
  [FieldOffset(8)]
  public System.IntPtr m_DeviceId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_DeviceName;

  static AudioInputDeviceInfoInternal()
  {
    Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioInputDeviceInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr);
    AudioInputDeviceInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AudioInputDeviceInfoInternal.NativeFieldInfoPtr_m_DefaultDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, nameof (m_DefaultDevice));
    AudioInputDeviceInfoInternal.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, nameof (m_DeviceId));
    AudioInputDeviceInfoInternal.NativeFieldInfoPtr_m_DeviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, nameof (m_DeviceName));
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666346);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666347);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666348);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666349);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666350);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666351);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Void_AudioInputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666352 /*0x06000BF0*/);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666353);
    AudioInputDeviceInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, 100666354);
  }

  public unsafe bool DefaultDevice
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380468, XrefRangeEnd = 380472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380472, XrefRangeEnd = 380476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeviceId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380476, XrefRangeEnd = 380480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380480, XrefRangeEnd = 380484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeviceName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380484, XrefRangeEnd = 380488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380488, XrefRangeEnd = 380492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 380504, RefRangeEnd = 380505, XrefRangeStart = 380492, XrefRangeEnd = 380504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AudioInputDeviceInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Void_AudioInputDeviceInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380505, XrefRangeEnd = 380508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380508, XrefRangeEnd = 380513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioInputDeviceInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
