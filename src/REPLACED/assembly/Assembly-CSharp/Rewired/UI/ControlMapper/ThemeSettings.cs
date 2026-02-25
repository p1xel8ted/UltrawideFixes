// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.ThemeSettings
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
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

[Serializable]
public class ThemeSettings(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__mainWindowBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr__popupWindowBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr__areaBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr__selectableSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__buttonSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__inputGridFieldSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__scrollbarSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__sliderSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__invertToggle;
  private static readonly System.IntPtr NativeFieldInfoPtr__invertToggleDisabledColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrationBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrationValueMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrationRawValueMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrationZeroMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrationCalibratedZeroMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr__calibrationDeadzone;
  private static readonly System.IntPtr NativeFieldInfoPtr__textSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__buttonTextSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__inputGridFieldTextSettings;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Component_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Image_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_TMP_Text_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyles_FontStyleOverride_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ThemeSettings()
  {
    Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (ThemeSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr);
    ThemeSettings.NativeFieldInfoPtr__mainWindowBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_mainWindowBackground));
    ThemeSettings.NativeFieldInfoPtr__popupWindowBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_popupWindowBackground));
    ThemeSettings.NativeFieldInfoPtr__areaBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_areaBackground));
    ThemeSettings.NativeFieldInfoPtr__selectableSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_selectableSettings));
    ThemeSettings.NativeFieldInfoPtr__buttonSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_buttonSettings));
    ThemeSettings.NativeFieldInfoPtr__inputGridFieldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_inputGridFieldSettings));
    ThemeSettings.NativeFieldInfoPtr__scrollbarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_scrollbarSettings));
    ThemeSettings.NativeFieldInfoPtr__sliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_sliderSettings));
    ThemeSettings.NativeFieldInfoPtr__invertToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_invertToggle));
    ThemeSettings.NativeFieldInfoPtr__invertToggleDisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_invertToggleDisabledColor));
    ThemeSettings.NativeFieldInfoPtr__calibrationBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_calibrationBackground));
    ThemeSettings.NativeFieldInfoPtr__calibrationValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_calibrationValueMarker));
    ThemeSettings.NativeFieldInfoPtr__calibrationRawValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_calibrationRawValueMarker));
    ThemeSettings.NativeFieldInfoPtr__calibrationZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_calibrationZeroMarker));
    ThemeSettings.NativeFieldInfoPtr__calibrationCalibratedZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_calibrationCalibratedZeroMarker));
    ThemeSettings.NativeFieldInfoPtr__calibrationDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_calibrationDeadzone));
    ThemeSettings.NativeFieldInfoPtr__textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_textSettings));
    ThemeSettings.NativeFieldInfoPtr__buttonTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_buttonTextSettings));
    ThemeSettings.NativeFieldInfoPtr__inputGridFieldTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (_inputGridFieldTextSettings));
    ThemeSettings.NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669951);
    ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669952 /*0x06001A00*/);
    ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669953);
    ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669954);
    ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669955);
    ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669956);
    ThemeSettings.NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyles_FontStyleOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669957);
    ThemeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100669958);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79752, RefRangeEnd = 79753, XrefRangeStart = 79750, XrefRangeEnd = 79752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(
    Il2CppReferenceArray<ThemedElement.ElementInfo> elementInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elementInfo)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79795, RefRangeEnd = 79796, XrefRangeStart = 79753, XrefRangeEnd = 79795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(string themeClass, Component component)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(themeClass);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79796, XrefRangeEnd = 79834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(string themeClass, Selectable item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(themeClass);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79834, XrefRangeEnd = 79886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(string themeClass, Image item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(themeClass);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79886, XrefRangeEnd = 79913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(string themeClass, TMP_Text item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(themeClass);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79913, XrefRangeEnd = 79929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(string themeClass, UIImageHelper item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(themeClass);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe FontStyles GetFontStyle(ThemeSettings.FontStyleOverride style)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &style
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyles_FontStyleOverride_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FontStyles*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ThemeSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThemeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ThemeSettings.ImageSettings _mainWindowBackground
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__mainWindowBackground));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__mainWindowBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _popupWindowBackground
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__popupWindowBackground));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__popupWindowBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _areaBackground
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__areaBackground));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__areaBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.SelectableSettings _selectableSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__selectableSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.SelectableSettings) null : Il2CppObjectPool.Get<ThemeSettings.SelectableSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__selectableSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.SelectableSettings _buttonSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.SelectableSettings) null : Il2CppObjectPool.Get<ThemeSettings.SelectableSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.SelectableSettings _inputGridFieldSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.SelectableSettings) null : Il2CppObjectPool.Get<ThemeSettings.SelectableSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ScrollbarSettings _scrollbarSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__scrollbarSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.ScrollbarSettings) null : Il2CppObjectPool.Get<ThemeSettings.ScrollbarSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__scrollbarSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.SliderSettings _sliderSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__sliderSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.SliderSettings) null : Il2CppObjectPool.Get<ThemeSettings.SliderSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__sliderSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _invertToggle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggle));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _invertToggleDisabledColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggleDisabledColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__invertToggleDisabledColor)) = value;
    }
  }

  public unsafe ThemeSettings.ImageSettings _calibrationBackground
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationBackground));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _calibrationValueMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationValueMarker));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationValueMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _calibrationRawValueMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationRawValueMarker));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationRawValueMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _calibrationZeroMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationZeroMarker));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationZeroMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationCalibratedZeroMarker));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationCalibratedZeroMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.ImageSettings _calibrationDeadzone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationDeadzone));
      return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__calibrationDeadzone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.TextSettings _textSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__textSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.TextSettings) null : Il2CppObjectPool.Get<ThemeSettings.TextSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__textSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.TextSettings _buttonTextSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonTextSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.TextSettings) null : Il2CppObjectPool.Get<ThemeSettings.TextSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__buttonTextSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ThemeSettings.TextSettings _inputGridFieldTextSettings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldTextSettings));
      return num == System.IntPtr.Zero ? (ThemeSettings.TextSettings) null : Il2CppObjectPool.Get<ThemeSettings.TextSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.NativeFieldInfoPtr__inputGridFieldTextSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SelectableSettings_Base(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__transition;
    private static readonly System.IntPtr NativeFieldInfoPtr__colors;
    private static readonly System.IntPtr NativeFieldInfoPtr__spriteState;
    private static readonly System.IntPtr NativeFieldInfoPtr__animationTriggers;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_transition_Public_get_Transition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    static SelectableSettings_Base()
    {
      Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (SelectableSettings_Base));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr);
      ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, nameof (_transition));
      ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, nameof (_colors));
      ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__spriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, nameof (_spriteState));
      ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__animationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, nameof (_animationTriggers));
      ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_transition_Public_get_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669959);
      ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669960);
      ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669961);
      ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669962);
      ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669963);
      ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr, 100669964);
    }

    public unsafe Selectable.Transition transition
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_transition_Public_get_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Selectable.Transition*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe ThemeSettings.CustomColorBlock selectableColors
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ThemeSettings.CustomColorBlock*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe ThemeSettings.CustomSpriteState spriteState
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
        return new ThemeSettings.CustomSpriteState(pointer);
      }
    }

    public unsafe ThemeSettings.CustomAnimationTriggers animationTriggers
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 72967, RefRangeEnd = 72968, XrefRangeStart = 72967, XrefRangeEnd = 72968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.CustomAnimationTriggers) null : Il2CppObjectPool.Get<ThemeSettings.CustomAnimationTriggers>(num3);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 79485, RefRangeEnd = 79488, XrefRangeStart = 79466, XrefRangeEnd = 79485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Apply(Selectable item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SelectableSettings_Base()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.SelectableSettings_Base>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Selectable.Transition _transition
    {
      get
      {
        return *(Selectable.Transition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__transition));
      }
      [param: In] set
      {
        *(Selectable.Transition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__transition)) = value;
      }
    }

    public unsafe ThemeSettings.CustomColorBlock _colors
    {
      get
      {
        return *(ThemeSettings.CustomColorBlock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__colors));
      }
      [param: In] set
      {
        *(ThemeSettings.CustomColorBlock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__colors)) = value;
      }
    }

    public ThemeSettings.CustomSpriteState _spriteState
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__spriteState);
        return new ThemeSettings.CustomSpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__spriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ThemeSettings.CustomAnimationTriggers _animationTriggers
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__animationTriggers));
        return num == System.IntPtr.Zero ? (ThemeSettings.CustomAnimationTriggers) null : Il2CppObjectPool.Get<ThemeSettings.CustomAnimationTriggers>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings_Base.NativeFieldInfoPtr__animationTriggers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class SelectableSettings(System.IntPtr pointer) : ThemeSettings.SelectableSettings_Base(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__imageSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SelectableSettings()
    {
      Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (SelectableSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr);
      ThemeSettings.SelectableSettings.NativeFieldInfoPtr__imageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, nameof (_imageSettings));
      ThemeSettings.SelectableSettings.NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, 100669965);
      ThemeSettings.SelectableSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, 100669966);
      ThemeSettings.SelectableSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr, 100669967);
    }

    public unsafe ThemeSettings.ImageSettings imageSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings.NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79488, XrefRangeEnd = 79495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Apply(Selectable item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ThemeSettings.SelectableSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SelectableSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.SelectableSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SelectableSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ThemeSettings.ImageSettings _imageSettings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings.NativeFieldInfoPtr__imageSettings));
        return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SelectableSettings.NativeFieldInfoPtr__imageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class SliderSettings(System.IntPtr pointer) : ThemeSettings.SelectableSettings_Base(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__handleImageSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__fillImageSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__backgroundImageSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_Slider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SliderSettings()
    {
      Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (SliderSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr);
      ThemeSettings.SliderSettings.NativeFieldInfoPtr__handleImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, nameof (_handleImageSettings));
      ThemeSettings.SliderSettings.NativeFieldInfoPtr__fillImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, nameof (_fillImageSettings));
      ThemeSettings.SliderSettings.NativeFieldInfoPtr__backgroundImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, nameof (_backgroundImageSettings));
      ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669968);
      ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669969);
      ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669970);
      ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Private_Void_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669971);
      ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669972);
      ThemeSettings.SliderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr, 100669973);
    }

    public unsafe ThemeSettings.ImageSettings handleImageSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num3);
      }
    }

    public unsafe ThemeSettings.ImageSettings fillImageSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num3);
      }
    }

    public unsafe ThemeSettings.ImageSettings backgroundImageSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num3);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 79516, RefRangeEnd = 79517, XrefRangeStart = 79495, XrefRangeEnd = 79516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Apply(Slider item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Private_Void_Slider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79517, XrefRangeEnd = 79521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Apply(Selectable item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ThemeSettings.SliderSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SliderSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.SliderSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.SliderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ThemeSettings.ImageSettings _handleImageSettings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__handleImageSettings));
        return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__handleImageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ThemeSettings.ImageSettings _fillImageSettings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__fillImageSettings));
        return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__fillImageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ThemeSettings.ImageSettings _backgroundImageSettings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__backgroundImageSettings));
        return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.SliderSettings.NativeFieldInfoPtr__backgroundImageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class ScrollbarSettings(System.IntPtr pointer) : ThemeSettings.SelectableSettings_Base(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__handleImageSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__backgroundImageSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ScrollbarSettings()
    {
      Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (ScrollbarSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr);
      ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__handleImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, nameof (_handleImageSettings));
      ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__backgroundImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, nameof (_backgroundImageSettings));
      ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669974);
      ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669975);
      ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669976);
      ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669977);
      ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr, 100669978);
    }

    public unsafe ThemeSettings.ImageSettings handle
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num3);
      }
    }

    public unsafe ThemeSettings.ImageSettings background
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79521, XrefRangeEnd = 79530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Apply(Scrollbar item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79530, XrefRangeEnd = 79543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Apply(Selectable item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScrollbarSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.ScrollbarSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ScrollbarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ThemeSettings.ImageSettings _handleImageSettings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__handleImageSettings));
        return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__handleImageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ThemeSettings.ImageSettings _backgroundImageSettings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__backgroundImageSettings));
        return num == System.IntPtr.Zero ? (ThemeSettings.ImageSettings) null : Il2CppObjectPool.Get<ThemeSettings.ImageSettings>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ScrollbarSettings.NativeFieldInfoPtr__backgroundImageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class ImageSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__color;
    private static readonly System.IntPtr NativeFieldInfoPtr__sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr__materal;
    private static readonly System.IntPtr NativeFieldInfoPtr__type;
    private static readonly System.IntPtr NativeFieldInfoPtr__preserveAspect;
    private static readonly System.IntPtr NativeFieldInfoPtr__fillCenter;
    private static readonly System.IntPtr NativeFieldInfoPtr__fillMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr__fillAmout;
    private static readonly System.IntPtr NativeFieldInfoPtr__fillClockwise;
    private static readonly System.IntPtr NativeFieldInfoPtr__fillOrigin;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_materal_Public_get_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ImageSettings()
    {
      Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (ImageSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr);
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_color));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_sprite));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__materal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_materal));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_type));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__preserveAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_preserveAspect));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_fillCenter));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_fillMethod));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillAmout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_fillAmout));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_fillClockwise));
      ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, nameof (_fillOrigin));
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669979);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669980);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_materal_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669981);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669982);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669983);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669984);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669985);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669986);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669987);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669988);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669989);
      ThemeSettings.ImageSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr, 100669990);
    }

    public unsafe Color color
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Sprite sprite
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
    }

    public unsafe Material materal
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_materal_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
      }
    }

    public unsafe Image.Type type
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Image.Type*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool preserveAspect
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 79543, RefRangeEnd = 79544, XrefRangeStart = 79543, XrefRangeEnd = 79543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool fillCenter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Image.FillMethod fillMethod
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Image.FillMethod*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float fillAmout
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool fillClockwise
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe int fillOrigin
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79544, XrefRangeEnd = 79556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void CopyTo(Image image)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ThemeSettings.ImageSettings.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79556, XrefRangeEnd = 79557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ImageSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.ImageSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.ImageSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Color _color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__color)) = value;
      }
    }

    public unsafe Sprite _sprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__sprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material _materal
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__materal));
        return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__materal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image.Type _type
    {
      get
      {
        return *(Image.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__type));
      }
      [param: In] set
      {
        *(Image.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__type)) = value;
      }
    }

    public unsafe bool _preserveAspect
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__preserveAspect));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__preserveAspect)) = value;
      }
    }

    public unsafe bool _fillCenter
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillCenter));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillCenter)) = value;
      }
    }

    public unsafe Image.FillMethod _fillMethod
    {
      get
      {
        return *(Image.FillMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillMethod));
      }
      [param: In] set
      {
        *(Image.FillMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillMethod)) = value;
      }
    }

    public unsafe float _fillAmout
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillAmout));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillAmout)) = value;
      }
    }

    public unsafe bool _fillClockwise
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillClockwise));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillClockwise)) = value;
      }
    }

    public unsafe int _fillOrigin
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillOrigin));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.ImageSettings.NativeFieldInfoPtr__fillOrigin)) = value;
      }
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CustomColorBlock
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FadeDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledHighlightedColor;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_normalColor_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0;
    [FieldOffset(0)]
    public float m_ColorMultiplier;
    [FieldOffset(4)]
    public Color m_DisabledColor;
    [FieldOffset(20)]
    public float m_FadeDuration;
    [FieldOffset(24)]
    public Color m_HighlightedColor;
    [FieldOffset(40)]
    public Color m_NormalColor;
    [FieldOffset(56)]
    public Color m_PressedColor;
    [FieldOffset(72)]
    public Color m_SelectedColor;
    [FieldOffset(88)]
    public Color m_DisabledHighlightedColor;

    static CustomColorBlock()
    {
      Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (CustomColorBlock));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr);
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_ColorMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_ColorMultiplier));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_DisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_DisabledColor));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_FadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_FadeDuration));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_HighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_HighlightedColor));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_NormalColor));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_PressedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_PressedColor));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_SelectedColor));
      ThemeSettings.CustomColorBlock.NativeFieldInfoPtr_m_DisabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, nameof (m_DisabledHighlightedColor));
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669991);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669992);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669993);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669994);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669995);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669996);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669997);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669998);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100669999);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670000);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670001);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670002);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670003);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670004);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670005);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670006);
      ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, 100670007);
    }

    public unsafe float colorMultiplier
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(43), CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Color disabledColor
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe float fadeDuration
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 70589, RefRangeEnd = 70590, XrefRangeStart = 70589, XrefRangeEnd = 70590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Color highlightedColor
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Color normalColor
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_normalColor_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 79557, RefRangeEnd = 79563, XrefRangeStart = 79557, XrefRangeEnd = 79557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Color pressedColor
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Color selectedColor
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Color disabledHighlightedColor
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 79566, RefRangeEnd = 79568, XrefRangeStart = 79563, XrefRangeEnd = 79566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ColorBlock(ThemeSettings.CustomColorBlock item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &item
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomColorBlock.NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorBlock*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ThemeSettings.CustomColorBlock>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  public sealed class CustomSpriteState : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledHighlightedSprite;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0;

    static CustomSpriteState()
    {
      Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (CustomSpriteState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr);
      ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, nameof (m_DisabledSprite));
      ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_HighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, nameof (m_HighlightedSprite));
      ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_PressedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, nameof (m_PressedSprite));
      ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_SelectedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, nameof (m_SelectedSprite));
      ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, nameof (m_DisabledHighlightedSprite));
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670008);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670009);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670010);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670011);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670012);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670013);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670014);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670015);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670016);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670017);
      ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr, 100670018);
    }

    public unsafe Sprite disabledSprite
    {
      [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Sprite highlightedSprite
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Sprite pressedSprite
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Sprite selectedSprite
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Sprite disabledHighlightedSprite
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    public static unsafe implicit operator SpriteState(ThemeSettings.CustomSpriteState item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) item))
      };
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomSpriteState.NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new SpriteState(pointer);
    }

    public CustomSpriteState(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CustomSpriteState()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.CustomSpriteState>.NativeClassPtr))
    {
    }

    public unsafe Sprite m_DisabledSprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledSprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite m_HighlightedSprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_HighlightedSprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_HighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite m_PressedSprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_PressedSprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_PressedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite m_SelectedSprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_SelectedSprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_SelectedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite m_DisabledHighlightedSprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledHighlightedSprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomSpriteState.NativeFieldInfoPtr_m_DisabledHighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class CustomAnimationTriggers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledHighlightedTrigger;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0;

    static CustomAnimationTriggers()
    {
      Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (CustomAnimationTriggers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr);
      ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, nameof (m_DisabledTrigger));
      ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, nameof (m_HighlightedTrigger));
      ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, nameof (m_NormalTrigger));
      ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, nameof (m_PressedTrigger));
      ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, nameof (m_SelectedTrigger));
      ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, nameof (m_DisabledHighlightedTrigger));
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670019);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670020);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670021);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670022);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670023);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670024);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670025);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670026);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670027);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670028);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670029);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670030);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670031);
      ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr, 100670032);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79737, XrefRangeEnd = 79744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomAnimationTriggers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.CustomAnimationTriggers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe string disabledTrigger
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe string highlightedTrigger
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe string normalTrigger
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe string pressedTrigger
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe string selectedTrigger
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe string disabledHighlightedTrigger
    {
      [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79745, XrefRangeEnd = 79749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AnimationTriggers(
      ThemeSettings.CustomAnimationTriggers item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.CustomAnimationTriggers.NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AnimationTriggers) null : Il2CppObjectPool.Get<AnimationTriggers>(num3);
    }

    public unsafe string m_DisabledTrigger
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_HighlightedTrigger
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_NormalTrigger
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_PressedTrigger
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_SelectedTrigger
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_DisabledHighlightedTrigger
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledHighlightedTrigger)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.CustomAnimationTriggers.NativeFieldInfoPtr_m_DisabledHighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [Serializable]
  public class TextSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__color;
    private static readonly System.IntPtr NativeFieldInfoPtr__font;
    private static readonly System.IntPtr NativeFieldInfoPtr__style;
    private static readonly System.IntPtr NativeFieldInfoPtr__sizeMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr__lineSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr__characterSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr__wordSpacing;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_chracterSpacing_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static TextSettings()
    {
      Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, nameof (TextSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr);
      ThemeSettings.TextSettings.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_color));
      ThemeSettings.TextSettings.NativeFieldInfoPtr__font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_font));
      ThemeSettings.TextSettings.NativeFieldInfoPtr__style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_style));
      ThemeSettings.TextSettings.NativeFieldInfoPtr__sizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_sizeMultiplier));
      ThemeSettings.TextSettings.NativeFieldInfoPtr__lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_lineSpacing));
      ThemeSettings.TextSettings.NativeFieldInfoPtr__characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_characterSpacing));
      ThemeSettings.TextSettings.NativeFieldInfoPtr__wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, nameof (_wordSpacing));
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670033);
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670034);
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670035);
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670036);
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670037);
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_chracterSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670038);
      ThemeSettings.TextSettings.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670039);
      ThemeSettings.TextSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr, 100670040);
    }

    public unsafe Color color
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe TMP_FontAsset font
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (TMP_FontAsset) null : Il2CppObjectPool.Get<TMP_FontAsset>(num3);
      }
    }

    public unsafe ThemeSettings.FontStyleOverride style
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(ThemeSettings.FontStyleOverride*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float sizeMultiplier
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float lineSpacing
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float chracterSpacing
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_chracterSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float wordSpacing
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79749, XrefRangeEnd = 79750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TextSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings.TextSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ThemeSettings.TextSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Color _color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__color)) = value;
      }
    }

    public unsafe TMP_FontAsset _font
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__font));
        return num == System.IntPtr.Zero ? (TMP_FontAsset) null : Il2CppObjectPool.Get<TMP_FontAsset>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__font), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ThemeSettings.FontStyleOverride _style
    {
      get
      {
        return *(ThemeSettings.FontStyleOverride*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__style));
      }
      [param: In] set
      {
        *(ThemeSettings.FontStyleOverride*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__style)) = value;
      }
    }

    public unsafe float _sizeMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__sizeMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__sizeMultiplier)) = value;
      }
    }

    public unsafe float _lineSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__lineSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__lineSpacing)) = value;
      }
    }

    public unsafe float _characterSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__characterSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__characterSpacing)) = value;
      }
    }

    public unsafe float _wordSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__wordSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ThemeSettings.TextSettings.NativeFieldInfoPtr__wordSpacing)) = value;
      }
    }
  }

  public enum FontStyleOverride
  {
    Default,
    Normal,
    Bold,
    Italic,
    BoldAndItalic,
  }
}
