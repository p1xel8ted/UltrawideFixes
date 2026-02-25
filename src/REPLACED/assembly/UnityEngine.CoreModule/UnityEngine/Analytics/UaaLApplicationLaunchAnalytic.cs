// Decompiled with JetBrains decompiler
// Type: UnityEngine.Analytics.UaaLApplicationLaunchAnalytic
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Analytics;

[Serializable]
public class UaaLApplicationLaunchAnalytic(IntPtr pointer) : AnalyticsEventBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_launch_type;
  private static readonly IntPtr NativeFieldInfoPtr_launch_process_type;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateUaaLApplicationLaunchAnalytic_Public_Static_UaaLApplicationLaunchAnalytic_0;

  static UaaLApplicationLaunchAnalytic()
  {
    Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", nameof (UaaLApplicationLaunchAnalytic));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr);
    UaaLApplicationLaunchAnalytic.NativeFieldInfoPtr_launch_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, nameof (launch_type));
    UaaLApplicationLaunchAnalytic.NativeFieldInfoPtr_launch_process_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, nameof (launch_process_type));
    UaaLApplicationLaunchAnalytic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, 100669600);
    UaaLApplicationLaunchAnalytic.NativeMethodInfoPtr_CreateUaaLApplicationLaunchAnalytic_Public_Static_UaaLApplicationLaunchAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr, 100669601);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481907, XrefRangeEnd = 481912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UaaLApplicationLaunchAnalytic()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UaaLApplicationLaunchAnalytic>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UaaLApplicationLaunchAnalytic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481912, XrefRangeEnd = 481920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UaaLApplicationLaunchAnalytic.NativeMethodInfoPtr_CreateUaaLApplicationLaunchAnalytic_Public_Static_UaaLApplicationLaunchAnalytic_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (UaaLApplicationLaunchAnalytic) null : Il2CppObjectPool.Get<UaaLApplicationLaunchAnalytic>(num3);
  }

  public unsafe int launch_type
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UaaLApplicationLaunchAnalytic.NativeFieldInfoPtr_launch_type));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UaaLApplicationLaunchAnalytic.NativeFieldInfoPtr_launch_type)) = value;
    }
  }

  public unsafe int launch_process_type
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UaaLApplicationLaunchAnalytic.NativeFieldInfoPtr_launch_process_type));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UaaLApplicationLaunchAnalytic.NativeFieldInfoPtr_launch_process_type)) = value;
    }
  }
}
