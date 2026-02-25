// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IDeathHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class IDeathHandler(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_OnKill_Public_Abstract_Virtual_New_Void_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnRespawn_Public_Abstract_Virtual_New_Void_0;

  static IDeathHandler()
  {
    Il2CppClassPointerStore<IDeathHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IDeathHandler));
    IDeathHandler.NativeMethodInfoPtr_OnKill_Public_Abstract_Virtual_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeathHandler>.NativeClassPtr, 100677641);
    IDeathHandler.NativeMethodInfoPtr_OnRespawn_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeathHandler>.NativeClassPtr, 100677642);
  }

  [CallerCount(0)]
  public virtual unsafe void OnKill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &deathType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDeathHandler.NativeMethodInfoPtr_OnKill_Public_Abstract_Virtual_New_Void_DeathType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnRespawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDeathHandler.NativeMethodInfoPtr_OnRespawn_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
