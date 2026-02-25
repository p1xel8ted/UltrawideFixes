// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.TransitToGraphWithPivotBlend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class TransitToGraphWithPivotBlend(IntPtr pointer) : Node(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Enter;
  private static readonly IntPtr NativeFieldInfoPtr_targetGraph;
  private static readonly IntPtr NativeFieldInfoPtr_transitClip;
  private static readonly IntPtr NativeFieldInfoPtr_cancellable;
  private static readonly IntPtr NativeFieldInfoPtr_blendOffset;
  private static readonly IntPtr NativeFieldInfoPtr_controller;
  private static readonly IntPtr NativeMethodInfoPtr_get_TargetGraph_Public_get_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BlendOffset_Public_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TransitClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Cancellable_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_Final_New_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TransitToGraphWithPivotBlend()
  {
    Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (TransitToGraphWithPivotBlend));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr);
    TransitToGraphWithPivotBlend.NativeFieldInfoPtr_Enter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, nameof (Enter));
    TransitToGraphWithPivotBlend.NativeFieldInfoPtr_targetGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, nameof (targetGraph));
    TransitToGraphWithPivotBlend.NativeFieldInfoPtr_transitClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, nameof (transitClip));
    TransitToGraphWithPivotBlend.NativeFieldInfoPtr_cancellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, nameof (cancellable));
    TransitToGraphWithPivotBlend.NativeFieldInfoPtr_blendOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, nameof (blendOffset));
    TransitToGraphWithPivotBlend.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, nameof (controller));
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_TargetGraph_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673318);
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_BlendOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673319);
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_TransitClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673320);
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_Cancellable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673321);
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr_Init_Public_Void_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673322);
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Final_New_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673323);
    TransitToGraphWithPivotBlend.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr, 100673324);
  }

  public unsafe FSMGraph TargetGraph
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_TargetGraph_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  public unsafe Vector2 BlendOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_BlendOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MeshClip TransitClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_TransitClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe bool Cancellable
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr_get_Cancellable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(StateController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr_Init_Public_Void_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109439, XrefRangeEnd = 109448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Final_New_IFSMObject_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TransitToGraphWithPivotBlend()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitToGraphWithPivotBlend>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransitToGraphWithPivotBlend.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FSMGraph Enter
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_Enter));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_Enter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph targetGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_targetGraph));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_targetGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip transitClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_transitClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_transitClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool cancellable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_cancellable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_cancellable)) = value;
    }
  }

  public unsafe Vector2 blendOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_blendOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_blendOffset)) = value;
    }
  }

  public unsafe StateController controller
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_controller));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitToGraphWithPivotBlend.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
