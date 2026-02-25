// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsManager
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
namespace Tayx.Graphy.Fps;

public class G_FpsManager(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraphGameObject;
  private static readonly IntPtr NativeFieldInfoPtr_m_nonBasicTextGameObjects;
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraph;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_fpsText;
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

  static G_FpsManager()
  {
    Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Fps", nameof (G_FpsManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr);
    G_FpsManager.NativeFieldInfoPtr_m_fpsGraphGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_fpsGraphGameObject));
    G_FpsManager.NativeFieldInfoPtr_m_nonBasicTextGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_nonBasicTextGameObjects));
    G_FpsManager.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_backgroundImages));
    G_FpsManager.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_graphyManager));
    G_FpsManager.NativeFieldInfoPtr_m_fpsGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_fpsGraph));
    G_FpsManager.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_fpsMonitor));
    G_FpsManager.NativeFieldInfoPtr_m_fpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_fpsText));
    G_FpsManager.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_rectTransform));
    G_FpsManager.NativeFieldInfoPtr_m_childrenGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_childrenGameObjects));
    G_FpsManager.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_previousModuleState));
    G_FpsManager.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, nameof (m_currentModuleState));
    G_FpsManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663588);
    G_FpsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663589);
    G_FpsManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663590);
    G_FpsManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663591);
    G_FpsManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663592);
    G_FpsManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663593);
    G_FpsManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663594);
    G_FpsManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663595);
    G_FpsManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663596);
    G_FpsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100663597);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362376, XrefRangeEnd = 362377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362377, XrefRangeEnd = 362378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 362394, RefRangeEnd = 362398, XrefRangeStart = 362378, XrefRangeEnd = 362394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &newModulePosition
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 362406, RefRangeEnd = 362419, XrefRangeStart = 362398, XrefRangeEnd = 362406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &silentUpdate;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362419, XrefRangeEnd = 362420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestorePreviousState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 362436, RefRangeEnd = 362460, XrefRangeStart = 362420, XrefRangeEnd = 362436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 362476, RefRangeEnd = 362478, XrefRangeStart = 362460, XrefRangeEnd = 362476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 362524, RefRangeEnd = 362525, XrefRangeStart = 362478, XrefRangeEnd = 362524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362525, XrefRangeEnd = 362528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGraphActive(bool active)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &active
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362528, XrefRangeEnd = 362545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_FpsManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject m_fpsGraphGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraphGameObject));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraphGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> m_nonBasicTextGameObjects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_nonBasicTextGameObjects));
      return num == IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_nonBasicTextGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Image> m_backgroundImages
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_backgroundImages));
      return num == IntPtr.Zero ? (List<Image>) null : Il2CppObjectPool.Get<List<Image>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_FpsGraph m_fpsGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraph));
      return num == IntPtr.Zero ? (G_FpsGraph) null : Il2CppObjectPool.Get<G_FpsGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_FpsMonitor m_fpsMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsMonitor));
      return num == IntPtr.Zero ? (G_FpsMonitor) null : Il2CppObjectPool.Get<G_FpsMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_FpsText m_fpsText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsText));
      return num == IntPtr.Zero ? (G_FpsText) null : Il2CppObjectPool.Get<G_FpsText>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform m_rectTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_rectTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> m_childrenGameObjects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_childrenGameObjects));
      return num == IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_childrenGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager.ModuleState m_previousModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_previousModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_previousModuleState)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_currentModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_currentModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_currentModuleState)) = value;
    }
  }
}
