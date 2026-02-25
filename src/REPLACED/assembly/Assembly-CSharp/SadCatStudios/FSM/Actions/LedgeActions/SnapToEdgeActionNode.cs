// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.LedgeActions.SnapToEdgeActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Actions.LedgeActions;

public class SnapToEdgeActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_rayOffset;
  private static readonly IntPtr NativeFieldInfoPtr_rayLength;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayOffset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayLength_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SnapToEdgeActionNode()
  {
    Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.LedgeActions", nameof (SnapToEdgeActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr);
    SnapToEdgeActionNode.NativeFieldInfoPtr_rayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr, nameof (rayOffset));
    SnapToEdgeActionNode.NativeFieldInfoPtr_rayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr, nameof (rayLength));
    SnapToEdgeActionNode.NativeMethodInfoPtr_get_RayOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr, 100673892);
    SnapToEdgeActionNode.NativeMethodInfoPtr_get_RayLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr, 100673893);
    SnapToEdgeActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr, 100673894);
    SnapToEdgeActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr, 100673895);
  }

  public unsafe Vector3 RayOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToEdgeActionNode.NativeMethodInfoPtr_get_RayOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float RayLength
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 72923, RefRangeEnd = 72924, XrefRangeStart = 72923, XrefRangeEnd = 72924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SnapToEdgeActionNode.NativeMethodInfoPtr_get_RayLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110745, XrefRangeEnd = 110749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnapToEdgeActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110749, XrefRangeEnd = 110750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SnapToEdgeActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnapToEdgeActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SnapToEdgeActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 rayOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToEdgeActionNode.NativeFieldInfoPtr_rayOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToEdgeActionNode.NativeFieldInfoPtr_rayOffset)) = value;
    }
  }

  public unsafe float rayLength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToEdgeActionNode.NativeFieldInfoPtr_rayLength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnapToEdgeActionNode.NativeFieldInfoPtr_rayLength)) = value;
    }
  }
}
