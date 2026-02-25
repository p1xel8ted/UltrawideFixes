// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Advanced.G_AdvancedData
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Advanced;

public class G_AdvancedData(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphicsDeviceVersionText;
  private static readonly IntPtr NativeFieldInfoPtr_m_processorTypeText;
  private static readonly IntPtr NativeFieldInfoPtr_m_operatingSystemText;
  private static readonly IntPtr NativeFieldInfoPtr_m_systemMemoryText;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphicsDeviceNameText;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphicsMemorySizeText;
  private static readonly IntPtr NativeFieldInfoPtr_m_screenResolutionText;
  private static readonly IntPtr NativeFieldInfoPtr_m_gameWindowResolutionText;
  private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;
  private static readonly IntPtr NativeFieldInfoPtr_m_deltaTime;
  private static readonly IntPtr NativeFieldInfoPtr_m_sb;
  private static readonly IntPtr NativeFieldInfoPtr_m_previousModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_currentModuleState;
  private static readonly IntPtr NativeFieldInfoPtr_m_windowStrings;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RefreshParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_AdvancedData()
  {
    Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Advanced", nameof (G_AdvancedData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr);
    G_AdvancedData.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_backgroundImages));
    G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceVersionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_graphicsDeviceVersionText));
    G_AdvancedData.NativeFieldInfoPtr_m_processorTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_processorTypeText));
    G_AdvancedData.NativeFieldInfoPtr_m_operatingSystemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_operatingSystemText));
    G_AdvancedData.NativeFieldInfoPtr_m_systemMemoryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_systemMemoryText));
    G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_graphicsDeviceNameText));
    G_AdvancedData.NativeFieldInfoPtr_m_graphicsMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_graphicsMemorySizeText));
    G_AdvancedData.NativeFieldInfoPtr_m_screenResolutionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_screenResolutionText));
    G_AdvancedData.NativeFieldInfoPtr_m_gameWindowResolutionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_gameWindowResolutionText));
    G_AdvancedData.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_updateRate));
    G_AdvancedData.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_graphyManager));
    G_AdvancedData.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_rectTransform));
    G_AdvancedData.NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_deltaTime));
    G_AdvancedData.NativeFieldInfoPtr_m_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_sb));
    G_AdvancedData.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_previousModuleState));
    G_AdvancedData.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_currentModuleState));
    G_AdvancedData.NativeFieldInfoPtr_m_windowStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, nameof (m_windowStrings));
    G_AdvancedData.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663651);
    G_AdvancedData.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663652);
    G_AdvancedData.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663653);
    G_AdvancedData.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663654);
    G_AdvancedData.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663655);
    G_AdvancedData.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663656);
    G_AdvancedData.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663657);
    G_AdvancedData.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663658);
    G_AdvancedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100663659);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362963, XrefRangeEnd = 362964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362964, XrefRangeEnd = 362991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 363043, RefRangeEnd = 363048, XrefRangeStart = 362991, XrefRangeEnd = 363043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &newModulePosition
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363048, XrefRangeEnd = 363053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &silentUpdate;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363053, XrefRangeEnd = 363058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RestorePreviousState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 363077, RefRangeEnd = 363085, XrefRangeStart = 363058, XrefRangeEnd = 363077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 363104, RefRangeEnd = 363106, XrefRangeStart = 363085, XrefRangeEnd = 363104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 363269, RefRangeEnd = 363270, XrefRangeStart = 363106, XrefRangeEnd = 363269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363270, XrefRangeEnd = 363294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_AdvancedData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<Image> m_backgroundImages
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_backgroundImages));
      return num == IntPtr.Zero ? (List<Image>) null : Il2CppObjectPool.Get<List<Image>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_graphicsDeviceVersionText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceVersionText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceVersionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_processorTypeText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_processorTypeText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_processorTypeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_operatingSystemText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_operatingSystemText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_operatingSystemText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_systemMemoryText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_systemMemoryText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_systemMemoryText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_graphicsDeviceNameText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceNameText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_graphicsMemorySizeText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsMemorySizeText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_screenResolutionText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_screenResolutionText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_screenResolutionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text m_gameWindowResolutionText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_gameWindowResolutionText));
      return num == IntPtr.Zero ? (UnityEngine.UI.Text) null : Il2CppObjectPool.Get<UnityEngine.UI.Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_gameWindowResolutionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_updateRate
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_updateRate));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_updateRate)) = value;
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform m_rectTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_rectTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_deltaTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_deltaTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_deltaTime)) = value;
    }
  }

  public unsafe StringBuilder m_sb
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_sb));
      return num == IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager.ModuleState m_previousModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_previousModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_previousModuleState)) = value;
    }
  }

  public unsafe GraphyManager.ModuleState m_currentModuleState
  {
    get
    {
      return *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_currentModuleState));
    }
    [param: In] set
    {
      *(GraphyManager.ModuleState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_currentModuleState)) = value;
    }
  }

  public unsafe Il2CppStringArray m_windowStrings
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_windowStrings));
      return num == IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_windowStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
