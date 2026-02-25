// Decompiled with JetBrains decompiler
// Type: UnityEngine.SkinnedMeshRenderer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public class SkinnedMeshRenderer(IntPtr pointer) : Renderer(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_quality_Public_get_SkinQuality_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_quality_Public_set_Void_SkinQuality_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_updateWhenOffscreen_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_rootBone_Public_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_skinnedMotionVectors_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_skinnedMotionVectors_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeWeight_Public_Single_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPreviousVertexBuffer_Public_GraphicsBuffer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Private_GraphicsBuffer_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_quality_Injected_Private_Static_SkinQuality_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_quality_Injected_Private_Static_Void_IntPtr_SkinQuality_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_updateWhenOffscreen_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_updateWhenOffscreen_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rootBone_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_rootBone_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bones_Injected_Private_Static_Il2CppReferenceArray_1_Transform_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_bones_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_skinnedMotionVectors_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_skinnedMotionVectors_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeWeight_Injected_Private_Static_Single_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetBlendShapeWeight_Injected_Private_Static_Void_IntPtr_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVertexBufferImpl_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferTarget_Injected_Private_Static_Target_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferTarget_Injected_Private_Static_Void_IntPtr_Target_0;

  static SkinnedMeshRenderer()
  {
    Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SkinnedMeshRenderer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_quality_Public_get_SkinQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666019);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_quality_Public_set_Void_SkinQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666020);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_updateWhenOffscreen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666021);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666022);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666023);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666024);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666025);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_rootBone_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666026);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666027);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666028);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666029);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666030);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_skinnedMotionVectors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666031);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_skinnedMotionVectors_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666032 /*0x06000AB0*/);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetBlendShapeWeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666033);
    SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666034);
    SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666035);
    SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666036);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666037);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666038);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666039);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Private_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666040);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666041);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666042);
    SkinnedMeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666043);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_quality_Injected_Private_Static_SkinQuality_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666044);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_quality_Injected_Private_Static_Void_IntPtr_SkinQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666045);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_updateWhenOffscreen_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666046);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666047);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666048 /*0x06000AC0*/);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666049);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_rootBone_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666050);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_rootBone_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666051);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Injected_Private_Static_Il2CppReferenceArray_1_Transform_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666052);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666053);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666054);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666055);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_skinnedMotionVectors_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666056);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_skinnedMotionVectors_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666057);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetBlendShapeWeight_Injected_Private_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666058);
    SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666059);
    SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666060);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBufferImpl_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666061);
    SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666062);
    SkinnedMeshRenderer.NativeMethodInfoPtr_get_vertexBufferTarget_Injected_Private_Static_Target_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666063);
    SkinnedMeshRenderer.NativeMethodInfoPtr_set_vertexBufferTarget_Injected_Private_Static_Void_IntPtr_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100666064 /*0x06000AD0*/);
  }

  public unsafe SkinQuality quality
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431196, XrefRangeEnd = 431201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_quality_Public_get_SkinQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SkinQuality*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431201, XrefRangeEnd = 431206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_quality_Public_set_Void_SkinQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool updateWhenOffscreen
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431206, XrefRangeEnd = 431211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_updateWhenOffscreen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431211, XrefRangeEnd = 431216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool forceMatrixRecalculationPerRender
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431216, XrefRangeEnd = 431221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431221, XrefRangeEnd = 431226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Transform rootBone
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431226, XrefRangeEnd = 431234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431234, XrefRangeEnd = 431242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_rootBone_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<Transform> bones
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431242, XrefRangeEnd = 431247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431247, XrefRangeEnd = 431252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Mesh sharedMesh
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431252, XrefRangeEnd = 431260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Mesh) null : Il2CppObjectPool.Get<Mesh>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431260, XrefRangeEnd = 431268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool skinnedMotionVectors
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431268, XrefRangeEnd = 431273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_skinnedMotionVectors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431273, XrefRangeEnd = 431278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_skinnedMotionVectors_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431278, XrefRangeEnd = 431283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetBlendShapeWeight(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetBlendShapeWeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431283, XrefRangeEnd = 431288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBlendShapeWeight(int index, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431288, XrefRangeEnd = 431299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeMesh(Mesh mesh)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431299, XrefRangeEnd = 431310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeMesh(Mesh mesh, bool useScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &useScale;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431310, XrefRangeEnd = 431319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer GetVertexBuffer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GraphicsBuffer) null : Il2CppObjectPool.Get<GraphicsBuffer>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431319, XrefRangeEnd = 431328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer GetPreviousVertexBuffer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GraphicsBuffer) null : Il2CppObjectPool.Get<GraphicsBuffer>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431328, XrefRangeEnd = 431333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer GetVertexBufferImpl()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GraphicsBuffer) null : Il2CppObjectPool.Get<GraphicsBuffer>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431333, XrefRangeEnd = 431338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphicsBuffer GetPreviousVertexBufferImpl()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Private_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GraphicsBuffer) null : Il2CppObjectPool.Get<GraphicsBuffer>(num3);
  }

  public unsafe GraphicsBuffer.Target vertexBufferTarget
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431338, XrefRangeEnd = 431343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsBuffer.Target*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431343, XrefRangeEnd = 431348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SkinnedMeshRenderer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431348, XrefRangeEnd = 431350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SkinQuality get_quality_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_quality_Injected_Private_Static_SkinQuality_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SkinQuality*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431350, XrefRangeEnd = 431352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_quality_Injected(IntPtr _unity_self, SkinQuality value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_quality_Injected_Private_Static_Void_IntPtr_SkinQuality_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431352, XrefRangeEnd = 431354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_updateWhenOffscreen_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_updateWhenOffscreen_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431354, XrefRangeEnd = 431356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_updateWhenOffscreen_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431356, XrefRangeEnd = 431358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_forceMatrixRecalculationPerRender_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431358, XrefRangeEnd = 431360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_forceMatrixRecalculationPerRender_Injected(
    IntPtr _unity_self,
    bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431360, XrefRangeEnd = 431362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_rootBone_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_rootBone_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431362, XrefRangeEnd = 431364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_rootBone_Injected(IntPtr _unity_self, IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_rootBone_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431364, XrefRangeEnd = 431366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Transform> get_bones_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Injected_Private_Static_Il2CppReferenceArray_1_Transform_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431366, XrefRangeEnd = 431368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_bones_Injected(
    IntPtr _unity_self,
    Il2CppReferenceArray<Transform> value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Transform_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431368, XrefRangeEnd = 431370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_sharedMesh_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431370, XrefRangeEnd = 431372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431372, XrefRangeEnd = 431374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_skinnedMotionVectors_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_skinnedMotionVectors_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431374, XrefRangeEnd = 431376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_skinnedMotionVectors_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_skinnedMotionVectors_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431376, XrefRangeEnd = 431378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetBlendShapeWeight_Injected(IntPtr _unity_self, int index)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetBlendShapeWeight_Injected_Private_Static_Single_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431378, XrefRangeEnd = 431380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetBlendShapeWeight_Injected(
    IntPtr _unity_self,
    int index,
    float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Injected_Private_Static_Void_IntPtr_Int32_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431380, XrefRangeEnd = 431382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, bool useScale)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mesh;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &useScale;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431382, XrefRangeEnd = 431384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetVertexBufferImpl_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBufferImpl_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431384, XrefRangeEnd = 431386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetPreviousVertexBufferImpl_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431386, XrefRangeEnd = 431388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsBuffer.Target get_vertexBufferTarget_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_vertexBufferTarget_Injected_Private_Static_Target_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsBuffer.Target*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431388, XrefRangeEnd = 431390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_vertexBufferTarget_Injected(
    IntPtr _unity_self,
    GraphicsBuffer.Target value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_vertexBufferTarget_Injected_Private_Static_Void_IntPtr_Target_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
