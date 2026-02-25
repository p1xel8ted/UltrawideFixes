// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IObjectWithLocalizableMenuText
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IObjectWithLocalizableMenuText(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_MenuText_Public_Abstract_Virtual_New_get_ArticyMultiLanguageString_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_MenuText_Public_Abstract_Virtual_New_set_Void_ArticyMultiLanguageString_0;

  static IObjectWithLocalizableMenuText()
  {
    Il2CppClassPointerStore<IObjectWithLocalizableMenuText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IObjectWithLocalizableMenuText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IObjectWithLocalizableMenuText>.NativeClassPtr);
    IObjectWithLocalizableMenuText.NativeMethodInfoPtr_get_MenuText_Public_Abstract_Virtual_New_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithLocalizableMenuText>.NativeClassPtr, 100664551);
    IObjectWithLocalizableMenuText.NativeMethodInfoPtr_set_MenuText_Public_Abstract_Virtual_New_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithLocalizableMenuText>.NativeClassPtr, 100664552);
  }

  public virtual unsafe ArticyMultiLanguageString MenuText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithLocalizableMenuText.NativeMethodInfoPtr_get_MenuText_Public_Abstract_Virtual_New_get_ArticyMultiLanguageString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithLocalizableMenuText.NativeMethodInfoPtr_set_MenuText_Public_Abstract_Virtual_New_set_Void_ArticyMultiLanguageString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
