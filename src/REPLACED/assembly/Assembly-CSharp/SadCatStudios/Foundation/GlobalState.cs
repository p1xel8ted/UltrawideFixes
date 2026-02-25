// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.GlobalState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using MessagePipe;
using SadCatStudios.Foundation.Events;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation;

[Serializable]
public class GlobalState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Gameplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_Visuals;
  private static readonly System.IntPtr NativeFieldInfoPtr_Audio;
  private static readonly System.IntPtr NativeFieldInfoPtr_Gamepad;
  private static readonly System.IntPtr NativeFieldInfoPtr_Language;
  private static readonly System.IntPtr NativeFieldInfoPtr_SimplifiedFont;
  private static readonly System.IntPtr NativeFieldInfoPtr__Instance_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_AudioDeviceSnapshots;
  private static readonly System.IntPtr NativeFieldInfoPtr_audioDeviceInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallbackEnglishLocalizationStrings;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateUpdatePublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr__SupportedResolutions_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_GlobalState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_GlobalState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SupportedResolutions_Public_Static_get_List_1_Resolution_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SupportedResolutions_Private_Static_set_Void_List_1_Resolution_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetToDefaults_Public_Static_Void_ResetMenu_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Static_UniTaskVoid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAndApply_Private_Static_UniTask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAndSave_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplySound_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplySubtitle_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Apply_b__29_0_Private_Boolean_Resolution_0;

  static GlobalState()
  {
    Il2CppClassPointerStore<GlobalState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (GlobalState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState>.NativeClassPtr);
    GlobalState.NativeFieldInfoPtr_Gameplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (Gameplay));
    GlobalState.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (Visuals));
    GlobalState.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (Audio));
    GlobalState.NativeFieldInfoPtr_Gamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (Gamepad));
    GlobalState.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (Language));
    GlobalState.NativeFieldInfoPtr_SimplifiedFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (SimplifiedFont));
    GlobalState.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "<Instance>k__BackingField");
    GlobalState.NativeFieldInfoPtr_AudioDeviceSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (AudioDeviceSnapshots));
    GlobalState.NativeFieldInfoPtr_audioDeviceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (audioDeviceInstance));
    GlobalState.NativeFieldInfoPtr_fallbackEnglishLocalizationStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (fallbackEnglishLocalizationStrings));
    GlobalState.NativeFieldInfoPtr_stateUpdatePublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (stateUpdatePublisher));
    GlobalState.NativeFieldInfoPtr__SupportedResolutions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "<SupportedResolutions>k__BackingField");
    GlobalState.NativeMethodInfoPtr_get_Instance_Public_Static_get_GlobalState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671223);
    GlobalState.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_GlobalState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671224);
    GlobalState.NativeMethodInfoPtr_get_SupportedResolutions_Public_Static_get_List_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671225);
    GlobalState.NativeMethodInfoPtr_set_SupportedResolutions_Private_Static_set_Void_List_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671226);
    GlobalState.NativeMethodInfoPtr_ResetToDefaults_Public_Static_Void_ResetMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671227);
    GlobalState.NativeMethodInfoPtr_InitializeAsync_Public_Static_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671228);
    GlobalState.NativeMethodInfoPtr_LoadAndApply_Private_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671229);
    GlobalState.NativeMethodInfoPtr_ApplyAndSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671230);
    GlobalState.NativeMethodInfoPtr_ApplySound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671231);
    GlobalState.NativeMethodInfoPtr_ApplySubtitle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671232 /*0x06001F00*/);
    GlobalState.NativeMethodInfoPtr_Apply_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671233);
    GlobalState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671234);
    GlobalState.NativeMethodInfoPtr__Apply_b__29_0_Private_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, 100671235);
  }

  public static unsafe GlobalState Instance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92077, XrefRangeEnd = 92079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_get_Instance_Public_Static_get_GlobalState_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GlobalState) null : Il2CppObjectPool.Get<GlobalState>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92079, XrefRangeEnd = 92081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_GlobalState_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe List<Resolution> SupportedResolutions
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92081, XrefRangeEnd = 92083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_get_SupportedResolutions_Public_Static_get_List_1_Resolution_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<Resolution>) null : Il2CppObjectPool.Get<List<Resolution>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92083, XrefRangeEnd = 92085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_set_SupportedResolutions_Private_Static_set_Void_List_1_Resolution_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 92147, RefRangeEnd = 92148, XrefRangeStart = 92085, XrefRangeEnd = 92147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetToDefaults(GlobalState.ResetMenu menuToReset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &menuToReset
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_ResetToDefaults_Public_Static_Void_ResetMenu_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 92151, RefRangeEnd = 92154, XrefRangeStart = 92148, XrefRangeEnd = 92151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UniTaskVoid InitializeAsync()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_InitializeAsync_Public_Static_UniTaskVoid_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92154, XrefRangeEnd = 92159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UniTask LoadAndApply()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_LoadAndApply_Private_Static_UniTask_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 92181, RefRangeEnd = 92182, XrefRangeStart = 92159, XrefRangeEnd = 92181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyAndSave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_ApplyAndSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 92220, RefRangeEnd = 92225, XrefRangeStart = 92182, XrefRangeEnd = 92220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplySound()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_ApplySound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 92232, RefRangeEnd = 92234, XrefRangeStart = 92225, XrefRangeEnd = 92232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplySubtitle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_ApplySubtitle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 92291, RefRangeEnd = 92294, XrefRangeStart = 92234, XrefRangeEnd = 92291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr_Apply_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 92311, RefRangeEnd = 92312, XrefRangeStart = 92294, XrefRangeEnd = 92311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalState()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92312, XrefRangeEnd = 92313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Apply_b__29_0(Resolution res)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &res
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.NativeMethodInfoPtr__Apply_b__29_0_Private_Boolean_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe GlobalState.GameplaySettings Gameplay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Gameplay));
      return num == System.IntPtr.Zero ? (GlobalState.GameplaySettings) null : Il2CppObjectPool.Get<GlobalState.GameplaySettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Gameplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GlobalState.VisualSettings Visuals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Visuals));
      return num == System.IntPtr.Zero ? (GlobalState.VisualSettings) null : Il2CppObjectPool.Get<GlobalState.VisualSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GlobalState.AudioSettings Audio
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Audio));
      return num == System.IntPtr.Zero ? (GlobalState.AudioSettings) null : Il2CppObjectPool.Get<GlobalState.AudioSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GlobalState.GamepadSettings Gamepad
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Gamepad));
      return num == System.IntPtr.Zero ? (GlobalState.GamepadSettings) null : Il2CppObjectPool.Get<GlobalState.GamepadSettings>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Gamepad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string Language
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Language)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_Language), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool SimplifiedFont
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_SimplifiedFont));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_SimplifiedFont)) = value;
    }
  }

  public static unsafe GlobalState _Instance_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlobalState.NativeFieldInfoPtr__Instance_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (GlobalState) null : Il2CppObjectPool.Get<GlobalState>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlobalState.NativeFieldInfoPtr__Instance_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<EventReference> AudioDeviceSnapshots
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlobalState.NativeFieldInfoPtr_AudioDeviceSnapshots, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<EventReference>) null : Il2CppObjectPool.Get<Il2CppStructArray<EventReference>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlobalState.NativeFieldInfoPtr_AudioDeviceSnapshots, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance audioDeviceInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_audioDeviceInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.NativeFieldInfoPtr_audioDeviceInstance)) = value;
    }
  }

  public static unsafe Dictionary<string, string> fallbackEnglishLocalizationStrings
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlobalState.NativeFieldInfoPtr_fallbackEnglishLocalizationStrings, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlobalState.NativeFieldInfoPtr_fallbackEnglishLocalizationStrings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe IPublisher<GameSettingsUpdateEvent> stateUpdatePublisher
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlobalState.NativeFieldInfoPtr_stateUpdatePublisher, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (IPublisher<GameSettingsUpdateEvent>) null : Il2CppObjectPool.Get<IPublisher<GameSettingsUpdateEvent>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlobalState.NativeFieldInfoPtr_stateUpdatePublisher, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<Resolution> _SupportedResolutions_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GlobalState.NativeFieldInfoPtr__SupportedResolutions_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<Resolution>) null : Il2CppObjectPool.Get<List<Resolution>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GlobalState.NativeFieldInfoPtr__SupportedResolutions_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class GameplaySettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraShake;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubtitleFontSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubtitleBackgroundAlpha;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static GameplaySettings()
    {
      Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (GameplaySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr);
      GlobalState.GameplaySettings.NativeFieldInfoPtr_CameraShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr, nameof (CameraShake));
      GlobalState.GameplaySettings.NativeFieldInfoPtr_SubtitleFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr, nameof (SubtitleFontSize));
      GlobalState.GameplaySettings.NativeFieldInfoPtr_SubtitleBackgroundAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr, nameof (SubtitleBackgroundAlpha));
      GlobalState.GameplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr, 100671236);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 91889, RefRangeEnd = 91892, XrefRangeStart = 91883, XrefRangeEnd = 91889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplaySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState.GameplaySettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.GameplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float CameraShake
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GameplaySettings.NativeFieldInfoPtr_CameraShake));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GameplaySettings.NativeFieldInfoPtr_CameraShake)) = value;
      }
    }

    public Il2CppSystem.Nullable<float> SubtitleFontSize
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GameplaySettings.NativeFieldInfoPtr_SubtitleFontSize);
        return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GameplaySettings.NativeFieldInfoPtr_SubtitleFontSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Il2CppSystem.Nullable<float> SubtitleBackgroundAlpha
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GameplaySettings.NativeFieldInfoPtr_SubtitleBackgroundAlpha);
        return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GameplaySettings.NativeFieldInfoPtr_SubtitleBackgroundAlpha), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [Serializable]
  public class VisualSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FullscreenMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResolutionWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResolutionHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResolutionRefreshRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_VSync;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VisualSettings()
    {
      Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (VisualSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr);
      GlobalState.VisualSettings.NativeFieldInfoPtr_FullscreenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, nameof (FullscreenMode));
      GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, nameof (ResolutionWidth));
      GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, nameof (ResolutionHeight));
      GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionRefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, nameof (ResolutionRefreshRate));
      GlobalState.VisualSettings.NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, nameof (VSync));
      GlobalState.VisualSettings.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, 100671237);
      GlobalState.VisualSettings.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, 100671238);
      GlobalState.VisualSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr, 100671239);
    }

    public unsafe float Brightness
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91892, XrefRangeEnd = 91894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.VisualSettings.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 91896, RefRangeEnd = 91897, XrefRangeStart = 91894, XrefRangeEnd = 91896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GlobalState.VisualSettings.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91897, XrefRangeEnd = 91898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VisualSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState.VisualSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.VisualSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe FullScreenMode FullscreenMode
    {
      get
      {
        return *(FullScreenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_FullscreenMode));
      }
      [param: In] set
      {
        *(FullScreenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_FullscreenMode)) = value;
      }
    }

    public unsafe int ResolutionWidth
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionWidth));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionWidth)) = value;
      }
    }

    public unsafe int ResolutionHeight
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionHeight));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionHeight)) = value;
      }
    }

    public unsafe int ResolutionRefreshRate
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionRefreshRate));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_ResolutionRefreshRate)) = value;
      }
    }

    public unsafe bool VSync
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_VSync));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.VisualSettings.NativeFieldInfoPtr_VSync)) = value;
      }
    }
  }

  [Serializable]
  public class AudioSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Master;
    private static readonly System.IntPtr NativeFieldInfoPtr_Music;
    private static readonly System.IntPtr NativeFieldInfoPtr_SFX;
    private static readonly System.IntPtr NativeFieldInfoPtr_AudioDevice;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static AudioSettings()
    {
      Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (AudioSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr);
      GlobalState.AudioSettings.NativeFieldInfoPtr_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr, nameof (Master));
      GlobalState.AudioSettings.NativeFieldInfoPtr_Music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr, nameof (Music));
      GlobalState.AudioSettings.NativeFieldInfoPtr_SFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr, nameof (SFX));
      GlobalState.AudioSettings.NativeFieldInfoPtr_AudioDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr, nameof (AudioDevice));
      GlobalState.AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr, 100671240);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91898, XrefRangeEnd = 91899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AudioSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState.AudioSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float Master
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_Master));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_Master)) = value;
      }
    }

    public unsafe float Music
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_Music));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_Music)) = value;
      }
    }

    public unsafe float SFX
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_SFX));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_SFX)) = value;
      }
    }

    public unsafe int AudioDevice
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_AudioDevice));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.AudioSettings.NativeFieldInfoPtr_AudioDevice)) = value;
      }
    }
  }

  [Serializable]
  public class GamepadSettings(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Vibration;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static GamepadSettings()
    {
      Il2CppClassPointerStore<GlobalState.GamepadSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, nameof (GamepadSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState.GamepadSettings>.NativeClassPtr);
      GlobalState.GamepadSettings.NativeFieldInfoPtr_Vibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.GamepadSettings>.NativeClassPtr, nameof (Vibration));
      GlobalState.GamepadSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.GamepadSettings>.NativeClassPtr, 100671241);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91899, XrefRangeEnd = 91900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GamepadSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState.GamepadSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.GamepadSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float Vibration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GamepadSettings.NativeFieldInfoPtr_Vibration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState.GamepadSettings.NativeFieldInfoPtr_Vibration)) = value;
      }
    }
  }

  public enum ResetMenu
  {
    Gameplay,
    Visuals,
    Audio,
    Keyboard,
    Gamepad,
    GamepadControls,
  }

  [ObfuscatedName("SadCatStudios.Foundation.GlobalState+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__24_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeAsync_b__24_0_Internal_String_String_ArticyLanguage_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeAsync_b__24_1_Internal_Boolean_Resolution_0;

    static __c()
    {
      Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr);
      GlobalState.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr, "<>9");
      GlobalState.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr, "<>9__24_0");
      GlobalState.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr, "<>9__24_1");
      GlobalState.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr, 100671243);
      GlobalState.__c.NativeMethodInfoPtr__InitializeAsync_b__24_0_Internal_String_String_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr, 100671244);
      GlobalState.__c.NativeMethodInfoPtr__InitializeAsync_b__24_1_Internal_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr, 100671245);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91900, XrefRangeEnd = 91911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _InitializeAsync_b__24_0(string key, ArticyLanguage _)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.__c.NativeMethodInfoPtr__InitializeAsync_b__24_0_Internal_String_String_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91911, XrefRangeEnd = 91913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _InitializeAsync_b__24_1(Resolution res)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &res
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalState.__c.NativeMethodInfoPtr__InitializeAsync_b__24_1_Internal_Boolean_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe GlobalState.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GlobalState.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GlobalState.__c) null : Il2CppObjectPool.Get<GlobalState.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalState.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe CustomTextLookup __9__24_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GlobalState.__c.NativeFieldInfoPtr___9__24_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CustomTextLookup) null : Il2CppObjectPool.Get<CustomTextLookup>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalState.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<Resolution> __9__24_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GlobalState.__c.NativeFieldInfoPtr___9__24_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Predicate<Resolution>) null : Il2CppObjectPool.Get<Il2CppSystem.Predicate<Resolution>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalState.__c.NativeFieldInfoPtr___9__24_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GlobalState+<InitializeAsync>d__24")]
  public sealed class _InitializeAsync_d__24 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _InitializeAsync_d__24()
    {
      Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "<InitializeAsync>d__24");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr);
      GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr, "<>1__state");
      GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr, "<>t__builder");
      GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr, "<>u__1");
      GlobalState._InitializeAsync_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr, 100671246);
      GlobalState._InitializeAsync_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr, 100671247);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91913, XrefRangeEnd = 92006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState._InitializeAsync_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState._InitializeAsync_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _InitializeAsync_d__24(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _InitializeAsync_d__24()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState._InitializeAsync_d__24>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._InitializeAsync_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GlobalState+<LoadAndApply>d__25")]
  public sealed class _LoadAndApply_d__25 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr__res_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadAndApply_d__25()
    {
      Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "<LoadAndApply>d__25");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr);
      GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr, "<>1__state");
      GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr, "<>t__builder");
      GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr__res_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr, "<res>5__2");
      GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr, "<>u__1");
      GlobalState._LoadAndApply_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr, 100671248);
      GlobalState._LoadAndApply_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr, 100671249);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 92073, RefRangeEnd = 92077, XrefRangeStart = 92006, XrefRangeEnd = 92073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState._LoadAndApply_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlobalState._LoadAndApply_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadAndApply_d__25(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadAndApply_d__25()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState._LoadAndApply_d__25>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Promise<GlobalState> _res_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr__res_5__2));
        return num == System.IntPtr.Zero ? (Promise<GlobalState>) null : Il2CppObjectPool.Get<Promise<GlobalState>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr__res_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalState._LoadAndApply_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
