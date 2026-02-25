// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.AsyncRequestNativeArrayData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AsyncRequestNativeArrayData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nativeArrayBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_lengthInBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0;
  [FieldOffset(0)]
  public System.IntPtr nativeArrayBuffer;
  [FieldOffset(8)]
  public long lengthInBytes;

  static AsyncRequestNativeArrayData()
  {
    Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (AsyncRequestNativeArrayData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr);
    AsyncRequestNativeArrayData.NativeFieldInfoPtr_nativeArrayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, nameof (nativeArrayBuffer));
    AsyncRequestNativeArrayData.NativeFieldInfoPtr_lengthInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, nameof (lengthInBytes));
    AsyncRequestNativeArrayData.NativeMethodInfoPtr_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, 100669624);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481998, XrefRangeEnd = 481999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncRequestNativeArrayData CreateAndCheckAccess<T>(NativeArray<T> array) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncRequestNativeArrayData.MethodInfoStoreGeneric_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AsyncRequestNativeArrayData*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe AsyncRequestNativeArrayData CreateAndCheckAccess<T>(NativeSlice<T> array) where T : struct
  {
    return new AsyncRequestNativeArrayData()
    {
      nativeArrayBuffer = (System.IntPtr) array.GetUnsafePtr<T>(),
      lengthInBytes = (long) ((NativeSlice<T>) ref array).Length * (long) UnsafeUtility.SizeOf<T>()
    };
  }

  private sealed class MethodInfoStoreGeneric_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncRequestNativeArrayData.NativeMethodInfoPtr_CreateAndCheckAccess_Public_Static_AsyncRequestNativeArrayData_NativeArray_1_T_0, Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
