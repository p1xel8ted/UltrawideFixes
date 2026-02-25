// Decompiled with JetBrains decompiler
// Type: UnityEngine.CrashReport
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class CrashReport
{
  private static readonly CrashReport.GetReportsDelegate GetReportsDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportsDelegate>("UnityEngine.CrashReport::GetReports");
  private static readonly CrashReport.GetReportData_InjectedDelegate GetReportData_InjectedDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportData_InjectedDelegate>("UnityEngine.CrashReport::GetReportData_Injected");
  private static readonly CrashReport.RemoveReport_InjectedDelegate RemoveReport_InjectedDelegateField = IL2CPP.ResolveICall<CrashReport.RemoveReport_InjectedDelegate>("UnityEngine.CrashReport::RemoveReport_Injected");

  public static int Compare(CrashReport c1, CrashReport c2)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void PopulateReports()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppReferenceArray<CrashReport> reports
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static CrashReport lastReport
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void RemoveAll() => throw new System.NotSupportedException("Method unstripping failed");

  public void Remove() => throw new System.NotSupportedException("Method unstripping failed");

  public static Il2CppStringArray GetReports()
  {
    System.IntPtr num = CrashReport.GetReportsDelegateField();
    return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
  }

  public static unsafe string GetReportData(string id, out double secondsSinceUnixEpoch)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(id, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = id.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      CrashReport.GetReportData_Injected(ref managedSpanWrapper, out secondsSinceUnixEpoch, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static unsafe bool RemoveReport(string id)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(id, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = id.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return CrashReport.RemoveReport_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void GetReportData_Injected(
    ref ManagedSpanWrapper id,
    out double secondsSinceUnixEpoch,
    out ManagedSpanWrapper ret)
  {
    CrashReport.GetReportData_InjectedDelegateField((System.IntPtr) ref id, (System.IntPtr) ref secondsSinceUnixEpoch, (System.IntPtr) ref ret);
  }

  public static bool RemoveReport_Injected(ref ManagedSpanWrapper id)
  {
    return CrashReport.RemoveReport_InjectedDelegateField((System.IntPtr) ref id);
  }

  private delegate System.IntPtr GetReportsDelegate();

  private delegate void GetReportData_InjectedDelegate(
    System.IntPtr id,
    [Out] System.IntPtr secondsSinceUnixEpoch,
    [Out] System.IntPtr ret);

  private delegate bool RemoveReport_InjectedDelegate(System.IntPtr id);
}
