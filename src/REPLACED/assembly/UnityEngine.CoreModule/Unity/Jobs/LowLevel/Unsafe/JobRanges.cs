// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.LowLevel.Unsafe.JobRanges
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Jobs.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct JobRanges
{
  private static readonly System.IntPtr NativeFieldInfoPtr_BatchSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_NumJobs;
  private static readonly System.IntPtr NativeFieldInfoPtr_TotalIterationCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartEndIndex;
  [FieldOffset(0)]
  public int BatchSize;
  [FieldOffset(4)]
  public int NumJobs;
  [FieldOffset(8)]
  public int TotalIterationCount;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr StartEndIndex;

  static JobRanges()
  {
    Il2CppClassPointerStore<JobRanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", nameof (JobRanges));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobRanges>.NativeClassPtr);
    JobRanges.NativeFieldInfoPtr_BatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, nameof (BatchSize));
    JobRanges.NativeFieldInfoPtr_NumJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, nameof (NumJobs));
    JobRanges.NativeFieldInfoPtr_TotalIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, nameof (TotalIterationCount));
    JobRanges.NativeFieldInfoPtr_StartEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, nameof (StartEndIndex));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
