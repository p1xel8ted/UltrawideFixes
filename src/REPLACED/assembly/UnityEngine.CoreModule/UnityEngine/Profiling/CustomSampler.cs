// Decompiled with JetBrains decompiler
// Type: UnityEngine.Profiling.CustomSampler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Profiling.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Profiling;

public sealed class CustomSampler(System.IntPtr pointer) : Sampler(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_InvalidCustomSampler;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0;

  static CustomSampler()
  {
    Il2CppClassPointerStore<CustomSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", nameof (CustomSampler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr);
    CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, nameof (s_InvalidCustomSampler));
    CustomSampler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100668919);
    CustomSampler.NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100668921);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472394, XrefRangeEnd = 472402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomSampler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSampler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 472410, RefRangeEnd = 472414, XrefRangeStart = 472402, XrefRangeEnd = 472410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CustomSampler Create(string name, bool collectGpuData = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &collectGpuData;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSampler.NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CustomSampler) null : Il2CppObjectPool.Get<CustomSampler>(num3);
  }

  public static unsafe CustomSampler s_InvalidCustomSampler
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CustomSampler) null : Il2CppObjectPool.Get<CustomSampler>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public void Begin() => ProfilerUnsafeUtility.BeginSample(this.m_Ptr);

  public void Begin(UnityEngine.Object targetObject)
  {
    ProfilerUnsafeUtility.Internal_BeginWithObject(this.m_Ptr, targetObject);
  }

  public void End() => ProfilerUnsafeUtility.EndSample(this.m_Ptr);

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CustomSampler_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<CustomSampler.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSampler.BindingsMarshaller>.NativeClassPtr);
      CustomSampler.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler.BindingsMarshaller>.NativeClassPtr, 100668923);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(CustomSampler customSampler)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) customSampler)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSampler.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CustomSampler_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
