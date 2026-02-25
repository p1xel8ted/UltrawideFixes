// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Audio.G_AudioManager
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Audio;

public class G_AudioManager(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphGameObject;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioDbText;
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioGraph;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioText;
  private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;
  private static readonly IntPtr NativeFieldInfoPtr_m_childrenGameObjects;
  private static readonly IntPtr NativeFieldInfoPtr_m_previousModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_currentModuleState;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RefreshParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_AudioManager()
  {
    Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Audio", nameof (G_AudioManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr);
    G_AudioManager.NativeFieldInfoPtr_m_audioGraphGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_audioGraphGameObject));
    G_AudioManager.NativeFieldInfoPtr_m_audioDbText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_audioDbText));
    G_AudioManager.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_backgroundImages));
    G_AudioManager.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_graphyManager));
    G_AudioManager.NativeFieldInfoPtr_m_audioGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_audioGraph));
    G_AudioManager.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_audioMonitor));
    G_AudioManager.NativeFieldInfoPtr_m_audioText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_audioText));
    G_AudioManager.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_rectTransform));
    G_AudioManager.NativeFieldInfoPtr_m_childrenGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_childrenGameObjects));
    G_AudioManager.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_previousModuleState));
    G_AudioManager.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, nameof (m_currentModuleState));
    G_AudioManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663622);
    G_AudioManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663623);
    G_AudioManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663624);
    G_AudioManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663625);
    G_AudioManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663626);
    G_AudioManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663627);
    G_AudioManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663628);
    G_AudioManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663629);
    G_AudioManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663630);
    G_AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100663631);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362709, XrefRangeEnd = 362710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362710, XrefRangeEnd = 362711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 362728, RefRangeEnd = 362732, XrefRangeStart = 362711, XrefRangeEnd = 362728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &newModulePosition
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 362740, RefRangeEnd = 362748, XrefRangeStart = 362732, XrefRangeEnd = 362740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &silentUpdate;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362748, XrefRangeEnd = 362749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestorePreviousState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(21)]
  [CachedScanResults(RefRangeStart = 362766, RefRangeEnd = 362787, XrefRangeStart = 362749, XrefRangeEnd = 362766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 362804, RefRangeEnd = 362806, XrefRangeStart = 362787, XrefRangeEnd = 362804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 362852, RefRangeEnd = 362853, XrefRangeStart = 362806, XrefRangeEnd = 362852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGraphActive(bool active)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &active
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362853, XrefRangeEnd = 362866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_AudioManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject m_audioGraphGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraphGameObject));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraphGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_audioDbText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioDbText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioDbText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Image> m_backgroundImages
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_backgroundImages));
      return num == IntPtr.Zero ? (List<Image>) null : Il2CppObjectPool.Get<List<Image>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioGraph m_audioGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraph));
      return num == IntPtr.Zero ? (G_AudioGraph) null : Il2CppObjectPool.Get<G_AudioGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioMonitor m_audioMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioMonitor));
      return num == IntPtr.Zero ? (G_AudioMonitor) null : Il2CppObjectPool.Get<G_AudioMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioText m_audioText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioText));
      return num == IntPtr.Zero ? (G_AudioText) null : Il2CppObjectPool.Get<G_AudioText>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform m_rectTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_rectTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> m_childrenGameObjects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_childrenGameObjects));
      return num == IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_childrenGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager.ModuleState m_previousModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_previousModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_previousModuleState)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_currentModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_currentModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_currentModuleState)) = value;
    }
  }
}
