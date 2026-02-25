// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.JobValidationInternal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace Unity.Jobs;

public static class JobValidationInternal
{
  public static void CheckReflectionDataCorrect<T>(System.IntPtr reflectionData)
  {
  }

  public static void CheckReflectionDataCorrectInternal<T>(
    System.IntPtr reflectionData,
    ref bool burstCompiled)
  {
    if (reflectionData == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("Reflection data was not set up by an Initialize() call. Support for burst compiled calls to Schedule depends on the Collections package.\n\nFor generic job types, please include [assembly: RegisterGenericJobType(typeof({0}))] in your source file.", (Il2CppSystem.Object) Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
    burstCompiled = false;
  }
}
