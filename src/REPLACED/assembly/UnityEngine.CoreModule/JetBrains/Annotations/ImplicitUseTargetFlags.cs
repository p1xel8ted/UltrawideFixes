// Decompiled with JetBrains decompiler
// Type: JetBrains.Annotations.ImplicitUseTargetFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace JetBrains.Annotations;

[Flags]
public enum ImplicitUseTargetFlags
{
  Default = 1,
  Itself = Default, // 0x00000001
  Members = 2,
  WithMembers = Members | Itself, // 0x00000003
}
