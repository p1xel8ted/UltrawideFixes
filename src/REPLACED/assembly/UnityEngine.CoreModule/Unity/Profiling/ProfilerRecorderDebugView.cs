// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerRecorderDebugView
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace Unity.Profiling;

public sealed class ProfilerRecorderDebugView(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  static ProfilerRecorderDebugView()
  {
    Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", nameof (ProfilerRecorderDebugView));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr);
  }

  public Il2CppStructArray<ProfilerRecorderSample> Items
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }
}
