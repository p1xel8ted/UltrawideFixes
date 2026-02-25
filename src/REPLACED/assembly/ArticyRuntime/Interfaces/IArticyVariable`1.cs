// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IArticyVariable`1
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IArticyVariable<T>(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_T_0;

  static IArticyVariable()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<IArticyVariable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", "IArticyVariable`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyVariable<T>>.NativeClassPtr);
    IArticyVariable<T>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyVariable<T>>.NativeClassPtr, 100664520);
    IArticyVariable<T>.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyVariable<T>>.NativeClassPtr, 100664521);
  }

  public virtual unsafe T Value
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyVariable<T>.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      T& local1;
      if (!typeof (T).IsValueType)
      {
        __Boxed<T> local2 = (object) value;
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyVariable<T>.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
