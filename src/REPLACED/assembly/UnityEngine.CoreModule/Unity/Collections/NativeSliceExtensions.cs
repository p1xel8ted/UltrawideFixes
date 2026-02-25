// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeSliceExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace Unity.Collections;

public static class NativeSliceExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0;

  static NativeSliceExtensions()
  {
    Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", nameof (NativeSliceExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr);
    NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663537 /*0x060000F1*/);
    NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663538 /*0x060000F2*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414579, RefRangeEnd = 414580, XrefRangeStart = 414577, XrefRangeEnd = 414579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe NativeSlice<T> Slice<T>(
    this NativeArray<T> thisArray,
    int start,
    int length)
    where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) thisArray));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSliceExtensions.MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeSlice<T>(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 414582, RefRangeEnd = 414586, XrefRangeStart = 414580, XrefRangeEnd = 414582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe NativeSlice<T> Slice<T>(
    this NativeSlice<T> thisSlice,
    int start,
    int length)
    where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) thisSlice));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSliceExtensions.MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeSlice<T>(pointer);
  }

  public NativeSliceExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray) where T : struct
  {
    return new NativeSlice<T>(thisArray);
  }

  public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start) where T : struct
  {
    return new NativeSlice<T>(thisArray, start);
  }

  public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice) where T : struct => thisSlice;

  public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start) where T : struct
  {
    return new NativeSlice<T>(thisSlice, start);
  }

  private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
