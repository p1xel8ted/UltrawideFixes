// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerLoop.TimeUpdate
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct TimeUpdate
{
  static TimeUpdate()
  {
    Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", nameof (TimeUpdate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, (System.IntPtr) ref this));
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct WaitForLastPresentationAndUpdateTime
  {
    static WaitForLastPresentationAndUpdateTime()
    {
      Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, nameof (WaitForLastPresentationAndUpdateTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public struct ProfilerStartFrame
  {
  }
}
