// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ICallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices;

public class ICallbackInfoInternal(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Abstract_Virtual_New_get_IntPtr_0;

  static ICallbackInfoInternal()
  {
    Il2CppClassPointerStore<ICallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (ICallbackInfoInternal));
    ICallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Abstract_Virtual_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICallbackInfoInternal>.NativeClassPtr, 100663891);
  }

  public virtual unsafe IntPtr ClientDataAddress
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Abstract_Virtual_New_get_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }
}
