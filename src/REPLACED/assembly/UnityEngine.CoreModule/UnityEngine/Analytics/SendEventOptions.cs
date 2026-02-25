// Decompiled with JetBrains decompiler
// Type: UnityEngine.Analytics.SendEventOptions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Analytics;

[Flags]
public enum SendEventOptions
{
  kAppendNone = 0,
  kAppendBuildGuid = 1,
  kAppendBuildTarget = 2,
}
