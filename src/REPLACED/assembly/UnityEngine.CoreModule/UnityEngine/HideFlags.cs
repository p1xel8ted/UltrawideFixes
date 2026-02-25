// Decompiled with JetBrains decompiler
// Type: UnityEngine.HideFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine;

[Flags]
public enum HideFlags
{
  None = 0,
  HideInHierarchy = 1,
  HideInInspector = 2,
  DontSaveInEditor = 4,
  NotEditable = 8,
  DontSaveInBuild = 16, // 0x00000010
  DontUnloadUnusedAsset = 32, // 0x00000020
  DontSave = DontUnloadUnusedAsset | DontSaveInBuild | DontSaveInEditor, // 0x00000034
  HideAndDontSave = DontSave | NotEditable | HideInHierarchy, // 0x0000003D
}
