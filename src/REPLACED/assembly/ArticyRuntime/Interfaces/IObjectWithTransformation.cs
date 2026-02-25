// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IObjectWithTransformation
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

public class IObjectWithTransformation(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transformation_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Transform_Public_Abstract_Virtual_New_set_Void_Transformation_0;

  static IObjectWithTransformation()
  {
    Il2CppClassPointerStore<IObjectWithTransformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IObjectWithTransformation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IObjectWithTransformation>.NativeClassPtr);
    IObjectWithTransformation.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithTransformation>.NativeClassPtr, 100664575);
    IObjectWithTransformation.NativeMethodInfoPtr_set_Transform_Public_Abstract_Virtual_New_set_Void_Transformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithTransformation>.NativeClassPtr, 100664576 /*0x06000500*/);
  }

  public virtual unsafe Transformation Transform
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithTransformation.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transformation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transformation) null : Il2CppObjectPool.Get<Transformation>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithTransformation.NativeMethodInfoPtr_set_Transform_Public_Abstract_Virtual_New_set_Void_Transformation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
