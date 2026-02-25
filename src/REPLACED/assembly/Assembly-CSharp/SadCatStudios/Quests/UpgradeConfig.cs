// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Quests.UpgradeConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Quests;

public class UpgradeConfig(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ManaGeneration;
  private static readonly IntPtr NativeFieldInfoPtr_HealPerUse;
  private static readonly IntPtr NativeFieldInfoPtr_HealSlots;
  private static readonly IntPtr NativeFieldInfoPtr_OverdriveGain;
  private static readonly IntPtr NativeFieldInfoPtr_PickaxeEnergyGain;
  private static readonly IntPtr NativeFieldInfoPtr_HealthIncrease;
  private static readonly IntPtr NativeFieldInfoPtr_AutoHealPerUse;
  private static readonly IntPtr NativeMethodInfoPtr_ApplyUpgrade_Public_Void_GuidReference_StatType_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UpgradeConfig()
  {
    Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Quests", nameof (UpgradeConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr);
    UpgradeConfig.NativeFieldInfoPtr_ManaGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (ManaGeneration));
    UpgradeConfig.NativeFieldInfoPtr_HealPerUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (HealPerUse));
    UpgradeConfig.NativeFieldInfoPtr_HealSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (HealSlots));
    UpgradeConfig.NativeFieldInfoPtr_OverdriveGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (OverdriveGain));
    UpgradeConfig.NativeFieldInfoPtr_PickaxeEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (PickaxeEnergyGain));
    UpgradeConfig.NativeFieldInfoPtr_HealthIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (HealthIncrease));
    UpgradeConfig.NativeFieldInfoPtr_AutoHealPerUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, nameof (AutoHealPerUse));
    UpgradeConfig.NativeMethodInfoPtr_ApplyUpgrade_Public_Void_GuidReference_StatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, 100671523);
    UpgradeConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr, 100671524);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94920, RefRangeEnd = 94922, XrefRangeStart = 94873, XrefRangeEnd = 94920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyUpgrade(GuidReference playerReference, StatType upgradeType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerReference);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &upgradeType;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpgradeConfig.NativeMethodInfoPtr_ApplyUpgrade_Public_Void_GuidReference_StatType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UpgradeConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpgradeConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float ManaGeneration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_ManaGeneration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_ManaGeneration)) = value;
    }
  }

  public unsafe float HealPerUse
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_HealPerUse));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_HealPerUse)) = value;
    }
  }

  public unsafe float HealSlots
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_HealSlots));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_HealSlots)) = value;
    }
  }

  public unsafe float OverdriveGain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_OverdriveGain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_OverdriveGain)) = value;
    }
  }

  public unsafe float PickaxeEnergyGain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_PickaxeEnergyGain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_PickaxeEnergyGain)) = value;
    }
  }

  public unsafe int HealthIncrease
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_HealthIncrease));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_HealthIncrease)) = value;
    }
  }

  public unsafe float AutoHealPerUse
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_AutoHealPerUse));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeConfig.NativeFieldInfoPtr_AutoHealPerUse)) = value;
    }
  }
}
