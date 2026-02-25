// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerSpawnOptionsInternal
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
public struct LogPlayerSpawnOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SpawnedPlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TeamId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogPlayerSpawnOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SpawnedPlayerHandle;
  [FieldOffset(16 /*0x10*/)]
  public uint m_TeamId;
  [FieldOffset(20)]
  public uint m_CharacterId;

  static LogPlayerSpawnOptionsInternal()
  {
    Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerSpawnOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr);
    LogPlayerSpawnOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogPlayerSpawnOptionsInternal.NativeFieldInfoPtr_m_SpawnedPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, nameof (m_SpawnedPlayerHandle));
    LogPlayerSpawnOptionsInternal.NativeFieldInfoPtr_m_TeamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, nameof (m_TeamId));
    LogPlayerSpawnOptionsInternal.NativeFieldInfoPtr_m_CharacterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, nameof (m_CharacterId));
    LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, 100672729);
    LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, 100672730);
    LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, 100672731);
    LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerSpawnOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, 100672732);
    LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, 100672733);
    LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, 100672734);
  }

  public unsafe System.IntPtr SpawnedPlayerHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint TeamId
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint CharacterId
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(LogPlayerSpawnOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerSpawnOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400479, XrefRangeEnd = 400481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400481, XrefRangeEnd = 400485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerSpawnOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
