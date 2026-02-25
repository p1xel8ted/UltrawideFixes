// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.PlatformPhysics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Foundation;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.MovementPhysics;

public class PlatformPhysics(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_passengerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_startingPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_speed;
  private static readonly System.IntPtr NativeFieldInfoPtr_easeAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPointsOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_platformCollider;
  private static readonly System.IntPtr NativeFieldInfoPtr_startingPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_floorOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_floorHalfOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_isMoving;
  private static readonly System.IntPtr NativeFieldInfoPtr_movedPassengers;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlappedPassengers;
  private static readonly System.IntPtr NativeFieldInfoPtr_startPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_extents;
  private static readonly System.IntPtr NativeFieldInfoPtr_percentBetweenWaypoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_movementInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopInstance;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPointPosition_Private_Vector3_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToPointInstant_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallToPoint_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToUpPoint_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToDownPoint_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToPoint_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePlatformMovement_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ease_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MovePassengers_Private_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlatformPhysics()
  {
    Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (PlatformPhysics));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr);
    PlatformPhysics.NativeFieldInfoPtr_passengerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (passengerMask));
    PlatformPhysics.NativeFieldInfoPtr_startingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (startingPoint));
    PlatformPhysics.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (speed));
    PlatformPhysics.NativeFieldInfoPtr_easeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (easeAmount));
    PlatformPhysics.NativeFieldInfoPtr_targetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (targetIndex));
    PlatformPhysics.NativeFieldInfoPtr_targetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (targetPoint));
    PlatformPhysics.NativeFieldInfoPtr_movementSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (movementSound));
    PlatformPhysics.NativeFieldInfoPtr_stopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (stopSound));
    PlatformPhysics.NativeFieldInfoPtr_targetPointsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (targetPointsOffset));
    PlatformPhysics.NativeFieldInfoPtr_platformCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (platformCollider));
    PlatformPhysics.NativeFieldInfoPtr_startingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (startingPosition));
    PlatformPhysics.NativeFieldInfoPtr_floorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (floorOffset));
    PlatformPhysics.NativeFieldInfoPtr_floorHalfOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (floorHalfOffset));
    PlatformPhysics.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (isMoving));
    PlatformPhysics.NativeFieldInfoPtr_movedPassengers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (movedPassengers));
    PlatformPhysics.NativeFieldInfoPtr_overlappedPassengers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (overlappedPassengers));
    PlatformPhysics.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (startPos));
    PlatformPhysics.NativeFieldInfoPtr_finalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (finalPos));
    PlatformPhysics.NativeFieldInfoPtr_extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (extents));
    PlatformPhysics.NativeFieldInfoPtr_percentBetweenWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (percentBetweenWaypoints));
    PlatformPhysics.NativeFieldInfoPtr_movementInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (movementInstance));
    PlatformPhysics.NativeFieldInfoPtr_stopInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, nameof (stopInstance));
    PlatformPhysics.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670983);
    PlatformPhysics.NativeMethodInfoPtr_GetPointPosition_Private_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670984);
    PlatformPhysics.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670985);
    PlatformPhysics.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670986);
    PlatformPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670987);
    PlatformPhysics.NativeMethodInfoPtr_MoveToPointInstant_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670988);
    PlatformPhysics.NativeMethodInfoPtr_CallToPoint_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670989);
    PlatformPhysics.NativeMethodInfoPtr_MoveToUpPoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670990);
    PlatformPhysics.NativeMethodInfoPtr_MoveToDownPoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670991);
    PlatformPhysics.NativeMethodInfoPtr_MoveToPoint_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670992);
    PlatformPhysics.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670993);
    PlatformPhysics.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670994);
    PlatformPhysics.NativeMethodInfoPtr_CalculatePlatformMovement_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670995);
    PlatformPhysics.NativeMethodInfoPtr_Ease_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670996);
    PlatformPhysics.NativeMethodInfoPtr_MovePassengers_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670997);
    PlatformPhysics.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670998);
    PlatformPhysics.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100670999);
    PlatformPhysics.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100671000);
    PlatformPhysics.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100671001);
    PlatformPhysics.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100671002);
    PlatformPhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr, 100671003);
  }

  public unsafe bool IsMoving
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90080, RefRangeEnd = 90083, XrefRangeStart = 90077, XrefRangeEnd = 90080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPointPosition(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_GetPointPosition_Private_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90083, XrefRangeEnd = 90101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90101, XrefRangeEnd = 90112 /*0x016000*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90112 /*0x016000*/, XrefRangeEnd = 90127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90127, XrefRangeEnd = 90130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToPointInstant(int target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &target
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_MoveToPointInstant_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90131, RefRangeEnd = 90132, XrefRangeStart = 90130, XrefRangeEnd = 90131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallToPoint(int targetPoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetPoint
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_CallToPoint_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90132, XrefRangeEnd = 90135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToUpPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_MoveToUpPoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90135, XrefRangeEnd = 90138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToDownPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_MoveToDownPoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 90153, RefRangeEnd = 90157, XrefRangeStart = 90138, XrefRangeEnd = 90153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToPoint(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_MoveToPoint_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90157, XrefRangeEnd = 90158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Continue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90158, XrefRangeEnd = 90170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90182, RefRangeEnd = 90183, XrefRangeStart = 90170, XrefRangeEnd = 90182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 CalculatePlatformMovement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_CalculatePlatformMovement_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90183, XrefRangeEnd = 90185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Ease(float x)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &x
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Ease_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90218, RefRangeEnd = 90219, XrefRangeStart = 90185, XrefRangeEnd = 90218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MovePassengers(Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &velocity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_MovePassengers_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90219, XrefRangeEnd = 90257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90257, XrefRangeEnd = 90261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90261, XrefRangeEnd = 90267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90267, XrefRangeEnd = 90269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90269, XrefRangeEnd = 90271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90271, XrefRangeEnd = 90287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlatformPhysics()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformPhysics>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlatformPhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask passengerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_passengerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_passengerMask)) = value;
    }
  }

  public unsafe int startingPoint
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_startingPoint));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_startingPoint)) = value;
    }
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe float easeAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_easeAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_easeAmount)) = value;
    }
  }

  public unsafe int targetIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_targetIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_targetIndex)) = value;
    }
  }

  public unsafe Vector3 targetPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_targetPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_targetPoint)) = value;
    }
  }

  public unsafe EventReference movementSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_movementSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_movementSound)) = value;
    }
  }

  public unsafe EventReference stopSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_stopSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_stopSound)) = value;
    }
  }

  public unsafe List<Vector3> targetPointsOffset
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_targetPointsOffset));
      return num == System.IntPtr.Zero ? (List<Vector3>) null : Il2CppObjectPool.Get<List<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_targetPointsOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider platformCollider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_platformCollider));
      return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_platformCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 startingPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_startingPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_startingPosition)) = value;
    }
  }

  public static unsafe float floorOffset
  {
    get
    {
      float floorOffset;
      IL2CPP.il2cpp_field_static_get_value(PlatformPhysics.NativeFieldInfoPtr_floorOffset, (void*) &floorOffset);
      return floorOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformPhysics.NativeFieldInfoPtr_floorOffset, (void*) &value);
    }
  }

  public static unsafe float floorHalfOffset
  {
    get
    {
      float floorHalfOffset;
      IL2CPP.il2cpp_field_static_get_value(PlatformPhysics.NativeFieldInfoPtr_floorHalfOffset, (void*) &floorHalfOffset);
      return floorHalfOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlatformPhysics.NativeFieldInfoPtr_floorHalfOffset, (void*) &value);
    }
  }

  public unsafe bool isMoving
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_isMoving));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_isMoving)) = value;
    }
  }

  public unsafe HashSet<Transform> movedPassengers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_movedPassengers));
      return num == System.IntPtr.Zero ? (HashSet<Transform>) null : Il2CppObjectPool.Get<HashSet<Transform>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_movedPassengers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlappedPassengers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_overlappedPassengers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_overlappedPassengers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 startPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_startPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_startPos)) = value;
    }
  }

  public unsafe Vector3 finalPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_finalPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_finalPos)) = value;
    }
  }

  public unsafe Vector3 extents
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_extents));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_extents)) = value;
    }
  }

  public unsafe float percentBetweenWaypoints
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_percentBetweenWaypoints));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_percentBetweenWaypoints)) = value;
    }
  }

  public unsafe EventInstance movementInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_movementInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_movementInstance)) = value;
    }
  }

  public unsafe EventInstance stopInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_stopInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformPhysics.NativeFieldInfoPtr_stopInstance)) = value;
    }
  }
}
