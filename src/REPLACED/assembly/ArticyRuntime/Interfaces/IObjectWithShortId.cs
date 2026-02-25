// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IObjectWithShortId
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IObjectWithShortId(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_ShortId_Public_Abstract_Virtual_New_get_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ShortId_Public_Abstract_Virtual_New_set_Void_UInt32_0;

  static IObjectWithShortId()
  {
    Il2CppClassPointerStore<IObjectWithShortId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IObjectWithShortId));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IObjectWithShortId>.NativeClassPtr);
    IObjectWithShortId.NativeMethodInfoPtr_get_ShortId_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithShortId>.NativeClassPtr, 100664563);
    IObjectWithShortId.NativeMethodInfoPtr_set_ShortId_Public_Abstract_Virtual_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithShortId>.NativeClassPtr, 100664564);
  }

  public virtual unsafe uint ShortId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithShortId.NativeMethodInfoPtr_get_ShortId_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithShortId.NativeMethodInfoPtr_set_ShortId_Public_Abstract_Virtual_New_set_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
