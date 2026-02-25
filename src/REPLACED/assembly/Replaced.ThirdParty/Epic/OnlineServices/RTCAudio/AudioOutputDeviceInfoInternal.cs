// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioOutputDeviceInfoInternal
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
public struct AudioOutputDeviceInfoInternal
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AudioOutputDeviceInfo_0;
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

  static AudioOutputDeviceInfoInternal()
  {
    Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioOutputDeviceInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr);
    AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_DefaultDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_DefaultDevice));
    AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_DeviceId));
    AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_DeviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_DeviceName));
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666381 /*0x06000C0D*/);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666382 /*0x06000C0E*/);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666383 /*0x06000C0F*/);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666384 /*0x06000C10*/);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666385);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666386);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Void_AudioOutputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666387);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666388);
    AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100666389);
  }

  public unsafe bool DefaultDevice
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380623, XrefRangeEnd = 380627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380627, XrefRangeEnd = 380631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeviceId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380631, XrefRangeEnd = 380635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380635, XrefRangeEnd = 380639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeviceName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380639, XrefRangeEnd = 380643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380643, XrefRangeEnd = 380647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 380659, RefRangeEnd = 380660, XrefRangeStart = 380647, XrefRangeEnd = 380659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AudioOutputDeviceInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Void_AudioOutputDeviceInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380660, XrefRangeEnd = 380663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380663, XrefRangeEnd = 380668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
