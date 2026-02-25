// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.InvadersProjectile
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

public class InvadersProjectile(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_destructionOffset;
  private static readonly IntPtr NativeFieldInfoPtr_destructionPattern;
  private static readonly IntPtr NativeMethodInfoPtr_IsAvailable_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_DestructionPattern_Public_Virtual_Final_New_Il2CppObjectBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_DestructionOffset_Public_Virtual_Final_New_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvadersProjectile()
  {
    Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (InvadersProjectile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr);
    InvadersProjectile.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, nameof (moveSpeed));
    InvadersProjectile.NativeFieldInfoPtr_destructionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, nameof (destructionOffset));
    InvadersProjectile.NativeFieldInfoPtr_destructionPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, nameof (destructionPattern));
    InvadersProjectile.NativeMethodInfoPtr_IsAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, 100676634);
    InvadersProjectile.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, 100676635);
    InvadersProjectile.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, 100676636);
    InvadersProjectile.NativeMethodInfoPtr_DestructionPattern_Public_Virtual_Final_New_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, 100676637);
    InvadersProjectile.NativeMethodInfoPtr_DestructionOffset_Public_Virtual_Final_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, 100676638);
    InvadersProjectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr, 100676639);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124927, XrefRangeEnd = 124930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsAvailable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersProjectile.NativeMethodInfoPtr_IsAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersProjectile.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124930, XrefRangeEnd = 124943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersProjectile.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppObjectBase DestructionPattern()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersProjectile.NativeMethodInfoPtr_DestructionPattern_Public_Virtual_Final_New_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersProjectile.NativeMethodInfoPtr_DestructionOffset_Public_Virtual_Final_New_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124943, XrefRangeEnd = 124950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvadersProjectile()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersProjectile>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersProjectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2 moveSpeed
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersProjectile.NativeFieldInfoPtr_moveSpeed));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersProjectile.NativeFieldInfoPtr_moveSpeed)) = value;
    }
  }

  public unsafe Vector2 destructionOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersProjectile.NativeFieldInfoPtr_destructionOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersProjectile.NativeFieldInfoPtr_destructionOffset)) = value;
    }
  }

  public unsafe Il2CppObjectBase destructionPattern
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersProjectile.NativeFieldInfoPtr_destructionPattern));
      return num == IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersProjectile.NativeFieldInfoPtr_destructionPattern), IL2CPP.Il2CppObjectBaseToPtr(value));
    }
  }
}
