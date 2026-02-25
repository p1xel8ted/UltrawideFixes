// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomControllerDemo
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
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class CustomControllerDemo(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerId;
  private static readonly IntPtr NativeFieldInfoPtr_controllerTag;
  private static readonly IntPtr NativeFieldInfoPtr_useUpdateCallbacks;
  private static readonly IntPtr NativeFieldInfoPtr_buttonCount;
  private static readonly IntPtr NativeFieldInfoPtr_axisCount;
  private static readonly IntPtr NativeFieldInfoPtr_axisValues;
  private static readonly IntPtr NativeFieldInfoPtr_buttonValues;
  private static readonly IntPtr NativeFieldInfoPtr_joysticks;
  private static readonly IntPtr NativeFieldInfoPtr_buttons;
  private static readonly IntPtr NativeFieldInfoPtr_controller;
  private static readonly IntPtr NativeFieldInfoPtr_initialized;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnInputSourceUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSourceAxisValues_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSourceButtonValues_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetControllerAxisValues_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetControllerButtonValues_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAxisValueCallback_Private_Single_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetButtonValueCallback_Private_Boolean_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CustomControllerDemo()
  {
    Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (CustomControllerDemo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr);
    CustomControllerDemo.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (playerId));
    CustomControllerDemo.NativeFieldInfoPtr_controllerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (controllerTag));
    CustomControllerDemo.NativeFieldInfoPtr_useUpdateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (useUpdateCallbacks));
    CustomControllerDemo.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (buttonCount));
    CustomControllerDemo.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (axisCount));
    CustomControllerDemo.NativeFieldInfoPtr_axisValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (axisValues));
    CustomControllerDemo.NativeFieldInfoPtr_buttonValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (buttonValues));
    CustomControllerDemo.NativeFieldInfoPtr_joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (joysticks));
    CustomControllerDemo.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (buttons));
    CustomControllerDemo.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (controller));
    CustomControllerDemo.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, nameof (initialized));
    CustomControllerDemo.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670290);
    CustomControllerDemo.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670291);
    CustomControllerDemo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670292);
    CustomControllerDemo.NativeMethodInfoPtr_OnInputSourceUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670293);
    CustomControllerDemo.NativeMethodInfoPtr_GetSourceAxisValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670294);
    CustomControllerDemo.NativeMethodInfoPtr_GetSourceButtonValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670295);
    CustomControllerDemo.NativeMethodInfoPtr_SetControllerAxisValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670296);
    CustomControllerDemo.NativeMethodInfoPtr_SetControllerButtonValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670297);
    CustomControllerDemo.NativeMethodInfoPtr_GetAxisValueCallback_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670298);
    CustomControllerDemo.NativeMethodInfoPtr_GetButtonValueCallback_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670299);
    CustomControllerDemo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr, 100670300);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82776, XrefRangeEnd = 82780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82837, RefRangeEnd = 82839, XrefRangeStart = 82780, XrefRangeEnd = 82837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82839, XrefRangeEnd = 82847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82847, XrefRangeEnd = 82854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnInputSourceUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_OnInputSourceUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82854, XrefRangeEnd = 82856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetSourceAxisValues()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetSourceAxisValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82856, XrefRangeEnd = 82857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetSourceButtonValues()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetSourceButtonValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82857, XrefRangeEnd = 82859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetControllerAxisValues()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_SetControllerAxisValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82859, XrefRangeEnd = 82861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetControllerButtonValues()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_SetControllerButtonValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe float GetAxisValueCallback(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetAxisValueCallback_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool GetButtonValueCallback(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr_GetButtonValueCallback_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomControllerDemo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerDemo>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe string controllerTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controllerTag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controllerTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool useUpdateCallbacks
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_useUpdateCallbacks));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_useUpdateCallbacks)) = value;
    }
  }

  public unsafe int buttonCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonCount)) = value;
    }
  }

  public unsafe int axisCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisCount)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> axisValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisValues));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_axisValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<bool> buttonValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonValues));
      return num == IntPtr.Zero ? (Il2CppStructArray<bool>) null : Il2CppObjectPool.Get<Il2CppStructArray<bool>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttonValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TouchJoystickExample> joysticks
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_joysticks));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<TouchJoystickExample>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TouchJoystickExample>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_joysticks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TouchButtonExample> buttons
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttons));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<TouchButtonExample>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TouchButtonExample>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CustomController controller
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controller));
      return num == IntPtr.Zero ? (CustomController) null : Il2CppObjectPool.Get<CustomController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomControllerDemo.NativeFieldInfoPtr_initialized)) = value;
    }
  }
}
