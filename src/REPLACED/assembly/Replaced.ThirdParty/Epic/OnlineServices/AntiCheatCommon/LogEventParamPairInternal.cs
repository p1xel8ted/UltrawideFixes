// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPairInternal
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
public struct LogEventParamPairInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamValue;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogEventParamPair_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public LogEventParamPairParamValueInternal m_ParamValue;

  static LogEventParamPairInternal()
  {
    Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPairInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr);
    LogEventParamPairInternal.NativeFieldInfoPtr_m_ParamValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, nameof (m_ParamValue));
    LogEventParamPairInternal.NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100672629);
    LogEventParamPairInternal.NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100672630);
    LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Void_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100672631);
    LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100672632);
    LogEventParamPairInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, 100672633);
  }

  public unsafe LogEventParamPairParamValue ParamValue
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399935, XrefRangeEnd = 399941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 399947, RefRangeEnd = 399949, XrefRangeStart = 399941, XrefRangeEnd = 399947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399949, XrefRangeEnd = 399950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogEventParamPair other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Void_LogEventParamPair_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399950, XrefRangeEnd = 399953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399953, XrefRangeEnd = 399959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPairInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
