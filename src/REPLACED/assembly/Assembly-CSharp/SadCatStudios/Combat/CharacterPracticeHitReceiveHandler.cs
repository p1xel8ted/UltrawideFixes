// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterPracticeHitReceiveHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterPracticeHitReceiveHandler(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_hitEffect;
  private static readonly IntPtr NativeFieldInfoPtr_hitEffectPerfect;
  private static readonly IntPtr NativeFieldInfoPtr_projectileHitEffect;
  private static readonly IntPtr NativeFieldInfoPtr_projectileHitOffset;
  private static readonly IntPtr NativeFieldInfoPtr_projectileHitRotationFromRight;
  private static readonly IntPtr NativeFieldInfoPtr_projectileHitRotationFromLeft;
  private static readonly IntPtr NativeFieldInfoPtr_statsControllers;
  private static readonly IntPtr NativeFieldInfoPtr_invincibilityHandlers;
  private static readonly IntPtr NativeFieldInfoPtr_boundariesController;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterPracticeHitReceiveHandler()
  {
    Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterPracticeHitReceiveHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr);
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_hitEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (hitEffect));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_hitEffectPerfect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (hitEffectPerfect));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (projectileHitEffect));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (projectileHitOffset));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitRotationFromRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (projectileHitRotationFromRight));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitRotationFromLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (projectileHitRotationFromLeft));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_statsControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (statsControllers));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_invincibilityHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (invincibilityHandlers));
    CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_boundariesController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, nameof (boundariesController));
    CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, 100677580);
    CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, 100677581);
    CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, 100677582);
    CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr, 100677583);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130710, XrefRangeEnd = 130719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130719, XrefRangeEnd = 130750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterPracticeHitReceiveHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPracticeHitReceiveHandler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPracticeHitReceiveHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AssetReference hitEffect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_hitEffect));
      return num == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_hitEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference hitEffectPerfect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_hitEffectPerfect));
      return num == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_hitEffectPerfect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference projectileHitEffect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitEffect));
      return num == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 projectileHitOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitOffset)) = value;
    }
  }

  public unsafe Vector3 projectileHitRotationFromRight
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitRotationFromRight));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitRotationFromRight)) = value;
    }
  }

  public unsafe Vector3 projectileHitRotationFromLeft
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitRotationFromLeft));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_projectileHitRotationFromLeft)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<ICombatStatsController> statsControllers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_statsControllers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ICombatStatsController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ICombatStatsController>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_statsControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IInvincibilityHandler> invincibilityHandlers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_invincibilityHandlers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<IInvincibilityHandler>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IInvincibilityHandler>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_invincibilityHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterBoundariesController boundariesController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_boundariesController));
      return num == IntPtr.Zero ? (CharacterBoundariesController) null : Il2CppObjectPool.Get<CharacterBoundariesController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPracticeHitReceiveHandler.NativeFieldInfoPtr_boundariesController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
