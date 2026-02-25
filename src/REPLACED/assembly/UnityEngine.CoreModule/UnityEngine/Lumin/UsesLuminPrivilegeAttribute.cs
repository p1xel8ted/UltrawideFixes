// Decompiled with JetBrains decompiler
// Type: UnityEngine.Lumin.UsesLuminPrivilegeAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine.Lumin;

public sealed class UsesLuminPrivilegeAttribute : Attribute
{
  public string privilege => throw new NotSupportedException("Method unstripping failed");
}
