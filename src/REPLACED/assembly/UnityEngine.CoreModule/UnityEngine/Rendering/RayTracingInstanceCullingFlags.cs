// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RayTracingInstanceCullingFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Rendering;

public enum RayTracingInstanceCullingFlags
{
  None = 0,
  EnableSphereCulling = 1,
  EnablePlaneCulling = 2,
  EnableLODCulling = 4,
  ComputeMaterialsCRC = 8,
  IgnoreReflectionProbes = 16, // 0x00000010
  EnableSolidAngleCulling = 32, // 0x00000020
}
