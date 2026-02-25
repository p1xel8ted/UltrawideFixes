// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTakeDamageOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class LogPlayerTakeDamageOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsHitscanAttack_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__HasLineOfSight_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsCriticalHit_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DamageTaken_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__HealthRemaining_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DamageSource_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DamageType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DamageResult_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DamagePosition_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VictimPlayerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VictimPlayerPosition_Public_get_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VictimPlayerViewRotation_Public_get_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackerPlayerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackerPlayerPosition_Public_get_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackerPlayerViewRotation_Public_get_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHitscanAttack_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLineOfSight_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCriticalHit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HitBoneId_DEPRECATED_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageTaken_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HealthRemaining_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageSource_Public_get_AntiCheatCommonPlayerTakeDamageSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageType_Public_get_AntiCheatCommonPlayerTakeDamageType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DamageResult_Public_get_AntiCheatCommonPlayerTakeDamageResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerUseWeaponData_Public_get_LogPlayerUseWeaponData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_LogPlayerUseWeaponData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSincePlayerUseWeaponMs_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DamagePosition_Public_get_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogPlayerTakeDamageOptions()
  {
    Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTakeDamageOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr);
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<VictimPlayerHandle>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<VictimPlayerPosition>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<VictimPlayerViewRotation>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<AttackerPlayerHandle>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<AttackerPlayerPosition>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<AttackerPlayerViewRotation>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsHitscanAttack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<IsHitscanAttack>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HasLineOfSight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<HasLineOfSight>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsCriticalHit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<IsCriticalHit>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<HitBoneId_DEPRECATED>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageTaken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageTaken>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HealthRemaining_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<HealthRemaining>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageSource>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageType>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamageResult>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<PlayerUseWeaponData>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<TimeSincePlayerUseWeaponMs>k__BackingField");
    LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamagePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, "<DamagePosition>k__BackingField");
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672735);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672736);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerPosition_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672737);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672738);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerViewRotation_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672739);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672740);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672741);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672742);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerPosition_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672743);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672744);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerViewRotation_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672745);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672746);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsHitscanAttack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672747);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672748);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HasLineOfSight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672749);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672750);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsCriticalHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672751);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672752);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HitBoneId_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672753);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672754);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageTaken_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672755);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672756);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HealthRemaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672757);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672758);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageSource_Public_get_AntiCheatCommonPlayerTakeDamageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672759);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672760);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageType_Public_get_AntiCheatCommonPlayerTakeDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672761);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672762);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageResult_Public_get_AntiCheatCommonPlayerTakeDamageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672763);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672764);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_PlayerUseWeaponData_Public_get_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672765);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672766);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_TimeSincePlayerUseWeaponMs_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672767);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672768 /*0x06002500*/);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamagePosition_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672769);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672770);
    LogPlayerTakeDamageOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr, 100672771);
  }

  public unsafe System.IntPtr VictimPlayerHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f VictimPlayerPosition
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerPosition_Public_get_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerPosition_Public_set_Void_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat VictimPlayerViewRotation
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_VictimPlayerViewRotation_Public_get_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_VictimPlayerViewRotation_Public_set_Void_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr AttackerPlayerHandle
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f AttackerPlayerPosition
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerPosition_Public_get_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerPosition_Public_set_Void_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat AttackerPlayerViewRotation
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_AttackerPlayerViewRotation_Public_get_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_AttackerPlayerViewRotation_Public_set_Void_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsHitscanAttack
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsHitscanAttack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsHitscanAttack_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool HasLineOfSight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HasLineOfSight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HasLineOfSight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsCriticalHit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_IsCriticalHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_IsCriticalHit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint HitBoneId_DEPRECATED
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HitBoneId_DEPRECATED_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 394042, RefRangeEnd = 394043, XrefRangeStart = 394042, XrefRangeEnd = 394043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HitBoneId_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float DamageTaken
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageTaken_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageTaken_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float HealthRemaining
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_HealthRemaining_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_HealthRemaining_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageSource DamageSource
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageSource_Public_get_AntiCheatCommonPlayerTakeDamageSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonPlayerTakeDamageSource*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageSource_Public_set_Void_AntiCheatCommonPlayerTakeDamageSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageType DamageType
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageType_Public_get_AntiCheatCommonPlayerTakeDamageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonPlayerTakeDamageType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageType_Public_set_Void_AntiCheatCommonPlayerTakeDamageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageResult DamageResult
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamageResult_Public_get_AntiCheatCommonPlayerTakeDamageResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonPlayerTakeDamageResult*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamageResult_Public_set_Void_AntiCheatCommonPlayerTakeDamageResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LogPlayerUseWeaponData PlayerUseWeaponData
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_PlayerUseWeaponData_Public_get_LogPlayerUseWeaponData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (LogPlayerUseWeaponData) null : Il2CppObjectPool.Get<LogPlayerUseWeaponData>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_PlayerUseWeaponData_Public_set_Void_LogPlayerUseWeaponData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint TimeSincePlayerUseWeaponMs
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_TimeSincePlayerUseWeaponMs_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 298986, RefRangeEnd = 298987, XrefRangeStart = 298986, XrefRangeEnd = 298987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_TimeSincePlayerUseWeaponMs_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f DamagePosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_get_DamagePosition_Public_get_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr_set_DamagePosition_Public_set_Void_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogPlayerTakeDamageOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogPlayerTakeDamageOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTakeDamageOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _VictimPlayerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerHandle_k__BackingField)) = value;
    }
  }

  public unsafe Vec3f _VictimPlayerPosition_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField));
      return num == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Quat _VictimPlayerViewRotation_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField));
      return num == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__VictimPlayerViewRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe System.IntPtr _AttackerPlayerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerHandle_k__BackingField)) = value;
    }
  }

  public unsafe Vec3f _AttackerPlayerPosition_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField));
      return num == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Quat _AttackerPlayerViewRotation_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField));
      return num == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__AttackerPlayerViewRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsHitscanAttack_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsHitscanAttack_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsHitscanAttack_k__BackingField)) = value;
    }
  }

  public unsafe bool _HasLineOfSight_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HasLineOfSight_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HasLineOfSight_k__BackingField)) = value;
    }
  }

  public unsafe bool _IsCriticalHit_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsCriticalHit_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__IsCriticalHit_k__BackingField)) = value;
    }
  }

  public unsafe uint _HitBoneId_DEPRECATED_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HitBoneId_DEPRECATED_k__BackingField)) = value;
    }
  }

  public unsafe float _DamageTaken_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageTaken_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageTaken_k__BackingField)) = value;
    }
  }

  public unsafe float _HealthRemaining_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HealthRemaining_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__HealthRemaining_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageSource _DamageSource_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonPlayerTakeDamageSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageSource_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonPlayerTakeDamageSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageSource_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageType _DamageType_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonPlayerTakeDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageType_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonPlayerTakeDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageType_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonPlayerTakeDamageResult _DamageResult_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonPlayerTakeDamageResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageResult_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonPlayerTakeDamageResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamageResult_k__BackingField)) = value;
    }
  }

  public unsafe LogPlayerUseWeaponData _PlayerUseWeaponData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField));
      return num == System.IntPtr.Zero ? (LogPlayerUseWeaponData) null : Il2CppObjectPool.Get<LogPlayerUseWeaponData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__PlayerUseWeaponData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe uint _TimeSincePlayerUseWeaponMs_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__TimeSincePlayerUseWeaponMs_k__BackingField)) = value;
    }
  }

  public unsafe Vec3f _DamagePosition_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamagePosition_k__BackingField));
      return num == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTakeDamageOptions.NativeFieldInfoPtr__DamagePosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
