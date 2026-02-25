// Decompiled with JetBrains decompiler
// Type: UnityEngine.IO.File
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.IO;

public static class File
{
  private static readonly File.SetRecordZeroSeeksDelegate SetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.SetRecordZeroSeeksDelegate>("UnityEngine.IO.File::SetRecordZeroSeeks");
  private static readonly File.GetRecordZeroSeeksDelegate GetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.GetRecordZeroSeeksDelegate>("UnityEngine.IO.File::GetRecordZeroSeeks");
  private static readonly File.GetTotalOpenCallsDelegate GetTotalOpenCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalOpenCallsDelegate>("UnityEngine.IO.File::GetTotalOpenCalls");
  private static readonly File.GetTotalCloseCallsDelegate GetTotalCloseCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalCloseCallsDelegate>("UnityEngine.IO.File::GetTotalCloseCalls");
  private static readonly File.GetTotalReadCallsDelegate GetTotalReadCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalReadCallsDelegate>("UnityEngine.IO.File::GetTotalReadCalls");
  private static readonly File.GetTotalWriteCallsDelegate GetTotalWriteCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalWriteCallsDelegate>("UnityEngine.IO.File::GetTotalWriteCalls");
  private static readonly File.GetTotalSeekCallsDelegate GetTotalSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalSeekCallsDelegate>("UnityEngine.IO.File::GetTotalSeekCalls");
  private static readonly File.GetTotalZeroSeekCallsDelegate GetTotalZeroSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalZeroSeekCallsDelegate>("UnityEngine.IO.File::GetTotalZeroSeekCalls");
  private static readonly File.GetTotalFilesOpenedDelegate GetTotalFilesOpenedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesOpenedDelegate>("UnityEngine.IO.File::GetTotalFilesOpened");
  private static readonly File.GetTotalFilesClosedDelegate GetTotalFilesClosedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesClosedDelegate>("UnityEngine.IO.File::GetTotalFilesClosed");
  private static readonly File.GetTotalBytesReadDelegate GetTotalBytesReadDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesReadDelegate>("UnityEngine.IO.File::GetTotalBytesRead");
  private static readonly File.GetTotalBytesWrittenDelegate GetTotalBytesWrittenDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesWrittenDelegate>("UnityEngine.IO.File::GetTotalBytesWritten");
  private static readonly File.SetMainThreadFileIORestrictionDelegate SetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.SetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::SetMainThreadFileIORestriction");
  private static readonly File.GetMainThreadFileIORestrictionDelegate GetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.GetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::GetMainThreadFileIORestriction");

  public static ulong totalOpenCalls => File.GetTotalOpenCalls();

  public static ulong totalCloseCalls => File.GetTotalCloseCalls();

  public static ulong totalReadCalls => File.GetTotalReadCalls();

  public static ulong totalWriteCalls => File.GetTotalWriteCalls();

  public static ulong totalSeekCalls => File.GetTotalSeekCalls();

  public static ulong totalZeroSeekCalls => File.GetTotalZeroSeekCalls();

  public static ulong totalFilesOpened => File.GetTotalFilesOpened();

  public static ulong totalFilesClosed => File.GetTotalFilesClosed();

  public static ulong totalBytesRead => File.GetTotalBytesRead();

  public static ulong totalBytesWritten => File.GetTotalBytesWritten();

  public static bool recordZeroSeeks
  {
    set => File.SetRecordZeroSeeks(value);
    get => File.GetRecordZeroSeeks();
  }

  public static ThreadIORestrictionMode MainThreadIORestrictionMode
  {
    get => File.GetMainThreadFileIORestriction();
    set => File.SetMainThreadFileIORestriction(value);
  }

  public static void SetRecordZeroSeeks(bool enable)
  {
    File.SetRecordZeroSeeksDelegateField(enable);
  }

  public static bool GetRecordZeroSeeks() => File.GetRecordZeroSeeksDelegateField();

  public static ulong GetTotalOpenCalls() => File.GetTotalOpenCallsDelegateField();

  public static ulong GetTotalCloseCalls() => File.GetTotalCloseCallsDelegateField();

  public static ulong GetTotalReadCalls() => File.GetTotalReadCallsDelegateField();

  public static ulong GetTotalWriteCalls() => File.GetTotalWriteCallsDelegateField();

  public static ulong GetTotalSeekCalls() => File.GetTotalSeekCallsDelegateField();

  public static ulong GetTotalZeroSeekCalls() => File.GetTotalZeroSeekCallsDelegateField();

  public static ulong GetTotalFilesOpened() => File.GetTotalFilesOpenedDelegateField();

  public static ulong GetTotalFilesClosed() => File.GetTotalFilesClosedDelegateField();

  public static ulong GetTotalBytesRead() => File.GetTotalBytesReadDelegateField();

  public static ulong GetTotalBytesWritten() => File.GetTotalBytesWrittenDelegateField();

  public static void SetMainThreadFileIORestriction(ThreadIORestrictionMode mode)
  {
    File.SetMainThreadFileIORestrictionDelegateField(mode);
  }

  public static ThreadIORestrictionMode GetMainThreadFileIORestriction()
  {
    return File.GetMainThreadFileIORestrictionDelegateField();
  }

  private delegate void SetRecordZeroSeeksDelegate(bool enable);

  private delegate bool GetRecordZeroSeeksDelegate();

  private delegate ulong GetTotalOpenCallsDelegate();

  private delegate ulong GetTotalCloseCallsDelegate();

  private delegate ulong GetTotalReadCallsDelegate();

  private delegate ulong GetTotalWriteCallsDelegate();

  private delegate ulong GetTotalSeekCallsDelegate();

  private delegate ulong GetTotalZeroSeekCallsDelegate();

  private delegate ulong GetTotalFilesOpenedDelegate();

  private delegate ulong GetTotalFilesClosedDelegate();

  private delegate ulong GetTotalBytesReadDelegate();

  private delegate ulong GetTotalBytesWrittenDelegate();

  private delegate void SetMainThreadFileIORestrictionDelegate(ThreadIORestrictionMode mode);

  private delegate ThreadIORestrictionMode GetMainThreadFileIORestrictionDelegate();
}
