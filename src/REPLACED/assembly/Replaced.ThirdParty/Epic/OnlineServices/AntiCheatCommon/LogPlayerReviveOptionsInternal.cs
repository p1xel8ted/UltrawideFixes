// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerReviveOptionsInternal
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
public struct LogPlayerReviveOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RevivedPlayerHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReviverPlayerHandle;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RevivedPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReviverPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogPlayerReviveOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_RevivedPlayerHandle;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ReviverPlayerHandle;

  static LogPlayerReviveOptionsInternal()
  {
    Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerReviveOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr);
    LogPlayerReviveOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogPlayerReviveOptionsInternal.NativeFieldInfoPtr_m_RevivedPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, nameof (m_RevivedPlayerHandle));
    LogPlayerReviveOptionsInternal.NativeFieldInfoPtr_m_ReviverPlayerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, nameof (m_ReviverPlayerHandle));
    LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_set_RevivedPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, 100672717);
    LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_set_ReviverPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, 100672718);
    LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerReviveOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, 100672719);
    LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, 100672720);
    LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, 100672721);
  }

  public unsafe System.IntPtr RevivedPlayerHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_set_RevivedPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr ReviverPlayerHandle
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_set_ReviverPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(LogPlayerReviveOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogPlayerReviveOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400472, XrefRangeEnd = 400474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400474, XrefRangeEnd = 400479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerReviveOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerReviveOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
