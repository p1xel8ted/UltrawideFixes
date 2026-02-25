// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamGraph
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
namespace Tayx.Graphy.Ram;

public class G_RamGraph(IntPtr pointer) : G_Graph(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_imageAllocated;
  private static readonly IntPtr NativeFieldInfoPtr_m_imageReserved;
  private static readonly IntPtr NativeFieldInfoPtr_m_imageMono;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderFull;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderLight;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_resolution;
  private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphAllocated;
  private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphReserved;
  private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphMono;
  private static readonly IntPtr NativeFieldInfoPtr_m_allocatedArray;
  private static readonly IntPtr NativeFieldInfoPtr_m_reservedArray;
  private static readonly IntPtr NativeFieldInfoPtr_m_monoArray;
  private static readonly IntPtr NativeFieldInfoPtr_m_highestMemory;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_RamGraph()
  {
    Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Ram", nameof (G_RamGraph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr);
    G_RamGraph.NativeFieldInfoPtr_m_imageAllocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_imageAllocated));
    G_RamGraph.NativeFieldInfoPtr_m_imageReserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_imageReserved));
    G_RamGraph.NativeFieldInfoPtr_m_imageMono = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_imageMono));
    G_RamGraph.NativeFieldInfoPtr_ShaderFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (ShaderFull));
    G_RamGraph.NativeFieldInfoPtr_ShaderLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (ShaderLight));
    G_RamGraph.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_graphyManager));
    G_RamGraph.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_ramMonitor));
    G_RamGraph.NativeFieldInfoPtr_m_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_resolution));
    G_RamGraph.NativeFieldInfoPtr_m_shaderGraphAllocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_shaderGraphAllocated));
    G_RamGraph.NativeFieldInfoPtr_m_shaderGraphReserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_shaderGraphReserved));
    G_RamGraph.NativeFieldInfoPtr_m_shaderGraphMono = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_shaderGraphMono));
    G_RamGraph.NativeFieldInfoPtr_m_allocatedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_allocatedArray));
    G_RamGraph.NativeFieldInfoPtr_m_reservedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_reservedArray));
    G_RamGraph.NativeFieldInfoPtr_m_monoArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_monoArray));
    G_RamGraph.NativeFieldInfoPtr_m_highestMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, nameof (m_highestMemory));
    G_RamGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663551 /*0x060000FF*/);
    G_RamGraph.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663552 /*0x06000100*/);
    G_RamGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663553 /*0x06000101*/);
    G_RamGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663554 /*0x06000102*/);
    G_RamGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663555 /*0x06000103*/);
    G_RamGraph.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663556 /*0x06000104*/);
    G_RamGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100663557 /*0x06000105*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362025, XrefRangeEnd = 362026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 362026, RefRangeEnd = 362037, XrefRangeStart = 362026, XrefRangeEnd = 362026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 362059, RefRangeEnd = 362062, XrefRangeStart = 362037, XrefRangeEnd = 362059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362062, XrefRangeEnd = 362068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateGraph()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), G_RamGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362068, XrefRangeEnd = 362098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CreatePoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), G_RamGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 362130, RefRangeEnd = 362132, XrefRangeStart = 362098, XrefRangeEnd = 362130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362132, XrefRangeEnd = 362133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_RamGraph()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Image m_imageAllocated
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageAllocated));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageAllocated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image m_imageReserved
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageReserved));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageReserved), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image m_imageMono
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageMono));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageMono), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader ShaderFull
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderFull));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderFull), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Shader ShaderLight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderLight));
      return num == IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderLight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamMonitor m_ramMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_ramMonitor));
      return num == IntPtr.Zero ? (G_RamMonitor) null : Il2CppObjectPool.Get<G_RamMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_resolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_resolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_resolution)) = value;
    }
  }

  public unsafe G_GraphShader m_shaderGraphAllocated
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphAllocated));
      return num == IntPtr.Zero ? (G_GraphShader) null : Il2CppObjectPool.Get<G_GraphShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphAllocated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_GraphShader m_shaderGraphReserved
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphReserved));
      return num == IntPtr.Zero ? (G_GraphShader) null : Il2CppObjectPool.Get<G_GraphShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphReserved), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_GraphShader m_shaderGraphMono
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphMono));
      return num == IntPtr.Zero ? (G_GraphShader) null : Il2CppObjectPool.Get<G_GraphShader>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphMono), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_allocatedArray
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_allocatedArray));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_allocatedArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_reservedArray
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_reservedArray));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_reservedArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_monoArray
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_monoArray));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_monoArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_highestMemory
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_highestMemory));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_highestMemory)) = value;
    }
  }
}
