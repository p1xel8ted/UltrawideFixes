// Decompiled with JetBrains decompiler
// Type: UnityEngine.LightingSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine;

public sealed class LightingSettings(IntPtr pointer) : Object(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_LightingSettings_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bakedGI_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_bakedGI_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_realtimeGI_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_realtimeGI_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bakedGI_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_bakedGI_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_realtimeGI_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_realtimeGI_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Injected_Private_Static_Void_IntPtr_Boolean_0;

  static LightingSettings()
  {
    Il2CppClassPointerStore<LightingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LightingSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr);
    LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664608 /*0x06000520*/);
    LightingSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664609);
    LightingSettings.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_LightingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664610);
    LightingSettings.NativeMethodInfoPtr_get_bakedGI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664611);
    LightingSettings.NativeMethodInfoPtr_set_bakedGI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664612);
    LightingSettings.NativeMethodInfoPtr_get_realtimeGI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664613);
    LightingSettings.NativeMethodInfoPtr_set_realtimeGI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664614);
    LightingSettings.NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664615);
    LightingSettings.NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664616);
    LightingSettings.NativeMethodInfoPtr_get_bakedGI_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664617);
    LightingSettings.NativeMethodInfoPtr_set_bakedGI_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664618);
    LightingSettings.NativeMethodInfoPtr_get_realtimeGI_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664619);
    LightingSettings.NativeMethodInfoPtr_set_realtimeGI_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664620);
    LightingSettings.NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664621);
    LightingSettings.NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664622);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LightingSettingsDontStripMe()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422564, XrefRangeEnd = 422570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightingSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422570, XrefRangeEnd = 422572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Create(LightingSettings self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_LightingSettings_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool bakedGI
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422572, XrefRangeEnd = 422577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_bakedGI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422577, XrefRangeEnd = 422582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_bakedGI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool realtimeGI
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422582, XrefRangeEnd = 422587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_realtimeGI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422587, XrefRangeEnd = 422592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_realtimeGI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool realtimeEnvironmentLighting
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422592, XrefRangeEnd = 422597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422597, XrefRangeEnd = 422602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422602, XrefRangeEnd = 422604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_bakedGI_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_bakedGI_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422604, XrefRangeEnd = 422606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_bakedGI_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_bakedGI_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422606, XrefRangeEnd = 422608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_realtimeGI_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_realtimeGI_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422608, XrefRangeEnd = 422610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_realtimeGI_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_realtimeGI_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422610, XrefRangeEnd = 422612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_realtimeEnvironmentLighting_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422612, XrefRangeEnd = 422614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_realtimeEnvironmentLighting_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
