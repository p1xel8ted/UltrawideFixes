// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.SimpleCombinedKeyboardMouseRemapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.Demos;

public class SimpleCombinedKeyboardMouseRemapping(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_category;
  private static readonly System.IntPtr NativeFieldInfoPtr_layout;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiCategory;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputMapper_keyboard;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputMapper_mouse;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_textPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_fieldGroupTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionGroupTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_controllerNameUIText;
  private static readonly System.IntPtr NativeFieldInfoPtr_statusUIText;
  private static readonly System.IntPtr NativeFieldInfoPtr_rows;
  private static readonly System.IntPtr NativeFieldInfoPtr__replaceTargetMapping;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_ControllerMap_ControllerMap_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SimpleCombinedKeyboardMouseRemapping()
  {
    Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (SimpleCombinedKeyboardMouseRemapping));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr);
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (category));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (layout));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_uiCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (uiCategory));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (inputMapper_keyboard));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (inputMapper_mouse));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (buttonPrefab));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_textPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (textPrefab));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_fieldGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (fieldGroupTransform));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_actionGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (actionGroupTransform));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_controllerNameUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (controllerNameUIText));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_statusUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (statusUIText));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (rows));
    SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr__replaceTargetMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (_replaceTargetMapping));
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670410);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670411);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670412);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670413);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670414);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670415);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670416);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670417);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_ControllerMap_ControllerMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670418);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670419);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670420);
    SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, 100670421);
  }

  public unsafe Player player
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 84230, RefRangeEnd = 84231, XrefRangeStart = 84224, XrefRangeEnd = 84230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84231, XrefRangeEnd = 84271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84271, XrefRangeEnd = 84276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84324, RefRangeEnd = 84326, XrefRangeStart = 84276, XrefRangeEnd = 84324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84326, XrefRangeEnd = 84333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84423, RefRangeEnd = 84424, XrefRangeStart = 84333, XrefRangeEnd = 84423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 84456, RefRangeEnd = 84460, XrefRangeStart = 84424, XrefRangeEnd = 84456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateUIRow(InputAction action, AxisRange actionRange, string label)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(label);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84484, RefRangeEnd = 84485, XrefRangeStart = 84460, XrefRangeEnd = 84484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionElementMapToReplaceId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84485, XrefRangeEnd = 84489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator StartListeningDelayed(
    int index,
    ControllerMap keyboardMap,
    ControllerMap mouseMap,
    int actionElementMapToReplaceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyboardMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mouseMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &actionElementMapToReplaceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_ControllerMap_ControllerMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84489, XrefRangeEnd = 84493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnInputMapped(InputMapper.InputMappedEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84493, XrefRangeEnd = 84503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnStopped(InputMapper.StoppedEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84503, XrefRangeEnd = 84517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SimpleCombinedKeyboardMouseRemapping()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string category
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_category, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_category, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string layout
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_layout, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_layout, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string uiCategory
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_uiCategory, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_uiCategory, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe InputMapper inputMapper_keyboard
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_keyboard));
      return num == System.IntPtr.Zero ? (InputMapper) null : Il2CppObjectPool.Get<InputMapper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_keyboard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputMapper inputMapper_mouse
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_mouse));
      return num == System.IntPtr.Zero ? (InputMapper) null : Il2CppObjectPool.Get<InputMapper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_inputMapper_mouse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject buttonPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_buttonPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject textPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_textPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_textPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform fieldGroupTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_fieldGroupTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_fieldGroupTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform actionGroupTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_actionGroupTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_actionGroupTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text controllerNameUIText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_controllerNameUIText));
      return num == System.IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_controllerNameUIText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text statusUIText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_statusUIText));
      return num == System.IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_statusUIText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SimpleCombinedKeyboardMouseRemapping.Row> rows
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_rows));
      return num == System.IntPtr.Zero ? (List<SimpleCombinedKeyboardMouseRemapping.Row>) null : Il2CppObjectPool.Get<List<SimpleCombinedKeyboardMouseRemapping.Row>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public SimpleCombinedKeyboardMouseRemapping.TargetMapping _replaceTargetMapping
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr__replaceTargetMapping);
      return new SimpleCombinedKeyboardMouseRemapping.TargetMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.NativeFieldInfoPtr__replaceTargetMapping), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public class Row(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_action;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_button;
    private static readonly System.IntPtr NativeFieldInfoPtr_text;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Row()
    {
      Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (Row));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr);
      SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, nameof (action));
      SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, nameof (actionRange));
      SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, nameof (button));
      SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, nameof (text));
      SimpleCombinedKeyboardMouseRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr, 100670422);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Row()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.Row>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe InputAction action
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_action));
        return num == System.IntPtr.Zero ? (InputAction) null : Il2CppObjectPool.Get<InputAction>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AxisRange actionRange
    {
      get
      {
        return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_actionRange));
      }
      [param: In] set
      {
        *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_actionRange)) = value;
      }
    }

    public unsafe UnityEngine.UI.Button button
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_button));
        return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Text text
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_text));
        return num == System.IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.Row.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public sealed class TargetMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionElementMapId;

    static TargetMapping()
    {
      Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, nameof (TargetMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr);
      SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_controllerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, nameof (controllerMap));
      SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr, nameof (actionElementMapId));
    }

    public TargetMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TargetMapping()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.TargetMapping>.NativeClassPtr))
    {
    }

    public unsafe ControllerMap controllerMap
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_controllerMap));
        return num == System.IntPtr.Zero ? (ControllerMap) null : Il2CppObjectPool.Get<ControllerMap>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_controllerMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int actionElementMapId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_actionElementMapId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.TargetMapping.NativeFieldInfoPtr_actionElementMapId)) = value;
      }
    }
  }

  [ObfuscatedName("Rewired.Demos.SimpleCombinedKeyboardMouseRemapping+<>c__DisplayClass17_0")]
  public sealed class __c__DisplayClass17_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionElementMapId;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0;

    static __c__DisplayClass17_0()
    {
      Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "<>c__DisplayClass17_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr);
      SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, nameof (index));
      SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, nameof (actionElementMapId));
      SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
      SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, 100670423);
      SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr, 100670424);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass17_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84209, XrefRangeEnd = 84211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RedrawUI_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
      }
    }

    public unsafe int actionElementMapId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_actionElementMapId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr_actionElementMapId)) = value;
      }
    }

    public unsafe SimpleCombinedKeyboardMouseRemapping __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SimpleCombinedKeyboardMouseRemapping) null : Il2CppObjectPool.Get<SimpleCombinedKeyboardMouseRemapping>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Rewired.Demos.SimpleCombinedKeyboardMouseRemapping+<StartListeningDelayed>d__22")]
  public sealed class _StartListeningDelayed_d__22(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeFieldInfoPtr_keyboardMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionElementMapToReplaceId;
    private static readonly System.IntPtr NativeFieldInfoPtr_mouseMap;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _StartListeningDelayed_d__22()
    {
      Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping>.NativeClassPtr, "<StartListeningDelayed>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr);
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "<>1__state");
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "<>2__current");
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, "<>4__this");
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, nameof (index));
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_keyboardMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, nameof (keyboardMap));
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_actionElementMapToReplaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, nameof (actionElementMapToReplaceId));
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_mouseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, nameof (mouseMap));
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100670425);
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100670426);
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100670427);
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100670428);
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100670429);
      SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr, 100670430);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _StartListeningDelayed_d__22(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84211, XrefRangeEnd = 84219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84219, XrefRangeEnd = 84224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleCombinedKeyboardMouseRemapping __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SimpleCombinedKeyboardMouseRemapping) null : Il2CppObjectPool.Get<SimpleCombinedKeyboardMouseRemapping>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_index)) = value;
      }
    }

    public unsafe ControllerMap keyboardMap
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_keyboardMap));
        return num == System.IntPtr.Zero ? (ControllerMap) null : Il2CppObjectPool.Get<ControllerMap>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_keyboardMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int actionElementMapToReplaceId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_actionElementMapToReplaceId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_actionElementMapToReplaceId)) = value;
      }
    }

    public unsafe ControllerMap mouseMap
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_mouseMap));
        return num == System.IntPtr.Zero ? (ControllerMap) null : Il2CppObjectPool.Get<ControllerMap>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleCombinedKeyboardMouseRemapping._StartListeningDelayed_d__22.NativeFieldInfoPtr_mouseMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
