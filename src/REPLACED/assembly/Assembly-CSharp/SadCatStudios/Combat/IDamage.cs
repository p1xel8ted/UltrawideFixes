// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Effects;
using SadCatStudios.FSM;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class IDamage(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Abstract_Virtual_New_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHealthDamage_Public_Abstract_Virtual_New_Single_EnemyDataType_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetArmorDamage_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPoiseDamage_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHealthRecovery_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPoiseResistance_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPushDistance_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetManaGenerate_Public_Abstract_Virtual_New_Single_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetManaSpend_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOverdriveGenerate_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetInvinsibilityDuration_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMagnetDistance_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAttackRange_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAttackCooldown_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetStunDuration_Public_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAttackType_Public_Abstract_Virtual_New_AttackType_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_AttackProperties_0;
  private static readonly IntPtr NativeMethodInfoPtr_InvokeLaunchImpactEvents_Public_Abstract_Virtual_New_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr_InvokeHitImpactEvents_Public_Abstract_Virtual_New_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetBlockedGraph_Public_Abstract_Virtual_New_FSMGraph_0;

  static IDamage()
  {
    Il2CppClassPointerStore<IDamage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IDamage));
    IDamage.NativeMethodInfoPtr_GetId_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677620);
    IDamage.NativeMethodInfoPtr_GetHealthDamage_Public_Abstract_Virtual_New_Single_EnemyDataType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677621);
    IDamage.NativeMethodInfoPtr_GetArmorDamage_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677622);
    IDamage.NativeMethodInfoPtr_GetPoiseDamage_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677623);
    IDamage.NativeMethodInfoPtr_GetHealthRecovery_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677624);
    IDamage.NativeMethodInfoPtr_GetPoiseResistance_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677625);
    IDamage.NativeMethodInfoPtr_GetPushDistance_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677626);
    IDamage.NativeMethodInfoPtr_GetManaGenerate_Public_Abstract_Virtual_New_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677627);
    IDamage.NativeMethodInfoPtr_GetManaSpend_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677628);
    IDamage.NativeMethodInfoPtr_GetOverdriveGenerate_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677629);
    IDamage.NativeMethodInfoPtr_GetInvinsibilityDuration_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677630);
    IDamage.NativeMethodInfoPtr_GetMagnetDistance_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677631);
    IDamage.NativeMethodInfoPtr_GetAttackRange_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677632 /*0x06003800*/);
    IDamage.NativeMethodInfoPtr_GetAttackCooldown_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677633);
    IDamage.NativeMethodInfoPtr_GetStunDuration_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677634);
    IDamage.NativeMethodInfoPtr_GetAttackType_Public_Abstract_Virtual_New_AttackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677635);
    IDamage.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_AttackProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677636);
    IDamage.NativeMethodInfoPtr_InvokeLaunchImpactEvents_Public_Abstract_Virtual_New_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677637);
    IDamage.NativeMethodInfoPtr_InvokeHitImpactEvents_Public_Abstract_Virtual_New_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677638);
    IDamage.NativeMethodInfoPtr_GetBlockedGraph_Public_Abstract_Virtual_New_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamage>.NativeClassPtr, 100677639);
  }

  [CallerCount(0)]
  public virtual unsafe string GetId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetId_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetHealthDamage(EnemyData.EnemyDataType enemyType = EnemyData.EnemyDataType.Grunt, bool isPerfect = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &enemyType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &isPerfect;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetHealthDamage_Public_Abstract_Virtual_New_Single_EnemyDataType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetArmorDamage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetArmorDamage_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetPoiseDamage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetPoiseDamage_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetHealthRecovery()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetHealthRecovery_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetPoiseResistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetPoiseResistance_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetPushDistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetPushDistance_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetManaGenerate(bool isPerfect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isPerfect
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetManaGenerate_Public_Abstract_Virtual_New_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetManaSpend()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetManaSpend_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetOverdriveGenerate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetOverdriveGenerate_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetInvinsibilityDuration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetInvinsibilityDuration_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetMagnetDistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetMagnetDistance_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetAttackRange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetAttackRange_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetAttackCooldown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetAttackCooldown_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe float GetStunDuration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetStunDuration_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe AttackType GetAttackType()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetAttackType_Public_Abstract_Virtual_New_AttackType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AttackType*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe AttackProperties GetAttributes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_AttackProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AttackProperties*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void InvokeLaunchImpactEvents(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_InvokeLaunchImpactEvents_Public_Abstract_Virtual_New_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void InvokeHitImpactEvents(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_InvokeHitImpactEvents_Public_Abstract_Virtual_New_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe FSMGraph GetBlockedGraph()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDamage.NativeMethodInfoPtr_GetBlockedGraph_Public_Abstract_Virtual_New_FSMGraph_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
  }
}
