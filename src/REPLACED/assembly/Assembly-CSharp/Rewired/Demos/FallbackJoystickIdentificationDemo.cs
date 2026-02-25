// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.FallbackJoystickIdentificationDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class FallbackJoystickIdentificationDemo(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_windowWidth;
  private static readonly IntPtr NativeFieldInfoPtr_windowHeight;
  private static readonly IntPtr NativeFieldInfoPtr_inputDelay;
  private static readonly IntPtr NativeFieldInfoPtr_identifyRequired;
  private static readonly IntPtr NativeFieldInfoPtr_joysticksToIdentify;
  private static readonly IntPtr NativeFieldInfoPtr_nextInputAllowedTime;
  private static readonly IntPtr NativeFieldInfoPtr_style;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly IntPtr NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;
  private static readonly IntPtr NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetInputDelay_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FallbackJoystickIdentificationDemo()
  {
    Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (FallbackJoystickIdentificationDemo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr);
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (windowWidth));
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (windowHeight));
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_inputDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (inputDelay));
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_identifyRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (identifyRequired));
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_joysticksToIdentify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (joysticksToIdentify));
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_nextInputAllowedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (nextInputAllowedTime));
    FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, nameof (style));
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670346);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670347);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670348);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670349);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_SetInputDelay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670350);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670351);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670352);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670353);
    FallbackJoystickIdentificationDemo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100670354);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83413, XrefRangeEnd = 83433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83433, XrefRangeEnd = 83434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickConnected(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JoystickDisconnected(ControllerStatusChangedEventArgs args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 83450, RefRangeEnd = 83453, XrefRangeStart = 83434, XrefRangeEnd = 83450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void IdentifyAllJoysticks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83453, XrefRangeEnd = 83454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInputDelay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_SetInputDelay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83454, XrefRangeEnd = 83486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83486, XrefRangeEnd = 83524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawDialogWindow(int windowId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &windowId
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FallbackJoystickIdentificationDemo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float windowWidth
  {
    get
    {
      float windowWidth;
      IL2CPP.il2cpp_field_static_get_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowWidth, (void*) &windowWidth);
      return windowWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowWidth, (void*) &value);
    }
  }

  public static unsafe float windowHeight
  {
    get
    {
      float windowHeight;
      IL2CPP.il2cpp_field_static_get_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowHeight, (void*) &windowHeight);
      return windowHeight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowHeight, (void*) &value);
    }
  }

  public static unsafe float inputDelay
  {
    get
    {
      float inputDelay;
      IL2CPP.il2cpp_field_static_get_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_inputDelay, (void*) &inputDelay);
      return inputDelay;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_inputDelay, (void*) &value);
    }
  }

  public unsafe bool identifyRequired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_identifyRequired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_identifyRequired)) = value;
    }
  }

  public unsafe Queue<Joystick> joysticksToIdentify
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_joysticksToIdentify));
      return num == IntPtr.Zero ? (Queue<Joystick>) null : Il2CppObjectPool.Get<Queue<Joystick>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_joysticksToIdentify), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float nextInputAllowedTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_nextInputAllowedTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_nextInputAllowedTime)) = value;
    }
  }

  public unsafe GUIStyle style
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_style));
      return num == IntPtr.Zero ? (GUIStyle) null : Il2CppObjectPool.Get<GUIStyle>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
