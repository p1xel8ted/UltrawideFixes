// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerUseWeaponDataInternal
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

[StructLayout(LayoutKind.Explicit)]
public struct LogPlayerUseWeaponDataInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerViewRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsPlayerViewZoomed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsMeleeAttack;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WeaponName;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogPlayerUseWeaponData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public System.IntPtr m_PlayerHandle;
  [FieldOffset(8)]
  public System.IntPtr m_PlayerPosition;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_PlayerViewRotation;
  [FieldOffset(24)]
  public int m_IsPlayerViewZoomed;
  [FieldOffset(28)]
  public int m_IsMeleeAttack;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_WeaponName;

  static LogPlayerUseWeaponDataInternal()
  {
    Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerUseWeaponDataInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr);
    LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_PlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_PlayerHandle));
    LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_PlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_PlayerPosition));
    LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_PlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_PlayerViewRotation));
    LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_IsPlayerViewZoomed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_IsPlayerViewZoomed));
    LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_IsMeleeAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_IsMeleeAttack));
    LogPlayerUseWeaponDataInternal.NativeFieldInfoPtr_m_WeaponName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, nameof (m_WeaponName));
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672846);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672847);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672848);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672849);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672850);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672851);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672852);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672853);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672854);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672855);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_WeaponName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672856);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_WeaponName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672857);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672858);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672859);
    LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, 100672860);
  }

  public unsafe System.IntPtr PlayerHandle
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f PlayerPosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400656, XrefRangeEnd = 400662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400668, RefRangeEnd = 400669, XrefRangeStart = 400662, XrefRangeEnd = 400668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat PlayerViewRotation
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400669, XrefRangeEnd = 400675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400681, RefRangeEnd = 400682, XrefRangeStart = 400675, XrefRangeEnd = 400681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsPlayerViewZoomed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400682, XrefRangeEnd = 400686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400686, XrefRangeEnd = 400690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsMeleeAttack
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400690, XrefRangeEnd = 400694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_IsMeleeAttack_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400694, XrefRangeEnd = 400698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_IsMeleeAttack_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string WeaponName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400698, XrefRangeEnd = 400702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_get_WeaponName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400702, XrefRangeEnd = 400706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_set_WeaponName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400720, RefRangeEnd = 400721, XrefRangeStart = 400706, XrefRangeEnd = 400720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogPlayerUseWeaponData other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerUseWeaponData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400721, XrefRangeEnd = 400724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400724, XrefRangeEnd = 400731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerUseWeaponDataInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
