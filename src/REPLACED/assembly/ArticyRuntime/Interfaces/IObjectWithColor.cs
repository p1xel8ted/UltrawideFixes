// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IObjectWithColor
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IObjectWithColor(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_Abstract_Virtual_New_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_Abstract_Virtual_New_set_Void_Color_0;

  static IObjectWithColor()
  {
    Il2CppClassPointerStore<IObjectWithColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IObjectWithColor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IObjectWithColor>.NativeClassPtr);
    IObjectWithColor.NativeMethodInfoPtr_get_Color_Public_Abstract_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithColor>.NativeClassPtr, 100664543);
    IObjectWithColor.NativeMethodInfoPtr_set_Color_Public_Abstract_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithColor>.NativeClassPtr, 100664544 /*0x060004E0*/);
  }

  public virtual unsafe Color Color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithColor.NativeMethodInfoPtr_get_Color_Public_Abstract_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithColor.NativeMethodInfoPtr_set_Color_Public_Abstract_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
