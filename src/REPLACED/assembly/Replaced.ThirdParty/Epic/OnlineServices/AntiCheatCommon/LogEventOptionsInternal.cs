// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct LogEventOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EventId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Params;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogEventOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(16 /*0x10*/)]
  public uint m_EventId;
  [FieldOffset(20)]
  public uint m_ParamsCount;
  [FieldOffset(24)]
  public System.IntPtr m_Params;

  static LogEventOptionsInternal()
  {
    Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr);
    LogEventOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LogEventOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
    LogEventOptionsInternal.NativeFieldInfoPtr_m_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_EventId));
    LogEventOptionsInternal.NativeFieldInfoPtr_m_ParamsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_ParamsCount));
    LogEventOptionsInternal.NativeFieldInfoPtr_m_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, nameof (m_Params));
    LogEventOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100672618);
    LogEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100672619);
    LogEventOptionsInternal.NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100672620);
    LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100672621);
    LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100672622);
    LogEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, 100672623);
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint EventId
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<LogEventParamPair> Params
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 399900, RefRangeEnd = 399902, XrefRangeStart = 399894, XrefRangeEnd = 399900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399902, XrefRangeEnd = 399903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogEventOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LogEventOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399903, XrefRangeEnd = 399906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399906, XrefRangeEnd = 399911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
