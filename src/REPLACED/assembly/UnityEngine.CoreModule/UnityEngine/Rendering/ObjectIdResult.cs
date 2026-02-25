// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ObjectIdResult
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
namespace UnityEngine.Rendering;

public class ObjectIdResult
{
  public Il2CppReferenceArray<UnityEngine.Object> idToObjectMapping
  {
    get => throw new NotSupportedException("Method unstripping failed");
  }

  public static int DecodeIdFromColor(Color color)
  {
    return (int) ((double) color.r * (double) byte.MaxValue) + ((int) ((double) color.g * (double) byte.MaxValue) << 8) + ((int) ((double) color.b * (double) byte.MaxValue) << 16 /*0x10*/) + ((int) ((double) color.a * (double) byte.MaxValue) << 24);
  }
}
