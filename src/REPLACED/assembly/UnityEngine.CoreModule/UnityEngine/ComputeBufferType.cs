// Decompiled with JetBrains decompiler
// Type: UnityEngine.ComputeBufferType
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine;

[Flags]
public enum ComputeBufferType
{
  Default = 0,
  Raw = 1,
  Append = 2,
  Counter = 4,
  Constant = 8,
  Structured = 16, // 0x00000010
  DrawIndirect = 256, // 0x00000100
  IndirectArguments = DrawIndirect, // 0x00000100
  GPUMemory = 512, // 0x00000200
}
