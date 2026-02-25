// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.VFXSurfaceCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Effects;

public class VFXSurfaceCollection(IntPtr pointer) : SerializedScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_useCharacterRotation;
  private static readonly IntPtr NativeFieldInfoPtr_rotationAxis;
  private static readonly IntPtr NativeFieldInfoPtr_vfxDictionary;
  private static readonly IntPtr NativeMethodInfoPtr_VFX_Public_AssetReferenceGameObject_PhysicsMaterial_0;
  private static readonly IntPtr NativeMethodInfoPtr_VFXRotation_Public_Void_byref_Quaternion_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VFXSurfaceCollection()
  {
    Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (VFXSurfaceCollection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr);
    VFXSurfaceCollection.NativeFieldInfoPtr_useCharacterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr, nameof (useCharacterRotation));
    VFXSurfaceCollection.NativeFieldInfoPtr_rotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr, nameof (rotationAxis));
    VFXSurfaceCollection.NativeFieldInfoPtr_vfxDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr, nameof (vfxDictionary));
    VFXSurfaceCollection.NativeMethodInfoPtr_VFX_Public_AssetReferenceGameObject_PhysicsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr, 100675729);
    VFXSurfaceCollection.NativeMethodInfoPtr_VFXRotation_Public_Void_byref_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr, 100675730);
    VFXSurfaceCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr, 100675731);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 119125, RefRangeEnd = 119129, XrefRangeStart = 119121, XrefRangeEnd = 119125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AssetReferenceGameObject VFX(PhysicsMaterial physicMaterial)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicMaterial)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXSurfaceCollection.NativeMethodInfoPtr_VFX_Public_AssetReferenceGameObject_PhysicsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AssetReferenceGameObject) null : Il2CppObjectPool.Get<AssetReferenceGameObject>(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 119131, RefRangeEnd = 119135, XrefRangeStart = 119129, XrefRangeEnd = 119131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VFXRotation(ref Quaternion rotation, int direction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) ref rotation;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &direction;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VFXSurfaceCollection.NativeMethodInfoPtr_VFXRotation_Public_Void_byref_Quaternion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119135, XrefRangeEnd = 119136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VFXSurfaceCollection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSurfaceCollection>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VFXSurfaceCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool useCharacterRotation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSurfaceCollection.NativeFieldInfoPtr_useCharacterRotation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSurfaceCollection.NativeFieldInfoPtr_useCharacterRotation)) = value;
    }
  }

  public unsafe Vector3 rotationAxis
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSurfaceCollection.NativeFieldInfoPtr_rotationAxis));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSurfaceCollection.NativeFieldInfoPtr_rotationAxis)) = value;
    }
  }

  public unsafe VFXDictionary vfxDictionary
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSurfaceCollection.NativeFieldInfoPtr_vfxDictionary));
      return num == IntPtr.Zero ? (VFXDictionary) null : Il2CppObjectPool.Get<VFXDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXSurfaceCollection.NativeFieldInfoPtr_vfxDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
