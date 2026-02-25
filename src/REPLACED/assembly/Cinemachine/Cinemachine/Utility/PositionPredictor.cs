// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.PositionPredictor
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public class PositionPredictor(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Velocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SmoothDampVelocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Pos;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HavePos;
  private static readonly System.IntPtr NativeFieldInfoPtr_Smoothing;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTransformDelta_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPosition_Public_Void_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PredictPositionDelta_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PositionPredictor()
  {
    Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (PositionPredictor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr);
    PositionPredictor.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, nameof (m_Velocity));
    PositionPredictor.NativeFieldInfoPtr_m_SmoothDampVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, nameof (m_SmoothDampVelocity));
    PositionPredictor.NativeFieldInfoPtr_m_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, nameof (m_Pos));
    PositionPredictor.NativeFieldInfoPtr_m_HavePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, nameof (m_HavePos));
    PositionPredictor.NativeFieldInfoPtr_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, nameof (Smoothing));
    PositionPredictor.NativeMethodInfoPtr_ApplyTransformDelta_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, 100664476);
    PositionPredictor.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, 100664477);
    PositionPredictor.NativeMethodInfoPtr_AddPosition_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, 100664478);
    PositionPredictor.NativeMethodInfoPtr_PredictPositionDelta_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, 100664479);
    PositionPredictor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr, 100664480 /*0x060004A0*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 947830, RefRangeEnd = 947832, XrefRangeStart = 947830, XrefRangeEnd = 947830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyTransformDelta(Vector3 positionDelta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &positionDelta
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PositionPredictor.NativeMethodInfoPtr_ApplyTransformDelta_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947836, RefRangeEnd = 947837, XrefRangeStart = 947832, XrefRangeEnd = 947836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PositionPredictor.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 947842, RefRangeEnd = 947844, XrefRangeStart = 947837, XrefRangeEnd = 947842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lookaheadTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PositionPredictor.NativeMethodInfoPtr_AddPosition_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 947844, RefRangeEnd = 947846, XrefRangeStart = 947844, XrefRangeEnd = 947844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 PredictPositionDelta(float lookaheadTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &lookaheadTime
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PositionPredictor.NativeMethodInfoPtr_PredictPositionDelta_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PositionPredictor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionPredictor>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PositionPredictor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 m_Velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_Velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_Velocity)) = value;
    }
  }

  public unsafe Vector3 m_SmoothDampVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_SmoothDampVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_SmoothDampVelocity)) = value;
    }
  }

  public unsafe Vector3 m_Pos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_Pos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_Pos)) = value;
    }
  }

  public unsafe bool m_HavePos
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_HavePos));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_m_HavePos)) = value;
    }
  }

  public unsafe float Smoothing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_Smoothing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionPredictor.NativeFieldInfoPtr_Smoothing)) = value;
    }
  }
}
