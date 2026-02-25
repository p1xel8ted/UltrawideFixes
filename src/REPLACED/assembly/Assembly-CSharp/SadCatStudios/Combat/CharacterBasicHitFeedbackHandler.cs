// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterBasicHitFeedbackHandler
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

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterBasicHitFeedbackHandler(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_statsControllers;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterBasicHitFeedbackHandler()
  {
    Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterBasicHitFeedbackHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr);
    CharacterBasicHitFeedbackHandler.NativeFieldInfoPtr_statsControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr, nameof (statsControllers));
    CharacterBasicHitFeedbackHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr, 100677411);
    CharacterBasicHitFeedbackHandler.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr, 100677412);
    CharacterBasicHitFeedbackHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr, 100677413);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129851, XrefRangeEnd = 129854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBasicHitFeedbackHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129854, XrefRangeEnd = 129859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBasicHitFeedbackHandler.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterBasicHitFeedbackHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBasicHitFeedbackHandler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBasicHitFeedbackHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<ICombatStatsController> statsControllers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBasicHitFeedbackHandler.NativeFieldInfoPtr_statsControllers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ICombatStatsController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ICombatStatsController>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBasicHitFeedbackHandler.NativeFieldInfoPtr_statsControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
