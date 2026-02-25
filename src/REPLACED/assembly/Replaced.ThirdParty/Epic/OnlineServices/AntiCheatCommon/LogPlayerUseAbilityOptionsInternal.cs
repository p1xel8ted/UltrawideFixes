// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerUseAbilityOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct LogPlayerUseAbilityOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AbilityId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AbilityDurationMs;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AbilityCooldownMs;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AbilityId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AbilityDurationMs_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AbilityCooldownMs_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogPlayerUseAbilityOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PlayerHandle;
  [FieldOffset(16 /*0x10*/)]
  public uint m_AbilityId;
  [FieldOffset(20)]
  public uint m_AbilityDurationMs;
  [FieldOffset(24)]
  public uint m_AbilityCooldownMs;

  static LogPlayerUseAbilityOptionsInternal()
  {
    Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerUseAbilityOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr);
    LogPlayerUseAbilityOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogPlayerUseAbilityOptionsInternal.NativeFieldInfoPtr_m_PlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, nameof (m_PlayerHandle));
    LogPlayerUseAbilityOptionsInternal.NativeFieldInfoPtr_m_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, nameof (m_AbilityId));
    LogPlayerUseAbilityOptionsInternal.NativeFieldInfoPtr_m_AbilityDurationMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, nameof (m_AbilityDurationMs));
    LogPlayerUseAbilityOptionsInternal.NativeFieldInfoPtr_m_AbilityCooldownMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, nameof (m_AbilityCooldownMs));
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672824);
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_AbilityId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672825);
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_AbilityDurationMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672826);
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_AbilityCooldownMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672827);
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerUseAbilityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672828);
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672829);
    LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, 100672830);
  }

  public unsafe System.IntPtr PlayerHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint AbilityId
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_AbilityId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint AbilityDurationMs
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_AbilityDurationMs_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint AbilityCooldownMs
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_set_AbilityCooldownMs_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(LogPlayerUseAbilityOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerUseAbilityOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400606, XrefRangeEnd = 400608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400608, XrefRangeEnd = 400612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerUseAbilityOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
