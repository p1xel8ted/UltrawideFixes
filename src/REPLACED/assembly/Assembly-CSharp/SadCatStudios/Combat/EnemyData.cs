// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.EnemyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.AI;
using SadCatStudios.Foundation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class EnemyData(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_unarmoredPoiseResist;
  private static readonly System.IntPtr NativeFieldInfoPtr_armoredPoiseResist;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockingdPoiseResist;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackCooldown;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_budgetPrice;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthOffsetRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackWeights;
  private static readonly System.IntPtr NativeFieldInfoPtr_prefferedOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyModifiers;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnarmoredPoiseResist_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArmoredPoiseResist_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BlockingdPoiseResist_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EnemyType_Public_get_EnemyDataType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BudgetPrice_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthOffsetRange_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackCooldown_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackWeights_Public_get_AttackWeigths_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefferedOffset_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnemyData()
  {
    Il2CppClassPointerStore<EnemyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (EnemyData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemyData>.NativeClassPtr);
    EnemyData.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (title));
    EnemyData.NativeFieldInfoPtr_maxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (maxHealth));
    EnemyData.NativeFieldInfoPtr_unarmoredPoiseResist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (unarmoredPoiseResist));
    EnemyData.NativeFieldInfoPtr_armoredPoiseResist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (armoredPoiseResist));
    EnemyData.NativeFieldInfoPtr_blockingdPoiseResist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (blockingdPoiseResist));
    EnemyData.NativeFieldInfoPtr_attackCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (attackCooldown));
    EnemyData.NativeFieldInfoPtr_enemyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (enemyType));
    EnemyData.NativeFieldInfoPtr_budgetPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (budgetPrice));
    EnemyData.NativeFieldInfoPtr_depthOffsetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (depthOffsetRange));
    EnemyData.NativeFieldInfoPtr_attackWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (attackWeights));
    EnemyData.NativeFieldInfoPtr_prefferedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (prefferedOffset));
    EnemyData.NativeFieldInfoPtr_difficultyModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (difficultyModifiers));
    EnemyData.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677704);
    EnemyData.NativeMethodInfoPtr_get_MaxHealth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677705);
    EnemyData.NativeMethodInfoPtr_get_UnarmoredPoiseResist_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677706);
    EnemyData.NativeMethodInfoPtr_get_ArmoredPoiseResist_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677707);
    EnemyData.NativeMethodInfoPtr_get_BlockingdPoiseResist_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677708);
    EnemyData.NativeMethodInfoPtr_get_EnemyType_Public_get_EnemyDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677709);
    EnemyData.NativeMethodInfoPtr_get_BudgetPrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677710);
    EnemyData.NativeMethodInfoPtr_get_DepthOffsetRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677711);
    EnemyData.NativeMethodInfoPtr_get_AttackCooldown_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677712);
    EnemyData.NativeMethodInfoPtr_get_AttackWeights_Public_get_AttackWeigths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677713);
    EnemyData.NativeMethodInfoPtr_get_PrefferedOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677714);
    EnemyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, 100677715);
  }

  public unsafe string Title
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe int MaxHealth
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131076 /*0x020004*/, XrefRangeEnd = 131085 /*0x02000D*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_MaxHealth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int UnarmoredPoiseResist
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_UnarmoredPoiseResist_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int ArmoredPoiseResist
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_ArmoredPoiseResist_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BlockingdPoiseResist
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_BlockingdPoiseResist_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EnemyData.EnemyDataType EnemyType
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16660, RefRangeEnd = 16661, XrefRangeStart = 16660, XrefRangeEnd = 16661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_EnemyType_Public_get_EnemyDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EnemyData.EnemyDataType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BudgetPrice
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_BudgetPrice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float DepthOffsetRange
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131085 /*0x02000D*/, XrefRangeEnd = 131086 /*0x02000E*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_DepthOffsetRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float AttackCooldown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_AttackCooldown_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AttackWeigths AttackWeights
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_AttackWeights_Public_get_AttackWeigths_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AttackWeigths) null : Il2CppObjectPool.Get<AttackWeigths>(num3);
    }
  }

  public unsafe float PrefferedOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr_get_PrefferedOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131086 /*0x02000E*/, XrefRangeEnd = 131087 /*0x02000F*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnemyData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemyData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int maxHealth
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_maxHealth));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_maxHealth)) = value;
    }
  }

  public unsafe int unarmoredPoiseResist
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_unarmoredPoiseResist));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_unarmoredPoiseResist)) = value;
    }
  }

  public unsafe int armoredPoiseResist
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_armoredPoiseResist));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_armoredPoiseResist)) = value;
    }
  }

  public unsafe int blockingdPoiseResist
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_blockingdPoiseResist));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_blockingdPoiseResist)) = value;
    }
  }

  public unsafe float attackCooldown
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_attackCooldown));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_attackCooldown)) = value;
    }
  }

  public unsafe EnemyData.EnemyDataType enemyType
  {
    get
    {
      return *(EnemyData.EnemyDataType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_enemyType));
    }
    [param: In] set
    {
      *(EnemyData.EnemyDataType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_enemyType)) = value;
    }
  }

  public unsafe int budgetPrice
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_budgetPrice));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_budgetPrice)) = value;
    }
  }

  public unsafe Vector2 depthOffsetRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_depthOffsetRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_depthOffsetRange)) = value;
    }
  }

  public unsafe AttackWeigths attackWeights
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_attackWeights));
      return num == System.IntPtr.Zero ? (AttackWeigths) null : Il2CppObjectPool.Get<AttackWeigths>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_attackWeights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float prefferedOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_prefferedOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_prefferedOffset)) = value;
    }
  }

  public unsafe EnemyData.DifficultyDictionary difficultyModifiers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_difficultyModifiers));
      return num == System.IntPtr.Zero ? (EnemyData.DifficultyDictionary) null : Il2CppObjectPool.Get<EnemyData.DifficultyDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.NativeFieldInfoPtr_difficultyModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum EnemyDataType
  {
    None = 1,
    Grunt = 2,
    Fast = 4,
    Tank = 8,
    Shooter = 16, // 0x00000010
    Boss = 32, // 0x00000020
  }

  [Serializable]
  public class DifficultyModifiers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DifficultyModifiers()
    {
      Il2CppClassPointerStore<EnemyData.DifficultyModifiers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (DifficultyModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemyData.DifficultyModifiers>.NativeClassPtr);
      EnemyData.DifficultyModifiers.NativeFieldInfoPtr_HealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyData.DifficultyModifiers>.NativeClassPtr, nameof (HealthModifier));
      EnemyData.DifficultyModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData.DifficultyModifiers>.NativeClassPtr, 100677716);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DifficultyModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemyData.DifficultyModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EnemyData.DifficultyModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int HealthModifier
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.DifficultyModifiers.NativeFieldInfoPtr_HealthModifier));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyData.DifficultyModifiers.NativeFieldInfoPtr_HealthModifier)) = value;
      }
    }
  }

  [Serializable]
  public class DifficultyDictionary(System.IntPtr pointer) : 
    UnitySerializedDictionary<DifficultyLevel, EnemyData.DifficultyModifiers>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DifficultyDictionary()
    {
      Il2CppClassPointerStore<EnemyData.DifficultyDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnemyData>.NativeClassPtr, nameof (DifficultyDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemyData.DifficultyDictionary>.NativeClassPtr);
      EnemyData.DifficultyDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyData.DifficultyDictionary>.NativeClassPtr, 100677717);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131073 /*0x020001*/, XrefRangeEnd = 131076 /*0x020004*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DifficultyDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemyData.DifficultyDictionary>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EnemyData.DifficultyDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
