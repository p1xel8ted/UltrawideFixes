// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.ClimbingObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class ClimbingObject(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_numOfSteps;
  private static readonly IntPtr NativeFieldInfoPtr_topStepsOffset;
  private static readonly IntPtr NativeFieldInfoPtr_bottomStepsOffset;
  private static readonly IntPtr NativeFieldInfoPtr_startOffset;
  private static readonly IntPtr NativeFieldInfoPtr_wallOffset;
  private static readonly IntPtr NativeFieldInfoPtr_stepVector;
  private static readonly IntPtr NativeFieldInfoPtr_stepOffset;
  private static readonly IntPtr NativeFieldInfoPtr_stepPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_stepVariants;
  private static readonly IntPtr NativeFieldInfoPtr_variantChance;
  private static readonly IntPtr NativeFieldInfoPtr_topStepPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_bottomStepPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreX;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreZ;
  private static readonly IntPtr NativeFieldInfoPtr_topPlatform;
  private static readonly IntPtr NativeFieldInfoPtr_topPlatformPositionAdjustment;
  private static readonly IntPtr NativeFieldInfoPtr_bottomPlatform;
  private static readonly IntPtr NativeFieldInfoPtr_bottomPlatformPositionAdjustment;
  private static readonly IntPtr NativeMethodInfoPtr_get_TopStepIndex_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BottomStepIndex_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NumOfSteps_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_StepVector_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClosestStep_Public_Int32_Vector3_Boolean_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_StepPos_Public_Vector3_Int32_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ClimbingObject()
  {
    Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (ClimbingObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr);
    ClimbingObject.NativeFieldInfoPtr_numOfSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (numOfSteps));
    ClimbingObject.NativeFieldInfoPtr_topStepsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (topStepsOffset));
    ClimbingObject.NativeFieldInfoPtr_bottomStepsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (bottomStepsOffset));
    ClimbingObject.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (startOffset));
    ClimbingObject.NativeFieldInfoPtr_wallOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (wallOffset));
    ClimbingObject.NativeFieldInfoPtr_stepVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (stepVector));
    ClimbingObject.NativeFieldInfoPtr_stepOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (stepOffset));
    ClimbingObject.NativeFieldInfoPtr_stepPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (stepPrefab));
    ClimbingObject.NativeFieldInfoPtr_stepVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (stepVariants));
    ClimbingObject.NativeFieldInfoPtr_variantChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (variantChance));
    ClimbingObject.NativeFieldInfoPtr_topStepPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (topStepPrefab));
    ClimbingObject.NativeFieldInfoPtr_bottomStepPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (bottomStepPrefab));
    ClimbingObject.NativeFieldInfoPtr_ignoreX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (ignoreX));
    ClimbingObject.NativeFieldInfoPtr_ignoreZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (ignoreZ));
    ClimbingObject.NativeFieldInfoPtr_topPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (topPlatform));
    ClimbingObject.NativeFieldInfoPtr_topPlatformPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (topPlatformPositionAdjustment));
    ClimbingObject.NativeFieldInfoPtr_bottomPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (bottomPlatform));
    ClimbingObject.NativeFieldInfoPtr_bottomPlatformPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, nameof (bottomPlatformPositionAdjustment));
    ClimbingObject.NativeMethodInfoPtr_get_TopStepIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675947);
    ClimbingObject.NativeMethodInfoPtr_get_BottomStepIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675948);
    ClimbingObject.NativeMethodInfoPtr_get_NumOfSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675949);
    ClimbingObject.NativeMethodInfoPtr_get_StepVector_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675950);
    ClimbingObject.NativeMethodInfoPtr_ClosestStep_Public_Int32_Vector3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675951);
    ClimbingObject.NativeMethodInfoPtr_StepPos_Public_Vector3_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675952);
    ClimbingObject.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675953);
    ClimbingObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr, 100675954);
  }

  public unsafe int TopStepIndex
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 120359, RefRangeEnd = 120360, XrefRangeStart = 120359, XrefRangeEnd = 120359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_get_TopStepIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BottomStepIndex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_get_BottomStepIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int NumOfSteps
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_get_NumOfSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 StepVector
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_get_StepVector_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 120374, RefRangeEnd = 120376, XrefRangeStart = 120360, XrefRangeEnd = 120374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int ClosestStep(
    Vector3 pos,
    bool ignoreTopOffset,
    bool ignoreBottomOffset,
    bool horizontal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ignoreTopOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ignoreBottomOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &horizontal;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_ClosestStep_Public_Int32_Vector3_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 120385, RefRangeEnd = 120401, XrefRangeStart = 120376, XrefRangeEnd = 120385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 StepPos(int index, Vector3 characterOriginalPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &characterOriginalPos;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_StepPos_Public_Vector3_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120401, XrefRangeEnd = 120411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120411, XrefRangeEnd = 120418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClimbingObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClimbingObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClimbingObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int numOfSteps
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_numOfSteps));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_numOfSteps)) = value;
    }
  }

  public unsafe int topStepsOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topStepsOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topStepsOffset)) = value;
    }
  }

  public unsafe int bottomStepsOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomStepsOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomStepsOffset)) = value;
    }
  }

  public unsafe Vector3 startOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_startOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_startOffset)) = value;
    }
  }

  public unsafe Vector3 wallOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_wallOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_wallOffset)) = value;
    }
  }

  public unsafe Vector3 stepVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepVector)) = value;
    }
  }

  public unsafe Vector3 stepOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepOffset)) = value;
    }
  }

  public unsafe GameObject stepPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> stepVariants
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepVariants));
      return num == IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_stepVariants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float variantChance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_variantChance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_variantChance)) = value;
    }
  }

  public unsafe GameObject topStepPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topStepPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topStepPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject bottomStepPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomStepPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomStepPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ignoreX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_ignoreX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_ignoreX)) = value;
    }
  }

  public unsafe bool ignoreZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_ignoreZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_ignoreZ)) = value;
    }
  }

  public unsafe GameObject topPlatform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topPlatform));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topPlatform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 topPlatformPositionAdjustment
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topPlatformPositionAdjustment));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_topPlatformPositionAdjustment)) = value;
    }
  }

  public unsafe GameObject bottomPlatform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomPlatform));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomPlatform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 bottomPlatformPositionAdjustment
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomPlatformPositionAdjustment));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingObject.NativeFieldInfoPtr_bottomPlatformPositionAdjustment)) = value;
    }
  }
}
