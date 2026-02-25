// Decompiled with JetBrains decompiler
// Type: UnityEngine.Profiling.Recorder
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Profiling;

public sealed class Recorder(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_InvalidRecorder;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecorderCPU;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecorderGPU;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0;
  public const ProfilerRecorderOptions s_RecorderDefaultOptions = (ProfilerRecorderOptions) 153;

  static Recorder()
  {
    Il2CppClassPointerStore<Recorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", nameof (Recorder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recorder>.NativeClassPtr);
    Recorder.NativeFieldInfoPtr_s_InvalidRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, nameof (s_InvalidRecorder));
    Recorder.NativeFieldInfoPtr_m_RecorderCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, nameof (m_RecorderCPU));
    Recorder.NativeFieldInfoPtr_m_RecorderGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, nameof (m_RecorderGPU));
    Recorder.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668903);
    Recorder.NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668904);
    Recorder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668905);
    Recorder.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668906);
    Recorder.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668907);
    Recorder.NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668908);
    Recorder.NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668909);
    Recorder.NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668910);
    Recorder.NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668911);
    Recorder.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100668912);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Recorder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472333, XrefRangeEnd = 472338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Recorder(ProfilerRecorderHandle handle)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472338, XrefRangeEnd = 472343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool enabled
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 472344, RefRangeEnd = 472350, XrefRangeStart = 472343, XrefRangeEnd = 472344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 472356, RefRangeEnd = 472362, XrefRangeStart = 472350, XrefRangeEnd = 472356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long elapsedNanoseconds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 472364, RefRangeEnd = 472366, XrefRangeStart = 472362, XrefRangeEnd = 472364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe long gpuElapsedNanoseconds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 472368, RefRangeEnd = 472369, XrefRangeStart = 472366, XrefRangeEnd = 472368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int sampleBlockCount
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 472372, RefRangeEnd = 472374, XrefRangeStart = 472369, XrefRangeEnd = 472372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int gpuSampleBlockCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 472377, RefRangeEnd = 472378, XrefRangeStart = 472374, XrefRangeEnd = 472377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 472356, RefRangeEnd = 472362, XrefRangeStart = 472356, XrefRangeEnd = 472362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEnabled(bool state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &state
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Recorder s_InvalidRecorder
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Recorder.NativeFieldInfoPtr_s_InvalidRecorder, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Recorder) null : Il2CppObjectPool.Get<Recorder>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Recorder.NativeFieldInfoPtr_s_InvalidRecorder, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProfilerRecorder m_RecorderCPU
  {
    get
    {
      return *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderCPU));
    }
    [param: In] set
    {
      *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderCPU)) = value;
    }
  }

  public unsafe ProfilerRecorder m_RecorderGPU
  {
    get
    {
      return *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderGPU));
    }
    [param: In] set
    {
      *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderGPU)) = value;
    }
  }

  public static Recorder Get(string samplerName)
  {
    ProfilerRecorderHandle handle = ProfilerRecorderHandle.Get(ProfilerCategory.Any, samplerName);
    return !handle.Valid ? Recorder.s_InvalidRecorder : new Recorder(handle);
  }

  public bool isValid => throw new System.NotSupportedException("Method unstripping failed");

  public void FilterToCurrentThread()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void CollectFromAllThreads()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
