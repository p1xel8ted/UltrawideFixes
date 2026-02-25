// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.TouchJoystickExample
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

public class TouchJoystickExample(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_allowMouseControl;
  private static readonly IntPtr NativeFieldInfoPtr_radius;
  private static readonly IntPtr NativeFieldInfoPtr_origAnchoredPosition;
  private static readonly IntPtr NativeFieldInfoPtr_origWorldPosition;
  private static readonly IntPtr NativeFieldInfoPtr_origScreenResolution;
  private static readonly IntPtr NativeFieldInfoPtr_origScreenOrientation;
  private static readonly IntPtr NativeFieldInfoPtr_hasFinger;
  private static readonly IntPtr NativeFieldInfoPtr_lastFingerId;
  private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Restart_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StoreOrigValues_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TouchJoystickExample()
  {
    Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (TouchJoystickExample));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr);
    TouchJoystickExample.NativeFieldInfoPtr_allowMouseControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (allowMouseControl));
    TouchJoystickExample.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (radius));
    TouchJoystickExample.NativeFieldInfoPtr_origAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (origAnchoredPosition));
    TouchJoystickExample.NativeFieldInfoPtr_origWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (origWorldPosition));
    TouchJoystickExample.NativeFieldInfoPtr_origScreenResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (origScreenResolution));
    TouchJoystickExample.NativeFieldInfoPtr_origScreenOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (origScreenOrientation));
    TouchJoystickExample.NativeFieldInfoPtr_hasFinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (hasFinger));
    TouchJoystickExample.NativeFieldInfoPtr_lastFingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, nameof (lastFingerId));
    TouchJoystickExample.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "<position>k__BackingField");
    TouchJoystickExample.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670313);
    TouchJoystickExample.NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670314);
    TouchJoystickExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670315);
    TouchJoystickExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670316);
    TouchJoystickExample.NativeMethodInfoPtr_Restart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670317);
    TouchJoystickExample.NativeMethodInfoPtr_StoreOrigValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670318);
    TouchJoystickExample.NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670319);
    TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670320);
    TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670321);
    TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670322);
    TouchJoystickExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670323);
    TouchJoystickExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100670324);
  }

  public unsafe Vector2 position
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82943, XrefRangeEnd = 82945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82945, XrefRangeEnd = 82950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82956, RefRangeEnd = 82958, XrefRangeStart = 82950, XrefRangeEnd = 82956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Restart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_Restart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82967, RefRangeEnd = 82969, XrefRangeStart = 82958, XrefRangeEnd = 82967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StoreOrigValues()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_StoreOrigValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void UpdateValue(Vector3 value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82969, XrefRangeEnd = 82970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(
    PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82970, XrefRangeEnd = 82977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_EventSystems_IDragHandler_OnDrag(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82977, XrefRangeEnd = 82978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchJoystickExample()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchJoystickExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool allowMouseControl
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_allowMouseControl));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_allowMouseControl)) = value;
    }
  }

  public unsafe int radius
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_radius));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_radius)) = value;
    }
  }

  public unsafe Vector2 origAnchoredPosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origAnchoredPosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origAnchoredPosition)) = value;
    }
  }

  public unsafe Vector3 origWorldPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origWorldPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origWorldPosition)) = value;
    }
  }

  public unsafe Vector2 origScreenResolution
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenResolution));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenResolution)) = value;
    }
  }

  public unsafe ScreenOrientation origScreenOrientation
  {
    get
    {
      return *(ScreenOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenOrientation));
    }
    [param: In] set
    {
      *(ScreenOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_origScreenOrientation)) = value;
    }
  }

  public unsafe bool hasFinger
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_hasFinger));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_hasFinger)) = value;
    }
  }

  public unsafe int lastFingerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_lastFingerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr_lastFingerId)) = value;
    }
  }

  public unsafe Vector2 _position_k__BackingField
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr__position_k__BackingField));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchJoystickExample.NativeFieldInfoPtr__position_k__BackingField)) = value;
    }
  }
}
