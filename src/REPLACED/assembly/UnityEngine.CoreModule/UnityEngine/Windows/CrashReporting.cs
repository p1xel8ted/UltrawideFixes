// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.CrashReporting
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Windows;

public static class CrashReporting
{
  private static readonly CrashReporting.get_crashReportFolder_InjectedDelegate get_crashReportFolder_InjectedDelegateField = IL2CPP.ResolveICall<CrashReporting.get_crashReportFolder_InjectedDelegate>("UnityEngine.Windows.CrashReporting::get_crashReportFolder_Injected");

  public static string crashReportFolder
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        CrashReporting.get_crashReportFolder_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public static void get_crashReportFolder_Injected(out ManagedSpanWrapper ret)
  {
    CrashReporting.get_crashReportFolder_InjectedDelegateField((IntPtr) ref ret);
  }

  private delegate void get_crashReportFolder_InjectedDelegate([Out] IntPtr ret);
}
