// Decompiled with JetBrains decompiler
// Type: Unity.Baselib.BaselibException
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;
using Unity.Baselib.LowLevel;

#nullable disable
namespace Unity.Baselib;

public class BaselibException : Exception
{
  public Binding.Baselib_ErrorCode ErrorCode
  {
    get => throw new NotSupportedException("Method unstripping failed");
  }
}
