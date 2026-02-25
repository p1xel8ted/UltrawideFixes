// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIHealthController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class UIHealthController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_healthCellPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_cellCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_cellPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_health;
  private static readonly System.IntPtr NativeFieldInfoPtr_addAnimationTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_drainAnimationTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthCells;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthCellsAnimators;
  private static readonly System.IntPtr NativeFieldInfoPtr_currCell;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastHealthValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastCellCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_Hit;
  private static readonly System.IntPtr NativeFieldInfoPtr_Heal;
  private static readonly System.IntPtr NativeFieldInfoPtr_LowHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_HitAnimName;
  private static readonly System.IntPtr NativeFieldInfoPtr_HealAnimName;
  private static readonly System.IntPtr NativeFieldInfoPtr_LowHealthAnimName;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentAnimation;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetCells_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HitAnimation_Private_UniTask_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HealAnimation_Private_UniTask_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LowHealthAnimation_Private_UniTask_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActualizeHealthSliders_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCell_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAnimation_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrainAnimation_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIHealthController()
  {
    Il2CppClassPointerStore<UIHealthController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIHealthController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr);
    UIHealthController.NativeFieldInfoPtr_healthCellPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (healthCellPrefab));
    UIHealthController.NativeFieldInfoPtr_cellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (cellCount));
    UIHealthController.NativeFieldInfoPtr_cellPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (cellPool));
    UIHealthController.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (health));
    UIHealthController.NativeFieldInfoPtr_addAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (addAnimationTrigger));
    UIHealthController.NativeFieldInfoPtr_drainAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (drainAnimationTrigger));
    UIHealthController.NativeFieldInfoPtr_healthCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (healthCells));
    UIHealthController.NativeFieldInfoPtr_healthCellsAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (healthCellsAnimators));
    UIHealthController.NativeFieldInfoPtr_currCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (currCell));
    UIHealthController.NativeFieldInfoPtr_lastHealthValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (lastHealthValue));
    UIHealthController.NativeFieldInfoPtr_lastCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (lastCellCount));
    UIHealthController.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (Hit));
    UIHealthController.NativeFieldInfoPtr_Heal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (Heal));
    UIHealthController.NativeFieldInfoPtr_LowHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (LowHealth));
    UIHealthController.NativeFieldInfoPtr_HitAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (HitAnimName));
    UIHealthController.NativeFieldInfoPtr_HealAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (HealAnimName));
    UIHealthController.NativeFieldInfoPtr_LowHealthAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (LowHealthAnimName));
    UIHealthController.NativeFieldInfoPtr_currentAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, nameof (currentAnimation));
    UIHealthController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672183);
    UIHealthController.NativeMethodInfoPtr_ResetCells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672184);
    UIHealthController.NativeMethodInfoPtr_HitAnimation_Private_UniTask_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672185);
    UIHealthController.NativeMethodInfoPtr_HealAnimation_Private_UniTask_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672186);
    UIHealthController.NativeMethodInfoPtr_LowHealthAnimation_Private_UniTask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672187);
    UIHealthController.NativeMethodInfoPtr_ActualizeHealthSliders_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672188);
    UIHealthController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672189);
    UIHealthController.NativeMethodInfoPtr_CalculateCell_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672190);
    UIHealthController.NativeMethodInfoPtr_AddAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672191);
    UIHealthController.NativeMethodInfoPtr_DrainAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672192);
    UIHealthController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, 100672193);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99021, XrefRangeEnd = 99047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 99105, RefRangeEnd = 99108, XrefRangeStart = 99047, XrefRangeEnd = 99105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetCells()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_ResetCells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99108, XrefRangeEnd = 99113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask HitAnimation(int lastActiveCell, int activeCell)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lastActiveCell;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeCell;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_HitAnimation_Private_UniTask_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99113, XrefRangeEnd = 99118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask HealAnimation(int lastActiveCell, int activeCell)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lastActiveCell;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeCell;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_HealAnimation_Private_UniTask_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99118, XrefRangeEnd = 99123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask LowHealthAnimation(int activeCell)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &activeCell
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_LowHealthAnimation_Private_UniTask_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 99136, RefRangeEnd = 99139, XrefRangeStart = 99123, XrefRangeEnd = 99136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActualizeHealthSliders(int activeCell)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &activeCell
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_ActualizeHealthSliders_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99139, XrefRangeEnd = 99179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99179, XrefRangeEnd = 99185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateCell()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_CalculateCell_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99185, XrefRangeEnd = 99204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_AddAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99204, XrefRangeEnd = 99223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrainAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr_DrainAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99223, XrefRangeEnd = 99236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIHealthController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHealthController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Slider healthCellPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_healthCellPrefab));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_healthCellPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference cellCount
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_cellCount));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_cellCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference cellPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_cellPool));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_cellPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference health
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_health));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_health), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string addAnimationTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_addAnimationTrigger)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_addAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string drainAnimationTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_drainAnimationTrigger)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_drainAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe List<Slider> healthCells
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_healthCells));
      return num == System.IntPtr.Zero ? (List<Slider>) null : Il2CppObjectPool.Get<List<Slider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_healthCells), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Animator> healthCellsAnimators
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_healthCellsAnimators));
      return num == System.IntPtr.Zero ? (List<Animator>) null : Il2CppObjectPool.Get<List<Animator>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_healthCellsAnimators), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currCell
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_currCell));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_currCell)) = value;
    }
  }

  public unsafe float lastHealthValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_lastHealthValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_lastHealthValue)) = value;
    }
  }

  public unsafe float lastCellCount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_lastCellCount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_lastCellCount)) = value;
    }
  }

  public static unsafe int Hit
  {
    get
    {
      int hit;
      IL2CPP.il2cpp_field_static_get_value(UIHealthController.NativeFieldInfoPtr_Hit, (void*) &hit);
      return hit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIHealthController.NativeFieldInfoPtr_Hit, (void*) &value);
    }
  }

  public static unsafe int Heal
  {
    get
    {
      int heal;
      IL2CPP.il2cpp_field_static_get_value(UIHealthController.NativeFieldInfoPtr_Heal, (void*) &heal);
      return heal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIHealthController.NativeFieldInfoPtr_Heal, (void*) &value);
    }
  }

  public static unsafe int LowHealth
  {
    get
    {
      int lowHealth;
      IL2CPP.il2cpp_field_static_get_value(UIHealthController.NativeFieldInfoPtr_LowHealth, (void*) &lowHealth);
      return lowHealth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIHealthController.NativeFieldInfoPtr_LowHealth, (void*) &value);
    }
  }

  public static unsafe int HitAnimName
  {
    get
    {
      int hitAnimName;
      IL2CPP.il2cpp_field_static_get_value(UIHealthController.NativeFieldInfoPtr_HitAnimName, (void*) &hitAnimName);
      return hitAnimName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIHealthController.NativeFieldInfoPtr_HitAnimName, (void*) &value);
    }
  }

  public static unsafe int HealAnimName
  {
    get
    {
      int healAnimName;
      IL2CPP.il2cpp_field_static_get_value(UIHealthController.NativeFieldInfoPtr_HealAnimName, (void*) &healAnimName);
      return healAnimName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIHealthController.NativeFieldInfoPtr_HealAnimName, (void*) &value);
    }
  }

  public static unsafe int LowHealthAnimName
  {
    get
    {
      int lowHealthAnimName;
      IL2CPP.il2cpp_field_static_get_value(UIHealthController.NativeFieldInfoPtr_LowHealthAnimName, (void*) &lowHealthAnimName);
      return lowHealthAnimName;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIHealthController.NativeFieldInfoPtr_LowHealthAnimName, (void*) &value);
    }
  }

  public Il2CppSystem.Nullable<UniTask> currentAnimation
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_currentAnimation);
      return new Il2CppSystem.Nullable<UniTask>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<UniTask>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController.NativeFieldInfoPtr_currentAnimation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<UniTask>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UIHealthController+<HealAnimation>d__20")]
  public sealed class _HealAnimation_d__20 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastActiveCell;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_activeCell;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__fallback_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _HealAnimation_d__20()
    {
      Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, "<HealAnimation>d__20");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr);
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, "<>1__state");
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, "<>t__builder");
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr_lastActiveCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, nameof (lastActiveCell));
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, "<>4__this");
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr_activeCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, nameof (activeCell));
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, "<i>5__2");
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr__fallback_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, "<fallback>5__3");
      UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, "<>u__1");
      UIHealthController._HealAnimation_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, 100672195);
      UIHealthController._HealAnimation_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr, 100672196);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 98907, RefRangeEnd = 98910, XrefRangeStart = 98845, XrefRangeEnd = 98907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIHealthController._HealAnimation_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIHealthController._HealAnimation_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _HealAnimation_d__20(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _HealAnimation_d__20()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHealthController._HealAnimation_d__20>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int lastActiveCell
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr_lastActiveCell));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr_lastActiveCell)) = value;
      }
    }

    public unsafe UIHealthController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIHealthController) null : Il2CppObjectPool.Get<UIHealthController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int activeCell
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr_activeCell));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr_activeCell)) = value;
      }
    }

    public unsafe int _i_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr__i_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr__i_5__2)) = value;
      }
    }

    public unsafe float _fallback_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr__fallback_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr__fallback_5__3)) = value;
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HealAnimation_d__20.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UIHealthController+<HitAnimation>d__19")]
  public sealed class _HitAnimation_d__19 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastActiveCell;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_activeCell;
    private static readonly System.IntPtr NativeFieldInfoPtr__fallback_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _HitAnimation_d__19()
    {
      Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, "<HitAnimation>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr);
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, "<>1__state");
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, "<>t__builder");
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr_lastActiveCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, nameof (lastActiveCell));
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, "<>4__this");
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr_activeCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, nameof (activeCell));
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr__fallback_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, "<fallback>5__2");
      UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, "<>u__1");
      UIHealthController._HitAnimation_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, 100672197);
      UIHealthController._HitAnimation_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr, 100672198);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 98960, RefRangeEnd = 98963, XrefRangeStart = 98910, XrefRangeEnd = 98960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIHealthController._HitAnimation_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIHealthController._HitAnimation_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _HitAnimation_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _HitAnimation_d__19()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHealthController._HitAnimation_d__19>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int lastActiveCell
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr_lastActiveCell));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr_lastActiveCell)) = value;
      }
    }

    public unsafe UIHealthController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIHealthController) null : Il2CppObjectPool.Get<UIHealthController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int activeCell
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr_activeCell));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr_activeCell)) = value;
      }
    }

    public unsafe float _fallback_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr__fallback_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr__fallback_5__2)) = value;
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._HitAnimation_d__19.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.UIHealthController+<LowHealthAnimation>d__21")]
  public sealed class _LowHealthAnimation_d__21 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_activeCell;
    private static readonly System.IntPtr NativeFieldInfoPtr__rememberedHealth_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__fallback_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LowHealthAnimation_d__21()
    {
      Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHealthController>.NativeClassPtr, "<LowHealthAnimation>d__21");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr);
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, "<>1__state");
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, "<>t__builder");
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, "<>4__this");
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr_activeCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, nameof (activeCell));
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr__rememberedHealth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, "<rememberedHealth>5__2");
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr__fallback_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, "<fallback>5__3");
      UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, "<>u__1");
      UIHealthController._LowHealthAnimation_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, 100672199);
      UIHealthController._LowHealthAnimation_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr, 100672200);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 99018, RefRangeEnd = 99021, XrefRangeStart = 98963, XrefRangeEnd = 99018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIHealthController._LowHealthAnimation_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIHealthController._LowHealthAnimation_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LowHealthAnimation_d__21(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LowHealthAnimation_d__21()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHealthController._LowHealthAnimation_d__21>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIHealthController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIHealthController) null : Il2CppObjectPool.Get<UIHealthController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int activeCell
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr_activeCell));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr_activeCell)) = value;
      }
    }

    public unsafe float _rememberedHealth_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr__rememberedHealth_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr__rememberedHealth_5__2)) = value;
      }
    }

    public unsafe float _fallback_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr__fallback_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr__fallback_5__3)) = value;
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHealthController._LowHealthAnimation_d__21.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }
}
