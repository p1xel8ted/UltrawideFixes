// Decompiled with JetBrains decompiler
// Type: CinemachineTouchInputMapper
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CinemachineTouchInputMapper(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_TouchSensitivityX;
  private static readonly IntPtr NativeFieldInfoPtr_TouchSensitivityY;
  private static readonly IntPtr NativeFieldInfoPtr_TouchXInputMapTo;
  private static readonly IntPtr NativeFieldInfoPtr_TouchYInputMapTo;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetInputAxis_Private_Single_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineTouchInputMapper()
  {
    Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineTouchInputMapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr);
    CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchSensitivityX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, nameof (TouchSensitivityX));
    CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchSensitivityY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, nameof (TouchSensitivityY));
    CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchXInputMapTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, nameof (TouchXInputMapTo));
    CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchYInputMapTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, nameof (TouchYInputMapTo));
    CinemachineTouchInputMapper.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, 100663304 /*0x06000008*/);
    CinemachineTouchInputMapper.NativeMethodInfoPtr_GetInputAxis_Private_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, 100663305 /*0x06000009*/);
    CinemachineTouchInputMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr, 100663306 /*0x0600000A*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936561, XrefRangeEnd = 936571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTouchInputMapper.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936571, XrefRangeEnd = 936576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetInputAxis(string axisName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(axisName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTouchInputMapper.NativeMethodInfoPtr_GetInputAxis_Private_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936576, XrefRangeEnd = 936581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineTouchInputMapper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTouchInputMapper>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTouchInputMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float TouchSensitivityX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchSensitivityX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchSensitivityX)) = value;
    }
  }

  public unsafe float TouchSensitivityY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchSensitivityY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchSensitivityY)) = value;
    }
  }

  public unsafe string TouchXInputMapTo
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchXInputMapTo)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchXInputMapTo), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string TouchYInputMapTo
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchYInputMapTo)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTouchInputMapper.NativeFieldInfoPtr_TouchYInputMapTo), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
