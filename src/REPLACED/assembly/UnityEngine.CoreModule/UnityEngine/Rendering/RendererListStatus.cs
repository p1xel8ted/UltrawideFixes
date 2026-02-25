// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RendererListStatus
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum RendererListStatus
{
  kRendererListInvalid = -2, // 0xFFFFFFFE
  kRendererListProcessing = -1, // 0xFFFFFFFF
  kRendererListEmpty = 0,
  kRendererListPopulated = 1,
}
