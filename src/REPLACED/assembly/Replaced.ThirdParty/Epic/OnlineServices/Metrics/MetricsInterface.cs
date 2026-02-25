// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.MetricsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics;

public sealed class MetricsInterface(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_BeginplayersessionApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_EndplayersessionApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BeginPlayerSession_Public_Result_BeginPlayerSessionOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_EndPlayerSession_Public_Result_EndPlayerSessionOptions_0;

  static MetricsInterface()
  {
    Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (MetricsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr);
    MetricsInterface.NativeFieldInfoPtr_BeginplayersessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, nameof (BeginplayersessionApiLatest));
    MetricsInterface.NativeFieldInfoPtr_EndplayersessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, nameof (EndplayersessionApiLatest));
    MetricsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, 100668811);
    MetricsInterface.NativeMethodInfoPtr_BeginPlayerSession_Public_Result_BeginPlayerSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, 100668813);
    MetricsInterface.NativeMethodInfoPtr_EndPlayerSession_Public_Result_EndPlayerSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, 100668814);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MetricsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MetricsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388288, XrefRangeEnd = 388296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result BeginPlayerSession(BeginPlayerSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MetricsInterface.NativeMethodInfoPtr_BeginPlayerSession_Public_Result_BeginPlayerSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388296, XrefRangeEnd = 388304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result EndPlayerSession(EndPlayerSessionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MetricsInterface.NativeMethodInfoPtr_EndPlayerSession_Public_Result_EndPlayerSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int BeginplayersessionApiLatest
  {
    get
    {
      int beginplayersessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(MetricsInterface.NativeFieldInfoPtr_BeginplayersessionApiLatest, (void*) &beginplayersessionApiLatest);
      return beginplayersessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MetricsInterface.NativeFieldInfoPtr_BeginplayersessionApiLatest, (void*) &value);
    }
  }

  public static unsafe int EndplayersessionApiLatest
  {
    get
    {
      int endplayersessionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(MetricsInterface.NativeFieldInfoPtr_EndplayersessionApiLatest, (void*) &endplayersessionApiLatest);
      return endplayersessionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MetricsInterface.NativeFieldInfoPtr_EndplayersessionApiLatest, (void*) &value);
    }
  }
}
