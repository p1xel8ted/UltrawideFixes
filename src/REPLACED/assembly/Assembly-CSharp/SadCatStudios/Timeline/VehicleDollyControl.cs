// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.VehicleDollyControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
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
public class VehicleDollyControl(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_useCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_curve;
  private static readonly System.IntPtr NativeFieldInfoPtr_movePath;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookPath;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSmooth;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSmoothSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookSmooth;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookSmoothSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_Mirror;
  private static readonly System.IntPtr NativeFieldInfoPtr_move;
  private static readonly System.IntPtr NativeFieldInfoPtr_look;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VehicleDollyControl()
  {
    Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (VehicleDollyControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr);
    VehicleDollyControl.NativeFieldInfoPtr_useCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (useCurve));
    VehicleDollyControl.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (curve));
    VehicleDollyControl.NativeFieldInfoPtr_movePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (movePath));
    VehicleDollyControl.NativeFieldInfoPtr_lookPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (lookPath));
    VehicleDollyControl.NativeFieldInfoPtr_moveSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (moveSmooth));
    VehicleDollyControl.NativeFieldInfoPtr_moveSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (moveSmoothSpeed));
    VehicleDollyControl.NativeFieldInfoPtr_lookSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (lookSmooth));
    VehicleDollyControl.NativeFieldInfoPtr_lookSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (lookSmoothSpeed));
    VehicleDollyControl.NativeFieldInfoPtr_Mirror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (Mirror));
    VehicleDollyControl.NativeFieldInfoPtr_move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (move));
    VehicleDollyControl.NativeFieldInfoPtr_look = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, nameof (look));
    VehicleDollyControl.NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, 100670825);
    VehicleDollyControl.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, 100670826);
    VehicleDollyControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr, 100670827);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88549, XrefRangeEnd = 88562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPlayableCreate(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VehicleDollyControl.NativeMethodInfoPtr_OnPlayableCreate_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88562, XrefRangeEnd = 88583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VehicleDollyControl.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88583, XrefRangeEnd = 88585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VehicleDollyControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleDollyControl>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VehicleDollyControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool useCurve
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_useCurve));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_useCurve)) = value;
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_curve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public ExposedReference<CinemachineSmoothPath> movePath
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_movePath);
      return new ExposedReference<CinemachineSmoothPath>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<CinemachineSmoothPath>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_movePath), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<CinemachineSmoothPath>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ExposedReference<CinemachineSmoothPath> lookPath
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_lookPath);
      return new ExposedReference<CinemachineSmoothPath>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<CinemachineSmoothPath>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_lookPath), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<CinemachineSmoothPath>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe bool moveSmooth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_moveSmooth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_moveSmooth)) = value;
    }
  }

  public unsafe float moveSmoothSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_moveSmoothSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_moveSmoothSpeed)) = value;
    }
  }

  public unsafe bool lookSmooth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_lookSmooth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_lookSmooth)) = value;
    }
  }

  public unsafe float lookSmoothSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_lookSmoothSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_lookSmoothSpeed)) = value;
    }
  }

  public unsafe bool Mirror
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_Mirror));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_Mirror)) = value;
    }
  }

  public unsafe CinemachineSmoothPath move
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_move));
      return num == System.IntPtr.Zero ? (CinemachineSmoothPath) null : Il2CppObjectPool.Get<CinemachineSmoothPath>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_move), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineSmoothPath look
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_look));
      return num == System.IntPtr.Zero ? (CinemachineSmoothPath) null : Il2CppObjectPool.Get<CinemachineSmoothPath>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VehicleDollyControl.NativeFieldInfoPtr_look), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
