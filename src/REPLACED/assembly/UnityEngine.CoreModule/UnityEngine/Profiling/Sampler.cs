// Decompiled with JetBrains decompiler
// Type: UnityEngine.Profiling.Sampler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Profiling.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Profiling;

public class Sampler(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_InvalidSampler;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRecorder_Public_Recorder_0;

  static Sampler()
  {
    Il2CppClassPointerStore<Sampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", nameof (Sampler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler>.NativeClassPtr);
    Sampler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, nameof (m_Ptr));
    Sampler.NativeFieldInfoPtr_s_InvalidSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, nameof (s_InvalidSampler));
    Sampler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100668914);
    Sampler.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100668916);
    Sampler.NativeMethodInfoPtr_GetRecorder_Public_Recorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100668917);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Sampler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool isValid
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 472378, RefRangeEnd = 472380, XrefRangeStart = 472378, XrefRangeEnd = 472378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 472390, RefRangeEnd = 472394, XrefRangeStart = 472380, XrefRangeEnd = 472390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Recorder GetRecorder()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetRecorder_Public_Recorder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Recorder) null : Il2CppObjectPool.Get<Recorder>(num3);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public static unsafe Sampler s_InvalidSampler
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Sampler.NativeFieldInfoPtr_s_InvalidSampler, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Sampler) null : Il2CppObjectPool.Get<Sampler>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Sampler.NativeFieldInfoPtr_s_InvalidSampler, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static Sampler Get(string name)
  {
    System.IntPtr marker = ProfilerUnsafeUtility.GetMarker(name);
    return marker == Il2CppSystem.IntPtr.Zero ? Sampler.s_InvalidSampler : new Sampler(marker);
  }

  public static int GetNames(List<string> names)
  {
    List<ProfilerRecorderHandle> outRecorderHandleList = new List<ProfilerRecorderHandle>();
    ProfilerRecorderHandle.GetAvailable(outRecorderHandleList);
    if (names != null)
    {
      if (names.Count < outRecorderHandleList.Count)
      {
        names.Capacity = outRecorderHandleList.Count;
        for (int count = names.Count; count < outRecorderHandleList.Count; ++count)
          names.Add((string) null);
      }
      int index = 0;
      List<ProfilerRecorderHandle>.Enumerator enumerator = outRecorderHandleList.GetEnumerator();
      try
      {
        while (((List<ProfilerRecorderHandle>.Enumerator) ref enumerator).MoveNext())
        {
          ProfilerRecorderDescription description = ProfilerRecorderHandle.GetDescription(((List<ProfilerRecorderHandle>.Enumerator) ref enumerator).Current);
          names[index] = description.Name;
          ++index;
        }
      }
      finally
      {
        enumerator.Dispose();
      }
    }
    return outRecorderHandleList.Count;
  }

  public string name => ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
}
