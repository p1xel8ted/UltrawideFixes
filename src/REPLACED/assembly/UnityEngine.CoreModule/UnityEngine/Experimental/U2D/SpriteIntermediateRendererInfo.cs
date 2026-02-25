// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.U2D.SpriteIntermediateRendererInfo
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.U2D;

[StructLayout(LayoutKind.Explicit)]
public struct SpriteIntermediateRendererInfo
{
  private static readonly System.IntPtr NativeFieldInfoPtr_SpriteID;
  private static readonly System.IntPtr NativeFieldInfoPtr_TextureID;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaterialID;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color;
  private static readonly System.IntPtr NativeFieldInfoPtr_Transform;
  private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
  private static readonly System.IntPtr NativeFieldInfoPtr_SortingLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_SortingOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_SceneCullingMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_IndexData;
  private static readonly System.IntPtr NativeFieldInfoPtr_VertexData;
  private static readonly System.IntPtr NativeFieldInfoPtr_IndexCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_VertexCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShaderChannelMask;
  [FieldOffset(0)]
  public int SpriteID;
  [FieldOffset(4)]
  public int TextureID;
  [FieldOffset(8)]
  public int MaterialID;
  [FieldOffset(12)]
  public Color Color;
  [FieldOffset(28)]
  public Matrix4x4 Transform;
  [FieldOffset(92)]
  public Bounds Bounds;
  [FieldOffset(116)]
  public int Layer;
  [FieldOffset(120)]
  public int SortingLayer;
  [FieldOffset(124)]
  public int SortingOrder;
  [FieldOffset(128 /*0x80*/)]
  public ulong SceneCullingMask;
  [FieldOffset(136)]
  public System.IntPtr IndexData;
  [FieldOffset(144 /*0x90*/)]
  public System.IntPtr VertexData;
  [FieldOffset(152)]
  public int IndexCount;
  [FieldOffset(156)]
  public int VertexCount;
  [FieldOffset(160 /*0xA0*/)]
  public int ShaderChannelMask;

  static SpriteIntermediateRendererInfo()
  {
    Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", nameof (SpriteIntermediateRendererInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr);
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (SpriteID));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_TextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (TextureID));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_MaterialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (MaterialID));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (Color));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (Transform));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (Bounds));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (Layer));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (SortingLayer));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (SortingOrder));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (SceneCullingMask));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (IndexData));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (VertexData));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (IndexCount));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (VertexCount));
    SpriteIntermediateRendererInfo.NativeFieldInfoPtr_ShaderChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, nameof (ShaderChannelMask));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
