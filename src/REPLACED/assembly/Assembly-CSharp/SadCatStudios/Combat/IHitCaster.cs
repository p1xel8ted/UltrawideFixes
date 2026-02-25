// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IHitCaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace SadCatStudios.Combat;

public class IHitCaster(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CastAttack_Public_Abstract_Virtual_New_Void_AttackObject_Action_1_HitCastResult_Action_1_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndCast_Public_Abstract_Virtual_New_Void_0;

  static IHitCaster()
  {
    Il2CppClassPointerStore<IHitCaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IHitCaster));
    IHitCaster.NativeMethodInfoPtr_CastAttack_Public_Abstract_Virtual_New_Void_AttackObject_Action_1_HitCastResult_Action_1_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHitCaster>.NativeClassPtr, 100677208);
    IHitCaster.NativeMethodInfoPtr_EndCast_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHitCaster>.NativeClassPtr, 100677209);
  }

  [CallerCount(0)]
  public virtual unsafe void CastAttack(
    AttackObject attack,
    Il2CppSystem.Action<HitCastResult> announceCallback,
    Il2CppSystem.Action<HitCastResult> connectionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) announceCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IHitCaster.NativeMethodInfoPtr_CastAttack_Public_Abstract_Virtual_New_Void_AttackObject_Action_1_HitCastResult_Action_1_HitCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void EndCast()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IHitCaster.NativeMethodInfoPtr_EndCast_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
