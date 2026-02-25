// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LocalRTCOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

[StructLayout(LayoutKind.Explicit)]
public struct LocalRTCOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UseManualAudioInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UseManualAudioOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalAudioDeviceInputStartsMuted;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LocalRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_Flags;
  [FieldOffset(8)]
  public int m_UseManualAudioInput;
  [FieldOffset(12)]
  public int m_UseManualAudioOutput;
  [FieldOffset(16 /*0x10*/)]
  public int m_LocalAudioDeviceInputStartsMuted;

  static LocalRTCOptionsInternal()
  {
    Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LocalRTCOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr);
    LocalRTCOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LocalRTCOptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_Flags));
    LocalRTCOptionsInternal.NativeFieldInfoPtr_m_UseManualAudioInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_UseManualAudioInput));
    LocalRTCOptionsInternal.NativeFieldInfoPtr_m_UseManualAudioOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_UseManualAudioOutput));
    LocalRTCOptionsInternal.NativeFieldInfoPtr_m_LocalAudioDeviceInputStartsMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_LocalAudioDeviceInputStartsMuted));
    LocalRTCOptionsInternal.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669587);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669588);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669589);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669590);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669591);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669592);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669593);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669594);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669595);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669596);
    LocalRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100669597);
  }

  public unsafe uint Flags
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UseManualAudioInput
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391049, XrefRangeEnd = 391053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391053, XrefRangeEnd = 391057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UseManualAudioOutput
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391057, XrefRangeEnd = 391061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391061, XrefRangeEnd = 391065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool LocalAudioDeviceInputStartsMuted
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391065, XrefRangeEnd = 391069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391069, XrefRangeEnd = 391073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 391085, RefRangeEnd = 391086, XrefRangeStart = 391073, XrefRangeEnd = 391085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LocalRTCOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LocalRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391086, XrefRangeEnd = 391089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
