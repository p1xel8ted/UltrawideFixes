// Decompiled with JetBrains decompiler
// Type: MeshToParticleScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class MeshToParticleScaler(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_meshTransform;
  private static readonly IntPtr NativeFieldInfoPtr_particleSystem;
  private static readonly IntPtr NativeFieldInfoPtr_smoothSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_minScaleX;
  private static readonly IntPtr NativeFieldInfoPtr_maxScaleX;
  private static readonly IntPtr NativeFieldInfoPtr_minScaleY;
  private static readonly IntPtr NativeFieldInfoPtr_maxScaleY;
  private static readonly IntPtr NativeFieldInfoPtr_minScaleZ;
  private static readonly IntPtr NativeFieldInfoPtr_maxScaleZ;
  private static readonly IntPtr NativeFieldInfoPtr_scaleX;
  private static readonly IntPtr NativeFieldInfoPtr_scaleY;
  private static readonly IntPtr NativeFieldInfoPtr_scaleZ;
  private static readonly IntPtr NativeFieldInfoPtr_targetScale;
  private static readonly IntPtr NativeFieldInfoPtr_mainCamera;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshToParticleScaler()
  {
    Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MeshToParticleScaler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr);
    MeshToParticleScaler.NativeFieldInfoPtr_meshTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (meshTransform));
    MeshToParticleScaler.NativeFieldInfoPtr_particleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (particleSystem));
    MeshToParticleScaler.NativeFieldInfoPtr_smoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (smoothSpeed));
    MeshToParticleScaler.NativeFieldInfoPtr_minScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (minScaleX));
    MeshToParticleScaler.NativeFieldInfoPtr_maxScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (maxScaleX));
    MeshToParticleScaler.NativeFieldInfoPtr_minScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (minScaleY));
    MeshToParticleScaler.NativeFieldInfoPtr_maxScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (maxScaleY));
    MeshToParticleScaler.NativeFieldInfoPtr_minScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (minScaleZ));
    MeshToParticleScaler.NativeFieldInfoPtr_maxScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (maxScaleZ));
    MeshToParticleScaler.NativeFieldInfoPtr_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (scaleX));
    MeshToParticleScaler.NativeFieldInfoPtr_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (scaleY));
    MeshToParticleScaler.NativeFieldInfoPtr_scaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (scaleZ));
    MeshToParticleScaler.NativeFieldInfoPtr_targetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (targetScale));
    MeshToParticleScaler.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, nameof (mainCamera));
    MeshToParticleScaler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, 100663793);
    MeshToParticleScaler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, 100663794);
    MeshToParticleScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr, 100663795);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23037, XrefRangeEnd = 23038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshToParticleScaler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23038, XrefRangeEnd = 23068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshToParticleScaler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23068, XrefRangeEnd = 23069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshToParticleScaler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshToParticleScaler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshToParticleScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform meshTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_meshTransform));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_meshTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem particleSystem
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_particleSystem));
      return num == IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_particleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float smoothSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_smoothSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_smoothSpeed)) = value;
    }
  }

  public unsafe float minScaleX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_minScaleX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_minScaleX)) = value;
    }
  }

  public unsafe float maxScaleX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_maxScaleX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_maxScaleX)) = value;
    }
  }

  public unsafe float minScaleY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_minScaleY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_minScaleY)) = value;
    }
  }

  public unsafe float maxScaleY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_maxScaleY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_maxScaleY)) = value;
    }
  }

  public unsafe float minScaleZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_minScaleZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_minScaleZ)) = value;
    }
  }

  public unsafe float maxScaleZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_maxScaleZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_maxScaleZ)) = value;
    }
  }

  public unsafe bool scaleX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_scaleX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_scaleX)) = value;
    }
  }

  public unsafe bool scaleY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_scaleY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_scaleY)) = value;
    }
  }

  public unsafe bool scaleZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_scaleZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_scaleZ)) = value;
    }
  }

  public unsafe Vector3 targetScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_targetScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_targetScale)) = value;
    }
  }

  public unsafe Camera mainCamera
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_mainCamera));
      return num == IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshToParticleScaler.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
