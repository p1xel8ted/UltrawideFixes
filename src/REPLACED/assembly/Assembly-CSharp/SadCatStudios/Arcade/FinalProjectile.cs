// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.FinalProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class FinalProjectile(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_destructionOffset;
  private static readonly IntPtr NativeFieldInfoPtr_destructionPattern;
  private static readonly IntPtr NativeMethodInfoPtr_IsAvailable_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_DestructionPattern_Public_Virtual_Final_New_Il2CppObjectBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_DestructionOffset_Public_Virtual_Final_New_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FinalProjectile()
  {
    Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (FinalProjectile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr);
    FinalProjectile.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, nameof (MoveSpeed));
    FinalProjectile.NativeFieldInfoPtr_destructionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, nameof (destructionOffset));
    FinalProjectile.NativeFieldInfoPtr_destructionPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, nameof (destructionPattern));
    FinalProjectile.NativeMethodInfoPtr_IsAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, 100676491);
    FinalProjectile.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, 100676492);
    FinalProjectile.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, 100676493);
    FinalProjectile.NativeMethodInfoPtr_DestructionPattern_Public_Virtual_Final_New_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, 100676494);
    FinalProjectile.NativeMethodInfoPtr_DestructionOffset_Public_Virtual_Final_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, 100676495);
    FinalProjectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr, 100676496);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123755, XrefRangeEnd = 123758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsAvailable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalProjectile.NativeMethodInfoPtr_IsAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123758, XrefRangeEnd = 123761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalProjectile.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123761, XrefRangeEnd = 123774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalProjectile.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppObjectBase DestructionPattern()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalProjectile.NativeMethodInfoPtr_DestructionPattern_Public_Virtual_Final_New_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe Vector2 DestructionOffset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FinalProjectile.NativeMethodInfoPtr_DestructionOffset_Public_Virtual_Final_New_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123774, XrefRangeEnd = 123781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalProjectile()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalProjectile>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalProjectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2 MoveSpeed
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalProjectile.NativeFieldInfoPtr_MoveSpeed));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalProjectile.NativeFieldInfoPtr_MoveSpeed)) = value;
    }
  }

  public unsafe Vector2 destructionOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalProjectile.NativeFieldInfoPtr_destructionOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalProjectile.NativeFieldInfoPtr_destructionOffset)) = value;
    }
  }

  public unsafe Il2CppObjectBase destructionPattern
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalProjectile.NativeFieldInfoPtr_destructionPattern));
      return num == IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalProjectile.NativeFieldInfoPtr_destructionPattern), IL2CPP.Il2CppObjectBaseToPtr(value));
    }
  }
}
