// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineBlend
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineBlend(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CamA;
  private static readonly System.IntPtr NativeFieldInfoPtr_CamB;
  private static readonly System.IntPtr NativeFieldInfoPtr_BlendCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeInBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BlendWeight_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsComplete_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Uses_Public_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICinemachineCamera_ICinemachineCamera_AnimationCurve_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraState_Public_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_CameraState_0;

  static CinemachineBlend()
  {
    Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineBlend));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr);
    CinemachineBlend.NativeFieldInfoPtr_CamA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, nameof (CamA));
    CinemachineBlend.NativeFieldInfoPtr_CamB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, nameof (CamB));
    CinemachineBlend.NativeFieldInfoPtr_BlendCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, nameof (BlendCurve));
    CinemachineBlend.NativeFieldInfoPtr_TimeInBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, nameof (TimeInBlend));
    CinemachineBlend.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, nameof (Duration));
    CinemachineBlend.NativeMethodInfoPtr_get_BlendWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663896);
    CinemachineBlend.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663897);
    CinemachineBlend.NativeMethodInfoPtr_get_IsComplete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663898);
    CinemachineBlend.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663899);
    CinemachineBlend.NativeMethodInfoPtr_Uses_Public_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663900);
    CinemachineBlend.NativeMethodInfoPtr__ctor_Public_Void_ICinemachineCamera_ICinemachineCamera_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663901);
    CinemachineBlend.NativeMethodInfoPtr_UpdateCameraState_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663902);
    CinemachineBlend.NativeMethodInfoPtr_get_State_Public_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr, 100663903);
  }

  public unsafe float BlendWeight
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 942582, RefRangeEnd = 942584, XrefRangeStart = 942579, XrefRangeEnd = 942582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_get_BlendWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsValid
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 942587, RefRangeEnd = 942592, XrefRangeStart = 942584, XrefRangeEnd = 942587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsComplete
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 942592, RefRangeEnd = 942601, XrefRangeStart = 942592, XrefRangeEnd = 942592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_get_IsComplete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string Description
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 942637, RefRangeEnd = 942638, XrefRangeStart = 942601, XrefRangeEnd = 942637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 942643, RefRangeEnd = 942654, XrefRangeStart = 942638, XrefRangeEnd = 942643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Uses(ICinemachineCamera cam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_Uses_Public_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 942655, RefRangeEnd = 942659, XrefRangeStart = 942654, XrefRangeEnd = 942655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlend(
    ICinemachineCamera a,
    ICinemachineCamera b,
    AnimationCurve curve,
    float duration,
    float t)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBlend>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr__ctor_Public_Void_ICinemachineCamera_ICinemachineCamera_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 942668, RefRangeEnd = 942677, XrefRangeStart = 942659, XrefRangeEnd = 942668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_UpdateCameraState_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CameraState State
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 942701, RefRangeEnd = 942708, XrefRangeStart = 942677, XrefRangeEnd = 942701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineBlend.NativeMethodInfoPtr_get_State_Public_get_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public unsafe ICinemachineCamera CamA
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_CamA));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_CamA), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICinemachineCamera CamB
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_CamB));
      return num == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_CamB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve BlendCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_BlendCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_BlendCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float TimeInBlend
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_TimeInBlend));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_TimeInBlend)) = value;
    }
  }

  public unsafe float Duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_Duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlend.NativeFieldInfoPtr_Duration)) = value;
    }
  }
}
