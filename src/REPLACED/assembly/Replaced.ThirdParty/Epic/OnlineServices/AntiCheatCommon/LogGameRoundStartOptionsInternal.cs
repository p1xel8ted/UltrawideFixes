// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogGameRoundStartOptionsInternal
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
public struct LogGameRoundStartOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionIdentifier;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LevelName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ModeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoundTimeSeconds;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LevelName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ModeName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogGameRoundStartOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionIdentifier;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LevelName;
  [FieldOffset(24)]
  public System.IntPtr m_ModeName;
  [FieldOffset(32 /*0x20*/)]
  public uint m_RoundTimeSeconds;

  static LogGameRoundStartOptionsInternal()
  {
    Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogGameRoundStartOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr);
    LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_SessionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_SessionIdentifier));
    LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_LevelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_LevelName));
    LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_ModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_ModeName));
    LogGameRoundStartOptionsInternal.NativeFieldInfoPtr_m_RoundTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, nameof (m_RoundTimeSeconds));
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672698);
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_LevelName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672699);
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_ModeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672700);
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672701);
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogGameRoundStartOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672702);
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672703);
    LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, 100672704);
  }

  public unsafe string SessionIdentifier
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400432, XrefRangeEnd = 400436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LevelName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400436, XrefRangeEnd = 400440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_LevelName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ModeName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400440, XrefRangeEnd = 400444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_ModeName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint RoundTimeSeconds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400456, RefRangeEnd = 400457, XrefRangeStart = 400444, XrefRangeEnd = 400456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogGameRoundStartOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogGameRoundStartOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400457, XrefRangeEnd = 400460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400460, XrefRangeEnd = 400466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogGameRoundStartOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
