// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.ICharacterHitSender
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

public class ICharacterHitSender(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SendAttack_Public_Abstract_Virtual_New_Void_AttackData_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveBlockFeedback_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveHitFeedback_Public_Abstract_Virtual_New_Void_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveStateFeedback_Public_Abstract_Virtual_New_Void_FSMGraph_0;

  static ICharacterHitSender()
  {
    Il2CppClassPointerStore<ICharacterHitSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (ICharacterHitSender));
    ICharacterHitSender.NativeMethodInfoPtr_SendAttack_Public_Abstract_Virtual_New_Void_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterHitSender>.NativeClassPtr, 100677401);
    ICharacterHitSender.NativeMethodInfoPtr_ReceiveBlockFeedback_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterHitSender>.NativeClassPtr, 100677402);
    ICharacterHitSender.NativeMethodInfoPtr_ReceiveHitFeedback_Public_Abstract_Virtual_New_Void_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterHitSender>.NativeClassPtr, 100677403);
    ICharacterHitSender.NativeMethodInfoPtr_ReceiveStateFeedback_Public_Abstract_Virtual_New_Void_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICharacterHitSender>.NativeClassPtr, 100677404);
  }

  [CallerCount(0)]
  public virtual unsafe void SendAttack(AttackData attackData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICharacterHitSender.NativeMethodInfoPtr_SendAttack_Public_Abstract_Virtual_New_Void_AttackData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveBlockFeedback()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICharacterHitSender.NativeMethodInfoPtr_ReceiveBlockFeedback_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveHitFeedback(HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICharacterHitSender.NativeMethodInfoPtr_ReceiveHitFeedback_Public_Abstract_Virtual_New_Void_HitCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveStateFeedback(FSMGraph graph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICharacterHitSender.NativeMethodInfoPtr_ReceiveStateFeedback_Public_Abstract_Virtual_New_Void_FSMGraph_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
