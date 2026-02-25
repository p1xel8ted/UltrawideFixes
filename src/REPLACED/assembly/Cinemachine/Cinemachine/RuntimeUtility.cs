// Decompiled with JetBrains decompiler
// Type: Cinemachine.RuntimeUtility
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public static class RuntimeUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_HitBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_PenetrationIndexBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_ScratchCollider;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_ScratchColliderGameObject;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RaycastIgnoreTag_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SphereCastIgnoreTag_Public_Static_Boolean_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScratchCollider_Internal_Static_SphereCollider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyScratchCollider_Internal_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeCurve_Public_Static_AnimationCurve_AnimationCurve_Boolean_Boolean_0;

  static RuntimeUtility()
  {
    Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (RuntimeUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr);
    RuntimeUtility.NativeFieldInfoPtr_s_HitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, nameof (s_HitBuffer));
    RuntimeUtility.NativeFieldInfoPtr_s_PenetrationIndexBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, nameof (s_PenetrationIndexBuffer));
    RuntimeUtility.NativeFieldInfoPtr_s_ScratchCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, nameof (s_ScratchCollider));
    RuntimeUtility.NativeFieldInfoPtr_s_ScratchColliderGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, nameof (s_ScratchColliderGameObject));
    RuntimeUtility.NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664178);
    RuntimeUtility.NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664179);
    RuntimeUtility.NativeMethodInfoPtr_RaycastIgnoreTag_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664180);
    RuntimeUtility.NativeMethodInfoPtr_SphereCastIgnoreTag_Public_Static_Boolean_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664181);
    RuntimeUtility.NativeMethodInfoPtr_GetScratchCollider_Internal_Static_SphereCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664182);
    RuntimeUtility.NativeMethodInfoPtr_DestroyScratchCollider_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664183);
    RuntimeUtility.NativeMethodInfoPtr_NormalizeCurve_Public_Static_AnimationCurve_AnimationCurve_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtility>.NativeClassPtr, 100664184);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944667, RefRangeEnd = 944673, XrefRangeStart = 944660, XrefRangeEnd = 944667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyObject(UnityEngine.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(194)]
  [CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsPrefab(GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 944702, RefRangeEnd = 944710, XrefRangeStart = 944673, XrefRangeEnd = 944702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool RaycastIgnoreTag(
    Ray ray,
    out RaycastHit hitInfo,
    float rayLength,
    int layerMask,
    [In] ref string ignoreTag)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = (System.IntPtr) &ray;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(ignoreTag);
    System.IntPtr* numPtr2 = &il2Cpp;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_RaycastIgnoreTag_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ignoreTag = IL2CPP.Il2CppStringToManaged(il2Cpp);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944785, RefRangeEnd = 944787, XrefRangeStart = 944710, XrefRangeEnd = 944785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SphereCastIgnoreTag(
    Vector3 rayStart,
    float radius,
    Vector3 dir,
    out RaycastHit hitInfo,
    float rayLength,
    int layerMask,
    [In] ref string ignoreTag)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = (System.IntPtr) &rayStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitInfo;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(ignoreTag);
    System.IntPtr* numPtr2 = &il2Cpp;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_SphereCastIgnoreTag_Public_Static_Boolean_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ignoreTag = IL2CPP.Il2CppStringToManaged(il2Cpp);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944829, RefRangeEnd = 944831, XrefRangeStart = 944787, XrefRangeEnd = 944829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SphereCollider GetScratchCollider()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_GetScratchCollider_Internal_Static_SphereCollider_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (SphereCollider) null : Il2CppObjectPool.Get<SphereCollider>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944856, RefRangeEnd = 944858, XrefRangeStart = 944831, XrefRangeEnd = 944856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyScratchCollider()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_DestroyScratchCollider_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944873, RefRangeEnd = 944874, XrefRangeStart = 944858, XrefRangeEnd = 944873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AnimationCurve NormalizeCurve(
    AnimationCurve curve,
    bool normalizeX,
    bool normalizeY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &normalizeX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &normalizeY;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RuntimeUtility.NativeMethodInfoPtr_NormalizeCurve_Public_Static_AnimationCurve_AnimationCurve_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
  }

  public RuntimeUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStructArray<RaycastHit> s_HitBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RuntimeUtility.NativeFieldInfoPtr_s_HitBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<RaycastHit>) null : Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RuntimeUtility.NativeFieldInfoPtr_s_HitBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> s_PenetrationIndexBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RuntimeUtility.NativeFieldInfoPtr_s_PenetrationIndexBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : Il2CppObjectPool.Get<Il2CppStructArray<int>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RuntimeUtility.NativeFieldInfoPtr_s_PenetrationIndexBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SphereCollider s_ScratchCollider
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RuntimeUtility.NativeFieldInfoPtr_s_ScratchCollider, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (SphereCollider) null : Il2CppObjectPool.Get<SphereCollider>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RuntimeUtility.NativeFieldInfoPtr_s_ScratchCollider, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe GameObject s_ScratchColliderGameObject
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RuntimeUtility.NativeFieldInfoPtr_s_ScratchColliderGameObject, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RuntimeUtility.NativeFieldInfoPtr_s_ScratchColliderGameObject, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
