// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.BasePhysics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.MovementPhysics;

public class BasePhysics(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_horizontalCollisionMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_verticalCollisionMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_horizontalRaySpacing;
  private static readonly System.IntPtr NativeFieldInfoPtr_verticalRaySpacing;
  private static readonly System.IntPtr NativeFieldInfoPtr_skinWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_horizontalRayCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_verticalRayCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_col;
  private static readonly System.IntPtr NativeFieldInfoPtr_raycastOrigins;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_collisions;
  private static readonly System.IntPtr NativeFieldInfoPtr_plane;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastExtents;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Plane_Public_get_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Collisions_Public_get_CollisionInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Corners_Public_get_RaycastOrigins_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthOffset_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SkinWidth_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HorizontalCollisionMask_Public_get_LayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HorizontalCollisionMask_Public_set_Void_LayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VerticalCollisionMask_Public_get_LayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePlane_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRaySpacing_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPlane_Public_Void_Plane_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AxisPoint_Public_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRaycastOrigins_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OverlapBoundaries_Public_Int32_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OverlapPoint_Public_Int32_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Protected_Boolean_Vector3_Vector3_Single_Nullable_1_LayerMask_Boolean_Nullable_1_Color_Nullable_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BasePhysics()
  {
    Il2CppClassPointerStore<BasePhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (BasePhysics));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr);
    BasePhysics.NativeFieldInfoPtr_horizontalCollisionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (horizontalCollisionMask));
    BasePhysics.NativeFieldInfoPtr_verticalCollisionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (verticalCollisionMask));
    BasePhysics.NativeFieldInfoPtr_horizontalRaySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (horizontalRaySpacing));
    BasePhysics.NativeFieldInfoPtr_verticalRaySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (verticalRaySpacing));
    BasePhysics.NativeFieldInfoPtr_skinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (skinWidth));
    BasePhysics.NativeFieldInfoPtr_overlapPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (overlapPoint));
    BasePhysics.NativeFieldInfoPtr_horizontalRayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (horizontalRayCount));
    BasePhysics.NativeFieldInfoPtr_verticalRayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (verticalRayCount));
    BasePhysics.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (col));
    BasePhysics.NativeFieldInfoPtr_raycastOrigins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (raycastOrigins));
    BasePhysics.NativeFieldInfoPtr_lastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (lastHit));
    BasePhysics.NativeFieldInfoPtr_collisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (collisions));
    BasePhysics.NativeFieldInfoPtr_plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (plane));
    BasePhysics.NativeFieldInfoPtr_depthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (depthOffset));
    BasePhysics.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (active));
    BasePhysics.NativeFieldInfoPtr_lastExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (lastExtents));
    BasePhysics.NativeFieldInfoPtr_overlapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (overlapBuffer));
    BasePhysics.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670899);
    BasePhysics.NativeMethodInfoPtr_get_Collisions_Public_get_CollisionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670900);
    BasePhysics.NativeMethodInfoPtr_get_Corners_Public_get_RaycastOrigins_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670901);
    BasePhysics.NativeMethodInfoPtr_get_DepthOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670902);
    BasePhysics.NativeMethodInfoPtr_get_SkinWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670903);
    BasePhysics.NativeMethodInfoPtr_get_HorizontalCollisionMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670904);
    BasePhysics.NativeMethodInfoPtr_set_HorizontalCollisionMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670905);
    BasePhysics.NativeMethodInfoPtr_get_VerticalCollisionMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670906);
    BasePhysics.NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670907);
    BasePhysics.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670908);
    BasePhysics.NativeMethodInfoPtr_Init_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670909);
    BasePhysics.NativeMethodInfoPtr_CalculatePlane_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670910);
    BasePhysics.NativeMethodInfoPtr_CalculateRaySpacing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670911);
    BasePhysics.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670912);
    BasePhysics.NativeMethodInfoPtr_SetPlane_Public_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670913);
    BasePhysics.NativeMethodInfoPtr_AxisPoint_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670914);
    BasePhysics.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670915);
    BasePhysics.NativeMethodInfoPtr_UpdateRaycastOrigins_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670916);
    BasePhysics.NativeMethodInfoPtr_OverlapBoundaries_Public_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670917);
    BasePhysics.NativeMethodInfoPtr_OverlapPoint_Public_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670918);
    BasePhysics.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670919);
    BasePhysics.NativeMethodInfoPtr_Raycast_Protected_Boolean_Vector3_Vector3_Single_Nullable_1_LayerMask_Boolean_Nullable_1_Color_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670920);
    BasePhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, 100670921);
  }

  public unsafe Plane Plane
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe BasePhysics.CollisionInfo Collisions
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_Collisions_Public_get_CollisionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new BasePhysics.CollisionInfo(pointer);
    }
  }

  public unsafe BasePhysics.RaycastOrigins Corners
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_Corners_Public_get_RaycastOrigins_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(BasePhysics.RaycastOrigins*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float DepthOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_DepthOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float SkinWidth
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_SkinWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe LayerMask HorizontalCollisionMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_HorizontalCollisionMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_set_HorizontalCollisionMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LayerMask VerticalCollisionMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_VerticalCollisionMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Bounds Bounds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89338, XrefRangeEnd = 89339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89339, XrefRangeEnd = 89353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BasePhysics.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 89360, RefRangeEnd = 89364, XrefRangeStart = 89353, XrefRangeEnd = 89360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(float depthOffset = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &depthOffset
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_Init_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 89369, RefRangeEnd = 89374, XrefRangeStart = 89364, XrefRangeEnd = 89369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculatePlane()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_CalculatePlane_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89383, RefRangeEnd = 89384, XrefRangeStart = 89374, XrefRangeEnd = 89383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateRaySpacing()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_CalculateRaySpacing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 89384, RefRangeEnd = 89391, XrefRangeStart = 89384, XrefRangeEnd = 89384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ClosestPoint(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void SetPlane(Plane plane)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &plane
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_SetPlane_Public_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89393, RefRangeEnd = 89395, XrefRangeStart = 89391, XrefRangeEnd = 89393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 AxisPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_AxisPoint_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void SetActive(bool active)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &active
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 89404, RefRangeEnd = 89411, XrefRangeStart = 89395, XrefRangeEnd = 89404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateRaycastOrigins(bool depth = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &depth
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_UpdateRaycastOrigins_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89420, RefRangeEnd = 89421, XrefRangeStart = 89411, XrefRangeEnd = 89420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int OverlapBoundaries(Vector3 position, Vector3 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_OverlapBoundaries_Public_Int32_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 89426, RefRangeEnd = 89429, XrefRangeStart = 89421, XrefRangeEnd = 89426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int OverlapPoint(Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &position
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_OverlapPoint_Public_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89429, XrefRangeEnd = 89437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 89456, RefRangeEnd = 89463, XrefRangeStart = 89437, XrefRangeEnd = 89456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Raycast(
    Vector3 origin,
    Vector3 dir,
    float length,
    Il2CppSystem.Nullable<LayerMask> layerMask = null,
    bool debug = false,
    Il2CppSystem.Nullable<Color> debugColor = null,
    Il2CppSystem.Nullable<float> duration = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) layerMask));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &debug;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) debugColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) duration));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr_Raycast_Protected_Boolean_Vector3_Vector3_Single_Nullable_1_LayerMask_Boolean_Nullable_1_Color_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89463, XrefRangeEnd = 89467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BasePhysics()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BasePhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask horizontalCollisionMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_horizontalCollisionMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_horizontalCollisionMask)) = value;
    }
  }

  public unsafe LayerMask verticalCollisionMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_verticalCollisionMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_verticalCollisionMask)) = value;
    }
  }

  public unsafe float horizontalRaySpacing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_horizontalRaySpacing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_horizontalRaySpacing)) = value;
    }
  }

  public unsafe float verticalRaySpacing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_verticalRaySpacing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_verticalRaySpacing)) = value;
    }
  }

  public static unsafe float skinWidth
  {
    get
    {
      float skinWidth;
      IL2CPP.il2cpp_field_static_get_value(BasePhysics.NativeFieldInfoPtr_skinWidth, (void*) &skinWidth);
      return skinWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BasePhysics.NativeFieldInfoPtr_skinWidth, (void*) &value);
    }
  }

  public unsafe Vector3 overlapPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_overlapPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_overlapPoint)) = value;
    }
  }

  public unsafe int horizontalRayCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_horizontalRayCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_horizontalRayCount)) = value;
    }
  }

  public unsafe int verticalRayCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_verticalRayCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_verticalRayCount)) = value;
    }
  }

  public unsafe BoxCollider col
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_col));
      return num == System.IntPtr.Zero ? (BoxCollider) null : Il2CppObjectPool.Get<BoxCollider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BasePhysics.RaycastOrigins raycastOrigins
  {
    get
    {
      return *(BasePhysics.RaycastOrigins*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_raycastOrigins));
    }
    [param: In] set
    {
      *(BasePhysics.RaycastOrigins*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_raycastOrigins)) = value;
    }
  }

  public unsafe RaycastHit lastHit
  {
    get
    {
      return *(RaycastHit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_lastHit));
    }
    [param: In] set
    {
      *(RaycastHit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_lastHit)) = value;
    }
  }

  public BasePhysics.CollisionInfo collisions
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_collisions);
      return new BasePhysics.CollisionInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_collisions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Plane plane
  {
    get
    {
      return *(Plane*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_plane));
    }
    [param: In] set
    {
      *(Plane*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_plane)) = value;
    }
  }

  public unsafe float depthOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_depthOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_depthOffset)) = value;
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe Vector3 lastExtents
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_lastExtents));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_lastExtents)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_overlapBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.NativeFieldInfoPtr_overlapBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct RaycastOrigins
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_topLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_topRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomRight;
    [FieldOffset(0)]
    public Vector3 topLeft;
    [FieldOffset(12)]
    public Vector3 topRight;
    [FieldOffset(24)]
    public Vector3 bottomLeft;
    [FieldOffset(36)]
    public Vector3 bottomRight;

    static RaycastOrigins()
    {
      Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (RaycastOrigins));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr);
      BasePhysics.RaycastOrigins.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr, nameof (topLeft));
      BasePhysics.RaycastOrigins.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr, nameof (topRight));
      BasePhysics.RaycastOrigins.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr, nameof (bottomLeft));
      BasePhysics.RaycastOrigins.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr, nameof (bottomRight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BasePhysics.RaycastOrigins>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class CollisionInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_above;
    private static readonly System.IntPtr NativeFieldInfoPtr_below;
    private static readonly System.IntPtr NativeFieldInfoPtr_left;
    private static readonly System.IntPtr NativeFieldInfoPtr_right;
    private static readonly System.IntPtr NativeFieldInfoPtr_climbingSlope;
    private static readonly System.IntPtr NativeFieldInfoPtr_descendingSlope;
    private static readonly System.IntPtr NativeFieldInfoPtr_slopeAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_slopeAngleOld;
    private static readonly System.IntPtr NativeFieldInfoPtr_velocityOld;
    private static readonly System.IntPtr NativeFieldInfoPtr_groundNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_landObject;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

    static CollisionInfo()
    {
      Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasePhysics>.NativeClassPtr, nameof (CollisionInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr);
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_above = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (above));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_below = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (below));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (left));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (right));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_climbingSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (climbingSlope));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_descendingSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (descendingSlope));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_slopeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (slopeAngle));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_slopeAngleOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (slopeAngleOld));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_velocityOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (velocityOld));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_groundNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (groundNormal));
      BasePhysics.CollisionInfo.NativeFieldInfoPtr_landObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, nameof (landObject));
      BasePhysics.CollisionInfo.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr, 100670922);
    }

    [CallerCount(0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BasePhysics.CollisionInfo.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public CollisionInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CollisionInfo()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasePhysics.CollisionInfo>.NativeClassPtr))
    {
    }

    public unsafe bool above
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_above));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_above)) = value;
      }
    }

    public unsafe bool below
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_below));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_below)) = value;
      }
    }

    public unsafe bool left
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_left));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_left)) = value;
      }
    }

    public unsafe bool right
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_right));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_right)) = value;
      }
    }

    public unsafe bool climbingSlope
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_climbingSlope));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_climbingSlope)) = value;
      }
    }

    public unsafe bool descendingSlope
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_descendingSlope));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_descendingSlope)) = value;
      }
    }

    public unsafe float slopeAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_slopeAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_slopeAngle)) = value;
      }
    }

    public unsafe float slopeAngleOld
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_slopeAngleOld));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_slopeAngleOld)) = value;
      }
    }

    public unsafe Vector3 velocityOld
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_velocityOld));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_velocityOld)) = value;
      }
    }

    public unsafe Vector3 groundNormal
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_groundNormal));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_groundNormal)) = value;
      }
    }

    public unsafe GameObject landObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_landObject));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BasePhysics.CollisionInfo.NativeFieldInfoPtr_landObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
