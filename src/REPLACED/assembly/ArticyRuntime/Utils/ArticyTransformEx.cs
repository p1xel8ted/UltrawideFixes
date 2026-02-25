// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Utils.ArticyTransformEx
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

#nullable disable
namespace Articy.Unity.Utils;

public static class ArticyTransformEx : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0;

  static ArticyTransformEx()
  {
    Il2CppClassPointerStore<ArticyTransformEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Utils", nameof (ArticyTransformEx));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTransformEx>.NativeClassPtr);
    ArticyTransformEx.NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTransformEx>.NativeClassPtr, 100664385);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999062, XrefRangeEnd = 999095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Transform Clear(this Transform transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTransformEx.NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  public ArticyTransformEx(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
