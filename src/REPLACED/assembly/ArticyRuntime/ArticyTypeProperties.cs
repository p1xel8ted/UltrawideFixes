// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyTypeProperties
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using System;

#nullable disable
namespace Articy.Unity;

[Flags]
public enum ArticyTypeProperties
{
  IncludeBaseType = 1,
  Template = 2,
  General = 4,
  ArticyObject = 8,
  All = ArticyObject | General | Template | IncludeBaseType, // 0x0000000F
}
