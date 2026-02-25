// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeLeakDetection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace Unity.Collections;

public static class NativeLeakDetection
{
  public static NativeLeakDetectionMode Mode
  {
    get => UnsafeUtility.GetLeakDetectionMode();
    set
    {
      if (value < NativeLeakDetectionMode.Disabled || value > NativeLeakDetectionMode.EnabledWithStackTrace)
        throw new ArgumentException("NativeLeakDetectionMode out of range");
      UnsafeUtility.SetLeakDetectionMode(value);
    }
  }
}
