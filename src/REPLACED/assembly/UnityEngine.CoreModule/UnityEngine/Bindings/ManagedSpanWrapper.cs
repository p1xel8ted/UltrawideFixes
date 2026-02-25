// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.ManagedSpanWrapper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct ManagedSpanWrapper
{
  private static readonly System.IntPtr NativeFieldInfoPtr_begin;
  private static readonly System.IntPtr NativeFieldInfoPtr_length;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0;
  [FieldOffset(0)]
  public readonly System.IntPtr begin;
  [FieldOffset(8)]
  public readonly int length;

  static ManagedSpanWrapper()
  {
    Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (ManagedSpanWrapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr);
    ManagedSpanWrapper.NativeFieldInfoPtr_begin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, nameof (begin));
    ManagedSpanWrapper.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, nameof (length));
    ManagedSpanWrapper.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, 100669197);
  }

  [CallerCount(529)]
  [CachedScanResults(RefRangeStart = 232843, RefRangeEnd = 233372, XrefRangeStart = 232843, XrefRangeEnd = 233372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ManagedSpanWrapper(void* begin, int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) begin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ManagedSpanWrapper.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Il2CppSystem.Span<T> ToSpan<T>(ManagedSpanWrapper spanWrapper)
  {
    return new Il2CppSystem.Span<T>((void*) spanWrapper.begin, spanWrapper.length);
  }

  public static unsafe Il2CppSystem.ReadOnlySpan<T> ToReadOnlySpan<T>(ManagedSpanWrapper spanWrapper)
  {
    return new Il2CppSystem.ReadOnlySpan<T>((void*) spanWrapper.begin, spanWrapper.length);
  }
}
