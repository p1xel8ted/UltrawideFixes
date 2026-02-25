// Decompiled with JetBrains decompiler
// Type: IPoolable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using SadCatStudios.Effects;
using UnityEngine;

#nullable disable
public class IPoolable(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Abstract_Virtual_New_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObject_Public_Abstract_Virtual_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromPoolable_Public_Abstract_Virtual_New_T_0;

  static IPoolable()
  {
    Il2CppClassPointerStore<IPoolable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (IPoolable));
    IPoolable.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolable>.NativeClassPtr, 100663655);
    IPoolable.NativeMethodInfoPtr_GetTransform_Public_Abstract_Virtual_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolable>.NativeClassPtr, 100663656);
    IPoolable.NativeMethodInfoPtr_GetGameObject_Public_Abstract_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolable>.NativeClassPtr, 100663657);
    IPoolable.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolable>.NativeClassPtr, 100663658);
  }

  [CallerCount(0)]
  public virtual unsafe void Init(
    ObjectPool pool,
    FloatReference lifetime = null,
    IImpactPositionProvider positionProvider = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lifetime);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPoolable.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Transform GetTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPoolable.NativeMethodInfoPtr_GetTransform_Public_Abstract_Virtual_New_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe GameObject GetGameObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPoolable.NativeMethodInfoPtr_GetGameObject_Public_Abstract_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe T GetComponentFromPoolable<T>() where T : MonoBehaviour
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPoolable.MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Abstract_Virtual_New_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Abstract_Virtual_New_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IPoolable.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Abstract_Virtual_New_T_0, Il2CppClassPointerStore<IPoolable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
