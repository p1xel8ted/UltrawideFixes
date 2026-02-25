// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.FinisherVariant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Combat;

public class FinisherVariant(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_finisherReceiverGraph;
  private static readonly IntPtr NativeFieldInfoPtr_finisherFeedbackGraph;
  private static readonly IntPtr NativeFieldInfoPtr_timelineLeft;
  private static readonly IntPtr NativeFieldInfoPtr_timelineRight;
  private static readonly IntPtr NativeMethodInfoPtr_get_FinisherReceiverGraph_Public_get_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FinisherFeedbackGraph_Public_get_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TimelineLeft_Public_get_TimelineAsset_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TimelineRight_Public_get_TimelineAsset_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FinisherVariant()
  {
    Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (FinisherVariant));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr);
    FinisherVariant.NativeFieldInfoPtr_finisherReceiverGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, nameof (finisherReceiverGraph));
    FinisherVariant.NativeFieldInfoPtr_finisherFeedbackGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, nameof (finisherFeedbackGraph));
    FinisherVariant.NativeFieldInfoPtr_timelineLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, nameof (timelineLeft));
    FinisherVariant.NativeFieldInfoPtr_timelineRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, nameof (timelineRight));
    FinisherVariant.NativeMethodInfoPtr_get_FinisherReceiverGraph_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, 100677718);
    FinisherVariant.NativeMethodInfoPtr_get_FinisherFeedbackGraph_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, 100677719);
    FinisherVariant.NativeMethodInfoPtr_get_TimelineLeft_Public_get_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, 100677720);
    FinisherVariant.NativeMethodInfoPtr_get_TimelineRight_Public_get_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, 100677721);
    FinisherVariant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr, 100677722);
  }

  public unsafe FSMGraph FinisherReceiverGraph
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinisherVariant.NativeMethodInfoPtr_get_FinisherReceiverGraph_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  public unsafe FSMGraph FinisherFeedbackGraph
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinisherVariant.NativeMethodInfoPtr_get_FinisherFeedbackGraph_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  public unsafe TimelineAsset TimelineLeft
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinisherVariant.NativeMethodInfoPtr_get_TimelineLeft_Public_get_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (TimelineAsset) null : Il2CppObjectPool.Get<TimelineAsset>(num3);
    }
  }

  public unsafe TimelineAsset TimelineRight
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinisherVariant.NativeMethodInfoPtr_get_TimelineRight_Public_get_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (TimelineAsset) null : Il2CppObjectPool.Get<TimelineAsset>(num3);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinisherVariant()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinisherVariant>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinisherVariant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FSMGraph finisherReceiverGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_finisherReceiverGraph));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_finisherReceiverGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph finisherFeedbackGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_finisherFeedbackGraph));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_finisherFeedbackGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TimelineAsset timelineLeft
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_timelineLeft));
      return num == IntPtr.Zero ? (TimelineAsset) null : Il2CppObjectPool.Get<TimelineAsset>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_timelineLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TimelineAsset timelineRight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_timelineRight));
      return num == IntPtr.Zero ? (TimelineAsset) null : Il2CppObjectPool.Get<TimelineAsset>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherVariant.NativeFieldInfoPtr_timelineRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
