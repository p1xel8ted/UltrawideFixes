// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UISaveIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI;

public class UISaveIndicator(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_priority;
  private static readonly System.IntPtr NativeFieldInfoPtr_showHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_animator;
  private static readonly System.IntPtr NativeFieldInfoPtr_indicators;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxIndicator_Public_Static_UISaveIndicator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UISaveIndicator()
  {
    Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UISaveIndicator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr);
    UISaveIndicator.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, nameof (priority));
    UISaveIndicator.NativeFieldInfoPtr_showHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, nameof (showHash));
    UISaveIndicator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, nameof (animator));
    UISaveIndicator.NativeFieldInfoPtr_indicators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, nameof (indicators));
    UISaveIndicator.NativeMethodInfoPtr_GetMaxIndicator_Public_Static_UISaveIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, 100672221);
    UISaveIndicator.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, 100672222);
    UISaveIndicator.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, 100672223);
    UISaveIndicator.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, 100672224);
    UISaveIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, 100672225);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99412, RefRangeEnd = 99413, XrefRangeStart = 99404, XrefRangeEnd = 99412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UISaveIndicator GetMaxIndicator()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.NativeMethodInfoPtr_GetMaxIndicator_Public_Static_UISaveIndicator_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UISaveIndicator) null : Il2CppObjectPool.Get<UISaveIndicator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99434, RefRangeEnd = 99435, XrefRangeStart = 99413, XrefRangeEnd = 99434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99435, XrefRangeEnd = 99443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99443, XrefRangeEnd = 99451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99451, XrefRangeEnd = 99455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISaveIndicator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int priority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISaveIndicator.NativeFieldInfoPtr_priority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISaveIndicator.NativeFieldInfoPtr_priority)) = value;
    }
  }

  public unsafe int showHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISaveIndicator.NativeFieldInfoPtr_showHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISaveIndicator.NativeFieldInfoPtr_showHash)) = value;
    }
  }

  public unsafe Animator animator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISaveIndicator.NativeFieldInfoPtr_animator));
      return num == System.IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISaveIndicator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SortedSet<UISaveIndicator> indicators
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UISaveIndicator.NativeFieldInfoPtr_indicators, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (SortedSet<UISaveIndicator>) null : Il2CppObjectPool.Get<SortedSet<UISaveIndicator>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UISaveIndicator.NativeFieldInfoPtr_indicators, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class IndicatorComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UISaveIndicator_UISaveIndicator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static IndicatorComparer()
    {
      Il2CppClassPointerStore<UISaveIndicator.IndicatorComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISaveIndicator>.NativeClassPtr, nameof (IndicatorComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISaveIndicator.IndicatorComparer>.NativeClassPtr);
      UISaveIndicator.IndicatorComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UISaveIndicator_UISaveIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator.IndicatorComparer>.NativeClassPtr, 100672227);
      UISaveIndicator.IndicatorComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISaveIndicator.IndicatorComparer>.NativeClassPtr, 100672228);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99402, XrefRangeEnd = 99404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(UISaveIndicator x, UISaveIndicator y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.IndicatorComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UISaveIndicator_UISaveIndicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IndicatorComparer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISaveIndicator.IndicatorComparer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISaveIndicator.IndicatorComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
