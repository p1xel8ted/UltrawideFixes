// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IInputPinsOwner
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IInputPinsOwner(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_GetInputPins_Public_Abstract_Virtual_New_List_1_IInputPin_0;

  static IInputPinsOwner()
  {
    Il2CppClassPointerStore<IInputPinsOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IInputPinsOwner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IInputPinsOwner>.NativeClassPtr);
    IInputPinsOwner.NativeMethodInfoPtr_GetInputPins_Public_Abstract_Virtual_New_List_1_IInputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputPinsOwner>.NativeClassPtr, 100664537);
  }

  [CallerCount(0)]
  public virtual unsafe List<IInputPin> GetInputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IInputPinsOwner.NativeMethodInfoPtr_GetInputPins_Public_Abstract_Virtual_New_List_1_IInputPin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (List<IInputPin>) null : Il2CppObjectPool.Get<List<IInputPin>>(num3);
  }
}
