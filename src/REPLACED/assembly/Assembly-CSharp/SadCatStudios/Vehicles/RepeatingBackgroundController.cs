// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.RepeatingBackgroundController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Vehicles;

public class RepeatingBackgroundController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_chunks;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_beginning;
  private static readonly System.IntPtr NativeFieldInfoPtr_end;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaveSegmentsOnStop;
  private static readonly System.IntPtr NativeFieldInfoPtr_chunkIWanted;
  private static readonly System.IntPtr NativeFieldInfoPtr_chunkI;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentMovingSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_segments;
  private static readonly System.IntPtr NativeFieldInfoPtr_segmentQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr_endingCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_segmentsSorted;
  private static readonly System.IntPtr NativeFieldInfoPtr_started;
  private static readonly System.IntPtr NativeFieldInfoPtr_ending;
  private static readonly System.IntPtr NativeMethodInfoPtr_Move_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartMoving_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopMoving_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextChunk_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Move_b__15_0_Private_Int32_RepeatingBackgroundSegment_RepeatingBackgroundSegment_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Move_b__15_1_Private_Int32_RepeatingBackgroundSegment_RepeatingBackgroundSegment_0;

  static RepeatingBackgroundController()
  {
    Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (RepeatingBackgroundController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr);
    RepeatingBackgroundController.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (chunks));
    RepeatingBackgroundController.NativeFieldInfoPtr_movementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (movementSpeed));
    RepeatingBackgroundController.NativeFieldInfoPtr_beginning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (beginning));
    RepeatingBackgroundController.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (end));
    RepeatingBackgroundController.NativeFieldInfoPtr_leaveSegmentsOnStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (leaveSegmentsOnStop));
    RepeatingBackgroundController.NativeFieldInfoPtr_chunkIWanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (chunkIWanted));
    RepeatingBackgroundController.NativeFieldInfoPtr_chunkI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (chunkI));
    RepeatingBackgroundController.NativeFieldInfoPtr_currentMovingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (currentMovingSpeed));
    RepeatingBackgroundController.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (segments));
    RepeatingBackgroundController.NativeFieldInfoPtr_segmentQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (segmentQueue));
    RepeatingBackgroundController.NativeFieldInfoPtr_endingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (endingCurve));
    RepeatingBackgroundController.NativeFieldInfoPtr_segmentsSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (segmentsSorted));
    RepeatingBackgroundController.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (started));
    RepeatingBackgroundController.NativeFieldInfoPtr_ending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (ending));
    RepeatingBackgroundController.NativeMethodInfoPtr_Move_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673092);
    RepeatingBackgroundController.NativeMethodInfoPtr_StartMoving_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673093);
    RepeatingBackgroundController.NativeMethodInfoPtr_StopMoving_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673094);
    RepeatingBackgroundController.NativeMethodInfoPtr_NextChunk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673095);
    RepeatingBackgroundController.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673096);
    RepeatingBackgroundController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673097);
    RepeatingBackgroundController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673098);
    RepeatingBackgroundController.NativeMethodInfoPtr__Move_b__15_0_Private_Int32_RepeatingBackgroundSegment_RepeatingBackgroundSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673099);
    RepeatingBackgroundController.NativeMethodInfoPtr__Move_b__15_1_Private_Int32_RepeatingBackgroundSegment_RepeatingBackgroundSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, 100673100);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106067, XrefRangeEnd = 106071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Move()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr_Move_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106071, XrefRangeEnd = 106083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartMoving()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr_StartMoving_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void StopMoving()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr_StopMoving_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 106088, RefRangeEnd = 106089, XrefRangeStart = 106083, XrefRangeEnd = 106088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextChunk()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr_NextChunk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106089, XrefRangeEnd = 106103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106103, XrefRangeEnd = 106117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106117, XrefRangeEnd = 106134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RepeatingBackgroundController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106134, XrefRangeEnd = 106149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int _Move_b__15_0(RepeatingBackgroundSegment a, RepeatingBackgroundSegment b)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr__Move_b__15_0_Private_Int32_RepeatingBackgroundSegment_RepeatingBackgroundSegment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int _Move_b__15_1(RepeatingBackgroundSegment a, RepeatingBackgroundSegment b)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.NativeMethodInfoPtr__Move_b__15_1_Private_Int32_RepeatingBackgroundSegment_RepeatingBackgroundSegment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Il2CppReferenceArray<RepeatingBackgroundController.SegmentChunk> chunks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_chunks));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RepeatingBackgroundController.SegmentChunk>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RepeatingBackgroundController.SegmentChunk>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_chunks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 movementSpeed
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_movementSpeed));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_movementSpeed)) = value;
    }
  }

  public unsafe Vector3 beginning
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_beginning));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_beginning)) = value;
    }
  }

  public unsafe Vector3 end
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_end));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_end)) = value;
    }
  }

  public unsafe int leaveSegmentsOnStop
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_leaveSegmentsOnStop));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_leaveSegmentsOnStop)) = value;
    }
  }

  public unsafe int chunkIWanted
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_chunkIWanted));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_chunkIWanted)) = value;
    }
  }

  public unsafe int chunkI
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_chunkI));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_chunkI)) = value;
    }
  }

  public unsafe Vector3 currentMovingSpeed
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_currentMovingSpeed));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_currentMovingSpeed)) = value;
    }
  }

  public unsafe List<RepeatingBackgroundSegment> segments
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_segments));
      return num == System.IntPtr.Zero ? (List<RepeatingBackgroundSegment>) null : Il2CppObjectPool.Get<List<RepeatingBackgroundSegment>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<Il2CppReferenceArray<RepeatingBackgroundSegment>> segmentQueue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_segmentQueue));
      return num == System.IntPtr.Zero ? (Queue<Il2CppReferenceArray<RepeatingBackgroundSegment>>) null : Il2CppObjectPool.Get<Queue<Il2CppReferenceArray<RepeatingBackgroundSegment>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_segmentQueue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve endingCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_endingCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_endingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<RepeatingBackgroundSegment> segmentsSorted
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_segmentsSorted));
      return num == System.IntPtr.Zero ? (List<RepeatingBackgroundSegment>) null : Il2CppObjectPool.Get<List<RepeatingBackgroundSegment>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_segmentsSorted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool started
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_started));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_started)) = value;
    }
  }

  public unsafe bool ending
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_ending));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.NativeFieldInfoPtr_ending)) = value;
    }
  }

  [Serializable]
  public class SegmentChunk(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Segments;
    private static readonly System.IntPtr NativeFieldInfoPtr_Once;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoopCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ending;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimesLooped;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SegmentChunk()
    {
      Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, nameof (SegmentChunk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr);
      RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr, nameof (Segments));
      RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Once = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr, nameof (Once));
      RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_LoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr, nameof (LoopCount));
      RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Ending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr, nameof (Ending));
      RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_TimesLooped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr, nameof (TimesLooped));
      RepeatingBackgroundController.SegmentChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr, 100673101);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SegmentChunk()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatingBackgroundController.SegmentChunk>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController.SegmentChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppReferenceArray<RepeatingBackgroundSegment> Segments
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Segments));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RepeatingBackgroundSegment>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RepeatingBackgroundSegment>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Segments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool Once
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Once));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Once)) = value;
      }
    }

    public unsafe int LoopCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_LoopCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_LoopCount)) = value;
      }
    }

    public unsafe bool Ending
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Ending));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_Ending)) = value;
      }
    }

    public unsafe int TimesLooped
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_TimesLooped));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController.SegmentChunk.NativeFieldInfoPtr_TimesLooped)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Vehicles.RepeatingBackgroundController+<Move>d__15")]
  public sealed class _Move_d__15(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__needsResorting_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Move_d__15()
    {
      Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepeatingBackgroundController>.NativeClassPtr, "<Move>d__15");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr);
      RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, "<>1__state");
      RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, "<>2__current");
      RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, "<>4__this");
      RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr__needsResorting_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, "<needsResorting>5__2");
      RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, 100673102);
      RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, 100673103);
      RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, 100673104);
      RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, 100673105);
      RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, 100673106);
      RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr, 100673107);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Move_d__15(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatingBackgroundController._Move_d__15>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105903, XrefRangeEnd = 106062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106062, XrefRangeEnd = 106067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundController._Move_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RepeatingBackgroundController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (RepeatingBackgroundController) null : Il2CppObjectPool.Get<RepeatingBackgroundController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _needsResorting_5__2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr__needsResorting_5__2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundController._Move_d__15.NativeFieldInfoPtr__needsResorting_5__2)) = value;
      }
    }
  }
}
