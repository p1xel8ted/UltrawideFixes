// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterGunFinisherCaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterGunFinisherCaster(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_castBackOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_castSphereRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_castDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_obscureMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_IGunFinisherSender_Action_1_FinisherCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterGunFinisherCaster()
  {
    Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterGunFinisherCaster));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr);
    CharacterGunFinisherCaster.NativeFieldInfoPtr_castBackOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (castBackOffset));
    CharacterGunFinisherCaster.NativeFieldInfoPtr_castSphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (castSphereRadius));
    CharacterGunFinisherCaster.NativeFieldInfoPtr_castDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (castDistance));
    CharacterGunFinisherCaster.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (layerMask));
    CharacterGunFinisherCaster.NativeFieldInfoPtr_obscureMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (obscureMask));
    CharacterGunFinisherCaster.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (rotationController));
    CharacterGunFinisherCaster.NativeFieldInfoPtr_overlapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, nameof (overlapBuffer));
    CharacterGunFinisherCaster.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, 100677170);
    CharacterGunFinisherCaster.NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_IGunFinisherSender_Action_1_FinisherCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, 100677171);
    CharacterGunFinisherCaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr, 100677172);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128510, XrefRangeEnd = 128513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherCaster.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128513, XrefRangeEnd = 128536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CastGrab(
    IGunFinisherSender finisherSender,
    Il2CppSystem.Action<FinisherCastResult> successCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finisherSender);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) successCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherCaster.NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_IGunFinisherSender_Action_1_FinisherCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128536, XrefRangeEnd = 128540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterGunFinisherCaster()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGunFinisherCaster>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherCaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float castBackOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_castBackOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_castBackOffset)) = value;
    }
  }

  public unsafe float castSphereRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_castSphereRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_castSphereRadius)) = value;
    }
  }

  public unsafe float castDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_castDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_castDistance)) = value;
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe LayerMask obscureMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_obscureMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_obscureMask)) = value;
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_overlapBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherCaster.NativeFieldInfoPtr_overlapBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
