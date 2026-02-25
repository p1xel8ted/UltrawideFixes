// Decompiled with JetBrains decompiler
// Type: UnityEngine.AsyncInstantiateOperationHelper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace UnityEngine;

public class AsyncInstantiateOperationHelper(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateAsyncInstantiateOperationResultArray_Public_Static_Il2CppReferenceArray_1_Object_AsyncInstantiateOperation_Int32_0;

  static AsyncInstantiateOperationHelper()
  {
    Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AsyncInstantiateOperationHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr);
    AsyncInstantiateOperationHelper.NativeMethodInfoPtr_CreateAsyncInstantiateOperationResultArray_Public_Static_Il2CppReferenceArray_1_Object_AsyncInstantiateOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr, 100667824);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442439, XrefRangeEnd = 442440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Object> CreateAsyncInstantiateOperationResultArray(
    AsyncInstantiateOperation op,
    int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperationHelper.NativeMethodInfoPtr_CreateAsyncInstantiateOperationResultArray_Public_Static_Il2CppReferenceArray_1_Object_AsyncInstantiateOperation_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }
}
