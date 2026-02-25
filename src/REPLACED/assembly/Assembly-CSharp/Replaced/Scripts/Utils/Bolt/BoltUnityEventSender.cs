// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.Utils.Bolt.BoltUnityEventSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.Utils.Bolt;

public class BoltUnityEventSender(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_EventName;
  private static readonly IntPtr NativeFieldInfoPtr_TargetMachine;
  private static readonly IntPtr NativeMethodInfoPtr_TriggerEvent_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BoltUnityEventSender()
  {
    Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.Utils.Bolt", nameof (BoltUnityEventSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr);
    BoltUnityEventSender.NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr, nameof (EventName));
    BoltUnityEventSender.NativeFieldInfoPtr_TargetMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr, nameof (TargetMachine));
    BoltUnityEventSender.NativeMethodInfoPtr_TriggerEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr, 100670640);
    BoltUnityEventSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr, 100670641);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86889, XrefRangeEnd = 86890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TriggerEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BoltUnityEventSender.NativeMethodInfoPtr_TriggerEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoltUnityEventSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoltUnityEventSender>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BoltUnityEventSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string EventName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventSender.NativeFieldInfoPtr_EventName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventSender.NativeFieldInfoPtr_EventName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe StateMachine TargetMachine
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventSender.NativeFieldInfoPtr_TargetMachine));
      return num == IntPtr.Zero ? (StateMachine) null : Il2CppObjectPool.Get<StateMachine>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventSender.NativeFieldInfoPtr_TargetMachine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
