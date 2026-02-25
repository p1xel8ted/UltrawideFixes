// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Audio.G_AudioGraph
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using Tayx.Graphy.Graph;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Audio;

public class G_AudioGraph(IntPtr pointer) : G_Graph(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_imageGraph;
  private static readonly IntPtr NativeFieldInfoPtr_m_imageGraphHighestValues;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderFull;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderLight;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_resolution;
  private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraph;
  private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphHighestValues;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphArray;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphArrayHighestValue;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_AudioGraph()
  {
    Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Audio", nameof (G_AudioGraph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr);
    G_AudioGraph.NativeFieldInfoPtr_m_imageGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_imageGraph));
    G_AudioGraph.NativeFieldInfoPtr_m_imageGraphHighestValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_imageGraphHighestValues));
    G_AudioGraph.NativeFieldInfoPtr_ShaderFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (ShaderFull));
    G_AudioGraph.NativeFieldInfoPtr_ShaderLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (ShaderLight));
    G_AudioGraph.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_graphyManager));
    G_AudioGraph.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_audioMonitor));
    G_AudioGraph.NativeFieldInfoPtr_m_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_resolution));
    G_AudioGraph.NativeFieldInfoPtr_m_shaderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_shaderGraph));
    G_AudioGraph.NativeFieldInfoPtr_m_shaderGraphHighestValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_shaderGraphHighestValues));
    G_AudioGraph.NativeFieldInfoPtr_m_graphArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_graphArray));
    G_AudioGraph.NativeFieldInfoPtr_m_graphArrayHighestValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, nameof (m_graphArrayHighestValue));
    G_AudioGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663615);
    G_AudioGraph.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663616 /*0x06000140*/);
    G_AudioGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663617);
    G_AudioGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663618);
    G_AudioGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663619);
    G_AudioGraph.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663620);
    G_AudioGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100663621);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362625, XrefRangeEnd = 362626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362626, XrefRangeEnd = 362630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 362644, RefRangeEnd = 362647, XrefRangeStart = 362630, XrefRangeEnd = 362644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362647, XrefRangeEnd = 362661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateGraph()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), G_AudioGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362661, XrefRangeEnd = 362682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CreatePoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), G_AudioGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 362707, RefRangeEnd = 362708, XrefRangeStart = 362682, XrefRangeEnd = 362707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362708, XrefRangeEnd = 362709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_AudioGraph()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Image m_imageGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraph));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image m_imageGraphHighestValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraphHighestValues));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraphHighestValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader ShaderFull
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderFull));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderFull), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader ShaderLight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderLight));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderLight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioMonitor m_audioMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_audioMonitor));
      return num == IntPtr.Zero ? (G_AudioMonitor) null : Il2CppObjectPool.Get<G_AudioMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_resolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_resolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_resolution)) = value;
    }
  }

  public unsafe G_GraphShader m_shaderGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraph));
      return num == IntPtr.Zero ? (G_GraphShader) null : Il2CppObjectPool.Get<G_GraphShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_GraphShader m_shaderGraphHighestValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraphHighestValues));
      return num == IntPtr.Zero ? (G_GraphShader) null : Il2CppObjectPool.Get<G_GraphShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraphHighestValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_graphArray
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArray));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_graphArrayHighestValue
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArrayHighestValue));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArrayHighestValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
