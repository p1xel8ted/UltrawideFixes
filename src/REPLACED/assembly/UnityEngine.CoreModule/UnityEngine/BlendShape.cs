// Decompiled with JetBrains decompiler
// Type: UnityEngine.BlendShape
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct BlendShape
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstVertex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VertexCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HasNormals;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HasTangents;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_firstVertex_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_UInt32_0;
  [FieldOffset(0)]
  public uint m_FirstVertex;
  [FieldOffset(4)]
  public uint m_VertexCount;
  [FieldOffset(8)]
  public bool m_HasNormals;
  [FieldOffset(9)]
  public bool m_HasTangents;

  static BlendShape()
  {
    Il2CppClassPointerStore<BlendShape>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BlendShape));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendShape>.NativeClassPtr);
    BlendShape.NativeFieldInfoPtr_m_FirstVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, nameof (m_FirstVertex));
    BlendShape.NativeFieldInfoPtr_m_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, nameof (m_VertexCount));
    BlendShape.NativeFieldInfoPtr_m_HasNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, nameof (m_HasNormals));
    BlendShape.NativeFieldInfoPtr_m_HasTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, nameof (m_HasTangents));
    BlendShape.NativeMethodInfoPtr_get_firstVertex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, 100666521);
    BlendShape.NativeMethodInfoPtr_get_vertexCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, 100666522);
  }

  public unsafe uint firstVertex
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendShape.NativeMethodInfoPtr_get_firstVertex_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_FirstVertex = value;
  }

  public unsafe uint vertexCount
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendShape.NativeMethodInfoPtr_get_vertexCount_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_VertexCount = value;
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public bool hasNormals
  {
    get => this.m_HasNormals;
    set => this.m_HasNormals = value;
  }

  public bool hasTangents
  {
    get => this.m_HasTangents;
    set => this.m_HasTangents = value;
  }
}
