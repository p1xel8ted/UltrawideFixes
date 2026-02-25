// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineLookAroundExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CinemachineLookAroundExtension(IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_maxSidesLookDistance;
  private static readonly IntPtr NativeFieldInfoPtr_maxUpLookDistance;
  private static readonly IntPtr NativeFieldInfoPtr_maxDownLookDistance;
  private static readonly IntPtr NativeFieldInfoPtr_smoothTime;
  private static readonly IntPtr NativeFieldInfoPtr_boundingMask;
  private static readonly IntPtr NativeFieldInfoPtr_boundingSphereRadius;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_resultingLook;
  private static readonly IntPtr NativeFieldInfoPtr_collisionFix;
  private static readonly IntPtr NativeFieldInfoPtr_finalEasing;
  private static readonly IntPtr NativeFieldInfoPtr_resultPos;
  private static readonly IntPtr NativeFieldInfoPtr_easingVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_lastNorm;
  private static readonly IntPtr NativeFieldInfoPtr_transposer;
  private static readonly IntPtr NativeFieldInfoPtr_overlapBuffer;
  private static readonly IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineLookAroundExtension()
  {
    Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineLookAroundExtension));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr);
    CinemachineLookAroundExtension.NativeFieldInfoPtr_maxSidesLookDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (maxSidesLookDistance));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_maxUpLookDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (maxUpLookDistance));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_maxDownLookDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (maxDownLookDistance));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (smoothTime));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_boundingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (boundingMask));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_boundingSphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (boundingSphereRadius));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (offset));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_resultingLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (resultingLook));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_collisionFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (collisionFix));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_finalEasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (finalEasing));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_resultPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (resultPos));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_easingVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (easingVelocity));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_lastNorm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (lastNorm));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_transposer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (transposer));
    CinemachineLookAroundExtension.NativeFieldInfoPtr_overlapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, nameof (overlapBuffer));
    CinemachineLookAroundExtension.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, 100676357);
    CinemachineLookAroundExtension.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, 100676358);
    CinemachineLookAroundExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr, 100676359);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122956, XrefRangeEnd = 123035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stage;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineLookAroundExtension.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123035, XrefRangeEnd = 123042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineLookAroundExtension.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123042, XrefRangeEnd = 123050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineLookAroundExtension()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineLookAroundExtension>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineLookAroundExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float maxSidesLookDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_maxSidesLookDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_maxSidesLookDistance)) = value;
    }
  }

  public unsafe float maxUpLookDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_maxUpLookDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_maxUpLookDistance)) = value;
    }
  }

  public unsafe float maxDownLookDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_maxDownLookDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_maxDownLookDistance)) = value;
    }
  }

  public unsafe float smoothTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_smoothTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_smoothTime)) = value;
    }
  }

  public unsafe LayerMask boundingMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_boundingMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_boundingMask)) = value;
    }
  }

  public unsafe float boundingSphereRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_boundingSphereRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_boundingSphereRadius)) = value;
    }
  }

  public unsafe VectorVariable offset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_offset));
      return num == IntPtr.Zero ? (VectorVariable) null : Il2CppObjectPool.Get<VectorVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_offset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 resultingLook
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_resultingLook));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_resultingLook)) = value;
    }
  }

  public unsafe Vector3 collisionFix
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_collisionFix));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_collisionFix)) = value;
    }
  }

  public unsafe Vector3 finalEasing
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_finalEasing));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_finalEasing)) = value;
    }
  }

  public unsafe Vector3 resultPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_resultPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_resultPos)) = value;
    }
  }

  public unsafe Vector3 easingVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_easingVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_easingVelocity)) = value;
    }
  }

  public unsafe Vector3 lastNorm
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_lastNorm));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_lastNorm)) = value;
    }
  }

  public unsafe CinemachineTransposer transposer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_transposer));
      return num == IntPtr.Zero ? (CinemachineTransposer) null : Il2CppObjectPool.Get<CinemachineTransposer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_transposer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapBuffer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_overlapBuffer));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineLookAroundExtension.NativeFieldInfoPtr_overlapBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
