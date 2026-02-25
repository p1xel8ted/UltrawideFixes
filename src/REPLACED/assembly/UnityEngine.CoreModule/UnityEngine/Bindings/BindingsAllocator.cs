// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.BindingsAllocator
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Bindings;

public static class BindingsAllocator : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeNativeOwnedMemory_Public_Static_Void_ptr_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeOwnedDataPointer_Public_Static_ptr_Void_ptr_Void_0;
  private static readonly BindingsAllocator.MallocDelegate MallocDelegateField;

  static BindingsAllocator()
  {
    Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (BindingsAllocator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr);
    BindingsAllocator.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, 100669189);
    BindingsAllocator.NativeMethodInfoPtr_FreeNativeOwnedMemory_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, 100669190);
    BindingsAllocator.NativeMethodInfoPtr_GetNativeOwnedDataPointer_Public_Static_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, 100669191);
    BindingsAllocator.MallocDelegateField = IL2CPP.ResolveICall<BindingsAllocator.MallocDelegate>("UnityEngine.Bindings.BindingsAllocator::Malloc");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478482, XrefRangeEnd = 478484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Free(void* ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ptr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BindingsAllocator.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 478486, RefRangeEnd = 478490, XrefRangeStart = 478484, XrefRangeEnd = 478486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FreeNativeOwnedMemory(void* ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ptr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BindingsAllocator.NativeMethodInfoPtr_FreeNativeOwnedMemory_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 478490, RefRangeEnd = 478517, XrefRangeStart = 478490, XrefRangeEnd = 478490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* GetNativeOwnedDataPointer(void* ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ptr
    };
    System.IntPtr num;
    System.IntPtr ownedDataPointer = IL2CPP.il2cpp_runtime_invoke(BindingsAllocator.NativeMethodInfoPtr_GetNativeOwnedDataPointer_Public_Static_ptr_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) ownedDataPointer;
  }

  public BindingsAllocator(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe void* Malloc(int size)
  {
    return (void*) BindingsAllocator.MallocDelegateField(size);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct NativeOwnedMemory
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    [FieldOffset(0)]
    public System.IntPtr data;

    static NativeOwnedMemory()
    {
      Il2CppClassPointerStore<BindingsAllocator.NativeOwnedMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingsAllocator>.NativeClassPtr, nameof (NativeOwnedMemory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsAllocator.NativeOwnedMemory>.NativeClassPtr);
      BindingsAllocator.NativeOwnedMemory.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingsAllocator.NativeOwnedMemory>.NativeClassPtr, nameof (data));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BindingsAllocator.NativeOwnedMemory>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  private delegate System.IntPtr MallocDelegate(int size);
}
