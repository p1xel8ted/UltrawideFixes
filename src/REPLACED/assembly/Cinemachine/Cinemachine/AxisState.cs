// Decompiled with JetBrains decompiler
// Type: Cinemachine.AxisState
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Cinemachine;

[Serializable]
public sealed class AxisState : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Value;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SpeedMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccelTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DecelTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAxisName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAxisValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InvertInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MinValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Wrap;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Recentering;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdateTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdateFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_Epsilon;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAxisProvider;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAxisIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr__ValueRangeLocked_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__HasRecentering_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_Boolean_Single_Single_Single_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInputAxisProvider_Public_Void_Int32_IInputAxisProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClampValue_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MaxSpeedUpdate_Private_Boolean_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxSpeed_Private_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ValueRangeLocked_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HasRecentering_Public_set_Void_Boolean_0;

  static AxisState()
  {
    Il2CppClassPointerStore<AxisState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (AxisState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisState>.NativeClassPtr);
    AxisState.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (Value));
    AxisState.NativeFieldInfoPtr_m_SpeedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_SpeedMode));
    AxisState.NativeFieldInfoPtr_m_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_MaxSpeed));
    AxisState.NativeFieldInfoPtr_m_AccelTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_AccelTime));
    AxisState.NativeFieldInfoPtr_m_DecelTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_DecelTime));
    AxisState.NativeFieldInfoPtr_m_InputAxisName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_InputAxisName));
    AxisState.NativeFieldInfoPtr_m_InputAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_InputAxisValue));
    AxisState.NativeFieldInfoPtr_m_InvertInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_InvertInput));
    AxisState.NativeFieldInfoPtr_m_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_MinValue));
    AxisState.NativeFieldInfoPtr_m_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_MaxValue));
    AxisState.NativeFieldInfoPtr_m_Wrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_Wrap));
    AxisState.NativeFieldInfoPtr_m_Recentering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_Recentering));
    AxisState.NativeFieldInfoPtr_m_CurrentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_CurrentSpeed));
    AxisState.NativeFieldInfoPtr_m_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_LastUpdateTime));
    AxisState.NativeFieldInfoPtr_m_LastUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_LastUpdateFrame));
    AxisState.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (Epsilon));
    AxisState.NativeFieldInfoPtr_m_InputAxisProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_InputAxisProvider));
    AxisState.NativeFieldInfoPtr_m_InputAxisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (m_InputAxisIndex));
    AxisState.NativeFieldInfoPtr__ValueRangeLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, "<ValueRangeLocked>k__BackingField");
    AxisState.NativeFieldInfoPtr__HasRecentering_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState>.NativeClassPtr, "<HasRecentering>k__BackingField");
    AxisState.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_Boolean_Single_Single_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663862);
    AxisState.NativeMethodInfoPtr_Validate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663863);
    AxisState.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663864);
    AxisState.NativeMethodInfoPtr_SetInputAxisProvider_Public_Void_Int32_IInputAxisProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663865);
    AxisState.NativeMethodInfoPtr_Update_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663866);
    AxisState.NativeMethodInfoPtr_ClampValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663867);
    AxisState.NativeMethodInfoPtr_MaxSpeedUpdate_Private_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663868);
    AxisState.NativeMethodInfoPtr_GetMaxSpeed_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663869);
    AxisState.NativeMethodInfoPtr_set_ValueRangeLocked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663870);
    AxisState.NativeMethodInfoPtr_set_HasRecentering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState>.NativeClassPtr, 100663871);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 942229, RefRangeEnd = 942234, XrefRangeStart = 942229, XrefRangeEnd = 942229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AxisState(
    float minValue,
    float maxValue,
    bool wrap,
    bool rangeLocked,
    float maxSpeed,
    float accelTime,
    float decelTime,
    string name,
    bool invert)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisState>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wrap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rangeLocked;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &accelTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &decelTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &invert;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_Boolean_Single_Single_Single_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 942234, RefRangeEnd = 942239, XrefRangeStart = 942234, XrefRangeEnd = 942234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Validate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_Validate_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 942239, RefRangeEnd = 942242, XrefRangeStart = 942239, XrefRangeEnd = 942239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 942242, RefRangeEnd = 942262, XrefRangeStart = 942242, XrefRangeEnd = 942242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInputAxisProvider(int axis, AxisState.IInputAxisProvider provider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) provider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_SetInputAxisProvider_Public_Void_Int32_IInputAxisProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 942293, RefRangeEnd = 942297, XrefRangeStart = 942262, XrefRangeEnd = 942293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Update(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_Update_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 942298, RefRangeEnd = 942301, XrefRangeStart = 942297, XrefRangeEnd = 942298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ClampValue(float v)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_ClampValue_Private_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942311, RefRangeEnd = 942312, XrefRangeStart = 942301, XrefRangeEnd = 942311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool MaxSpeedUpdate(float input, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_MaxSpeedUpdate_Private_Boolean_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942313, RefRangeEnd = 942314, XrefRangeStart = 942312, XrefRangeEnd = 942313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetMaxSpeed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_GetMaxSpeed_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool ValueRangeLocked
  {
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_set_ValueRangeLocked_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool HasRecentering
  {
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AxisState.NativeMethodInfoPtr_set_HasRecentering_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public AxisState(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public AxisState()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisState>.NativeClassPtr))
  {
  }

  public unsafe float Value
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_Value));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_Value)) = value;
    }
  }

  public unsafe AxisState.SpeedMode m_SpeedMode
  {
    get
    {
      return *(AxisState.SpeedMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_SpeedMode));
    }
    [param: In] set
    {
      *(AxisState.SpeedMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_SpeedMode)) = value;
    }
  }

  public unsafe float m_MaxSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_MaxSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_MaxSpeed)) = value;
    }
  }

  public unsafe float m_AccelTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_AccelTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_AccelTime)) = value;
    }
  }

  public unsafe float m_DecelTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_DecelTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_DecelTime)) = value;
    }
  }

  public unsafe string m_InputAxisName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float m_InputAxisValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisValue)) = value;
    }
  }

  public unsafe bool m_InvertInput
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InvertInput));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InvertInput)) = value;
    }
  }

  public unsafe float m_MinValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_MinValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_MinValue)) = value;
    }
  }

  public unsafe float m_MaxValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_MaxValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_MaxValue)) = value;
    }
  }

  public unsafe bool m_Wrap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_Wrap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_Wrap)) = value;
    }
  }

  public unsafe AxisState.Recentering m_Recentering
  {
    get
    {
      return *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_Recentering));
    }
    [param: In] set
    {
      *(AxisState.Recentering*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_Recentering)) = value;
    }
  }

  public unsafe float m_CurrentSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_CurrentSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_CurrentSpeed)) = value;
    }
  }

  public unsafe float m_LastUpdateTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_LastUpdateTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_LastUpdateTime)) = value;
    }
  }

  public unsafe int m_LastUpdateFrame
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_LastUpdateFrame));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_LastUpdateFrame)) = value;
    }
  }

  public static unsafe float Epsilon
  {
    get
    {
      float epsilon;
      IL2CPP.il2cpp_field_static_get_value(AxisState.NativeFieldInfoPtr_Epsilon, (void*) &epsilon);
      return epsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AxisState.NativeFieldInfoPtr_Epsilon, (void*) &value);
    }
  }

  public unsafe AxisState.IInputAxisProvider m_InputAxisProvider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisProvider));
      return num == System.IntPtr.Zero ? (AxisState.IInputAxisProvider) null : Il2CppObjectPool.Get<AxisState.IInputAxisProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_InputAxisIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr_m_InputAxisIndex)) = value;
    }
  }

  public unsafe bool _ValueRangeLocked_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr__ValueRangeLocked_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr__ValueRangeLocked_k__BackingField)) = value;
    }
  }

  public unsafe bool _HasRecentering_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr__HasRecentering_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AxisState.NativeFieldInfoPtr__HasRecentering_k__BackingField)) = value;
    }
  }

  public enum SpeedMode
  {
    MaxSpeed,
    InputValueGain,
  }

  public class IInputAxisProvider(System.IntPtr pointer) : Il2CppObjectBase(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisValue_Public_Abstract_Virtual_New_Single_Int32_0;

    static IInputAxisProvider()
    {
      Il2CppClassPointerStore<AxisState.IInputAxisProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (IInputAxisProvider));
      AxisState.IInputAxisProvider.NativeMethodInfoPtr_GetAxisValue_Public_Abstract_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState.IInputAxisProvider>.NativeClassPtr, 100663872 /*0x06000240*/);
    }

    [CallerCount(0)]
    public virtual unsafe float GetAxisValue(int axis)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &axis
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AxisState.IInputAxisProvider.NativeMethodInfoPtr_GetAxisValue_Public_Abstract_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Recentering
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_WaitTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RecenteringTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_mLastAxisInputTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_mRecenteringVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyHeadingDefinition;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyVelocityFilterStrength;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelRecentering_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoRecentering_Public_Void_byref_AxisState_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LegacyUpgrade_Internal_Boolean_byref_Int32_byref_Int32_0;
    [FieldOffset(0)]
    public bool m_enabled;
    [FieldOffset(4)]
    public float m_WaitTime;
    [FieldOffset(8)]
    public float m_RecenteringTime;
    [FieldOffset(12)]
    public float m_LastUpdateTime;
    [FieldOffset(16 /*0x10*/)]
    public float mLastAxisInputTime;
    [FieldOffset(20)]
    public float mRecenteringVelocity;
    [FieldOffset(24)]
    public int m_LegacyHeadingDefinition;
    [FieldOffset(28)]
    public int m_LegacyVelocityFilterStrength;

    static Recentering()
    {
      Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AxisState>.NativeClassPtr, nameof (Recentering));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr);
      AxisState.Recentering.NativeFieldInfoPtr_m_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (m_enabled));
      AxisState.Recentering.NativeFieldInfoPtr_m_WaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (m_WaitTime));
      AxisState.Recentering.NativeFieldInfoPtr_m_RecenteringTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (m_RecenteringTime));
      AxisState.Recentering.NativeFieldInfoPtr_m_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (m_LastUpdateTime));
      AxisState.Recentering.NativeFieldInfoPtr_mLastAxisInputTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (mLastAxisInputTime));
      AxisState.Recentering.NativeFieldInfoPtr_mRecenteringVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (mRecenteringVelocity));
      AxisState.Recentering.NativeFieldInfoPtr_m_LegacyHeadingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (m_LegacyHeadingDefinition));
      AxisState.Recentering.NativeFieldInfoPtr_m_LegacyVelocityFilterStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, nameof (m_LegacyVelocityFilterStrength));
      AxisState.Recentering.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, 100663873);
      AxisState.Recentering.NativeMethodInfoPtr_Validate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, 100663874);
      AxisState.Recentering.NativeMethodInfoPtr_CancelRecentering_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, 100663875);
      AxisState.Recentering.NativeMethodInfoPtr_DoRecentering_Public_Void_byref_AxisState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, 100663876);
      AxisState.Recentering.NativeMethodInfoPtr_LegacyUpgrade_Internal_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, 100663877);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 942192, RefRangeEnd = 942197, XrefRangeStart = 942192, XrefRangeEnd = 942192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Recentering(bool enabled, float waitTime, float recenteringTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &enabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &waitTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &recenteringTime;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AxisState.Recentering.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 942197, RefRangeEnd = 942202, XrefRangeStart = 942197, XrefRangeEnd = 942197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Validate()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AxisState.Recentering.NativeMethodInfoPtr_Validate_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 942203, RefRangeEnd = 942210, XrefRangeStart = 942202, XrefRangeEnd = 942203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelRecentering()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AxisState.Recentering.NativeMethodInfoPtr_CancelRecentering_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 942219, RefRangeEnd = 942227, XrefRangeStart = 942210, XrefRangeEnd = 942219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) axis);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &recenterTarget;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AxisState.Recentering.NativeMethodInfoPtr_DoRecentering_Public_Void_byref_AxisState_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 942227, RefRangeEnd = 942229, XrefRangeStart = 942227, XrefRangeEnd = 942227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LegacyUpgrade(ref int heading, ref int velocityFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref heading;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocityFilter;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AxisState.Recentering.NativeMethodInfoPtr_LegacyUpgrade_Internal_Boolean_byref_Int32_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisState.Recentering>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
