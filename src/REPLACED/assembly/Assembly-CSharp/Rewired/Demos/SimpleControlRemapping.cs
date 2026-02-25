// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.SimpleControlRemapping
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

public class SimpleControlRemapping(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_category;
  private static readonly System.IntPtr NativeFieldInfoPtr_layout;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiCategory;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputMapper;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_textPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_fieldGroupTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_actionGroupTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_controllerNameUIText;
  private static readonly System.IntPtr NativeFieldInfoPtr_statusUIText;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedControllerType;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedControllerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_rows;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerMap_Private_get_ControllerMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controller_Private_get_Controller_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedController_Private_Void_ControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerSelected_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerChanged_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SimpleControlRemapping()
  {
    Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (SimpleControlRemapping));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr);
    SimpleControlRemapping.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (category));
    SimpleControlRemapping.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (layout));
    SimpleControlRemapping.NativeFieldInfoPtr_uiCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (uiCategory));
    SimpleControlRemapping.NativeFieldInfoPtr_inputMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (inputMapper));
    SimpleControlRemapping.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (buttonPrefab));
    SimpleControlRemapping.NativeFieldInfoPtr_textPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (textPrefab));
    SimpleControlRemapping.NativeFieldInfoPtr_fieldGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (fieldGroupTransform));
    SimpleControlRemapping.NativeFieldInfoPtr_actionGroupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (actionGroupTransform));
    SimpleControlRemapping.NativeFieldInfoPtr_controllerNameUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (controllerNameUIText));
    SimpleControlRemapping.NativeFieldInfoPtr_statusUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (statusUIText));
    SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (selectedControllerType));
    SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (selectedControllerId));
    SimpleControlRemapping.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (rows));
    SimpleControlRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670431);
    SimpleControlRemapping.NativeMethodInfoPtr_get_controllerMap_Private_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670432);
    SimpleControlRemapping.NativeMethodInfoPtr_get_controller_Private_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670433);
    SimpleControlRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670434);
    SimpleControlRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670435);
    SimpleControlRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670436);
    SimpleControlRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670437);
    SimpleControlRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670438);
    SimpleControlRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670439);
    SimpleControlRemapping.NativeMethodInfoPtr_SetSelectedController_Private_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670440);
    SimpleControlRemapping.NativeMethodInfoPtr_OnControllerSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670441);
    SimpleControlRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670442);
    SimpleControlRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670443);
    SimpleControlRemapping.NativeMethodInfoPtr_OnControllerChanged_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670444);
    SimpleControlRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670445);
    SimpleControlRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670446);
    SimpleControlRemapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, 100670447);
  }

  public unsafe Player player
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84537, XrefRangeEnd = 84543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
    }
  }

  public unsafe ControllerMap controllerMap
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 84555, RefRangeEnd = 84556, XrefRangeStart = 84543, XrefRangeEnd = 84555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_get_controllerMap_Private_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ControllerMap) null : Il2CppObjectPool.Get<ControllerMap>(num3);
    }
  }

  public unsafe Controller controller
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 84563, RefRangeEnd = 84570, XrefRangeStart = 84556, XrefRangeEnd = 84563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_get_controller_Private_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Controller) null : Il2CppObjectPool.Get<Controller>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84570, XrefRangeEnd = 84610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84610, XrefRangeEnd = 84628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 84683, RefRangeEnd = 84686, XrefRangeStart = 84628, XrefRangeEnd = 84683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_RedrawUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84686, XrefRangeEnd = 84696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_ClearUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84786, RefRangeEnd = 84787, XrefRangeStart = 84696, XrefRangeEnd = 84786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_InitializeUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 84819, RefRangeEnd = 84823, XrefRangeStart = 84787, XrefRangeEnd = 84819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateUIRow(InputAction action, AxisRange actionRange, string label)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(label);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_CreateUIRow_Private_Void_InputAction_AxisRange_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84842, RefRangeEnd = 84844, XrefRangeStart = 84823, XrefRangeEnd = 84842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSelectedController(ControllerType controllerType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &controllerType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_SetSelectedController_Private_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84844, XrefRangeEnd = 84845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerSelected(int controllerType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &controllerType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnControllerSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84845, XrefRangeEnd = 84852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionElementMapToReplaceId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnInputFieldClicked_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84852, XrefRangeEnd = 84856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionElementMapToReplaceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_StartListeningDelayed_Private_IEnumerator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84856, XrefRangeEnd = 84857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnControllerChanged(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnControllerChanged_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84857, XrefRangeEnd = 84858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnInputMapped(InputMapper.InputMappedEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnInputMapped_Private_Void_InputMappedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84858, XrefRangeEnd = 84868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnStopped(InputMapper.StoppedEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84868, XrefRangeEnd = 84879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SimpleControlRemapping()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string category
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SimpleControlRemapping.NativeFieldInfoPtr_category, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SimpleControlRemapping.NativeFieldInfoPtr_category, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string layout
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SimpleControlRemapping.NativeFieldInfoPtr_layout, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SimpleControlRemapping.NativeFieldInfoPtr_layout, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string uiCategory
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SimpleControlRemapping.NativeFieldInfoPtr_uiCategory, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SimpleControlRemapping.NativeFieldInfoPtr_uiCategory, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe InputMapper inputMapper
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_inputMapper));
      return num == System.IntPtr.Zero ? (InputMapper) null : Il2CppObjectPool.Get<InputMapper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_inputMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject buttonPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_buttonPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject textPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_textPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_textPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform fieldGroupTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_fieldGroupTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_fieldGroupTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform actionGroupTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_actionGroupTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_actionGroupTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text controllerNameUIText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_controllerNameUIText));
      return num == System.IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_controllerNameUIText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text statusUIText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_statusUIText));
      return num == System.IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_statusUIText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerType selectedControllerType
  {
    get
    {
      return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerType));
    }
    [param: In] set
    {
      *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerType)) = value;
    }
  }

  public unsafe int selectedControllerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_selectedControllerId)) = value;
    }
  }

  public unsafe List<SimpleControlRemapping.Row> rows
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_rows));
      return num == System.IntPtr.Zero ? (List<SimpleControlRemapping.Row>) null : Il2CppObjectPool.Get<List<SimpleControlRemapping.Row>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
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
      Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, nameof (Row));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr);
      SimpleControlRemapping.Row.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, nameof (action));
      SimpleControlRemapping.Row.NativeFieldInfoPtr_actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, nameof (actionRange));
      SimpleControlRemapping.Row.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, nameof (button));
      SimpleControlRemapping.Row.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, nameof (text));
      SimpleControlRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr, 100670448);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Row()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping.Row>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe InputAction action
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_action));
        return num == System.IntPtr.Zero ? (InputAction) null : Il2CppObjectPool.Get<InputAction>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AxisRange actionRange
    {
      get
      {
        return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_actionRange));
      }
      [param: In] set
      {
        *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_actionRange)) = value;
      }
    }

    public unsafe UnityEngine.UI.Button button
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_button));
        return num == System.IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Text text
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_text));
        return num == System.IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.Row.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Rewired.Demos.SimpleControlRemapping+<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionElementMapId;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0;

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr);
      SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, nameof (index));
      SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_actionElementMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, nameof (actionElementMapId));
      SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
      SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, 100670449);
      SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr, 100670450);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84517, XrefRangeEnd = 84524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RedrawUI_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping.__c__DisplayClass21_0.NativeMethodInfoPtr__RedrawUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_index)) = value;
      }
    }

    public unsafe int actionElementMapId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_actionElementMapId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr_actionElementMapId)) = value;
      }
    }

    public unsafe SimpleControlRemapping __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SimpleControlRemapping) null : Il2CppObjectPool.Get<SimpleControlRemapping>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Rewired.Demos.SimpleControlRemapping+<StartListeningDelayed>d__28")]
  public sealed class _StartListeningDelayed_d__28(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionElementMapToReplaceId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _StartListeningDelayed_d__28()
    {
      Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleControlRemapping>.NativeClassPtr, "<StartListeningDelayed>d__28");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr);
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "<>1__state");
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "<>2__current");
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, "<>4__this");
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, nameof (index));
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_actionElementMapToReplaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, nameof (actionElementMapToReplaceId));
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100670451);
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100670452);
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100670453);
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100670454);
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100670455);
      SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr, 100670456);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _StartListeningDelayed_d__28(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleControlRemapping._StartListeningDelayed_d__28>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84524, XrefRangeEnd = 84532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84532, XrefRangeEnd = 84537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SimpleControlRemapping._StartListeningDelayed_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleControlRemapping __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SimpleControlRemapping) null : Il2CppObjectPool.Get<SimpleControlRemapping>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_index)) = value;
      }
    }

    public unsafe int actionElementMapToReplaceId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_actionElementMapToReplaceId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleControlRemapping._StartListeningDelayed_d__28.NativeFieldInfoPtr_actionElementMapToReplaceId)) = value;
      }
    }
  }
}
