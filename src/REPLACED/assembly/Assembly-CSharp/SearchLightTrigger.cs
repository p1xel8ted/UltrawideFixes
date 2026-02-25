// Decompiled with JetBrains decompiler
// Type: SearchLightTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SearchLightTrigger(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_obstructionMask;
  private static readonly IntPtr NativeFieldInfoPtr_detectionCallback;
  private static readonly IntPtr NativeFieldInfoPtr_distractedCallback;
  private static readonly IntPtr NativeFieldInfoPtr_stabilize;
  private static readonly IntPtr NativeFieldInfoPtr_forwardVector;
  private static readonly IntPtr NativeFieldInfoPtr_upwardsVector;
  private static readonly IntPtr NativeFieldInfoPtr_called;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SearchLightTrigger()
  {
    Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SearchLightTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr);
    SearchLightTrigger.NativeFieldInfoPtr_obstructionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (obstructionMask));
    SearchLightTrigger.NativeFieldInfoPtr_detectionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (detectionCallback));
    SearchLightTrigger.NativeFieldInfoPtr_distractedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (distractedCallback));
    SearchLightTrigger.NativeFieldInfoPtr_stabilize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (stabilize));
    SearchLightTrigger.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (forwardVector));
    SearchLightTrigger.NativeFieldInfoPtr_upwardsVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (upwardsVector));
    SearchLightTrigger.NativeFieldInfoPtr_called = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, nameof (called));
    SearchLightTrigger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, 100663431 /*0x06000087*/);
    SearchLightTrigger.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, 100663432 /*0x06000088*/);
    SearchLightTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, 100663433 /*0x06000089*/);
    SearchLightTrigger.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, 100663434 /*0x0600008A*/);
    SearchLightTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr, 100663435 /*0x0600008B*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16520, XrefRangeEnd = 16523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SearchLightTrigger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16523, XrefRangeEnd = 16549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerStay(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SearchLightTrigger.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16549, XrefRangeEnd = 16557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SearchLightTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SearchLightTrigger.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16557, XrefRangeEnd = 16562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SearchLightTrigger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchLightTrigger>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SearchLightTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask obstructionMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_obstructionMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_obstructionMask)) = value;
    }
  }

  public unsafe UnityEvent detectionCallback
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_detectionCallback));
      return num == IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_detectionCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent<Vector3> distractedCallback
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_distractedCallback));
      return num == IntPtr.Zero ? (UnityEvent<Vector3>) null : Il2CppObjectPool.Get<UnityEvent<Vector3>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_distractedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool stabilize
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_stabilize));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_stabilize)) = value;
    }
  }

  public unsafe Vector3 forwardVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_forwardVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_forwardVector)) = value;
    }
  }

  public unsafe Vector3 upwardsVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_upwardsVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_upwardsVector)) = value;
    }
  }

  public unsafe bool called
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_called));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchLightTrigger.NativeFieldInfoPtr_called)) = value;
    }
  }
}
