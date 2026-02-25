// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterGrabController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Environment;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterGrabController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_col;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitLayersMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_grabMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_ledgeClimbingConfig;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapConfig;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomOverlapConfig;
  private static readonly System.IntPtr NativeFieldInfoPtr_LastPlatformingHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_CachedPlatformingHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomOverlapHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_ledgeHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_climbFromBelowHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontalHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontalMidHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_dropdownHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_dropdownClimbHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_wallStepHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthStepHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapContext;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomOverlapContext;
  private static readonly System.IntPtr NativeFieldInfoPtr_climbingContext;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontalContext;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthContext;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveGrabTransform_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveClimbTransform_Public_ClimbingObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleCasting_Public_Boolean_CastType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignHitDataFromRaycast_Public_Void_byref_PlatformingHitData_RaycastHit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignHitDataFromCollider_Public_Void_byref_PlatformingHitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleOverlapCasting_Public_Boolean_Vector3_Vector3_LayerMask_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleBottomOverlap_Public_Boolean_Vector3_Vector3_LayerMask_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleLedgeClimbCasting_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleFrontalCasting_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleFrontalMidCasting_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleDropdownCasting_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleDepthCasting_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnectionQueue_Private_Boolean_Queue_1_PlatformingConnectionHandler_byref_PlatformingHitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookLedgeCast_Public_Boolean_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_RaycastHit_0;

  static CharacterGrabController()
  {
    Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterGrabController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr);
    CharacterGrabController.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (personPhysics));
    CharacterGrabController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (rotationController));
    CharacterGrabController.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (col));
    CharacterGrabController.NativeFieldInfoPtr_defaultMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (defaultMask));
    CharacterGrabController.NativeFieldInfoPtr_hitLayersMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (hitLayersMask));
    CharacterGrabController.NativeFieldInfoPtr_overlapMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (overlapMask));
    CharacterGrabController.NativeFieldInfoPtr_grabMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (grabMask));
    CharacterGrabController.NativeFieldInfoPtr_overlapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (overlapBuffer));
    CharacterGrabController.NativeFieldInfoPtr_ledgeClimbingConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (ledgeClimbingConfig));
    CharacterGrabController.NativeFieldInfoPtr_overlapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (overlapConfig));
    CharacterGrabController.NativeFieldInfoPtr_bottomOverlapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (bottomOverlapConfig));
    CharacterGrabController.NativeFieldInfoPtr_LastPlatformingHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (LastPlatformingHit));
    CharacterGrabController.NativeFieldInfoPtr_CachedPlatformingHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (CachedPlatformingHit));
    CharacterGrabController.NativeFieldInfoPtr_overlapHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (overlapHandlers));
    CharacterGrabController.NativeFieldInfoPtr_bottomOverlapHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (bottomOverlapHandlers));
    CharacterGrabController.NativeFieldInfoPtr_ledgeHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (ledgeHandlers));
    CharacterGrabController.NativeFieldInfoPtr_climbFromBelowHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (climbFromBelowHandlers));
    CharacterGrabController.NativeFieldInfoPtr_frontalHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (frontalHandlers));
    CharacterGrabController.NativeFieldInfoPtr_frontalMidHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (frontalMidHandlers));
    CharacterGrabController.NativeFieldInfoPtr_dropdownHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (dropdownHandlers));
    CharacterGrabController.NativeFieldInfoPtr_dropdownClimbHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (dropdownClimbHandlers));
    CharacterGrabController.NativeFieldInfoPtr_wallStepHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (wallStepHandlers));
    CharacterGrabController.NativeFieldInfoPtr_depthStepHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (depthStepHandlers));
    CharacterGrabController.NativeFieldInfoPtr_overlapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (overlapContext));
    CharacterGrabController.NativeFieldInfoPtr_bottomOverlapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (bottomOverlapContext));
    CharacterGrabController.NativeFieldInfoPtr_climbingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (climbingContext));
    CharacterGrabController.NativeFieldInfoPtr_frontalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (frontalContext));
    CharacterGrabController.NativeFieldInfoPtr_depthContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (depthContext));
    CharacterGrabController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100674997);
    CharacterGrabController.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100674998);
    CharacterGrabController.NativeMethodInfoPtr_SaveGrabTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100674999);
    CharacterGrabController.NativeMethodInfoPtr_SaveClimbTransform_Public_ClimbingObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675000);
    CharacterGrabController.NativeMethodInfoPtr_HandleCasting_Public_Boolean_CastType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675001);
    CharacterGrabController.NativeMethodInfoPtr_AssignHitDataFromRaycast_Public_Void_byref_PlatformingHitData_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675002);
    CharacterGrabController.NativeMethodInfoPtr_AssignHitDataFromCollider_Public_Void_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675003);
    CharacterGrabController.NativeMethodInfoPtr_HandleOverlapCasting_Public_Boolean_Vector3_Vector3_LayerMask_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675004);
    CharacterGrabController.NativeMethodInfoPtr_HandleBottomOverlap_Public_Boolean_Vector3_Vector3_LayerMask_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675005);
    CharacterGrabController.NativeMethodInfoPtr_HandleLedgeClimbCasting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675006);
    CharacterGrabController.NativeMethodInfoPtr_HandleFrontalCasting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675007);
    CharacterGrabController.NativeMethodInfoPtr_HandleFrontalMidCasting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675008);
    CharacterGrabController.NativeMethodInfoPtr_HandleDropdownCasting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675009);
    CharacterGrabController.NativeMethodInfoPtr_HandleDepthCasting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675010);
    CharacterGrabController.NativeMethodInfoPtr_HandleConnectionQueue_Private_Boolean_Queue_1_PlatformingConnectionHandler_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675011);
    CharacterGrabController.NativeMethodInfoPtr_LookLedgeCast_Public_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675012);
    CharacterGrabController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675013);
    CharacterGrabController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675014);
    CharacterGrabController.NativeMethodInfoPtr_Method_Private_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, 100675015);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114973, XrefRangeEnd = 115216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 115217, RefRangeEnd = 115221, XrefRangeStart = 115216, XrefRangeEnd = 115217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 115226, RefRangeEnd = 115237, XrefRangeStart = 115221, XrefRangeEnd = 115226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SaveGrabTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_SaveGrabTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115237, XrefRangeEnd = 115242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClimbingObject SaveClimbTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_SaveClimbTransform_Public_ClimbingObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ClimbingObject) null : Il2CppObjectPool.Get<ClimbingObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115268, RefRangeEnd = 115269, XrefRangeStart = 115242, XrefRangeEnd = 115268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleCasting(CharacterGrabController.CastType castType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &castType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleCasting_Public_Boolean_CastType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115280, RefRangeEnd = 115282, XrefRangeStart = 115269, XrefRangeEnd = 115280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignHitDataFromRaycast(
    ref CharacterGrabController.PlatformingHitData data,
    RaycastHit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hit;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_AssignHitDataFromRaycast_Public_Void_byref_PlatformingHitData_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115287, RefRangeEnd = 115288, XrefRangeStart = 115282, XrefRangeEnd = 115287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignHitDataFromCollider(
    ref CharacterGrabController.PlatformingHitData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_AssignHitDataFromCollider_Public_Void_byref_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115408, RefRangeEnd = 115410, XrefRangeStart = 115288, XrefRangeEnd = 115408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleOverlapCasting(
    Vector3 center,
    Vector3 ovelapSize,
    LayerMask layerMask,
    bool cacheOverlap,
    string excludeTag = null,
    bool debug = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ovelapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheOverlap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(excludeTag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &debug;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleOverlapCasting_Public_Boolean_Vector3_Vector3_LayerMask_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115434, RefRangeEnd = 115435, XrefRangeStart = 115410, XrefRangeEnd = 115434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleBottomOverlap(
    Vector3 center,
    Vector3 ovelapSize,
    LayerMask layerMask,
    bool cacheOverlap,
    string excludeTag = null,
    bool debug = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ovelapSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &cacheOverlap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(excludeTag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &debug;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleBottomOverlap_Public_Boolean_Vector3_Vector3_LayerMask_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115470, RefRangeEnd = 115471, XrefRangeStart = 115435, XrefRangeEnd = 115470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleLedgeClimbCasting()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleLedgeClimbCasting_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115491, RefRangeEnd = 115492, XrefRangeStart = 115471, XrefRangeEnd = 115491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleFrontalCasting()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleFrontalCasting_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115512, RefRangeEnd = 115513, XrefRangeStart = 115492, XrefRangeEnd = 115512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleFrontalMidCasting()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleFrontalMidCasting_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 115566, RefRangeEnd = 115568, XrefRangeStart = 115513, XrefRangeEnd = 115566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleDropdownCasting()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleDropdownCasting_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115578, RefRangeEnd = 115579, XrefRangeStart = 115568, XrefRangeEnd = 115578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleDepthCasting()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleDepthCasting_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 115596, RefRangeEnd = 115600, XrefRangeStart = 115579, XrefRangeEnd = 115596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HandleConnectionQueue(
    Queue<CharacterGrabController.PlatformingConnectionHandler> queue,
    ref CharacterGrabController.PlatformingHitData hitData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) queue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitData);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_HandleConnectionQueue_Private_Boolean_Queue_1_PlatformingConnectionHandler_byref_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115614, RefRangeEnd = 115615, XrefRangeStart = 115600, XrefRangeEnd = 115614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool LookLedgeCast(float distance, bool debug)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &distance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &debug;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_LookLedgeCast_Public_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115615, XrefRangeEnd = 115619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterGrabController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115640, RefRangeEnd = 115641, XrefRangeStart = 115619, XrefRangeEnd = 115640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Method_Private_Boolean_RaycastHit_0(RaycastHit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &hit
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.NativeMethodInfoPtr_Method_Private_Boolean_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_personPhysics));
      return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoxCollider col
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_col));
      return num == System.IntPtr.Zero ? (BoxCollider) null : Il2CppObjectPool.Get<BoxCollider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int defaultMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_defaultMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_defaultMask)) = value;
    }
  }

  public unsafe int hitLayersMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_hitLayersMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_hitLayersMask)) = value;
    }
  }

  public unsafe int overlapMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapMask)) = value;
    }
  }

  public unsafe int grabMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_grabMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_grabMask)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.LedgeClimbingConfig ledgeClimbingConfig
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_ledgeClimbingConfig));
      return num == System.IntPtr.Zero ? (CharacterGrabController.LedgeClimbingConfig) null : Il2CppObjectPool.Get<CharacterGrabController.LedgeClimbingConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_ledgeClimbingConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.OverlapConfig overlapConfig
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapConfig));
      return num == System.IntPtr.Zero ? (CharacterGrabController.OverlapConfig) null : Il2CppObjectPool.Get<CharacterGrabController.OverlapConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.OverlapConfig bottomOverlapConfig
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_bottomOverlapConfig));
      return num == System.IntPtr.Zero ? (CharacterGrabController.OverlapConfig) null : Il2CppObjectPool.Get<CharacterGrabController.OverlapConfig>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_bottomOverlapConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CharacterGrabController.PlatformingHitData LastPlatformingHit
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_LastPlatformingHit);
      return new CharacterGrabController.PlatformingHitData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_LastPlatformingHit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CharacterGrabController.PlatformingHitData CachedPlatformingHit
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_CachedPlatformingHit);
      return new CharacterGrabController.PlatformingHitData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_CachedPlatformingHit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> overlapHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> bottomOverlapHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_bottomOverlapHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_bottomOverlapHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> ledgeHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_ledgeHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_ledgeHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> climbFromBelowHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_climbFromBelowHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_climbFromBelowHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> frontalHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_frontalHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_frontalHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> frontalMidHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_frontalMidHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_frontalMidHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> dropdownHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_dropdownHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_dropdownHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> dropdownClimbHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_dropdownClimbHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_dropdownClimbHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> wallStepHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_wallStepHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_wallStepHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<CharacterGrabController.PlatformingConnectionHandler> depthStepHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_depthStepHandlers));
      return num == System.IntPtr.Zero ? (Queue<CharacterGrabController.PlatformingConnectionHandler>) null : Il2CppObjectPool.Get<Queue<CharacterGrabController.PlatformingConnectionHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_depthStepHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.OvelapContext overlapContext
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapContext));
      return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_overlapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.BottomOverlapContext bottomOverlapContext
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_bottomOverlapContext));
      return num == System.IntPtr.Zero ? (CharacterGrabController.BottomOverlapContext) null : Il2CppObjectPool.Get<CharacterGrabController.BottomOverlapContext>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_bottomOverlapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.ClimbLedgeContext climbingContext
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_climbingContext));
      return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_climbingContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.FrontalConnectionContext frontalContext
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_frontalContext));
      return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_frontalContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController.DepthConnectionContext depthContext
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_depthContext));
      return num == System.IntPtr.Zero ? (CharacterGrabController.DepthConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.DepthConnectionContext>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.NativeFieldInfoPtr_depthContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum PlatformingType
  {
    Undefined,
    Ledge,
    LedgeUngrounded,
    MidLedge,
    MidLedgeUngrounded,
    WallStep,
    WallStepUngrounded,
    Step,
    Vault,
    WallHit,
    WallSlide,
    Ladder,
    Stairs,
    BulgeOverlap,
    PipeOverlap,
    PoleOverlapAbove,
    PoleOverlapBelow,
    PoleOverlapSideBottom,
    PoleOverlapSideTop,
    WallStepWallRun,
    LedgeWallRun,
    VaultWallRun,
    VaultOver,
    LadderBelowJumpIn,
    FrontalLadder,
    PipeVertical,
    DepthStep,
    Crouch,
    DepthStepHigh,
    DepthStepHighSide,
    DepthStepSide,
    Slope,
    SlopeClimbing,
    Glider,
    Trip,
    TripNonLethal,
    Door,
    Pickaxe,
  }

  public enum CastType
  {
    Undefined = 0,
    LedgeClimbing = 1,
    BoundariesOverlap = 2,
    FrontalConnect = 4,
    JumpCast = 7,
    DepthCast = 16, // 0x00000010
    DropdownCast = 32, // 0x00000020
  }

  public sealed class PlatformingHitData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitCollider;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitPoint;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_Collider_Vector3_0;

    static PlatformingHitData()
    {
      Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (PlatformingHitData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr);
      CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, nameof (Type));
      CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, nameof (HitTransform));
      CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, nameof (HitCollider));
      CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, nameof (HitPoint));
      CharacterGrabController.PlatformingHitData.NativeMethodInfoPtr__ctor_Public_Void_Transform_Collider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr, 100675016);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114552, RefRangeEnd = 114553, XrefRangeStart = 114552, XrefRangeEnd = 114552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlatformingHitData(
      Transform hitTransform,
      Collider hitCollider,
      Vector3 hitPoint)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hitTransform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hitCollider);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hitPoint;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PlatformingHitData.NativeMethodInfoPtr__ctor_Public_Void_Transform_Collider_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public PlatformingHitData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public PlatformingHitData()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PlatformingHitData>.NativeClassPtr))
    {
    }

    public unsafe CharacterGrabController.PlatformingType Type
    {
      get
      {
        return *(CharacterGrabController.PlatformingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(CharacterGrabController.PlatformingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe Transform HitTransform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitTransform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Collider HitCollider
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitCollider));
        return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 HitPoint
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitPoint));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PlatformingHitData.NativeFieldInfoPtr_HitPoint)) = value;
      }
    }
  }

  [Serializable]
  public class LedgeClimbingConfig(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_raycastLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_sphereCastRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_stepHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_midHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_highHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_wallRunHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_climbingCastDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_standingCastOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_dropdownBackLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthCastLenth;
    private static readonly System.IntPtr NativeFieldInfoPtr_slopeCastLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_dropdownBlockSphereRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_vaultOverlapMaxWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_vaultOverlapMaxHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_debug;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RaycastLength_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StepHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MidHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HighHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WallRunHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClimbingCastDistance_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StandingCastOffset_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DropdownBackLength_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthCastLenth_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SlopeCastLength_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DropdownBlockSphereRadius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SphereCastRadius_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VaultOverlapMaxWidth_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VaultOverlapMaxHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static LedgeClimbingConfig()
    {
      Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (LedgeClimbingConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr);
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_raycastLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (raycastLength));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_sphereCastRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (sphereCastRadius));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_stepHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (stepHeight));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_midHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (midHeight));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_highHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (highHeight));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_wallRunHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (wallRunHeight));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_climbingCastDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (climbingCastDistance));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_standingCastOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (standingCastOffset));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_dropdownBackLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (dropdownBackLength));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_depthCastLenth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (depthCastLenth));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_slopeCastLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (slopeCastLength));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_dropdownBlockSphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (dropdownBlockSphereRadius));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_vaultOverlapMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (vaultOverlapMaxWidth));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_vaultOverlapMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (vaultOverlapMaxHeight));
      CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, nameof (debug));
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_RaycastLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675017);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_StepHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675018);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_MidHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675019);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_HighHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675020);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_WallRunHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675021);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_ClimbingCastDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675022);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_StandingCastOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675023);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_DropdownBackLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675024);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_DepthCastLenth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675025);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_SlopeCastLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675026);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_DropdownBlockSphereRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675027);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_SphereCastRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675028);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_VaultOverlapMaxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675029);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_VaultOverlapMaxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675030);
      CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr, 100675031);
    }

    public unsafe float RaycastLength
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_RaycastLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float StepHeight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_StepHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float MidHeight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_MidHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float HighHeight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_HighHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float WallRunHeight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_WallRunHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float ClimbingCastDistance
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_ClimbingCastDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float StandingCastOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_StandingCastOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float DropdownBackLength
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_DropdownBackLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float DepthCastLenth
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_DepthCastLenth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float SlopeCastLength
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_SlopeCastLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float DropdownBlockSphereRadius
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_DropdownBlockSphereRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float SphereCastRadius
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_SphereCastRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float VaultOverlapMaxWidth
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 72922, RefRangeEnd = 72923, XrefRangeStart = 72922, XrefRangeEnd = 72923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_VaultOverlapMaxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe float VaultOverlapMaxHeight
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 72923, RefRangeEnd = 72924, XrefRangeStart = 72923, XrefRangeEnd = 72924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr_get_VaultOverlapMaxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114553, XrefRangeEnd = 114554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LedgeClimbingConfig()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.LedgeClimbingConfig>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeClimbingConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float raycastLength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_raycastLength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_raycastLength)) = value;
      }
    }

    public unsafe float sphereCastRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_sphereCastRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_sphereCastRadius)) = value;
      }
    }

    public unsafe float stepHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_stepHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_stepHeight)) = value;
      }
    }

    public unsafe float midHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_midHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_midHeight)) = value;
      }
    }

    public unsafe float highHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_highHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_highHeight)) = value;
      }
    }

    public unsafe float wallRunHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_wallRunHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_wallRunHeight)) = value;
      }
    }

    public unsafe float climbingCastDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_climbingCastDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_climbingCastDistance)) = value;
      }
    }

    public unsafe float standingCastOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_standingCastOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_standingCastOffset)) = value;
      }
    }

    public unsafe float dropdownBackLength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_dropdownBackLength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_dropdownBackLength)) = value;
      }
    }

    public unsafe float depthCastLenth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_depthCastLenth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_depthCastLenth)) = value;
      }
    }

    public unsafe float slopeCastLength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_slopeCastLength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_slopeCastLength)) = value;
      }
    }

    public unsafe float dropdownBlockSphereRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_dropdownBlockSphereRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_dropdownBlockSphereRadius)) = value;
      }
    }

    public unsafe float vaultOverlapMaxWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_vaultOverlapMaxWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_vaultOverlapMaxWidth)) = value;
      }
    }

    public unsafe float vaultOverlapMaxHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_vaultOverlapMaxHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_vaultOverlapMaxHeight)) = value;
      }
    }

    public unsafe bool debug
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_debug));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeClimbingConfig.NativeFieldInfoPtr_debug)) = value;
      }
    }
  }

  [Serializable]
  public class OverlapConfig(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_overlapTopOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_overlapSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_overlapObstructionCheckOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_debugOverlap;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverlapTopOffset_Public_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverlapSize_Public_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverlapObstructionCheckOffset_Public_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugOverlap_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static OverlapConfig()
    {
      Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (OverlapConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr);
      CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapTopOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, nameof (overlapTopOffset));
      CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, nameof (overlapSize));
      CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapObstructionCheckOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, nameof (overlapObstructionCheckOffset));
      CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_debugOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, nameof (debugOverlap));
      CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_OverlapTopOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, 100675032);
      CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_OverlapSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, 100675033);
      CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_OverlapObstructionCheckOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, 100675034);
      CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_DebugOverlap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, 100675035);
      CharacterGrabController.OverlapConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr, 100675036);
    }

    public unsafe Vector3 OverlapTopOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_OverlapTopOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Vector3 OverlapSize
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_OverlapSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Vector3 OverlapObstructionCheckOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_OverlapObstructionCheckOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool DebugOverlap
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 79543, RefRangeEnd = 79544, XrefRangeStart = 79543, XrefRangeEnd = 79544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OverlapConfig.NativeMethodInfoPtr_get_DebugOverlap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114554, XrefRangeEnd = 114555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OverlapConfig()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.OverlapConfig>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OverlapConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 overlapTopOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapTopOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapTopOffset)) = value;
      }
    }

    public unsafe Vector3 overlapSize
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapSize));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapSize)) = value;
      }
    }

    public unsafe Vector3 overlapObstructionCheckOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapObstructionCheckOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_overlapObstructionCheckOffset)) = value;
      }
    }

    public unsafe bool debugOverlap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_debugOverlap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OverlapConfig.NativeFieldInfoPtr_debugOverlap)) = value;
      }
    }
  }

  public class PlatformingConnectionHandler(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Handle_Public_Void_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Abstract_Virtual_New_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Abstract_Virtual_New_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    static PlatformingConnectionHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (PlatformingConnectionHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr);
      CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr_Handle_Public_Void_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr, 100675037);
      CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr_HasConnected_Protected_Abstract_Virtual_New_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr, 100675038);
      CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr_HandleConnection_Protected_Abstract_Virtual_New_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr, 100675039);
      CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr, 100675040);
    }

    [CallerCount(0)]
    public unsafe void Handle(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr_Handle_Public_Void_byref_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr_HasConnected_Protected_Abstract_Virtual_New_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr_HandleConnection_Protected_Abstract_Virtual_New_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlatformingConnectionHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PlatformingConnectionHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PlatformingConnectionHandler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public class ConnectionContext(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinorOffset;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTag_Public_Boolean_PlatformingHitData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ConnectionContext()
    {
      Il2CppClassPointerStore<CharacterGrabController.ConnectionContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (ConnectionContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.ConnectionContext>.NativeClassPtr);
      CharacterGrabController.ConnectionContext.NativeFieldInfoPtr_MinorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ConnectionContext>.NativeClassPtr, nameof (MinorOffset));
      CharacterGrabController.ConnectionContext.NativeMethodInfoPtr_CompareTag_Public_Boolean_PlatformingHitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ConnectionContext>.NativeClassPtr, 100675041);
      CharacterGrabController.ConnectionContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ConnectionContext>.NativeClassPtr, 100675042);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114555, XrefRangeEnd = 114556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CompareTag(
      CharacterGrabController.PlatformingHitData platformingHitData,
      string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ConnectionContext.NativeMethodInfoPtr_CompareTag_Public_Boolean_PlatformingHitData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectionContext()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.ConnectionContext>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ConnectionContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe float MinorOffset
    {
      get
      {
        float minorOffset;
        IL2CPP.il2cpp_field_static_get_value(CharacterGrabController.ConnectionContext.NativeFieldInfoPtr_MinorOffset, (void*) &minorOffset);
        return minorOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterGrabController.ConnectionContext.NativeFieldInfoPtr_MinorOffset, (void*) &value);
      }
    }
  }

  public class OvelapContext(System.IntPtr pointer) : CharacterGrabController.ConnectionContext(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_overlapConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_col;
    private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OverlapConfig_Collider_PersonPhysics_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InOverlapCenter_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverlapFromAbove_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MovingHorizontally_Public_Boolean_0;

    static OvelapContext()
    {
      Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (OvelapContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr);
      CharacterGrabController.OvelapContext.NativeFieldInfoPtr_overlapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, nameof (overlapConfig));
      CharacterGrabController.OvelapContext.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, nameof (col));
      CharacterGrabController.OvelapContext.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, nameof (personPhysics));
      CharacterGrabController.OvelapContext.NativeMethodInfoPtr__ctor_Public_Void_OverlapConfig_Collider_PersonPhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, 100675043);
      CharacterGrabController.OvelapContext.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, 100675044);
      CharacterGrabController.OvelapContext.NativeMethodInfoPtr_InOverlapCenter_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, 100675045);
      CharacterGrabController.OvelapContext.NativeMethodInfoPtr_OverlapFromAbove_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, 100675046);
      CharacterGrabController.OvelapContext.NativeMethodInfoPtr_MovingHorizontally_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr, 100675047);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 114557, RefRangeEnd = 114562, XrefRangeStart = 114556, XrefRangeEnd = 114557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OvelapContext(
      CharacterGrabController.OverlapConfig overlapConfig,
      Collider col,
      PersonPhysics personPhysics)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.OvelapContext>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overlapConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) col);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) personPhysics);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OvelapContext.NativeMethodInfoPtr__ctor_Public_Void_OverlapConfig_Collider_PersonPhysics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 Center
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 114566, RefRangeEnd = 114571, XrefRangeStart = 114562, XrefRangeEnd = 114566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OvelapContext.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114571, XrefRangeEnd = 114576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool InOverlapCenter(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OvelapContext.NativeMethodInfoPtr_InOverlapCenter_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114576, XrefRangeEnd = 114577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool OverlapFromAbove(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OvelapContext.NativeMethodInfoPtr_OverlapFromAbove_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114577, XrefRangeEnd = 114580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MovingHorizontally()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.OvelapContext.NativeMethodInfoPtr_MovingHorizontally_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OverlapConfig overlapConfig
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OvelapContext.NativeFieldInfoPtr_overlapConfig));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OverlapConfig) null : Il2CppObjectPool.Get<CharacterGrabController.OverlapConfig>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OvelapContext.NativeFieldInfoPtr_overlapConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Collider col
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OvelapContext.NativeFieldInfoPtr_col));
        return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OvelapContext.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PersonPhysics personPhysics
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OvelapContext.NativeFieldInfoPtr_personPhysics));
        return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.OvelapContext.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class ClimbLedgeContext(System.IntPtr pointer) : CharacterGrabController.ConnectionContext(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
    private static readonly System.IntPtr NativeFieldInfoPtr_ledgeClimbingConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_col;
    private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_blockingMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_CharacterRotationController_LedgeClimbingConfig_Collider_PersonPhysics_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Blocked_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanStand_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSpaceAbove_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLean_Public_Boolean_PlatformingHitData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Grounded_Public_Boolean_PlatformingHitData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanWallRun_Public_Boolean_PlatformingHitData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LowerThanStep_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LowerThanMid_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LowerThanHigh_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LowerThanWallRun_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClimbFromBelowThreshold_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerticalDistance_Public_Single_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MovingHorizontally_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidWallRun_Public_Boolean_PlatformingHitData_0;

    static ClimbLedgeContext()
    {
      Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (ClimbLedgeContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr);
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (transform));
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (rotationController));
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_ledgeClimbingConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (ledgeClimbingConfig));
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (col));
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (layerMask));
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_blockingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (blockingMask));
      CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, nameof (personPhysics));
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_CharacterRotationController_LedgeClimbingConfig_Collider_PersonPhysics_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675048);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_Blocked_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675049);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_CanStand_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675050);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_HasSpaceAbove_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675051);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_CanLean_Public_Boolean_PlatformingHitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675052);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_Grounded_Public_Boolean_PlatformingHitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675053);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_CanWallRun_Public_Boolean_PlatformingHitData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675054);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanStep_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675055);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanMid_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675056);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanHigh_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675057);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanWallRun_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675058);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_ClimbFromBelowThreshold_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675059);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_VerticalDistance_Public_Single_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675060);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_MovingHorizontally_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675061);
      CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_ValidWallRun_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr, 100675062);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114580, XrefRangeEnd = 114581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClimbLedgeContext(
      Transform transform,
      CharacterRotationController rotationController,
      CharacterGrabController.LedgeClimbingConfig ledgeClimbingConfig,
      Collider col,
      PersonPhysics personPhysics,
      int layerMask,
      int blockingMask)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.ClimbLedgeContext>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rotationController);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ledgeClimbingConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) col);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) personPhysics);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &blockingMask;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_CharacterRotationController_LedgeClimbingConfig_Collider_PersonPhysics_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 114588, RefRangeEnd = 114592, XrefRangeStart = 114581, XrefRangeEnd = 114588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Blocked(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_Blocked_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 114602, RefRangeEnd = 114604, XrefRangeStart = 114592, XrefRangeEnd = 114602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanStand(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_CanStand_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 114625, RefRangeEnd = 114627, XrefRangeStart = 114604, XrefRangeEnd = 114625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasSpaceAbove(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_HasSpaceAbove_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 114636, RefRangeEnd = 114638, XrefRangeStart = 114627, XrefRangeEnd = 114636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanLean(
      CharacterGrabController.PlatformingHitData platformingHitData,
      bool dropdown = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dropdown;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_CanLean_Public_Boolean_PlatformingHitData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 114647, RefRangeEnd = 114649, XrefRangeStart = 114638, XrefRangeEnd = 114647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Grounded(
      CharacterGrabController.PlatformingHitData platformingHitData,
      bool dropdown = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dropdown;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_Grounded_Public_Boolean_PlatformingHitData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114658, RefRangeEnd = 114659, XrefRangeStart = 114649, XrefRangeEnd = 114658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanWallRun(
      CharacterGrabController.PlatformingHitData platformingHitData,
      bool dropdown = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dropdown;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_CanWallRun_Public_Boolean_PlatformingHitData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114659, XrefRangeEnd = 114660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LowerThanStep(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanStep_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114660, XrefRangeEnd = 114661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LowerThanMid(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanMid_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114661, XrefRangeEnd = 114662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LowerThanHigh(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanHigh_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114662, XrefRangeEnd = 114663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LowerThanWallRun(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_LowerThanWallRun_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114663, XrefRangeEnd = 114665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ClimbFromBelowThreshold(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_ClimbFromBelowThreshold_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114665, XrefRangeEnd = 114666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float VerticalDistance(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_VerticalDistance_Public_Single_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114669, RefRangeEnd = 114670, XrefRangeStart = 114666, XrefRangeEnd = 114669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MovingHorizontally()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_MovingHorizontally_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool ValidWallRun(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.ClimbLedgeContext.NativeMethodInfoPtr_ValidWallRun_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Transform transform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_transform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterRotationController rotationController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_rotationController));
        return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterGrabController.LedgeClimbingConfig ledgeClimbingConfig
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_ledgeClimbingConfig));
        return num == System.IntPtr.Zero ? (CharacterGrabController.LedgeClimbingConfig) null : Il2CppObjectPool.Get<CharacterGrabController.LedgeClimbingConfig>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_ledgeClimbingConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Collider col
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_col));
        return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int layerMask
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_layerMask));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_layerMask)) = value;
      }
    }

    public unsafe int blockingMask
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_blockingMask));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_blockingMask)) = value;
      }
    }

    public unsafe PersonPhysics personPhysics
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_personPhysics));
        return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.ClimbLedgeContext.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class FrontalConnectionContext(System.IntPtr pointer) : 
    CharacterGrabController.ConnectionContext(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
    private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
    private static readonly System.IntPtr NativeFieldInfoPtr_climbingConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastGroundHit;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_PersonPhysics_CharacterRotationController_LedgeClimbingConfig_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GroundTag_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSlopeClimbing_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnection_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FrontalConnection_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MiddleConnection_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StepConnection_Public_Boolean_PlatformingHitData_byref_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanStand_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanVaultOver_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBlocked_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWalled_Public_Boolean_PlatformingHitData_0;

    static FrontalConnectionContext()
    {
      Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (FrontalConnectionContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr);
      CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, nameof (transform));
      CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, nameof (personPhysics));
      CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, nameof (rotationController));
      CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_climbingConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, nameof (climbingConfig));
      CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, nameof (layerMask));
      CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_lastGroundHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, nameof (lastGroundHit));
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_PersonPhysics_CharacterRotationController_LedgeClimbingConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675063);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675064);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_GroundTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675065);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsSlopeClimbing_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675066);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_HasConnection_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675067);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_FrontalConnection_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675068);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_MiddleConnection_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675069);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_StepConnection_Public_Boolean_PlatformingHitData_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675070);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_CanStand_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675071);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_CanVaultOver_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675072 /*0x06002E00*/);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsBlocked_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675073);
      CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsWalled_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr, 100675074);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114670, XrefRangeEnd = 114671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FrontalConnectionContext(
      Transform transform,
      PersonPhysics personPhysics,
      CharacterRotationController rotationController,
      CharacterGrabController.LedgeClimbingConfig climbingConfig,
      int layerMask)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.FrontalConnectionContext>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) personPhysics);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rotationController);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) climbingConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_PersonPhysics_CharacterRotationController_LedgeClimbingConfig_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114671, XrefRangeEnd = 114676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsGrounded()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114699, RefRangeEnd = 114700, XrefRangeStart = 114676, XrefRangeEnd = 114699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GroundTag(string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(tag)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_GroundTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114700, XrefRangeEnd = 114704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSlopeClimbing()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsSlopeClimbing_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114704, XrefRangeEnd = 114708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasConnection(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_HasConnection_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 114717, RefRangeEnd = 114719, XrefRangeStart = 114708, XrefRangeEnd = 114717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FrontalConnection()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_FrontalConnection_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114728, RefRangeEnd = 114729, XrefRangeStart = 114719, XrefRangeEnd = 114728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MiddleConnection()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_MiddleConnection_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114740, RefRangeEnd = 114741, XrefRangeStart = 114729, XrefRangeEnd = 114740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool StepConnection(
      CharacterGrabController.PlatformingHitData platformingHitData,
      ref Vector3 hitPoint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitPoint;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_StepConnection_Public_Boolean_PlatformingHitData_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114751, RefRangeEnd = 114752, XrefRangeStart = 114741, XrefRangeEnd = 114751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanStand(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_CanStand_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114752, XrefRangeEnd = 114760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanVaultOver(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_CanVaultOver_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114760, XrefRangeEnd = 114767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsBlocked(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsBlocked_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114776, RefRangeEnd = 114777, XrefRangeStart = 114767, XrefRangeEnd = 114776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWalled(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalConnectionContext.NativeMethodInfoPtr_IsWalled_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Transform transform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_transform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PersonPhysics personPhysics
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_personPhysics));
        return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterRotationController rotationController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_rotationController));
        return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterGrabController.LedgeClimbingConfig climbingConfig
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_climbingConfig));
        return num == System.IntPtr.Zero ? (CharacterGrabController.LedgeClimbingConfig) null : Il2CppObjectPool.Get<CharacterGrabController.LedgeClimbingConfig>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_climbingConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int layerMask
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_layerMask));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_layerMask)) = value;
      }
    }

    public unsafe RaycastHit lastGroundHit
    {
      get
      {
        return *(RaycastHit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_lastGroundHit));
      }
      [param: In] set
      {
        *(RaycastHit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalConnectionContext.NativeFieldInfoPtr_lastGroundHit)) = value;
      }
    }
  }

  public class DepthConnectionContext(System.IntPtr pointer) : 
    CharacterGrabController.ConnectionContext(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
    private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_CharacterRotationController_PersonPhysics_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHighStep_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSide_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsReachable_Public_Boolean_PlatformingHitData_0;

    static DepthConnectionContext()
    {
      Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (DepthConnectionContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr);
      CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, nameof (transform));
      CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, nameof (rotationController));
      CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, nameof (personPhysics));
      CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_CharacterRotationController_PersonPhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, 100675075);
      CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr_IsHighStep_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, 100675076);
      CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr_IsSide_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, 100675077);
      CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr_IsReachable_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr, 100675078);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 114557, RefRangeEnd = 114562, XrefRangeStart = 114557, XrefRangeEnd = 114562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DepthConnectionContext(
      Transform transform,
      CharacterRotationController rotationController,
      PersonPhysics personPhysics)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.DepthConnectionContext>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rotationController);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) personPhysics);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_CharacterRotationController_PersonPhysics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114777, XrefRangeEnd = 114779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHighStep(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr_IsHighStep_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114782, RefRangeEnd = 114783, XrefRangeStart = 114779, XrefRangeEnd = 114782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSide(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr_IsSide_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114783, XrefRangeEnd = 114785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsReachable(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DepthConnectionContext.NativeMethodInfoPtr_IsReachable_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Transform transform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_transform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterRotationController rotationController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_rotationController));
        return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PersonPhysics personPhysics
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_personPhysics));
        return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthConnectionContext.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class BottomOverlapContext(System.IntPtr pointer) : 
    CharacterGrabController.ConnectionContext(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_overlapConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_climbingConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_col;
    private static readonly System.IntPtr NativeFieldInfoPtr_defaultMask;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OverlapConfig_LedgeClimbingConfig_Collider_LayerMask_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Pivot_Public_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsVaultCollider_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLean_Public_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOverlapping_Public_Boolean_PlatformingHitData_0;

    static BottomOverlapContext()
    {
      Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (BottomOverlapContext));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr);
      CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_overlapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, nameof (overlapConfig));
      CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_climbingConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, nameof (climbingConfig));
      CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, nameof (col));
      CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_defaultMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, nameof (defaultMask));
      CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr__ctor_Public_Void_OverlapConfig_LedgeClimbingConfig_Collider_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, 100675079);
      CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, 100675080);
      CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_get_Pivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, 100675081);
      CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_IsVaultCollider_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, 100675082);
      CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_CanLean_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, 100675083);
      CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_IsOverlapping_Public_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr, 100675084);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114785, XrefRangeEnd = 114786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BottomOverlapContext(
      CharacterGrabController.OverlapConfig overlapConfig,
      CharacterGrabController.LedgeClimbingConfig climbingConfig,
      Collider col,
      LayerMask defaultMask)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.BottomOverlapContext>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overlapConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) climbingConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) col);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultMask;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr__ctor_Public_Void_OverlapConfig_LedgeClimbingConfig_Collider_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 Center
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114786, XrefRangeEnd = 114790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Vector3 Pivot
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114790, XrefRangeEnd = 114792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_get_Pivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114792, XrefRangeEnd = 114793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsVaultCollider(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_IsVaultCollider_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114793, XrefRangeEnd = 114800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanLean(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_CanLean_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 114811, RefRangeEnd = 114812, XrefRangeStart = 114800, XrefRangeEnd = 114811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsOverlapping(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BottomOverlapContext.NativeMethodInfoPtr_IsOverlapping_Public_Boolean_PlatformingHitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OverlapConfig overlapConfig
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_overlapConfig));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OverlapConfig) null : Il2CppObjectPool.Get<CharacterGrabController.OverlapConfig>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_overlapConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterGrabController.LedgeClimbingConfig climbingConfig
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_climbingConfig));
        return num == System.IntPtr.Zero ? (CharacterGrabController.LedgeClimbingConfig) null : Il2CppObjectPool.Get<CharacterGrabController.LedgeClimbingConfig>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_climbingConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Collider col
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_col));
        return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LayerMask defaultMask
    {
      get
      {
        return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_defaultMask));
      }
      [param: In] set
      {
        *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BottomOverlapContext.NativeFieldInfoPtr_defaultMask)) = value;
      }
    }
  }

  public class BulgeOverlapHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ovelapContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static BulgeOverlapHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (BulgeOverlapHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr);
      CharacterGrabController.BulgeOverlapHandler.NativeFieldInfoPtr_ovelapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr, nameof (ovelapContext));
      CharacterGrabController.BulgeOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr, 100675085);
      CharacterGrabController.BulgeOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr, 100675086);
      CharacterGrabController.BulgeOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr, 100675087);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BulgeOverlapHandler(
      CharacterGrabController.OvelapContext ovelapContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.BulgeOverlapHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ovelapContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.BulgeOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.BulgeOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114812, XrefRangeEnd = 114815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.BulgeOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OvelapContext ovelapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BulgeOverlapHandler.NativeFieldInfoPtr_ovelapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.BulgeOverlapHandler.NativeFieldInfoPtr_ovelapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class FrontalLadderOverlapHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ovelapContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static FrontalLadderOverlapHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (FrontalLadderOverlapHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr);
      CharacterGrabController.FrontalLadderOverlapHandler.NativeFieldInfoPtr_ovelapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr, nameof (ovelapContext));
      CharacterGrabController.FrontalLadderOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr, 100675088);
      CharacterGrabController.FrontalLadderOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr, 100675089);
      CharacterGrabController.FrontalLadderOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr, 100675090);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FrontalLadderOverlapHandler(
      CharacterGrabController.OvelapContext ovelapContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.FrontalLadderOverlapHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ovelapContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.FrontalLadderOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114815, XrefRangeEnd = 114816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.FrontalLadderOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114816, XrefRangeEnd = 114819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.FrontalLadderOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OvelapContext ovelapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalLadderOverlapHandler.NativeFieldInfoPtr_ovelapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.FrontalLadderOverlapHandler.NativeFieldInfoPtr_ovelapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PipeOverlapHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ovelapContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static PipeOverlapHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (PipeOverlapHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr);
      CharacterGrabController.PipeOverlapHandler.NativeFieldInfoPtr_ovelapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr, nameof (ovelapContext));
      CharacterGrabController.PipeOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr, 100675091);
      CharacterGrabController.PipeOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr, 100675092);
      CharacterGrabController.PipeOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr, 100675093);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PipeOverlapHandler(
      CharacterGrabController.OvelapContext ovelapContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PipeOverlapHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ovelapContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PipeOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114819, XrefRangeEnd = 114820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PipeOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114820, XrefRangeEnd = 114823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PipeOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OvelapContext ovelapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PipeOverlapHandler.NativeFieldInfoPtr_ovelapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PipeOverlapHandler.NativeFieldInfoPtr_ovelapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PoleOverlapHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ovelapContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static PoleOverlapHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (PoleOverlapHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr);
      CharacterGrabController.PoleOverlapHandler.NativeFieldInfoPtr_ovelapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr, nameof (ovelapContext));
      CharacterGrabController.PoleOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr, 100675094);
      CharacterGrabController.PoleOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr, 100675095);
      CharacterGrabController.PoleOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr, 100675096);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PoleOverlapHandler(
      CharacterGrabController.OvelapContext ovelapContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PoleOverlapHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ovelapContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PoleOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114823, XrefRangeEnd = 114832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PoleOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114832, XrefRangeEnd = 114835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PoleOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OvelapContext ovelapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PoleOverlapHandler.NativeFieldInfoPtr_ovelapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PoleOverlapHandler.NativeFieldInfoPtr_ovelapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class GliderOverlapHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ovelapContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static GliderOverlapHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (GliderOverlapHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr);
      CharacterGrabController.GliderOverlapHandler.NativeFieldInfoPtr_ovelapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr, nameof (ovelapContext));
      CharacterGrabController.GliderOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr, 100675097);
      CharacterGrabController.GliderOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr, 100675098);
      CharacterGrabController.GliderOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr, 100675099);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GliderOverlapHandler(
      CharacterGrabController.OvelapContext ovelapContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.GliderOverlapHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ovelapContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.GliderOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.GliderOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114835, XrefRangeEnd = 114838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.GliderOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OvelapContext ovelapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.GliderOverlapHandler.NativeFieldInfoPtr_ovelapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.GliderOverlapHandler.NativeFieldInfoPtr_ovelapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PickaxeOverlapHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ovelapContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static PickaxeOverlapHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (PickaxeOverlapHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr);
      CharacterGrabController.PickaxeOverlapHandler.NativeFieldInfoPtr_ovelapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr, nameof (ovelapContext));
      CharacterGrabController.PickaxeOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr, 100675100);
      CharacterGrabController.PickaxeOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr, 100675101);
      CharacterGrabController.PickaxeOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr, 100675102);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PickaxeOverlapHandler(
      CharacterGrabController.OvelapContext ovelapContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PickaxeOverlapHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ovelapContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PickaxeOverlapHandler.NativeMethodInfoPtr__ctor_Public_Void_OvelapContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PickaxeOverlapHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114838, XrefRangeEnd = 114841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PickaxeOverlapHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.OvelapContext ovelapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PickaxeOverlapHandler.NativeFieldInfoPtr_ovelapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.OvelapContext) null : Il2CppObjectPool.Get<CharacterGrabController.OvelapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PickaxeOverlapHandler.NativeFieldInfoPtr_ovelapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class VaultJumpUpHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomOverlapContext;
    private static readonly System.IntPtr NativeFieldInfoPtr_climbingContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BottomOverlapContext_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;

    static VaultJumpUpHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (VaultJumpUpHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr);
      CharacterGrabController.VaultJumpUpHandler.NativeFieldInfoPtr_bottomOverlapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr, nameof (bottomOverlapContext));
      CharacterGrabController.VaultJumpUpHandler.NativeFieldInfoPtr_climbingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr, nameof (climbingContext));
      CharacterGrabController.VaultJumpUpHandler.NativeMethodInfoPtr__ctor_Public_Void_BottomOverlapContext_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr, 100675103);
      CharacterGrabController.VaultJumpUpHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr, 100675104);
      CharacterGrabController.VaultJumpUpHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr, 100675105);
    }

    [CallerCount(80 /*0x50*/)]
    [CachedScanResults(RefRangeStart = 79068, RefRangeEnd = 79148, XrefRangeStart = 79068, XrefRangeEnd = 79148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VaultJumpUpHandler(
      CharacterGrabController.BottomOverlapContext bottomOverlapContext,
      CharacterGrabController.ClimbLedgeContext climbingContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.VaultJumpUpHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bottomOverlapContext);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) climbingContext);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.VaultJumpUpHandler.NativeMethodInfoPtr__ctor_Public_Void_BottomOverlapContext_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114841, XrefRangeEnd = 114845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.VaultJumpUpHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114845, XrefRangeEnd = 114853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.VaultJumpUpHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.BottomOverlapContext bottomOverlapContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.VaultJumpUpHandler.NativeFieldInfoPtr_bottomOverlapContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.BottomOverlapContext) null : Il2CppObjectPool.Get<CharacterGrabController.BottomOverlapContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.VaultJumpUpHandler.NativeFieldInfoPtr_bottomOverlapContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterGrabController.ClimbLedgeContext climbingContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.VaultJumpUpHandler.NativeFieldInfoPtr_climbingContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.VaultJumpUpHandler.NativeFieldInfoPtr_climbingContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class LedgeHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static LedgeHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (LedgeHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr);
      CharacterGrabController.LedgeHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.LedgeHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr, 100675106);
      CharacterGrabController.LedgeHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr, 100675107);
      CharacterGrabController.LedgeHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr, 100675108);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LedgeHandler(
      CharacterGrabController.ClimbLedgeContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.LedgeHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LedgeHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114853, XrefRangeEnd = 114855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.LedgeHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114855, XrefRangeEnd = 114861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.LedgeHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.ClimbLedgeContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LedgeHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class VaultClimbingHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static VaultClimbingHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (VaultClimbingHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr);
      CharacterGrabController.VaultClimbingHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.VaultClimbingHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr, 100675109);
      CharacterGrabController.VaultClimbingHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr, 100675110);
      CharacterGrabController.VaultClimbingHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr, 100675111);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VaultClimbingHandler(
      CharacterGrabController.ClimbLedgeContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.VaultClimbingHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.VaultClimbingHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114861, XrefRangeEnd = 114863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.VaultClimbingHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114863, XrefRangeEnd = 114870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.VaultClimbingHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.ClimbLedgeContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.VaultClimbingHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.VaultClimbingHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class LadderFromBelowHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static LadderFromBelowHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (LadderFromBelowHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr);
      CharacterGrabController.LadderFromBelowHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.LadderFromBelowHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr, 100675112);
      CharacterGrabController.LadderFromBelowHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr, 100675113);
      CharacterGrabController.LadderFromBelowHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr, 100675114);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LadderFromBelowHandler(
      CharacterGrabController.ClimbLedgeContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.LadderFromBelowHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LadderFromBelowHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114870, XrefRangeEnd = 114879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.LadderFromBelowHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114879, XrefRangeEnd = 114882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.LadderFromBelowHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.ClimbLedgeContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LadderFromBelowHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LadderFromBelowHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class WallStepHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static WallStepHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (WallStepHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr);
      CharacterGrabController.WallStepHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.WallStepHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr, 100675115);
      CharacterGrabController.WallStepHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr, 100675116);
      CharacterGrabController.WallStepHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr, 100675117);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WallStepHandler(
      CharacterGrabController.ClimbLedgeContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.WallStepHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.WallStepHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114882, XrefRangeEnd = 114884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.WallStepHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114884, XrefRangeEnd = 114889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.WallStepHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.ClimbLedgeContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.WallStepHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.WallStepHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class StepClimbingHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static StepClimbingHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (StepClimbingHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr);
      CharacterGrabController.StepClimbingHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.StepClimbingHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr, 100675118);
      CharacterGrabController.StepClimbingHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr, 100675119);
      CharacterGrabController.StepClimbingHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr, 100675120);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StepClimbingHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.StepClimbingHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.StepClimbingHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114889, XrefRangeEnd = 114894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.StepClimbingHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114894, XrefRangeEnd = 114912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.StepClimbingHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.StepClimbingHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.StepClimbingHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class WallHitHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static WallHitHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (WallHitHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr);
      CharacterGrabController.WallHitHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.WallHitHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr, 100675121);
      CharacterGrabController.WallHitHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr, 100675122);
      CharacterGrabController.WallHitHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr, 100675123);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WallHitHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.WallHitHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.WallHitHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.WallHitHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114912, XrefRangeEnd = 114920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.WallHitHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.WallHitHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.WallHitHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class SlopeHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static SlopeHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (SlopeHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr);
      CharacterGrabController.SlopeHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.SlopeHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr, 100675124);
      CharacterGrabController.SlopeHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr, 100675125);
      CharacterGrabController.SlopeHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr, 100675126);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SlopeHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.SlopeHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.SlopeHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114920, XrefRangeEnd = 114925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.SlopeHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114925, XrefRangeEnd = 114929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.SlopeHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.SlopeHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.SlopeHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class TripHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static TripHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (TripHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr);
      CharacterGrabController.TripHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.TripHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr, 100675127);
      CharacterGrabController.TripHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr, 100675128);
      CharacterGrabController.TripHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr, 100675129);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TripHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.TripHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.TripHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114929, XrefRangeEnd = 114932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.TripHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114932, XrefRangeEnd = 114940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.TripHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.TripHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.TripHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class DoorHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static DoorHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (DoorHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr);
      CharacterGrabController.DoorHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.DoorHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr, 100675130);
      CharacterGrabController.DoorHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr, 100675131);
      CharacterGrabController.DoorHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr, 100675132);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DoorHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.DoorHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DoorHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.DoorHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114940, XrefRangeEnd = 114947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.DoorHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DoorHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DoorHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class LadderHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static LadderHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (LadderHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr);
      CharacterGrabController.LadderHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.LadderHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr, 100675133);
      CharacterGrabController.LadderHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr, 100675134);
      CharacterGrabController.LadderHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr, 100675135);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LadderHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.LadderHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.LadderHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.LadderHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114947, XrefRangeEnd = 114950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.LadderHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LadderHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.LadderHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class StairsHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static StairsHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (StairsHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr);
      CharacterGrabController.StairsHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.StairsHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr, 100675136);
      CharacterGrabController.StairsHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr, 100675137);
      CharacterGrabController.StairsHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr, 100675138);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StairsHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.StairsHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.StairsHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.StairsHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114950, XrefRangeEnd = 114953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.StairsHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.StairsHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.StairsHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PipeVerticalHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static PipeVerticalHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (PipeVerticalHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr);
      CharacterGrabController.PipeVerticalHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.PipeVerticalHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr, 100675139);
      CharacterGrabController.PipeVerticalHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr, 100675140);
      CharacterGrabController.PipeVerticalHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr, 100675141);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PipeVerticalHandler(
      CharacterGrabController.FrontalConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.PipeVerticalHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.PipeVerticalHandler.NativeMethodInfoPtr__ctor_Public_Void_FrontalConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PipeVerticalHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114953, XrefRangeEnd = 114956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.PipeVerticalHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.FrontalConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PipeVerticalHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.FrontalConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.FrontalConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.PipeVerticalHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class WallStepDropdown(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static WallStepDropdown()
    {
      Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (WallStepDropdown));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr);
      CharacterGrabController.WallStepDropdown.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.WallStepDropdown.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr, 100675142);
      CharacterGrabController.WallStepDropdown.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr, 100675143);
      CharacterGrabController.WallStepDropdown.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr, 100675144);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WallStepDropdown(
      CharacterGrabController.ClimbLedgeContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.WallStepDropdown>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.WallStepDropdown.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.WallStepDropdown.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114956, XrefRangeEnd = 114959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.WallStepDropdown.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.ClimbLedgeContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.WallStepDropdown.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.WallStepDropdown.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class DropdownLedgeHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static DropdownLedgeHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (DropdownLedgeHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr);
      CharacterGrabController.DropdownLedgeHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.DropdownLedgeHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr, 100675145);
      CharacterGrabController.DropdownLedgeHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr, 100675146);
      CharacterGrabController.DropdownLedgeHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr, 100675147);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropdownLedgeHandler(
      CharacterGrabController.ClimbLedgeContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.DropdownLedgeHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DropdownLedgeHandler.NativeMethodInfoPtr__ctor_Public_Void_ClimbLedgeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114959, XrefRangeEnd = 114960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.DropdownLedgeHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114960, XrefRangeEnd = 114964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.DropdownLedgeHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.ClimbLedgeContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DropdownLedgeHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.ClimbLedgeContext) null : Il2CppObjectPool.Get<CharacterGrabController.ClimbLedgeContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DropdownLedgeHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class DepthStepHandler(System.IntPtr pointer) : 
    CharacterGrabController.PlatformingConnectionHandler(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionContext;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DepthConnectionContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0;

    static DepthStepHandler()
    {
      Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabController>.NativeClassPtr, nameof (DepthStepHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr);
      CharacterGrabController.DepthStepHandler.NativeFieldInfoPtr_connectionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr, nameof (connectionContext));
      CharacterGrabController.DepthStepHandler.NativeMethodInfoPtr__ctor_Public_Void_DepthConnectionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr, 100675148);
      CharacterGrabController.DepthStepHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr, 100675149);
      CharacterGrabController.DepthStepHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr, 100675150);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DepthStepHandler(
      CharacterGrabController.DepthConnectionContext connectionContext)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabController.DepthStepHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionContext)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabController.DepthStepHandler.NativeMethodInfoPtr__ctor_Public_Void_DepthConnectionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114964, XrefRangeEnd = 114968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CharacterGrabController.PlatformingType HandleConnection(
      ref CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.DepthStepHandler.NativeMethodInfoPtr_HandleConnection_Protected_Virtual_PlatformingType_byref_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CharacterGrabController.PlatformingType*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114968, XrefRangeEnd = 114973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasConnected(
      CharacterGrabController.PlatformingHitData platformingHitData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) platformingHitData))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterGrabController.DepthStepHandler.NativeMethodInfoPtr_HasConnected_Protected_Virtual_Boolean_PlatformingHitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe CharacterGrabController.DepthConnectionContext connectionContext
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthStepHandler.NativeFieldInfoPtr_connectionContext));
        return num == System.IntPtr.Zero ? (CharacterGrabController.DepthConnectionContext) null : Il2CppObjectPool.Get<CharacterGrabController.DepthConnectionContext>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabController.DepthStepHandler.NativeFieldInfoPtr_connectionContext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
