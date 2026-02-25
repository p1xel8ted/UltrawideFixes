// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIBossHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using SadCatStudios.Dialogs.Articy;
using SadCatStudios.Foundation.Events;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIBossHealth(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_healthSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossName;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeFieldInfoPtr_registeredControllers;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HealthStatusChanged_Private_Void_BossHealthStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HealthChanged_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIBossHealth()
  {
    Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIBossHealth));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr);
    UIBossHealth.NativeFieldInfoPtr_healthSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, nameof (healthSlider));
    UIBossHealth.NativeFieldInfoPtr_bossName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, nameof (bossName));
    UIBossHealth.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, nameof (eventDisposable));
    UIBossHealth.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, nameof (active));
    UIBossHealth.NativeFieldInfoPtr_registeredControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, nameof (registeredControllers));
    UIBossHealth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, 100670645);
    UIBossHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, 100670646);
    UIBossHealth.NativeMethodInfoPtr_HealthStatusChanged_Private_Void_BossHealthStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, 100670647);
    UIBossHealth.NativeMethodInfoPtr_HealthChanged_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, 100670648);
    UIBossHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, 100670649);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86941, XrefRangeEnd = 86960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBossHealth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86960, XrefRangeEnd = 86997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBossHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87030, RefRangeEnd = 87031, XrefRangeStart = 86997, XrefRangeEnd = 87030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HealthStatusChanged(BossHealthStatus status)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) status))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBossHealth.NativeMethodInfoPtr_HealthStatusChanged_Private_Void_BossHealthStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87067, RefRangeEnd = 87068, XrefRangeStart = 87031, XrefRangeEnd = 87067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HealthChanged(string id, float newHealth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newHealth;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBossHealth.NativeMethodInfoPtr_HealthChanged_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87068, XrefRangeEnd = 87075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIBossHealth()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBossHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Slider healthSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_healthSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_healthSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text bossName
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_bossName));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_bossName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe Dictionary<string, UIBossHealth.BossHealthControllers> registeredControllers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_registeredControllers));
      return num == System.IntPtr.Zero ? (Dictionary<string, UIBossHealth.BossHealthControllers>) null : Il2CppObjectPool.Get<Dictionary<string, UIBossHealth.BossHealthControllers>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.NativeFieldInfoPtr_registeredControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class BossHealthControllers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Controllers;
    private static readonly System.IntPtr NativeFieldInfoPtr_BossActor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChangedCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static BossHealthControllers()
    {
      Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, nameof (BossHealthControllers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr);
      UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_Controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr, nameof (Controllers));
      UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_BossActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr, nameof (BossActor));
      UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_ChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr, nameof (ChangedCallback));
      UIBossHealth.BossHealthControllers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr, 100670650);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86925, XrefRangeEnd = 86932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BossHealthControllers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBossHealth.BossHealthControllers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIBossHealth.BossHealthControllers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe HashSet<CharacterHealthController> Controllers
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_Controllers));
        return num == System.IntPtr.Zero ? (HashSet<CharacterHealthController>) null : Il2CppObjectPool.Get<HashSet<CharacterHealthController>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_Controllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ActorReference BossActor
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_BossActor));
        return num == System.IntPtr.Zero ? (ActorReference) null : Il2CppObjectPool.Get<ActorReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_BossActor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<float> ChangedCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_ChangedCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.BossHealthControllers.NativeFieldInfoPtr_ChangedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIBossHealth+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__9_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HealthStatusChanged_b__8_0_Internal_Single_CharacterHealthController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HealthStatusChanged_b__8_1_Internal_Single_CharacterHealthController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HealthChanged_b__9_0_Internal_Single_CharacterHealthController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HealthChanged_b__9_1_Internal_Single_CharacterHealthController_0;

    static __c()
    {
      Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr);
      UIBossHealth.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, "<>9");
      UIBossHealth.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, "<>9__8_0");
      UIBossHealth.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, "<>9__8_1");
      UIBossHealth.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, "<>9__9_0");
      UIBossHealth.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, "<>9__9_1");
      UIBossHealth.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, 100670652);
      UIBossHealth.__c.NativeMethodInfoPtr__HealthStatusChanged_b__8_0_Internal_Single_CharacterHealthController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, 100670653);
      UIBossHealth.__c.NativeMethodInfoPtr__HealthStatusChanged_b__8_1_Internal_Single_CharacterHealthController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, 100670654);
      UIBossHealth.__c.NativeMethodInfoPtr__HealthChanged_b__9_0_Internal_Single_CharacterHealthController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, 100670655);
      UIBossHealth.__c.NativeMethodInfoPtr__HealthChanged_b__9_1_Internal_Single_CharacterHealthController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr, 100670656);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBossHealth.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe float _HealthStatusChanged_b__8_0(CharacterHealthController c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c.NativeMethodInfoPtr__HealthStatusChanged_b__8_0_Internal_Single_CharacterHealthController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86932, XrefRangeEnd = 86934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _HealthStatusChanged_b__8_1(CharacterHealthController c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c.NativeMethodInfoPtr__HealthStatusChanged_b__8_1_Internal_Single_CharacterHealthController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _HealthChanged_b__9_0(CharacterHealthController c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c.NativeMethodInfoPtr__HealthChanged_b__9_0_Internal_Single_CharacterHealthController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _HealthChanged_b__9_1(CharacterHealthController c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c.NativeMethodInfoPtr__HealthChanged_b__9_1_Internal_Single_CharacterHealthController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe UIBossHealth.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIBossHealth.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UIBossHealth.__c) null : Il2CppObjectPool.Get<UIBossHealth.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIBossHealth.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CharacterHealthController, float> __9__8_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIBossHealth.__c.NativeFieldInfoPtr___9__8_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CharacterHealthController, float>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CharacterHealthController, float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIBossHealth.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CharacterHealthController, float> __9__8_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIBossHealth.__c.NativeFieldInfoPtr___9__8_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CharacterHealthController, float>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CharacterHealthController, float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIBossHealth.__c.NativeFieldInfoPtr___9__8_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CharacterHealthController, float> __9__9_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIBossHealth.__c.NativeFieldInfoPtr___9__9_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CharacterHealthController, float>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CharacterHealthController, float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIBossHealth.__c.NativeFieldInfoPtr___9__9_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CharacterHealthController, float> __9__9_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UIBossHealth.__c.NativeFieldInfoPtr___9__9_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<CharacterHealthController, float>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<CharacterHealthController, float>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIBossHealth.__c.NativeFieldInfoPtr___9__9_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Replaced.Scripts.UI.UIBossHealth+<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_status;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HealthStatusChanged_b__2_Internal_Void_Single_0;

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIBossHealth>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr);
      UIBossHealth.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
      UIBossHealth.__c__DisplayClass8_0.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr, nameof (status));
      UIBossHealth.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr, 100670657);
      UIBossHealth.__c__DisplayClass8_0.NativeMethodInfoPtr__HealthStatusChanged_b__2_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr, 100670658);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass8_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBossHealth.__c__DisplayClass8_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86934, XrefRangeEnd = 86941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _HealthStatusChanged_b__2(float newHealth)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &newHealth
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIBossHealth.__c__DisplayClass8_0.NativeMethodInfoPtr__HealthStatusChanged_b__2_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UIBossHealth __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIBossHealth) null : Il2CppObjectPool.Get<UIBossHealth>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public BossHealthStatus status
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.__c__DisplayClass8_0.NativeFieldInfoPtr_status);
        return new BossHealthStatus(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBossHealth.__c__DisplayClass8_0.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
