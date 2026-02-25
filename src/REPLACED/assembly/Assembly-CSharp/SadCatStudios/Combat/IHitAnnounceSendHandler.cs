// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IHitAnnounceSendHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class IHitAnnounceSendHandler(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SendAnnounce_Public_Abstract_Virtual_New_Void_AttackObject_0;

  static IHitAnnounceSendHandler()
  {
    Il2CppClassPointerStore<IHitAnnounceSendHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IHitAnnounceSendHandler));
    IHitAnnounceSendHandler.NativeMethodInfoPtr_SendAnnounce_Public_Abstract_Virtual_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHitAnnounceSendHandler>.NativeClassPtr, 100677130);
  }

  [CallerCount(0)]
  public virtual unsafe void SendAnnounce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IHitAnnounceSendHandler.NativeMethodInfoPtr_SendAnnounce_Public_Abstract_Virtual_New_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
