// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.SetAudioOutputSettingsOptionsInternal
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
public struct SetAudioOutputSettingsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Volume;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetAudioOutputSettingsOptions_0;
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

  static SetAudioOutputSettingsOptionsInternal()
  {
    Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (SetAudioOutputSettingsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr);
    SetAudioOutputSettingsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetAudioOutputSettingsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    SetAudioOutputSettingsOptionsInternal.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, nameof (m_DeviceId));
    SetAudioOutputSettingsOptionsInternal.NativeFieldInfoPtr_m_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, nameof (m_Volume));
    SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, 100666592 /*0x06000CE0*/);
    SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, 100666593);
    SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, 100666594);
    SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetAudioOutputSettingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, 100666595);
    SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, 100666596);
    SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, 100666597);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381209, XrefRangeEnd = 381213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeviceId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381213, XrefRangeEnd = 381217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 381225, RefRangeEnd = 381226, XrefRangeStart = 381217, XrefRangeEnd = 381225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SetAudioOutputSettingsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetAudioOutputSettingsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381226, XrefRangeEnd = 381229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381229, XrefRangeEnd = 381234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetAudioOutputSettingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetAudioOutputSettingsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
