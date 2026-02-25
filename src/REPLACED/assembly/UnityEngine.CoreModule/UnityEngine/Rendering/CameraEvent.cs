// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CameraEvent
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum CameraEvent
{
  BeforeDepthTexture,
  AfterDepthTexture,
  BeforeDepthNormalsTexture,
  AfterDepthNormalsTexture,
  BeforeGBuffer,
  AfterGBuffer,
  BeforeLighting,
  AfterLighting,
  BeforeFinalPass,
  AfterFinalPass,
  BeforeForwardOpaque,
  AfterForwardOpaque,
  BeforeImageEffectsOpaque,
  AfterImageEffectsOpaque,
  BeforeSkybox,
  AfterSkybox,
  BeforeForwardAlpha,
  AfterForwardAlpha,
  BeforeImageEffects,
  AfterImageEffects,
  AfterEverything,
  BeforeReflections,
  AfterReflections,
  BeforeHaloAndLensFlares,
  AfterHaloAndLensFlares,
}
