// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshClipFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Effects;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Animation;

[Serializable]
public class MeshClipFrame(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_tags;
  private static readonly System.IntPtr NativeFieldInfoPtr_slicePivots;
  private static readonly System.IntPtr NativeFieldInfoPtr_sliceNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameState;
  private static readonly System.IntPtr NativeFieldInfoPtr_pivot;
  private static readonly System.IntPtr NativeFieldInfoPtr_sourcePosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnitPivot;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameEvents_Public_get_List_1_ImpactEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FrameEvents_Public_set_Void_List_1_ImpactEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Sprite_Public_get_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Duration_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameTags_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Pivot_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SourcePosition_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SliceNames_Public_get_SliceNamesDictionary_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SlicePivots_Public_get_SlicePivotsDictionary_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshClipFrame()
  {
    Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshClipFrame));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr);
    MeshClipFrame.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (sprite));
    MeshClipFrame.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (duration));
    MeshClipFrame.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (tags));
    MeshClipFrame.NativeFieldInfoPtr_slicePivots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (slicePivots));
    MeshClipFrame.NativeFieldInfoPtr_sliceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (sliceNames));
    MeshClipFrame.NativeFieldInfoPtr_frameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (frameState));
    MeshClipFrame.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (pivot));
    MeshClipFrame.NativeFieldInfoPtr_sourcePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (sourcePosition));
    MeshClipFrame.NativeFieldInfoPtr_frameEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (frameEvents));
    MeshClipFrame.NativeFieldInfoPtr_UnitPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (UnitPivot));
    MeshClipFrame.NativeMethodInfoPtr_get_FrameEvents_Public_get_List_1_ImpactEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676820);
    MeshClipFrame.NativeMethodInfoPtr_set_FrameEvents_Public_set_Void_List_1_ImpactEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676821);
    MeshClipFrame.NativeMethodInfoPtr_get_Sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676822);
    MeshClipFrame.NativeMethodInfoPtr_get_Duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676823);
    MeshClipFrame.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676824);
    MeshClipFrame.NativeMethodInfoPtr_get_FrameTags_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676825);
    MeshClipFrame.NativeMethodInfoPtr_get_Pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676826);
    MeshClipFrame.NativeMethodInfoPtr_get_SourcePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676827);
    MeshClipFrame.NativeMethodInfoPtr_get_SliceNames_Public_get_SliceNamesDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676828);
    MeshClipFrame.NativeMethodInfoPtr_get_SlicePivots_Public_get_SlicePivotsDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676829);
    MeshClipFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, 100676830);
  }

  public unsafe List<ImpactEvent> FrameEvents
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_FrameEvents_Public_get_List_1_ImpactEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_set_FrameEvents_Public_set_Void_List_1_ImpactEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Sprite Sprite
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_Sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
    }
  }

  public unsafe float Duration
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 126416, RefRangeEnd = 126419, XrefRangeStart = 126416, XrefRangeEnd = 126416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_Duration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FrameState FrameState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrameState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string FrameTags
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_FrameTags_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe Vector2 Pivot
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_Pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 SourcePosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_SourcePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MeshClipFrame.SliceNamesDictionary SliceNames
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_SliceNames_Public_get_SliceNamesDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClipFrame.SliceNamesDictionary) null : Il2CppObjectPool.Get<MeshClipFrame.SliceNamesDictionary>(num3);
    }
  }

  public unsafe MeshClipFrame.SlicePivotsDictionary SlicePivots
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr_get_SlicePivots_Public_get_SlicePivotsDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClipFrame.SlicePivotsDictionary) null : Il2CppObjectPool.Get<MeshClipFrame.SlicePivotsDictionary>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126419, XrefRangeEnd = 126426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipFrame()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Sprite sprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_sprite));
      return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe string tags
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_tags)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_tags), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe MeshClipFrame.SlicePivotsDictionary slicePivots
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_slicePivots));
      return num == System.IntPtr.Zero ? (MeshClipFrame.SlicePivotsDictionary) null : Il2CppObjectPool.Get<MeshClipFrame.SlicePivotsDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_slicePivots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClipFrame.SliceNamesDictionary sliceNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_sliceNames));
      return num == System.IntPtr.Zero ? (MeshClipFrame.SliceNamesDictionary) null : Il2CppObjectPool.Get<MeshClipFrame.SliceNamesDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_sliceNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FrameState frameState
  {
    get
    {
      return *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_frameState));
    }
    [param: In] set
    {
      *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_frameState)) = value;
    }
  }

  public unsafe Vector2 pivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_pivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_pivot)) = value;
    }
  }

  public unsafe Vector2 sourcePosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_sourcePosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_sourcePosition)) = value;
    }
  }

  public unsafe List<ImpactEvent> frameEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_frameEvents));
      return num == System.IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_frameEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 UnitPivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_UnitPivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipFrame.NativeFieldInfoPtr_UnitPivot)) = value;
    }
  }

  [Serializable]
  public class SlicePivotsDictionary(System.IntPtr pointer) : 
    UnitySerializedDictionary<string, Vector2>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SlicePivotsDictionary()
    {
      Il2CppClassPointerStore<MeshClipFrame.SlicePivotsDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (SlicePivotsDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipFrame.SlicePivotsDictionary>.NativeClassPtr);
      MeshClipFrame.SlicePivotsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame.SlicePivotsDictionary>.NativeClassPtr, 100676831);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126410, XrefRangeEnd = 126413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SlicePivotsDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipFrame.SlicePivotsDictionary>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.SlicePivotsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class SliceNamesDictionary(System.IntPtr pointer) : 
    UnitySerializedDictionary<MeshClipFrame.SliceType, string>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SliceNamesDictionary()
    {
      Il2CppClassPointerStore<MeshClipFrame.SliceNamesDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshClipFrame>.NativeClassPtr, nameof (SliceNamesDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipFrame.SliceNamesDictionary>.NativeClassPtr);
      MeshClipFrame.SliceNamesDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipFrame.SliceNamesDictionary>.NativeClassPtr, 100676832);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126413, XrefRangeEnd = 126416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SliceNamesDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipFrame.SliceNamesDictionary>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshClipFrame.SliceNamesDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public enum SliceType
  {
    Vfx,
    Projectile,
    ProjectileDirection,
  }
}
