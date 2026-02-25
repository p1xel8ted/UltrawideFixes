// Decompiled with JetBrains decompiler
// Type: UnityEngineInternal.MemorylessManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngineInternal;

public class MemorylessManager
{
  private static readonly MemorylessManager.GetFramebufferDepthMemorylessModeDelegate GetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.GetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode");
  private static readonly MemorylessManager.SetFramebufferDepthMemorylessModeDelegate SetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.SetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode");

  public static MemorylessMode depthMemorylessMode
  {
    get => MemorylessManager.GetFramebufferDepthMemorylessMode();
    set => MemorylessManager.SetFramebufferDepthMemorylessMode(value);
  }

  public static MemorylessMode GetFramebufferDepthMemorylessMode()
  {
    return MemorylessManager.GetFramebufferDepthMemorylessModeDelegateField();
  }

  public static void SetFramebufferDepthMemorylessMode(MemorylessMode mode)
  {
    MemorylessManager.SetFramebufferDepthMemorylessModeDelegateField(mode);
  }

  private delegate MemorylessMode GetFramebufferDepthMemorylessModeDelegate();

  private delegate void SetFramebufferDepthMemorylessModeDelegate(MemorylessMode mode);
}
