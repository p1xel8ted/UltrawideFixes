// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.FallMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.MovementPhysics;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Character;

public sealed class FallMovement : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_moveUnit;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuidReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0;

  static FallMovement()
  {
    Il2CppClassPointerStore<FallMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (FallMovement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallMovement>.NativeClassPtr);
    FallMovement.NativeFieldInfoPtr_moveUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallMovement>.NativeClassPtr, nameof (moveUnit));
    FallMovement.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallMovement>.NativeClassPtr, nameof (walkController));
    FallMovement.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallMovement>.NativeClassPtr, nameof (personPhysics));
    FallMovement.NativeMethodInfoPtr__ctor_Public_Void_GuidReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallMovement>.NativeClassPtr, 100674967);
    FallMovement.NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallMovement>.NativeClassPtr, 100674968);
    FallMovement.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallMovement>.NativeClassPtr, 100674969);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114416, XrefRangeEnd = 114423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FallMovement(GuidReference actor)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallMovement>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actor)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallMovement.NativeMethodInfoPtr__ctor_Public_Void_GuidReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool IsAtPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FallMovement.NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114423, XrefRangeEnd = 114424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Move()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FallMovement.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public FallMovement(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public FallMovement()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallMovement>.NativeClassPtr))
  {
  }

  public unsafe MoveUnit moveUnit
  {
    get
    {
      return *(MoveUnit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallMovement.NativeFieldInfoPtr_moveUnit));
    }
    [param: In] set
    {
      *(MoveUnit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallMovement.NativeFieldInfoPtr_moveUnit)) = value;
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallMovement.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FallMovement.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FallMovement.NativeFieldInfoPtr_personPhysics));
      return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FallMovement.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
