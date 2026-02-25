// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IArticyNamespace
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IArticyNamespace(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_RegisterVariables_Public_Abstract_Virtual_New_Void_BaseGlobalVariables_0;

  static IArticyNamespace()
  {
    Il2CppClassPointerStore<IArticyNamespace>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IArticyNamespace));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyNamespace>.NativeClassPtr);
    IArticyNamespace.NativeMethodInfoPtr_RegisterVariables_Public_Abstract_Virtual_New_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyNamespace>.NativeClassPtr, 100664410);
  }

  [CallerCount(0)]
  public virtual unsafe void RegisterVariables(BaseGlobalVariables aStorage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStorage)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyNamespace.NativeMethodInfoPtr_RegisterVariables_Public_Abstract_Virtual_New_Void_BaseGlobalVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
