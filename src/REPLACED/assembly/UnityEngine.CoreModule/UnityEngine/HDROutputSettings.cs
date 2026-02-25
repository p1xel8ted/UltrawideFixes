// Decompiled with JetBrains decompiler
// Type: UnityEngine.HDROutputSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine;

public class HDROutputSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_displays;
  private static readonly System.IntPtr NativeFieldInfoPtr__mainDisplay;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_available_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_automaticHDRTonemapping_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HDRModeChangeRequested_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAutomaticHDRTonemapping_Private_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Private_Static_GraphicsFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHDRModeChangeRequested_Private_Static_Boolean_Int32_0;
  private static readonly HDROutputSettings.SetAutomaticHDRTonemappingDelegate SetAutomaticHDRTonemappingDelegateField;
  private static readonly HDROutputSettings.SetPaperWhiteNitsDelegate SetPaperWhiteNitsDelegateField;
  private static readonly HDROutputSettings.RequestHDRModeChangeInternalDelegate RequestHDRModeChangeInternalDelegateField;

  static HDROutputSettings()
  {
    Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (HDROutputSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr);
    HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, nameof (m_DisplayIndex));
    HDROutputSettings.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, nameof (displays));
    HDROutputSettings.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, nameof (_mainDisplay));
    HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664779);
    HDROutputSettings.NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664780);
    HDROutputSettings.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664781);
    HDROutputSettings.NativeMethodInfoPtr_get_available_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664782);
    HDROutputSettings.NativeMethodInfoPtr_get_automaticHDRTonemapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664783);
    HDROutputSettings.NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664784 /*0x060005D0*/);
    HDROutputSettings.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664785);
    HDROutputSettings.NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664786);
    HDROutputSettings.NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664787);
    HDROutputSettings.NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664788);
    HDROutputSettings.NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664789);
    HDROutputSettings.NativeMethodInfoPtr_get_HDRModeChangeRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664790);
    HDROutputSettings.NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664791);
    HDROutputSettings.NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664792);
    HDROutputSettings.NativeMethodInfoPtr_GetAutomaticHDRTonemapping_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664793);
    HDROutputSettings.NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664794);
    HDROutputSettings.NativeMethodInfoPtr_GetGraphicsFormat_Private_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664795);
    HDROutputSettings.NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664796);
    HDROutputSettings.NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664797);
    HDROutputSettings.NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664798);
    HDROutputSettings.NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664799);
    HDROutputSettings.NativeMethodInfoPtr_GetHDRModeChangeRequested_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664800 /*0x060005E0*/);
    HDROutputSettings.SetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::SetAutomaticHDRTonemapping");
    HDROutputSettings.SetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::SetPaperWhiteNits");
    HDROutputSettings.RequestHDRModeChangeInternalDelegateField = IL2CPP.ResolveICall<HDROutputSettings.RequestHDRModeChangeInternalDelegate>("UnityEngine.HDROutputSettings::RequestHDRModeChangeInternal");
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423726, RefRangeEnd = 423728, XrefRangeStart = 423725, XrefRangeEnd = 423726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HDROutputSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe HDROutputSettings main
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423732, RefRangeEnd = 423733, XrefRangeStart = 423728, XrefRangeEnd = 423732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (HDROutputSettings) null : Il2CppObjectPool.Get<HDROutputSettings>(num3);
    }
  }

  public unsafe bool active
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423738, RefRangeEnd = 423739, XrefRangeStart = 423733, XrefRangeEnd = 423738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool available
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 423744, RefRangeEnd = 423753, XrefRangeStart = 423739, XrefRangeEnd = 423744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_available_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool automaticHDRTonemapping
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423753, XrefRangeEnd = 423758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_automaticHDRTonemapping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => HDROutputSettings.SetAutomaticHDRTonemapping(this.m_DisplayIndex, value);
  }

  public unsafe ColorGamut displayColorGamut
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423758, XrefRangeEnd = 423763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ColorGamut*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe GraphicsFormat graphicsFormat
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423763, XrefRangeEnd = 423768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float paperWhiteNits
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423768, XrefRangeEnd = 423773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => HDROutputSettings.SetPaperWhiteNits(this.m_DisplayIndex, value);
  }

  public unsafe int maxFullFrameToneMapLuminance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423773, XrefRangeEnd = 423778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int maxToneMapLuminance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423778, XrefRangeEnd = 423783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int minToneMapLuminance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423783, XrefRangeEnd = 423788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool HDRModeChangeRequested
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423788, XrefRangeEnd = 423793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_HDRModeChangeRequested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423793, XrefRangeEnd = 423795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetActive(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423795, XrefRangeEnd = 423797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetAvailable(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423797, XrefRangeEnd = 423799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetAutomaticHDRTonemapping(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetAutomaticHDRTonemapping_Private_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423799, XrefRangeEnd = 423801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorGamut GetDisplayColorGamut(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ColorGamut*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423801, XrefRangeEnd = 423803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetGraphicsFormat(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetGraphicsFormat_Private_Static_GraphicsFormat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423803, XrefRangeEnd = 423815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetPaperWhiteNits(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423815, XrefRangeEnd = 423817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetMaxFullFrameToneMapLuminance(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423817, XrefRangeEnd = 423819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetMaxToneMapLuminance(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423819, XrefRangeEnd = 423821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetMinToneMapLuminance(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423821, XrefRangeEnd = 423823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetHDRModeChangeRequested(int displayIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetHDRModeChangeRequested_Private_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe int m_DisplayIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex)) = value;
    }
  }

  public static unsafe Il2CppReferenceArray<HDROutputSettings> displays
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(HDROutputSettings.NativeFieldInfoPtr_displays, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<HDROutputSettings>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<HDROutputSettings>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HDROutputSettings.NativeFieldInfoPtr_displays, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe HDROutputSettings _mainDisplay
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(HDROutputSettings.NativeFieldInfoPtr__mainDisplay, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (HDROutputSettings) null : Il2CppObjectPool.Get<HDROutputSettings>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HDROutputSettings.NativeFieldInfoPtr__mainDisplay, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public RenderTextureFormat format
  {
    get
    {
      return GraphicsFormatUtility.GetRenderTextureFormat(HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex));
    }
  }

  public void RequestHDRModeChange(bool enabled)
  {
    HDROutputSettings.RequestHDRModeChangeInternal(this.m_DisplayIndex, enabled);
  }

  public static void SetPaperWhiteInNits(float paperWhite)
  {
    int displayIndex = 0;
    if (!HDROutputSettings.GetAvailable(displayIndex))
      return;
    HDROutputSettings.SetPaperWhiteNits(displayIndex, paperWhite);
  }

  public static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
  {
    HDROutputSettings.SetAutomaticHDRTonemappingDelegateField(displayIndex, scripted);
  }

  public static void SetPaperWhiteNits(int displayIndex, float paperWhite)
  {
    HDROutputSettings.SetPaperWhiteNitsDelegateField(displayIndex, paperWhite);
  }

  public static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
  {
    HDROutputSettings.RequestHDRModeChangeInternalDelegateField(displayIndex, enabled);
  }

  private delegate void SetAutomaticHDRTonemappingDelegate(int displayIndex, bool scripted);

  private delegate void SetPaperWhiteNitsDelegate(int displayIndex, float paperWhite);

  private delegate void RequestHDRModeChangeInternalDelegate(int displayIndex, bool enabled);
}
