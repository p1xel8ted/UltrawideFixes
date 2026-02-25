// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredPointerInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI;

public class RewiredPointerInputModule(System.IntPtr pointer) : BaseInputModule(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kMouseLeftId;
  private static readonly System.IntPtr NativeFieldInfoPtr_kMouseRightId;
  private static readonly System.IntPtr NativeFieldInfoPtr_kMouseMiddleId;
  private static readonly System.IntPtr NativeFieldInfoPtr_kFakeTouchesId;
  private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsStartingId;
  private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsMaxCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsLastId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseInputSourcesList;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPointerData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserDefaultTouchInputSource;
  private static readonly System.IntPtr NativeFieldInfoPtr___m_DefaultInputSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseState;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static RewiredPointerInputModule()
  {
    Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (RewiredPointerInputModule));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr);
    RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kMouseLeftId));
    RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kMouseRightId));
    RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kMouseMiddleId));
    RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kFakeTouchesId));
    RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (customButtonsStartingId));
    RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (customButtonsMaxCount));
    RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (customButtonsLastId));
    RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_MouseInputSourcesList));
    RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_PlayerPointerData));
    RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_UserDefaultTouchInputSource));
    RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (__m_DefaultInputSource));
    RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_MouseState));
    RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668318);
    RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668319);
    RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668320);
    RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668321);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668322);
    RewiredPointerInputModule.NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668323);
    RewiredPointerInputModule.NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668324);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668325);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668326);
    RewiredPointerInputModule.NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668327);
    RewiredPointerInputModule.NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668328);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668329);
    RewiredPointerInputModule.NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668330);
    RewiredPointerInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668331);
    RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668332);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668333);
    RewiredPointerInputModule.NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668334);
    RewiredPointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668335);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668336);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668337);
    RewiredPointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668338);
    RewiredPointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668339);
    RewiredPointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668340);
    RewiredPointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668341);
    RewiredPointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668342);
    RewiredPointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668343);
    RewiredPointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668344);
    RewiredPointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668345);
    RewiredPointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668346);
    RewiredPointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668347);
    RewiredPointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668348);
  }

  public unsafe RewiredPointerInputModule.UnityInputSource defaultInputSource
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 67030, RefRangeEnd = 67033, XrefRangeStart = 67029, XrefRangeEnd = 67030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RewiredPointerInputModule.UnityInputSource) null : Il2CppObjectPool.Get<RewiredPointerInputModule.UnityInputSource>(num3);
    }
  }

  public unsafe IMouseInputSource defaultMouseInputSource
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 67030, RefRangeEnd = 67033, XrefRangeStart = 67030, XrefRangeEnd = 67033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IMouseInputSource) null : Il2CppObjectPool.Get<IMouseInputSource>(num3);
    }
  }

  public unsafe ITouchInputSource defaultTouchInputSource
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 67030, RefRangeEnd = 67033, XrefRangeStart = 67030, XrefRangeEnd = 67033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ITouchInputSource) null : Il2CppObjectPool.Get<ITouchInputSource>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67033, XrefRangeEnd = 67038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsDefaultMouse(IMouseInputSource mouse)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mouse)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 67044, RefRangeEnd = 67056, XrefRangeStart = 67038, XrefRangeEnd = 67044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IMouseInputSource) null : Il2CppObjectPool.Get<IMouseInputSource>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67056, XrefRangeEnd = 67066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveMouseInputSource(IMouseInputSource source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 67075, RefRangeEnd = 67077, XrefRangeStart = 67066, XrefRangeEnd = 67075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddMouseInputSource(IMouseInputSource source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 67082, RefRangeEnd = 67088, XrefRangeStart = 67077, XrefRangeEnd = 67082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetMouseInputSourceCount(int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 67095, RefRangeEnd = 67096, XrefRangeStart = 67088, XrefRangeEnd = 67095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ITouchInputSource) null : Il2CppObjectPool.Get<ITouchInputSource>(num3);
  }

  [CallerCount(0)]
  public unsafe void RemoveTouchInputSource(ITouchInputSource source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67096, XrefRangeEnd = 67102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddTouchInputSource(ITouchInputSource source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe int GetTouchInputSourceCount(int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67102, XrefRangeEnd = 67104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearMouseInputSources()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool isMouseSupported
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67104, XrefRangeEnd = 67111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool IsDefaultPlayer(int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 67154, RefRangeEnd = 67161, XrefRangeStart = 67111, XrefRangeEnd = 67154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetPointerData(
    int playerId,
    int pointerIndex,
    int pointerTypeId,
    out PlayerPointerEventData data,
    bool create,
    PointerEventType pointerEventType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
    numPtr1[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerTypeId;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &create;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerEventType;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PlayerPointerEventData local = ref data;
    System.IntPtr pointer = zero;
    PlayerPointerEventData pointerEventData = pointer == System.IntPtr.Zero ? (PlayerPointerEventData) null : new PlayerPointerEventData(pointer);
    local = pointerEventData;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67161, XrefRangeEnd = 67171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerPointerEventData CreatePointerEventData(
    int playerId,
    int pointerIndex,
    int pointerTypeId,
    PointerEventType pointerEventType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerTypeId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerEventType;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PlayerPointerEventData) null : Il2CppObjectPool.Get<PlayerPointerEventData>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 67177, RefRangeEnd = 67178, XrefRangeStart = 67171, XrefRangeEnd = 67177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemovePointerData(PlayerPointerEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 67194, RefRangeEnd = 67195, XrefRangeStart = 67178, XrefRangeEnd = 67194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerPointerEventData GetTouchPointerEventData(
    int playerId,
    int touchDeviceIndex,
    Touch input,
    out bool pressed,
    out bool released)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &touchDeviceIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref pressed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref released;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PlayerPointerEventData) null : Il2CppObjectPool.Get<PlayerPointerEventData>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67195, XrefRangeEnd = 67235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe RewiredPointerInputModule.MouseState GetMousePointerEventData(
    int playerId,
    int mouseIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseState) null : Il2CppObjectPool.Get<RewiredPointerInputModule.MouseState>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67235, XrefRangeEnd = 67257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerPointerEventData GetLastPointerEventData(
    int playerId,
    int pointerIndex,
    int pointerTypeId,
    bool ignorePointerTypeId,
    PointerEventType pointerEventType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerTypeId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ignorePointerTypeId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerEventType;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PlayerPointerEventData) null : Il2CppObjectPool.Get<PlayerPointerEventData>(num3);
  }

  [CallerCount(0)]
  public static unsafe bool ShouldStartDrag(
    Vector2 pressPos,
    Vector2 currentPos,
    float threshold,
    bool useDragThreshold)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &pressPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &threshold;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &useDragThreshold;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67257, XrefRangeEnd = 67272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessMove(PlayerPointerEventData pointerEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67272, XrefRangeEnd = 67312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessDrag(PlayerPointerEventData pointerEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67312, XrefRangeEnd = 67330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool IsPointerOverGameObject(int pointerTypeId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pointerTypeId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 67365, RefRangeEnd = 67366, XrefRangeStart = 67330, XrefRangeEnd = 67365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearSelection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67366, XrefRangeEnd = 67424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67424, XrefRangeEnd = 67435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeselectIfSelectionChanged(
    GameObject currentOverGo,
    BaseEventData pointerEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentOverGo);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 67444, RefRangeEnd = 67448, XrefRangeStart = 67435, XrefRangeEnd = 67444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PointerEventData.FramePressState StateForMouseButton(
    int playerId,
    int mouseIndex,
    int buttonId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buttonId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PointerEventData.FramePressState*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67448, XrefRangeEnd = 67471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RewiredPointerInputModule()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kMouseLeftId
  {
    get
    {
      int kMouseLeftId;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*) &kMouseLeftId);
      return kMouseLeftId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*) &value);
    }
  }

  public static unsafe int kMouseRightId
  {
    get
    {
      int kMouseRightId;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*) &kMouseRightId);
      return kMouseRightId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*) &value);
    }
  }

  public static unsafe int kMouseMiddleId
  {
    get
    {
      int kMouseMiddleId;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*) &kMouseMiddleId);
      return kMouseMiddleId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*) &value);
    }
  }

  public static unsafe int kFakeTouchesId
  {
    get
    {
      int kFakeTouchesId;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*) &kFakeTouchesId);
      return kFakeTouchesId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*) &value);
    }
  }

  public static unsafe int customButtonsStartingId
  {
    get
    {
      int buttonsStartingId;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId, (void*) &buttonsStartingId);
      return buttonsStartingId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId, (void*) &value);
    }
  }

  public static unsafe int customButtonsMaxCount
  {
    get
    {
      int customButtonsMaxCount;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount, (void*) &customButtonsMaxCount);
      return customButtonsMaxCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount, (void*) &value);
    }
  }

  public static unsafe int customButtonsLastId
  {
    get
    {
      int customButtonsLastId;
      IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId, (void*) &customButtonsLastId);
      return customButtonsLastId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId, (void*) &value);
    }
  }

  public unsafe List<IMouseInputSource> m_MouseInputSourcesList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList));
      return num == System.IntPtr.Zero ? (List<IMouseInputSource>) null : Il2CppObjectPool.Get<List<IMouseInputSource>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>> m_PlayerPointerData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData));
      return num == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>>) null : Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ITouchInputSource m_UserDefaultTouchInputSource
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource));
      return num == System.IntPtr.Zero ? (ITouchInputSource) null : Il2CppObjectPool.Get<ITouchInputSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource));
      return num == System.IntPtr.Zero ? (RewiredPointerInputModule.UnityInputSource) null : Il2CppObjectPool.Get<RewiredPointerInputModule.UnityInputSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RewiredPointerInputModule.MouseState m_MouseState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState));
      return num == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseState) null : Il2CppObjectPool.Get<RewiredPointerInputModule.MouseState>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class MouseState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TrackedButtons;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MouseState()
    {
      Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (MouseState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr);
      RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, nameof (m_TrackedButtons));
      RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668349);
      RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668350);
      RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668351);
      RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668352);
      RewiredPointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668353);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66906, XrefRangeEnd = 66911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AnyPressesThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66911, XrefRangeEnd = 66916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AnyReleasesThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 66935, RefRangeEnd = 66947, XrefRangeStart = 66916, XrefRangeEnd = 66935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RewiredPointerInputModule.ButtonState GetButtonState(int button)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &button
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RewiredPointerInputModule.ButtonState) null : Il2CppObjectPool.Get<RewiredPointerInputModule.ButtonState>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66947, XrefRangeEnd = 66948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetButtonState(
      int button,
      PointerEventData.FramePressState stateForMouseButton,
      PlayerPointerEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &button;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stateForMouseButton;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66948, XrefRangeEnd = 66955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MouseState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe List<RewiredPointerInputModule.ButtonState> m_TrackedButtons
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons));
        return num == System.IntPtr.Zero ? (List<RewiredPointerInputModule.ButtonState>) null : Il2CppObjectPool.Get<List<RewiredPointerInputModule.ButtonState>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class MouseButtonEventData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_buttonState;
    private static readonly System.IntPtr NativeFieldInfoPtr_buttonData;
    private static readonly System.IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MouseButtonEventData()
    {
      Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (MouseButtonEventData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr);
      RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, nameof (buttonState));
      RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, nameof (buttonData));
      RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100668354);
      RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100668355);
      RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100668356);
    }

    [CallerCount(0)]
    public unsafe bool PressedThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 66955, RefRangeEnd = 66968, XrefRangeStart = 66955, XrefRangeEnd = 66955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ReleasedThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MouseButtonEventData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe PointerEventData.FramePressState buttonState
    {
      get
      {
        return *(PointerEventData.FramePressState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState));
      }
      [param: In] set
      {
        *(PointerEventData.FramePressState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState)) = value;
      }
    }

    public unsafe PlayerPointerEventData buttonData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData));
        return num == System.IntPtr.Zero ? (PlayerPointerEventData) null : Il2CppObjectPool.Get<PlayerPointerEventData>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class ButtonState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EventData;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_button_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ButtonState()
    {
      Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (ButtonState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr);
      RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, nameof (m_Button));
      RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, nameof (m_EventData));
      RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668357);
      RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668358);
      RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668359);
      RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668360);
      RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668361);
    }

    public unsafe RewiredPointerInputModule.MouseButtonEventData eventData
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseButtonEventData) null : Il2CppObjectPool.Get<RewiredPointerInputModule.MouseButtonEventData>(num3);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe int button
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ButtonState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int m_Button
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button)) = value;
      }
    }

    public unsafe RewiredPointerInputModule.MouseButtonEventData m_EventData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData));
        return num == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseButtonEventData) null : Il2CppObjectPool.Get<RewiredPointerInputModule.MouseButtonEventData>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public sealed class UnityInputSource(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MousePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MousePositionPrev;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdatedFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryUpdate_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static UnityInputSource()
    {
      Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (UnityInputSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr);
      RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, nameof (m_MousePosition));
      RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, nameof (m_MousePositionPrev));
      RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, nameof (m_LastUpdatedFrame));
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668362);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668363);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668364);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668365);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668366);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668367);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668368);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668369);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668370);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668371);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668372);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668373);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668374);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668375);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_TryUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668376);
      RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668377);
    }

    public virtual unsafe int Rewired\u002EUI\u002EIMouseInputSource\u002EplayerId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66976, XrefRangeEnd = 66979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe int Rewired\u002EUI\u002EITouchInputSource\u002EplayerId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe bool Rewired\u002EUI\u002EIMouseInputSource\u002Eenabled
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66979, XrefRangeEnd = 66983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe bool Rewired\u002EUI\u002EIMouseInputSource\u002Elocked
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66983, XrefRangeEnd = 66987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe int Rewired\u002EUI\u002EIMouseInputSource\u002EbuttonCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66987, XrefRangeEnd = 66990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66990, XrefRangeEnd = 66994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_UI_IMouseInputSource_GetButtonDown(int button)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &button
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66994, XrefRangeEnd = 66998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_UI_IMouseInputSource_GetButtonUp(int button)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &button
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66998, XrefRangeEnd = 67002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Rewired_UI_IMouseInputSource_GetButton(int button)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &button
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Vector2 Rewired\u002EUI\u002EIMouseInputSource\u002EscreenPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67002, XrefRangeEnd = 67006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe Vector2 Rewired\u002EUI\u002EIMouseInputSource\u002EscreenPositionDelta
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67006, XrefRangeEnd = 67009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe Vector2 Rewired\u002EUI\u002EIMouseInputSource\u002EwheelDelta
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67009, XrefRangeEnd = 67013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe bool Rewired\u002EUI\u002EITouchInputSource\u002EtouchSupported
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67013, XrefRangeEnd = 67017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe int Rewired\u002EUI\u002EITouchInputSource\u002EtouchCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67017, XrefRangeEnd = 67021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67021, XrefRangeEnd = 67025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Touch Rewired_UI_ITouchInputSource_GetTouch(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Touch*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67025, XrefRangeEnd = 67028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_TryUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67028, XrefRangeEnd = 67029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnityInputSource()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector2 m_MousePosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition)) = value;
      }
    }

    public unsafe Vector2 m_MousePositionPrev
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev)) = value;
      }
    }

    public unsafe int m_LastUpdatedFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame)) = value;
      }
    }
  }
}
