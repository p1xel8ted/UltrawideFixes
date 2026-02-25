// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamText
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
namespace Tayx.Graphy.Ram;

public class G_RamText(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_allocatedSystemMemorySizeText;
  private static readonly IntPtr NativeFieldInfoPtr_m_reservedSystemMemorySizeText;
  private static readonly IntPtr NativeFieldInfoPtr_m_monoSystemMemorySizeText;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;
  private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;
  private static readonly IntPtr NativeFieldInfoPtr_m_deltaTime;
  private static readonly IntPtr NativeFieldInfoPtr_m_memoryStringFormat;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_RamText()
  {
    Il2CppClassPointerStore<G_RamText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Ram", nameof (G_RamText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamText>.NativeClassPtr);
    G_RamText.NativeFieldInfoPtr_m_allocatedSystemMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_allocatedSystemMemorySizeText));
    G_RamText.NativeFieldInfoPtr_m_reservedSystemMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_reservedSystemMemorySizeText));
    G_RamText.NativeFieldInfoPtr_m_monoSystemMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_monoSystemMemorySizeText));
    G_RamText.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_graphyManager));
    G_RamText.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_ramMonitor));
    G_RamText.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_updateRate));
    G_RamText.NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_deltaTime));
    G_RamText.NativeFieldInfoPtr_m_memoryStringFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, nameof (m_memoryStringFormat));
    G_RamText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100663573);
    G_RamText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100663574);
    G_RamText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100663575);
    G_RamText.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100663576);
    G_RamText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100663577);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362291, XrefRangeEnd = 362314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362314, XrefRangeEnd = 362321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 362321, RefRangeEnd = 362325, XrefRangeStart = 362321, XrefRangeEnd = 362321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362325, XrefRangeEnd = 362328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_RamText()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamText>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Text m_allocatedSystemMemorySizeText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_allocatedSystemMemorySizeText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_allocatedSystemMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_reservedSystemMemorySizeText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_reservedSystemMemorySizeText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_reservedSystemMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text m_monoSystemMemorySizeText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_monoSystemMemorySizeText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_monoSystemMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamMonitor m_ramMonitor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_ramMonitor));
      return num == IntPtr.Zero ? (G_RamMonitor) null : Il2CppObjectPool.Get<G_RamMonitor>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_updateRate
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_updateRate));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_updateRate)) = value;
    }
  }

  public unsafe float m_deltaTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_deltaTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_deltaTime)) = value;
    }
  }

  public unsafe string m_memoryStringFormat
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_memoryStringFormat)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_memoryStringFormat), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
