// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IArticyReference
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IArticyReference(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_UInt64_0;

  static IArticyReference()
  {
    Il2CppClassPointerStore<IArticyReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IArticyReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyReference>.NativeClassPtr);
    IArticyReference.NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyReference>.NativeClassPtr, 100664411);
  }

  public virtual unsafe ulong Id
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyReference.NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }
}
