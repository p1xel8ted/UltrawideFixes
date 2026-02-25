// Decompiled with JetBrains decompiler
// Type: IPoolableHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

#nullable disable
public static class IPoolableHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromPoolableHelper_Public_Static_T_GameObject_Dictionary_2_Type_MonoBehaviour_0;

  static IPoolableHelper()
  {
    Il2CppClassPointerStore<IPoolableHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (IPoolableHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPoolableHelper>.NativeClassPtr);
    IPoolableHelper.NativeMethodInfoPtr_GetComponentFromPoolableHelper_Public_Static_T_GameObject_Dictionary_2_Type_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolableHelper>.NativeClassPtr, 100663654);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 22145, RefRangeEnd = 22150, XrefRangeStart = 22130, XrefRangeEnd = 22145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetComponentFromPoolableHelper<T>(
    this GameObject gameObject,
    Dictionary<Il2CppSystem.Type, MonoBehaviour> cacheDict)
    where T : MonoBehaviour
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cacheDict);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IPoolableHelper.MethodInfoStoreGeneric_GetComponentFromPoolableHelper_Public_Static_T_GameObject_Dictionary_2_Type_MonoBehaviour_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  public IPoolableHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromPoolableHelper_Public_Static_T_GameObject_Dictionary_2_Type_MonoBehaviour_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IPoolableHelper.NativeMethodInfoPtr_GetComponentFromPoolableHelper_Public_Static_T_GameObject_Dictionary_2_Type_MonoBehaviour_0, Il2CppClassPointerStore<IPoolableHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
