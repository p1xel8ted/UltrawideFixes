// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.SetAudioInputSettingsOptionsInternal
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
public struct SetAudioInputSettingsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Volume;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlatformAEC;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformAEC_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetAudioInputSettingsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_DeviceId;
  [FieldOffset(24)]
  public float m_Volume;
  [FieldOffset(28)]
  public int m_PlatformAEC;

  static SetAudioInputSettingsOptionsInternal()
  {
    Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (SetAudioInputSettingsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr);
    SetAudioInputSettingsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetAudioInputSettingsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    SetAudioInputSettingsOptionsInternal.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, nameof (m_DeviceId));
    SetAudioInputSettingsOptionsInternal.NativeFieldInfoPtr_m_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, nameof (m_Volume));
    SetAudioInputSettingsOptionsInternal.NativeFieldInfoPtr_m_PlatformAEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, nameof (m_PlatformAEC));
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666578);
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666579);
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666580);
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_PlatformAEC_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666581);
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetAudioInputSettingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666582);
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666583);
    SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, 100666584);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381176, XrefRangeEnd = 381180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeviceId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381180, XrefRangeEnd = 381184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float Volume
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 70590, RefRangeEnd = 70591, XrefRangeStart = 70590, XrefRangeEnd = 70591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PlatformAEC
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381184, XrefRangeEnd = 381188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_set_PlatformAEC_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 381200, RefRangeEnd = 381201, XrefRangeStart = 381188, XrefRangeEnd = 381200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SetAudioInputSettingsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetAudioInputSettingsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381201, XrefRangeEnd = 381204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381204, XrefRangeEnd = 381209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetAudioInputSettingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetAudioInputSettingsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
