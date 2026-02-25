// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterClimbController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Environment;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterClimbController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly IntPtr NativeFieldInfoPtr_grabController;
  private static readonly IntPtr NativeFieldInfoPtr_currClimbingObject;
  private static readonly IntPtr NativeFieldInfoPtr_currIndex;
  private static readonly IntPtr NativeFieldInfoPtr_nextClimbingObjectDistance;
  private static readonly IntPtr NativeFieldInfoPtr_oddStep;
  private static readonly IntPtr NativeFieldInfoPtr_horizontal;
  private static readonly IntPtr NativeMethodInfoPtr_get_OddStep_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NextClimbingObjectDistance_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapToClimbingObject_Public_Vector3_Boolean_Boolean_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapToClimbingObject_Public_Vector3_Boolean_Boolean_Boolean_Boolean_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CountStep_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveToTop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveToBottom_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsTop_Public_Boolean_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsBottom_Public_Boolean_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_RightDirection_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterClimbController()
  {
    Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterClimbController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr);
    CharacterClimbController.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (personPhysics));
    CharacterClimbController.NativeFieldInfoPtr_grabController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (grabController));
    CharacterClimbController.NativeFieldInfoPtr_currClimbingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (currClimbingObject));
    CharacterClimbController.NativeFieldInfoPtr_currIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (currIndex));
    CharacterClimbController.NativeFieldInfoPtr_nextClimbingObjectDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (nextClimbingObjectDistance));
    CharacterClimbController.NativeFieldInfoPtr_oddStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (oddStep));
    CharacterClimbController.NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, nameof (horizontal));
    CharacterClimbController.NativeMethodInfoPtr_get_OddStep_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674941);
    CharacterClimbController.NativeMethodInfoPtr_get_NextClimbingObjectDistance_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674942);
    CharacterClimbController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674943);
    CharacterClimbController.NativeMethodInfoPtr_SnapToClimbingObject_Public_Vector3_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674944);
    CharacterClimbController.NativeMethodInfoPtr_SnapToClimbingObject_Public_Vector3_Boolean_Boolean_Boolean_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674945);
    CharacterClimbController.NativeMethodInfoPtr_MoveUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674946);
    CharacterClimbController.NativeMethodInfoPtr_MoveDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674947);
    CharacterClimbController.NativeMethodInfoPtr_CountStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674948);
    CharacterClimbController.NativeMethodInfoPtr_MoveToTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674949);
    CharacterClimbController.NativeMethodInfoPtr_MoveToBottom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674950);
    CharacterClimbController.NativeMethodInfoPtr_IsTop_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674951);
    CharacterClimbController.NativeMethodInfoPtr_IsBottom_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674952);
    CharacterClimbController.NativeMethodInfoPtr_RightDirection_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674953);
    CharacterClimbController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr, 100674954);
  }

  public unsafe bool OddStep
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_get_OddStep_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 NextClimbingObjectDistance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_get_NextClimbingObjectDistance_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114301, XrefRangeEnd = 114307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114318, RefRangeEnd = 114319, XrefRangeStart = 114307, XrefRangeEnd = 114318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 SnapToClimbingObject(
    bool ignoreTopOffset,
    bool ignoreBottomOffset,
    bool horizontal,
    bool reset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &ignoreTopOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ignoreBottomOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &horizontal;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &reset;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_SnapToClimbingObject_Public_Vector3_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114319, XrefRangeEnd = 114327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 SnapToClimbingObject(
    bool ignoreTopOffset,
    bool ignoreBottomOffset,
    bool horizontal,
    bool reset,
    Vector3 closestPoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &ignoreTopOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ignoreBottomOffset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &horizontal;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &reset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &closestPoint;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_SnapToClimbingObject_Public_Vector3_Boolean_Boolean_Boolean_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114333, RefRangeEnd = 114334, XrefRangeStart = 114327, XrefRangeEnd = 114333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_MoveUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 114340, RefRangeEnd = 114343, XrefRangeStart = 114334, XrefRangeEnd = 114340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_MoveDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114343, RefRangeEnd = 114344, XrefRangeStart = 114343, XrefRangeEnd = 114343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CountStep()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_CountStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114355, RefRangeEnd = 114356, XrefRangeStart = 114344, XrefRangeEnd = 114355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToTop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_MoveToTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114367, RefRangeEnd = 114368, XrefRangeStart = 114356, XrefRangeEnd = 114367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToBottom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_MoveToBottom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114369, RefRangeEnd = 114370, XrefRangeStart = 114368, XrefRangeEnd = 114369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsTop(int extraSteps = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &extraSteps
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_IsTop_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114370, RefRangeEnd = 114371, XrefRangeStart = 114370, XrefRangeEnd = 114370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsBottom(int extraSteps = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &extraSteps
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_IsBottom_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114374, RefRangeEnd = 114375, XrefRangeStart = 114371, XrefRangeEnd = 114374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RightDirection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr_RightDirection_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114375, XrefRangeEnd = 114376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterClimbController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterClimbController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterClimbController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_personPhysics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController grabController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_grabController));
      return num == IntPtr.Zero ? (CharacterGrabController) null : Il2CppObjectPool.Get<CharacterGrabController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_grabController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClimbingObject currClimbingObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_currClimbingObject));
      return num == IntPtr.Zero ? (ClimbingObject) null : Il2CppObjectPool.Get<ClimbingObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_currClimbingObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_currIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_currIndex)) = value;
    }
  }

  public unsafe Vector3 nextClimbingObjectDistance
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_nextClimbingObjectDistance));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_nextClimbingObjectDistance)) = value;
    }
  }

  public unsafe bool oddStep
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_oddStep));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_oddStep)) = value;
    }
  }

  public unsafe bool horizontal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_horizontal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterClimbController.NativeFieldInfoPtr_horizontal)) = value;
    }
  }
}
