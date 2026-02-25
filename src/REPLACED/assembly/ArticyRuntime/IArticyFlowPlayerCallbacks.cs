// Decompiled with JetBrains decompiler
// Type: Articy.Unity.IArticyFlowPlayerCallbacks
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace Articy.Unity;

public class IArticyFlowPlayerCallbacks(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Abstract_Virtual_New_Void_IFlowObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnBranchesUpdated_Public_Abstract_Virtual_New_Void_IList_1_Branch_0;

  static IArticyFlowPlayerCallbacks()
  {
    Il2CppClassPointerStore<IArticyFlowPlayerCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (IArticyFlowPlayerCallbacks));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyFlowPlayerCallbacks>.NativeClassPtr);
    IArticyFlowPlayerCallbacks.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Abstract_Virtual_New_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyFlowPlayerCallbacks>.NativeClassPtr, 100664222);
    IArticyFlowPlayerCallbacks.NativeMethodInfoPtr_OnBranchesUpdated_Public_Abstract_Virtual_New_Void_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyFlowPlayerCallbacks>.NativeClassPtr, 100664223);
  }

  [CallerCount(0)]
  public virtual unsafe void OnFlowPlayerPaused(IFlowObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyFlowPlayerCallbacks.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Abstract_Virtual_New_Void_IFlowObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnBranchesUpdated(IList<Branch> aBranches)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranches)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyFlowPlayerCallbacks.NativeMethodInfoPtr_OnBranchesUpdated_Public_Abstract_Virtual_New_Void_IList_1_Branch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
