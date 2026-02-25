// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.CreateSceneParameters
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.SceneManagement;

[Serializable]
public struct CreateSceneParameters
{
  public LocalPhysicsMode m_LocalPhysicsMode;

  public LocalPhysicsMode localPhysicsMode
  {
    get => this.m_LocalPhysicsMode;
    set => this.m_LocalPhysicsMode = value;
  }
}
