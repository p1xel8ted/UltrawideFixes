// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IGrabReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.FSM;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class IGrabReceiver(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CanBeGrabbed_Public_Abstract_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ConnectGrab_Public_Abstract_Virtual_New_Void_IGrabSender_GrabCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResolveConnection_Public_Abstract_Virtual_New_Void_GrabConnectionType_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveAttack_Public_Abstract_Virtual_New_Void_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveLaunch_Public_Abstract_Virtual_New_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_BreakGrab_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearConnection_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchFSM_Public_Abstract_Virtual_New_Void_FSMGraph_0;

  static IGrabReceiver()
  {
    Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IGrabReceiver));
    IGrabReceiver.NativeMethodInfoPtr_CanBeGrabbed_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677267);
    IGrabReceiver.NativeMethodInfoPtr_ConnectGrab_Public_Abstract_Virtual_New_Void_IGrabSender_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677268);
    IGrabReceiver.NativeMethodInfoPtr_ResolveConnection_Public_Abstract_Virtual_New_Void_GrabConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677269);
    IGrabReceiver.NativeMethodInfoPtr_ReceiveAttack_Public_Abstract_Virtual_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677270);
    IGrabReceiver.NativeMethodInfoPtr_ReceiveLaunch_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677271);
    IGrabReceiver.NativeMethodInfoPtr_BreakGrab_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677272);
    IGrabReceiver.NativeMethodInfoPtr_ClearConnection_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677273);
    IGrabReceiver.NativeMethodInfoPtr_SwitchFSM_Public_Abstract_Virtual_New_Void_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabReceiver>.NativeClassPtr, 100677274);
  }

  [CallerCount(0)]
  public virtual unsafe bool CanBeGrabbed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_CanBeGrabbed_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void ConnectGrab(IGrabSender grabSender, GrabCastResult grabCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) grabSender);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) grabCastResult));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_ConnectGrab_Public_Abstract_Virtual_New_Void_IGrabSender_GrabCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResolveConnection(GrabConnectionType connectionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &connectionType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_ResolveConnection_Public_Abstract_Virtual_New_Void_GrabConnectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveAttack(AttackObject attackData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_ReceiveAttack_Public_Abstract_Virtual_New_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveLaunch(bool turnAround = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &turnAround
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_ReceiveLaunch_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void BreakGrab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_BreakGrab_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ClearConnection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_ClearConnection_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void SwitchFSM(FSMGraph graph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabReceiver.NativeMethodInfoPtr_SwitchFSM_Public_Abstract_Virtual_New_Void_FSMGraph_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
