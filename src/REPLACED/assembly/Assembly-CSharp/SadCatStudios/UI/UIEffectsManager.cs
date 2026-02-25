// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIEffectsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI;

public class UIEffectsManager(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_manaFilledVFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaPoolController;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManaChargeFilled_Private_Void_ManaChargeFilled_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManaAdded_Private_Void_ManaChargeAdded_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ManaDrained_Private_Void_ManaDrained_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIEffectsManager()
  {
    Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIEffectsManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr);
    UIEffectsManager.NativeFieldInfoPtr_manaFilledVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, nameof (manaFilledVFX));
    UIEffectsManager.NativeFieldInfoPtr_manaPoolController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, nameof (manaPoolController));
    UIEffectsManager.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, nameof (eventDisposable));
    UIEffectsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, 100672155);
    UIEffectsManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, 100672156);
    UIEffectsManager.NativeMethodInfoPtr_ManaChargeFilled_Private_Void_ManaChargeFilled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, 100672157);
    UIEffectsManager.NativeMethodInfoPtr_ManaAdded_Private_Void_ManaChargeAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, 100672158);
    UIEffectsManager.NativeMethodInfoPtr_ManaDrained_Private_Void_ManaDrained_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, 100672159);
    UIEffectsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr, 100672160);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98645, XrefRangeEnd = 98698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIEffectsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98698, XrefRangeEnd = 98701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIEffectsManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98701, XrefRangeEnd = 98703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ManaChargeFilled(SadCatStudios.Foundation.Events.ManaChargeFilled e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIEffectsManager.NativeMethodInfoPtr_ManaChargeFilled_Private_Void_ManaChargeFilled_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98703, XrefRangeEnd = 98705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ManaAdded(ManaChargeAdded e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIEffectsManager.NativeMethodInfoPtr_ManaAdded_Private_Void_ManaChargeAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98705, XrefRangeEnd = 98707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ManaDrained(SadCatStudios.Foundation.Events.ManaDrained e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIEffectsManager.NativeMethodInfoPtr_ManaDrained_Private_Void_ManaDrained_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIEffectsManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIEffectsManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIEffectsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ParticleSystem manaFilledVFX
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIEffectsManager.NativeFieldInfoPtr_manaFilledVFX));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIEffectsManager.NativeFieldInfoPtr_manaFilledVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIStatSlider manaPoolController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIEffectsManager.NativeFieldInfoPtr_manaPoolController));
      return num == System.IntPtr.Zero ? (UIStatSlider) null : Il2CppObjectPool.Get<UIStatSlider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIEffectsManager.NativeFieldInfoPtr_manaPoolController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIEffectsManager.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIEffectsManager.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
