// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerRecorderSample
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorderSample
{
  private static readonly System.IntPtr NativeFieldInfoPtr_value;
  private static readonly System.IntPtr NativeFieldInfoPtr_count;
  private static readonly System.IntPtr NativeFieldInfoPtr_refValue;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int64_0;
  [FieldOffset(0)]
  public long value;
  [FieldOffset(8)]
  public long count;
  [FieldOffset(16 /*0x10*/)]
  public long refValue;

  static ProfilerRecorderSample()
  {
    Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", nameof (ProfilerRecorderSample));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr);
    ProfilerRecorderSample.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, nameof (value));
    ProfilerRecorderSample.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, nameof (count));
    ProfilerRecorderSample.NativeFieldInfoPtr_refValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, nameof (refValue));
    ProfilerRecorderSample.NativeMethodInfoPtr_get_Count_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, 100663389 /*0x0600005D*/);
  }

  public unsafe long Count
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderSample.NativeMethodInfoPtr_get_Count_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public long Value => this.value;
}
