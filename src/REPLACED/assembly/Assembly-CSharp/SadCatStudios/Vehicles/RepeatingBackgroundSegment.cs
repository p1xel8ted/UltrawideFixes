// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.RepeatingBackgroundSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Vehicles;

public class RepeatingBackgroundSegment(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SegmentEnd;
  private static readonly IntPtr NativeFieldInfoPtr_SegmentStart;
  private static readonly IntPtr NativeFieldInfoPtr_ParentChunk;
  private static readonly IntPtr NativeFieldInfoPtr_QueuedParentChunks;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RepeatingBackgroundSegment()
  {
    Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (RepeatingBackgroundSegment));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr);
    RepeatingBackgroundSegment.NativeFieldInfoPtr_SegmentEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr, nameof (SegmentEnd));
    RepeatingBackgroundSegment.NativeFieldInfoPtr_SegmentStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr, nameof (SegmentStart));
    RepeatingBackgroundSegment.NativeFieldInfoPtr_ParentChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr, nameof (ParentChunk));
    RepeatingBackgroundSegment.NativeFieldInfoPtr_QueuedParentChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr, nameof (QueuedParentChunks));
    RepeatingBackgroundSegment.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr, 100673108);
    RepeatingBackgroundSegment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr, 100673109);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106149, XrefRangeEnd = 106157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundSegment.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106157, XrefRangeEnd = 106164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RepeatingBackgroundSegment()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatingBackgroundSegment>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RepeatingBackgroundSegment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 SegmentEnd
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_SegmentEnd));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_SegmentEnd)) = value;
    }
  }

  public unsafe Vector3 SegmentStart
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_SegmentStart));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_SegmentStart)) = value;
    }
  }

  public unsafe RepeatingBackgroundController.SegmentChunk ParentChunk
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_ParentChunk));
      return num == IntPtr.Zero ? (RepeatingBackgroundController.SegmentChunk) null : Il2CppObjectPool.Get<RepeatingBackgroundController.SegmentChunk>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_ParentChunk), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<RepeatingBackgroundController.SegmentChunk> QueuedParentChunks
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_QueuedParentChunks));
      return num == IntPtr.Zero ? (Queue<RepeatingBackgroundController.SegmentChunk>) null : Il2CppObjectPool.Get<Queue<RepeatingBackgroundController.SegmentChunk>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepeatingBackgroundSegment.NativeFieldInfoPtr_QueuedParentChunks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
