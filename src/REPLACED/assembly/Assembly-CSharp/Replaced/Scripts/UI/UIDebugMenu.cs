// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIDebugMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using MessagePipe;
using Replaced.Scripts.Utils;
using SadCatStudios.Character;
using SadCatStudios.Foundation;
using SadCatStudios.Foundation.Events;
using SadCatStudios.UI.Elements;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIDebugMenu(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_levelSelectDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialSavesDropdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_player;
  private static readonly System.IntPtr NativeFieldInfoPtr_sceneList;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialSavesList;
  private static readonly System.IntPtr NativeFieldInfoPtr_fontScaleSelect;
  private static readonly System.IntPtr NativeFieldInfoPtr_reloadToggle;
  private static readonly System.IntPtr NativeFieldInfoPtr_unpausePublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_beginResetPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReloadOnRestart_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonGrid;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_methodNames;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReloadOnRestart_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReloadOnRestart_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FontScale_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentLevel_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__13_0_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__13_1_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__13_6_Private_UniTask_0;

  static UIDebugMenu()
  {
    Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIDebugMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr);
    UIDebugMenu.NativeFieldInfoPtr_levelSelectDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (levelSelectDropdown));
    UIDebugMenu.NativeFieldInfoPtr_specialSavesDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (specialSavesDropdown));
    UIDebugMenu.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (player));
    UIDebugMenu.NativeFieldInfoPtr_sceneList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (sceneList));
    UIDebugMenu.NativeFieldInfoPtr_specialSavesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (specialSavesList));
    UIDebugMenu.NativeFieldInfoPtr_fontScaleSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (fontScaleSelect));
    UIDebugMenu.NativeFieldInfoPtr_reloadToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (reloadToggle));
    UIDebugMenu.NativeFieldInfoPtr_unpausePublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (unpausePublisher));
    UIDebugMenu.NativeFieldInfoPtr_beginResetPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (beginResetPublisher));
    UIDebugMenu.NativeFieldInfoPtr__ReloadOnRestart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, "<ReloadOnRestart>k__BackingField");
    UIDebugMenu.NativeFieldInfoPtr_buttonGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (buttonGrid));
    UIDebugMenu.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (buttonPrefab));
    UIDebugMenu.NativeFieldInfoPtr_methodNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, nameof (methodNames));
    UIDebugMenu.NativeMethodInfoPtr_get_ReloadOnRestart_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670675);
    UIDebugMenu.NativeMethodInfoPtr_set_ReloadOnRestart_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670676);
    UIDebugMenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670677);
    UIDebugMenu.NativeMethodInfoPtr_FontScale_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670678);
    UIDebugMenu.NativeMethodInfoPtr_SelectCurrentLevel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670679);
    UIDebugMenu.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670680);
    UIDebugMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670681);
    UIDebugMenu.NativeMethodInfoPtr__Start_b__13_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670682);
    UIDebugMenu.NativeMethodInfoPtr__Start_b__13_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670683);
    UIDebugMenu.NativeMethodInfoPtr__Start_b__13_6_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, 100670684);
  }

  public static unsafe bool ReloadOnRestart
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87313, XrefRangeEnd = 87315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr_get_ReloadOnRestart_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87315, XrefRangeEnd = 87317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr_set_ReloadOnRestart_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87317, XrefRangeEnd = 87406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FontScale(int selected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &selected
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr_FontScale_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87418, RefRangeEnd = 87420, XrefRangeStart = 87406, XrefRangeEnd = 87418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SelectCurrentLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr_SelectCurrentLevel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87420, XrefRangeEnd = 87422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIDebugMenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87422, XrefRangeEnd = 87451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__13_0(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr__Start_b__13_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87451, XrefRangeEnd = 87490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__13_1(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr__Start_b__13_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87490, XrefRangeEnd = 87506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask _Start_b__13_6()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.NativeMethodInfoPtr__Start_b__13_6_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  public unsafe TMP_Dropdown levelSelectDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_levelSelectDropdown));
      return num == System.IntPtr.Zero ? (TMP_Dropdown) null : Il2CppObjectPool.Get<TMP_Dropdown>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_levelSelectDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Dropdown specialSavesDropdown
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_specialSavesDropdown));
      return num == System.IntPtr.Zero ? (TMP_Dropdown) null : Il2CppObjectPool.Get<TMP_Dropdown>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_specialSavesDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference player
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_player));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIDebugMenuSceneList sceneList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_sceneList));
      return num == System.IntPtr.Zero ? (UIDebugMenuSceneList) null : Il2CppObjectPool.Get<UIDebugMenuSceneList>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_sceneList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpecialSavesList specialSavesList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_specialSavesList));
      return num == System.IntPtr.Zero ? (SpecialSavesList) null : Il2CppObjectPool.Get<SpecialSavesList>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_specialSavesList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIHorizontalSelect fontScaleSelect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_fontScaleSelect));
      return num == System.IntPtr.Zero ? (UIHorizontalSelect) null : Il2CppObjectPool.Get<UIHorizontalSelect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_fontScaleSelect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Toggle reloadToggle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_reloadToggle));
      return num == System.IntPtr.Zero ? (Toggle) null : Il2CppObjectPool.Get<Toggle>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_reloadToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<GameUnpausedEvent> unpausePublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_unpausePublisher));
      return num == System.IntPtr.Zero ? (IPublisher<GameUnpausedEvent>) null : Il2CppObjectPool.Get<IPublisher<GameUnpausedEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_unpausePublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<BeginResetToCheckpointEvent> beginResetPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_beginResetPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<BeginResetToCheckpointEvent>) null : Il2CppObjectPool.Get<IPublisher<BeginResetToCheckpointEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_beginResetPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool _ReloadOnRestart_k__BackingField
  {
    get
    {
      bool restartKBackingField;
      IL2CPP.il2cpp_field_static_get_value(UIDebugMenu.NativeFieldInfoPtr__ReloadOnRestart_k__BackingField, (void*) &restartKBackingField);
      return restartKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIDebugMenu.NativeFieldInfoPtr__ReloadOnRestart_k__BackingField, (void*) &value);
    }
  }

  public unsafe GridLayoutGroup buttonGrid
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_buttonGrid));
      return num == System.IntPtr.Zero ? (GridLayoutGroup) null : Il2CppObjectPool.Get<GridLayoutGroup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_buttonGrid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button buttonPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_buttonPrefab));
      return num == System.IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> methodNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_methodNames));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.NativeFieldInfoPtr_methodNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIDebugMenu+<<Start>b__13_6>d")]
  public sealed class __Start_b__13_6_d : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static __Start_b__13_6_d()
    {
      Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, "<<Start>b__13_6>d");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr);
      UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr, "<>1__state");
      UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr, "<>t__builder");
      UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr, "<>4__this");
      UIDebugMenu.__Start_b__13_6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr, 100670685);
      UIDebugMenu.__Start_b__13_6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr, 100670686);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 87201, RefRangeEnd = 87203, XrefRangeStart = 87195, XrefRangeEnd = 87201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__Start_b__13_6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__Start_b__13_6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public __Start_b__13_6_d(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __Start_b__13_6_d()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDebugMenu.__Start_b__13_6_d>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIDebugMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIDebugMenu) null : Il2CppObjectPool.Get<UIDebugMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__Start_b__13_6_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIDebugMenu+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__13_4;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__13_5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__13_4_Internal_Boolean_PlayerSpawner_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__13_5_Internal_Boolean_PlayerSpawner_0;

    static __c()
    {
      Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr);
      UIDebugMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr, "<>9");
      UIDebugMenu.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr, "<>9__13_4");
      UIDebugMenu.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr, "<>9__13_5");
      UIDebugMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr, 100670688);
      UIDebugMenu.__c.NativeMethodInfoPtr__Start_b__13_4_Internal_Boolean_PlayerSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr, 100670689);
      UIDebugMenu.__c.NativeMethodInfoPtr__Start_b__13_5_Internal_Boolean_PlayerSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr, 100670690);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDebugMenu.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__13_4(PlayerSpawner p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c.NativeMethodInfoPtr__Start_b__13_4_Internal_Boolean_PlayerSpawner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87203, XrefRangeEnd = 87206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Start_b__13_5(PlayerSpawner s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c.NativeMethodInfoPtr__Start_b__13_5_Internal_Boolean_PlayerSpawner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe UIDebugMenu.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIDebugMenu.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UIDebugMenu.__c) null : Il2CppObjectPool.Get<UIDebugMenu.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIDebugMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<PlayerSpawner> __9__13_4
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIDebugMenu.__c.NativeFieldInfoPtr___9__13_4, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Predicate<PlayerSpawner>) null : Il2CppObjectPool.Get<Il2CppSystem.Predicate<PlayerSpawner>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIDebugMenu.__c.NativeFieldInfoPtr___9__13_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<PlayerSpawner> __9__13_5
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIDebugMenu.__c.NativeFieldInfoPtr___9__13_5, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Predicate<PlayerSpawner>) null : Il2CppObjectPool.Get<Il2CppSystem.Predicate<PlayerSpawner>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIDebugMenu.__c.NativeFieldInfoPtr___9__13_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIDebugMenu+<>c__DisplayClass13_0")]
  public sealed class __c__DisplayClass13_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_interactionController;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__2_Internal_UniTask_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__3_Internal_Void_0;

    static __c__DisplayClass13_0()
    {
      Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, "<>c__DisplayClass13_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr);
      UIDebugMenu.__c__DisplayClass13_0.NativeFieldInfoPtr_interactionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr, nameof (interactionController));
      UIDebugMenu.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
      UIDebugMenu.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr, 100670691);
      UIDebugMenu.__c__DisplayClass13_0.NativeMethodInfoPtr__Start_b__2_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr, 100670692);
      UIDebugMenu.__c__DisplayClass13_0.NativeMethodInfoPtr__Start_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr, 100670693);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87206, XrefRangeEnd = 87295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UniTask _Start_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c__DisplayClass13_0.NativeMethodInfoPtr__Start_b__2_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new UniTask(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87295, XrefRangeEnd = 87296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c__DisplayClass13_0.NativeMethodInfoPtr__Start_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CharacterInteractionController interactionController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__c__DisplayClass13_0.NativeFieldInfoPtr_interactionController));
        return num == System.IntPtr.Zero ? (CharacterInteractionController) null : Il2CppObjectPool.Get<CharacterInteractionController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__c__DisplayClass13_0.NativeFieldInfoPtr_interactionController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIDebugMenu __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIDebugMenu) null : Il2CppObjectPool.Get<UIDebugMenu>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIDebugMenu+<>c__DisplayClass13_1")]
  public sealed class __c__DisplayClass13_1(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_player;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__7_Internal_Void_0;

    static __c__DisplayClass13_1()
    {
      Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDebugMenu>.NativeClassPtr, "<>c__DisplayClass13_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_1>.NativeClassPtr);
      UIDebugMenu.__c__DisplayClass13_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_1>.NativeClassPtr, nameof (player));
      UIDebugMenu.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_1>.NativeClassPtr, 100670694);
      UIDebugMenu.__c__DisplayClass13_1.NativeMethodInfoPtr__Start_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_1>.NativeClassPtr, 100670695);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDebugMenu.__c__DisplayClass13_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87296, XrefRangeEnd = 87313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDebugMenu.__c__DisplayClass13_1.NativeMethodInfoPtr__Start_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject player
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__c__DisplayClass13_1.NativeFieldInfoPtr_player));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDebugMenu.__c__DisplayClass13_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
