// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.UI.IModifiableState
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Tayx.Graphy.UI;

public class IModifiableState(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_ModuleState_Boolean_0;

  static IModifiableState()
  {
    Il2CppClassPointerStore<IModifiableState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.UI", nameof (IModifiableState));
    IModifiableState.NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiableState>.NativeClassPtr, 100663549 /*0x060000FD*/);
  }

  [CallerCount(0)]
  public virtual unsafe void SetState(GraphyManager.ModuleState newState, bool silentUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &newState;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &silentUpdate;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiableState.NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_ModuleState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
