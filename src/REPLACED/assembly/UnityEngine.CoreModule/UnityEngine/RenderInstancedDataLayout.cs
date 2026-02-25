// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderInstancedDataLayout
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderInstancedDataLayout
{
  private static readonly System.IntPtr NativeFieldInfoPtr__size_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField;
  [FieldOffset(0)]
  public readonly int _size_k__BackingField;
  [FieldOffset(4)]
  public readonly int _offsetObjectToWorld_k__BackingField;
  [FieldOffset(8)]
  public readonly int _offsetPrevObjectToWorld_k__BackingField;
  [FieldOffset(12)]
  public readonly int _offsetRenderingLayerMask_k__BackingField;

  static RenderInstancedDataLayout()
  {
    Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RenderInstancedDataLayout));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr);
    RenderInstancedDataLayout.NativeFieldInfoPtr__size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<size>k__BackingField");
    RenderInstancedDataLayout.NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetObjectToWorld>k__BackingField");
    RenderInstancedDataLayout.NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetPrevObjectToWorld>k__BackingField");
    RenderInstancedDataLayout.NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetRenderingLayerMask>k__BackingField");
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public int size => this._size_k__BackingField;

  public int offsetObjectToWorld => this._offsetObjectToWorld_k__BackingField;

  public int offsetPrevObjectToWorld => this._offsetPrevObjectToWorld_k__BackingField;

  public int offsetRenderingLayerMask => this._offsetRenderingLayerMask_k__BackingField;
}
