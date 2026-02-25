// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.UI.IMovable
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Tayx.Graphy.UI;

public class IMovable(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Abstract_Virtual_New_Void_ModulePosition_0;

  static IMovable()
  {
    Il2CppClassPointerStore<IMovable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.UI", nameof (IMovable));
    IMovable.NativeMethodInfoPtr_SetPosition_Public_Abstract_Virtual_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMovable>.NativeClassPtr, 100663550 /*0x060000FE*/);
  }

  [CallerCount(0)]
  public virtual unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &newModulePosition
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IMovable.NativeMethodInfoPtr_SetPosition_Public_Abstract_Virtual_New_Void_ModulePosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
