// Decompiled with JetBrains decompiler
// Type: UnityEngine.Display
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class Display(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nativeDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_displays;
  private static readonly System.IntPtr NativeFieldInfoPtr__mainDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveEditorGameViewTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_onDisplaysUpdated;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Display_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0;
  private static readonly Display.GetRenderingBuffersImplDelegate GetRenderingBuffersImplDelegateField;
  private static readonly Display.SetRenderingResolutionImplDelegate SetRenderingResolutionImplDelegateField;
  private static readonly Display.SetParamsImplDelegate SetParamsImplDelegateField;
  private static readonly Display.GetActiveImplDelegate GetActiveImplDelegateField;
  private static readonly Display.RequiresBlitToBackbufferImplDelegate RequiresBlitToBackbufferImplDelegateField;
  private static readonly Display.RequiresSrgbBlitToBackbufferImplDelegate RequiresSrgbBlitToBackbufferImplDelegateField;
  private static readonly Display.ActivateDisplayImpl_InjectedDelegate ActivateDisplayImpl_InjectedDelegateField;

  static Display()
  {
    Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Display));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
    Display.NativeFieldInfoPtr_nativeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, nameof (nativeDisplay));
    Display.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, nameof (displays));
    Display.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, nameof (_mainDisplay));
    Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, nameof (m_ActiveEditorGameViewTarget));
    Display.NativeFieldInfoPtr_onDisplaysUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, nameof (onDisplaysUpdated));
    Display.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664655);
    Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664657);
    Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664658);
    Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664659);
    Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664660);
    Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664661);
    Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664662);
    Display.NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664663);
    Display.NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664664);
    Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664665);
    Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664666);
    Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664667);
    Display.GetRenderingBuffersImplDelegateField = IL2CPP.ResolveICall<Display.GetRenderingBuffersImplDelegate>("UnityEngine.Display::GetRenderingBuffersImpl");
    Display.SetRenderingResolutionImplDelegateField = IL2CPP.ResolveICall<Display.SetRenderingResolutionImplDelegate>("UnityEngine.Display::SetRenderingResolutionImpl");
    Display.SetParamsImplDelegateField = IL2CPP.ResolveICall<Display.SetParamsImplDelegate>("UnityEngine.Display::SetParamsImpl");
    Display.GetActiveImplDelegateField = IL2CPP.ResolveICall<Display.GetActiveImplDelegate>("UnityEngine.Display::GetActiveImpl");
    Display.RequiresBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresBlitToBackbufferImpl");
    Display.RequiresSrgbBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresSrgbBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresSrgbBlitToBackbufferImpl");
    Display.ActivateDisplayImpl_InjectedDelegateField = IL2CPP.ResolveICall<Display.ActivateDisplayImpl_InjectedDelegate>("UnityEngine.Display::ActivateDisplayImpl_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422890, XrefRangeEnd = 422892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Display()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int renderingWidth
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 422897, RefRangeEnd = 422900, XrefRangeStart = 422892, XrefRangeEnd = 422897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int renderingHeight
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 422905, RefRangeEnd = 422909, XrefRangeStart = 422900, XrefRangeEnd = 422905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int systemWidth
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 422914, RefRangeEnd = 422917, XrefRangeStart = 422909, XrefRangeEnd = 422914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int systemHeight
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 422922, RefRangeEnd = 422932, XrefRangeStart = 422917, XrefRangeEnd = 422922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 422937, RefRangeEnd = 422943, XrefRangeStart = 422932, XrefRangeEnd = 422937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputMouseCoordinates
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Display main
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 422947, RefRangeEnd = 422951, XrefRangeStart = 422943, XrefRangeEnd = 422947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Display) null : Il2CppObjectPool.Get<Display>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422951, XrefRangeEnd = 422967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RecreateDisplayList(Il2CppStructArray<System.IntPtr> nativeDisplay)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nativeDisplay)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422967, XrefRangeEnd = 422973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FireDisplaysUpdated()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422973, XrefRangeEnd = 422975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSystemExtImpl(System.IntPtr nativeDisplay, out int w, out int h)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &nativeDisplay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422975, XrefRangeEnd = 422977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetRenderingExtImpl(System.IntPtr nativeDisplay, out int w, out int h)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &nativeDisplay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref w;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422977, XrefRangeEnd = 422979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ry;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe System.IntPtr nativeDisplay
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay)) = value;
    }
  }

  public static unsafe Il2CppReferenceArray<Display> displays
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_displays, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<Display>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Display>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_displays, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Display _mainDisplay
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr__mainDisplay, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Display) null : Il2CppObjectPool.Get<Display>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr__mainDisplay, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int m_ActiveEditorGameViewTarget
  {
    get
    {
      int editorGameViewTarget;
      IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*) &editorGameViewTarget);
      return editorGameViewTarget;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*) &value);
    }
  }

  public static unsafe Display.DisplaysUpdatedDelegate onDisplaysUpdated
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Display.DisplaysUpdatedDelegate) null : Il2CppObjectPool.Get<Display.DisplaysUpdatedDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public RenderBuffer colorBuffer
  {
    get
    {
      RenderBuffer color;
      Display.GetRenderingBuffersImpl(this.nativeDisplay, out color, out RenderBuffer _);
      return color;
    }
  }

  public RenderBuffer depthBuffer
  {
    get
    {
      RenderBuffer depth;
      Display.GetRenderingBuffersImpl(this.nativeDisplay, out RenderBuffer _, out depth);
      return depth;
    }
  }

  public bool active => Display.GetActiveImpl(this.nativeDisplay);

  public bool requiresBlitToBackbuffer
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }

  public bool requiresSrgbBlitToBackbuffer
  {
    get => Display.RequiresSrgbBlitToBackbufferImpl(this.nativeDisplay);
  }

  public void Activate()
  {
    Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, new RefreshRate()
    {
      numerator = 60U,
      denominator = 1U
    });
  }

  public void Activate(int width, int height, RefreshRate refreshRate)
  {
    Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
  }

  public void Activate(int width, int height, int refreshRate)
  {
    if (refreshRate < 0)
      refreshRate = 0;
    Display.ActivateDisplayImpl(this.nativeDisplay, width, height, new RefreshRate()
    {
      numerator = (uint) refreshRate,
      denominator = 1U
    });
  }

  public void SetParams(int width, int height, int x, int y)
  {
    Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
  }

  public void SetRenderingResolution(int w, int h)
  {
    Display.SetRenderingResolutionImpl(this.nativeDisplay, w, h);
  }

  public static bool MultiDisplayLicense() => true;

  public static int activeEditorGameViewTarget
  {
    get => Display.m_ActiveEditorGameViewTarget;
    set => Display.m_ActiveEditorGameViewTarget = value;
  }

  [SpecialName]
  public static void add_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void GetRenderingBuffersImpl(
    System.IntPtr nativeDisplay,
    out RenderBuffer color,
    out RenderBuffer depth)
  {
    Display.GetRenderingBuffersImplDelegateField(nativeDisplay, (System.IntPtr) ref color, (System.IntPtr) ref depth);
  }

  public static void SetRenderingResolutionImpl(System.IntPtr nativeDisplay, int w, int h)
  {
    Display.SetRenderingResolutionImplDelegateField(nativeDisplay, w, h);
  }

  public static void ActivateDisplayImpl(
    System.IntPtr nativeDisplay,
    int width,
    int height,
    RefreshRate refreshRate)
  {
    Display.ActivateDisplayImpl_Injected(nativeDisplay, width, height, ref refreshRate);
  }

  public static void SetParamsImpl(System.IntPtr nativeDisplay, int width, int height, int x, int y)
  {
    Display.SetParamsImplDelegateField(nativeDisplay, width, height, x, y);
  }

  public static bool GetActiveImpl(System.IntPtr nativeDisplay)
  {
    return Display.GetActiveImplDelegateField(nativeDisplay);
  }

  public static bool RequiresBlitToBackbufferImpl(System.IntPtr nativeDisplay)
  {
    return Display.RequiresBlitToBackbufferImplDelegateField(nativeDisplay);
  }

  public static bool RequiresSrgbBlitToBackbufferImpl(System.IntPtr nativeDisplay)
  {
    return Display.RequiresSrgbBlitToBackbufferImplDelegateField(nativeDisplay);
  }

  public static void ActivateDisplayImpl_Injected(
    System.IntPtr nativeDisplay,
    int width,
    int height,
    [In] ref RefreshRate refreshRate)
  {
    Display.ActivateDisplayImpl_InjectedDelegateField(nativeDisplay, width, height, (System.IntPtr) ref refreshRate);
  }

  public sealed class DisplaysUpdatedDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

    static DisplaysUpdatedDelegate()
    {
      Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Display>.NativeClassPtr, nameof (DisplaysUpdatedDelegate));
      Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100664669);
      Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100664670);
    }

    [CallerCount(483)]
    [CachedScanResults(RefRangeStart = 231718, RefRangeEnd = 232201, XrefRangeStart = 231718, XrefRangeEnd = 232201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DisplaysUpdatedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator Display.DisplaysUpdatedDelegate([In] System.Action obj0)
    {
      return DelegateSupport.ConvertDelegate<Display.DisplaysUpdatedDelegate>((System.Delegate) obj0);
    }

    public static Display.DisplaysUpdatedDelegate operator +(
      [In] Display.DisplaysUpdatedDelegate obj0,
      [In] Display.DisplaysUpdatedDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Display.DisplaysUpdatedDelegate>();
    }

    public static Display.DisplaysUpdatedDelegate operator -(
      [In] Display.DisplaysUpdatedDelegate obj0,
      [In] Display.DisplaysUpdatedDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (Display.DisplaysUpdatedDelegate) @delegate : @delegate.Cast<Display.DisplaysUpdatedDelegate>();
    }
  }

  private delegate void GetRenderingBuffersImplDelegate(
    System.IntPtr nativeDisplay,
    [Out] System.IntPtr color,
    [Out] System.IntPtr depth);

  private delegate void SetRenderingResolutionImplDelegate(System.IntPtr nativeDisplay, int w, int h);

  private delegate void SetParamsImplDelegate(
    System.IntPtr nativeDisplay,
    int width,
    int height,
    int x,
    int y);

  private delegate bool GetActiveImplDelegate(System.IntPtr nativeDisplay);

  private delegate bool RequiresBlitToBackbufferImplDelegate(System.IntPtr nativeDisplay);

  private delegate bool RequiresSrgbBlitToBackbufferImplDelegate(System.IntPtr nativeDisplay);

  private delegate void ActivateDisplayImpl_InjectedDelegate(
    System.IntPtr nativeDisplay,
    int width,
    int height,
    [In] System.IntPtr refreshRate);
}
