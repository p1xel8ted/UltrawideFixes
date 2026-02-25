// Decompiled with JetBrains decompiler
// Type: UnityEngine.Screen
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Screen(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequestOrientation_Private_Static_Void_ScreenOrientation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_orientation_Public_Static_set_Void_ScreenOrientation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mainWindowDisplayInfo_Public_Static_get_DisplayInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMainWindowDisplayInfo_Private_Static_DisplayInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMainWindowDisplayInfo_Injected_Private_Static_Void_byref_DisplayInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_resolutions_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0;
  private static readonly Screen.get_sleepTimeoutDelegate get_sleepTimeoutDelegateField;
  private static readonly Screen.set_sleepTimeoutDelegate set_sleepTimeoutDelegateField;
  private static readonly Screen.IsOrientationEnabledDelegate IsOrientationEnabledDelegateField;
  private static readonly Screen.SetOrientationEnabledDelegate SetOrientationEnabledDelegateField;
  private static readonly Screen.set_fullScreenDelegate set_fullScreenDelegateField;
  private static readonly Screen.set_fullScreenModeDelegate set_fullScreenModeDelegateField;
  private static readonly Screen.SetMSAASamplesDelegate SetMSAASamplesDelegateField;
  private static readonly Screen.GetMSAASamplesDelegate GetMSAASamplesDelegateField;
  private static readonly Screen.GetDisplayLayoutImplDelegate GetDisplayLayoutImplDelegateField;
  private static readonly Screen.get_brightnessDelegate get_brightnessDelegateField;
  private static readonly Screen.set_brightnessDelegate set_brightnessDelegateField;
  private static readonly Screen.get_safeArea_InjectedDelegate get_safeArea_InjectedDelegateField;
  private static readonly Screen.get_cutouts_InjectedDelegate get_cutouts_InjectedDelegateField;
  private static readonly Screen.GetMainWindowPosition_InjectedDelegate GetMainWindowPosition_InjectedDelegateField;
  private static readonly Screen.MoveMainWindowImpl_InjectedDelegate MoveMainWindowImpl_InjectedDelegateField;

  static Screen()
  {
    Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Screen));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
    Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664676);
    Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664677);
    Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664678);
    Screen.NativeMethodInfoPtr_RequestOrientation_Private_Static_Void_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664679);
    Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664680);
    Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664681);
    Screen.NativeMethodInfoPtr_set_orientation_Public_Static_set_Void_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664682);
    Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664683);
    Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664684);
    Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664685);
    Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664686);
    Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664687);
    Screen.NativeMethodInfoPtr_get_mainWindowDisplayInfo_Public_Static_get_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664688 /*0x06000570*/);
    Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Private_Static_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664689);
    Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664690);
    Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664691);
    Screen.NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664692);
    Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Injected_Private_Static_Void_byref_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664693);
    Screen.NativeMethodInfoPtr_get_resolutions_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664694);
    Screen.get_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.get_sleepTimeoutDelegate>("UnityEngine.Screen::get_sleepTimeout");
    Screen.set_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.set_sleepTimeoutDelegate>("UnityEngine.Screen::set_sleepTimeout");
    Screen.IsOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.IsOrientationEnabledDelegate>("UnityEngine.Screen::IsOrientationEnabled");
    Screen.SetOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.SetOrientationEnabledDelegate>("UnityEngine.Screen::SetOrientationEnabled");
    Screen.set_fullScreenDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenDelegate>("UnityEngine.Screen::set_fullScreen");
    Screen.set_fullScreenModeDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenModeDelegate>("UnityEngine.Screen::set_fullScreenMode");
    Screen.SetMSAASamplesDelegateField = IL2CPP.ResolveICall<Screen.SetMSAASamplesDelegate>("UnityEngine.Screen::SetMSAASamples");
    Screen.GetMSAASamplesDelegateField = IL2CPP.ResolveICall<Screen.GetMSAASamplesDelegate>("UnityEngine.Screen::GetMSAASamples");
    Screen.GetDisplayLayoutImplDelegateField = IL2CPP.ResolveICall<Screen.GetDisplayLayoutImplDelegate>("UnityEngine.Screen::GetDisplayLayoutImpl");
    Screen.get_brightnessDelegateField = IL2CPP.ResolveICall<Screen.get_brightnessDelegate>("UnityEngine.Screen::get_brightness");
    Screen.set_brightnessDelegateField = IL2CPP.ResolveICall<Screen.set_brightnessDelegate>("UnityEngine.Screen::set_brightness");
    Screen.get_safeArea_InjectedDelegateField = IL2CPP.ResolveICall<Screen.get_safeArea_InjectedDelegate>("UnityEngine.Screen::get_safeArea_Injected");
    Screen.get_cutouts_InjectedDelegateField = IL2CPP.ResolveICall<Screen.get_cutouts_InjectedDelegate>("UnityEngine.Screen::get_cutouts_Injected");
    Screen.GetMainWindowPosition_InjectedDelegateField = IL2CPP.ResolveICall<Screen.GetMainWindowPosition_InjectedDelegate>("UnityEngine.Screen::GetMainWindowPosition_Injected");
    Screen.MoveMainWindowImpl_InjectedDelegateField = IL2CPP.ResolveICall<Screen.MoveMainWindowImpl_InjectedDelegate>("UnityEngine.Screen::MoveMainWindowImpl_Injected");
  }

  public static unsafe int width
  {
    [CallerCount(43), CachedScanResults(RefRangeStart = 422989, RefRangeEnd = 423032, XrefRangeStart = 422987, XrefRangeEnd = 422989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe int height
  {
    [CallerCount(54), CachedScanResults(RefRangeStart = 423034, RefRangeEnd = 423088, XrefRangeStart = 423032, XrefRangeEnd = 423034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float dpi
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 423090, RefRangeEnd = 423096, XrefRangeStart = 423088, XrefRangeEnd = 423090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423096, XrefRangeEnd = 423098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RequestOrientation(ScreenOrientation orient)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &orient
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_RequestOrientation_Private_Static_Void_ScreenOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 423100, RefRangeEnd = 423106, XrefRangeStart = 423098, XrefRangeEnd = 423100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScreenOrientation GetScreenOrientation()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ScreenOrientation*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe ScreenOrientation orientation
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 423100, RefRangeEnd = 423106, XrefRangeStart = 423100, XrefRangeEnd = 423106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ScreenOrientation*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 423114, RefRangeEnd = 423116, XrefRangeStart = 423106, XrefRangeEnd = 423114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_set_orientation_Public_Static_set_Void_ScreenOrientation_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Resolution currentResolution
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 423118, RefRangeEnd = 423125, XrefRangeStart = 423116, XrefRangeEnd = 423118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Resolution*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe bool fullScreen
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 423127, RefRangeEnd = 423129, XrefRangeStart = 423125, XrefRangeEnd = 423127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => Screen.set_fullScreenDelegateField(value);
  }

  public static unsafe FullScreenMode fullScreenMode
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 423131, RefRangeEnd = 423136, XrefRangeStart = 423129, XrefRangeEnd = 423131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FullScreenMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => Screen.set_fullScreenModeDelegateField(value);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423138, RefRangeEnd = 423139, XrefRangeStart = 423136, XrefRangeEnd = 423138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetResolution(
    int width,
    int height,
    FullScreenMode fullscreenMode,
    RefreshRate preferredRefreshRate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullscreenMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &preferredRefreshRate;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423141, RefRangeEnd = 423142, XrefRangeStart = 423139, XrefRangeEnd = 423141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetResolution(int width, int height, FullScreenMode fullscreenMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullscreenMode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe DisplayInfo mainWindowDisplayInfo
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 423144, RefRangeEnd = 423146, XrefRangeStart = 423142, XrefRangeEnd = 423144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_mainWindowDisplayInfo_Public_Static_get_DisplayInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new DisplayInfo(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423146, XrefRangeEnd = 423148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DisplayInfo GetMainWindowDisplayInfo()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Private_Static_DisplayInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new DisplayInfo(pointer);
  }

  public static unsafe Il2CppStructArray<Resolution> resolutions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423154, RefRangeEnd = 423155, XrefRangeStart = 423148, XrefRangeEnd = 423154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<Resolution>) null : Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423155, XrefRangeEnd = 423157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_currentResolution_Injected(out Resolution ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423157, XrefRangeEnd = 423159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetResolution_Injected(
    int width,
    int height,
    FullScreenMode fullscreenMode,
    [In] ref RefreshRate preferredRefreshRate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullscreenMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref preferredRefreshRate;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423159, XrefRangeEnd = 423161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Injected_Private_Static_Void_byref_DisplayInfo_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    ref DisplayInfo local = ref ret;
    System.IntPtr pointer = zero;
    DisplayInfo displayInfo = pointer == System.IntPtr.Zero ? (DisplayInfo) null : new DisplayInfo(pointer);
    local = displayInfo;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423161, XrefRangeEnd = 423163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_resolutions_Injected(out BlittableArrayWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_resolutions_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static int sleepTimeout
  {
    get => Screen.get_sleepTimeoutDelegateField();
    set => Screen.set_sleepTimeoutDelegateField(value);
  }

  public static bool IsOrientationEnabled(EnabledOrientation orient)
  {
    return Screen.IsOrientationEnabledDelegateField(orient);
  }

  public static void SetOrientationEnabled(EnabledOrientation orient, bool enabled)
  {
    Screen.SetOrientationEnabledDelegateField(orient, enabled);
  }

  public static bool autorotateToPortrait
  {
    get => Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
    set => Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
  }

  public static bool autorotateToPortraitUpsideDown
  {
    get => Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
    set => Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown, value);
  }

  public static bool autorotateToLandscapeLeft
  {
    get => Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
    set => Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft, value);
  }

  public static bool autorotateToLandscapeRight
  {
    get => Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
    set => Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight, value);
  }

  public static Rect safeArea
  {
    get
    {
      Rect ret;
      Screen.get_safeArea_Injected(out ret);
      return ret;
    }
  }

  public static Il2CppStructArray<Rect> cutouts
  {
    get
    {
      BlittableArrayWrapper ret;
      Il2CppStructArray<Rect> cutouts;
      try
      {
        Screen.get_cutouts_Injected(out ret);
      }
      finally
      {
        Il2CppStructArray<Rect> il2CppStructArray;
        ret.Unmarshal<Rect>((Il2CppArrayBase<Rect>&) ref il2CppStructArray);
        cutouts = il2CppStructArray;
      }
      return cutouts;
    }
  }

  public static void SetResolution(
    int width,
    int height,
    FullScreenMode fullscreenMode,
    int preferredRefreshRate)
  {
    if (preferredRefreshRate < 0)
      preferredRefreshRate = 0;
    Screen.SetResolution(width, height, fullscreenMode, new RefreshRate()
    {
      numerator = (uint) preferredRefreshRate,
      denominator = 1U
    });
  }

  public static void SetResolution(
    int width,
    int height,
    bool fullscreen,
    int preferredRefreshRate)
  {
    if (preferredRefreshRate < 0)
      preferredRefreshRate = 0;
    Screen.SetResolution(width, height, (FullScreenMode) (fullscreen ? 1 : 3), new RefreshRate()
    {
      numerator = (uint) preferredRefreshRate,
      denominator = 1U
    });
  }

  public static void SetResolution(int width, int height, bool fullscreen)
  {
    Screen.SetResolution(width, height, fullscreen, 0);
  }

  public static void SetMSAASamples(int numSamples)
  {
    Screen.SetMSAASamplesDelegateField(numSamples);
  }

  public static int GetMSAASamples() => Screen.GetMSAASamplesDelegateField();

  public static int msaaSamples => Screen.GetMSAASamples();

  public static Vector2Int mainWindowPosition => Screen.GetMainWindowPosition();

  public static void GetDisplayLayout(List<DisplayInfo> displayLayout)
  {
    if (displayLayout == null)
      throw new Il2CppSystem.ArgumentNullException();
    Screen.GetDisplayLayoutImpl(displayLayout);
  }

  public static AsyncOperation MoveMainWindowTo([In] ref DisplayInfo display, Vector2Int position)
  {
    return Screen.MoveMainWindowImpl(ref display, position);
  }

  public static Vector2Int GetMainWindowPosition()
  {
    Vector2Int ret;
    Screen.GetMainWindowPosition_Injected(out ret);
    return ret;
  }

  public static void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout)
  {
    Screen.GetDisplayLayoutImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayLayout));
  }

  public static AsyncOperation MoveMainWindowImpl([In] ref DisplayInfo display, Vector2Int position)
  {
    System.IntPtr ptr = Screen.MoveMainWindowImpl_Injected(ref display, ref position);
    return ptr != System.IntPtr.Zero ? AsyncOperation.BindingsMarshaller.ConvertToManaged(ptr) : (AsyncOperation) null;
  }

  public static float brightness
  {
    get => Screen.get_brightnessDelegateField();
    set => Screen.set_brightnessDelegateField(value);
  }

  public static bool lockCursor
  {
    get => CursorLockMode.Locked == Cursor.lockState;
    set
    {
      if (value)
      {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
      }
      else
      {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
      }
    }
  }

  public static void get_safeArea_Injected(out Rect ret)
  {
    Screen.get_safeArea_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_cutouts_Injected(out BlittableArrayWrapper ret)
  {
    Screen.get_cutouts_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void GetMainWindowPosition_Injected(out Vector2Int ret)
  {
    Screen.GetMainWindowPosition_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static unsafe System.IntPtr MoveMainWindowImpl_Injected(
    [In] ref DisplayInfo display,
    [In] ref Vector2Int position)
  {
    return Screen.MoveMainWindowImpl_InjectedDelegateField((System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) display), (System.IntPtr) ref position);
  }

  private delegate int get_sleepTimeoutDelegate();

  private delegate void set_sleepTimeoutDelegate(int value);

  private delegate bool IsOrientationEnabledDelegate(EnabledOrientation orient);

  private delegate void SetOrientationEnabledDelegate(EnabledOrientation orient, bool enabled);

  private delegate void set_fullScreenDelegate(bool value);

  private delegate void set_fullScreenModeDelegate(FullScreenMode value);

  private delegate void SetMSAASamplesDelegate(int numSamples);

  private delegate int GetMSAASamplesDelegate();

  private delegate void GetDisplayLayoutImplDelegate(System.IntPtr displayLayout);

  private delegate float get_brightnessDelegate();

  private delegate void set_brightnessDelegate(float value);

  private delegate void get_safeArea_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_cutouts_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void GetMainWindowPosition_InjectedDelegate([Out] System.IntPtr ret);

  private delegate System.IntPtr MoveMainWindowImpl_InjectedDelegate(
    [In] System.IntPtr display,
    [In] System.IntPtr position);
}
