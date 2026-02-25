// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.AreaRadiusCaster
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
namespace SadCatStudios.Combat;

public class AreaRadiusCaster(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_castMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_castTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_castBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_CastAttack_Public_Virtual_Final_New_Void_AttackObject_Action_1_HitCastResult_Action_1_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndCast_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AreaRadiusCaster()
  {
    Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (AreaRadiusCaster));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr);
    AreaRadiusCaster.NativeFieldInfoPtr_castMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr, nameof (castMask));
    AreaRadiusCaster.NativeFieldInfoPtr_castTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr, nameof (castTag));
    AreaRadiusCaster.NativeFieldInfoPtr_castBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr, nameof (castBuffer));
    AreaRadiusCaster.NativeMethodInfoPtr_CastAttack_Public_Virtual_Final_New_Void_AttackObject_Action_1_HitCastResult_Action_1_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr, 100677160);
    AreaRadiusCaster.NativeMethodInfoPtr_EndCast_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr, 100677161);
    AreaRadiusCaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr, 100677162);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128439, XrefRangeEnd = 128451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CastAttack(
    AttackObject attack,
    Il2CppSystem.Action<HitCastResult> announceCallback,
    Il2CppSystem.Action<HitCastResult> connectionCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) announceCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaRadiusCaster.NativeMethodInfoPtr_CastAttack_Public_Virtual_Final_New_Void_AttackObject_Action_1_HitCastResult_Action_1_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndCast()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaRadiusCaster.NativeMethodInfoPtr_EndCast_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128451, XrefRangeEnd = 128455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AreaRadiusCaster()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaRadiusCaster>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AreaRadiusCaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask castMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaRadiusCaster.NativeFieldInfoPtr_castMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaRadiusCaster.NativeFieldInfoPtr_castMask)) = value;
    }
  }

  public unsafe string castTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaRadiusCaster.NativeFieldInfoPtr_castTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaRadiusCaster.NativeFieldInfoPtr_castTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> castBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaRadiusCaster.NativeFieldInfoPtr_castBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaRadiusCaster.NativeFieldInfoPtr_castBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
