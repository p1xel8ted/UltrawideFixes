// Decompiled with JetBrains decompiler
// Type: UnityEngine.Skybox
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Skybox : Behaviour
{
  private static readonly Skybox.get_material_InjectedDelegate get_material_InjectedDelegateField = IL2CPP.ResolveICall<Skybox.get_material_InjectedDelegate>("UnityEngine.Skybox::get_material_Injected");
  private static readonly Skybox.set_material_InjectedDelegate set_material_InjectedDelegateField = IL2CPP.ResolveICall<Skybox.set_material_InjectedDelegate>("UnityEngine.Skybox::set_material_Injected");

  public Material material
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Skybox>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return Unmarshal.UnmarshalUnityObject<Material>(Skybox.get_material_Injected(_unity_self));
    }
    set
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<Skybox>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Skybox.set_material_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Material>(value));
    }
  }

  public static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
  {
    return Skybox.get_material_InjectedDelegateField(_unity_self);
  }

  public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    Skybox.set_material_InjectedDelegateField(_unity_self, value);
  }

  private delegate System.IntPtr get_material_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);
}
