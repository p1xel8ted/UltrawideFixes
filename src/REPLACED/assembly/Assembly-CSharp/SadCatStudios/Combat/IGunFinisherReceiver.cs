// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IGunFinisherReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class IGunFinisherReceiver(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveFinisher_Public_Abstract_Virtual_New_Void_FinisherCastResult_0;

  static IGunFinisherReceiver()
  {
    Il2CppClassPointerStore<IGunFinisherReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IGunFinisherReceiver));
    IGunFinisherReceiver.NativeMethodInfoPtr_ReceiveFinisher_Public_Abstract_Virtual_New_Void_FinisherCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGunFinisherReceiver>.NativeClassPtr, 100677275);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveFinisher(FinisherCastResult castResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) castResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGunFinisherReceiver.NativeMethodInfoPtr_ReceiveFinisher_Public_Abstract_Virtual_New_Void_FinisherCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
