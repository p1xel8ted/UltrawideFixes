// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Playables.TexturePlayableBinding
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Experimental.Playables;

public static class TexturePlayableBinding
{
  public static PlayableBinding Create(string name, UnityEngine.Object key)
  {
    // ISSUE: method pointer
    return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderTexture>()), new PlayableBinding.CreateOutputMethod((Il2CppSystem.Object) null, __methodptr(CreateTextureOutput)));
  }

  public static PlayableOutput CreateTextureOutput(PlayableGraph graph, string name)
  {
    return (PlayableOutput) TexturePlayableOutput.Create(graph, name, (RenderTexture) null);
  }
}
