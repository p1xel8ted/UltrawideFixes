// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.VehicleWaypointControl
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
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

[Serializable]
public class VehicleWaypointControl(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_startMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_endMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_startLook;
  private static readonly System.IntPtr NativeFieldInfoPtr_endLook;
  private static readonly System.IntPtr NativeFieldInfoPtr_Mirror;
  private static readonly System.IntPtr NativeFieldInfoPtr_startMoveTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_endMoveTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_startLookTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_endLookTransform;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VehicleWaypointControl()
  {
    Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (VehicleWaypointControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr);
    VehicleWaypointControl.NativeFieldInfoPtr_startMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (startMove));
    VehicleWaypointControl.NativeFieldInfoPtr_endMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (endMove));
    VehicleWaypointControl.NativeFieldInfoPtr_startLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (startLook));
    VehicleWaypointControl.NativeFieldInfoPtr_endLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (endLook));
    VehicleWaypointControl.NativeFieldInfoPtr_Mirror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (Mirror));
    VehicleWaypointControl.NativeFieldInfoPtr_startMoveTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (startMoveTransform));
    VehicleWaypointControl.NativeFieldInfoPtr_endMoveTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (endMoveTransform));
    VehicleWaypointControl.NativeFieldInfoPtr_startLookTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (startLookTransform));
    VehicleWaypointControl.NativeFieldInfoPtr_endLookTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, nameof (endLookTransform));
    VehicleWaypointControl.NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, 100670834);
    VehicleWaypointControl.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, 100670835);
    VehicleWaypointControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr, 100670836);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88616, XrefRangeEnd = 88639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPlayableCreate(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VehicleWaypointControl.NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88639, XrefRangeEnd = 88670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VehicleWaypointControl.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VehicleWaypointControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleWaypointControl>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VehicleWaypointControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ExposedReference<Transform> startMove
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startMove);
      return new ExposedReference<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startMove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ExposedReference<Transform> endMove
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endMove);
      return new ExposedReference<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endMove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ExposedReference<Transform> startLook
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startLook);
      return new ExposedReference<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startLook), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ExposedReference<Transform> endLook
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endLook);
      return new ExposedReference<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endLook), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe bool Mirror
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_Mirror));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_Mirror)) = value;
    }
  }

  public unsafe Transform startMoveTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startMoveTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startMoveTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform endMoveTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endMoveTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endMoveTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform startLookTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startLookTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_startLookTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform endLookTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endLookTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleWaypointControl.NativeFieldInfoPtr_endLookTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
