// Decompiled with JetBrains decompiler
// Type: UnityEngine.Analytics.AnalyticsEventBase
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Analytics;

public class AnalyticsEventBase(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_eventName;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventPrefix;
  private static readonly System.IntPtr NativeFieldInfoPtr_sendEventOptions;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SendEventOptions_String_0;

  static AnalyticsEventBase()
  {
    Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", nameof (AnalyticsEventBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr);
    AnalyticsEventBase.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, nameof (eventName));
    AnalyticsEventBase.NativeFieldInfoPtr_eventVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, nameof (eventVersion));
    AnalyticsEventBase.NativeFieldInfoPtr_eventPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, nameof (eventPrefix));
    AnalyticsEventBase.NativeFieldInfoPtr_sendEventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, nameof (sendEventOptions));
    AnalyticsEventBase.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SendEventOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, 100669597);
  }

  [CallerCount(67)]
  [CachedScanResults(RefRangeStart = 481827, RefRangeEnd = 481894, XrefRangeStart = 481826, XrefRangeEnd = 481827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AnalyticsEventBase(
    string eventName,
    int eventVersion,
    SendEventOptions sendEventOptions = SendEventOptions.kAppendNone,
    string eventPrefix = "")
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventVersion;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sendEventOptions;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(eventPrefix);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AnalyticsEventBase.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SendEventOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string eventName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_eventName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int eventVersion
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_eventVersion));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_eventVersion)) = value;
    }
  }

  public unsafe string eventPrefix
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_eventPrefix)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_eventPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe SendEventOptions sendEventOptions
  {
    get
    {
      return *(SendEventOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_sendEventOptions));
    }
    [param: In] set
    {
      *(SendEventOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsEventBase.NativeFieldInfoPtr_sendEventOptions)) = value;
    }
  }

  public string EventName() => this.eventName;

  public int EventVersion() => this.eventVersion;

  public string EventPrefix() => this.eventPrefix;
}
