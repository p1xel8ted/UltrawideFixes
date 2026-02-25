// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsText
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Fps;

public class G_FpsText(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsText;
  private static readonly IntPtr NativeFieldInfoPtr_m_msText;
  private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsText;
  private static readonly IntPtr NativeFieldInfoPtr_m_minFpsText;
  private static readonly IntPtr NativeFieldInfoPtr_m_maxFpsText;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;
  private static readonly IntPtr NativeFieldInfoPtr_m_frameCount;
  private static readonly IntPtr NativeFieldInfoPtr_m_deltaTime;
  private static readonly IntPtr NativeFieldInfoPtr_m_fps;
  private static readonly IntPtr NativeFieldInfoPtr_m_minFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_maxFps;
  private static readonly IntPtr NativeFieldInfoPtr_m_msStringFormat;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetFpsRelatedTextColor_Private_Void_Text_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_FpsText()
  {
    Il2CppClassPointerStore<G_FpsText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Fps", nameof (G_FpsText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr);
    G_FpsText.NativeFieldInfoPtr_m_fpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_fpsText));
    G_FpsText.NativeFieldInfoPtr_m_msText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_msText));
    G_FpsText.NativeFieldInfoPtr_m_avgFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_avgFpsText));
    G_FpsText.NativeFieldInfoPtr_m_minFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_minFpsText));
    G_FpsText.NativeFieldInfoPtr_m_maxFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_maxFpsText));
    G_FpsText.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_graphyManager));
    G_FpsText.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_fpsMonitor));
    G_FpsText.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_updateRate));
    G_FpsText.NativeFieldInfoPtr_m_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_frameCount));
    G_FpsText.NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_deltaTime));
    G_FpsText.NativeFieldInfoPtr_m_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_fps));
    G_FpsText.NativeFieldInfoPtr_m_minFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_minFps));
    G_FpsText.NativeFieldInfoPtr_m_maxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_maxFps));
    G_FpsText.NativeFieldInfoPtr_m_msStringFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, nameof (m_msStringFormat));
    G_FpsText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100663609);
    G_FpsText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100663610);
    G_FpsText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100663611);
    G_FpsText.NativeMethodInfoPtr_SetFpsRelatedTextColor_Private_Void_Text_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100663612);
    G_FpsText.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100663613);
    G_FpsText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100663614);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362558, XrefRangeEnd = 362559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362559, XrefRangeEnd = 362589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362589, XrefRangeEnd = 362591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFpsRelatedTextColor(Text text, float fps)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &fps;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_SetFpsRelatedTextColor_Private_Void_Text_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 362623, RefRangeEnd = 362624, XrefRangeStart = 362591, XrefRangeEnd = 362623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362624, XrefRangeEnd = 362625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_FpsText()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Text m_fpsText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_msText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_msText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_msText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_avgFpsText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_avgFpsText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_avgFpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_minFpsText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_minFpsText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_minFpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_maxFpsText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_maxFpsText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_maxFpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_FpsMonitor m_fpsMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsMonitor));
      return num == IntPtr.Zero ? (G_FpsMonitor) null : Il2CppObjectPool.Get<G_FpsMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_updateRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_updateRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_updateRate)) = value;
    }
  }

  public unsafe int m_frameCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_frameCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_frameCount)) = value;
    }
  }

  public unsafe float m_deltaTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_deltaTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_deltaTime)) = value;
    }
  }

  public unsafe float m_fps
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fps));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fps)) = value;
    }
  }

  public static unsafe int m_minFps
  {
    get
    {
      int mMinFps;
      IL2CPP.il2cpp_field_static_get_value(G_FpsText.NativeFieldInfoPtr_m_minFps, (void*) &mMinFps);
      return mMinFps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FpsText.NativeFieldInfoPtr_m_minFps, (void*) &value);
    }
  }

  public static unsafe int m_maxFps
  {
    get
    {
      int mMaxFps;
      IL2CPP.il2cpp_field_static_get_value(G_FpsText.NativeFieldInfoPtr_m_maxFps, (void*) &mMaxFps);
      return mMaxFps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FpsText.NativeFieldInfoPtr_m_maxFps, (void*) &value);
    }
  }

  public static unsafe string m_msStringFormat
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(G_FpsText.NativeFieldInfoPtr_m_msStringFormat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FpsText.NativeFieldInfoPtr_m_msStringFormat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
