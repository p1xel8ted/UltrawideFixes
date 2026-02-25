// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.CanvasScalerFitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class CanvasScalerFitter(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_breakPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasScaler;
  private static readonly System.IntPtr NativeFieldInfoPtr_screenWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_screenHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScreenSizeChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSize_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CanvasScalerFitter()
  {
    Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (CanvasScalerFitter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr);
    CanvasScalerFitter.NativeFieldInfoPtr_breakPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, nameof (breakPoints));
    CanvasScalerFitter.NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, nameof (canvasScaler));
    CanvasScalerFitter.NativeFieldInfoPtr_screenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, nameof (screenWidth));
    CanvasScalerFitter.NativeFieldInfoPtr_screenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, nameof (screenHeight));
    CanvasScalerFitter.NativeFieldInfoPtr_ScreenSizeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, nameof (ScreenSizeChanged));
    CanvasScalerFitter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668990);
    CanvasScalerFitter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668991);
    CanvasScalerFitter.NativeMethodInfoPtr_UpdateSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668992);
    CanvasScalerFitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668993);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72325, XrefRangeEnd = 72330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 72339, RefRangeEnd = 72340, XrefRangeStart = 72330, XrefRangeEnd = 72339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72340, XrefRangeEnd = 72345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr_UpdateSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CanvasScalerFitter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CanvasScalerFitter.BreakPoint> breakPoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_breakPoints));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CanvasScalerFitter.BreakPoint>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasScalerFitter.BreakPoint>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_breakPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasScalerExt canvasScaler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_canvasScaler));
      return num == System.IntPtr.Zero ? (CanvasScalerExt) null : Il2CppObjectPool.Get<CanvasScalerExt>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_canvasScaler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int screenWidth
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenWidth));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenWidth)) = value;
    }
  }

  public unsafe int screenHeight
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenHeight));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenHeight)) = value;
    }
  }

  public unsafe Il2CppSystem.Action ScreenSizeChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_ScreenSizeChanged));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_ScreenSizeChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class BreakPoint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_screenAspectRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_referenceResolution;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static BreakPoint()
    {
      Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, nameof (BreakPoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr);
      CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, nameof (name));
      CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_screenAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, nameof (screenAspectRatio));
      CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_referenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, nameof (referenceResolution));
      CanvasScalerFitter.BreakPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, 100668994);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BreakPoint()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.BreakPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float screenAspectRatio
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_screenAspectRatio));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_screenAspectRatio)) = value;
      }
    }

    public unsafe Vector2 referenceResolution
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_referenceResolution));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_referenceResolution)) = value;
      }
    }
  }
}
