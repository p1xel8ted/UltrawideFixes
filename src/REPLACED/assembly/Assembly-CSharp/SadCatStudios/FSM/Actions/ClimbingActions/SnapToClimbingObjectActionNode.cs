// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.ClimbingActions.SnapToClimbingObjectActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.ClimbingActions;

public class SnapToClimbingObjectActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ignoreTopOffset;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreBottomOffset;
  private static readonly IntPtr NativeFieldInfoPtr_horizontal;
  private static readonly IntPtr NativeFieldInfoPtr_dontResetStepCounter;
  private static readonly IntPtr NativeFieldInfoPtr_snapToGround;
  private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreTopOffset_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreBottomOffset_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Horizontal_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DontResetStepCounter_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SnapToGround_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SnapToClimbingObjectActionNode()
  {
    Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.ClimbingActions", nameof (SnapToClimbingObjectActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr);
    SnapToClimbingObjectActionNode.NativeFieldInfoPtr_ignoreTopOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, nameof (ignoreTopOffset));
    SnapToClimbingObjectActionNode.NativeFieldInfoPtr_ignoreBottomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, nameof (ignoreBottomOffset));
    SnapToClimbingObjectActionNode.NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, nameof (horizontal));
    SnapToClimbingObjectActionNode.NativeFieldInfoPtr_dontResetStepCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, nameof (dontResetStepCounter));
    SnapToClimbingObjectActionNode.NativeFieldInfoPtr_snapToGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, nameof (snapToGround));
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_IgnoreTopOffset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674120);
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_IgnoreBottomOffset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674121);
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_Horizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674122);
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_DontResetStepCounter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674123);
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_SnapToGround_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674124);
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674125);
    SnapToClimbingObjectActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr, 100674126);
  }

  public unsafe bool IgnoreTopOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_IgnoreTopOffset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IgnoreBottomOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_IgnoreBottomOffset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Horizontal
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_Horizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool DontResetStepCounter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_DontResetStepCounter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool SnapToGround
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToClimbingObjectActionNode.NativeMethodInfoPtr_get_SnapToGround_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111366, XrefRangeEnd = 111370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnapToClimbingObjectActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 111108, RefRangeEnd = 111111, XrefRangeStart = 111108, XrefRangeEnd = 111111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SnapToClimbingObjectActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnapToClimbingObjectActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SnapToClimbingObjectActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool ignoreTopOffset
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_ignoreTopOffset));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_ignoreTopOffset)) = value;
    }
  }

  public unsafe bool ignoreBottomOffset
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_ignoreBottomOffset));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_ignoreBottomOffset)) = value;
    }
  }

  public unsafe bool horizontal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_horizontal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_horizontal)) = value;
    }
  }

  public unsafe bool dontResetStepCounter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_dontResetStepCounter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_dontResetStepCounter)) = value;
    }
  }

  public unsafe bool snapToGround
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_snapToGround));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToClimbingObjectActionNode.NativeFieldInfoPtr_snapToGround)) = value;
    }
  }
}
