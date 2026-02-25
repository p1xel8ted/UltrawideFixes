// Decompiled with JetBrains decompiler
// Type: Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace Unity.Collections.LowLevel.Unsafe;

public static class NativeArrayUnsafeUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0;

  static NativeArrayUnsafeUtility()
  {
    Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", nameof (NativeArrayUnsafeUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr);
    NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663575);
    NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663576);
    NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663577);
  }

  [CallerCount(84)]
  [CachedScanResults(RefRangeStart = 414662, RefRangeEnd = 414746, XrefRangeStart = 414662, XrefRangeEnd = 414662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe NativeArray<T> ConvertExistingDataToNativeArray<T>(
    void* dataPointer,
    int length,
    Allocator allocator)
    where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) dataPointer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) nativeArray))
    };
    System.IntPtr num;
    System.IntPtr unsafePtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) unsafePtr;
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) nativeArray))
    };
    System.IntPtr num;
    System.IntPtr unsafeReadOnlyPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) unsafeReadOnlyPtr;
  }

  public NativeArrayUnsafeUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe NativeArray<T> ConvertExistingDataToNativeArray<T>(
    Il2CppSystem.Span<T> data,
    Allocator allocator)
    where T : struct, Il2CppSystem.ValueType
  {
    fixed (T* objPtr = &((Il2CppSystem.Span<T>) ref data).GetPinnableReference())
    {
      NativeArray<T> nativeArray = (NativeArray<T>) null;
      ((NativeArray<>) ref nativeArray).m_Buffer = (void*) objPtr;
      ((NativeArray<>) ref nativeArray).m_Length = ((Il2CppSystem.Span<T>) ref data).Length;
      ((NativeArray<>) ref nativeArray).m_AllocatorLabel = allocator;
      return nativeArray;
    }
  }

  public static unsafe void* GetUnsafeReadOnlyPtr<T>(NativeArray<T>.ReadOnly nativeArray) where T : struct
  {
    return ((NativeArray<>.ReadOnly) nativeArray).m_Buffer;
  }

  public static unsafe void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : struct
  {
    return ((NativeArray<>) nativeArray).m_Buffer;
  }

  private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
