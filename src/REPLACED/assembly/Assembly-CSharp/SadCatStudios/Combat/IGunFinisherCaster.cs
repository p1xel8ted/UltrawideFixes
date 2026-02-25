// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IGunFinisherCaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace SadCatStudios.Combat;

public class IGunFinisherCaster(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_IGunFinisherSender_Action_1_FinisherCastResult_0;

  static IGunFinisherCaster()
  {
    Il2CppClassPointerStore<IGunFinisherCaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IGunFinisherCaster));
    IGunFinisherCaster.NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_IGunFinisherSender_Action_1_FinisherCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGunFinisherCaster>.NativeClassPtr, 100677207);
  }

  [CallerCount(0)]
  public virtual unsafe void CastGrab(
    IGunFinisherSender finisherSender,
    Il2CppSystem.Action<FinisherCastResult> successCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finisherSender);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) successCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGunFinisherCaster.NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_IGunFinisherSender_Action_1_FinisherCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
