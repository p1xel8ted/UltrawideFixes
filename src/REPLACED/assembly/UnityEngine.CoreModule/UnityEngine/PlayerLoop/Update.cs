// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerLoop.Update
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct Update
{
  static Update()
  {
    Il2CppClassPointerStore<Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", nameof (Update));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update>.NativeClassPtr);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update>.NativeClassPtr, (System.IntPtr) ref this));
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ScriptRunBehaviourUpdate
  {
    static ScriptRunBehaviourUpdate()
    {
      Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, nameof (ScriptRunBehaviourUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DirectorUpdate
  {
    static DirectorUpdate()
    {
      Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, nameof (DirectorUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ScriptRunDelayedDynamicFrameRate
  {
    static ScriptRunDelayedDynamicFrameRate()
    {
      Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, nameof (ScriptRunDelayedDynamicFrameRate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ScriptRunDelayedTasks
  {
    static ScriptRunDelayedTasks()
    {
      Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, nameof (ScriptRunDelayedTasks));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
