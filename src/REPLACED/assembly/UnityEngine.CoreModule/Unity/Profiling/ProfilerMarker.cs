// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerMarker
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;
using Unity.Profiling.LowLevel.Unsafe;

#nullable disable
namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerMarker
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Auto_Public_AutoScope_0;
  [FieldOffset(0)]
  [NonSerialized]
  public readonly System.IntPtr m_Ptr;

  static ProfilerMarker()
  {
    Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", nameof (ProfilerMarker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr);
    ProfilerMarker.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, nameof (m_Ptr));
    ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663384 /*0x06000058*/);
    ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663385 /*0x06000059*/);
    ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663386 /*0x0600005A*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413690, XrefRangeEnd = 413691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProfilerMarker(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413691, XrefRangeEnd = 413692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProfilerMarker(ProfilerCategory category, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &category;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413692, XrefRangeEnd = 413694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProfilerMarker.AutoScope Auto()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerMarker.AutoScope*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public System.IntPtr Handle => this.m_Ptr;

  public void Begin() => ProfilerUnsafeUtility.BeginSample(this.m_Ptr);

  public void Begin(UnityEngine.Object contextUnityObject)
  {
    ProfilerUnsafeUtility.Internal_BeginWithObject(this.m_Ptr, contextUnityObject);
  }

  public void End() => ProfilerUnsafeUtility.EndSample(this.m_Ptr);

  public void GetName(ref string name) => name = ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);

  [StructLayout(LayoutKind.Explicit)]
  public struct AutoScope
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public readonly System.IntPtr m_Ptr;

    static AutoScope()
    {
      Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, nameof (AutoScope));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr);
      ProfilerMarker.AutoScope.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, nameof (m_Ptr));
      ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, 100663388 /*0x0600005C*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413688, XrefRangeEnd = 413690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
