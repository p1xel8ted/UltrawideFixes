// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.BlittableArrayWrapper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct BlittableArrayWrapper
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeFieldInfoPtr_size;
  private static readonly System.IntPtr NativeFieldInfoPtr_updateFlags;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0;
  [FieldOffset(0)]
  public System.IntPtr data;
  [FieldOffset(8)]
  public int size;
  [FieldOffset(12)]
  public BlittableArrayWrapper.UpdateFlags updateFlags;

  static BlittableArrayWrapper()
  {
    Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (BlittableArrayWrapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr);
    BlittableArrayWrapper.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, nameof (data));
    BlittableArrayWrapper.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, nameof (size));
    BlittableArrayWrapper.NativeFieldInfoPtr_updateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, nameof (updateFlags));
    BlittableArrayWrapper.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, 100669192);
    BlittableArrayWrapper.NativeMethodInfoPtr_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, 100669193);
  }

  [CallerCount(0)]
  public unsafe BlittableArrayWrapper(void* data, int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlittableArrayWrapper.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478517, XrefRangeEnd = 478528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unmarshal<T>(ref Il2CppArrayBase<T> array) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    IL2CPP.il2cpp_runtime_invoke(BlittableArrayWrapper.MethodInfoStoreGeneric_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref Il2CppArrayBase<T> local = ref array;
    System.IntPtr num2 = ptr;
    Il2CppArrayBase<T> il2CppArrayBase = num2 == System.IntPtr.Zero ? (Il2CppArrayBase<T>) null : new Il2CppArrayBase<T>(num2);
    local = il2CppArrayBase;
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public enum UpdateFlags
  {
    NoUpdateNeeded,
    SizeChanged,
    DataIsNativePointer,
    DataIsNativeOwnedMemory,
    DataIsEmpty,
    DataIsNull,
  }

  private sealed class MethodInfoStoreGeneric_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BlittableArrayWrapper.NativeMethodInfoPtr_Unmarshal_Internal_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<BlittableArrayWrapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
