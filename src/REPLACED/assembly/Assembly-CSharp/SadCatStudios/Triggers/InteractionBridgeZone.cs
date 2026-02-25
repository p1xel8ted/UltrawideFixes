// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.InteractionBridgeZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Environment;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Triggers;

public class InteractionBridgeZone(IntPtr pointer) : InteractionZone(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_isUp;
  private static readonly IntPtr NativeFieldInfoPtr_bridgeObject;
  private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NeedMarker_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsUp_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BridgeObject_Public_get_BridgeObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InteractionBridgeZone()
  {
    Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (InteractionBridgeZone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr);
    InteractionBridgeZone.NativeFieldInfoPtr_isUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, nameof (isUp));
    InteractionBridgeZone.NativeFieldInfoPtr_bridgeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, nameof (bridgeObject));
    InteractionBridgeZone.NativeMethodInfoPtr_get_Priority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671642);
    InteractionBridgeZone.NativeMethodInfoPtr_get_NeedMarker_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671643);
    InteractionBridgeZone.NativeMethodInfoPtr_get_IsUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671644);
    InteractionBridgeZone.NativeMethodInfoPtr_get_BridgeObject_Public_get_BridgeObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671645);
    InteractionBridgeZone.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671646);
    InteractionBridgeZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671647);
    InteractionBridgeZone.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671648 /*0x060020A0*/);
    InteractionBridgeZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671649);
    InteractionBridgeZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr, 100671650);
  }

  public override unsafe int Priority
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBridgeZone.NativeMethodInfoPtr_get_Priority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe bool NeedMarker
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBridgeZone.NativeMethodInfoPtr_get_NeedMarker_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsUp
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 67512, RefRangeEnd = 67513, XrefRangeStart = 67512, XrefRangeEnd = 67513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionBridgeZone.NativeMethodInfoPtr_get_IsUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe BridgeObject BridgeObject
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionBridgeZone.NativeMethodInfoPtr_get_BridgeObject_Public_get_BridgeObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (BridgeObject) null : Il2CppObjectPool.Get<BridgeObject>(num3);
    }
  }

  public override unsafe InteractionZone.InteractionIcon ZoneInteractionType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBridgeZone.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Virtual_get_InteractionIcon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95570, XrefRangeEnd = 95577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionBridgeZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95577, XrefRangeEnd = 95584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractionBridgeZone.NativeMethodInfoPtr_HasInteracted_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95584, XrefRangeEnd = 95599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionBridgeZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95599, XrefRangeEnd = 95604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InteractionBridgeZone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionBridgeZone>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionBridgeZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool isUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBridgeZone.NativeFieldInfoPtr_isUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBridgeZone.NativeFieldInfoPtr_isUp)) = value;
    }
  }

  public unsafe BridgeObject bridgeObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionBridgeZone.NativeFieldInfoPtr_bridgeObject));
      return num == IntPtr.Zero ? (BridgeObject) null : Il2CppObjectPool.Get<BridgeObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionBridgeZone.NativeFieldInfoPtr_bridgeObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
