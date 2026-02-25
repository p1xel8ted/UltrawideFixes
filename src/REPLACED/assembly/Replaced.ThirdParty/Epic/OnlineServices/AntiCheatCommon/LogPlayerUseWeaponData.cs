// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerUseWeaponData
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class LogPlayerUseWeaponData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPosition_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerViewRotation_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsMeleeAttack_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__WeaponName_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WeaponName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_WeaponName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LogPlayerUseWeaponDataInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogPlayerUseWeaponData()
  {
    Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerUseWeaponData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr);
    LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, "<PlayerHandle>k__BackingField");
    LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, "<PlayerPosition>k__BackingField");
    LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, "<PlayerViewRotation>k__BackingField");
    LogPlayerUseWeaponData.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, "<IsPlayerViewZoomed>k__BackingField");
    LogPlayerUseWeaponData.NativeFieldInfoPtr__IsMeleeAttack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, "<IsMeleeAttack>k__BackingField");
    LogPlayerUseWeaponData.NativeFieldInfoPtr__WeaponName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, "<WeaponName>k__BackingField");
    LogPlayerUseWeaponData.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672831);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672832);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672833);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672834);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672835);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672836);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672837);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672838);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672839);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672840);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_get_WeaponName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672841);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_set_WeaponName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672842);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LogPlayerUseWeaponDataInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672843);
    LogPlayerUseWeaponData.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672844);
    LogPlayerUseWeaponData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr, 100672845);
  }

  public unsafe System.IntPtr PlayerHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f PlayerPosition
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat PlayerViewRotation
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsPlayerViewZoomed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsMeleeAttack
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string WeaponName
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_get_WeaponName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_set_WeaponName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400650, RefRangeEnd = 400651, XrefRangeStart = 400612, XrefRangeEnd = 400650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<LogPlayerUseWeaponDataInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LogPlayerUseWeaponDataInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400651, XrefRangeEnd = 400656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogPlayerUseWeaponData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogPlayerUseWeaponData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _PlayerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerHandle_k__BackingField)) = value;
    }
  }

  public unsafe Vec3f _PlayerPosition_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerPosition_k__BackingField));
      return num == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Quat _PlayerViewRotation_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField));
      return num == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsPlayerViewZoomed_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField)) = value;
    }
  }

  public unsafe bool _IsMeleeAttack_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__IsMeleeAttack_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__IsMeleeAttack_k__BackingField)) = value;
    }
  }

  public unsafe string _WeaponName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__WeaponName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponData.NativeFieldInfoPtr__WeaponName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
