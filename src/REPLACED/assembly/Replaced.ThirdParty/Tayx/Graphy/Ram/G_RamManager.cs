// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamManager
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
namespace Tayx.Graphy.Ram;

public class G_RamManager(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_ramGraphGameObject;
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramGraph;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramText;
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

  static G_RamManager()
  {
    Il2CppClassPointerStore<G_RamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Ram", nameof (G_RamManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr);
    G_RamManager.NativeFieldInfoPtr_m_ramGraphGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_ramGraphGameObject));
    G_RamManager.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_backgroundImages));
    G_RamManager.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_graphyManager));
    G_RamManager.NativeFieldInfoPtr_m_ramGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_ramGraph));
    G_RamManager.NativeFieldInfoPtr_m_ramText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_ramText));
    G_RamManager.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_rectTransform));
    G_RamManager.NativeFieldInfoPtr_m_childrenGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_childrenGameObjects));
    G_RamManager.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_previousModuleState));
    G_RamManager.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, nameof (m_currentModuleState));
    G_RamManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663558 /*0x06000106*/);
    G_RamManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663559 /*0x06000107*/);
    G_RamManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663560 /*0x06000108*/);
    G_RamManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663561 /*0x06000109*/);
    G_RamManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663562 /*0x0600010A*/);
    G_RamManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663563 /*0x0600010B*/);
    G_RamManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663564 /*0x0600010C*/);
    G_RamManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663565 /*0x0600010D*/);
    G_RamManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663566 /*0x0600010E*/);
    G_RamManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100663567 /*0x0600010F*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362133, XrefRangeEnd = 362134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362134, XrefRangeEnd = 362135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 362151, RefRangeEnd = 362155, XrefRangeStart = 362135, XrefRangeEnd = 362151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &newModulePosition
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 362163, RefRangeEnd = 362173, XrefRangeStart = 362155, XrefRangeEnd = 362163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &silentUpdate;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362173, XrefRangeEnd = 362174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestorePreviousState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 362191, RefRangeEnd = 362209, XrefRangeStart = 362174, XrefRangeEnd = 362191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 362226, RefRangeEnd = 362228, XrefRangeStart = 362209, XrefRangeEnd = 362226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 362271, RefRangeEnd = 362272, XrefRangeStart = 362228, XrefRangeEnd = 362271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362272, XrefRangeEnd = 362275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGraphActive(bool active)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &active
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362275, XrefRangeEnd = 362288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_RamManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject m_ramGraphGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraphGameObject));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraphGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Image> m_backgroundImages
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_backgroundImages));
      return num == IntPtr.Zero ? (List<Image>) null : Il2CppObjectPool.Get<List<Image>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamGraph m_ramGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraph));
      return num == IntPtr.Zero ? (G_RamGraph) null : Il2CppObjectPool.Get<G_RamGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamText m_ramText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramText));
      return num == IntPtr.Zero ? (G_RamText) null : Il2CppObjectPool.Get<G_RamText>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform m_rectTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_rectTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> m_childrenGameObjects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_childrenGameObjects));
      return num == IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_childrenGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager.ModuleState m_previousModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_previousModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_previousModuleState)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_currentModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_currentModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_currentModuleState)) = value;
    }
  }
}
