// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.Window
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
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class Window(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_content;
  private static readonly System.IntPtr NativeFieldInfoPtr__initialized;
  private static readonly System.IntPtr NativeFieldInfoPtr__id;
  private static readonly System.IntPtr NativeFieldInfoPtr__rectTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr__titleText;
  private static readonly System.IntPtr NativeFieldInfoPtr__contentText;
  private static readonly System.IntPtr NativeFieldInfoPtr__defaultUIElement;
  private static readonly System.IntPtr NativeFieldInfoPtr__updateCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr__isFocusedCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr__timer;
  private static readonly System.IntPtr NativeFieldInfoPtr__canvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastUISelection;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_hasFocus_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_titleText_Public_get_TMP_Text_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_contentText_Public_get_List_1_TMP_Text_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultUIElement_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultUIElement_Public_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_updateCallback_Public_get_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_updateCallback_Public_set_Void_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timer_Public_get_Timer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_initialized_Protected_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Int32_Func_2_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateButton_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_UnityAction_UnityAction_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTitleText_Public_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTitleText_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContentText_Public_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContentTextHeight_Public_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContentText_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUpdateCallback_Public_Void_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateText_Private_Void_GameObject_byref_TMP_Text_String_UIPivot_UIAnchor_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateImage_Private_Void_GameObject_String_UIPivot_UIAnchor_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateButton_Private_GameObject_GameObject_String_UIAnchor_UIPivot_Vector2_byref_ButtonInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableAsync_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckUISelection_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RestoreDefaultOrLastUISelection_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Window()
  {
    Il2CppClassPointerStore<Window>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (Window));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window>.NativeClassPtr);
    Window.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (backgroundImage));
    Window.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (content));
    Window.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_initialized));
    Window.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_id));
    Window.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_rectTransform));
    Window.NativeFieldInfoPtr__titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_titleText));
    Window.NativeFieldInfoPtr__contentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_contentText));
    Window.NativeFieldInfoPtr__defaultUIElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_defaultUIElement));
    Window.NativeFieldInfoPtr__updateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_updateCallback));
    Window.NativeFieldInfoPtr__isFocusedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_isFocusedCallback));
    Window.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_timer));
    Window.NativeFieldInfoPtr__canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (_canvasGroup));
    Window.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (cancelCallback));
    Window.NativeFieldInfoPtr_lastUISelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (lastUISelection));
    Window.NativeMethodInfoPtr_get_hasFocus_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670092);
    Window.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670093);
    Window.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670094);
    Window.NativeMethodInfoPtr_get_titleText_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670095);
    Window.NativeMethodInfoPtr_get_contentText_Public_get_List_1_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670096);
    Window.NativeMethodInfoPtr_get_defaultUIElement_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670097);
    Window.NativeMethodInfoPtr_set_defaultUIElement_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670098);
    Window.NativeMethodInfoPtr_get_updateCallback_Public_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670099);
    Window.NativeMethodInfoPtr_set_updateCallback_Public_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670100);
    Window.NativeMethodInfoPtr_get_timer_Public_get_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670101);
    Window.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670102);
    Window.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670103);
    Window.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670104);
    Window.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670105);
    Window.NativeMethodInfoPtr_get_initialized_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670106);
    Window.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670107);
    Window.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670108);
    Window.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670109);
    Window.NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670110);
    Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670111);
    Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670112);
    Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670113);
    Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670114);
    Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670115);
    Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670116);
    Window.NativeMethodInfoPtr_CreateButton_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_UnityAction_UnityAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670117);
    Window.NativeMethodInfoPtr_GetTitleText_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670118);
    Window.NativeMethodInfoPtr_SetTitleText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670119);
    Window.NativeMethodInfoPtr_GetContentText_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670120);
    Window.NativeMethodInfoPtr_GetContentTextHeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670121);
    Window.NativeMethodInfoPtr_SetContentText_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670122);
    Window.NativeMethodInfoPtr_SetUpdateCallback_Public_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670123);
    Window.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670124);
    Window.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670125);
    Window.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670126);
    Window.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670127);
    Window.NativeMethodInfoPtr_CreateText_Private_Void_GameObject_byref_TMP_Text_String_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670128);
    Window.NativeMethodInfoPtr_CreateImage_Private_Void_GameObject_String_UIPivot_UIAnchor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670129);
    Window.NativeMethodInfoPtr_CreateButton_Private_GameObject_GameObject_String_UIAnchor_UIPivot_Vector2_byref_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670130);
    Window.NativeMethodInfoPtr_OnEnableAsync_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670131);
    Window.NativeMethodInfoPtr_CheckUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670132);
    Window.NativeMethodInfoPtr_RestoreDefaultOrLastUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670133);
    Window.NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670134);
    Window.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100670135);
  }

  public unsafe bool hasFocus
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_hasFocus_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int id
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16660, RefRangeEnd = 16661, XrefRangeStart = 16660, XrefRangeEnd = 16661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe RectTransform rectTransform
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 80442, RefRangeEnd = 80450, XrefRangeStart = 80434, XrefRangeEnd = 80442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num3);
    }
  }

  public unsafe TMP_Text titleText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_titleText_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num3);
    }
  }

  public unsafe List<TMP_Text> contentText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_contentText_Public_get_List_1_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<TMP_Text>) null : Il2CppObjectPool.Get<List<TMP_Text>>(num3);
    }
  }

  public unsafe GameObject defaultUIElement
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_defaultUIElement_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_defaultUIElement_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Action<int> updateCallback
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_updateCallback_Public_get_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num3);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_updateCallback_Public_set_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Window.Timer timer
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_timer_Public_get_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Window.Timer) null : Il2CppObjectPool.Get<Window.Timer>(num3);
    }
  }

  public unsafe int width
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80457, XrefRangeEnd = 80459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80459, XrefRangeEnd = 80464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int height
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80464, XrefRangeEnd = 80466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80466, XrefRangeEnd = 80471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool initialized
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_get_initialized_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80472, XrefRangeEnd = 80475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80476, RefRangeEnd = 80477, XrefRangeStart = 80475, XrefRangeEnd = 80476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Window.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80492, RefRangeEnd = 80493, XrefRangeStart = 80477, XrefRangeEnd = 80492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize(int id, Il2CppSystem.Func<int, bool> isFocusedCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) isFocusedCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Window.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80493, XrefRangeEnd = 80496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSize(int width, int height)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80496, XrefRangeEnd = 80501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateTitleText(GameObject prefab, Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 80510, RefRangeEnd = 80524, XrefRangeStart = 80501, XrefRangeEnd = 80510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateTitleText(GameObject prefab, Vector2 offset, string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateTitleText_Public_Void_GameObject_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80524, XrefRangeEnd = 80530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddContentText(
    GameObject prefab,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 80548, RefRangeEnd = 80568, XrefRangeStart = 80530, XrefRangeEnd = 80548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddContentText(
    GameObject prefab,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset,
    string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentText_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 80582, RefRangeEnd = 80585, XrefRangeStart = 80568, XrefRangeEnd = 80582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddContentImage(
    GameObject prefab,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 80582, RefRangeEnd = 80585, XrefRangeStart = 80582, XrefRangeEnd = 80585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddContentImage(
    GameObject prefab,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset,
    string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_AddContentImage_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 80613, RefRangeEnd = 80625, XrefRangeStart = 80585, XrefRangeEnd = 80613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateButton(
    GameObject prefab,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset,
    string buttonText,
    UnityAction confirmCallback,
    UnityAction cancelCallback,
    bool setDefault)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(buttonText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) confirmCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cancelCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &setDefault;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateButton_Public_Void_GameObject_UIPivot_UIAnchor_Vector2_String_UnityAction_UnityAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80625, XrefRangeEnd = 80630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetTitleText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_GetTitleText_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80630, XrefRangeEnd = 80634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTitleText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetTitleText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80634, XrefRangeEnd = 80645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetContentText(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_GetContentText_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80657, RefRangeEnd = 80658, XrefRangeStart = 80645, XrefRangeEnd = 80657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetContentTextHeight(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_GetContentTextHeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 80668, RefRangeEnd = 80676, XrefRangeStart = 80658, XrefRangeEnd = 80668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContentText(string text, int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetContentText_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUpdateCallback(Il2CppSystem.Action<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetUpdateCallback_Public_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78981, RefRangeEnd = 78982, XrefRangeStart = 78981, XrefRangeEnd = 78982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void TakeInputFocus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Window.NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80676, XrefRangeEnd = 80678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Enable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Window.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80678, XrefRangeEnd = 80680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Window.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Cancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Window.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 80711, RefRangeEnd = 80715, XrefRangeStart = 80680, XrefRangeEnd = 80711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateText(
    GameObject prefab,
    ref TMP_Text textComponent,
    string name,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textComponent);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateText_Private_Void_GameObject_byref_TMP_Text_String_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref TMP_Text local = ref textComponent;
    System.IntPtr pointer = ptr;
    TMP_Text tmpText = pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    local = tmpText;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80715, XrefRangeEnd = 80727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateImage(
    GameObject prefab,
    string name,
    UIPivot pivot,
    UIAnchor anchor,
    Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateImage_Private_Void_GameObject_String_UIPivot_UIAnchor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80759, RefRangeEnd = 80760, XrefRangeStart = 80727, XrefRangeEnd = 80759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject CreateButton(
    GameObject prefab,
    string name,
    UIAnchor anchor,
    UIPivot pivot,
    Vector2 offset,
    out ButtonInfo buttonInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CreateButton_Private_GameObject_GameObject_String_UIAnchor_UIPivot_Vector2_byref_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ButtonInfo local = ref buttonInfo;
    System.IntPtr pointer = zero;
    ButtonInfo buttonInfo1 = pointer == System.IntPtr.Zero ? (ButtonInfo) null : new ButtonInfo(pointer);
    local = buttonInfo1;
    System.IntPtr num4 = num3;
    return num4 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num4);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80760, XrefRangeEnd = 80764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator OnEnableAsync()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_OnEnableAsync_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80788, RefRangeEnd = 80789, XrefRangeStart = 80764, XrefRangeEnd = 80788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckUISelection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_CheckUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80789, XrefRangeEnd = 80796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestoreDefaultOrLastUISelection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_RestoreDefaultOrLastUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 80808, RefRangeEnd = 80811, XrefRangeStart = 80796, XrefRangeEnd = 80808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUISelection(GameObject selection)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selection)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79045, RefRangeEnd = 79046, XrefRangeStart = 79045, XrefRangeEnd = 79046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Window()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Window.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Image backgroundImage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_backgroundImage));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_backgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject content
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_content));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__initialized)) = value;
    }
  }

  public unsafe int _id
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__id));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__id)) = value;
    }
  }

  public unsafe RectTransform _rectTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__rectTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text _titleText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__titleText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__titleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<TMP_Text> _contentText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__contentText));
      return num == System.IntPtr.Zero ? (List<TMP_Text>) null : Il2CppObjectPool.Get<List<TMP_Text>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__contentText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject _defaultUIElement
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__defaultUIElement));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__defaultUIElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<int> _updateCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__updateCallback));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__updateCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Func<int, bool> _isFocusedCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__isFocusedCallback));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<int, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<int, bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__isFocusedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Window.Timer _timer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__timer));
      return num == System.IntPtr.Zero ? (Window.Timer) null : Il2CppObjectPool.Get<Window.Timer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup _canvasGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__canvasGroup));
      return num == System.IntPtr.Zero ? (CanvasGroup) null : Il2CppObjectPool.Get<CanvasGroup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr__canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityAction cancelCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_cancelCallback));
      return num == System.IntPtr.Zero ? (UnityAction) null : Il2CppObjectPool.Get<UnityAction>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject lastUISelection
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_lastUISelection));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window.NativeFieldInfoPtr_lastUISelection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Timer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__started;
    private static readonly System.IntPtr NativeFieldInfoPtr_end;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_started_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_finished_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_remaining_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

    static Timer()
    {
      Il2CppClassPointerStore<Window.Timer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Window>.NativeClassPtr, nameof (Timer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr);
      Window.Timer.NativeFieldInfoPtr__started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, nameof (_started));
      Window.Timer.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, nameof (end));
      Window.Timer.NativeMethodInfoPtr_get_started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100670136);
      Window.Timer.NativeMethodInfoPtr_get_finished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100670137);
      Window.Timer.NativeMethodInfoPtr_get_remaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100670138);
      Window.Timer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100670139);
      Window.Timer.NativeMethodInfoPtr_Start_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100670140);
      Window.Timer.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr, 100670141);
    }

    public unsafe bool started
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_get_started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool finished
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 80398, RefRangeEnd = 80405, XrefRangeStart = 80397, XrefRangeEnd = 80398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_get_finished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float remaining
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 80406, RefRangeEnd = 80413, XrefRangeStart = 80405, XrefRangeEnd = 80406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_get_remaining_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Timer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window.Timer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 80414, RefRangeEnd = 80422, XrefRangeStart = 80413, XrefRangeEnd = 80414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start(float length)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &length
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_Start_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 80422, RefRangeEnd = 80425, XrefRangeStart = 80422, XrefRangeEnd = 80422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window.Timer.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool _started
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr__started));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr__started)) = value;
      }
    }

    public unsafe float end
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr_end));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window.Timer.NativeFieldInfoPtr_end)) = value;
      }
    }
  }

  [ObfuscatedName("Rewired.UI.ControlMapper.Window+<OnEnableAsync>d__64")]
  public sealed class _OnEnableAsync_d__64(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _OnEnableAsync_d__64()
    {
      Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Window>.NativeClassPtr, "<OnEnableAsync>d__64");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr);
      Window._OnEnableAsync_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, "<>1__state");
      Window._OnEnableAsync_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, "<>2__current");
      Window._OnEnableAsync_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, "<>4__this");
      Window._OnEnableAsync_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100670142);
      Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100670143);
      Window._OnEnableAsync_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100670144);
      Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100670145);
      Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100670146);
      Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr, 100670147);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _OnEnableAsync_d__64(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window._OnEnableAsync_d__64>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80425, XrefRangeEnd = 80429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80429, XrefRangeEnd = 80434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Window._OnEnableAsync_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Window __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (Window) null : Il2CppObjectPool.Get<Window>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Window._OnEnableAsync_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
