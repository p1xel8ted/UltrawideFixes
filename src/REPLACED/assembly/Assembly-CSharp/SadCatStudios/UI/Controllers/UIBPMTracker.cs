// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Controllers.UIBPMTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Controllers;

public class UIBPMTracker(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_updateFrequency;
  private static readonly IntPtr NativeFieldInfoPtr_bpmTextMesh;
  private static readonly IntPtr NativeFieldInfoPtr_BpmBaseCount;
  private static readonly IntPtr NativeFieldInfoPtr_BpmFluctuation;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetBaseCount_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetFluctuation_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIBPMTracker()
  {
    Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Controllers", nameof (UIBPMTracker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr);
    UIBPMTracker.NativeFieldInfoPtr_updateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, nameof (updateFrequency));
    UIBPMTracker.NativeFieldInfoPtr_bpmTextMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, nameof (bpmTextMesh));
    UIBPMTracker.NativeFieldInfoPtr_BpmBaseCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, nameof (BpmBaseCount));
    UIBPMTracker.NativeFieldInfoPtr_BpmFluctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, nameof (BpmFluctuation));
    UIBPMTracker.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, nameof (timer));
    UIBPMTracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, 100672576);
    UIBPMTracker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, 100672577);
    UIBPMTracker.NativeMethodInfoPtr_SetBaseCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, 100672578);
    UIBPMTracker.NativeMethodInfoPtr_SetFluctuation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, 100672579);
    UIBPMTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr, 100672580);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102115, XrefRangeEnd = 102118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBPMTracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102118, XrefRangeEnd = 102126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBPMTracker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBaseCount(int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &count
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBPMTracker.NativeMethodInfoPtr_SetBaseCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetFluctuation(int fluctuation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &fluctuation
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBPMTracker.NativeMethodInfoPtr_SetFluctuation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102126, XrefRangeEnd = 102127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIBPMTracker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIBPMTracker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIBPMTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float updateFrequency
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_updateFrequency));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_updateFrequency)) = value;
    }
  }

  public unsafe TextMeshProUGUI bpmTextMesh
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_bpmTextMesh));
      return num == IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_bpmTextMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int BpmBaseCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_BpmBaseCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_BpmBaseCount)) = value;
    }
  }

  public unsafe int BpmFluctuation
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_BpmFluctuation));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_BpmFluctuation)) = value;
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIBPMTracker.NativeFieldInfoPtr_timer)) = value;
    }
  }
}
