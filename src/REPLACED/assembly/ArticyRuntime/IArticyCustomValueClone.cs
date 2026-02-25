// Decompiled with JetBrains decompiler
// Type: Articy.Unity.IArticyCustomValueClone
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity;

public class IArticyCustomValueClone(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CustomClone_Public_Abstract_Virtual_New_Void_IArticyCustomValueClone_0;

  static IArticyCustomValueClone()
  {
    Il2CppClassPointerStore<IArticyCustomValueClone>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (IArticyCustomValueClone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyCustomValueClone>.NativeClassPtr);
    IArticyCustomValueClone.NativeMethodInfoPtr_CustomClone_Public_Abstract_Virtual_New_Void_IArticyCustomValueClone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyCustomValueClone>.NativeClassPtr, 100664018);
  }

  [CallerCount(0)]
  public virtual unsafe void CustomClone(IArticyCustomValueClone aTargetObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyCustomValueClone.NativeMethodInfoPtr_CustomClone_Public_Abstract_Virtual_New_Void_IArticyCustomValueClone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
