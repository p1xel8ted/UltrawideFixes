// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatSequencerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Sirenix.OdinInspector;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatSequencerBase(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_combatZone;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontline;
  private static readonly System.IntPtr NativeFieldInfoPtr_backline;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatZoneLeftBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatZoneRightBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatZoneLeftBacklineBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatZoneRightBacklineBorder_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastAgent_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldDecreaseRoleCooldown_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SequenceRunning_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartSequence_Public_Void_CombatZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToFrontline_Public_Void_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToBackline_Public_Void_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddToBackline_Public_Void_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopSequence_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForDefeat_Protected_Abstract_Virtual_New_IEnumerator_CombatZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Abstract_Virtual_New_Void_List_1_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Public_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__25_0_Private_Void_0;

  static CombatSequencerBase()
  {
    Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatSequencerBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr);
    CombatSequencerBase.NativeFieldInfoPtr_combatZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, nameof (combatZone));
    CombatSequencerBase.NativeFieldInfoPtr_frontline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, nameof (frontline));
    CombatSequencerBase.NativeFieldInfoPtr_backline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, nameof (backline));
    CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneLeftBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676905);
    CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneRightBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676906);
    CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneLeftBacklineBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676907);
    CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneRightBacklineBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676908);
    CombatSequencerBase.NativeMethodInfoPtr_get_LastAgent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676909);
    CombatSequencerBase.NativeMethodInfoPtr_get_ShouldDecreaseRoleCooldown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676910);
    CombatSequencerBase.NativeMethodInfoPtr_get_SequenceRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676911);
    CombatSequencerBase.NativeMethodInfoPtr_StartSequence_Public_Void_CombatZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676912);
    CombatSequencerBase.NativeMethodInfoPtr_MoveToFrontline_Public_Void_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676913);
    CombatSequencerBase.NativeMethodInfoPtr_MoveToBackline_Public_Void_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676914);
    CombatSequencerBase.NativeMethodInfoPtr_AddToBackline_Public_Void_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676915);
    CombatSequencerBase.NativeMethodInfoPtr_StopSequence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676916);
    CombatSequencerBase.NativeMethodInfoPtr_WaitForDefeat_Protected_Abstract_Virtual_New_IEnumerator_CombatZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676917);
    CombatSequencerBase.NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Abstract_Virtual_New_Void_List_1_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676918);
    CombatSequencerBase.NativeMethodInfoPtr_GetId_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676919);
    CombatSequencerBase.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676920);
    CombatSequencerBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676921);
    CombatSequencerBase.NativeMethodInfoPtr__Initialize_b__25_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, 100676922);
  }

  public unsafe float CombatZoneLeftBorder
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 127015, RefRangeEnd = 127021, XrefRangeStart = 127014, XrefRangeEnd = 127015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneLeftBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float CombatZoneRightBorder
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 127022, RefRangeEnd = 127027, XrefRangeStart = 127021, XrefRangeEnd = 127022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneRightBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float CombatZoneLeftBacklineBorder
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 127028, RefRangeEnd = 127030, XrefRangeStart = 127027, XrefRangeEnd = 127028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneLeftBacklineBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float CombatZoneRightBacklineBorder
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 127031, RefRangeEnd = 127033, XrefRangeStart = 127030, XrefRangeEnd = 127031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_CombatZoneRightBacklineBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool LastAgent
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127033, XrefRangeEnd = 127039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_LastAgent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ShouldDecreaseRoleCooldown
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 127040, RefRangeEnd = 127041, XrefRangeStart = 127039, XrefRangeEnd = 127040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_ShouldDecreaseRoleCooldown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool SequenceRunning
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 127045, RefRangeEnd = 127046, XrefRangeStart = 127041, XrefRangeEnd = 127045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_get_SequenceRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127096, RefRangeEnd = 127097, XrefRangeStart = 127046, XrefRangeEnd = 127096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartSequence(CombatZone combatZone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatZone)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_StartSequence_Public_Void_CombatZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 127105, RefRangeEnd = 127110, XrefRangeStart = 127097, XrefRangeEnd = 127105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToFrontline(EnemyCombatController enemy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemy)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_MoveToFrontline_Public_Void_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127110, XrefRangeEnd = 127118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToBackline(EnemyCombatController enemy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemy)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_MoveToBackline_Public_Void_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127118, XrefRangeEnd = 127120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddToBackline(EnemyCombatController enemy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemy)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_AddToBackline_Public_Void_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127120, XrefRangeEnd = 127121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopSequence()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_StopSequence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe IEnumerator WaitForDefeat(CombatZone combatZone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatZone)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatSequencerBase.NativeMethodInfoPtr_WaitForDefeat_Protected_Abstract_Virtual_New_IEnumerator_CombatZone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe void VisibleBacklineEnemies(List<EnemyCombatController> result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatSequencerBase.NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Abstract_Virtual_New_Void_List_1_EnemyCombatController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 89593, RefRangeEnd = 89608, XrefRangeStart = 89593, XrefRangeEnd = 89608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Type GetId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_GetId_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127121, XrefRangeEnd = 127159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatSequencerBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127159, XrefRangeEnd = 127169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Initialize_b__25_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.NativeMethodInfoPtr__Initialize_b__25_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CombatZone combatZone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.NativeFieldInfoPtr_combatZone));
      return num == System.IntPtr.Zero ? (CombatZone) null : Il2CppObjectPool.Get<CombatZone>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.NativeFieldInfoPtr_combatZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CombatSequencerBase.Line frontline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.NativeFieldInfoPtr_frontline));
      return num == System.IntPtr.Zero ? (CombatSequencerBase.Line) null : Il2CppObjectPool.Get<CombatSequencerBase.Line>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.NativeFieldInfoPtr_frontline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CombatSequencerBase.Line backline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.NativeFieldInfoPtr_backline));
      return num == System.IntPtr.Zero ? (CombatSequencerBase.Line) null : Il2CppObjectPool.Get<CombatSequencerBase.Line>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.NativeFieldInfoPtr_backline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Line(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_line;
    private static readonly System.IntPtr NativeFieldInfoPtr_availablePools;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineChanged;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_IEnumerable_1_EnemyCombatController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_EnemyCombatController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_EnemyCombatController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateEnemies_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToLine_Public_Void_Line_EnemyCombatController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCount_Public_Int32_EnemyDataType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalCount_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalBudget_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnemy_Public_EnemyCombatController_EnemyDataType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnemy_Public_EnemyCombatController_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Line()
    {
      Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatSequencerBase>.NativeClassPtr, nameof (Line));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr);
      CombatSequencerBase.Line.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, nameof (line));
      CombatSequencerBase.Line.NativeFieldInfoPtr_availablePools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, nameof (availablePools));
      CombatSequencerBase.Line.NativeFieldInfoPtr_LineChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, nameof (LineChanged));
      CombatSequencerBase.Line.NativeMethodInfoPtr_Init_Public_Void_IEnumerable_1_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676923);
      CombatSequencerBase.Line.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676924);
      CombatSequencerBase.Line.NativeMethodInfoPtr_Add_Public_Void_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676925);
      CombatSequencerBase.Line.NativeMethodInfoPtr_Remove_Public_Void_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676926);
      CombatSequencerBase.Line.NativeMethodInfoPtr_ValidateEnemies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676927);
      CombatSequencerBase.Line.NativeMethodInfoPtr_SwitchToLine_Public_Void_Line_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676928);
      CombatSequencerBase.Line.NativeMethodInfoPtr_GetCount_Public_Int32_EnemyDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676929);
      CombatSequencerBase.Line.NativeMethodInfoPtr_GetTotalCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676930);
      CombatSequencerBase.Line.NativeMethodInfoPtr_GetTotalBudget_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676931);
      CombatSequencerBase.Line.NativeMethodInfoPtr_GetEnemy_Public_EnemyCombatController_EnemyDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676932);
      CombatSequencerBase.Line.NativeMethodInfoPtr_GetEnemy_Public_EnemyCombatController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676933);
      CombatSequencerBase.Line.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr, 100676934);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 126777, RefRangeEnd = 126778, XrefRangeStart = 126759, XrefRangeEnd = 126777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init(IEnumerable<EnemyCombatController> enemiesList)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemiesList)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_Init_Public_Void_IEnumerable_1_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126778, XrefRangeEnd = 126781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 126804, RefRangeEnd = 126811, XrefRangeStart = 126781, XrefRangeEnd = 126804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add(EnemyCombatController enemy)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemy)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_Add_Public_Void_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 126820, RefRangeEnd = 126824, XrefRangeStart = 126811, XrefRangeEnd = 126820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(EnemyCombatController enemy)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemy)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_Remove_Public_Void_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 126864, RefRangeEnd = 126873, XrefRangeStart = 126824, XrefRangeEnd = 126864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ValidateEnemies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_ValidateEnemies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126873, XrefRangeEnd = 126876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwitchToLine(
      CombatSequencerBase.Line anotherLine,
      EnemyCombatController enemy)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anotherLine);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemy);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_SwitchToLine_Public_Void_Line_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126876, XrefRangeEnd = 126880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCount(EnemyData.EnemyDataType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &type
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_GetCount_Public_Int32_EnemyDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(16 /*0x10*/)]
    [CachedScanResults(RefRangeStart = 126901, RefRangeEnd = 126917, XrefRangeStart = 126880, XrefRangeEnd = 126901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetTotalCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_GetTotalCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 126945, RefRangeEnd = 126953, XrefRangeStart = 126917, XrefRangeEnd = 126945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetTotalBudget()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_GetTotalBudget_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 126964, RefRangeEnd = 126965, XrefRangeStart = 126953, XrefRangeEnd = 126964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnemyCombatController GetEnemy(EnemyData.EnemyDataType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &type
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_GetEnemy_Public_EnemyCombatController_EnemyDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num3);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 126997, RefRangeEnd = 127001, XrefRangeStart = 126965, XrefRangeEnd = 126997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnemyCombatController GetEnemy(int budget)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &budget
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr_GetEnemy_Public_EnemyCombatController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127001, XrefRangeEnd = 127014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Line()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerBase.Line>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBase.Line.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Dictionary<EnemyData.EnemyDataType, List<EnemyCombatController>> line
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.Line.NativeFieldInfoPtr_line));
        return num == System.IntPtr.Zero ? (Dictionary<EnemyData.EnemyDataType, List<EnemyCombatController>>) null : Il2CppObjectPool.Get<Dictionary<EnemyData.EnemyDataType, List<EnemyCombatController>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.Line.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<EnemyData.EnemyDataType> availablePools
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.Line.NativeFieldInfoPtr_availablePools));
        return num == System.IntPtr.Zero ? (List<EnemyData.EnemyDataType>) null : Il2CppObjectPool.Get<List<EnemyData.EnemyDataType>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.Line.NativeFieldInfoPtr_availablePools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action LineChanged
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.Line.NativeFieldInfoPtr_LineChanged));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBase.Line.NativeFieldInfoPtr_LineChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
