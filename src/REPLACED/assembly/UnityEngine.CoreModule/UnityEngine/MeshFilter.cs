// Decompiled with JetBrains decompiler
// Type: UnityEngine.MeshFilter
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public sealed class MeshFilter(IntPtr pointer) : Component(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Injected_Private_Static_Void_IntPtr_IntPtr_0;

  static MeshFilter()
  {
    Il2CppClassPointerStore<MeshFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (MeshFilter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr);
    MeshFilter.NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666009);
    MeshFilter.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666010);
    MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666011);
    MeshFilter.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666012);
    MeshFilter.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666013);
    MeshFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666014);
    MeshFilter.NativeMethodInfoPtr_get_sharedMesh_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666015);
    MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666016 /*0x06000AA0*/);
    MeshFilter.NativeMethodInfoPtr_get_mesh_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666017);
    MeshFilter.NativeMethodInfoPtr_set_mesh_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100666018);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DontStripMeshFilter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Mesh sharedMesh
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 431145, RefRangeEnd = 431152, XrefRangeStart = 431137, XrefRangeEnd = 431145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Mesh) null : Il2CppObjectPool.Get<Mesh>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 431160, RefRangeEnd = 431168, XrefRangeStart = 431152, XrefRangeEnd = 431160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Mesh mesh
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431168, XrefRangeEnd = 431176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Mesh) null : Il2CppObjectPool.Get<Mesh>(num3);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 431184, RefRangeEnd = 431188, XrefRangeStart = 431176, XrefRangeEnd = 431184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshFilter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431188, XrefRangeEnd = 431190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_sharedMesh_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_get_sharedMesh_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431190, XrefRangeEnd = 431192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431192, XrefRangeEnd = 431194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_mesh_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_get_mesh_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431194, XrefRangeEnd = 431196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_mesh_Injected(IntPtr _unity_self, IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_mesh_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
