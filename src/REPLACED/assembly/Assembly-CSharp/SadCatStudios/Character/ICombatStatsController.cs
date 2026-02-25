// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.ICombatStatsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Combat;
using System;

#nullable disable
namespace SadCatStudios.Character;

public class ICombatStatsController(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ProcessSentAttack_Public_Abstract_Virtual_New_Void_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessConnectedAttack_Public_Abstract_Virtual_New_Void_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessReceivedAttack_Public_Abstract_Virtual_New_Void_AttackObject_0;

  static ICombatStatsController()
  {
    Il2CppClassPointerStore<ICombatStatsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (ICombatStatsController));
    ICombatStatsController.NativeMethodInfoPtr_ProcessSentAttack_Public_Abstract_Virtual_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatStatsController>.NativeClassPtr, 100675580);
    ICombatStatsController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Abstract_Virtual_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatStatsController>.NativeClassPtr, 100675581);
    ICombatStatsController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Abstract_Virtual_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICombatStatsController>.NativeClassPtr, 100675582);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessSentAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICombatStatsController.NativeMethodInfoPtr_ProcessSentAttack_Public_Abstract_Virtual_New_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessConnectedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICombatStatsController.NativeMethodInfoPtr_ProcessConnectedAttack_Public_Abstract_Virtual_New_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessReceivedAttack(AttackObject attackObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICombatStatsController.NativeMethodInfoPtr_ProcessReceivedAttack_Public_Abstract_Virtual_New_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
