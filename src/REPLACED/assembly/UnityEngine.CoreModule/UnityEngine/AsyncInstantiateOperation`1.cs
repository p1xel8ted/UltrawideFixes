// Decompiled with JetBrains decompiler
// Type: UnityEngine.AsyncInstantiateOperation`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

#nullable disable
namespace UnityEngine;

public class AsyncInstantiateOperation<T>(System.IntPtr pointer) : AsyncInstantiateOperation(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Result_Public_get_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_Il2CppReferenceArray_1_Object_Int32_0;

  static AsyncInstantiateOperation()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperation`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr);
    AsyncInstantiateOperation<T>.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr, 100667821);
    AsyncInstantiateOperation<T>.NativeMethodInfoPtr_get_Result_Public_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr, 100667822);
    AsyncInstantiateOperation<T>.NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr, 100667823);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442428, RefRangeEnd = 442429, XrefRangeStart = 442424, XrefRangeEnd = 442428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AsyncInstantiateOperation(System.IntPtr ptr, CancellationToken cancellationToken)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ptr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation<T>.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppArrayBase<T> Result
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 442430, RefRangeEnd = 442431, XrefRangeStart = 442429, XrefRangeEnd = 442430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation<T>.NativeMethodInfoPtr_get_Result_Public_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442431, XrefRangeEnd = 442439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppReferenceArray<Object> CreateResultArray(int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &size
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AsyncInstantiateOperation<T>.NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_Il2CppReferenceArray_1_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }
}
