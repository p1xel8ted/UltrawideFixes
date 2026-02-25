// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystem
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppSystem;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public abstract class ScriptableRuntimeReflectionSystem
{
  public virtual bool TickRealtimeProbes() => false;

  public virtual void Dispose(bool disposing)
  {
  }

  public void System\u002EIDisposable\u002EDispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((Il2CppSystem.Object) this);
  }
}
