// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.LowLevel.Unsafe.JobHandleUnsafeUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace Unity.Jobs.LowLevel.Unsafe;

public static class JobHandleUnsafeUtility
{
  public static unsafe JobHandle CombineDependencies(JobHandle* jobs, int count)
  {
    return JobHandle.CombineDependenciesInternalPtr((void*) jobs, count);
  }
}
