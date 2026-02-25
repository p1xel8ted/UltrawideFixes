// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Quests.AchievementManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Foundation.SaveData;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Quests;

public class AchievementManager(System.IntPtr pointer) : LocalSingletonBehaviour<AchievementManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_achievementObjectives;
  private static readonly System.IntPtr NativeFieldInfoPtr_inventoryAchievments;
  private static readonly System.IntPtr NativeFieldInfoPtr_notificationCallbacksHolder;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateObjective_Private_Void_ObjectiveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateItemAchievements_Public_Void_HashSet_1_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AchievementManager()
  {
    Il2CppClassPointerStore<AchievementManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Quests", nameof (AchievementManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr);
    AchievementManager.NativeFieldInfoPtr_achievementObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, nameof (achievementObjectives));
    AchievementManager.NativeFieldInfoPtr_inventoryAchievments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, nameof (inventoryAchievments));
    AchievementManager.NativeFieldInfoPtr_notificationCallbacksHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, nameof (notificationCallbacksHolder));
    AchievementManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100671467);
    AchievementManager.NativeMethodInfoPtr_EvaluateObjective_Private_Void_ObjectiveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100671468);
    AchievementManager.NativeMethodInfoPtr_EvaluateItemAchievements_Public_Void_HashSet_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100671469);
    AchievementManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100671470);
    AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100671471);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94270, XrefRangeEnd = 94308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94329, RefRangeEnd = 94331, XrefRangeStart = 94308, XrefRangeEnd = 94329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvaluateObjective(AchievementManager.ObjectiveData objData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_EvaluateObjective_Private_Void_ObjectiveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94356, RefRangeEnd = 94357, XrefRangeStart = 94331, XrefRangeEnd = 94356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvaluateItemAchievements(HashSet<ulong> items)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) items)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_EvaluateItemAchievements_Public_Void_HashSet_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94357, XrefRangeEnd = 94376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AchievementManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94376, XrefRangeEnd = 94385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AchievementManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<AchievementManager.ObjectiveData> achievementObjectives
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementObjectives));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<AchievementManager.ObjectiveData>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementManager.ObjectiveData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_achievementObjectives), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<AchievementManager.InventoryItemsAchievement> inventoryAchievments
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_inventoryAchievments));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<AchievementManager.InventoryItemsAchievement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementManager.InventoryItemsAchievement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_inventoryAchievments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Action<string, Il2CppSystem.Object>>> notificationCallbacksHolder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_notificationCallbacksHolder));
      return num == System.IntPtr.Zero ? (List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Action<string, Il2CppSystem.Object>>>) null : Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Action<string, Il2CppSystem.Object>>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_notificationCallbacksHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ObjectiveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectiveReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_Achievement;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsedVariables;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ObjectiveData()
    {
      Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, nameof (ObjectiveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr);
      AchievementManager.ObjectiveData.NativeFieldInfoPtr_ObjectiveReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr, nameof (ObjectiveReference));
      AchievementManager.ObjectiveData.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr, nameof (Achievement));
      AchievementManager.ObjectiveData.NativeFieldInfoPtr_UsedVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr, nameof (UsedVariables));
      AchievementManager.ObjectiveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr, 100671472);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectiveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.ObjectiveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AchievementManager.ObjectiveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ArticyRef ObjectiveReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.ObjectiveData.NativeFieldInfoPtr_ObjectiveReference));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.ObjectiveData.NativeFieldInfoPtr_ObjectiveReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BaseSaveData.Achievement Achievement
    {
      get
      {
        return *(BaseSaveData.Achievement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.ObjectiveData.NativeFieldInfoPtr_Achievement));
      }
      [param: In] set
      {
        *(BaseSaveData.Achievement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.ObjectiveData.NativeFieldInfoPtr_Achievement)) = value;
      }
    }

    public unsafe List<string> UsedVariables
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.ObjectiveData.NativeFieldInfoPtr_UsedVariables));
        return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.ObjectiveData.NativeFieldInfoPtr_UsedVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class InventoryItemsAchievement(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemsList;
    private static readonly System.IntPtr NativeFieldInfoPtr_Achievement;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static InventoryItemsAchievement()
    {
      Il2CppClassPointerStore<AchievementManager.InventoryItemsAchievement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, nameof (InventoryItemsAchievement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.InventoryItemsAchievement>.NativeClassPtr);
      AchievementManager.InventoryItemsAchievement.NativeFieldInfoPtr_ItemsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.InventoryItemsAchievement>.NativeClassPtr, nameof (ItemsList));
      AchievementManager.InventoryItemsAchievement.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.InventoryItemsAchievement>.NativeClassPtr, nameof (Achievement));
      AchievementManager.InventoryItemsAchievement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.InventoryItemsAchievement>.NativeClassPtr, 100671473);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryItemsAchievement()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.InventoryItemsAchievement>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AchievementManager.InventoryItemsAchievement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ArticyRef ItemsList
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.InventoryItemsAchievement.NativeFieldInfoPtr_ItemsList));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.InventoryItemsAchievement.NativeFieldInfoPtr_ItemsList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BaseSaveData.Achievement Achievement
    {
      get
      {
        return *(BaseSaveData.Achievement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.InventoryItemsAchievement.NativeFieldInfoPtr_Achievement));
      }
      [param: In] set
      {
        *(BaseSaveData.Achievement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.InventoryItemsAchievement.NativeFieldInfoPtr_Achievement)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Quests.AchievementManager+<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_objectiveData;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_String_Object_0;

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr);
      AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr_objectiveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr, nameof (objectiveData));
      AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
      AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr, "<>9__0");
      AchievementManager.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr, 100671474);
      AchievementManager.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr, 100671475);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AchievementManager.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94264, XrefRangeEnd = 94266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__0(string k, Il2CppSystem.Object v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(k);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) v);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AchievementManager.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe AchievementManager.ObjectiveData objectiveData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr_objectiveData));
        return num == System.IntPtr.Zero ? (AchievementManager.ObjectiveData) null : Il2CppObjectPool.Get<AchievementManager.ObjectiveData>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr_objectiveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AchievementManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (AchievementManager) null : Il2CppObjectPool.Get<AchievementManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string, Il2CppSystem.Object> __9__0
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Object>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Quests.AchievementManager+<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_items;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EvaluateItemAchievements_b__0_Internal_Boolean_ArticyObject_0;

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr);
      AchievementManager.__c__DisplayClass7_0.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr, nameof (items));
      AchievementManager.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr, "<>9__0");
      AchievementManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr, 100671476);
      AchievementManager.__c__DisplayClass7_0.NativeMethodInfoPtr__EvaluateItemAchievements_b__0_Internal_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr, 100671477);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AchievementManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94266, XrefRangeEnd = 94270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _EvaluateItemAchievements_b__0(ArticyObject achItem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) achItem)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.__c__DisplayClass7_0.NativeMethodInfoPtr__EvaluateItemAchievements_b__0_Internal_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe HashSet<ulong> items
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass7_0.NativeFieldInfoPtr_items));
        return num == System.IntPtr.Zero ? (HashSet<ulong>) null : Il2CppObjectPool.Get<HashSet<ulong>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass7_0.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<ArticyObject, bool> __9__0
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyObject, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyObject, bool>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementManager.__c__DisplayClass7_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
