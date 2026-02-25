// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.TouchButtonExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Demos;

public class TouchButtonExample(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_allowMouseControl;
  private static readonly IntPtr NativeFieldInfoPtr__isPressed_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_isPressed_Private_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Restart_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TouchButtonExample()
  {
    Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (TouchButtonExample));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr);
    TouchButtonExample.NativeFieldInfoPtr_allowMouseControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, nameof (allowMouseControl));
    TouchButtonExample.NativeFieldInfoPtr__isPressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, "<isPressed>k__BackingField");
    TouchButtonExample.NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670305);
    TouchButtonExample.NativeMethodInfoPtr_set_isPressed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670306);
    TouchButtonExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670307);
    TouchButtonExample.NativeMethodInfoPtr_Restart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670308);
    TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670309);
    TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670310);
    TouchButtonExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670311);
    TouchButtonExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100670312);
  }

  public unsafe bool isPressed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_set_isPressed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82926, XrefRangeEnd = 82927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Restart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_Restart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown(
    PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(
    PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe bool IsMousePointerId(int id)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &id
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 82928, RefRangeEnd = 82943, XrefRangeStart = 82927, XrefRangeEnd = 82928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchButtonExample()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool allowMouseControl
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr_allowMouseControl));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr_allowMouseControl)) = value;
    }
  }

  public unsafe bool _isPressed_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr__isPressed_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr__isPressed_k__BackingField)) = value;
    }
  }
}
