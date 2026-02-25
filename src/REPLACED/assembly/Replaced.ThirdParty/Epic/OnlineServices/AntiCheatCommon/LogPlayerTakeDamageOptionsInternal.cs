// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTakeDamageOptionsInternal
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
public struct LogPlayerTakeDamageOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VictimPlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VictimPlayerPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VictimPlayerViewRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackerPlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackerPlayerPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackerPlayerViewRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsHitscanAttack;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HasLineOfSight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsCriticalHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HitBoneId_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageTaken;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HealthRemaining;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DamageResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerUseWeaponData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeSincePlayerUseWeaponMs;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DamagePosition;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_LogPlayerUseWeaponData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogPlayerTakeDamageOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_VictimPlayerHandle;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_VictimPlayerPosition;
  [FieldOffset(24)]
  public System.IntPtr m_VictimPlayerViewRotation;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_AttackerPlayerHandle;
  [FieldOffset(40)]
  public System.IntPtr m_AttackerPlayerPosition;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_AttackerPlayerViewRotation;
  [FieldOffset(56)]
  public int m_IsHitscanAttack;
  [FieldOffset(60)]
  public int m_HasLineOfSight;
  [FieldOffset(64 /*0x40*/)]
  public int m_IsCriticalHit;
  [FieldOffset(68)]
  public uint m_HitBoneId_DEPRECATED;
  [FieldOffset(72)]
  public float m_DamageTaken;
  [FieldOffset(76)]
  public float m_HealthRemaining;
  [FieldOffset(80 /*0x50*/)]
  public AntiCheatCommonPlayerTakeDamageSource m_DamageSource;
  [FieldOffset(84)]
  public AntiCheatCommonPlayerTakeDamageType m_DamageType;
  [FieldOffset(88)]
  public AntiCheatCommonPlayerTakeDamageResult m_DamageResult;
  [FieldOffset(96 /*0x60*/)]
  public System.IntPtr m_PlayerUseWeaponData;
  [FieldOffset(104)]
  public uint m_TimeSincePlayerUseWeaponMs;
  [FieldOffset(112 /*0x70*/)]
  public System.IntPtr m_DamagePosition;

  static LogPlayerTakeDamageOptionsInternal()
  {
    Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTakeDamageOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr);
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_VictimPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_VictimPlayerHandle));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_VictimPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_VictimPlayerPosition));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_VictimPlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_VictimPlayerViewRotation));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_AttackerPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_AttackerPlayerHandle));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_AttackerPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_AttackerPlayerPosition));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_AttackerPlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_AttackerPlayerViewRotation));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_IsHitscanAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_IsHitscanAttack));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_HasLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_HasLineOfSight));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_IsCriticalHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_IsCriticalHit));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_HitBoneId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_HitBoneId_DEPRECATED));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageTaken));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_HealthRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_HealthRemaining));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageSource));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageType));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamageResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamageResult));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_PlayerUseWeaponData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_PlayerUseWeaponData));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_TimeSincePlayerUseWeaponMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_TimeSincePlayerUseWeaponMs));
    LogPlayerTakeDamageOptionsInternal.NativeFieldInfoPtr_m_DamagePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, nameof (m_DamagePosition));
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672772);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672773);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672774);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672775);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672776);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672777);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672778);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672779);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672780);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672781);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672782);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672783);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672784);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672785);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672786);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672787);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672788);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672789);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerTakeDamageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672790);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672791);
    LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, 100672792);
  }

  public unsafe System.IntPtr VictimPlayerHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f VictimPlayerPosition
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400491, RefRangeEnd = 400492, XrefRangeStart = 400485, XrefRangeEnd = 400491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat VictimPlayerViewRotation
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400498, RefRangeEnd = 400499, XrefRangeStart = 400492, XrefRangeEnd = 400498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr AttackerPlayerHandle
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f AttackerPlayerPosition
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400505, RefRangeEnd = 400506, XrefRangeStart = 400499, XrefRangeEnd = 400505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat AttackerPlayerViewRotation
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400512, RefRangeEnd = 400513, XrefRangeStart = 400506, XrefRangeEnd = 400512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsHitscanAttack
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400513, XrefRangeEnd = 400517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool HasLineOfSight
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400517, XrefRangeEnd = 400521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsCriticalHit
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400521, XrefRangeEnd = 400525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint HitBoneId_DEPRECATED
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 394042, RefRangeEnd = 394043, XrefRangeStart = 394042, XrefRangeEnd = 394043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float DamageTaken
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float HealthRemaining
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageSource DamageSource
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageType DamageType
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageResult DamageResult
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LogPlayerUseWeaponData PlayerUseWeaponData
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400531, RefRangeEnd = 400532, XrefRangeStart = 400525, XrefRangeEnd = 400531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_LogPlayerUseWeaponData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint TimeSincePlayerUseWeaponMs
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 298986, RefRangeEnd = 298987, XrefRangeStart = 298986, XrefRangeEnd = 298987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f DamagePosition
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400538, RefRangeEnd = 400539, XrefRangeStart = 400532, XrefRangeEnd = 400538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400557, RefRangeEnd = 400558, XrefRangeStart = 400539, XrefRangeEnd = 400557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogPlayerTakeDamageOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerTakeDamageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400558, XrefRangeEnd = 400561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400561, XrefRangeEnd = 400572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerTakeDamageOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
