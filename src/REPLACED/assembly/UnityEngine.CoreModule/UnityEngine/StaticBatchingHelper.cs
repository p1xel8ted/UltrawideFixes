// Decompiled with JetBrains decompiler
// Type: UnityEngine.StaticBatchingHelper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
namespace UnityEngine;

public struct StaticBatchingHelper
{
  private static readonly StaticBatchingHelper.CombineMeshes_InjectedDelegate CombineMeshes_InjectedDelegateField = IL2CPP.ResolveICall<StaticBatchingHelper.CombineMeshes_InjectedDelegate>("UnityEngine.StaticBatchingHelper::CombineMeshes_Injected");

  public static void CombineMeshes(Il2CppReferenceArray<GameObject> gos, GameObject staticBatchRoot)
  {
    StaticBatchingHelper.CombineMeshes_Injected(gos, Object.MarshalledUnityObject.Marshal<GameObject>(staticBatchRoot));
  }

  public static void CombineMeshes_Injected(
    Il2CppReferenceArray<GameObject> gos,
    IntPtr staticBatchRoot)
  {
    StaticBatchingHelper.CombineMeshes_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gos), staticBatchRoot);
  }

  private delegate void CombineMeshes_InjectedDelegate(IntPtr gos, IntPtr staticBatchRoot);
}
