// Decompiled with JetBrains decompiler
// Type: UnityEngine.Gizmos
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Gizmos(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_byref_ManagedSpanWrapper_Boolean_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0;
  private static readonly Gizmos.get_probeSizeDelegate get_probeSizeDelegateField;
  private static readonly Gizmos.DrawLineStrip_InjectedDelegate DrawLineStrip_InjectedDelegateField;
  private static readonly Gizmos.DrawLineListInternal_InjectedDelegate DrawLineListInternal_InjectedDelegateField;
  private static readonly Gizmos.DrawGUITexture_InjectedDelegate DrawGUITexture_InjectedDelegateField;
  private static readonly Gizmos.get_matrix_InjectedDelegate get_matrix_InjectedDelegateField;
  private static readonly Gizmos.get_exposure_InjectedDelegate get_exposure_InjectedDelegateField;
  private static readonly Gizmos.set_exposure_InjectedDelegate set_exposure_InjectedDelegateField;
  private static readonly Gizmos.DrawFrustum_InjectedDelegate DrawFrustum_InjectedDelegateField;
  private static readonly Gizmos.CalculateLOD_InjectedDelegate CalculateLOD_InjectedDelegateField;

  static Gizmos()
  {
    Il2CppClassPointerStore<Gizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Gizmos));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmos>.NativeClassPtr);
    Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664623);
    Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664624 /*0x06000530*/);
    Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664625);
    Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664626);
    Gizmos.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664627);
    Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664628);
    Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664629);
    Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664630);
    Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664631);
    Gizmos.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664632);
    Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664633);
    Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664634);
    Gizmos.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664635);
    Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664636);
    Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664637);
    Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664638);
    Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664639);
    Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664640 /*0x06000540*/);
    Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664641);
    Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664642);
    Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664643);
    Gizmos.NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664644);
    Gizmos.NativeMethodInfoPtr_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664645);
    Gizmos.NativeMethodInfoPtr_DrawWireMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664646);
    Gizmos.NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_byref_ManagedSpanWrapper_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664647);
    Gizmos.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664648);
    Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664649);
    Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100664650);
    Gizmos.get_probeSizeDelegateField = IL2CPP.ResolveICall<Gizmos.get_probeSizeDelegate>("UnityEngine.Gizmos::get_probeSize");
    Gizmos.DrawLineStrip_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawLineStrip_InjectedDelegate>("UnityEngine.Gizmos::DrawLineStrip_Injected");
    Gizmos.DrawLineListInternal_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawLineListInternal_InjectedDelegate>("UnityEngine.Gizmos::DrawLineListInternal_Injected");
    Gizmos.DrawGUITexture_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawGUITexture_InjectedDelegate>("UnityEngine.Gizmos::DrawGUITexture_Injected");
    Gizmos.get_matrix_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_matrix_InjectedDelegate>("UnityEngine.Gizmos::get_matrix_Injected");
    Gizmos.get_exposure_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_exposure_InjectedDelegate>("UnityEngine.Gizmos::get_exposure_Injected");
    Gizmos.set_exposure_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.set_exposure_InjectedDelegate>("UnityEngine.Gizmos::set_exposure_Injected");
    Gizmos.DrawFrustum_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawFrustum_InjectedDelegate>("UnityEngine.Gizmos::DrawFrustum_Injected");
    Gizmos.CalculateLOD_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.CalculateLOD_InjectedDelegate>("UnityEngine.Gizmos::CalculateLOD_Injected");
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 422616, RefRangeEnd = 422638, XrefRangeStart = 422614, XrefRangeEnd = 422616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLine(Vector3 from, Vector3 to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 422640, RefRangeEnd = 422646, XrefRangeStart = 422638, XrefRangeEnd = 422640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireSphere(Vector3 center, float radius)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Public_Static_Void_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 422648, RefRangeEnd = 422671, XrefRangeStart = 422646, XrefRangeEnd = 422648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawSphere(Vector3 center, float radius)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Public_Static_Void_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 422673, RefRangeEnd = 422689, XrefRangeStart = 422671, XrefRangeEnd = 422673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireCube(Vector3 center, Vector3 size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 422691, RefRangeEnd = 422701, XrefRangeStart = 422689, XrefRangeEnd = 422691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCube(Vector3 center, Vector3 size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawCube_Public_Static_Void_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422701, XrefRangeEnd = 422706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMesh(
    Mesh mesh,
    int submeshIndex,
    Vector3 position,
    Quaternion rotation,
    Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422706, XrefRangeEnd = 422711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireMesh(
    Mesh mesh,
    int submeshIndex,
    Vector3 position,
    Quaternion rotation,
    Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Int32_Vector3_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422711, XrefRangeEnd = 422712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawIcon(Vector3 center, string name, bool allowScaling)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allowScaling;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 422726, RefRangeEnd = 422728, XrefRangeStart = 422712, XrefRangeEnd = 422726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allowScaling;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_Boolean_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Color color
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 422730, RefRangeEnd = 422732, XrefRangeStart = 422728, XrefRangeEnd = 422730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_get_color_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(62), CachedScanResults(RefRangeStart = 422734, RefRangeEnd = 422796, XrefRangeStart = 422732, XrefRangeEnd = 422734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Matrix4x4 matrix
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 422798, RefRangeEnd = 422809, XrefRangeStart = 422796, XrefRangeEnd = 422798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Public_Static_set_Void_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      Matrix4x4 ret;
      Gizmos.get_matrix_Injected(out ret);
      return ret;
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 422811, RefRangeEnd = 422820, XrefRangeStart = 422809, XrefRangeEnd = 422811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawRay(Vector3 from, Vector3 direction)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 422831, RefRangeEnd = 422832, XrefRangeStart = 422820, XrefRangeEnd = 422831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMesh(Mesh mesh)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422832, XrefRangeEnd = 422837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 422842, RefRangeEnd = 422843, XrefRangeStart = 422837, XrefRangeEnd = 422842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireMesh(
    Mesh mesh,
    Vector3 position,
    Quaternion rotation,
    Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 422844, RefRangeEnd = 422845, XrefRangeStart = 422843, XrefRangeEnd = 422844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawIcon(Vector3 center, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Public_Static_Void_Vector3_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422845, XrefRangeEnd = 422847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLine_Injected([In] ref Vector3 from, [In] ref Vector3 to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422847, XrefRangeEnd = 422849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireSphere_Injected([In] ref Vector3 center, float radius)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422849, XrefRangeEnd = 422851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawSphere_Injected([In] ref Vector3 center, float radius)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawSphere_Injected_Private_Static_Void_byref_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422851, XrefRangeEnd = 422853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireCube_Injected([In] ref Vector3 center, [In] ref Vector3 size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422853, XrefRangeEnd = 422855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCube_Injected([In] ref Vector3 center, [In] ref Vector3 size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawCube_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422855, XrefRangeEnd = 422857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawMesh_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    [In] ref Vector3 position,
    [In] ref Quaternion rotation,
    [In] ref Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &mesh;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref scale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422857, XrefRangeEnd = 422859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawWireMesh_Injected(
    System.IntPtr mesh,
    int submeshIndex,
    [In] ref Vector3 position,
    [In] ref Quaternion rotation,
    [In] ref Vector3 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &mesh;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &submeshIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref scale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawWireMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_byref_Quaternion_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422859, XrefRangeEnd = 422861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawIcon_Injected(
    [In] ref Vector3 center,
    ref ManagedSpanWrapper name,
    bool allowScaling,
    [In] ref Color tint)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allowScaling;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawIcon_Injected_Private_Static_Void_byref_Vector3_byref_ManagedSpanWrapper_Boolean_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422861, XrefRangeEnd = 422863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_color_Injected(out Color ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422863, XrefRangeEnd = 422865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_color_Injected([In] ref Color value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422865, XrefRangeEnd = 422867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_matrix_Injected([In] ref Matrix4x4 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_matrix_Injected_Private_Static_Void_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe void DrawLineStrip(Il2CppSystem.ReadOnlySpan<Vector3> points, bool looped)
  {
    Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = points;
    fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper points1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<Vector3>) ref readOnlySpan).Length);
      Gizmos.DrawLineStrip_Injected(ref points1, looped);
    }
  }

  public static unsafe void DrawLineListInternal(Il2CppSystem.ReadOnlySpan<Vector3> points)
  {
    Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = points;
    fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>) ref readOnlySpan).GetPinnableReference())
    {
      ManagedSpanWrapper points1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<Vector3>) ref readOnlySpan).Length);
      Gizmos.DrawLineListInternal_Injected(ref points1);
    }
  }

  public static void DrawLineList(Il2CppSystem.ReadOnlySpan<Vector3> points)
  {
    if ((((Il2CppSystem.ReadOnlySpan<Vector3>) ref points).Length & 1) != 0)
      throw new UnityException("You cannot draw a line list from an odd number of points, with two points per line the number of points must be even");
    Gizmos.DrawLineListInternal(points);
  }

  public static void DrawGUITexture(
    Rect screenRect,
    Texture texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    Material mat)
  {
    Gizmos.DrawGUITexture_Injected(ref screenRect, Object.MarshalledUnityObject.Marshal<Texture>(texture), leftBorder, rightBorder, topBorder, bottomBorder, Object.MarshalledUnityObject.Marshal<Material>(mat));
  }

  public static Texture exposure
  {
    get => Unmarshal.UnmarshalUnityObject<Texture>(Gizmos.get_exposure_Injected());
    set => Gizmos.set_exposure_Injected(Object.MarshalledUnityObject.Marshal<Texture>(value));
  }

  public static float probeSize => Gizmos.get_probeSizeDelegateField();

  public static void DrawFrustum(
    Vector3 center,
    float fov,
    float maxRange,
    float minRange,
    float aspect)
  {
    Gizmos.DrawFrustum_Injected(ref center, fov, maxRange, minRange, aspect);
  }

  public static float CalculateLOD(Vector3 position, float radius)
  {
    return Gizmos.CalculateLOD_Injected(ref position, radius);
  }

  public static void DrawRay(Ray r) => Gizmos.DrawLine(r.origin, r.origin + r.direction);

  public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
  {
    Vector3 one = Vector3.one;
    Gizmos.DrawMesh(mesh, position, rotation, one);
  }

  public static void DrawMesh(Mesh mesh, Vector3 position)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Gizmos.DrawMesh(mesh, position, identity, one);
  }

  public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
  {
    Vector3 one = Vector3.one;
    Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, one);
  }

  public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Gizmos.DrawMesh(mesh, submeshIndex, position, identity, one);
  }

  public static void DrawMesh(Mesh mesh, int submeshIndex)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Vector3 zero = Vector3.zero;
    Gizmos.DrawMesh(mesh, submeshIndex, zero, identity, one);
  }

  public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
  {
    Vector3 one = Vector3.one;
    Gizmos.DrawWireMesh(mesh, position, rotation, one);
  }

  public static void DrawWireMesh(Mesh mesh, Vector3 position)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Gizmos.DrawWireMesh(mesh, position, identity, one);
  }

  public static void DrawWireMesh(Mesh mesh)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Vector3 zero = Vector3.zero;
    Gizmos.DrawWireMesh(mesh, zero, identity, one);
  }

  public static void DrawWireMesh(
    Mesh mesh,
    int submeshIndex,
    Vector3 position,
    Quaternion rotation)
  {
    Vector3 one = Vector3.one;
    Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, one);
  }

  public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Gizmos.DrawWireMesh(mesh, submeshIndex, position, identity, one);
  }

  public static void DrawWireMesh(Mesh mesh, int submeshIndex)
  {
    Vector3 one = Vector3.one;
    Quaternion identity = Quaternion.identity;
    Vector3 zero = Vector3.zero;
    Gizmos.DrawWireMesh(mesh, submeshIndex, zero, identity, one);
  }

  public static void DrawGUITexture(Rect screenRect, Texture texture)
  {
    Material mat = (Material) null;
    Gizmos.DrawGUITexture(screenRect, texture, mat);
  }

  public static void DrawGUITexture(Rect screenRect, Texture texture, Material mat)
  {
    Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
  }

  public static void DrawGUITexture(
    Rect screenRect,
    Texture texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder)
  {
    Material mat = (Material) null;
    Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
  }

  public static void DrawLineStrip_Injected(ref ManagedSpanWrapper points, bool looped)
  {
    Gizmos.DrawLineStrip_InjectedDelegateField((System.IntPtr) ref points, looped);
  }

  public static void DrawLineListInternal_Injected(ref ManagedSpanWrapper points)
  {
    Gizmos.DrawLineListInternal_InjectedDelegateField((System.IntPtr) ref points);
  }

  public static void DrawGUITexture_Injected(
    [In] ref Rect screenRect,
    System.IntPtr texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    System.IntPtr mat)
  {
    Gizmos.DrawGUITexture_InjectedDelegateField((System.IntPtr) ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
  }

  public static void get_matrix_Injected(out Matrix4x4 ret)
  {
    Gizmos.get_matrix_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static System.IntPtr get_exposure_Injected()
  {
    return Gizmos.get_exposure_InjectedDelegateField();
  }

  public static void set_exposure_Injected(System.IntPtr value)
  {
    Gizmos.set_exposure_InjectedDelegateField(value);
  }

  public static void DrawFrustum_Injected(
    [In] ref Vector3 center,
    float fov,
    float maxRange,
    float minRange,
    float aspect)
  {
    Gizmos.DrawFrustum_InjectedDelegateField((System.IntPtr) ref center, fov, maxRange, minRange, aspect);
  }

  public static float CalculateLOD_Injected([In] ref Vector3 position, float radius)
  {
    return Gizmos.CalculateLOD_InjectedDelegateField((System.IntPtr) ref position, radius);
  }

  private delegate float get_probeSizeDelegate();

  private delegate void DrawLineStrip_InjectedDelegate(System.IntPtr points, bool looped);

  private delegate void DrawLineListInternal_InjectedDelegate(System.IntPtr points);

  private delegate void DrawGUITexture_InjectedDelegate(
    [In] System.IntPtr screenRect,
    System.IntPtr texture,
    int leftBorder,
    int rightBorder,
    int topBorder,
    int bottomBorder,
    System.IntPtr mat);

  private delegate void get_matrix_InjectedDelegate([Out] System.IntPtr ret);

  private delegate System.IntPtr get_exposure_InjectedDelegate();

  private delegate void set_exposure_InjectedDelegate(System.IntPtr value);

  private delegate void DrawFrustum_InjectedDelegate(
    [In] System.IntPtr center,
    float fov,
    float maxRange,
    float minRange,
    float aspect);

  private delegate float CalculateLOD_InjectedDelegate([In] System.IntPtr position, float radius);
}
