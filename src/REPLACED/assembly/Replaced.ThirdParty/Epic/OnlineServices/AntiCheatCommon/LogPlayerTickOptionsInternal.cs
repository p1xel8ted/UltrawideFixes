// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerTickOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct LogPlayerTickOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerViewRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsPlayerViewZoomed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerMovementState;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogPlayerTickOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PlayerHandle;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_PlayerPosition;
  [FieldOffset(24)]
  public System.IntPtr m_PlayerViewRotation;
  [FieldOffset(32 /*0x20*/)]
  public int m_IsPlayerViewZoomed;
  [FieldOffset(36)]
  public float m_PlayerHealth;
  [FieldOffset(40)]
  public AntiCheatCommonPlayerMovementState m_PlayerMovementState;

  static LogPlayerTickOptionsInternal()
  {
    Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerTickOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr);
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerHandle));
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerPosition));
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerViewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerViewRotation));
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_IsPlayerViewZoomed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_IsPlayerViewZoomed));
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerHealth));
    LogPlayerTickOptionsInternal.NativeFieldInfoPtr_m_PlayerMovementState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, nameof (m_PlayerMovementState));
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672806);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672807);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672808);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672809);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672810);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672811);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerTickOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672812);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672813);
    LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, 100672814);
  }

  public unsafe System.IntPtr PlayerHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f PlayerPosition
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400578, RefRangeEnd = 400579, XrefRangeStart = 400572, XrefRangeEnd = 400578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerPosition_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat PlayerViewRotation
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400585, RefRangeEnd = 400586, XrefRangeStart = 400579, XrefRangeEnd = 400585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerViewRotation_Public_set_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsPlayerViewZoomed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400586, XrefRangeEnd = 400590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_IsPlayerViewZoomed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float PlayerHealth
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerHealth_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonPlayerMovementState PlayerMovementState
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_set_PlayerMovementState_Public_set_Void_AntiCheatCommonPlayerMovementState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400596, RefRangeEnd = 400597, XrefRangeStart = 400590, XrefRangeEnd = 400596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogPlayerTickOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerTickOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400597, XrefRangeEnd = 400600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400600, XrefRangeEnd = 400606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerTickOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerTickOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
