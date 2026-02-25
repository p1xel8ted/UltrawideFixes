// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Quests.InventoryManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using SadCatStudios.Foundation;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Quests;

public class InventoryManager(System.IntPtr pointer) : LocalSingletonBehaviour<InventoryManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_upgradeConfig;
  private static readonly System.IntPtr NativeFieldInfoPtr_inventory;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnObjectiveOpened;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnActivityAdded;
  private static readonly System.IntPtr NativeFieldInfoPtr_upgradableControllers;
  private static readonly System.IntPtr NativeFieldInfoPtr_abilityStateController;
  private static readonly System.IntPtr NativeFieldInfoPtr__Articy_Unity_IBaseScriptMethodProvider_IsCalledInForecast_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Void_UInt64_UniTaskCompletionSource_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasItem_Public_Boolean_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SeePDAEntry_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasSeenPDAEntry_Public_Boolean_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AbilityHandler_Private_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ObjectiveHanlder_Private_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoreItemHandler_Private_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Articy_Unity_IBaseScriptMethodProvider_get_IsCalledInForecast_Private_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Articy_Unity_IBaseScriptMethodProvider_set_IsCalledInForecast_Private_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Articy_Replaced_IScriptMethodProvider_NumberOfArcadesBeaten_Private_Virtual_Final_New_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InventoryManager()
  {
    Il2CppClassPointerStore<InventoryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Quests", nameof (InventoryManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr);
    InventoryManager.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (playerReference));
    InventoryManager.NativeFieldInfoPtr_upgradeConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (upgradeConfig));
    InventoryManager.NativeFieldInfoPtr_inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (inventory));
    InventoryManager.NativeFieldInfoPtr_OnObjectiveOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (OnObjectiveOpened));
    InventoryManager.NativeFieldInfoPtr_OnActivityAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (OnActivityAdded));
    InventoryManager.NativeFieldInfoPtr_upgradableControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (upgradableControllers));
    InventoryManager.NativeFieldInfoPtr_abilityStateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (abilityStateController));
    InventoryManager.NativeFieldInfoPtr__Articy_Unity_IBaseScriptMethodProvider_IsCalledInForecast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, "<Articy.Unity.IBaseScriptMethodProvider.IsCalledInForecast>k__BackingField");
    InventoryManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671478);
    InventoryManager.NativeMethodInfoPtr_AddItem_Public_Void_UInt64_UniTaskCompletionSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671479);
    InventoryManager.NativeMethodInfoPtr_RemoveItem_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671480);
    InventoryManager.NativeMethodInfoPtr_HasItem_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671481);
    InventoryManager.NativeMethodInfoPtr_SeePDAEntry_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671482);
    InventoryManager.NativeMethodInfoPtr_HasSeenPDAEntry_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671483);
    InventoryManager.NativeMethodInfoPtr_AbilityHandler_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671484);
    InventoryManager.NativeMethodInfoPtr_ObjectiveHanlder_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671485);
    InventoryManager.NativeMethodInfoPtr_LoreItemHandler_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671486);
    InventoryManager.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671487);
    InventoryManager.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671488 /*0x06002000*/);
    InventoryManager.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671489 /*0x06002001*/);
    InventoryManager.NativeMethodInfoPtr_Articy_Unity_IBaseScriptMethodProvider_get_IsCalledInForecast_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671490 /*0x06002002*/);
    InventoryManager.NativeMethodInfoPtr_Articy_Unity_IBaseScriptMethodProvider_set_IsCalledInForecast_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671491 /*0x06002003*/);
    InventoryManager.NativeMethodInfoPtr_Articy_Replaced_IScriptMethodProvider_NumberOfArcadesBeaten_Private_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671492 /*0x06002004*/);
    InventoryManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, 100671493 /*0x06002005*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94396, XrefRangeEnd = 94403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 94453, RefRangeEnd = 94456, XrefRangeStart = 94403, XrefRangeEnd = 94453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddItem(
    ulong itemId,
    UniTaskCompletionSource newItemWindowClosed = null,
    bool allowPlayingSound = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &itemId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newItemWindowClosed);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allowPlayingSound;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_AddItem_Public_Void_UInt64_UniTaskCompletionSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94456, XrefRangeEnd = 94462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveItem(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_RemoveItem_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94466, RefRangeEnd = 94468, XrefRangeStart = 94462, XrefRangeEnd = 94466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasItem(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_HasItem_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94472, RefRangeEnd = 94474, XrefRangeStart = 94468, XrefRangeEnd = 94472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SeePDAEntry(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_SeePDAEntry_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94478, RefRangeEnd = 94479, XrefRangeStart = 94474, XrefRangeEnd = 94478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasSeenPDAEntry(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_HasSeenPDAEntry_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94505, RefRangeEnd = 94506, XrefRangeStart = 94479, XrefRangeEnd = 94505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AbilityHandler(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_AbilityHandler_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ObjectiveHanlder(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_ObjectiveHanlder_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoreItemHandler(ulong itemId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &itemId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_LoreItemHandler_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94506, XrefRangeEnd = 94536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94536, XrefRangeEnd = 94538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94538, XrefRangeEnd = 94589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool Articy\u002EUnity\u002EIBaseScriptMethodProvider\u002EIsCalledInForecast
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Articy_Unity_IBaseScriptMethodProvider_get_IsCalledInForecast_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Articy_Unity_IBaseScriptMethodProvider_set_IsCalledInForecast_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94589, XrefRangeEnd = 94596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int Articy_Replaced_IScriptMethodProvider_NumberOfArcadesBeaten()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr_Articy_Replaced_IScriptMethodProvider_NumberOfArcadesBeaten_Private_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94596, XrefRangeEnd = 94613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InventoryManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InventoryManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UpgradeConfig upgradeConfig
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_upgradeConfig));
      return num == System.IntPtr.Zero ? (UpgradeConfig) null : Il2CppObjectPool.Get<UpgradeConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_upgradeConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InventoryManager.InventoryData inventory
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_inventory));
      return num == System.IntPtr.Zero ? (InventoryManager.InventoryData) null : Il2CppObjectPool.Get<InventoryManager.InventoryData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_inventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<ulong> OnObjectiveOpened
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_OnObjectiveOpened));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<ulong>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_OnObjectiveOpened), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<ulong> OnActivityAdded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_OnActivityAdded));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<ulong>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_OnActivityAdded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IUpgradableController> upgradableControllers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_upgradableControllers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<IUpgradableController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IUpgradableController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_upgradableControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AbilityStateController abilityStateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_abilityStateController));
      return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr_abilityStateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _Articy_Unity_IBaseScriptMethodProvider_IsCalledInForecast_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr__Articy_Unity_IBaseScriptMethodProvider_IsCalledInForecast_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.NativeFieldInfoPtr__Articy_Unity_IBaseScriptMethodProvider_IsCalledInForecast_k__BackingField)) = value;
    }
  }

  [Serializable]
  public class InventoryData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ArticyVariables;
    private static readonly System.IntPtr NativeFieldInfoPtr_Items;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeenPDAEntires;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static InventoryData()
    {
      Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryManager>.NativeClassPtr, nameof (InventoryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr);
      InventoryManager.InventoryData.NativeFieldInfoPtr_ArticyVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr, nameof (ArticyVariables));
      InventoryManager.InventoryData.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr, nameof (Items));
      InventoryManager.InventoryData.NativeFieldInfoPtr_SeenPDAEntires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr, nameof (SeenPDAEntires));
      InventoryManager.InventoryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr, 100671494 /*0x06002006*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94385, XrefRangeEnd = 94396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryManager.InventoryData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InventoryManager.InventoryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Dictionary<string, Il2CppSystem.Object> ArticyVariables
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.InventoryData.NativeFieldInfoPtr_ArticyVariables));
        return num == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.InventoryData.NativeFieldInfoPtr_ArticyVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<ulong> Items
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.InventoryData.NativeFieldInfoPtr_Items));
        return num == System.IntPtr.Zero ? (HashSet<ulong>) null : Il2CppObjectPool.Get<HashSet<ulong>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.InventoryData.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<ulong> SeenPDAEntires
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.InventoryData.NativeFieldInfoPtr_SeenPDAEntires));
        return num == System.IntPtr.Zero ? (HashSet<ulong>) null : Il2CppObjectPool.Get<HashSet<ulong>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryManager.InventoryData.NativeFieldInfoPtr_SeenPDAEntires), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
