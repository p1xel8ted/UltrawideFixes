// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterAttackReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterAttackReceiver(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_connectWithoutAnnounce;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitHandlers;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveAttack_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnnounceConnected_Public_Virtual_Final_New_Boolean_IHitReceiver_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAttackReceiver()
  {
    Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterAttackReceiver));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr);
    CharacterAttackReceiver.NativeFieldInfoPtr_connectWithoutAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr, nameof (connectWithoutAnnounce));
    CharacterAttackReceiver.NativeFieldInfoPtr_hitHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr, nameof (hitHandlers));
    CharacterAttackReceiver.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr, 100677210);
    CharacterAttackReceiver.NativeMethodInfoPtr_ReceiveAttack_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr, 100677211);
    CharacterAttackReceiver.NativeMethodInfoPtr_AnnounceConnected_Public_Virtual_Final_New_Boolean_IHitReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr, 100677212);
    CharacterAttackReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr, 100677213);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128762, XrefRangeEnd = 128873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackReceiver.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128901, RefRangeEnd = 128902, XrefRangeStart = 128873, XrefRangeEnd = 128901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReceiveAttack(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackReceiver.NativeMethodInfoPtr_ReceiveAttack_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool AnnounceConnected(IHitReceiver receiver)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiver)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackReceiver.NativeMethodInfoPtr_AnnounceConnected_Public_Virtual_Final_New_Boolean_IHitReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128902, XrefRangeEnd = 128909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAttackReceiver()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAttackReceiver>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool connectWithoutAnnounce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackReceiver.NativeFieldInfoPtr_connectWithoutAnnounce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackReceiver.NativeFieldInfoPtr_connectWithoutAnnounce)) = value;
    }
  }

  public unsafe Queue<Il2CppSystem.ValueTuple<IHitReceiveHandler, bool>> hitHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackReceiver.NativeFieldInfoPtr_hitHandlers));
      return num == System.IntPtr.Zero ? (Queue<Il2CppSystem.ValueTuple<IHitReceiveHandler, bool>>) null : Il2CppObjectPool.Get<Queue<Il2CppSystem.ValueTuple<IHitReceiveHandler, bool>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackReceiver.NativeFieldInfoPtr_hitHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
