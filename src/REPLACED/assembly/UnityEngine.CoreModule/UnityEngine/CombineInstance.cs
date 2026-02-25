// Decompiled with JetBrains decompiler
// Type: UnityEngine.CombineInstance
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CombineInstance
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MeshInstanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SubMeshIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Transform;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LightmapScaleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset;
  [FieldOffset(0)]
  public int m_MeshInstanceID;
  [FieldOffset(4)]
  public int m_SubMeshIndex;
  [FieldOffset(8)]
  public Matrix4x4 m_Transform;
  [FieldOffset(72)]
  public Vector4 m_LightmapScaleOffset;
  [FieldOffset(88)]
  public Vector4 m_RealtimeLightmapScaleOffset;

  static CombineInstance()
  {
    Il2CppClassPointerStore<CombineInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CombineInstance));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr);
    CombineInstance.NativeFieldInfoPtr_m_MeshInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, nameof (m_MeshInstanceID));
    CombineInstance.NativeFieldInfoPtr_m_SubMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, nameof (m_SubMeshIndex));
    CombineInstance.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, nameof (m_Transform));
    CombineInstance.NativeFieldInfoPtr_m_LightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, nameof (m_LightmapScaleOffset));
    CombineInstance.NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, nameof (m_RealtimeLightmapScaleOffset));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Mesh mesh
  {
    get => Mesh.FromInstanceID(this.m_MeshInstanceID);
    set => this.m_MeshInstanceID = (Object) value != (Object) null ? value.GetInstanceID() : 0;
  }

  public int subMeshIndex
  {
    get => this.m_SubMeshIndex;
    set => this.m_SubMeshIndex = value;
  }

  public Matrix4x4 transform
  {
    get => this.m_Transform;
    set => this.m_Transform = value;
  }

  public Vector4 lightmapScaleOffset
  {
    get => this.m_LightmapScaleOffset;
    set => this.m_LightmapScaleOffset = value;
  }

  public Vector4 realtimeLightmapScaleOffset
  {
    get => this.m_RealtimeLightmapScaleOffset;
    set => this.m_RealtimeLightmapScaleOffset = value;
  }
}
