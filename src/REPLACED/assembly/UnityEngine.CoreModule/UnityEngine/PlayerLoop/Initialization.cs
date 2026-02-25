// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerLoop.Initialization
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct Initialization
{
  static Initialization()
  {
    Il2CppClassPointerStore<Initialization>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", nameof (Initialization));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization>.NativeClassPtr);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization>.NativeClassPtr, (System.IntPtr) ref this));
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ProfilerStartFrame
  {
    static ProfilerStartFrame()
    {
      Il2CppClassPointerStore<Initialization.ProfilerStartFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (ProfilerStartFrame));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.ProfilerStartFrame>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.ProfilerStartFrame>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateCameraMotionVectors
  {
    static UpdateCameraMotionVectors()
    {
      Il2CppClassPointerStore<Initialization.UpdateCameraMotionVectors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (UpdateCameraMotionVectors));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.UpdateCameraMotionVectors>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.UpdateCameraMotionVectors>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DirectorSampleTime
  {
    static DirectorSampleTime()
    {
      Il2CppClassPointerStore<Initialization.DirectorSampleTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (DirectorSampleTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.DirectorSampleTime>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.DirectorSampleTime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct AsyncUploadTimeSlicedUpdate
  {
    static AsyncUploadTimeSlicedUpdate()
    {
      Il2CppClassPointerStore<Initialization.AsyncUploadTimeSlicedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (AsyncUploadTimeSlicedUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.AsyncUploadTimeSlicedUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.AsyncUploadTimeSlicedUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SynchronizeState
  {
    static SynchronizeState()
    {
      Il2CppClassPointerStore<Initialization.SynchronizeState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (SynchronizeState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.SynchronizeState>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.SynchronizeState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SynchronizeInputs
  {
    static SynchronizeInputs()
    {
      Il2CppClassPointerStore<Initialization.SynchronizeInputs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (SynchronizeInputs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.SynchronizeInputs>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.SynchronizeInputs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct XREarlyUpdate
  {
    static XREarlyUpdate()
    {
      Il2CppClassPointerStore<Initialization.XREarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, nameof (XREarlyUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization.XREarlyUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization.XREarlyUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public struct PlayerUpdateTime
  {
  }
}
