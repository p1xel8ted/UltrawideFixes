// Decompiled with JetBrains decompiler
// Type: UnityEngine.RendererExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public static class RendererExtensions
{
  private static readonly RendererExtensions.UpdateGIMaterialsForRenderer_InjectedDelegate UpdateGIMaterialsForRenderer_InjectedDelegateField = IL2CPP.ResolveICall<RendererExtensions.UpdateGIMaterialsForRenderer_InjectedDelegate>("UnityEngine.RendererExtensions::UpdateGIMaterialsForRenderer_Injected");

  public static void UpdateGIMaterials(Renderer renderer)
  {
    RendererExtensions.UpdateGIMaterialsForRenderer(renderer);
  }

  public static void UpdateGIMaterialsForRenderer(Renderer renderer)
  {
    RendererExtensions.UpdateGIMaterialsForRenderer_Injected(Object.MarshalledUnityObject.Marshal<Renderer>(renderer));
  }

  public static void UpdateGIMaterialsForRenderer_Injected(IntPtr renderer)
  {
    RendererExtensions.UpdateGIMaterialsForRenderer_InjectedDelegateField(renderer);
  }

  private delegate void UpdateGIMaterialsForRenderer_InjectedDelegate(IntPtr renderer);
}
