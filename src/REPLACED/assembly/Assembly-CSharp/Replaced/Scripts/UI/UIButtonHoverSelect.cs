// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIButtonHoverSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIButtonHoverSelect(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_selectSound;
  private static readonly IntPtr NativeFieldInfoPtr_submitSound;
  private static readonly IntPtr NativeFieldInfoPtr_selectAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_submitAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_selectCallback;
  private static readonly IntPtr NativeFieldInfoPtr_deselectCallback;
  private static readonly IntPtr NativeFieldInfoPtr_selectAnimatorParams;
  private static readonly IntPtr NativeFieldInfoPtr_submitAnimatorParams;
  private static readonly IntPtr NativeFieldInfoPtr_selectable;
  private static readonly IntPtr NativeMethodInfoPtr_GatherParams_Private_Void_Animator_byref_List_1_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_RandomTrigger_Private_Void_Animator_List_1_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIButtonHoverSelect()
  {
    Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIButtonHoverSelect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr);
    UIButtonHoverSelect.NativeFieldInfoPtr_selectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (selectSound));
    UIButtonHoverSelect.NativeFieldInfoPtr_submitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (submitSound));
    UIButtonHoverSelect.NativeFieldInfoPtr_selectAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (selectAnimator));
    UIButtonHoverSelect.NativeFieldInfoPtr_submitAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (submitAnimator));
    UIButtonHoverSelect.NativeFieldInfoPtr_selectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (selectCallback));
    UIButtonHoverSelect.NativeFieldInfoPtr_deselectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (deselectCallback));
    UIButtonHoverSelect.NativeFieldInfoPtr_selectAnimatorParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (selectAnimatorParams));
    UIButtonHoverSelect.NativeFieldInfoPtr_submitAnimatorParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (submitAnimatorParams));
    UIButtonHoverSelect.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, nameof (selectable));
    UIButtonHoverSelect.NativeMethodInfoPtr_GatherParams_Private_Void_Animator_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670659);
    UIButtonHoverSelect.NativeMethodInfoPtr_RandomTrigger_Private_Void_Animator_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670660);
    UIButtonHoverSelect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670661);
    UIButtonHoverSelect.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670662);
    UIButtonHoverSelect.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670663);
    UIButtonHoverSelect.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670664);
    UIButtonHoverSelect.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670665);
    UIButtonHoverSelect.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670666);
    UIButtonHoverSelect.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670667);
    UIButtonHoverSelect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr, 100670668);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87092, RefRangeEnd = 87094, XrefRangeStart = 87075, XrefRangeEnd = 87092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GatherParams(Animator animator, ref List<int> animatorParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animatorParams);
    IntPtr* numPtr2 = &ptr;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_GatherParams_Private_Void_Animator_byref_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref List<int> local = ref animatorParams;
    IntPtr pointer = ptr;
    List<int> list = pointer == IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    local = list;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87094, XrefRangeEnd = 87100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RandomTrigger(Animator animator, List<int> animatorParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animatorParams);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_RandomTrigger_Private_Void_Animator_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87100, XrefRangeEnd = 87105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87105, XrefRangeEnd = 87119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87119, XrefRangeEnd = 87120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87120, XrefRangeEnd = 87133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSubmit(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87133, XrefRangeEnd = 87139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnPointerEnter(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87139, XrefRangeEnd = 87160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnPointerUp(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonHoverSelect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonHoverSelect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonHoverSelect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference selectSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectSound)) = value;
    }
  }

  public unsafe EventReference submitSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_submitSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_submitSound)) = value;
    }
  }

  public unsafe Animator selectAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectAnimator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Animator submitAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_submitAnimator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_submitAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent selectCallback
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectCallback));
      return num == IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent deselectCallback
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_deselectCallback));
      return num == IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_deselectCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> selectAnimatorParams
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectAnimatorParams));
      return num == IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectAnimatorParams), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> submitAnimatorParams
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_submitAnimatorParams));
      return num == IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_submitAnimatorParams), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Selectable selectable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectable));
      return num == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonHoverSelect.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
