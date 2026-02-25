// Decompiled with JetBrains decompiler
// Type: UnityEngine.Serialization.UnitySurrogateSelector
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppSystem.Runtime.Serialization;

#nullable disable
namespace UnityEngine.Serialization;

public class UnitySurrogateSelector
{
  public ISerializationSurrogate GetSurrogate(
    Il2CppSystem.Type type,
    StreamingContext context,
    out ISurrogateSelector selector)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void ChainSelector(ISurrogateSelector selector) => throw new Il2CppSystem.NotImplementedException();

  public ISurrogateSelector GetNextSelector() => throw new Il2CppSystem.NotImplementedException();
}
