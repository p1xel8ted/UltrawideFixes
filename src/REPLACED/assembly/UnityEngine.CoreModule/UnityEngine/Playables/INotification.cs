// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.INotification
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Playables;

public class INotification(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0;

  static INotification()
  {
    Il2CppClassPointerStore<INotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (INotification));
    INotification.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotification>.NativeClassPtr, 100669374);
  }

  public virtual unsafe PropertyName id
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), INotification.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PropertyName*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }
}
