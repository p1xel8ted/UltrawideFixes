// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.InputDecisions.InputDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Decisions.InputDecisions;

public class InputDecision(IntPtr pointer) : ForkDecisionObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_inputNode;
  private static readonly IntPtr NativeFieldInfoPtr_walkController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_axisCancelled;
  private static readonly IntPtr NativeFieldInfoPtr_cacheResult;
  private static readonly IntPtr NativeFieldInfoPtr_targetTime;
  private static readonly IntPtr NativeFieldInfoPtr_currTimer;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_HandleDelay_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CancelAxis_Private_Void_Boolean_0;

  static InputDecision()
  {
    Il2CppClassPointerStore<InputDecision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.InputDecisions", nameof (InputDecision));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDecision>.NativeClassPtr);
    InputDecision.NativeFieldInfoPtr_inputNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (inputNode));
    InputDecision.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (walkController));
    InputDecision.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (rotationController));
    InputDecision.NativeFieldInfoPtr_axisCancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (axisCancelled));
    InputDecision.NativeFieldInfoPtr_cacheResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (cacheResult));
    InputDecision.NativeFieldInfoPtr_targetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (targetTime));
    InputDecision.NativeFieldInfoPtr_currTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, nameof (currTimer));
    InputDecision.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673506);
    InputDecision.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673507);
    InputDecision.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673508);
    InputDecision.NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673509);
    InputDecision.NativeMethodInfoPtr_HandleDelay_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673510);
    InputDecision.NativeMethodInfoPtr_HandleInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673511);
    InputDecision.NativeMethodInfoPtr_CancelAxis_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecision>.NativeClassPtr, 100673512);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109821, XrefRangeEnd = 109822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputDecision(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDecision>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputDecision.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109822, XrefRangeEnd = 109831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputDecision.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputDecision.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109831, XrefRangeEnd = 109834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Reason()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputDecision.NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109834, XrefRangeEnd = 109835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HandleDelay(bool isPressed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isPressed
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputDecision.NativeMethodInfoPtr_HandleDelay_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109889, RefRangeEnd = 109890, XrefRangeStart = 109835, XrefRangeEnd = 109889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecision.NativeMethodInfoPtr_HandleInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void CancelAxis(bool isPressed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isPressed
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputDecision.NativeMethodInfoPtr_CancelAxis_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InputDecisionNode inputNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_inputNode));
      return num == IntPtr.Zero ? (InputDecisionNode) null : Il2CppObjectPool.Get<InputDecisionNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_inputNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_walkController));
      return num == IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool axisCancelled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_axisCancelled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_axisCancelled)) = value;
    }
  }

  public unsafe bool cacheResult
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_cacheResult));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_cacheResult)) = value;
    }
  }

  public unsafe float targetTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_targetTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_targetTime)) = value;
    }
  }

  public unsafe float currTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_currTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecision.NativeFieldInfoPtr_currTimer)) = value;
    }
  }
}
