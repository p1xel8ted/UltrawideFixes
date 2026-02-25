// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LogMessageInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Logging;

[StructLayout(LayoutKind.Explicit)]
public struct LogMessageInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Category;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Message;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Level;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Level_Public_get_LogLevel_0;
  [FieldOffset(0)]
  public System.IntPtr m_Category;
  [FieldOffset(8)]
  public System.IntPtr m_Message;
  [FieldOffset(16 /*0x10*/)]
  public LogLevel m_Level;

  static LogMessageInternal()
  {
    Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Logging", nameof (LogMessageInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr);
    LogMessageInternal.NativeFieldInfoPtr_m_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, nameof (m_Category));
    LogMessageInternal.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, nameof (m_Message));
    LogMessageInternal.NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, nameof (m_Level));
    LogMessageInternal.NativeMethodInfoPtr_get_Category_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100668827);
    LogMessageInternal.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100668828);
    LogMessageInternal.NativeMethodInfoPtr_get_Level_Public_get_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, 100668829);
  }

  public unsafe string Category
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388370, XrefRangeEnd = 388374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_get_Category_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string Message
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388374, XrefRangeEnd = 388378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_get_Message_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe LogLevel Level
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogMessageInternal.NativeMethodInfoPtr_get_Level_Public_get_LogLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LogLevel*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogMessageInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
