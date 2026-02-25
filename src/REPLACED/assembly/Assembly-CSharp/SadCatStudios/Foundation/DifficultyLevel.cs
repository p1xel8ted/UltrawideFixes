// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.DifficultyLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation;

public class DifficultyLevel(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_DisplayName;
  private static readonly IntPtr NativeFieldInfoPtr_DrainToZero;
  private static readonly IntPtr NativeFieldInfoPtr_HealAfterBattle;
  private static readonly IntPtr NativeFieldInfoPtr_AdditionalHealingCharges;
  private static readonly IntPtr NativeFieldInfoPtr_HealingChargesRestored;
  private static readonly IntPtr NativeFieldInfoPtr_DisplayNameTranslation;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DifficultyLevel()
  {
    Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (DifficultyLevel));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr);
    DifficultyLevel.NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, nameof (DisplayName));
    DifficultyLevel.NativeFieldInfoPtr_DrainToZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, nameof (DrainToZero));
    DifficultyLevel.NativeFieldInfoPtr_HealAfterBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, nameof (HealAfterBattle));
    DifficultyLevel.NativeFieldInfoPtr_AdditionalHealingCharges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, nameof (AdditionalHealingCharges));
    DifficultyLevel.NativeFieldInfoPtr_HealingChargesRestored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, nameof (HealingChargesRestored));
    DifficultyLevel.NativeFieldInfoPtr_DisplayNameTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, nameof (DisplayNameTranslation));
    DifficultyLevel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr, 100671100);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DifficultyLevel()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DifficultyLevel>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DifficultyLevel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string DisplayName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_DisplayName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool DrainToZero
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_DrainToZero));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_DrainToZero)) = value;
    }
  }

  public unsafe bool HealAfterBattle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_HealAfterBattle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_HealAfterBattle)) = value;
    }
  }

  public unsafe int AdditionalHealingCharges
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_AdditionalHealingCharges));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_AdditionalHealingCharges)) = value;
    }
  }

  public unsafe int HealingChargesRestored
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_HealingChargesRestored));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_HealingChargesRestored)) = value;
    }
  }

  public unsafe ArticyRef DisplayNameTranslation
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_DisplayNameTranslation));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DifficultyLevel.NativeFieldInfoPtr_DisplayNameTranslation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
