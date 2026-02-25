// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SubMeshDescriptor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SubMeshDescriptor
{
  private static readonly System.IntPtr NativeFieldInfoPtr__bounds_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__topology_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__indexStart_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__indexCount_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__baseVertex_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__firstVertex_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__vertexCount_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  [FieldOffset(0)]
  public Bounds _bounds_k__BackingField;
  [FieldOffset(24)]
  public MeshTopology _topology_k__BackingField;
  [FieldOffset(28)]
  public int _indexStart_k__BackingField;
  [FieldOffset(32 /*0x20*/)]
  public int _indexCount_k__BackingField;
  [FieldOffset(36)]
  public int _baseVertex_k__BackingField;
  [FieldOffset(40)]
  public int _firstVertex_k__BackingField;
  [FieldOffset(44)]
  public int _vertexCount_k__BackingField;

  static SubMeshDescriptor()
  {
    Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SubMeshDescriptor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr);
    SubMeshDescriptor.NativeFieldInfoPtr__bounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<bounds>k__BackingField");
    SubMeshDescriptor.NativeFieldInfoPtr__topology_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<topology>k__BackingField");
    SubMeshDescriptor.NativeFieldInfoPtr__indexStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexStart>k__BackingField");
    SubMeshDescriptor.NativeFieldInfoPtr__indexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexCount>k__BackingField");
    SubMeshDescriptor.NativeFieldInfoPtr__baseVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<baseVertex>k__BackingField");
    SubMeshDescriptor.NativeFieldInfoPtr__firstVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<firstVertex>k__BackingField");
    SubMeshDescriptor.NativeFieldInfoPtr__vertexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<vertexCount>k__BackingField");
    SubMeshDescriptor.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669629);
    SubMeshDescriptor.NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669630);
    SubMeshDescriptor.NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669631);
    SubMeshDescriptor.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669632);
    SubMeshDescriptor.NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669633);
    SubMeshDescriptor.NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669634);
    SubMeshDescriptor.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669635);
    SubMeshDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100669636);
  }

  public unsafe Bounds bounds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 482014, RefRangeEnd = 482015, XrefRangeStart = 482014, XrefRangeEnd = 482014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._bounds_k__BackingField = value;
  }

  public unsafe MeshTopology topology
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(MeshTopology*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._topology_k__BackingField = value;
  }

  public unsafe int indexStart
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._indexStart_k__BackingField = value;
  }

  public unsafe int indexCount
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._indexCount_k__BackingField = value;
  }

  public unsafe int baseVertex
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._baseVertex_k__BackingField = value;
  }

  public unsafe int firstVertex
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._firstVertex_k__BackingField = value;
  }

  public unsafe int vertexCount
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._vertexCount_k__BackingField = value;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482015, XrefRangeEnd = 482044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
