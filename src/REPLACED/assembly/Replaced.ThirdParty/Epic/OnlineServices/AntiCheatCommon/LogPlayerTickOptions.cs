// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTickOptions
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

public class LogPlayerTickOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPosition_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerViewRotation_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHealth_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerMovementState_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHealth_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMovementState_Public_get_AntiCheatCommonPlayerMovementState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogPlayerTickOptions()
  {
    Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTickOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr);
    LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerHandle>k__BackingField");
    LogPlayerTickOptions.NativeFieldInfoPtr__PlayerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerPosition>k__BackingField");
    LogPlayerTickOptions.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerViewRotation>k__BackingField");
    LogPlayerTickOptions.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<IsPlayerViewZoomed>k__BackingField");
    LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHealth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerHealth>k__BackingField");
    LogPlayerTickOptions.NativeFieldInfoPtr__PlayerMovementState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, "<PlayerMovementState>k__BackingField");
    LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672793);
    LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672794);
    LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672795);
    LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672796);
    LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672797);
    LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672798);
    LogPlayerTickOptions.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672799);
    LogPlayerTickOptions.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672800);
    LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672801);
    LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672802);
    LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerMovementState_Public_get_AntiCheatCommonPlayerMovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672803);
    LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672804);
    LogPlayerTickOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr, 100672805);
  }

  public unsafe System.IntPtr PlayerHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerViewRotation_Public_get_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_IsPlayerViewZoomed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float PlayerHealth
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 169009, RefRangeEnd = 169016, XrefRangeStart = 169009, XrefRangeEnd = 169016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerMovementState PlayerMovementState
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_get_PlayerMovementState_Public_get_AntiCheatCommonPlayerMovementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonPlayerMovementState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogPlayerTickOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogPlayerTickOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _PlayerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHandle_k__BackingField)) = value;
    }
  }

  public unsafe Vec3f _PlayerPosition_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerPosition_k__BackingField));
      return num == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Quat _PlayerViewRotation_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField));
      return num == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerViewRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsPlayerViewZoomed_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__IsPlayerViewZoomed_k__BackingField)) = value;
    }
  }

  public unsafe float _PlayerHealth_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHealth_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerHealth_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonPlayerMovementState _PlayerMovementState_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonPlayerMovementState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerMovementState_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonPlayerMovementState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerTickOptions.NativeFieldInfoPtr__PlayerMovementState_k__BackingField)) = value;
    }
  }
}
