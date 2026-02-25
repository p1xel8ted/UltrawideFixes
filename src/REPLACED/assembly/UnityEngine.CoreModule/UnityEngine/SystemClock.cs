// Decompiled with JetBrains decompiler
// Type: UnityEngine.SystemClock
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class SystemClock(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Epoch;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0;

  static SystemClock()
  {
    Il2CppClassPointerStore<SystemClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SystemClock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemClock>.NativeClassPtr);
    SystemClock.NativeFieldInfoPtr_s_Epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, nameof (s_Epoch));
    SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100668586);
  }

  public static unsafe Il2CppSystem.DateTime now
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 465207, RefRangeEnd = 465210, XrefRangeStart = 465203, XrefRangeEnd = 465207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Il2CppSystem.DateTime s_Epoch
  {
    get
    {
      Il2CppSystem.DateTime sEpoch;
      IL2CPP.il2cpp_field_static_get_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*) &sEpoch);
      return sEpoch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*) &value);
    }
  }

  public static long ToUnixTimeMilliseconds(Il2CppSystem.DateTime date)
  {
    return Il2CppSystem.Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
  }

  public static long ToUnixTimeSeconds(Il2CppSystem.DateTime date)
  {
    return Il2CppSystem.Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
  }
}
