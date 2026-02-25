// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pool.IObjectPool`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace UnityEngine.Pool;

public class IObjectPool<T>(System.IntPtr pointer) : Il2CppObjectBase(pointer) where T : class
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0;

  static IObjectPool()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<IObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "IObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IObjectPool<T>.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectPool<T>>.NativeClassPtr, 100669297);
  }

  [CallerCount(0)]
  public virtual unsafe void Release(T element)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) element;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref element;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectPool<T>.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
