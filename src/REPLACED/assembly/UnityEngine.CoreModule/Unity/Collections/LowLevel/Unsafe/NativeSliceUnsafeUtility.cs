// Decompiled with JetBrains decompiler
// Type: Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility
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

public static class NativeSliceUnsafeUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0;

  static NativeSliceUnsafeUtility()
  {
    Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", nameof (NativeSliceUnsafeUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr);
    NativeSliceUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663578);
    NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663579);
    NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663580);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414746, RefRangeEnd = 414747, XrefRangeStart = 414746, XrefRangeEnd = 414746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe NativeSlice<T> ConvertExistingDataToNativeSlice<T>(
    void* dataPointer,
    int stride,
    int length)
    where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) dataPointer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stride;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeSlice<T>(pointer);
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* GetUnsafePtr<T>(this NativeSlice<T> nativeSlice) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) nativeSlice))
    };
    System.IntPtr num;
    System.IntPtr unsafePtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) unsafePtr;
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* GetUnsafeReadOnlyPtr<T>(this NativeSlice<T> nativeSlice) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) nativeSlice))
    };
    System.IntPtr num;
    System.IntPtr unsafeReadOnlyPtr = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) unsafeReadOnlyPtr;
  }

  public NativeSliceUnsafeUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
