// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.GunData
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
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Combat;

public class GunData(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_attackData;
  private static readonly IntPtr NativeFieldInfoPtr_gunshotPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_flashEffect;
  private static readonly IntPtr NativeFieldInfoPtr_attackObject;
  private static readonly IntPtr NativeFieldInfoPtr_gunshotPool;
  private static readonly IntPtr NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FlashEffect_Public_get_AssetReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Attack_Public_get_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitPool_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGunshot_Public_ProjectileBase_Vector3_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GunData()
  {
    Il2CppClassPointerStore<GunData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (GunData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunData>.NativeClassPtr);
    GunData.NativeFieldInfoPtr_attackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunData>.NativeClassPtr, nameof (attackData));
    GunData.NativeFieldInfoPtr_gunshotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunData>.NativeClassPtr, nameof (gunshotPrefab));
    GunData.NativeFieldInfoPtr_flashEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunData>.NativeClassPtr, nameof (flashEffect));
    GunData.NativeFieldInfoPtr_attackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunData>.NativeClassPtr, nameof (attackObject));
    GunData.NativeFieldInfoPtr_gunshotPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunData>.NativeClassPtr, nameof (gunshotPool));
    GunData.NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677723);
    GunData.NativeMethodInfoPtr_get_FlashEffect_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677724);
    GunData.NativeMethodInfoPtr_get_Attack_Public_get_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677725);
    GunData.NativeMethodInfoPtr_InitPool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677726);
    GunData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677727);
    GunData.NativeMethodInfoPtr_GetGunshot_Public_ProjectileBase_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677728);
    GunData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunData>.NativeClassPtr, 100677729);
  }

  public unsafe AttackData AttackData
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num3);
    }
  }

  public unsafe AssetReference FlashEffect
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr_get_FlashEffect_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num3);
    }
  }

  public unsafe AttackObject Attack
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 131091, RefRangeEnd = 131094, XrefRangeStart = 131087 /*0x02000F*/, XrefRangeEnd = 131091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr_get_Attack_Public_get_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131094, XrefRangeEnd = 131107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr_InitPool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131122, RefRangeEnd = 131125, XrefRangeStart = 131107, XrefRangeEnd = 131122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProjectileBase GetGunshot(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rot;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr_GetGunshot_Public_ProjectileBase_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ProjectileBase) null : Il2CppObjectPool.Get<ProjectileBase>(num3);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GunData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GunData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AttackData attackData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_attackData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_attackData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PoolableObject gunshotPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_gunshotPrefab));
      return num == IntPtr.Zero ? (PoolableObject) null : Il2CppObjectPool.Get<PoolableObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_gunshotPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference flashEffect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_flashEffect));
      return num == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_flashEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject attackObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_attackObject));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_attackObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool gunshotPool
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_gunshotPool));
      return num == IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunData.NativeFieldInfoPtr_gunshotPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
