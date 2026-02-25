// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.PersonPhysics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.MovementPhysics;

public sealed class PersonPhysics(System.IntPtr pointer) : BasePhysics(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_depthThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthPushDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthPushSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_movableGroundTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthCollisionMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowdownMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxClimbAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxDescendAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_safetySpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_pushSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_DepthOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_stepZone;
  private static readonly System.IntPtr NativeFieldInfoPtr_stepThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_vertOriginOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_averageHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_direction;
  private static readonly System.IntPtr NativeFieldInfoPtr_velocityNormalized;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastVelocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastUnsafeVelocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastConnectPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastGroundPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowdownBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapWithEnemiesBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_invincibility;
  private static readonly System.IntPtr NativeFieldInfoPtr_movableGround;
  private static readonly System.IntPtr NativeFieldInfoPtr_connectionTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_groundTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr__LastConnectionPoint_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_invincibilityCoroutine;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VelocityNormalized_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Invincible_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectionTransform_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GroundTransform_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LastConnectionPoint_Private_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastConnectionPoint_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLayer_Public_Void_LayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SubLayer_Public_Void_LayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableInvincibility_Public_Virtual_Final_New_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Void_Vector3_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Boost_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectTo_Public_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GroundTo_Public_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unground_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HorizontalCollisions_Private_Void_byref_Vector3_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VerticalCollisions_Private_Void_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DepthCollision_Private_Void_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClimbSlope_Private_Void_byref_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DescendSlope_Private_Void_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SafetyMeasures_Private_Boolean_Single_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvinsibilityFrames_Private_IEnumerator_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PersonPhysics()
  {
    Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (PersonPhysics));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr);
    PersonPhysics.NativeFieldInfoPtr_depthThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (depthThreshold));
    PersonPhysics.NativeFieldInfoPtr_depthPushDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (depthPushDistance));
    PersonPhysics.NativeFieldInfoPtr_depthPushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (depthPushSpeed));
    PersonPhysics.NativeFieldInfoPtr_movableGroundTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (movableGroundTag));
    PersonPhysics.NativeFieldInfoPtr_depthCollisionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (depthCollisionMask));
    PersonPhysics.NativeFieldInfoPtr_slowdownMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (slowdownMask));
    PersonPhysics.NativeFieldInfoPtr_maxClimbAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (maxClimbAngle));
    PersonPhysics.NativeFieldInfoPtr_maxDescendAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (maxDescendAngle));
    PersonPhysics.NativeFieldInfoPtr_safetySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (safetySpeed));
    PersonPhysics.NativeFieldInfoPtr_pushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (pushSpeed));
    PersonPhysics.NativeFieldInfoPtr_DepthOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (DepthOverride));
    PersonPhysics.NativeFieldInfoPtr_stepZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (stepZone));
    PersonPhysics.NativeFieldInfoPtr_stepThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (stepThreshold));
    PersonPhysics.NativeFieldInfoPtr_vertOriginOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (vertOriginOffset));
    PersonPhysics.NativeFieldInfoPtr_averageHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (averageHeight));
    PersonPhysics.NativeFieldInfoPtr_overlapOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (overlapOffset));
    PersonPhysics.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (direction));
    PersonPhysics.NativeFieldInfoPtr_velocityNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (velocityNormalized));
    PersonPhysics.NativeFieldInfoPtr_lastVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (lastVelocity));
    PersonPhysics.NativeFieldInfoPtr_lastUnsafeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (lastUnsafeVelocity));
    PersonPhysics.NativeFieldInfoPtr_lastConnectPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (lastConnectPos));
    PersonPhysics.NativeFieldInfoPtr_lastGroundPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (lastGroundPos));
    PersonPhysics.NativeFieldInfoPtr_slowdownBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (slowdownBuffer));
    PersonPhysics.NativeFieldInfoPtr_overlapWithEnemiesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (overlapWithEnemiesBuffer));
    PersonPhysics.NativeFieldInfoPtr_invincibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (invincibility));
    PersonPhysics.NativeFieldInfoPtr_movableGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (movableGround));
    PersonPhysics.NativeFieldInfoPtr_connectionTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (connectionTransform));
    PersonPhysics.NativeFieldInfoPtr_groundTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (groundTransform));
    PersonPhysics.NativeFieldInfoPtr__LastConnectionPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, "<LastConnectionPoint>k__BackingField");
    PersonPhysics.NativeFieldInfoPtr_invincibilityCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, nameof (invincibilityCoroutine));
    PersonPhysics.NativeMethodInfoPtr_get_Direction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670944);
    PersonPhysics.NativeMethodInfoPtr_get_VelocityNormalized_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670945);
    PersonPhysics.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670946);
    PersonPhysics.NativeMethodInfoPtr_get_Invincible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670947);
    PersonPhysics.NativeMethodInfoPtr_get_ConnectionTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670948);
    PersonPhysics.NativeMethodInfoPtr_get_GroundTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670949);
    PersonPhysics.NativeMethodInfoPtr_set_LastConnectionPoint_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670950);
    PersonPhysics.NativeMethodInfoPtr_get_LastConnectionPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670951);
    PersonPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670952);
    PersonPhysics.NativeMethodInfoPtr_AddLayer_Public_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670953);
    PersonPhysics.NativeMethodInfoPtr_SubLayer_Public_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670954);
    PersonPhysics.NativeMethodInfoPtr_EnableInvincibility_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670955);
    PersonPhysics.NativeMethodInfoPtr_Move_Public_Void_Vector3_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670956);
    PersonPhysics.NativeMethodInfoPtr_Boost_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670957);
    PersonPhysics.NativeMethodInfoPtr_ConnectTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670958);
    PersonPhysics.NativeMethodInfoPtr_Disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670959);
    PersonPhysics.NativeMethodInfoPtr_GroundTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670960);
    PersonPhysics.NativeMethodInfoPtr_Unground_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670961);
    PersonPhysics.NativeMethodInfoPtr_HorizontalCollisions_Private_Void_byref_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670962);
    PersonPhysics.NativeMethodInfoPtr_VerticalCollisions_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670963);
    PersonPhysics.NativeMethodInfoPtr_DepthCollision_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670964);
    PersonPhysics.NativeMethodInfoPtr_ClimbSlope_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670965);
    PersonPhysics.NativeMethodInfoPtr_DescendSlope_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670966);
    PersonPhysics.NativeMethodInfoPtr_SafetyMeasures_Private_Boolean_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670967);
    PersonPhysics.NativeMethodInfoPtr_InvinsibilityFrames_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670968);
    PersonPhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, 100670969);
  }

  public unsafe float Direction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_Direction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 VelocityNormalized
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_VelocityNormalized_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 Velocity
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Invincible
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_Invincible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Transform ConnectionTransform
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_ConnectionTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public unsafe Transform GroundTransform
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_GroundTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public unsafe Vector3 LastConnectionPoint
  {
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_set_LastConnectionPoint_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_get_LastConnectionPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89628, XrefRangeEnd = 89649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89649, XrefRangeEnd = 89652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddLayer(LayerMask overrideMask)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &overrideMask
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_AddLayer_Public_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89652, XrefRangeEnd = 89655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SubLayer(LayerMask overrideMask)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &overrideMask
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_SubLayer_Public_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89655, XrefRangeEnd = 89661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnableInvincibility(float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &duration
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_EnableInvincibility_Public_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 89734, RefRangeEnd = 89740, XrefRangeStart = 89661, XrefRangeEnd = 89734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Move(
    Vector3 velocity,
    bool ignoreDirection = false,
    bool safetyMeasures = false,
    bool ignoreVertical = false,
    bool ignoreDepth = true,
    bool ignoreSlowdown = false,
    bool restrictAutoStep = false,
    bool pushOut = false,
    bool push = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &velocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreDirection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &safetyMeasures;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreVertical;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSlowdown;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictAutoStep;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &pushOut;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &push;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_Move_Public_Void_Vector3_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Boost(Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &velocity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_Boost_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89745, RefRangeEnd = 89746, XrefRangeStart = 89740, XrefRangeEnd = 89745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ConnectTo(Transform connectionTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionTransform)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_ConnectTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89748, RefRangeEnd = 89749, XrefRangeStart = 89746, XrefRangeEnd = 89748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disconnect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_Disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89749, XrefRangeEnd = 89751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GroundTo(Transform groundTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) groundTransform)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_GroundTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Unground()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_Unground_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89819, RefRangeEnd = 89821, XrefRangeStart = 89751, XrefRangeEnd = 89819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HorizontalCollisions(ref Vector3 velocity, bool restrictAutoStep)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref velocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictAutoStep;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_HorizontalCollisions_Private_Void_byref_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89866, RefRangeEnd = 89867, XrefRangeStart = 89821, XrefRangeEnd = 89866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VerticalCollisions(ref Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref velocity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_VerticalCollisions_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89897, RefRangeEnd = 89898, XrefRangeStart = 89867, XrefRangeEnd = 89897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DepthCollision(ref Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref velocity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_DepthCollision_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89899, RefRangeEnd = 89900, XrefRangeStart = 89898, XrefRangeEnd = 89899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClimbSlope(ref Vector3 velocity, float slopeAngle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref velocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &slopeAngle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_ClimbSlope_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89928, RefRangeEnd = 89929, XrefRangeStart = 89900, XrefRangeEnd = 89928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DescendSlope(ref Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref velocity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_DescendSlope_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89968, RefRangeEnd = 89970, XrefRangeStart = 89929, XrefRangeEnd = 89968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool SafetyMeasures(float direction, ref Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_SafetyMeasures_Private_Boolean_Single_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89970, XrefRangeEnd = 89974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator InvinsibilityFrames(float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &duration
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr_InvinsibilityFrames_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89974, XrefRangeEnd = 89985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PersonPhysics()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersonPhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference depthThreshold
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthThreshold));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthThreshold), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference depthPushDistance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthPushDistance));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthPushDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float depthPushSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthPushSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthPushSpeed)) = value;
    }
  }

  public unsafe string movableGroundTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_movableGroundTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_movableGroundTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LayerMask depthCollisionMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthCollisionMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_depthCollisionMask)) = value;
    }
  }

  public unsafe LayerMask slowdownMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_slowdownMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_slowdownMask)) = value;
    }
  }

  public unsafe float maxClimbAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_maxClimbAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_maxClimbAngle)) = value;
    }
  }

  public unsafe float maxDescendAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_maxDescendAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_maxDescendAngle)) = value;
    }
  }

  public unsafe float safetySpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_safetySpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_safetySpeed)) = value;
    }
  }

  public unsafe float pushSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_pushSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_pushSpeed)) = value;
    }
  }

  public unsafe float DepthOverride
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_DepthOverride));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_DepthOverride)) = value;
    }
  }

  public static unsafe float stepZone
  {
    get
    {
      float stepZone;
      IL2CPP.il2cpp_field_static_get_value(PersonPhysics.NativeFieldInfoPtr_stepZone, (void*) &stepZone);
      return stepZone;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PersonPhysics.NativeFieldInfoPtr_stepZone, (void*) &value);
    }
  }

  public static unsafe float stepThreshold
  {
    get
    {
      float stepThreshold;
      IL2CPP.il2cpp_field_static_get_value(PersonPhysics.NativeFieldInfoPtr_stepThreshold, (void*) &stepThreshold);
      return stepThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PersonPhysics.NativeFieldInfoPtr_stepThreshold, (void*) &value);
    }
  }

  public static unsafe float vertOriginOffset
  {
    get
    {
      float vertOriginOffset;
      IL2CPP.il2cpp_field_static_get_value(PersonPhysics.NativeFieldInfoPtr_vertOriginOffset, (void*) &vertOriginOffset);
      return vertOriginOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PersonPhysics.NativeFieldInfoPtr_vertOriginOffset, (void*) &value);
    }
  }

  public static unsafe float averageHeight
  {
    get
    {
      float averageHeight;
      IL2CPP.il2cpp_field_static_get_value(PersonPhysics.NativeFieldInfoPtr_averageHeight, (void*) &averageHeight);
      return averageHeight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PersonPhysics.NativeFieldInfoPtr_averageHeight, (void*) &value);
    }
  }

  public unsafe Vector3 overlapOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_overlapOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_overlapOffset)) = value;
    }
  }

  public unsafe float direction
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_direction));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_direction)) = value;
    }
  }

  public unsafe Vector2 velocityNormalized
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_velocityNormalized));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_velocityNormalized)) = value;
    }
  }

  public unsafe Vector3 lastVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastVelocity)) = value;
    }
  }

  public unsafe Vector3 lastUnsafeVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastUnsafeVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastUnsafeVelocity)) = value;
    }
  }

  public unsafe Vector3 lastConnectPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastConnectPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastConnectPos)) = value;
    }
  }

  public unsafe Vector3 lastGroundPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastGroundPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_lastGroundPos)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Collider> slowdownBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_slowdownBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_slowdownBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapWithEnemiesBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_overlapWithEnemiesBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_overlapWithEnemiesBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool invincibility
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_invincibility));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_invincibility)) = value;
    }
  }

  public unsafe bool movableGround
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_movableGround));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_movableGround)) = value;
    }
  }

  public unsafe Transform connectionTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_connectionTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_connectionTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform groundTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_groundTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_groundTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 _LastConnectionPoint_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr__LastConnectionPoint_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr__LastConnectionPoint_k__BackingField)) = value;
    }
  }

  public unsafe Coroutine invincibilityCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_invincibilityCoroutine));
      return num == System.IntPtr.Zero ? (Coroutine) null : Il2CppObjectPool.Get<Coroutine>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics.NativeFieldInfoPtr_invincibilityCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.MovementPhysics.PersonPhysics+<InvinsibilityFrames>d__61")]
  public sealed class _InvinsibilityFrames_d__61(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_duration;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _InvinsibilityFrames_d__61()
    {
      Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersonPhysics>.NativeClassPtr, "<InvinsibilityFrames>d__61");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr);
      PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, "<>1__state");
      PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, "<>2__current");
      PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, "<>4__this");
      PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, nameof (duration));
      PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, "<timer>5__2");
      PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, 100670970);
      PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, 100670971);
      PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, 100670972);
      PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, 100670973);
      PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, 100670974);
      PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr, 100670975);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _InvinsibilityFrames_d__61(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersonPhysics._InvinsibilityFrames_d__61>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89621, XrefRangeEnd = 89623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89623, XrefRangeEnd = 89628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersonPhysics._InvinsibilityFrames_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PersonPhysics __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr_duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr_duration)) = value;
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersonPhysics._InvinsibilityFrames_d__61.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }
}
