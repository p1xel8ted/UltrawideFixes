// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.ICounterReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class ICounterReceiver(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_NeedCounter_Public_Abstract_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ConnectCounter_Public_Abstract_Virtual_New_Void_ICounterFeedbackHandler_CounterCastResult_IDamage_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAttack_Public_Abstract_Virtual_New_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_InPerfectWindow_Public_Abstract_Virtual_New_Boolean_0;

  static ICounterReceiver()
  {
    Il2CppClassPointerStore<ICounterReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (ICounterReceiver));
    ICounterReceiver.NativeMethodInfoPtr_NeedCounter_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterReceiver>.NativeClassPtr, 100677261);
    ICounterReceiver.NativeMethodInfoPtr_ConnectCounter_Public_Abstract_Virtual_New_Void_ICounterFeedbackHandler_CounterCastResult_IDamage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterReceiver>.NativeClassPtr, 100677262);
    ICounterReceiver.NativeMethodInfoPtr_GetAttack_Public_Abstract_Virtual_New_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterReceiver>.NativeClassPtr, 100677263);
    ICounterReceiver.NativeMethodInfoPtr_InPerfectWindow_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterReceiver>.NativeClassPtr, 100677264);
  }

  [CallerCount(0)]
  public virtual unsafe bool NeedCounter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterReceiver.NativeMethodInfoPtr_NeedCounter_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void ConnectCounter(
    ICounterFeedbackHandler counterFeedbackHandler,
    CounterCastResult counterCastResult,
    IDamage counterAttackData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) counterFeedbackHandler);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) counterCastResult));
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) counterAttackData);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterReceiver.NativeMethodInfoPtr_ConnectCounter_Public_Abstract_Virtual_New_Void_ICounterFeedbackHandler_CounterCastResult_IDamage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe AttackObject GetAttack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterReceiver.NativeMethodInfoPtr_GetAttack_Public_Abstract_Virtual_New_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe bool InPerfectWindow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterReceiver.NativeMethodInfoPtr_InPerfectWindow_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
