// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsMonitor
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
using UnityEngine;

#nullable disable
namespace Tayx.Graphy.Fps;

public class G_FpsMonitor(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_averageSamples;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_currentFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_avgFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_minFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_maxFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_averageFpsSamples;
  private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsSamplesOffset;
  private static readonly IntPtr NativeFieldInfoPtr_m_indexMask;
  private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsSamplesCapacity;
  private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsSamplesCount;
  private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinMaxFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinFpsPassed;
  private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMaxFpsPassed;
  private static readonly IntPtr NativeFieldInfoPtr_unscaledDeltaTime;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResizeSamplesBuffer_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToBufferIndex_Private_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_FpsMonitor()
  {
    Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Fps", nameof (G_FpsMonitor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr);
    G_FpsMonitor.NativeFieldInfoPtr_m_averageSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_averageSamples));
    G_FpsMonitor.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_graphyManager));
    G_FpsMonitor.NativeFieldInfoPtr_m_currentFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_currentFps));
    G_FpsMonitor.NativeFieldInfoPtr_m_avgFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_avgFps));
    G_FpsMonitor.NativeFieldInfoPtr_m_minFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_minFps));
    G_FpsMonitor.NativeFieldInfoPtr_m_maxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_maxFps));
    G_FpsMonitor.NativeFieldInfoPtr_m_averageFpsSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_averageFpsSamples));
    G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_avgFpsSamplesOffset));
    G_FpsMonitor.NativeFieldInfoPtr_m_indexMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_indexMask));
    G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_avgFpsSamplesCapacity));
    G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_avgFpsSamplesCount));
    G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinMaxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_timeToResetMinMaxFps));
    G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinFpsPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_timeToResetMinFpsPassed));
    G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMaxFpsPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (m_timeToResetMaxFpsPassed));
    G_FpsMonitor.NativeFieldInfoPtr_unscaledDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, nameof (unscaledDeltaTime));
    G_FpsMonitor.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663598);
    G_FpsMonitor.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663599);
    G_FpsMonitor.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663600 /*0x06000130*/);
    G_FpsMonitor.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663601);
    G_FpsMonitor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663602);
    G_FpsMonitor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663603);
    G_FpsMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663604);
    G_FpsMonitor.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663605);
    G_FpsMonitor.NativeMethodInfoPtr_ResizeSamplesBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663606);
    G_FpsMonitor.NativeMethodInfoPtr_ToBufferIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663607);
    G_FpsMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100663608);
  }

  public unsafe float CurrentFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AverageFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MinFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MaxFPS
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362545, XrefRangeEnd = 362553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362553, XrefRangeEnd = 362554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362554, XrefRangeEnd = 362557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResizeSamplesBuffer(int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &size
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_ResizeSamplesBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe int ToBufferIndex(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_ToBufferIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362557, XrefRangeEnd = 362558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_FpsMonitor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int m_averageSamples
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageSamples));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageSamples)) = value;
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_currentFps
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_currentFps));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_currentFps)) = value;
    }
  }

  public unsafe float m_avgFps
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFps));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFps)) = value;
    }
  }

  public unsafe float m_minFps
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_minFps));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_minFps)) = value;
    }
  }

  public unsafe float m_maxFps
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_maxFps));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_maxFps)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> m_averageFpsSamples
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageFpsSamples));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageFpsSamples), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_avgFpsSamplesOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesOffset)) = value;
    }
  }

  public unsafe int m_indexMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_indexMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_indexMask)) = value;
    }
  }

  public unsafe int m_avgFpsSamplesCapacity
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCapacity));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCapacity)) = value;
    }
  }

  public unsafe int m_avgFpsSamplesCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCount)) = value;
    }
  }

  public unsafe int m_timeToResetMinMaxFps
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinMaxFps));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinMaxFps)) = value;
    }
  }

  public unsafe float m_timeToResetMinFpsPassed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinFpsPassed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinFpsPassed)) = value;
    }
  }

  public unsafe float m_timeToResetMaxFpsPassed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMaxFpsPassed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMaxFpsPassed)) = value;
    }
  }

  public unsafe float unscaledDeltaTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_unscaledDeltaTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_unscaledDeltaTime)) = value;
    }
  }
}
