// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.DronePatrolTimelineWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Vehicles;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

public class DronePatrolTimelineWrapper(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_droneAIControllers;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_markers;
  private static readonly System.IntPtr NativeFieldInfoPtr_segmentMarked;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextSegment_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DronePatrolTimelineWrapper()
  {
    Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (DronePatrolTimelineWrapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr);
    DronePatrolTimelineWrapper.NativeFieldInfoPtr_droneAIControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, nameof (droneAIControllers));
    DronePatrolTimelineWrapper.NativeFieldInfoPtr_timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, nameof (timeline));
    DronePatrolTimelineWrapper.NativeFieldInfoPtr_markers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, nameof (markers));
    DronePatrolTimelineWrapper.NativeFieldInfoPtr_segmentMarked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, nameof (segmentMarked));
    DronePatrolTimelineWrapper.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, 100670762);
    DronePatrolTimelineWrapper.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, 100670763);
    DronePatrolTimelineWrapper.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, 100670764);
    DronePatrolTimelineWrapper.NativeMethodInfoPtr_NextSegment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, 100670765);
    DronePatrolTimelineWrapper.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, 100670766);
    DronePatrolTimelineWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, 100670767);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88099, XrefRangeEnd = 88102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88102, XrefRangeEnd = 88158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88158, XrefRangeEnd = 88165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnNotify(Playable origin, INotification notification, Il2CppSystem.Object context)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88165, XrefRangeEnd = 88167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextSegment()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.NativeMethodInfoPtr_NextSegment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88167, XrefRangeEnd = 88174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DronePatrolTimelineWrapper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<FlyingDroneAIController> droneAIControllers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_droneAIControllers));
      return num == System.IntPtr.Zero ? (List<FlyingDroneAIController>) null : Il2CppObjectPool.Get<List<FlyingDroneAIController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_droneAIControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector timeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_timeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_timeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IMarker> markers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_markers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<IMarker>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IMarker>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_markers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool segmentMarked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_segmentMarked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DronePatrolTimelineWrapper.NativeFieldInfoPtr_segmentMarked)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Timeline.DronePatrolTimelineWrapper+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnValidate_b__5_0_Internal_Double_IMarker_0;

    static __c()
    {
      Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DronePatrolTimelineWrapper>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr);
      DronePatrolTimelineWrapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr, "<>9");
      DronePatrolTimelineWrapper.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr, "<>9__5_0");
      DronePatrolTimelineWrapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr, 100670769);
      DronePatrolTimelineWrapper.__c.NativeMethodInfoPtr__OnValidate_b__5_0_Internal_Double_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr, 100670770);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DronePatrolTimelineWrapper.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88095, XrefRangeEnd = 88099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe double _OnValidate_b__5_0(IMarker marker)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) marker)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DronePatrolTimelineWrapper.__c.NativeMethodInfoPtr__OnValidate_b__5_0_Internal_Double_IMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe DronePatrolTimelineWrapper.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(DronePatrolTimelineWrapper.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (DronePatrolTimelineWrapper.__c) null : Il2CppObjectPool.Get<DronePatrolTimelineWrapper.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DronePatrolTimelineWrapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<IMarker, double> __9__5_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(DronePatrolTimelineWrapper.__c.NativeFieldInfoPtr___9__5_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<IMarker, double>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<IMarker, double>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DronePatrolTimelineWrapper.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
