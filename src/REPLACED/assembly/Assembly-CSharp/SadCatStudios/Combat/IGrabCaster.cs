// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IGrabCaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace SadCatStudios.Combat;

public class IGrabCaster(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_Action_1_GrabCastResult_0;

  static IGrabCaster()
  {
    Il2CppClassPointerStore<IGrabCaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IGrabCaster));
    IGrabCaster.NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_Action_1_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabCaster>.NativeClassPtr, 100677206);
  }

  [CallerCount(0)]
  public virtual unsafe void CastGrab(Il2CppSystem.Action<GrabCastResult> grabCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) grabCallback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabCaster.NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_Action_1_GrabCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
