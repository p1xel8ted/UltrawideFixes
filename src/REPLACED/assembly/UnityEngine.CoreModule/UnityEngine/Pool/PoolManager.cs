// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pool.PoolManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Pool;

public static class PoolManager : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_WeakPoolReferences;
  private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0;

  static PoolManager()
  {
    Il2CppClassPointerStore<PoolManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", nameof (PoolManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager>.NativeClassPtr);
    PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, nameof (s_WeakPoolReferences));
    PoolManager.NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100669309);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479465, RefRangeEnd = 479466, XrefRangeStart = 479452, XrefRangeEnd = 479465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Register(IPool pool)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PoolManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe List<Il2CppSystem.WeakReference<IPool>> s_WeakPoolReferences
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<Il2CppSystem.WeakReference<IPool>>) null : Il2CppObjectPool.Get<List<Il2CppSystem.WeakReference<IPool>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static void Reset()
  {
    for (int index = PoolManager.s_WeakPoolReferences.Count - 1; index >= 0; --index)
    {
      IPool target;
      if (PoolManager.s_WeakPoolReferences[index].TryGetTarget(out target))
        target.Clear();
      else
        PoolManager.s_WeakPoolReferences.RemoveAt(index);
    }
  }
}
