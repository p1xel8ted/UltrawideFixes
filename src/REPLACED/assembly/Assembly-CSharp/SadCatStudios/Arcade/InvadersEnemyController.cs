// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.InvadersEnemyController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class InvadersEnemyController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_sprites;
  private static readonly IntPtr NativeFieldInfoPtr_score;
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_deathSound;
  private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;
  private static readonly IntPtr NativeFieldInfoPtr_formationRow;
  private static readonly IntPtr NativeFieldInfoPtr_isLeadingFormation;
  private static readonly IntPtr NativeFieldInfoPtr_originPos;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_InvadersRow_Int32_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetAsFormationLeader_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NextSprite_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvadersEnemyController()
  {
    Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (InvadersEnemyController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr);
    InvadersEnemyController.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (sprites));
    InvadersEnemyController.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (score));
    InvadersEnemyController.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (spriteRenderer));
    InvadersEnemyController.NativeFieldInfoPtr_deathSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (deathSound));
    InvadersEnemyController.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (spriteIndex));
    InvadersEnemyController.NativeFieldInfoPtr_formationRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (formationRow));
    InvadersEnemyController.NativeFieldInfoPtr_isLeadingFormation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (isLeadingFormation));
    InvadersEnemyController.NativeFieldInfoPtr_originPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, nameof (originPos));
    InvadersEnemyController.NativeMethodInfoPtr_Init_Public_Void_InvadersRow_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676586);
    InvadersEnemyController.NativeMethodInfoPtr_Respawn_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676587);
    InvadersEnemyController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676588);
    InvadersEnemyController.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676589);
    InvadersEnemyController.NativeMethodInfoPtr_SetSprite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676590);
    InvadersEnemyController.NativeMethodInfoPtr_SetAsFormationLeader_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676591);
    InvadersEnemyController.NativeMethodInfoPtr_Move_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676592);
    InvadersEnemyController.NativeMethodInfoPtr_Shoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676593);
    InvadersEnemyController.NativeMethodInfoPtr_NextSprite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676594);
    InvadersEnemyController.NativeMethodInfoPtr_Kill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676595);
    InvadersEnemyController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr, 100676596);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124524, XrefRangeEnd = 124526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(InvadersRow formationRow, int spriteIndex, bool isLeadingFormation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formationRow);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &spriteIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &isLeadingFormation;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_Init_Public_Void_InvadersRow_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124526, XrefRangeEnd = 124531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Respawn(float verticalOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &verticalOffset
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_Respawn_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124531, XrefRangeEnd = 124534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124534, XrefRangeEnd = 124539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124539, XrefRangeEnd = 124542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_SetSprite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetAsFormationLeader()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_SetAsFormationLeader_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124542, XrefRangeEnd = 124545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Move(Vector3 delta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &delta
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_Move_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124545, XrefRangeEnd = 124549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shoot()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_Shoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124549, XrefRangeEnd = 124552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_NextSprite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124584, RefRangeEnd = 124585, XrefRangeStart = 124552, XrefRangeEnd = 124584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Kill()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr_Kill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvadersEnemyController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersEnemyController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersEnemyController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Sprite> sprites
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_sprites));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int score
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_score));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_score)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_spriteRenderer));
      return num == IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference deathSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_deathSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_deathSound)) = value;
    }
  }

  public unsafe int spriteIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_spriteIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_spriteIndex)) = value;
    }
  }

  public unsafe InvadersRow formationRow
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_formationRow));
      return num == IntPtr.Zero ? (InvadersRow) null : Il2CppObjectPool.Get<InvadersRow>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_formationRow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isLeadingFormation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_isLeadingFormation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_isLeadingFormation)) = value;
    }
  }

  public unsafe Vector3 originPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_originPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersEnemyController.NativeFieldInfoPtr_originPos)) = value;
    }
  }
}
