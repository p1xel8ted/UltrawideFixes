// Decompiled with JetBrains decompiler
// Type: UnityEngine.BillboardRenderer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class BillboardRenderer : Renderer
{
  private static readonly BillboardRenderer.get_billboard_InjectedDelegate get_billboard_InjectedDelegateField = IL2CPP.ResolveICall<BillboardRenderer.get_billboard_InjectedDelegate>("UnityEngine.BillboardRenderer::get_billboard_Injected");
  private static readonly BillboardRenderer.set_billboard_InjectedDelegate set_billboard_InjectedDelegateField = IL2CPP.ResolveICall<BillboardRenderer.set_billboard_InjectedDelegate>("UnityEngine.BillboardRenderer::set_billboard_Injected");

  public BillboardAsset billboard
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardRenderer>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<BillboardAsset>(BillboardRenderer.get_billboard_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<BillboardRenderer>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      BillboardRenderer.set_billboard_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<BillboardAsset>(value));
    }
  }

  public static System.IntPtr get_billboard_Injected(System.IntPtr _unity_self)
  {
    return BillboardRenderer.get_billboard_InjectedDelegateField(_unity_self);
  }

  public static void set_billboard_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    BillboardRenderer.set_billboard_InjectedDelegateField(_unity_self, value);
  }

  private delegate System.IntPtr get_billboard_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_billboard_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);
}
