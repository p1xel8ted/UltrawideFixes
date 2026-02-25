// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.SceneUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.SceneManagement;

public static class SceneUtility
{
  private static readonly SceneUtility.GetScenePathByBuildIndex_InjectedDelegate GetScenePathByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<SceneUtility.GetScenePathByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneUtility::GetScenePathByBuildIndex_Injected");
  private static readonly SceneUtility.GetBuildIndexByScenePath_InjectedDelegate GetBuildIndexByScenePath_InjectedDelegateField = IL2CPP.ResolveICall<SceneUtility.GetBuildIndexByScenePath_InjectedDelegate>("UnityEngine.SceneManagement.SceneUtility::GetBuildIndexByScenePath_Injected");

  public static string GetScenePathByBuildIndex(int buildIndex)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      SceneUtility.GetScenePathByBuildIndex_Injected(buildIndex, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static unsafe int GetBuildIndexByScenePath(string scenePath)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(scenePath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = scenePath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return SceneUtility.GetBuildIndexByScenePath_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void GetScenePathByBuildIndex_Injected(int buildIndex, out ManagedSpanWrapper ret)
  {
    SceneUtility.GetScenePathByBuildIndex_InjectedDelegateField(buildIndex, (System.IntPtr) ref ret);
  }

  public static int GetBuildIndexByScenePath_Injected(ref ManagedSpanWrapper scenePath)
  {
    return SceneUtility.GetBuildIndexByScenePath_InjectedDelegateField((System.IntPtr) ref scenePath);
  }

  private delegate void GetScenePathByBuildIndex_InjectedDelegate(int buildIndex, [Out] System.IntPtr ret);

  private delegate int GetBuildIndexByScenePath_InjectedDelegate(System.IntPtr scenePath);
}
